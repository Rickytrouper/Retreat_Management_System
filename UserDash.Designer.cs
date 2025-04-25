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
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWelcomeMessage = new System.Windows.Forms.Label();
            this.groupUserInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
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
            this.btnViewRetreats = new System.Windows.Forms.Button();
            this.lbViewRetreats = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retreatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreatManagementDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreat_Management_DBDataSet2 = new Retreat_Management_System.Retreat_Management_DBDataSet2();
            this.reservationDataTableAdapter = new Retreat_Management_System.Retreat_Management_DBDataSet2TableAdapters.ReservationDataTableAdapter();
            this.lbReservationDetails = new System.Windows.Forms.Label();
            this.lbProfileError = new System.Windows.Forms.Label();
            this.menuStripUserDash.SuspendLayout();
            this.groupUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfile)).BeginInit();
            this.groupBoxUserAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatManagementDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripUserDash
            // 
            this.menuStripUserDash.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripUserDash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemHelp});
            this.menuStripUserDash.Location = new System.Drawing.Point(0, 0);
            this.menuStripUserDash.Name = "menuStripUserDash";
            this.menuStripUserDash.Size = new System.Drawing.Size(1259, 28);
            this.menuStripUserDash.TabIndex = 0;
            this.menuStripUserDash.Text = "Menu";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogout});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(46, 24);
            this.menuItemFile.Text = "File";
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(139, 26);
            this.menuItemLogout.Text = "Logout";
            this.menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(55, 24);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(133, 26);
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.AutoSize = true;
            this.lbWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeMessage.Location = new System.Drawing.Point(467, 62);
            this.lbWelcomeMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(331, 39);
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
            this.groupUserInformation.Location = new System.Drawing.Point(20, 155);
            this.groupUserInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupUserInformation.Name = "groupUserInformation";
            this.groupUserInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupUserInformation.Size = new System.Drawing.Size(571, 337);
            this.groupUserInformation.TabIndex = 2;
            this.groupUserInformation.TabStop = false;
            this.groupUserInformation.Text = "User Information / Edit Profile";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(405, 204);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.Location = new System.Drawing.Point(405, 135);
            this.btnSaveProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(115, 28);
            this.btnSaveProfile.TabIndex = 7;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(405, 55);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(111, 28);
            this.btnEditProfile.TabIndex = 6;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(156, 208);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.ReadOnly = true;
            this.txtContactNum.Size = new System.Drawing.Size(201, 23);
            this.txtContactNum.TabIndex = 5;
            // 
            // lbContactInfo
            // 
            this.lbContactInfo.AutoSize = true;
            this.lbContactInfo.Location = new System.Drawing.Point(15, 217);
            this.lbContactInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContactInfo.Name = "lbContactInfo";
            this.lbContactInfo.Size = new System.Drawing.Size(134, 17);
            this.lbContactInfo.TabIndex = 4;
            this.lbContactInfo.Text = "Contact Number :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(201, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(15, 148);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 17);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(156, 59);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(201, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // lnUserName
            // 
            this.lnUserName.AutoSize = true;
            this.lnUserName.Location = new System.Drawing.Point(15, 63);
            this.lnUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnUserName.Name = "lnUserName";
            this.lnUserName.Size = new System.Drawing.Size(91, 17);
            this.lnUserName.TabIndex = 0;
            this.lnUserName.Text = "Username :";
            // 
            // picbxProfile
            // 
            this.picbxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxProfile.Location = new System.Drawing.Point(743, 155);
            this.picbxProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbxProfile.Name = "picbxProfile";
            this.picbxProfile.Size = new System.Drawing.Size(100, 100);
            this.picbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbxProfile.TabIndex = 3;
            this.picbxProfile.TabStop = false;
            this.picbxProfile.Click += new System.EventHandler(this.picbxProfile_Click);
            // 
            // groupBoxUserAction
            // 
            this.groupBoxUserAction.Controls.Add(this.btnViewReservation);
            this.groupBoxUserAction.Controls.Add(this.label1);
            this.groupBoxUserAction.Controls.Add(this.btnViewRetreats);
            this.groupBoxUserAction.Controls.Add(this.lbViewRetreats);
            this.groupBoxUserAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserAction.Location = new System.Drawing.Point(743, 327);
            this.groupBoxUserAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserAction.Name = "groupBoxUserAction";
            this.groupBoxUserAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUserAction.Size = new System.Drawing.Size(440, 165);
            this.groupBoxUserAction.TabIndex = 4;
            this.groupBoxUserAction.TabStop = false;
            this.groupBoxUserAction.Text = "User Actions";
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservation.Location = new System.Drawing.Point(264, 69);
            this.btnViewReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(141, 44);
            this.btnViewReservation.TabIndex = 3;
            this.btnViewReservation.Text = "View Reservation";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Reserveration";
            // 
            // btnViewRetreats
            // 
            this.btnViewRetreats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRetreats.Location = new System.Drawing.Point(23, 69);
            this.btnViewRetreats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewRetreats.Name = "btnViewRetreats";
            this.btnViewRetreats.Size = new System.Drawing.Size(167, 44);
            this.btnViewRetreats.TabIndex = 1;
            this.btnViewRetreats.Text = "View Retreat\r\nListing\r\n";
            this.btnViewRetreats.UseVisualStyleBackColor = true;
            this.btnViewRetreats.Click += new System.EventHandler(this.btnViewRetreats_Click);
            // 
            // lbViewRetreats
            // 
            this.lbViewRetreats.AutoSize = true;
            this.lbViewRetreats.Location = new System.Drawing.Point(45, 36);
            this.lbViewRetreats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbViewRetreats.Name = "lbViewRetreats";
            this.lbViewRetreats.Size = new System.Drawing.Size(141, 17);
            this.lbViewRetreats.TabIndex = 0;
            this.lbViewRetreats.Text = "Available Retreats";
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToOrderColumns = true;
            this.dataGridViewReservations.AutoGenerateColumns = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.bookingIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.retreatNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn});
            this.dataGridViewReservations.DataSource = this.reservationDataTableBindingSource;
            this.dataGridViewReservations.Location = new System.Drawing.Point(20, 543);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.Size = new System.Drawing.Size(1201, 283);
            this.dataGridViewReservations.TabIndex = 5;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // retreatNameDataGridViewTextBoxColumn
            // 
            this.retreatNameDataGridViewTextBoxColumn.DataPropertyName = "RetreatName";
            this.retreatNameDataGridViewTextBoxColumn.HeaderText = "RetreatName";
            this.retreatNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.retreatNameDataGridViewTextBoxColumn.Name = "retreatNameDataGridViewTextBoxColumn";
            this.retreatNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            this.contactInfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationDataTableBindingSource
            // 
            this.reservationDataTableBindingSource.DataMember = "ReservationDataTable";
            this.reservationDataTableBindingSource.DataSource = this.retreatManagementDBDataSet2BindingSource;
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
            // reservationDataTableAdapter
            // 
            this.reservationDataTableAdapter.ClearBeforeFill = true;
            // 
            // lbReservationDetails
            // 
            this.lbReservationDetails.AutoSize = true;
            this.lbReservationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservationDetails.Location = new System.Drawing.Point(16, 519);
            this.lbReservationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReservationDetails.Name = "lbReservationDetails";
            this.lbReservationDetails.Size = new System.Drawing.Size(175, 20);
            this.lbReservationDetails.TabIndex = 6;
            this.lbReservationDetails.Text = "Reservation Details";
            // 
            // lbProfileError
            // 
            this.lbProfileError.AutoSize = true;
            this.lbProfileError.Location = new System.Drawing.Point(739, 282);
            this.lbProfileError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProfileError.Name = "lbProfileError";
            this.lbProfileError.Size = new System.Drawing.Size(0, 16);
            this.lbProfileError.TabIndex = 7;
            // 
            // UserDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 838);
            this.Controls.Add(this.lbProfileError);
            this.Controls.Add(this.lbReservationDetails);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.groupBoxUserAction);
            this.Controls.Add(this.picbxProfile);
            this.Controls.Add(this.groupUserInformation);
            this.Controls.Add(this.lbWelcomeMessage);
            this.Controls.Add(this.menuStripUserDash);
            this.MainMenuStrip = this.menuStripUserDash;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserDash";
            this.Text = "  User Dash";
            this.Load += new System.EventHandler(this.UserDash_Load);
            this.menuStripUserDash.ResumeLayout(false);
            this.menuStripUserDash.PerformLayout();
            this.groupUserInformation.ResumeLayout(false);
            this.groupUserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfile)).EndInit();
            this.groupBoxUserAction.ResumeLayout(false);
            this.groupBoxUserAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatManagementDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUserDash;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogout;
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
        private System.Windows.Forms.Label lbViewRetreats;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRetreats;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.BindingSource retreatManagementDBDataSet2BindingSource;
        private Retreat_Management_DBDataSet2 retreat_Management_DBDataSet2;
        private System.Windows.Forms.BindingSource reservationDataTableBindingSource;
        private Retreat_Management_DBDataSet2TableAdapters.ReservationDataTableAdapter reservationDataTableAdapter;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retreatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbReservationDetails;
        private System.Windows.Forms.Label lbProfileError;
    }
}