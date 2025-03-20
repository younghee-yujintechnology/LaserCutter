using YujinTechnology;
using Raize.CodeSiteLogging;
using System;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class panConfigCommon : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();
        
        private frmMain frmMain;
        private frmChannelSpy frmChannelSpy;
        private frmRunStatus frmRunStatus;

        public panAuto Auto;
        public panSideMenu SideMenu;

        private const int X_AXIS_NO = 1;
        private const int Y1_AXIS_NO = 2;
        private const int Y2_AXIS_NO = 3;
        private const int Z_AXIS_NO = 5;

        private LoadDir mTable1LoadDir = LoadDir.Center;
        private LoadDir mTable2LoadDir = LoadDir.Center;

        public DoublePoint TableCenter;
        public DoublePoint[] TableBasePos = new DoublePoint[5];

        private int CurrentStep = 0, nIndex = 0;
        TimeCounter Counter = new TimeCounter();
        private double OldPulsePitch = 0;
        private double OldPulseWidth = 0;

        public panConfigCommon()
        {
            // logger.SendMsg("panConfigCommon()");

            InitializeComponent();

            staticInstance = this;

            frmMain = frmMain.StaticInstance;
            frmChannelSpy = frmChannelSpy.StaticInstance;
            frmRunStatus = frmRunStatus.StaticInstance;
            
            logger.Category = "Config.Common";
            cbTable1UseVacuumCount.SelectedIndex = 0;
            cbTable2UseVacuumCount.SelectedIndex = 0;
        }

        #region public static panConfigCommon StaticInstance
        private static panConfigCommon staticInstance;
        public static panConfigCommon StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panConfigCommon();
                }
                return staticInstance;
            }
        }
        #endregion

        #region public void ChannelAssign()
        public void ChannelAssign()
        {
            SetDataServer(this.Controls);

            #region Display Set
            edHomeOffsetPosX.ChannelName = "HomeOffset_Pos_X";
            edHomeOffsetPosY1.ChannelName = "HomeOffset_Pos_Y1";
            edHomeOffsetPosY2.ChannelName = "HomeOffset_Pos_Y2";
            edHomeOffsetPosZ.ChannelName = "HomeOffset_Pos_Z";
            edLoadPosX.ChannelName = "Load_Pos_X";
            edLoadPosY1.ChannelName = "Load_Pos_Y1";
            edLoadPosY2.ChannelName = "Load_Pos_Y2";
            edLoadPosZ.ChannelName = "Load_Pos_Z";
            edTableSizeX.ChannelName = "TableSize_X";
            edTableSizeY.ChannelName = "TableSize_Y";

            edLineSpeed.ChannelName = "Line_Speed";
            edLineTA.ChannelName = "Line_TA";
            edArcSpeed.ChannelName = "Arc_Speed";
            edArcTA.ChannelName = "Arc_TA";
            edJumpSpeed.ChannelName = "Jump_Speed";
            edJumpTA.ChannelName = "Jump_TA";

            edPowerMeterXPos.ChannelName = "PowerMeter_Pos_X";
            edPowerMeterZPos.ChannelName = "PowerMeter_Pos_Z";
            
            edTable1LaserZFocus.ChannelName = "Table1LaserZFocus";
            edTable1VisionZFocus.ChannelName = "Table1VisionZFocus";
            edTable2LaserZFocus.ChannelName = "Table2LaserZFocus";
            edTable2VisionZFocus.ChannelName = "Table2VisionZFocus";

            edTable2NozzleXOffset.ChannelName = "Table1NozzleXOffset";
            edTable2NozzleYOffset.ChannelName = "Table1NozzleYOffset";
                
            //cbManualAlign.chann

            chkDoorAlarmUse.ChannelName = "CenterDoor Use";
            chkVacAlarmUse.ChannelName = "Alarm Use";
            chkVacuumAutoRelease.ChannelName = "Release Use";

            //productinput

            cbTable1LoadDir.DataServer = DataServer;
            cbTable1LoadDir.ChannelName = "Table1LoadDir";

            edTable1LeftBottomYPos.ChannelName = "Table1LeftBottomYPos";
            edTable1LeftBottomXPos.ChannelName = "Table1LeftBottomXPos";

            edTable1LeftTopYPos.ChannelName = "Table1LeftTopYPos";
            edTable1LeftTopXPos.ChannelName = "Table1LeftTopXPos";

            edTable1RightTopYPos.ChannelName = "Table1RightTopYPos";
            edTable1RightTopXPos.ChannelName = "Table1RightTopXPos";

            edTable1RightBottomYPos.ChannelName = "Table1RightBottomYPos";
            edTable1RightBottomXPos.ChannelName = "Table1RightBottomXPos";

            edTable1CenterYPos.ChannelName = "Table1CenterYPos";
            edTable1CenterXPos.ChannelName = "Table1CenterXPos";

            cbTable2LoadDir.DataServer = DataServer;
            cbTable2LoadDir.ChannelName = "Table2LoadDir";

            edTable2LeftBottomYPos.ChannelName = "Table2LeftBottomYPos";
            edTable2LeftBottomXPos.ChannelName = "Table2LeftBottomXPos";

            edTable2LeftTopYPos.ChannelName = "Table2LeftTopYPos";
            edTable2LeftTopXPos.ChannelName = "Table2LeftTopXPos";

            edTable2RightTopYPos.ChannelName = "Table2RightTopYPos";
            edTable2RightTopXPos.ChannelName = "Table2RightTopXPos";

            edTable2RightBottomYPos.ChannelName = "Table2RightBottomYPos";
            edTable2RightBottomXPos.ChannelName = "Table2RightBottomXPos";

            edTable2CenterYPos.ChannelName = "Table2CenterYPos";
            edTable2CenterXPos.ChannelName = "Table2CenterXPos";

            edTable2LeftTopYPos.ChannelName = "Table2LeftTopYPos";
            edTable2LeftTopXPos.ChannelName = "Table2LeftTopXPos";

            edTable2RightTopYPos.ChannelName = "Table2RightTopYPos";
            edTable2RightTopXPos.ChannelName = "Table2RightTopXPos";

            edTable2RightBottomYPos.ChannelName = "Table2RightBottomYPos";
            edTable2RightBottomXPos.ChannelName = "Table2RightBottomXPos";

            edTable2CenterYPos.ChannelName = "Table2CenterYPos";
            edTable2CenterXPos.ChannelName = "Table2CenterXPos";

            chkAreaSensorUse.ChannelName = "AreaSensor Use";
            chkAreaSensorVacuumUse.ChannelName = "AreaSensor_Vacuum Use";
            edAccelerationG.ChannelName = "AccelerationG";

            edAutoRunSpeedStage.ChannelName = "AutoRunSpeedStage";
            edAutoRunSpeedZ.ChannelName = "AutoRunSpeedZ";

            Global.chConHomeOffsetPosX = DataServer.Channels.Find(edHomeOffsetPosX.ChannelName);
            Global.chConHomeOffsetPosY1 = DataServer.Channels.Find(edHomeOffsetPosY1.ChannelName);
            Global.chConHomeOffsetPosY2 = DataServer.Channels.Find(edHomeOffsetPosY2.ChannelName);
            Global.chConHomeOffsetPosZ = DataServer.Channels.Find(edHomeOffsetPosZ.ChannelName);
            Global.chLoadPosX = DataServer.Channels.Find(edLoadPosX.ChannelName);
            Global.chTable1LoadPosY = DataServer.Channels.Find(edLoadPosY1.ChannelName);
            Global.chTable2LoadPosY = DataServer.Channels.Find(edLoadPosY2.ChannelName);
            Global.chConLoadPosZ = DataServer.Channels.Find(edLoadPosZ.ChannelName);
            Global.chConTableSizeX = DataServer.Channels.Find(edTableSizeX.ChannelName);
            Global.chConTableSizeY = DataServer.Channels.Find(edTableSizeY.ChannelName);
            Global.chConLineSpeed = DataServer.Channels.Find(edLineSpeed.ChannelName);
            Global.chConLineTA = DataServer.Channels.Find(edLineTA.ChannelName);
            Global.chConArcSpeed = DataServer.Channels.Find(edArcSpeed.ChannelName);
            Global.chConArcTA = DataServer.Channels.Find(edArcTA.ChannelName);
            Global.chConJumpSpeed = DataServer.Channels.Find(edJumpSpeed.ChannelName);
            Global.chConJumpTA = DataServer.Channels.Find(edJumpTA.ChannelName);
            Global.chConPowerMeterPosX = DataServer.Channels.Find(edPowerMeterXPos.ChannelName);
            Global.chConPowerMeterPosZ = DataServer.Channels.Find(edPowerMeterZPos.ChannelName);
            Global.chConCenterDoorUse = DataServer.Channels.Find(chkDoorAlarmUse.ChannelName);
            Global.chConVacuumAlarmUse = DataServer.Channels.Find(chkVacAlarmUse.ChannelName);
            Global.chConVacuumReleaseUse = DataServer.Channels.Find(chkVacuumAutoRelease.ChannelName);

            Global.chTable1LaserZFocus = DataServer.Channels.Find(edTable1LaserZFocus.ChannelName);
            Global.chTable1VisionZFocus = DataServer.Channels.Find(edTable1VisionZFocus.ChannelName);
            Global.chTable2LaserZFocus = DataServer.Channels.Find(edTable2LaserZFocus.ChannelName);
            Global.chTable2VisionZFocus = DataServer.Channels.Find(edTable2VisionZFocus.ChannelName);

            Global.chTable1NozzleXOffset = DataServer.Channels.Find(edTable2NozzleXOffset.ChannelName);
            Global.chTable1NozzleYOffset = DataServer.Channels.Find(edTable2NozzleYOffset.ChannelName);

            Global.chTable1LeftBottomYPos = DataServer.Channels.Find(edTable1LeftBottomYPos.ChannelName);
            Global.chTable1LeftBottomXPos = DataServer.Channels.Find(edTable1LeftBottomXPos.ChannelName);

            Global.chTable1LeftTopYPos = DataServer.Channels.Find(edTable1LeftTopYPos.ChannelName);
            Global.chTable1LeftTopXPos = DataServer.Channels.Find(edTable1LeftTopXPos.ChannelName);

            Global.chTable1RightBottomYPos = DataServer.Channels.Find(edTable1RightBottomYPos.ChannelName);
            Global.chTable1RightBottomXPos = DataServer.Channels.Find(edTable1RightBottomXPos.ChannelName);

            Global.chTable1RightTopYPos = DataServer.Channels.Find(edTable1RightTopYPos.ChannelName);
            Global.chTable1RightTopXPos = DataServer.Channels.Find(edTable1RightTopXPos.ChannelName);

            Global.chTable1CenterYPos = DataServer.Channels.Find(edTable1CenterYPos.ChannelName);
            Global.chTable1CenterXPos = DataServer.Channels.Find(edTable1CenterXPos.ChannelName);

            Global.chTable2LeftBottomYPos = DataServer.Channels.Find(edTable2LeftBottomYPos.ChannelName);
            Global.chTable2LeftBottomXPos = DataServer.Channels.Find(edTable2LeftBottomXPos.ChannelName);

            Global.chTable2LeftTopYPos = DataServer.Channels.Find(edTable2LeftTopYPos.ChannelName);
            Global.chTable2LeftTopXPos = DataServer.Channels.Find(edTable2LeftTopXPos.ChannelName);

            Global.chTable2RightTopYPos = DataServer.Channels.Find(edTable2RightTopYPos.ChannelName);
            Global.chTable2RightTopXPos = DataServer.Channels.Find(edTable2RightTopXPos.ChannelName);

            Global.chTable2RightBottomYPos = DataServer.Channels.Find(edTable2RightBottomYPos.ChannelName);
            Global.chTable2RightBottomXPos = DataServer.Channels.Find(edTable2RightBottomXPos.ChannelName);

            Global.chTable2CenterYPos = DataServer.Channels.Find(edTable2CenterYPos.ChannelName);
            Global.chTable2CenterXPos = DataServer.Channels.Find(edTable2CenterXPos.ChannelName);

            Global.chTable1LoadDir = DataServer.Channels.Find(cbTable1LoadDir.ChannelName);
            Global.chTable2LoadDir = DataServer.Channels.Find(cbTable2LoadDir.ChannelName);

            Global.chAreaSensorUse = DataServer.Channels.Find(chkAreaSensorUse.ChannelName);
            Global.chAreaSensorVacuumUse = DataServer.Channels.Find(chkAreaSensorVacuumUse.ChannelName);
            Global.chAccelerationG = DataServer.Channels.Find(edAccelerationG.ChannelName);

            Global.chAutoRunSpeedStage = DataServer.Channels.Find(edAutoRunSpeedStage.ChannelName);
            Global.chAutoRunSpeedZ = DataServer.Channels.Find(edAutoRunSpeedZ.ChannelName);

            //cbManualAlign

            #endregion
        }
        #endregion
        #region public void LoadChannelInfo()
        public void LoadChannelInfo()
        {
            String szPath = String.Format("{0}Config\\ConfigCommonChannels.csv", yjCommon.AppPath());
            if (yjCommon.FileExists(szPath))
            {
                DataServer.LoadFromCSV(szPath);

                if (frmChannelSpy != null)
                {
                    frmChannelSpy.propGridConfig.DataServer = DataServer;
                    frmChannelSpy.propGridConfig.Active = true;
                }
            }
        }
        #endregion

        #region public void SetDataServer(Control.ControlCollection controls)
        public void SetDataServer(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is KeypadEdit)
                {
                    ((KeypadEdit)control).DataServer = DataServer;
                }

                if (control.HasChildren)
                {
                    SetDataServer(control.Controls);
                }
            }
        }
        #endregion
        //Global.chLaserRRD.AsInteger
        private void btnAllSave_Click(object sender, EventArgs e)
        {
            edLineSpeed.Apply();
            edArcSpeed.Apply();
            edJumpSpeed.Apply();

            edLineTA.Apply();
            edArcTA.Apply();
            edJumpTA.Apply();

            edTable1VacuumDelay.Apply();
            edTable2VacuumDelay.Apply();

            propSaver1.SaveProperty();
            propSaver1.LoadProperty();

            OptionApply();
        }
        public void InitControls()
        {
            Auto.Table1.LaserProject.Model1.UseVacuumCount = yjCommon.StrToIntDef(cbTable1UseVacuumCount.Text, 0);
            cbTable1UseVacuumCount.SelectedIndex = yjCommon.StrToIntDef(cbTable1UseVacuumCount.Text, 0) - 1;

            Auto.Table2.LaserProject.Model1.UseVacuumCount = yjCommon.StrToIntDef(cbTable2UseVacuumCount.Text, 0);
            cbTable2UseVacuumCount.SelectedIndex = yjCommon.StrToIntDef(cbTable2UseVacuumCount.Text, 0) - 1;

            OptionApply();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            OptionApply();

            SetTableBasePos();
        }

        public void OptionApply()
        {
            edLineSpeed.Apply();
            edArcSpeed.Apply();
            edJumpSpeed.Apply();

            edLineTA.Apply();
            edArcTA.Apply();
            edJumpTA.Apply();

            edTable1VacuumDelay.Apply();
            edTable2VacuumDelay.Apply();

            edHomeOffsetPosX.Apply();
            edHomeOffsetPosY1.Apply();
            edHomeOffsetPosY2.Apply(); 
            edHomeOffsetPosZ.Apply();

            edLoadPosX.Apply(); 
            edLoadPosY1.Apply();
            edLoadPosY2.Apply();
            edLoadPosZ.Apply();

            edPowerMeterXPos.Apply();
            edPowerMeterZPos.Apply();

            edTable1LeftBottomXPos.Apply();
            edTable1LeftBottomYPos.Apply();

            edTable1LeftTopXPos.Apply();
            edTable1LeftTopYPos.Apply();

            edTable1RightTopXPos.Apply();
            edTable1RightTopYPos.Apply();

            edTable1RightBottomXPos.Apply();
            edTable1RightBottomYPos.Apply();

            edTable1CenterXPos.Apply();
            edTable1CenterYPos.Apply();

            edTable2LeftBottomXPos.Apply();
            edTable2LeftBottomYPos.Apply();

            edTable2LeftTopXPos.Apply();
            edTable2LeftTopYPos.Apply();

            edTable2RightTopXPos.Apply();
            edTable2RightTopYPos.Apply();

            edTable2RightBottomXPos.Apply();
            edTable2RightBottomYPos.Apply();

            edTable2CenterXPos.Apply();
            edTable2CenterYPos.Apply();

            edTable2NozzleXOffset.Apply();
            edTable2NozzleYOffset.Apply();

            edTable1LaserZFocus.Apply();
            edTable1VisionZFocus.Apply();

            edTable2LaserZFocus.Apply();
            edTable2VisionZFocus.Apply();

            edAutoRunSpeedStage.Apply();
            edAutoRunSpeedZ.Apply();

            edTable1VisionFocusLightValue.Apply();
            edTable1LaserFocusLightValue.Apply();
            edTable2VisionFocusLightValue.Apply();
            edTable2LaserFocusLightValue.Apply();

            Pmac.QueryCommand($"P2U_Mach_LookAheadAcc={Global.chAccelerationG.AsDouble}");

            //Vacuum 관련
            Pmac.QueryCommand(string.Format($"Table1VacuumSolCount = {cbTable1UseVacuumCount.SelectedIndex + 1}"));

            Pmac.QueryCommand(string.Format($"Table1VacuumDelayTime = {edTable1VacuumDelay.Value}"));

            Pmac.QueryCommand(string.Format($"Table2VacuumSolCount = {cbTable2UseVacuumCount.SelectedIndex + 1}"));

            Pmac.QueryCommand(string.Format($"Table2VacuumDelayTime={edTable2VacuumDelay.Value}"));
        }

        #region public Table1LoadDir LoadDir
        public LoadDir Table1LoadDir
        {
            get
            {
                return mTable1LoadDir;
            }

            set
            {
                mTable1LoadDir = value;

                ledTable1LeftBottom.LED.Value = (mTable1LoadDir == LoadDir.LeftBottom);
                ledTable1LeftTop.LED.Value = (mTable1LoadDir == LoadDir.LeftTop);
                ledTable1RightBottom.LED.Value = (mTable1LoadDir == LoadDir.RightBottom);
                ledTable1RightTop.LED.Value = (mTable1LoadDir == LoadDir.RightTop);
                ledTable1Center.LED.Value = (mTable1LoadDir == LoadDir.Center);

                cbTable1LoadDir.SelectedIndex = (int)value;

                Auto.Table1.LoadDir = value;
            }
        }
        #endregion

        #region public LoadDir Table2LoadDir
        public LoadDir Table2LoadDir
        {
            get
            {
                return mTable2LoadDir;
            }

            set
            {
                mTable2LoadDir = value;

                ledTable2LeftBottom.LED.Value = (mTable2LoadDir == LoadDir.LeftBottom);
                ledTable2LeftTop.LED.Value = (mTable2LoadDir == LoadDir.LeftTop);
                ledTable2RightBottom.LED.Value = (mTable2LoadDir == LoadDir.RightBottom);
                ledTable2RightTop.LED.Value = (mTable2LoadDir == LoadDir.RightTop);
                ledTable2Center.LED.Value = (mTable2LoadDir == LoadDir.Center);

                cbTable2LoadDir.SelectedIndex = (int)value;
                Auto.Table2.LoadDir = value;
            }
        }
        #endregion

        public void SetVelocity(int nSelectAxis)
        {
            double dSpeed = 0.0;
            double dTA = 0.0;

            if (Global.chSelectSpeed.AsInteger == 0)//Low
            {
                if (nSelectAxis == Z_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[3].JogSpeedLow * 5;
                    dTA = Global.MotionParameters[3].JogTALow / 2;

                    Pmac.ZSetSpeed(dSpeed);
                    Pmac.ZSetTA(dTA);
                    Pmac.ZSetTS(dTA);
                }
                else
                if (nSelectAxis == X_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTALow / 2;//TA /2;

                    Pmac.XSetSpeed(dSpeed);
                    Pmac.XSetTA(dTA);
                    Pmac.XSetTS(dTA);
                }
                else if (nSelectAxis == Y1_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTALow / 2;//TA /2;

                    Pmac.Y1SetSpeed(dSpeed);
                    Pmac.Y1SetTA(dTA);
                    Pmac.Y1SetTS(dTA);
                }
                else
                if (nSelectAxis == Y2_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTALow / 2;//TA /2;

                    Pmac.Y2SetSpeed(dSpeed);
                    Pmac.Y2SetTA(dTA);
                    Pmac.Y2SetTS(dTA);
                }
            }
            else
            if (Global.chSelectSpeed.AsInteger == 1)//Mid
            {
                if (nSelectAxis == Z_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[3].JogSpeedMiddle * 5;
                    dTA = Global.MotionParameters[3].JogTAMiddle / 2;

                    Pmac.ZSetSpeed(dSpeed);
                    Pmac.ZSetTA(dTA);
                    Pmac.ZSetTS(dTA);
                }
                else
                if (nSelectAxis == X_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAMiddle / 2;//TA /2;

                    Pmac.XSetSpeed(dSpeed);
                    Pmac.XSetTA(dTA);
                    Pmac.XSetTS(dTA);
                }
                else
                if (nSelectAxis == Y1_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAMiddle / 2;//TA /2;

                    Pmac.Y1SetSpeed(dSpeed);
                    Pmac.Y1SetTA(dTA);
                    Pmac.Y1SetTS(dTA);
                }
                else
                if (nSelectAxis == Y2_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAMiddle / 2;//TA /2;

                    Pmac.Y2SetSpeed(dSpeed);
                    Pmac.Y2SetTA(dTA);
                    Pmac.Y2SetTS(dTA);
                }
            }
            else
            if (Global.chSelectSpeed.AsInteger == 2)
            {
                if (nSelectAxis == Z_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[3].JogSpeedHigh * 5;
                    dTA = Global.MotionParameters[3].JogTAHigh / 2;
                }
            }
        }

        private void btnSetTable1Pos1_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 Left Bottom 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable1LeftBottomXPos.Value = Global.chXActualPos.AsDouble;
                edTable1LeftBottomYPos.Value = Global.chY1ActualPos.AsDouble;
            }
        }

        private void btnMoveTable1Pos1_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable1LeftBottomXPos.Value);
                Pmac.Y1MoveAbs(edTable1LeftBottomYPos.Value);
                Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable1Pos2_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 Left Top 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable1LeftTopXPos.Value = Global.chXActualPos.AsDouble;
                edTable1LeftTopYPos.Value = Global.chY1ActualPos.AsDouble;
            }
        }
        private void btnMoveTable1Pos2_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable1LeftTopXPos.Value);
                Pmac.Y1MoveAbs(edTable1LeftTopYPos.Value);
                Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
            }
        }


        private void btnSetTable1Pos3_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 Right Top 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable1RightTopXPos.Value = Global.chXActualPos.AsDouble;
                edTable1RightTopYPos.Value = Global.chY1ActualPos.AsDouble;
            }
        }

        private void btnMoveTable1Pos3_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable1RightTopXPos.Value);
                Pmac.Y1MoveAbs(edTable1RightTopYPos.Value);
                Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
            }
        }


        private void btnSetTable1Pos4_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 Right Bottom 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable1RightBottomXPos.Value = Global.chXActualPos.AsDouble;
                edTable1RightBottomYPos.Value = Global.chY1ActualPos.AsDouble;
            }
        }

        private void btnMoveTable1Pos4_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable1RightBottomXPos.Value);
                Pmac.Y1MoveAbs(edTable1RightBottomYPos.Value);
                Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable1Pos5_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 Center 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable1CenterXPos.Value = Global.chXActualPos.AsDouble;
                edTable1CenterYPos.Value = Global.chY1ActualPos.AsDouble;
            }
        }

        private void btnMoveTable1Pos5_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable1CenterXPos.Value);
                Pmac.Y1MoveAbs(edTable1CenterYPos.Value);
                Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable2Pos1_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 Left Bottom 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable2LeftBottomXPos.Value = Global.chXActualPos.AsDouble;
                edTable2LeftBottomYPos.Value = Global.chY2ActualPos.AsDouble;
            }
        }

        private void btnMoveTable2Pos1_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable2LeftBottomXPos.Value);
                Pmac.Y2MoveAbs(edTable2LeftBottomYPos.Value);
                Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable2Pos2_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 Left Top 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable2LeftTopXPos.Value = Global.chXActualPos.AsDouble;
                edTable2LeftTopYPos.Value = Global.chY2ActualPos.AsDouble;
            }
        }
        private void btnMoveTable2Pos2_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable2LeftTopXPos.Value);
                Pmac.Y2MoveAbs(edTable2LeftTopYPos.Value);
                Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable2Pos3_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 Right Top 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable2RightTopXPos.Value = Global.chXActualPos.AsDouble;
                edTable2RightTopYPos.Value = Global.chY2ActualPos.AsDouble;
            }
        }

        private void btnMoveTable2Pos3_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable2RightTopXPos.Value);
                Pmac.Y2MoveAbs(edTable2RightTopYPos.Value);
                Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable2Pos4_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 Right Bottom 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable2RightBottomXPos.Value = Global.chXActualPos.AsDouble;
                edTable2RightBottomYPos.Value = Global.chY2ActualPos.AsDouble;
            }
        }

        private void btnMoveTable2Pos4_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable2RightBottomXPos.Value);
                Pmac.Y2MoveAbs(edTable2RightBottomYPos.Value);
                Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable2Pos5_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 Center 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                edTable2CenterXPos.Value = Global.chXActualPos.AsDouble;
                edTable2CenterYPos.Value = Global.chY2ActualPos.AsDouble;
            }
        }

        private void btnMoveTable2Pos5_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 위치를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable2CenterXPos.Value);
                Pmac.Y2MoveAbs(edTable2CenterYPos.Value);
                Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
        }

        public void SetTableBasePos()
        {
            Auto.Table1.LoadDir = (LoadDir)Global.chTable1LoadDir.AsInteger;

            Auto.Table1.TableBasePos[0] = new DoublePoint(Global.chTable1LeftBottomXPos.AsDouble, Global.chTable1LeftBottomYPos.AsDouble);
            Auto.Table1.TableBasePos[1] = new DoublePoint(Global.chTable1LeftTopXPos.AsDouble, Global.chTable1LeftTopYPos.AsDouble);
            Auto.Table1.TableBasePos[2] = new DoublePoint(Global.chTable1RightTopXPos.AsDouble, Global.chTable1RightTopYPos.AsDouble);
            Auto.Table1.TableBasePos[3] = new DoublePoint(Global.chTable1RightBottomXPos.AsDouble, Global.chTable1RightBottomYPos.AsDouble);
            Auto.Table1.TableBasePos[4] = new DoublePoint(Global.chTable1CenterXPos.AsDouble, Global.chTable1CenterYPos.AsDouble);

            ShowTable1LoadingPos();

            Auto.Table2.LoadDir = (LoadDir)Global.chTable2LoadDir.AsInteger;

            Auto.Table2.TableBasePos[0] = new DoublePoint(Global.chTable2LeftBottomXPos.AsDouble, Global.chTable2LeftBottomYPos.AsDouble);
            Auto.Table2.TableBasePos[1] = new DoublePoint(Global.chTable2LeftTopXPos.AsDouble, Global.chTable2LeftTopYPos.AsDouble);
            Auto.Table2.TableBasePos[2] = new DoublePoint(Global.chTable2RightTopXPos.AsDouble, Global.chTable2RightTopYPos.AsDouble);
            Auto.Table2.TableBasePos[3] = new DoublePoint(Global.chTable2RightBottomXPos.AsDouble, Global.chTable2RightBottomYPos.AsDouble);
            Auto.Table2.TableBasePos[4] = new DoublePoint(Global.chTable2CenterXPos.AsDouble, Global.chTable2CenterYPos.AsDouble);
           
            ShowTable2LoadingPos();
        }

        private void ledLeftTop_Click(object sender, EventArgs e)
        {
            Table1LoadDir = LoadDir.LeftTop;            
        }

        private void ledLeftBottom_Click(object sender, EventArgs e)
        {
            Table1LoadDir = LoadDir.LeftBottom;
        }

        private void ledCenter_Click(object sender, EventArgs e)
        {
            Table1LoadDir = LoadDir.Center;
        }

        private void ledRightTop_Click(object sender, EventArgs e)
        {
            Table1LoadDir = LoadDir.RightTop;
        }

        private void ledRightBottom_Click(object sender, EventArgs e)
        {
            Table1LoadDir = LoadDir.RightBottom;
        }

        private void chkVacAlarmUse_Click(object sender, EventArgs e)
        {
            Global.chConVacuumAlarmUse.AsBoolean = chkVacAlarmUse.Checked;

        }

        private void chkDoorAlarmUse_Click(object sender, EventArgs e)
        {
            Global.chConCenterDoorUse.AsBoolean = chkDoorAlarmUse.Checked;
        }

        private void chkVacuumRelease_Click(object sender, EventArgs e)
        {
            Global.chConVacuumReleaseUse.AsBoolean = chkVacuumAutoRelease.Checked;
        }

        private void chkAreaSensorUse_Click(object sender, EventArgs e)
        {
            Global.chAreaSensorUse.AsBoolean = chkAreaSensorUse.Checked;
        }

        private void chkAreaSensorVacuumUse_Click(object sender, EventArgs e)
        {
            Global.chAreaSensorVacuumUse.AsBoolean = chkAreaSensorVacuumUse.Checked;
        }

        private void ledTable2LeftTop_Click(object sender, EventArgs e)
        {
            Table2LoadDir = LoadDir.LeftTop;
        }

        private void ledTable2RightTop_Click(object sender, EventArgs e)
        {
            Table2LoadDir = LoadDir.RightTop;
        }

        private void ledTable2Center_Click(object sender, EventArgs e)
        {
            Table2LoadDir = LoadDir.Center;
        }

        private void ledTable2LeftBottom_Click(object sender, EventArgs e)
        {
            Table2LoadDir = LoadDir.LeftBottom;
        }

        private void ledTable2RightBottom_Click(object sender, EventArgs e)
        {
            Table2LoadDir = LoadDir.RightBottom;
        }

        private void cbTable2LoadDir_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Table2LoadDir = (LoadDir)cbTable2LoadDir.SelectedIndex;
        }

        private void cbTable1LoadDir_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Table1LoadDir = (LoadDir)cbTable1LoadDir.SelectedIndex;
        }

        private void ShowTable1LoadingPos()
        {
            if (ledTable1LeftBottom.LED.Value)
            {
                if ((Global.chTable1LeftBottomXPos != null) && (Global.chTable1LeftBottomYPos != null))
                {
                    edTable1LoadingPosX.Value = Global.chTable1LeftBottomXPos.AsDouble;
                    edTable1LoadingPosY.Value = Global.chTable1LeftBottomYPos.AsDouble;
                }
            } 
            else
            if (ledTable1LeftTop.LED.Value)
            {
                if ((Global.chTable1LeftTopXPos != null) && (Global.chTable1LeftTopYPos != null))
                {
                    edTable1LoadingPosX.Value = Global.chTable1LeftTopXPos.AsDouble;
                    edTable1LoadingPosY.Value = Global.chTable1LeftTopYPos.AsDouble;
                }
            } 
            else
            if (ledTable1RightTop.LED.Value)
            {
                if ((Global.chTable1RightTopXPos != null) && (Global.chTable1RightTopYPos != null))
                {
                    edTable1LoadingPosX.Value = Global.chTable1RightTopXPos.AsDouble;
                    edTable1LoadingPosY.Value = Global.chTable1RightTopYPos.AsDouble;
                }
            } 
            else
            if (ledTable1RightBottom.LED.Value)
            {
                if ((Global.chTable1RightBottomXPos != null) && (Global.chTable1RightBottomYPos != null))
                {
                    edTable1LoadingPosX.Value = Global.chTable1RightBottomXPos.AsDouble;
                    edTable1LoadingPosY.Value = Global.chTable1RightBottomYPos.AsDouble;
                }
            } 
            else
            if (ledTable1Center.LED.Value)
            {
                if ((Global.chTable1CenterXPos != null) && (Global.chTable1CenterYPos != null))
                {
                    edTable1LoadingPosX.Value = Global.chTable1CenterXPos.AsDouble;
                    edTable1LoadingPosY.Value = Global.chTable1CenterYPos.AsDouble;
                }
            }
        }

        private void ShowTable2LoadingPos()
        {
            if (ledTable2LeftBottom.LED.Value)
            {
                if ((Global.chTable2LeftBottomXPos != null) && (Global.chTable2LeftBottomYPos != null))
                {
                    edTable2LoadingPosX.Value = Global.chTable2LeftBottomXPos.AsDouble;
                    edTable2LoadingPosY.Value = Global.chTable2LeftBottomYPos.AsDouble;
                }
            }
            else
            if (ledTable2LeftTop.LED.Value)
            {
                if ((Global.chTable2LeftTopXPos != null) && (Global.chTable2LeftTopYPos != null))
                {
                    edTable2LoadingPosX.Value = Global.chTable2LeftTopXPos.AsDouble;
                    edTable2LoadingPosY.Value = Global.chTable2LeftTopYPos.AsDouble;
                }
            }
            else
            if (ledTable2RightTop.LED.Value)
            {
                if ((Global.chTable2RightTopXPos != null) && (Global.chTable2RightTopYPos != null))
                {
                    edTable2LoadingPosX.Value = Global.chTable2RightTopXPos.AsDouble;
                    edTable2LoadingPosY.Value = Global.chTable2RightTopYPos.AsDouble;
                }
            }
            else
            if (ledTable2RightBottom.LED.Value)
            {
                if ((Global.chTable2RightBottomXPos != null) && (Global.chTable2RightBottomYPos != null))
                {
                    edTable2LoadingPosX.Value = Global.chTable2RightBottomXPos.AsDouble;
                    edTable2LoadingPosY.Value = Global.chTable2RightBottomYPos.AsDouble;
                }
            }
            else
            if (ledTable2Center.LED.Value)
            {
                if ((Global.chTable2CenterXPos != null) && (Global.chTable2CenterYPos != null))
                {
                    edTable2LoadingPosX.Value = Global.chTable2CenterXPos.AsDouble;
                    edTable2LoadingPosY.Value = Global.chTable2CenterYPos.AsDouble;
                }
            }
        }

        private void ledTable1LeftBottom_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable1LoadingPos();
        }

        private void ledTable1LeftTop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable1LoadingPos();
        }

        private void ledTable1RightTop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable1LoadingPos();
        }

        private void ledTable1RightBottom_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable1LoadingPos();
        }

        private void ledTable1Center_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable1LoadingPos();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTable1LoadDir.ItemIndex)
            {
                case 0:
                    if ((Global.chTable1LeftBottomXPos != null) && (Global.chTable1LeftBottomYPos != null))
                    {
                        edTable1LoadingPosX.Value = Global.chTable1LeftBottomXPos.AsDouble;
                        edTable1LoadingPosY.Value = Global.chTable1LeftBottomYPos.AsDouble;
                    }
                    break;

                case 1:
                    if ((Global.chTable1LeftTopXPos != null) && (Global.chTable1LeftTopYPos != null))
                    {
                        edTable1LoadingPosX.Value = Global.chTable1LeftTopXPos.AsDouble;
                        edTable1LoadingPosY.Value = Global.chTable1LeftTopYPos.AsDouble;
                    }
                    break;
            }

            switch (cbTable2LoadDir.ItemIndex)
            {
                case 0:
                    if ((Global.chTable2LeftBottomXPos != null) && (Global.chTable2LeftBottomYPos != null))
                    {
                        edTable2LoadingPosX.Value = Global.chTable2LeftBottomXPos.AsDouble;
                        edTable2LoadingPosY.Value = Global.chTable2LeftBottomYPos.AsDouble;
                    }
                    break;

                case 1:
                    if ((Global.chTable2LeftTopXPos != null) && (Global.chTable2LeftTopYPos != null))
                    {
                        edTable2LoadingPosX.Value = Global.chTable2LeftTopXPos.AsDouble;
                        edTable2LoadingPosY.Value = Global.chTable2LeftTopYPos.AsDouble;
                    }
                    break;
            }
        }

        private void tmr_SearchOffset_Tick(object sender, EventArgs e)
        {
            edTable2XOffset.Value = edTable2MarkCenterX.Value - Global.chXActualPos.AsDouble;
            edTable2YOffset.Value = edTable2MarkCenterY.Value - Global.chY2ActualPos.AsDouble;
        }

        private void cbTable1UseVacuumCount_Click(object sender, EventArgs e)
        {
            Pmac.QueryCommand("Table1VacuumOff = true");
        }

        private void cbTable2UseVacuumCount_Click(object sender, EventArgs e)
        {
            Pmac.QueryCommand("Table2VacuumOff = true");
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            btnMeasure.LED.Value = !btnMeasure.LED.Value;

            if (!btnMeasure.LED.Value)
            {
                if (yjCommon.Confirm("Nozzle Offset을 변경합니다.", "확인") == DialogResult.Yes)
                {
                    edTable2NozzleXOffset.Value = edTable2XOffset.Value;
                    edTable2NozzleYOffset.Value = edTable2YOffset.Value;

                    propSaver1.SaveProperty();
                }
            }
        }

        private void btnMeasure_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            if (btnMeasure.LED.Value)
            {
                edTable2MarkCenterX.Value = Global.chXActualPos.AsDouble;
                edTable2MarkCenterY.Value = Global.chY2ActualPos.AsDouble;
            }

            tmr_SearchOffset.Enabled = btnMeasure.LED.Value;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("측정 시작 위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);

                Pmac.XMoveAbs(edTable2MarkCenterX.Value);
                Pmac.Y2MoveAbs(edTable2MarkCenterY.Value);
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Mark표시를 진행합니다.", "확인") == DialogResult.Yes)
            {
                CurrentStep = 3000;
                AutoThread.Enabled = true;             
            }
        }

        private void btnMoveTable1LaserZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Z축의 높이를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(Z_AXIS_NO);

                Pmac.ZMoveAbs(edTable1LaserZFocus.Value);
            }
        }

        private void btnMoveTable1VisionZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Z축의 높이를 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(Z_AXIS_NO);

                Pmac.ZMoveAbs(edTable1VisionZFocus.Value);
            }
        }

        private void btnMoveTable2LaserZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Z축의 높이를 이동합니다.", "확인") == DialogResult.Yes)
            {
                Pmac.ZMoveAbs(edTable2LaserZFocus.Value);
            }
        }

        private void btnMoveTable2VisionZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Z축의 높이를 이동합니다.", "확인") == DialogResult.Yes)
            {
                Pmac.ZMoveAbs(edTable2VisionZFocus.Value);
            }
        }

        private void btnMoveMeasurePos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Measure Pos위치 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edPowerMeterXPos.Value);
                Pmac.ZMoveAbs(edPowerMeterZPos.Value);
            }
        }

        private void btnSetTable1LaserZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 LaserFocus 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                Global.chTable1LaserZFocus.AsDouble = Global.chZActualPos.AsDouble;

                propSaver1.SaveProperty();
            }
        }

        private void btnSetTable2LaserZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 LaserFocus 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                Global.chTable2LaserZFocus.AsDouble = Global.chZActualPos.AsDouble;

                propSaver1.SaveProperty();
            }
        }

        private void btnSetTable1VisionZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table1의 VisionFocus 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                Global.chTable1VisionZFocus.AsDouble = Global.chZActualPos.AsDouble;

                propSaver1.SaveProperty();
            }
        }

        private void btnSetTable2VisionZFocus_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Table2의 VisionFocus 위치를 변경합니다", "확인") == DialogResult.Yes)
            {
                Global.chTable2VisionZFocus.AsDouble = Global.chZActualPos.AsDouble;

                propSaver1.SaveProperty();
            }
        }

        private void btnSetMeasurePos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("현재 위치를 Powermeter Measuer Pos로 지정합니다.", "확인") == DialogResult.Yes)
            {
                edPowerMeterXPos.Value = Global.chXActualPos.AsDouble;
                edPowerMeterZPos.Value = Global.chZActualPos.AsDouble;

                propSaver1.SaveProperty();
            }
        }
        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnCancel.Text = Global.iniEng.ReadString("panConfigCommon", "btnCancel.Text", "Cancel");
            btnSet.Text = Global.iniEng.ReadString("panConfigCommon", "btnSet.Text", "Apply");
            btnAllSave.Text = Global.iniEng.ReadString("panConfigCommon", "btnAllSave.Text", "Save");
            gradientLabel23.Text = Global.iniEng.ReadString("panConfigCommon", "gradientLabel23.Text", "Unit mm");
            gradientLabel24.Text = Global.iniEng.ReadString("panConfigCommon", "gradientLabel24.Text", "Left,Bottom");
            gradientLabel22.Text = Global.iniEng.ReadString("panConfigCommon", "gradientLabel22.Text", "Left,Top");
            gradientLabel20.Text = Global.iniEng.ReadString("panConfigCommon", "gradientLabel20.Text", "Right,Top");
            gradientLabel32.Text = Global.iniEng.ReadString("panConfigCommon", "gradientLabel32.Text", "Right,Bottom");
            gradientLabel36.Text = Global.iniEng.ReadString("panConfigCommon", "gradientLabel36.Text", "Center");
            btnSetTable1Pos1.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1Pos1.Text", "Set");            
            btnSetTable1Pos2.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1Pos2.Text", "Set");            
            btnSetTable1Pos3.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1Pos3.Text", "Set");            
            btnSetTable1Pos4.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1Pos4.Text", "Set");            
            btnSetTable1Pos5.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1Pos5.Text", "Set");            
            btnSetTable2Pos1.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2Pos1.Text", "Set");            
            btnSetTable2Pos2.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2Pos2.Text", "Set");            
            btnSetTable2Pos3.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2Pos3.Text", "Set");            
            btnSetTable2Pos4.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2Pos4.Text", "Set");            
            btnSetTable2Pos5.Text = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2Pos5.Text", "Set");            

            groupBox6.Text = Global.iniEng.ReadString("panConfigCommon", "groupBox6.Text", "Table #1 Product Input Position");
            ledTable1LeftTop.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable1LeftTop.Text", "Left,Top");
            ledTable1RightTop.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable1RightTop.Text", "Right,Top");
            ledTable1Center.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable1Center.Text", "Center");
            ledTable1LeftBottom.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable1LeftBottom.Text", "Left,Bottom");
            ledTable1RightBottom.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable1RightBottom.Text", "Right,Bottom");
            groupBox3.Text = Global.iniEng.ReadString("panConfigCommon", "groupBox3.Text", "Table #2 Product Input Position");
            ledTable2LeftTop.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable2LeftTop.Text", "Left,Top");
            ledTable2RightTop.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable2RightTop.Text", "Right,Top");
            ledTable2Center.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable2Center.Text", "Center");
            ledTable2LeftBottom.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable2LeftBottom.Text", "Left,Bottom");
            ledTable2RightBottom.Text = Global.iniEng.ReadString("panConfigCommon", "ledTable2RightBottom.Text", "Right,Bottom");

            btnSetMeasurePos.Text           = Global.iniEng.ReadString("panConfigCommon", "btnSetMeasurePos.Text", "Set");
            btnSetTable1LaserZFocus.Text    = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1LaserZFocus.Text", "Set");
            btnSetTable1VisionZFocus.Text   = Global.iniEng.ReadString("panConfigCommon", "btnSetTable1VisionZFocus.Text", "Set");
            btnSetTable2LaserZFocus.Text    = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2LaserZFocus.Text", "Set");
            btnSetTable2VisionZFocus.Text   = Global.iniEng.ReadString("panConfigCommon", "btnSetTable2VisionZFocus.Text", "Set");
            btnMark.Text                    = Global.iniEng.ReadString("panConfigCommon", "btnMark.Text", "Mark Cross");
            btnMeasure.Text                 = Global.iniEng.ReadString("panConfigCommon", "btnMeasure.Text", "Measure");
        }
        #endregion
        #region public void ChangeLanguageKorea()
        public void ChangeLanguageKorea()
        {
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnCancel.Text");
            btnSet.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSet.Text");
            btnAllSave.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnAllSave.Text");
            gradientLabel23.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "gradientLabel23.Text");
            gradientLabel24.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "gradientLabel24.Text");
            gradientLabel22.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "gradientLabel22.Text");
            gradientLabel20.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "gradientLabel20.Text");
            gradientLabel32.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "gradientLabel32.Text");
            gradientLabel36.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "gradientLabel36.Text");
            btnSetTable1Pos1.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1Pos1.Text");            
            btnSetTable1Pos2.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1Pos2.Text");            
            btnSetTable1Pos3.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1Pos3.Text");            
            btnSetTable1Pos4.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1Pos4.Text");            
            btnSetTable1Pos5.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1Pos5.Text");            
            btnSetTable2Pos1.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2Pos1.Text");            
            btnSetTable2Pos2.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2Pos2.Text");            
            btnSetTable2Pos3.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2Pos3.Text");            
            btnSetTable2Pos4.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2Pos4.Text");            
            btnSetTable2Pos5.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2Pos5.Text");            

            groupBox6.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "groupBox6.Text");
            ledTable1LeftTop.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable1LeftTop.Text");
            ledTable1RightTop.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable1RightTop.Text");
            ledTable1Center.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable1Center.Text");
            ledTable1LeftBottom.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable1LeftBottom.Text");
            ledTable1RightBottom.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable1RightBottom.Text");

            groupBox3.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "groupBox3.Text");
            ledTable2LeftTop.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable2LeftTop.Text");
            ledTable2RightTop.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable2RightTop.Text");
            ledTable2Center.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable2Center.Text");
            ledTable2LeftBottom.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable2LeftBottom.Text");
            ledTable2RightBottom.Text = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "ledTable2RightBottom.Text");

            btnSetMeasurePos.Text           = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetMeasurePos.Text");
            btnSetTable1LaserZFocus.Text    = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1LaserZFocus.Text");
            btnSetTable1VisionZFocus.Text   = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable1VisionZFocus.Text");
            btnSetTable2LaserZFocus.Text    = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2LaserZFocus.Text");
            btnSetTable2VisionZFocus.Text   = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnSetTable2VisionZFocus.Text");
            btnMark.Text                    = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnMark.Text");
            btnMeasure.Text                 = Global.GetIniLanguageValue(Global.iniKor, "panConfigCommon", "btnMeasure.Text");

        }
        #endregion

        #region public void ChangeLanguageVietnam()
        public void ChangeLanguageVietnam()
        {
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnCancel.Text");
            btnSet.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSet.Text");
            btnAllSave.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnAllSave.Text");
            gradientLabel23.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "gradientLabel23.Text");
            gradientLabel24.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "gradientLabel24.Text");
            gradientLabel22.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "gradientLabel22.Text");
            gradientLabel20.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "gradientLabel20.Text");
            gradientLabel32.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "gradientLabel32.Text");
            gradientLabel36.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "gradientLabel36.Text");
            btnSetTable1Pos1.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable1Pos1.Text");            
            btnSetTable1Pos2.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable1Pos2.Text");            
            btnSetTable1Pos3.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable1Pos3.Text");            
            btnSetTable1Pos4.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable1Pos4.Text");            
            btnSetTable1Pos5.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable1Pos5.Text");            
            btnSetTable2Pos1.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable2Pos1.Text");            
            btnSetTable2Pos2.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable2Pos2.Text");            
            btnSetTable2Pos3.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable2Pos3.Text");            
            btnSetTable2Pos4.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable2Pos4.Text");            
            btnSetTable2Pos5.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "btnSetTable2Pos5.Text");            

            groupBox6.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "groupBox6.Text");
            ledTable1LeftTop.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable1LeftTop.Text");
            ledTable1RightTop.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable1RightTop.Text");
            ledTable1Center.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable1Center.Text");
            ledTable1LeftBottom.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable1LeftBottom.Text");
            ledTable1RightBottom.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable1RightBottom.Text");

            groupBox3.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "groupBox3.Text");
            ledTable2LeftTop.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable2LeftTop.Text");
            ledTable2RightTop.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable2RightTop.Text");
            ledTable2Center.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable2Center.Text");
            ledTable2LeftBottom.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable2LeftBottom.Text");
            ledTable2RightBottom.Text = Global.GetIniLanguageValue(Global.iniVie, "panConfigCommon", "ledTable2RightBottom.Text");

        }

        private void btnTable1Start_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("가공을 시작합니다.", "확인") == DialogResult.Yes)
            {
                frmRunStatus.Abort = false;

                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                edTable1StartX.Apply();
                edTable1StartY.Apply();
                edTable1StartZ.Apply();

                edTable1PitchY.Apply();
                edTable1PitchZ.Apply();

                if (edTable1PitchZ.Value < 0)
                {
                    edTable1PitchZ.Value = edTable1PitchZ.Value * -1;
                }
                
                if (edTable1StepZ.AsInteger > 20)
                { 
                    edTable1StepZ.AsInteger = 20;
                }

                edTable1StepZ.Apply();

                edTable1DrawX.Apply();

                CurrentStep = 1000;
                AutoThread.Enabled = true;
            }
        }

        private void btnTable2Start_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("가공을 시작합니다.", "확인") == DialogResult.Yes)
            {
                edTable2StartX.Apply();
                edTable2StartY.Apply();
                edTable2StartZ.Apply();

                edTable2PitchY.Apply();
                edTable2PitchZ.Apply();

                if (edTable2StepZ.AsInteger > 20)
                {
                    edTable2StepZ.AsInteger = 20;
                }

                edTable2StepZ.Apply();

                edTable2DrawX.Apply();

                CurrentStep = 2000;
                AutoThread.Enabled = true;
            }
        }
        #endregion

        private void btnSetTable1StartPos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("현재의 위치를 가공 시작 위치로 변경합니다.", "확인") == DialogResult.Yes)
            {
                edTable1StartX.Value = Global.chXActualPos.AsDouble;
                edTable1StartY.Value = Global.chY1ActualPos.AsDouble;
                edTable1StartZ.Value = Global.chZActualPos.AsDouble;
            }
        }

        private void btnSetTable2StartPos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("현재의 위치를 가공 시작 위치로 변경합니다.", "확인") == DialogResult.Yes)
            {
                edTable2StartX.Value = Global.chXActualPos.AsDouble;
                edTable2StartY.Value = Global.chY2ActualPos.AsDouble;
                edTable2StartZ.Value = Global.chZActualPos.AsDouble;
            }
        }

        private void btnMoveTable1StartPos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("가공 시작 위치로 이동합니다..", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable1StartX.Value);
                Pmac.Y1MoveAbs(edTable1StartY.Value);
                Pmac.ZMoveAbs(edTable1StartZ.Value);
            };
        }

        private void btnMoveTable2StartPos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("가공 시작 위치로 이동합니다..", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edTable2StartX.Value);
                Pmac.Y2MoveAbs(edTable2StartY.Value);
                Pmac.ZMoveAbs(edTable2StartZ.Value);
            };
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.Auto.TabControl1.SelectedIndex = tabControl2.SelectedIndex;
        }

        private void btnSetLoadPos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("현재 위치를 시스템의 LoadPos로 지정합니다.", "확인") == DialogResult.Yes)
            {
                edLoadPosX.Value = Global.chXActualPos.AsDouble;
                edLoadPosY1.Value = Global.chY1ActualPos.AsDouble;
                edLoadPosY2.Value = Global.chY2ActualPos.AsDouble;
                edLoadPosZ.Value = Global.chZActualPos.AsDouble;

                propSaver1.SaveProperty();
            }
        }

        private void btnMoveLoadPos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Load Pos위치 이동합니다.", "확인") == DialogResult.Yes)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                SetVelocity(Z_AXIS_NO);

                Pmac.XMoveAbs(edLoadPosX.Value);
                Pmac.Y1MoveAbs(edLoadPosY1.Value);
                Pmac.Y2MoveAbs(edLoadPosY2.Value);
                Pmac.ZMoveAbs(edLoadPosZ.Value);
            }
        }

        private void ledTable2LeftTop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable2LoadingPos();
        }

        private void ledTable2RightTop_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable2LoadingPos();
        }

        private void ledTable2Center_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable2LoadingPos();
        }

        private void ledTable2LeftBottom_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable2LoadingPos();
        }

        private void ledTable2RightBottom_LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            ShowTable2LoadingPos();
        }

        private void panConfigCommon_Load(object sender, EventArgs e)
        {

        }

        private void AutoThread_OnExecute(object sender, EventArgs e)
        {
            if (frmRunStatus.Abort)
            {
                CurrentStep = Const.CASE_ABORT;
            }

            switch (CurrentStep)
            {
                //
                // table1
                //
                case 1000:
                    frmRunStatus.TopMost = true;
                    frmRunStatus.Show();

                    OldPulseWidth = frmMain.Manual.ADV.edMode2PulseWidth.Value;
                    OldPulsePitch = frmMain.Manual.ADV.edMode2PulsePitch.Value;

                    frmMain.Manual.ADV.edMode2PulseWidth.Value = 2.0;
                    frmMain.Manual.ADV.edMode2PulsePitch.Value = 0.8;
                    frmMain.Manual.ADV.btnMode2Set_Click(null, null);

                    Pmac.QueryCommand("doBeamShutterOpen=true");
                    Pmac.QueryCommand("doSelectTable=TABLE1");

                    Counter.Start();

                    CurrentStep = 1010;
                    break;

                case 1010:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        CurrentStep = 1020;
                    }
                    break;

                case 1020:

                    Pmac.XMoveAbs(edTable1StartX.Value + edTable2NozzleXOffset.Value);
                    Pmac.Y1MoveAbs(edTable1StartY.Value + edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(edTable1StartZ.Value);

                    Counter.Start();
                    CurrentStep = 1030;

                    break;

                case 1030:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        Counter.Start();
                        CurrentStep = 1031;
                    }
                    break;

                case 1031:
                    if ((Global.chXMotionDone.AsBoolean) && (Global.chY1MotionDone.AsBoolean) && (Global.chZMotionDone.AsBoolean))
                    {
                        Counter.Stop();

                        CurrentStep = 1040;
                    } 
                    else
                    if (Counter.isTimeOver(1000 * 30))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 1040:
                    nIndex = 0;
                    CurrentStep = 1050;

                    break;

                case 1050:
                    frmRunStatus.lblMessage.Text = String.Format("{0}/{1}회 가공중입니다.", nIndex + 1, edTable1StepZ.AsInteger);

                    frmMain.Manual.ADV.OperationOn();

                    Counter.Start();
                    CurrentStep = 1060;

                    break;

                case 1060:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();
                        CurrentStep = 1070;
                    }
                    break;

                case 1070:
                    Pmac.XMoveInc(edTable1DrawX.Value);

                    Counter.Start();
                    CurrentStep = 1080;

                    break;

                case 1080:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        Counter.Start();
                        CurrentStep = 1081;
                    }
                    break;

                case 1081:
                    if (Global.chXMotionDone.AsBoolean)
                    {
                        Counter.Stop();

                        CurrentStep = 1090;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 2))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 1090:
                    frmMain.Manual.ADV.OperationOff();

                    Counter.Start();
                    CurrentStep = 1100;

                    break;

                case 1100:
                    if (Counter.isTimeOver(500)) 
                    { 
                        Counter.Stop();

                        CurrentStep = 1110;
                    }
                    break;

                case 1110:
                    Pmac.XMoveInc(-edTable1DrawX.Value);
                    Pmac.ZMoveInc(-edTable1PitchZ.Value);
                    Pmac.Y1MoveInc(edTable1PitchY.Value);

                    Counter.Start();
                    CurrentStep = 1111;
                    break;

                case 1111:
                    if ((Global.chXMotionDone.AsBoolean) && (Global.chY1MotionDone.AsBoolean) && (Global.chZMotionDone.AsBoolean))
                    {
                        Counter.Stop();

                        CurrentStep = 1200;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 5))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 1200:
                    if (nIndex + 1 < edTable1StepZ.AsInteger)
                    {
                        nIndex = nIndex + 1;
                        CurrentStep = 1050;
                    } 
                    else
                    {
                        CurrentStep = 1300;
                    }
                    break;

                case 1300:
                    Pmac.QueryCommand("doBeamShutterOpen=false");

                    Counter.Start();
                    CurrentStep = 1310;

                    break;

                case 1310:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();
                        CurrentStep = 1320;
                    }
                    break;

                case 1320:
                    Pmac.XMoveAbs(edTable1StartX.Value - edTable2NozzleXOffset.Value);
                    Pmac.Y1MoveAbs(edTable1StartY.Value - edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(edTable1StartZ.Value);

                    frmMain.Manual.ADV.edMode2PulseWidth.Value = OldPulseWidth;
                    frmMain.Manual.ADV.edMode2PulsePitch.Value = OldPulsePitch;

                    frmRunStatus.Hide();

                    CurrentStep = Const.CASE_DONE;
                    break;

                //
                // table2
                //
                case 2000:
                    frmRunStatus.TopMost = true;
                    frmRunStatus.Show();

                    OldPulseWidth = frmMain.Manual.ADV.edMode2PulseWidth.Value;
                    OldPulsePitch = frmMain.Manual.ADV.edMode2PulsePitch.Value;

                    frmMain.Manual.ADV.edMode2PulseWidth.Value = 2.0;
                    frmMain.Manual.ADV.edMode2PulsePitch.Value = 0.8;
                    frmMain.Manual.ADV.btnMode2Set_Click(null, null);

                    Pmac.QueryCommand("doBeamShutterOpen=true");
                    Pmac.QueryCommand("doSelectTable=TABLE2");

                    Counter.Start();
       
                    CurrentStep = 2010;
                    break;

                case 2010:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        CurrentStep = 2020;
                    }
                    break;

                case 2020:

                    Pmac.XMoveAbs(edTable2StartX.Value + edTable2NozzleXOffset.Value);
                    Pmac.Y1MoveAbs(edTable2StartY.Value + edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(edTable2StartZ.Value);

                    Counter.Start();
                    CurrentStep = 2030;

                    break;

                case 2030:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();
                        CurrentStep = 2031;
                    }
                    break;

                case 2031:
                    if ((Global.chXMotionDone.AsBoolean) && (Global.chY2MotionDone.AsBoolean) && (Global.chZMotionDone.AsBoolean))
                    {
                        Counter.Stop();

                        CurrentStep = 2040;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 30))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 2040:
                    nIndex = 0;
                    CurrentStep = 2050;

                    break;

                case 2050:
                    frmRunStatus.lblMessage.Text = String.Format("{0}/{1}회 가공중입니다.", nIndex + 1, edTable1StepZ.AsInteger);

                    frmMain.Manual.ADV.OperationOn();

                    Counter.Start();
                    CurrentStep = 2060;

                    break;

                case 2060:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();
                        CurrentStep = 2070;
                    }
                    break;

                case 2070:
                    Pmac.XMoveInc(edTable2DrawX.Value);

                    Counter.Start();
                    CurrentStep = 2080;

                    break;

                case 2080:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        Counter.Start();
                        CurrentStep = 2081;
                    }
                    break;

                case 2081:
                    if (Global.chXMotionDone.AsBoolean)
                    {
                        Counter.Stop();

                        CurrentStep = 2090;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 2))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 2090:
                    frmMain.Manual.ADV.OperationOff();

                    Counter.Start();
                    CurrentStep = 2100;

                    break;

                case 2100:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();

                        CurrentStep = 2110;
                    }
                    break;

                case 2110:
                    Pmac.XMoveInc(-edTable2DrawX.Value);
                    Pmac.ZMoveInc(-edTable2PitchZ.Value);
                    Pmac.Y2MoveInc(edTable2PitchY.Value);

                    Counter.Start();
                    CurrentStep = 2111;
                    break;

                case 2111:
                    if ((Global.chXMotionDone.AsBoolean) && (Global.chY2MotionDone.AsBoolean) && (Global.chZMotionDone.AsBoolean))
                    {
                        Counter.Stop();
                        
                        CurrentStep = 2200;
                    }
                    else
                    if (Counter.isTimeOver(1000 * 5))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 2200:
                    if (nIndex + 1 < edTable2StepZ.AsInteger)
                    {
                        nIndex = nIndex + 1;
                        CurrentStep = 2050;
                    }
                    else
                    {
                        CurrentStep = 2300;
                    }
                    break;

                case 2300:
                    Pmac.QueryCommand("doBeamShutterOpen=false");

                    Counter.Start();
                    CurrentStep = 2310;

                    break;

                case 2310:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();
                        CurrentStep = 2320;
                    }
                    break;

                case 2320:
                    Pmac.XMoveAbs(edTable2StartX.Value - edTable2NozzleXOffset.Value);
                    Pmac.Y1MoveAbs(edTable2StartY.Value - edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(edTable2StartZ.Value);

                    frmMain.Manual.ADV.edMode2PulseWidth.Value = OldPulseWidth;
                    frmMain.Manual.ADV.edMode2PulsePitch.Value = OldPulsePitch;

                    frmRunStatus.Hide();

                    CurrentStep = Const.CASE_DONE;
                    break;

                    ////////////////////////////////
                case 3000:
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);
                    SetVelocity(Z_AXIS_NO);

                    CurrentStep = 3100;
                    break;

                case 3100:
                    OldPulseWidth = frmMain.Manual.ADV.edMode2PulseWidth.Value;
                    OldPulsePitch = frmMain.Manual.ADV.edMode2PulsePitch.Value;

                    frmMain.Manual.ADV.edMode2PulseWidth.Value = 2.0;
                    frmMain.Manual.ADV.edMode2PulsePitch.Value = 0.8;
                    frmMain.Manual.ADV.btnMode2Set_Click(null, null);

           //         Pmac.ZMoveAbs(Global.chTable2LaserZFocus.AsDouble);
                    Counter.Start();

                    CurrentStep = 3200;
                    break;

                case 3200:
                    if (Counter.isTimeOver(250))
                    {
                        Counter.Stop();

                        Pmac.QueryCommand("doSelectTable=TABLE2");
                        Pmac.QueryCommand("doBeamShutterOpen=true");

                        Counter.Start();

                        CurrentStep = 3300;
                    }
                    break;

                case 3300:
                    if (Counter.isTimeOver(250))
                    {
                        Counter.Stop();

                        Pmac.XMoveInc(-5.0);

                        Counter.Start();

                        CurrentStep = 3400;
                    }
                    break;

                case 3400:
                    if (Counter.isTimeOver(500))
                    {
                        Counter.Stop();
                        
                        frmMain.Manual.ADV.OperationOn();

                        Counter.Start();

                        CurrentStep = 3600;
                    }
                    break;

                case 3600:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        Pmac.XMoveInc(10);

                        Counter.Start();

                        CurrentStep = 3700;
                    }
                    break;

                case 3700:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        frmMain.Manual.ADV.OperationOff();

                        Counter.Start();

                        CurrentStep = 3800;
                    }
                    break;

                case 3800:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                        
                        //Pmac.ZMoveAbs(Global.chTable2LaserZFocus.AsDouble);
                        Pmac.XMoveInc(-5);
                        Pmac.Y2MoveInc(-5);

                        Counter.Start();

                        CurrentStep = 3900;
                    }
                    break;

                case 3900:
                    if (Counter.isTimeOver(300))
                    {
                        Counter.Stop();

                        frmMain.Manual.ADV.OperationOn();

                        Counter.Start();

                        CurrentStep = 4000;
                    }
                    break;

                case 4000:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        Pmac.Y2MoveInc(10);

                        Counter.Start();

                        CurrentStep = 4100;
                    }
                    break;

                case 4100:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        frmMain.Manual.ADV.OperationOff();

                        Counter.Start();

                        CurrentStep = 4200;
                    }
                    break;

                case 4200:
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        Pmac.Y2MoveInc(-5);

                        Counter.Start();

                        CurrentStep = 4300;
                    }
                    break;

                case 4300: 
                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    frmMain.Manual.ADV.edMode2PulseWidth.Value = OldPulseWidth;
                    frmMain.Manual.ADV.edMode2PulsePitch.Value = OldPulsePitch;

                    CurrentStep = Const.CASE_DONE;
                    break;

                case Const.CASE_ERROR:
                    break;

                case Const.CASE_DONE:
                    AutoThread.Enabled = false;
                    break;

                case Const.CASE_ABORT:

                    frmRunStatus.Hide();
                    
                    AutoThread.Enabled = false;
                    break;
            }
        }
    }
}