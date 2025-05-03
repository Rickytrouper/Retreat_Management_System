using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Retreat_Management_System
{
    public partial class UserDash : Form
    {
        
        private readonly int currentUserId;


        // Store original values for cancel operation.
        private string originalUsername;
        private string originalEmail;
        private string originalContactInfo;

        public UserDash(int userId) // user ID  passed as a parameter
        {
            InitializeComponent();
            currentUserId = userId; // Set the current user ID
                                    //reservationTableAdapter 
            this.FormClosed += UserDash_FormClosed;
        }

        private void UserDash_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUserInfo();
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
                lbProfileError.Text = "Profile picture not found."; // Set the error message
                lbProfileError.ForeColor = Color.Red; // Change text color to red
                lbProfileError.Visible = true; // Show the error label
                picbxProfile.Image = null; // Clear the image if no data found
            }
        }

        private void StoreOriginalValues()
        {
            originalUsername = txtUserName.Text;
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
                    MessageBox.Show("Username and Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    }
                }

                // Confirmation message
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset original values after successful save
                StoreOriginalValues();

                // Make text boxes read-only again
                ResetTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    // Retrieve reservations for the current user using lambda expressions
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
                                UserID = user.UserID // Use user.UserID here
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
            // Close the MDI parent form (which will close all child forms)
            this.MdiParent.Close();

            // Open the LoginPage form
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void btnViewRetreats_Click(object sender, EventArgs e)
        {
            // Hide the UserDash form
            this.Hide();

            // Open the RetreatDetails form with the current user ID
            lblRetreatDetails retreatDetails = new lblRetreatDetails(currentUserId); // Pass the userId
            retreatDetails.MdiParent = this.MdiParent;
            // Hide the UserDash form
            this.Hide();
            retreatDetails.Show();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            // Create a new AboutPage form
            AboutPage aboutPage = new AboutPage(currentUserId);

            // Set the MdiParent of the AboutPage to the same as the UserDash
            aboutPage.MdiParent = this.MdiParent;

            // Show the AboutPage
            aboutPage.Show();
        }

        private void UserDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the LoginPage when this form is closed
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void RetreatDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the UserDash form again
            this.Show();
        }
    }
}