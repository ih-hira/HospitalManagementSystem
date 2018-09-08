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
    public partial class UserControl_AppointmentShow : UserControl
    {
        private static UserControl_AppointmentShow _instance;
        private DataTable dt = new DataTable();
        private String aid;
        public static UserControl_AppointmentShow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AppointmentShow();
                return _instance;


            }

        }
        public void showPatientList()
        {
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "select Appointment_ID,Name from appointments";
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

        public UserControl_AppointmentShow()
        {
            InitializeComponent();
        }

        private void UserControl_AppointmentShow_Load(object sender, EventArgs e)
        {
            showPatientList();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            showPatientList();
        }

        private void dataGridView_patientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aid = dataGridView_patientList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            try
            {
                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "select * from appointments where Appointment_ID ='" + aid + "';";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        textBox_appoid.Text = myReader[0].ToString();
                        textBox_patientName.Text = myReader[1].ToString();
                        textBox_gender.Text = myReader[2].ToString();
                        textBox_age.Text = myReader[3].ToString();
                        textBox_phone.Text = myReader[4].ToString();
                        richTextBox_add.Text = myReader[5].ToString();
                        textBox_disease.Text = myReader[6].ToString();
                        textBox_docid.Text = myReader[7].ToString();
                        textBox_docname.Text = myReader[8].ToString();
                        textBox_roomno.Text = myReader[9].ToString();
                        textBox_date.Text = myReader[10].ToString();
                    }

                }
                databaseConnection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Data not found");
            }
        }

        private void textBox_givenName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Name like '%{0}%'", textBox_givenName.Text);
                dataGridView_patientList.DataSource = dv.ToTable();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            ArrayList patientInfo = new ArrayList();
            patientInfo.Add(textBox_appoid.Text);
            patientInfo.Add(textBox_patientName.Text);
            patientInfo.Add(textBox_gender.Text);
            patientInfo.Add(textBox_age.Text);
            patientInfo.Add(textBox_phone.Text);
            patientInfo.Add(richTextBox_add.Text);
            patientInfo.Add(textBox_disease.Text);
            patientInfo.Add(textBox_docid.Text);
            patientInfo.Add(textBox_docname.Text);
            patientInfo.Add(textBox_roomno.Text);
            patientInfo.Add(textBox_date.Text);
            DatabaseHelperClass ob = new DatabaseHelperClass(patientInfo);
            if (ob.updateAppointmentData())
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error Update");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_patientList.CurrentCell.RowIndex;
            dataGridView_patientList.Rows.RemoveAt(rowIndex);

            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "DELETE FROM appointments WHERE Appointment_ID = '" + aid + "';";

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
