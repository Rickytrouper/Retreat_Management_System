namespace Retreat_Management_System
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbPageLable = new System.Windows.Forms.Label();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.lbReportType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.retreatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreatManagementDBreportsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreat_Management_DBreportsDataSet = new Retreat_Management_System.Retreat_Management_DBreportsDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new Retreat_Management_System.Retreat_Management_DBreportsDataSetTableAdapters.BookingTableAdapter();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter = new Retreat_Management_System.Retreat_Management_DBreportsDataSetTableAdapters.FeedbackTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Retreat_Management_System.Retreat_Management_DBreportsDataSetTableAdapters.PaymentTableAdapter();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Retreat_Management_System.Retreat_Management_DBreportsDataSetTableAdapters.UserTableAdapter();
            this.retreatTableAdapter = new Retreat_Management_System.Retreat_Management_DBreportsDataSetTableAdapters.RetreatTableAdapter();
            this.groupBoxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatManagementDBreportsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DBreportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPageLable
            // 
            this.lbPageLable.AutoSize = true;
            this.lbPageLable.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLable.Location = new System.Drawing.Point(417, 51);
            this.lbPageLable.Name = "lbPageLable";
            this.lbPageLable.Size = new System.Drawing.Size(113, 32);
            this.lbPageLable.TabIndex = 0;
            this.lbPageLable.Text = "Reports";
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.lbEndDate);
            this.groupBoxReport.Controls.Add(this.lbStartDate);
            this.groupBoxReport.Controls.Add(this.btnCancel);
            this.groupBoxReport.Controls.Add(this.btnGenerateReport);
            this.groupBoxReport.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxReport.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxReport.Controls.Add(this.cbReportType);
            this.groupBoxReport.Controls.Add(this.lbReportType);
            this.groupBoxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReport.Location = new System.Drawing.Point(67, 104);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(463, 220);
            this.groupBoxReport.TabIndex = 1;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Report Management";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(14, 110);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(79, 16);
            this.lbEndDate.TabIndex = 7;
            this.lbEndDate.Text = "End Date :";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(14, 68);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(84, 16);
            this.lbStartDate.TabIndex = 6;
            this.lbStartDate.Text = "Start Date :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(352, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(6, 155);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(146, 33);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click_1);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(248, 104);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(248, 62);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // cbReportType
            // 
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(248, 23);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(200, 24);
            this.cbReportType.TabIndex = 1;
            // 
            // lbReportType
            // 
            this.lbReportType.AutoSize = true;
            this.lbReportType.Location = new System.Drawing.Point(14, 31);
            this.lbReportType.Name = "lbReportType";
            this.lbReportType.Size = new System.Drawing.Size(102, 16);
            this.lbReportType.TabIndex = 0;
            this.lbReportType.Text = "Report Type :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(67, 616);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(810, 577);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 33);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export to file";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(67, 357);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(832, 214);
            this.dgvReport.TabIndex = 9;
            // 
            // retreatBindingSource
            // 
            this.retreatBindingSource.DataMember = "Retreat";
            this.retreatBindingSource.DataSource = this.retreatManagementDBreportsDataSetBindingSource;
            // 
            // retreatManagementDBreportsDataSetBindingSource
            // 
            this.retreatManagementDBreportsDataSetBindingSource.DataSource = this.retreat_Management_DBreportsDataSet;
            this.retreatManagementDBreportsDataSetBindingSource.Position = 0;
            // 
            // retreat_Management_DBreportsDataSet
            // 
            this.retreat_Management_DBreportsDataSet.DataSetName = "Retreat_Management_DBreportsDataSet";
            this.retreat_Management_DBreportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Report Table";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.retreatManagementDBreportsDataSetBindingSource;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "Feedback";
            this.feedbackBindingSource.DataSource = this.retreatManagementDBreportsDataSetBindingSource;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.retreatManagementDBreportsDataSetBindingSource;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.retreatManagementDBreportsDataSetBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.retreatManagementDBreportsDataSetBindingSource;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // retreatTableAdapter
            // 
            this.retreatTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxReport);
            this.Controls.Add(this.lbPageLable);
            this.Name = "Reports";
            this.Text = "Reports";
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatManagementDBreportsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DBreportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPageLable;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label lbReportType;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource retreatManagementDBreportsDataSetBindingSource;
        private Retreat_Management_DBreportsDataSet retreat_Management_DBreportsDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private Retreat_Management_DBreportsDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private Retreat_Management_DBreportsDataSetTableAdapters.FeedbackTableAdapter feedbackTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Retreat_Management_DBreportsDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Retreat_Management_DBreportsDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource retreatBindingSource;
        private Retreat_Management_DBreportsDataSetTableAdapters.RetreatTableAdapter retreatTableAdapter;
    }
}