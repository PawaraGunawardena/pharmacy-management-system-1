using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace Star_Pharmacy
{
    public partial class create_order : Form
    {
        public DataTable dt = new DataTable();
        private static create_order inst4;
        private decimal total;
        private decimal cash;
        private decimal change;
        private String branch = TransactionControl.findBranch(Program.logged_id.ToString());
        cashierForm parentCashierForm;

        public static create_order getCreateOrder(SplitContainer s, Form f)
        {
            if (inst4 == null || inst4.IsDisposed)
            {
                inst4 = new create_order();
                
                inst4.MdiParent = f;
                s.Panel2.Controls.Add(inst4);
                return inst4;
            }
            else
            {
                return inst4;
            }
        }
        public void setParentForm(cashierForm parentCashierForm)
        {
            this.parentCashierForm = parentCashierForm;
        }
        public create_order()
        {
            InitializeComponent();
        }

        private void create_order_Load(object sender, EventArgs e)
        {
            load_dgv1();
            invoiceno_lbl.Text = TransactionControl.genrateInvoiceNo().ToString();

        }
        private void load_dgv1()
        {
            String query = "Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where InStock >0 and Branch = '"+branch+"';";
            SqlCon.updateDataGridView(query, dataGridView1);
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (productID_nud.Value != 0)
            {
                MySqlDataAdapter sAdapter2 = new MySqlDataAdapter("Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where ProductID like '" + productID_nud.Value.ToString() + "%" + "' and InStock > 0 and Branch = '" + branch + "';", SqlCon.con);
                DataTable dt2 = new DataTable();
                sAdapter2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else
            {
                String query = "Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where InStock > 0 and Branch = '" + branch + "';";
                SqlCon.updateDataGridView(query, dataGridView1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter sAdapter3 = new MySqlDataAdapter("Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where BrandName like '" + "%" + textBox1.Text + "%" + "'and InStock > 0 and Branch = '" + branch + "';", SqlCon.con);
            DataTable dt3 = new DataTable();
            sAdapter3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter sAdapter4 = new MySqlDataAdapter("Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where MedicalName like '" + "%" + textBox2.Text + "%" + "'and InStock > 0 and Branch = '" + branch + "';", SqlCon.con);
            DataTable dt4 = new DataTable();
            sAdapter4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            productID_nud.ResetText();
            textBox2.Text = null;
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            productID_nud.ResetText();
            textBox1.Text = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private int selectedRowIndex;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            change_lbl.Text = " ";
            int newInstock;
            int oldStock;
            oldStock = System.Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[5].Value);
            newInstock = oldStock - System.Convert.ToInt32(numericUpDown2.Value);
            if (numericUpDown2.Value == 0)
            {
                MessageBox.Show("Enter a quantity!");
            }
            else if (newInstock<0)
            {
                MessageBox.Show("Low Stock!");
            }
            else
            {
                String unitPrice, ProductName, Quantity, Amount,productId;
                
                productId = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                ProductName = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                unitPrice = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                Quantity = numericUpDown2.Value.ToString();
                Amount = (System.Convert.ToDecimal(unitPrice) * numericUpDown2.Value).ToString();
                bill_dgv.Rows.Add(new String [] {productId,ProductName,unitPrice,Quantity,Amount});
                total = total + System.Convert.ToDecimal(Amount);
                total_lbl.Text = total.ToString();

                SqlCon.con.Open();
                MySqlCommand com = new MySqlCommand("update pharmacy.inventory  set InStock = '" + newInstock.ToString() + "' where ProductID = '" + productId + "' ;", SqlCon.con);
                com.ExecuteNonQuery();
                SqlCon.con.Close();
                load_dgv1();
                MySqlDataAdapter sAdapter5 = new MySqlDataAdapter("Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where InStock > 0 and Branch = '" + branch + "';", SqlCon.con);
                DataTable dt5 = new DataTable();
                sAdapter5.Fill(dt5);
                dataGridView1.DataSource = dt5;
                dataGridView1.Refresh();

            }

        }
        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            DialogResult result = printDialog.ShowDialog();
            if(result == DialogResult.OK){
            printDocument.Print();}
            

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 55;
            graphic.DrawString("StarX Pharmacy-"+branch, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY);

            graphic.DrawString("Date :"+DateTime.Today.ToString("yyyy-MM-dd")+"   "+"Invoice NO:"+invoiceno_lbl.Text, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY+23);
            graphic.DrawString("ID"+"\t"+"Name"+"\t"+"UPrz"+"\t"+"Qty"+"\t"+"total", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + 40);

            foreach (DataGridViewRow row in bill_dgv.Rows)
            {
                String productID = row.Cells[0].Value.ToString();
                String pName = row.Cells[1].Value.ToString();
                String productName;
                if (pName.Length > 5)
                {
                    productName = row.Cells[1].Value.ToString().Substring(0,5);
                }
                else
                {
                    productName = row.Cells[1].Value.ToString();
                }
                String quantity = row.Cells[3].Value.ToString();
                String unitPrice = row.Cells[2].Value.ToString();
                String total = row.Cells[4].Value.ToString();
                String productLine = productID + "\t" + productName + "\t" + unitPrice + "\t" + quantity +"\t" + total;
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;

            }
            offset = offset + 20;
            graphic.DrawString("Net Total"+"\t"+total_lbl.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Cash" + "\t" + "\t" + cash.ToString()+" Rs", font, new SolidBrush(Color.Black), startX, startY + offset + 15);
            graphic.DrawString("Change" + "\t" + "\t" + change_lbl.Text, font, new SolidBrush(Color.Black), startX, startY + offset + 30); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bill_dgv.Rows.Count > 0)
            {
                cash_nud.Value = 0;
                change_lbl.Text = " ";
                int selIndex = bill_dgv.CurrentCell.RowIndex;
                int newStock, oldStock;
                MySqlDataAdapter sda = new MySqlDataAdapter("select InStock from pharmacy.inventory where ProductID='" + bill_dgv.Rows[selIndex].Cells[0].Value.ToString() + "'; ", SqlCon.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Error! Check inventory for duplicate entries!");
                }
                else
                {
                    oldStock = System.Convert.ToInt32(dt.Rows[0][0].ToString());
                    newStock = oldStock + System.Convert.ToInt32(bill_dgv.Rows[selIndex].Cells[3].Value.ToString());
                    SqlCon.con.Open();
                    MySqlCommand com = new MySqlCommand("update pharmacy.inventory  set InStock = '" + newStock.ToString() + "' where ProductID = '" + bill_dgv.Rows[selIndex].Cells[0].Value.ToString() + "' ;", SqlCon.con);
                    com.ExecuteNonQuery();
                    SqlCon.con.Close();
                    MySqlDataAdapter sAdapter5 = new MySqlDataAdapter("Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory where Branch = '" + branch + "';", SqlCon.con);
                    DataTable dt5 = new DataTable();
                    sAdapter5.Fill(dt5);
                    dataGridView1.DataSource = dt5;
                    dataGridView1.Refresh();
                    total = total - System.Convert.ToDecimal(bill_dgv.Rows[selIndex].Cells[4].Value.ToString());
                    total_lbl.Text = total.ToString() + " Rs";
                    bill_dgv.Rows.RemoveAt(selIndex);

                }
            }
            else
            {
                MessageBox.Show("No items to remove!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (bill_dgv.Rows.Count > 0)
            {
                button4_Click(sender, e);
            }
            parentCashierForm.parentButtonActivation(true);
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bill_dgv.RowCount > 0 && cash_nud.Value >= Convert.ToDecimal(total))
            {
                TransactionControl.updateDatabase(bill_dgv, invoiceno_lbl.Text, Program.logged_id.ToString());
                PrintReceipt();
                invoiceno_lbl.Text = TransactionControl.genrateInvoiceNo().ToString();
                bill_dgv.Rows.Clear();
                total_lbl.ResetText();
                change_lbl.ResetText();
                parentCashierForm.parentButtonActivation(true);
            }
            else if (cash_nud.Value < Convert.ToDecimal(total))
            {
                cash_nud.ResetText();
                MessageBox.Show("Insufficient Money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Select Atleast One Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
           // thic.close();
        }

        private void cash_nud_ValueChanged(object sender, EventArgs e)
        {
               cash = cash_nud.Value;
               if (cash_nud.Value == null)
               {
                   change_lbl.Text = "";
               }
               else if (cash_nud.Value < Convert.ToDecimal(total))
               {
                   cash_nud.ResetText();
                   MessageBox.Show("Insufficient Money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {
                   change = cash - total;
                   total_lbl.Text = total.ToString() + " Rs";
                   change_lbl.Text = change.ToString() + " Rs";
               }
            
            
        }

        private void productID_nud_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }
        

        

        
        

    }
}
