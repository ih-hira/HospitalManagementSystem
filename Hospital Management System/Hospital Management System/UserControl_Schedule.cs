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
    public partial class UserControl_Schedule : UserControl
    {
        private String data;

        private static UserControl_Schedule _instance;

        public static UserControl_Schedule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Schedule();
                return _instance;


            }

        }

        public UserControl_Schedule()
        {
            InitializeComponent();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            try
            {
                String title = comboBox_jobtitle.Text;

                if (title == "Doctor")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from schedule where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_schedule.DataSource = dt;

                    }

                    databaseConnection.Close();

                }

                else if (title == "Receptionist")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from schedule where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_schedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (title == "Nurse")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from schedule where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_schedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }

                else if (title == "Stuff")
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    String query = "SELECT * from schedule where Job_Title='" + title + "';";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    if (myReader.HasRows)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(myReader);

                        dataGridView_schedule.DataSource = dt;

                    }

                    databaseConnection.Close();
                }



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
                NewTime ob = new NewTime();
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_schedule.CurrentCell.RowIndex;
            dataGridView_schedule.Rows.RemoveAt(rowIndex);

            String select = data;

            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "DELETE FROM schedule WHERE Employee_ID ='" + select + "';";



            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(myReader);
                dataGridView_schedule.DataSource = dt;

            }
            databaseConnection.Close();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_schedule.CurrentCell.RowIndex;

            UpdateTime ob = new UpdateTime(data);
            ob.Show();
        }

        private void dataGridView_schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data = dataGridView_schedule.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
