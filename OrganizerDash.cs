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

        public OrganizerDash(int id) // Constructor to accept the organizer ID
        {
            InitializeComponent();
            this.organizerID = id; // Store the organizer ID
            userService = new UserService(); // Initialize the UserService
        }

        private void OrganizerDash_Load(object sender, EventArgs e)
        {
            var userDetails = userService.GetUserDetails(organizerID);

            if (userDetails != null)
            {
                // Auto-fill organizer's full name using properties directly
                txtOrganiserName.Text = $"{userDetails.FirstName} {userDetails.LastName}"; // Combine first and last names
                txtEmailAddress.Text = userDetails.Email;
            }
            else
            {
                MessageBox.Show("User details not found.");
            }
        }

        public void SetWelcome(string username)
        {
            // Welcome message
            lbWelcome.Text = $"Welcome, {username}!";
        }

        private void btnAddRetreats_Click(object sender, EventArgs e)
        {
            // Capture the full name from the text fields
            string fullName = txtOrganiserName.Text; // Assuming this is the full name
            string email = txtEmailAddress.Text;
            string phoneNumber = txtContactNumber.Text;
            string companyName = txtCompanyName.Text;
            string contact = txtContactInfo.Text; // Assuming there's a textbox for contact info

            // Split the full name into first and last names
            string[] nameParts = fullName.Split(new char[] { ' ' }, 2); // Split into first and last names
            string firstName = nameParts.Length > 0 ? nameParts[0] : string.Empty; // First name
            string lastName = nameParts.Length > 1 ? nameParts[1] : string.Empty; // Last name

            // Update the organizer data
            UpdateOrganizerData(email, firstName, lastName, phoneNumber, companyName, contact);


            // Open the AddRetreat form
            AddRetreat addRetreatForm = new AddRetreat(null); // Create an instance of AddRetreat
            addRetreatForm.Show(); // Show the form

            // Close the current form
            this.Hide();
        }

        private void UpdateOrganizerData(string email, string firstName, string lastName, string phoneNumber, string companyName, string contact)
        {
            using (var dbContext = new Retreat_Management_DBEntities())
            {
                // Find the existing organizer by email
                var organizer = dbContext.Organizers.FirstOrDefault(o => o.Email == email);

                if (organizer != null)
                {
                    // Update existing organizer properties
                    organizer.FirstName = firstName;
                    organizer.LastName = lastName;
                    organizer.PhoneNumber = phoneNumber;
                    organizer.CompanyName = companyName;
                    organizer.ContactInfo = contact;

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
                    // Create new organizer entry if not found
                    organizer = new Organizer
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        PhoneNumber = phoneNumber,
                        CompanyName = companyName,
                        ContactInfo = contact
                    };
                    dbContext.Organizers.Add(organizer);

                    // Save changes to the database
                    try
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("New organizer created successfully.");
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
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Close(); // Close the current form
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // Open the AboutPage form
            var aboutPage = new AboutPage(); // Create an instance of AboutPage
            aboutPage.Show();
        }
    }
}