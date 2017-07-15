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
    public partial class cashierForm : Form
    {
        public cashierForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            lblProductID returnOrder = new lblProductID();
            returnOrder.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(returnOrder);
            returnOrder.Location = new Point((splitContainer1.Panel2.Width - returnOrder.Width) / 2, (splitContainer1.Panel2.Height - returnOrder.Height) / 2);
            returnOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            returnOrder.Show();
            returnOrder.setParentForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            create_order co = create_order.getCreateOrder(splitContainer1, this);
            co.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(co);
            co.Location = new Point((splitContainer1.Panel2.Width - co.Width) / 2, (splitContainer1.Panel2.Height - co.Height) / 2);
            co.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            co.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            LookupItemAvailability availabilityForm = new LookupItemAvailability();
            availabilityForm.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(availabilityForm);
            availabilityForm.Location = new Point((splitContainer1.Panel2.Width - availabilityForm.Width) / 2, (splitContainer1.Panel2.Height - availabilityForm.Height) / 2);
            availabilityForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            availabilityForm.Show();
            availabilityForm.buttonDeactivate();
            availabilityForm.setParentForm(this);

        }

        private void cashierForm_Load(object sender, EventArgs e)
        {

        }

        private void cashierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dialog = MessageBox.Show("Do you want to close the Application :","Exit" ,MessageBoxButtons.YesNo);
            if (dialog ==DialogResult.Yes)
            {
                
            }
            else 
            {
                e.Cancel = true;
            }*/
            Application.Exit();
        }
        public void parentButtonActivation(bool activation)
        {
            Button returnBtn = this.btnReturnOrder;
            Button newOrderBtn = this.btnNewOrder;
            Button availabilityBtn = this.button3;

            returnBtn.Enabled = activation;
            newOrderBtn.Enabled = activation;
            availabilityBtn.Enabled = activation;
        }
    }
}
