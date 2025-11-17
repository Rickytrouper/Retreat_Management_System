using System;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AdminDash : Form
    {
        private readonly int currentAdminID; // Store the current admin's ID
        private readonly AdminActionService adminActionService;

        // Constructor to accept both adminID and username
        public AdminDash(int adminID, string fullName)
        {
            InitializeComponent();
            currentAdminID = adminID; // Initialize currentAdminID
            adminActionService = new AdminActionService(); // Initialize the logging service


            // Set the welcome message with the username
            SetWelcomeMessage(fullName);

            // Subscribe to form events
            this.FormClosed += AdminDash_FormClosed;
            this.FormClosing += AdminDash_FormClosing;
        }

        public void SetWelcomeMessage(string fullName)
        {
            lbWelcomeMessage.Text = $"Welcome, {fullName}!"; // Display the fullname

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
                adminActionService.LogAdminAction(currentAdminID, actionType, targetEntity,
                    "Admin opened the user management form.");

                UserManagementForm userManagementForm = Application.OpenForms.OfType<UserManagementForm>().FirstOrDefault();
                if (userManagementForm == null)
                {
                    userManagementForm = new UserManagementForm(currentAdminID);
                    userManagementForm.MdiParent = this.MdiParent;
                    userManagementForm.Show();
                }
                else
                {
                    userManagementForm.BringToFront();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdminDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Logic when the form closes
        }

        private void AdminDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isAnyFormOpen = Application.OpenForms.OfType<EditRetreats>().Any() ||
                                  Application.OpenForms.OfType<UserManagementForm>().Any() ||
                                  Application.OpenForms.OfType<Reports>().Any() ||
                                  Application.OpenForms.OfType<AboutPage>().Any();

            if (isAnyFormOpen)
            {
                e.Cancel = true;
                MessageBox.Show("Please close all open forms before exiting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuItemLogout_Click_1(object sender, EventArgs e)
        {
            LoginPage.PerformLogout();
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
                    aboutPage.MdiParent = this.MdiParent;
                    aboutPage.Show();
                }
                else
                {
                    aboutPage.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening About page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}