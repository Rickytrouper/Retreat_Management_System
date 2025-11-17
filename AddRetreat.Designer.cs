namespace Retreat_Management_System
{
    partial class AddRetreat
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
            this.txtRetreatName = new System.Windows.Forms.TextBox();
            this.lbRetreatName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRetreatLocation = new System.Windows.Forms.TextBox();
            this.lbRetreatLocation = new System.Windows.Forms.Label();
            this.lbRetreatDiscription = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.lbnumPrice = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbUploadImage = new System.Windows.Forms.Label();
            this.txtContatctDetails = new System.Windows.Forms.TextBox();
            this.lbContactDetails = new System.Windows.Forms.Label();
            this.btnSaveRetreat = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImageUpload = new System.Windows.Forms.Button();
            this.rbRetreatDiscription = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cbRetreatStatus = new System.Windows.Forms.ComboBox();
            this.lbRetreatStatus = new System.Windows.Forms.Label();
            this.retreat_Status = new Retreat_Management_System.Retreat_Status();
            this.retreatStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRetreatName
            // 
            this.txtRetreatName.Location = new System.Drawing.Point(177, 141);
            this.txtRetreatName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetreatName.Name = "txtRetreatName";
            this.txtRetreatName.Size = new System.Drawing.Size(240, 20);
            this.txtRetreatName.TabIndex = 0;
            // 
            // lbRetreatName
            // 
            this.lbRetreatName.AutoSize = true;
            this.lbRetreatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetreatName.Location = new System.Drawing.Point(59, 140);
            this.lbRetreatName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRetreatName.Name = "lbRetreatName";
            this.lbRetreatName.Size = new System.Drawing.Size(104, 18);
            this.lbRetreatName.TabIndex = 1;
            this.lbRetreatName.Text = "Retreat Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(340, 41);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(225, 38);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Add a Retreat";
            // 
            // txtRetreatLocation
            // 
            this.txtRetreatLocation.Location = new System.Drawing.Point(617, 139);
            this.txtRetreatLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetreatLocation.Name = "txtRetreatLocation";
            this.txtRetreatLocation.Size = new System.Drawing.Size(240, 20);
            this.txtRetreatLocation.TabIndex = 4;
            // 
            // lbRetreatLocation
            // 
            this.lbRetreatLocation.AutoSize = true;
            this.lbRetreatLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetreatLocation.Location = new System.Drawing.Point(487, 140);
            this.lbRetreatLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRetreatLocation.Name = "lbRetreatLocation";
            this.lbRetreatLocation.Size = new System.Drawing.Size(121, 18);
            this.lbRetreatLocation.TabIndex = 5;
            this.lbRetreatLocation.Text = "Retreat Location:";
            // 
            // lbRetreatDiscription
            // 
            this.lbRetreatDiscription.AutoSize = true;
            this.lbRetreatDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetreatDiscription.Location = new System.Drawing.Point(27, 253);
            this.lbRetreatDiscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRetreatDiscription.Name = "lbRetreatDiscription";
            this.lbRetreatDiscription.Size = new System.Drawing.Size(139, 18);
            this.lbRetreatDiscription.TabIndex = 6;
            this.lbRetreatDiscription.Text = "Retreat Description:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(617, 192);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(185, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(617, 246);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.MinDate = new System.DateTime(2025, 4, 24, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(185, 20);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.Value = new System.DateTime(2025, 5, 9, 0, 0, 0, 0);
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(521, 192);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(78, 18);
            this.lbStartDate.TabIndex = 9;
            this.lbStartDate.Text = "Start Date:";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(526, 246);
            this.lbEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(73, 18);
            this.lbEndDate.TabIndex = 10;
            this.lbEndDate.Text = "End Date:";
            this.lbEndDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(617, 306);
            this.numPrice.Margin = new System.Windows.Forms.Padding(2);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(104, 20);
            this.numPrice.TabIndex = 11;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(617, 350);
            this.numCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(104, 20);
            this.numCapacity.TabIndex = 12;
            // 
            // lbnumPrice
            // 
            this.lbnumPrice.AutoSize = true;
            this.lbnumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumPrice.Location = new System.Drawing.Point(551, 304);
            this.lbnumPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnumPrice.Name = "lbnumPrice";
            this.lbnumPrice.Size = new System.Drawing.Size(46, 18);
            this.lbnumPrice.TabIndex = 13;
            this.lbnumPrice.Text = "Price:";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapacity.Location = new System.Drawing.Point(530, 350);
            this.lbCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(69, 18);
            this.lbCapacity.TabIndex = 14;
            this.lbCapacity.Text = "Capacity:";
            // 
            // lbUploadImage
            // 
            this.lbUploadImage.AutoSize = true;
            this.lbUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUploadImage.Location = new System.Drawing.Point(59, 553);
            this.lbUploadImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUploadImage.Name = "lbUploadImage";
            this.lbUploadImage.Size = new System.Drawing.Size(103, 18);
            this.lbUploadImage.TabIndex = 16;
            this.lbUploadImage.Text = "Image Upload:";
            // 
            // txtContatctDetails
            // 
            this.txtContatctDetails.Location = new System.Drawing.Point(617, 408);
            this.txtContatctDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtContatctDetails.Name = "txtContatctDetails";
            this.txtContatctDetails.Size = new System.Drawing.Size(185, 20);
            this.txtContatctDetails.TabIndex = 17;
            // 
            // lbContactDetails
            // 
            this.lbContactDetails.AutoSize = true;
            this.lbContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactDetails.Location = new System.Drawing.Point(455, 408);
            this.lbContactDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContactDetails.Name = "lbContactDetails";
            this.lbContactDetails.Size = new System.Drawing.Size(142, 18);
            this.lbContactDetails.TabIndex = 18;
            this.lbContactDetails.Text = "Contact Information:";
            // 
            // btnSaveRetreat
            // 
            this.btnSaveRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRetreat.Location = new System.Drawing.Point(435, 618);
            this.btnSaveRetreat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveRetreat.Name = "btnSaveRetreat";
            this.btnSaveRetreat.Size = new System.Drawing.Size(86, 24);
            this.btnSaveRetreat.TabIndex = 19;
            this.btnSaveRetreat.Text = "Submit";
            this.btnSaveRetreat.UseVisualStyleBackColor = true;
            this.btnSaveRetreat.Click += new System.EventHandler(this.btnSaveRetreat_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(607, 618);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 24);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageUpload.Location = new System.Drawing.Point(211, 549);
            this.btnImageUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(160, 24);
            this.btnImageUpload.TabIndex = 21;
            this.btnImageUpload.Text = "Upload";
            this.btnImageUpload.UseVisualStyleBackColor = true;
            this.btnImageUpload.Click += new System.EventHandler(this.btnImageUpload_Click);
            // 
            // rbRetreatDiscription
            // 
            this.rbRetreatDiscription.Location = new System.Drawing.Point(177, 209);
            this.rbRetreatDiscription.Margin = new System.Windows.Forms.Padding(2);
            this.rbRetreatDiscription.Name = "rbRetreatDiscription";
            this.rbRetreatDiscription.Size = new System.Drawing.Size(240, 113);
            this.rbRetreatDiscription.TabIndex = 22;
            this.rbRetreatDiscription.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(833, 618);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 24);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(177, 373);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 160);
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 24);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "menuStrip";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLogout});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(112, 22);
            this.MenuItemLogout.Text = "Logout";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // cbRetreatStatus
            // 
            this.cbRetreatStatus.FormattingEnabled = true;
            this.cbRetreatStatus.Location = new System.Drawing.Point(617, 472);
            this.cbRetreatStatus.Name = "cbRetreatStatus";
            this.cbRetreatStatus.Size = new System.Drawing.Size(121, 21);
            this.cbRetreatStatus.TabIndex = 27;
            // 
            // lbRetreatStatus
            // 
            this.lbRetreatStatus.AutoSize = true;
            this.lbRetreatStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetreatStatus.Location = new System.Drawing.Point(541, 473);
            this.lbRetreatStatus.Name = "lbRetreatStatus";
            this.lbRetreatStatus.Size = new System.Drawing.Size(60, 20);
            this.lbRetreatStatus.TabIndex = 26;
            this.lbRetreatStatus.Text = "Status:";
            // 
            // retreat_Status
            // 
            this.retreat_Status.DataSetName = "Retreat_Status";
            this.retreat_Status.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retreatStatusBindingSource
            // 
            this.retreatStatusBindingSource.DataSource = this.retreat_Status;
            this.retreatStatusBindingSource.Position = 0;
            // 
            // AddRetreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.cbRetreatStatus);
            this.Controls.Add(this.lbRetreatStatus);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbRetreatDiscription);
            this.Controls.Add(this.btnImageUpload);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveRetreat);
            this.Controls.Add(this.lbContactDetails);
            this.Controls.Add(this.txtContatctDetails);
            this.Controls.Add(this.lbUploadImage);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbnumPrice);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lbRetreatDiscription);
            this.Controls.Add(this.lbRetreatLocation);
            this.Controls.Add(this.txtRetreatLocation);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbRetreatName);
            this.Controls.Add(this.txtRetreatName);
            this.Name = "AddRetreat";
            this.Text = "AddRetreat";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txtRetreatName;
        private System.Windows.Forms.Label lbRetreatName;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtRetreatLocation;
        private System.Windows.Forms.Label lbRetreatLocation;
        private System.Windows.Forms.Label lbRetreatDiscription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lbnumPrice;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label lbUploadImage;
        private System.Windows.Forms.TextBox txtContatctDetails;
        private System.Windows.Forms.Label lbContactDetails;
        private System.Windows.Forms.Button btnSaveRetreat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnImageUpload;
        private System.Windows.Forms.RichTextBox rbRetreatDiscription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ComboBox cbRetreatStatus;
        private System.Windows.Forms.Label lbRetreatStatus;
        private Retreat_Status retreat_Status;
        private System.Windows.Forms.BindingSource retreatStatusBindingSource;
    }
}