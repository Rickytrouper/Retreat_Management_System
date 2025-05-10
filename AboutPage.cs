using System;
using System.Drawing;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AboutPage : Form
    {
        private int userId; // Store the user ID

        // Constructor that accepts user ID
        public AboutPage(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Set the user ID
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {            
                this.StartPosition = FormStartPosition.CenterParent;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.ControlBox = false;
                this.ShowInTaskbar = false;
                this.BackColor = Color.LightBlue;
                this.Text = "About Us";
           
        }       

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            // Open the LoginPage form
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Close(); // Close the AboutPage
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Check the owner of the dash and show the appropriate dashboard
            if (this.Owner is UserDash userDash)
            {
                userDash.Show(); // Return to User Dashboard
            }
            else if (this.Owner is AdminDash adminDash)
            {
                adminDash.Show(); // Return to Admin Dashboard
            }
            else if (this.Owner is OrganizerDash organizerDash)
            {
                organizerDash.Show(); // Return to Organizer Dashboard
            }

            this.Close(); // Close AboutPage

        }
    }
}