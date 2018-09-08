using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    class DatabaseHelperClass
    {
        ArrayList dataInfo;
        String MySqlConnStr = null;
        MySqlConnection databaseConnection = null;
        MySqlCommand commandDatabase = null;
        MySqlDataReader myReader = null;

        public DatabaseHelperClass()
        {

        }
        public DatabaseHelperClass(ArrayList dataInfo)
        {
            this.dataInfo = dataInfo;
        }



        public void databaseConnect(String query)
        {
            MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
            databaseConnection = new MySqlConnection(MySqlConnStr);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            myReader = commandDatabase.ExecuteReader();
            databaseConnection.Close();
        }




        public bool insertData()
        {
            String status = "Checked In";
            try
            {
                String query = "insert into patient values('" + dataInfo[3] + "','" + dataInfo[0] + "','" + dataInfo[4] + "','" +
                            dataInfo[5] + "','" + Convert.ToString(dataInfo[6]) + "','" + dataInfo[7] + "','" + dataInfo[8] + "','" + dataInfo[9] + "','" +
                            dataInfo[10] + "','" + dataInfo[12] + "','" + dataInfo[1] + "','" + dataInfo[2] + "','" + dataInfo[11] + "','" + status+ "');";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        



        public bool updateData()
        {
            try
            {
                String query = "update patient set Pid='" + dataInfo[0] + "',Reg_ID='" + dataInfo[1] + "',Name='" + dataInfo[2] + "',Gender='" +
                            dataInfo[3] + "',Age='" + dataInfo[4] + "',Phone='" + dataInfo[5] + "',Address='" + dataInfo[6] + "',Disease='" + dataInfo[7] + "',Status='" +
                            dataInfo[8] + "',Room_ID='" + dataInfo[9] + "',Date='" + dataInfo[10] + "',Room_type='" + dataInfo[11] + "',Building='" + dataInfo[12] + "' where Pid='" + dataInfo[0] + "';";
                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }


        }

        


        public bool Checkout()
        {
            try
            {
                String query = "insert into checkout values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + dataInfo[2] + "','" +
                            dataInfo[3] + "','" + Convert.ToInt32(dataInfo[4]) + "','" + dataInfo[5] + "','" + Convert.ToInt32(dataInfo[6]) + "','" + Convert.ToInt32(dataInfo[7]) + "','" +
                            Convert.ToInt32(dataInfo[8]) + "','" + Convert.ToInt32(dataInfo[9]) + "','" + Convert.ToInt32(dataInfo[10]) + "');";

                String query2 = "update patient set Check_Status='" + dataInfo[11] + "'where Pid ='"+dataInfo[1]+"';";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                ob.databaseConnect(query2);
                return true;
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }

        }




        public bool insertRoomInfo()
        {
            try
            {
                String query = "insert into room (Room_ID, Room_Type, No_of_Bed, Price, Building, Floor_No) values('" + dataInfo[0] + "','" +
                    dataInfo[1] + "','" + Convert.ToInt32(dataInfo[2]) + "','" + Convert.ToInt32(dataInfo[3]) + "','" + dataInfo[4] + "','" +
                    Convert.ToInt32(dataInfo[5]) + "');";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }
        }





        public bool addNewUser()
        {
            try
            {
                String query = "insert into user(Username,Password,Position,Name) values('" + dataInfo[0] + "','" + dataInfo[1] + "','" +
                    dataInfo[2] +  "','" + dataInfo[3] + "');";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }
        }






        public bool checkUserExist(String us)
        {
            try
            {
                String query = "select Username from user ;";

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                DatabaseHelperClass ob = new DatabaseHelperClass();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                        if (String.Compare(myReader[0].ToString(), us) == 0)
                        {
                            databaseConnection.Close();
                            return false;
                        }
                    }

                }
                databaseConnection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                databaseConnection.Close();
                return false;
            }
        }






        public bool checkBill(String bill, String pid)
        {
            try
            {
                String query = "select Bill_ID, PID from checkout ;";

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                DatabaseHelperClass ob = new DatabaseHelperClass();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                        if ((String.Compare(myReader[0].ToString(), bill) == 0) || (String.Compare(myReader[1].ToString(), pid) == 0))
                        {
                            databaseConnection.Close();
                            return false;
                        }
                    }

                }
                databaseConnection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                databaseConnection.Close();
                return false;
            }
        }








        public bool checkPassword(String password, int ID)
        {
            try
            {
                String query = "select Password from user WHERE User_ID =" + ID;

                

                String MySqlConnStr = "server=localhost;port=3306;database=hospital_management;uid=root;password=''";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnStr);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();

                DatabaseHelperClass ob = new DatabaseHelperClass();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                myReader.Read();
                //databaseConnection.Close();

                if (String.Compare(myReader[0].ToString(), password) == 0)
                { 
                    return true;
                }

                else
                {
                    return false;
                }

                
            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }
        }




        public bool changePassword(int ID)
        {
            try
            {
                String query = "UPDATE user SET Password ='" + dataInfo[0] + "' WHERE User_ID='" + ID + "';";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;

            }
            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                databaseConnection.Close();
                return false;
            }
        }






        public bool addNewEmployee(String emp)
        {
            if(emp=="Doctor")
            {
                try
                {
                    String query = "insert into doctor values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + Convert.ToInt32(dataInfo[2]) + "','" +
                        dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "','" + Convert.ToInt32(dataInfo[7]) + "','" + dataInfo[8] + "','" + dataInfo[9] + "');";


                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }

                catch (MySqlException e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }

            else if (emp == "Receptionist")
            {
                try
                {
                    String query = "insert into receptionist values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + Convert.ToInt32(dataInfo[2]) + "','" +
                        dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "','" + Convert.ToInt32(dataInfo[7]) + "','" + dataInfo[8] + "','" + dataInfo[9] + "');";


                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }

                catch (MySqlException e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }

            else if (emp == "Nurse")
            {
                try
                {
                    String query = "insert into nurse values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + Convert.ToInt32(dataInfo[2]) + "','" +
                        dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "','" + Convert.ToInt32(dataInfo[7]) + "','" + dataInfo[8] + "','" + dataInfo[9] + "');";


                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }

                catch (MySqlException e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }

            else if (emp == "Stuff")
            {
                try
                {
                    String query = "insert into stuff values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + Convert.ToInt32(dataInfo[2]) + "','" +
                        dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "','" + Convert.ToInt32(dataInfo[7]) + "','" + dataInfo[8] + "','" + dataInfo[9] + "');";


                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }

                catch (MySqlException e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }


            else
                return false;
        }







        public bool updateEmployee(String emp)
        {
            if (emp == "Doctor")
            {
                try
                {
                    String query = "UPDATE doctor SET Doctor_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] + "',Age='" + Convert.ToInt32(dataInfo[2]) + "',Gender='" +
                                dataInfo[3] + "',Department='" + dataInfo[4] + "',Qualification='" + dataInfo[5] + "',Experience='" + dataInfo[6] + "',Salary='" + Convert.ToInt32(dataInfo[7]) + "',Phone='" +
                                dataInfo[8] + "',Address='" + dataInfo[9] + "' WHERE Doctor_ID='" + dataInfo[0] + "';";

                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }

            else if (emp == "Receptionist")
            {
                try
                {
                    String query = "UPDATE receptionist SET Recep_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] + "',Age='" + Convert.ToInt32(dataInfo[2]) + "',Gender='" +
                                dataInfo[3] + "',Department='" + dataInfo[4] + "',Qualification='" + dataInfo[5] + "',Experience='" + dataInfo[6] + "',Salary='" + Convert.ToInt32(dataInfo[7]) + "',Phone='" +
                                dataInfo[8] + "',Address='" + dataInfo[9] + "' WHERE Recep_ID='" + dataInfo[0] + "';";

                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }

            else if (emp == "Nurse")
            {
                try
                {
                    String query = "UPDATE nurse SET Nurse_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] + "',Age='" + Convert.ToInt32(dataInfo[2]) + "',Gender='" +
                                dataInfo[3] + "',Department='" + dataInfo[4] + "',Qualification='" + dataInfo[5] + "',Experience='" + dataInfo[6] + "',Salary='" + Convert.ToInt32(dataInfo[7]) + "',Phone='" +
                                dataInfo[8] + "',Address='" + dataInfo[9] + "' WHERE Nurse_ID='" + dataInfo[0] + "';";

                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }

            else if (emp == "Stuff")
            {
                try
                {
                    String query = "UPDATE stuff SET Stuff_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] + "',Age='" + Convert.ToInt32(dataInfo[2]) + "',Gender='" +
                                dataInfo[3] + "',Department='" + dataInfo[4] + "',Qualification='" + dataInfo[5] + "',Experience='" + dataInfo[6] + "',Salary='" + Convert.ToInt32(dataInfo[7]) + "',Phone='" +
                                dataInfo[8] + "',Address='" + dataInfo[9] + "' WHERE Stuff_ID='" + dataInfo[0] + "';";

                    DatabaseHelperClass ob = new DatabaseHelperClass();
                    ob.databaseConnect(query);
                    return true;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                    return false;
                }
            }


            else
                return false;



        }




        public bool updateRoom()
        {
            try
            {
                String query = "UPDATE room SET Room_ID='" + dataInfo[0] + "',Room_Type='" + dataInfo[1] + "',No_of_Bed='" + Convert.ToInt32(dataInfo[2]) + "',Status='" +
                            dataInfo[3] + "',Price='" + Convert.ToInt32(dataInfo[4]) + "',Building='" + dataInfo[5] + "',Floor_No='" + Convert.ToInt32(dataInfo[6]) + "' WHERE Room_ID='" + dataInfo[0] + "';";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }


        }





        public bool takeAppointment()
        {
            try
            {
                String query = "insert into appointments values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + dataInfo[2] + "','" +
                            Convert.ToInt32(dataInfo[3]) + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "','" + dataInfo[7] + "','" +
                            dataInfo[8] + "','" + dataInfo[9] + "','" + dataInfo[10] + "');";
                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }





        public bool updateAppointmentData()
        {
            try
            {
                String query = "update appointments set Appointment_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] + "',Gender='" +
                            dataInfo[2] + "',Age='" + dataInfo[3] + "',Phone='" + dataInfo[4] + "',Address='" + dataInfo[5] + "',Disease='" + dataInfo[6] + "',Doctor_ID='" +
                            dataInfo[7] + "',Doctor_Name='" + dataInfo[8] + "',Room_No='" + dataInfo[9] + "',Date='" + dataInfo[10] + "' where Appointment_ID='" + dataInfo[0] + "';";
                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }


        }



        public bool addNewSchedule()
        {

            try
            {
                String query = "insert into doctor_schedule values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + (dataInfo[2]) + "','" +
                    dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "','" + (dataInfo[7]) + "');";


                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }

            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }

        }


        public bool addNewSalary()
        {

            try
            {
                String query = "insert into salary (Employee_ID,Name,Job_Title,Salary,Month,Date,Payment_status) values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + (dataInfo[2]) + "','" +
                    dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "','" + dataInfo[6] + "');";


                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }

            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }

        }



        public bool updateSchedule()
        {
            try
            {
                String query = "update doctor_schedule set Doctor_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] + "',Department='" +
                            dataInfo[2] + "',Specialist='" + dataInfo[3] + "',Room_No='" + dataInfo[4] + "',Start_Time='" + dataInfo[5] + "',End_Time='" + dataInfo[6] + "',Days='" +
                            dataInfo[7] + "' where Doctor_ID='" + dataInfo[0] + "';";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }

            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }


        }


        public bool updateBloodData()
        {
            try
            {
                String query = "update bloodBank set Number_of_Bags='" + dataInfo[1] + "' where Blood_Type='" + dataInfo[0] + "';";
                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }


        }


        public bool addReport()
        {
            try
            {
                String query = "insert into reports values('" + dataInfo[0] + "','" + Convert.ToInt32(dataInfo[1]) + "','" + Convert.ToInt32(dataInfo[2]) + "','" +
                            dataInfo[3] + "');";
                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }




        public bool updateReportsData()
        {
            try
            {
                String query = "update reports set PID='" + dataInfo[0] + "',No_of_Test_Request='" + Convert.ToInt32(dataInfo[1]) +
                                "',No_of_Test_Complete='" + Convert.ToInt32(dataInfo[2]) + "',Delivery_Date='" + dataInfo[3] + "' where PID='" + dataInfo[0] + "';";
                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }


        }


        public bool addNewTime()
        {

            try
            {
                String query = "insert into schedule values('" + dataInfo[0] + "','" + dataInfo[1] + "','" + (dataInfo[2]) + "','" +
                    dataInfo[3] + "','" + dataInfo[4] + "','" + dataInfo[5] + "');";


                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }

            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }

        }

        public bool updateTime()
        {

            try
            {
                String query = "update schedule set Employee_ID='" + dataInfo[0] + "',Name='" + dataInfo[1] +
                                 "',Job_Title='" + dataInfo[2] + "',Start_Time='" + dataInfo[3] + "',End_Time='" + dataInfo[4] + "',Days='" + Convert.ToInt32(dataInfo[5]) + "' where Employee_ID='" + dataInfo[0] + "';";

                DatabaseHelperClass ob = new DatabaseHelperClass();
                ob.databaseConnect(query);
                return true;
            }

            catch (MySqlException e)
            {
                Console.Error.WriteLine(e.StackTrace);
                return false;
            }

        }



    }
}
