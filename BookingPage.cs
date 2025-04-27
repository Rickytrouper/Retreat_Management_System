using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class BookingPage : Form
    {
        private readonly Retreat_Management_DBEntities db;
        private int currentUserId; // store the user ID
        private int? currentRetreatId; //  store the retreat ID
        private decimal paymentAmount; // store the payment amount


        public BookingPage(int userId, int retreatId, decimal amount) // Constructor accepting userId and retreatId
        {
            InitializeComponent();
            currentUserId = userId; // Store the user ID
            currentRetreatId = retreatId; // Store the retreat ID
            paymentAmount = amount; // Store the payment amount
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            this.Load += BookingPage_Load;

            // Initialize the database context
            db = new Retreat_Management_DBEntities();
        }

        // Define the SetRetreatName method
        public void SetRetreatName(string retreatName)
        {
            txtRetreatName.Text = retreatName;  // Set the text of the label to the retreat name
        }

        public void SetUserName(string userName)
        {
            txtUserName.Text = userName; // Set the username in the textbox
        }

        public void SetEmail(string email)
        {
            txtEmail.Text = email; // Set the email in the textbox
        }

        private void SetupMaskedInput(MaskedTextBox mtb)
        {
            // move caret to the beginning on focus
            mtb.Enter += (s, args) =>
            {
                mtb.Select(0, 0);
            };

            
            mtb.Click += (s, args) =>
            {
               
                if (!mtb.MaskFull)
                {
                    mtb.Select(0, 0);
                }
            };
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            SetupMaskedInput(mtbCardNumber);
            SetupMaskedInput(mtbCVV);
            SetupMaskedInput(mtbExpiryDate);

            mtbCardNumber.PromptChar = ' ';
            mtbCVV.PromptChar = ' ';
            mtbExpiryDate.PromptChar = ' ';
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cardNumber = mtbCardNumber.Text.Trim();
            string expiry = mtbExpiryDate.Text.Trim();
            string cvv = mtbCVV.Text.Trim();
            string retreatName = txtRetreatName.Text.Trim();

            // Validate input fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in your name and email.");
                return;
            }

            // Validate payment details
            if (!ProcessPayment(cardNumber, expiry, cvv))
            {
                // If payment validation fails, exit the method
                return;
            }

            // Check if currentRetreatId has a value
            if (!currentRetreatId.HasValue)
            {
                MessageBox.Show("Retreat ID is not valid.");
                return;
            }


            // Create the booking first
            var booking = new Booking
            {
                UserID = currentUserId,
                RetreatID = currentRetreatId.Value,
                BookingDate = DateTime.Now,
                Status = "Confirmed",
                UserName = username,
                Email = email,
                CardNumber = cardNumber,
                ExpiryDate = DateTime.ParseExact(expiry, "MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).AddDays(1).AddMonths(-1),
                CVV = cvv,
                PaymentStatus = "Paid" 
            };

            // Start a transaction
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    // Save the booking
                    db.Bookings.Add(booking);
                    db.SaveChanges(); // Save the booking

                    // Create the payment record
                    var payment = new Payment
                    {
                        Amount = paymentAmount,
                        PaymentDate = DateTime.Now,
                        PaymentMethod = "Credit Card",
                        Status = "Successful",
                        TransactionID = GenerateTransactionID(),
                        BookingID = booking.BookingID // Set the BookingID after saving the booking
                    };                 

                // Save the payment
                db.Payments.Add(payment);
                    db.SaveChanges(); // Save the payment record

                    // Commit the transaction
                    transaction.Commit();
                    MessageBox.Show("Booking and payment completed successfully.");


                    // Navigate back to UserDash
                    var userDash = new UserDash(currentUserId); 
                    this.Hide(); // Hide the current form
                    userDash.Show(); // Show the UserDash form


                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show($"An error occurred while saving your booking: {dbEx.InnerException?.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private bool ProcessPayment(string cardNumber, string expiry, string cvv)
        {
            bool validCard = System.Text.RegularExpressions.Regex.IsMatch(cardNumber, @"^\d{4}-\d{4}-\d{4}-\d{4}$");
            bool validCVV = System.Text.RegularExpressions.Regex.IsMatch(cvv, @"^\d{3}$");

            bool validExpiry = DateTime.TryParseExact(
                expiry,
                "MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime expDate
            );

            bool notExpired = validExpiry && expDate >= DateTime.Now;

            if (!validCard)
            {
                MessageBox.Show("Invalid card number format. Please use ####-####-####-####.");
            }
            if (!validCVV)
            {
                MessageBox.Show("Invalid CVV format. Please enter a 3-digit CVV.");
            }
            if (!validExpiry || !notExpired)
            {
                MessageBox.Show("Invalid expiry date. Please ensure it is in MM/yyyy format and not expired.");
            }

            return validCard && validCVV && validExpiry && notExpired; // Return the validation result
        }
        private string GenerateTransactionID()
        {
            // logic to generate a unique transaction ID
            return Guid.NewGuid().ToString(); 
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Cancel this booking?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Clear fields
                txtUserName.Clear();
                txtEmail.Clear();
                mtbCardNumber.Clear();
                mtbExpiryDate.Clear();
                mtbCVV.Clear();
                txtRetreatName.Clear();
                MessageBox.Show("Booking canceled.");
                this.Hide();

                // Pass the userId to RetreatDetails
                lblRetreatDetails retreatDetails = new lblRetreatDetails(currentUserId);
                retreatDetails.Show();
            }
        }
    }
}