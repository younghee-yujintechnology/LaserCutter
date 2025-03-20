

/*

_VERSION1, _PMAC, _COHERENT, _ADV, _POWERMETER, _LIGHT, _VISION, _MVS

_VERSION2, _PMAC, _CARBIDE, _ADV, _POWERMETER, _LIGHT, _VISION, _MVS

 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using DaekhonSystem;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panAuto : UserControl
    {
        CodeSiteLogger logger;

        private const int X_AXIS_NO = 1;
        private const int Y1_AXIS_NO = 2;
        private const int Y2_AXIS_NO = 3;
        private const int Z_AXIS_NO = 5;

        private Command mCommand;
        private Command mOldCommand;

        private Stopwatch stopwatch;

        private frmMotionFile frmMotionFile = new frmMotionFile();

        private bool btnStopPressed = false;
        private uint MotorMoveStartTimeOut = 300;

        public frmChannelSpy frmChannelSpy;
        public frmVision frmVision;

        public frmRestart frmRestart;

        public frmMVS frmMVS;
        public frmMain frmMain;

        public panSideMenu SideMenu;
        public panConfigCommon Common;

        public panVision Vision1;
        public panVision Vision2;

        public int mStep = 0;
        public int LastStep = 0;
        public int ErrorCode = 0;

        public int LastReadyStep = 0;
        public int ErrorReadyCode = 0;
#if _PMAC
        uint MotorMoveTimeOut = 15000;
#endif
        uint MotorStopTime = 300;

        TimeCounter Counter = new TimeCounter();

        public panTable Table1;
        public panTable Table2;

        int mTabIndex;
        int iiii = 0;
        public panAuto()
        {
            CodeSite.SendMsg("panAuto.Create()");

            InitializeComponent();

            SetCodeSitelogger();

            staticInstance = this;

            ledADV.LED.Value = true;
            ledLaser.LED.Value = true;
            ledMotion.LED.Value = true;
            ledVision.LED.Value = true;

#if !_ADV
            ledADV.LED.OnColor = Color.Black;
            ledADV.LED.OffColor = Color.Black;
            ledADV.LED.Value = false;
            ledADV.ForeColor = Color.White;
#endif

#if (!_CARBIDE) && (!_COHERENT)
            ledLaser.LED.OnColor = Color.Black;
            ledLaser.LED.OffColor = Color.Black;
            ledLaser.LED.Value = false;
            ledLaser.ForeColor = Color.White;
#endif

#if !_PMAC
            ledMotion.LED.OnColor = Color.Black;
            ledMotion.LED.OffColor = Color.Black;
            ledMotion.LED.Value = false;
            ledMotion.ForeColor = Color.White;
#endif

#if !_VISION
            ledVision.LED.OnColor = Color.Black;
            ledVision.LED.OffColor = Color.Black;
            ledVision.LED.Value = false;
            ledVision.ForeColor = Color.White;
#endif

#if !_LIGHT
            ledLight.LED.OnColor = Color.Black;
            ledLight.LED.OffColor = Color.Black;
            ledLight.LED.Value = false;
            ledLight.ForeColor = Color.White;
#endif

#if !_MVS
            ledMVS.LED.OnColor = Color.Black;
            ledMVS.LED.OffColor = Color.Black;
            ledMVS.LED.Value = false;
            ledMVS.ForeColor = Color.White;
#endif

#if _VERSION1
            LabelLaserStatus.Visible = false;
            lblLaserStatus.Visible = false;
            lblEmissionStatus.Visible = false;

            LabelLaserSet.Visible = false;
            lblLaserSet.Visible = false;
#endif
            bool withVision = true;

            Table1 = new panTable(withVision);
            Table1.Auto = this;
            Table1.TableNo = TableNo.Table1;
            Table1.Location = new Point(50, 0);
            Table1.EnableControl(false);
            tabTable1.Controls.Add(Table1);

            Table2 = new panTable(withVision);
            Table2.Auto = this;
            Table2.TableNo = TableNo.Table2;
            Table2.Location = new Point(50, 0);
            Table2.EnableControl(false);
            tabTable2.Controls.Add(Table2);

            Vision1 = Table1.Vision;
            Vision2 = Table2.Vision;

            String szFileName = String.Format("{0}ErrorList.txt", dkCommon.AppPath());
            if (dkCommon.FileExists(szFileName))
            {
                errorProcessor1.LoadFromFile(szFileName);
                errorProcessor1.Monitor = true;
            }

            TabControl1.ItemSize = new Size(610, 36);

            InitListViewControl();
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

        void InitListViewControl()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("ID", 0, HorizontalAlignment.Center);
            listView1.Columns.Add("No", 56, HorizontalAlignment.Center);
            listView1.Columns.Add("Message", 560, HorizontalAlignment.Left);
        }

        void AddListViewItem(int id, int no, string action)
        {
            ListViewItem item = new ListViewItem(id.ToString());  // 첫 번째 열: ID
            item.SubItems.Add(no.ToString());                     // 두 번째 열: No
            item.SubItems.Add(action);                            // 세 번째 열: Action

            listView1.Items.Add(item);
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

        #region protected override void WndProc(ref Message m)
        [StructLayout(LayoutKind.Sequential)]
        public struct CopyDataStruct
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == PowerPMac.WM_MESSAGE_DOWNLOAD)
            {
                var cds = (CopyDataStruct)Marshal.PtrToStructure(m.LParam, typeof(CopyDataStruct));

                switch (cds.dwData.ToInt32())
                {
                    case PowerPMac.DT_Progress:

                        if (cds.cbData == 0)
                        {
                            if (iiii == 0)
                            {
                            }
                        }
                        else
                        if ((cds.cbData > 0) && (cds.cbData < 100))
                        {
                        }
                        else
                        if (cds.cbData == 100)
                        {
                            iiii = iiii + 1;
                            if (iiii > 1)
                            {
                            }
                        }

                        break;

                    case PowerPMac.DT_StringA:
                        string s = Marshal.PtrToStringAnsi(cds.lpData);
                        s = dkCommon.RemoveCRLF(s);
                        frmMotionFile.Memo1.AppendText(s + Environment.NewLine);
                        logger.SendMsg("        " + s + Environment.NewLine);
                        break;

                    case PowerPMac.DT_StringW:
                        // Handle wide string case if needed
                        break;
                }

                frmMotionFile.MessageQueue.Add(m.WParam.ToInt32());
            }
            base.WndProc(ref m);
        }
        #endregion

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

        public Command Command
        {
            get
            {
                return mCommand;
            }

            set
            {
                if (mCommand != value)
                {
                    mCommand = value;
                    logger.AddSeparator();
                    logger.SendMsg(String.Format("Command = {0}", mCommand.ToString()));
                }
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
                            szStr = String.Format("    Auto.Step = CASE_DONE");

                        }
                        else
                        if (value == Const.CASE_ERROR)
                        {
                            szStr = String.Format("    Auto.Step = CASE_ERROR");

                        }
                        else
                        if (value == Const.CASE_ABORT)
                        {
                            szStr = String.Format("    Auto.Step = CASE_ABORT");

                        }
                        else
                        {
                            szStr = String.Format("    Auto.Step = {0}", mStep);
                        }

                        logger.SendMsg(szStr);
                    }
                }
            }
        }

        private void Thread_OnExecute(object sender, EventArgs e)
        {
            btnTable1New.LED.Value = Global.Table1New;
            btnTable2New.LED.Value = Global.Table2New;

            ledTable1CycleStop.LED.Value = Global.diTable1CycleStop;
            ledTable2CycleStop.LED.Value = Global.diTable2CycleStop;

            ledTable1Stop.LED.Value = Global.diTable1Stop;
            ledTable2Stop.LED.Value = Global.diTable2Stop;

            ledTable1AreaSensor.LED.Value = Global.ciTable1AreaSensor.AsBoolean;
            ledTable2AreaSensor.LED.Value = Global.ciTable2AreaSensor.AsBoolean;

            ledCoord1ProgRunning.LED.Value = Global.chCoord1Running;

            ShowTableStep();

            Global.isAutoRun = (Command == Command.Start);
            switch (Command)
            {
                case Command.AutoReady:
                    {
                        DoAutoReady();
                        break;
                    }

                case Command.Start:
                    {
                        DoStart();
                        break;
                    }

                case Command.Stop:
                    {
                        DoStop();
                        break;
                    }
            }

            CheckError();
        }

        #region Error 출력
        public void CheckError()
        {
            if (!(ledTable1JobFileLoad.LED.Value || ledTable2JobFileLoad.LED.Value))
            {
                errorProcessor1.AddError(Const.ERROR_JOBFILE_LOAD);
            }
            else
            {
                errorProcessor1.ReleaseError(Const.ERROR_JOBFILE_LOAD);
            }

            if (Command != Command.Start)
            {
                errorProcessor1.AddError(Const.NOW_START_READY);
            }
        }
        #endregion

        public void ShowTableStep()
        {
            if (Table1.Step == Const.CASE_ABORT)
            {
                lblTable1Step.Text = String.Format("{0}", "ABORT");
            }
            else
            if (Table1.Step == Const.CASE_ERROR)
            {
                lblTable1Step.Text = String.Format("{0}", "ERROR");
            }
            else
            if (Table1.Step == Const.CASE_DONE)
            {
                lblTable1Step.Text = String.Format("{0}", "DONE");
            }
            else
            {
                lblTable1Step.Text = String.Format("{0}", Table1.Step);
            }

            if (Table2.Step == Const.CASE_ABORT)
            {
                lblTable2Step.Text = String.Format("{0}", "ABORT");
            }
            else
            if (Table2.Step == Const.CASE_ERROR)
            {
                lblTable2Step.Text = String.Format("{0}", "ERROR");
            }
            else
            if (Table2.Step == Const.CASE_DONE)
            {
                lblTable2Step.Text = String.Format("{0}", "DONE");
            }
            else
            {
                lblTable2Step.Text = String.Format("{0}", Table2.Step);
            }
        }

        private void DoAutoReady()
        {
            switch (Step)
            {
                case 0:

#if _VERSION1
                    Pmac.XSetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
                    Pmac.Y1SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
                    Pmac.Y2SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
#elif _VERSION2
                    Pmac.XSetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
                    Pmac.Y1SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
                    Pmac.Y2SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
#endif
                    Pmac.ZSetSpeed(Global.chAutoRunSpeedZ.AsDouble * 10);

                    btnAutoReady.LED.Value = false;
#if _PMAC
                    Step = 10;
#else
                    Step = Const.CASE_DONE;
 #endif
                    break;

                case 10:
                    if (btnLaserRun.LED.Value)
                    {
                        if (frmMain.Manual.Laser.btnConnect.LED.Value)
                        {
                            frmMain.Manual.Laser.btnShutterOpen_Click(null, null);

                            Counter.Start();
                            Step = 11;
                        }
                        else
                        {
                            AddError(Const.ERROR_LASER_POWER_OFF);
                            Step = Const.CASE_ERROR;
                        }
                    }
                    else
                    {
                        frmMain.Manual.Laser.btnShutterClose_Click(null, null);
                        Pmac.QueryCommand("doBeamShutterOpen=false");

                        Step = 30;
                    }
                    break;

                case 11:
                    if (frmMain.Manual.Laser.btnShutterOpen.LED.Value)
                    {
                        Counter.Stop();

                        Step = 20;
                    } 
                    else
                    if (Counter.isTimeOver(1000 * 5))
                    {
                        Counter.Stop();

                        AddError(Const.ERROR_LASER_INNER_SHUTTER_OPEN_ERROR);

                        Step = Const.CASE_ERROR;
                    }
                    break;

                case 20:
                    Pmac.QueryCommand("doBeamShutterOpen=true");

                    Step = 30;
                    break;

                case 30:
                    if (!Pmac.XInTargetPos(Table1.LoadPos.x))
                    {
                        Pmac.XMoveAbs(Table1.LoadPos.x);
                    }

                    if (!Pmac.Y1InTargetPos(Table1.LoadPos.y))
                    {
                        Pmac.QueryCommand("Table1Unload=true");
                    }

                    if (!Pmac.Y2InTargetPos(Table2.LoadPos.y))
                    {
                        Pmac.QueryCommand("Table2Unload=true");
                    }

                    Step = Const.CASE_DONE;
                    break;

                case Const.CASE_DONE:
                    if (ledTable1JobFileLoad.LED.Value) Pmac.QueryCommand("Table1Ready=true");
                    if (ledTable2JobFileLoad.LED.Value) Pmac.QueryCommand("Table2Ready=true");

                    btnAutoReady.LED.Value = true;

                    Step = 0;
                    Command = Command.Ready;
                    break;

                case Const.CASE_ERROR:
                    Step = 0;
                    Command = Command.Ready;
                    break;

            }
        }

        private void DoStart()
        {
            Pmac.QueryCommand(String.Format("Table1Step = {0}", Table1.Step));
            Pmac.QueryCommand(String.Format("Table2Step = {0}", Table2.Step));

            if ((Global.Table1New || (Table1.Step > 0)) && (Table2.Step <= 0))
            {
                if (ledTable1JobFileLoad.LED.Value)
                {
                    errorProcessor1.ReleaseError(Const.NOW_START_READY);
                    errorProcessor1.AddError(Const.NOW_TABLE1_RUNNING);
                    errorProcessor1.ReleaseError(Const.NOW_TABLE2_RUNNING);

                    DoTable1Start();
                }
                else
                {
                    errorProcessor1.AddError(Const.ERROR_TABLE1_JOBFILE_LOAD);
                }
            }
            else
            if ((Global.Table2New || (Table2.Step > 0)) && (Table1.Step <= 0))
            {
                if (ledTable2JobFileLoad.LED.Value)
                {
                    errorProcessor1.ReleaseError(Const.NOW_START_READY);
                    errorProcessor1.ReleaseError(Const.NOW_TABLE1_RUNNING);
                    errorProcessor1.AddError(Const.NOW_TABLE2_RUNNING);

                    DoTable2Start();
                }
                else
                {
                    errorProcessor1.AddError(Const.ERROR_TABLE2_JOBFILE_LOAD);
                }
            }
            else
            {
                errorProcessor1.ReleaseError(Const.NOW_START_READY);
                errorProcessor1.ReleaseError(Const.NOW_TABLE1_RUNNING);
                errorProcessor1.ReleaseError(Const.NOW_TABLE2_RUNNING);
                errorProcessor1.AddError(Const.NOW_RUNNING);
            }
        }

        #region private void DoTable1Start()
        private void DoTable1Start()
        {
            lblPageIndex.Text = String.Format("{0}", Table1.PageIndex);
            lblPageCount.Text = String.Format("{0}", Table1.PageCount);

            if (Pmac.CommError) return;

            if ((Table1.Stop) && (Table1.Step < Const.CASE_DONE))
            {
                if ((Table1.Step > 1120) && (Table1.Step <= 1180))
                {
                    int r = 0;
                    Pmac.QueryCommand("M0", out r);
                    if (r == 0)
                    {
                        Pmac.QueryCommand("doLaserTriggerOn=false");
                        Table1.Step = Const.CASE_ABORT;
                    }
                }
                else
                if ((Table1.Step > 1180) && (Table1.Step <= 1220))
                {
                    if (ledCoord1ProgRunning.LED.Value)
                    {
                        int r = 0;
                        Pmac.QueryCommand("M0", out r);
                        if (r == 0)
                        {
                            Pmac.QueryCommand("&1a");

                            Pmac.QueryCommand("doLaserTriggerOn=false");
                            Table1.Step = Const.CASE_ABORT;
                        }
                    }
                    else
                    {
                        Pmac.QueryCommand("doLaserTriggerOn=false");
                        Table1.Step = Const.CASE_ABORT;
                    }
                }
                else
                {
                    Pmac.QueryCommand("doLaserTriggerOn=false");
                    Table1.Step = Const.CASE_ABORT;
                }
            }

            switch (Table1.Step)
            {
                // @@ 
                case 0: // Vision을 사용하지 않으면 1100으로 점프
                    Table1.Step = 1;
                    break;

                case 1:
                    viTable1InputCount.AsInteger = viTable1InputCount.AsInteger + 1;

                    stopwatch = Stopwatch.StartNew();

                    Global.isChangeAble = true;
                    TabControl1.SelectedIndex = 0;
                    Global.isChangeAble = false;

                    Table1.Stop = false;
                    btnStopPressed = false;

                    logger.SendMsg("    ");
                    logger.SendMsg("=======================================================================");
                    logger.SendMsg("    Table1.New");

                    logger.SendMsg(String.Format("    JobFile = {0}/{1}", Table1.GroupName, Table1.ModelName));
                    if (Table1.JobInfo.TabControl2.SelectedIndex == 0)
                    {
                        logger.SendMsg("    Process = DXF");
                    }
                    else
                    if (Table1.JobInfo.TabControl2.SelectedIndex == 1)
                    {
                        logger.SendMsg("    Process = Array");
                    }
                    else
                    if (Table1.JobInfo.TabControl2.SelectedIndex == 2)
                    {
                        logger.SendMsg("    Process = MakeCell");
                    }
                    logger.SendMsg("    ");

                    Table1.TotalPageCount = Table1.GetTotalPageCount();
                    Table1.PageCount = Table1.GetPageCount();
                    Table1.PageIndex = Table1.GetFirstPage();
                    Table1.Layers = Table1.GetLayers();

                    logger.AddResetSeparator();
                    logger.SendMsg(String.Format("    Table1.PageIndex = {0}/{1}/{2}", Table1.PageIndex, Table1.PageCount, Table1.TotalPageCount));

                    Pmac.QueryCommand(String.Format("doBeamShutterOpen={0}", btnLaserRun.LED.Value.ToString()));
                    Pmac.QueryCommand(String.Format("doDustCollectorOn={0}", Common.chkDustCollectorAutoRun.Checked.ToString()));

                    Pmac.QueryCommand(String.Format("doTable1IonizerOn={0}", Common.chkIOnizoerAutoRun.Checked.ToString()));
                    Pmac.QueryCommand(String.Format("doTable1IonizerSol={0}", Common.chkIOnizoerAutoRun.Checked.ToString()));

                    Pmac.QueryCommand("doSelectTable=TABLE1"); // Pmac.QueryCommand("Out_SelectBoard=1");
                    Pmac.QueryCommand("Table1Busy=true");

                    if (Global.chAutoRunSpeedStage.AsDouble > 200)
                    {
                        Global.chAutoRunSpeedStage.AsDouble = 200;
                    }
                    else
                    if (Global.chAutoRunSpeedStage.AsDouble <= 0)
                    {
                        Global.chAutoRunSpeedStage.AsDouble = 100;
                    }

                    if (Global.chAutoRunSpeedZ.AsDouble > 30)
                    {
                        Global.chAutoRunSpeedZ.AsDouble = 30;
                    }
                    else
                    if (Global.chAutoRunSpeedZ.AsDouble <= 0)
                    {
                        Global.chAutoRunSpeedZ.AsDouble = 20;
                    }

                    if (frmMain.Config.Common.edJumpSpeed.Value <= 0)
                    {
                        frmMain.Config.Common.edJumpSpeed.Value = 200;
                    }
                    else
                    if (frmMain.Config.Common.edJumpSpeed.Value > 300)
                    {
                        frmMain.Config.Common.edJumpSpeed.Value = 300;
                    };

#if _VERSION1
                    Pmac.XSetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
                    Pmac.Y1SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
                    Pmac.Y2SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
#elif _VERSION2
                    Pmac.XSetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
                    Pmac.Y1SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
                    Pmac.Y2SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
#endif
                    Pmac.ZSetSpeed(Global.chAutoRunSpeedZ.AsDouble * 10);

                    Table1.Step = 10;
                    break;

                case 10:
                    Table1.GetPageCenter(Table1.PageIndex);

                    Vision1.viAngle.AsDouble = 0.0;

                    Vision1.viAlign1SearchScore.AsDouble = 0.0;
                    Vision1.viAlign1SearchResultXPos.AsDouble = 0.0;
                    Vision1.viAlign1SearchResultYPos.AsDouble = 0.0;
                    Vision1.ledAlign1SearchResultGood.LED.Value = false;
                    Vision1.ledAlign1SearchResultBad.LED.Value = false;

                    Vision1.viAlign2SearchScore.AsDouble = 0.0;
                    Vision1.viAlign2SearchResultXPos.AsDouble = 0.0;
                    Vision1.viAlign2SearchResultYPos.AsDouble = 0.0;
                    Vision1.ledAlign2SearchResultGood.LED.Value = false;
                    Vision1.ledAlign2SearchResultBad.LED.Value = false;

                    Vision1.viAlign3SearchScore.AsDouble = 0.0;
                    Vision1.viAlign3SearchResultXPos.AsDouble = 0.0;
                    Vision1.viAlign3SearchResultYPos.AsDouble = 0.0;
                    Vision1.ledAlign3SearchResultGood.LED.Value = false;
                    Vision1.ledAlign3SearchResultBad.LED.Value = false;

                    Vision1.viAlign4SearchScore.AsDouble = 0.0;
                    Vision1.viAlign4SearchResultXPos.AsDouble = 0.0;
                    Vision1.viAlign4SearchResultYPos.AsDouble = 0.0;
                    Vision1.ledAlign4SearchResultGood.LED.Value = false;
                    Vision1.ledAlign4SearchResultBad.LED.Value = false;

                    Vision1.viAngleDiff.AsDouble = 0.0;
                    Vision1.viAlign1OffsetX.AsDouble = 0.0;
                    Vision1.viAlign1OffsetY.AsDouble = 0.0;
                    Vision1.viAlign2OffsetX.AsDouble = 0.0;
                    Vision1.viAlign2OffsetY.AsDouble = 0.0;

                    Table1.AlignShift.x = 0;
                    Table1.AlignShift.y = 0.0;

                    Table1.LastStep = 0;

                    Table1.GetReadyPos(Table1.PageIndex);

                    Table1.Step = 20;
                    break;

                case 20:    //Table1 Ready Pos 이동
                    if (Table1.UseVision)
                    {
                        // MoveAlign#1Pos
                        Table1.GetPageInfo(Table1.PageIndex);
                        Table1.Step = 110;
                    }
                    else
                    {
                        // Vision 사용하지 않음 가공 위치로..
                        logger.SendMsg("        Table1.SkipVision");
                        logger.SendMsg("");

                        if (Pmac.ZInTargetPos(Common.edTable1VisionZFocus.Value))
                        {
                            Pmac.ZMoveAbs(Common.edTable1VisionZFocus.Value);
                        }

                        Table1.Step = 1100;
                    }
                    break;
                /* ======================================================================
                 * Align Pos
                 */

                // @@ MoveAlign#1Pos --------------------------------------------------
                case 110: // Move Align#1 Pos
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table1.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable1VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table1.Align1Pos.x) != true)
                            || (Pmac.Y1InTargetPos(Table1.Align1Pos.y) != true)
                                || (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table1.MoveAlign1Pos({0})", Table1.Align1Pos.ToString()));

                        Pmac.XMoveAbs(Table1.Align1Pos.x);
                        Pmac.Y1MoveAbs(Table1.Align1Pos.y);
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);

                        Counter.Start();
                        Table1.Step = 112;
                    }
                    else
                    {
                        Table1.Step = 130;
                    }
                    break;

                case 112: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut)) // Motor 기동 시간 < Sys.Time)
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table1.Step = 120;
                    }
                    break;

                case 120: // Align#1 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY1MotionDone.AsBoolean) /*&& (Global.chY1InPosition.AsBoolean)*/
                            && (Pmac.XInTargetPos(Table1.Align1Pos.x)) 
                                && (Pmac.Y1InTargetPos(Table1.Align1Pos.y))
                                    && (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble)))
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table1.Step = 121;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut)) // Align#1 pos 이동 최대 5.0초
                    {
                        Counter.Stop();

                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_MOVE_ALIGN1_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table1.Step = 121;
#endif
                    break;

                case 121:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table1.Step = 130;
                    }
                    break;

                case 130: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start(); // Vision1ReplyTimeOut;    // Align#1 응답 시간 최대 3.0초

                    Vision1.Search1();

                    Table1.Step = 131;
                    break;

                case 131:
