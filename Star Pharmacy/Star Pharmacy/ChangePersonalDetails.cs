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
    public partial class ChangePersonalDetails : Form
    {
        private string branch;
        private int logged_id;
        private string firstName;
        private string lastName;
        private string adress;
        private string userName;
        private string password;
        private int working;
        private string type;
        private string dob;
        private int salary;

        private string newUserName;
        private string newPassword;
        private string newAddress;
        private string newLastName;
        private string newConfirmPassword;

        private int enableUpdateLastName =0;
        private int enableUpdateAdress = 0;
        private int enablUserName = 0;
        private int enablePassword = 0;
        CheckBox[] check =new  CheckBox[4];
        cashierForm parentCashierForm;
        StockManagerForm stockForm;


        public ChangePersonalDetails(string fName, string lName,int id, string adress, string UName, string password, string branch , int working, string type, string dob, int salary )
        {
            InitializeComponent();

            this.branch = branch;
            this.logged_id = id;
            this.firstName = fName;
            this.lastName = lName;
            this.adress = adress;
            this.userName = UName;
            this.password = password;
            this.working = working;
            this.type = type;
            this.dob = dob;
            this.salary = salary;
            existingDetailsFill();
            button1.Enabled = false;
            btnUpdate.Enabled = false;
            txtAdress.Enabled = false;
            txtConfirmPasswordNew.Enabled = false;
            txtLastName.Enabled = false;
            txtPasswordNew.Enabled = false;
            txtUserNameNew.Enabled = false;
            checkBoxAddress.Enabled = false;
            checkBoxLastName.Enabled = false;
            checkBoxPassword.Enabled = false;
            checkBoxUserName.Enabled = false;
            check[0] = checkBoxLastName;
            check[1] = checkBoxAddress;
            check[2] = checkBoxUserName;
            check[3] = checkBoxPassword;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void setParentForm(cashierForm parentCashierForm)
        {
            this.parentCashierForm = parentCashierForm;
        }
        private void existingDetailsFill()
        {
            lblgetAddress.Text = adress;
            lblgetBranch.Text = branch;
            lblgetDOB.Text = dob;
            lblgetFName.Text = firstName;
            lblgetLName.Text = lastName;
            lblgetID.Text = logged_id.ToString();
            lblgetPosition.Text = type;
            lblGetSalary.Text = salary.ToString();
            
        }
        private bool checkExistingPasswordAndUserName()
        {
            bool value = false;
            if (txtBoxOldUName.Text == userName && txtBoxOldPassword.Text == password)
            {
                value = true;
            }
            return value;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkExistingPasswordAndUserName())
            {
                MessageBox.Show(firstName +lastName+adress,"f l a ");
                checkBoxAddress.Enabled = true;
                checkBoxLastName.Enabled = true;
                checkBoxPassword.Enabled = true;
                checkBoxUserName.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Your enetered current username or password incorrect. Fill again and try", "Invalid Username or password");
                txtBoxOldPassword.Text = "";
                txtBoxOldUName.Text = "";
                MessageBox.Show(firstName + lastName + adress, "f l a ");

            }
        }


        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            newLastName = txtLastName.Text;
            //enablePassword = getCheckedAndnonEmpty(txtLastName);

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            newAddress = txtAdress.Text;
            //enableUpdateAdress = getCheckedAndnonEmpty(txtAdress);
        }

        private void txtUserNameNew_TextChanged(object sender, EventArgs e)
        {
            newUserName = txtUserNameNew.Text;
            //enablUserName = getCheckedAndnonEmpty(txtUserNameNew);
        }

        private void txtPasswordNew_TextChanged(object sender, EventArgs e)
        {
            newPassword = txtPasswordNew.Text;
            //enablePassword = getCheckedAndnonEmpty(txtPasswordNew);
        }

        private void txtConfirmPasswordNew_TextChanged(object sender, EventArgs e)
        {
            newConfirmPassword = txtConfirmPasswordNew.Text;
            //enablePassword = getCheckedAndnonEmpty(txtConfirmPasswordNew);
            
        }

        private string getNewQuery()
        {
            string query = "UPDATE pharmacy.people SET ";

            if (checkBoxLastName.Checked && txtLastName.Enabled)
            {
                query = query + "' , LastName = '" + newLastName;
            }
          
            if (checkBoxAddress.Checked)
            {
                query = query + "' , Address = '"+ newAddress;
            }
            
            if (checkBoxUserName.Checked)
            {
                query = query + "' , Username = '" + newUserName;
            }
        
            if ((checkBoxPassword.Checked) && (newPassword == newConfirmPassword))
            {
                query = query + "' , Password = '" + newPassword; 
            }
            else
            {
                MessageBox.Show("Wrong Password confirmation", "Password Error");
            }
            query = query + "' WHERE ID = " + logged_id +" ;";
            MessageBox.Show(query);
            query = query.Remove(query.IndexOf("' ,"), 4);
            MessageBox.Show(query);
            return query;

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            stockForm.parentButtonActivation(true);
            string connectionString = "server=localhost;user id=root;database=pharmacy";
            string myQuery = getNewQuery();

            MySqlConnection newConnnection = new MySqlConnection(connectionString);
            MySqlCommand newCommand = new MySqlCommand(myQuery, newConnnection);
            MySqlDataReader newDataReader;

            try
            {
                newConnnection.Open();
                newDataReader = newCommand.ExecuteReader();

                while (newDataReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong in the database writing");
            }
            this.Close();
        }


        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLastName.Checked)
            {
                txtLastName.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtLastName.Enabled = false;
                if (getCheckedAndnonEmpty())
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
            }
        }

        private void checkBoxAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddress.Checked)
            {
                txtAdress.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtAdress.Enabled = false;
                if (getCheckedAndnonEmpty())
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
            }
        }

        private void checkBoxUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserName.Checked)
            {
                txtUserNameNew.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtUserNameNew.Enabled = false;
                if (getCheckedAndnonEmpty())
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
            }

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                txtPasswordNew.Enabled = true;
                txtConfirmPasswordNew.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtPasswordNew.Enabled = false;
                txtConfirmPasswordNew.Enabled = false;
                if (getCheckedAndnonEmpty())
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                }
            }
        }

        private void txtBoxOldUName_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxOldUName.Text.Length !=0 && txtBoxOldPassword.Text.Length != 0)
            {
                button1.Enabled = true;
            }

        }

        private void txtBoxOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxOldUName.Text.Length != 0 && txtBoxOldPassword.Text.Length != 0)
            {
                button1.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            stockForm.parentButtonActivation(true);
        }

        private bool getCheckedAndnonEmpty()
        {
            bool enableupadate = false;
            foreach (CheckBox i in check)
            {
               
                if (i.Checked)
                {
                    enableupadate = true;
                    break;
                   // return true;
                }
            }
            return enableupadate;
        }
        public void setParentStock(StockManagerForm stockForm)
        {
            this.stockForm = stockForm;

        }
        
    }
}
