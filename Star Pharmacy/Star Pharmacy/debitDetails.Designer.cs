namespace Star_Pharmacy
{
    partial class debitDetails
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supDetails_search = new System.Windows.Forms.ComboBox();
            this.Amount_search = new System.Windows.Forms.NumericUpDown();
            this.debitID_search = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.debitDetails_dgv = new System.Windows.Forms.DataGridView();
            this.pharmacyDataSet1 = new Star_Pharmacy.pharmacyDataSet1();
            this.supplierdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierdetailsTableAdapter = new Star_Pharmacy.pharmacyDataSet1TableAdapters.supplierdetailsTableAdapter();
            this.clrBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitID_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitDetails_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clrBtn);
            this.groupBox2.Controls.Add(this.supDetails_search);
            this.groupBox2.Controls.Add(this.Amount_search);
            this.groupBox2.Controls.Add(this.debitID_search);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 57);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Debit Details";
            // 
            // supDetails_search
            // 
            this.supDetails_search.DataSource = this.supplierdetailsBindingSource;
            this.supDetails_search.DisplayMember = "CompanyName";
            this.supDetails_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supDetails_search.FormattingEnabled = true;
            this.supDetails_search.Location = new System.Drawing.Point(526, 21);
            this.supDetails_search.Name = "supDetails_search";
            this.supDetails_search.Size = new System.Drawing.Size(175, 21);
            this.supDetails_search.TabIndex = 12;
            this.supDetails_search.ValueMember = "CompanyName";
            this.supDetails_search.SelectedIndexChanged += new System.EventHandler(this.supDetails_search_SelectedIndexChanged);
            // 
            // Amount_search
            // 
            this.Amount_search.DecimalPlaces = 2;
            this.Amount_search.Location = new System.Drawing.Point(288, 22);
            this.Amount_search.Name = "Amount_search";
            this.Amount_search.Size = new System.Drawing.Size(121, 20);
            this.Amount_search.TabIndex = 11;
            this.Amount_search.ValueChanged += new System.EventHandler(this.Amount_search_ValueChanged);
            // 
            // debitID_search
            // 
            this.debitID_search.Location = new System.Drawing.Point(80, 22);
            this.debitID_search.Name = "debitID_search";
            this.debitID_search.Size = new System.Drawing.Size(93, 20);
            this.debitID_search.TabIndex = 10;
            this.debitID_search.ValueChanged += new System.EventHandler(this.debitID_search_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount     Rs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Debit ID";
            // 
            // debitDetails_dgv
            // 
            this.debitDetails_dgv.AllowUserToAddRows = false;
            this.debitDetails_dgv.AllowUserToDeleteRows = false;
            this.debitDetails_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debitDetails_dgv.Location = new System.Drawing.Point(25, 102);
            this.debitDetails_dgv.Name = "debitDetails_dgv";
            this.debitDetails_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debitDetails_dgv.Size = new System.Drawing.Size(799, 302);
            this.debitDetails_dgv.TabIndex = 17;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet1";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierdetailsBindingSource
            // 
            this.supplierdetailsBindingSource.DataMember = "supplierdetails";
            this.supplierdetailsBindingSource.DataSource = this.pharmacyDataSet1;
            // 
            // supplierdetailsTableAdapter
            // 
            this.supplierdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(718, 19);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 13;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // debitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 435);
            this.Controls.Add(this.debitDetails_dgv);
            this.Controls.Add(this.groupBox2);
            this.Name = "debitDetails";
            this.Text = "Debit Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.debitDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitID_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitDetails_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox supDetails_search;
        private System.Windows.Forms.NumericUpDown Amount_search;
        private System.Windows.Forms.NumericUpDown debitID_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView debitDetails_dgv;
        private pharmacyDataSet1 pharmacyDataSet1;
        private System.Windows.Forms.BindingSource supplierdetailsBindingSource;
        private pharmacyDataSet1TableAdapters.supplierdetailsTableAdapter supplierdetailsTableAdapter;
        private System.Windows.Forms.Button clrBtn;
    }
}