#if _VISION
                    if (Vision1.SearchOK)
                    {
                        Vision1.ledAlign1SearchResultGood.LED.Value = true;
                        Vision1.ledAlign1SearchResultBad.LED.Value = false;

                        Vision1.viAlign1SearchScore.AsDouble = Vision1.SearchScore;
                        Vision1.viAlign1SearchResultXPos.AsDouble = Vision1.SearchResultXPos;
                        Vision1.viAlign1SearchResultYPos.AsDouble = Vision1.SearchResultYPos;

                        logger.SendMsg("        Align1SearchOK = true");

                        Table1.Step = 140;
                    }
                    else
                    {
                        Vision1.ledAlign1SearchResultGood.LED.Value = false;
                        Vision1.ledAlign1SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align1SearchOK = false");
                        AddError(Const.ERROR_TABLE1_VISION_ALIGN1_SEARCH_FAIL);

                        Table1.LastStep = Table1.Step;
                        Table1.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision1.ledAlign1SearchResultGood.LED.Value = true;
                    Table1.Step = 140;
#endif
                    break;

                case 140: // Vision 응답 대기
                    if ((Table1.AlignMethod == AlignMethod.Align2P_1_2)
                        || (Table1.AlignMethod == AlignMethod.Align4P))
                    {
                        Table1.Step = 210;
                    }
                    else
                    if (Table1.AlignMethod == AlignMethod.Align2P_1_3)
                    {
                        Table1.Step = 310;
                    }
                    else
                    if (Table1.AlignMethod == AlignMethod.Align2P_1_4)
                    {
                        Table1.Step = 410;
                    }
                    break;

                // @@ MoveAlign#2Pos --------------------------------------------------
                case 210:
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table1.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable1VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table1.Align2Pos.x) != true)
                        || (Pmac.Y1InTargetPos(Table1.Align2Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table1.MoveAlign2Pos({0})", Table1.Align2Pos.ToString()));

                        Pmac.XMoveAbs(Table1.Align2Pos.x);
                        Pmac.Y1MoveAbs(Table1.Align2Pos.y);
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);

                        Counter.Start();
                        Table1.Step = 212;
                    }
                    else
                    {
                        Table1.Step = 230;
                    }
                    break;

                case 212: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Stop();

                        Counter.Start();
                        Table1.Step = 220;
                    }
                    break;

                case 220: // Align#2 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY1MotionDone.AsBoolean) && (Global.chY1InPosition.AsBoolean) 
                        && (Pmac.XInTargetPos(Table1.Align2Pos.x)) 
                            && (Pmac.Y1InTargetPos(Table1.Align2Pos.y))
                                && (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble)))
                    {
                        Counter.Start();
                        Table1.Step = 221;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_MOVE_ALIGN2_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table1.Step = 221;
#endif
                    break;

                case 221:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table1.Step = 230;
                    }
                    break;

                case 230: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start();

                    if (!Table1.UseIndividualAlignMark())
                    {
                        Vision1.Search1();
                    }
                    else
                    {
                        Vision1.Search2();
                    }

                    Table1.Step = 231;
                    break;

                case 231:
#if _VISION
                    if (Vision1.SearchOK)
                    {
                        Vision1.ledAlign2SearchResultGood.LED.Value = true;
                        Vision1.ledAlign2SearchResultBad.LED.Value = false;

                        Vision1.viAlign2SearchScore.AsDouble = Vision1.SearchScore;
                        Vision1.viAlign2SearchResultXPos.AsDouble = Vision1.SearchResultXPos;
                        Vision1.viAlign2SearchResultYPos.AsDouble = Vision1.SearchResultYPos;

                        logger.SendMsg("        Align2SearchOK = true");

                        Table1.Step = 240;
                    }
                    else
                    {
                        Vision1.ledAlign2SearchResultGood.LED.Value = false;
                        Vision1.ledAlign2SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align2SearchOK = false");
                        AddError(Const.ERROR_TABLE1_VISION_ALIGN2_SEARCH_FAIL);

                        Table1.LastStep = Table1.Step;
                        Table1.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision1.ledAlign2SearchResultGood.LED.Value = true;
                    Table1.Step = 240;
#endif
                    break;

                case 240: // Vision 응답 대기
                    if (Table1.AlignMethod == AlignMethod.Align2P_1_2) // Vision 2Point
                    {
                        // MoveReadyPos
                        Table1.Step = 1100;
                    }
                    else
                    if (Table1.AlignMethod == AlignMethod.Align4P)
                    {
                        // MoveAlign#3Pos
                        Table1.Step = 310;
                    }
                    break;

                // @@ MoveAlign#3Pos --------------------------------------------------
                case 310: // Move Align#3 Pos
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table1.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable1VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table1.Align3Pos.x) != true)
                        || (Pmac.Y1InTargetPos(Table1.Align3Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table1.MoveAlign3Pos({0})", Table1.Align3Pos.ToString()));

                        Pmac.XMoveAbs(Table1.Align3Pos.x);
                        Pmac.Y1MoveAbs(Table1.Align3Pos.y);
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);

                        Counter.Start();
                        Table1.Step = 312;
                    }
                    else
                    {
                        Table1.Step = 330;
                    }
                    break;

                case 312: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table1.Step = 320;
                    }
                    break;

                case 320: // Align#3 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY1MotionDone.AsBoolean == true) /*&& (Global.chY1InPosition.AsBoolean == true)*/
                            && (Pmac.XInTargetPos(Table1.Align3Pos.x) == true) 
                                && (Pmac.Y1InTargetPos(Table1.Align3Pos.y) == true)
                                    && (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble)))
                    {
                        Counter.Start();
                        Table1.Step = 321;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_MOVE_ALIGN2_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table1.Step = 321;
#endif
                    break;

                case 321:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table1.Step = 330;
                    }
                    break;

                case 330: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start();

                    Vision1.Search1();

                    Table1.Step = 331;
                    break;

                case 331:
