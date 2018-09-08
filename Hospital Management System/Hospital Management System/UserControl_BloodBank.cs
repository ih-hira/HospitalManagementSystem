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
    public partial class UserControl_BloodBank : UserControl
    {
        private static UserControl_BloodBank _instance;
        private DataTable dt = new DataTable();
        private String bloodType,noOfBags;
        public static UserControl_BloodBank Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_BloodBank();
                return _instance;
            }

        }

        public UserControl_BloodBank()
        {
            InitializeComponent();
            showBloodList();
        }

        public void showBloodList()
        {
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "select Blood_Type,Number_of_Bags from bloodbank";
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

                dataGridView_bloodList.DataSource = newDt;

            }
            databaseConnection.Close();
        }

        private void UserControl_BloodBank_Load(object sender, EventArgs e)
        {
            showBloodList();
        }

        private void dataGridView_bloodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bloodType = dataGridView_bloodList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            noOfBags = dataGridView_bloodList.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value.ToString();

            textBox_noOfBags.Text = noOfBags;
            label_bloodType.Text = bloodType;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            ArrayList bloodInfo = new ArrayList();
            bloodInfo.Add(label_bloodType.Text);
            bloodInfo.Add(textBox_noOfBags.Text);
            DatabaseHelperClass ob = new DatabaseHelperClass(bloodInfo);
            if (ob.updateBloodData())
            {
                MessageBox.Show("Updated");
                showBloodList();
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
    }
}
