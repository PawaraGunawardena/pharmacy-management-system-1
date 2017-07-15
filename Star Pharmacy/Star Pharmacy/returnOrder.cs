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

namespace Star_Pharmacy
{
    public partial class lblProductID : Form
    {
        string productID, productName, invoiceNo, cashierID, createdDate, createdTime, quantity, amount, branch;
        string currentDate = DateTime.Today.ToString("yyyy-MM-dd");
        string currentTime = DateTime.Now.ToString("HH:mm:ss");
        private int CreditNoteNo;
        private cashierForm parentCashierForm;
        //private int rowIndex = 0;
        int possibleReturns;


        public lblProductID()
        {
            CreditNoteNo = getCreditNoteNo();
            InitializeComponent();
            
            fillComboBoxInvoiceNo("SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions");
            fillComboBoxProductID("SELECT DISTINCT ProductID FROM pharmacy.order_transactions"); // should change by joining two tables
            
            //CreditNoteNo++;
            setTxtCreditNoteNo();
        }//DONE

        private void txtBoxCreditNoteNo_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You can't change Current Credit Note Value!");
        }//NOT WANT

        private void setTxtCreditNoteNo()
        {
            txtBoxCreditNoteNo.Text = CreditNoteNo.ToString();
        }//DONE

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateCustomerOrderTransactionsForCloseButton_CancelButton();
            cancelButtonReturnDatabaseQuery();
            this.Close();
            parentCashierForm.parentButtonActivation(true);
            CreditNoteNo--;
        }//NO

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//NOT WANT

        public void setParentForm(cashierForm parentCashierForm)
        {
            this.parentCashierForm = parentCashierForm;
        }//DONE

        private void fillComboBoxInvoiceNo(string query)
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = query;
            //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];
            
            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    string productID = newDataReader.GetInt16("InvoiceNo").ToString();
                    cmbBoxInvoiceNo.Items.Add(productID);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //DONE

        private void fillComboBoxProductID(string query)
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = query;
            //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    string productID = newDataReader.GetInt16("ProductID").ToString();
                    cmbBoxProductID.Items.Add(productID);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getQuery()
        {
            string query = "";
            if (cmbBoxInvoiceNo.Text.Length !=0 && cmbBoxProductID.Text.Length!=0 )
            {
                query = "SELECT InvoiceNo AS 'Invoice No',ProductID AS 'Product ID', ProductName AS 'Product Name', CashierID AS 'Cashier ID', CreatedDate AS 'Created Date', CreatedTime AS 'Created Time', Quantity AS 'Quantity', Amount AS 'Amount', Branch AS 'Branch'  FROM pharmacy.order_transactions WHERE InvoiceNO = "+cmbBoxInvoiceNo.Text+" AND ProductID = "+cmbBoxProductID.Text+"  ;  ";
                //MessageBox.Show(query);
                //MessageBox.Show(cmbBoxInvoiceNo.Text.Length.ToString());
                //MessageBox.Show(cmbBoxProductID.Text.Length.ToString());
            }
            else if (cmbBoxInvoiceNo.Text.Length == 0 && cmbBoxProductID.Text.Length != 0)
            {
                query = "SELECT InvoiceNo AS 'Invoice No',ProductID AS 'Product ID', ProductName AS 'Product Name', CashierID AS 'Cashier ID', CreatedDate AS 'Created Date', CreatedTime AS 'Created Time', Quantity AS 'Quantity', Amount AS 'Amount', Branch AS 'Branch'  FROM pharmacy.order_transactions WHERE ProductID = " + cmbBoxProductID.Text + "  ;  ";
                //MessageBox.Show(query);
            }
            else if (cmbBoxInvoiceNo.Text.Length != 0 && cmbBoxProductID.Text.Length == 0)
            {
                query = "SELECT InvoiceNo AS 'Invoice No',ProductID AS 'Product ID', ProductName AS 'Product Name', CashierID AS 'Cashier ID', CreatedDate AS 'Created Date', CreatedTime AS 'Created Time', Quantity AS 'Quantity', Amount AS 'Amount', Branch AS 'Branch'  FROM pharmacy.order_transactions WHERE InvoiceNO = " + cmbBoxInvoiceNo.Text + "  ;  ";
                //MessageBox.Show(query);
            }

            return query;
        } //DONE

        private void fillDataGridViewSalesInfo() //DONE
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = getQuery();
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            //MySqlDataReader newDataReader;
            try
            {
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = newCommand;
                DataTable myTable = new DataTable();
                myAdapter.Fill(myTable);
                BindingSource mySource = new BindingSource();
                mySource.DataSource = myTable;
                dataGridViewSalesDetails.DataSource = mySource;
                myAdapter.Update(myTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillDataGridViewReturnDetails() //NO
        {
            foreach (DataGridViewRow row in dataGridViewSalesDetails.SelectedRows)
            {
                if (numericUpDownReturnQuantity.Value == 0)
                {
                    MessageBox.Show("You should give return quantity!", "Update Quantity");
                }
                else if (numericUpDownReturnQuantity.Value > getPossibleReturn())
                {
                    MessageBox.Show("Customer didn't bought this much quantity!", "Error in Quantity");
                }
                else if (numericUpDownReturnQuantity.Value > 0)
                {
                     
                    if (this.dataGridViewSalesDetails.SelectedRows.Count == 1)
                    {
                        // this.dataGridView1.Rows.Add();

                        invoiceNo = this.dataGridViewSalesDetails.SelectedRows[0].Cells[0].Value.ToString();
                        productID = this.dataGridViewSalesDetails.SelectedRows[0].Cells[1].Value.ToString();
                        productName = this.dataGridViewSalesDetails.SelectedRows[0].Cells[2].Value.ToString();
                        cashierID = this.dataGridViewSalesDetails.SelectedRows[0].Cells[3].Value.ToString();
                        createdDate = this.dataGridViewSalesDetails.SelectedRows[0].Cells[4].Value.ToString();
                        createdTime = this.dataGridViewSalesDetails.SelectedRows[0].Cells[5].Value.ToString();
                        //quantity = this.dataGridViewSalesDetails.SelectedRows[0].Cells[6].Value.ToString();

                        quantity = numericUpDownReturnQuantity.Value.ToString();

                        amount = this.getNewReturnAmount().ToString();
                        MessageBox.Show(amount,"new amount -- fill2datagridview");
                        int unitPrice = this.getUnitPrice();
                        MessageBox.Show(unitPrice.ToString(), "unitPrice -- fill2datagridview");
                        //amount = this.dataGridViewSalesDetails.SelectedRows[0].Cells[7].Value.ToString();
                        branch = this.dataGridViewSalesDetails.SelectedRows[0].Cells[8].Value.ToString();
                        //MessageBox.Show(ProductID.ToString());

                        DataGridViewRow row1 = (DataGridViewRow)dataGridViewReturnDetails.Rows[0].Clone();
                        row1.Cells[0].Value = invoiceNo.ToString();
                        row1.Cells[1].Value = productID.ToString();
                        row1.Cells[2].Value = productName.ToString();
                        row1.Cells[3].Value = cashierID.ToString();
                        row1.Cells[4].Value = createdDate.ToString();
                        row1.Cells[5].Value = createdTime.ToString();
                        row1.Cells[6].Value = quantity.ToString();
                        row1.Cells[7].Value = amount.ToString();
                        row1.Cells[8].Value = branch.ToString();

                        dataGridViewReturnDetails.Rows.Add(row1);
                        /*
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[0].Value = invoiceNo.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[1].Value = productID.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[2].Value = productName.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[3].Value = cashierID.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[4].Value = createdDate.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[5].Value = createdTime.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[6].Value = quantity.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[7].Value = amount.ToString();
                        dataGridViewReturnDetails.Rows[rowIndex].Cells[8].Value = branch.ToString();
                        rowIndex += 1;
                        */

                        
                    }
                }
            }
        }

        private void cmbBoxInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridViewSalesInfo();

            /*
            string query;
            if (cmbBoxProductID.Text.Length != 0)
            {
                //
            }
            else
            {
                query = "SELECT DISTINCT ProductID FROM pharmacy.order_transactions WHERE InvoiceNo = " + cmbBoxInvoiceNo.Text + ";";
                fillComboBoxProductID(query);
            }*/
        } //DONE
      
        private void cmbBoxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridViewSalesInfo();
            /* {
                 string query;
                 if (cmbBoxInvoiceNo.Text.Length != 0)
                 {
                     //
                 }
                 else
                 {
                     query = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions WHERE InvoiceNo = " + cmbBoxProductID.Text + ";";
                     fillComboBoxInvoiceNo(query);
                 }
             }**/
        }//DONE

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBoxProductID.Text = null;
            cmbBoxInvoiceNo.Text = null;

            dataGridViewSalesDetails.DataSource = null;

        }//DONE --look more

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fillDataGridViewReturnDetails();
            //dataGridViewReturnDetails.Refresh();
            writeDataBaseReturn(getReturnItemsQuery());
            //Add to 2datagridview                  //DONE
            //add to the Return_transaction         //DONE
            //update order_transactions-table function     >>>base on the invoiceNo AND the productID
            //refresh upper datagridview1 function
            updateCustomerOrderTransactionsForReturn_AddButton();
        } //NO

        private void numericUpDownReturnQuantity_ValueChanged(object sender, EventArgs e)
        {
            //if(numericUpDownReturnQuantity.Value >= )
        }//NOT WANT

        private void btnRemove_Click(object sender, EventArgs e)
        {
            updateCustomerOrdeerTransactionsForRemoveItem_RemoveButton();

            string myQuery = getRemoveItemQuery();
            if (myQuery.Length != 0)
            {
                writeDataBaseReturn(myQuery);
            }
            else
            {
                MessageBox.Show("Wrong Query");
            }

            foreach (DataGridViewRow row in dataGridViewReturnDetails.SelectedRows)
            {
                if (this.dataGridViewReturnDetails.SelectedRows.Count == 1)
                {
                    this.dataGridViewReturnDetails.Rows.RemoveAt(this.dataGridViewReturnDetails.SelectedRows[0].Index);

                }
            }
            // string myQuery = "";
           //update return_transaction - table by removing                      //DONE
           //update  ordertransaction - table  >>> about the number of quantity
           //remove from down datagridview                                  //DONE
            //refresh upper datagridview1

            
        }//NO

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }//NO --just close the form

        private string getRemoveItemQuery()
        {
            string query ="";
            foreach (DataGridViewRow row in dataGridViewReturnDetails.SelectedRows)
            {
                if (this.dataGridViewReturnDetails.SelectedRows.Count == 1)
                {
                    try
                    {
                        invoiceNo = this.dataGridViewReturnDetails.SelectedRows[0].Cells[0].Value.ToString();
                        productID = this.dataGridViewReturnDetails.SelectedRows[0].Cells[1].Value.ToString();
                        //productName = this.dataGridViewReturnDetails.SelectedRows[0].Cells[2].Value.ToString();
                        //cashierID = this.dataGridViewReturnDetails.SelectedRows[0].Cells[3].Value.ToString();
                        //createdDate = this.dataGridViewReturnDetails.SelectedRows[0].Cells[4].Value.ToString();
                        //createdTime = this.dataGridViewReturnDetails.SelectedRows[0].Cells[5].Value.ToString();
                        quantity = this.dataGridViewReturnDetails.SelectedRows[0].Cells[6].Value.ToString();

                        //quantity = numericUpDownReturnQuantity.Value.ToString();
                        //amount = this.dataGridViewReturnDetails.SelectedRows[0].Cells[7].Value.ToString();
                        //branch = this.dataGridViewReturnDetails.SelectedRows[0].Cells[8].Value.ToString();

                        query = "DELETE FROM customer_return_item WHERE CreditNoteNo = " + CreditNoteNo + " AND InvoiceNo = " + invoiceNo + " AND ProductNo = " + productID + " AND NumberOfUnits = " + quantity + " ;";
                        MessageBox.Show(query);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return query;
        }

        private string getReturnItemsQuery()
        {
            invoiceNo = this.dataGridViewSalesDetails.SelectedRows[0].Cells[0].Value.ToString();
            productID = this.dataGridViewSalesDetails.SelectedRows[0].Cells[1].Value.ToString();
            productName = this.dataGridViewSalesDetails.SelectedRows[0].Cells[2].Value.ToString();
            cashierID = this.dataGridViewSalesDetails.SelectedRows[0].Cells[3].Value.ToString();
            createdDate = this.dataGridViewSalesDetails.SelectedRows[0].Cells[4].Value.ToString();
            createdTime = this.dataGridViewSalesDetails.SelectedRows[0].Cells[5].Value.ToString();
            //quantity = this.dataGridViewSalesDetails.SelectedRows[0].Cells[6].Value.ToString();

            quantity = numericUpDownReturnQuantity.Value.ToString();
            amount = this.dataGridViewSalesDetails.SelectedRows[0].Cells[7].Value.ToString();
            branch = this.dataGridViewSalesDetails.SelectedRows[0].Cells[8].Value.ToString();

            string query = "INSERT INTO customer_return_item (PrimaryID, CreditNoteNo, InvoiceNo, ProductNo, NumberOfUnits, ReturnDate, ReturnTime, ReturnCashierID) VALUES (0,"+ CreditNoteNo+","+ invoiceNo+", "+productID+", "+quantity+", '"+currentDate+"', '"+currentTime+"', 1) ;";
            MessageBox.Show(query);
            return query;
        }

         private void writeDataBaseReturn(string query)
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = query;
            //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    //string productID = newDataReader.GetInt16("ProductID").ToString();
                    //cmbBoxProductID.Items.Add(productID);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//DONE

        private void cancelButtonReturnDatabaseQuery()
        {
            string query = "";
            int row = dataGridViewReturnDetails.Rows.Count;
            for(int index=0; index<row-1;index++)
            {
                //int iteration = dataGridViewReturnDetails.Rows.Count;

                if (this.dataGridViewReturnDetails.Rows.Count > 1)
                {
                    try
                    {
                        invoiceNo = dataGridViewReturnDetails.Rows[index].Cells[0].Value.ToString();
                        productID = dataGridViewReturnDetails.Rows[index].Cells[1].Value.ToString();
                        //productName = this.dataGridViewReturnDetails.SelectedRows[0].Cells[2].Value.ToString();
                        //cashierID = this.dataGridViewReturnDetails.SelectedRows[0].Cells[3].Value.ToString();
                        //createdDate = this.dataGridViewReturnDetails.SelectedRows[0].Cells[4].Value.ToString();
                        //createdTime = this.dataGridViewReturnDetails.SelectedRows[0].Cells[5].Value.ToString();
                        quantity = dataGridViewReturnDetails.Rows[index].Cells[6].Value.ToString();

                        //quantity = numericUpDownReturnQuantity.Value.ToString();
                        //amount = this.dataGridViewReturnDetails.SelectedRows[0].Cells[7].Value.ToString();
                        //branch = this.dataGridViewReturnDetails.SelectedRows[0].Cells[8].Value.ToString();

                        query = "DELETE FROM customer_return_item WHERE CreditNoteNo = " + CreditNoteNo + " ;";
                        //MessageBox.Show(query);
                        writeDataBaseReturn(query);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }//DONE

        private int getCreditNoteNo()
        {
            int CreditNote=0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery ;
            myQuery = "SELECT MAX(CreditNoteNo) FROM pharmacy.customer_return_item;";
            //myQuery = "SELECT CreditNoteNo FROM pharmacy.customer_return_item ORDER BY CreditNoteNo DESC LIMIT 1 ;";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                
                while (newDataReader.Read())
                {
                    //MessageBox.Show(newDataReader.GetInt16(CreditNoteNo).ToString());
                    CreditNote = (int)newDataReader.GetInt16(CreditNoteNo);
                    //CreditNoteNo = (int)newDataReader.GetInt16(CreditNoteNo);
                    //MessageBox.Show(CreditNoteNo.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return CreditNote+1;
        }//DONE

        private int getReturnQuantity()
        {
            int ReturnQuantity = 0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery;
            //myQuery = "SELECT MAX(CreditNoteNo) FROM pharmacy.customer_return_item;";
            myQuery = "SELECT ReturnQuantity FROM pharmacy.order_transactions WHERE ProductID = "+cmbBoxProductID.Text+" AND InvoiceNo = " +cmbBoxInvoiceNo.Text+" ; ";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();

                while (newDataReader.Read())
                {
                    //MessageBox.Show(newDataReader.GetInt16(CreditNoteNo).ToString());
                    ReturnQuantity = (int)newDataReader.GetInt16(ReturnQuantity);
                    //CreditNoteNo = (int)newDataReader.GetInt16(CreditNoteNo);
                    MessageBox.Show(ReturnQuantity.ToString(), "return quantity -- getReturnQuantity()");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ReturnQuantity;
        }//DONE

        private int getUnitPrice() 
        {
            int UnitPrice = 0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery;
            //myQuery = "SELECT MAX(CreditNoteNo) FROM pharmacy.customer_return_item;";
            myQuery = "SELECT FLOOR(UnitPrice) FROM pharmacy.inventory WHERE ProductID = " + cmbBoxProductID.Text + " ; ";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
         
            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();

                while (newDataReader.Read())
                {
                    //MessageBox.Show(newDataReader.GetInt16(CreditNoteNo).ToString());
                    UnitPrice = (int)newDataReader.GetInt16("FLOOR(UnitPrice)");
                    //CreditNoteNo = (int)newDataReader.GetInt16(CreditNoteNo);
                    //MessageBox.Show(UnitPrice.ToString(),"FFFFFFFFFF UnitPrice -- getUnitPrice()");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return UnitPrice;
        } //DONE

        private int getQuantity()
        {
            int Quantity = 0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery;

            MessageBox.Show(this.dataGridViewSalesDetails.SelectedRows[0].Cells[1].ToString(), "read from data frid view//product ID -getQuantity()");

            //myQuery = "SELECT MAX(CreditNoteNo) FROM pharmacy.customer_return_item;";
            myQuery = "SELECT Quantity FROM pharmacy.order_transactions WHERE ProductID = " + cmbBoxProductID.Text + " AND InvoiceNo = " + cmbBoxInvoiceNo.Text + " ; ";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();

                while (newDataReader.Read())
                {
                    //MessageBox.Show(newDataReader.GetInt16(CreditNoteNo).ToString());
                    Quantity = (int)newDataReader.GetInt16(Quantity);
                    //CreditNoteNo = (int)newDataReader.GetInt16(CreditNoteNo);
                    //MessageBox.Show(Quantity.ToString(), "Quantity sold - getQuantity()");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Quantity;
        } // DONE
            
        private int getNewReturnAmount()
        {
            int returnQuantity = (int)this.numericUpDownReturnQuantity.Value;
            int unitPice = this.getUnitPrice();

            int totalNewReturnAmount = (int)returnQuantity * (int)unitPice;
            return totalNewReturnAmount;

            MessageBox.Show(totalNewReturnAmount.ToString(),"return amount -- getNEwReturnAmount()");
        }//DONE

        private int getPossibleReturn()
        {
            int boughtQuantity = this.getQuantity();
            int returnQuantity = this.getReturnQuantity();
            int possibleReturn = boughtQuantity - returnQuantity;
            //MessageBox.Show(boughtQuantity.ToString(), "Quantity bought - getPossibleReturn()");
            //MessageBox.Show(returnQuantity.ToString(), "Quantity alredy returned - getPossibleReturn()");
            //MessageBox.Show(possibleReturn.ToString(), "Quantity available to return - getPossibleReturn()");
            return possibleReturn;
        }//DONE



        private void updateCustomerOrderTransactionsForReturn_AddButton()
        {
            string productID1;
            string returnQuantity1;
            //string creditNote1;
            string invoiceNo1;
            int currentReturnQuantity = getCurrentReturnAmount();

            productID1 = this.cmbBoxProductID.Text.ToString();
            returnQuantity1 = ((int)this.numericUpDownReturnQuantity.Value + currentReturnQuantity).ToString();
            //creditNote1 = this.CreditNoteNo.ToString();
            invoiceNo1= this.cmbBoxInvoiceNo.Text.ToString();

            string query1 = "UPDATE pharmacy.order_transactions SET ReturnQuantity = "+ returnQuantity1 + " WHERE ProductID = "+productID1+ " AND InvoiceNo = "+invoiceNo1+" ;";

            string connectionString = "server=localhost;user id=root;database=pharmacy";
            //string myQuery = query;
            //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(query1, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    //string productID = newDataReader.GetInt16("ProductID").ToString();
                    //cmbBoxProductID.Items.Add(productID);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//DONE
        private int getCurrentReturnAmount()
        {

            string productID1;
            //string returnQuantity1;
            //string creditNote1;
            string invoiceNo1;
            int currentReturnQuantity=0;

            productID1 = this.cmbBoxProductID.Text.ToString();
            //returnQuantity1 = this.numericUpDownReturnQuantity.Value.ToString();
            //creditNote1 = this.CreditNoteNo.ToString();
            invoiceNo1 = this.cmbBoxInvoiceNo.Text.ToString();

            string query1 = "SELECT ReturnQuantity FROM pharmacy.order_transactions WHERE ProductID = " + productID1 + " AND InvoiceNo = " + invoiceNo1 + " ;";

            string connectionString = "server=localhost;user id=root;database=pharmacy";
            //string myQuery = query;
            //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(query1, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    currentReturnQuantity =(int) newDataReader.GetInt16("ReturnQuantity");
                    //cmbBoxProductID.Items.Add(productID);
                    //MessageBox.Show(currentReturnQuantity.ToString(), "getCurrentReturn()");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return currentReturnQuantity;
        }//DONE
            

        private int getCurrentReturnAmount_grid2(DataGridViewRow row)
        {
            string productID1;
            
            string invoiceNo1;
            int currentReturnQuantity = 0;

            productID1 = row.Cells["ProductID"].Value.ToString();
            invoiceNo1 = row.Cells["InvoiceNo"].Value.ToString();
            
            string query1 = "SELECT ReturnQuantity FROM pharmacy.order_transactions WHERE ProductID = " + productID1 + " AND InvoiceNo = " + invoiceNo1 + " ;";

            string connectionString = "server=localhost;user id=root;database=pharmacy";
          
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(query1, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    currentReturnQuantity = (int)newDataReader.GetInt16("ReturnQuantity");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return currentReturnQuantity;
        }

        private void updateCustomerOrdeerTransactionsForRemoveItem_RemoveButton()
        {
            string productID1="";
            string returnQuantity1 ="";
            //string creditNote1;
            string invoiceNo1="";
            int currentReturnQuantity = getCurrentReturnAmount_grid2(dataGridViewReturnDetails.CurrentRow);

            if (dataGridViewReturnDetails.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewReturnDetails.SelectedRows)
                {
                    productID1 = row.Cells["ProductID"].Value.ToString();
                    invoiceNo1 = row.Cells["InvoiceNo"].Value.ToString();
                    returnQuantity1 = row.Cells["Quantity"].Value.ToString() ;
                    break;
                }
            }
            else
            {
                MessageBox.Show("Please select item!");
            }
            int returnQuantity2 = currentReturnQuantity - Int32.Parse(returnQuantity1); ;

        string query1 = "UPDATE pharmacy.order_transactions SET ReturnQuantity = " + returnQuantity2 + " WHERE ProductID = " + productID1 + " AND InvoiceNo = " + invoiceNo1 + " ;";

            string connectionString = "server=localhost;user id=root;database=pharmacy";
            //string myQuery = query;
            //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(query1, newConnnection);
            MySqlDataReader newDataReader;
            //DataGridViewComboBoxColumn newRow = this.dataGridView1.
            //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    //string productID = newDataReader.GetInt16("ProductID").ToString();
                    //cmbBoxProductID.Items.Add(productID);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//DONE

        private void updateCustomerOrderTransactionsForCloseButton_CancelButton()
        {
            string productID1 = "";
            string returnQuantity1 = "";
            //string creditNote1;
            string invoiceNo1 = "";
            int currentReturnQuantity = 0;

            if (dataGridViewReturnDetails.SelectedRows.Count > 0)
            {
                int index = dataGridViewReturnDetails.RowCount - 1;
                MessageBox.Show(dataGridViewReturnDetails.RowCount.ToString(),"row count");
                DataGridViewRow row;
                for(int i=0; i<index; i++)
                {
                    
                    //MessageBox.Show(i.ToString(), "row");
                    row = dataGridViewReturnDetails.Rows[i];
                    currentReturnQuantity = getCurrentReturnAmount_grid2(row);
                    productID1 = row.Cells["ProductID"].Value.ToString();
                    invoiceNo1 = row.Cells["InvoiceNo"].Value.ToString();
                    returnQuantity1 = row.Cells["Quantity"].Value.ToString();
                    int returnQuantity2 = currentReturnQuantity - Int32.Parse(returnQuantity1); ;
                    MessageBox.Show(returnQuantity2.ToString() ,"wrong value!!!");


                    string query1 = "UPDATE pharmacy.order_transactions SET ReturnQuantity = " + returnQuantity2 + " WHERE ProductID = " + productID1 + " AND InvoiceNo = " + invoiceNo1 + " ;";

                    string connectionString = "server=localhost;user id=root;database=pharmacy";
                    //string myQuery = query;
                    //string myQuery = "SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions";
                    MySqlConnection newConnnection = new MySqlConnection(connectionString);
                    MySqlCommand newCommand = new MySqlCommand(query1, newConnnection);
                    MySqlDataReader newDataReader;
                    //DataGridViewComboBoxColumn newRow = this.dataGridView1.
                    //DataGridViewComboBoxCell newCell = newRow.Cells["Invoice No"];

                    try
                    {
                        newConnnection.Open();
                        newDataReader = newCommand.ExecuteReader();
                        while (newDataReader.Read())
                        {
                            //string productID = newDataReader.GetInt16("ProductID").ToString();
                            //cmbBoxProductID.Items.Add(productID);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select item!");
            }
            

            
        }
    }
}
