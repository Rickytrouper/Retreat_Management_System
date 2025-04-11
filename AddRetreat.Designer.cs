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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AddRetreat";
        }

        #endregion

        private System.Windows.Forms.Label lbRetreatName;
        private System.Windows.Forms.TextBox txtRetreatName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label txtStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label txtEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Button btnSaveRetreat;
        private System.Windows.Forms.Button btnCancel;
    }
}