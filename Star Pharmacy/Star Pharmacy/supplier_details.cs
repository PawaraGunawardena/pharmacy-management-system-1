﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    public partial class supplier_details : Form
    {
        public supplier_details()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
        MySqlCommand command;
        MySqlDataReader mdr;
        
        private static supplier_details inst;

        public static supplier_details getSupplierDetails(SplitContainer s, Form f)
        {
            if (inst == null || inst.IsDisposed)
            {
                inst = new supplier_details();
                inst.MdiParent = f;
                s.Panel2.Controls.Add(inst);
                return inst;
            }
            else
            {
                return inst;
            }
        }



        private void supplier_details_Load(object sender, EventArgs e)
        {
            //con.Open();
        }

        private void btnViewSupliers_Click(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.supplierdetails;";
            SqlCon.updateDataGridView(query, supplierDetailsDgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            supplier_info_form supplierInfo = new supplier_info_form();
            string connString = "Server=localhost;Database=pharmacy;Uid=root;Pwd=;";
            command = new MySqlCommand("SELECT * FROM pharmacy.supplierdetails WHERE SupplierID=" + supplierDetailsDgv.SelectedRows[0].Cells[0].Value, con);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                supplierInfo.companyName.Text = mdr.GetString("CompanyName");
                supplierInfo.contactNumber.Text = mdr.GetString("ContactPersonTelephone");
                supplierInfo.contactPersonTelephone.Text = mdr.GetString("ContactPersonTelephone");
                supplierInfo.companyTelephone.Text = mdr.GetString("CompanyTelephone");

            }

            supplierInfo.Show();

            con.Close();

        }
    }
}