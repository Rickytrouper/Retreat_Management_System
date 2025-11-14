using System;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class EditRetreats : Form
    {
        private readonly int adminID; // Store admin ID
        private readonly Retreat_Management_DBEntities db;

        public EditRetreats(int adminID) // Constructor accepting only adminID
        {
            InitializeComponent();
            this.adminID = adminID; // Store the admin ID
            db = new Retreat_Management_DBEntities(); // Initialize the database context
            InitializeDataGridView(); // Initialize DataGridView settings
        }

        private void InitializeDataGridView()
        {
            // Set DataGridView properties
            dataGVRetreats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVRetreats.ReadOnly = true; // Make sure it's read-only for viewing
        }

        private void EditRetreats_Load(object sender, EventArgs e)
        {
            LoadRetreatsData(); // Load retreat data on form load
        }

        private void LoadRetreatsData()
        {
            this.retreatDetails.EnforceConstraints = false; // Disable constraints temporarily
                       
            this.retreatTableAdapter.Fill(this.retreatDetails.Retreat);
            
            Debug.WriteLine($"Rows Count: {dataGVRetreats.Rows.Count}"); // Debugging line

            //this.retreatDetails.EnforceConstraints = true; // Re-enable constraints after loadin

            // Print out column names for debugging
            foreach (DataGridViewColumn column in dataGVRetreats.Columns)
            {
                Debug.WriteLine($"Column Name: {column.Name}");
            }

            if (dataGVRetreats.Rows.Count == 0)
            {
                MessageBox.Show("No retreats available.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditSelectedRetreat_Click_1(object sender, EventArgs e)
        {
            if (dataGVRetreats.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGVRetreats.SelectedRows[0];

                // Get the RetreatID from the selected row
                int retreatID = (int)selectedRow.Cells["retreatIDDataGridViewTextBoxColumn"].Value;

                // Retrieve the retreat from the database using the RetreatID
                Retreat selectedRetreat = db.Retreats.Find(retreatID);

                if (selectedRetreat != null)
                {
                    // Open the AddRetreat form in edit mode, passing the selected retreat
                    AddRetreat editForm = new AddRetreat(selectedRetreat, adminID, adminID);
                    editForm.MdiParent = this.MdiParent; // Set the MDI parent
                    editForm.FormClosed += (s, args) => LoadRetreatsData(); // Refresh data after closing
                    editForm.Show();
                }
                else
                {
                    MessageBox.Show("Retreat not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a retreat to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBackToAdminDashboard_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form
        }

        private void btnDeleteSelectedRetreat_Click(object sender, EventArgs e)
        {
            if (dataGVRetreats.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGVRetreats.SelectedRows[0];
                int retreatID = (int)selectedRow.Cells["retreatIDDataGridViewTextBoxColumn"].Value;

                var confirmResult = MessageBox.Show("Are you sure you want to delete this retreat?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        var retreatToDelete = db.Retreats.Find(retreatID);
                        if (retreatToDelete != null)
                        {
                            db.Retreats.Remove(retreatToDelete);
                            db.SaveChanges();
                            MessageBox.Show("Retreat deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRetreatsData(); // Refresh the grid after deletion
                        }
                        else
                        {
                            MessageBox.Show("Retreat not found. Please refresh the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (DbUpdateException dbEx)
                    {
                        var innerException = dbEx.InnerException?.InnerException;
                        MessageBox.Show($"An error occurred while deleting the retreat: {innerException?.Message ?? dbEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a retreat to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}