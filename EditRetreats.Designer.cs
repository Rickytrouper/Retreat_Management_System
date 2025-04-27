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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditSelectedRetreat = new System.Windows.Forms.Button();
            this.btnDeleteSelectedRetreat = new System.Windows.Forms.Button();
            this.btnBackToAdminDashboard = new System.Windows.Forms.Button();
            this.retreatDetails = new Retreat_Management_System.RetreatDetails();
            this.retreatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retreatTableAdapter = new Retreat_Management_System.RetreatDetailsTableAdapters.RetreatTableAdapter();
            this.dataGVRetreats = new System.Windows.Forms.DataGridView();
            this.retreatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.retreatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retreatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.retreatDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRetreats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Retreat";
            // 
            // btnEditSelectedRetreat
            // 
            this.btnEditSelectedRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSelectedRetreat.Location = new System.Drawing.Point(192, 548);
            this.btnEditSelectedRetreat.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSelectedRetreat.Name = "btnEditSelectedRetreat";
            this.btnEditSelectedRetreat.Size = new System.Drawing.Size(110, 24);
            this.btnEditSelectedRetreat.TabIndex = 2;
            this.btnEditSelectedRetreat.Text = "Edit Selection";
            this.btnEditSelectedRetreat.UseVisualStyleBackColor = true;
            this.btnEditSelectedRetreat.Click += new System.EventHandler(this.btnEditSelectedRetreat_Click_1);
            // 
            // btnDeleteSelectedRetreat
            // 
            this.btnDeleteSelectedRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedRetreat.Location = new System.Drawing.Point(385, 548);
            this.btnDeleteSelectedRetreat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSelectedRetreat.Name = "btnDeleteSelectedRetreat";
            this.btnDeleteSelectedRetreat.Size = new System.Drawing.Size(110, 24);
            this.btnDeleteSelectedRetreat.TabIndex = 3;
            this.btnDeleteSelectedRetreat.Text = "Delete Selection";
            this.btnDeleteSelectedRetreat.UseVisualStyleBackColor = true;
            // 
            // btnBackToAdminDashboard
            // 
            this.btnBackToAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAdminDashboard.Location = new System.Drawing.Point(571, 548);
            this.btnBackToAdminDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToAdminDashboard.Name = "btnBackToAdminDashboard";
            this.btnBackToAdminDashboard.Size = new System.Drawing.Size(164, 24);
            this.btnBackToAdminDashboard.TabIndex = 4;
            this.btnBackToAdminDashboard.Text = "Back to Admin Dashboard";
            this.btnBackToAdminDashboard.UseVisualStyleBackColor = true;
            this.btnBackToAdminDashboard.Click += new System.EventHandler(this.btnBackToAdminDashboard_Click);
            // 
            // retreatDetails
            // 
            this.retreatDetails.DataSetName = "RetreatDetails";
            this.retreatDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retreatBindingSource
            // 
            this.retreatBindingSource.DataMember = "Retreat";
            this.retreatBindingSource.DataSource = this.retreatDetails;
            // 
            // retreatTableAdapter
            // 
            this.retreatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGVRetreats
            // 
            this.dataGVRetreats.AutoGenerateColumns = false;
            this.dataGVRetreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVRetreats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.retreatIDDataGridViewTextBoxColumn,
            this.retreatNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.imageURLDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.organizerIDDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn});
            this.dataGVRetreats.DataSource = this.retreatBindingSource1;
            this.dataGVRetreats.Location = new System.Drawing.Point(43, 120);
            this.dataGVRetreats.Name = "dataGVRetreats";
            this.dataGVRetreats.Size = new System.Drawing.Size(851, 394);
            this.dataGVRetreats.TabIndex = 5;
            // 
            // retreatBindingSource1
            // 
            this.retreatBindingSource1.DataMember = "Retreat";
            this.retreatBindingSource1.DataSource = this.retreatDetails;
            // 
            // retreatIDDataGridViewTextBoxColumn
            // 
            this.retreatIDDataGridViewTextBoxColumn.DataPropertyName = "RetreatID";
            this.retreatIDDataGridViewTextBoxColumn.HeaderText = "RetreatID";
            this.retreatIDDataGridViewTextBoxColumn.Name = "retreatIDDataGridViewTextBoxColumn";
            this.retreatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retreatNameDataGridViewTextBoxColumn
            // 
            this.retreatNameDataGridViewTextBoxColumn.DataPropertyName = "RetreatName";
            this.retreatNameDataGridViewTextBoxColumn.HeaderText = "RetreatName";
            this.retreatNameDataGridViewTextBoxColumn.Name = "retreatNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // imageURLDataGridViewTextBoxColumn
            // 
            this.imageURLDataGridViewTextBoxColumn.DataPropertyName = "ImageURL";
            this.imageURLDataGridViewTextBoxColumn.HeaderText = "ImageURL";
            this.imageURLDataGridViewTextBoxColumn.Name = "imageURLDataGridViewTextBoxColumn";
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // organizerIDDataGridViewTextBoxColumn
            // 
            this.organizerIDDataGridViewTextBoxColumn.DataPropertyName = "OrganizerID";
            this.organizerIDDataGridViewTextBoxColumn.HeaderText = "OrganizerID";
            this.organizerIDDataGridViewTextBoxColumn.Name = "organizerIDDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            // 
            // EditRetreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.dataGVRetreats);
            this.Controls.Add(this.btnBackToAdminDashboard);
            this.Controls.Add(this.btnDeleteSelectedRetreat);
            this.Controls.Add(this.btnEditSelectedRetreat);
            this.Controls.Add(this.label1);
            this.Name = "EditRetreats";
            this.Text = "EditRetreats";
            this.Load += new System.EventHandler(this.EditRetreats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.retreatDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRetreats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retreatBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSelectedRetreat;
        private System.Windows.Forms.Button btnDeleteSelectedRetreat;
        private System.Windows.Forms.Button btnBackToAdminDashboard;
        private RetreatDetails retreatDetails;
        private System.Windows.Forms.BindingSource retreatBindingSource;
        private RetreatDetailsTableAdapters.RetreatTableAdapter retreatTableAdapter;
        private System.Windows.Forms.DataGridView dataGVRetreats;
        private System.Windows.Forms.DataGridViewTextBoxColumn retreatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retreatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource retreatBindingSource1;
    }
}