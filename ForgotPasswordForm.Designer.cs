namespace Retreat_Management_System
{
    partial class ForgotPasswordForm
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.btnSubmitEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(303, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(303, 133);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(70, 13);
            this.lblEmailAddress.TabIndex = 1;
            this.lblEmailAddress.Text = "EmailAddress";
            // 
            // btnSubmitEmail
            // 
            this.btnSubmitEmail.Location = new System.Drawing.Point(303, 189);
            this.btnSubmitEmail.Name = "btnSubmitEmail";
            this.btnSubmitEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitEmail.TabIndex = 2;
            this.btnSubmitEmail.Text = "Submit";
            this.btnSubmitEmail.UseVisualStyleBackColor = true;
            this.btnSubmitEmail.Click += new System.EventHandler(this.btnSubmitEmail_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitEmail);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtEmail);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Button btnSubmitEmail;
    }
}