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
            this.btnShowAvailability = new System.Windows.Forms.Button();
            this.cmbBoxBrandName = new System.Windows.Forms.ComboBox();
            this.cmbBoxMedicalName = new System.Windows.Forms.ComboBox();
            this.cmbBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.cmbBoxProductID = new System.Windows.Forms.ComboBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblMedicalName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.grpBoxAvailabilityDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewAvailabilityDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxProductID = new System.Windows.Forms.CheckBox();
            this.cBoxSupplierName = new System.Windows.Forms.CheckBox();
            this.cBoxBrandName = new System.Windows.Forms.CheckBox();
            this.cBoxUnitPrice = new System.Windows.Forms.CheckBox();
            this.cBoxReoderLevel = new System.Windows.Forms.CheckBox();
            this.cBoxMedicalName = new System.Windows.Forms.CheckBox();
            this.cBoxExpiryDate = new System.Windows.Forms.CheckBox();
            this.cBoxInStockAmount = new System.Windows.Forms.CheckBox();
            this.radioButtonWelivita = new System.Windows.Forms.RadioButton();
            this.radioButtonBothBranches = new System.Windows.Forms.RadioButton();
            this.radioButtonMelleriawa = new System.Windows.Forms.RadioButton();
            this.grpBoxItemDetails.SuspendLayout();
            this.grpBoxAvailabilityDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailabilityDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.grpBoxItemDetails.Location = new System.Drawing.Point(33, 60);
            this.grpBoxItemDetails.Name = "grpBoxItemDetails";
            this.grpBoxItemDetails.Size = new System.Drawing.Size(787, 168);
            this.grpBoxItemDetails.TabIndex = 0;
            this.grpBoxItemDetails.TabStop = false;
            this.grpBoxItemDetails.Text = "Item Details";
            // 
            // btnShowAvailability
            // 
            this.btnShowAvailability.Location = new System.Drawing.Point(569, 113);
            this.btnShowAvailability.Name = "btnShowAvailability";
            this.btnShowAvailability.Size = new System.Drawing.Size(151, 37);
            this.btnShowAvailability.TabIndex = 8;
            this.btnShowAvailability.Text = "Show Availability";
            this.btnShowAvailability.UseVisualStyleBackColor = true;
            this.btnShowAvailability.Click += new System.EventHandler(this.btnShowAvailability_Click);
            // 
            // cmbBoxBrandName
            // 
            this.cmbBoxBrandName.FormattingEnabled = true;
            this.cmbBoxBrandName.Location = new System.Drawing.Point(537, 70);
            this.cmbBoxBrandName.Name = "cmbBoxBrandName";
            this.cmbBoxBrandName.Size = new System.Drawing.Size(183, 21);
            this.cmbBoxBrandName.TabIndex = 7;
            this.cmbBoxBrandName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBrandName_SelectedIndexChanged);
            // 
            // cmbBoxMedicalName
            // 
            this.cmbBoxMedicalName.FormattingEnabled = true;
            this.cmbBoxMedicalName.Location = new System.Drawing.Point(537, 32);
            this.cmbBoxMedicalName.Name = "cmbBoxMedicalName";
            this.cmbBoxMedicalName.Size = new System.Drawing.Size(183, 21);
            this.cmbBoxMedicalName.TabIndex = 6;
            this.cmbBoxMedicalName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMedicalName_SelectedIndexChanged);
            // 
            // cmbBoxSupplierName
            // 
            this.cmbBoxSupplierName.FormattingEnabled = true;
            this.cmbBoxSupplierName.Location = new System.Drawing.Point(150, 70);
            this.cmbBoxSupplierName.Name = "cmbBoxSupplierName";
            this.cmbBoxSupplierName.Size = new System.Drawing.Size(195, 21);
            this.cmbBoxSupplierName.TabIndex = 5;
            this.cmbBoxSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSupplierName_SelectedIndexChanged);
            // 
            // cmbBoxProductID
            // 
            this.cmbBoxProductID.FormattingEnabled = true;
            this.cmbBoxProductID.Location = new System.Drawing.Point(150, 32);
            this.cmbBoxProductID.Name = "cmbBoxProductID";
            this.cmbBoxProductID.Size = new System.Drawing.Size(195, 21);
            this.cmbBoxProductID.TabIndex = 4;
            this.cmbBoxProductID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductID_SelectedIndexChanged);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(425, 73);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(72, 13);
            this.lblBrandName.TabIndex = 3;
            this.lblBrandName.Text = "Brand Name :";
            // 
            // lblMedicalName
            // 
            this.lblMedicalName.AutoSize = true;
            this.lblMedicalName.Location = new System.Drawing.Point(425, 35);
            this.lblMedicalName.Name = "lblMedicalName";
            this.lblMedicalName.Size = new System.Drawing.Size(81, 13);
            this.lblMedicalName.TabIndex = 2;
            this.lblMedicalName.Text = "Medical Name :";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(55, 73);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(82, 13);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier Name :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(55, 35);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(64, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID :";
            // 
            // grpBoxAvailabilityDetails
            // 
            this.grpBoxAvailabilityDetails.Controls.Add(this.dataGridViewAvailabilityDetails);
            this.grpBoxAvailabilityDetails.Location = new System.Drawing.Point(15, 153);
            this.grpBoxAvailabilityDetails.Name = "grpBoxAvailabilityDetails";
            this.grpBoxAvailabilityDetails.Size = new System.Drawing.Size(756, 189);
            this.grpBoxAvailabilityDetails.TabIndex = 1;
            this.grpBoxAvailabilityDetails.TabStop = false;
            this.grpBoxAvailabilityDetails.Text = "Availability Details";
            // 
            // dataGridViewAvailabilityDetails
            // 
            this.dataGridViewAvailabilityDetails.AllowUserToAddRows = false;
            this.dataGridViewAvailabilityDetails.AllowUserToDeleteRows = false;
            this.dataGridViewAvailabilityDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailabilityDetails.Location = new System.Drawing.Point(14, 28);
            this.dataGridViewAvailabilityDetails.Name = "dataGridViewAvailabilityDetails";
            this.dataGridViewAvailabilityDetails.ReadOnly = true;
            this.dataGridViewAvailabilityDetails.Size = new System.Drawing.Size(721, 135);
            this.dataGridViewAvailabilityDetails.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(539, 642);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(681, 642);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowMore
            // 
            this.btnShowMore.Location = new System.Drawing.Point(111, 58);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(149, 41);
            this.btnShowMore.TabIndex = 4;
            this.btnShowMore.Text = "Show More";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMelleriawa);
            this.groupBox1.Controls.Add(this.radioButtonBothBranches);
            this.groupBox1.Controls.Add(this.radioButtonWelivita);
            this.groupBox1.Controls.Add(this.cBoxInStockAmount);
            this.groupBox1.Controls.Add(this.cBoxExpiryDate);
            this.groupBox1.Controls.Add(this.cBoxMedicalName);
            this.groupBox1.Controls.Add(this.cBoxReoderLevel);
            this.groupBox1.Controls.Add(this.cBoxUnitPrice);
            this.groupBox1.Controls.Add(this.cBoxBrandName);
            this.groupBox1.Controls.Add(this.cBoxSupplierName);
            this.groupBox1.Controls.Add(this.cBoxProductID);
            this.groupBox1.Controls.Add(this.btnShowMore);
            this.groupBox1.Controls.Add(this.grpBoxAvailabilityDetails);
            this.groupBox1.Location = new System.Drawing.Point(33, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 360);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "More Details :";
            // 
            // cBoxProductID
            // 
            this.cBoxProductID.AutoSize = true;
            this.cBoxProductID.Location = new System.Drawing.Point(313, 35);
            this.cBoxProductID.Name = "cBoxProductID";
            this.cBoxProductID.Size = new System.Drawing.Size(77, 17);
            this.cBoxProductID.TabIndex = 5;
            this.cBoxProductID.Text = "Product ID";
            this.cBoxProductID.UseVisualStyleBackColor = true;
            // 
            // cBoxSupplierName
            // 
            this.cBoxSupplierName.AutoSize = true;
            this.cBoxSupplierName.Location = new System.Drawing.Point(313, 60);
            this.cBoxSupplierName.Name = "cBoxSupplierName";
            this.cBoxSupplierName.Size = new System.Drawing.Size(95, 17);
            this.cBoxSupplierName.TabIndex = 6;
            this.cBoxSupplierName.Text = "Supplier Name";
            this.cBoxSupplierName.UseVisualStyleBackColor = true;
            // 
            // cBoxBrandName
            // 
            this.cBoxBrandName.AutoSize = true;
            this.cBoxBrandName.Location = new System.Drawing.Point(449, 35);
            this.cBoxBrandName.Name = "cBoxBrandName";
            this.cBoxBrandName.Size = new System.Drawing.Size(85, 17);
            this.cBoxBrandName.TabIndex = 7;
            this.cBoxBrandName.Text = "Brand Name";
            this.cBoxBrandName.UseVisualStyleBackColor = true;
            // 
            // cBoxUnitPrice
            // 
            this.cBoxUnitPrice.AutoSize = true;
            this.cBoxUnitPrice.Location = new System.Drawing.Point(449, 58);
            this.cBoxUnitPrice.Name = "cBoxUnitPrice";
            this.cBoxUnitPrice.Size = new System.Drawing.Size(72, 17);
            this.cBoxUnitPrice.TabIndex = 8;
            this.cBoxUnitPrice.Text = "Unit Price";
            this.cBoxUnitPrice.UseVisualStyleBackColor = true;
            // 
            // cBoxReoderLevel
            // 
            this.cBoxReoderLevel.AutoSize = true;
            this.cBoxReoderLevel.Location = new System.Drawing.Point(449, 83);
            this.cBoxReoderLevel.Name = "cBoxReoderLevel";
            this.cBoxReoderLevel.Size = new System.Drawing.Size(93, 17);
            this.cBoxReoderLevel.TabIndex = 9;
            this.cBoxReoderLevel.Text = "Reorder Level";
            this.cBoxReoderLevel.UseVisualStyleBackColor = true;
            // 
            // cBoxMedicalName
            // 
            this.cBoxMedicalName.AutoSize = true;
            this.cBoxMedicalName.Location = new System.Drawing.Point(569, 35);
            this.cBoxMedicalName.Name = "cBoxMedicalName";
            this.cBoxMedicalName.Size = new System.Drawing.Size(94, 17);
            this.cBoxMedicalName.TabIndex = 11;
            this.cBoxMedicalName.Text = "Medical Name";
            this.cBoxMedicalName.UseVisualStyleBackColor = true;
            // 
            // cBoxExpiryDate
            // 
            this.cBoxExpiryDate.AutoSize = true;
            this.cBoxExpiryDate.Location = new System.Drawing.Point(569, 59);
            this.cBoxExpiryDate.Name = "cBoxExpiryDate";
            this.cBoxExpiryDate.Size = new System.Drawing.Size(80, 17);
            this.cBoxExpiryDate.TabIndex = 12;
            this.cBoxExpiryDate.Text = "Expiry Date";
            this.cBoxExpiryDate.UseVisualStyleBackColor = true;
            // 
            // cBoxInStockAmount
            // 
            this.cBoxInStockAmount.AutoSize = true;
            this.cBoxInStockAmount.Location = new System.Drawing.Point(313, 82);
            this.cBoxInStockAmount.Name = "cBoxInStockAmount";
            this.cBoxInStockAmount.Size = new System.Drawing.Size(62, 17);
            this.cBoxInStockAmount.TabIndex = 13;
            this.cBoxInStockAmount.Text = "Amount";
            this.cBoxInStockAmount.UseVisualStyleBackColor = true;
            // 
            // radioButtonWelivita
            // 
            this.radioButtonWelivita.AutoSize = true;
            this.radioButtonWelivita.Location = new System.Drawing.Point(449, 118);
            this.radioButtonWelivita.Name = "radioButtonWelivita";
            this.radioButtonWelivita.Size = new System.Drawing.Size(100, 17);
            this.radioButtonWelivita.TabIndex = 14;
            this.radioButtonWelivita.TabStop = true;
            this.radioButtonWelivita.Text = "Welivita Branch";
            this.radioButtonWelivita.UseVisualStyleBackColor = true;
            // 
            // radioButtonBothBranches
            // 
            this.radioButtonBothBranches.AutoSize = true;
            this.radioButtonBothBranches.Location = new System.Drawing.Point(313, 118);
            this.radioButtonBothBranches.Name = "radioButtonBothBranches";
            this.radioButtonBothBranches.Size = new System.Drawing.Size(95, 17);
            this.radioButtonBothBranches.TabIndex = 15;
            this.radioButtonBothBranches.TabStop = true;
            this.radioButtonBothBranches.Text = "Both Branches";
            this.radioButtonBothBranches.UseVisualStyleBackColor = true;
            // 
            // radioButtonMelleriawa
            // 
            this.radioButtonMelleriawa.AutoSize = true;
            this.radioButtonMelleriawa.Location = new System.Drawing.Point(569, 118);
            this.radioButtonMelleriawa.Name = "radioButtonMelleriawa";
            this.radioButtonMelleriawa.Size = new System.Drawing.Size(117, 17);
            this.radioButtonMelleriawa.TabIndex = 16;
            this.radioButtonMelleriawa.TabStop = true;
            this.radioButtonMelleriawa.Text = "Mulleriyawa Branch";
            this.radioButtonMelleriawa.UseVisualStyleBackColor = true;
            // 
            // LookupItemAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxItemDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Name = "LookupItemAvailability";
            this.Text = "LookupItemAvailability";
            this.Load += new System.EventHandler(this.LookupItemAvailability_Load);
            this.grpBoxItemDetails.ResumeLayout(false);
            this.grpBoxItemDetails.PerformLayout();
            this.grpBoxAvailabilityDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailabilityDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxInStockAmount;
        private System.Windows.Forms.CheckBox cBoxExpiryDate;
        private System.Windows.Forms.CheckBox cBoxMedicalName;
        private System.Windows.Forms.CheckBox cBoxReoderLevel;
        private System.Windows.Forms.CheckBox cBoxUnitPrice;
        private System.Windows.Forms.CheckBox cBoxBrandName;
        private System.Windows.Forms.CheckBox cBoxSupplierName;
        private System.Windows.Forms.CheckBox cBoxProductID;
        private System.Windows.Forms.RadioButton radioButtonMelleriawa;
        private System.Windows.Forms.RadioButton radioButtonBothBranches;
        private System.Windows.Forms.RadioButton radioButtonWelivita;
    }
}