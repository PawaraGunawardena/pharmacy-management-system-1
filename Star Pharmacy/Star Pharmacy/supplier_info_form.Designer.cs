namespace Star_Pharmacy
{
    partial class supplier_info_form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.companyName = new System.Windows.Forms.TextBox();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.contactPersonTelephone = new System.Windows.Forms.TextBox();
            this.companyTelephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Person Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Company Telephone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Credit Amounts";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(280, 99);
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Size = new System.Drawing.Size(282, 26);
            this.companyName.TabIndex = 8;
            // 
            // contactNumber
            // 
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.Location = new System.Drawing.Point(280, 155);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            this.contactNumber.Size = new System.Drawing.Size(282, 26);
            this.contactNumber.TabIndex = 9;
            // 
            // contactPersonTelephone
            // 
            this.contactPersonTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonTelephone.Location = new System.Drawing.Point(280, 221);
            this.contactPersonTelephone.Name = "contactPersonTelephone";
            this.contactPersonTelephone.ReadOnly = true;
            this.contactPersonTelephone.Size = new System.Drawing.Size(282, 26);
            this.contactPersonTelephone.TabIndex = 10;
            // 
            // companyTelephone
            // 
            this.companyTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTelephone.Location = new System.Drawing.Point(280, 276);
            this.companyTelephone.Name = "companyTelephone";
            this.companyTelephone.ReadOnly = true;
            this.companyTelephone.Size = new System.Drawing.Size(282, 26);
            this.companyTelephone.TabIndex = 11;
            // 
            // supplier_info_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 486);
            this.Controls.Add(this.companyTelephone);
            this.Controls.Add(this.contactPersonTelephone);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "supplier_info_form";
            this.Text = "supplier_info_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox companyName;
        public System.Windows.Forms.TextBox contactNumber;
        public System.Windows.Forms.TextBox contactPersonTelephone;
        public System.Windows.Forms.TextBox companyTelephone;
    }
}