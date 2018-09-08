using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public partial class UserControl_Reports : UserControl
    {
        private static UserControl_Reports _instance;
        private DataTable dt = new DataTable();
        private String pid;
        public static UserControl_Reports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Reports();
                return _instance;
            }

        }

        public UserControl_Reports()
        {
            InitializeComponent();
            showPatientList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ArrayList reportInfo = new ArrayList();
            
            reportInfo.Add(textBox_patientid.Text);
            reportInfo.Add(textBox_testRequest.Text);
            reportInfo.Add(textBox_testComplete.Text);
            reportInfo.Add(dateTimePicker1.Text);

            DatabaseHelperClass ob = new DatabaseHelperClass(reportInfo);
            if (ob.addReport())
            {
                MessageBox.Show("Report Added");
                showPatientList();
            }
            else
            {
                MessageBox.Show("Error Adding Report");
            }
        }

        public void showPatientList()
        {
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "select PID from reports";
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

        private void UserControl_Reports_Load(object sender, EventArgs e)
        {
            showPatientList();
        }

        private void dataGridView_patientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pid = dataGridView_patientList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "select * from reports where Pid ='" + pid + "';";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    textBox_patientid.Text = myReader[0].ToString();
                    textBox_testRequest.Text = myReader[1].ToString();
                    textBox_testComplete.Text = myReader[2].ToString();
                    dateTimePicker1.Text = myReader[3].ToString();
                }

            }
            databaseConnection.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            ArrayList reportInfo = new ArrayList();

            reportInfo.Add(textBox_patientid.Text);
            reportInfo.Add(textBox_testRequest.Text);
            reportInfo.Add(textBox_testComplete.Text);
            reportInfo.Add(dateTimePicker1.Text);

            DatabaseHelperClass ob = new DatabaseHelperClass(reportInfo);
            if (ob.updateReportsData())
            {
                MessageBox.Show("Updated");
                showPatientList();
            }
            else
            {
                MessageBox.Show("Error Update");
            }
        }

        private void textBox_searchid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("PID like '%{0}%'", textBox_searchid.Text);
                dataGridView_patientList.DataSource = dv.ToTable();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }

    }
}
