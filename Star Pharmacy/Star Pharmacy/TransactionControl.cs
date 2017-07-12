using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    public static class TransactionControl
    {
        //public static int generateTransactionID()
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.CommandText="select count(*) from inventory;";
        //    cmd.Connection=SqlCon.con;
        //    int result = int.Parse(cmd.ExecuteScalar().ToString());
        //    SqlCon.con.Open();
        //    if (result == 0)
        //    {
        //        return 1;
        //        SqlCon.con.Close();
        //    }
        //    else
        //    {
        //        cmd.CommandText = "SELECT MAX(`transaction_id`) AS `transaction_id` FROM order_transactions;";
        //        int max = int.Parse(cmd.ExecuteScalar().ToString());
        //        return max+1;
        //        SqlCon.con.Close();
        //    }
        //}
        public static int genrateInvoiceNo()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select count(*) from order_transactions;";
            cmd.Connection = SqlCon.con;
            SqlCon.con.Open();
            int result = int.Parse(cmd.ExecuteScalar().ToString());
            if (result == 0)
            {

                SqlCon.con.Close();
                return 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(`InvoiceNo`) AS `InvoiceNo` FROM order_transactions;";
                int max = int.Parse(cmd.ExecuteScalar().ToString());
                SqlCon.con.Close();
                return max + 1;
                
            }
            
        }
        public static void updateDatabase( DataGridView dg1,String invoiceNO,String cashierID)
        {

            SqlCon.con.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = SqlCon.con;
            foreach (DataGridViewRow row in dg1.Rows)
            {
                String productID = row.Cells[0].Value.ToString();
                String productName = row.Cells[1].Value.ToString();
                String createdDate = DateTime.Today.Date.ToString("yyyy-MM-dd");
                String createdTime = DateTime.Now.ToShortTimeString();
                String quantity = row.Cells[3].Value.ToString();
                String amount = row.Cells[4].Value.ToString();
                String branch = findBranch(cashierID);
                com.CommandText = "INSERT INTO `order_transactions` (`transaction_id`, `ProductID`, `ProductName`, `InvoiceNo`, `CashierID`, `CreatedDate`, `CreatedTime`, `Quantity`, `Amount`, `Branch`) VALUES (NULL, '"+productID+"', '"+productName+"', '"+invoiceNO+"', '"+cashierID+"', '"+createdDate+"', '"+createdTime+"', '"+quantity+"', '"+amount+"', '"+branch+"');";
                com.ExecuteNonQuery();
            }
            
            SqlCon.con.Close();
        }


        private static string findBranch(String cashierID)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from people where ID = '" + cashierID + "'; ", SqlCon.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0][9].ToString();
        }
    }
}
