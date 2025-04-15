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
            this.lbAddRetreat = new System.Windows.Forms.Label();
            this.btnEditRetreat = new System.Windows.Forms.Button();
            this.btnAddRetreat = new System.Windows.Forms.Button();
            this.groupBoxUserManagement = new System.Windows.Forms.GroupBox();
            this.lbManageUsers = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.lbGenerateReports = new System.Windows.Forms.Label();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRetreatManament.SuspendLayout();
            this.groupBoxUserManagement.SuspendLayout();
            this.groupBoxReports.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.AutoSize = true;
            this.lbWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeMessage.Location = new System.Drawing.Point(355, 49);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(258, 31);
            this.lbWelcomeMessage.TabIndex = 0;
            this.lbWelcomeMessage.Text = "Welcome Message";
            // 
            // groupBoxRetreatManament
            // 
            this.groupBoxRetreatManament.Controls.Add(this.lbEditRetreat);
            this.groupBoxRetreatManament.Controls.Add(this.lbAddRetreat);
            this.groupBoxRetreatManament.Controls.Add(this.btnEditRetreat);
            this.groupBoxRetreatManament.Controls.Add(this.btnAddRetreat);
            this.groupBoxRetreatManament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRetreatManament.Location = new System.Drawing.Point(57, 136);
            this.groupBoxRetreatManament.Name = "groupBoxRetreatManament";
            this.groupBoxRetreatManament.Size = new System.Drawing.Size(399, 162);
            this.groupBoxRetreatManament.TabIndex = 1;
            this.groupBoxRetreatManament.TabStop = false;
            this.groupBoxRetreatManament.Text = "Retreat Management";
            // 
            // lbEditRetreat
            // 
            this.lbEditRetreat.AutoSize = true;
            this.lbEditRetreat.Location = new System.Drawing.Point(226, 43);
            this.lbEditRetreat.Name = "lbEditRetreat";
            this.lbEditRetreat.Size = new System.Drawing.Size(135, 16);
            this.lbEditRetreat.TabIndex = 3;
            this.lbEditRetreat.Text = "View / Edit Retreat";
            // 
            // lbAddRetreat
            // 
            this.lbAddRetreat.AutoSize = true;
            this.lbAddRetreat.Location = new System.Drawing.Point(29, 43);
            this.lbAddRetreat.Name = "lbAddRetreat";
            this.lbAddRetreat.Size = new System.Drawing.Size(90, 16);
            this.lbAddRetreat.TabIndex = 2;
            this.lbAddRetreat.Text = "Add Retreat";
            // 
            // btnEditRetreat
            // 
            this.btnEditRetreat.Location = new System.Drawing.Point(241, 71);
            this.btnEditRetreat.Name = "btnEditRetreat";
            this.btnEditRetreat.Size = new System.Drawing.Size(102, 36);
            this.btnEditRetreat.TabIndex = 1;
            this.btnEditRetreat.Text = "Edit";
            this.btnEditRetreat.UseVisualStyleBackColor = true;
            this.btnEditRetreat.Click += new System.EventHandler(this.btnEditRetreat_Click);
            // 
            // btnAddRetreat
            // 
            this.btnAddRetreat.Location = new System.Drawing.Point(20, 71);
            this.btnAddRetreat.Name = "btnAddRetreat";
            this.btnAddRetreat.Size = new System.Drawing.Size(110, 36);
            this.btnAddRetreat.TabIndex = 0;
            this.btnAddRetreat.Text = "Add";
            this.btnAddRetreat.UseVisualStyleBackColor = true;
            this.btnAddRetreat.Click += new System.EventHandler(this.btnAddRetreat_Click);
            // 
            // groupBoxUserManagement
            // 
            this.groupBoxUserManagement.Controls.Add(this.lbManageUsers);
            this.groupBoxUserManagement.Controls.Add(this.btnManageUsers);
            this.groupBoxUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserManagement.Location = new System.Drawing.Point(535, 136);
            this.groupBoxUserManagement.Name = "groupBoxUserManagement";
            this.groupBoxUserManagement.Size = new System.Drawing.Size(308, 162);
            this.groupBoxUserManagement.TabIndex = 2;
            this.groupBoxUserManagement.TabStop = false;
            this.groupBoxUserManagement.Text = "User Management";
            // 
            // lbManageUsers
            // 
            this.lbManageUsers.AutoSize = true;
            this.lbManageUsers.Location = new System.Drawing.Point(105, 43);
            this.lbManageUsers.Name = "lbManageUsers";
            this.lbManageUsers.Size = new System.Drawing.Size(108, 16);
            this.lbManageUsers.TabIndex = 2;
            this.lbManageUsers.Text = "Manage Users";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(103, 71);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(110, 36);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Controls.Add(this.lbGenerateReports);
            this.groupBoxReports.Controls.Add(this.btnGenerateReports);
            this.groupBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReports.Location = new System.Drawing.Point(68, 380);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(332, 117);
            this.groupBoxReports.TabIndex = 3;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Reports ";
            // 
            // lbGenerateReports
            // 
            this.lbGenerateReports.AutoSize = true;
            this.lbGenerateReports.Location = new System.Drawing.Point(70, 60);
            this.lbGenerateReports.Name = "lbGenerateReports";
            this.lbGenerateReports.Size = new System.Drawing.Size(62, 16);
            this.lbGenerateReports.TabIndex = 7;
            this.lbGenerateReports.Text = "Reports";
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Location = new System.Drawing.Point(176, 50);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(102, 36);
            this.btnGenerateReports.TabIndex = 6;
            this.btnGenerateReports.Text = "Generate";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Name = "AdminDash";
            this.Text = "Admin Dash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDash_FormClosing);
            this.groupBoxRetreatManament.ResumeLayout(false);
            this.groupBoxRetreatManament.PerformLayout();
            this.groupBoxUserManagement.ResumeLayout(false);
            this.groupBoxUserManagement.PerformLayout();
            this.groupBoxReports.ResumeLayout(false);
            this.groupBoxReports.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}