using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hospital_Management_System
{
    public partial class UserControl_AddAppointment : UserControl
    {
        private static UserControl_AddAppointment _instance;

        public static UserControl_AddAppointment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_AddAppointment();
                return _instance;


            }

        }

        public UserControl_AddAppointment()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            ArrayList patientInfo = new ArrayList();

            patientInfo.Add(textBox_appid.Text);
            patientInfo.Add(textBox_name.Text);
            patientInfo.Add(comboBox_gender.Text);
            patientInfo.Add(textBox_age.Text);
            patientInfo.Add(textBox_phone.Text);
            patientInfo.Add(richTextBox_address.Text);
            patientInfo.Add(textBox_disease.Text);
            patientInfo.Add(textBox_doctorid.Text);
            patientInfo.Add(textBox_docname.Text);
            patientInfo.Add(textBox_roomnum.Text);
            patientInfo.Add(dateTimePicker1.Text);

            DatabaseHelperClass ob = new DatabaseHelperClass(patientInfo);
            if (ob.takeAppointment())
            {
                MessageBox.Show("Appointed");
            }
            else
            {
                MessageBox.Show("Error Taking Appointment");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }
    }
}
