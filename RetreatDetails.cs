using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Retreat_Management_System
{



    public partial class RetreatDetails : Form
    {



        private readonly Retreat_Management_DBEntities retreatManagementEntities;





        public RetreatDetails()
        {
            InitializeComponent();
            this.Load += RetreatDetails_Load;
            cbRetreatName.SelectedIndexChanged += cbRetreatName_SelectedIndexChanged;
            retreatManagementEntities = new Retreat_Management_DBEntities();
        }

        private void RetreatDetails_Load(object sender, EventArgs e)
        {
            var Retreat = retreatManagementEntities.Retreats.ToList();
            cbRetreatName.DisplayMember = "RetreatName";
            cbRetreatName.ValueMember = "ID";
            cbRetreatName.DataSource = Retreat;
        }

        /*private void RetreatDetails_Load(object sender, EventArgs e)
        {
            try
            {
                var retreats = retreatManagementEntities.Retreats.ToList();



                cbRetreatName.DisplayMember = "RetreatName";
                cbRetreatName.ValueMember = "Id";
                cbRetreatName.DataSource = retreats;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading retreat list: " + ex.Message);
            }
        }*/


        private void cbRetreatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (cbRetreatName.SelectedItem != null)
            {
                // Get the selected retreat object from the ComboBox
                var selectedRetreat = cbRetreatName.SelectedItem as Retreat;

                if (selectedRetreat != null)
                {
                    // Populate the text fields with the retreat details
                    txtDescription.Text = selectedRetreat.Description ?? "N/A";
                    txtLocation.Text = selectedRetreat.Location ?? "N/A";
                    txtRetreatDates.Text = $"{selectedRetreat.StartDate:MM/dd/yyyy} to {selectedRetreat.EndDate:MM/dd/yyyy}";
                    txtRetreatPrice.Text = selectedRetreat.Price.ToString("C");
                }
                else
                {
                    MessageBox.Show("Selected retreat is invalid.");
                }
            }
            else
            {
                // Handle the case when nothing is selected
                MessageBox.Show("Please select a retreat.");
            }
        }





        /*private void btnBookNow_Click(object sender, EventArgs e)
        {
            var selectedRetreat = cbRetreatName.SelectedItem as Retreat;



            if (selectedRetreat != null)
            {
                BookingPage bookingPage = new BookingPage();
                bookingPage.SetRetreatName(selectedRetreat.RetreatName);
                bookingPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a retreat first.");
            }
        }*/
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            var selectedRetreat = cbRetreatName.SelectedItem as Retreat;

            if (selectedRetreat != null)
            {
                BookingPage bookingPage = new BookingPage();
                bookingPage.SetRetreatName(selectedRetreat.RetreatName);  // Set the retreat name on the booking page
                bookingPage.Show();  // Show the booking page
                this.Hide();  // Hide the current form
            }
            else
            {
                MessageBox.Show("Please select a retreat first.");
            }
        }



    }



}