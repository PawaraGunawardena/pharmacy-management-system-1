﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    public partial class cashier_form : Form
    {
        public cashier_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventory_details id = new inventory_details();
            id.MdiParent = this;
            id.Show();
        }

        private void cashier_form_Load(object sender, EventArgs e)
        {
            
            if (Program.isExpire)
            {
                Expiry_Products exProd = new Expiry_Products();
                exProd.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            create_order co = new create_order();
            co.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(co);
            co.Location = new Point((splitContainer1.Panel2.Width - co.Width) / 2, (splitContainer1.Panel2.Height - co.Height) / 2);
            co.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            co.Show();
        }

        
    }
}