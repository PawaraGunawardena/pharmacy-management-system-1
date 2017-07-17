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
using MySql.Data.MySqlClient;

namespace Star_Pharmacy

{
    public partial class StockManagerForm : Form
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

        public StockManagerForm(int id, string branch)
        {
            InitializeComponent();
            this.logged_id = id;
            this.branch = branch;
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

        private void btnChnageDetails_Click(object sender, EventArgs e)
        {
            parentButtonActivation(false);
            readDetails();
            ChangePersonalDetails availabilityForm = new ChangePersonalDetails(firstName, lastName, logged_id, address, userName, password, branch, working, type, dob, salary);
            availabilityForm.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(availabilityForm);
            availabilityForm.Location = new Point((splitContainer1.Panel2.Width - availabilityForm.Width) / 2, (splitContainer1.Panel2.Height - availabilityForm.Height) / 2);
            availabilityForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            availabilityForm.Show();
            //availabilityForm.buttonDeactivate();
            availabilityForm.setParentStock(this);
        }
        public void parentButtonActivation(bool activation)
        {
            Button mulleriyawa = this.button1;
            Button welivita = this.button2;
            Button inventory = this.button3;
            Button btndetails = this.btnChnageDetails;

            mulleriyawa.Enabled = activation;
            welivita.Enabled = activation;
            inventory.Enabled = activation;
            btndetails.Enabled = activation;
        }

        public void readDetails()
        {
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = "SELECT * FROM pharmacy.people WHERE ID = " + logged_id + " ; ";
            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();
                while (newDataReader.Read())
                {
                    firstName = newDataReader.GetString("FirstName").ToString();
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

       
    }
}
