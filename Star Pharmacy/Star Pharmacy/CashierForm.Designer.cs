namespace Star_Pharmacy
{
    partial class cashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashierForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReturnOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();

            this.pictureBoxName = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.Controls.Add(this.btnChangeDetails);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.btnReturnOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxName);
            this.splitContainer1.Size = new System.Drawing.Size(830, 541);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnChangeDetails
            // 

            this.btnChangeDetails.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.btnChangeDetails.Location = new System.Drawing.Point(20, 337);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(181, 60);
            this.btnChangeDetails.TabIndex = 3;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = true;
            this.btnChangeDetails.Click += new System.EventHandler(this.btnChangeDetails_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(20, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lookup Item Availability";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnOrder.Location = new System.Drawing.Point(20, 138);
            this.btnReturnOrder.Name = "btnReturnOrder";
            this.btnReturnOrder.Size = new System.Drawing.Size(181, 64);
            this.btnReturnOrder.TabIndex = 1;
            this.btnReturnOrder.Text = "Return Cutomer Order";
            this.btnReturnOrder.UseVisualStyleBackColor = true;
            this.btnReturnOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewOrder.Location = new System.Drawing.Point(20, 33);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(181, 64);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.button1_Click);
            // 

            // pictureBoxName
            // 
            this.pictureBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxName.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxName.Image")));
            this.pictureBoxName.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(606, 541);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxName.TabIndex = 0;
            this.pictureBoxName.TabStop = false;

            // cashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 541);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "cashierForm";
            this.Text = "Cashier LogIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cashierForm_FormClosing_1);
            this.Load += new System.EventHandler(this.cashierForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReturnOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnChangeDetails;
        private System.Windows.Forms.PictureBox pictureBoxName;
    }
}