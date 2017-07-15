namespace Star_Pharmacy
{
    partial class emp_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet2 = new Star_Pharmacy.pharmacyDataSet2();
            this.peopleTableAdapter = new Star_Pharmacy.pharmacyDataSet2TableAdapters.peopleTableAdapter();
            this.emp_details = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.availability_indicator = new System.Windows.Forms.Label();
            this.salary_updown = new System.Windows.Forms.NumericUpDown();
            this.bdayPicker = new System.Windows.Forms.DateTimePicker();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.roleSelect_cmboBox = new System.Windows.Forms.ComboBox();
            this.emp_ID = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.address_txtBox = new System.Windows.Forms.TextBox();
            this.pwd_txtBox = new System.Windows.Forms.TextBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.lName_txtBox = new System.Windows.Forms.TextBox();
            this.fName_txtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emplastName_txtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.empID_search = new System.Windows.Forms.NumericUpDown();
            this.role_CmbBox = new System.Windows.Forms.ComboBox();
            this.empfirstName_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change_emp = new System.Windows.Forms.Button();
            this.fire_emp = new System.Windows.Forms.Button();
            this.add_emp = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.branchSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_ID)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empID_search)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "people";
            this.peopleBindingSource.DataSource = this.pharmacyDataSet2;
            // 
            // pharmacyDataSet2
            // 
            this.pharmacyDataSet2.DataSetName = "pharmacyDataSet2";
            this.pharmacyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // emp_details
            // 
            this.emp_details.AllowUserToAddRows = false;
            this.emp_details.AllowUserToDeleteRows = false;
            this.emp_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_details.Location = new System.Drawing.Point(29, 110);
            this.emp_details.MultiSelect = false;
            this.emp_details.Name = "emp_details";
            this.emp_details.ReadOnly = true;
            this.emp_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emp_details.Size = new System.Drawing.Size(742, 200);
            this.emp_details.TabIndex = 6;
            this.emp_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_details_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.branchSelect);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.availability_indicator);
            this.groupBox1.Controls.Add(this.salary_updown);
            this.groupBox1.Controls.Add(this.bdayPicker);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.roleSelect_cmboBox);
            this.groupBox1.Controls.Add(this.emp_ID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.address_txtBox);
            this.groupBox1.Controls.Add(this.pwd_txtBox);
            this.groupBox1.Controls.Add(this.username_txtBox);
            this.groupBox1.Controls.Add(this.lName_txtBox);
            this.groupBox1.Controls.Add(this.fName_txtBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(195, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // availability_indicator
            // 
            this.availability_indicator.AutoSize = true;
            this.availability_indicator.Location = new System.Drawing.Point(127, 16);
            this.availability_indicator.Name = "availability_indicator";
            this.availability_indicator.Size = new System.Drawing.Size(0, 13);
            this.availability_indicator.TabIndex = 25;
            // 
            // salary_updown
            // 
            this.salary_updown.DecimalPlaces = 2;
            this.salary_updown.Location = new System.Drawing.Point(360, 66);
            this.salary_updown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.salary_updown.Name = "salary_updown";
            this.salary_updown.Size = new System.Drawing.Size(147, 20);
            this.salary_updown.TabIndex = 24;
            // 
            // bdayPicker
            // 
            this.bdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdayPicker.Location = new System.Drawing.Point(98, 189);
            this.bdayPicker.Name = "bdayPicker";
            this.bdayPicker.Size = new System.Drawing.Size(147, 20);
            this.bdayPicker.TabIndex = 23;
            this.bdayPicker.Value = new System.DateTime(2017, 7, 15, 0, 0, 0, 0);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(289, 225);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 28);
            this.cancelBtn.TabIndex = 22;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(148, 225);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(119, 28);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // roleSelect_cmboBox
            // 
            this.roleSelect_cmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleSelect_cmboBox.FormattingEnabled = true;
            this.roleSelect_cmboBox.Items.AddRange(new object[] {
            "Owner",
            "Cashier",
            "StockManager"});
            this.roleSelect_cmboBox.Location = new System.Drawing.Point(360, 95);
            this.roleSelect_cmboBox.Name = "roleSelect_cmboBox";
            this.roleSelect_cmboBox.Size = new System.Drawing.Size(147, 21);
            this.roleSelect_cmboBox.TabIndex = 15;
            // 
            // emp_ID
            // 
            this.emp_ID.Location = new System.Drawing.Point(98, 32);
            this.emp_ID.Name = "emp_ID";
            this.emp_ID.Size = new System.Drawing.Size(147, 20);
            this.emp_ID.TabIndex = 20;
            this.emp_ID.ValueChanged += new System.EventHandler(this.emp_ID_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Employee ID";
            // 
            // address_txtBox
            // 
            this.address_txtBox.Location = new System.Drawing.Point(98, 134);
            this.address_txtBox.Multiline = true;
            this.address_txtBox.Name = "address_txtBox";
            this.address_txtBox.Size = new System.Drawing.Size(147, 42);
            this.address_txtBox.TabIndex = 18;
            this.address_txtBox.TextChanged += new System.EventHandler(this.address_txtBox_TextChanged);
            // 
            // pwd_txtBox
            // 
            this.pwd_txtBox.Location = new System.Drawing.Point(360, 167);
            this.pwd_txtBox.Name = "pwd_txtBox";
            this.pwd_txtBox.Size = new System.Drawing.Size(147, 20);
            this.pwd_txtBox.TabIndex = 17;
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(360, 131);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(147, 20);
            this.username_txtBox.TabIndex = 16;
            // 
            // lName_txtBox
            // 
            this.lName_txtBox.Location = new System.Drawing.Point(98, 101);
            this.lName_txtBox.Name = "lName_txtBox";
            this.lName_txtBox.Size = new System.Drawing.Size(147, 20);
            this.lName_txtBox.TabIndex = 12;
            // 
            // fName_txtBox
            // 
            this.fName_txtBox.Location = new System.Drawing.Point(98, 66);
            this.fName_txtBox.Name = "fName_txtBox";
            this.fName_txtBox.Size = new System.Drawing.Size(147, 20);
            this.fName_txtBox.TabIndex = 11;
            this.fName_txtBox.TextChanged += new System.EventHandler(this.fName_txtBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary        Rs.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emplastName_txtBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.empID_search);
            this.groupBox2.Controls.Add(this.role_CmbBox);
            this.groupBox2.Controls.Add(this.empfirstName_txtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seach Employee";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // emplastName_txtBox
            // 
            this.emplastName_txtBox.Location = new System.Drawing.Point(427, 29);
            this.emplastName_txtBox.Name = "emplastName_txtBox";
            this.emplastName_txtBox.Size = new System.Drawing.Size(120, 20);
            this.emplastName_txtBox.TabIndex = 16;
            this.emplastName_txtBox.TextChanged += new System.EventHandler(this.emplastName_txtBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Last Name";
            // 
            // empID_search
            // 
            this.empID_search.Location = new System.Drawing.Point(32, 30);
            this.empID_search.Name = "empID_search";
            this.empID_search.Size = new System.Drawing.Size(80, 20);
            this.empID_search.TabIndex = 14;
            this.empID_search.ValueChanged += new System.EventHandler(this.empID_search_ValueChanged);
            // 
            // role_CmbBox
            // 
            this.role_CmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_CmbBox.FormattingEnabled = true;
            this.role_CmbBox.Items.AddRange(new object[] {
            "Owner",
            "Cashier",
            "StockManager"});
            this.role_CmbBox.Location = new System.Drawing.Point(617, 29);
            this.role_CmbBox.Name = "role_CmbBox";
            this.role_CmbBox.Size = new System.Drawing.Size(100, 21);
            this.role_CmbBox.TabIndex = 13;
            this.role_CmbBox.SelectedIndexChanged += new System.EventHandler(this.role_CmbBox_SelectedIndexChanged);
            // 
            // empfirstName_txtBox
            // 
            this.empfirstName_txtBox.Location = new System.Drawing.Point(212, 30);
            this.empfirstName_txtBox.Name = "empfirstName_txtBox";
            this.empfirstName_txtBox.Size = new System.Drawing.Size(120, 20);
            this.empfirstName_txtBox.TabIndex = 12;
            this.empfirstName_txtBox.TextChanged += new System.EventHandler(this.empfirstName_txtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // change_emp
            // 
            this.change_emp.Location = new System.Drawing.Point(29, 414);
            this.change_emp.Name = "change_emp";
            this.change_emp.Size = new System.Drawing.Size(127, 40);
            this.change_emp.TabIndex = 11;
            this.change_emp.Text = "Change Details";
            this.change_emp.UseVisualStyleBackColor = true;
            this.change_emp.Click += new System.EventHandler(this.change_emp_Click);
            // 
            // fire_emp
            // 
            this.fire_emp.Location = new System.Drawing.Point(29, 486);
            this.fire_emp.Name = "fire_emp";
            this.fire_emp.Size = new System.Drawing.Size(127, 40);
            this.fire_emp.TabIndex = 10;
            this.fire_emp.Text = "Fire Employee";
            this.fire_emp.UseVisualStyleBackColor = true;
            this.fire_emp.Click += new System.EventHandler(this.fire_emp_Click);
            // 
            // add_emp
            // 
            this.add_emp.Location = new System.Drawing.Point(29, 342);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(127, 40);
            this.add_emp.TabIndex = 9;
            this.add_emp.Text = "Add Employee";
            this.add_emp.UseVisualStyleBackColor = true;
            this.add_emp.Click += new System.EventHandler(this.add_emp_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Branch";
            // 
            // branchSelect
            // 
            this.branchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchSelect.FormattingEnabled = true;
            this.branchSelect.Items.AddRange(new object[] {
            "Mulleriyawa",
            "Welivita"});
            this.branchSelect.Location = new System.Drawing.Point(360, 31);
            this.branchSelect.Name = "branchSelect";
            this.branchSelect.Size = new System.Drawing.Size(147, 21);
            this.branchSelect.TabIndex = 27;
            // 
            // emp_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 601);
            this.Controls.Add(this.change_emp);
            this.Controls.Add(this.fire_emp);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.emp_details);
            this.Name = "emp_management";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.emp_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_ID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empID_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private pharmacyDataSet2 pharmacyDataSet2;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private pharmacyDataSet2TableAdapters.peopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.DataGridView emp_details;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address_txtBox;
        private System.Windows.Forms.TextBox pwd_txtBox;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox lName_txtBox;
        private System.Windows.Forms.TextBox fName_txtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown empID_search;
        private System.Windows.Forms.ComboBox role_CmbBox;
        private System.Windows.Forms.TextBox empfirstName_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown emp_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox roleSelect_cmboBox;
        private System.Windows.Forms.TextBox emplastName_txtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button change_emp;
        private System.Windows.Forms.Button fire_emp;
        private System.Windows.Forms.Button add_emp;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker bdayPicker;
        private System.Windows.Forms.NumericUpDown salary_updown;
        private System.Windows.Forms.Label availability_indicator;
        private System.Windows.Forms.ComboBox branchSelect;
        private System.Windows.Forms.Label label14;
    }
}