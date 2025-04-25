using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AdminDash: Form
    {
        private int currentAdminID; // Store the current admin's ID
        private readonly AdminActionService adminActionService;

             
        public AdminDash(int adminID)
        {
            InitializeComponent();
            currentAdminID = adminID; // Initialize currentAdminID
            adminActionService = new AdminActionService(); // Initialize the logging service
        }

        public void SetWelcomeMessage(string username)
        {
            // Welcome  message
            lbWelcomeMessage.Text =$"Welcome, {username}!"; } 

       

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
            Reports generateReportsForm = new Reports(currentAdminID); // Create an instance of GenerateReports
            generateReportsForm.Show(); // Show the form
           
            this.Hide(); // Hide the current form

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
                userManagementForm.Show(); // Show the form
                this.Hide(); // Hide the current form
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
    }

}
