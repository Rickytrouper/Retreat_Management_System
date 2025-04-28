using System;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class EditRetreats : Form
    {
        private int adminID; // Store admin ID
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
            dataGVRetreats.ReadOnly = false; // Make sure it's not read-only
        }


        private void EditRetreats_Load(object sender, EventArgs e)
        {
            LoadRetreatsData(); // Load retreat data on form load
        }

        private void LoadRetreatsData()
        {
            this.retreatTableAdapter.Fill(this.retreatDetails.Retreat);

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

                // Correcting the column name
                string retreatName = selectedRow.Cells["retreatNameDataGridViewTextBoxColumn"].Value.ToString();
                string description = selectedRow.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                string location = selectedRow.Cells["locationDataGridViewTextBoxColumn"].Value.ToString();
                DateTime startDate = DateTime.Parse(selectedRow.Cells["startDateDataGridViewTextBoxColumn"].Value.ToString());
                DateTime endDate = DateTime.Parse(selectedRow.Cells["endDateDataGridViewTextBoxColumn"].Value.ToString());
                decimal price = decimal.Parse(selectedRow.Cells["priceDataGridViewTextBoxColumn"].Value.ToString());
                int capacity = Convert.ToInt32(selectedRow.Cells["capacityDataGridViewTextBoxColumn"].Value);

                // Create a retreat object with the selected data
                Retreat selectedRetreat = new Retreat
                {
                    RetreatID = (int)selectedRow.Cells["retreatIDDataGridViewTextBoxColumn"].Value,
                    RetreatName = retreatName,
                    Description = description,
                    Location = location,
                    StartDate = startDate,
                    EndDate = endDate,
                    Price = price,
                    Capacity = capacity
                };

                // Open the AddRetreat form in edit mode
                using (AddRetreat editForm = new AddRetreat(selectedRetreat))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadRetreatsData(); // Refresh the grid after editing
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a retreat name to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBackToAdminDashboard_Click(object sender, EventArgs e)
        {
            // Navigate back to the Admin Dashboard
            AdminDash adminDashForm = new AdminDash(adminID); // Pass adminID
            adminDashForm.Show();
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