using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

using Raize.CodeSiteLogging;
using yjTech;

namespace LaserCutter
{
    public partial class panTable: UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public LaserProject LaserProject;

        public panAuto Auto;
        public panAutoMenu AutoMenu;
        public panConfigCommon Common;

        public panJobType1 Type1;
        public panJobType2 Type2;
        public panJobType3 Type3;
        public panJobType4 Type4;

        public frmMain frmMain;

        public DoublePoint[] TableBasePos = new DoublePoint[5];
        private LoadDir mLoadDir = LoadDir.LeftBottom;

        public int PageCount = 0;
        public int PageIndex = 0;

        public panTable(bool withVision = false)
        {
            InitializeComponent();

            SetCodeSitelogger();

            Common = panConfigCommon.StaticInstance;
            AutoMenu = panAutoMenu.StaticInstance;

            LaserProject = new LaserProject();

            Type1 = new panJobType1();
            Type1.Auto = panAuto.StaticInstance;
            Type1.AutoMenu = panAutoMenu.StaticInstance;
            Type1.LaserProject = LaserProject;
            Type1.Table = this;
            Type1.EnableControl(false);

            Type2 = new panJobType2();
            Type2.Auto = panAuto.StaticInstance;
            Type2.AutoMenu = panAutoMenu.StaticInstance;
            Type2.LaserProject = LaserProject;
            Type2.Table = this;
            Type2.EnableControl(false);

            Type3 = new panJobType3();
            Type3.Auto = panAuto.StaticInstance;
            Type3.AutoMenu = panAutoMenu.StaticInstance;
            Type3.LaserProject = LaserProject;
            Type3.Table = this;
            Type3.EnableControl(false);

            Type4 = new panJobType4();
            Type4.Auto = panAuto.StaticInstance;
            Type4.AutoMenu = panAutoMenu.StaticInstance;
            Type4.LaserProject = LaserProject;
            Type4.Table = this;
            Type4.EnableControl(false);

            frmMain = frmMain.StaticInstance;

            tabPage1.Controls.Add(Type1);
            tabPage2.Controls.Add(Type2);
            tabPage3.Controls.Add(Type3);
            tabPage4.Controls.Add(Type4);

            Type1.Location = new Point(0, 0);
            Type2.Location = new Point(0, 0);
            Type3.Location = new Point(0, 0);
            Type4.Location = new Point(0, 0);
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
                    if (LoadJobFile(GroupName, ModelName))
                    {
                        DisplayJobFile();
                    }
                    else
                    {
                        ClearAllControlValue();
                    }
                }
                else
                {
                    ClearAllControlValue();
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

                logger.SendMsg(String.Format("{0}.Open([{1}][{2}])", TableNo.ToString(), frmSelectJob.GroupName, frmSelectJob.ModelName));

                lblGroupName.Text = frmSelectJob.GroupName;
                lblModelName.Text = String.Format("{0}", frmSelectJob.ModelName);

                GroupName = frmSelectJob.GroupName;
                ModelName = frmSelectJob.ModelName;

                ////LaserProject.NozzleOffsetX = Global.chTable1NozzleXOffset.AsDouble;
                ////LaserProject.NozzleOffsetY = Global.chTable1NozzleYOffset.AsDouble;

                if (TableNo == TableNo.Table1)
                {
                    AutoMenu.ledTable1JobFileLoad.LED.Value = true;
                }
                else
                if (TableNo == TableNo.Table2)
                {
                    AutoMenu.ledTable2JobFileLoad.LED.Value = true;
                }

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
            SetEventProc();
        }

