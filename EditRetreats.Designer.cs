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
            this.dataGridViewRetreats = new System.Windows.Forms.DataGridView();
            this.btnEditSelectedRetreat = new System.Windows.Forms.Button();
            this.btnDeleteSelectedRetreat = new System.Windows.Forms.Button();
            this.btnBackToAdminDashboard = new System.Windows.Forms.Button();
            this.RetreatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetreats)).BeginInit();
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
            // dataGridViewRetreats
            // 
            this.dataGridViewRetreats.AllowUserToOrderColumns = true;
            this.dataGridViewRetreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetreats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RetreatName,
            this.Locations,
            this.StartDate,
            this.EndDate,
            this.Price,
            this.Capacity});
            this.dataGridViewRetreats.Location = new System.Drawing.Point(284, 174);
            this.dataGridViewRetreats.Name = "dataGridViewRetreats";
            this.dataGridViewRetreats.RowHeadersWidth = 51;
            this.dataGridViewRetreats.RowTemplate.Height = 24;
            this.dataGridViewRetreats.Size = new System.Drawing.Size(802, 439);
            this.dataGridViewRetreats.TabIndex = 1;
            this.dataGridViewRetreats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // RetreatName
            // 
            this.RetreatName.HeaderText = "Retreat Name";
            this.RetreatName.MinimumWidth = 6;
            this.RetreatName.Name = "RetreatName";
            this.RetreatName.Width = 125;
            // 
            // Locations
            // 
            this.Locations.HeaderText = "Location";
            this.Locations.MinimumWidth = 6;
            this.Locations.Name = "Locations";
            this.Locations.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 125;
            // 
            // EditRetreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 838);
            this.Controls.Add(this.btnBackToAdminDashboard);
            this.Controls.Add(this.btnDeleteSelectedRetreat);
            this.Controls.Add(this.btnEditSelectedRetreat);
            this.Controls.Add(this.dataGridViewRetreats);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditRetreats";
            this.Text = "EditRetreats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRetreats;
        private System.Windows.Forms.Button btnEditSelectedRetreat;
        private System.Windows.Forms.Button btnDeleteSelectedRetreat;
        private System.Windows.Forms.Button btnBackToAdminDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetreatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locations;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
    }
}