#if _VISION
                    if (Vision1.SearchOK)
                    {
                        Vision1.ledAlign3SearchResultGood.LED.Value = true;
                        Vision1.ledAlign3SearchResultBad.LED.Value = false;

                        Vision1.viAlign3SearchScore.AsDouble = Vision1.SearchScore;
                        Vision1.viAlign3SearchResultXPos.AsDouble = Vision1.SearchResultXPos;
                        Vision1.viAlign3SearchResultYPos.AsDouble = Vision1.SearchResultYPos;
                       
                        logger.SendMsg("        Align3SearchOK = true");
                        AddError(Const.ERROR_TABLE1_VISION_ALIGN3_SEARCH_FAIL);

                        Table1.Step = 340;
                    }
                    else
                    {
                        Vision1.ledAlign3SearchResultGood.LED.Value = false;
                        Vision1.ledAlign3SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align3SearchOK = false");
                        AddError(Const.ERROR_TABLE1_VISION_ALIGN3_SEARCH_FAIL);

                        Table1.LastStep = Table1.Step;
                        Table1.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision1.ledAlign3SearchResultBad.LED.Value = true;
                    Table1.Step = 340;
#endif
                    break;

                case 340: // Vision 응답 대기
                    if (Table1.AlignMethod == AlignMethod.Align2P_1_3) // Vision 3Point
                    {
                        // MoveReadyPos
                        Table1.Step = 1100;
                    }
                    else
                    if (Table1.AlignMethod == AlignMethod.Align4P)
                    {
                        // MoveAlign#4Pos
                        Table1.Step = 410;
                    }
                    break;

                // @@ MoveAlign#4Pos --------------------------------------------------
                case 410: // Move Align#4 Pos
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table1.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable1VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table1.Align4Pos.x) != true)
                        || (Pmac.Y1InTargetPos(Table1.Align4Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table1.MoveAlig4Pos({0})", Table1.Align4Pos.ToString()));

                        Pmac.XMoveAbs(Table1.Align4Pos.x);
                        Pmac.Y1MoveAbs(Table1.Align4Pos.y);
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);

                        Counter.Start();
                        Table1.Step = 412;
                    }
                    else
                    {
                        Table1.Step = 430;
                    }
                    break;

                case 412: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table1.Step = 420;
                    }
                    break;

                case 420: // Align#1 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY1MotionDone.AsBoolean == true) /*&& (Global.chY1InPosition.AsBoolean == true)*/
                            && (Pmac.XInTargetPos(Table1.Align4Pos.x) == true) 
                                && (Pmac.Y1InTargetPos(Table1.Align4Pos.y) == true)
                                    && (Pmac.ZInTargetPos(Global.chTable1VisionZFocus.AsDouble)))

                    {
                        Counter.Start();
                        Table1.Step = 421;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_MOVE_ALIGN4_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table1.Step = 421;
#endif
                    break;

                case 421:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table1.Step = 430;
                    }
                    break;

                case 430: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start();

                    Vision1.Search1();

                    Table1.Step = 431;
                    break;

                case 431:
#if _VISION
                    if (Vision1.SearchOK)
                    {
                        Vision1.ledAlign4SearchResultGood.LED.Value = true;
                        Vision1.ledAlign4SearchResultBad.LED.Value = false;

                        Vision1.viAlign4SearchScore.AsDouble = Vision1.SearchScore;
                        Vision1.viAlign4SearchResultXPos.AsDouble = Vision1.SearchResultXPos;
                        Vision1.viAlign4SearchResultYPos.AsDouble = Vision1.SearchResultYPos;

                        logger.SendMsg("        Align4SearchOK = true");
                    
                        Table1.Step = 440;
                    }
                    else
                    {
                        Vision1.ledAlign4SearchResultGood.LED.Value = false;
                        Vision1.ledAlign4SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align4SearchOK = false");
                        AddError(Const.ERROR_TABLE1_VISION_ALIGN4_SEARCH_FAIL);

                        Table1.LastStep = Table1.Step;
                        Table1.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision1.ledAlign4SearchResultGood.LED.Value = true;
                    Table1.Step = 440;
#endif
                    break;

                case 440: // Vision 응답 대기
                    Table1.Step = 1100;
                    break;

                /* ======================================================================
                 * Vision을 찍었으면 보정 하고..
                 * 가공 대기 위치로 출발
                 */
                case 1100:  // 가공 대기 위치로 출발
                    logger.SendMsg("        Change Table1.LaserFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable1LaserFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if (Table1.UseVision)
                    {
                        logger.SendMsg("");
                        logger.SendMsg("    Table1.Calc...");

                        double Align1ResultX = Table1.Align1Pos.x + Vision1.viAlign1SearchResultXPos.AsDouble;
                        double Align1ResultY = Table1.Align1Pos.y + Vision1.viAlign1SearchResultYPos.AsDouble;

                        double Align2ResultX = Table1.Align2Pos.x + Vision1.viAlign2SearchResultXPos.AsDouble;
                        double Align2ResultY = Table1.Align2Pos.y + Vision1.viAlign2SearchResultYPos.AsDouble;

                        double Rad = Math.Atan2(Table1.Align2Pos.y - Table1.Align1Pos.y, Table1.Align2Pos.x - Table1.Align1Pos.x);
                        Rad = Rad * (180.0 / Math.PI);
                        Vision1.viAngle0.AsDouble = Rad;

                        Rad = Math.Atan2(Align2ResultY - Align1ResultY, Align2ResultX - Align1ResultX);
                        Rad = Rad * (180.0 / Math.PI);
                        Vision1.viAngle.AsDouble = Rad;

                        Vision1.viAngleDiff.AsDouble = Vision1.viAngle0.AsDouble - Vision1.viAngle.AsDouble;

                        logger.SendMsg(String.Format("        Vision1.Align1Pos = ({0:F3}, {1:F3})", Align1ResultX, Align1ResultY));
                        logger.SendMsg(String.Format("        Vision1.Align2Pos = ({0:F3}, {1:F3})", Align2ResultX, Align2ResultY));
                        logger.SendMsg(String.Format("        Vision1.Angle = {0:F3}", Vision1.viAngleDiff.AsDouble));

                        DoublePoint CenterPos = new DoublePoint(Table1.CenterPos.x, Table1.CenterPos.y);
                        DoublePoint NewAlign1Pos = new DoublePoint(0.0, 0.0);
                        DoublePoint NewAlign2Pos = new DoublePoint(0.0, 0.0);

                        logger.SendMsg(String.Format("        Table1.CenterPos = {0:F3}, {1:F3}", Table1.CenterPos.x, Table1.CenterPos.y));

                        dkCommon.GetRotatorPos(CenterPos, Table1.Align1Pos, -Vision1.viAngleDiff.AsDouble, ref NewAlign1Pos);
                        dkCommon.GetRotatorPos(CenterPos, Table1.Align2Pos, -Vision1.viAngleDiff.AsDouble, ref NewAlign2Pos);

                        logger.SendMsg(String.Format("        Table1.NewAlign1Pos = ({0:F3})", NewAlign1Pos));
                        logger.SendMsg(String.Format("        Table1.NewAlign2Pos = ({0:F3})", NewAlign2Pos));

                        Vision1.viAlign1OffsetX.AsDouble = Align1ResultX - NewAlign1Pos.x;
                        Vision1.viAlign1OffsetY.AsDouble = Align1ResultY - NewAlign1Pos.y;

                        Vision1.viAlign2OffsetX.AsDouble = Align2ResultX - NewAlign2Pos.x;
                        Vision1.viAlign2OffsetY.AsDouble = Align2ResultY - NewAlign2Pos.y;

                        Table1.AlignShift = new DoublePoint(0, 0);

                        Table1.AlignShift.x = (Vision1.viAlign1OffsetX.AsDouble + Vision1.viAlign2OffsetX.AsDouble) / 2;
                        Table1.AlignShift.y = (Vision1.viAlign1OffsetY.AsDouble + Vision1.viAlign2OffsetY.AsDouble) / 2;

                        logger.SendMsg(String.Format("        AlignShift = {0:F3}, {1:F3}", Table1.AlignShift.x, Table1.AlignShift.y));
                    }

                    /*
                     * viAlign1Offset, viALign2Offset의 차이를 비교하여 일정 이상이면 Error을 띄워야 한다.
                     */

                    if ((Math.Abs(Vision1.viAlign1OffsetX.AsDouble - Vision1.viAlign2OffsetX.AsDouble) > 0.03)
                            || (Math.Abs(Vision1.viAlign1OffsetY.AsDouble - Vision1.viAlign2OffsetY.AsDouble) > 0.03))
                    {
                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_VISION_SHIFT_OFFSET_OVER;         // 도착 시간 TIME OVER
                        AddError(Const.ERROR_TABLE1_VISION_SHIFT_OFFSET_OVER);

                        Table1.Step = Const.CASE_ERROR;
                    }
                    else
                    {
                        logger.SendMsg(String.Format("        Table1.MoveReadyPos({0})", Table1.ReadyPos.ToString()));
                        Table1.Step = 1101;
                    }
                    break;

                case 1101:
#if _PMAC
                    if ((Pmac.XInTargetPos(Table1.ReadyPos.x) != true) 
                        || (Pmac.Y1InTargetPos(Table1.ReadyPos.y) != true)) 
                    {
                        Pmac.XMoveAbs(Table1.ReadyPos.x);
                        Pmac.Y1MoveAbs(Table1.ReadyPos.y);

                        if (btnLaserRun.LED.Value)
                        {
                            if (Pmac.ZInTargetPos(Table1.GetZPosition()) != true)
                            {
                                Pmac.ZMoveAbs(Table1.GetZPosition());
                            }
                        }
                        else
                        {
                            if (Pmac.ZInTargetPos(Common.edTable1VisionZFocus.Value) != true)
                            {
                                Pmac.ZMoveAbs(Common.edTable1VisionZFocus.Value);
                            }
                        }

                        Counter.Start();
                        Table1.Step = 1110;
                    }
                    else
                    {
                        Table1.Step = 1120;
                    }
#else
                    Counter.Start();

                    Table1.Step = 1110;
#endif
                    break;

                case 1110:
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table1.Step = 1111;
                    }
                    break;

                case 1111: // 가공 대기 위치 도착 확인, 
#if _PMAC
                    if ((Global.chY1MotionDone.AsBoolean == true) /*&& (Global.chY1InPosition.AsBoolean == true)*/
                            && (Pmac.XInTargetPos(Table1.ReadyPos.x) == true) 
                                && (Pmac.Y1InTargetPos(Table1.ReadyPos.y) == true))
                    {
                        if (btnLaserRun.LED.Value)
                        {
                            if (Pmac.ZInTargetPos(Table1.GetZPosition()) == true)
                            {
                                Table1.Step = 1120;
                            } 
                            else
                            if (Counter.isTimeOver(MotorMoveTimeOut))
                            {
                                Table1.LastStep = Table1.Step;
                                Table1.ErrorCode = Const.ERROR_TABLE1_MOVE_READY_POS_TIME_OVER;         // 도착 시간 TIME OVER

                                Table1.Step = Const.CASE_ERROR;
                            }
                        }
                        else
                        {
                            Table1.Step = 1120;
                        }
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_MOVE_READY_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Table1.Step = 1120;
#endif
                    break;

                case 1120: // MotionDownload 요청
                    SetLaserPower(TableNo.Table1, Table1.JobInfo.TabControl2.SelectedIndex);
                    SetPulseWidth(TableNo.Table1, Table1.JobInfo.TabControl2.SelectedIndex);
                    SetPulsePitch(TableNo.Table1, Table1.JobInfo.TabControl2.SelectedIndex);

                    logger.SendMsg("");
                    frmMotionFile.Memo1.Clear();
                    Table1.MakeMotionFile(Vision1.viAngleDiff.AsDouble, Table1.AlignShift, btnLaserRun.LED.Value);

                    Table1.LayerIndex = (-1);
                    if (Pmac.DownloadFile1(Handle) == 0)
                    {
                        Counter.Start();
                        Table1.Step = 1170;
                    }
                    else
                    {
                        Counter.Start();
                        Table1.Step = 1150;
                    }
                    break;

                case 1150:

                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        Counter.Start();
                        Table1.Step = 1160;
                    }
                    break;

                case 1160:
#if _PMAC
                    if (frmMotionFile.MessageQueue.Count > 100)
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table1.Step = 1170;
                    }
                    else
                    if (Counter.isTimeOver(2000))
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table1.Step = 1170;
                    };
#else
                    Counter.Start();

                    Table1.Step = 1170;
#endif
                    break;

                case 1170:
#if _PMAC
                    int r;
                    Pmac.QueryCommand("M0", out r);

                    if (r == 0)
                    {
                        Counter.Stop();

                        if (frmMotionFile.isStartAble())
                        {
                            Counter.Start();

                            Table1.Step = 1180;
                        }
                        else
                        {
                            AddError(Const.ERR0R_MOTIONFILE_INVALID_DATA);
                            Table1.Step = Const.CASE_ERROR;
                        };
                    }
                    else
                    if (Counter.isTimeOver(5000))
                    {
                        Counter.Stop();

                        Table1.Step = Const.CASE_ERROR;
                    };
#else
                    Counter.Start();

                    Table1.Step = 1175;
#endif
                    break;

                case 1175://laser power, pitch set
                    Counter.Stop();

                    Counter.Start();

                    Table1.Step = 1180;
                    break;

                case 1180:
                    Counter.Stop();

                    Table1.LayerIndex = Table1.GetLayerIndex(Table1.LayerIndex + 1);
                    if (Table1.LayerIndex >= 0)
                    {
                        logger.AddSeparator();
                        logger.SendMsg(String.Format("        Layer = [{0}]", Table1.Layers[Table1.LayerIndex].Name));
                        logger.SendMsg(String.Format("        Table1.Motion[{0}].Run()~~", Table1.LayerIndex + 100));
                        Pmac.QueryCommand(String.Format("&1b{0}r", Table1.LayerIndex + 100));

                        Counter.Start();

                        Table1.Step = 1190;
                    } 
                    else
                    {
                        Table1.Step = 2000;
                    }
                    break;

                case 1190:
                    if (Counter.isTimeOver(10))
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table1.Step = 1200;
                    }
                    break;

                case 1200:
