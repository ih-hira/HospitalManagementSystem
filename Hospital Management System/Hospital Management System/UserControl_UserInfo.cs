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



namespace Hospital_Management_System
{
    public partial class UserControl_UserInfo : UserControl
    {
        private static UserControl_UserInfo _instance;

        private String data;

        public static UserControl_UserInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_UserInfo();
                return _instance;


            }

        }

        public UserControl_UserInfo()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            NewUser ob = new NewUser();
            ob.Show();
        }


        public void showUserList()
        {
            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "SELECT User_ID,Username,Position,Name from user";

            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            if (myReader.HasRows)
            {

                DataTable dt = new DataTable();

                dt.Load(myReader);

                dataGridView_userList.DataSource = dt;

            }
            databaseConnection.Close();
        }

       


        private void UserControl_UserInfo_Load(object sender, EventArgs e)
        {
            showUserList();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            showUserList();
        }

        private void dataGridView_userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data = dataGridView_userList.Rows[e.RowIndex].Cells[0].Value.ToString();
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_userList.CurrentCell.RowIndex;
            dataGridView_userList.Rows.RemoveAt(rowIndex);

            String select = data;


            String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            String query = "DELETE FROM user WHERE User_ID ='" + select + "';";

            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();

            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            if (myReader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(myReader);
                dataGridView_userList.DataSource = dt;

            }
            databaseConnection.Close();

        }
        

        private void button_changepw_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_userList.CurrentCell.RowIndex;

            int select = Convert.ToInt32(data);

            ChangePassword ob = new ChangePassword(select);
            ob.Show();


        }
    }
}
