using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class BookingPage : Form
    {
        public BookingPage()
        {
            InitializeComponent();
        }
        // Define the SetRetreatName method
        public void SetRetreatName(string retreatName)
        {
            lblRetreatName.Text = retreatName;  // Set the text of the label to the retreat name
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string cardNumber = txtCardNumber.Text;
            string expiry = txtExpiryDate.Text;
            string cvv = txtCVV.Text;
            string retreatName = txtRetreatName.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(expiry) ||
                string.IsNullOrWhiteSpace(cvv))
            {
                MessageBox.Show("Please fill in all required fields.");
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
            throw new NotImplementedException();
        }
    }
}
