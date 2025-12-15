using System;
using System.Collections.Generic; // Required for List<T>
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class UserDash : Form
    {
        private readonly int currentUserId; // Store the current user ID
        private readonly string username;     // Store the username
        private string originalUsername;      // Store original values for cancel operation
        private string originalEmail;
        private string originalContactInfo;

        private const string EmptyFieldMessage = "Username and Email cannot be empty.";
        private const string UpdateSuccessMessage = "Profile updated successfully!";
        private const string ProfilePictureNotFoundMessage = "Profile picture not found.";

        private List<Form> openedForms; // List to track opened forms

        public UserDash(int userId, string fullName) // Constructor accepting user ID and full name
        {
            InitializeComponent();
            currentUserId = userId; // Set the current user ID
            openedForms = new List<Form>(); // Initialize the list of opened forms
            this.FormClosed += UserDash_FormClosed;
            SetWelcomeMessage(fullName); // Show welcome message
        }

        public UserDash(int currentUserId)
        {
            this.currentUserId = currentUserId;
        }

        private void SetWelcomeMessage(string fullName)
        {
            lbWelcomeMessage.Text = $"Welcome, {fullName}!"; // Set welcome message with username
        }

        private void UserDash_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUserInfo(); // Load user information when the form loads
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void LoadUserInfo()
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                var user = context.Users.FirstOrDefault(q => q.UserID == currentUserId);
                if (user != null)
                {
                    // Populate user details
                    txtUserName.Text = user.Username;
                    txtEmail.Text = user.Email;
                    txtContactNum.Text = user.ContactInfo;

                    // Display welcome message
                    lbWelcomeMessage.Text = $"Welcome, {user.FirstName} {user.LastName}!";

                    // Load profile picture
                    LoadProfilePicture(user.ProfilePicture);

                    // Store original values
                    StoreOriginalValues();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProfilePicture(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                picbxProfile.Image = Image.FromFile(imagePath); // Set the PictureBox image
                picbxProfile.SizeMode = PictureBoxSizeMode.StretchImage; // Optional
            }
            else
            {
                lbProfileError.Text = ProfilePictureNotFoundMessage; // Set the error message
                lbProfileError.ForeColor = Color.Red; // Change text color to red
                lbProfileError.Visible = true; // Show the error label
                picbxProfile.Image = null; // Clear the image if no data found
            }
        }

        private void StoreOriginalValues()
        {
            originalUsername = txtUserName.Text; // Store original values for cancel operation
            originalEmail = txtEmail.Text;
            originalContactInfo = txtContactNum.Text;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // Make text boxes editable
            txtUserName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContactNum.ReadOnly = false;

            // Change button states
            btnEditProfile.Enabled = false; // Disable Edit button to prevent multiple clicks
            btnSaveProfile.Enabled = true;   // Enable Save button
            btnCancel.Enabled = true;        // Enable Cancel button

            MessageBox.Show("You can now edit your profile.", "Edit Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect updated information
                string username = txtUserName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string contactInfo = txtContactNum.Text.Trim();

                // Validation
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show(EmptyFieldMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsEmailValid(email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the user record in the database
                using (var context = new Retreat_Management_DBEntities())
                {
                    var existingUser = context.Users.FirstOrDefault(q => q.UserID == currentUserId);
                    if (existingUser != null)
                    {
                        existingUser.Username = username;
                        existingUser.Email = email;
                        existingUser.ContactInfo = contactInfo;

                        context.SaveChanges(); // Save changes to the database

                        // Confirmation message
                        MessageBox.Show(UpdateSuccessMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset original values after successful save
                        StoreOriginalValues();

                        // Make text boxes read-only again
                        ResetTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Database error: " + dbEx.InnerException?.Message ?? dbEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Validate email format
        }

        private void ResetTextBoxes()
        {
            // Set text boxes back to read-only
            txtUserName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContactNum.ReadOnly = true;

            // Reset button states
            btnEditProfile.Enabled = true;
            btnSaveProfile.Enabled = false; // Disable Save button after saving
            btnCancel.Enabled = false;      // Disable Cancel button after saving
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Revert text boxes to original values
            txtUserName.Text = originalUsername;
            txtEmail.Text = originalEmail;
            txtContactNum.Text = originalContactInfo;

            // Make text boxes read-only again
            ResetTextBoxes();
        }

        private void picbxProfile_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a new profile picture
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Select a Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadProfilePicture(filePath);

                    // Optionally, save new profile picture path to the database
                    SaveProfilePicturePath(filePath);
                }
            }
        }

        private void SaveProfilePicturePath(string imagePath)
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                var existingUser = context.Users.FirstOrDefault(q => q.UserID == currentUserId);
                if (existingUser != null)
                {
                    existingUser.ProfilePicture = imagePath; // Update profile picture path
                    context.SaveChanges(); // Save the change
                }
            }
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Retreat_Management_DBEntities())
                {
                    // Retrieve reservations for the current user
                    var reservations = context.Bookings
                        .Join(context.Payments,
                            booking => booking.BookingID,
                            payment => payment.BookingID,
                            (booking, payment) => new { booking, payment })
                        .Join(context.Retreats,
                            bp => bp.booking.RetreatID,
                            retreat => retreat.RetreatID,
                            (bp, retreat) => new { bp.booking, bp.payment, retreat })
                        .Join(context.Users,
                            bpr => bpr.booking.UserID,
                            user => user.UserID,
                            (bpr, user) => new
                            {
                                BookingID = bpr.booking.BookingID,
                                BookingDate = bpr.booking.BookingDate,
                                Status = bpr.booking.Status,
                                PaymentStatus = bpr.booking.PaymentStatus,
                                Amount = bpr.payment.Amount,
                                PaymentDate = bpr.payment.PaymentDate,
                                RetreatName = bpr.retreat.RetreatName,
                                Location = bpr.retreat.Location,
                                StartDate = bpr.retreat.StartDate,
                                EndDate = bpr.retreat.EndDate,
                                Price = bpr.retreat.Price,
                                ContactInfo = bpr.retreat.ContactInfo,
                                Username = user.Username,
                                UserID = user.UserID // Store user ID
                            })
                        .Where(result => result.UserID == currentUserId) // Filter by current user's ID
                        .ToList();

                    // Check if there are any reservations
                    if (reservations.Count > 0)
                    {
                        // Bind the reservations to the DataGridView
                        dataGridViewReservations.DataSource = reservations;
                    }
                    else
                    {
                        MessageBox.Show("You have no reservations.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewReservations.DataSource = null; // Clear the DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemLogout_Click(object sender, EventArgs e)
        {
            LoginPage.PerformLogout(); // Call the static method directly
        }

        private void btnViewRetreats_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the UserDash form
            var retreatDetails = new lblRetreatDetails(currentUserId, username, this); // Pass the existing UserDash instance
            retreatDetails.Show(); // Show the retreat details form
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Remove the closed form from the list of opened forms
            openedForms.Remove(sender as Form);
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the AboutPage is already open
                AboutPage aboutPage = Application.OpenForms.OfType<AboutPage>().FirstOrDefault();
                if (aboutPage == null)
                {
                    // If not, open a new instance
                    aboutPage = new AboutPage(currentUserId);
                    aboutPage.FormClosed += ChildForm_FormClosed; // Track when this form closes
                    aboutPage.Show();

                    // Track opened forms
                    openedForms.Add(aboutPage);
                }
                else
                {
                    // If already open, bring it to the front
                    aboutPage.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening About page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Check if any forms are still open
            if (openedForms.Count > 0)
            {
                // Show a warning message but do not close the form
                MessageBox.Show("Please close all open forms before exiting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevent the form from closing
            }
            base.OnFormClosing(e); // Call the base class method
        }

        private void UserDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormClosed -= UserDash_FormClosed; // Unsubscribe from event
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Hide();
            string retrievedUsername = ""; // Placeholder for the username

            using (var context = new Retreat_Management_DBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == currentUserId);
                if (user != null)
                {
                    retrievedUsername = user.Username; // Fetch the username
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if user not found
                }
            }
            
        }
    }
}