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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            this.Hide();
            ob.Show();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();

            Login ob = new Login();
            ob.Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
        }

        private void button_scheduling_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_Schedule.Instance))
            {
                panel_manager.Controls.Add(UserControl_Schedule.Instance);
                UserControl_Schedule.Instance.Dock = DockStyle.Fill;
                UserControl_Schedule.Instance.BringToFront();
            }
            else
                UserControl_Schedule.Instance.BringToFront();
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_Reports.Instance))
            {
                panel_manager.Controls.Add(UserControl_Reports.Instance);
                UserControl_Reports.Instance.Dock = DockStyle.Fill;
                UserControl_Reports.Instance.BringToFront();
            }
            else
                UserControl_Reports.Instance.BringToFront();
        }

        private void button_salary_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_Salary.Instance))
            {
                panel_manager.Controls.Add(UserControl_Salary.Instance);
                UserControl_Salary.Instance.Dock = DockStyle.Fill;
                UserControl_Salary.Instance.BringToFront();
            }
            else
                UserControl_Salary.Instance.BringToFront();
        }

        private void button_empinfo_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_StaffInfo.Instance))
            {
                panel_manager.Controls.Add(UserControl_StaffInfo.Instance);
                UserControl_StaffInfo.Instance.Dock = DockStyle.Fill;
                UserControl_StaffInfo.Instance.BringToFront();
            }
            else
                UserControl_StaffInfo.Instance.BringToFront();
        }

        private void button_roominfo_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_Roominfo.Instance))
            {
                panel_manager.Controls.Add(UserControl_Roominfo.Instance);
                UserControl_Roominfo.Instance.Dock = DockStyle.Fill;
                UserControl_Roominfo.Instance.BringToFront();
            }
            else
                UserControl_Roominfo.Instance.BringToFront();
        }

        private void button_newward_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_NewWard.Instance))
            {
                panel_manager.Controls.Add(UserControl_NewWard.Instance);
                UserControl_NewWard.Instance.Dock = DockStyle.Fill;
                UserControl_NewWard.Instance.BringToFront();
            }
            else
                UserControl_NewWard.Instance.BringToFront();
        }

        private void button_patientinfo_Click(object sender, EventArgs e)
        {
            if (!panel_manager.Controls.Contains(UserControl_Patientinfo.Instance))
            {
                panel_manager.Controls.Add(UserControl_Patientinfo.Instance);
                UserControl_Patientinfo.Instance.Dock = DockStyle.Fill;
                UserControl_Patientinfo.Instance.BringToFront();
            }
            else
            {

                UserControl_Patientinfo.Instance.BringToFront();
            }
        }

        private void button_addemp_Click(object sender, EventArgs e)
        {
            NewEmployee ob = new NewEmployee();
            ob.Show();
        }
    }
}
