namespace Retreat_Management_System
{
    partial class UserDash
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
            this.menuStripUserDash = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWelcomeMessage = new System.Windows.Forms.Label();
            this.groupUserInformation = new System.Windows.Forms.GroupBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.lbContactInfo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lnUserName = new System.Windows.Forms.Label();
            this.picbxProfile = new System.Windows.Forms.PictureBox();
            this.groupBoxUserAction = new System.Windows.Forms.GroupBox();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.lbMakeReservation = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.retreatManagementDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreat_Management_DBDataSet2 = new Retreat_Management_System.Retreat_Management_DBDataSet2();
            this.reservationDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationDataTableAdapter = new Retreat_Management_System.Retreat_Management_DBDataSet2TableAdapters.ReservationDataTableAdapter();
            this.lbReservationDetails = new System.Windows.Forms.Label();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.lbProfilePic = new System.Windows.Forms.Label();
            this.menuStripUserDash.SuspendLayout();
            this.groupUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfile)).BeginInit();
            this.groupBoxUserAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatManagementDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripUserDash
            // 
            this.menuStripUserDash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemHelp});
            this.menuStripUserDash.Location = new System.Drawing.Point(0, 0);
            this.menuStripUserDash.Name = "menuStripUserDash";
            this.menuStripUserDash.Size = new System.Drawing.Size(856, 24);
            this.menuStripUserDash.TabIndex = 0;
            this.menuStripUserDash.Text = "Menu";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogout,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(180, 22);
            this.menuItemLogout.Text = "Logout";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemExit.Text = "Exit";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.menuItemAbout.Text = "About";
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.AutoSize = true;
            this.lbWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeMessage.Location = new System.Drawing.Point(306, 41);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(217, 25);
            this.lbWelcomeMessage.TabIndex = 1;
            this.lbWelcomeMessage.Text = "Welcome  Message";
            // 
            // groupUserInformation
            // 
            this.groupUserInformation.Controls.Add(this.btnCancel);
            this.groupUserInformation.Controls.Add(this.btnSaveProfile);
            this.groupUserInformation.Controls.Add(this.btnEditProfile);
            this.groupUserInformation.Controls.Add(this.txtContactNum);
            this.groupUserInformation.Controls.Add(this.lbContactInfo);
            this.groupUserInformation.Controls.Add(this.txtEmail);
            this.groupUserInformation.Controls.Add(this.lbEmail);
            this.groupUserInformation.Controls.Add(this.txtUserName);
            this.groupUserInformation.Controls.Add(this.lnUserName);
            this.groupUserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUserInformation.Location = new System.Drawing.Point(22, 83);
            this.groupUserInformation.Name = "groupUserInformation";
            this.groupUserInformation.Size = new System.Drawing.Size(428, 211);
            this.groupUserInformation.TabIndex = 2;
            this.groupUserInformation.TabStop = false;
            this.groupUserInformation.Text = "User Information / Edit Profile";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(304, 34);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(83, 23);
            this.btnEditProfile.TabIndex = 6;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(117, 123);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.ReadOnly = true;
            this.txtContactNum.Size = new System.Drawing.Size(152, 20);
            this.txtContactNum.TabIndex = 5;
            // 
            // lbContactInfo
            // 
            this.lbContactInfo.AutoSize = true;
            this.lbContactInfo.Location = new System.Drawing.Point(11, 130);
            this.lbContactInfo.Name = "lbContactInfo";
            this.lbContactInfo.Size = new System.Drawing.Size(106, 13);
            this.lbContactInfo.TabIndex = 4;
            this.lbContactInfo.Text = "Contact Number :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(11, 95);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(152, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lnUserName
            // 
            this.lnUserName.AutoSize = true;
            this.lnUserName.Location = new System.Drawing.Point(11, 51);
            this.lnUserName.Name = "lnUserName";
            this.lnUserName.Size = new System.Drawing.Size(71, 13);
            this.lnUserName.TabIndex = 0;
            this.lnUserName.Text = "Username :";
            // 
            // picbxProfile
            // 
            this.picbxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxProfile.Location = new System.Drawing.Point(521, 83);
            this.picbxProfile.Name = "picbxProfile";
            this.picbxProfile.Size = new System.Drawing.Size(100, 100);
            this.picbxProfile.TabIndex = 3;
            this.picbxProfile.TabStop = false;
            this.picbxProfile.Click += new System.EventHandler(this.picbxProfile_Click);
            // 
            // groupBoxUserAction
            // 
            this.groupBoxUserAction.Controls.Add(this.btnViewReservation);
            this.groupBoxUserAction.Controls.Add(this.label1);
            this.groupBoxUserAction.Controls.Add(this.btnMakeReservation);
            this.groupBoxUserAction.Controls.Add(this.lbMakeReservation);
            this.groupBoxUserAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserAction.Location = new System.Drawing.Point(521, 196);
            this.groupBoxUserAction.Name = "groupBoxUserAction";
            this.groupBoxUserAction.Size = new System.Drawing.Size(300, 98);
            this.groupBoxUserAction.TabIndex = 4;
            this.groupBoxUserAction.TabStop = false;
            this.groupBoxUserAction.Text = "User Actions";
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Location = new System.Drawing.Point(169, 56);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(106, 23);
            this.btnViewReservation.TabIndex = 3;
            this.btnViewReservation.Text = "View Reservation";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Reserveration";
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(17, 56);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(106, 23);
            this.btnMakeReservation.TabIndex = 1;
            this.btnMakeReservation.Text = "Book Now";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            // 
            // lbMakeReservation
            // 
            this.lbMakeReservation.AutoSize = true;
            this.lbMakeReservation.Location = new System.Drawing.Point(14, 29);
            this.lbMakeReservation.Name = "lbMakeReservation";
            this.lbMakeReservation.Size = new System.Drawing.Size(121, 13);
            this.lbMakeReservation.TabIndex = 0;
            this.lbMakeReservation.Text = "Make Reserveration";
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToOrderColumns = true;
            this.dataGridViewReservations.AutoGenerateColumns = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.retreatNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridViewReservations.DataSource = this.reservationDataTableBindingSource;
            this.dataGridViewReservations.Location = new System.Drawing.Point(22, 325);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.Size = new System.Drawing.Size(834, 150);
            this.dataGridViewReservations.TabIndex = 5;
            // 
            // retreatManagementDBDataSet2BindingSource
            // 
            this.retreatManagementDBDataSet2BindingSource.DataSource = this.retreat_Management_DBDataSet2;
            this.retreatManagementDBDataSet2BindingSource.Position = 0;
            // 
            // retreat_Management_DBDataSet2
            // 
            this.retreat_Management_DBDataSet2.DataSetName = "Retreat_Management_DBDataSet2";
            this.retreat_Management_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationDataTableBindingSource
            // 
            this.reservationDataTableBindingSource.DataMember = "ReservationDataTable";
            this.reservationDataTableBindingSource.DataSource = this.retreatManagementDBDataSet2BindingSource;
            // 
            // reservationDataTableAdapter
            // 
            this.reservationDataTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // retreatNameDataGridViewTextBoxColumn
            // 
            this.retreatNameDataGridViewTextBoxColumn.DataPropertyName = "RetreatName";
            this.retreatNameDataGridViewTextBoxColumn.HeaderText = "RetreatName";
            this.retreatNameDataGridViewTextBoxColumn.Name = "retreatNameDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(304, 83);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(86, 23);
            this.btnSaveProfile.TabIndex = 7;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePic.Location = new System.Drawing.Point(730, 170);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 7;
            this.btnUpdatePic.Text = "Update";
            this.btnUpdatePic.UseVisualStyleBackColor = true;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // lbProfilePic
            // 
            this.lbProfilePic.AutoSize = true;
            this.lbProfilePic.Location = new System.Drawing.Point(608, 107);
            this.lbProfilePic.Name = "lbProfilePic";
            this.lbProfilePic.Size = new System.Drawing.Size(72, 13);
            this.lbProfilePic.TabIndex = 8;
            this.lbProfilePic.Text = "Profile Picture";
            // 
            // UserDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 683);
            this.Controls.Add(this.lbProfilePic);
            this.Controls.Add(this.btnUpdatePic);
            this.Controls.Add(this.lbReservationDetails);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.groupBoxUserAction);
            this.Controls.Add(this.picbxProfile);
            this.Controls.Add(this.groupUserInformation);
            this.Controls.Add(this.lbWelcomeMessage);
            this.Controls.Add(this.menuStripUserDash);
            this.MainMenuStrip = this.menuStripUserDash;
            this.Name = "UserDash";
            this.Text = "  User Dash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDash_FormClosing);
            this.Load += new System.EventHandler(this.UserDash_Load);
            this.menuStripUserDash.ResumeLayout(false);
            this.menuStripUserDash.PerformLayout();
            this.groupUserInformation.ResumeLayout(false);
            this.groupUserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfile)).EndInit();
            this.groupBoxUserAction.ResumeLayout(false);
            this.groupBoxUserAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatManagementDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUserDash;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.Label lbWelcomeMessage;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.GroupBox groupUserInformation;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lnUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label lbContactInfo;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.PictureBox picbxProfile;
        private System.Windows.Forms.GroupBox groupBoxUserAction;
        private System.Windows.Forms.Label lbMakeReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.BindingSource retreatManagementDBDataSet2BindingSource;
        private Retreat_Management_DBDataSet2 retreat_Management_DBDataSet2;
        private System.Windows.Forms.BindingSource reservationDataTableBindingSource;
        private Retreat_Management_DBDataSet2TableAdapters.ReservationDataTableAdapter reservationDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retreatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbReservationDetails;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Label lbProfilePic;
    }
}