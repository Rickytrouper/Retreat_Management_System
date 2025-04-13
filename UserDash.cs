using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public UserDash()
        {
            InitializeComponent();
            reservationTableAdapter = new ReservationDataTableAdapter(); // Initialize the table adapter
        }

        private void UserDash_Load(object sender, EventArgs e)
        {
            // Loads data into the 'retreat_Management_DBDataSet2.ReservationDataTable' table.
            this.reservationDataTableAdapter.Fill(this.retreat_Management_DBDataSet2.ReservationDataTable);

            try
            {
                // Fill the DataTable with data from the database
                reservationDataTable = new DataTable();
                reservationTableAdapter.Fill((Retreat_Management_DBDataSet2.ReservationDataTableDataTable)reservationDataTable); // Use the Fill method to get data

                // Set the DataGridView's DataSource to the DataTable
                dataGridViewReservations.DataSource = reservationDataTable; // Assuming 'dataGridViewReservations' is the name of your DataGridView

                // Load user info and store original values
                LoadUserInfo();
                StoreOriginalValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
        }

        private void LoadUserInfo()
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                var user = context.Users.FirstOrDefault(q => q.UserID == currentUserId);
                if (user != null)
                {
                    txtUserName.Text = user.Username;
                    txtEmail.Text = user.Email;
                    txtContactNum.Text = user.ContactInfo;
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

                // Validation (basic example)
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Username and Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = currentUserId;

                // Update the user record in the database
                using (var context = new Retreat_Management_DBEntities())
                {
                    var existingUser = context.Users.FirstOrDefault(q => q.UserID == userId);
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

                    // Check if the image path is valid
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        // Load the image from the file path
                        picbxProfile.Image = Image.FromFile(imagePath); // Set the PictureBox image
                    }
                    else
                    {
                        MessageBox.Show("Profile picture not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picbxProfile.Image = null; // Clear the image if no data found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}