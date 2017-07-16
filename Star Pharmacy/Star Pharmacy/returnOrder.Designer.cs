namespace Star_Pharmacy
{
    partial class lblProductID
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownReturnQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.cmbBoxProductID = new System.Windows.Forms.ComboBox();
            this.cmbBoxInvoiceNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInvoiceNO = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewSalesDetails = new System.Windows.Forms.DataGridView();
            this.txtBoxCreditNoteNo = new System.Windows.Forms.TextBox();
            this.lblCreditNote = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridViewReturnDetails = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownReturnQuantity);
            this.groupBox1.Controls.Add(this.lblReturnQuantity);
            this.groupBox1.Controls.Add(this.cmbBoxProductID);
            this.groupBox1.Controls.Add(this.cmbBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblInvoiceNO);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dataGridViewSalesDetails);
            this.groupBox1.Location = new System.Drawing.Point(57, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Item";
            // 
            // numericUpDownReturnQuantity
            // 
            this.numericUpDownReturnQuantity.Location = new System.Drawing.Point(131, 163);
            this.numericUpDownReturnQuantity.Name = "numericUpDownReturnQuantity";
            this.numericUpDownReturnQuantity.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownReturnQuantity.TabIndex = 10;
            this.numericUpDownReturnQuantity.ValueChanged += new System.EventHandler(this.numericUpDownReturnQuantity_ValueChanged);
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.Location = new System.Drawing.Point(44, 165);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(81, 13);
            this.lblReturnQuantity.TabIndex = 9;
            this.lblReturnQuantity.Text = "Return Quantity";
            // 
            // cmbBoxProductID
            // 
            this.cmbBoxProductID.FormattingEnabled = true;
            this.cmbBoxProductID.Location = new System.Drawing.Point(332, 23);
            this.cmbBoxProductID.Name = "cmbBoxProductID";
            this.cmbBoxProductID.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProductID.TabIndex = 8;
            this.cmbBoxProductID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductID_SelectedIndexChanged);
            // 
            // cmbBoxInvoiceNo
            // 
            this.cmbBoxInvoiceNo.FormattingEnabled = true;
            this.cmbBoxInvoiceNo.Location = new System.Drawing.Point(108, 23);
            this.cmbBoxInvoiceNo.Name = "cmbBoxInvoiceNo";
            this.cmbBoxInvoiceNo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxInvoiceNo.TabIndex = 7;
            this.cmbBoxInvoiceNo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxInvoiceNo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product ID :";
            // 
            // lblInvoiceNO
            // 
            this.lblInvoiceNO.AutoSize = true;
            this.lblInvoiceNO.Location = new System.Drawing.Point(26, 26);
            this.lblInvoiceNO.Name = "lblInvoiceNO";
            this.lblInvoiceNO.Size = new System.Drawing.Size(65, 13);
            this.lblInvoiceNO.TabIndex = 5;
            this.lblInvoiceNO.Text = "Invoice No :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(387, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(523, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewSalesDetails
            // 
            this.dataGridViewSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesDetails.Location = new System.Drawing.Point(19, 63);
            this.dataGridViewSalesDetails.MultiSelect = false;
            this.dataGridViewSalesDetails.Name = "dataGridViewSalesDetails";
            this.dataGridViewSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesDetails.Size = new System.Drawing.Size(615, 75);
            this.dataGridViewSalesDetails.TabIndex = 0;
            this.dataGridViewSalesDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBoxCreditNoteNo
            // 
            this.txtBoxCreditNoteNo.Location = new System.Drawing.Point(153, 28);
            this.txtBoxCreditNoteNo.Name = "txtBoxCreditNoteNo";
            this.txtBoxCreditNoteNo.ReadOnly = true;
            this.txtBoxCreditNoteNo.Size = new System.Drawing.Size(148, 20);
            this.txtBoxCreditNoteNo.TabIndex = 2;
            this.txtBoxCreditNoteNo.TextChanged += new System.EventHandler(this.txtBoxCreditNoteNo_TextChanged);
            // 
            // lblCreditNote
            // 
            this.lblCreditNote.AutoSize = true;
            this.lblCreditNote.Location = new System.Drawing.Point(64, 31);
            this.lblCreditNote.Name = "lblCreditNote";
            this.lblCreditNote.Size = new System.Drawing.Size(83, 13);
            this.lblCreditNote.TabIndex = 1;
            this.lblCreditNote.Text = "Credit Note No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.dataGridViewReturnDetails);
            this.groupBox2.Location = new System.Drawing.Point(57, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Items";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(521, 184);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataGridViewReturnDetails
            // 
            this.dataGridViewReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.ProductID,
            this.ProductName,
            this.CashierID,
            this.CreatedDate,
            this.CreatedTime,
            this.Quantity,
            this.Amount,
            this.Branch});
            this.dataGridViewReturnDetails.Location = new System.Drawing.Point(20, 31);
            this.dataGridViewReturnDetails.MultiSelect = false;
            this.dataGridViewReturnDetails.Name = "dataGridViewReturnDetails";
            this.dataGridViewReturnDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReturnDetails.Size = new System.Drawing.Size(615, 115);
            this.dataGridViewReturnDetails.TabIndex = 0;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.HeaderText = "Invoice No";
            this.InvoiceNo.Name = "InvoiceNo";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // CashierID
            // 
            this.CashierID.HeaderText = "Cashier ID";
            this.CashierID.Name = "CashierID";
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            // 
            // CreatedTime
            // 
            this.CreatedTime.HeaderText = "Created Time";
            this.CreatedTime.Name = "CreatedTime";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(581, 564);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Finish";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 564);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProductID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCreditNote);
            this.Controls.Add(this.txtBoxCreditNoteNo);
            this.Name = "lblProductID";
            this.Text = "returnOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSalesDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxCreditNoteNo;
        private System.Windows.Forms.Label lblCreditNote;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dataGridViewReturnDetails;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbBoxInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInvoiceNO;
        private System.Windows.Forms.ComboBox cmbBoxProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Label lblReturnQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownReturnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
    }
}