#if _PMAC
                    if (Global.chCoord1Running)
                    {
                        Counter.Start();

                        Table1.Step = 1210;
                    }
                    else
                    if (Counter.isTimeOver(5000))
                    {
                        logger.SendMsg("        TABLE1_COORD1_START_TIME_OVER");

                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_COORD1_START_TIME_OVER;

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Table1.Step = 1210;
#endif
                    break;

                case 1210:
#if _PMAC
                    if (!Global.chCoord1Running)
                    {
                        Counter.Start();

                        Table1.Step = 1220;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 60 * 5)) // 30초... 
                    {
                        Table1.LastStep = Table1.Step;
                        Table1.ErrorCode = Const.ERROR_TABLE1_COORD1_STOP_TIME_OVER;

                        Table1.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table1.Step = 1220;
#endif
                    break;

                case 1220:
                    if (Counter.isTimeOver(100))
                    {
                        logger.SendMsg(String.Format("        Table1.Motion[{0}].Finish~~", Table1.LayerIndex + 100));

                        Table1.Step = 1180;
                    }
                    break;

                /* ======================================================================
                 * Motion 완료 후 Load 위치로 이동
                 */
                case 2000:
                    Table1.PageIndex = Table1.GetNextPage(Table1.PageIndex + 1);
                    if (Table1.PageIndex > (-1))
                    {
                        logger.AddResetSeparator();
                        logger.SendMsg(String.Format("    Table1.PageIndex = {0}/{1}/{2}", Table1.PageIndex, Table1.PageCount, Table1.TotalPageCount));

                        Table1.Step = 10;
                    }
                    else
                    {
                        stopwatch.Stop();

                        viTable1CycleTime.AsDouble = stopwatch.ElapsedMilliseconds / 1000.0;

                        if (!Pmac.XInTargetPos(Table1.LoadPos.x))
                        {
                            Pmac.XMoveAbs(Table1.LoadPos.x);
                        }

                        logger.AddSeparator();
                        logger.SendMsg("        Table1.Unload~~");
                        Pmac.QueryCommand("Table1Unload=true");
                        Pmac.QueryCommand("Table1New=false");

                        if (frmMain.Config.Common.chkVacuumAutoRelease.Checked)
                        {
                            Pmac.QueryCommand("Table1VacuumAutoRelease=true");
                        }

                        Counter.Start();
                        Table1.Step = 2010;
                    }
                    break;

                case 2010:
                    if (Counter.isTimeOver(100))
                    {
                        Counter.Stop();

                        Table1.Step = 2100;
                    }
                    break;

                /* ======================================================================
                * Motion 완료 후 Load 위치로 이동
                */
                case 2100: // 투입 위치로 출발
                    if ((Pmac.XInTargetPos(Table1.LoadPos.x) != true))
                    {
                        Pmac.XMoveAbs(Table1.LoadPos.x);

                        Counter.Start();
                        Table1.Step = 2110;
                    }
                    else
                    {
                        Table1.Step = 3000;
                    }

                    break;

                case 2110:
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table1.Step = 3000;
                    }
                    break;

                /* ======================================================================
                 * Jog로 대기위치로 이동 
                 */
                case 3000:
#if !Pmac
                    Global.Table1New = false;
                    Global.Table2New = false;
#endif
                    Table1.Step = Const.CASE_DONE;
                    break;

                case Const.CASE_VISION_ERROR:

                    frmRestart.TopMost = true;
                    frmRestart.lblMessage.Text = "Vision Align Search Error.";

                    frmRestart.Start = false;
                    frmRestart.Stop = false;
                    frmRestart.StartPosition = FormStartPosition.CenterScreen;

                    frmRestart.Show();
                    frmRestart.AutoThread.Enabled = true;

                    frmMain.ButtonEnables(true);
                    frmVision.ButtonEnables(true);

                    Table1.Step = Const.CASE_VISION_ERROR + 1;
                    break;

                case Const.CASE_VISION_ERROR + 1:

                    if (frmRestart.Start)
                    {
                        Vision1.btnManualSet.LED.Value = false;

                        frmRestart.Close();

                        btnReset_Click(null, null);
                        btnReset_Click(null, null);

                        frmMain.ButtonEnables(false);
                        frmVision.ButtonEnables(false);

                        Table1.Step = Table1.LastStep;
                    }
                    else
                    if (frmRestart.Stop)
                    {
                        Vision1.btnManualSet.LED.Value = false;

                        frmRestart.Close();

                        btnReset_Click(null, null);
                        btnReset_Click(null, null);

                        if (!Pmac.XInTargetPos(Table1.LoadPos.x))
                        {
                            Pmac.XMoveAbs(Table1.LoadPos.x);
                        }

                        if (frmMain.Config.Common.chkVacuumAutoRelease.Checked)
                        {
                            Pmac.QueryCommand("Table1VacuumAutoRelease=true");
                        }

                        Pmac.QueryCommand("Table1Unload=true");
                        Pmac.QueryCommand("Table1New=false");

                        Table1.Step = Const.CASE_ERROR;
                    }
                    break;

                case Const.CASE_DONE:

                    Pmac.QueryCommand("doTable1IonizerOn=false");
                    Pmac.QueryCommand("doTable1IonizerSol=false");
                    Pmac.QueryCommand("Table1Busy=false");

                    Table1.Step = 0;
                    break;

                case Const.CASE_ABORT:
                    Pmac.XStop();
                    Pmac.Y1Stop();

                    Counter.Start();
                    Table1.Step = Const.CASE_ABORT + 1;
                    break;

                case Const.CASE_ABORT + 1:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        Table1.Step = Const.CASE_ABORT + 2;
                    }
                    break;

                case Const.CASE_ABORT + 2:
                    if (frmMain.Config.Common.chkVacuumAutoRelease.Checked)
                    {
                        Pmac.QueryCommand("Table1VacuumAutoRelease=true");
                    }

                    if (!Pmac.XInTargetPos(Table1.LoadPos.x))
                    {
                        Pmac.XMoveAbs(Table1.LoadPos.x);
                    }

                    Pmac.QueryCommand("Table1Unload=true");
                    Pmac.QueryCommand("Table1New=false");
                    Pmac.QueryCommand("Table1Busy=false");

                    Pmac.QueryCommand("doTable1IonizerOn=false");
                    Pmac.QueryCommand("doTable1IonizerSol=false");

                    Table1.Step = Const.CASE_ABORT + 3;
                    break;

                case Const.CASE_ABORT + 3:
                    Global.Table1New = false;
                    Table1.Stop = false;
                    Table1.Step = 0;

                    if (btnStopPressed)
                    {
                        Command = Command.Stop;
                        btnStopPressed = false;
                    }

                    break;

                case Const.CASE_ERROR:
                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    Pmac.QueryCommand("doLaserTriggerOn=false");

                    Pmac.QueryCommand("Table1Busy=false");
                    Pmac.QueryCommand("Table1New=false");

                    Pmac.QueryCommand("doTable1IonizerOn=false");
                    Pmac.QueryCommand("doTable1IonizerSol=false");

                    lblTable1ErrorStep.Text = String.Format("{0}", Table1.LastStep);

                    Global.Table1New = false;
                    Table1.Stop = false;
                    Table1.Step = 0;
                    break;
            }
        }
#endregion

        #region private void DoTable2Start()
        private void DoTable2Start()
        {
            lblPageIndex.Text = String.Format("{0}", Table2.PageIndex);
            lblPageCount.Text = String.Format("{0}", Table2.PageCount);

            if (Pmac.CommError) return;

            if ((Table2.Stop) && (Table2.Step < Const.CASE_DONE))
            {
                if ((Table2.Step > 1120) && (Table2.Step <= 1180))
                {
                    int r = 0;
                    Pmac.QueryCommand("M0", out r);
                    if (r == 0)
                    {
                        Pmac.QueryCommand("doLaserTriggerOn=false");
                        Table2.Step = Const.CASE_ABORT;
                    }
                }
                else
                if ((Table2.Step > 1180) && (Table2.Step <= 1220))
                {
                    if (ledCoord1ProgRunning.LED.Value)
                    {
                        int r = 0;
                        Pmac.QueryCommand("M0", out r);
                        if (r == 0)
                        {
                            Pmac.QueryCommand("&1a");

                            Pmac.QueryCommand("doLaserTriggerOn=false");
                            Table2.Step = Const.CASE_ABORT;
                        }
                    }
                    else
                    {
                        Pmac.QueryCommand("doLaserTriggerOn=false");
                        Table2.Step = Const.CASE_ABORT;
                    }
                }
                else
                {
                    Pmac.QueryCommand("doLaserTriggerOn=false");
                    Table2.Step = Const.CASE_ABORT;
                }
            }

            switch (Table2.Step)
            {
                // @@ 
                case 0: // Vision을 사용하지 않으면 1100으로 점프
                    Table2.Step = 1;
                    break;

                case 1:
                    viTable2InputCount.AsInteger = viTable2InputCount.AsInteger + 1;

                    stopwatch = Stopwatch.StartNew();

                    Global.isChangeAble = true;
                    TabControl1.SelectedIndex = 1;
                    Global.isChangeAble = false;

                    Table2.Stop = false;
                    btnStopPressed = false;

                    logger.SendMsg("");
                    logger.SendMsg("=======================================================================");
                    logger.SendMsg("    Table2.New");

                    logger.SendMsg(String.Format("    JobFile = {0}/{1}", Table2.GroupName, Table2.ModelName));
                    if (Table2.JobInfo.TabControl2.SelectedIndex == 0)
                    {
                        logger.SendMsg("    Process = DXF");
                    }
                    else
                    if (Table2.JobInfo.TabControl2.SelectedIndex == 1)
                    {
                        logger.SendMsg("    Process = Array");
                    }
                    else
                    if (Table2.JobInfo.TabControl2.SelectedIndex == 2)
                    {
                        logger.SendMsg("    Process = MakeCell");
                    }
                    logger.SendMsg("    ");

                    Table2.TotalPageCount = Table2.GetTotalPageCount();
                    Table2.PageCount = Table2.GetPageCount();
                    Table2.PageIndex = Table2.GetFirstPage();
                    Table2.Layers = Table2.GetLayers();

                    logger.AddResetSeparator();
                    logger.SendMsg(String.Format("    Table2.PageIndex = {0}/{1}/{2}", Table2.PageIndex, Table2.PageCount, Table2.TotalPageCount));

                    Pmac.QueryCommand(String.Format("doBeamShutterOpen={0}", btnLaserRun.LED.Value.ToString()));
                    Pmac.QueryCommand(String.Format("doDustCollectorOn={0}", Common.chkDustCollectorAutoRun.Checked.ToString()));

                    Pmac.QueryCommand(String.Format("doTable2IonizerOn={0}", Common.chkIOnizoerAutoRun.Checked.ToString()));
                    Pmac.QueryCommand(String.Format("doTable2IonizerSol={0}", Common.chkIOnizoerAutoRun.Checked.ToString()));

                    Pmac.QueryCommand("doSelectTable=TABLE2"); // Pmac.QueryCommand("Out_SelectBoard=1");
                    Pmac.QueryCommand("Table2Busy=true");

                    if (Global.chAutoRunSpeedStage.AsDouble > 200)
                    {
                        Global.chAutoRunSpeedStage.AsDouble = 200;
                    }
                    else
                    if (Global.chAutoRunSpeedStage.AsDouble <= 0)
                    {
                        Global.chAutoRunSpeedStage.AsDouble = 100;
                    }

                    if (Global.chAutoRunSpeedZ.AsDouble > 30)
                    {
                        Global.chAutoRunSpeedZ.AsDouble = 30;
                    }
                    else
                    if (Global.chAutoRunSpeedZ.AsDouble <= 0)
                    {
                        Global.chAutoRunSpeedZ.AsDouble = 20;
                    }

                    if (frmMain.Config.Common.edJumpSpeed.Value <= 0)
                    {
                        frmMain.Config.Common.edJumpSpeed.Value = 200;
                    }
                    else
                    if (frmMain.Config.Common.edJumpSpeed.Value > 300)
                    {
                        frmMain.Config.Common.edJumpSpeed.Value = 300;
                    };

#if _VERSION1
                    Pmac.XSetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
                    Pmac.Y1SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
                    Pmac.Y2SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 1);
#elif _VERSION2
                    Pmac.XSetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
                    Pmac.Y1SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
                    Pmac.Y2SetSpeed(Global.chAutoRunSpeedStage.AsDouble * 10);
#endif
                    Pmac.ZSetSpeed(Global.chAutoRunSpeedZ.AsDouble * 10);

                    Table2.Step = 10;
                    break;

                case 10:
                    Table2.GetPageCenter(Table2.PageIndex);

                    Vision2.viAngle.AsDouble = 0.0;

                    Vision2.viAlign1SearchScore.AsDouble = 0.0;
                    Vision2.viAlign1SearchResultXPos.AsDouble = 0.0;
                    Vision2.viAlign1SearchResultYPos.AsDouble = 0.0;
                    Vision2.ledAlign1SearchResultGood.LED.Value = false;
                    Vision2.ledAlign1SearchResultBad.LED.Value = false;

                    Vision2.viAlign2SearchScore.AsDouble = 0.0;
                    Vision2.viAlign2SearchResultXPos.AsDouble = 0.0;
                    Vision2.viAlign2SearchResultYPos.AsDouble = 0.0;
                    Vision2.ledAlign2SearchResultGood.LED.Value = false;
                    Vision2.ledAlign2SearchResultBad.LED.Value = false;
                    
                    Vision2.viAlign3SearchScore.AsDouble = 0.0;
                    Vision2.viAlign3SearchResultXPos.AsDouble = 0.0;
                    Vision2.viAlign3SearchResultYPos.AsDouble = 0.0;
                    Vision2.ledAlign3SearchResultGood.LED.Value = false;
                    Vision2.ledAlign3SearchResultBad.LED.Value = false;
                    
                    Vision2.viAlign4SearchScore.AsDouble = 0.0;
                    Vision2.viAlign4SearchResultXPos.AsDouble = 0.0;
                    Vision2.viAlign4SearchResultYPos.AsDouble = 0.0;
                    Vision2.ledAlign4SearchResultGood.LED.Value = false;
                    Vision2.ledAlign4SearchResultBad.LED.Value = false;
                    
                    Vision2.viAngleDiff.AsDouble = 0.0;
                    Vision2.viAlign1OffsetX.AsDouble = 0.0;
                    Vision2.viAlign1OffsetY.AsDouble = 0.0;
                    Vision2.viAlign2OffsetX.AsDouble = 0.0;
                    Vision2.viAlign2OffsetY.AsDouble = 0.0;

                    Table2.AlignShift.x = 0;
                    Table2.AlignShift.y = 0.0;

                    Table2.LastStep = 0;

                    Table2.GetReadyPos(Table2.PageIndex);

                    Table2.Step = 20;
                    break;

                case 20: //Table1 Ready Pos 이동
                    if (Table2.UseVision)
                    {
                        // MoveAlign#1Pos
                        Table2.GetPageInfo(Table2.PageIndex);
                        Table2.Step = 110;
                    }
                    else
                    {
                        // Vision 사용하지 않음 가공 위치로..
                        logger.SendMsg("        Table2.SkipVision");
                        logger.SendMsg("");

                        if (Pmac.ZInTargetPos(Common.edTable2VisionZFocus.Value))
                        {
                            Pmac.ZMoveAbs(Common.edTable2VisionZFocus.Value);
                        }

                        Table2.Step = 1100;
                    }
                    break;
                /* ======================================================================
                 * Align Pos
                 */

                // @@ MoveAlign#1Pos --------------------------------------------------
                case 110: // Move Align#1 Pos
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table2.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable2VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table2.Align1Pos.x) != true) 
                        || (Pmac.Y2InTargetPos(Table2.Align1Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table2.MoveAlign1Pos({0})", Table2.Align1Pos.ToString()));

                        Pmac.XMoveAbs(Table2.Align1Pos.x);
                        Pmac.Y2MoveAbs(Table2.Align1Pos.y);
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);

                        Counter.Start();
                        Table2.Step = 112;
                    }
                    else
                    {
                        Table2.Step = 130;
                    }
                    break;

                case 112: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut)) // Motor 기동 시간 < Sys.Time)
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table2.Step = 120;
                    }
                    break;

                case 120: // Align#1 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY2MotionDone.AsBoolean) /*&& (Global.chY2InPosition.AsBoolean)*/
                            && (Pmac.XInTargetPos(Table2.Align1Pos.x)) 
                                && (Pmac.Y2InTargetPos(Table2.Align1Pos.y))
                                    && (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble)))
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table2.Step = 121;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut)) // Align#1 pos 이동 최대 5.0초
                    {
                        Counter.Stop();

                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_MOVE_ALIGN1_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table2.Step = 121;
#endif
                    break;

                case 121:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table2.Step = 130;
                    }
                    break;

                case 130: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start(); // Vision1ReplyTimeOut;    // Align#1 응답 시간 최대 3.0초

                    Vision2.Search1();

                    Table2.Step = 131;
                    break;

                case 131:
