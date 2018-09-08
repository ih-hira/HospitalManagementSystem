using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public partial class UpdateSchedule : Form
    {
        String select;
        public UpdateSchedule()
        {
            InitializeComponent();
        }

        public UpdateSchedule(String select)
        {
            InitializeComponent();
            this.select = select;
            showList();
        }


        public void showList()
        {
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";

            String query = "select * from doctor_schedule Where Doctor_ID='" + select + "';";

            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {

                while (myReader.Read())
                {
                    textBox_docid.Text = Convert.ToString(myReader[0]);
                    textBox_name.Text = Convert.ToString(myReader[1]);
                    comboBox_department.Text = Convert.ToString(myReader[2]);
                    textBox_spec.Text = Convert.ToString(myReader[3]);
                    textBox_roomno.Text = Convert.ToString(myReader[4]);
                    textBox_stime.Text = Convert.ToString(myReader[5]);
                    textBox_etime.Text = Convert.ToString(myReader[6]);
                    textBox_days.Text = Convert.ToString(myReader[7]);
                }
                    

            }

            databaseConnection.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            ArrayList updateInfo = new ArrayList();


            updateInfo.Add(textBox_docid.Text);
            updateInfo.Add(textBox_name.Text);
            updateInfo.Add(comboBox_department.Text);
            updateInfo.Add(textBox_spec.Text);
            updateInfo.Add(textBox_roomno.Text);
            updateInfo.Add(textBox_stime.Text);
            updateInfo.Add(textBox_etime.Text);
            updateInfo.Add(textBox_days.Text);

            DatabaseHelperClass ob = new DatabaseHelperClass(updateInfo);

            if (ob.updateSchedule())
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error Update");
            }

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
