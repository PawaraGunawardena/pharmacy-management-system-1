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
        int possibleReturns;
        string connectionString;
        MySqlConnection newConnnection;
        int unitPrice;
        int logged_id;
         string branchOriginal;


        public lblProductID(int logged_id, string branch)
        {
            this.logged_id = logged_id;
            this.branchOriginal = branch;
            InitializeComponent();
            CreditNoteNo = getCreditNoteNo();
            setTxtCreditNoteNo();
            fillComboBoxInvoiceNo("SELECT DISTINCT InvoiceNo FROM pharmacy.order_transactions");
            fillComboBoxProductID("SELECT DISTINCT ProductID FROM pharmacy.order_transactions");
            refreshButtons_EnableDisable(false);
            connectionString = "server=localhost;user id=root;database=pharmacy";
            newConnnection = new MySqlConnection(connectionString);
        }//DONE

        private void refreshButtons_EnableDisable(bool activation)
        {
            this.btnAdd.Enabled = activation;
            this.numericUpDownReturnQuantity.Enabled = activation;
            this.btnClear.Enabled = activation;
            this.btnRemove.Enabled = activation;
            this.btnReturn.Enabled = activation;
        }

        private int getCreditNoteNo()
        {
            int CreditNote = 0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery;
            myQuery = "SELECT MAX(CreditNoteNo) FROM pharmacy.customer_return_item;";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();

                while (newDataReader.Read())
                {
                    CreditNote = (int)newDataReader.GetInt16(CreditNoteNo);
                }
            }
            catch (Exception ex)
            {
            }
            return CreditNote + 1;
        }
        private void fillComboBoxInvoiceNo(string query)
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = query;
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

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
                MessageBox.Show("You haven't sold any item to customers yet.");
            }
        } //DONE
        private void fillComboBoxProductID(string query)
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = query;
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

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
            }
        }
        private void txtBoxCreditNoteNo_TextChanged(object sender, EventArgs e)
        {
        }//NOT WANT
        private void setTxtCreditNoteNo()
        {
            txtBoxCreditNoteNo.Text = CreditNoteNo.ToString();
        }//DONE
        private void activation_nulldatagridview()
        {
            if (dataGridViewSalesDetails.RowCount > 1 && cmbBoxInvoiceNo.Text.Length != 0 && cmbBoxProductID.Text.Length != 0)
            {
                //btnAdd.Enabled = true;
                btnClear.Enabled = true;
                numericUpDownReturnQuantity.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
                numericUpDownReturnQuantity.Enabled = false;
            }
        }


        private void cmbBoxInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownReturnQuantity.Value = 0;
            numericUpDownReturnQuantity.Enabled = false;
            fillDataGridViewSalesInfo();
            activation_nulldatagridview();


        } //DONE
        private void cmbBoxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridViewSalesInfo();
            activation_nulldatagridview();
        }//DONE
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            activation_nulldatagridview();
        }//NOT WANT
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
        private string getQuery()
        {
            string query = "";
            if (cmbBoxInvoiceNo.Text.Length != 0 && cmbBoxProductID.Text.Length != 0)
            {
                query = "SELECT InvoiceNo AS 'Invoice No',ProductID AS 'Product ID', ProductName AS 'Product Name', CashierID AS 'Cashier ID', CreatedDate AS 'Created Date', CreatedTime AS 'Created Time', Quantity AS 'Quantity', Amount AS 'Amount', Branch AS 'Branch'  FROM pharmacy.order_transactions WHERE InvoiceNO = " + cmbBoxInvoiceNo.Text + " AND ProductID = " + cmbBoxProductID.Text + "  ;  ";
            }
            else if (cmbBoxInvoiceNo.Text.Length == 0 && cmbBoxProductID.Text.Length != 0)
            {
                query = "SELECT InvoiceNo AS 'Invoice No',ProductID AS 'Product ID', ProductName AS 'Product Name', CashierID AS 'Cashier ID', CreatedDate AS 'Created Date', CreatedTime AS 'Created Time', Quantity AS 'Quantity', Amount AS 'Amount', Branch AS 'Branch'  FROM pharmacy.order_transactions WHERE ProductID = " + cmbBoxProductID.Text + "  ;  ";
            }
            else if (cmbBoxInvoiceNo.Text.Length != 0 && cmbBoxProductID.Text.Length == 0)
            {
                query = "SELECT InvoiceNo AS 'Invoice No',ProductID AS 'Product ID', ProductName AS 'Product Name', CashierID AS 'Cashier ID', CreatedDate AS 'Created Date', CreatedTime AS 'Created Time', Quantity AS 'Quantity', Amount AS 'Amount', Branch AS 'Branch'  FROM pharmacy.order_transactions WHERE InvoiceNO = " + cmbBoxInvoiceNo.Text + "  ;  ";
            }
            return query;
        } //DONE


        private int getNewReturnAmount()
        {
            unitPrice = this.getUnitPrice(newConnnection);
            int returnQuantity = (int)this.numericUpDownReturnQuantity.Value;
            int totalNewReturnAmount = (int)returnQuantity * (int)unitPrice;
            return totalNewReturnAmount;
        }//DONE
        private int getUnitPrice(MySqlConnection newConnnection)
        {
            int UnitPrice = 0;
            string myQuery;
            myQuery = "SELECT FLOOR(UnitPrice) FROM pharmacy.inventory WHERE ProductID = " + productID + " ; ";
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    UnitPrice = (int)newDataReader.GetInt16("FLOOR(UnitPrice)");
                }
            }
            catch (Exception ex)
            {
            }
            newConnnection.Close();
            return UnitPrice;
        } //DONE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fillDataGridViewReturnDetails();
            btnReturn.Enabled = true;
            btnRemove.Enabled = true;
        } //DONE
        private string getReturnItemsQuery()
        {
            string query = "INSERT INTO customer_return_item (PrimaryID, CreditNoteNo, InvoiceNo, ProductNo, NumberOfUnits, ReturnDate, ReturnTime, ReturnCashierID, Amount) VALUES (0," + CreditNoteNo + "," + invoiceNo + ", " + productID + ", " + quantity + ", '" + currentDate + "', '" + currentTime + "', "+logged_id+" ," + amount + " ) ;";
            return query;
            //MessageBox.Show(query, "getReturnItemsQuery()");
        }
        private string getReturnItemQuery_order_transactions_table()
        {
            string returnQuantity1;
            int currentReturnQuantity = getCurrentReturnAmount();
            returnQuantity1 = ((int)this.numericUpDownReturnQuantity.Value + currentReturnQuantity).ToString();
            string query1 = "UPDATE pharmacy.order_transactions SET ReturnQuantity = " + returnQuantity1 + " WHERE ProductID = " + productID + " AND InvoiceNo = " + invoiceNo + " ;";
            return query1;
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
                        invoiceNo = this.dataGridViewSalesDetails.SelectedRows[0].Cells[0].Value.ToString();
                        productID = this.dataGridViewSalesDetails.SelectedRows[0].Cells[1].Value.ToString();
                        productName = this.dataGridViewSalesDetails.SelectedRows[0].Cells[2].Value.ToString();
                        cashierID = this.dataGridViewSalesDetails.SelectedRows[0].Cells[3].Value.ToString();
                        createdDate = this.dataGridViewSalesDetails.SelectedRows[0].Cells[4].Value.ToString();
                        createdTime = this.dataGridViewSalesDetails.SelectedRows[0].Cells[5].Value.ToString();
                        quantity = numericUpDownReturnQuantity.Value.ToString();
                        amount = this.getNewReturnAmount().ToString();
                        //unitPrice = this.getUnitPrice(newConnnection);
                        branch = this.dataGridViewSalesDetails.SelectedRows[0].Cells[8].Value.ToString();
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

                        try
                        {
                            updateCustomerOrderTransactionsForReturn_AddButton(getReturnItemQuery_order_transactions_table(), newConnnection);
                            writeDataBaseReturn(getReturnItemsQuery(), newConnnection);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        private void updateCustomerOrderTransactionsForReturn_AddButton(string query1, MySqlConnection newConnection)
        {
            MySqlCommand newCommand = new MySqlCommand(query1, newConnnection);
            MySqlDataReader newDataReader;
            newConnnection.Open();
            newDataReader = newCommand.ExecuteReader();
            while (newDataReader.Read())
            {
            }
            newConnnection.Close();
        }//DONE
        private void writeDataBaseReturn(string query, MySqlConnection newConnnection)
        {
            //MessageBox.Show(query, "writereturnDatabaseQuery");
            MySqlCommand newCommand = new MySqlCommand(query, newConnnection);
            MySqlDataReader newDataReader;
            newConnnection.Open();
            newDataReader = newCommand.ExecuteReader();
            while (newDataReader.Read())
            {
            }
            newConnnection.Close();
        }//DONE


        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateCustomerOrderTransactionsForCloseButton_CancelButton();
            cancelButtonReturnDatabaseQuery();
            this.Close();
            parentCashierForm.parentButtonActivation(true);
            CreditNoteNo--;

        }//NO
        private void cancelButtonReturnDatabaseQuery()
        {
            string query = "";
            int row = dataGridViewReturnDetails.Rows.Count;
            for (int index = 0; index < row - 1; index++)
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
                        writeDataBaseReturn(query, newConnnection);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
                //MessageBox.Show(dataGridViewReturnDetails.RowCount.ToString(), "row count");
                DataGridViewRow row;
                for (int i = 0; i < index; i++)
                {

                    //MessageBox.Show(i.ToString(), "row");
                    row = dataGridViewReturnDetails.Rows[i];
                    currentReturnQuantity = getCurrentReturnAmount_grid2(row);
                    productID1 = row.Cells["ProductID"].Value.ToString();
                    invoiceNo1 = row.Cells["InvoiceNo"].Value.ToString();
                    returnQuantity1 = row.Cells["Quantity"].Value.ToString();
                    int returnQuantity2 = currentReturnQuantity - Int32.Parse(returnQuantity1); ;
                    ///MessageBox.Show(returnQuantity2.ToString(), "Wrong value!!!");


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridViewReturnDetails.RowCount == 1)
            {
                refreshButtons_EnableDisable(false);
            }
            else if (dataGridViewReturnDetails.RowCount > 1)
            {
                btnAdd.Enabled = false;
                numericUpDownReturnQuantity.Enabled = false;
                btnClear.Enabled = false;
            }
            cmbBoxProductID.Text = null;
            cmbBoxInvoiceNo.Text = null;
            dataGridViewSalesDetails.DataSource = null;

        }//DONE --look more
        public void setParentForm(cashierForm parentCashierForm)
        {
            this.parentCashierForm = parentCashierForm;
        }//DONE

        private void numericUpDownReturnQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownReturnQuantity.Value <= 0)
            {
                MessageBox.Show("Invalid Quantity !!!", "Update Quantity");
                btnAdd.Enabled = false;
                numericUpDownReturnQuantity.Enabled = false;
            }
            else if (numericUpDownReturnQuantity.Value > getPossibleReturn())
            {
                MessageBox.Show("Customer didn't bought this much quantity to return back!", "Error in Quantity");
                btnAdd.Enabled = false;
            }
            else if (numericUpDownReturnQuantity.Value > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }//NOT WANT


        private void btnRemove_Click(object sender, EventArgs e)
        {

            int row_count = dataGridViewReturnDetails.Rows.Count;
            row_count--;
            DataGridViewRow last_row = dataGridViewReturnDetails.Rows[row_count - 1];


            if (dataGridViewReturnDetails.SelectedRows.Count > 0 )
            {



                updateCustomerOrdeerTransactionsForRemoveItem_RemoveButton();
                string myQuery = getRemoveItemQuery();
                if (myQuery.Length != 0)
                {
                    writeDataBaseReturn(myQuery, newConnnection);
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
                if (dataGridViewReturnDetails.RowCount == 1)
                {
                    btnReturn.Enabled = false;
                    btnRemove.Enabled = false;
                }
            }
        }//NO

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parentCashierForm.parentButtonActivation(true);
        }//NO --just close the form

        private string getRemoveItemQuery()
        {
            string query = "";
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
                        //MessageBox.Show(query);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return query;
        }

        private int getReturnQuantity()
        {
            int ReturnQuantity = 0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery;
            //DataGridViewRow row = dataGridViewSalesDetails.SelectedRows[0];
            //string productID1 = row.Cells["ProductID"].Value.ToString();
            //string invoiceNo1 = row.Cells["InvoiceNo"].Value.ToString();

            myQuery = "SELECT ReturnQuantity FROM pharmacy.order_transactions WHERE ProductID = " + cmbBoxProductID.Text + " AND InvoiceNo = " + cmbBoxInvoiceNo.Text + " ; ";
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
                    // MessageBox.Show(ReturnQuantity.ToString(), "return quantity -- getReturnQuantity()");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(myQuery, ex.Message + " GetReturnQuantity() ");
            }
            return ReturnQuantity;
        }//DONE
        private int getQuantity()
        {
            int Quantity = 0;
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery;

            //MessageBox.Show(this.dataGridViewSalesDetails.SelectedRows[0].Cells[1].ToString(), "read from data frid view//product ID -getQuantity()");

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
                MessageBox.Show(myQuery, ex.Message + " GetQuantity() ");
            }
            return Quantity;
        } // DONE

        private int getPossibleReturn()
        {
            int boughtQuantity = this.getQuantity();
            int returnQuantity = this.getReturnQuantity();
            int possibleReturn = boughtQuantity - returnQuantity;
            // MessageBox.Show(boughtQuantity.ToString(), "Quantity bought - getPossibleReturn()");
            // MessageBox.Show(returnQuantity.ToString(), "Quantity alredy returned - getPossibleReturn()");
            // MessageBox.Show(possibleReturn.ToString(), "Quantity available to return - getPossibleReturn()");
            return possibleReturn;
        }//DONE

        private int getCurrentReturnAmount()
        {

            string productID1;
            //string returnQuantity1;
            //string creditNote1;
            string invoiceNo1;
            int currentReturnQuantity = 0;

            productID1 = this.cmbBoxProductID.Text.ToString();
            //returnQuantity1 = this.numericUpDownReturnQuantity.Value.ToString();
            //creditNote1 = this.CreditNoteNo.ToString();
            invoiceNo1 = this.cmbBoxInvoiceNo.Text.ToString();

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
        }//DONE

        private int getCurrentReturnAmount_grid2(DataGridViewRow row)
        {
            int currentReturnQuantity = 0;
            try
            {
                string productID1;

                string invoiceNo1;



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

            } catch (Exception ex)
            {

            }
            return currentReturnQuantity;
        }

        private void updateCustomerOrdeerTransactionsForRemoveItem_RemoveButton()
        {
                string productID1 = "";
                string returnQuantity1 = "";
                string invoiceNo1 = "";
                int currentReturnQuantity = getCurrentReturnAmount_grid2(dataGridViewReturnDetails.CurrentRow);
                int row_count = dataGridViewReturnDetails.Rows.Count;
                row_count--;
                DataGridViewRow last_row = dataGridViewReturnDetails.Rows[row_count - 1];


                if (dataGridViewReturnDetails.SelectedRows.Count > 0 )
                {

                    foreach (DataGridViewRow row in dataGridViewReturnDetails.SelectedRows)
                    {
                        productID1 = row.Cells["ProductID"].Value.ToString();
                        invoiceNo1 = row.Cells["InvoiceNo"].Value.ToString();
                        returnQuantity1 = row.Cells["Quantity"].Value.ToString();
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
        }
}
