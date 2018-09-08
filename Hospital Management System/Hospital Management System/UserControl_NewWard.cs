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
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public partial class UserControl_NewWard : UserControl
    {
        private static UserControl_NewWard _instance;

        public static UserControl_NewWard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_NewWard();
                return _instance;


            }

        }


        public UserControl_NewWard()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ArrayList roomInfo = new ArrayList();

            roomInfo.Add(textBox_roomno.Text);
            roomInfo.Add(comboBox_roomtype.Text);
            roomInfo.Add(textBox_numbed.Text);
            roomInfo.Add(textBox_unitprice.Text);
            roomInfo.Add(comboBox_building.Text);
            roomInfo.Add(comboBox_floor.Text);

            DatabaseHelperClass ob = new DatabaseHelperClass(roomInfo);

            if (ob.insertRoomInfo())
            {
                MessageBox.Show("Room Added");
            }
            else
            {
                MessageBox.Show("Error Adding Room");
            }
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;
        }
    }
}
