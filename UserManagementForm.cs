using System;
using System.Linq;
using System.Windows.Forms;
using Retreat_Management_System;

namespace Retreat_Management_System
{
    public partial class UserManagementForm : Form
    {
        private readonly AdminActionService adminActionService;
        private int currentAdminID; // Assuming this will be set when the admin logs in

        public UserManagementForm(int adminID)
        {
            InitializeComponent();
            currentAdminID = adminID; // Set the current admin ID
            adminActionService = new AdminActionService(); // Initialize the AdminActionService
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.retreat_Management_DB_UserInfo.User);
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("User");
            cbRole.Items.Add("Organizer");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewUserData.SelectedRows[0];
                string username = selectedRow.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();
                string email = selectedRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                string role = selectedRow.Cells["roleDataGridViewTextBoxColumn"].Value.ToString();

                txtUserName.Text = username;
                txtEmail.Text = email;
                cbRole.SelectedItem = role;
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewUserData.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["userIDDataGridViewTextBoxColumn"].Value);
                string newRole = cbRole.SelectedItem.ToString();

                try
                {
                    adminActionService.UpdateUserRole(currentAdminID, userId, newRole);
                    this.userTableAdapter.Fill(this.retreat_Management_DB_UserInfo.User);
                    MessageBox.Show("User role updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user role: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to save the changes.");
            }
        }

        private void btnEnable_Disable_Click(object sender, EventArgs e)
        {
            if (gridViewUserData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewUserData.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["userIDDataGridViewTextBoxColumn"].Value);

                try
                {
                    adminActionService.ToggleUserStatus(currentAdminID, userId);
                    this.userTableAdapter.Fill(this.retreat_Management_DB_UserInfo.User);
                    MessageBox.Show("User account status changed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing user account status: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to change the status.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbRole.SelectedItem = null;

            if (gridViewUserData.SelectedRows.Count > 0)
            {
                gridViewUserData.ClearSelection();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form, returning to AdminDash
        }
    }
}