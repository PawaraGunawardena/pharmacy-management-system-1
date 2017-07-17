using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    public partial class Sales_History : Form
    {
        private static Sales_History sh;
        static String pdfFilename;
        static String pdfFilename2;
        public Sales_History()
        {
            InitializeComponent();
        }

        private void Sales_History_Load(object sender, EventArgs e)
        {
            to_dtp.MaxDate = DateTime.Today;
            from_dtp.MaxDate = DateTime.Today;
            String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions;";
            SqlCon.updateDataGridView(query,dataGridView1);
        }
        public static Sales_History getSalesHistory(SplitContainer s, Form f)
        {

            if (sh == null || sh.IsDisposed)
            {
                sh = new Sales_History();
                sh.MdiParent = f;
                s.Panel2.Controls.Add(sh);
                return sh;
            }
            else
            {
                return sh;
            }
        }

        private void date_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (date_chkbox.Checked)
            {
                to_dtp.Enabled = true;
                from_dtp.Enabled = true;
                branch_chkbox.Checked = false;
                invoice_chkbox.Checked = false;
            }
            else
            {
                to_dtp.Enabled = false;
                from_dtp.Enabled = false;
            }
        }

        private void branch_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (branch_chkbox.Checked)
            {
                comboBox1.Enabled = true;
                date_chkbox.Checked = false;
                invoice_chkbox.Checked = false;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }

        private void invoice_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (invoice_chkbox.Checked)
            {
                numericUpDown1.Enabled = true;
                date_chkbox.Checked = false;
                branch_chkbox.Checked = false;
            }
            else
            {
                numericUpDown1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (date_chkbox.Checked)
            {
                String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions where CreatedDate between '" + from_dtp.Value.ToString("yyyy-MM-dd") + "' and '" + to_dtp.Value.ToString("yyyy-MM-dd") + "';";
                SqlCon.updateDataGridView(query, dataGridView1);
            }
            else if (branch_chkbox.Checked)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Select an option for branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (comboBox1.Text == "All")
                    {
                        String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions;";
                        SqlCon.updateDataGridView(query, dataGridView1);
                    }
                    else if (comboBox1.Text == "Mulleriyawa")
                    {
                        String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions where Branch ='" + "Mulleriyawa" + "';";
                        SqlCon.updateDataGridView(query, dataGridView1);
                    }
                    else if (comboBox1.Text == "Welivita")
                    {
                        String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions where Branch ='" + "Welivita" + "';";
                        SqlCon.updateDataGridView(query, dataGridView1);
                    }
                }
            }else if(invoice_chkbox.Checked)
            {
                String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions where InvoiceNo = '"+numericUpDown1.Value.ToString()+"';";
                SqlCon.updateDataGridView(query, dataGridView1);
            }
            else
            {
                String query = "select ProductID,ProductName,InvoiceNo,CashierID,CreatedDate,CreatedTime,Quantity,Amount,Branch from order_transactions;";
                SqlCon.updateDataGridView(query, dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/DisplayRecords/DailyReport.php");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //When the user presses this, he'd generate a PDF, saves it in his local computer and sends it to a designated email address.
            //generatePDFtoRange();
            Utilities3.generatePDFtoRange(date_chkbox.Checked, from_dtp.Value.ToString("yyyy-MM-dd"), to_dtp.Value.ToString("yyyy-MM-dd"));


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            Utilities3.generateMothlyReport();
            //generateMothlyReport();
        }
    }
}
