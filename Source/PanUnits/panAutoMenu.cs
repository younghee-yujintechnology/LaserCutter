using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class panAutoMenu: UserControl
    {

        public panAutoMenu()
        {
            InitializeComponent();
        }

        private void tabControlEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }

        private void tabControlEx1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (frmMain.StaticInstance.MenuIndex == 10)
            {
                e.Cancel = (tabControlEx1.SelectedIndex == 2);
            }
            else
            if (frmMain.StaticInstance.MenuIndex == 11)
            {
                e.Cancel = !(tabControlEx1.SelectedIndex == 1);
            }
            else
            if (frmMain.StaticInstance.MenuIndex == 14)
            {
                e.Cancel = (tabControlEx1.SelectedIndex == 0);
            }
        }
    }
}
