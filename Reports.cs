using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Retreat_Management_System;
using Retreat_Management_System.Retreat_Management_DBreportsDataSetTableAdapters;
using System.Data.Entity.Validation;

namespace Retreat_Management_System
{
    public partial class Reports : Form
    {
        private Retreat_Management_DBEntities dbContext;
        
        public Reports()
        {
            InitializeComponent();
            dbContext = new Retreat_Management_DBEntities();
            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            cbReportType.Items.Clear();
            cbReportType.Items.Add("Booking Report");
            cbReportType.Items.Add("Feedback Report");
            cbReportType.Items.Add("Financial Report");
            cbReportType.Items.Add("User Report");
            cbReportType.Items.Add("Retreat Report");
            cbReportType.SelectedIndex = 0; // Default to the first type
        }

        private void Reports_Load_1(object sender, EventArgs e)
        {
            LoadReportTypes();
        }

        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            if (cbReportType.SelectedItem != null)
            {
                string selectedReportType = cbReportType.SelectedItem.ToString();
                GenerateReport(selectedReportType);
            }
            else
            {
                MessageBox.Show("Please select a report type.");
            }
        }

        private void GenerateReport(string reportType)
        {
            try
            {
                switch (reportType)
                {
                    case "Booking Report":
                        GenerateBookingReport();
                        break;
                    case "Feedback Report":
                        GenerateFeedbackReport();
                        break;
                    case "Financial Report":
                        GenerateFinancialReport();
                        break;
                    case "User Report":
                        GenerateUserReport();
                        break;
                    case "Retreat Report":
                        GenerateRetreatReport();
                        break;
                    default:
                        MessageBox.Show("Invalid report type selected.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateBookingReport()
        {
            try
            {
                var bookings = dbContext.Bookings
                    .Include(b => b.User)
                    .Include(b => b.Retreat)
                    .Where(b => b.BookingDate >= dateTimePickerStartDate.Value && b.BookingDate <= dateTimePickerEndDate.Value)
                    .ToList();

                DataTable bookingTable = new DataTable();
                bookingTable.Columns.Add("Booking ID");
                bookingTable.Columns.Add("User Name");
                bookingTable.Columns.Add("Retreat Name");
                bookingTable.Columns.Add("Booking Date");

                foreach (var booking in bookings)
                {
                    bookingTable.Rows.Add(booking.BookingID, booking.User.Username, booking.Retreat.RetreatName, booking.BookingDate);
                }

                if (bookings.Any())
                {
                    bookingBindingSource.DataSource = bookingTable;

                    dgvReport.DataSource = bookingBindingSource;
                    dgvReport.Columns["Booking ID"].HeaderText = "Booking ID";
                    dgvReport.Columns["User Name"].HeaderText = "User Name";
                    dgvReport.Columns["Retreat Name"].HeaderText = "Retreat Name";
                    dgvReport.Columns["Booking Date"].HeaderText = "Booking Date";
                    dgvReport.Columns["Booking Date"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format the date column
                    dgvReport.Columns["Booking Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align the date column
                    dgvReport.Columns["User Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the User Name column
                    dgvReport.Columns["Retreat Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Retreat Name column
                    dgvReport.Columns["Booking ID"].Width = 100; // Set width for Booking ID column
                    dgvReport.Columns["Booking Date"].Width = 120; // Set width for Booking Date column
                    dgvReport.Columns["User Name"].Width = 150; // Set width for User Name column
                    dgvReport.Columns["Retreat Name"].Width = 150; // Set width for Retreat Name column
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto size all columns
                    dgvReport.AllowUserToResizeColumns = true; // Allow user to resize columns



                }
                else
                {
                    MessageBox.Show("No bookings found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show($"Validation error: {ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating booking report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void GenerateFeedbackReport()
        {
            try
            {
                var feedbacks = dbContext.Feedbacks
                    .Include(f => f.User)
                    .Include(f => f.Retreat)
                    .Where(f => f.DateSubmitted >= dateTimePickerStartDate.Value && f.DateSubmitted <= dateTimePickerEndDate.Value)
                    .ToList();

                DataTable feedbackTable = new DataTable();
                feedbackTable.Columns.Add("Feedback ID");
                feedbackTable.Columns.Add("User Name");
                feedbackTable.Columns.Add("Retreat Name");
                feedbackTable.Columns.Add("Feedback Date");

                foreach (var feedback in feedbacks)
                {
                    feedbackTable.Rows.Add(feedback.FeedbackID, feedback.User.Username, feedback.Retreat.RetreatName, feedback.DateSubmitted);
                }

                if (feedbacks.Any())
                {
                    feedbackBindingSource.DataSource = feedbackTable;
                    dgvReport.DataSource = feedbackBindingSource;
                    dgvReport.Columns["Feedback ID"].HeaderText = "Feedback ID";
                    dgvReport.Columns["User Name"].HeaderText = "User Name";
                    dgvReport.Columns["Retreat Name"].HeaderText = "Retreat Name";
                    dgvReport.Columns["Feedback Date"].HeaderText = "Feedback Date";
                    dgvReport.Columns["Feedback Date"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format the date column
                    dgvReport.Columns["Feedback Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align the date column
                    dgvReport.Columns["User Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the User Name column
                    dgvReport.Columns["Retreat Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Retreat Name column
                    dgvReport.Columns["Feedback ID"].Width = 100; // Set width for Feedback ID column
                    dgvReport.Columns["Feedback Date"].Width = 120; // Set width for Feedback Date column
                    dgvReport.Columns["User Name"].Width = 150; // Set width for User Name column
                    dgvReport.Columns["Retreat Name"].Width = 150; // Set width for Retreat Name column
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto size all columns
                    dgvReport.AllowUserToResizeColumns = true; // Allow user to resize columns

                }
                else
                {
                    MessageBox.Show("No feedback entries found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show($"Validation error: {ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating feedback report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateFinancialReport()
        {
            try
            {
                var payments = dbContext.Payments
                    .Where(p => p.PaymentDate >= dateTimePickerStartDate.Value && p.PaymentDate <= dateTimePickerEndDate.Value)
                    .ToList();

                DataTable paymentTable = new DataTable();
                paymentTable.Columns.Add("Payment ID");
                paymentTable.Columns.Add("Booking ID");
                paymentTable.Columns.Add("Amount");
                paymentTable.Columns.Add("Payment Date");

                foreach (var payment in payments)
                {
                    paymentTable.Rows.Add(payment.PaymentID, payment.BookingID, payment.Amount, payment.PaymentDate);
                }

                if (payments.Any())
                {
                    paymentBindingSource.DataSource = paymentTable;
                    dgvReport.DataSource = paymentBindingSource;
                    dgvReport.Columns["Payment ID"].HeaderText = "Payment ID";
                    dgvReport.Columns["Booking ID"].HeaderText = "Booking ID";
                    dgvReport.Columns["Amount"].HeaderText = "Amount";
                    dgvReport.Columns["Payment Date"].HeaderText = "Payment Date";
                    dgvReport.Columns["Payment Date"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format the date column
                    dgvReport.Columns["Payment Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align the date column
                    dgvReport.Columns["Booking ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Booking ID column
                    dgvReport.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Amount column
                    dgvReport.Columns["Payment ID"].Width = 100; // Set width for Payment ID column
                    dgvReport.Columns["Payment Date"].Width = 120; // Set width for Payment Date column
                    dgvReport.Columns["Booking ID"].Width = 150; // Set width for Booking ID column
                    dgvReport.Columns["Amount"].Width = 150; // Set width for Amount column
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto size all columns
                    dgvReport.AllowUserToResizeColumns = true; // Allow user to resize columns

                }
                else
                {
                    MessageBox.Show("No financial entries found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show($"Validation error: {ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating financial report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateUserReport()
        {

            try
            {
                var users = dbContext.Users
                .Where(u => u.DateCreated >= dateTimePickerStartDate.Value && u.DateCreated <= dateTimePickerEndDate.Value).ToList();
                DataTable userTable = new DataTable();
                userTable.Columns.Add("User ID");
                userTable.Columns.Add("Username");
                userTable.Columns.Add("Email");
                userTable.Columns.Add("Date Created");
                userTable.Columns.Add("Role");

                foreach (var user in users)
                {
                    userTable.Rows.Add(user.UserID, user.Username, user.Email, user.DateCreated, user.Role);
                }

                if (users.Any())
                {
                    userBindingSource.DataSource = userTable;
                    dgvReport.DataSource = userBindingSource;
                    dgvReport.Columns["User ID"].HeaderText = "User ID";
                    dgvReport.Columns["Username"].HeaderText = "Username";
                    dgvReport.Columns["Email"].HeaderText = "Email";
                    dgvReport.Columns["Date Created"].HeaderText = "Date Created";
                    dgvReport.Columns["Role"].HeaderText = "Role";
                    dgvReport.Columns["Date Created"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format the date column
                    dgvReport.Columns["Date Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align the date column
                    dgvReport.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Username column
                    dgvReport.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Email column
                    dgvReport.Columns["User ID"].Width = 100; // Set width for User ID column
                    dgvReport.Columns["Date Created"].Width = 120; // Set width for Date Created column
                    dgvReport.Columns["Username"].Width = 150; // Set width for Username column
                    dgvReport.Columns["Email"].Width = 150; // Set width for Email column
                    dgvReport.Columns["Role"].Width = 100; // Set width for Role column
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto size all columns
                    dgvReport.AllowUserToResizeColumns = true; // Allow user to resize columns
                }
                else
                {
                    MessageBox.Show("No users found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show($"Validation error: {ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating user report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateRetreatReport()
        {
            try
            {
                var retreats = dbContext.Retreats
                    .Where(r => r.StartDate >= dateTimePickerStartDate.Value && r.EndDate <= dateTimePickerEndDate.Value).ToList();
                DataTable retreatTable = new DataTable();
                retreatTable.Columns.Add("Retreat ID");
                retreatTable.Columns.Add("Retreat Name");
                retreatTable.Columns.Add("Location");
                retreatTable.Columns.Add("Start Date");
                retreatTable.Columns.Add("End Date");

                foreach (var retreat in retreats)
                {
                    retreatTable.Rows.Add(retreat.RetreatID, retreat.RetreatName, retreat.Location, retreat.StartDate, retreat.EndDate);
                }

                if (retreats.Any())
                {
                    retreatBindingSource.DataSource = retreatTable;
                    dgvReport.DataSource = retreatBindingSource;
                    dgvReport.Columns["Retreat ID"].HeaderText = "Retreat ID";
                    dgvReport.Columns["Retreat Name"].HeaderText = "Retreat Name";
                    dgvReport.Columns["Location"].HeaderText = "Location";
                    dgvReport.Columns["Start Date"].HeaderText = "Start Date";
                    dgvReport.Columns["End Date"].HeaderText = "End Date";
                    dgvReport.Columns["Start Date"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format the date column
                    dgvReport.Columns["Start Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align the date column
                    dgvReport.Columns["End Date"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format the date column
                    dgvReport.Columns["End Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align the date column
                    dgvReport.Columns["Retreat Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Retreat Name column
                    dgvReport.Columns["Location"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Auto size the Location column
                    dgvReport.Columns["Retreat ID"].Width = 100; // Set width for Retreat ID column
                    dgvReport.Columns["Start Date"].Width = 120; // Set width for Start Date column
                    dgvReport.Columns["Retreat Name"].Width = 150; // Set width for Retreat Name column
                    dgvReport.Columns["Location"].Width = 150; // Set width for Location column
                    dgvReport.Columns["End Date"].Width = 120; // Set width for End Date column
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto size all columns
                    dgvReport.AllowUserToResizeColumns = true; // Allow user to resize columns

                }
                else
                {
                    MessageBox.Show("No retreats found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show($"Validation error: {ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating retreat report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
            this.Hide();
        }

             
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Export the report to a file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Excel files (*.xlsx)|*.xlsx|Word files (*.docx)|*.docx";
            saveFileDialog.Title = "Save Report";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // similate exporting file 
                string filePath = saveFileDialog.FileName;
                string fileExtension = System.IO.Path.GetExtension(filePath);

                MessageBox.Show("Report exported successfully!");
                
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            // Clear the form
            cbReportType.SelectedIndex = -1; // Clear the selected report type
            dateTimePickerStartDate.Value = DateTime.Now; // Reset start date to current date
            dateTimePickerEndDate.Value = DateTime.Now; // Reset end date to current date
            dgvReport.DataSource = null; // Clear the DataGridView
        }

        
    }
}