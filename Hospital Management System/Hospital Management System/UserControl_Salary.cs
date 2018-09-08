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

namespace Hospital_Management_System
{
    public partial class UserControl_Salary : UserControl
    {
        private static UserControl_Salary _instance;

        public static UserControl_Salary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Salary();
                return _instance;


            }

        }

        public UserControl_Salary()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                NewSalary ob = new NewSalary();
                ob.Show();

            }

            catch (Exception exp)
            {
                MessageBox.Show("Error !");
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            try
            {
                String title = comboBox_jobtitle.Text;

                if (title == "Doctor")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from Salary where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_salary.DataSource = dt;

                    }

                    databaseConnection.Close();

                }

                else if (title == "Receptionist")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from Salary where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_salary.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (title == "Nurse")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from Salary where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_salary.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (title == "Stuff")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from Salary where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_salary.DataSource = dt;

                    }

                    databaseConnection.Close();
                }


                

                else
                {

                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from Salary";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_salary.DataSource = dt;

                    }

                    databaseConnection.Close();
                }



            }

            catch (Exception exp)
            {
                MessageBox.Show("Error !");
            }

        }
    }
}
