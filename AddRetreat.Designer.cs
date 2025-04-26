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
            this.txtRetreatName = new System.Windows.Forms.TextBox();
            this.lbRetreatName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericCapacity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveRetreat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImageUpload = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRetreatName
            // 
            this.txtRetreatName.Location = new System.Drawing.Point(243, 250);
            this.txtRetreatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRetreatName.Name = "txtRetreatName";
            this.txtRetreatName.Size = new System.Drawing.Size(319, 22);
            this.txtRetreatName.TabIndex = 0;
            this.txtRetreatName.TextChanged += new System.EventHandler(this.txtRetreatName_TextChanged);
            // 
            // lbRetreatName
            // 
            this.lbRetreatName.AutoSize = true;
            this.lbRetreatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetreatName.Location = new System.Drawing.Point(85, 249);
            this.lbRetreatName.Name = "lbRetreatName";
            this.lbRetreatName.Size = new System.Drawing.Size(126, 22);
            this.lbRetreatName.TabIndex = 1;
            this.lbRetreatName.Text = "Retreat Name:";
            this.lbRetreatName.Click += new System.EventHandler(this.lbRetreatName_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(491, 124);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(276, 48);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Add a Retreat";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(829, 247);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(319, 22);
            this.txtLocation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Retreat Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Retreat Description:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(829, 313);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(245, 22);
            this.dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(829, 379);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.MinDate = new System.DateTime(2025, 4, 24, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(245, 22);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.Value = new System.DateTime(2025, 5, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(708, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "End Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Location = new System.Drawing.Point(829, 453);
            this.numericPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(139, 22);
            this.numericPrice.TabIndex = 11;
            // 
            // numericCapacity
            // 
            this.numericCapacity.Location = new System.Drawing.Point(829, 507);
            this.numericCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCapacity.Name = "numericCapacity";
            this.numericCapacity.Size = new System.Drawing.Size(139, 22);
            this.numericCapacity.TabIndex = 12;
            // 
            // numPrice
            // 
            this.numPrice.AutoSize = true;
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(741, 450);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(56, 22);
            this.numPrice.TabIndex = 13;
            this.numPrice.Text = "Price:";
            // 
            // numCapacity
            // 
            this.numCapacity.AutoSize = true;
            this.numCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacity.Location = new System.Drawing.Point(713, 507);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(85, 22);
            this.numCapacity.TabIndex = 14;
            this.numCapacity.Text = "Capacity:";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(829, 578);
            this.txtContactInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(245, 22);
            this.txtContactInfo.TabIndex = 17;
            this.txtContactInfo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contact Information:";
            // 
            // btnSaveRetreat
            // 
            this.btnSaveRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRetreat.Location = new System.Drawing.Point(447, 717);
            this.btnSaveRetreat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveRetreat.Name = "btnSaveRetreat";
            this.btnSaveRetreat.Size = new System.Drawing.Size(115, 30);
            this.btnSaveRetreat.TabIndex = 19;
            this.btnSaveRetreat.Text = "Submit";
            this.btnSaveRetreat.UseVisualStyleBackColor = true;
            this.btnSaveRetreat.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(829, 717);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 30);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageUpload.Location = new System.Drawing.Point(243, 578);
            this.btnImageUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(253, 30);
            this.btnImageUpload.TabIndex = 21;
            this.btnImageUpload.Text = "Upload";
            this.btnImageUpload.UseVisualStyleBackColor = true;
            this.btnImageUpload.Click += new System.EventHandler(this.btnImageUpload_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(243, 334);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(319, 177);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Upload Image:";
            // 
            // AddRetreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 838);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnImageUpload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveRetreat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numericCapacity);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbRetreatName);
            this.Controls.Add(this.txtRetreatName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddRetreat";
            this.Text = "AddRetreat";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txtRetreatName;
        private System.Windows.Forms.Label lbRetreatName;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericCapacity;
        private System.Windows.Forms.Label numPrice;
        private System.Windows.Forms.Label numCapacity;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveRetreat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImageUpload;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label6;
    }
}