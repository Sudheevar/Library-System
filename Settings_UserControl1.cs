using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Settings_UserControl1 : UserControl
    {
        private static Settings_UserControl1 _instance;
        public static Settings_UserControl1 Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new Settings_UserControl1();
                }
                return _instance;
            }
        }
        public Settings_UserControl1()
        {
            InitializeComponent();
        }
    }
}
