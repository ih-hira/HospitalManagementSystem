using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class UserControl_Item : UserControl
    {
        private static UserControl_Item _instance;

        public static UserControl_Item Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Item();
                return _instance;


            }

        }

        public UserControl_Item()
        {
            InitializeComponent();
        }
    }
}
