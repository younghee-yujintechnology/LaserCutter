using System;
using System.Drawing;
using System.Windows.Forms;

using YujinTechnology;

namespace LaserCutter
{
    public partial class frmVision : Form
    {
        private panAuto Auto;
        private Point mMousePoint;

        public panVision Vision1;
        public panVision Vision2;

        public bool exitConfirmed = false;

        public frmVision()
        {
            InitializeComponent();

            String szStr = String.Format("{0}Logo.png", yjCommon.AppPath());
            pictureBox1.BackgroundImage = Image.FromFile(szStr);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            Auto = panAuto.StaticInstance;

            Vision1 = Auto.Table1.Vision;
            Vision2 = Auto.Table2.Vision;

            panClient.Controls.Add(Vision1);
            panClient.Controls.Add(Vision2);

#if _VISION
            Vision1.InitCognexControl();
            Vision2.InitCognexControl();

            if (Screen.AllScreens.Length > 1)
            {
                Screen sencondScreen = Screen.AllScreens[1];

                this.StartPosition = FormStartPosition.Manual;
                this.Location = sencondScreen.WorkingArea.Location;
                this.Left = sencondScreen.WorkingArea.Left;
                this.Top = sencondScreen.WorkingArea.Top;
            }

#endif
            Vision1.BringToFront();
        }

        #region public static frmVision StaticInstance 
        private static frmVision staticForm;
        public static frmVision StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmVision();
                }
                return staticForm;
            }
        }
        #endregion


        private void frmVision_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Alt + F4 또는 사용자가 종료를 선택한 경우
            if (e.CloseReason == CloseReason.UserClosing && !exitConfirmed)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                // 폼이 닫힌 후 실행할 코드
                // 예: 프로그램 종료, 리소스 해제 등
                Application.Exit();
            }
        }

        public void Finilization()
        {
            //CodeSite.EnterMethod("AAA");

#if _VISION
            Vision1.DestroyCognexToolGroup();

            Vision1.cogDisplay.Dispose();
            Vision1.cogModel.Dispose();
            Vision1.Dispose();

            Vision2.DestroyCognexToolGroup();

            Vision2.cogDisplay.Dispose();
            Vision2.cogModel.Dispose();
            Vision2.Dispose();
#endif
            //CodeSite.ExitMethod("AAA");
        }

        public void ButtonEnables(bool bEnable)
        {
            Vision1.EnableControl(bEnable);
            Vision2.EnableControl(bEnable);     
        }

        private void lblMainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (yjCommon.IsCtrlKeyDown())
            {
                mMousePoint = new Point(e.X, e.Y);
            }
        }

        private void lblMainTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (yjCommon.IsCtrlKeyDown())
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    Location = new Point(Left - (mMousePoint.X - e.X), Top - (mMousePoint.Y - e.Y));
                }
            }
        }

        private void AutoThread_OnExecute(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void lblMainTitle_DoubleClick(object sender, EventArgs e)
        {
            if (yjCommon.IsCtrlKeyDown())
            {
                if (Screen.AllScreens.Length > 1)
                {
                    Screen sencondScreen = Screen.AllScreens[1];

                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = sencondScreen.WorkingArea.Location;
                    this.Left = sencondScreen.WorkingArea.Left;
                    this.Top = sencondScreen.WorkingArea.Top;
                }
            }
        }
    }
}
