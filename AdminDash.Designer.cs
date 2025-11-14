namespace Retreat_Management_System
{
    partial class AdminDash
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
            this.lbWelcomeMessage = new System.Windows.Forms.Label();
            this.groupBoxRetreatManament = new System.Windows.Forms.GroupBox();
            this.lbEditRetreat = new System.Windows.Forms.Label();
            this.btnEditRetreat = new System.Windows.Forms.Button();
            this.groupBoxUserManagement = new System.Windows.Forms.GroupBox();
            this.lbManageUsers = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.lbGenerateReports = new System.Windows.Forms.Label();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRetreatManament.SuspendLayout();
            this.groupBoxUserManagement.SuspendLayout();
            this.groupBoxReports.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.AutoSize = true;
            this.lbWelcomeMessage.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeMessage.Location = new System.Drawing.Point(355, 49);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(244, 32);
            this.lbWelcomeMessage.TabIndex = 0;
            this.lbWelcomeMessage.Text = "Welcome Message";
            // 
            // groupBoxRetreatManament
            // 
            this.groupBoxRetreatManament.Controls.Add(this.lbEditRetreat);
            this.groupBoxRetreatManament.Controls.Add(this.btnEditRetreat);
            this.groupBoxRetreatManament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRetreatManament.Location = new System.Drawing.Point(97, 136);
            this.groupBoxRetreatManament.Name = "groupBoxRetreatManament";
            this.groupBoxRetreatManament.Size = new System.Drawing.Size(332, 149);
            this.groupBoxRetreatManament.TabIndex = 1;
            this.groupBoxRetreatManament.TabStop = false;
            this.groupBoxRetreatManament.Text = "Retreat Management";
            // 
            // lbEditRetreat
            // 
            this.lbEditRetreat.AutoSize = true;
            this.lbEditRetreat.Location = new System.Drawing.Point(110, 57);
            this.lbEditRetreat.Name = "lbEditRetreat";
            this.lbEditRetreat.Size = new System.Drawing.Size(141, 16);
            this.lbEditRetreat.TabIndex = 3;
            this.lbEditRetreat.Text = "View / Edit Retreat";
            // 
            // btnEditRetreat
            // 
            this.btnEditRetreat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditRetreat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditRetreat.Location = new System.Drawing.Point(113, 89);
            this.btnEditRetreat.Name = "btnEditRetreat";
            this.btnEditRetreat.Size = new System.Drawing.Size(102, 32);
            this.btnEditRetreat.TabIndex = 1;
            this.btnEditRetreat.Text = "Edit";
            this.btnEditRetreat.UseVisualStyleBackColor = false;
            this.btnEditRetreat.Click += new System.EventHandler(this.btnEditRetreat_Click);
            // 
            // groupBoxUserManagement
            // 
            this.groupBoxUserManagement.Controls.Add(this.lbManageUsers);
            this.groupBoxUserManagement.Controls.Add(this.btnManageUsers);
            this.groupBoxUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserManagement.Location = new System.Drawing.Point(562, 136);
            this.groupBoxUserManagement.Name = "groupBoxUserManagement";
            this.groupBoxUserManagement.Size = new System.Drawing.Size(308, 162);
            this.groupBoxUserManagement.TabIndex = 2;
            this.groupBoxUserManagement.TabStop = false;
            this.groupBoxUserManagement.Text = "User Management";
            // 
            // lbManageUsers
            // 
            this.lbManageUsers.AutoSize = true;
            this.lbManageUsers.Location = new System.Drawing.Point(102, 42);
            this.lbManageUsers.Name = "lbManageUsers";
            this.lbManageUsers.Size = new System.Drawing.Size(111, 16);
            this.lbManageUsers.TabIndex = 2;
            this.lbManageUsers.Text = "Manage Users";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageUsers.Location = new System.Drawing.Point(98, 89);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(115, 32);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Controls.Add(this.lbGenerateReports);
            this.groupBoxReports.Controls.Add(this.btnGenerateReports);
            this.groupBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReports.Location = new System.Drawing.Point(97, 380);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(332, 149);
            this.groupBoxReports.TabIndex = 3;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Reports ";
            // 
            // lbGenerateReports
            // 
            this.lbGenerateReports.AutoSize = true;
            this.lbGenerateReports.Location = new System.Drawing.Point(130, 45);
            this.lbGenerateReports.Name = "lbGenerateReports";
            this.lbGenerateReports.Size = new System.Drawing.Size(63, 16);
            this.lbGenerateReports.TabIndex = 7;
            this.lbGenerateReports.Text = "Reports";
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGenerateReports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerateReports.Location = new System.Drawing.Point(113, 73);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(102, 36);
            this.btnGenerateReports.TabIndex = 6;
            this.btnGenerateReports.Text = "Generate";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 24);
            this.menuStrip.TabIndex = 5;
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
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click_1);
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
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click_1);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxReports);
            this.Controls.Add(this.groupBoxUserManagement);
            this.Controls.Add(this.groupBoxRetreatManament);
            this.Controls.Add(this.lbWelcomeMessage);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AdminDash";
            this.Text = "Admin Dash";
            this.groupBoxRetreatManament.ResumeLayout(false);
            this.groupBoxRetreatManament.PerformLayout();
            this.groupBoxUserManagement.ResumeLayout(false);
            this.groupBoxUserManagement.PerformLayout();
            this.groupBoxReports.ResumeLayout(false);
            this.groupBoxReports.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcomeMessage;
        private System.Windows.Forms.GroupBox groupBoxRetreatManament;
        private System.Windows.Forms.Button btnEditRetreat;
        private System.Windows.Forms.Label lbEditRetreat;
        private System.Windows.Forms.GroupBox groupBoxUserManagement;
        private System.Windows.Forms.Label lbManageUsers;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.Label lbGenerateReports;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
    }
}