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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
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

        private void button_item_Click(object sender, EventArgs e)
        {
            if (!panel_pharmacist.Controls.Contains(UserControl_Item.Instance))
            {
                panel_pharmacist.Controls.Add(UserControl_Item.Instance);
                UserControl_Item.Instance.Dock = DockStyle.Fill;
                UserControl_Item.Instance.BringToFront();
            }
            else
                UserControl_Item.Instance.BringToFront();
        }
    }
}
