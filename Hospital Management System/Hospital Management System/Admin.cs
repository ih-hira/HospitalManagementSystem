using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button_patientreg_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_Patientreg.Instance))
            {
                panel_admin.Controls.Add(UserControl_Patientreg.Instance);
                UserControl_Patientreg.Instance.Dock = DockStyle.Fill;
                UserControl_Patientreg.Instance.BringToFront();
            }
            else
            {
                UserControl_Patientreg.Instance.BringToFront();
            }
        }

        private void button_patientinfo_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_Patientinfo.Instance))
            {
                panel_admin.Controls.Add(UserControl_Patientinfo.Instance);
                UserControl_Patientinfo.Instance.Dock = DockStyle.Fill;
                UserControl_Patientinfo.Instance.BringToFront();
            }
            else
            {

                UserControl_Patientinfo.Instance.BringToFront();
            }
        }

        private void button_patientcout_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_Checkout.Instance))
            {
                panel_admin.Controls.Add(UserControl_Checkout.Instance);
                UserControl_Checkout.Instance.Dock = DockStyle.Fill;
                UserControl_Checkout.Instance.BringToFront();
            }
            else
                UserControl_Checkout.Instance.BringToFront();
        }


        private void button_empinfo_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_StaffInfo.Instance))
            {
                panel_admin.Controls.Add(UserControl_StaffInfo.Instance);
                UserControl_StaffInfo.Instance.Dock = DockStyle.Fill;
                UserControl_StaffInfo.Instance.BringToFront();
            }
            else
                UserControl_StaffInfo.Instance.BringToFront();

        }


        private void button_roominfo_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_Roominfo.Instance))
            {
                panel_admin.Controls.Add(UserControl_Roominfo.Instance);
                UserControl_Roominfo.Instance.Dock = DockStyle.Fill;
                UserControl_Roominfo.Instance.BringToFront();
            }
            else
                UserControl_Roominfo.Instance.BringToFront();

        }

        private void button_newward_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_NewWard.Instance))
            {
                panel_admin.Controls.Add(UserControl_NewWard.Instance);
                UserControl_NewWard.Instance.Dock = DockStyle.Fill;
                UserControl_NewWard.Instance.BringToFront();
            }
            else
                UserControl_NewWard.Instance.BringToFront();

        }


        private void button_userinfo_Click(object sender, EventArgs e)
        {
            if (!panel_admin.Controls.Contains(UserControl_UserInfo.Instance))
            {
                panel_admin.Controls.Add(UserControl_UserInfo.Instance);
                UserControl_UserInfo.Instance.Dock = DockStyle.Fill;
                UserControl_UserInfo.Instance.BringToFront();
            }
            else
                UserControl_UserInfo.Instance.BringToFront();

        }

        private void button_newuser_Click(object sender, EventArgs e)
        {
            NewUser ob = new NewUser();
            ob.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            this.Hide();
            ob.Show();
        }

        
    }
}
