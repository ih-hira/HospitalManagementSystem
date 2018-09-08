using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hospital_Management_System
{
    public partial class ChangePassword : Form
    {
        int givenID;

        public ChangePassword()
        {
            InitializeComponent();
        }


        public ChangePassword(int select)
        {
            InitializeComponent();
            this.givenID = select;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            ArrayList userInfo = new ArrayList();


            String givenOldPass = textBox_oldpw.Text;
            String givenNewPass = textBox_newpw.Text;
            String givenConfPass = textBox_confirm.Text;


            if (String.IsNullOrEmpty(textBox_oldpw.Text) || String.IsNullOrEmpty(textBox_newpw.Text) ||
                String.IsNullOrEmpty(textBox_confirm.Text))
            {
                MessageBox.Show("Fill up all data");
            }

            else
            {
                DatabaseHelperClass ob1 = new DatabaseHelperClass();


                if (ob1.checkPassword(givenOldPass,givenID))
                {
                    if (String.Compare(givenNewPass, givenConfPass) == 0)
                    {
                        userInfo.Add(textBox_newpw.Text);
                        

                        DatabaseHelperClass ob = new DatabaseHelperClass(userInfo);
                        if (ob.changePassword(givenID))
                        {
                            MessageBox.Show("Password Changed");
                        }
                        else
                        {
                            MessageBox.Show("Error Changing Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Doesn't Match");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong old password !");
                }

            }

        }
    }
}
