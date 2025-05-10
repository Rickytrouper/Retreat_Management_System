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
                // Get the current user
                var user = dbContext.Users.FirstOrDefault(u => u.UserID == currentUserID);
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                // Try to find an organizer by UserID first
                var organizer = dbContext.Organizers.FirstOrDefault(o => o.UserID == currentUserID);

                if (organizer == null)
                {
                    // If UserID is not found, try to find an organizer by Email
                    organizer = dbContext.Organizers.FirstOrDefault(o => o.Email == user.Email);

                    if (organizer != null)
                    {
                        // Organizer found by Email, update the UserID
                        organizer.UserID = currentUserID;
                        try
                        {
                            dbContext.SaveChanges();
                            MessageBox.Show("Organizer found by email, UserID updated.");
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

                if (organizer != null)
                {
                    // Organizer found (either by UserID or Email), update missing data
                    bool dataUpdated = false;

                    if (string.IsNullOrEmpty(organizer.FirstName))
                    {
                        organizer.FirstName = user.FirstName;
                        dataUpdated = true;
                    }
                    if (string.IsNullOrEmpty(organizer.LastName))
                    {
                        organizer.LastName = user.LastName;
                        dataUpdated = true;
                    }
                    if (string.IsNullOrEmpty(organizer.Email))
                    {
                        organizer.Email = user.Email;
                        dataUpdated = true;
                    }
                    if (string.IsNullOrEmpty(organizer.PhoneNumber))
                    {
                        organizer.PhoneNumber = user.ContactInfo;
                        dataUpdated = true;
                    }

                    if (dataUpdated)
                    {
                        try
                        {
                            dbContext.SaveChanges();
                            MessageBox.Show("Organizer information updated from user profile.");
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

                    // Load the data into the textboxes
                    txtOrganiserName.Text = $"{organizer.FirstName} {organizer.LastName}";
                    txtEmailAddress.Text = organizer.Email;
                    txtContactNumber.Text = organizer.PhoneNumber;
                    txtCompanyName.Text = organizer.CompanyName;
                    txtContactInfo.Text = organizer.ContactInfo;
                    organizerID = organizer.OrganizerID; // Store the OrganizerID
                }
                else
                {
                    // No organizer profile found (neither by UserID nor Email). Create a new one.
                    Organizer newOrganizer = new Organizer
                    {
                        UserID = currentUserID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNumber = user.ContactInfo,
                        CompanyName = "",
                        ContactInfo = ""
                    };

                    dbContext.Organizers.Add(newOrganizer);

                    try
                    {
                        dbContext.SaveChanges();
                        organizerID = newOrganizer.OrganizerID;
                        MessageBox.Show("New organizer profile created.");

                        // Now load the data into the textboxes
                        txtOrganiserName.Text = $"{newOrganizer.FirstName} {newOrganizer.LastName}";
                        txtEmailAddress.Text = newOrganizer.Email;
                        txtContactNumber.Text = newOrganizer.PhoneNumber;
                        txtCompanyName.Text = newOrganizer.CompanyName;
                        txtContactInfo.Text = newOrganizer.ContactInfo;
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
            LoginPage.PerformLogout(); // Call the static method directly
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
            // Do nothing.  The PerformLogout() method handles showing the LoginPage.
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginPage.PerformLogout(); // Call the static method directly
        }
    }
}