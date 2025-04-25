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
    public partial class EditRetreats: Form
    {
        private AdminDash adminDash;

        public EditRetreats()
        {
            InitializeComponent();
        }

        public EditRetreats(AdminDash adminDash)
        {
            this.adminDash = adminDash;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadRetreatsData()
        {
            // In a real application, this would load data from a database
            // Here we're just adding sample data for demonstration

            // Clear existing data
            dataGridViewRetreats.Rows.Clear();

            // Add sample retreats
            dataGridViewRetreats.Rows.Add(
                "Yoga Retreat",
                "Santorini, Greece",
                DateTime.Now.AddDays(30),
                DateTime.Now.AddDays(37),
                1200m,
                20
            );

            dataGridViewRetreats.Rows.Add(
                "Meditation Retreat",
                "Ocho Rios, Jamaica",
                DateTime.Now.AddDays(45),
                DateTime.Now.AddDays(52),
                950m,
                15
            );

            dataGridViewRetreats.Rows.Add(
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
            if (dataGridViewRetreats.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a retreat to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewRetreats.SelectedRows[0];

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
            if (dataGridViewRetreats.SelectedRows.Count == 0)
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
                    dataGridViewRetreats.Rows.RemoveAt(dataGridViewRetreats.SelectedRows[0].Index);

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
            // Show the admin dashboard form
            
            AdminDash adminDashForm = new AdminDash();
            adminDashForm.Show(); // Show the form

            // Close this form
            this.Close();
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

