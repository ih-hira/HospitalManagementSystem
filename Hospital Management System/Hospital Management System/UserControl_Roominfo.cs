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
    public partial class UserControl_Roominfo : UserControl
    {
        private static UserControl_Roominfo _instance;
        String roomid;

        public static UserControl_Roominfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Roominfo();
                return _instance;


            }

        }

        public UserControl_Roominfo()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            String roomtp = null;
            String building = comboBox_building.Text;

         

            if (radioButton_normal.Checked)
            {
                 roomtp = "Normal";

            }
            else if (radioButton_medium.Checked)
            {
                roomtp = "Medium";

            }
            else if (radioButton_vip.Checked)
            {
                roomtp = "VIP";

            }


            if (string.IsNullOrEmpty(roomtp) || string.IsNullOrEmpty(building))
            {
                MessageBox.Show("Enter Roomtype and Building");
            }

            else
            {

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "SELECT Room_ID from room WHERE Room_Type ='" + roomtp + "' AND Building='"+ building + "';";

                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {

                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    dataGridView_roomList.DataSource = dt;

                }
                databaseConnection.Close();
            }



           
        }

        private void dataGridView_roomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             roomid = dataGridView_roomList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            try
            {
                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                String query = "select * from room where Room_ID ='" + roomid + "';";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        textBox_roomno.Text = myReader[0].ToString();
                        textBox_roomtype.Text = myReader[1].ToString();
                        textBox_numbed.Text = myReader[2].ToString();
                        textBox_status.Text = myReader[3].ToString();
                        textBox_price.Text = myReader[4].ToString();
                        textBox_building.Text = myReader[5].ToString();
                        textBox_floorno.Text = myReader[6].ToString();
                      
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
            ArrayList roomList = new ArrayList();


            roomList.Add(textBox_roomno.Text);
            roomList.Add(textBox_roomtype.Text);
            roomList.Add(textBox_numbed.Text);
            roomList.Add(textBox_status.Text);
            roomList.Add(textBox_price.Text);
            roomList.Add(textBox_building.Text);
            roomList.Add(textBox_floorno.Text);
          


            DatabaseHelperClass ob = new DatabaseHelperClass(roomList);

            if (ob.updateRoom())
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
            int rowIndex = dataGridView_roomList.CurrentCell.RowIndex;
            dataGridView_roomList.Rows.RemoveAt(rowIndex);

            

            String select = roomid;


            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "DELETE FROM room WHERE Room_ID ='" + select + "';";



            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(myReader);
                dataGridView_roomList.DataSource = dt;

            }
            databaseConnection.Close();
        }
    }
}
