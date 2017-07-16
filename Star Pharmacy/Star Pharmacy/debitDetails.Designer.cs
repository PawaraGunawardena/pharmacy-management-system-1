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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supDetails_search = new System.Windows.Forms.ComboBox();
            this.Amount_search = new System.Windows.Forms.NumericUpDown();
            this.debitID_search = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitID_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supDetails_search);
            this.groupBox2.Controls.Add(this.Amount_search);
            this.groupBox2.Controls.Add(this.debitID_search);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 57);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Debit Details";
            // 
            // supDetails_search
            // 
            this.supDetails_search.DisplayMember = "CompanyName";
            this.supDetails_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supDetails_search.FormattingEnabled = true;
            this.supDetails_search.Location = new System.Drawing.Point(599, 21);
            this.supDetails_search.Name = "supDetails_search";
            this.supDetails_search.Size = new System.Drawing.Size(175, 21);
            this.supDetails_search.TabIndex = 12;
            this.supDetails_search.ValueMember = "CompanyName";
            // 
            // Amount_search
            // 
            this.Amount_search.Location = new System.Drawing.Point(352, 22);
            this.Amount_search.Name = "Amount_search";
            this.Amount_search.Size = new System.Drawing.Size(121, 20);
            this.Amount_search.TabIndex = 11;
            // 
            // debitID_search
            // 
            this.debitID_search.Location = new System.Drawing.Point(91, 22);
            this.debitID_search.Name = "debitID_search";
            this.debitID_search.Size = new System.Drawing.Size(121, 20);
            this.debitID_search.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount     Rs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Debit ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 302);
            this.dataGridView1.TabIndex = 17;
            // 
            // debitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "debitDetails";
            this.Text = "Debit Details";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitID_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}