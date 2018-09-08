using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        
        private void button_add_Click(object sender, EventArgs e)
        {
            ArrayList userInfo = new ArrayList();

            String pass = textBox_password.Text;
            String conPass = textBox_confirm.Text;


            if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_uname.Text) || String.IsNullOrEmpty(textBox_password.Text) || 
                String.IsNullOrEmpty(textBox_confirm.Text) || String.IsNullOrEmpty(textBox_position.Text))
            {
                MessageBox.Show("Fill up all data");
            }

            else
            {
                DatabaseHelperClass ob1 = new DatabaseHelperClass();
                String username = textBox_uname.Text;

                if (ob1.checkUserExist(username))
                {
                    if (String.Compare(pass, conPass) == 0)
                    {
                        userInfo.Add(textBox_uname.Text);
                        userInfo.Add(pass);
                        userInfo.Add(textBox_position.Text);
                        userInfo.Add(textBox_name.Text);

                        DatabaseHelperClass ob = new DatabaseHelperClass(userInfo);
                        if (ob.addNewUser())
                        {
                            MessageBox.Show("User Added");
                        }
                        else
                        {
                            MessageBox.Show("Error Adding User");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Don't Matched");
                    }
                }
                else
                {
                    MessageBox.Show("User already exist");
                }
            }
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
