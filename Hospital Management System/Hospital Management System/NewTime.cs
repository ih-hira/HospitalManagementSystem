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
    public partial class NewTime : Form
    {
        public NewTime()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {

                ArrayList dataInfo = new ArrayList();

                if (String.IsNullOrEmpty(textBox_id.Text) || String.IsNullOrEmpty(textBox_name.Text) ||
                    String.IsNullOrEmpty(comboBox_jobtitle.Text) || String.IsNullOrEmpty(textBox_stime.Text) ||
                    String.IsNullOrEmpty(textBox_etime.Text) || String.IsNullOrEmpty(textBox_days.Text))
                {
                    MessageBox.Show("Fill up all data");
                }

                else
                {
                    dataInfo.Add(textBox_id.Text);
                    dataInfo.Add(textBox_name.Text);
                    dataInfo.Add(comboBox_jobtitle.Text);
                    
                    dataInfo.Add(textBox_stime.Text);
                    dataInfo.Add(textBox_etime.Text);
                    dataInfo.Add(textBox_days.Text);

                    DatabaseHelperClass ob = new DatabaseHelperClass(dataInfo);

                    if (ob.addNewTime())
                    {
                        MessageBox.Show("Schedule Added");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Schedule");
                    }
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show("Exception");
            }

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
