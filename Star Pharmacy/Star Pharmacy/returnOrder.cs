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
    public partial class returnOrder : Form
    {
        private static int CreditNoteNo = 0;

        public returnOrder()
        {
            CreditNoteNo++;
            InitializeComponent();
            setTxtCreditNoteNo();
        }

        private void txtBoxCreditNoteNo_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You can't change Current Credit Note Value!");
        }

        private void setTxtCreditNoteNo()
        {
            txtBoxCreditNoteNo.Text = CreditNoteNo.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
