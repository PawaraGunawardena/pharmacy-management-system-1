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
            this.roleSelect_cmboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.address_txtBox = new System.Windows.Forms.TextBox();
            this.pwd_txtBox = new System.Windows.Forms.TextBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.salary_txtBox = new System.Windows.Forms.TextBox();
            this.dob_txtBox = new System.Windows.Forms.TextBox();
            this.lName_txtBox = new System.Windows.Forms.TextBox();
            this.fName_txtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.change_emp = new System.Windows.Forms.Button();
            this.fire_emp = new System.Windows.Forms.Button();
            this.add_emp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.empID_search = new System.Windows.Forms.NumericUpDown();
            this.role_CmbBox = new System.Windows.Forms.ComboBox();
            this.empfirstName_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.emp_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_details.Location = new System.Drawing.Point(29, 110);
            this.emp_details.Name = "emp_details";
            this.emp_details.Size = new System.Drawing.Size(707, 211);
            this.emp_details.TabIndex = 6;
            this.emp_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_details_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roleSelect_cmboBox);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.address_txtBox);
            this.groupBox1.Controls.Add(this.pwd_txtBox);
            this.groupBox1.Controls.Add(this.username_txtBox);
            this.groupBox1.Controls.Add(this.salary_txtBox);
            this.groupBox1.Controls.Add(this.dob_txtBox);
            this.groupBox1.Controls.Add(this.lName_txtBox);
            this.groupBox1.Controls.Add(this.fName_txtBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.change_emp);
            this.groupBox1.Controls.Add(this.fire_emp);
            this.groupBox1.Controls.Add(this.add_emp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Change Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // roleSelect_cmboBox
            // 
            this.roleSelect_cmboBox.DataSource = this.peopleBindingSource;
            this.roleSelect_cmboBox.FormattingEnabled = true;
            this.roleSelect_cmboBox.Location = new System.Drawing.Point(543, 81);
            this.roleSelect_cmboBox.Name = "roleSelect_cmboBox";
            this.roleSelect_cmboBox.Size = new System.Drawing.Size(147, 21);
            this.roleSelect_cmboBox.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(281, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(147, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Employee ID";
            // 
            // address_txtBox
            // 
            this.address_txtBox.Location = new System.Drawing.Point(281, 120);
            this.address_txtBox.Multiline = true;
            this.address_txtBox.Name = "address_txtBox";
            this.address_txtBox.Size = new System.Drawing.Size(147, 42);
            this.address_txtBox.TabIndex = 18;
            this.address_txtBox.TextChanged += new System.EventHandler(this.address_txtBox_TextChanged);
            // 
            // pwd_txtBox
            // 
            this.pwd_txtBox.Location = new System.Drawing.Point(543, 153);
            this.pwd_txtBox.Name = "pwd_txtBox";
            this.pwd_txtBox.Size = new System.Drawing.Size(147, 20);
            this.pwd_txtBox.TabIndex = 17;
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(543, 117);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(147, 20);
            this.username_txtBox.TabIndex = 16;
            // 
            // salary_txtBox
            // 
            this.salary_txtBox.Location = new System.Drawing.Point(543, 48);
            this.salary_txtBox.Name = "salary_txtBox";
            this.salary_txtBox.Size = new System.Drawing.Size(147, 20);
            this.salary_txtBox.TabIndex = 14;
            // 
            // dob_txtBox
            // 
            this.dob_txtBox.Location = new System.Drawing.Point(543, 13);
            this.dob_txtBox.Name = "dob_txtBox";
            this.dob_txtBox.Size = new System.Drawing.Size(147, 20);
            this.dob_txtBox.TabIndex = 13;
            // 
            // lName_txtBox
            // 
            this.lName_txtBox.Location = new System.Drawing.Point(281, 87);
            this.lName_txtBox.Name = "lName_txtBox";
            this.lName_txtBox.Size = new System.Drawing.Size(147, 20);
            this.lName_txtBox.TabIndex = 12;
            // 
            // fName_txtBox
            // 
            this.fName_txtBox.Location = new System.Drawing.Point(281, 52);
            this.fName_txtBox.Name = "fName_txtBox";
            this.fName_txtBox.Size = new System.Drawing.Size(147, 20);
            this.fName_txtBox.TabIndex = 11;
            this.fName_txtBox.TextChanged += new System.EventHandler(this.fName_txtBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary";
            // 
            // change_emp
            // 
            this.change_emp.Location = new System.Drawing.Point(6, 79);
            this.change_emp.Name = "change_emp";
            this.change_emp.Size = new System.Drawing.Size(127, 23);
            this.change_emp.TabIndex = 6;
            this.change_emp.Text = "Change Details";
            this.change_emp.UseVisualStyleBackColor = true;
            // 
            // fire_emp
            // 
            this.fire_emp.Location = new System.Drawing.Point(6, 133);
            this.fire_emp.Name = "fire_emp";
            this.fire_emp.Size = new System.Drawing.Size(127, 23);
            this.fire_emp.TabIndex = 5;
            this.fire_emp.Text = "Fire Employee";
            this.fire_emp.UseVisualStyleBackColor = true;
            // 
            // add_emp
            // 
            this.add_emp.Location = new System.Drawing.Point(6, 29);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(127, 23);
            this.add_emp.TabIndex = 4;
            this.add_emp.Text = "Add Employee";
            this.add_emp.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.empID_search);
            this.groupBox2.Controls.Add(this.role_CmbBox);
            this.groupBox2.Controls.Add(this.empfirstName_txtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seach Employee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 32);
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
            this.role_CmbBox.DataSource = this.peopleBindingSource;
            this.role_CmbBox.FormattingEnabled = true;
            this.role_CmbBox.Location = new System.Drawing.Point(581, 29);
            this.role_CmbBox.Name = "role_CmbBox";
            this.role_CmbBox.Size = new System.Drawing.Size(100, 21);
            this.role_CmbBox.TabIndex = 13;
            // 
            // empfirstName_txtBox
            // 
            this.empfirstName_txtBox.Location = new System.Drawing.Point(195, 29);
            this.empfirstName_txtBox.Name = "empfirstName_txtBox";
            this.empfirstName_txtBox.Size = new System.Drawing.Size(120, 20);
            this.empfirstName_txtBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 32);
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
            // emp_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 541);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button fire_emp;
        private System.Windows.Forms.Button add_emp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button change_emp;
        private System.Windows.Forms.TextBox address_txtBox;
        private System.Windows.Forms.TextBox pwd_txtBox;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox salary_txtBox;
        private System.Windows.Forms.TextBox dob_txtBox;
        private System.Windows.Forms.TextBox lName_txtBox;
        private System.Windows.Forms.TextBox fName_txtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown empID_search;
        private System.Windows.Forms.ComboBox role_CmbBox;
        private System.Windows.Forms.TextBox empfirstName_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox roleSelect_cmboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
    }
}