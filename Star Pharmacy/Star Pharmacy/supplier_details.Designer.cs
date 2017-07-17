namespace Star_Pharmacy
{
    partial class supplier_details
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
            this.supplierDetailsDgv = new System.Windows.Forms.DataGridView();
            this.btnViewSupliers = new System.Windows.Forms.Button();
            this.btnViewCredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewSupplierDetails = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierDetailsDgv
            // 
            this.supplierDetailsDgv.AllowUserToAddRows = false;
            this.supplierDetailsDgv.AllowUserToDeleteRows = false;
            this.supplierDetailsDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supplierDetailsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supplierDetailsDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.supplierDetailsDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplierDetailsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDetailsDgv.Location = new System.Drawing.Point(72, 183);
            this.supplierDetailsDgv.MultiSelect = false;
            this.supplierDetailsDgv.Name = "supplierDetailsDgv";
            this.supplierDetailsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierDetailsDgv.Size = new System.Drawing.Size(579, 340);
            this.supplierDetailsDgv.TabIndex = 0;
            this.supplierDetailsDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierDetailsDgv_CellContentClick);
            // 
            // btnViewSupliers
            // 
            this.btnViewSupliers.Location = new System.Drawing.Point(84, 92);
            this.btnViewSupliers.Name = "btnViewSupliers";
            this.btnViewSupliers.Size = new System.Drawing.Size(90, 43);
            this.btnViewSupliers.TabIndex = 1;
            this.btnViewSupliers.Text = "View Suppliers";
            this.btnViewSupliers.UseVisualStyleBackColor = true;
            this.btnViewSupliers.Click += new System.EventHandler(this.btnViewSupliers_Click);
            // 
            // btnViewCredit
            // 
            this.btnViewCredit.Location = new System.Drawing.Point(577, 92);
            this.btnViewCredit.Name = "btnViewCredit";
            this.btnViewCredit.Size = new System.Drawing.Size(74, 43);
            this.btnViewCredit.TabIndex = 2;
            this.btnViewCredit.Text = "View Credit";
            this.btnViewCredit.UseVisualStyleBackColor = true;
            this.btnViewCredit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suppliers";
            // 
            // btnViewSupplierDetails
            // 
            this.btnViewSupplierDetails.Location = new System.Drawing.Point(400, 92);
            this.btnViewSupplierDetails.Name = "btnViewSupplierDetails";
            this.btnViewSupplierDetails.Size = new System.Drawing.Size(87, 43);
            this.btnViewSupplierDetails.TabIndex = 4;
            this.btnViewSupplierDetails.Text = "View Suppliers Details";
            this.btnViewSupplierDetails.UseVisualStyleBackColor = true;
            this.btnViewSupplierDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Location = new System.Drawing.Point(246, 92);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(87, 43);
            this.btnAddSuppliers.TabIndex = 5;
            this.btnAddSuppliers.Text = "Add Suppliers";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(235, 547);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 43);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove Suppliers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // supplier_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.btnViewSupplierDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewCredit);
            this.Controls.Add(this.btnViewSupliers);
            this.Controls.Add(this.supplierDetailsDgv);
            this.Name = "supplier_details";
            this.Text = "supplier_details";
            this.Load += new System.EventHandler(this.supplier_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewSupliers;
        private System.Windows.Forms.Button btnViewCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewSupplierDetails;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.DataGridView supplierDetailsDgv;
    }
}