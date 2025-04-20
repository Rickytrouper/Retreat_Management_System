namespace Retreat_Management_System
{
    partial class UserManagementForm
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
            this.lbUserManagement = new System.Windows.Forms.Label();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.groupBoxUserInfoTable = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbUserRole = new System.Windows.Forms.Label();
            this.gridViewUserData = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreat_Management_DB_UserInfo = new Retreat_Management_System.Retreat_Management_DB_UserInfo();
            this.btnEnable_Disable = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.userTableAdapter = new Retreat_Management_System.Retreat_Management_DB_UserInfoTableAdapters.UserTableAdapter();
            this.groupBoxUserInfo.SuspendLayout();
            this.groupBoxUserInfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DB_UserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserManagement
            // 
            this.lbUserManagement.AutoSize = true;
            this.lbUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserManagement.Location = new System.Drawing.Point(268, 32);
            this.lbUserManagement.Name = "lbUserManagement";
            this.lbUserManagement.Size = new System.Drawing.Size(251, 31);
            this.lbUserManagement.TabIndex = 0;
            this.lbUserManagement.Text = "User Management";
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.btnCancel);
            this.groupBoxUserInfo.Controls.Add(this.btnSave);
            this.groupBoxUserInfo.Controls.Add(this.cbRole);
            this.groupBoxUserInfo.Controls.Add(this.lbRole);
            this.groupBoxUserInfo.Controls.Add(this.txtEmail);
            this.groupBoxUserInfo.Controls.Add(this.lbEmail);
            this.groupBoxUserInfo.Controls.Add(this.txtUserName);
            this.groupBoxUserInfo.Controls.Add(this.lbUserName);
            this.groupBoxUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserInfo.Location = new System.Drawing.Point(30, 80);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(386, 180);
            this.groupBoxUserInfo.TabIndex = 1;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "User Info Control";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(210, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(82, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(183, 93);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(186, 24);
            this.cbRole.TabIndex = 5;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(7, 93);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(48, 16);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Role :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(8, 59);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 16);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(184, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(8, 28);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(86, 16);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Username :";
            // 
            // groupBoxUserInfoTable
            // 
            this.groupBoxUserInfoTable.Controls.Add(this.lbStatus);
            this.groupBoxUserInfoTable.Controls.Add(this.lbUserRole);
            this.groupBoxUserInfoTable.Controls.Add(this.gridViewUserData);
            this.groupBoxUserInfoTable.Controls.Add(this.btnEnable_Disable);
            this.groupBoxUserInfoTable.Controls.Add(this.btnEdit);
            this.groupBoxUserInfoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserInfoTable.Location = new System.Drawing.Point(30, 266);
            this.groupBoxUserInfoTable.Name = "groupBoxUserInfoTable";
            this.groupBoxUserInfoTable.Size = new System.Drawing.Size(773, 342);
            this.groupBoxUserInfoTable.TabIndex = 2;
            this.groupBoxUserInfoTable.TabStop = false;
            this.groupBoxUserInfoTable.Text = "User Info";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(462, 276);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(70, 16);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Edit Status";
            // 
            // lbUserRole
            // 
            this.lbUserRole.AutoSize = true;
            this.lbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserRole.Location = new System.Drawing.Point(266, 275);
            this.lbUserRole.Name = "lbUserRole";
            this.lbUserRole.Size = new System.Drawing.Size(62, 16);
            this.lbUserRole.TabIndex = 10;
            this.lbUserRole.Text = "Edit Role";
            // 
            // gridViewUserData
            // 
            this.gridViewUserData.AutoGenerateColumns = false;
            this.gridViewUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.lastLoginDataGridViewTextBoxColumn,
            this.accountStatusDataGridViewTextBoxColumn});
            this.gridViewUserData.DataSource = this.userBindingSource;
            this.gridViewUserData.Location = new System.Drawing.Point(11, 18);
            this.gridViewUserData.Name = "gridViewUserData";
            this.gridViewUserData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridViewUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUserData.Size = new System.Drawing.Size(748, 240);
            this.gridViewUserData.TabIndex = 9;
            this.gridViewUserData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewUserData_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // lastLoginDataGridViewTextBoxColumn
            // 
            this.lastLoginDataGridViewTextBoxColumn.DataPropertyName = "LastLogin";
            this.lastLoginDataGridViewTextBoxColumn.HeaderText = "LastLogin";
            this.lastLoginDataGridViewTextBoxColumn.Name = "lastLoginDataGridViewTextBoxColumn";
            // 
            // accountStatusDataGridViewTextBoxColumn
            // 
            this.accountStatusDataGridViewTextBoxColumn.DataPropertyName = "AccountStatus";
            this.accountStatusDataGridViewTextBoxColumn.HeaderText = "AccountStatus";
            this.accountStatusDataGridViewTextBoxColumn.Name = "accountStatusDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.retreat_Management_DB_UserInfo;
            // 
            // retreat_Management_DB_UserInfo
            // 
            this.retreat_Management_DB_UserInfo.DataSetName = "Retreat_Management_DB_UserInfo";
            this.retreat_Management_DB_UserInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEnable_Disable
            // 
            this.btnEnable_Disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable_Disable.Location = new System.Drawing.Point(435, 291);
            this.btnEnable_Disable.Name = "btnEnable_Disable";
            this.btnEnable_Disable.Size = new System.Drawing.Size(129, 32);
            this.btnEnable_Disable.TabIndex = 8;
            this.btnEnable_Disable.Text = "Enable/Disable";
            this.btnEnable_Disable.UseVisualStyleBackColor = true;
            this.btnEnable_Disable.Click += new System.EventHandler(this.btnEnable_Disable_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(254, 291);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 614);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxUserInfoTable);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.lbUserManagement);
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.groupBoxUserInfoTable.ResumeLayout(false);
            this.groupBoxUserInfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreat_Management_DB_UserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserManagement;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxUserInfoTable;
        private System.Windows.Forms.Button btnEnable_Disable;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gridViewUserData;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbUserRole;
        private Retreat_Management_DB_UserInfo retreat_Management_DB_UserInfo;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Retreat_Management_DB_UserInfoTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountStatusDataGridViewTextBoxColumn;
    }
}