#if _VISION
                    if (Vision2.SearchOK)
                    {
                        Vision2.ledAlign1SearchResultGood.LED.Value = true;
                        Vision2.ledAlign1SearchResultBad.LED.Value = false;

                        Vision2.viAlign1SearchScore.AsDouble = Vision2.SearchScore;
                        Vision2.viAlign1SearchResultXPos.AsDouble = Vision2.SearchResultXPos;
                        Vision2.viAlign1SearchResultYPos.AsDouble = Vision2.SearchResultYPos;

                        logger.SendMsg("        Align1SearchOK = true");

                        Table2.Step = 140;
                    }
                    else
                    {
                        Vision2.ledAlign1SearchResultGood.LED.Value = false;
                        Vision2.ledAlign1SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align1SearchOK = false");
                        AddError(Const.ERROR_TABLE2_VISION_ALIGN1_SEARCH_FAIL);

                        Table2.LastStep = Table2.Step;
                        Table2.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision2.ledAlign1SearchResultGood.LED.Value = true;
                    Table2.Step = 140;
#endif
                    break;

                case 140: // Vision 응답 대기
                    if ((Table2.AlignMethod == AlignMethod.Align2P_1_2)
                        || (Table2.AlignMethod == AlignMethod.Align4P))
                    {
                        Table2.Step = 210;
                    }
                    else
                    if (Table2.AlignMethod == AlignMethod.Align2P_1_3)
                    {
                        Table2.Step = 310;
                    }
                    else
                    if (Table2.AlignMethod == AlignMethod.Align2P_1_4)
                    {
                        Table2.Step = 410;
                    }
                    break;

                // @@ MoveAlign#2Pos --------------------------------------------------
                case 210:
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table2.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable2VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table2.Align2Pos.x) != true) 
                        || (Pmac.Y2InTargetPos(Table2.Align2Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table2.MoveAlign2Pos({0})", Table2.Align2Pos.ToString()));

                        Pmac.XMoveAbs(Table2.Align2Pos.x);
                        Pmac.Y2MoveAbs(Table2.Align2Pos.y);
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);

                        Counter.Start();
                        Table2.Step = 212;
                    }
                    else
                    {
                        Table2.Step = 230;
                    }
                    break;

                case 212: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Stop();

                        Counter.Start();
                        Table2.Step = 220;
                    }
                    break;

                case 220: // Align#1 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY2MotionDone.AsBoolean) /*&& (Global.chY2InPosition.AsBoolean) */
                            && (Pmac.XInTargetPos(Table2.Align2Pos.x)) 
                                && (Pmac.Y2InTargetPos(Table2.Align2Pos.y))
                                    && (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble)))
                    {
                        Counter.Start();
                        Table2.Step = 221;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_MOVE_ALIGN2_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table2.Step = 221;
#endif
                    break;

                case 221:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table2.Step = 230;
                    }
                    break;

                case 230: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start();

                    if (!Table2.UseIndividualAlignMark())
                    {
                        Vision2.Search1();
                    }
                    else
                    {
                        Vision2.Search2();
                    }

                    Table2.Step = 231;
                    break;

                case 231:
#if _VISION
                    if (Vision2.SearchOK)
                    {
                        Vision2.ledAlign2SearchResultGood.LED.Value = true;
                        Vision2.ledAlign2SearchResultBad.LED.Value = false;

                        Vision2.viAlign2SearchScore.AsDouble = Vision2.SearchScore;
                        Vision2.viAlign2SearchResultXPos.AsDouble = Vision2.SearchResultXPos;
                        Vision2.viAlign2SearchResultYPos.AsDouble = Vision2.SearchResultYPos;

                        logger.SendMsg("        Align2SearchOK = true");

                        Table2.Step = 240;
                    }
                    else
                    {
                        Vision2.ledAlign2SearchResultGood.LED.Value = false;
                        Vision2.ledAlign2SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align2SearchOK = false");
                        AddError(Const.ERROR_TABLE2_VISION_ALIGN2_SEARCH_FAIL);

                        Table2.LastStep = Table2.Step;
                        Table2.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision2.ledAlign2SearchResultGood.LED.Value = true;
                    Table2.Step = 240;
#endif
                    break;

                case 240: // Vision 응답 대기
                    if (Table2.AlignMethod == AlignMethod.Align2P_1_2) // Vision 2Point
                    {
                        // MoveReadyPos
                        Table2.Step = 1100;
                    }
                    else
                    if (Table2.AlignMethod == AlignMethod.Align4P)
                    {
                        // MoveAlign#3Pos
                        Table2.Step = 310;
                    }
                    break;

                // @@ MoveAlign#3Pos --------------------------------------------------
                case 310: // Move Align#3 Pos
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table2.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable2VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table2.Align3Pos.x) != true) 
                        || (Pmac.Y2InTargetPos(Table2.Align3Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table2.MoveAlign3Pos({0})", Table2.Align3Pos.ToString()));
                        
                        Pmac.XMoveAbs(Table2.Align3Pos.x);
                        Pmac.Y2MoveAbs(Table2.Align3Pos.y);
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);

                        Counter.Start();
                        Table2.Step = 312;
                    }
                    else
                    {
                        Table2.Step = 330;
                    }
                    break;

                case 312: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table2.Step = 320;
                    }
                    break;

                case 320: // Align#3 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY2MotionDone.AsBoolean == true) /*&& (Global.chY2InPosition.AsBoolean == true)*/
                            && (Pmac.XInTargetPos(Table2.Align3Pos.x) == true) 
                                && (Pmac.Y2InTargetPos(Table2.Align3Pos.y) == true)
                                   && (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble)))
                    {
                        Counter.Start();
                        Table2.Step = 321;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_MOVE_ALIGN2_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table2.Step = 321;
#endif
                    break;

                case 321:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table2.Step = 330;
                    }
                    break;

                case 330: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start();

                    Vision2.Search1();

                    Table2.Step = 331;
                    break;

                case 331:
#if _VISION
                    if (Vision2.SearchOK)
                    {
                        Vision2.ledAlign3SearchResultGood.LED.Value = true;
                        Vision2.ledAlign3SearchResultBad.LED.Value = false;

                        Vision2.viAlign3SearchScore.AsDouble = Vision2.SearchScore;
                        Vision2.viAlign3SearchResultXPos.AsDouble = Vision2.SearchResultXPos;
                        Vision2.viAlign3SearchResultYPos.AsDouble = Vision2.SearchResultYPos;

                        logger.SendMsg("        Align3SearchOK = true");
                        AddError(Const.ERROR_TABLE2_VISION_ALIGN3_SEARCH_FAIL);

                        Table2.Step = 340;
                    }
                    else
                    {
                        Vision2.ledAlign3SearchResultGood.LED.Value = false;
                        Vision2.ledAlign3SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align3SearchOK = false");
                        AddError(Const.ERROR_TABLE2_VISION_ALIGN3_SEARCH_FAIL);

                        Table2.LastStep = Table2.Step;
                        Table2.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision2.ledAlign3SearchResultBad.LED.Value = true;
                    Table2.Step = 340;
#endif
                    break;

                case 340: // Vision 응답 대기
                    if (Table2.AlignMethod == AlignMethod.Align2P_1_3) // Vision 3Point
                    {
                        // MoveReadyPos
                        Table2.Step = 1100;
                    }
                    else
                    if (Table2.AlignMethod == AlignMethod.Align4P)
                    {
                        // MoveAlign#4Pos
                        Table2.Step = 410;
                    }
                    break;

                // @@ MoveAlign#4Pos --------------------------------------------------
                case 410: // Move Align#1 Pos
                    logger.SendMsg("");
                    logger.SendMsg("    Change Table2.VisionFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable2VisionFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if ((Pmac.XInTargetPos(Table2.Align4Pos.x) != true) 
                        || (Pmac.Y2InTargetPos(Table2.Align4Pos.y) != true)
                            || (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble) != true))
                    {
                        logger.SendMsg(String.Format("    Table2.MoveAlig4Pos({0})", Table2.Align4Pos.ToString()));
                        
                        Pmac.XMoveAbs(Table2.Align4Pos.x);
                        Pmac.Y2MoveAbs(Table2.Align4Pos.y);
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);

                        Counter.Start();
                        Table2.Step = 412;
                    }
                    else
                    {
                        Table2.Step = 430;
                    }
                    break;

                case 412: // 기동 Delay
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table2.Step = 420;
                    }
                    break;

                case 420: // Align#1 Pos 도착 확인, 
#if _PMAC
                    if ((Global.chY2MotionDone.AsBoolean == true) /*&& (Global.chY2InPosition.AsBoolean == true)*/
                            && (Pmac.XInTargetPos(Table2.Align4Pos.x) == true) 
                                && (Pmac.Y2InTargetPos(Table2.Align4Pos.y) == true)
                                    && (Pmac.ZInTargetPos(Global.chTable2VisionZFocus.AsDouble)))

                    {
                        Counter.Start();
                        Table2.Step = 421;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_MOVE_ALIGN4_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table2.Step = 421;
#endif
                    break;

                case 421:
                    if (Counter.isTimeOver(MotorStopTime))
                    {
                        Table2.Step = 430;
                    }
                    break;

                case 430: // Vision 찍어라!!
                    logger.SendMsg("");
                    Counter.Start();

                    Vision2.Search1();
                    
                    Table2.Step = 431;
                    break;

                case 431:
#if _VISION
                    if (Vision2.SearchOK)
                    {
                        Vision2.ledAlign4SearchResultGood.LED.Value = true;
                        Vision2.ledAlign4SearchResultBad.LED.Value = false;

                        Vision2.viAlign4SearchScore.AsDouble = Vision2.SearchScore;
                        Vision2.viAlign4SearchResultXPos.AsDouble = Vision2.SearchResultXPos;
                        Vision2.viAlign4SearchResultYPos.AsDouble = Vision2.SearchResultYPos;

                        logger.SendMsg("        Align4SearchOK = true");

                        Table2.Step = 440;
                    }
                    else
                    {
                        Vision2.ledAlign4SearchResultGood.LED.Value = false;
                        Vision2.ledAlign4SearchResultBad.LED.Value = true;

                        logger.SendMsg("        Align4SearchOK = false");
                        AddError(Const.ERROR_TABLE2_VISION_ALIGN4_SEARCH_FAIL);

                        Table2.LastStep = Table2.Step;
                        Table2.Step = Const.CASE_VISION_ERROR;
                    }
#else
                    Vision2.ledAlign4SearchResultGood.LED.Value = true;
                    Table2.Step = 440;
#endif
                    break;

                case 440: // Vision 응답 대기
                    Table2.Step = 1100;
                    break;

                /* ======================================================================
                 * Vision을 찍었으면 보정 하고..
                 * 가공 대기 위치로 출발
                 */
                case 1100:  // 가공 대기 위치로 출발
                    logger.SendMsg("    Change Table2.LaserFocusLightValue");
                    frmMain.Manual.Light.WriteChannelValue(1, frmMain.Config.Common.edTable2LaserFocusLightValue.AsInteger);
                    frmMain.Manual.Light.ReadChannelValue();
                    frmMain.Manual.Light.LightOn();

                    if (Table2.UseVision)
                    {
                        logger.SendMsg("");
                        logger.SendMsg("    Table2.Calc...");

                        double Align1ResultX = Table2.Align1Pos.x + Vision2.viAlign1SearchResultXPos.AsDouble;
                        double Align1ResultY = Table2.Align1Pos.y + Vision2.viAlign1SearchResultYPos.AsDouble;

                        double Align2ResultX = Table2.Align2Pos.x + Vision2.viAlign2SearchResultXPos.AsDouble;
                        double Align2ResultY = Table2.Align2Pos.y + Vision2.viAlign2SearchResultYPos.AsDouble;

                        double Rad = Math.Atan2(Table2.Align2Pos.y - Table2.Align1Pos.y, Table2.Align2Pos.x - Table2.Align1Pos.x);
                        Rad = Rad * (180.0 / Math.PI);
                        Vision2.viAngle0.AsDouble = Rad;

                        Rad = Math.Atan2(Align2ResultY - Align1ResultY, Align2ResultX - Align1ResultX);
                        Rad = Rad * (180.0 / Math.PI);
                        Vision2.viAngle.AsDouble = Rad;

                        Vision2.viAngleDiff.AsDouble = Vision2.viAngle0.AsDouble - Vision2.viAngle.AsDouble;
                        
                        logger.SendMsg(String.Format("        Vision2.Align1Pos = ({0:F3}, {1:F3})", Align1ResultX, Align1ResultY));
                        logger.SendMsg(String.Format("        Vision2.Align2Pos = ({0:F3}, {1:F3})", Align2ResultX, Align2ResultY));
                        logger.SendMsg(String.Format("        Vision2.Angle = {0:F3}", Vision2.viAngleDiff.AsDouble));

                        DoublePoint CenterPos = new DoublePoint(Table2.CenterPos.x, Table2.CenterPos.y);
                        DoublePoint NewAlign1Pos = new DoublePoint(0.0, 0.0);
                        DoublePoint NewAlign2Pos = new DoublePoint(0.0, 0.0);

                        logger.SendMsg(String.Format("        Table2.CenterPos = {0:F3}, {1:F3}", Table2.CenterPos.x, Table2.CenterPos.y));

                        dkCommon.GetRotatorPos(CenterPos, Table2.Align1Pos, -Vision2.viAngleDiff.AsDouble, ref NewAlign1Pos);
                        dkCommon.GetRotatorPos(CenterPos, Table2.Align2Pos, -Vision2.viAngleDiff.AsDouble, ref NewAlign2Pos);

                        logger.SendMsg(String.Format("        Table2.NewAlign1Pos = ({0:F3})", NewAlign1Pos));
                        logger.SendMsg(String.Format("        Table2.NewAlign2Pos = ({0:F3})", NewAlign2Pos));

                        Vision2.viAlign1OffsetX.AsDouble = Align1ResultX - NewAlign1Pos.x;
                        Vision2.viAlign1OffsetY.AsDouble = Align1ResultY - NewAlign1Pos.y;

                        Vision2.viAlign2OffsetX.AsDouble = Align2ResultX - NewAlign2Pos.x;
                        Vision2.viAlign2OffsetY.AsDouble = Align2ResultY - NewAlign2Pos.y;

                        Table2.AlignShift = new DoublePoint(0, 0);

                        Table2.AlignShift.x = (Vision2.viAlign1OffsetX.AsDouble + Vision2.viAlign2OffsetX.AsDouble) / 2;
                        Table2.AlignShift.y = (Vision2.viAlign1OffsetY.AsDouble + Vision2.viAlign2OffsetY.AsDouble) / 2;

                        logger.SendMsg(String.Format("        AlignShift = {0:F3}, {1:F3}", Table2.AlignShift.x, Table2.AlignShift.y));
                    }

                    /*
                     * viAlign1Offset, viALign2Offset의 차이를 비교하여 일정 이상이면 Error을 띄워야 한다.
                     */

                    if ((Math.Abs(Vision2.viAlign1OffsetX.AsDouble - Vision2.viAlign2OffsetX.AsDouble) > 0.03)
                            || (Math.Abs(Vision2.viAlign1OffsetY.AsDouble - Vision2.viAlign2OffsetY.AsDouble) > 0.03))
                    {
                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_VISION_SHIFT_OFFSET_OVER;         // 도착 시간 TIME OVER
                        AddError(Const.ERROR_TABLE2_VISION_SHIFT_OFFSET_OVER);

                        Table2.Step = Const.CASE_ERROR;
                    }
                    else
                    {
                        logger.SendMsg(String.Format("        Table2.MoveReadyPos({0})", Table2.ReadyPos.ToString()));
                        Table2.Step = 1101;
                    }
                    break;

                case 1101:
#if _PMAC
                    if ((Pmac.XInTargetPos(Table2.ReadyPos.x) != true) 
                        || (Pmac.Y2InTargetPos(Table2.ReadyPos.y) != true))
                    {
                        Pmac.XMoveAbs(Table2.ReadyPos.x);
                        Pmac.Y2MoveAbs(Table2.ReadyPos.y);

                        if (btnLaserRun.LED.Value)
                        {
                            if (Pmac.ZInTargetPos(Table2.GetZPosition()) != true)
                            {
                                Pmac.ZMoveAbs(Table2.GetZPosition());
                            }
                        }
                        else
                        {
                            if (Pmac.ZInTargetPos(Common.edTable2VisionZFocus.Value) != true)
                            {
                                Pmac.ZMoveAbs(Common.edTable2VisionZFocus.Value);
                            }
                        }

                        Counter.Start();
                        Table2.Step = 1110;
                    }
                    else
                    {
                        Table2.Step = 1120;
                    }
#else
                    Counter.Start();

                    Table2.Step = 1110;
#endif
                    break;

                case 1110:
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table2.Step = 1111;
                    }
                    break;

                case 1111: // 가공 대기 위치 도착 확인, 
