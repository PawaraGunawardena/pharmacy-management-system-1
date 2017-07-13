namespace Star_Pharmacy
{
    partial class LookupItemAvailability
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
            this.grpBoxItemDetails = new System.Windows.Forms.GroupBox();
            this.grpBoxAvailabilityDetails = new System.Windows.Forms.GroupBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblMedicalName = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.cmbBoxProductID = new System.Windows.Forms.ComboBox();
            this.cmbBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.cmbBoxMedicalName = new System.Windows.Forms.ComboBox();
            this.cmbBoxBrandName = new System.Windows.Forms.ComboBox();
            this.btnShowAvailability = new System.Windows.Forms.Button();
            this.dataGridViewAvailabilityDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.grpBoxItemDetails.SuspendLayout();
            this.grpBoxAvailabilityDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailabilityDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxItemDetails
            // 
            this.grpBoxItemDetails.Controls.Add(this.btnShowAvailability);
            this.grpBoxItemDetails.Controls.Add(this.cmbBoxBrandName);
            this.grpBoxItemDetails.Controls.Add(this.cmbBoxMedicalName);
            this.grpBoxItemDetails.Controls.Add(this.cmbBoxSupplierName);
            this.grpBoxItemDetails.Controls.Add(this.cmbBoxProductID);
            this.grpBoxItemDetails.Controls.Add(this.lblBrandName);
            this.grpBoxItemDetails.Controls.Add(this.lblMedicalName);
            this.grpBoxItemDetails.Controls.Add(this.lblSupplierName);
            this.grpBoxItemDetails.Controls.Add(this.lblProductID);
            this.grpBoxItemDetails.Location = new System.Drawing.Point(33, 24);
            this.grpBoxItemDetails.Name = "grpBoxItemDetails";
            this.grpBoxItemDetails.Size = new System.Drawing.Size(649, 158);
            this.grpBoxItemDetails.TabIndex = 0;
            this.grpBoxItemDetails.TabStop = false;
            this.grpBoxItemDetails.Text = "Item Details";
            // 
            // grpBoxAvailabilityDetails
            // 
            this.grpBoxAvailabilityDetails.Controls.Add(this.dataGridViewAvailabilityDetails);
            this.grpBoxAvailabilityDetails.Location = new System.Drawing.Point(33, 237);
            this.grpBoxAvailabilityDetails.Name = "grpBoxAvailabilityDetails";
            this.grpBoxAvailabilityDetails.Size = new System.Drawing.Size(649, 189);
            this.grpBoxAvailabilityDetails.TabIndex = 1;
            this.grpBoxAvailabilityDetails.TabStop = false;
            this.grpBoxAvailabilityDetails.Text = "Availability Details";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(26, 35);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(64, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID :";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(26, 73);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(82, 13);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier Name :";
            // 
            // lblMedicalName
            // 
            this.lblMedicalName.AutoSize = true;
            this.lblMedicalName.Location = new System.Drawing.Point(339, 35);
            this.lblMedicalName.Name = "lblMedicalName";
            this.lblMedicalName.Size = new System.Drawing.Size(81, 13);
            this.lblMedicalName.TabIndex = 2;
            this.lblMedicalName.Text = "Medical Name :";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(339, 73);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(72, 13);
            this.lblBrandName.TabIndex = 3;
            this.lblBrandName.Text = "Brand Name :";
            // 
            // cmbBoxProductID
            // 
            this.cmbBoxProductID.FormattingEnabled = true;
            this.cmbBoxProductID.Location = new System.Drawing.Point(137, 32);
            this.cmbBoxProductID.Name = "cmbBoxProductID";
            this.cmbBoxProductID.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProductID.TabIndex = 4;
            this.cmbBoxProductID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductID_SelectedIndexChanged);
            // 
            // cmbBoxSupplierName
            // 
            this.cmbBoxSupplierName.FormattingEnabled = true;
            this.cmbBoxSupplierName.Location = new System.Drawing.Point(137, 70);
            this.cmbBoxSupplierName.Name = "cmbBoxSupplierName";
            this.cmbBoxSupplierName.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSupplierName.TabIndex = 5;
            this.cmbBoxSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSupplierName_SelectedIndexChanged);
            // 
            // cmbBoxMedicalName
            // 
            this.cmbBoxMedicalName.FormattingEnabled = true;
            this.cmbBoxMedicalName.Location = new System.Drawing.Point(440, 32);
            this.cmbBoxMedicalName.Name = "cmbBoxMedicalName";
            this.cmbBoxMedicalName.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxMedicalName.TabIndex = 6;
            this.cmbBoxMedicalName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMedicalName_SelectedIndexChanged);
            // 
            // cmbBoxBrandName
            // 
            this.cmbBoxBrandName.FormattingEnabled = true;
            this.cmbBoxBrandName.Location = new System.Drawing.Point(440, 70);
            this.cmbBoxBrandName.Name = "cmbBoxBrandName";
            this.cmbBoxBrandName.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxBrandName.TabIndex = 7;
            this.cmbBoxBrandName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBrandName_SelectedIndexChanged);
            // 
            // btnShowAvailability
            // 
            this.btnShowAvailability.Location = new System.Drawing.Point(489, 107);
            this.btnShowAvailability.Name = "btnShowAvailability";
            this.btnShowAvailability.Size = new System.Drawing.Size(121, 23);
            this.btnShowAvailability.TabIndex = 8;
            this.btnShowAvailability.Text = "Show Availability";
            this.btnShowAvailability.UseVisualStyleBackColor = true;
            this.btnShowAvailability.Click += new System.EventHandler(this.btnShowAvailability_Click);
            // 
            // dataGridViewAvailabilityDetails
            // 
            this.dataGridViewAvailabilityDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailabilityDetails.Location = new System.Drawing.Point(29, 28);
            this.dataGridViewAvailabilityDetails.Name = "dataGridViewAvailabilityDetails";
            this.dataGridViewAvailabilityDetails.Size = new System.Drawing.Size(581, 135);
            this.dataGridViewAvailabilityDetails.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(504, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(607, 449);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowMore
            // 
            this.btnShowMore.Location = new System.Drawing.Point(522, 199);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(121, 23);
            this.btnShowMore.TabIndex = 4;
            this.btnShowMore.Text = "Show More";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // LookupItemAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 484);
            this.Controls.Add(this.btnShowMore);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBoxAvailabilityDetails);
            this.Controls.Add(this.grpBoxItemDetails);
            this.Name = "LookupItemAvailability";
            this.Text = "LookupItemAvailability";
            this.grpBoxItemDetails.ResumeLayout(false);
            this.grpBoxItemDetails.PerformLayout();
            this.grpBoxAvailabilityDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailabilityDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxItemDetails;
        private System.Windows.Forms.Button btnShowAvailability;
        private System.Windows.Forms.ComboBox cmbBoxBrandName;
        private System.Windows.Forms.ComboBox cmbBoxMedicalName;
        private System.Windows.Forms.ComboBox cmbBoxSupplierName;
        private System.Windows.Forms.ComboBox cmbBoxProductID;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblMedicalName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.GroupBox grpBoxAvailabilityDetails;
        private System.Windows.Forms.DataGridView dataGridViewAvailabilityDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowMore;
    }
}