using System;
using System.Linq;
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
            this.FormClosed += AdminDash_FormClosed;

            // Subscribe to the FormClosing event
            this.FormClosing += AdminDash_FormClosing;
        }

        public void SetWelcomeMessage(string username)
        {
            // Welcome message
            lbWelcomeMessage.Text = $"Welcome, {username}!";
        }

        private void btnEditRetreat_Click(object sender, EventArgs e)
        {
            OpenEditRetreatForm();
        }

        private void OpenEditRetreatForm()
        {
            // Open the EditRetreat form
            EditRetreats editRetreatsForm = Application.OpenForms.OfType<EditRetreats>().FirstOrDefault();
            if (editRetreatsForm == null)
            {
                editRetreatsForm = new EditRetreats(currentAdminID);
                editRetreatsForm.MdiParent = this.MdiParent;
                editRetreatsForm.Show(); // Show the form
            }
            else
            {
                editRetreatsForm.BringToFront(); // Bring it to the front if it's already open
            }
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            OpenGenerateReportsForm();
        }

        private void OpenGenerateReportsForm()
        {
            // Open the GenerateReports form
            Reports generateReportsForm = Application.OpenForms.OfType<Reports>().FirstOrDefault();
            if (generateReportsForm == null)
            {
                generateReportsForm = new Reports(currentAdminID);
                generateReportsForm.MdiParent = this.MdiParent;
                generateReportsForm.Show(); // Show the form
            }
            else
            {
                generateReportsForm.BringToFront(); // Bring it to the front if it's already open
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            OpenManageUsersForm();
        }

        private void OpenManageUsersForm()
        {
            var actionType = "Open User Management";
            var targetEntity = "User";

            try
            {
                // Log the action of opening the user management form
                adminActionService.LogAdminAction(currentAdminID, actionType, targetEntity, "Admin opened the user management form.");

                // Open UserManagementForm with the currentAdminID
                UserManagementForm userManagementForm = Application.OpenForms.OfType<UserManagementForm>().FirstOrDefault();
                if (userManagementForm == null)
                {
                    userManagementForm = new UserManagementForm(currentAdminID);
                    userManagementForm.MdiParent = this.MdiParent;
                    userManagementForm.Show(); // Show the form
                }
                else
                {
                    userManagementForm.BringToFront(); // Bring it to the front if it's already open
                }
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
            // PerformLogout() use to reshow login page
        }

        private void AdminDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check for specific open forms
            bool isAnyFormOpen = Application.OpenForms.OfType<EditRetreats>().Any() ||
                                  Application.OpenForms.OfType<UserManagementForm>().Any() ||
                                  Application.OpenForms.OfType<Reports>().Any() ||
                                  Application.OpenForms.OfType<AboutPage>().Any();

            if (isAnyFormOpen)
            {
                // Cancel the close operation
                e.Cancel = true;
                MessageBox.Show("Please close all open forms before exiting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuItemLogout_Click_1(object sender, EventArgs e)
        {
            LoginPage.PerformLogout(); // Call the static method 
        }

        private void MenuItemAbout_Click_1(object sender, EventArgs e)
        {
            OpenAboutPage();
        }

        private void OpenAboutPage()
        {
            try
            {
                AboutPage aboutPage = Application.OpenForms.OfType<AboutPage>().FirstOrDefault();
                if (aboutPage == null)
                {
                    aboutPage = new AboutPage(currentAdminID);
                    aboutPage.MdiParent = this.MdiParent; // Set the MDI parent
                    aboutPage.Show(); // Show the AboutPage
                }
                else
                {
                    aboutPage.BringToFront(); // Bring it to the front if it's already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening About page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}