#if _PMAC
                    if ((Global.chY2MotionDone.AsBoolean == true) /*&& (Global.chY2InPosition.AsBoolean == true)*/
                            && (Pmac.XInTargetPos(Table2.ReadyPos.x) == true) 
                                && (Pmac.Y2InTargetPos(Table2.ReadyPos.y) == true))
                    {
                        if (btnLaserRun.LED.Value)
                        {
                            if (Pmac.ZInTargetPos(Table2.GetZPosition()) == true)
                            {
                                Table2.Step = 1120;
                            }
                            else
                            if (Counter.isTimeOver(MotorMoveTimeOut))
                            {
                                Table2.LastStep = Table2.Step;
                                Table2.ErrorCode = Const.ERROR_TABLE2_MOVE_READY_POS_TIME_OVER;         // 도착 시간 TIME OVER

                                Table2.Step = Const.CASE_ERROR;
                            }
                        }
                        else
                        {
                            Table2.Step = 1120;
                        }
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut))
                    {
                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_MOVE_READY_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Table2.Step = 1120;
#endif
                    break;

                case 1120: // MotionDownload 요청
                    SetLaserPower(TableNo.Table2, Table2.JobInfo.TabControl2.SelectedIndex);
                    SetPulseWidth(TableNo.Table2, Table2.JobInfo.TabControl2.SelectedIndex); 
                    SetPulsePitch(TableNo.Table2, Table2.JobInfo.TabControl2.SelectedIndex);
                    
                    logger.SendMsg("");
                    frmMotionFile.Memo1.Clear();
                    Table2.MakeMotionFile(Vision2.viAngleDiff.AsDouble, Table2.AlignShift, btnLaserRun.LED.Value);

                    Table2.LayerIndex = (-1);
                    if (Pmac.DownloadFile2(Handle) == 0)
                    {
                        Counter.Start();
                        Table2.Step = 1170;
                    }
                    else
                    {
                        Counter.Start();
                        Table2.Step = 1150;
                    }
                    break;

                case 1150:

                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        Counter.Start();
                        Table2.Step = 1160;
                    }
                    break;

                case 1160:
#if _PMAC
                    if (frmMotionFile.MessageQueue.Count > 100)
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table2.Step = 1170;
                    }
                    else
                    if (Counter.isTimeOver(2000))
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table2.Step = 1170;
                    };
#else
                    Counter.Start();

                    Table2.Step = 1170;
#endif
                    break;

                case 1170:
#if _PMAC
                    int r;
                    Pmac.QueryCommand("M0", out r);

                    if (r == 0)
                    {
                        Counter.Stop();

                        if (frmMotionFile.isStartAble())
                        {
                            Counter.Start();

                            Table2.Step = 1180;
                        }
                        else
                        {
                            AddError(Const.ERR0R_MOTIONFILE_INVALID_DATA);
                            Table2.Step = Const.CASE_ERROR;
                        };
                    }
                    else
                    if (Counter.isTimeOver(5000))
                    {
                        Counter.Stop();

                        Table2.Step = Const.CASE_ERROR;
                    };
#else
                    Counter.Start();

                    Table2.Step = 1175;
#endif
                    break;

                case 1175://laser power, pitch set
                    Counter.Stop();

                    Counter.Start();

                    Table2.Step = 1180;
                    break;

                case 1180:
                    Counter.Stop();

                    Table2.LayerIndex = Table2.GetLayerIndex(Table2.LayerIndex + 1);
                    if (Table2.LayerIndex >= 0)
                    {
                        logger.AddSeparator();
                        logger.SendMsg(String.Format("        Layer = [{0}]", Table2.Layers[Table2.LayerIndex].Name));
                        logger.SendMsg(String.Format("        Table2.Motion[{0}].Run()~~", Table2.LayerIndex + 200));
                        Pmac.QueryCommand(String.Format("&1b{0}r", Table2.LayerIndex + 200));

                        Counter.Start();

                        Table2.Step = 1190;
                    }
                    else
                    {
                        Table2.Step = 2000;
                    }
                    break;

                case 1190:
                    if (Counter.isTimeOver(10))
                    {
                        Counter.Stop();

                        Counter.Start();

                        Table2.Step = 1200;
                    }
                    break;

                case 1200:
#if _PMAC
                    if (Global.chCoord1Running)
                    {
                        Counter.Start();

                        Table2.Step = 1210;
                    }
                    else
                    if (Counter.isTimeOver(5000))
                    {
                        logger.SendMsg("TABLE2_COORD1_START_TIME_OVER");

                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_COORD1_START_TIME_OVER;

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Table2.Step = 1210;
#endif
                    break;

                case 1210:
#if _PMAC
                    if (!Global.chCoord1Running)
                    {
                        Counter.Start();

                        Table2.Step = 1220;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 60 * 5))
                    {
                        Table2.LastStep = Table2.Step;
                        Table2.ErrorCode = Const.ERROR_TABLE2_COORD1_STOP_TIME_OVER;

                        Table2.Step = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();

                    Table2.Step = 1220;
#endif
                    break;

                case 1220:
                    if (Counter.isTimeOver(100))
                    {
                        logger.SendMsg("        Table2.MotionFinish~~");

                        Table2.Step = 1180;
                    }
                    break;

                /* ======================================================================
                 * Motion 완료 후 Load 위치로 이동
                 */
                case 2000:
                    Table2.PageIndex = Table2.GetNextPage(Table2.PageIndex + 1);
                    if (Table2.PageIndex > (-1))
                    {
                        logger.AddSeparator();
                        logger.SendMsg(String.Format("        Table2.PageIndex = {0}/{1}/{2}", Table2.PageIndex, Table2.PageCount, Table2.TotalPageCount));

                        Table2.Step = 10;
                    }
                    else
                    {
                        stopwatch.Stop();

                        viTable2CycleTime.AsDouble = stopwatch.ElapsedMilliseconds / 1000.0;

                        if (!Pmac.XInTargetPos(Table2.LoadPos.x))
                        {
                            Pmac.XMoveAbs(Table2.LoadPos.x);
                        }

                        logger.AddSeparator();
                        logger.SendMsg("        Table2.Unload~~");

                        if (frmMain.Config.Common.chkVacuumAutoRelease.Checked)
                        {
                            Pmac.QueryCommand("Table2VacuumAutoRelease=true");
                        }
                        Pmac.QueryCommand("Table2Unload=true");
                        Pmac.QueryCommand("Table2New=false");

                        Counter.Start();
                        Table2.Step = 2010;
                    }
                    break;

                case 2010:
                    if (Counter.isTimeOver(100))
                    {
                        Counter.Stop();

                        Table2.Step = 2100;
                    }
                    break;

                /* ======================================================================
                * Motion 완료 후 Load 위치로 이동
                */
                case 2100: // 투입 위치로 출발
                    if ((Pmac.XInTargetPos(Table2.LoadPos.x) != true))
                    {
                        Pmac.XMoveAbs(Table2.LoadPos.x);

                        Counter.Start();
                        Table2.Step = 2110;
                    }
                    else
                    {
                        Table2.Step = 3000;
                    }

                    break;

                case 2110:
                    if (Counter.isTimeOver(MotorMoveStartTimeOut))
                    {
                        Counter.Start();

                        Table2.Step = 3000;
                    }
                    break;

                /* ======================================================================
                 * Jog로 대기위치로 이동 
                 */
                case 3000:
#if !Pmac
                    Global.Table1New = false;
                    Global.Table2New = false;
#endif
                    Table2.Step = Const.CASE_DONE;
                    break;

                case Const.CASE_VISION_ERROR:

                    frmRestart.TopMost = true;
                    frmRestart.lblMessage.Text = "Vision Align Search Error.";

                    frmRestart.Start = false;
                    frmRestart.Stop = false;
                    frmRestart.StartPosition = FormStartPosition.CenterScreen;

                    frmRestart.Show();
                    frmRestart.AutoThread.Enabled = true;

                    frmMain.ButtonEnables(true);
                    frmVision.ButtonEnables(true);

                    Table2.Step = Const.CASE_VISION_ERROR + 1;
                    break;

                case Const.CASE_VISION_ERROR + 1:

                    if (frmRestart.Start)
                    {
                        Vision2.btnManualSet.LED.Value = false;

                        frmRestart.Close();

                        btnReset_Click(null, null);
                        btnReset_Click(null, null);

                        frmMain.ButtonEnables(false);
                        frmVision.ButtonEnables(false);

                        Table2.Step = Table2.LastStep;
                    } 
                    else
                    if (frmRestart.Stop)
                    {
                        Vision2.btnManualSet.LED.Value = false;

                        frmRestart.Close();

                        btnReset_Click(null, null);
                        btnReset_Click(null, null);

                        if (!Pmac.XInTargetPos(Table2.LoadPos.x))
                        {
                            Pmac.XMoveAbs(Table2.LoadPos.x);
                        }

                        if (frmMain.Config.Common.chkVacuumAutoRelease.Checked)
                        {
                            Pmac.QueryCommand("Table2VacuumAutoRelease=true");
                        }

                        Pmac.QueryCommand("Table2Unload=true");
                        Pmac.QueryCommand("Table2New=false");

                        Pmac.QueryCommand("doTable2IonizerOn=false");
                        Pmac.QueryCommand("doTable2IonizerSol=false");

                        Table2.Step = Const.CASE_ERROR;
                    }                    
                    break;

                case Const.CASE_DONE:
                    Pmac.QueryCommand("Table2Busy=false");

                    Pmac.QueryCommand("doTable2IonizerOn=false");
                    Pmac.QueryCommand("doTable2IonizerSol=false");

                    Table2.Step = 0;
                    break;

                case Const.CASE_ABORT:
                    Pmac.XStop();
                    Pmac.Y2Stop();

                    Counter.Start();
                    Table2.Step = Const.CASE_ABORT + 1;
                    break;

                case Const.CASE_ABORT + 1:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        Table2.Step = Const.CASE_ABORT + 2;
                    }
                    break;

                case Const.CASE_ABORT + 2:

                    if (!Pmac.XInTargetPos(Table2.LoadPos.x))
                    {
                        Pmac.XMoveAbs(Table2.LoadPos.x);
                    }

                    if (frmMain.Config.Common.chkVacuumAutoRelease.Checked)
                    {
                        Pmac.QueryCommand("Table2VacuumAutoRelease=true");
                    }
                    Pmac.QueryCommand("Table2Unload=true");
                    
                    Pmac.QueryCommand("Table2New=false");
                    Pmac.QueryCommand("Table2Busy=false");

                    Pmac.QueryCommand("doTable2IonizerOn=false");
                    Pmac.QueryCommand("doTable2IonizerSol=false");

                    Table2.Step = Const.CASE_ABORT + 3;
                    break;

                case Const.CASE_ABORT + 3:
                    Global.Table2New = false;
                    Table2.Stop = false;
                    Table2.Step = 0;

                    if (btnStopPressed)
                    {
                        Command = Command.Stop;
                        btnStopPressed = false;
                    }

                    break;

                case Const.CASE_ERROR:
                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    Pmac.QueryCommand("doLaserTriggerOn=false");

                    Pmac.QueryCommand("Table2Busy=false");
                    Pmac.QueryCommand("Table2New=false");

                    Pmac.QueryCommand("doTable2IonizerOn=false");
                    Pmac.QueryCommand("doTable2IonizerSol=false");

                    lblTable2ErrorStep.Text = String.Format("{0}", Table2.LastStep);

                    Global.Table2New = false;
                    Table2.Stop = false;
                    Table2.Step = 0;
                    break;
            }
        }
