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
    public partial class UserControl_Checkout : UserControl
    {
        private String pid;
        private DataTable dt = new DataTable();
        private static UserControl_Checkout _instance;

        public static UserControl_Checkout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Checkout();
                return _instance;


            }

        }

        public UserControl_Checkout()
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
            
            if (myReader.HasRows)
            {

                DataTable newdt = new DataTable();

                newdt.Load(myReader);
                dt = newdt;
                dataGridView_patientList.DataSource = newdt;

            }
            databaseConnection.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            showPatientList();
        }

        private void UserControl_Checkout_Load(object sender, EventArgs e)
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
                        textBox_roomno.Text = myReader[9].ToString();
                        textBox_datein.Text = myReader[10].ToString();
                        textBox_roomtype.Text = myReader[11].ToString();
                        textBox_building.Text = myReader[12].ToString();
                        textBox_checked.Text = myReader[13].ToString();
                    }

                }
                databaseConnection.Close();
            }

            catch (Exception exp)
            {
                MessageBox.Show("Data not found");
            }

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }

       
        private void button_submit_Click(object sender, EventArgs e)
        {
            ArrayList patientInfo = new ArrayList();


            patientInfo.Add(textBox_billid.Text);
            patientInfo.Add(textBox_pid.Text);
            patientInfo.Add(textBox_datein.Text);
            patientInfo.Add(textBox_dateout.Text);
            patientInfo.Add(textBox_days.Text);
            patientInfo.Add(textBox_roomtype.Text);
            patientInfo.Add(textBox_unit.Text);
            patientInfo.Add(textBox_service.Text);
            patientInfo.Add(textBox_medCharge.Text);
            patientInfo.Add(textBox_docCharge.Text);
            patientInfo.Add(textBox_price.Text);
            patientInfo.Add("Checked Out");

            String bill = textBox_billid.Text;
            String pid = textBox_pid.Text;


            DatabaseHelperClass ob = new DatabaseHelperClass(patientInfo);

           if (ob.checkBill(bill,pid))
           {
                if (ob.Checkout())
                {
                     MessageBox.Show("Checked Out");
                     
               
                }

           
                else
                 {
                        MessageBox.Show("Error Checking Out");
                
                 }

           
       
           
           
           
           }

           else
               MessageBox.Show("Bill Or Patient ID Already Exist");



        }







        private int days, total, service, medCharge, docCharge;
        private string roomtype;

        private void button_show_Click(object sender, EventArgs e)
        {
            try
            {
                days = Convert.ToInt32(textBox_days.Text);
                docCharge = Convert.ToInt32(textBox_docCharge.Text);
                medCharge = Convert.ToInt32(textBox_medCharge.Text);
                roomtype = textBox_roomtype.Text;

                if (roomtype == "Normal")
                {
                    service = 300 * days;
                    textBox_unit.Text = "300";

                    total = service + docCharge + medCharge;
                    textBox_price.Text = Convert.ToString(total);
                    textBox_service.Text = Convert.ToString(service);

                }

                else if (roomtype == "Medium")
                {
                    service = 500 * days;
                    textBox_unit.Text = "500";

                    total = service + docCharge + medCharge;
                    textBox_price.Text = Convert.ToString(total);
                    textBox_service.Text = Convert.ToString(service);


                }

                else if (roomtype == "VIP")
                {
                    service = 800 * days;
                    textBox_unit.Text = "800";

                    total = service + docCharge + medCharge;
                    textBox_price.Text = Convert.ToString(total);
                    textBox_service.Text = Convert.ToString(service);
                  
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show("Put the value");
            }
        }

        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv1 = dt.DefaultView;
                dv1.RowFilter = string.Format("Name like '%{0}%'", textBox_input.Text);
                dataGridView_patientList.DataSource = dv1.ToTable();
            }
        }


    }
}
