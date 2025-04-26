namespace Retreat_Management_System
{
    partial class EditRetreats
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditSelectedRetreat = new System.Windows.Forms.Button();
            this.btnDeleteSelectedRetreat = new System.Windows.Forms.Button();
            this.btnBackToAdminDashboard = new System.Windows.Forms.Button();
            this.txtRetreatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Retreat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtRetreatName,
            this.txtLocation,
            this.dtpStartDate,
            this.dtpEndDate,
            this.numPrice,
            this.numCapacity});
            this.dataGridView1.Location = new System.Drawing.Point(284, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 439);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEditSelectedRetreat
            // 
            this.btnEditSelectedRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSelectedRetreat.Location = new System.Drawing.Point(324, 678);
            this.btnEditSelectedRetreat.Name = "btnEditSelectedRetreat";
            this.btnEditSelectedRetreat.Size = new System.Drawing.Size(147, 29);
            this.btnEditSelectedRetreat.TabIndex = 2;
            this.btnEditSelectedRetreat.Text = "Edit Selection";
            this.btnEditSelectedRetreat.UseVisualStyleBackColor = true;
            this.btnEditSelectedRetreat.Click += new System.EventHandler(this.BtnEditSelectedRetreat_Click);
            // 
            // btnDeleteSelectedRetreat
            // 
            this.btnDeleteSelectedRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedRetreat.Location = new System.Drawing.Point(581, 678);
            this.btnDeleteSelectedRetreat.Name = "btnDeleteSelectedRetreat";
            this.btnDeleteSelectedRetreat.Size = new System.Drawing.Size(147, 29);
            this.btnDeleteSelectedRetreat.TabIndex = 3;
            this.btnDeleteSelectedRetreat.Text = "Delete Selection";
            this.btnDeleteSelectedRetreat.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedRetreat.Click += new System.EventHandler(this.BtnDeleteSelectedRetreat_Click);
            // 
            // btnBackToAdminDashboard
            // 
            this.btnBackToAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAdminDashboard.Location = new System.Drawing.Point(829, 678);
            this.btnBackToAdminDashboard.Name = "btnBackToAdminDashboard";
            this.btnBackToAdminDashboard.Size = new System.Drawing.Size(219, 29);
            this.btnBackToAdminDashboard.TabIndex = 4;
            this.btnBackToAdminDashboard.Text = "Back to Admin Dashboard";
            this.btnBackToAdminDashboard.UseVisualStyleBackColor = true;
            this.btnBackToAdminDashboard.Click += new System.EventHandler(this.BtnBackToAdminDashboard_Click);
            // 
            // txtRetreatName
            // 
            this.txtRetreatName.HeaderText = "Retreat Name";
            this.txtRetreatName.MinimumWidth = 6;
            this.txtRetreatName.Name = "txtRetreatName";
            this.txtRetreatName.Width = 125;
            // 
            // txtLocation
            // 
            this.txtLocation.HeaderText = "Location";
            this.txtLocation.MinimumWidth = 6;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Width = 125;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.HeaderText = "Start Date";
            this.dtpStartDate.MinimumWidth = 6;
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Width = 125;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.HeaderText = "End Date";
            this.dtpEndDate.MinimumWidth = 6;
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Width = 125;
            // 
            // numPrice
            // 
            this.numPrice.HeaderText = "Price";
            this.numPrice.MinimumWidth = 6;
            this.numPrice.Name = "numPrice";
            this.numPrice.Width = 125;
            // 
            // numCapacity
            // 
            this.numCapacity.HeaderText = "Capacity";
            this.numCapacity.MinimumWidth = 6;
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Width = 125;
            // 
            // EditRetreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 838);
            this.Controls.Add(this.btnBackToAdminDashboard);
            this.Controls.Add(this.btnDeleteSelectedRetreat);
            this.Controls.Add(this.btnEditSelectedRetreat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditRetreats";
            this.Text = "EditRetreats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditSelectedRetreat;
        private System.Windows.Forms.Button btnDeleteSelectedRetreat;
        private System.Windows.Forms.Button btnBackToAdminDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRetreatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtpStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtpEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCapacity;
    }
}