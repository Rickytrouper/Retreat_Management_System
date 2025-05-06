using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AdminDash : Form
    {
        private readonly int currentAdminID; // Store the current admin's ID
        private readonly AdminActionService adminActionService;

        public AdminDash(int adminID)
        {
            InitializeComponent();
            currentAdminID = adminID; // Initialize currentAdminID
            adminActionService = new AdminActionService(); // Initialize the logging service
            // Subscribe to the FormClosed event
            this.FormClosed += AdminDash_FormClosed;
        }

        public void SetWelcomeMessage(string username)
        {
            // Welcome message
            lbWelcomeMessage.Text = $"Welcome, {username}!";
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            // Open the LoginPage form
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            // Close the MDI parent form (which will close all child forms)
            this.MdiParent.Close();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // Create a new AboutPage form
            AboutPage aboutPage = new AboutPage(currentAdminID);
            aboutPage.MdiParent = this.MdiParent; // Set the MDI parent
            aboutPage.Show(); // Show the AboutPage
        }

        private void btnEditRetreat_Click(object sender, EventArgs e)
        {
            // Open the EditRetreat form
            EditRetreats editRetreatsForm = new EditRetreats(currentAdminID); // Pass adminID only
            editRetreatsForm.MdiParent = this.MdiParent;
            editRetreatsForm.Show(); // Show the form
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            // Open the GenerateReports form
            Reports generateReportsForm = new Reports(currentAdminID); // Create an instance of GenerateReports
            generateReportsForm.MdiParent = this.MdiParent;
            generateReportsForm.Show(); // Show the form
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            var adminActionService = new AdminActionService(); // Create an instance of the service
            string actionType = "Open User Management"; // Action type for opening user management
            string targetEntity = "User"; // Set the target entity to "User"

            try
            {
                // Log the action of opening the user management form
                adminActionService.LogAdminAction(currentAdminID, actionType, targetEntity, "Admin opened the user management form.");
                // MessageBox.Show("Action logged successfully.");

                // Open UserManagementForm with the currentAdminID
                UserManagementForm userManagementForm = new UserManagementForm(currentAdminID);
                userManagementForm.MdiParent = this.MdiParent;
                userManagementForm.Show(); // Show the form
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message); // Handle invalid action type
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Handle other errors
            }
        }

        private void AdminDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the LoginPage when this form is closed
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }
    }
}