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
    public partial class RetreatDetails : Form
    {
        public RetreatDetails()
        {
            InitializeComponent();

            // Load sample retreat details (or fetch from DB)
            txtRetreatName.Text = "Mountain Zen Retreat";
            txtDescription.Text = "Relax, rejuvenate, and recharge in the serene mountain landscape with daily yoga, meditation, and nature hikes.";
            txtLocation.Text = "Aspen, Colorado";
            txtRetreatDates.Text = "June 10 - June 15, 2025";
            txtRetreatPrice.Text = "$599";
            
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            BookingPage bookingPage = new BookingPage();
            bookingPage.SetRetreatName(txtRetreatName.Text); // Pass retreat name
            bookingPage.Show();
            this.Hide();
            BookingPage dashboard = new BookingPage(); // Assuming you have a form named Dashboard
            dashboard.Show();
            this.Hide();

        }
        

    }

}
