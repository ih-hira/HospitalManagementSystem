using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Hospital_Management_System
{
    public partial class UserControl_Patientinfo : UserControl
    {
        private String pid;
        private static UserControl_Patientinfo _instance;
        private DataTable dt = new DataTable();

        public static UserControl_Patientinfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl_Patientinfo();
                }
                return _instance;
            }

        }

        public UserControl_Patientinfo()
        {
            InitializeComponent();

        }
        public void showPatientList()
        {
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "select Pid,Name from patient";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            DataTable newDt = new DataTable();
            dt = newDt;
            if (myReader.HasRows)
            {

                newDt.Load(myReader);

                dataGridView_patientList.DataSource = newDt;

            }
            databaseConnection.Close();
        }

        private void UserControl_Patientinfo_Load(object sender, EventArgs e)
        {
            showPatientList();
        }


        private void button_refresh_Click(object sender, EventArgs e)
        {
            showPatientList();
        }

        
        private void dataGridView_patientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pid = dataGridView_patientList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            try
            {
                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "select * from patient where Pid ='" + pid + "';";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        textBox_pid.Text = myReader[0].ToString();
                        textBox_rid.Text = myReader[1].ToString();
                        textBox_name.Text = myReader[2].ToString();
                        textBox_gender.Text = myReader[3].ToString();
                        textBox_age.Text = myReader[4].ToString();
                        textBox_phone.Text = myReader[5].ToString();
                        richTextBox_address.Text = myReader[6].ToString();
                        textBox_disease.Text = myReader[7].ToString();
                        textBox_status.Text = myReader[8].ToString();
                        textBox_roomno.Text = myReader[9].ToString();
                        textBox_checkin.Text = myReader[10].ToString();
                        textBox_roomtype.Text = myReader[11].ToString();
                        textBox_building.Text = myReader[12].ToString();
                    }

                }
                databaseConnection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Data not found");
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            ArrayList patientInfo = new ArrayList();


            patientInfo.Add(textBox_pid.Text);
            patientInfo.Add(textBox_rid.Text);
            patientInfo.Add(textBox_name.Text);
            patientInfo.Add(textBox_gender.Text);
            patientInfo.Add(textBox_age.Text);
            patientInfo.Add(textBox_phone.Text);
            patientInfo.Add(richTextBox_address.Text);
            patientInfo.Add(textBox_disease.Text);
            patientInfo.Add(textBox_status.Text);
            patientInfo.Add(textBox_roomno.Text);
            patientInfo.Add(textBox_checkin.Text);
            patientInfo.Add(textBox_roomtype.Text);
            patientInfo.Add(textBox_building.Text);
            DatabaseHelperClass ob = new DatabaseHelperClass(patientInfo);
            if (ob.updateData())
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
            this.Dispose();
            _instance = null;
        }

        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Name like '%{0}%'",textBox_input.Text);
                dataGridView_patientList.DataSource = dv.ToTable();
            }
        }

       

        private void button_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_patientList.CurrentCell.RowIndex;
            dataGridView_patientList.Rows.RemoveAt(rowIndex);

            String select = pid;


            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "DELETE FROM patient WHERE Pid = '" + select + "';";

            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(myReader);
                dataGridView_patientList.DataSource = dt;

            }
            databaseConnection.Close();
        }
    }
}
