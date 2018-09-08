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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        



        private void button_logout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            this.Hide();
            ob.Show();
        }

        private void button_doctorSchedule_Click(object sender, EventArgs e)
        {
            if (!panel_receptionist.Controls.Contains(UserControl_DoctorSchedule.Instance))
            {
                panel_receptionist.Controls.Add(UserControl_DoctorSchedule.Instance);
                UserControl_DoctorSchedule.Instance.Dock = DockStyle.Fill;
                UserControl_DoctorSchedule.Instance.BringToFront();
            }
            else
                UserControl_DoctorSchedule.Instance.BringToFront();

        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            if (!panel_receptionist.Controls.Contains(UserControl_Reports.Instance))
            {
                panel_receptionist.Controls.Add(UserControl_Reports.Instance);
                UserControl_Reports.Instance.Dock = DockStyle.Fill;
                UserControl_Reports.Instance.BringToFront();
            }
            else
                UserControl_Reports.Instance.BringToFront();

        }

        private void button_blood_Click(object sender, EventArgs e)
        {
            if (!panel_receptionist.Controls.Contains(UserControl_BloodBank.Instance))
            {
                panel_receptionist.Controls.Add(UserControl_BloodBank.Instance);
                UserControl_BloodBank.Instance.Dock = DockStyle.Fill;
                UserControl_BloodBank.Instance.BringToFront();
            }
            else
                UserControl_BloodBank.Instance.BringToFront();

        }

        private void button_roominfo_Click(object sender, EventArgs e)
        {
            if (!panel_receptionist.Controls.Contains(UserControl_Roominfo.Instance))
            {
                panel_receptionist.Controls.Add(UserControl_Roominfo.Instance);
                UserControl_Roominfo.Instance.Dock = DockStyle.Fill;
                UserControl_Roominfo.Instance.BringToFront();
            }
            else
                UserControl_BloodBank.Instance.BringToFront();

        }

        private void button_addapp_Click(object sender, EventArgs e)
        {
            if (!panel_receptionist.Controls.Contains(UserControl_AddAppointment.Instance))
            {
                panel_receptionist.Controls.Add(UserControl_AddAppointment.Instance);
                UserControl_AddAppointment.Instance.Dock = DockStyle.Fill;
                UserControl_AddAppointment.Instance.BringToFront();
            }
            else
                UserControl_AddAppointment.Instance.BringToFront();
        }

        private void button_showapp_Click(object sender, EventArgs e)
        {
            if (!panel_receptionist.Controls.Contains(UserControl_AppointmentShow.Instance))
            {
                panel_receptionist.Controls.Add(UserControl_AppointmentShow.Instance);
                UserControl_AppointmentShow.Instance.Dock = DockStyle.Fill;
                UserControl_AppointmentShow.Instance.BringToFront();
            }
            else
                UserControl_AppointmentShow.Instance.BringToFront();
        }
    }
}
