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
            returnOrder returnOrder = new returnOrder();
            returnOrder.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(returnOrder);
            returnOrder.Location = new Point((splitContainer1.Panel2.Width - returnOrder.Width) / 2, (splitContainer1.Panel2.Height - returnOrder.Height) / 2);
            returnOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            returnOrder.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hideUnwantedForms();
            create_order co = create_order.getCreateOrder(splitContainer1, this);
            co.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(co);
            co.Location = new Point((splitContainer1.Panel2.Width - co.Width) / 2, (splitContainer1.Panel2.Height - co.Height) / 2);
            co.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            co.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cashierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
