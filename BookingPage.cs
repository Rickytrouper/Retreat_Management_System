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
    public partial class BookingPage: Form
    {
        public BookingPage()
        {
            InitializeComponent();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            // save the booking details to the database

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            // Cancel the booking and go back to the previous page
            RetreatDetails retreatDetails = new RetreatDetails();
            retreatDetails.Show();
            this.Hide(); // Hide the current form
        }
    }
}
