using System.Drawing;
using System.Windows.Forms;
using YujinTechnology;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panConfig : UserControl
    {
        public panConfigCommon Common;
        public panConfigMotor Motor;

        private frmChannelSpy frmChannelSpy;
        public panConfig()
        {
            InitializeComponent();

            frmChannelSpy = frmChannelSpy.StaticInstance;

            Global.ChangeControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));

            Common = panConfigCommon.StaticInstance;
            Common.Auto = panAuto.StaticInstance;
            Common.SideMenu = panSideMenu.StaticInstance;

            Motor = new panConfigMotor();

            Common.LoadChannelInfo();
            Common.ChannelAssign();

            tabPage1.Controls.Add(Common);
            tabPage2.Controls.Add(Motor);

            Common.Location = new Point(0, 0);
            Motor.Location = new Point(0, 0);
        }

        public void SetTableBasePos()
        {
            Common.SetTableBasePos();
        }

        private void AAA(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is KeypadEdit)
                {
                    ((KeypadEdit)control).Apply();
                }
                else if (control.HasChildren)
                {
                    AAA(control);
                }
            }
        }
    }
}
