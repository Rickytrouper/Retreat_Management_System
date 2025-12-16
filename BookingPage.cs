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
        private readonly int currentUserId;
        private readonly int? currentRetreatId;
        private decimal paymentAmountPerSpace;

        public BookingPage(int userId, int retreatId, decimal amount, UserDash userDashboard)
        {
            InitializeComponent();
            currentUserId = userId;
            currentRetreatId = retreatId;
            paymentAmountPerSpace = amount;

            btnConfirmBooking.Click += btnConfirmBooking_Click;
            this.Load += BookingPage_Load;

            db = new Retreat_Management_DBEntities();
        }

        public void SetRetreatName(string retreatName)
        {
            txtRetreatName.Text = retreatName;
        }

        public void SetUserName(string userName)
        {
            txtUserName.Text = userName;
        }

        public void SetEmail(string email)
        {
            txtEmail.Text = email;
        }

        private void SetupMaskedInput(MaskedTextBox mtb, string mask, string placeholder)
        {
            mtb.Mask = mask;
            mtb.PromptChar = ' ';
            mtb.Clear();

            mtb.Enter += (s, args) =>
            {
                mtb.SelectionStart = 0; // Set caret position to the start
            };

            mtb.Click += (s, args) =>
            {
                if (!mtb.MaskFull)
                {
                    mtb.SelectionStart = 0; // Set caret position to the start
                }
            };

            mtb.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(mtb.Text))
                {
                    mtb.Clear();
                }
            };
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            SetupMaskedInput(mtbCardNumber, "####-####-####-####", "####-####-####-####");
            SetupMaskedInput(mtbCVV, "###", "###");
            SetupMaskedInput(mtbExpiryDate, "00/0000", "MM/yyyy");

            // Assuming these are regular TextBox controls
            txtUserName.Enter += (s, args) => txtUserName.SelectionStart = 0; // Caret at start
            txtEmail.Enter += (s, args) => txtEmail.SelectionStart = 0; // Caret at start
            txtNumOfSpaces.Enter += (s, args) => txtNumOfSpaces.SelectionStart = 0; // Caret at start

            var retreat = db.Retreats.Find(currentRetreatId);
            if (retreat != null)
            {
                paymentAmountPerSpace = retreat.Price;
                txtNumOfSpaces.TextChanged += UpdateTotals;
            }
        }
        private void UpdateTotals(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumOfSpaces.Text, out int numberOfSpaces))
            {
                decimal subtotal = paymentAmountPerSpace * numberOfSpaces;
                txtSubtotal.Text = subtotal.ToString("C");
                txtTotal.Text = subtotal.ToString("C");
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

            if (!IsAvailableForBooking(currentRetreatId.Value, numberOfSpaces))
            {
                MessageBox.Show("The selected retreat does not have enough available spaces. Please adjust your request.");
                return;
            }

            if (!ProcessPayment(cardNumber, expiry, cvv))
            {
                return;
            }

            // Extracting the visible parts of the card number
            string maskedCardNumber = $"{cardNumber.Substring(0, 4)}-XXXX-XXXX-{cardNumber.Substring(15, 4)}";

            var booking = new Booking
            {
                UserID = currentUserId,
                RetreatID = currentRetreatId.Value,
                BookingDate = DateTime.Now,
                Status = "Confirmed",
                UserName = username,
                Email = email,
                CardNumber = maskedCardNumber, // Save the masked number
                ExpiryDate = DateTime.ParseExact(expiry, "MM/yyyy", CultureInfo.InvariantCulture).AddDays(1).AddMonths(-1),
                CVV = cvv,
                PaymentStatus = "Paid",
                NumberOfSpaces = numberOfSpaces
            };

            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Bookings.Add(booking);
                    db.SaveChanges();

                    UpdateCurrentBookings(currentRetreatId.Value, numberOfSpaces); // Ensure correct booking update

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
                    db.SaveChanges();

                    transaction.Commit();
                    MessageBox.Show("Booking and payment completed successfully.");
                    this.Close();
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show($"An error occurred while saving your booking: {dbEx.InnerException?.Message}");
                    transaction.Rollback();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    transaction.Rollback();
                }
            }
        }

        private void UpdateCurrentBookings(int retreatId, int numberOfSpaces)
        {
            var retreat = db.Retreats.FirstOrDefault(r => r.RetreatID == retreatId);
            if (retreat != null)
            {
                retreat.currentBookings += numberOfSpaces; // Increment current bookings
                db.SaveChanges(); // Commit the changes
            }
        }

        private bool IsAvailableForBooking(int retreatId, int numberOfSpaces)
        {
            var retreat = db.Retreats.Find(retreatId);
            if (retreat == null) return false; // Invalid retreat ID

            // Count current bookings for this retreat
            int currentBookings = db.Bookings
                .Where(b => b.RetreatID == retreatId)
                .Sum(b => (int?)b.NumberOfSpaces) ?? 0;

            // Check availability
            return (currentBookings + numberOfSpaces) <= retreat.Capacity;
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

            return validCard && validCVV && validExpiry && notExpired;
        }

        private string GenerateTransactionID()
        {
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