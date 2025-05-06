using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class OrganizerDash : Form
    {
        private int organizerID; // Store organizer ID
        private readonly UserService userService; // Service to handle user-related operations
        private int currentUserID; // Store the current user's ID

        public OrganizerDash(int userID) // Constructor to accept the user ID
        {
            InitializeComponent();
            this.currentUserID = userID; // Store the user ID
            userService = new UserService(); // Initialize the UserService
            // Subscribe to the FormClosed event
            this.FormClosed += OrganizerDash_FormClosed;
        }

        private void OrganizerDash_Load(object sender, EventArgs e)
        {
            LoadOrganizerData();
        }

        private void LoadOrganizerData()
        {
            using (var dbContext = new Retreat_Management_DBEntities())
            {
                // Get the current user's email
                var user = dbContext.Users.FirstOrDefault(u => u.UserID == currentUserID);
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                string currentEmail = user.Email; // Store the current user's email

                // Check if the email exists in the Organizers table
                var organizer = dbContext.Organizers.FirstOrDefault(o => o.Email == currentEmail);
                if (organizer != null)
                {
                    // Organizer found, update the input fields
                    txtOrganiserName.Text = $"{organizer.FirstName} {organizer.LastName}";
                    txtEmailAddress.Text = organizer.Email;
                    txtContactNumber.Text = organizer.PhoneNumber;
                    txtCompanyName.Text = organizer.CompanyName;
                    txtContactInfo.Text = organizer.ContactInfo;
                    organizerID = organizer.OrganizerID; // Store the OrganizerID
                }
                else
                {
                    MessageBox.Show("The email address is not associated with an organizer profile.");
                }
            }
        }

        private void btnAddRetreats_Click(object sender, EventArgs e)
        {
            // Open the AddRetreat form, passing organizerID and currentUserID
            AddRetreat addRetreatForm = new AddRetreat(null, organizerID, currentUserID); // Pass organizerID and currentUserID
            addRetreatForm.MdiParent = this.MdiParent;
            addRetreatForm.Show(); // Show the form
        }

        private void UpdateOrganizerData(string email, string firstName, string lastName, string phoneNumber, string companyName, string contact)
        {
            using (var dbContext = new Retreat_Management_DBEntities())
            {
                // Find the existing organizer by OrganizerID
                var organizer = dbContext.Organizers.FirstOrDefault(o => o.OrganizerID == organizerID);

                if (organizer != null)
                {
                    // Update existing organizer properties
                    organizer.FirstName = firstName;
                    organizer.LastName = lastName;
                    organizer.PhoneNumber = phoneNumber;
                    organizer.CompanyName = companyName;
                    organizer.ContactInfo = contact;
                    organizer.UserID = currentUserID; // Update the UserID

                    // Save changes to the database
                    try
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("Organizer information updated successfully.");
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                            }
                        }
                    }
                    catch (DbUpdateException dbUpdateEx)
                    {
                        string errorMessage = "An error occurred while updating the database.";
                        if (dbUpdateEx.InnerException != null && dbUpdateEx.InnerException.InnerException != null)
                        {
                            errorMessage += $"\nInner Exception: {dbUpdateEx.InnerException.InnerException.Message}";
                        }
                        MessageBox.Show(errorMessage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Organizer not found.");
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the MDI parent form (which will close all child forms)
            this.MdiParent.Close();

            // Open the LoginPage form
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // Create a new AboutPage form
            AboutPage aboutPage = new AboutPage(organizerID);
            aboutPage.MdiParent = this.MdiParent; // Set the MDI parent
            aboutPage.Show(); // Show the AboutPage
        }

        private void OrganizerDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the LoginPage when this form is closed
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Show the LoginPage when this form is closed
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            Hide();



        }
    }
}