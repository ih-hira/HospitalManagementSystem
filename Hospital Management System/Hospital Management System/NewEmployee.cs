using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public partial class NewEmployee : Form
    {
       
        private String employee;

        public NewEmployee()
        {
            InitializeComponent();
        }

        
        public NewEmployee(String emp)
        {
            InitializeComponent();
            this.employee = emp;
          
        }
        

        private void button_add_Click(object sender, EventArgs e)
        {

            if (employee == "Doctor")
            {

                ArrayList userInfo = new ArrayList();

                if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_age.Text) ||
                    String.IsNullOrEmpty(textBox_dept.Text) || String.IsNullOrEmpty(textBox_qual.Text) ||
                    String.IsNullOrEmpty(textBox_exp.Text) || String.IsNullOrEmpty(textBox_salary.Text) ||
                    String.IsNullOrEmpty(textBox_phone.Text) || String.IsNullOrEmpty(richTextBox_address.Text))
                {
                    MessageBox.Show("Fill up all data");
                }

                else
                {
                    userInfo.Add(textBox_id.Text);
                    userInfo.Add(textBox_name.Text);
                    userInfo.Add(textBox_age.Text);
                    userInfo.Add(comboBox_gender.Text);
                    userInfo.Add(textBox_dept.Text);
                    userInfo.Add(textBox_qual.Text);
                    userInfo.Add(textBox_exp.Text);
                    userInfo.Add(textBox_salary.Text);
                    userInfo.Add(textBox_phone.Text);
                    userInfo.Add(richTextBox_address.Text);

                    DatabaseHelperClass ob = new DatabaseHelperClass(userInfo);

                    if (ob.addNewEmployee(employee))
                    {
                        MessageBox.Show("Doctor Added");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Doctor");
                    }
                }
            }

            else if (employee == "Receptionist")
            {
                ArrayList userInfo = new ArrayList();

                if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_age.Text) ||
                    String.IsNullOrEmpty(textBox_dept.Text) || String.IsNullOrEmpty(textBox_qual.Text) ||
                    String.IsNullOrEmpty(textBox_exp.Text) || String.IsNullOrEmpty(textBox_salary.Text) ||
                    String.IsNullOrEmpty(textBox_phone.Text) || String.IsNullOrEmpty(richTextBox_address.Text))
                {
                    MessageBox.Show("Fill up all data");
                }

                else
                {
                    userInfo.Add(textBox_id.Text);
                    userInfo.Add(textBox_name.Text);
                    userInfo.Add(textBox_age.Text);
                    userInfo.Add(comboBox_gender.Text);
                    userInfo.Add(textBox_dept.Text);
                    userInfo.Add(textBox_qual.Text);
                    userInfo.Add(textBox_exp.Text);
                    userInfo.Add(textBox_salary.Text);
                    userInfo.Add(textBox_phone.Text);
                    userInfo.Add(richTextBox_address.Text);

                    DatabaseHelperClass ob = new DatabaseHelperClass(userInfo);
                    if (ob.addNewEmployee(employee))
                    {
                        MessageBox.Show("Receptionist Added");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Receptionist");
                    }
                }

            }

            else if (employee == "Nurse")
            {
                ArrayList userInfo = new ArrayList();

                if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_age.Text) ||
                    String.IsNullOrEmpty(textBox_dept.Text) || String.IsNullOrEmpty(textBox_qual.Text) ||
                    String.IsNullOrEmpty(textBox_exp.Text) || String.IsNullOrEmpty(textBox_salary.Text) ||
                    String.IsNullOrEmpty(textBox_phone.Text) || String.IsNullOrEmpty(richTextBox_address.Text))
                {
                    MessageBox.Show("Fill up all data");
                }

                else
                {
                    userInfo.Add(textBox_id.Text);
                    userInfo.Add(textBox_name.Text);
                    userInfo.Add(textBox_age.Text);
                    userInfo.Add(comboBox_gender.Text);
                    userInfo.Add(textBox_dept.Text);
                    userInfo.Add(textBox_qual.Text);
                    userInfo.Add(textBox_exp.Text);
                    userInfo.Add(textBox_salary.Text);
                    userInfo.Add(textBox_phone.Text);
                    userInfo.Add(richTextBox_address.Text);

                    DatabaseHelperClass ob = new DatabaseHelperClass(userInfo);
                    if (ob.addNewEmployee(employee))
                    {
                        MessageBox.Show("Nurse Added");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Nurse");
                    }
                }

            }


            else if (employee == "Stuff")
            {
                ArrayList userInfo = new ArrayList();

                if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_age.Text) ||
                    String.IsNullOrEmpty(textBox_dept.Text) || String.IsNullOrEmpty(textBox_qual.Text) ||
                    String.IsNullOrEmpty(textBox_exp.Text) || String.IsNullOrEmpty(textBox_salary.Text) ||
                    String.IsNullOrEmpty(textBox_phone.Text) || String.IsNullOrEmpty(richTextBox_address.Text))
                {
                    MessageBox.Show("Fill up all data");
                }

                else
                {
                    userInfo.Add(textBox_id.Text);
                    userInfo.Add(textBox_name.Text);
                    userInfo.Add(textBox_age.Text);
                    userInfo.Add(comboBox_gender.Text);
                    userInfo.Add(textBox_dept.Text);
                    userInfo.Add(textBox_qual.Text);
                    userInfo.Add(textBox_exp.Text);
                    userInfo.Add(textBox_salary.Text);
                    userInfo.Add(textBox_phone.Text);
                    userInfo.Add(richTextBox_address.Text);

                    DatabaseHelperClass ob = new DatabaseHelperClass(userInfo);
                    if (ob.addNewEmployee(employee))
                    {
                        MessageBox.Show("Stuff Added");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Stuff");
                    }
                }

            }


            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
