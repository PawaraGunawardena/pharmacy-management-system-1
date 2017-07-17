using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Star_Pharmacy
{
    public partial class owner_form : Form
    {

        System.Timers.Timer timer;
        String file;
        String file2;

        delegate void UpdateMessageBox(String messageBoxString);

        void UpdateTheMessageBox(String str)
        {
            MessageBox.Show("Reports are generated for the day!");
            MessageBox.Show("Reports are generated for the day22222!");
            file = Utilities3.generatePDF();
            Utilities3.sendEmail(file);
            showNotification();
            
        }

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

            showNotification();
            //Initiating the timer
            if (DateTime.Now.Day == 28) //Ever29th of the month, a monthly report will get emailed.
            {

                file2 = Utilities3.generateMothlyReportS();
                Utilities3.sendEmail(file2);

            }

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            timer.Start();

        }


        public void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime current = DateTime.Now;
            //Setting the time to 7PM
            if(current.Hour == 19 &&  current.Minute == 00 && current.Second == 00)
            {
                
                //MessageBox.Show("Reports have been generated.", "Check Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                file = Utilities3.generatePDF(); //Generates the pdf at 7PM (Or between 7PM and 12Midnight) and saves it in local computer.
                Utilities3.sendEmail(file);  //Sends the file to a given location (Location is specified at sendEmail() method.

                //file is a String where it comprises of the location (Address) where the generated PDF is located. You can change it in generatePDF() method.
                //check out sendEmail(String file) for more information. 
                
                try
                {
                    //Thread managements. Have doubts on this.
                    UpdateMessageBox upd = UpdateTheMessageBox;
                    Invoke(upd);
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
             
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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            emp_management emp = emp_management.getEmpManagement(splitContainer1, this);
            emp.Location = new Point((splitContainer1.Panel2.Width - emp.Width) / 2, (splitContainer1.Panel2.Height - emp.Height) / 2);
            emp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            emp.Show();
        }

        private void showNotification()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.if_icon_28_information_314283;   
            //You may have to change this Image property. 
            // Add a reference to your image by going to Properties -> 
            popup.TitleText = "Notification.";
            popup.ContentText = "Remember to check your email for reports.";
            popup.Popup();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            hideUnwantedForms();
            NotificationForm nf = NotificationForm.getNotificationForm(splitContainer1, this);
            nf.Location = new Point((splitContainer1.Panel2.Width - nf.Width) / 2, (splitContainer1.Panel2.Height - nf.Height) / 2);
            nf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //nf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            nf.Show();
        }

        private void supTransaction_Btn_Click(object sender, EventArgs e)
        {
            hideUnwantedForms();
            supplier_transactions suptrans = supplier_transactions.getSupTransactions(splitContainer1, this);
            suptrans.refreshdatagrid();
            suptrans.Location = new Point((splitContainer1.Panel2.Width - suptrans.Width) / 2, (splitContainer1.Panel2.Height - suptrans.Height) / 2);
            suptrans.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            suptrans.Show();
        }
    }
}
