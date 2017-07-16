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

        public static void sendEmail(String attachment2)
        {

            try
            {

                /*
                 * Sending
                    password - administrator1
                    username- starxpharmacy@gmail.com

                   Recieving
                    password - iamtheowner
                    username - starxowner@gmail.com
                 */

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("starxpharmacy@gmail.com");  //give an address to send the email.

                /* 
                 * Note - You have to adjust the privacy settings in the email account.
                 * First try to give the proper credentials (Username and password) and try to run it.
                 * Then you'll recieve an email (in your sending mail account) from google saying that an external party tries to access it.
                 * Change settings to allow this access.
                 * Now you can send the messages freely.
                 * You have to do this only for the account which you provice the passwor, i.e. the account which  you're trying to send the mail from.
                 */


                mail.To.Add("starxowner@gmail.com");  //Give an address to recieve the email.
                mail.Subject = "Report";
                mail.Body = "mail with attachment";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(attachment2);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("starxpharmacy@gmail.com", "administrator1");  //Username password gahapan.
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("Mail Sent!");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        } 

         public static String generatePDF()
        {
            try
            {
                int yPoint = 0; //A pointer for the y coordinate.
                int i = 0;
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
                MySqlCommand command;
                MySqlDataReader mdr;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();

                String transaction_id;
                String product_id;
                String product_name;
                String invoice_no;
                String cashier_id;
                String createdDate;
                String createdTime;
                String Quantity;
                String Amount;
                String Branch;

                DateTime dateTime= DateTime.Now;

                string date = dateTime.ToString("yyyy-MM-dd");
                MessageBox.Show(date);

                con.Open();
                command = new MySqlCommand("SELECT * FROM pharmacy.order_transactions WHERE CreatedDate= '" + date +"';", con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                con.Close();


                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfPage pdfPage = pdf.AddPage();
                pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font2 = new XFont("Verdana", 16, XFontStyle.BoldItalic);

                yPoint = yPoint + 20;
                //XReacts' first parameter is the X cordinate.
                graph.DrawString("Daily Report", font2, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 20;
                XFont font3 = new XFont("Verdana", 14, XFontStyle.Italic);
                graph.DrawString("StarX Pharmacy and Grocery", font3, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                XFont font = new XFont("Courier New", 12, XFontStyle.Regular);

                XFont font4 = new XFont("Courier New", 8, XFontStyle.Regular);
                yPoint = yPoint + 100;


                graph.DrawString("TR.ID", font4, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("PR.ID", font4, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                //
                graph.DrawString("PN", font4, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("I.NO", font4, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("CSH.ID", font4, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                //


                graph.DrawString("DT", font4, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString("Q", font4, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString("BR", font4, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 20;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    transaction_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    product_id = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    product_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    invoice_no = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    cashier_id = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    createdDate = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    createdDate = createdDate.Replace("12:00:00AM", " ");   //Tried to remove 12:00:00AM from the created date but didn't work.
                    //It has something to do with ToString() method applied to a date type in MySQL.

                    Quantity = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    Amount = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    Branch = ds.Tables[0].Rows[i].ItemArray[9].ToString();


                    graph.DrawString(transaction_id, font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(product_id, font, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //
                    graph.DrawString(product_name, font, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(invoice_no, font, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cashier_id, font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //


                    graph.DrawString(createdDate, font, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString(Quantity, font, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString(Branch, font, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);



                    yPoint = yPoint + 40;
                }

                pdfFilename = "C:/New folder/Report.pdf";
                pdf.Save(pdfFilename);
                //Process.Start(pdfFilename);
                sendEmail(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return pdfFilename;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //When the user presses this, he'd generate a PDF, saves it in his local computer and sends it to a designated email address.
            generatePDFtoRange();
   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public  void generatePDFtoRange()
        {

            if (date_chkbox.Checked)
            {
                try
                {

                    int yPoint = 0; //A pointer for the y coordinate.
                    int i = 0;
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
                    MySqlCommand command;
                    MySqlDataReader mdr;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DataSet ds = new DataSet();

                    String transaction_id;
                    String product_id;
                    String product_name;
                    String invoice_no;
                    String cashier_id;
                    String createdDate;
                    String createdTime;
                    String Quantity;
                    String Amount;
                    String Branch;

                    DateTime dateTime = DateTime.Now;

                    string date = dateTime.ToString("yyyy-MM-dd");
                    

                    con.Open();

                    //I have to give a certain range for the query.

                    command = new MySqlCommand("select * from order_transactions where CreatedDate between '" + from_dtp.Value.ToString("yyyy-MM-dd") + "' and '" + to_dtp.Value.ToString("yyyy-MM-dd") + "';", con);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    con.Close();


                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Database to PDF";
                    PdfPage pdfPage = pdf.AddPage();
                    pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                    XFont font2 = new XFont("Verdana", 16, XFontStyle.BoldItalic);

                    yPoint = yPoint + 20;
                    //XReacts' first parameter is the X cordinate.
                    graph.DrawString("Daily Report", font2, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 20;
                    XFont font3 = new XFont("Verdana", 14, XFontStyle.Italic);
                    graph.DrawString("StarX Pharmacy and Grocery", font3, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    XFont font = new XFont("Courier New", 12, XFontStyle.Regular);

                    XFont font4 = new XFont("Courier New", 8, XFontStyle.Regular);
                    yPoint = yPoint + 100;


                    graph.DrawString("TR.ID", font4, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("PR.ID", font4, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //
                    graph.DrawString("PN", font4, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("I.NO", font4, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("CSH.ID", font4, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //


                    graph.DrawString("DT", font4, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString("Q", font4, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString("BR", font4, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 20;

                    for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        transaction_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        product_id = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        product_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        invoice_no = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                        cashier_id = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                        createdDate = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                        createdDate = createdDate.Replace("12:00:00AM", " ");   //Tried to remove 12:00:00AM from the created date but didn't work.
                                                                                //It has something to do with ToString() method applied to a date type in MySQL.

                        Quantity = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                        Amount = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                        Branch = ds.Tables[0].Rows[i].ItemArray[9].ToString();


                        graph.DrawString(transaction_id, font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(product_id, font, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        //
                        graph.DrawString(product_name, font, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(invoice_no, font, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(cashier_id, font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        //


                        graph.DrawString(createdDate, font, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                        graph.DrawString(Quantity, font, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                        graph.DrawString(Branch, font, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);



                        yPoint = yPoint + 40;
                    }

                    pdfFilename = "C:/New folder/Report.pdf";
                    pdf.Save(pdfFilename);
                    //Process.Start(pdfFilename);
                    //sendEmail(pdfFilename);
                    MessageBox.Show("PDF Generated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }else
            {
                MessageBox.Show("Please Select Range button and provide a valid range.");
            }
            

            
        }

        //I have to create pdfs to other radio buttons as well.

        public void generateMothlyReport()
        {
            try
            {

                int yPoint = 0; //A pointer for the y coordinate.
                int i = 0;
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
                MySqlCommand command;
                MySqlCommand command2;
                MySqlDataReader mdr;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();

                String transaction_id;
                String product_id;
                String product_name;
                String invoice_no;
                String cashier_id;
                String createdDate;
                String createdTime;
                String Quantity;
                String Amount;
                String Branch;

                DateTime dateTime = DateTime.Now;

                string date = dateTime.ToString("yyyy-MM-dd");
                string month = DateTime.Now.ToString("MMMM");

                var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                

                con.Open();

                //I have to give a certain range for the query.

                command = new MySqlCommand("SELECT * FROM order_transactions WHERE MONTH(CreatedDate)= MONTH(NOW());", con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                con.Close();


                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfPage pdfPage = pdf.AddPage();
                pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font2 = new XFont("Verdana", 16, XFontStyle.BoldItalic);

                yPoint = yPoint + 20;
                //XReacts' first parameter is the X cordinate.
                graph.DrawString("Daily Report", font2, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 20;
                XFont font3 = new XFont("Verdana", 14, XFontStyle.Italic);
                graph.DrawString("StarX Pharmacy and Grocery", font3, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                yPoint = yPoint + 30;
                XFont font5 = new XFont("Verdana", 14, XFontStyle.Italic);
                graph.DrawString("Monthly Report for " + month, font5, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                XFont font = new XFont("Courier New", 12, XFontStyle.Regular);

                XFont font4 = new XFont("Courier New", 8, XFontStyle.Regular);
                yPoint = yPoint + 100;


                graph.DrawString("TR.ID", font4, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("PR.ID", font4, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                //
                graph.DrawString("PN", font4, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("I.NO", font4, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("CSH.ID", font4, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                //


                graph.DrawString("DT", font4, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString("Q", font4, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString("BR", font4, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 20;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    transaction_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    product_id = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    product_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    invoice_no = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    cashier_id = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    createdDate = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    createdDate = createdDate.Replace("12:00:00AM", " ");   //Tried to remove 12:00:00AM from the created date but didn't work.
                                                                            //It has something to do with ToString() method applied to a date type in MySQL.

                    Quantity = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    Amount = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    Branch = ds.Tables[0].Rows[i].ItemArray[9].ToString();


                    graph.DrawString(transaction_id, font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(product_id, font, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //
                    graph.DrawString(product_name, font, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(invoice_no, font, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cashier_id, font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //


                    graph.DrawString(createdDate, font, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString(Quantity, font, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString(Branch, font, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);



                    yPoint = yPoint + 40;
                }

                yPoint = yPoint + 30;
                con.Open();

                command2 = new MySqlCommand("SELECT SUM(Amount) FROM order_transactions WHERE MONTH(CreatedDate)= MONTH(NOW());", con);

                String sales = "";
                Decimal sum = (Decimal)command2.ExecuteScalar();
                con.Close();
                graph.DrawString("Net Sales for the Month = " + Convert.ToString(sum), font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);



                pdfFilename = "C:/Users/Geethani/Desktop/MonthlyReport.pdf";
                pdf.Save(pdfFilename);
                //Process.Start(pdfFilename);
                MessageBox.Show("Monthly Reports are generated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

}

        public static String generateMothlyReportS()
        {
            try
            {

                int yPoint = 0; //A pointer for the y coordinate.
                int i = 0;
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
                MySqlCommand command;
                MySqlCommand command2;
                MySqlDataReader mdr;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet ds = new DataSet();

                String transaction_id;
                String product_id;
                String product_name;
                String invoice_no;
                String cashier_id;
                String createdDate;
                String createdTime;
                String Quantity;
                String Amount;
                String Branch;

                DateTime dateTime = DateTime.Now;

                string date = dateTime.ToString("yyyy-MM-dd");
                string month = DateTime.Now.ToString("MMMM");

                var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                

                con.Open();

                //I have to give a certain range for the query.

                command = new MySqlCommand("SELECT * FROM order_transactions WHERE MONTH(CreatedDate)= MONTH(NOW());", con);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                con.Close();


                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfPage pdfPage = pdf.AddPage();
                pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font2 = new XFont("Verdana", 16, XFontStyle.BoldItalic);

                yPoint = yPoint + 20;
                //XReacts' first parameter is the X cordinate.
                graph.DrawString("Daily Report", font2, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 20;
                XFont font3 = new XFont("Verdana", 14, XFontStyle.Italic);
                graph.DrawString("StarX Pharmacy and Grocery", font3, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                yPoint = yPoint + 30;
                XFont font5 = new XFont("Verdana", 14, XFontStyle.Italic);
                graph.DrawString("Monthly Report for " + month, font5, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                XFont font = new XFont("Courier New", 12, XFontStyle.Regular);

                XFont font4 = new XFont("Courier New", 8, XFontStyle.Regular);
                yPoint = yPoint + 100;


                graph.DrawString("TR.ID", font4, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("PR.ID", font4, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                //
                graph.DrawString("PN", font4, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("I.NO", font4, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("CSH.ID", font4, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                //


                graph.DrawString("DT", font4, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString("Q", font4, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString("BR", font4, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 20;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    transaction_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    product_id = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    product_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    invoice_no = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    cashier_id = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    createdDate = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    createdDate = createdDate.Replace("12:00:00AM", " ");   //Tried to remove 12:00:00AM from the created date but didn't work.
                                                                            //It has something to do with ToString() method applied to a date type in MySQL.

                    Quantity = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    Amount = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    Branch = ds.Tables[0].Rows[i].ItemArray[9].ToString();


                    graph.DrawString(transaction_id, font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(product_id, font, XBrushes.Black, new XRect(70, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //
                    graph.DrawString(product_name, font, XBrushes.Black, new XRect(110, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(invoice_no, font, XBrushes.Black, new XRect(200, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cashier_id, font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //


                    graph.DrawString(createdDate, font, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString(Quantity, font, XBrushes.Black, new XRect(500, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString(Branch, font, XBrushes.Black, new XRect(550, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);



                    yPoint = yPoint + 40;
                }

                yPoint = yPoint + 30;
                con.Open();

                command2 = new MySqlCommand("SELECT SUM(Amount) FROM order_transactions WHERE MONTH(CreatedDate)= MONTH(NOW());", con);

                String sales = "";
                Decimal sum = (Decimal)command2.ExecuteScalar();
                con.Close();
                graph.DrawString("Net Sales for the Month = " + Convert.ToString(sum), font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);



                pdfFilename2 = "C:/Users/Geethani/Desktop/MonthlyReport.pdf";
                pdf.Save(pdfFilename2);
                MessageBox.Show("Monthly Reports are generated and emailed");
                //Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return pdfFilename2;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            generateMothlyReport();
        }
    }
}
