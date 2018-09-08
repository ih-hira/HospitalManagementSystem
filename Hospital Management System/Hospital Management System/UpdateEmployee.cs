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
    public partial class UpdateEmployee : Form
    {
        private String select;
        private String employee;
       

        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public UpdateEmployee(String select , String emp)
        {
            InitializeComponent();
            this.select = select;
            this.employee = emp;
            showList();
        }


        public void showList()
        {
            
            if(employee=="Doctor")
            { 

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";

                String query = "select * from doctor Where Doctor_ID='" + select + "';";

                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    while (myReader.Read())
                    {
                        textBox_id.Text = Convert.ToString(myReader[0]);
                        textBox_name.Text = Convert.ToString(myReader[1]);
                        textBox_age.Text = Convert.ToString(myReader[2]);
                        comboBox_gender.Text = Convert.ToString(myReader[3]);
                        textBox_dept.Text = Convert.ToString(myReader[4]);
                        textBox_qual.Text = Convert.ToString(myReader[5]);
                        textBox_exp.Text = Convert.ToString(myReader[6]);
                        textBox_salary.Text = Convert.ToString(myReader[7]);
                        textBox_phone.Text = Convert.ToString(myReader[8]);
                        richTextBox_address.Text = Convert.ToString(myReader[9]);
                    }



                }

                databaseConnection.Close();


            }


            else if (employee == "Receptionist")
            {

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";

                String query = "select * from receptionist Where Recep_ID='" + select + "';";

                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    while (myReader.Read())
                    {
                        textBox_id.Text = Convert.ToString(myReader[0]);
                        textBox_name.Text = Convert.ToString(myReader[1]);
                        textBox_age.Text = Convert.ToString(myReader[2]);
                        comboBox_gender.Text = Convert.ToString(myReader[3]);
                        textBox_dept.Text = Convert.ToString(myReader[4]);
                        textBox_qual.Text = Convert.ToString(myReader[5]);
                        textBox_exp.Text = Convert.ToString(myReader[6]);
                        textBox_salary.Text = Convert.ToString(myReader[7]);
                        textBox_phone.Text = Convert.ToString(myReader[8]);
                        richTextBox_address.Text = Convert.ToString(myReader[9]);
                    }



                }

                databaseConnection.Close();


            }


            else if (employee == "Nurse")
            {

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";

                String query = "select * from nurse Where Nurse_ID='" + select + "';";

                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    while (myReader.Read())
                    {
                        textBox_id.Text = Convert.ToString(myReader[0]);
                        textBox_name.Text = Convert.ToString(myReader[1]);
                        textBox_age.Text = Convert.ToString(myReader[2]);
                        comboBox_gender.Text = Convert.ToString(myReader[3]);
                        textBox_dept.Text = Convert.ToString(myReader[4]);
                        textBox_qual.Text = Convert.ToString(myReader[5]);
                        textBox_exp.Text = Convert.ToString(myReader[6]);
                        textBox_salary.Text = Convert.ToString(myReader[7]);
                        textBox_phone.Text = Convert.ToString(myReader[8]);
                        richTextBox_address.Text = Convert.ToString(myReader[9]);
                    }



                }

                databaseConnection.Close();


            }


            else if (employee == "Stuff")
            {

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";

                String query = "select * from stuff Where Stuff_ID='" + select + "';";

                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    while (myReader.Read())
                    {
                        textBox_id.Text = Convert.ToString(myReader[0]);
                        textBox_name.Text = Convert.ToString(myReader[1]);
                        textBox_age.Text = Convert.ToString(myReader[2]);
                        comboBox_gender.Text = Convert.ToString(myReader[3]);
                        textBox_dept.Text = Convert.ToString(myReader[4]);
                        textBox_qual.Text = Convert.ToString(myReader[5]);
                        textBox_exp.Text = Convert.ToString(myReader[6]);
                        textBox_salary.Text = Convert.ToString(myReader[7]);
                        textBox_phone.Text = Convert.ToString(myReader[8]);
                        richTextBox_address.Text = Convert.ToString(myReader[9]);
                    }



                }

                databaseConnection.Close();


            }

            else
                MessageBox.Show("Employee Not Found");

        }







        private void button_update_Click(object sender, EventArgs e)
        {
            ArrayList updateInfo = new ArrayList();


            updateInfo.Add(textBox_id.Text);
            updateInfo.Add(textBox_name.Text);
            updateInfo.Add(textBox_age.Text);
            updateInfo.Add(comboBox_gender.Text);
            updateInfo.Add(textBox_dept.Text);
            updateInfo.Add(textBox_qual.Text);
            updateInfo.Add(textBox_exp.Text);
            updateInfo.Add(textBox_salary.Text);
            updateInfo.Add(textBox_phone.Text);
            updateInfo.Add(richTextBox_address.Text);

            DatabaseHelperClass ob = new DatabaseHelperClass(updateInfo);

            if (ob.updateEmployee(employee))
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
