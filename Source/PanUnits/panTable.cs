using System;
using System.Drawing;
using System.Windows.Forms;

using DaekhonSystem;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panTable : UserControl
    {
        CodeSiteLogger logger;

        public LaserProject LaserProject;

        public frmSelectJob frmSelectJob;
        public panAuto Auto;
        public panJobInfo JobInfo;
        public panVision Vision;
        public panConfigCommon Common;

        public int mStep = 0;
        public int LastStep = 0;
        public int ErrorCode = 0;

        public int TotalPageCount = 0;
        public int PageCount = 0;
        public int PageIndex = 0;

        public LayerCollection Layers;
        public int LayerIndex;

        public DoublePoint[] TableBasePos = new DoublePoint[5];

        private LoadDir mLoadDir = LoadDir.LeftBottom;

        public panTable(bool withVision = false)
        {
            InitializeComponent();

            SetCodeSitelogger();

            if (withVision)
            {
                Vision = new panVision();
            }

            Common = panConfigCommon.StaticInstance;

            JobInfo = new panJobInfo();
            JobInfo.TableNo = TableNo;
            JobInfo.Location = new Point(3, 36);
            panClient.Controls.Add(JobInfo);

            LaserProject = new LaserProject();

            JobInfo.Type1.Table = this;
            JobInfo.Type1.LaserProject = LaserProject;

            JobInfo.Type2.Table = this;
            JobInfo.Type2.LaserProject = LaserProject;

            JobInfo.Type3.Table = this;
            JobInfo.Type3.LaserProject = LaserProject;

            JobInfo.Type1.btnClear.Enabled = false;
            JobInfo.Type1.btnOpenFile.Enabled = false;
        }

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = String.Format("{0}", TableNo.ToString());

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = dkCommon.AppPath();
            fileDestination.LogFile.FileName = "LaserCutter";

            logger.Destination = fileDestination;
            logger.Destination.Viewer.Active = true;
        }

        public void ChangeLogFilePath(String szPath)
        {
            logger.Destination.LogFile.LogByDate = false;
            logger.Destination.LogFile.Active = false;

            logger.Destination.LogFile.FilePath = szPath;

            logger.Destination.LogFile.LogByDate = true;
            logger.Destination.LogFile.Active = true;
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
                };

                logger.SendMsg(String.Format("{0}.Open([{1}][{2}])", TableNo.ToString(), frmSelectJob.GroupName, frmSelectJob.ModelName));

                lblGroupName.Text = frmSelectJob.GroupName;
                lblModelName.Text = String.Format("{0}", frmSelectJob.ModelName);

                GroupName = frmSelectJob.GroupName;
                ModelName = frmSelectJob.ModelName;

                LaserProject.NozzleOffsetX = Global.chTable1NozzleXOffset.AsDouble;
                LaserProject.NozzleOffsetY = Global.chTable1NozzleYOffset.AsDouble;

                if (TableNo == TableNo.Table1)
                {
                    Auto.ledTable1JobFileLoad.LED.Value = true;
                }
                else
                if (TableNo == TableNo.Table2)
                {
                    Auto.ledTable2JobFileLoad.LED.Value = true;
                }

                Vision.DefaultVisionFile = String.Format("{0}CogPMAlignTool(4Align).vpp", frmSelectJob.GetModelPath());
                Vision.ledCogPMAlignTool.LED.Value = dkCommon.FileExists(Vision.DefaultVisionFile);
                Vision.btnLoadProject.Enabled = Vision.ledCogPMAlignTool.LED.Value;

                if (Vision.ledCogPMAlignTool.LED.Value)
                {
                    Vision.btnLoadProject_Click(null, null);
                }

                DaekhonSystem.StringList ss;
                ss = LaserProject.Model1.ToStringList();

                CodeSite.SendMsg("");
                CodeSite.SendMsg(String.Format("    {0}.FileName = [{1}][{2}][Table{3}].prj", TableNo, GroupName, ModelName, (int)JobInfo.TableNo));
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
            JobInfo.SetEventProc();
        }

        public bool LoadJobFile(String aGroupName, String aModelName)
        {
            // CodeSite.EnterMethod("panJobInfo.LoadJobFile()");

            bool Result = false;

            String szPath = String.Format("{0}Model\\{1}\\{2}", dkCommon.AppPath(), aGroupName, aModelName);
            String szName = String.Empty;

            szName = String.Format("[{0}][{1}][Table{2}].prj", aGroupName, aModelName, (int)TableNo);
            szPath = String.Format("{0}\\{1}", szPath, szName);

            if (dkCommon.FileExists(szPath))
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

        #region public void DisplayJobFile()
        public void DisplayJobFile()
        {
            // CodeSite.EnterMethod("JobInfo.DisplayJobFile()");

            JobInfo.Type1.lblDxfPath.Text = LaserProject.CadFile;
            JobInfo.Type2.lblDxfPath.Text = LaserProject.CadFile;

            int Old = JobInfo.TabControl2.SelectedIndex;

            JobInfo.TabControl2.SelectedIndex = 0;

            JobInfo.Type1.ClearControlValue();
            if (!String.IsNullOrEmpty(LaserProject.CadFile))
            {
                if (dkCommon.FileExists(GetModelPath() + LaserProject.CadFile))
                {
                    JobInfo.Type1.Cad1.Visible = true;
                    JobInfo.Type1.Cad1.Open(GetModelPath() + LaserProject.CadFile);
                    JobInfo.Type1.lblDxfPath.Text = LaserProject.CadFile;
                    JobInfo.Type1.Cad1.ZoomExtend();
                    JobInfo.Type1.Cad1.ZoomScale(0.8);

                    JobInfo.Type1.CheckLayerInfo();
                    JobInfo.Type1.DisplayLayerInfo();
                }
                else
                {
                    /*
                     * 등록된 도면을 불러들일수 없습니다. 에러 메세지를 도면에 출력
                     */
                    JobInfo.Type1.panCad.Text = "등록된 도면을 불러들일수 없습니다." + "\r\n\r\n"
                                        + "경로가 올바른지 확인이 필요합니다.";
                    JobInfo.Type1.Cad1.Visible = false;
                }
            }
            else
            {
                /*
                 * 도면이 등록되지 않았습니다. 에러 메세지 출력
                 */
                JobInfo.Type1.panCad.Text = "도면이 등록되지 않았습니다." + "\r\n\r\n"
                                    + "도면을 등록을 해주십시오.";
                JobInfo.Type1.Cad1.Visible = false;
            }

            JobInfo.Type1.edZOffset.Enabled = (TableNo != TableNo.Table0);

            JobInfo.Type1.edThickness.Value = LaserProject.Model1.Thickness;

            JobInfo.Type1.edZOffset.Value = LaserProject.Model1.ZOffset;
            JobInfo.Type1.edZOffset.BackColor = Color.White;
            JobInfo.Type1.edZOffset.Frame.FlatColor = Color.FromArgb(80, 160, 255);

            // Type1.viRepeatCount.AsInteger = LaserProject.Model1.RepeatCount;
            JobInfo.Type1.edManualShiftX.Value = LaserProject.Model1.ManualShiftX;
            JobInfo.Type1.edManualShiftY.Value = LaserProject.Model1.ManualShiftY;
            JobInfo.Type1.edLaserPower.Value = LaserProject.Model1.LaserPower;
            JobInfo.Type1.edPulsePitch.Value = LaserProject.Model1.PulsePitch;
            JobInfo.Type1.cbStartPoint.ItemIndex = (int)LaserProject.Model1.StartPoint;
            JobInfo.Type1.edGlassSizeX.Value = LaserProject.Model1.GlassSizeX;
            JobInfo.Type1.edGlassSizeY.Value = LaserProject.Model1.GlassSizeY;

            if (TableNo == TableNo.Table1)
            {
                JobInfo.Type1.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model1.ZOffset + JobInfo.Type1.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                JobInfo.Type1.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model1.ZOffset + JobInfo.Type1.edThickness.Value);
            }

            JobInfo.Type1.chkAlignUse.Checked = LaserProject.Model1.AlignUse;
            JobInfo.Type1.ledUseVision.LED.Value = LaserProject.Model1.AlignUse;
            JobInfo.Type1.AlignMethod = LaserProject.Model1.AlignMethod;
            
            JobInfo.Type1.btnUse.LED.Value = (LaserProject.MenuIndex == 0);
            
            JobInfo.Type1.EnableControl(true);
            JobInfo.Type1.GetWorkCenter();
            
            JobInfo.TabControl2.SelectedIndex = 1;
            JobInfo.Type2.ClearControlValue();

            if (!String.IsNullOrEmpty(GetModelPath() + LaserProject.CadFile))
            {
                if (dkCommon.FileExists(GetModelPath() + LaserProject.CadFile))
                {
                    JobInfo.Type2.Cad2.Visible = true;
                    JobInfo.Type2.Cad2.Open(GetModelPath() + LaserProject.CadFile);
                    JobInfo.Type2.lblDxfPath.Text = LaserProject.CadFile;
                    JobInfo.Type2.Cad2.ZoomExtend();
                    JobInfo.Type2.Cad2.ZoomScale(0.8);

                    JobInfo.Type2.CheckLayerInfo();
                    JobInfo.Type2.DisplayLayerInfo();
                }
                else
                {
                    /*
                     * 등록된 도면을 불러들일수 없습니다. 에러 메세지를 도면에 출력
                     */
                    JobInfo.Type2.panCad2.Text = "등록된 도면을 불러들일수 없습니다." + "\r\n\r\n"
                                        + "경로가 올바른지 확인이 필요합니다.";
                    JobInfo.Type2.Cad2.Visible = false;
                }
            }
            else
            {
                /*
                 * 도면이 등록되지 않았습니다. 에러 메세지 출력
                 */
                JobInfo.Type2.panCad2.Text = "도면이 등록되지 않았습니다." + "\r\n\r\n"
                                    + "도면을 등록을 해주십시오.";
                JobInfo.Type2.Cad2.Visible = false;
            }

            JobInfo.Type2.edXCount.AsInteger = LaserProject.Model2.XCount;
            JobInfo.Type2.edYCount.AsInteger = LaserProject.Model2.YCount;

            JobInfo.Type2.edGapX.Value = LaserProject.Model2.GapX;
            JobInfo.Type2.edGapY.Value = LaserProject.Model2.GapY;

            JobInfo.Type2.ledSortMethod1.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method1);
            JobInfo.Type2.ledSortMethod2.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method2);
            JobInfo.Type2.ledSortMethod3.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method3);
            JobInfo.Type2.ledSortMethod4.LED.Value = (LaserProject.Model2.SortMethod == SortMethod.Method4);

            JobInfo.Type2.edThickness.Value = LaserProject.Model2.Thickness;
            JobInfo.Type2.edZOffset.Value = LaserProject.Model2.ZOffset;

            if (TableNo == TableNo.Table1)
            {
                JobInfo.Type2.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model2.ZOffset + JobInfo.Type2.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                JobInfo.Type2.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model2.ZOffset + JobInfo.Type2.edThickness.Value);
            }

            JobInfo.Type2.edManualShiftX.Value = LaserProject.Model2.ManualShiftX;
            JobInfo.Type2.edManualShiftY.Value = LaserProject.Model2.ManualShiftY;
            JobInfo.Type2.edGlassSizeX.Value = LaserProject.Model2.GlassSizeX;
            JobInfo.Type2.edGlassSizeY.Value = LaserProject.Model2.GlassSizeY;
            JobInfo.Type2.edLaserPower.Value = LaserProject.Model2.LaserPower;
            JobInfo.Type2.edPulsePitch.Value = LaserProject.Model2.PulsePitch;
            JobInfo.Type2.cbStartPoint.ItemIndex = (int)LaserProject.Model2.StartPoint;

            JobInfo.Type2.chkAlignUse.Checked = LaserProject.Model2.AlignUse;
            JobInfo.Type2.ledUseVision.LED.Value = LaserProject.Model2.AlignUse;
            JobInfo.Type2.btnUse.LED.Value = (LaserProject.MenuIndex == 1);

            JobInfo.Type2.EnableControl(true);
            JobInfo.Type2.GetPageData();
            
            JobInfo.Type2.btnApply_Click(null, null);
            JobInfo.Type2.GetWorkCenter(0);
            
            JobInfo.TabControl2.SelectedIndex = 2;
            JobInfo.Type3.ClearControlValue();
            
            JobInfo.Type3.edLaserPower.Value = LaserProject.Model3.LaserPower;
            JobInfo.Type3.edPulsePitch.Value = LaserProject.Model3.PulsePitch;
            JobInfo.Type3.cbStartPoint.ItemIndex = (int)LaserProject.Model3.StartPoint;
            
            JobInfo.Type3.edThickness.Value = LaserProject.Model3.Thickness;
            JobInfo.Type3.edZOffset.Value = LaserProject.Model3.ZOffset;

            if (TableNo == TableNo.Table1)
            {
                JobInfo.Type3.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model3.ZOffset + JobInfo.Type3.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                JobInfo.Type3.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model3.ZOffset + JobInfo.Type3.edThickness.Value);
            }

            JobInfo.Type3.rdoCell.Checked = (LaserProject.Model3.SelectType == 0);
            JobInfo.Type3.rdoCircle.Checked = !(LaserProject.Model3.SelectType == 0);

            if (JobInfo.Type3.rdoCell.Checked)
            {
                JobInfo.Type3.UpdateCellTypeUI(true);
            }
            else
            if (JobInfo.Type3.rdoCircle.Checked)
            {
                JobInfo.Type3.UpdateCellTypeUI(false);
            }

            JobInfo.Type3.edXCount.AsInteger = LaserProject.Model3.XCount;
            JobInfo.Type3.edYCount.AsInteger = LaserProject.Model3.YCount;
            
            JobInfo.Type3.edGapX.Value = LaserProject.Model3.GapX;
            JobInfo.Type3.edGapY.Value = LaserProject.Model3.GapY;
            JobInfo.Type3.edCellWidth.Value = LaserProject.Model3.Width;
            JobInfo.Type3.edCellHeight.Value = LaserProject.Model3.Height;
            JobInfo.Type3.edCellRadius.Value = LaserProject.Model3.Radius;
            JobInfo.Type3.chkUseBreakLine.Checked = LaserProject.Model3.UseBreakingLine;
            JobInfo.Type3.chkBreakLineOutDir.Checked = LaserProject.Model3.LineDir;
            
            JobInfo.Type3.edBreakLineOffset.Value = LaserProject.Model3.BreakingLineOffset;
            JobInfo.Type3.edBreakLineLength.Value = LaserProject.Model3.BreakingLineLength;
            
            JobInfo.Type3.ledSortMethod1.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method1);
            JobInfo.Type3.ledSortMethod2.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method2);
            JobInfo.Type3.ledSortMethod3.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method3);
            JobInfo.Type3.ledSortMethod4.LED.Value = (LaserProject.Model3.SortMethod == SortMethod.Method4);
            
            JobInfo.Type3.edGlassSizeX.Value = LaserProject.Model3.GlassSizeX;
            JobInfo.Type3.edGlassSizeY.Value = LaserProject.Model3.GlassSizeY;
            JobInfo.Type3.btnUse.LED.Value = (LaserProject.MenuIndex == 2);

            JobInfo.Type3.EnableControl(true);
            JobInfo.Type3.CreateUserCell();
            JobInfo.Type3.CheckLayerInfo();
            JobInfo.Type3.btnApply_Click(null, null);
            JobInfo.Type3.GetWorkCenter(0);
            
            JobInfo.TabControl2.SelectedIndex = Old;
            
            JobInfo.TabControl2.SelectedIndex = LaserProject.MenuIndex;

            // CodeSite.ExitMethod("JobInfo.DisplayJobFile()");
        }
        #endregion

        #region public void SaveJobFile()
        public void SaveJobFile()
        {
            LaserProject.CadFile = JobInfo.Type1.lblDxfPath.Text;

            LaserProject.Model1.LaserPower = JobInfo.Type1.edLaserPower.Value;
            LaserProject.Model1.ZOffset = JobInfo.Type1.edZOffset.Value;

            if (TableNo == TableNo.Table1)
            {
                JobInfo.Type1.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model1.ZOffset + JobInfo.Type1.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                JobInfo.Type1.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model1.ZOffset + JobInfo.Type1.edThickness.Value);
            }

            LaserProject.Model1.PulsePitch = JobInfo.Type1.edPulsePitch.Value;
            LaserProject.Model1.Thickness = JobInfo.Type1.edThickness.Value;

            LaserProject.Model1.ManualShiftX = JobInfo.Type1.edManualShiftX.Value;
            LaserProject.Model1.ManualShiftY = JobInfo.Type1.edManualShiftY.Value;
            LaserProject.Model1.StartPoint = (StartPoint)JobInfo.Type1.cbStartPoint.ItemIndex;

            LaserProject.Model1.GlassSizeX = JobInfo.Type1.edGlassSizeX.Value;
            LaserProject.Model1.GlassSizeY = JobInfo.Type1.edGlassSizeY.Value;
            LaserProject.Model1.AlignUse = JobInfo.Type1.chkAlignUse.Checked;
            LaserProject.Model1.AlignMethod = JobInfo.Type1.AlignMethod;


            LaserProject.Model2.LaserPower = JobInfo.Type2.edLaserPower.Value;
            LaserProject.Model2.ZOffset = JobInfo.Type2.edZOffset.Value;
            LaserProject.Model2.PulsePitch = JobInfo.Type2.edPulsePitch.Value;
            LaserProject.Model2.Thickness = JobInfo.Type2.edThickness.Value;

            if (TableNo == TableNo.Table1)
            {
                JobInfo.Type2.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model2.ZOffset + JobInfo.Type2.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                JobInfo.Type2.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model2.ZOffset + JobInfo.Type2.edThickness.Value);
            }

            LaserProject.Model2.XCount = JobInfo.Type2.edXCount.AsInteger;
            LaserProject.Model2.YCount = JobInfo.Type2.edYCount.AsInteger;
            LaserProject.Model2.GapX = JobInfo.Type2.edGapX.Value;
            LaserProject.Model2.GapY = JobInfo.Type2.edGapY.Value;

            LaserProject.Model2.StartPoint = (StartPoint)JobInfo.Type2.cbStartPoint.ItemIndex;

            LaserProject.Model2.GlassSizeX = JobInfo.Type2.edGlassSizeX.Value;
            LaserProject.Model2.GlassSizeY = JobInfo.Type2.edGlassSizeY.Value;
            LaserProject.Model2.AlignUse = JobInfo.Type2.chkAlignUse.Checked;
            LaserProject.Model2.AlignMethod = JobInfo.Type2.AlignMethod;
            LaserProject.Model2.ManualShiftX = JobInfo.Type2.edManualShiftX.Value;
            LaserProject.Model2.ManualShiftY = JobInfo.Type2.edManualShiftY.Value;

            LaserProject.Model3.LaserPower = JobInfo.Type3.edLaserPower.Value;
            LaserProject.Model3.ZOffset = JobInfo.Type3.edZOffset.Value;
            LaserProject.Model3.PulsePitch = JobInfo.Type3.edPulsePitch.Value;
            LaserProject.Model3.Thickness = JobInfo.Type3.edThickness.Value;

            if (TableNo == TableNo.Table1)
            {
                JobInfo.Type3.viLaserFocus.AsDouble = Common.edTable1LaserZFocus.Value - (LaserProject.Model3.ZOffset + JobInfo.Type3.edThickness.Value);
            }
            else
            if (TableNo == TableNo.Table2)
            {
                JobInfo.Type3.viLaserFocus.AsDouble = Common.edTable2LaserZFocus.Value - (LaserProject.Model3.ZOffset + JobInfo.Type3.edThickness.Value);
            }

            LaserProject.Model3.StartPoint = (StartPoint)JobInfo.Type3.cbStartPoint.ItemIndex;

            LaserProject.Model3.XCount = JobInfo.Type3.edXCount.AsInteger;
            LaserProject.Model3.YCount = JobInfo.Type3.edYCount.AsInteger;
            LaserProject.Model3.GapX = JobInfo.Type3.edGapX.Value;
            LaserProject.Model3.GapY = JobInfo.Type3.edGapY.Value;
            LaserProject.Model3.GlassSizeX = JobInfo.Type3.edGlassSizeX.Value;
            LaserProject.Model3.GlassSizeY = JobInfo.Type3.edGlassSizeY.Value;
            LaserProject.Model3.Width = JobInfo.Type3.edCellWidth.Value;
            LaserProject.Model3.Height = JobInfo.Type3.edCellHeight.Value;

            /*
             * Cell은 Radius 없이 만들수 없게 되어있으므로
             * Radius는 0을 기입할수 없게..
             */
            if (JobInfo.Type3.edCellRadius.Value <= 0.0) JobInfo.Type3.edCellRadius.Value = 0.001;
            LaserProject.Model3.Radius = JobInfo.Type3.edCellRadius.Value;

            LaserProject.Model3.UseBreakingLine = JobInfo.Type3.chkUseBreakLine.Checked;
            LaserProject.Model3.LineDir = JobInfo.Type3.chkBreakLineOutDir.Checked;
            LaserProject.Model3.BreakingLineLength = JobInfo.Type3.edBreakLineLength.Value;
            LaserProject.Model3.BreakingLineOffset = JobInfo.Type3.edBreakLineOffset.Value;

            if (JobInfo.Type3.rdoCell.Checked)
            {
                LaserProject.Model3.SelectType = 0;
            }
            else
            if (JobInfo.Type3.rdoCircle.Checked)
            {
                LaserProject.Model3.SelectType = 1;
            }

            String szFileName = String.Empty;
            szFileName = String.Format("{0}[{1}][{2}][Table{3}].prj", GetModelPath(), GroupName, ModelName, (int)TableNo);

            LaserProject.DateTime = DateTime.Now;
            LaserProject.SaveToFile(szFileName);
        }
        #endregion

        public string GetModelPath()
        {
            return String.Format("{0}Model\\{1}\\{2}\\", dkCommon.AppPath(), GroupName, ModelName);
        }

        public bool isStartAble()
        {
            bool Result = true;

            if (JobInfo.TabControl2.SelectedIndex == 0)
            {
                if ((JobInfo.Type1.edLaserPower.Value <= 0) || (JobInfo.Type1.edLaserPower.Value > 100.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_LASER_POWER);
                    Result = false;
                }

                if ((JobInfo.Type1.edPulsePitch.Value <= 0) || (JobInfo.Type1.edPulsePitch.Value > 3.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_PULSE_PITCH);
                    Result = false;
                }

                if ((JobInfo.Type1.edManualShiftX.Value < -5.0) || (JobInfo.Type1.edManualShiftX.Value > 5.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SHIFT_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type1.edManualShiftY.Value < -5.0) || (JobInfo.Type1.edManualShiftY.Value > 5.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SHIFT_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type1.edThickness.Value <= 0.0) || (JobInfo.Type1.edThickness.Value >= 34.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_THICKNESS);
                    Result = false;
                }

                if ((JobInfo.Type1.edZOffset.Value < -1.0) || (JobInfo.Type1.edZOffset.Value >= 1.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_Z_POSITION);
                    Result = false;
                }

                if (LaserProject.Model1.UsedCount() == 0)
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_LAYER_USED);
                    Result = false;
                }
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                if ((JobInfo.Type2.edLaserPower.Value <= 0) || (JobInfo.Type2.edLaserPower.Value > 100.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_LASER_POWER);
                    Result = false;
                }

                if ((JobInfo.Type2.edPulsePitch.Value <= 0) || (JobInfo.Type2.edPulsePitch.Value > 3.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_PULSE_PITCH);
                    Result = false;
                }

                if ((JobInfo.Type2.edManualShiftX.Value < 0.0) || (JobInfo.Type2.edManualShiftX.Value > 5.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SHIFT_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type2.edManualShiftY.Value < 0.0) || (JobInfo.Type2.edManualShiftY.Value > 5.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SHIFT_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type2.edThickness.Value <= 0.0) || (JobInfo.Type2.edThickness.Value >= 34.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_THICKNESS);
                    Result = false;
                }

                if ((JobInfo.Type2.edZOffset.Value < -1.0) || (JobInfo.Type2.edZOffset.Value >= 1.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_Z_POSITION);
                    Result = false;
                }

                if ((JobInfo.Type2.edGapX.Value < -50) || (JobInfo.Type2.edGapX.Value > 50))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_GAP_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type2.edGapY.Value < -50) || (JobInfo.Type2.edGapY.Value > 50))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_GAP_VALUE);
                    Result = false;
                }

                if (JobInfo.Type2.PageList.SelectedCount() == 0)
                {
                   Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SELECTION);
                    Result = false;
                }

                if (LaserProject.Model2.UsedCount() == 0)
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_LAYER_USED);
                    Result = false;
                }
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 2)
            {
                if ((JobInfo.Type3.edLaserPower.Value <= 0) || (JobInfo.Type3.edLaserPower.Value > 100.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_LASER_POWER);
                    Result = false;
                }

                if ((JobInfo.Type3.edPulsePitch.Value <= 0) || (JobInfo.Type3.edPulsePitch.Value > 3.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_PULSE_PITCH);
                    Result = false;
                }

                if ((JobInfo.Type3.edThickness.Value <= 0.0) || (JobInfo.Type3.edThickness.Value >= 34.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_THICKNESS);
                    Result = false;
                }

                if ((JobInfo.Type3.edZOffset.Value < -1.0) || (JobInfo.Type3.edZOffset.Value >= 1.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_Z_POSITION);
                    Result = false;
                }

                if ((JobInfo.Type3.edXCount.AsInteger <= 0) || (JobInfo.Type3.edXCount.AsInteger >= 20))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_ARRAY_COUNT);
                    Result = false;
                }

                if ((JobInfo.Type3.edYCount.AsInteger <= 0) || (JobInfo.Type3.edYCount.AsInteger >= 20))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_ARRAY_COUNT);
                    Result = false;
                }

                if ((JobInfo.Type3.edGapX.Value < -50.0) || (JobInfo.Type3.edGapX.Value > 50.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_GAP_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type3.edGapY.Value < -50.0) || (JobInfo.Type3.edGapY.Value > 50.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_GAP_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type3.edCellRadius.Value < 0.0) || (JobInfo.Type3.edCellRadius.Value > 10.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_RADIUS_VALUE);
                    Result = false;
                }

                if (JobInfo.Type3.edCellRadius.Value == 0.0) JobInfo.Type3.edCellRadius.Value = 0.001;

                if ((JobInfo.Type3.edCellWidth.Value <= 0.0) || (JobInfo.Type3.edCellWidth.Value > 300.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SIZE_VALUE);
                    Result = false;
                }

                if ((JobInfo.Type3.edCellHeight.Value <= 0.0) || (JobInfo.Type3.edCellHeight.Value > 300.0))
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SIZE_VALUE);
                    Result = false;
                }

                if (JobInfo.Type3.PageList.SelectedCount() == 0)
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_SELECTION);
                    Result = false;
                }

                if (LaserProject.Model3.UsedCount() == 0)
                {
                    Auto.AddError(Const.ERROR_JOBFILE_INVALID_PARAMETER_LAYER_USED);
                    Result = false;
                }
            };

            return Result;
        }


        public void GetPageCenter(int AIndex)
        {
            if (JobInfo.TabControl2.SelectedIndex == 0)
            {
                JobInfo.Type1.GetWorkCenter();
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                JobInfo.Type2.GetWorkCenter(AIndex);
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 2)
            {
                JobInfo.Type3.GetWorkCenter(AIndex);

            }
        }

        public void GetPageInfo(int AIndex)
        {
            switch (JobInfo.TabControl2.SelectedIndex)
            {
                case 0:
                    Align1Pos.x = JobInfo.Type1.WorkCenter.x + (JobInfo.Type1.viAlign1PosX.AsDouble - JobInfo.Type1.CenterPos.x);
                    Align1Pos.y = JobInfo.Type1.WorkCenter.y - (JobInfo.Type1.viAlign1PosY.AsDouble - JobInfo.Type1.CenterPos.y);

                    Align2Pos.x = JobInfo.Type1.WorkCenter.x + (JobInfo.Type1.viAlign2PosX.AsDouble - JobInfo.Type1.CenterPos.x);
                    Align2Pos.y = JobInfo.Type1.WorkCenter.y - (JobInfo.Type1.viAlign2PosY.AsDouble - JobInfo.Type1.CenterPos.y);

                    Align3Pos.x = JobInfo.Type1.WorkCenter.x + (JobInfo.Type1.viAlign3PosX.AsDouble - JobInfo.Type1.CenterPos.x);
                    Align3Pos.y = JobInfo.Type1.WorkCenter.y - (JobInfo.Type1.viAlign3PosY.AsDouble - JobInfo.Type1.CenterPos.y);

                    Align4Pos.x = JobInfo.Type1.WorkCenter.x + (JobInfo.Type1.viAlign4PosX.AsDouble - JobInfo.Type1.CenterPos.x);
                    Align4Pos.y = JobInfo.Type1.WorkCenter.y - (JobInfo.Type1.viAlign4PosY.AsDouble - JobInfo.Type1.CenterPos.y);

                    CenterPos = JobInfo.Type1.WorkCenter;
                    break;

                case 1:
                    Align1Pos.x = JobInfo.Type2.WorkCenter.x + (JobInfo.Type2.viAlign1PosX.AsDouble - JobInfo.Type2.CenterPos.x);
                    Align1Pos.y = JobInfo.Type2.WorkCenter.y - (JobInfo.Type2.viAlign1PosY.AsDouble - JobInfo.Type2.CenterPos.y);

                    Align2Pos.x = JobInfo.Type2.WorkCenter.x + (JobInfo.Type2.viAlign2PosX.AsDouble - JobInfo.Type2.CenterPos.x);
                    Align2Pos.y = JobInfo.Type2.WorkCenter.y - (JobInfo.Type2.viAlign2PosY.AsDouble - JobInfo.Type2.CenterPos.y);

                    Align3Pos.x = JobInfo.Type2.WorkCenter.x + (JobInfo.Type2.viAlign3PosX.AsDouble - JobInfo.Type2.CenterPos.x);
                    Align3Pos.y = JobInfo.Type2.WorkCenter.y - (JobInfo.Type2.viAlign3PosY.AsDouble - JobInfo.Type2.CenterPos.y);

                    Align4Pos.x = JobInfo.Type2.WorkCenter.x + (JobInfo.Type2.viAlign4PosX.AsDouble - JobInfo.Type2.CenterPos.x);
                    Align4Pos.y = JobInfo.Type2.WorkCenter.y - (JobInfo.Type2.viAlign4PosY.AsDouble - JobInfo.Type2.CenterPos.y);

                    CenterPos = JobInfo.Type2.WorkCenter;
                    break;

                case 2:
                    break;
            }
        }

        public int GetPageCount()
        {
            int Result = 1;

            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                Result = JobInfo.Type2.PageList.SelectedCount();
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 2)
            {
                Result = JobInfo.Type3.PageList.SelectedCount();
            }

            return Result;
        }

        public int GetFirstPage()
        {
            int Result = (0);

            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                Result = JobInfo.Type2.PageList.GetFirstPage();
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 2)
            {
                Result = JobInfo.Type3.PageList.GetFirstPage();
            }

            return Result;
        }

        public int GetNextPage(int AIndex)
        {
            int Result = (-1);

            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                Result = JobInfo.Type2.PageList.GetNextPage(AIndex);
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 2)
            {
                Result = JobInfo.Type3.PageList.GetNextPage(AIndex);
            }

            return Result;
        }

        public int GetTotalPageCount()
        {
            int Result = 1;

            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                Result = JobInfo.Type2.PageList.Count;
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 2)
            {
                Result = JobInfo.Type3.PageList.Count;
            }

            return Result;
        }

        public LayerCollection GetLayers()
        {
            if (JobInfo.TabControl2.SelectedIndex == 0)
            {
                return LaserProject.Model1.Layers;
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                return LaserProject.Model2.Layers;
            }
            else
            {
                return LaserProject.Model3.Layers;
            }
        }

        public int GetLayerIndex(int AIndex)
        {
            int Result = (-1);

            if (Layers != null)
            {
                for (int nIndex = AIndex; nIndex < Layers.Count; nIndex++)
                {
                    if (Layers[nIndex].Used && Layers[nIndex].Count > 0)
                    {
                        Result = nIndex;
                        break;
                    }
                }
            }

            return Result;
        }

        public void GetReadyPos(int APageIndex = 0)
        {
            switch (JobInfo.TabControl2.SelectedIndex)
            {
                case 0:
                    JobInfo.Type1.GetReadyPos();
                    ReadyPos = JobInfo.Type1.ReadyPos;
                    logger.SendMsg(String.Format("        Type1.ReadyPos = {0}", JobInfo.Type1.ReadyPos.ToString()));
                    break;

                case 1:
                    JobInfo.Type2.GetReadyPos();
                    ReadyPos = JobInfo.Type2.ReadyPos;
                    logger.SendMsg(String.Format("        Type2.ReadyPos = {0}", JobInfo.Type2.ReadyPos.ToString()));
                    break;

                case 2:
                    JobInfo.Type3.GetReadyPos();
                    ReadyPos = JobInfo.Type3.ReadyPos;
                    logger.SendMsg(String.Format("        Type3.ReadyPos = {0}", JobInfo.Type3.ReadyPos.ToString()));
                    break;        
            }
        }

        public double GetZPosition()
        {
            double Result = 0.0;

            if (TableNo == TableNo.Table1)
            {
                switch (JobInfo.TabControl2.SelectedIndex)
                {
                    case 0:
                        Result = Global.chTable1LaserZFocus.AsDouble - (JobInfo.Type1.edThickness.Value + JobInfo.Type1.edZOffset.Value);
                        break;

                    case 1:
                        Result = Global.chTable1LaserZFocus.AsDouble - (JobInfo.Type2.edThickness.Value + JobInfo.Type2.edZOffset.Value);
                        break;

                    case 2:
                        Result = Global.chTable1LaserZFocus.AsDouble - (JobInfo.Type3.edThickness.Value + JobInfo.Type3.edZOffset.Value);
                        break;
                }
            }
            else
            if (TableNo == TableNo.Table2)
            {
                switch (JobInfo.TabControl2.SelectedIndex)
                {
                    case 0:
                        Result = Global.chTable2LaserZFocus.AsDouble - (JobInfo.Type1.edThickness.Value + JobInfo.Type1.edZOffset.Value);
                        break;

                    case 1:
                        Result = Global.chTable2LaserZFocus.AsDouble - (JobInfo.Type2.edThickness.Value + JobInfo.Type2.edZOffset.Value);
                        break;

                    case 2:
                        Result = Global.chTable2LaserZFocus.AsDouble - (JobInfo.Type3.edThickness.Value + JobInfo.Type3.edZOffset.Value);
                        break;
                }
            }

            return Result;
        }

        public void MakeMotionFile(double Angle, DoublePoint AlignShift, bool LaserRun)
        {
            switch (JobInfo.TabControl2.SelectedIndex)
            {
                case 0:
                    JobInfo.Type1.MakeMotionFile(TableNo, Angle, 
                                                    LaserProject.Model1.ManualShiftX + AlignShift.x, 
                                                        LaserProject.Model1.ManualShiftY - AlignShift.y, LaserRun);
                    break;

                case 1:
                    JobInfo.Type2.MakeMotionFile(TableNo, PageIndex, Angle,
                                                    LaserProject.Model2.ManualShiftX + AlignShift.x,
                                                        LaserProject.Model2.ManualShiftY - AlignShift.y, LaserRun);
                    break;

                case 2:
                    JobInfo.Type3.MakeMotionFile(TableNo, PageIndex, 0, 0, LaserRun);
                    break;
            }
        }

        public int Step
        {
            get
            {
                return mStep;
            }

            set
            {
                if (mStep != value)
                {
                    mStep = value;

                    if (Global.chShowStep)
                    {
                        String szStr;

                        if (value == Const.CASE_DONE)
                        {
                            szStr = String.Format("    {0}.Step = CASE_DONE", TableNo);

                        }
                        else
                        if (value == Const.CASE_ERROR)
                        {
                            szStr = String.Format("    {0}.Step = CASE_ERROR", TableNo);

                        }
                        else
                        if (value == Const.CASE_ABORT)
                        {
                            szStr = String.Format("    {0}.Step = CASE_ABORT", TableNo);

                        }
                        else
                        {
                            szStr = String.Format("    {0}.Step = {1}", TableNo, mStep);
                        }

                        logger.SendMsg(szStr);
                    }
                }
            }
        }

        public bool Stop;
        public bool UseVision
        {
            get
            {
                if (JobInfo.TabControl2.SelectedIndex == 0)
                {
                    return JobInfo.Type1.chkAlignUse.Checked;
                }
                else
                if (JobInfo.TabControl2.SelectedIndex == 1)
                {
                    return JobInfo.Type2.chkAlignUse.Checked;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UseIndividualAlignMark()
        {
            if (JobInfo.TabControl2.SelectedIndex == 0)
            {
                return JobInfo.Type1.chkUseIndividualAlign.Checked;
            }
            else
            if (JobInfo.TabControl2.SelectedIndex == 1)
            {
                return JobInfo.Type1.chkUseIndividualAlign.Checked;
            }
            else
            {
                return false;
            }
        }

        public AlignMethod AlignMethod
        {
            get 
            {
                if (JobInfo.TabControl2.SelectedIndex == 0)
                {
                    return JobInfo.Type1.AlignMethod;
                }
                else
                if (JobInfo.TabControl2.SelectedIndex == 1)
                {
                    return JobInfo.Type1.AlignMethod;
                }
                else
                {
                    return AlignMethod.Align2P_1_2;
                }
            }
        }

        private DoublePoint mAlign1Pos = new DoublePoint();
        public DoublePoint Align1Pos
        {
            get { return mAlign1Pos; }
            set { mAlign1Pos = value; }
        }

        private DoublePoint mAlign2Pos = new DoublePoint();
        public DoublePoint Align2Pos
        {
            get { return mAlign2Pos; }
            set { mAlign2Pos = value; }
        }

        private DoublePoint mAlign3Pos = new DoublePoint();
        public DoublePoint Align3Pos
        {
            get { return mAlign3Pos; }
            set { mAlign3Pos = value; }
        }

        private DoublePoint mAlign4Pos = new DoublePoint();
        public DoublePoint Align4Pos
        {
            get { return mAlign4Pos; }
            set { mAlign4Pos = value; }
        }

        #region public DoublePoint ReadyPos
        private DoublePoint mReadyPos = new DoublePoint();
        public DoublePoint ReadyPos
        {
            get { return mReadyPos; }
            set { mReadyPos = value; }
        }
        #endregion

        #region public DoublePoint LoadPos
        private DoublePoint mLoadPos = new DoublePoint();
        public DoublePoint LoadPos
        {
            get { return mLoadPos; }
            set { mLoadPos = value; }
        }
        #endregion

        #region public DoublePoint CenterPos
        private DoublePoint mCenterPos = new DoublePoint();
        public DoublePoint CenterPos
        {
            get { return mCenterPos; }
            set { mCenterPos = value; }
        }
        #endregion

        #region public DoublePoint AlignShift
        private DoublePoint mAlignShift = new DoublePoint();
        public DoublePoint AlignShift
        {
            get { return mAlignShift; }
            set { mAlignShift = value; }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (TableNo == TableNo.Table1)
            {
                Auto.ledTable1JobFileLoad.LED.Value = false;
            }
            else
            if (TableNo == TableNo.Table2)
            {
                Auto.ledTable2JobFileLoad.LED.Value = false;
            };

            JobInfo.Type1.EnableControl(false);
            JobInfo.Type2.EnableControl(false);
            JobInfo.Type3.EnableControl(false);

            JobInfo.Type1.ClearControlValue();
            JobInfo.Type2.ClearControlValue();
            JobInfo.Type3.ClearControlValue();
        }

        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnOpenJobFile.Text = Global.iniEng.ReadString("panTable1", "btnOpenJobFile.Text", "Ready");
            btnClose.Text = Global.iniEng.ReadString("panTable1", "btnClose.Text", "Start");
        }
        public void ChangeLanguageKorea()
        {
            btnOpenJobFile.Text = Global.GetIniLanguageValue(Global.iniKor, "panTable1", "btnOpenJobFile.Text"); 
            btnClose.Text = Global.GetIniLanguageValue(Global.iniKor, "panTable1", "btnClose.Text");
        }
        public void ChangeLanguageVietnam()
        {
            btnOpenJobFile.Text = Global.GetIniLanguageValue(Global.iniVie, "panTable1", "btnOpenJobFile.Text");
            btnClose.Text = Global.GetIniLanguageValue(Global.iniVie, "panTable1", "btnClose.Text");
        }
        #endregion

        public void EnableControl(bool enable)
        {
    //        btnOpenJobFile.Enabled = enable;
    //        btnClose.Enabled = enable;

            // JobInfo.TabControl2.Enabled = enable;
            JobInfo.Type1.EnableControl(enable);
            JobInfo.Type2.EnableControl(enable);
            JobInfo.Type3.EnableControl(enable);
        }

        #region public void ClearAllControlValue()
        public void ClearAllControlValue()
        {
            // Type1
            JobInfo.Type1.lblDxfPath.Text = "";

            JobInfo.Type1.edLaserPower.Value = 0.0;
            JobInfo.Type1.edZOffset.Value = 0.0;
            
            JobInfo.Type1.edManualShiftX.Value = 0.0;
            JobInfo.Type1.edManualShiftY.Value = 0.0;
            
            JobInfo.Type1.edPulsePitch.Value = 0.000;
            
            JobInfo.Type1.edGlassSizeX.Value = 0.0;
            JobInfo.Type1.edGlassSizeY.Value = 0.0;
            
            // Type2
            JobInfo.Type2.edLaserPower.Value = 0.0;
            JobInfo.Type2.edZOffset.Value = 0.0;
            JobInfo.Type2.edPulsePitch.Value = 0.000;
            JobInfo.Type2.edYCount.AsInteger = 0;
            JobInfo.Type2.edXCount.AsInteger = 0;
            JobInfo.Type2.edGapX.Value = 0.0;
            JobInfo.Type2.edGapY.Value = 0.0;
            
            JobInfo.Type3.edLaserPower.Value = 0.0;
            JobInfo.Type3.edZOffset.Value = 0.0;
            JobInfo.Type3.edPulsePitch.Value = 0.000;
        }

        #endregion


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
    }
}

