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
    public partial class UserControl_DoctorSchedule : UserControl
    {
        private String data;
        private static UserControl_DoctorSchedule _instance;

        public static UserControl_DoctorSchedule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_DoctorSchedule();
                return _instance;


            }

        }

        public UserControl_DoctorSchedule()
        {
            InitializeComponent();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            try
            {
                String dept = comboBox_department.Text;

                if (dept == "Anesthesiology")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='"+ dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

                    }

                    databaseConnection.Close();

                }

                else if (dept == "Medicine & Cardiology")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='" + dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (dept == "ENT")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='" + dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (dept == "Gynecology")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='" + dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }


                else if (dept == "Neurology")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='" + dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }


                else if (dept == "Orthopedic")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='" + dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }


                else if (dept == "Radiology and Imaging")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from doctor_schedule where Department='" + dept + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_docSchedule.DataSource = dt;

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



        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                NewSchedule ob = new NewSchedule();
                ob.Show();

            }

            catch (Exception exp)
            {
                MessageBox.Show("Error !");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }


        private void dataGridView_docSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data = dataGridView_docSchedule.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_docSchedule.CurrentCell.RowIndex;
            dataGridView_docSchedule.Rows.RemoveAt(rowIndex);

            String select = data;

            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "DELETE FROM doctor_schedule WHERE Doctor_ID ='" + select + "';";



            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(myReader);
                dataGridView_docSchedule.DataSource = dt;

            }
            databaseConnection.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_docSchedule.CurrentCell.RowIndex;
            String select=data;

            UpdateSchedule ob = new UpdateSchedule(select);
            ob.Show();
        }
    }
}
