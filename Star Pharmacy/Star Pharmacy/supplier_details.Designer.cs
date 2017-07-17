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
            this.btnViewCredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewSupplierDetails = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supID_nud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supID_nud)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.supplierDetailsDgv.Location = new System.Drawing.Point(21, 85);
            this.supplierDetailsDgv.MultiSelect = false;
            this.supplierDetailsDgv.Name = "supplierDetailsDgv";
            this.supplierDetailsDgv.ReadOnly = true;
            this.supplierDetailsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierDetailsDgv.Size = new System.Drawing.Size(669, 291);
            this.supplierDetailsDgv.TabIndex = 0;
            this.supplierDetailsDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierDetailsDgv_CellContentClick);
            // 
            // btnViewCredit
            // 
            this.btnViewCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewCredit.Location = new System.Drawing.Point(385, 18);
            this.btnViewCredit.Name = "btnViewCredit";
            this.btnViewCredit.Size = new System.Drawing.Size(112, 43);
            this.btnViewCredit.TabIndex = 2;
            this.btnViewCredit.Text = "View Credit";
            this.btnViewCredit.UseVisualStyleBackColor = true;
            this.btnViewCredit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suppliers";
            // 
            // btnViewSupplierDetails
            // 
            this.btnViewSupplierDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewSupplierDetails.Location = new System.Drawing.Point(244, 18);
            this.btnViewSupplierDetails.Name = "btnViewSupplierDetails";
            this.btnViewSupplierDetails.Size = new System.Drawing.Size(125, 43);
            this.btnViewSupplierDetails.TabIndex = 4;
            this.btnViewSupplierDetails.Text = "View Suppliers Details";
            this.btnViewSupplierDetails.UseVisualStyleBackColor = true;
            this.btnViewSupplierDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSuppliers.Location = new System.Drawing.Point(111, 18);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(125, 43);
            this.btnAddSuppliers.TabIndex = 5;
            this.btnAddSuppliers.Text = "Add Suppliers";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove_btn.Location = new System.Drawing.Point(509, 18);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(125, 43);
            this.remove_btn.TabIndex = 7;
            this.remove_btn.Text = "Remove Suppliers";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Note - Select a Row first.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.supID_nud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(79, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 125);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(482, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Company Telephone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(482, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Person Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Person";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Company Name";
            // 
            // supID_nud
            // 
            this.supID_nud.Location = new System.Drawing.Point(124, 19);
            this.supID_nud.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.supID_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.supID_nud.Name = "supID_nud";
            this.supID_nud.Size = new System.Drawing.Size(120, 20);
            this.supID_nud.TabIndex = 1;
            this.supID_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.remove_btn);
            this.groupBox2.Controls.Add(this.btnAddSuppliers);
            this.groupBox2.Controls.Add(this.btnViewSupplierDetails);
            this.groupBox2.Controls.Add(this.btnViewCredit);
            this.groupBox2.Controls.Add(this.supplierDetailsDgv);
            this.groupBox2.Location = new System.Drawing.Point(79, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 396);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // supplier_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "supplier_details";
            this.Text = "Supplier Details";
            this.Load += new System.EventHandler(this.supplier_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supID_nud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewSupplierDetails;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button remove_btn;
        protected System.Windows.Forms.DataGridView supplierDetailsDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown supID_nud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}