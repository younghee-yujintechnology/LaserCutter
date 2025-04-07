using System.Drawing;
using System.Windows.Forms;
using Raize.CodeSiteLogging;

using yjTech;

namespace LaserCutter
{
    public partial class panAuto: UserControl
    {
        CodeSiteLogger logger;

        public frmMain frmMain;
        public frmChannelSpy frmChannelSpy;

        public panTable Table1;
        public panTable Table2;

        int mTabIndex;

        public panAuto()
        {
            CodeSite.SendMsg("panAuto.Create()");

            InitializeComponent();

            SetCodeSitelogger();

            staticInstance = this;

            bool withVision = true;

            Table1 = new panTable(withVision);
            Table1.Auto = this;
            Table1.TableNo = TableNo.Table1;
            Table1.Location = new Point(2, 2);
            Table1.EnableControl(false);
            tabTable1.Controls.Add(Table1);

            Table2 = new panTable(withVision);
            Table2.Auto = this;
            Table2.TableNo = TableNo.Table2;
            Table2.Location = new Point(2, 2);
            Table2.EnableControl(false);
            tabTable2.Controls.Add(Table2);
        }

        #region staticInstance
        private static panAuto staticInstance;

        public static panAuto StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panAuto();
                }
                return staticInstance;
            }
        }
        #endregion

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Auto";

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = yjCommon.AppPath();
            fileDestination.LogFile.FileName = "LaserCutter";

            logger.Destination = fileDestination;
            logger.Destination.Viewer.Active = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (frmMain.MenuIndex == 10)
            {
                frmMain.ChangeAutoTitle();
            }

            mTabIndex = tabControl1.SelectedIndex;

            if (mTabIndex == 0)
            {
                ////Vision1.BringToFront();
                ////SideMenu.tabControl2.SelectedIndex = 0;

                tabControl1.TabSelectedColor = Color.Lime;
                tabControl1.TabSelectedForeColor = Color.Black;
                tabControl1.TabSelectedHighColor = Color.Red;

                Table1.tabControl1.TabSelectedColor = Color.Lime;
                Table1.tabControl1.TabSelectedForeColor = Color.Black;
                Table1.tabControl1.TabSelectedHighColor = Color.Red;

                frmMain.lblMainTitle.ForeColor = Color.Lime;
                ////frmVision.lblTitle.Text = "Table1 - Vision";
                ////frmVision.lblTitle.ForeColor = Color.Lime;
            }
            else
            if (mTabIndex == 1)
            {
                ////Vision2.BringToFront();
                ////SideMenu.tabControl2.SelectedIndex = 1;

                tabControl1.TabSelectedColor = Color.Yellow;
                tabControl1.TabSelectedForeColor = Color.Black;
                tabControl1.TabSelectedHighColor = Color.Red;

                Table2.tabControl1.TabSelectedColor = Color.Yellow;
                Table2.tabControl1.TabSelectedForeColor = Color.Black;
                Table2.tabControl1.TabSelectedHighColor = Color.Red;

                frmMain.lblMainTitle.ForeColor = Color.Yellow;
                ////frmVision.lblTitle.Text = "Table2 - Vision";
                ////frmVision.lblTitle.ForeColor = Color.Yellow;
            }

            ////if (frmVision.Visible)
            ////{
            ////    frmMVS.UpdateThread1.Enabled = (mTabIndex == 0);
            ////    frmMVS.UpdateThread2.Enabled = (mTabIndex == 1);
            ////}
        }
    }
}
