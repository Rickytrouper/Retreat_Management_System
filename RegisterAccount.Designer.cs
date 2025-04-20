namespace Retreat_Management_System
{
    partial class RegisterAccount
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
            this.lbPageLable = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtCrePassword = new System.Windows.Forms.TextBox();
            this.lbCrePassword = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.lbConPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbSelectRole = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.picbxProfile = new System.Windows.Forms.PictureBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.lbContactNum = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbProfilePic = new System.Windows.Forms.Label();
            this.lbPasswordError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPageLable
            // 
            this.lbPageLable.AutoSize = true;
            this.lbPageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLable.Location = new System.Drawing.Point(358, 59);
            this.lbPageLable.Name = "lbPageLable";
            this.lbPageLable.Size = new System.Drawing.Size(117, 31);
            this.lbPageLable.TabIndex = 0;
            this.lbPageLable.Text = "Sign Up";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(36, 250);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(79, 16);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "UserName :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(168, 249);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(238, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtCrePassword
            // 
            this.txtCrePassword.Location = new System.Drawing.Point(168, 296);
            this.txtCrePassword.Name = "txtCrePassword";
            this.txtCrePassword.Size = new System.Drawing.Size(238, 20);
            this.txtCrePassword.TabIndex = 4;
            // 
            // lbCrePassword
            // 
            this.lbCrePassword.AutoSize = true;
            this.lbCrePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrePassword.Location = new System.Drawing.Point(36, 300);
            this.lbCrePassword.Name = "lbCrePassword";
            this.lbCrePassword.Size = new System.Drawing.Size(116, 16);
            this.lbCrePassword.TabIndex = 3;
            this.lbCrePassword.Text = "Create Password :";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(168, 346);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(238, 20);
            this.txtConPassword.TabIndex = 6;
            // 
            // lbConPassword
            // 
            this.lbConPassword.AutoSize = true;
            this.lbConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConPassword.Location = new System.Drawing.Point(36, 350);
            this.lbConPassword.Name = "lbConPassword";
            this.lbConPassword.Size = new System.Drawing.Size(121, 16);
            this.lbConPassword.TabIndex = 5;
            this.lbConPassword.Text = "Confirm Password :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(528, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(421, 250);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(101, 16);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email Address :";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "User",
            "Admin",
            "Organizer"});
            this.cbRole.Location = new System.Drawing.Point(168, 397);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(238, 21);
            this.cbRole.TabIndex = 9;
            // 
            // lbSelectRole
            // 
            this.lbSelectRole.AutoSize = true;
            this.lbSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectRole.Location = new System.Drawing.Point(36, 402);
            this.lbSelectRole.Name = "lbSelectRole";
            this.lbSelectRole.Size = new System.Drawing.Size(83, 16);
            this.lbSelectRole.TabIndex = 10;
            this.lbSelectRole.Text = "Select Role :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 443);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(36, 447);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(78, 16);
            this.lbFirstName.TabIndex = 11;
            this.lbFirstName.Text = "First Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(528, 443);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(433, 447);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(78, 16);
            this.lbLastName.TabIndex = 13;
            this.lbLastName.Text = "Last Name :";
            // 
            // picbxProfile
            // 
            this.picbxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxProfile.Location = new System.Drawing.Point(31, 88);
            this.picbxProfile.Name = "picbxProfile";
            this.picbxProfile.Size = new System.Drawing.Size(121, 102);
            this.picbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbxProfile.TabIndex = 15;
            this.picbxProfile.TabStop = false;
            this.picbxProfile.Click += new System.EventHandler(this.picbxProfile_Click);
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(168, 490);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(238, 20);
            this.txtContactNum.TabIndex = 17;
            // 
            // lbContactNum
            // 
            this.lbContactNum.AutoSize = true;
            this.lbContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactNum.Location = new System.Drawing.Point(36, 491);
            this.lbContactNum.Name = "lbContactNum";
            this.lbContactNum.Size = new System.Drawing.Size(109, 16);
            this.lbContactNum.TabIndex = 16;
            this.lbContactNum.Text = "Contact Number :";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(168, 549);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(94, 39);
            this.btnSignUp.TabIndex = 18;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(528, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 46);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbProfilePic
            // 
            this.lbProfilePic.AutoSize = true;
            this.lbProfilePic.Location = new System.Drawing.Point(39, 193);
            this.lbProfilePic.Name = "lbProfilePic";
            this.lbProfilePic.Size = new System.Drawing.Size(94, 13);
            this.lbProfilePic.TabIndex = 20;
            this.lbProfilePic.Text = "Add Profile Picture";
            // 
            // lbPasswordError
            // 
            this.lbPasswordError.AutoSize = true;
            this.lbPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordError.Location = new System.Drawing.Point(168, 369);
            this.lbPasswordError.Name = "lbPasswordError";
            this.lbPasswordError.Size = new System.Drawing.Size(0, 13);
            this.lbPasswordError.TabIndex = 21;
            // 
            // RegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.lbPasswordError);
            this.Controls.Add(this.lbProfilePic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.lbContactNum);
            this.Controls.Add(this.picbxProfile);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbSelectRole);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.lbConPassword);
            this.Controls.Add(this.txtCrePassword);
            this.Controls.Add(this.lbCrePassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbPageLable);
            this.Name = "RegisterAccount";
            this.Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.picbxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPageLable;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtCrePassword;
        private System.Windows.Forms.Label lbCrePassword;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label lbConPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbSelectRole;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.PictureBox picbxProfile;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label lbContactNum;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbProfilePic;
        private System.Windows.Forms.Label lbPasswordError;
    }
}