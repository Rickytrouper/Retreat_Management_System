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
    public partial class AddRetreat : Form
    {
        private EditRetreats.Retreat selectedRetreat;
        private EditRetreats editRetreatsForm;
        private AdminDash adminDashboard;

        public AddRetreat(AdminDash dashboard, EditRetreats editForm)
        {
            InitializeComponent();
            this.adminDashboard = dashboard;
            this.editRetreatsForm = editForm;
        }

        public AddRetreat(EditRetreats.Retreat selectedRetreat)
        {
            this.selectedRetreat = selectedRetreat;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create and populate the retreat object
            EditRetreats.Retreat newRetreat = new EditRetreats.Retreat
            {
                Name = txtRetreatName.Text,
                Location = txtLocation.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                //Description = txtDescription.Text,
                //ContactInfo = txtContactInfo.Text
                //Price = numPrice.ToString(),
                //Capacity = numCapacity.ToString(),
            };

            newRetreat.Name = txtRetreatName.Text;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtRetreatName.Text))
            {
                MessageBox.Show("Please enter a retreat name");
                return;
            }

            if (editRetreatsForm != null)
            {
                //editRetreatsForm.RetreatsList.Add(newRetreat);

                // Call the refresh method
                editRetreatsForm.RefreshDataGridView();

                MessageBox.Show("Retreat added successfully!");
            }
            this.Close();

            // Handle numeric conversions
            if (!int.TryParse(numericCapacity.Text, out int capacity))
            {
                MessageBox.Show("Please enter valid capacity");
                return;
            }
            newRetreat.Capacity = capacity;

            if (!decimal.TryParse(numericPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid price");
                return;
            }
            newRetreat.Price = price;

            // Add to DataGridView in EditRetreats form
            if (editRetreatsForm != null)
            {
                // Add to the data source
                editRetreatsForm.RetreatsList.Add(newRetreat);

                // Refresh the DataGridView
                editRetreatsForm.RefreshDataGridView();

                // Optional: Show success message
                MessageBox.Show("Retreat added successfully!");
            }

            // Return to admin dashboard
            this.Close();
            adminDashboard?.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Return to admin dashboard without saving
            this.Close();
            adminDashboard?.Show();
        }

        private void ClearForm()
        {
            // Clear all inputs
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is NumericUpDown)
                    ((NumericUpDown)control).Value = 0;
                else if (control is DateTimePicker)
                    ((DateTimePicker)control).Value = DateTime.Now;
            }
        }

        // TextBox event handlers
        private void txtRetreatName_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
            // Consider renaming textBox2 to something meaningful
        }

        // Label click handlers (usually not needed, can be empty)
        private void lbRetreatName_Click(object sender, EventArgs e)
        {
            // Typically labels don't need click handlers
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Typically labels don't need click handlers
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Typically labels don't need click handlers
        }

        // Button click handler
        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select Retreat Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                // Handle the selected image file
            }
        }
    }
}