        public bool LoadJobFile(String aGroupName, String aModelName)
        {
            // CodeSite.EnterMethod("panJobInfo.LoadJobFile()");

            bool Result = false;

            String szPath = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), aGroupName, aModelName);
            String szName = String.Empty;

            szName = String.Format("[{0}][{1}][Table{2}].prj", aGroupName, aModelName, (int)TableNo);
            szPath = String.Format("{0}\\{1}", szPath, szName);

            if (yjCommon.FileExists(szPath))
            {
                Result = true;

                LaserProject.Clear();
                LaserProject.Model1.Clear();
                LaserProject.Model2.Clear();
                LaserProject.Model3.Clear();

                LaserProject.LoadFromFile(szPath);
            }

            // CodeSite.ExitMethod("panJobInfo.LoadJobFile()");

            return Result;
        }

        public string GetModelPath()
        {
            return String.Format("{0}Model\\{1}\\{2}\\", yjCommon.AppPath(), GroupName, ModelName);
        }

        #region public void DisplayJobFile()
        public void DisplayJobFile()
        {
            // CodeSite.EnterMethod("JobInfo.DisplayJobFile()");

            Type1.lblDxfPath.Text = LaserProject.CadFile;
            Type2.lblDxfPath.Text = LaserProject.CadFile;

            int Old = tabControl1.SelectedIndex;

            tabControl1.SelectedIndex = 0;

            Type1.ClearControlValue();
            if (!String.IsNullOrEmpty(LaserProject.CadFile))
            {
                if (yjCommon.FileExists(GetModelPath() + LaserProject.CadFile))
                {
                    Type1.Cad1.Visible = true;
                    Type1.Cad1.Open(GetModelPath() + LaserProject.CadFile);
                    Type1.lblDxfPath.Text = LaserProject.CadFile;
                    Type1.Cad1.ZoomExtend();
                    Type1.Cad1.ZoomScale(0.8);

                    Type1.CheckLayerInfo();
                    Type1.DisplayLayerInfo();
                }
                else
                {
                    /*
                     * 등록된 도면을 불러들일수 없습니다. 에러 메세지를 도면에 출력
                     */
                    Type1.panCad.Text = "등록된 도면을 불러들일수 없습니다." + "\r\n\r\n"
                                + "경로가 올바른지 확인이 필요합니다.";
                    Type1.Cad1.Visible = false;
                }
            }
            else
            {
                /*
                 * 도면이 등록되지 않았습니다. 에러 메세지 출력
                 */
               Type1.panCad.Text = "도면이 등록되지 않았습니다." + "\r\n\r\n"
                           + "도면을 등록을 해주십시오.";
               Type1.Cad1.Visible = false;
            }

            Type1.edZOffset.Enabled = (TableNo != TableNo.Table0);

            Type1.edThickness.Value = LaserProject.Model1.Thickness;

            Type1.edZOffset.Value = LaserProject.Model1.ZOffset;
            Type1.edZOffset.BackColor = Color.White;
            Type1.edZOffset.Frame.FlatColor = Color.FromArgb(80, 160, 255);

            // Type1.viRepeatCount.AsInteger = LaserProject.Model1.RepeatCount;
            Type1.edManualShiftX.Value = LaserProject.Model1.ManualShiftX;
            Type1.edManualShiftY.Value = LaserProject.Model1.ManualShiftY;
            Type1.edLaserPower.Value = LaserProject.Model1.LaserPower;
            Type1.edPulsePitch.Value = LaserProject.Model1.PulsePitch;
            Type1.cbStartPoint.ItemIndex = (int)LaserProject.Model1.StartPoint;
            Type1.edGlassSizeX.Value = LaserProject.Model1.GlassSizeX;
            Type1.edGlassSizeY.Value = LaserProject.Model1.GlassSizeY;

            if (TableNo == TableNo.Table1)
            {
                ////Type1.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model1.ZOffset + Type1.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                ////Type1.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model1.ZOffset + Type1.edThickness.Value);
            }

            Type1.chkAlignUse.Checked = LaserProject.Model1.AlignUse;
            Type1.ledUseVision.LED.Value = LaserProject.Model1.AlignUse;
            Type1.AlignMethod = LaserProject.Model1.AlignMethod;

            Type1.btnUse.LED.Value = (LaserProject.MenuIndex == 0);

            Type1.EnableControl(true);
            Type1.GetWorkCenter();

            tabControl1.SelectedIndex = 1;
            Type2.ClearControlValue();

            if (!String.IsNullOrEmpty(GetModelPath() + LaserProject.CadFile))
            {
                if (yjCommon.FileExists(GetModelPath() + LaserProject.CadFile))
                {
                    Type2.Cad2.Visible = true;
                    Type2.Cad2.Open(GetModelPath() + LaserProject.CadFile);
                    Type2.lblDxfPath.Text = LaserProject.CadFile;
                    Type2.Cad2.ZoomExtend();
                    Type2.Cad2.ZoomScale(0.8);

                    Type2.CheckLayerInfo();
                    Type2.DisplayLayerInfo();
                }
                else
                {
                    /*
                     * 등록된 도면을 불러들일수 없습니다. 에러 메세지를 도면에 출력
                     */
                    Type2.panCad2.Text = "등록된 도면을 불러들일수 없습니다." + "\r\n\r\n"
                                + "경로가 올바른지 확인이 필요합니다.";
                    Type2.Cad2.Visible = false;
                }
            }
            else
            {
                /*
                 * 도면이 등록되지 않았습니다. 에러 메세지 출력
                 */
               Type2.panCad2.Text = "도면이 등록되지 않았습니다." + "\r\n\r\n"
                           + "도면을 등록을 해주십시오.";
               Type2.Cad2.Visible = false;
            }

            Type2.edXCount.AsInteger = LaserProject.Model2.XCount;
            Type2.edYCount.AsInteger = LaserProject.Model2.YCount;

            Type2.edGapX.Value = LaserProject.Model2.GapX;
            Type2.edGapY.Value = LaserProject.Model2.GapY;

            Type2.ledSortMethod1.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method1);
            Type2.ledSortMethod2.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method2);
            Type2.ledSortMethod3.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method3);
            Type2.ledSortMethod4.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method4);

            Type2.edThickness.Value = LaserProject.Model2.Thickness;
            Type2.edZOffset.Value = LaserProject.Model2.ZOffset;

            if (TableNo == TableNo.Table1)
            {
                ////Type2.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model2.ZOffset + Type2.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                ////Type2.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model2.ZOffset + Type2.edThickness.Value);
            }

            Type2.edManualShiftX.Value = LaserProject.Model2.ManualShiftX;
            Type2.edManualShiftY.Value = LaserProject.Model2.ManualShiftY;
            Type2.edGlassSizeX.Value = LaserProject.Model2.GlassSizeX;
            Type2.edGlassSizeY.Value = LaserProject.Model2.GlassSizeY;
            Type2.edLaserPower.Value = LaserProject.Model2.LaserPower;
            Type2.edPulsePitch.Value = LaserProject.Model2.PulsePitch;
            Type2.cbStartPoint.ItemIndex = (int)LaserProject.Model2.StartPoint;

            Type2.chkAlignUse.Checked = LaserProject.Model2.AlignUse;
            Type2.ledUseVision.LED.Value = LaserProject.Model2.AlignUse;
            Type2.btnUse.LED.Value = (LaserProject.MenuIndex == 1);

            Type2.EnableControl(true);
            Type2.GetPageData();

            Type2.btnApply_Click(null, null);
            Type2.GetWorkCenter(0);

            tabControl1.SelectedIndex = 2;
            Type3.ClearControlValue();

            Type3.edLaserPower.Value = LaserProject.Model3.LaserPower;
            Type3.edPulsePitch.Value = LaserProject.Model3.PulsePitch;
            Type3.cbStartPoint.ItemIndex = (int)LaserProject.Model3.StartPoint;

            Type3.edThickness.Value = LaserProject.Model3.Thickness;
            Type3.edZOffset.Value = LaserProject.Model3.ZOffset;

            if (TableNo == TableNo.Table1)
            {
                ////Type3.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model3.ZOffset + Type3.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                ////Type3.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model3.ZOffset + Type3.edThickness.Value);
            }

            Type3.rdoCell.Checked = (LaserProject.Model3.SelectType == 0);
            Type3.rdoCircle.Checked = !(LaserProject.Model3.SelectType == 0);

            if (Type3.rdoCell.Checked)
            {
                Type3.UpdateCellTypeUI(true);
            }
            else
            if (Type3.rdoCircle.Checked)
            {
                Type3.UpdateCellTypeUI(false);
            }

            Type3.edXCount.AsInteger = LaserProject.Model3.XCount;
            Type3.edYCount.AsInteger = LaserProject.Model3.YCount;

            Type3.edGapX.Value = LaserProject.Model3.GapX;
            Type3.edGapY.Value = LaserProject.Model3.GapY;
            Type3.edCellWidth.Value = LaserProject.Model3.Width;
            Type3.edCellHeight.Value = LaserProject.Model3.Height;
            Type3.edCellRadius.Value = LaserProject.Model3.Radius;
            Type3.chkUseBreakLine.Checked = LaserProject.Model3.UseBreakingLine;
            Type3.chkBreakLineOutDir.Checked = LaserProject.Model3.LineDir;

            Type3.edBreakLineOffset.Value = LaserProject.Model3.BreakingLineOffset;
            Type3.edBreakLineLength.Value = LaserProject.Model3.BreakingLineLength;

            Type3.ledSortMethod1.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method1);
            Type3.ledSortMethod2.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method2);
            Type3.ledSortMethod3.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method3);
            Type3.ledSortMethod4.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method4);

            Type3.edGlassSizeX.Value = LaserProject.Model3.GlassSizeX;
            Type3.edGlassSizeY.Value = LaserProject.Model3.GlassSizeY;
            Type3.btnUse.LED.Value = (LaserProject.MenuIndex == 2);

            Type3.EnableControl(true);
            Type3.CreateUserCell();
            Type3.CheckLayerInfo();
            Type3.btnApply_Click(null, null);
            Type3.GetWorkCenter(0);

            tabControl1.SelectedIndex = Old;

            tabControl1.SelectedIndex = LaserProject.MenuIndex;

            // CodeSite.ExitMethod("JobInfo.DisplayJobFile()");
        }
        #endregion


        #region public void ClearAllControlValue()
        public void ClearAllControlValue()
        {
            // Type1
            Type1.lblDxfPath.Text = "";

            Type1.edLaserPower.Value = 0.0;
            Type1.edZOffset.Value = 0.0;

            Type1.edManualShiftX.Value = 0.0;
            Type1.edManualShiftY.Value = 0.0;

            Type1.edPulsePitch.Value = 0.000;

            Type1.edGlassSizeX.Value = 0.0;
            Type1.edGlassSizeY.Value = 0.0;

            // Type2
            Type2.edLaserPower.Value = 0.0;
            Type2.edZOffset.Value = 0.0;
            Type2.edPulsePitch.Value = 0.000;
            Type2.edYCount.AsInteger = 0;
            Type2.edXCount.AsInteger = 0;
            Type2.edGapX.Value = 0.0;
            Type2.edGapY.Value = 0.0;

            Type3.edLaserPower.Value = 0.0;
            Type3.edZOffset.Value = 0.0;
            Type3.edPulsePitch.Value = 0.000;
        }
        #endregion

        public void SetEventProc()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if (Type1.Cad1 != null)
                    {
                        Type1.Cad1.SetEventProc();
                    }
                    break;

                case 1:
                    if (Type2.Cad2 != null)
                    {
                        Type2.Cad2.SetEventProc();
                    }
                    break;

                case 2:
                    if (Type3.Cad3 != null)
                    {
                        Type3.Cad3.SetEventProc();
                    }
                    break;

                case 3:
                    if (Type4.Cad4 != null)
                    {
                        Type4.Cad4.SetEventProc();
                    }
                    break;
            }
        }

        public void GetTableBaseOffset(PageList APageList, int APageIndex, double xShift, double yShift, ztMarkPage ACadData, ref double offsetX, ref double offsetY)
        {
            // Original Loading위치를 가져오고..
            GetTableBaseOffset(xShift, yShift, ACadData, ref offsetX, ref offsetY);

            // Original Loading위치에서 APageIndex 제품의 보정빼준다..
            switch (LoadDir)
            {
                case LoadDir.LeftBottom:
                    offsetX = offsetX + APageList[APageIndex].x;
                    offsetY = offsetY - APageList[APageIndex].y;
                    break;

                case LoadDir.LeftTop:
                    break;

                case LoadDir.RightTop:
                    break;

                case LoadDir.RightBottom:
                    break;

                case LoadDir.Center:
                    offsetX = offsetX - (APageList.Width - APageList.PageSize.x) / 2.0 + APageList[APageIndex].x;
                    offsetY = offsetY + (APageList.Height - APageList.PageSize.y) / 2.0 - APageList[APageIndex].y;
                    break;
            }
        }

        public void GetTableBaseOffset(double xShift, double yShift, ztMarkPage ACadData, ref double offsetX, ref double offsetY)
        {
            GetTableBaseOffset(ACadData.XMin, ACadData.YMin, ACadData.XMax, ACadData.YMax, xShift, yShift, ref offsetX, ref offsetY);
        }

        public void GetTableBaseOffset(double xMin, double yMin, double xMax, double yMax, double xShift, double yShift, ref double offsetX, ref double offsetY)
        {
            double width = (xMax - xMin);
            double height = (yMax - yMin);

            switch (LoadDir)
            {
                case LoadDir.LeftBottom:
                    if (TableBasePos[0] != null)
                    {
                        offsetX = TableBasePos[0].x + (width / 2) + xShift;
                        offsetY = TableBasePos[0].y - ((height / 2) + yShift);
                    }
                    break;

                case LoadDir.LeftTop:
                    if (TableBasePos[1] != null)
                    {
                        offsetX = TableBasePos[1].x + (width / 2);
                        offsetY = TableBasePos[1].y + (height / 2);
                    }
                    break;

                case LoadDir.RightTop:
                    if (TableBasePos[2] != null)
                    {
                        offsetX = TableBasePos[2].x - (width / 2);
                        offsetY = TableBasePos[2].y + (height / 2);
                    }

                    break;

                case LoadDir.RightBottom:
                    if (TableBasePos[3] != null)
                    {
                        offsetX = TableBasePos[3].x - (width / 2);
                        offsetY = TableBasePos[3].y - (height / 2);
                    }
                    break;

                case LoadDir.Center:
                    if (TableBasePos[4] != null)
                    {
                        offsetX = TableBasePos[4].x;
                        offsetY = TableBasePos[4].y;
                    }

                    break;
            }
        }

        #region public LoadDir LoadDir
        public LoadDir LoadDir
        {
            get
            {
                return mLoadDir;
            }

            set
            {
                mLoadDir = value;
            }
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.ChangeAutoTitle();
            SetEventProc();
        }


        #region public void SaveJobFile()
        public void SaveJobFile()
        {
            LaserProject.CadFile = Type1.lblDxfPath.Text;

            LaserProject.Model1.LaserPower = Type1.edLaserPower.Value;
            LaserProject.Model1.ZOffset = Type1.edZOffset.Value;

            if (TableNo == TableNo.Table1)
            {
                Type1.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model1.ZOffset + Type1.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                Type1.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model1.ZOffset + Type1.edThickness.Value);
            }

            LaserProject.Model1.PulsePitch = Type1.edPulsePitch.Value;
            LaserProject.Model1.Thickness = Type1.edThickness.Value;

            LaserProject.Model1.ManualShiftX = Type1.edManualShiftX.Value;
            LaserProject.Model1.ManualShiftY = Type1.edManualShiftY.Value;
            LaserProject.Model1.StartPoint = (StartPoint)Type1.cbStartPoint.ItemIndex;

            LaserProject.Model1.GlassSizeX = Type1.edGlassSizeX.Value;
            LaserProject.Model1.GlassSizeY = Type1.edGlassSizeY.Value;
            LaserProject.Model1.AlignUse = Type1.chkAlignUse.Checked;
            LaserProject.Model1.AlignMethod = Type1.AlignMethod;


            LaserProject.Model2.LaserPower = Type2.edLaserPower.Value;
            LaserProject.Model2.ZOffset = Type2.edZOffset.Value;
            LaserProject.Model2.PulsePitch = Type2.edPulsePitch.Value;
            LaserProject.Model2.Thickness = Type2.edThickness.Value;

            if (TableNo == TableNo.Table1)
            {
                Type2.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model2.ZOffset + Type2.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                Type2.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model2.ZOffset + Type2.edThickness.Value);
            }

            LaserProject.Model2.XCount = Type2.edXCount.AsInteger;
            LaserProject.Model2.YCount = Type2.edYCount.AsInteger;
            LaserProject.Model2.GapX = Type2.edGapX.Value;
            LaserProject.Model2.GapY = Type2.edGapY.Value;

            LaserProject.Model2.StartPoint = (StartPoint)Type2.cbStartPoint.ItemIndex;

            LaserProject.Model2.GlassSizeX = Type2.edGlassSizeX.Value;
            LaserProject.Model2.GlassSizeY = Type2.edGlassSizeY.Value;
            LaserProject.Model2.AlignUse = Type2.chkAlignUse.Checked;
            LaserProject.Model2.AlignMethod = Type2.AlignMethod;
            LaserProject.Model2.ManualShiftX = Type2.edManualShiftX.Value;
            LaserProject.Model2.ManualShiftY = Type2.edManualShiftY.Value;

            LaserProject.Model3.LaserPower = Type3.edLaserPower.Value;
            LaserProject.Model3.ZOffset = Type3.edZOffset.Value;
            LaserProject.Model3.PulsePitch = Type3.edPulsePitch.Value;
            LaserProject.Model3.Thickness = Type3.edThickness.Value;

            if (TableNo == TableNo.Table1)
            {
                Type3.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model3.ZOffset + Type3.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                Type3.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model3.ZOffset + Type3.edThickness.Value);
            }

            LaserProject.Model3.StartPoint = (StartPoint)Type3.cbStartPoint.ItemIndex;

            LaserProject.Model3.XCount = Type3.edXCount.AsInteger;
            LaserProject.Model3.YCount = Type3.edYCount.AsInteger;
            LaserProject.Model3.GapX = Type3.edGapX.Value;
            LaserProject.Model3.GapY = Type3.edGapY.Value;
            LaserProject.Model3.GlassSizeX = Type3.edGlassSizeX.Value;
            LaserProject.Model3.GlassSizeY = Type3.edGlassSizeY.Value;
            LaserProject.Model3.Width = Type3.edCellWidth.Value;
            LaserProject.Model3.Height = Type3.edCellHeight.Value;

            /*
             * Cell은 Radius 없이 만들수 없게 되어있으므로
             * Radius는 0을 기입할수 없게..
             */
            if (Type3.edCellRadius.Value <= 0.0) Type3.edCellRadius.Value = 0.001;
            LaserProject.Model3.Radius = Type3.edCellRadius.Value;

            LaserProject.Model3.UseBreakingLine = Type3.chkUseBreakLine.Checked;
            LaserProject.Model3.LineDir = Type3.chkBreakLineOutDir.Checked;
            LaserProject.Model3.BreakingLineLength = Type3.edBreakLineLength.Value;
            LaserProject.Model3.BreakingLineOffset = Type3.edBreakLineOffset.Value;

            if (Type3.rdoCell.Checked)
            {
                LaserProject.Model3.SelectType = 0;
            }
            else
            if (Type3.rdoCircle.Checked)
            {
                LaserProject.Model3.SelectType = 1;
            }

            String szFileName = String.Empty;
            szFileName = String.Format("{0}[{1}][{2}][Table{3}].prj", GetModelPath(), GroupName, ModelName, (int)TableNo);

            LaserProject.DateTime = DateTime.Now;
            LaserProject.SaveToFile(szFileName);
        }
        #endregion

        public int GetFirstPage()
        {
            int Result = (0);

            if (tabControl1.SelectedIndex == 1)
            {
                Result = Type2.PageList.GetFirstPage();
            }
            else
            if (tabControl1.SelectedIndex == 2)
            {
                Result = Type3.PageList.GetFirstPage();
            }

            return Result;
        }

        public int GetNextPage(int AIndex)
        {
            int Result = (-1);

            if (tabControl1.SelectedIndex == 1)
            {
                Result = Type2.PageList.GetNextPage(AIndex);
            }
            else
            if (tabControl1.SelectedIndex == 2)
            {
                Result = Type3.PageList.GetNextPage(AIndex);
            }

            return Result;
        }

        public int GetTotalPageCount()
        {
            int Result = 1;

            if (tabControl1.SelectedIndex == 1)
            {
                Result = Type2.PageList.Count;
            }
            else
            if (tabControl1.SelectedIndex == 2)
            {
                Result = Type3.PageList.Count;
            }

            return Result;
        }

        public void MakeMotionFile(double Angle, DoublePoint AlignShift, bool LaserRun)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Type1.MakeMotionFile(TableNo, Angle,
                                                    LaserProject.Model1.ManualShiftX + AlignShift.x,
                                                        LaserProject.Model1.ManualShiftY - AlignShift.y, LaserRun);
                    break;

                case 1:
                    Type2.MakeMotionFile(TableNo, PageIndex, Angle,
                                                    LaserProject.Model2.ManualShiftX + AlignShift.x,
                                                        LaserProject.Model2.ManualShiftY - AlignShift.y, LaserRun);
                    break;

                case 2:
                    Type3.MakeMotionFile(TableNo, PageIndex, 0, 0, LaserRun);
                    break;
            }
        }


        public DoublePoint MakeRectType(bool LaserRun, ref StringList List, ztRectItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

                // yhbyun rr = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                
            }

            return rr;
        }

        public DoublePoint MakeArcType(ztArcItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                DoublePoint ptC = new DoublePoint { x = OffsetX + pItem.Xc, y = OffsetY - pItem.Yc };

                DoublePoint ptS = new DoublePoint(OffsetX + (pItem.X0 + ptShift.x), OffsetY - (pItem.Y0 + ptShift.y));
                DoublePoint ptE = new DoublePoint(OffsetX + (pItem.X1 + ptShift.x), OffsetY - (pItem.Y1 + ptShift.y));

                rr = ptS;
            }

            return rr;
        }

        public DoublePoint MakeArcType(bool LaserRun, ref StringList List, ztArcItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            //   CodeSite.SendMsg("MakeArcType");
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                DoublePoint ptCenter = new DoublePoint { x = OffsetX + pItem.Xc, y = OffsetY - pItem.Yc };

                DoublePoint ptStart = new DoublePoint(OffsetX + (pItem.X0 + ptShift.x), OffsetY - (pItem.Y0 + ptShift.y));
                DoublePoint ptEnd = new DoublePoint(OffsetX + (pItem.X1 + ptShift.x), OffsetY - (pItem.Y1 + ptShift.y));

                rr = ptStart;

                SetSpeed(ref List, Global.chConArcSpeed.AsDouble, 0, 3, ptStart, false);

                WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, !pItem.bCCW);
            }

            return rr;
        }


        public DoublePoint MakePolylineType(ztPolylineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                for (int nVertexIndex = 0; nVertexIndex < pItem.GetCount(); nVertexIndex++)
                {
                    ztPolylineVertex pVertex = pItem.GetVertex(nVertexIndex);
                    pVertex.CalculateArcCenter();

                    double dBulge = pItem.GetVertex(nVertexIndex).Bulge;
                    double dR = 0.0;

                    if (dBulge != 0.0)
                    {
                        dR = pItem.GetVertex(nVertexIndex).ArcRad;
                    }

                    if (nVertexIndex == 0)
                    {
                        if (dBulge != 0.0)
                        {
                            DoublePoint ptS, ptE;
                            DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                            DoublePoint ptC = new DoublePoint(0, 0);// = new DoublePoint { x = pVertex.cX, y = pVertex.cY };
                            DoublePoint ptTempC = new DoublePoint(0, 0);

                            ptS = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                            ptE = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));

                            rr = ptS;
                        }
                        else
                        {
                            DoublePoint ptS = new DoublePoint(OffsetX + (pVertex.X + ShiftX), OffsetY - (pVertex.Y + ShiftY));

                            rr = ptS;
                        }
                    }
                }
            }

            return rr;
        }

        public DoublePoint MakePolylineType(bool LaserRun, ref StringList List, ztPolylineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint ptPrev = new DoublePoint(0, 0);
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                for (int nVertexIndex = 0; nVertexIndex < pItem.GetCount(); nVertexIndex++)
                {
                    ztPolylineVertex pVertex = pItem.GetVertex(nVertexIndex);
                    pVertex.CalculateArcCenter();

                    double dBulge = pItem.GetVertex(nVertexIndex).Bulge;
                    double dR = 0.0;

                    if (dBulge != 0.0)
                    {
                        dR = pItem.GetVertex(nVertexIndex).ArcRad;
                    }

                    if (nVertexIndex == 0)
                    {
                        if (dBulge != 0.0)
                        {
                            List.Add("");
                            List.Add($"    // Arc [{nVertexIndex}/{pItem.GetCount()}]");

                            double cx, cy;

                            DoublePoint ptStart, ptEnd;
                            DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                            DoublePoint ptCenter = new DoublePoint(0, 0);

                            ptStart = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                            ptEnd = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));

                            rr = ptStart;

                            cx = pVertex.cX;
                            cy = pVertex.cY;
                            ptCenter = new DoublePoint { x = OffsetX + (pVertex.cX + ptShift.x), y = OffsetY - (pVertex.cY + ptShift.y) };
                            SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptStart, false);

                            WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, (pVertex.Bulge < 0)); // Bulge값이 음수일때가 CountClock 방향
                            List.Add($"    DWELL 7");
                            if (LaserRun)
                            {
                                List.Add($"    doLaserTriggerOn==true");// file.WriteLine($"M7122==1"); i/o확인 해야함!!!
                            }
                            else
                            {
                                List.Add($"    doLaserTriggerOn==false");// DryRun
                            }
                            List.Add($"    DWELL 7");
                        }
                        else
                        {
                            List.Add("");
                            List.Add($"    // Line [{nVertexIndex}/{pItem.GetCount()}]");

                            DoublePoint ptStart = new DoublePoint(OffsetX + (pVertex.X + ShiftX), OffsetY - (pVertex.Y + ShiftY));

                            rr = ptStart;

                            SetSpeed(ref List, Global.chConJumpSpeed.AsDouble, Global.chConJumpTA.AsDouble, 20, ptStart, false);
                            List.Add($"    DWELL 7");
                            if (LaserRun)
                            {
                                List.Add($"    doLaserTriggerOn==true");
                            }
                            else
                            {
                                List.Add($"    doLaserTriggerOn==false"); // DryRun
                            }
                            List.Add($"    DWELL 7");

                            List.Add("");
                            DoublePoint ptEnd = new DoublePoint(OffsetX + (pVertex.X + pVertex.dX + ShiftX), OffsetY - (pVertex.Y + pVertex.dY + ShiftY));

                            SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptEnd, false);
                        }
                    }
                    else
                    if (nVertexIndex < (pItem.GetCount() - 1))
                    {
                        if (dBulge != 0.0)
                        {
                            List.Add("");
                            List.Add($"    // Arc [{nVertexIndex}/{pItem.GetCount()}]");

                            DoublePoint ptStart, ptEnd;
                            DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                            DoublePoint ptCenter = new DoublePoint(0, 0);

                            pVertex.CalculateArcCenter();

                            double cx, cy;
                            cx = pVertex.cX;
                            cy = pVertex.cY;

                            ptStart = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                            ptEnd = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));

                            ptCenter = new DoublePoint { x = OffsetX + (pVertex.cX + ptShift.x), y = OffsetY - (pVertex.cY + ptShift.y) };

                            ptPrev = ptEnd;
                            WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, (pVertex.Bulge < 0)); // Bulge값이 음수일때가 CountClock 방향
                        }
                        else
                        {
                            List.Add("");
                            List.Add($"    // Line [{nVertexIndex}/{pItem.GetCount()}]");

                            DoublePoint ptS = new DoublePoint(OffsetX + (pVertex.X + pVertex.dX + ShiftX), OffsetY - (pVertex.Y + pVertex.dY + ShiftY));

                            SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptS, false);
                        }
                    }
                    else
                    if (nVertexIndex == (pItem.GetCount() - 1))
                    {
                        if (pItem.Closed)
                        {
                            if (dBulge != 0.0)
                            {
                                List.Add("");
                                List.Add($"    // Arc [{nVertexIndex}/{pItem.GetCount()}]");
                                double cx, cy;
                                DoublePoint ptStart, ptEnd;
                                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                                DoublePoint ptCenter = new DoublePoint(0, 0);

                                pVertex.CalculateArcCenter();
                                cx = pVertex.cX;
                                cy = pVertex.cY;
                                ptStart = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                                ptEnd = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));
                                ptCenter = new DoublePoint { x = OffsetX + (pVertex.cX + ptShift.x), y = OffsetY - (pVertex.cY + ptShift.y) };

                                WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, (pVertex.Bulge < 0)); // Bulge값이 음수일때가 CountClock 방향
                            }
                            else
                            {
                                List.Add("");
                                List.Add($"    // Line [{nVertexIndex}/{pItem.GetCount()}]");

                                DoublePoint ptEnd = new DoublePoint(OffsetX + (pVertex.X + pVertex.dX + ShiftX), OffsetY - (pVertex.Y + pVertex.dY + ShiftY));

                                DoublePoint ptEnd2 = ExtendLine(ptPrev, ptEnd, 0.004);

                                SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptEnd2, false);

                                List.Add("");
                                List.Add($"    DWELL 7");
                                List.Add($"    doLaserTriggerOn==false");// file.WriteLine($"M7122==1"); i/o확인 해야함!!!
                                List.Add($"    DWELL 7");
                            }
                        }
                        else
                        {
                            List.Add($"    // Polyline.Open!!");
                        }
                    }
                }
            }

            return rr;
        }

        public DoublePoint MakeLineType(ztLineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptS = new DoublePoint(OffsetX + (pItem.X0 + ShiftX), OffsetY - (pItem.Y0 + ShiftY));
                DoublePoint ptE = new DoublePoint(OffsetX + (pItem.X1 + ShiftX), OffsetY - (pItem.Y1 + ShiftY));

                rr = ptS;
            }

            return rr;
        }

        public DoublePoint MakeLineType(bool LaserRun, ref StringList List, ztLineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptS = new DoublePoint(OffsetX + (pItem.X0 + ShiftX), OffsetY - (pItem.Y0 + ShiftY));
                DoublePoint ptE = new DoublePoint(OffsetX + (pItem.X1 + ShiftX), OffsetY - (pItem.Y1 + ShiftY));

                rr = ptS;

                if (List != null)
                {
                    SetSpeed(ref List, Global.chConJumpSpeed.AsDouble, Global.chConJumpTA.AsDouble, 20, ptS, false);
                    List.Add($"    DWELL 7");
                    if (LaserRun)
                    {
                        List.Add($"    doLaserTriggerOn==true");// file.WriteLine($"M7122==1"); i/o확인 해야함!!!
                    }
                    else
                    {
                        List.Add($"    doLaserTriggerOn==false"); // DryRun
                    }
                    List.Add($"    DWELL 7");
                    List.Add("");

                    SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptE, true);
                    List.Add($"    DWELL 7");
                    List.Add($"    doLaserTriggerOn==false");// file.WriteLine($"M7122==0"); i/o확인 해야함!!!
                    List.Add($"    DWELL 7");
                }
            }

            return rr;
        }

        public DoublePoint MakeCircleType(ztCircleItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

                rr = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                
            }

            return rr;
        }

        public DoublePoint MakeCircleType(bool LaserRun, ref StringList List, ztCircleItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptStart, ptEnd;
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

                DoublePoint ptCenter = new DoublePoint { x = OffsetX + pItem.CenterX + ptShift.x, y = OffsetY - (pItem.CenterY + ptShift.y) };
                ptStart = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                

                rr = ptStart;

                pItem.StartAngle = pItem.StartAngle + 180.0;
                DoublePoint ptHalf = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)               

                // Overlap 하는 거리만큼을 각으로 산출하여
                double additionalDistance = 0.00; // 원하는 추가 거리 (10 µm = 0.01 mm)
                double radius = pItem.R;     // pItem의 반지름 값

                // 추가 각도 계산 (라디안)
                double additionalAngle = additionalDistance / radius; // 라디안 값

                if (pItem.DirCW)
                {
                    pItem.StartAngle = pItem.StartAngle + 180 - additionalAngle * (180 / Math.PI);
                }
                else
                {
                    pItem.StartAngle = pItem.StartAngle + 180 + additionalAngle * (180 / Math.PI);
                }

                ptEnd = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)

                SetSpeed(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 20, ptStart, false);
                List.Add("");
                List.Add($"    DWELL 7");
                if (LaserRun)
                {
                    List.Add($"    doLaserTriggerOn==true");
                }
                else
                {
                    List.Add($"    doLaserTriggerOn==false"); // DryRun
                }
                List.Add($"    DWELL 7");
                List.Add("");
                WriteCircleToArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptHalf, ptCenter, pItem.DirCW);
                List.Add("");

                // 두 번째 반원
                WriteCircleToArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptHalf, ptEnd, ptCenter, pItem.DirCW);

                List.Add($"    DWELL 7");
                List.Add($"    doLaserTriggerOn==false");
                List.Add($"    DWELL 7");
            }

            return rr;
        }


        private void WriteArcGCode(ref StringList List, double f, double ta, int ts, DoublePoint ptStart, DoublePoint ptEnd, DoublePoint ptCenter, bool ClockWiseDir)//arc인경우 ptE값은 ptS값임!!!!!
        {
            double i, j;

            i = ptCenter.x - ptStart.x;
            j = ptCenter.y - ptStart.y;

            string command = ClockWiseDir ? "CIRCLE2" : "CIRCLE1";//"CIRCLE1" : "CIRCLE2";
            List.Add($"    F({f}) TA({ta}) TS({ts})");
            if (ClockWiseDir)
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // ClockWise, EndX, EndY, CenterX, CenterY");
            }
            else
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // CountClockWise, EndX, EndY, CenterX, CenterY");
            }
        }

        private void WriteCircleToArcGCode(ref StringList List, double f, double ta, int ts, DoublePoint ptStart, DoublePoint ptEnd, DoublePoint ptCenter, bool ClockWiseDir)//arc인경우 ptE값은 ptS값임!!!!!
        {
            double i, j;

            i = ptCenter.x - ptStart.x;
            j = ptCenter.y - ptStart.y;

            string command = ClockWiseDir ? "CIRCLE2" : "CIRCLE1";//"CIRCLE1" : "CIRCLE2";
            List.Add($"    F({f}) TA({ta}) TS({ts})");
            if (ClockWiseDir)
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // ClockWise, EndX, EndY, CenterX, CenterY");
            }
            else
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // CountClockWise, EndX, EndY, CenterX, CenterY");
            }
        }


        public void SetSpeed(ref StringList List, double f, double ta, int ts, DoublePoint pt, bool isRapid)
        {
            List.Add($"    F({f}) TA({ta}) TS({ts})");
            List.Add($"    X{pt.x:F3} Y{pt.y:F3} // StartX, StartY");
        }

        public DoublePoint ExtendLine(DoublePoint ptStart, DoublePoint ptEnd, double extendLength)
        {
            // ptStart에서 ptEnd까지의 차이를 구함
            double dx = ptEnd.x - ptStart.x;
            double dy = ptEnd.y - ptStart.y;

            // 두 점 사이의 거리를 계산
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // 새로운 거리 = 기존 거리 + 연장하고 싶은 길이 (예: 1mm)
            double newDistance = distance + extendLength;

            // 기울기를 유지하면서 새 점을 계산 (단위 벡터로 방향 유지)
            double scale = newDistance / distance;

            // ptEnd 위치를 확장된 거리만큼 이동
            double newX = ptStart.x + dx * scale;
            double newY = ptStart.y + dy * scale;

            return new DoublePoint(newX, newY);
        }

    }

    public struct PageItem
    {
        public double x { get; set; }
        public double y { get; set; }
        public bool Used { get; set; }

        public PageItem(double x, double y, bool used)
        {
            this.x = x;
            this.y = y;
            this.Used = used;
        }

        public override string ToString()
        {
            return $"[{x}, {y}, {Used}]";
        }
    }

    public class PageList
    {
        private List<PageItem> positions; // 좌표 리스트

        private DoublePoint mPageSize; // 페이지 크기

        public PageList()
        {
            positions = new List<PageItem>();
        }

        // Clear: 리스트 초기화
        public void Clear()
        {
            positions.Clear();
        }

        // Add: x, y 값을 추가
        public void Add(double x, double y, bool used)
        {
            positions.Add(new PageItem(x, y, used));
        }

        // Count: 현재 리스트의 개수 반환
        public int Count => positions.Count;

        // SetCellSize: 셀 크기 설정
        public DoublePoint PageSize
        {
            get => mPageSize;
            set => mPageSize = value;
        }

        // XMin: x 좌표의 최소값 - PageSize.x / 2
        public double XMin
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double minX = double.MaxValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].x < minX)
                    {
                        minX = positions[i].x;
                    }
                }

                return minX - PageSize.x / 2;
            }
        }

        // XMax: x 좌표의 최대값 + PageSize.x / 2
        public double XMax
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double maxX = double.MinValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].x > maxX)
                    {
                        maxX = positions[i].x;
                    }
                }

                return maxX + PageSize.x / 2;
            }
        }

        // YMin: y 좌표의 최소값 - PageSize.y / 2
        public double YMin
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double minY = double.MaxValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].y < minY)
                    {
                        minY = positions[i].y;
                    }
                }

                return minY - PageSize.y / 2;
            }
        }

        // YMax: y 좌표의 최대값 + PageSize.y / 2
        public double YMax
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double maxY = double.MinValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].y > maxY)
                    {
                        maxY = positions[i].y;
                    }
                }

                return maxY + PageSize.y / 2;
            }
        }

        // Width: 전체 페이지의 너비 계산
        public double Width => XMax - XMin;

        // Height: 전체 페이지의 높이 계산
        public double Height => YMax - YMin;

        // 인덱서를 사용하여 특정 좌표를 참조
        public PageItem this[int index]
        {
            get
            {
                if (index < 0 || index >= positions.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                return positions[index];
            }
            set
            {
                if (index < 0 || index >= positions.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                positions[index] = value;
            }
        }

        // GetAll: 모든 좌표 반환
        public List<PageItem> GetAll()
        {
            return new List<PageItem>(positions);
        }

        public int SelectedCount()
        {
            int result = 0;

            for (int nIndex = 0; nIndex < Count; nIndex++)
            {
                if (this[nIndex].Used) result = result + 1;
            }
            return result;
        }

        public int GetFirstPage()
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Used)
                {
                    return i;
                }
            }

            return -1; // 없으면 -1 반환
        }

        // GetNextPage: 지정된 인덱스 이후로 처음 Used == true인 인덱스 반환
        public int GetNextPage(int index)
        {
            for (int i = index; i < Count; i++)
            {
                if (this[i].Used)
                {
                    return i;
                }
            }

            return -1; // 없으면 -1 반환
        }
    }
}
