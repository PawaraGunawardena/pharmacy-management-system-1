namespace Star_Pharmacy
{
    partial class viewCredit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_supID = new System.Windows.Forms.Label();
            this.lbl_SupName = new System.Windows.Forms.Label();
            this.lblSup_Credit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Credit Due";
            // 
            // lbl_supID
            // 
            this.lbl_supID.AutoSize = true;
            this.lbl_supID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_supID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supID.Location = new System.Drawing.Point(311, 86);
            this.lbl_supID.Name = "lbl_supID";
            this.lbl_supID.Size = new System.Drawing.Size(0, 25);
            this.lbl_supID.TabIndex = 4;
            // 
            // lbl_SupName
            // 
            this.lbl_SupName.AutoSize = true;
            this.lbl_SupName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupName.Location = new System.Drawing.Point(311, 150);
            this.lbl_SupName.Name = "lbl_SupName";
            this.lbl_SupName.Size = new System.Drawing.Size(0, 25);
            this.lbl_SupName.TabIndex = 5;
            // 
            // lblSup_Credit
            // 
            this.lblSup_Credit.AutoSize = true;
            this.lblSup_Credit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSup_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSup_Credit.Location = new System.Drawing.Point(311, 214);
            this.lblSup_Credit.Name = "lblSup_Credit";
            this.lblSup_Credit.Size = new System.Drawing.Size(0, 25);
            this.lblSup_Credit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Essential Details of Suppliers";
            // 
            // viewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSup_Credit);
            this.Controls.Add(this.lbl_SupName);
            this.Controls.Add(this.lbl_supID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "viewCredit";
            this.Text = "View Credit";
            this.Load += new System.EventHandler(this.viewCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_supID;
        public System.Windows.Forms.Label lbl_SupName;
        public System.Windows.Forms.Label lblSup_Credit;
        private System.Windows.Forms.Label label4;
    }
}