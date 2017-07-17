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
    public partial class cashierForm : Form
    {
        private string branch;
        private int logged_id;
        private string firstName;
        private string lastName;
        private string address;
        private string userName;
        private string password;
        private int working;
        private string type;
        private string dob;
        private int salary;

        public cashierForm(int id, string branch)
        {
            InitializeComponent();
            this.logged_id = id;
            this.branch = branch;
            readDetails();
            
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
            co.setParentForm(this);
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
            Application.Exit();
        }
        public void parentButtonActivation(bool activation)
        {
            Button returnBtn = this.btnReturnOrder;
            Button newOrderBtn = this.btnNewOrder;
            Button availabilityBtn = this.button3;
            Button btnChangeDetails = this.btnChangeDetails;

            returnBtn.Enabled = activation;
            newOrderBtn.Enabled = activation;
            availabilityBtn.Enabled = activation;
            btnChangeDetails.Enabled = activation;
        }

        public void readDetails()
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = "SELECT * FROM pharmacy.people WHERE ID = "+logged_id+" ; ";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    firstName=newDataReader.GetString("FirstName").ToString();
                    lastName = newDataReader.GetString("LastName").ToString();
                    type = newDataReader.GetString("Type").ToString();
                    address = newDataReader.GetString("Address").ToString();
                    dob = newDataReader.GetString("DateOfBirth").ToString();
                    salary = newDataReader.GetInt32("Salary");
                    userName = newDataReader.GetString("Username").ToString();
                    password = newDataReader.GetString("Password").ToString();
                    working = newDataReader.GetInt16("Working");

                   // M/essageBox.Show(firstName+lastName+type,"f  l t read Details() CashierForm)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "readDetails()-CashierForm");
            }
        }

        private void btnChangeDetails_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            readDetails();
            ChangePersonalDetails availabilityForm = new ChangePersonalDetails(firstName,lastName, logged_id, address, userName, password, branch, working, type,dob, salary);
            availabilityForm.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(availabilityForm);
            availabilityForm.Location = new Point((splitContainer1.Panel2.Width - availabilityForm.Width) / 2, (splitContainer1.Panel2.Height - availabilityForm.Height) / 2);
            availabilityForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            availabilityForm.Show();
            //availabilityForm.buttonDeactivate();
          availabilityForm.setParentForm(this);
        }
    }
}
