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

        public panConfigCommon Common;

        public panTable Table1;
        public panTable Table2;

        int mTabIndex;

        public panAuto()
        {
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

        public void SetTableBasePos()
        {
            Table1.TableBasePos[0] = new DoublePoint(Global.chTable1LeftBottomXPos.AsDouble, Global.chTable1LeftBottomYPos.AsDouble);
            Table1.TableBasePos[1] = new DoublePoint(Global.chTable1LeftTopXPos.AsDouble, Global.chTable1LeftTopYPos.AsDouble);
            Table1.TableBasePos[2] = new DoublePoint(Global.chTable1RightTopXPos.AsDouble, Global.chTable1RightTopYPos.AsDouble);
            Table1.TableBasePos[3] = new DoublePoint(Global.chTable1RightBottomXPos.AsDouble, Global.chTable1RightBottomYPos.AsDouble);
            Table1.TableBasePos[4] = new DoublePoint(Global.chTable1CenterXPos.AsDouble, Global.chTable1CenterYPos.AsDouble);

            Table2.TableBasePos[0] = new DoublePoint(Global.chTable2LeftBottomXPos.AsDouble, Global.chTable2LeftBottomYPos.AsDouble);
            Table2.TableBasePos[1] = new DoublePoint(Global.chTable2LeftTopXPos.AsDouble, Global.chTable2LeftTopYPos.AsDouble);
            Table2.TableBasePos[2] = new DoublePoint(Global.chTable2RightTopXPos.AsDouble, Global.chTable2RightTopYPos.AsDouble);
            Table2.TableBasePos[3] = new DoublePoint(Global.chTable2RightBottomXPos.AsDouble, Global.chTable2RightBottomYPos.AsDouble);
            Table2.TableBasePos[4] = new DoublePoint(Global.chTable2CenterXPos.AsDouble, Global.chTable2CenterYPos.AsDouble);
        }
    }
}
