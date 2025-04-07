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
            if (tabControlEx1.SelectedIndex == 2)
            {
                frmMain.StaticInstance.ChangeMainPanel(frmMain.StaticInstance.btnJobFile);
            } else
            {
                frmMain.StaticInstance.ChangeMainPanel(frmMain.StaticInstance.btnAuto);
            }
        }
    }
}
