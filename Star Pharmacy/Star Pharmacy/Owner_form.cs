using System;
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
    public partial class owner_form : Form
    {
        public owner_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            inventory_details_mulleriyawa id = inventory_details_mulleriyawa.getInventoryDetails(splitContainer1,this);
            id.Location = new Point((splitContainer1.Panel2.Width - id.Width) / 2, (splitContainer1.Panel2.Height - id.Height) / 2);
            id.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            id.inventory_details_Load(sender,e);
            id.Show();
            
            
            
        }

        private void cashier_form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            create_order co = create_order.getCreateOrder(splitContainer1,this);
            //co.MdiParent = this;
            //splitContainer1.Panel2.Controls.Add(co);
            co.Location = new Point((splitContainer1.Panel2.Width - co.Width) / 2, (splitContainer1.Panel2.Height - co.Height) / 2);
            co.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            co.Show();
        }

        private void cashier_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void hideUnwantedForms()
        {
            foreach (Form form in this.splitContainer1.Panel2.Controls)
            {
                if (form.GetType() != this.GetType())
                {
                        form.Hide();
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            Inventory_details_welivita id = Inventory_details_welivita.getInventoryDetails(splitContainer1, this);
            id.Location = new Point((splitContainer1.Panel2.Width - id.Width) / 2, (splitContainer1.Panel2.Height - id.Height) / 2);
            id.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            id.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            modify_inventory mi = modify_inventory.getModifyInventory(splitContainer1, this);
            mi.Location = new Point((splitContainer1.Panel2.Width - mi.Width) / 2, (splitContainer1.Panel2.Height - mi.Height) / 2);
            mi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            supplier_details id = supplier_details.getSupplierDetails(splitContainer1, this);
            id.Location = new Point((splitContainer1.Panel2.Width - id.Width) / 2, (splitContainer1.Panel2.Height - id.Height) / 2);
            id.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            id.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            Sales_History sh = Sales_History.getSalesHistory(splitContainer1, this);
            sh.Location = new Point((splitContainer1.Panel2.Width - sh.Width) / 2, (splitContainer1.Panel2.Height - sh.Height) / 2);
            sh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sh.Show();
        }
    }
}
