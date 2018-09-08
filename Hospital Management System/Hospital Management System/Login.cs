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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                String dept = comboBox_dept.Text;
                String givenUserId = textBox_username.Text;
                String givenPass = textBox_password.Text;

                if (string.IsNullOrEmpty(givenUserId) || string.IsNullOrEmpty(givenPass))
                {
                    MessageBox.Show("Enter User Id or Password");
                }

                else
                {
                    String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                    bool userFound = false;
                    String query = "select * from user";

                    MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();

                    if (dept == "Admin")
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                String userId = myReader.GetString(1);
                                String userPass = myReader.GetString(2);
                                String userPosition = myReader.GetString(3);

                                if ((String.Compare(givenUserId, userId) == 0) && (String.Compare(givenPass, userPass) == 0) && (String.Compare(dept, userPosition) == 0))
                                {
                                    userFound = true;
                                    break;
                                }
                            }
                        }

                        if (userFound)
                        {
                            Admin ob = new Admin();
                            userFound = false;
                            this.Hide();
                            ob.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong ID or Password !");
                        }
                    }

                    else if (dept == "Receptionist")
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                String userId = myReader.GetString(1);
                                String userPass = myReader.GetString(2);
                                String userPosition = myReader.GetString(3);

                                if ((String.Compare(givenUserId, userId) == 0) && (String.Compare(givenPass, userPass) == 0) && (String.Compare(dept, userPosition) == 0))
                                {
                                    userFound = true;
                                    break;
                                }
                            }
                        }

                        if (userFound)
                        {
                            Receptionist ob = new Receptionist();
                            userFound = false;
                            this.Hide();
                            ob.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong ID or Password !");
                        }


                    }

                    else if (dept == "Manager")
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                String userId = myReader.GetString(1);
                                String userPass = myReader.GetString(2);
                                String userPosition = myReader.GetString(3);

                                if ((String.Compare(givenUserId, userId) == 0) && (String.Compare(givenPass, userPass) == 0) && (String.Compare(dept, userPosition) == 0))
                                {
                                    userFound = true;
                                    break;
                                }
                            }
                        }

                        if (userFound)
                        {
                            Manager ob = new Manager();
                            userFound = false;
                            this.Hide();
                            ob.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong ID or Password !");
                        }


                    }

                    else if (dept == "Pharmacist")
                    {

                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                String userId = myReader.GetString(1);
                                String userPass = myReader.GetString(2);
                                String userPosition = myReader.GetString(3);

                                if ((String.Compare(givenUserId, userId) == 0) && (String.Compare(givenPass, userPass) == 0) && (String.Compare(dept, userPosition) == 0))
                                {
                                    userFound = true;
                                    break;
                                }
                            }
                        }

                        if (userFound)
                        {
                            Pharmacist ob = new Pharmacist();
                            userFound = false;
                            this.Hide();
                            ob.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong ID or Password !");
                        }

                    }

                    else
                    {
                        MessageBox.Show("Select A Department");
                    }
                }

            }

            catch (Exception exp)
            {
                MessageBox.Show("Login Error !");
            }
        }
    }
}
