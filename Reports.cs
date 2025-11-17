using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Retreat_Management_System
{
    public partial class Reports : Form
    {
        private Retreat_Management_DBEntities dbContext;
        private int currentAdminID;
        private AdminActionService adminActionService;

        // Constructor that accepts adminID
        public Reports(int adminID)
        {
            InitializeComponent();
            dbContext = new Retreat_Management_DBEntities();
            currentAdminID = adminID; // Set the admin ID
            adminActionService = new AdminActionService(); // Initialize the service
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

        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        { // Check if a report type is selected
            if (cbReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the start date is later than the end date
            if (dateTimePickerStartDate.Value > dateTimePickerEndDate.Value)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed to generate the report
            string selectedReportType = cbReportType.SelectedItem.ToString();
            GenerateReport(selectedReportType);
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
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"Argument error: {argEx.Message}", "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateBookingReport()
        {
            try
            {
                // Validate the date range
                if (dateTimePickerStartDate.Value > dateTimePickerEndDate.Value)
                {
                    throw new ArgumentException("Start date cannot be later than end date.");
                }

                // Fetch bookings within the specified date range
                var bookings = dbContext.Bookings
                    .Include(b => b.User)
                    .Include(b => b.Retreat)
                    .Where(b => b.BookingDate >= dateTimePickerStartDate.Value && b.BookingDate <= dateTimePickerEndDate.Value)
                    .Select(b => new
                    {
                        b.BookingDate,
                        b.Status,
                        UserName = b.User.Username,
                        Email = b.User.Email,
                        b.CardNumber,
                        b.ExpiryDate,
                        b.CVV,
                        b.PaymentStatus
                    })
                    .ToList();

                // Check if any bookings were found
                if (!bookings.Any())
                {
                    MessageBox.Show("No bookings found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create a DataTable to hold booking data
                DataTable bookingTable = new DataTable();
                bookingTable.Columns.Add("Booking Date", typeof(DateTime));
                bookingTable.Columns.Add("Status", typeof(string));
                bookingTable.Columns.Add("User Name", typeof(string));
                bookingTable.Columns.Add("Email", typeof(string));
                bookingTable.Columns.Add("Card Number", typeof(string));
                bookingTable.Columns.Add("Expiry Date", typeof(DateTime));
                bookingTable.Columns.Add("CVV", typeof(string));
                bookingTable.Columns.Add("Payment Status", typeof(string));

                // Populate the DataTable with booking information
                foreach (var booking in bookings)
                {
                    // Format Card Number to show only the first 4 and last 4 digits
                    string formattedCardNumber = FormatCardNumber(booking.CardNumber);

                    bookingTable.Rows.Add(
                        booking.BookingDate,
                        booking.Status,
                        booking.UserName,
                        booking.Email,
                        formattedCardNumber, // Use the formatted card number
                        booking.ExpiryDate,
                        booking.CVV,
                        booking.PaymentStatus
                    );
                }

                // Bind the DataTable to the BindingSource
                var bookingBindingSource = new BindingSource();
                bookingBindingSource.DataSource = bookingTable;

                // Set the DataSource of the DataGridView to the BindingSource
                dgvReport.DataSource = bookingBindingSource;

                // Set column headers and formatting
                dgvReport.Columns["Booking Date"].HeaderText = "Booking Date";
                dgvReport.Columns["Status"].HeaderText = "Status";
                dgvReport.Columns["User Name"].HeaderText = "User Name";
                dgvReport.Columns["Email"].HeaderText = "Email";
                dgvReport.Columns["Card Number"].HeaderText = "Card Number";
                dgvReport.Columns["Expiry Date"].HeaderText = "Expiry Date";
                dgvReport.Columns["CVV"].HeaderText = "CVV";
                dgvReport.Columns["Payment Status"].HeaderText = "Payment Status";

                // Format the columns as necessary
                dgvReport.Columns["Booking Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvReport.Columns["Expiry Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvReport.Columns["Booking Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReport.Columns["Expiry Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Set auto-sizing and widths for columns
                dgvReport.Columns["User Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReport.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReport.Columns["Card Number"].Width = 120;
                dgvReport.Columns["Payment Status"].Width = 120;

                // Enable column resizing
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReport.AllowUserToResizeColumns = true;
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show($"Validation error: {ex.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"Argument error: {argEx.Message}", "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating booking report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to format the card number
        private string FormatCardNumber(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length < 8)
            {
                return cardNumber; // Return as is if not valid
            }

            return cardNumber.Substring(0, 4) + "-****-****-" + cardNumber.Substring(cardNumber.Length - 4, 4);
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
                // Retrieve users based on the selected date range
                var users = dbContext.Users
                    .Where(u => u.DateCreated >= dateTimePickerStartDate.Value && u.DateCreated <= dateTimePickerEndDate.Value)
                    .ToList();

                // Create a DataTable to hold user data
                DataTable userTable = new DataTable();
                userTable.Columns.Add("User ID");
                userTable.Columns.Add("Username");
                userTable.Columns.Add("Email");
                userTable.Columns.Add("Date Created");
                userTable.Columns.Add("Role");

                // Populate the DataTable with user information
                foreach (var user in users)
                {
                    userTable.Rows.Add(user.UserID, user.Username, user.Email, user.DateCreated, user.Role);
                }

                // Check if any users were found
                if (users.Any())
                {
                    userBindingSource.DataSource = userTable;
                    dgvReport.DataSource = userBindingSource;

                    // Set column headers and formatting
                    dgvReport.Columns["User ID"].HeaderText = "User ID";
                    dgvReport.Columns["Username"].HeaderText = "Username";
                    dgvReport.Columns["Email"].HeaderText = "Email";
                    dgvReport.Columns["Date Created"].HeaderText = "Date Created";
                    dgvReport.Columns["Role"].HeaderText = "Role";

                    // Format the Date Created column
                    dgvReport.Columns["Date Created"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvReport.Columns["Date Created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Set auto-sizing and widths for columns
                    dgvReport.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns["User ID"].Width = 100;
                    dgvReport.Columns["Date Created"].Width = 120;
                    dgvReport.Columns["Username"].Width = 150;
                    dgvReport.Columns["Email"].Width = 150;
                    dgvReport.Columns["Role"].Width = 100;

                    // Enable column resizing
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvReport.AllowUserToResizeColumns = true;
                }
                else
                {
                    MessageBox.Show("No users found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Handle validation errors specifically
                var errorMessage = ex.EntityValidationErrors
                    .SelectMany(e => e.ValidationErrors)
                    .Select(v => v.ErrorMessage)
                    .FirstOrDefault() ?? "Validation error occurred.";

                MessageBox.Show($"Validation error: {errorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle general exceptions
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Export the report to a file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"; // Limiting to PDF for simplicity
            saveFileDialog.Title = "Save Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string selectedReportType = cbReportType.SelectedItem.ToString();

                try
                {
                    ExportToPdf(filePath, selectedReportType);
                    MessageBox.Show("Report exported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToPdf(string filePath, string reportType)
        {
            Document document = new Document();
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Add report title
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph($"{reportType} Report", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Add date range
                Font dateRangeFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                Paragraph dateRange = new Paragraph($"Date Range: {dateTimePickerStartDate.Value.ToShortDateString()} - {dateTimePickerEndDate.Value.ToShortDateString()}", dateRangeFont);
                dateRange.Alignment = Element.ALIGN_CENTER;
                document.Add(dateRange);

                // Add a blank line
                document.Add(new Paragraph(" "));

                // Create a PdfPTable from the DataGridView
                PdfPTable pdfTable = new PdfPTable(dgvReport.ColumnCount);
                pdfTable.WidthPercentage = 100;

                // Add headers
                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                foreach (DataGridViewColumn column in dgvReport.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                    pdfTable.AddCell(cell);
                }

                // Add data
                Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        object cellValue = cell.Value;
                        string cellText = cellValue != null ? cellValue.ToString() : string.Empty; // Handle null values

                        PdfPCell pdfCell = new PdfPCell(new Phrase(cellText, cellFont));
                        pdfTable.AddCell(pdfCell);
                    }
                }

                // Add the table to the document
                document.Add(pdfTable);
            }
            finally
            {
                document.Close();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            LoginPage.PerformLogout(); // Call the logout static method 
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {

        }
    }
}