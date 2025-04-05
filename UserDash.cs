using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Retreat_Management_System.Retreat_Management_DBDataSet2TableAdapters;

namespace Retreat_Management_System
{
    public partial class UserDash : Form
    {
        // Declare the adapter
        private ReservationDataTableAdapter reservationTableAdapter;
        private DataTable reservationDataTable;
        private int currentUserId;

        // Store original values for cancel operation.
        private string originalUsername;
        private string originalEmail;
        private string originalContactInfo;

        public UserDash(int userId) // Assume user ID is passed as a parameter
        {
            InitializeComponent();
            currentUserId = userId; // Set the current user ID
            reservationTableAdapter = new ReservationDataTableAdapter(); // Initialize the table adapter
        }

        private void UserDash_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUserInfo();
                CheckUserReservations();
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
                    lbWelcomeMessage.Text = $"Welcome, {user.FirstName} {user.LastName}!"; // Assuming User has FirstName and LastName properties

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
                MessageBox.Show("Profile picture not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                picbxProfile.Image = null; // Clear the image if no data found
            }
        }

        private void CheckUserReservations()
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                // Check if the user has any reservations
                var reservations = context.Reservations.Where(q =>
                {
                    return q.UserID == currentUserId;
                }).ToList();

                if (reservations.Any())
                {
                    // User has reservations, load them into the GridView
                    reservationDataTable = new DataTable();
                    reservationTableAdapter.Fill(this.retreat_Management_DBDataSet2.ReservationDataTable); // Fill adapter with relevant data
                    dataGridViewReservations.DataSource = reservationDataTable;
                }
                else
                {
                    MessageBox.Show("You have no reservations.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            try
            {
                using (var context = new Retreat_Management_DBEntities())
                {
                    // Fetch the user's profile picture path using DbContext
                    string imagePath = context.Users
                        .Where(q => q.UserID == currentUserId) // Assuming currentUserId is set
                        .Select(q => q.ProfilePicture)
                        .FirstOrDefault();

                    // Load profile picture
                    LoadProfilePicture(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}