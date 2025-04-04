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

        private void btnTable2New_Click(object sender, System.EventArgs e)
        {

        }
    }
}
