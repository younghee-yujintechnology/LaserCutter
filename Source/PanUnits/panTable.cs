using System;
using System.Drawing;
using System.Windows.Forms;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panTable: UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public LaserProject LaserProject;

        public panAuto Auto;

        public panJobType1 Type1;
        public panJobType2 Type2;
        public panJobType3 Type3;
        public panJobType4 Type4;

        public frmMain frmMain;

        public panTable(bool withVision = false)
        {
            InitializeComponent();

            SetCodeSitelogger();

            LaserProject = new LaserProject();

            Type1 = new panJobType1();
            Type1.Auto = panAuto.StaticInstance;
            Type1.EnableControl(false);

            Type2 = new panJobType2();
            Type2.Auto = panAuto.StaticInstance;
            Type2.EnableControl(false);

            Type3 = new panJobType3();
            Type3.Auto = panAuto.StaticInstance;
            Type3.EnableControl(false);

            Type4 = new panJobType4();
            Type4.Auto = panAuto.StaticInstance;
            Type4.EnableControl(false);

            frmMain = frmMain.StaticInstance;

            tabPage1.Controls.Add(Type1);
            tabPage2.Controls.Add(Type2);
            tabPage3.Controls.Add(Type3);
            tabPage4.Controls.Add(Type4);

            Type1.Location = new Point(0, 0);
            Type2.Location = new Point(0, 0);
            Type3.Location = new Point(0, 0);
        }

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = String.Format("{0}", TableNo.ToString());

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = yjCommon.AppPath();
            fileDestination.LogFile.FileName = "LaserCutter";

            logger.Destination = fileDestination;
            logger.Destination.Viewer.Active = true;
        }

        #region private TableNo TableNo
        private TableNo mTableNo;

        public TableNo TableNo
        {
            get
            {
                return mTableNo;
            }

            set
            {
                mTableNo = value;
            }
        }
        #endregion

        public void EnableControl(bool enable)
        {
            //        btnOpenJobFile.Enabled = enable;
            //        btnClose.Enabled = enable;

            // JobInfo.TabControl2.Enabled = enable;
            //// JobInfo.Type1.EnableControl(enable);
            //// JobInfo.Type2.EnableControl(enable);
            //// JobInfo.Type3.EnableControl(enable);
        }


        #region property public string GroupName
        private String mGroupName;
        public string GroupName
        {
            get { return mGroupName; }
            set
            {
                mGroupName = value;
            }
        }
        #endregion


        #region property public string ModelName
        private String mModelName;
        public string ModelName
        {
            get { return mModelName; }
            set
            {
                mModelName = value;

                if (!String.IsNullOrEmpty(mModelName))
                {
                    ////if (LoadJobFile(GroupName, ModelName))
                    ////{
                    ////    DisplayJobFile();
                    ////}
                    ////else
                    ////{
                    ////    ClearAllControlValue();
                    ////}
                }
                else
                {
                    ////ClearAllControlValue();
                }
            }
        }
        #endregion

        private void btnOpenJobFile_Click(object sender, EventArgs e)
        {
            frmSelectJob frmSelectJob = frmSelectJob.StaticInstance;

            frmSelectJob.TableNo = TableNo;
            frmSelectJob.StartPosition = FormStartPosition.CenterScreen;
            if (frmSelectJob.ShowDialog() == DialogResult.OK)
            {
                if (TableNo == TableNo.Table1)
                {
                    Auto.ledTable1JobFileLoad.LED.Value = false;
                }
                else
                if (TableNo == TableNo.Table2)
                {
                    Auto.ledTable2JobFileLoad.LED.Value = false;
                }

                logger.SendMsg(String.Format("{0}.Open([{1}][{2}])", TableNo.ToString(), frmSelectJob.GroupName, frmSelectJob.ModelName));

                lblGroupName.Text = frmSelectJob.GroupName;
                lblModelName.Text = String.Format("{0}", frmSelectJob.ModelName);

                GroupName = frmSelectJob.GroupName;
                ModelName = frmSelectJob.ModelName;

                ////LaserProject.NozzleOffsetX = Global.chTable1NozzleXOffset.AsDouble;
                ////LaserProject.NozzleOffsetY = Global.chTable1NozzleYOffset.AsDouble;

                ////if (TableNo == TableNo.Table1)
                ////{
                ////    Auto.ledTable1JobFileLoad.LED.Value = true;
                ////}
                ////else
                ////if (TableNo == TableNo.Table2)
                ////{
                ////    Auto.ledTable2JobFileLoad.LED.Value = true;
                ////}

                ////Vision.DefaultVisionFile = String.Format("{0}CogPMAlignTool(4Align).vpp", frmSelectJob.GetModelPath());
                ////Vision.ledCogPMAlignTool.LED.Value = yjCommon.FileExists(Vision.DefaultVisionFile);
                ////Vision.btnLoadProject.Enabled = Vision.ledCogPMAlignTool.LED.Value;

                ////if (Vision.ledCogPMAlignTool.LED.Value)
                ////{
                ////    Vision.btnLoadProject_Click(null, null);
                ////}

                yjTech.StringList ss;
                ss = LaserProject.Model1.ToStringList();

                CodeSite.SendMsg("");
                CodeSite.SendMsg(String.Format("    {0}.FileName = [{1}][{2}][Table{3}].prj", TableNo, GroupName, ModelName, (int)TableNo));
                for (int nIndex = 0; nIndex < ss.Count; nIndex++)
                {
                    CodeSite.SendMsg(ss[nIndex]);
                }

                ss = LaserProject.Model2.ToStringList();

                CodeSite.SendMsg("");
                for (int nIndex = 0; nIndex < ss.Count; nIndex++)
                {
                    CodeSite.SendMsg(ss[nIndex]);
                }

                ss = LaserProject.Model3.ToStringList();

                CodeSite.SendMsg("");
                for (int nIndex = 0; nIndex < ss.Count; nIndex++)
                {
                    CodeSite.SendMsg(ss[nIndex]);
                }
            }

            /*
             * Cad Event를 다시 가져와야 함.
             */
            ////JobInfo.SetEventProc();
        }
    }
}