#endregion

        private void DoStop()
        {
            Table1.Step = 0;
            Table2.Step = 0;

            errorProcessor1.ReleaseError(Const.NOW_START_READY);
            errorProcessor1.ReleaseError(Const.NOW_TABLE1_RUNNING);
            errorProcessor1.ReleaseError(Const.NOW_TABLE2_RUNNING);
            errorProcessor1.ReleaseError(Const.NOW_RUNNING);

            Pmac.QueryCommand("doDustCollectorOn=false");

            Command = Command.Ready;
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmMain.MenuIndex == 10)
            {
                frmMain.ChangeAutoTitle();
            }

            mTabIndex = TabControl1.SelectedIndex;

            if (mTabIndex == 0)
            {
                Vision1.BringToFront();
                SideMenu.tabControl2.SelectedIndex = 0;

                TabControl1.TabSelectedColor = Color.Lime;
                TabControl1.TabSelectedForeColor = Color.Black;
                TabControl1.TabSelectedHighColor = Color.Red;

                Table1.JobInfo.TabControl2.TabSelectedColor = Color.Lime;
                Table1.JobInfo.TabControl2.TabSelectedForeColor = Color.Black;
                Table1.JobInfo.TabControl2.TabSelectedHighColor = Color.Red;

                frmMain.lblMainTitle.ForeColor = Color.Lime;
                frmVision.lblTitle.Text = "Table1 - Vision";
                frmVision.lblTitle.ForeColor = Color.Lime;
            }
            else
            if (mTabIndex == 1)
            {
                Vision2.BringToFront();
                SideMenu.tabControl2.SelectedIndex = 1;

                TabControl1.TabSelectedColor = Color.Yellow;
                TabControl1.TabSelectedForeColor = Color.Black;
                TabControl1.TabSelectedHighColor = Color.Red;

                Table2.JobInfo.TabControl2.TabSelectedColor = Color.Yellow;
                Table2.JobInfo.TabControl2.TabSelectedForeColor = Color.Black;
                Table2.JobInfo.TabControl2.TabSelectedHighColor = Color.Red;

                frmMain.lblMainTitle.ForeColor = Color.Yellow;
                frmVision.lblTitle.Text = "Table2 - Vision";
                frmVision.lblTitle.ForeColor = Color.Yellow;
            }

            if (frmVision.Visible)
            {
                frmMVS.UpdateThread1.Enabled = (mTabIndex == 0);
                frmMVS.UpdateThread2.Enabled = (mTabIndex == 1);
            }
        }

        private void SetLaserPower(TableNo ATableNo, int ATabCtrlIndex)
        {
            double dPower = 0.0;
            if(ATableNo == TableNo.Table1)
            {
                if (ATabCtrlIndex == 0)
                {
                    dPower = Table1.LaserProject.Model1.LaserPower;
                }
                else
                if (ATabCtrlIndex == 1)
                {
                    dPower = Table1.LaserProject.Model2.LaserPower;
                }
                else
                if (ATabCtrlIndex == 2)
                {
                    dPower = Table1.LaserProject.Model3.LaserPower;
                }
            }
            else
            if (ATableNo == TableNo.Table2)
            {
                if (ATabCtrlIndex == 0)
                {
                    dPower = Table2.LaserProject.Model1.LaserPower;
                }
                else
                if (ATabCtrlIndex == 1)
                {
                    dPower = Table2.LaserProject.Model2.LaserPower;
                }
                else
                if (ATabCtrlIndex == 2)
                {
                    dPower = Table2.LaserProject.Model3.LaserPower;
                }
            }

            logger.SendMsg(String.Format("        Table{0}.SetLaserPower({1:F3})", (int)ATableNo, dPower));
#if _CARBIDE
            frmMain.Manual.Laser.SetAttenuator(dPower);
#endif
        }

        private void SetPulsePitch(TableNo ATableNo, int ATabControlIndex)
        {
            double dPitch = 0.0;

            if (ATableNo == TableNo.Table1)
            {
                if (ATabControlIndex == 0)
                {
                    dPitch = Table1.LaserProject.Model1.PulsePitch;
                }
                else
                if (ATabControlIndex == 1)
                {
                    dPitch = Table1.LaserProject.Model2.PulsePitch;
                }
                else
                if (ATabControlIndex == 2)
                {
                    dPitch = Table1.LaserProject.Model3.PulsePitch;
                }
            }
            else
            if (ATableNo == TableNo.Table2)
            {
                if (ATabControlIndex == 0)
                {
                    dPitch = Table2.LaserProject.Model1.PulsePitch;
                }
                else
                if (ATabControlIndex == 1)
                {
                    dPitch = Table2.LaserProject.Model2.PulsePitch;
                }
                else
                if (ATabControlIndex == 2)
                { 
                    dPitch = Table2.LaserProject.Model3.PulsePitch;
                }
            }

            logger.SendMsg(String.Format("        Table{0}.SetPulsePitch({1:F3})", (int)ATableNo, dPitch));
            if (frmMain.Manual.ADV.IsConnected())
            {
                frmMain.Manual.ADV.SetMode2Pitch(dPitch);
            }
        }

        private void SetPulseWidth(TableNo ATableNo, int ATabControlIndex)
        {
            double dPulseWidth = 2.0;
            logger.SendMsg(String.Format("        Table{0}.SetPulseWidth({1:F3})", (int)ATableNo, dPulseWidth));
            if (frmMain.Manual.ADV.IsConnected())
            {
                frmMain.Manual.ADV.SetMode2Pitch(dPulseWidth);
            }
        }

        bool isJobFileError()
        {
            bool Result = false;

            if (ledTable1JobFileLoad.LED.Value)
            {
                if (!Table1.isStartAble())
                {
                    errorProcessor1.AddError(Const.ERROR_TABLE1_JOBFILE_INVALID_PARAMETER);
                    Result = true;
                }
            }

            if (ledTable2JobFileLoad.LED.Value)
            {
                if (!Table2.isStartAble())
                {
                    errorProcessor1.AddError(Const.ERROR_TABLE2_JOBFILE_INVALID_PARAMETER);
                    Result = true;
                }
            }

            return Result;
        }

        public bool isAutoReady()
        {
            bool Result = true;

            if (!frmMain.Manual.Laser.btnShutterOpen.LED.Value) Result = false;
            if (!Pmac.XInTargetPos(Global.chLoadPosX.AsDouble)) Result = false;
            if (!Pmac.Y1InTargetPos(Table1.LoadPos.y)) Result = false;
            if (!Pmac.Y2InTargetPos(Table2.LoadPos.y)) Result = false;

            return Result;
        }

        public bool isStartAble()
        {
            bool Result = true;

#if _PMAC
            if (!Global.chXHome.AsBoolean) Result = false;
            if (!Global.chXServoOn.AsBoolean) Result = false;
            if (Global.chXAlarm.AsBoolean) Result = false;
            if (Global.chXCCW.AsBoolean) Result = false;
            if (Global.chXCW.AsBoolean) Result = false;

            if (!Global.chY1Home.AsBoolean) Result = false;
            if (!Global.chY1ServoOn.AsBoolean) Result = false;
            if (Global.chY1Alarm.AsBoolean) Result = false;
            if (Global.chY1CCW.AsBoolean) Result = false;
            if (Global.chY1CW.AsBoolean) Result = false;

            if (!Global.chY2Home.AsBoolean) Result = false;
            if (!Global.chY2ServoOn.AsBoolean) Result = false;
            if (Global.chY2Alarm.AsBoolean) Result = false;
            if (Global.chY2CCW.AsBoolean) Result = false;
            if (Global.chY2CW.AsBoolean) Result = false;

            if (!Global.chZHome.AsBoolean) Result = false;
            if (!Global.chZServoOn.AsBoolean) Result = false;
            if (Global.chZAlarm.AsBoolean) Result = false;
            if (Global.chZCCW.AsBoolean) Result = false;
            if (Global.chZCW.AsBoolean) Result = false;

            if (Common.chkAreaSensorUse.Checked && !ledTable1AreaSensor.LED.Value)
            {
                errorProcessor1.AddError(Const.ERROR_TABLE1_AREA_SENSOR);
                Result = false;
            }

            if (Common.chkAreaSensorUse.Checked && !ledTable2AreaSensor.LED.Value)
            {
                errorProcessor1.AddError(Const.ERROR_TABLE2_AREA_SENSOR);
                Result = false;
            }
#endif

            if (btnLaserRun.LED.Value && !frmMain.Manual.Laser.isLaserOn())
            {
                errorProcessor1.AddError(Const.ERROR_LASER_POWER_OFF);
                Result = false;
            }
#if (_MVS)

            if (!Global.CameraInitial)
            {
                errorProcessor1.AddError(Const.ERROR_CAMERA_INITIAL_FAIL);
                Result = false;
            }
#endif
            return Result;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStopPressed = false;
            if (btnAutoReady.LED.Value)
            {
                if (isStartAble())
                {
                    if (ledTable1JobFileLoad.LED.Value || ledTable2JobFileLoad.LED.Value)
                    {
                        if (ledTable1JobFileLoad.LED.Value)
                        {
                            // Shift가 있을때.. 경고 메세지
                            if (Table1.JobInfo.TabControl2.SelectedIndex == 0)
                            {
                                Table1.JobInfo.Type1.btnSave_Click(null, null);
                            }
                            else
                            if (Table1.JobInfo.TabControl2.SelectedIndex == 1)
                            {
                                Table1.JobInfo.Type2.btnSave_Click(null, null);
                            }
                            else
                            if (Table1.JobInfo.TabControl2.SelectedIndex == 2)
                            {
                                Table1.JobInfo.Type3.btnSave_Click(null, null);
                            }
                        }

                        if (ledTable2JobFileLoad.LED.Value)
                        {
                            if (Table2.JobInfo.TabControl2.SelectedIndex == 0)
                            {
                                Table2.JobInfo.Type1.btnSave_Click(null, null);
                            }
                            else
                            if (Table2.JobInfo.TabControl2.SelectedIndex == 1)
                            {
                                Table2.JobInfo.Type2.btnSave_Click(null, null);
                            }
                            else
                            if (Table2.JobInfo.TabControl2.SelectedIndex == 2)
                            {
                                Table2.JobInfo.Type3.btnSave_Click(null, null);
                            }
                        }

                        if (isJobFileError() == false)
                        {
                            btnStart.LED.Value = true;
                            btnStop.LED.Value = false;

                            Command = Command.Start;

                            ButtonEnables(false);
                            frmMain.ButtonEnables(false);
                            frmVision.ButtonEnables(false);

                            Pmac.QueryCommand("doBeamShutterOpen=true");

                            Table1.EnableControl(false);
                            Table2.EnableControl(false);

                            Global.isChangeAble = false;
                        }
                    }
                    else
                    {
                        errorProcessor1.AddError(Const.ERROR_JOBFILE_LOAD);
                    }
                }
            }
            else
            {

            }
        }

        public void ButtonEnables(bool enable)
        {
            btnAutoReady.Enabled = enable;

            btnLaserRun.Enabled = enable;
            btnDryRun.Enabled = enable;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStopPressed = true;

            Table1.EnableControl(ledTable1JobFileLoad.LED.Value);
            Table2.EnableControl(ledTable2JobFileLoad.LED.Value);

            btnStart.LED.Value = false;
            btnStop.LED.Value = true;
            btnAutoReady.LED.Value = false;

            if (Table1.Step > 0)
            {
                Table1.Stop = true;
            }

            if (Table2.Step > 0)
            {
                Table2.Stop = true;
            }

            if ((Table1.Step == 0) && (Table2.Step == 0))
            {
                Command = Command.Stop;
            }

            Pmac.QueryCommand("Table1New=false");
            Pmac.QueryCommand("Table2New=false");

            if (Common.chkVacuumAutoRelease.Checked)
            {
                Pmac.QueryCommand("Table1VacuumOff=true");
                Pmac.QueryCommand("Table2VacuumOff=true");
            }

            Pmac.QueryCommand("Table1Busy=false");
            Pmac.QueryCommand("Table2Busy=false");

            frmMain.ButtonEnables(true);
            frmVision.ButtonEnables(true);
            ButtonEnables(true);

            Global.isChangeAble = true;
        }

        private void panMain_Load(object sender, EventArgs e)
        {
            /*
             * ztCad가 하도 많아서.. Event가 어느 넘에게 갔는지 알수가 없음..
             */
            Table1.JobInfo.SetEventProc();

            btnStop_Click(null, null);
        }

        public bool mMoveStage;

        private void btnAutoReady_Click(object sender, EventArgs e)
        {
            if (!btnAutoReady.LED.Value)
            {
                Table1.LoadPos.x = frmMain.Config.Common.edLoadPosX.Value;
                Table1.LoadPos.y = frmMain.Config.Common.edLoadPosY1.Value;

                Table2.LoadPos.x = frmMain.Config.Common.edLoadPosX.Value;
                Table2.LoadPos.y = frmMain.Config.Common.edLoadPosY2.Value;

                if (ledTable1JobFileLoad.LED.Value || ledTable2JobFileLoad.LED.Value)
                {

                    if (isAutoReady())
                    {
                        if (btnStop.LED.Value)
                        {
                            btnAutoReady.LED.Value = !btnAutoReady.LED.Value;

                            Command = Command.Ready;

                            if (btnAutoReady.LED.Value)
                            {
                                Pmac.QueryCommand("Table1Ready=true");
                                Pmac.QueryCommand("Table2Ready=true");
                            }
                            else
                            {
                                Pmac.QueryCommand("Table1Ready=false");
                                Pmac.QueryCommand("Table2Ready=false");
                                Pmac.QueryCommand("Table1New=false");
                                Pmac.QueryCommand("Table2New=false");
                            }

                            frmMain.Manual.ADV.btnMode2Set_Click(null, null);
                        }
                    }
                    else
                    {
                        Command = Command.AutoReady;
                    }
                }
                else
                {
                    errorProcessor1.AddError(Const.ERROR_JOBFILE_LOAD);
                }
            } 
            else
            {
                btnAutoReady.LED.Value = false;
            }
        }

        private void ledTable1CycleStop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (ledTable1CycleStop.LED.Value)
            {
                logger.SendMsg("    Table1CycleStop");
                Table1.Stop = true;
            }
        }

        private void ledTable1Stop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (ledTable1Stop.LED.Value)
            {
                logger.SendMsg("    Table1Stop");
                Table1.Stop = true;
            }
        }

        private void ledTable2CycleStop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (ledTable2CycleStop.LED.Value)
            {
                logger.SendMsg("    Table2CycleStop");
                Table2.Stop = true;
            }
        }

        private void ledTable2Stop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (ledTable2Stop.LED.Value)
            {
                logger.SendMsg("    Table2Stop");
                Table2.Stop = true;
            }
        }

        private void btnTable1New_Click(object sender, EventArgs e)
        {
            if (dkCommon.IsCtrlKeyDown())
            {
                if (ledTable1JobFileLoad.LED.Value && btnAutoReady.LED.Value && btnStart.LED.Value)
                {
#if _PMAC
                    Pmac.QueryCommand("Table1New=true");
                    Pmac.QueryCommand("Table1VacuumOn=true");

#else
                    Global.Table1New = true;
#endif
                }
                else
                {
                    errorProcessor1.AddError(Const.ERROR_TABLE1_JOBFILE_LOAD);
                }
            }
        }

        public void AddError(int AErrorCode)
        {
            errorProcessor1.AddError(AErrorCode);
        }

        public void ErrorReset()
        {
            previousErrorCodes.Clear();
            errorProcessor1.ResetError();
            listView1.Items.Clear();

            Global.ciMainPower.AsBoolean = true;
            Global.ciEMO1.AsBoolean = false;
            Global.ciEMO2.AsBoolean = false;
            Global.ciEMO3.AsBoolean = false;

            Global.ciTable1PressureSensor.AsBoolean = true;
            Global.ciTable2PressureSensor.AsBoolean = true;

            Global.ciStagePower.AsBoolean = true;
            Global.ciLeakSensor.AsBoolean = true;

            Global.ciDoorSensor1.AsBoolean = true;
            Global.ciDoorSensor2.AsBoolean = true;
            Global.ciDoorSensor3.AsBoolean = true;
            Global.ciDoorSensor4.AsBoolean = true;
            Global.ciDoorSensor5.AsBoolean = true;

            Global.ciTable1AreaSensor.AsBoolean = true;
            Global.ciTable2AreaSensor.AsBoolean = true;

            Global.chXServoOn.AsBoolean = true;
            Global.chY1ServoOn.AsBoolean = true;
            Global.chY2ServoOn.AsBoolean = true;
            Global.chZServoOn.AsBoolean = true;

            Global.chXCCW.AsBoolean = false;
            Global.chY1CCW.AsBoolean = false;
            Global.chY2CCW.AsBoolean = false;
            Global.chZCCW.AsBoolean = false;

            Global.chXCW.AsBoolean = false;
            Global.chY1CW.AsBoolean = false;
            Global.chY2CW.AsBoolean = false;
            Global.chZCW.AsBoolean = false;

            Global.chXAlarm.AsBoolean = false;
            Global.chY1Alarm.AsBoolean = false;
            Global.chY2Alarm.AsBoolean = false;
            Global.chZAlarm.AsBoolean = false;

            // 특정 오류 코드를 True로 설정
            //ErrorBits[ERR_NOW_HANDLER_RUN_READY] = true;
            //ErrorBits[ERR_NOW_HANDLER_AUTO_RUN] = true;

            // frmClipper에서 QueryCommand 실행
            // frmClipper.QueryCommand("ExtStop = 0");

            Pmac.QueryCommand("doTowerLampBuzzer=false");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (Global.coTowerLampBuzzer.AsBoolean)
            {
                Pmac.QueryCommand("doTowerLampBuzzer=false");
                Global.coTowerLampBuzzer.AsBoolean = false;
            }
            else
            {
                btnReset.LED.Blink = false;
                btnReset.LED.Value = false;
                BlinkThread.Enabled = false;

                ErrorReset();
            }
        }

        #region public void ChangeLanguageEnglish() 
        public void ChangeLanguageEnglish()
        {
            btnAutoReady.Text = Global.iniEng.ReadString("panAuto", "btnReady.Text", "Ready");
            btnStart.Text = Global.iniEng.ReadString("panAuto", "btnStart.Text", "Start");
            btnStop.Text = Global.iniEng.ReadString("panAuto", "btnStop.Text", "Stop");
            btnReset.Text = Global.iniEng.ReadString("panAuto", "btnReset.Text", "Reset");
        }

        public void ChangeLanguageKorea()
        {
            btnAutoReady.Text   = Global.GetIniLanguageValue(Global.iniKor, "panAuto", "btnReady.Text");
            btnStart.Text   = Global.GetIniLanguageValue(Global.iniKor, "panAuto", "btnStart.Text");
            btnStop.Text    = Global.GetIniLanguageValue(Global.iniKor, "panAuto", "btnStop.Text");
            btnReset.Text   = Global.GetIniLanguageValue(Global.iniKor, "panAuto", "btnReset.Text");
        }

        public void ChangeLanguageVietnam()
        {
            btnAutoReady.Text = Global.GetIniLanguageValue(Global.iniVie, "panAuto", "btnReady.Text"); 
            btnStart.Text = Global.GetIniLanguageValue(Global.iniVie, "panAuto", "btnStart.Text");
            btnStop.Text = Global.GetIniLanguageValue(Global.iniVie, "panAuto", "btnStop.Text");
            btnReset.Text = Global.GetIniLanguageValue(Global.iniVie, "panAuto", "btnReset.Text"); 
        }
        #endregion

        private void btnLaserRun_Click(object sender, EventArgs e)
        {
            btnLaserRun.LED.Value = true;
            btnDryRun.LED.Value = false;

            frmMain.Manual.Laser.btnShutterOpen_Click(null, null);
            Pmac.QueryCommand("doBeamShutterOpen=true");
        }

        private void btnDryRun_Click(object sender, EventArgs e)
        {
            btnLaserRun.LED.Value = false;
            btnDryRun.LED.Value = true;

            frmMain.Manual.Laser.btnShutterClose_Click(null, null);
            Pmac.QueryCommand("doBeamShutterOpen=false");
        }

        private void btnTable2New_Click(object sender, EventArgs e)
        {
            if (dkCommon.IsCtrlKeyDown())
            {
                if (ledTable2JobFileLoad.LED.Value && btnAutoReady.LED.Value && btnStart.LED.Value)
                {
#if _PMAC
                    Pmac.QueryCommand("Table2New=true");
                    Pmac.QueryCommand("Table2VacuumOn=true");
#else
                    Global.Table2New = true;
#endif
                }
                else
                {
                    errorProcessor1.AddError(Const.ERROR_TABLE2_JOBFILE_LOAD);
                }
            }
        }

        public bool isAutoRun()
        {
            return btnStart.LED.Value;
        }

        public bool isAutoRun(TableNo tableNo)
        {
            if (tableNo == TableNo.Table1)
            {
                return isAutoRun() && (Table1.Step > 0);
            }
            else
            if (tableNo == TableNo.Table2)
            {
                return isAutoRun() && (Table2.Step > 0);
            }
            else
            {
                return false;
            }
        }

        private void errorProcessor1_OnAlarmOccured(object arg1, string arg2)
        {
            CodeSite.SendMsg(String.Format("AlarmOccurred = {0}", arg2));
        }

        private void errorProcessor1_OnAlarmReleased(object arg1, string arg2)
        {
            CodeSite.SendMsg(String.Format("AlarmReleased = {0}", arg2));
        }

        private HashSet<string> previousErrorCodes = new HashSet<string>();

        private void errorProcessor1_OnErrorOccured(object arg1, string arg2)
        {
            // 현재 에러 코드를 ',' 기준으로 분리
            string[] currentErrorCodes = arg2.Split(',');
            HashSet<string> currentErrorSet = new HashSet<string>(currentErrorCodes);

            // 추가해야 할 에러 코드와 삭제해야 할 에러 코드를 구분
            var newErrors = currentErrorSet.Except(previousErrorCodes);
            var resolvedErrors = previousErrorCodes.Except(currentErrorSet);

            // 삭제할 에러 코드가 있을 경우 ListView에서 제거
            foreach (string resolvedError in resolvedErrors)
            {
                var itemToRemove = listView1.Items.Cast<ListViewItem>()
                    .FirstOrDefault(item => item.SubItems[1].Text == resolvedError);
                if (itemToRemove != null)
                {
                    listView1.Items.Remove(itemToRemove);
                }
            }

            // 새로운 에러 코드가 있을 경우 ListView에 추가
            foreach (string newError in newErrors)
            {
                if (!string.IsNullOrWhiteSpace(newError))
                {
                    int code = dkCommon.StrToIntDef(newError, 0);
                    string szDesc = errorProcessor1.ErrorCode2Desc(code);
                    if (szDesc == "") szDesc = "(no error desc)";

                    ListViewItem item = new ListViewItem(listView1.Items.Count.ToString()); // ID
                    item.SubItems.Add(newError);  // No
                    item.SubItems.Add(szDesc);    // Action
                    item.SubItems.Add(DateTime.Now.ToString("HH:mm:ss")); // Time

                    bool inserted = false;
                    for (int j = 0; j < listView1.Items.Count; j++)
                    {
                        int existingCode = dkCommon.StrToIntDef(listView1.Items[j].SubItems[1].Text, 0);
                        if (code < existingCode)
                        {
                            listView1.Items.Insert(j, item);
                            inserted = true;
                            break;
                        }
                    }

                    if (!inserted)
                    {
                        listView1.Items.Add(item);
                    }

                    // 타워 램프 제어
                    if (code < 800)
                    {
                        Pmac.QueryCommand("doTowerLampRed=true");
                        Pmac.QueryCommand("doTowerLampYellow=false");
                        Pmac.QueryCommand("doTowerLampGreen=false");

                       // AddError(code);
                        logger.SendMsg(String.Format("        ERR:{0}, {1}", newError, szDesc));

                        btnReset.LED.Blink = true;
                        BlinkThread.Enabled = true;

                        Pmac.QueryCommand("doTowerLampBuzzer=true");
                        Global.coTowerLampBuzzer.AsBoolean = true;
                    }
                    else 
                    if (btnAutoReady.LED.Value)
                    {
                        if (!btnStart.LED.Value)
                        {
                            Pmac.QueryCommand("doTowerLampRed=false");
                            Pmac.QueryCommand("doTowerLampYellow=true");
                            Pmac.QueryCommand("doTowerLampGreen=false");
                        }
                        else
                        {
                            Pmac.QueryCommand("doTowerLampRed=false");
                            Pmac.QueryCommand("doTowerLampYellow=false");
                            Pmac.QueryCommand("doTowerLampGreen=true");
                        }
                    }
                }
            }

            // 현재 에러 코드를 이전 에러 코드로 업데이트
            previousErrorCodes = currentErrorSet;
        }
   
        private void errorProcessor1_OnErrorReleased(object arg1, string arg2)
        {    // 해제된 에러 코드를 ',' 기준으로 분리
            string[] releasedErrorCodes = arg2.Split(',');

            foreach (string code in releasedErrorCodes)
            {
                // 빈 문자열이 아닌 경우에만 처리
                if (!string.IsNullOrWhiteSpace(code))
                {
                    // ListView에서 해당 error code를 가진 항목을 찾고 삭제
                    foreach (ListViewItem item in listView1.Items)
                    {
                        // No 컬럼에 해당 error code가 있는지 확인
                        if (item.SubItems[1].Text == code)
                        {
                            listView1.Items.Remove(item);
                            break; // 항목을 삭제했으므로 내부 루프를 빠져나감
                        }
                    }
                }
            }
        }

        private void ledRunStatus_DoubleClick(object sender, EventArgs e)
        {
            ledRunStatus.LED.Value = !ledRunStatus.LED.Value;

            panRunStatus.Visible = ledRunStatus.LED.Value;
        }

        private void ledTable1AreaSensor_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (!ledTable1AreaSensor.LED.Value && frmMain.Config.Common.chkAreaSensorUse.Checked)
            {
                if ((Table1.Step > 0) && (Table1.Step < Const.CASE_VISION_ERROR))
                {
                    logger.SendMsg("    Const.ERR_TABLE1_AREA_SENSOR_ERROR");
                    AddError(Const.ERROR_TABLE1_AREA_SENSOR);

                    if (ledCoord1ProgRunning.LED.Value)
                    {
                        Pmac.QueryCommand("&1a");
                        Pmac.QueryCommand("doLaserTriggerOn=false");

                        Global.Table1New = false;
                        Pmac.QueryCommand("Table1New=false");
                        Global.Table2New = false;
                        Pmac.QueryCommand("Table2New=false");
                    }

                    Table1.Step = Const.CASE_ERROR;
                }
                else
                if (!Global.chY1MotionDone.AsBoolean)
                {
                    logger.SendMsg("    Const.ERR_TABLE1_AREA_SENSOR_ERROR");
                    AddError(Const.ERROR_TABLE1_AREA_SENSOR);

                    Pmac.Y1Stop();
                }
            }
        }
        
        private void ledTable2AreaSensor_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (!ledTable2AreaSensor.LED.Value && frmMain.Config.Common.chkAreaSensorUse.Checked)
            {
                if ((Table2.Step > 0) && (Table2.Step < Const.CASE_VISION_ERROR))
                {
                    logger.SendMsg("    Const.ERR_TABLE2_AREA_SENSOR_ERROR");
                    AddError(Const.ERROR_TABLE2_AREA_SENSOR);

                    if (ledCoord1ProgRunning.LED.Value)
                    {
                        Pmac.QueryCommand("&1a");
                        Pmac.QueryCommand("doLaserTriggerOn=false");

                        Global.Table1New = false;
                        Pmac.QueryCommand("Table1New=false");
                        Global.Table2New = false;
                        Pmac.QueryCommand("Table2New=false");

                    }

                    Table2.Step = Const.CASE_ERROR;
                }
                else
                if (!Global.chY2MotionDone.AsBoolean)
                {
                    logger.SendMsg("    Const.ERR_TABLE2_AREA_SENSOR_ERROR");
                    AddError(Const.ERROR_TABLE2_AREA_SENSOR);

                    Pmac.Y2Stop();
                }
            }
        }

        private void BlinkThread_OnExecute(object sender, EventArgs e)
        {
            btnReset.LED.Value = !btnReset.LED.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viTable1InputCount.AsInteger = 0;
            viTable2InputCount.AsInteger = 0;
        }

        private void ledTable1JobFileLoad_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (ledTable1JobFileLoad.LED.Value)
            {
                ledTable1JobFileLoad.Text = "Load";

                Pmac.QueryCommand("Table1Project=true");
            }
            else
            {
                ledTable1JobFileLoad.Text = "Load Error";

                Pmac.QueryCommand("Table1Project=false");
            }
        }

        private void ledTable2JobFileLoad_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (ledTable2JobFileLoad.LED.Value)
            {
                ledTable2JobFileLoad.Text = "Load";

                Pmac.QueryCommand("Table2Project=true");
            }
            else
            {
                ledTable2JobFileLoad.Text = "Load Error";

                Pmac.QueryCommand("Table2Project=false");
            }
        }

        private void ledShowStep_DoubleClick(object sender, EventArgs e)
        {
            ledShowStep.LED.Value = !ledShowStep.LED.Value;

            Global.chShowStep = ledShowStep.LED.Value;
        }

        private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = (Global.isChangeAble == false);
            
            if (Global.isAutoRun) Global.isChangeAble = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ledRunStatus.ForeColor = Color.Black;
            CodeSite.SendMsg(String.Format("ledRunstatus.Text = {0}", ledRunStatus.Text));

            Global.isChangeAble = true;
            TabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.isChangeAble = true;
            TabControl1.SelectedIndex = 1;
        }
    }
}