using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; // For Entity Framework
using Retreat_Management_System;
using Retreat_Management_System.Retreat_Management_DB_UserInfoTableAdapters; // Your namespace

namespace Retreat_Management_System
{
    public partial class UserManagementForm: Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'retreat_Management_DB_UserInfo.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.retreat_Management_DB_UserInfo.User);
            // Initialize ComboBox with roles
            cbRole.Items.Clear(); // Clear existing items (if any)
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("User");
            cbRole.Items.Add("Organizer");

        }

        private void gridViewUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = gridViewUserData.SelectedRows[0];

                // Retrieve user information from the selected row
                string username = selectedRow.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();
                string email = selectedRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                string role = selectedRow.Cells["roleDataGridViewTextBoxColumn"].Value.ToString();

                // Load the retrieved information into the text fields and combo box
                txtUserName.Text = username;
                txtEmail.Text = email;
                cbRole.SelectedItem = role; // Assuming role matches the items in cbRole
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = gridViewUserData.SelectedRows[0];

                // Retrieve the User ID from the selected row
                int userId = Convert.ToInt32(selectedRow.Cells["userIDDataGridViewTextBoxColumn"].Value);

                // Retrieve the newly selected role from the combo box
                string newRole = cbRole.SelectedItem.ToString();

                // Update the user role in the database using Entity Framework
                using (var context = new Retreat_Management_DBEntities()) // Ensure YourDbContext is defined
                {
                    try
                    {
                        // Find the user by ID
                        var user = context.Users.SingleOrDefault(u => u.UserID == userId);

                        if (user != null)
                        {
                            // Update the user's role
                            user.Role = newRole;

                            // Save changes to the database
                            context.SaveChanges();

                            // Refresh the DataGridView
                            this.userTableAdapter.Fill(this.retreat_Management_DB_UserInfo.User);

                            MessageBox.Show("User role updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating user role: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to save the changes.");
            }

        }             

        private void btnEnable_Disable_Click(object sender, EventArgs e)
        {// Check if any row is selected
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = gridViewUserData.SelectedRows[0];

                // Retrieve the User ID from the selected row
                int userId = Convert.ToInt32(selectedRow.Cells["userIDDataGridViewTextBoxColumn"].Value);

                using (var context = new Retreat_Management_DBEntities()) // Ensure YourDbContext is used
                {
                    try
                    {
                        // Find the user by ID
                        var user = context.Users.SingleOrDefault(u => u.UserID == userId);

                        if (user != null)
                        {
                            // Toggle the user's account status based on the AccountStatus column
                            if (user.AccountStatus == "Active")
                            {
                                user.AccountStatus = "Suspended"; // Set to suspended
                            }
                            else
                            {
                                user.AccountStatus = "Active"; // Set back to active
                            }

                            // Save changes to the database
                            context.SaveChanges();

                            // Display the status change message
                            MessageBox.Show($"User account has been {user.AccountStatus} successfully.");

                            // Refresh the DataGridView to show updated status
                            this.userTableAdapter.Fill(this.retreat_Management_DB_UserInfo.User);
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error changing user account status: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to change the status.");
            }
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;

            // Clear the selected item in the combo box
            cbRole.SelectedItem = null; // Or alternatively: cbRole.SelectedIndex = -1; if you want to deselect

            // Optionally, you can also deselect any selected row in the DataGridView
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                gridViewUserData.ClearSelection(); // Deselects all selected rows
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // back to admin dash
            AdminDash adminDash = new AdminDash(); // Create an instance of AdminDash
            adminDash.Show(); // Show the form
            // Close the current form
            this.Close();

        }
    }
}