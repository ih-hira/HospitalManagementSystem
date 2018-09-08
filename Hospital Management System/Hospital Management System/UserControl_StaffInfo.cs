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
    public partial class UserControl_StaffInfo : UserControl
    {
        private static UserControl_StaffInfo _instance;

        private String data;

        public static UserControl_StaffInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_StaffInfo();
                return _instance;


            }

        }

        public UserControl_StaffInfo()
        {
            InitializeComponent();
        }


        

        private void button_add_Click(object sender, EventArgs e)
        {

            try
            {
                String employee = comboBox_employee.Text;

                if (employee == "Doctor")
                {
                    NewEmployee ob = new NewEmployee(employee);
                    ob.Show();
                }

                else if (employee == "Receptionist")
                {
                    NewEmployee ob = new NewEmployee(employee);
                    ob.Show();
                }

                else if (employee == "Nurse")
                {
                    NewEmployee ob = new NewEmployee(employee);
                    ob.Show();
                }

                else if (employee == "Stuff")
                { 
                    NewEmployee ob = new NewEmployee(employee);
                    ob.Show();
                }

                else
                    MessageBox.Show("Select a Department");

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
                String employee = comboBox_employee.Text;

                if (employee == "Doctor")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_employee.DataSource = dt;

                    }

                    databaseConnection.Close();

                }

                else if (employee == "Receptionist")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from receptionist";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_employee.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (employee == "Nurse")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from nurse";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_employee.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (employee == "Stuff")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from stuff";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_employee.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else
                    MessageBox.Show("Select a Department");



            }

            catch (Exception exp)
            {
                MessageBox.Show("Error !");
            }

        }


        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data = dataGridView_employee.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        

        
        private void button_delete_Click(object sender, EventArgs e)
        {
            String employee = comboBox_employee.Text;

            if (employee == "Doctor")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;
                dataGridView_employee.Rows.RemoveAt(rowIndex);

                String select = data;


                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "DELETE FROM doctor WHERE Doctor_ID ='" + select + "';";



                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView_employee.DataSource = dt;

                }
                databaseConnection.Close();
            }


            else if (employee == "Receptionist")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;
                dataGridView_employee.Rows.RemoveAt(rowIndex);

                String select = data;


                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "DELETE FROM receptionist WHERE Recep_ID ='" + select + "';";



                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView_employee.DataSource = dt;

                }
                databaseConnection.Close();
            }

            else if (employee == "Nurse")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;
                dataGridView_employee.Rows.RemoveAt(rowIndex);

                String select = data;


                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "DELETE FROM nurse WHERE Nurse_ID ='" + select + "';";



                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView_employee.DataSource = dt;

                }
                databaseConnection.Close();
            }

            else if (employee == "Stuff")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;
                dataGridView_employee.Rows.RemoveAt(rowIndex);

                String select = data;


                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "DELETE FROM stuff WHERE Stuff_ID ='" + select + "';";



                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView_employee.DataSource = dt;

                }
                databaseConnection.Close();
            }


            else
                MessageBox.Show("Select a Department");

        }





        private void button_update_Click(object sender, EventArgs e)
        {
            String employee = comboBox_employee.Text;

            if (employee == "Doctor")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;

                UpdateEmployee ob = new UpdateEmployee(data,employee);
                ob.Show();
            }

            else if (employee == "Receptionist")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;
                
                UpdateEmployee ob = new UpdateEmployee(data, employee);
                ob.Show();
            }

            else if (employee == "Nurse")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;

                UpdateEmployee ob = new UpdateEmployee(data, employee);
                ob.Show();
            }

            else if (employee == "Stuff")
            {
                int rowIndex = dataGridView_employee.CurrentCell.RowIndex;
               
                UpdateEmployee ob = new UpdateEmployee(data, employee);
                ob.Show();
            }


            else
                MessageBox.Show("Select a Department");

        }





        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }


    }
}
