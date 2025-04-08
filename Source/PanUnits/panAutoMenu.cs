using System;
using System.Windows.Forms;

using yjTech;

namespace LaserCutter
{
    public partial class panAutoMenu: UserControl
    {
        public frmChannelSpy frmChannelSpy;

        public panAutoMenu()
        {
            InitializeComponent();
        }
       
        #region public void SetDataServer(Control.ControlCollection controls)
        public void SetDataServer(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                //LEDLabel
                if (control is ValueIndicator)
                {
                    ((ValueIndicator)control).DataServer = frmChannelSpy.propGridMotion.DataServer;
                }
                else
                if (control is LEDLabel)
                {
                    ((LEDLabel)control).DataServer = frmChannelSpy.propGridMotion.DataServer;
                }
                else
                if (control.HasChildren)
                {
                    SetDataServer(control.Controls);
                }
            }
        }

        #endregion
        public void ChannelAssign()
        {
            SetDataServer(this.Controls);

            viXVelocity.ChannelName = "X.Velocity";
            viY1Velocity.ChannelName = "Y1.Velocity";
            viY2Velocity.ChannelName = "Y2.Velocity";
            viZVelocity.ChannelName = "Z.Velocity";

            viXPosition.ChannelName = "X.Position";
            viY1Position.ChannelName = "Y1.Position";
            viY2Position.ChannelName = "Y2.Position";
            viZPosition.ChannelName = "Z.Position";
        }

        #region staticInstance
        private static panAutoMenu staticInstance;

        public static panAutoMenu StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panAutoMenu();
                }
                return staticInstance;
            }
        }
        #endregion

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
