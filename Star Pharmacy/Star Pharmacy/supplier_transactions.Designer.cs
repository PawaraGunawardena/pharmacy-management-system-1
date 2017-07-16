namespace Star_Pharmacy
{
    partial class supplier_transactions
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
            this.supplier_transactionsDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionID_search = new System.Windows.Forms.NumericUpDown();
            this.itemID_search = new System.Windows.Forms.NumericUpDown();
            this.supDetails_search = new System.Windows.Forms.ComboBox();
            this.pharmacyDataSet3 = new Star_Pharmacy.pharmacyDataSet3();
            this.supplierdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierdetailsTableAdapter = new Star_Pharmacy.pharmacyDataSet3TableAdapters.supplierdetailsTableAdapter();
            this.supplierdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.supplier_transactionsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionID_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemID_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_transactionsDetails
            // 
            this.supplier_transactionsDetails.AllowUserToAddRows = false;
            this.supplier_transactionsDetails.AllowUserToDeleteRows = false;
            this.supplier_transactionsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplier_transactionsDetails.Location = new System.Drawing.Point(23, 83);
            this.supplier_transactionsDetails.Name = "supplier_transactionsDetails";
            this.supplier_transactionsDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplier_transactionsDetails.Size = new System.Drawing.Size(770, 335);
            this.supplier_transactionsDetails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ItemID";
            // 
            // transactionID_search
            // 
            this.transactionID_search.Location = new System.Drawing.Point(103, 34);
            this.transactionID_search.Name = "transactionID_search";
            this.transactionID_search.Size = new System.Drawing.Size(129, 20);
            this.transactionID_search.TabIndex = 4;
            // 
            // itemID_search
            // 
            this.itemID_search.Location = new System.Drawing.Point(344, 34);
            this.itemID_search.Name = "itemID_search";
            this.itemID_search.Size = new System.Drawing.Size(129, 20);
            this.itemID_search.TabIndex = 5;
            // 
            // supDetails_search
            // 
            this.supDetails_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supDetails_search.FormattingEnabled = true;
            this.supDetails_search.Location = new System.Drawing.Point(620, 33);
            this.supDetails_search.Name = "supDetails_search";
            this.supDetails_search.Size = new System.Drawing.Size(172, 21);
            this.supDetails_search.TabIndex = 6;
            // 
            // pharmacyDataSet3
            // 
            this.pharmacyDataSet3.DataSetName = "pharmacyDataSet3";
            this.pharmacyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierdetailsBindingSource
            // 
            this.supplierdetailsBindingSource.DataMember = "supplierdetails";
            this.supplierdetailsBindingSource.DataSource = this.pharmacyDataSet3;
            // 
            // supplierdetailsTableAdapter
            // 
            this.supplierdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // supplierdetailsBindingSource1
            // 
            this.supplierdetailsBindingSource1.DataMember = "supplierdetails";
            this.supplierdetailsBindingSource1.DataSource = this.pharmacyDataSet3;
            // 
            // supplier_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 568);
            this.Controls.Add(this.supDetails_search);
            this.Controls.Add(this.itemID_search);
            this.Controls.Add(this.transactionID_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplier_transactionsDetails);
            this.Name = "supplier_transactions";
            this.Text = "Supplier Transactions";
            this.Load += new System.EventHandler(this.supplier_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplier_transactionsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionID_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemID_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView supplier_transactionsDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown transactionID_search;
        private System.Windows.Forms.NumericUpDown itemID_search;
        private System.Windows.Forms.ComboBox supDetails_search;
        private pharmacyDataSet3 pharmacyDataSet3;
        private System.Windows.Forms.BindingSource supplierdetailsBindingSource;
        private pharmacyDataSet3TableAdapters.supplierdetailsTableAdapter supplierdetailsTableAdapter;
        private System.Windows.Forms.BindingSource supplierdetailsBindingSource1;
    }
}