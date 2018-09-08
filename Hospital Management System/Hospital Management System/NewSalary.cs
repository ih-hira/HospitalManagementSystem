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
    public partial class NewSalary : Form
    {
        public NewSalary()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {

                ArrayList dataInfo = new ArrayList();

                if (String.IsNullOrEmpty(textBox_eid.Text) || String.IsNullOrEmpty(textBox_name.Text) ||
                    String.IsNullOrEmpty(comboBox_jobtitle.Text) || String.IsNullOrEmpty(textBox_salary.Text) ||
                    String.IsNullOrEmpty(textBox_month.Text) || String.IsNullOrEmpty(dateTimePicker1.Text) ||
                    String.IsNullOrEmpty(textBox_status.Text))
                {
                    MessageBox.Show("Fill up all data");
                }

                else
                {
                    dataInfo.Add(textBox_eid.Text);
                    dataInfo.Add(textBox_name.Text);
                    dataInfo.Add(comboBox_jobtitle.Text);
                    dataInfo.Add(textBox_salary.Text);
                    dataInfo.Add(textBox_month.Text);
                    dataInfo.Add(dateTimePicker1.Text);
                    dataInfo.Add(textBox_status.Text);
                   

                    DatabaseHelperClass ob = new DatabaseHelperClass(dataInfo);

                    if (ob.addNewSalary())
                    {
                        MessageBox.Show("Salary Added");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Salary");
                    }
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show("Exception");
            }

        }
    }
}
