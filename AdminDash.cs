using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AdminDash: Form
    {
      
        public AdminDash()
        {
            InitializeComponent();
            this.FormClosing += AdminDash_FormClosing;
        }
        
        public void SetWelcomeMessage(string username)
        {
            // Display Welcome  message
            lbWelcomeMessage.Text =$"Welcome, {username}!"; 
        }        

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Open the LoginPage form
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // Open the AboutPage form
            AboutPage aboutPage = new AboutPage(); // Create an instance of AboutPage
            aboutPage.Show();
        }

        private void btnAddRetreat_Click(object sender, EventArgs e)
        {
            // Open the AddRetreat form
            AddRetreat addRetreatForm = new AddRetreat(); // Create an instance of AddRetreat
            addRetreatForm.Show(); // Show the form
        }

        private void btnEditRetreat_Click(object sender, EventArgs e)
        {
            // Open the EditRetreat form
            EditRetreats editRetreatForm = new EditRetreats(); // Create an instance of EditRetreat
            editRetreatForm.Show(); // Show the form

        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            // Open the GenerateReports form
            Reports generateReportsForm = new Reports(); // Create an instance of GenerateReports
            generateReportsForm.Show(); // Show the form
           
            this.Hide(); // Hide the current form

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // open user managementform
            UserManagementForm userManagementForm = new UserManagementForm(); // Create an instance of UserManagementForm
            userManagementForm.Show(); // Show the form
            this.Hide(); // Hide the current form
        }

        private void AdminDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close login page when Admin dash closes
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginPage)
                {
                    form.Close();
                    break;
                }
            }

        }
    }
}
