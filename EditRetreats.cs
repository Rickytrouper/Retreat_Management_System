using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class EditRetreats : Form
    {
        private AdminDash adminDash;

        // Default constructor
        public EditRetreats()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            LoadRetreatsData();
        }

        // Constructor with AdminDash reference
        public EditRetreats(AdminDash adminDash) : this() // Calls the default constructor first
        {
            this.adminDash = adminDash;
        }

        public List<Retreat> RetreatsList { get; set; } = new List<Retreat>();

        
        private void EditRetreats_Load(object sender, EventArgs e)
        {
            LoadRetreatsData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your event handling code here
            // If you don't need any special handling, you can leave it empty
        }

        //public List<Retreat> RetreatsList { get; set; } = new List<Retreat>();

        // Add this method to refresh your DataGridView
         public void RefreshDataGridView()
         {
             // Make sure your DataGridView is named dataGridView1
             dataGridView1.DataSource = null;
             dataGridView1.DataSource = RetreatsList;
             //dataGridView1.AutoResizeColumns(); // Optional: Adjust column widths
         }

        private void SetupDataGridViewColumns()
        {
            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Add columns with proper names that match your code
            dataGridView1.Columns.Add("RetreatName", "Retreat Name");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("StartDate", "Start Date");
            dataGridView1.Columns.Add("EndDate", "End Date");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Capacity", "Capacity");

            // Format date columns
            dataGridView1.Columns["StartDate"].DefaultCellStyle.Format = "d";
            dataGridView1.Columns["EndDate"].DefaultCellStyle.Format = "d";

            // Format price column as currency
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
        }

        private void LoadRetreatsData()
        {
            // Clear existing data
            dataGridView1.Rows.Clear();

            // Add sample retreats
            dataGridView1.Rows.Add(
                "Yoga Retreat",
                "Santorini, Greece",
                DateTime.Now.AddDays(30),
                DateTime.Now.AddDays(37),
                1200m,
                20
            );

            dataGridView1.Rows.Add(
                "Meditation Retreat",
                "Ocho Rios, Jamaica",
                DateTime.Now.AddDays(45),
                DateTime.Now.AddDays(52),
                950m,
                15
            );

            dataGridView1.Rows.Add(
                "Wellness Retreat",
                "Portland, Jamaica",
                DateTime.Now.AddDays(60),
                DateTime.Now.AddDays(67),
                1500m,
                25
            );
        }

        private void BtnEditSelectedRetreat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a retreat to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Create a retreat object with the selected data
            Retreat selectedRetreat = new Retreat
            {
                Name = selectedRow.Cells["RetreatName"].Value.ToString(),
                Location = selectedRow.Cells["Location"].Value.ToString(),
                StartDate = (DateTime)selectedRow.Cells["StartDate"].Value,
                EndDate = (DateTime)selectedRow.Cells["EndDate"].Value,
                Price = (decimal)selectedRow.Cells["Price"].Value,
                Capacity = Convert.ToInt32(selectedRow.Cells["Capacity"].Value)
            };

            // Open the AddRetreat form in edit mode
            AddRetreat editForm = new AddRetreat(selectedRetreat);
            editForm.ShowDialog();

            // Refresh data after editing
            if (editForm.DialogResult == DialogResult.OK)
            {
                LoadRetreatsData();
            }
        }

        private void BtnDeleteSelectedRetreat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a retreat to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this retreat? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // In a real application, you would delete from database here
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    MessageBox.Show("Retreat deleted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting retreat: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBackToAdminDashboard_Click(object sender, EventArgs e)
        {
            if (adminDash != null)
            {
                adminDash.Show();
            }
            this.Close();
        }

        //public List<Retreat> RetreatsList { get; set; } // If using direct list access

        // OR

        public void AddRetreatToList(Retreat retreat)
        {
            RetreatsList.Add(retreat);
            // Refresh your list display here if needed
        }

        // Retreat class to hold retreat data
        public class Retreat
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public decimal Price { get; set; }
            public int Capacity { get; set; }
        }
    }
}

