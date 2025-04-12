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
    public partial class RetreatDetails: Form
    {
        public RetreatDetails()
        {
            InitializeComponent();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            // back to user dash
            UserDash userDash = new UserDash();
            userDash.Show();
            this.Hide(); // Hide the current form
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            // Open the BookingPage
            BookingPage bookingPage = new BookingPage();
            bookingPage.Show();
            this.Hide(); // Hide the current form

        }
    }
}
