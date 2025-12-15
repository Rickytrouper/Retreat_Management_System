using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class BookingPage : Form
    {
        private readonly Retreat_Management_DBEntities db;
        private readonly int currentUserId; // Store the user ID
        private readonly int? currentRetreatId; // Store the retreat ID
        private decimal paymentAmountPerSpace; // Store the payment amount per space

        public BookingPage(int userId, int retreatId, decimal amount, UserDash userDashboard) // Constructor accepting userId, retreatId, and amount
        {
            InitializeComponent();
            currentUserId = userId; // Store the user ID
            currentRetreatId = retreatId; // Store the retreat ID
            paymentAmountPerSpace = amount; // Store the payment amount per space
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            this.Load += BookingPage_Load;

            // Initialize the database context
            db = new Retreat_Management_DBEntities();
        }

        // Method to set the retreat name
        public void SetRetreatName(string retreatName)
        {
            txtRetreatName.Text = retreatName;  // Set the text of the label to the retreat name
        }

        // Existing methods for setting user information
        public void SetUserName(string userName)
        {
            txtUserName.Text = userName; // Set the username in the textbox
        }

        public void SetEmail(string email)
        {
            txtEmail.Text = email; // Set the email in the textbox
        }

        private void SetupMaskedInput(MaskedTextBox mtb, string mask, string placeholder)
        {

            mtb.Mask = mask;
            mtb.PromptChar = ' '; // Use a space as the prompt character
            mtb.Clear(); // Clear any existing text when setting up
            mtb.TextAlign = HorizontalAlignment.Left; // Ensure text aligns to the left

            // Move caret to the beginning on focus
            mtb.Enter += (s, args) =>
            {
                mtb.SelectAll(); // Select all text on focus to allow easy overwriting
            };

            mtb.Click += (s, args) =>
            {
                if (!mtb.MaskFull)
                {
                    mtb.Select(mtb.Text.Length, 0); // Allow user to start typing at the end of current text
                }
            };

            mtb.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(mtb.Text))
                {
                    mtb.Clear(); // Clear any placeholder if empty
                }
            };
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            SetupMaskedInput(mtbCardNumber, "####-####-####-####", "####-####-####-####");// Standard card number mask
            SetupMaskedInput(mtbCVV, "###", "###");  // CVV mask
            SetupMaskedInput(mtbExpiryDate, "00/0000", "MM/yyyy"); // Expiry date mask

            // Load retreat capacity to calculate prices
            var retreat = db.Retreats.Find(currentRetreatId);
            if (retreat != null)
            {
                paymentAmountPerSpace = retreat.Price; // Assuming Price is a property of Retreat
                txtNumOfSpaces.TextChanged += UpdateTotals;
            }
        }

        private void UpdateTotals(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumOfSpaces.Text, out int numberOfSpaces))
            {
                decimal subtotal = paymentAmountPerSpace * numberOfSpaces;
                txtSubtotal.Text = subtotal.ToString("C"); // Update Subtotal
                txtTotal.Text = subtotal.ToString("C"); // Assuming no additional fees; adjust as necessary
            }
            else
            {
                txtSubtotal.Text = "$0.00";
                txtTotal.Text = "$0.00";
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cardNumber = mtbCardNumber.Text.Trim();
            string expiry = mtbExpiryDate.Text.Trim();
            string cvv = mtbCVV.Text.Trim();

            // Validate input fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in your name and email correctly.");
                return;
            }

            if (!int.TryParse(txtNumOfSpaces.Text, out int numberOfSpaces) || numberOfSpaces <= 0)
            {
                MessageBox.Show("Please enter a valid number of spaces.");
                return;
            }

            // Check availability before proceeding with payment processing
            if (!IsAvailableForBooking(currentRetreatId.Value, numberOfSpaces))
            {
                MessageBox.Show("The selected retreat does not have enough available spaces. Please adjust your request.");
                return;
            }

            // Validate payment details
            if (!ProcessPayment(cardNumber, expiry, cvv))
            {
                return; // Exit if payment validation fails
            }

            // Create the booking 
            var booking = new Booking
            {
                UserID = currentUserId,
                RetreatID = currentRetreatId.Value,
                BookingDate = DateTime.Now,
                Status = "Confirmed",
                UserName = username,
                Email = email,
                CardNumber = cardNumber,
                ExpiryDate = DateTime.ParseExact(expiry, "MM/yyyy", CultureInfo.InvariantCulture).AddDays(1).AddMonths(-1),
                CVV = cvv,
                PaymentStatus = "Paid",
                NumberOfSpaces = numberOfSpaces // Store number of spaces
            };

            // Start transaction to ensure atomic operations
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    // Save the booking
                    db.Bookings.Add(booking);
                    db.SaveChanges(); // Save the booking

                    // Update the current bookings for the selected retreat
                    UpdateCurrentBookings(currentRetreatId.Value, numberOfSpaces); // Call the update method

                    // Create and save payment record
                    var payment = new Payment
                    {
                        Amount = paymentAmountPerSpace * numberOfSpaces,
                        PaymentDate = DateTime.Now,
                        PaymentMethod = "Credit Card",
                        Status = "Successful",
                        TransactionID = GenerateTransactionID(),
                        BookingID = booking.BookingID // Set the BookingID after saving the booking
                    };

                    db.Payments.Add(payment);
                    db.SaveChanges(); // Save the payment record

                    // Commit the transaction
                    transaction.Commit();
                    MessageBox.Show("Booking and payment completed successfully.");
                    this.Close(); // Close the BookingPage
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show($"An error occurred while saving your booking: {dbEx.InnerException?.Message}");
                    transaction.Rollback(); // Rollback the transaction in case of error
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    transaction.Rollback(); // Rollback the transaction in case of error
                }
            }
        }

        // Method to update CurrentBooking
        private void UpdateCurrentBookings(int retreatId, int numberOfSpaces)
        {
            var retreat = db.Retreats.Find(retreatId);
            if (retreat == null) return; // Ensure retreat exists

            // Update the CurrentBooking field
            retreat.currentBookings += numberOfSpaces; // Increment current bookings
            db.SaveChanges(); // Commit the changes
        }

        private bool IsAvailableForBooking(int? retreatId, int numberOfSpaces)
        {
            // Ensure retreatId has a value
            if (!retreatId.HasValue)
                return false;

            // Get the retreat's capacity
            var retreat = db.Retreats.Find(retreatId.Value); // Use retreatId.Value
            if (retreat == null)
                return false; // Invalid Retreat ID

            // Count current bookings for this retreat
            int currentBookings = (int)(db.Bookings.Where(b => b.RetreatID == retreatId.Value).Sum(b => (int?)b.NumberOfSpaces) ?? 0);

            // Check availability
            return (currentBookings + numberOfSpaces) <= retreat.Capacity; // Ensure total does not exceed capacity
        }

        private bool ProcessPayment(string cardNumber, string expiry, string cvv)
        {
            bool validCard = System.Text.RegularExpressions.Regex.IsMatch(cardNumber, @"^\d{4}-\d{4}-\d{4}-\d{4}$");
            bool validCVV = System.Text.RegularExpressions.Regex.IsMatch(cvv, @"^\d{3}$");

            bool validExpiry = DateTime.TryParseExact(
                expiry,
                "MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime expDate
            );

            bool notExpired = validExpiry && expDate >= DateTime.Now;

            // Provide feedback for each validation
            if (!validCard)
            {
                MessageBox.Show("Invalid card number format. Please enter the card number as ####-####-####-####.");
            }
            if (!validCVV)
            {
                MessageBox.Show("Invalid CVV format. Please enter a 3-digit CVV.");
            }
            if (!validExpiry || !notExpired)
            {
                MessageBox.Show("Invalid expiry date. Please ensure it is in MM/YYYY format and not expired.");
            }

            return validCard && validCVV && validExpiry && notExpired; // Return the validation result
        }



        private string GenerateTransactionID()
        {
            // Logic to generate a unique transaction ID
            return Guid.NewGuid().ToString();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("This action will cancel your current booking. Are you sure you want to proceed?",
                                           "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Clear fields
                txtUserName.Clear();
                txtEmail.Clear();
                mtbCardNumber.Clear();
                mtbExpiryDate.Clear();
                mtbCVV.Clear();
                txtRetreatName.Clear();
                txtNumOfSpaces.Clear();
                txtSubtotal.Text = "$0.00";
                txtTotal.Text = "$0.00";
                MessageBox.Show("Booking canceled.");

                // Close the BookingPage
                this.Close();
            }
        }
    }
}