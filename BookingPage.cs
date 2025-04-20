using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class BookingPage : Form
    {
       // private readonly Retreat_Management_DBEntities db;
        private int currentUserId; // Add this line to store the user ID

        public BookingPage(int userId) // Constructor accepting userId
        {
            InitializeComponent();
            currentUserId = userId; // Store the user ID
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            this.Load += BookingPage_Load;
        }
        // Define the SetRetreatName method
        public void SetRetreatName(string retreatName)
        {
            txtRetreatName.Text =  retreatName;  // Set the text of the label to the retreat name
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
            // Always move caret to the beginning on focus
            mtb.Enter += (s, args) =>
            {
                mtb.Select(0, 0);
            };

            // Optional: if you want to auto-clear the field when clicked
            mtb.Click += (s, args) =>
            {
                // Only reset if the input is partially filled
                if (!mtb.MaskFull)
                {
                    mtb.Select(0, 0);
                }
            };
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            /*mtbCardNumber.Enter += (s, args) => mtbCardNumber.Select(0, 0);
            mtbCVV.Enter += (s, args) => mtbCVV.Select(0, 0);
            mtbExpiryDate.Enter += (s, args) => mtbExpiryDate.Select(0, 0);*/

            SetupMaskedInput(mtbCardNumber);
            SetupMaskedInput(mtbCVV);
            SetupMaskedInput(mtbExpiryDate);

            mtbCardNumber.PromptChar = ' ';
            mtbCVV.PromptChar = ' ';
            mtbExpiryDate.PromptChar = ' ';
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string cardNumber = mtbCardNumber.Text;
            string expiry = mtbExpiryDate.Text;
            string cvv = mtbCVV.Text;
            string retreatName = txtRetreatName.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in your name and email.");
                return;
            }

            if (!mtbCardNumber.MaskFull || !mtbCVV.MaskFull || !mtbExpiryDate.MaskFull)
            {
                MessageBox.Show("Please complete all payment fields correctly.");
                return;
            }


            bool paymentSuccess = ProcessPayment(cardNumber, expiry, cvv);

            if (paymentSuccess)
            {
                MessageBox.Show($"Booking confirmed for '{retreatName}'.\nThank you, {username}!");
            }
            else
            {
                MessageBox.Show("Payment failed. Please check your card details.");
            }
        }

        private bool ProcessPayment(string cardNumber, string expiry, string cvv)
        {
            // Check card format: 16 digits with dashes (e.g., 1234-5678-9012-3456)
            bool validCard = System.Text.RegularExpressions.Regex.IsMatch(cardNumber, @"^\d{4}-\d{4}-\d{4}-\d{4}$");

            // Check CVV: exactly 3 digits
            bool validCVV = System.Text.RegularExpressions.Regex.IsMatch(cvv, @"^\d{3}$");

            // Check Expiry: MM/yyyy format and valid date
            bool validExpiry = DateTime.TryParseExact(
                expiry,
                "MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime expDate
            );

            // Optionally, reject expired cards:
            bool notExpired = validExpiry && expDate >= DateTime.Now;

            return validCard && validCVV && validExpiry && notExpired;
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


