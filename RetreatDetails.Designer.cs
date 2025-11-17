namespace Retreat_Management_System
{
    partial class lblRetreatDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.btnBackToDashboard = new System.Windows.Forms.Button();
            this.lblRetreatName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetreatPrice = new System.Windows.Forms.TextBox();
            this.txtRetreatDates = new System.Windows.Forms.TextBox();
            this.cbRetreatName = new System.Windows.Forms.ComboBox();
            this.pbRetreat = new System.Windows.Forms.PictureBox();
            this.lblDiscriptionName = new System.Windows.Forms.Label();
            this.retreatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.retreatDetails = new Retreat_Management_System.RetreatDetails();
            this.retreatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreatTableAdapter1 = new Retreat_Management_System.Retreat_StatusTableAdapters.RetreatTableAdapter();
            this.retreatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.retreatTableAdapter = new Retreat_Management_System.RetreatDetailsTableAdapters.RetreatTableAdapter();
            this.retreatDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreat_Status = new Retreat_Management_System.Retreat_Status();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetreat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Status)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retreat";
            // 
            // btnBookNow
            // 
            this.btnBookNow.Location = new System.Drawing.Point(746, 600);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(92, 40);
            this.btnBookNow.TabIndex = 1;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnBackToDashboard
            // 
            this.btnBackToDashboard.Location = new System.Drawing.Point(60, 600);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(92, 40);
            this.btnBackToDashboard.TabIndex = 2;
            this.btnBackToDashboard.Text = "Back";
            this.btnBackToDashboard.UseVisualStyleBackColor = true;
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            // 
            // lblRetreatName
            // 
            this.lblRetreatName.AutoSize = true;
            this.lblRetreatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetreatName.Location = new System.Drawing.Point(385, 144);
            this.lblRetreatName.Name = "lblRetreatName";
            this.lblRetreatName.Size = new System.Drawing.Size(63, 20);
            this.lblRetreatName.TabIndex = 3;
            this.lblRetreatName.Text = "Retreat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(389, 340);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(210, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(389, 227);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(210, 47);
            this.txtDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(742, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // txtRetreatPrice
            // 
            this.txtRetreatPrice.Location = new System.Drawing.Point(746, 340);
            this.txtRetreatPrice.Name = "txtRetreatPrice";
            this.txtRetreatPrice.ReadOnly = true;
            this.txtRetreatPrice.Size = new System.Drawing.Size(153, 20);
            this.txtRetreatPrice.TabIndex = 13;
            // 
            // txtRetreatDates
            // 
            this.txtRetreatDates.Location = new System.Drawing.Point(746, 167);
            this.txtRetreatDates.Multiline = true;
            this.txtRetreatDates.Name = "txtRetreatDates";
            this.txtRetreatDates.ReadOnly = true;
            this.txtRetreatDates.Size = new System.Drawing.Size(153, 45);
            this.txtRetreatDates.TabIndex = 15;
            // 
            // cbRetreatName
            // 
            this.cbRetreatName.FormattingEnabled = true;
            this.cbRetreatName.Location = new System.Drawing.Point(389, 167);
            this.cbRetreatName.Name = "cbRetreatName";
            this.cbRetreatName.Size = new System.Drawing.Size(210, 21);
            this.cbRetreatName.TabIndex = 16;
            // 
            // pbRetreat
            // 
            this.pbRetreat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRetreat.Location = new System.Drawing.Point(24, 123);
            this.pbRetreat.Name = "pbRetreat";
            this.pbRetreat.Size = new System.Drawing.Size(339, 389);
            this.pbRetreat.TabIndex = 17;
            this.pbRetreat.TabStop = false;
            // 
            // lblDiscriptionName
            // 
            this.lblDiscriptionName.AutoSize = true;
            this.lblDiscriptionName.Location = new System.Drawing.Point(159, 515);
            this.lblDiscriptionName.Name = "lblDiscriptionName";
            this.lblDiscriptionName.Size = new System.Drawing.Size(23, 13);
            this.lblDiscriptionName.TabIndex = 18;
            this.lblDiscriptionName.Text = "\"  \"";
            // 
            // retreatBindingSource2
            // 
            this.retreatBindingSource2.DataMember = "Retreat";
            // 
            // retreatDetails
            // 
            this.retreatDetails.DataSetName = "RetreatDetails";
            this.retreatDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retreatBindingSource
            // 
            this.retreatBindingSource.DataMember = "Retreat";
            // 
            // retreatTableAdapter1
            // 
            this.retreatTableAdapter1.ClearBeforeFill = true;
            // 
            // retreatBindingSource1
            // 
            this.retreatBindingSource1.DataMember = "Retreat";
            // 
            // retreatTableAdapter
            // 
            this.retreatTableAdapter.ClearBeforeFill = true;
            // 
            // retreatDetailsBindingSource
            // 
            this.retreatDetailsBindingSource.DataSource = this.retreatDetails;
            this.retreatDetailsBindingSource.Position = 0;
            // 
            // retreat_Status
            // 
            this.retreat_Status.DataSetName = "Retreat_Status";
            this.retreat_Status.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 24);
            this.menuStrip.TabIndex = 22;
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
            // lblRetreatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblDiscriptionName);
            this.Controls.Add(this.pbRetreat);
            this.Controls.Add(this.cbRetreatName);
            this.Controls.Add(this.txtRetreatDates);
            this.Controls.Add(this.txtRetreatPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRetreatName);
            this.Controls.Add(this.btnBackToDashboard);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.label1);
            this.Name = "lblRetreatDetails";
            this.Text = "RetreatDetails";
            this.Load += new System.EventHandler(this.lblRetreatDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRetreat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Status)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnBackToDashboard;
        private System.Windows.Forms.Label lblRetreatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetreatPrice;
        private System.Windows.Forms.TextBox txtRetreatDates;
        private System.Windows.Forms.ComboBox cbRetreatName;
        private System.Windows.Forms.PictureBox pbRetreat;
        private System.Windows.Forms.Label lblDiscriptionName;
        private RetreatDetails retreatDetails;
        private System.Windows.Forms.BindingSource retreatBindingSource;
        private Retreat_StatusTableAdapters.RetreatTableAdapter retreatTableAdapter1;
        private System.Windows.Forms.BindingSource retreatBindingSource2;
        private System.Windows.Forms.BindingSource retreatBindingSource1;
        private RetreatDetailsTableAdapters.RetreatTableAdapter retreatTableAdapter;
        private System.Windows.Forms.BindingSource retreatDetailsBindingSource;
        private Retreat_Status retreat_Status;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
    }
}