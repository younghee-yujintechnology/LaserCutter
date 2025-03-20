namespace LaserCutter
{
    partial class panConfigCommon
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.propSaver1 = new YujinTechnology.PropSaver();
            this.DataServer = new YujinTechnology.DataServer();
            this.tmr_SearchOffset = new System.Windows.Forms.Timer(this.components);
            this.multiLanguage1 = new YujinTechnology.MultiLanguage();
            this.AutoThread = new YujinTechnology.Thread();
            this.panClient = new LaserCutter.sjPanel();
            this.btnCancel = new YujinTechnology.BitBtn();
            this.btnSet = new YujinTechnology.BitBtn();
            this.tabControl1 = new YujinTechnology.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gradientLabel63 = new YujinTechnology.GradientLabel();
            this.edAutoRunSpeedZ = new YujinTechnology.KeypadEdit();
            this.edAutoRunTA = new YujinTechnology.KeypadEdit();
            this.gradientLabel64 = new YujinTechnology.GradientLabel();
            this.edAutoRunSpeedStage = new YujinTechnology.KeypadEdit();
            this.gradientLabel65 = new YujinTechnology.GradientLabel();
            this.edJumpTA = new YujinTechnology.KeypadEdit();
            this.edArcTA = new YujinTechnology.KeypadEdit();
            this.edLineTA = new YujinTechnology.KeypadEdit();
            this.gradLabel52 = new YujinTechnology.GradientLabel();
            this.gradLabel50 = new YujinTechnology.GradientLabel();
            this.gradLabel22 = new YujinTechnology.GradientLabel();
            this.edJumpSpeed = new YujinTechnology.KeypadEdit();
            this.edArcSpeed = new YujinTechnology.KeypadEdit();
            this.edLineSpeed = new YujinTechnology.KeypadEdit();
            this.gradLabel51 = new YujinTechnology.GradientLabel();
            this.gradLabel35 = new YujinTechnology.GradientLabel();
            this.gradLabel29 = new YujinTechnology.GradientLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sunnyLine4 = new YujinTechnology.SunnyLine();
            this.btnSetLoadPos = new YujinTechnology.BitBtn();
            this.btnMoveLoadPos = new YujinTechnology.BitBtn();
            this.uiLine17 = new YujinTechnology.SunnyLine();
            this.edMode0Period = new YujinTechnology.KeypadEdit();
            this.edMode0PulseWidth = new YujinTechnology.KeypadEdit();
            this.gradientLabel60 = new YujinTechnology.GradientLabel();
            this.gradientLabel61 = new YujinTechnology.GradientLabel();
            this.btnSetMeasurePos = new YujinTechnology.BitBtn();
            this.btnMoveMeasurePos = new YujinTechnology.BitBtn();
            this.gradientLabel8 = new YujinTechnology.GradientLabel();
            this.btnMark = new YujinTechnology.LEDButton();
            this.gradientLabel29 = new YujinTechnology.GradientLabel();
            this.edTable2YOffset = new YujinTechnology.KeypadEdit();
            this.edTable2XOffset = new YujinTechnology.KeypadEdit();
            this.btnMove = new YujinTechnology.BitBtn();
            this.gradientLabel6 = new YujinTechnology.GradientLabel();
            this.edTable2MarkCenterY = new YujinTechnology.KeypadEdit();
            this.edTable2MarkCenterX = new YujinTechnology.KeypadEdit();
            this.btnMeasure = new YujinTechnology.LEDButton();
            this.gradientLabel14 = new YujinTechnology.GradientLabel();
            this.gradientLabel15 = new YujinTechnology.GradientLabel();
            this.gradientLabel16 = new YujinTechnology.GradientLabel();
            this.edHomeOffsetPosZ = new YujinTechnology.KeypadEdit();
            this.edHomeOffsetPosY1 = new YujinTechnology.KeypadEdit();
            this.edHomeOffsetPosY2 = new YujinTechnology.KeypadEdit();
            this.edHomeOffsetPosX = new YujinTechnology.KeypadEdit();
            this.gradientLabel17 = new YujinTechnology.GradientLabel();
            this.gradientLabel18 = new YujinTechnology.GradientLabel();
            this.sunnyLine1 = new YujinTechnology.SunnyLine();
            this.gradientLabel7 = new YujinTechnology.GradientLabel();
            this.edPowerMeterZPos = new YujinTechnology.KeypadEdit();
            this.edPowerMeterXPos = new YujinTechnology.KeypadEdit();
            this.gradLabel28 = new YujinTechnology.GradientLabel();
            this.gradLabel30 = new YujinTechnology.GradientLabel();
            this.edTable2NozzleYOffset = new YujinTechnology.KeypadEdit();
            this.edTable2NozzleXOffset = new YujinTechnology.KeypadEdit();
            this.sunnyLine3 = new YujinTechnology.SunnyLine();
            this.gradLabel39 = new YujinTechnology.GradientLabel();
            this.gradLabel15 = new YujinTechnology.GradientLabel();
            this.gradientLabel3 = new YujinTechnology.GradientLabel();
            this.gradientLabel2 = new YujinTechnology.GradientLabel();
            this.gradientLabel1 = new YujinTechnology.GradientLabel();
            this.edLoadPosZ = new YujinTechnology.KeypadEdit();
            this.edLoadPosY1 = new YujinTechnology.KeypadEdit();
            this.edLoadPosY2 = new YujinTechnology.KeypadEdit();
            this.edLoadPosX = new YujinTechnology.KeypadEdit();
            this.uiLine5 = new YujinTechnology.SunnyLine();
            this.gradLabel7 = new YujinTechnology.GradientLabel();
            this.gradLabel6 = new YujinTechnology.GradientLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkAreaSensorVacuumUse = new YujinTechnology.CheckBox();
            this.chkAreaSensorUse = new YujinTechnology.CheckBox();
            this.chkVacuumAutoRelease = new YujinTechnology.CheckBox();
            this.chkVacAlarmUse = new YujinTechnology.CheckBox();
            this.chkDoorAlarmUse = new YujinTechnology.CheckBox();
            this.chkIOnizoerAutoRun = new YujinTechnology.CheckBox();
            this.chkDustCollectorAutoRun = new YujinTechnology.CheckBox();
            this.gradientLabel38 = new YujinTechnology.GradientLabel();
            this.gradientLabel39 = new YujinTechnology.GradientLabel();
            this.gradientLabel33 = new YujinTechnology.GradientLabel();
            this.cbTable2UseVacuumCount = new YujinTechnology.ComboBox();
            this.edTable2VacuumDelay = new YujinTechnology.KeypadEdit();
            this.gradientLabel34 = new YujinTechnology.GradientLabel();
            this.cbTable1UseVacuumCount = new YujinTechnology.ComboBox();
            this.edTable1VacuumDelay = new YujinTechnology.KeypadEdit();
            this.sunnyLine6 = new YujinTechnology.SunnyLine();
            this.edAccelerationG = new YujinTechnology.KeypadEdit();
            this.gradientLabel27 = new YujinTechnology.GradientLabel();
            this.sunnyLine5 = new YujinTechnology.SunnyLine();
            this.gradientLabel26 = new YujinTechnology.GradientLabel();
            this.gradientLabel25 = new YujinTechnology.GradientLabel();
            this.sunnyLine2 = new YujinTechnology.SunnyLine();
            this.uiLine2 = new YujinTechnology.SunnyLine();
            this.gradLabel3 = new YujinTechnology.GradientLabel();
            this.uiLine3 = new YujinTechnology.SunnyLine();
            this.gradLabel38 = new YujinTechnology.GradientLabel();
            this.gradLabel37 = new YujinTechnology.GradientLabel();
            this.edTableSizeX = new YujinTechnology.KeypadEdit();
            this.edTableSizeY = new YujinTechnology.KeypadEdit();
            this.gradLabel5 = new YujinTechnology.GradientLabel();
            this.gradLabel2 = new YujinTechnology.GradientLabel();
            this.uiLine1 = new YujinTechnology.SunnyLine();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new YujinTechnology.Label();
            this.gradientLabel10 = new YujinTechnology.GradientLabel();
            this.gradientLabel35 = new YujinTechnology.GradientLabel();
            this.gradientLabel37 = new YujinTechnology.GradientLabel();
            this.edTable2LoadingPosX = new YujinTechnology.NumberEdit();
            this.edTable2LoadingPosY = new YujinTechnology.NumberEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ledTable2Center = new YujinTechnology.LEDLabel();
            this.cbTable2LoadDir = new YujinTechnology.ComboBox();
            this.ledTable2RightBottom = new YujinTechnology.LEDLabel();
            this.ledTable2RightTop = new YujinTechnology.LEDLabel();
            this.ledTable2LeftBottom = new YujinTechnology.LEDLabel();
            this.ledTable2LeftTop = new YujinTechnology.LEDLabel();
            this.gradientLabel11 = new YujinTechnology.GradientLabel();
            this.gradientLabel12 = new YujinTechnology.GradientLabel();
            this.gradientLabel13 = new YujinTechnology.GradientLabel();
            this.edTable1LoadingPosX = new YujinTechnology.NumberEdit();
            this.edTable1LoadingPosY = new YujinTechnology.NumberEdit();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ledTable1Center = new YujinTechnology.LEDLabel();
            this.cbTable1LoadDir = new YujinTechnology.ComboBox();
            this.ledTable1RightBottom = new YujinTechnology.LEDLabel();
            this.ledTable1RightTop = new YujinTechnology.LEDLabel();
            this.ledTable1LeftBottom = new YujinTechnology.LEDLabel();
            this.ledTable1LeftTop = new YujinTechnology.LEDLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblInfom = new YujinTechnology.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMoveTable2Pos5 = new YujinTechnology.BitBtn();
            this.btnMoveTable2Pos4 = new YujinTechnology.BitBtn();
            this.btnMoveTable2Pos3 = new YujinTechnology.BitBtn();
            this.btnMoveTable2Pos2 = new YujinTechnology.BitBtn();
            this.btnMoveTable2Pos1 = new YujinTechnology.BitBtn();
            this.btnSetTable2Pos5 = new YujinTechnology.BitBtn();
            this.btnSetTable2Pos4 = new YujinTechnology.BitBtn();
            this.btnSetTable2Pos3 = new YujinTechnology.BitBtn();
            this.btnSetTable2Pos2 = new YujinTechnology.BitBtn();
            this.btnSetTable2Pos1 = new YujinTechnology.BitBtn();
            this.gradientLabel19 = new YujinTechnology.GradientLabel();
            this.gradientLabel21 = new YujinTechnology.GradientLabel();
            this.edTable2CenterYPos = new YujinTechnology.KeypadEdit();
            this.edTable2CenterXPos = new YujinTechnology.KeypadEdit();
            this.edTable2RightBottomYPos = new YujinTechnology.KeypadEdit();
            this.edTable2RightBottomXPos = new YujinTechnology.KeypadEdit();
            this.edTable2RightTopYPos = new YujinTechnology.KeypadEdit();
            this.edTable2RightTopXPos = new YujinTechnology.KeypadEdit();
            this.edTable2LeftTopYPos = new YujinTechnology.KeypadEdit();
            this.edTable2LeftTopXPos = new YujinTechnology.KeypadEdit();
            this.edTable2LeftBottomYPos = new YujinTechnology.KeypadEdit();
            this.edTable2LeftBottomXPos = new YujinTechnology.KeypadEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gradientLabel23 = new YujinTechnology.GradientLabel();
            this.btnMoveTable1Pos5 = new YujinTechnology.BitBtn();
            this.btnMoveTable1Pos4 = new YujinTechnology.BitBtn();
            this.btnMoveTable1Pos3 = new YujinTechnology.BitBtn();
            this.btnMoveTable1Pos2 = new YujinTechnology.BitBtn();
            this.btnMoveTable1Pos1 = new YujinTechnology.BitBtn();
            this.btnSetTable1Pos5 = new YujinTechnology.BitBtn();
            this.btnSetTable1Pos4 = new YujinTechnology.BitBtn();
            this.btnSetTable1Pos3 = new YujinTechnology.BitBtn();
            this.btnSetTable1Pos2 = new YujinTechnology.BitBtn();
            this.btnSetTable1Pos1 = new YujinTechnology.BitBtn();
            this.gradientLabel36 = new YujinTechnology.GradientLabel();
            this.edTable1CenterYPos = new YujinTechnology.KeypadEdit();
            this.edTable1CenterXPos = new YujinTechnology.KeypadEdit();
            this.gradientLabel32 = new YujinTechnology.GradientLabel();
            this.edTable1RightBottomYPos = new YujinTechnology.KeypadEdit();
            this.edTable1RightBottomXPos = new YujinTechnology.KeypadEdit();
            this.gradientLabel20 = new YujinTechnology.GradientLabel();
            this.gradientLabel22 = new YujinTechnology.GradientLabel();
            this.gradientLabel24 = new YujinTechnology.GradientLabel();
            this.edTable1RightTopYPos = new YujinTechnology.KeypadEdit();
            this.edTable1RightTopXPos = new YujinTechnology.KeypadEdit();
            this.edTable1LeftTopYPos = new YujinTechnology.KeypadEdit();
            this.edTable1LeftTopXPos = new YujinTechnology.KeypadEdit();
            this.edTable1LeftBottomYPos = new YujinTechnology.KeypadEdit();
            this.edTable1LeftBottomXPos = new YujinTechnology.KeypadEdit();
            this.gradientLabel28 = new YujinTechnology.GradientLabel();
            this.gradientLabel30 = new YujinTechnology.GradientLabel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new YujinTechnology.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.gradientLabel67 = new YujinTechnology.GradientLabel();
            this.edTable1VisionFocusLightValue = new YujinTechnology.KeypadEdit();
            this.edTable1LaserFocusLightValue = new YujinTechnology.KeypadEdit();
            this.gradientLabel62 = new YujinTechnology.GradientLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientLabel57 = new YujinTechnology.GradientLabel();
            this.gradientLabel58 = new YujinTechnology.GradientLabel();
            this.gradientLabel59 = new YujinTechnology.GradientLabel();
            this.btnMoveTable1LaserZFocus = new YujinTechnology.BitBtn();
            this.keypadEdit2 = new YujinTechnology.KeypadEdit();
            this.keypadEdit1 = new YujinTechnology.KeypadEdit();
            this.keypadEdit6 = new YujinTechnology.KeypadEdit();
            this.keypadEdit7 = new YujinTechnology.KeypadEdit();
            this.keypadEdit5 = new YujinTechnology.KeypadEdit();
            this.keypadEdit4 = new YujinTechnology.KeypadEdit();
            this.gradientLabel46 = new YujinTechnology.GradientLabel();
            this.edTable1StartX = new YujinTechnology.KeypadEdit();
            this.btnTable1Start = new YujinTechnology.BitBtn();
            this.edTable1DrawX = new YujinTechnology.KeypadEdit();
            this.gradientLabel43 = new YujinTechnology.GradientLabel();
            this.edTable1StepZ = new YujinTechnology.KeypadEdit();
            this.gradientLabel42 = new YujinTechnology.GradientLabel();
            this.edTable1PitchZ = new YujinTechnology.KeypadEdit();
            this.edTable1PitchY = new YujinTechnology.KeypadEdit();
            this.gradientLabel41 = new YujinTechnology.GradientLabel();
            this.gradientLabel40 = new YujinTechnology.GradientLabel();
            this.edTable1StartZ = new YujinTechnology.KeypadEdit();
            this.gradientLabel31 = new YujinTechnology.GradientLabel();
            this.btnSetTable1StartPos = new YujinTechnology.BitBtn();
            this.btnMoveTable1StartPos = new YujinTechnology.BitBtn();
            this.edTable1StartY = new YujinTechnology.KeypadEdit();
            this.gradientLabel9 = new YujinTechnology.GradientLabel();
            this.btnSetTable1VisionZFocus = new YujinTechnology.BitBtn();
            this.btnSetTable1LaserZFocus = new YujinTechnology.BitBtn();
            this.btnMoveTable1VisionZFocus = new YujinTechnology.BitBtn();
            this.gradientLabel4 = new YujinTechnology.GradientLabel();
            this.gradientLabel5 = new YujinTechnology.GradientLabel();
            this.edTable1VisionZFocus = new YujinTechnology.KeypadEdit();
            this.edTable1LaserZFocus = new YujinTechnology.KeypadEdit();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.gradientLabel68 = new YujinTechnology.GradientLabel();
            this.edTable2VisionFocusLightValue = new YujinTechnology.KeypadEdit();
            this.edTable2LaserFocusLightValue = new YujinTechnology.KeypadEdit();
            this.gradientLabel66 = new YujinTechnology.GradientLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientLabel54 = new YujinTechnology.GradientLabel();
            this.gradientLabel55 = new YujinTechnology.GradientLabel();
            this.gradientLabel56 = new YujinTechnology.GradientLabel();
            this.keypadEdit3 = new YujinTechnology.KeypadEdit();
            this.keypadEdit12 = new YujinTechnology.KeypadEdit();
            this.keypadEdit8 = new YujinTechnology.KeypadEdit();
            this.keypadEdit9 = new YujinTechnology.KeypadEdit();
            this.keypadEdit10 = new YujinTechnology.KeypadEdit();
            this.keypadEdit11 = new YujinTechnology.KeypadEdit();
            this.gradientLabel48 = new YujinTechnology.GradientLabel();
            this.gradientLabel49 = new YujinTechnology.GradientLabel();
            this.gradientLabel50 = new YujinTechnology.GradientLabel();
            this.gradientLabel51 = new YujinTechnology.GradientLabel();
            this.gradientLabel52 = new YujinTechnology.GradientLabel();
            this.gradientLabel53 = new YujinTechnology.GradientLabel();
            this.gradientLabel47 = new YujinTechnology.GradientLabel();
            this.edTable2StartX = new YujinTechnology.KeypadEdit();
            this.btnTable2Start = new YujinTechnology.BitBtn();
            this.edTable2DrawX = new YujinTechnology.KeypadEdit();
            this.edTable2StepZ = new YujinTechnology.KeypadEdit();
            this.edTable2PitchZ = new YujinTechnology.KeypadEdit();
            this.edTable2PitchY = new YujinTechnology.KeypadEdit();
            this.gradientLabel44 = new YujinTechnology.GradientLabel();
            this.edTable2StartZ = new YujinTechnology.KeypadEdit();
            this.gradientLabel45 = new YujinTechnology.GradientLabel();
            this.btnSetTable2StartPos = new YujinTechnology.BitBtn();
            this.btnMoveTable2StartPos = new YujinTechnology.BitBtn();
            this.edTable2StartY = new YujinTechnology.KeypadEdit();
            this.btnSetTable2VisionZFocus = new YujinTechnology.BitBtn();
            this.btnSetTable2LaserZFocus = new YujinTechnology.BitBtn();
            this.btnMoveTable2VisionZFocus = new YujinTechnology.BitBtn();
            this.btnMoveTable2LaserZFocus = new YujinTechnology.BitBtn();
            this.edTable2VisionZFocus = new YujinTechnology.KeypadEdit();
            this.edTable2LaserZFocus = new YujinTechnology.KeypadEdit();
            this.btnAllSave = new YujinTechnology.BitBtn();
            this.panClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // propSaver1
            // 
            this.propSaver1.Active = false;
            this.propSaver1.FormStateSection = "";
            this.propSaver1.ManageFormState = false;
            this.propSaver1.ParentControl = this;
            this.propSaver1.PropList = new string[] {
        "edTable1LaserZFocus;Text;Table1;LaserZFocus;0",
        "edTable1NozzleXOffset;Text;Table1;NozzleXOffset;0",
        "edTable1VisionZFocus;Text;Table1;VisionZFocus;0",
        "edTable2LaserZFocus;Text;Table2;LaserZFocus;0",
        "edTable2NozzleXOffset;Text;Table2;NozzleXOffset;0",
        "edTable2VisionZFocus;Text;Table2;VisionZFocus;0",
        "edLoadPosX;Text;LoadPos;LoadXPos;0",
        "edLoadPosY1;Text;LoadPos;LoadY1Pos;0",
        "edLoadPosY2;Text;LoadPos;LoadY2Pos;0",
        "chkDoorAlarmUse;Checked;Option;DoorAlarmUse;true",
        "chkStartReserved;Checked;Option;StartReserved;true",
        "edLoadPosZ;Text;LoadPos;LoadZPos;0",
        "edSafetyPosY1;Text;LoadPos;SafetyY1Pos;0",
        "edSafetyPosY2;Text;LoadPos;SafetyY2Pos;0",
        "edTableSizeX;Text;Tablesize;TableXSize;0",
        "edTableSizeY;Text;TableSize;TableYSize;0",
        "edLineSpeed;Text;LineAndArcSpeed;Line_Speed;0",
        "edArcSpeed;Text;LineAndArcSpeed;ArcSpeed;0",
        "edJumpSpeed;Text;LineAndArcSpeed;JumpSpeed;0",
        "edVisionRunSpeed;Text;Vision;VisionRunSpeed;0",
        "edVisionRunTA;Text;Vision;VisionRunTA;0",
        "edVisionRunTS;Text;Vision;VisionRunTS;0",
        "edPowerMeterXPos;Text;PowerMeterPos;PowerMeterXPos;0",
        "edPowerMeterZPos;Text;PowerMeterPos;PowerMeterZPos;0",
        "edLineTA;Text;LineAndArcSpeed;LineTA;0",
        "edArcTA;Text;LineAndArcSpeed;ArcTA;0",
        "edJumpTA;Text;LineAndArcSpeed;JumpTA;0",
        "edAlignScore;Text;Vision;AlignScore;0",
        "chkVacAlarmUse;Checked;Option;VacAlarmUse;true",
        "chkVacuumAutoRelease;Checked;Option;VacuumAutoReleaseUse;true",
        "cbFocusTopBottomUse;Checked;VariableFocus;FocusTopBottomUse;true",
        "edFocusLX;Text;VariableFocus;FocusLX;0",
        "edFocusRX;Text;VariableFocus;FocusRX;0",
        "cbFocusLeftRightUse;Checked;VariableFocus;FocusTopBottomUse;true",
        "edFocusTY;Text;VariableFocus;FocusTY;0",
        "edFocusBY;Text;VariableFocus;FocusBY;0",
        "edFocusZOffset;Text;VariableFocus;ZFocusOffset;0",
        "edFocusZSpeed;Text;VariableFocus;ZFocusSpeed;0",
        "edCircleYOffset;Text;CircleYOffset;YOffset;0",
        "edTable1NozzleYOffset;Text;Table1;NozzleYOffset;0",
        "edTable2NozzleYOffset;Text;Table2;NozzleYOffset;0",
        "edTable1NozzleXCenterPos;Text;Table1;CenterPosNozzleXPos;0",
        "edTable1NozzleYCenterPos;Text;Table1;CenterPosNozzleYPos;0",
        "edTable2NozzleXCenterPos;Text;Table2;CenterPosNozzleXPos;0",
        "edTable2NozzleYCenterPos;Text;Table2;CenterPosNozzleYPos;0",
        "edTable1VisionXCenterPos;Text;Table1;CenterPosVisionXPos;0",
        "edTable1VisionYCenterPos;Text;Table1;CenterPosVisionYPos;0",
        "edTable2VisionXCenterPos;Text;Table2;CenterPosVisionXPos;0",
        "edTable2VisionYCenterPos;Text;Table2;CenterPosVisionYPos;0",
        "edTable1GuideCornerXPos;Text;Table1;GuideCornerXPos;0",
        "edTable1GuideCornerYPos;Text;Table1;GuideCornerYPos;0",
        "edTable2GuideCornerXPos;Text;Table2;GuideCornerXPos;0",
        "edTable2GuideCornerYPos;Text;Table2;GuideCornerYPos;0",
        "edHomeOffsetPosX;Text;HomeOffset;HomeOffsetX;0",
        "edHomeOffsetPosY1;Text;HomeOffset;HomeOffsetY1;0",
        "edHomeOffsetPosY2;Text;HomeOffset;HomeOffsetY2;0",
        "edHomeOffsetPosZ;Text;HomeOffset;HomeOffsetZ;0",
        "edTable1LeftBottomXPos;Text;ProductInput;Table1LeftBottomXPos;0",
        "edTable1LeftBottomYPos;Text;ProductInput;Table1LeftBottomYPos;0",
        "edTable1LeftTopXPos;Text;ProductInput;Table1LeftTopXPos;0",
        "edTable1LeftTopYPos;Text;ProductInput;Table1LeftTopYPos;0",
        "edTable1RightTopXPos;Text;ProductInput;Table1RightTopXPos;0",
        "edTable1RightTopYPos;Text;ProductInput;Table1RightTopYPos;0",
        "edTable1RightBottomXPos;Text;ProductInput;Table1RightBottomXPos;0",
        "edTable1RightBottomYPos;Text;ProductInput;Table1RightBottomYPos;0",
        "edTable1CenterXPos;Text;ProductInput;Table1CenterXPos;0",
        "edTable1CenterYPos;Text;ProductInput;Table1CenterYPos;0",
        "edTable2LeftBottomXPos;Text;ProductInput;Table2LeftBottomXPos;0",
        "edTable2LeftBottomYPos;Text;ProductInput;Table2LeftBottomYPos;0",
        "edTable2LeftTopXPos;Text;ProductInput;Table2LeftTopXPos;0",
        "edTable2LeftTopYPos;Text;ProductInput;Table2LeftTopYPos;0",
        "edTable2RightTopXPos;Text;ProductInput;Table2RightTopXPos;0",
        "edTable2RightTopYPos;Text;ProductInput;Table2RightTopYPos;0",
        "edTable2RightBottomXPos;Text;ProductInput;Table2RightBottomXPos;0",
        "edTable2RightBottomYPos;Text;ProductInput;Table2RightBottomYPos;0",
        "edTable2CenterXPos;Text;ProductInput;Table2CenterXPos;0",
        "edTable2CenterYPos;Text;ProductInput;Table2CenterYPos;0",
        "chkAreaSensorUse;Checked;Option;AreaSensorUse;true",
        "chkAreaSensorVacuumUse;Checked;Option;AreaSensorVacuumUse;true",
        "edAccelerationG;Text;Option;AccelerationG;0",
        "cbTable1UseVacuumCount;Text;Option;Table1VacuumCount;1",
        "edTable1VacuumDelay;Text;Option;Table1VacuumDelay;0",
        "cbTable2UseVacuumCount;Text;Option;Table2VacuumCount;1",
        "edTable2VacuumDelay;Text;Option;Table2VacuumDelay;0",
        "cbTable1LoadDir;ItemIndex;Table1LoadDir;LoadDir;0",
        "cbTable2LoadDir;ItemIndex;Table2LoadDir;LoadDir;0",
        "edAutoRunSpeedStage;Text;AutoRunSpeed;AutoRunSpeedStage;200",
        "edAutoRunSpeedZ;Text;AutoRunSpeed;AutoRunSpeedZ;30",
        "edTable1VisionFocusLightValue;Text;LightValue;Table1VisionFocusLightValue;100",
        "edTable1LaserFocusLightValue;Text;LightValue;Table1LaserFocusLightValue;100",
        "edTable2VisionFocusLightValue;Text;LightValue;Table2VisionFocusLightValue;100",
        "edTable2LaserFocusLightValue;Text;LightValue;Table2LaserFocusLightValue;100",
        "chkDustCollectorAutoRun;Checked;Option;DustCollectorAutoRun;true",
        "chkIOnizoerAutoRun;Checked;Option;IonizierAutoRun;true"};
            this.propSaver1.RootKey = YujinTechnology.RootKey.artHKEY_CURRENT_USER;
            this.propSaver1.SaveToRegistry = false;
            // 
            // tmr_SearchOffset
            // 
            this.tmr_SearchOffset.Interval = 200;
            this.tmr_SearchOffset.Tick += new System.EventHandler(this.tmr_SearchOffset_Tick);
            // 
            // multiLanguage1
            // 
            this.multiLanguage1.ActiveLanguage = -1;
            this.multiLanguage1.LanguageFilePrefix = "";
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = false;
            this.AutoThread.Interval = 200;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.btnCancel);
            this.panClient.Controls.Add(this.btnSet);
            this.panClient.Controls.Add(this.tabControl1);
            this.panClient.Controls.Add(this.btnAllSave);
            this.panClient.Font = new System.Drawing.Font("Tahoma", 11F);
            this.panClient.Location = new System.Drawing.Point(3, 3);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1367, 843);
            this.panClient.TabIndex = 0;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panClient.TitleText = "Common";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(955, 771);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 57);
            this.btnCancel.TabIndex = 1595;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            this.btnSet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSet.Location = new System.Drawing.Point(1084, 771);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(123, 57);
            this.btnSet.TabIndex = 1594;
            this.btnSet.Text = "Apply";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(15, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.ShowActiveCloseButton = false;
            this.tabControl1.ShowCloseButton = false;
            this.tabControl1.Size = new System.Drawing.Size(1332, 705);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControl1.TabIndex = 1593;
            this.tabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.tabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabControl1.TabSelectedHighColorSize = 4;
            this.tabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tabControl1.TabVisible = true;
            this.tabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabControl1.TipsColor = System.Drawing.Color.Red;
            this.tabControl1.TipsFont = new System.Drawing.Font("Arial", 8F);
            this.tabControl1.TipsForeColor = System.Drawing.Color.White;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.gradientLabel63);
            this.tabPage1.Controls.Add(this.edAutoRunSpeedZ);
            this.tabPage1.Controls.Add(this.edAutoRunTA);
            this.tabPage1.Controls.Add(this.gradientLabel64);
            this.tabPage1.Controls.Add(this.edAutoRunSpeedStage);
            this.tabPage1.Controls.Add(this.gradientLabel65);
            this.tabPage1.Controls.Add(this.edJumpTA);
            this.tabPage1.Controls.Add(this.edArcTA);
            this.tabPage1.Controls.Add(this.edLineTA);
            this.tabPage1.Controls.Add(this.gradLabel52);
            this.tabPage1.Controls.Add(this.gradLabel50);
            this.tabPage1.Controls.Add(this.gradLabel22);
            this.tabPage1.Controls.Add(this.edJumpSpeed);
            this.tabPage1.Controls.Add(this.edArcSpeed);
            this.tabPage1.Controls.Add(this.edLineSpeed);
            this.tabPage1.Controls.Add(this.gradLabel51);
            this.tabPage1.Controls.Add(this.gradLabel35);
            this.tabPage1.Controls.Add(this.gradLabel29);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1324, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Speed  ";
            // 
            // gradientLabel63
            // 
            this.gradientLabel63.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel63.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel63.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel63.FormatString = "0.00";
            this.gradientLabel63.Frame.Visible = false;
            this.gradientLabel63.GradientEnable = false;
            this.gradientLabel63.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel63.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel63.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel63.Location = new System.Drawing.Point(374, 356);
            this.gradientLabel63.Name = "gradientLabel63";
            this.gradientLabel63.ShowAccelChar = false;
            this.gradientLabel63.Size = new System.Drawing.Size(181, 26);
            this.gradientLabel63.TabIndex = 1610;
            this.gradientLabel63.Text = "- Z";
            this.gradientLabel63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edAutoRunSpeedZ
            // 
            this.edAutoRunSpeedZ.BackColor = System.Drawing.Color.White;
            this.edAutoRunSpeedZ.DataType = YujinTechnology.DataType.Double;
            this.edAutoRunSpeedZ.Frame.CornerRound = 1;
            this.edAutoRunSpeedZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edAutoRunSpeedZ.Hint = null;
            this.edAutoRunSpeedZ.Location = new System.Drawing.Point(561, 353);
            this.edAutoRunSpeedZ.Max = 0D;
            this.edAutoRunSpeedZ.Min = 0D;
            this.edAutoRunSpeedZ.Name = "edAutoRunSpeedZ";
            this.edAutoRunSpeedZ.NewText = "0.000";
            this.edAutoRunSpeedZ.PrecisionDigits = 3;
            this.edAutoRunSpeedZ.ShowHint = false;
            this.edAutoRunSpeedZ.Size = new System.Drawing.Size(95, 29);
            this.edAutoRunSpeedZ.TabIndex = 1609;
            this.edAutoRunSpeedZ.Text = "0.000";
            this.edAutoRunSpeedZ.Value = 0D;
            // 
            // edAutoRunTA
            // 
            this.edAutoRunTA.BackColor = System.Drawing.Color.White;
            this.edAutoRunTA.DataType = YujinTechnology.DataType.Double;
            this.edAutoRunTA.Frame.CornerRound = 1;
            this.edAutoRunTA.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edAutoRunTA.Hint = null;
            this.edAutoRunTA.Location = new System.Drawing.Point(796, 318);
            this.edAutoRunTA.Max = 0D;
            this.edAutoRunTA.Min = 0D;
            this.edAutoRunTA.Name = "edAutoRunTA";
            this.edAutoRunTA.NewText = "0.000";
            this.edAutoRunTA.PrecisionDigits = 3;
            this.edAutoRunTA.ShowHint = false;
            this.edAutoRunTA.Size = new System.Drawing.Size(95, 29);
            this.edAutoRunTA.TabIndex = 1607;
            this.edAutoRunTA.Text = "0.000";
            this.edAutoRunTA.Value = 0D;
            // 
            // gradientLabel64
            // 
            this.gradientLabel64.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel64.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel64.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel64.Frame.Visible = false;
            this.gradientLabel64.GradientEnable = false;
            this.gradientLabel64.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel64.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel64.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel64.Location = new System.Drawing.Point(662, 319);
            this.gradientLabel64.Name = "gradientLabel64";
            this.gradientLabel64.ShowAccelChar = false;
            this.gradientLabel64.Size = new System.Drawing.Size(128, 26);
            this.gradientLabel64.TabIndex = 1606;
            this.gradientLabel64.Text = "Auto Run Accel";
            this.gradientLabel64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edAutoRunSpeedStage
            // 
            this.edAutoRunSpeedStage.BackColor = System.Drawing.Color.White;
            this.edAutoRunSpeedStage.DataType = YujinTechnology.DataType.Double;
            this.edAutoRunSpeedStage.Frame.CornerRound = 1;
            this.edAutoRunSpeedStage.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edAutoRunSpeedStage.Hint = null;
            this.edAutoRunSpeedStage.Location = new System.Drawing.Point(561, 318);
            this.edAutoRunSpeedStage.Max = 0D;
            this.edAutoRunSpeedStage.Min = 0D;
            this.edAutoRunSpeedStage.Name = "edAutoRunSpeedStage";
            this.edAutoRunSpeedStage.NewText = "0.000";
            this.edAutoRunSpeedStage.PrecisionDigits = 3;
            this.edAutoRunSpeedStage.ShowHint = false;
            this.edAutoRunSpeedStage.Size = new System.Drawing.Size(95, 29);
            this.edAutoRunSpeedStage.TabIndex = 1605;
            this.edAutoRunSpeedStage.Text = "0.000";
            this.edAutoRunSpeedStage.Value = 0D;
            // 
            // gradientLabel65
            // 
            this.gradientLabel65.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel65.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel65.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel65.Frame.Visible = false;
            this.gradientLabel65.GradientEnable = false;
            this.gradientLabel65.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel65.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel65.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel65.Location = new System.Drawing.Point(374, 318);
            this.gradientLabel65.Name = "gradientLabel65";
            this.gradientLabel65.ShowAccelChar = false;
            this.gradientLabel65.Size = new System.Drawing.Size(181, 26);
            this.gradientLabel65.TabIndex = 1604;
            this.gradientLabel65.Text = "Auto Run Speed - Stage";
            this.gradientLabel65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edJumpTA
            // 
            this.edJumpTA.BackColor = System.Drawing.Color.White;
            this.edJumpTA.DataType = YujinTechnology.DataType.Double;
            this.edJumpTA.Frame.CornerRound = 1;
            this.edJumpTA.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edJumpTA.Hint = null;
            this.edJumpTA.Location = new System.Drawing.Point(796, 196);
            this.edJumpTA.Max = 0D;
            this.edJumpTA.Min = 0D;
            this.edJumpTA.Name = "edJumpTA";
            this.edJumpTA.NewText = "0.000";
            this.edJumpTA.PrecisionDigits = 3;
            this.edJumpTA.ShowHint = false;
            this.edJumpTA.Size = new System.Drawing.Size(95, 29);
            this.edJumpTA.TabIndex = 1599;
            this.edJumpTA.Text = "0.000";
            this.edJumpTA.Value = 0D;
            // 
            // edArcTA
            // 
            this.edArcTA.BackColor = System.Drawing.Color.White;
            this.edArcTA.DataType = YujinTechnology.DataType.Double;
            this.edArcTA.Frame.CornerRound = 1;
            this.edArcTA.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edArcTA.Hint = null;
            this.edArcTA.Location = new System.Drawing.Point(796, 164);
            this.edArcTA.Max = 0D;
            this.edArcTA.Min = 0D;
            this.edArcTA.Name = "edArcTA";
            this.edArcTA.NewText = "0.000";
            this.edArcTA.PrecisionDigits = 3;
            this.edArcTA.ShowHint = false;
            this.edArcTA.Size = new System.Drawing.Size(95, 29);
            this.edArcTA.TabIndex = 1598;
            this.edArcTA.Text = "0.000";
            this.edArcTA.Value = 0D;
            // 
            // edLineTA
            // 
            this.edLineTA.BackColor = System.Drawing.Color.White;
            this.edLineTA.DataType = YujinTechnology.DataType.Double;
            this.edLineTA.Frame.CornerRound = 1;
            this.edLineTA.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLineTA.Hint = null;
            this.edLineTA.Location = new System.Drawing.Point(796, 132);
            this.edLineTA.Max = 0D;
            this.edLineTA.Min = 0D;
            this.edLineTA.Name = "edLineTA";
            this.edLineTA.NewText = "0.000";
            this.edLineTA.PrecisionDigits = 3;
            this.edLineTA.ShowHint = false;
            this.edLineTA.Size = new System.Drawing.Size(95, 29);
            this.edLineTA.TabIndex = 1597;
            this.edLineTA.Text = "0.000";
            this.edLineTA.Value = 0D;
            // 
            // gradLabel52
            // 
            this.gradLabel52.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel52.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel52.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel52.Frame.Visible = false;
            this.gradLabel52.GradientEnable = false;
            this.gradLabel52.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel52.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel52.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel52.Location = new System.Drawing.Point(662, 197);
            this.gradLabel52.Name = "gradLabel52";
            this.gradLabel52.ShowAccelChar = false;
            this.gradLabel52.Size = new System.Drawing.Size(128, 26);
            this.gradLabel52.TabIndex = 1594;
            this.gradLabel52.Text = "Jump TA";
            this.gradLabel52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel50
            // 
            this.gradLabel50.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel50.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel50.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel50.Frame.Visible = false;
            this.gradLabel50.GradientEnable = false;
            this.gradLabel50.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel50.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel50.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel50.Location = new System.Drawing.Point(662, 165);
            this.gradLabel50.Name = "gradLabel50";
            this.gradLabel50.ShowAccelChar = false;
            this.gradLabel50.Size = new System.Drawing.Size(128, 26);
            this.gradLabel50.TabIndex = 1595;
            this.gradLabel50.Text = "Arc TA";
            this.gradLabel50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel22
            // 
            this.gradLabel22.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel22.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel22.Frame.Visible = false;
            this.gradLabel22.GradientEnable = false;
            this.gradLabel22.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel22.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel22.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel22.Location = new System.Drawing.Point(662, 133);
            this.gradLabel22.Name = "gradLabel22";
            this.gradLabel22.ShowAccelChar = false;
            this.gradLabel22.Size = new System.Drawing.Size(128, 26);
            this.gradLabel22.TabIndex = 1596;
            this.gradLabel22.Text = "Line TA";
            this.gradLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edJumpSpeed
            // 
            this.edJumpSpeed.BackColor = System.Drawing.Color.White;
            this.edJumpSpeed.DataType = YujinTechnology.DataType.Double;
            this.edJumpSpeed.Frame.CornerRound = 1;
            this.edJumpSpeed.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edJumpSpeed.Hint = null;
            this.edJumpSpeed.Location = new System.Drawing.Point(561, 196);
            this.edJumpSpeed.Max = 300D;
            this.edJumpSpeed.Min = 100D;
            this.edJumpSpeed.Name = "edJumpSpeed";
            this.edJumpSpeed.NewText = "0.000";
            this.edJumpSpeed.PrecisionDigits = 3;
            this.edJumpSpeed.ShowHint = false;
            this.edJumpSpeed.Size = new System.Drawing.Size(95, 29);
            this.edJumpSpeed.TabIndex = 1593;
            this.edJumpSpeed.Text = "100.000";
            this.edJumpSpeed.Value = 100D;
            // 
            // edArcSpeed
            // 
            this.edArcSpeed.BackColor = System.Drawing.Color.White;
            this.edArcSpeed.DataType = YujinTechnology.DataType.Double;
            this.edArcSpeed.Frame.CornerRound = 1;
            this.edArcSpeed.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edArcSpeed.Hint = null;
            this.edArcSpeed.Location = new System.Drawing.Point(561, 164);
            this.edArcSpeed.Max = 0D;
            this.edArcSpeed.Min = 0D;
            this.edArcSpeed.Name = "edArcSpeed";
            this.edArcSpeed.NewText = "0.000";
            this.edArcSpeed.PrecisionDigits = 3;
            this.edArcSpeed.ShowHint = false;
            this.edArcSpeed.Size = new System.Drawing.Size(95, 29);
            this.edArcSpeed.TabIndex = 1592;
            this.edArcSpeed.Text = "0.000";
            this.edArcSpeed.Value = 0D;
            // 
            // edLineSpeed
            // 
            this.edLineSpeed.BackColor = System.Drawing.Color.White;
            this.edLineSpeed.DataType = YujinTechnology.DataType.Double;
            this.edLineSpeed.Frame.CornerRound = 1;
            this.edLineSpeed.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLineSpeed.Hint = null;
            this.edLineSpeed.Location = new System.Drawing.Point(561, 132);
            this.edLineSpeed.Max = 0D;
            this.edLineSpeed.Min = 0D;
            this.edLineSpeed.Name = "edLineSpeed";
            this.edLineSpeed.NewText = "0.000";
            this.edLineSpeed.PrecisionDigits = 3;
            this.edLineSpeed.ShowHint = false;
            this.edLineSpeed.Size = new System.Drawing.Size(95, 29);
            this.edLineSpeed.TabIndex = 1591;
            this.edLineSpeed.Text = "0.000";
            this.edLineSpeed.Value = 0D;
            // 
            // gradLabel51
            // 
            this.gradLabel51.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel51.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel51.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel51.Frame.Visible = false;
            this.gradLabel51.GradientEnable = false;
            this.gradLabel51.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel51.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel51.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel51.Location = new System.Drawing.Point(427, 197);
            this.gradLabel51.Name = "gradLabel51";
            this.gradLabel51.ShowAccelChar = false;
            this.gradLabel51.Size = new System.Drawing.Size(128, 26);
            this.gradLabel51.TabIndex = 1588;
            this.gradLabel51.Text = "Jump Speed";
            this.gradLabel51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel35
            // 
            this.gradLabel35.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel35.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel35.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel35.Frame.Visible = false;
            this.gradLabel35.GradientEnable = false;
            this.gradLabel35.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel35.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel35.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel35.Location = new System.Drawing.Point(427, 165);
            this.gradLabel35.Name = "gradLabel35";
            this.gradLabel35.ShowAccelChar = false;
            this.gradLabel35.Size = new System.Drawing.Size(128, 26);
            this.gradLabel35.TabIndex = 1589;
            this.gradLabel35.Text = "Arc Speed";
            this.gradLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel29
            // 
            this.gradLabel29.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel29.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel29.Frame.Visible = false;
            this.gradLabel29.GradientEnable = false;
            this.gradLabel29.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel29.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel29.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel29.Location = new System.Drawing.Point(427, 133);
            this.gradLabel29.Name = "gradLabel29";
            this.gradLabel29.ShowAccelChar = false;
            this.gradLabel29.Size = new System.Drawing.Size(128, 26);
            this.gradLabel29.TabIndex = 1590;
            this.gradLabel29.Text = "Line Speed";
            this.gradLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.sunnyLine4);
            this.tabPage2.Controls.Add(this.btnSetLoadPos);
            this.tabPage2.Controls.Add(this.btnMoveLoadPos);
            this.tabPage2.Controls.Add(this.uiLine17);
            this.tabPage2.Controls.Add(this.edMode0Period);
            this.tabPage2.Controls.Add(this.edMode0PulseWidth);
            this.tabPage2.Controls.Add(this.gradientLabel60);
            this.tabPage2.Controls.Add(this.gradientLabel61);
            this.tabPage2.Controls.Add(this.btnSetMeasurePos);
            this.tabPage2.Controls.Add(this.btnMoveMeasurePos);
            this.tabPage2.Controls.Add(this.gradientLabel8);
            this.tabPage2.Controls.Add(this.btnMark);
            this.tabPage2.Controls.Add(this.gradientLabel29);
            this.tabPage2.Controls.Add(this.edTable2YOffset);
            this.tabPage2.Controls.Add(this.edTable2XOffset);
            this.tabPage2.Controls.Add(this.btnMove);
            this.tabPage2.Controls.Add(this.gradientLabel6);
            this.tabPage2.Controls.Add(this.edTable2MarkCenterY);
            this.tabPage2.Controls.Add(this.edTable2MarkCenterX);
            this.tabPage2.Controls.Add(this.btnMeasure);
            this.tabPage2.Controls.Add(this.gradientLabel14);
            this.tabPage2.Controls.Add(this.gradientLabel15);
            this.tabPage2.Controls.Add(this.gradientLabel16);
            this.tabPage2.Controls.Add(this.edHomeOffsetPosZ);
            this.tabPage2.Controls.Add(this.edHomeOffsetPosY1);
            this.tabPage2.Controls.Add(this.edHomeOffsetPosY2);
            this.tabPage2.Controls.Add(this.edHomeOffsetPosX);
            this.tabPage2.Controls.Add(this.gradientLabel17);
            this.tabPage2.Controls.Add(this.gradientLabel18);
            this.tabPage2.Controls.Add(this.sunnyLine1);
            this.tabPage2.Controls.Add(this.gradientLabel7);
            this.tabPage2.Controls.Add(this.edPowerMeterZPos);
            this.tabPage2.Controls.Add(this.edPowerMeterXPos);
            this.tabPage2.Controls.Add(this.gradLabel28);
            this.tabPage2.Controls.Add(this.gradLabel30);
            this.tabPage2.Controls.Add(this.edTable2NozzleYOffset);
            this.tabPage2.Controls.Add(this.edTable2NozzleXOffset);
            this.tabPage2.Controls.Add(this.sunnyLine3);
            this.tabPage2.Controls.Add(this.gradLabel39);
            this.tabPage2.Controls.Add(this.gradLabel15);
            this.tabPage2.Controls.Add(this.gradientLabel3);
            this.tabPage2.Controls.Add(this.gradientLabel2);
            this.tabPage2.Controls.Add(this.gradientLabel1);
            this.tabPage2.Controls.Add(this.edLoadPosZ);
            this.tabPage2.Controls.Add(this.edLoadPosY1);
            this.tabPage2.Controls.Add(this.edLoadPosY2);
            this.tabPage2.Controls.Add(this.edLoadPosX);
            this.tabPage2.Controls.Add(this.uiLine5);
            this.tabPage2.Controls.Add(this.gradLabel7);
            this.tabPage2.Controls.Add(this.gradLabel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1324, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Position  ";
            // 
            // sunnyLine4
            // 
            this.sunnyLine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine4.Direction = YujinTechnology.LineDirection.Horizontal;
            this.sunnyLine4.EndCap = YujinTechnology.UILineCap.None;
            this.sunnyLine4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine4.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine4.Frame.Visible = false;
            this.sunnyLine4.Hint = null;
            this.sunnyLine4.LineCapSize = 4;
            this.sunnyLine4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine4.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.sunnyLine4.LineWidth = 1F;
            this.sunnyLine4.Location = new System.Drawing.Point(746, 272);
            this.sunnyLine4.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine4.Name = "sunnyLine4";
            this.sunnyLine4.ShowHint = false;
            this.sunnyLine4.Size = new System.Drawing.Size(243, 17);
            this.sunnyLine4.StartCap = YujinTechnology.UILineCap.None;
            this.sunnyLine4.TabIndex = 1683;
            this.sunnyLine4.Text = "Table2번 전용";
            this.sunnyLine4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine4.TextInterval = 4;
            // 
            // btnSetLoadPos
            // 
            this.btnSetLoadPos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetLoadPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetLoadPos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetLoadPos.Location = new System.Drawing.Point(746, 206);
            this.btnSetLoadPos.Name = "btnSetLoadPos";
            this.btnSetLoadPos.Size = new System.Drawing.Size(32, 29);
            this.btnSetLoadPos.TabIndex = 1682;
            this.btnSetLoadPos.Text = "Set";
            this.btnSetLoadPos.UseVisualStyleBackColor = false;
            this.btnSetLoadPos.Click += new System.EventHandler(this.btnSetLoadPos_Click);
            // 
            // btnMoveLoadPos
            // 
            this.btnMoveLoadPos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveLoadPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveLoadPos.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMoveLoadPos.Location = new System.Drawing.Point(782, 206);
            this.btnMoveLoadPos.Name = "btnMoveLoadPos";
            this.btnMoveLoadPos.Size = new System.Drawing.Size(32, 29);
            this.btnMoveLoadPos.TabIndex = 1681;
            this.btnMoveLoadPos.Text = "▷";
            this.btnMoveLoadPos.UseVisualStyleBackColor = false;
            this.btnMoveLoadPos.Click += new System.EventHandler(this.btnMoveLoadPos_Click);
            // 
            // uiLine17
            // 
            this.uiLine17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine17.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine17.Direction = YujinTechnology.LineDirection.Horizontal;
            this.uiLine17.EndCap = YujinTechnology.UILineCap.None;
            this.uiLine17.Font = new System.Drawing.Font("Tahoma", 11F);
            this.uiLine17.ForeColor = System.Drawing.Color.Black;
            this.uiLine17.Frame.Visible = false;
            this.uiLine17.Hint = null;
            this.uiLine17.LineCapSize = 4;
            this.uiLine17.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine17.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.uiLine17.LineWidth = 1F;
            this.uiLine17.Location = new System.Drawing.Point(260, 373);
            this.uiLine17.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine17.Name = "uiLine17";
            this.uiLine17.ShowHint = false;
            this.uiLine17.Size = new System.Drawing.Size(183, 17);
            this.uiLine17.StartCap = YujinTechnology.UILineCap.None;
            this.uiLine17.TabIndex = 1680;
            this.uiLine17.Text = "Mode 0 (Int - Encoder)";
            this.uiLine17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine17.TextInterval = 4;
            // 
            // edMode0Period
            // 
            this.edMode0Period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edMode0Period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edMode0Period.DataType = YujinTechnology.DataType.Double;
            this.edMode0Period.Enabled = false;
            this.edMode0Period.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMode0Period.ForeColor = System.Drawing.Color.Black;
            this.edMode0Period.Frame.CornerRound = 1;
            this.edMode0Period.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMode0Period.Hint = null;
            this.edMode0Period.Location = new System.Drawing.Point(348, 399);
            this.edMode0Period.Max = 0D;
            this.edMode0Period.Min = 0D;
            this.edMode0Period.Name = "edMode0Period";
            this.edMode0Period.PrecisionDigits = 3;
            this.edMode0Period.ShowHint = false;
            this.edMode0Period.Size = new System.Drawing.Size(95, 29);
            this.edMode0Period.TabIndex = 1678;
            this.edMode0Period.TabStop = false;
            this.edMode0Period.Text = "0.000";
            this.edMode0Period.Value = 0D;
            // 
            // edMode0PulseWidth
            // 
            this.edMode0PulseWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edMode0PulseWidth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edMode0PulseWidth.DataType = YujinTechnology.DataType.Double;
            this.edMode0PulseWidth.Enabled = false;
            this.edMode0PulseWidth.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMode0PulseWidth.ForeColor = System.Drawing.Color.Black;
            this.edMode0PulseWidth.Frame.CornerRound = 1;
            this.edMode0PulseWidth.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMode0PulseWidth.Hint = null;
            this.edMode0PulseWidth.Location = new System.Drawing.Point(348, 431);
            this.edMode0PulseWidth.Max = 0D;
            this.edMode0PulseWidth.Min = 0D;
            this.edMode0PulseWidth.Name = "edMode0PulseWidth";
            this.edMode0PulseWidth.PrecisionDigits = 3;
            this.edMode0PulseWidth.ShowHint = false;
            this.edMode0PulseWidth.Size = new System.Drawing.Size(95, 29);
            this.edMode0PulseWidth.TabIndex = 1679;
            this.edMode0PulseWidth.TabStop = false;
            this.edMode0PulseWidth.Text = "0.000";
            this.edMode0PulseWidth.Value = 0D;
            // 
            // gradientLabel60
            // 
            this.gradientLabel60.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel60.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel60.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel60.Frame.Visible = false;
            this.gradientLabel60.GradientEnable = false;
            this.gradientLabel60.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel60.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel60.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel60.Location = new System.Drawing.Point(214, 402);
            this.gradientLabel60.Name = "gradientLabel60";
            this.gradientLabel60.ShowAccelChar = false;
            this.gradientLabel60.Size = new System.Drawing.Size(128, 29);
            this.gradientLabel60.TabIndex = 1676;
            this.gradientLabel60.Text = "Pulse Period (us)";
            this.gradientLabel60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel61
            // 
            this.gradientLabel61.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel61.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel61.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel61.Frame.Visible = false;
            this.gradientLabel61.GradientEnable = false;
            this.gradientLabel61.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel61.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel61.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel61.Location = new System.Drawing.Point(214, 431);
            this.gradientLabel61.Name = "gradientLabel61";
            this.gradientLabel61.ShowAccelChar = false;
            this.gradientLabel61.Size = new System.Drawing.Size(128, 29);
            this.gradientLabel61.TabIndex = 1677;
            this.gradientLabel61.Text = "Pulse Width (us)";
            this.gradientLabel61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetMeasurePos
            // 
            this.btnSetMeasurePos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetMeasurePos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetMeasurePos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetMeasurePos.Location = new System.Drawing.Point(546, 335);
            this.btnSetMeasurePos.Name = "btnSetMeasurePos";
            this.btnSetMeasurePos.Size = new System.Drawing.Size(32, 29);
            this.btnSetMeasurePos.TabIndex = 1675;
            this.btnSetMeasurePos.Text = "Set";
            this.btnSetMeasurePos.UseVisualStyleBackColor = false;
            this.btnSetMeasurePos.Click += new System.EventHandler(this.btnSetMeasurePos_Click);
            // 
            // btnMoveMeasurePos
            // 
            this.btnMoveMeasurePos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveMeasurePos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveMeasurePos.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMoveMeasurePos.Location = new System.Drawing.Point(582, 335);
            this.btnMoveMeasurePos.Name = "btnMoveMeasurePos";
            this.btnMoveMeasurePos.Size = new System.Drawing.Size(32, 29);
            this.btnMoveMeasurePos.TabIndex = 1670;
            this.btnMoveMeasurePos.Text = "▷";
            this.btnMoveMeasurePos.UseVisualStyleBackColor = false;
            this.btnMoveMeasurePos.Click += new System.EventHandler(this.btnMoveMeasurePos_Click);
            // 
            // gradientLabel8
            // 
            this.gradientLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel8.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel8.GradientEnable = false;
            this.gradientLabel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel8.Location = new System.Drawing.Point(142, 334);
            this.gradientLabel8.Name = "gradientLabel8";
            this.gradientLabel8.ShowAccelChar = false;
            this.gradientLabel8.Size = new System.Drawing.Size(200, 29);
            this.gradientLabel8.TabIndex = 1669;
            this.gradientLabel8.Text = "Power Meter Measure Pos";
            this.gradientLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMark
            // 
            this.btnMark.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMark.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMark.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMark.ForeColor = System.Drawing.Color.Black;
            this.btnMark.LED.Size = new System.Drawing.Size(16, 26);
            this.btnMark.Location = new System.Drawing.Point(896, 440);
            this.btnMark.Margin2 = 10;
            this.btnMark.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(91, 46);
            this.btnMark.TabIndex = 1664;
            this.btnMark.Text = "Mark Cross";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // gradientLabel29
            // 
            this.gradientLabel29.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel29.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel29.GradientEnable = false;
            this.gradientLabel29.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel29.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel29.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel29.Location = new System.Drawing.Point(872, 367);
            this.gradientLabel29.Name = "gradientLabel29";
            this.gradientLabel29.ShowAccelChar = false;
            this.gradientLabel29.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel29.TabIndex = 1663;
            this.gradientLabel29.Text = "Current";
            this.gradientLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable2YOffset
            // 
            this.edTable2YOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable2YOffset.DataType = YujinTechnology.DataType.Double;
            this.edTable2YOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2YOffset.Frame.CornerRound = 1;
            this.edTable2YOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2YOffset.Hint = null;
            this.edTable2YOffset.Location = new System.Drawing.Point(1092, 367);
            this.edTable2YOffset.Max = 0D;
            this.edTable2YOffset.Min = 0D;
            this.edTable2YOffset.Name = "edTable2YOffset";
            this.edTable2YOffset.NewText = "0.000";
            this.edTable2YOffset.PrecisionDigits = 3;
            this.edTable2YOffset.ShowHint = false;
            this.edTable2YOffset.Size = new System.Drawing.Size(95, 29);
            this.edTable2YOffset.TabIndex = 1662;
            this.edTable2YOffset.Text = "0.000";
            this.edTable2YOffset.Value = 0D;
            // 
            // edTable2XOffset
            // 
            this.edTable2XOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable2XOffset.DataType = YujinTechnology.DataType.Double;
            this.edTable2XOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2XOffset.Frame.CornerRound = 1;
            this.edTable2XOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2XOffset.Hint = null;
            this.edTable2XOffset.Location = new System.Drawing.Point(993, 367);
            this.edTable2XOffset.Max = 0D;
            this.edTable2XOffset.Min = 0D;
            this.edTable2XOffset.Name = "edTable2XOffset";
            this.edTable2XOffset.NewText = "0.000";
            this.edTable2XOffset.PrecisionDigits = 3;
            this.edTable2XOffset.ShowHint = false;
            this.edTable2XOffset.Size = new System.Drawing.Size(95, 29);
            this.edTable2XOffset.TabIndex = 1661;
            this.edTable2XOffset.Text = "0.000";
            this.edTable2XOffset.Value = 0D;
            // 
            // btnMove
            // 
            this.btnMove.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMove.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMove.Location = new System.Drawing.Point(1191, 334);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(32, 29);
            this.btnMove.TabIndex = 1660;
            this.btnMove.Text = "▷";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // gradientLabel6
            // 
            this.gradientLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel6.GradientEnable = false;
            this.gradientLabel6.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel6.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel6.Location = new System.Drawing.Point(872, 334);
            this.gradientLabel6.Name = "gradientLabel6";
            this.gradientLabel6.ShowAccelChar = false;
            this.gradientLabel6.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel6.TabIndex = 1659;
            this.gradientLabel6.Text = "Start Pos";
            this.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable2MarkCenterY
            // 
            this.edTable2MarkCenterY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable2MarkCenterY.DataType = YujinTechnology.DataType.Double;
            this.edTable2MarkCenterY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2MarkCenterY.Frame.CornerRound = 1;
            this.edTable2MarkCenterY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2MarkCenterY.Hint = null;
            this.edTable2MarkCenterY.Location = new System.Drawing.Point(1092, 334);
            this.edTable2MarkCenterY.Max = 0D;
            this.edTable2MarkCenterY.Min = 0D;
            this.edTable2MarkCenterY.Name = "edTable2MarkCenterY";
            this.edTable2MarkCenterY.NewText = "0.000";
            this.edTable2MarkCenterY.PrecisionDigits = 3;
            this.edTable2MarkCenterY.ShowHint = false;
            this.edTable2MarkCenterY.Size = new System.Drawing.Size(95, 29);
            this.edTable2MarkCenterY.TabIndex = 1658;
            this.edTable2MarkCenterY.Text = "0.000";
            this.edTable2MarkCenterY.Value = 0D;
            // 
            // edTable2MarkCenterX
            // 
            this.edTable2MarkCenterX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable2MarkCenterX.DataType = YujinTechnology.DataType.Double;
            this.edTable2MarkCenterX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2MarkCenterX.Frame.CornerRound = 1;
            this.edTable2MarkCenterX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2MarkCenterX.Hint = null;
            this.edTable2MarkCenterX.Location = new System.Drawing.Point(993, 334);
            this.edTable2MarkCenterX.Max = 0D;
            this.edTable2MarkCenterX.Min = 0D;
            this.edTable2MarkCenterX.Name = "edTable2MarkCenterX";
            this.edTable2MarkCenterX.NewText = "0.000";
            this.edTable2MarkCenterX.PrecisionDigits = 3;
            this.edTable2MarkCenterX.ShowHint = false;
            this.edTable2MarkCenterX.Size = new System.Drawing.Size(95, 29);
            this.edTable2MarkCenterX.TabIndex = 1657;
            this.edTable2MarkCenterX.Text = "0.000";
            this.edTable2MarkCenterX.Value = 0D;
            // 
            // btnMeasure
            // 
            this.btnMeasure.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMeasure.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMeasure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasure.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMeasure.ForeColor = System.Drawing.Color.Black;
            this.btnMeasure.LED.Size = new System.Drawing.Size(16, 26);
            this.btnMeasure.Location = new System.Drawing.Point(1092, 440);
            this.btnMeasure.Margin2 = 10;
            this.btnMeasure.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(91, 46);
            this.btnMeasure.TabIndex = 1656;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = false;
            this.btnMeasure.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.btnMeasure_LEDValueChanged);
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // gradientLabel14
            // 
            this.gradientLabel14.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel14.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel14.GradientEnable = false;
            this.gradientLabel14.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel14.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel14.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel14.Location = new System.Drawing.Point(645, 81);
            this.gradientLabel14.Name = "gradientLabel14";
            this.gradientLabel14.ShowAccelChar = false;
            this.gradientLabel14.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel14.TabIndex = 1655;
            this.gradientLabel14.Text = "Z";
            this.gradientLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel15
            // 
            this.gradientLabel15.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel15.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel15.GradientEnable = false;
            this.gradientLabel15.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel15.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel15.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel15.Location = new System.Drawing.Point(546, 81);
            this.gradientLabel15.Name = "gradientLabel15";
            this.gradientLabel15.ShowAccelChar = false;
            this.gradientLabel15.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel15.TabIndex = 1654;
            this.gradientLabel15.Text = "Y2";
            this.gradientLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel16
            // 
            this.gradientLabel16.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel16.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel16.GradientEnable = false;
            this.gradientLabel16.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel16.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel16.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel16.Location = new System.Drawing.Point(447, 81);
            this.gradientLabel16.Name = "gradientLabel16";
            this.gradientLabel16.ShowAccelChar = false;
            this.gradientLabel16.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel16.TabIndex = 1653;
            this.gradientLabel16.Text = "Y1";
            this.gradientLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edHomeOffsetPosZ
            // 
            this.edHomeOffsetPosZ.BackColor = System.Drawing.Color.White;
            this.edHomeOffsetPosZ.DataType = YujinTechnology.DataType.Double;
            this.edHomeOffsetPosZ.Enabled = false;
            this.edHomeOffsetPosZ.Frame.CornerRound = 1;
            this.edHomeOffsetPosZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edHomeOffsetPosZ.Hint = null;
            this.edHomeOffsetPosZ.Location = new System.Drawing.Point(645, 111);
            this.edHomeOffsetPosZ.Max = 0D;
            this.edHomeOffsetPosZ.Min = 0D;
            this.edHomeOffsetPosZ.Name = "edHomeOffsetPosZ";
            this.edHomeOffsetPosZ.NewText = "0.000";
            this.edHomeOffsetPosZ.PrecisionDigits = 3;
            this.edHomeOffsetPosZ.ShowHint = false;
            this.edHomeOffsetPosZ.Size = new System.Drawing.Size(95, 29);
            this.edHomeOffsetPosZ.TabIndex = 1652;
            this.edHomeOffsetPosZ.Text = "0.000";
            this.edHomeOffsetPosZ.Value = 0D;
            // 
            // edHomeOffsetPosY1
            // 
            this.edHomeOffsetPosY1.BackColor = System.Drawing.Color.White;
            this.edHomeOffsetPosY1.DataType = YujinTechnology.DataType.Double;
            this.edHomeOffsetPosY1.Enabled = false;
            this.edHomeOffsetPosY1.Frame.CornerRound = 1;
            this.edHomeOffsetPosY1.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edHomeOffsetPosY1.Hint = null;
            this.edHomeOffsetPosY1.Location = new System.Drawing.Point(447, 111);
            this.edHomeOffsetPosY1.Max = 0D;
            this.edHomeOffsetPosY1.Min = 0D;
            this.edHomeOffsetPosY1.Name = "edHomeOffsetPosY1";
            this.edHomeOffsetPosY1.NewText = "0.000";
            this.edHomeOffsetPosY1.PrecisionDigits = 3;
            this.edHomeOffsetPosY1.ShowHint = false;
            this.edHomeOffsetPosY1.Size = new System.Drawing.Size(95, 29);
            this.edHomeOffsetPosY1.TabIndex = 1651;
            this.edHomeOffsetPosY1.Text = "0.000";
            this.edHomeOffsetPosY1.Value = 0D;
            // 
            // edHomeOffsetPosY2
            // 
            this.edHomeOffsetPosY2.BackColor = System.Drawing.Color.White;
            this.edHomeOffsetPosY2.DataType = YujinTechnology.DataType.Double;
            this.edHomeOffsetPosY2.Enabled = false;
            this.edHomeOffsetPosY2.Frame.CornerRound = 1;
            this.edHomeOffsetPosY2.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edHomeOffsetPosY2.Hint = null;
            this.edHomeOffsetPosY2.Location = new System.Drawing.Point(546, 111);
            this.edHomeOffsetPosY2.Max = 0D;
            this.edHomeOffsetPosY2.Min = 0D;
            this.edHomeOffsetPosY2.Name = "edHomeOffsetPosY2";
            this.edHomeOffsetPosY2.NewText = "0.000";
            this.edHomeOffsetPosY2.PrecisionDigits = 3;
            this.edHomeOffsetPosY2.ShowHint = false;
            this.edHomeOffsetPosY2.Size = new System.Drawing.Size(95, 29);
            this.edHomeOffsetPosY2.TabIndex = 1650;
            this.edHomeOffsetPosY2.Text = "0.000";
            this.edHomeOffsetPosY2.Value = 0D;
            // 
            // edHomeOffsetPosX
            // 
            this.edHomeOffsetPosX.BackColor = System.Drawing.Color.White;
            this.edHomeOffsetPosX.DataType = YujinTechnology.DataType.Double;
            this.edHomeOffsetPosX.Enabled = false;
            this.edHomeOffsetPosX.Frame.CornerRound = 1;
            this.edHomeOffsetPosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edHomeOffsetPosX.Hint = null;
            this.edHomeOffsetPosX.Location = new System.Drawing.Point(348, 111);
            this.edHomeOffsetPosX.Max = 0D;
            this.edHomeOffsetPosX.Min = 0D;
            this.edHomeOffsetPosX.Name = "edHomeOffsetPosX";
            this.edHomeOffsetPosX.NewText = "0.000";
            this.edHomeOffsetPosX.PrecisionDigits = 3;
            this.edHomeOffsetPosX.ShowHint = false;
            this.edHomeOffsetPosX.Size = new System.Drawing.Size(95, 29);
            this.edHomeOffsetPosX.TabIndex = 1649;
            this.edHomeOffsetPosX.Text = "0.000";
            this.edHomeOffsetPosX.Value = 0D;
            // 
            // gradientLabel17
            // 
            this.gradientLabel17.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel17.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel17.GradientEnable = false;
            this.gradientLabel17.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel17.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel17.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel17.Location = new System.Drawing.Point(348, 81);
            this.gradientLabel17.Name = "gradientLabel17";
            this.gradientLabel17.ShowAccelChar = false;
            this.gradientLabel17.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel17.TabIndex = 1647;
            this.gradientLabel17.Text = "X";
            this.gradientLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel18
            // 
            this.gradientLabel18.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel18.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel18.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel18.GradientEnable = false;
            this.gradientLabel18.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel18.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel18.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel18.Location = new System.Drawing.Point(227, 111);
            this.gradientLabel18.Name = "gradientLabel18";
            this.gradientLabel18.ShowAccelChar = false;
            this.gradientLabel18.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel18.TabIndex = 1648;
            this.gradientLabel18.Text = "Offset Pos";
            this.gradientLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sunnyLine1
            // 
            this.sunnyLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine1.Direction = YujinTechnology.LineDirection.Horizontal;
            this.sunnyLine1.EndCap = YujinTechnology.UILineCap.None;
            this.sunnyLine1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine1.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine1.Frame.Visible = false;
            this.sunnyLine1.Hint = null;
            this.sunnyLine1.LineCapSize = 4;
            this.sunnyLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine1.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.sunnyLine1.LineWidth = 1F;
            this.sunnyLine1.Location = new System.Drawing.Point(222, 61);
            this.sunnyLine1.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine1.Name = "sunnyLine1";
            this.sunnyLine1.ShowHint = false;
            this.sunnyLine1.Size = new System.Drawing.Size(183, 17);
            this.sunnyLine1.StartCap = YujinTechnology.UILineCap.None;
            this.sunnyLine1.TabIndex = 1646;
            this.sunnyLine1.Text = "Home Offset Position";
            this.sunnyLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine1.TextInterval = 4;
            // 
            // gradientLabel7
            // 
            this.gradientLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel7.GradientEnable = false;
            this.gradientLabel7.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel7.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel7.Location = new System.Drawing.Point(872, 400);
            this.gradientLabel7.Name = "gradientLabel7";
            this.gradientLabel7.ShowAccelChar = false;
            this.gradientLabel7.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel7.TabIndex = 1637;
            this.gradientLabel7.Text = "Offset";
            this.gradientLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edPowerMeterZPos
            // 
            this.edPowerMeterZPos.BackColor = System.Drawing.Color.White;
            this.edPowerMeterZPos.DataType = YujinTechnology.DataType.Double;
            this.edPowerMeterZPos.Frame.CornerRound = 1;
            this.edPowerMeterZPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPowerMeterZPos.Hint = null;
            this.edPowerMeterZPos.Location = new System.Drawing.Point(447, 334);
            this.edPowerMeterZPos.Max = 0D;
            this.edPowerMeterZPos.Min = 0D;
            this.edPowerMeterZPos.Name = "edPowerMeterZPos";
            this.edPowerMeterZPos.NewText = "0.000";
            this.edPowerMeterZPos.PrecisionDigits = 3;
            this.edPowerMeterZPos.ShowHint = false;
            this.edPowerMeterZPos.Size = new System.Drawing.Size(95, 29);
            this.edPowerMeterZPos.TabIndex = 1633;
            this.edPowerMeterZPos.Text = "0.000";
            this.edPowerMeterZPos.Value = 0D;
            // 
            // edPowerMeterXPos
            // 
            this.edPowerMeterXPos.BackColor = System.Drawing.Color.White;
            this.edPowerMeterXPos.DataType = YujinTechnology.DataType.Double;
            this.edPowerMeterXPos.Frame.CornerRound = 1;
            this.edPowerMeterXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPowerMeterXPos.Hint = null;
            this.edPowerMeterXPos.Location = new System.Drawing.Point(348, 334);
            this.edPowerMeterXPos.Max = 0D;
            this.edPowerMeterXPos.Min = 0D;
            this.edPowerMeterXPos.Name = "edPowerMeterXPos";
            this.edPowerMeterXPos.NewText = "0.000";
            this.edPowerMeterXPos.PrecisionDigits = 3;
            this.edPowerMeterXPos.ShowHint = false;
            this.edPowerMeterXPos.Size = new System.Drawing.Size(95, 29);
            this.edPowerMeterXPos.TabIndex = 1632;
            this.edPowerMeterXPos.Text = "0.000";
            this.edPowerMeterXPos.Value = 0D;
            // 
            // gradLabel28
            // 
            this.gradLabel28.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel28.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel28.GradientEnable = false;
            this.gradLabel28.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel28.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel28.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel28.Location = new System.Drawing.Point(447, 304);
            this.gradLabel28.Name = "gradLabel28";
            this.gradLabel28.ShowAccelChar = false;
            this.gradLabel28.Size = new System.Drawing.Size(95, 26);
            this.gradLabel28.TabIndex = 1630;
            this.gradLabel28.Text = "Z";
            this.gradLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel30
            // 
            this.gradLabel30.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel30.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel30.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel30.GradientEnable = false;
            this.gradLabel30.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel30.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel30.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel30.Location = new System.Drawing.Point(348, 304);
            this.gradLabel30.Name = "gradLabel30";
            this.gradLabel30.ShowAccelChar = false;
            this.gradLabel30.Size = new System.Drawing.Size(95, 26);
            this.gradLabel30.TabIndex = 1631;
            this.gradLabel30.Text = "X";
            this.gradLabel30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable2NozzleYOffset
            // 
            this.edTable2NozzleYOffset.BackColor = System.Drawing.Color.White;
            this.edTable2NozzleYOffset.DataType = YujinTechnology.DataType.Double;
            this.edTable2NozzleYOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2NozzleYOffset.Frame.CornerRound = 1;
            this.edTable2NozzleYOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2NozzleYOffset.Hint = null;
            this.edTable2NozzleYOffset.Location = new System.Drawing.Point(1092, 400);
            this.edTable2NozzleYOffset.Max = 0D;
            this.edTable2NozzleYOffset.Min = 0D;
            this.edTable2NozzleYOffset.Name = "edTable2NozzleYOffset";
            this.edTable2NozzleYOffset.NewText = "0.000";
            this.edTable2NozzleYOffset.PrecisionDigits = 3;
            this.edTable2NozzleYOffset.ShowHint = false;
            this.edTable2NozzleYOffset.Size = new System.Drawing.Size(95, 29);
            this.edTable2NozzleYOffset.TabIndex = 1615;
            this.edTable2NozzleYOffset.Text = "0.000";
            this.edTable2NozzleYOffset.Value = 0D;
            // 
            // edTable2NozzleXOffset
            // 
            this.edTable2NozzleXOffset.BackColor = System.Drawing.Color.White;
            this.edTable2NozzleXOffset.DataType = YujinTechnology.DataType.Double;
            this.edTable2NozzleXOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2NozzleXOffset.Frame.CornerRound = 1;
            this.edTable2NozzleXOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2NozzleXOffset.Hint = null;
            this.edTable2NozzleXOffset.Location = new System.Drawing.Point(993, 400);
            this.edTable2NozzleXOffset.Max = 0D;
            this.edTable2NozzleXOffset.Min = 0D;
            this.edTable2NozzleXOffset.Name = "edTable2NozzleXOffset";
            this.edTable2NozzleXOffset.NewText = "0.000";
            this.edTable2NozzleXOffset.PrecisionDigits = 3;
            this.edTable2NozzleXOffset.ShowHint = false;
            this.edTable2NozzleXOffset.Size = new System.Drawing.Size(95, 29);
            this.edTable2NozzleXOffset.TabIndex = 1614;
            this.edTable2NozzleXOffset.Text = "0.000";
            this.edTable2NozzleXOffset.Value = 0D;
            // 
            // sunnyLine3
            // 
            this.sunnyLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine3.Direction = YujinTechnology.LineDirection.Horizontal;
            this.sunnyLine3.EndCap = YujinTechnology.UILineCap.None;
            this.sunnyLine3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine3.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine3.Frame.Visible = false;
            this.sunnyLine3.Hint = null;
            this.sunnyLine3.LineCapSize = 4;
            this.sunnyLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine3.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.sunnyLine3.LineWidth = 1F;
            this.sunnyLine3.Location = new System.Drawing.Point(744, 309);
            this.sunnyLine3.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine3.Name = "sunnyLine3";
            this.sunnyLine3.ShowHint = false;
            this.sunnyLine3.Size = new System.Drawing.Size(243, 17);
            this.sunnyLine3.StartCap = YujinTechnology.UILineCap.None;
            this.sunnyLine3.TabIndex = 1600;
            this.sunnyLine3.Text = "Vision Center To Nozzle Center Offset";
            this.sunnyLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine3.TextInterval = 4;
            // 
            // gradLabel39
            // 
            this.gradLabel39.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel39.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel39.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel39.GradientEnable = false;
            this.gradLabel39.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel39.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel39.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel39.Location = new System.Drawing.Point(993, 304);
            this.gradLabel39.Name = "gradLabel39";
            this.gradLabel39.ShowAccelChar = false;
            this.gradLabel39.Size = new System.Drawing.Size(94, 26);
            this.gradLabel39.TabIndex = 1598;
            this.gradLabel39.Text = "X";
            this.gradLabel39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel15
            // 
            this.gradLabel15.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel15.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel15.GradientEnable = false;
            this.gradLabel15.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel15.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel15.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel15.Location = new System.Drawing.Point(1092, 304);
            this.gradLabel15.Name = "gradLabel15";
            this.gradLabel15.ShowAccelChar = false;
            this.gradLabel15.Size = new System.Drawing.Size(94, 26);
            this.gradLabel15.TabIndex = 1599;
            this.gradLabel15.Text = "Y";
            this.gradLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel3.GradientEnable = false;
            this.gradientLabel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel3.Location = new System.Drawing.Point(645, 176);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.ShowAccelChar = false;
            this.gradientLabel3.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel3.TabIndex = 1595;
            this.gradientLabel3.Text = "Z";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel2.GradientEnable = false;
            this.gradientLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel2.Location = new System.Drawing.Point(546, 176);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.ShowAccelChar = false;
            this.gradientLabel2.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel2.TabIndex = 1594;
            this.gradientLabel2.Text = "Y2";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(447, 176);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.ShowAccelChar = false;
            this.gradientLabel1.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel1.TabIndex = 1593;
            this.gradientLabel1.Text = "Y1";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edLoadPosZ
            // 
            this.edLoadPosZ.BackColor = System.Drawing.Color.White;
            this.edLoadPosZ.DataType = YujinTechnology.DataType.Double;
            this.edLoadPosZ.Frame.CornerRound = 1;
            this.edLoadPosZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLoadPosZ.Hint = null;
            this.edLoadPosZ.Location = new System.Drawing.Point(645, 206);
            this.edLoadPosZ.Max = 0D;
            this.edLoadPosZ.Min = 0D;
            this.edLoadPosZ.Name = "edLoadPosZ";
            this.edLoadPosZ.NewText = "0.000";
            this.edLoadPosZ.PrecisionDigits = 3;
            this.edLoadPosZ.ShowHint = false;
            this.edLoadPosZ.Size = new System.Drawing.Size(95, 29);
            this.edLoadPosZ.TabIndex = 1591;
            this.edLoadPosZ.Text = "0.000";
            this.edLoadPosZ.Value = 0D;
            // 
            // edLoadPosY1
            // 
            this.edLoadPosY1.BackColor = System.Drawing.Color.White;
            this.edLoadPosY1.DataType = YujinTechnology.DataType.Double;
            this.edLoadPosY1.Frame.CornerRound = 1;
            this.edLoadPosY1.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLoadPosY1.Hint = null;
            this.edLoadPosY1.Location = new System.Drawing.Point(447, 206);
            this.edLoadPosY1.Max = 0D;
            this.edLoadPosY1.Min = 0D;
            this.edLoadPosY1.Name = "edLoadPosY1";
            this.edLoadPosY1.NewText = "0.000";
            this.edLoadPosY1.PrecisionDigits = 3;
            this.edLoadPosY1.ShowHint = false;
            this.edLoadPosY1.Size = new System.Drawing.Size(95, 29);
            this.edLoadPosY1.TabIndex = 1589;
            this.edLoadPosY1.Text = "0.000";
            this.edLoadPosY1.Value = 0D;
            // 
            // edLoadPosY2
            // 
            this.edLoadPosY2.BackColor = System.Drawing.Color.White;
            this.edLoadPosY2.DataType = YujinTechnology.DataType.Double;
            this.edLoadPosY2.Frame.CornerRound = 1;
            this.edLoadPosY2.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLoadPosY2.Hint = null;
            this.edLoadPosY2.Location = new System.Drawing.Point(546, 206);
            this.edLoadPosY2.Max = 0D;
            this.edLoadPosY2.Min = 0D;
            this.edLoadPosY2.Name = "edLoadPosY2";
            this.edLoadPosY2.NewText = "0.000";
            this.edLoadPosY2.PrecisionDigits = 3;
            this.edLoadPosY2.ShowHint = false;
            this.edLoadPosY2.Size = new System.Drawing.Size(95, 29);
            this.edLoadPosY2.TabIndex = 1588;
            this.edLoadPosY2.Text = "0.000";
            this.edLoadPosY2.Value = 0D;
            // 
            // edLoadPosX
            // 
            this.edLoadPosX.BackColor = System.Drawing.Color.White;
            this.edLoadPosX.DataType = YujinTechnology.DataType.Double;
            this.edLoadPosX.Frame.CornerRound = 1;
            this.edLoadPosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLoadPosX.Hint = null;
            this.edLoadPosX.Location = new System.Drawing.Point(348, 206);
            this.edLoadPosX.Max = 0D;
            this.edLoadPosX.Min = 0D;
            this.edLoadPosX.Name = "edLoadPosX";
            this.edLoadPosX.NewText = "0.000";
            this.edLoadPosX.PrecisionDigits = 3;
            this.edLoadPosX.ShowHint = false;
            this.edLoadPosX.Size = new System.Drawing.Size(95, 29);
            this.edLoadPosX.TabIndex = 1587;
            this.edLoadPosX.Text = "0.000";
            this.edLoadPosX.Value = 0D;
            // 
            // uiLine5
            // 
            this.uiLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine5.Direction = YujinTechnology.LineDirection.Horizontal;
            this.uiLine5.EndCap = YujinTechnology.UILineCap.None;
            this.uiLine5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine5.ForeColor = System.Drawing.Color.Black;
            this.uiLine5.Frame.Visible = false;
            this.uiLine5.Hint = null;
            this.uiLine5.LineCapSize = 4;
            this.uiLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine5.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.uiLine5.LineWidth = 1F;
            this.uiLine5.Location = new System.Drawing.Point(222, 150);
            this.uiLine5.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.ShowHint = false;
            this.uiLine5.Size = new System.Drawing.Size(183, 17);
            this.uiLine5.StartCap = YujinTechnology.UILineCap.None;
            this.uiLine5.TabIndex = 1586;
            this.uiLine5.Text = "Loading Position";
            this.uiLine5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine5.TextInterval = 4;
            // 
            // gradLabel7
            // 
            this.gradLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel7.GradientEnable = false;
            this.gradLabel7.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel7.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel7.Location = new System.Drawing.Point(348, 176);
            this.gradLabel7.Name = "gradLabel7";
            this.gradLabel7.ShowAccelChar = false;
            this.gradLabel7.Size = new System.Drawing.Size(95, 26);
            this.gradLabel7.TabIndex = 1583;
            this.gradLabel7.Text = "X";
            this.gradLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel6
            // 
            this.gradLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel6.GradientEnable = false;
            this.gradLabel6.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel6.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel6.Location = new System.Drawing.Point(227, 206);
            this.gradLabel6.Name = "gradLabel6";
            this.gradLabel6.ShowAccelChar = false;
            this.gradLabel6.Size = new System.Drawing.Size(115, 29);
            this.gradLabel6.TabIndex = 1584;
            this.gradLabel6.Text = "Load Pos";
            this.gradLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.chkAreaSensorVacuumUse);
            this.tabPage4.Controls.Add(this.chkAreaSensorUse);
            this.tabPage4.Controls.Add(this.chkVacuumAutoRelease);
            this.tabPage4.Controls.Add(this.chkVacAlarmUse);
            this.tabPage4.Controls.Add(this.chkDoorAlarmUse);
            this.tabPage4.Controls.Add(this.chkIOnizoerAutoRun);
            this.tabPage4.Controls.Add(this.chkDustCollectorAutoRun);
            this.tabPage4.Controls.Add(this.gradientLabel38);
            this.tabPage4.Controls.Add(this.gradientLabel39);
            this.tabPage4.Controls.Add(this.gradientLabel33);
            this.tabPage4.Controls.Add(this.cbTable2UseVacuumCount);
            this.tabPage4.Controls.Add(this.edTable2VacuumDelay);
            this.tabPage4.Controls.Add(this.gradientLabel34);
            this.tabPage4.Controls.Add(this.cbTable1UseVacuumCount);
            this.tabPage4.Controls.Add(this.edTable1VacuumDelay);
            this.tabPage4.Controls.Add(this.sunnyLine6);
            this.tabPage4.Controls.Add(this.edAccelerationG);
            this.tabPage4.Controls.Add(this.gradientLabel27);
            this.tabPage4.Controls.Add(this.sunnyLine5);
            this.tabPage4.Controls.Add(this.gradientLabel26);
            this.tabPage4.Controls.Add(this.gradientLabel25);
            this.tabPage4.Controls.Add(this.sunnyLine2);
            this.tabPage4.Controls.Add(this.uiLine2);
            this.tabPage4.Controls.Add(this.gradLabel3);
            this.tabPage4.Controls.Add(this.uiLine3);
            this.tabPage4.Controls.Add(this.gradLabel38);
            this.tabPage4.Controls.Add(this.gradLabel37);
            this.tabPage4.Controls.Add(this.edTableSizeX);
            this.tabPage4.Controls.Add(this.edTableSizeY);
            this.tabPage4.Controls.Add(this.gradLabel5);
            this.tabPage4.Controls.Add(this.gradLabel2);
            this.tabPage4.Controls.Add(this.uiLine1);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1324, 675);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "  Option  ";
            // 
            // chkAreaSensorVacuumUse
            // 
            this.chkAreaSensorVacuumUse.AutoSize = true;
            this.chkAreaSensorVacuumUse.Channel = null;
            this.chkAreaSensorVacuumUse.Location = new System.Drawing.Point(813, 112);
            this.chkAreaSensorVacuumUse.Name = "chkAreaSensorVacuumUse";
            this.chkAreaSensorVacuumUse.Size = new System.Drawing.Size(52, 22);
            this.chkAreaSensorVacuumUse.TabIndex = 1693;
            this.chkAreaSensorVacuumUse.Text = "Use";
            this.chkAreaSensorVacuumUse.UseVisualStyleBackColor = true;
            // 
            // chkAreaSensorUse
            // 
            this.chkAreaSensorUse.AutoSize = true;
            this.chkAreaSensorUse.Channel = null;
            this.chkAreaSensorUse.Location = new System.Drawing.Point(813, 79);
            this.chkAreaSensorUse.Name = "chkAreaSensorUse";
            this.chkAreaSensorUse.Size = new System.Drawing.Size(52, 22);
            this.chkAreaSensorUse.TabIndex = 1692;
            this.chkAreaSensorUse.Text = "Use";
            this.chkAreaSensorUse.UseVisualStyleBackColor = true;
            // 
            // chkVacuumAutoRelease
            // 
            this.chkVacuumAutoRelease.AutoSize = true;
            this.chkVacuumAutoRelease.Channel = null;
            this.chkVacuumAutoRelease.Location = new System.Drawing.Point(496, 181);
            this.chkVacuumAutoRelease.Name = "chkVacuumAutoRelease";
            this.chkVacuumAutoRelease.Size = new System.Drawing.Size(52, 22);
            this.chkVacuumAutoRelease.TabIndex = 1691;
            this.chkVacuumAutoRelease.Text = "Use";
            this.chkVacuumAutoRelease.UseVisualStyleBackColor = true;
            // 
            // chkVacAlarmUse
            // 
            this.chkVacAlarmUse.AutoSize = true;
            this.chkVacAlarmUse.Channel = null;
            this.chkVacAlarmUse.Location = new System.Drawing.Point(496, 112);
            this.chkVacAlarmUse.Name = "chkVacAlarmUse";
            this.chkVacAlarmUse.Size = new System.Drawing.Size(52, 22);
            this.chkVacAlarmUse.TabIndex = 1690;
            this.chkVacAlarmUse.Text = "Use";
            this.chkVacAlarmUse.UseVisualStyleBackColor = true;
            // 
            // chkDoorAlarmUse
            // 
            this.chkDoorAlarmUse.AutoSize = true;
            this.chkDoorAlarmUse.Channel = null;
            this.chkDoorAlarmUse.Location = new System.Drawing.Point(496, 79);
            this.chkDoorAlarmUse.Name = "chkDoorAlarmUse";
            this.chkDoorAlarmUse.Size = new System.Drawing.Size(52, 22);
            this.chkDoorAlarmUse.TabIndex = 1689;
            this.chkDoorAlarmUse.Text = "Use";
            this.chkDoorAlarmUse.UseVisualStyleBackColor = true;
            // 
            // chkIOnizoerAutoRun
            // 
            this.chkIOnizoerAutoRun.AutoSize = true;
            this.chkIOnizoerAutoRun.Channel = null;
            this.chkIOnizoerAutoRun.Location = new System.Drawing.Point(496, 252);
            this.chkIOnizoerAutoRun.Name = "chkIOnizoerAutoRun";
            this.chkIOnizoerAutoRun.Size = new System.Drawing.Size(133, 22);
            this.chkIOnizoerAutoRun.TabIndex = 1688;
            this.chkIOnizoerAutoRun.Text = "Ionizier AutoRun";
            this.chkIOnizoerAutoRun.UseVisualStyleBackColor = true;
            // 
            // chkDustCollectorAutoRun
            // 
            this.chkDustCollectorAutoRun.AutoSize = true;
            this.chkDustCollectorAutoRun.Channel = null;
            this.chkDustCollectorAutoRun.Location = new System.Drawing.Point(496, 224);
            this.chkDustCollectorAutoRun.Name = "chkDustCollectorAutoRun";
            this.chkDustCollectorAutoRun.Size = new System.Drawing.Size(176, 22);
            this.chkDustCollectorAutoRun.TabIndex = 1687;
            this.chkDustCollectorAutoRun.Text = "Dust Collector AutoRun";
            this.chkDustCollectorAutoRun.UseVisualStyleBackColor = true;
            // 
            // gradientLabel38
            // 
            this.gradientLabel38.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel38.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel38.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel38.GradientEnable = false;
            this.gradientLabel38.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel38.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel38.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel38.Location = new System.Drawing.Point(679, 387);
            this.gradientLabel38.Name = "gradientLabel38";
            this.gradientLabel38.ShowAccelChar = false;
            this.gradientLabel38.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel38.TabIndex = 1685;
            this.gradientLabel38.Text = "Table #2";
            this.gradientLabel38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel39
            // 
            this.gradientLabel39.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel39.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel39.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel39.GradientEnable = false;
            this.gradientLabel39.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel39.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel39.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel39.Location = new System.Drawing.Point(679, 355);
            this.gradientLabel39.Name = "gradientLabel39";
            this.gradientLabel39.ShowAccelChar = false;
            this.gradientLabel39.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel39.TabIndex = 1686;
            this.gradientLabel39.Text = "Table #1";
            this.gradientLabel39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel33
            // 
            this.gradientLabel33.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel33.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel33.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel33.GradientEnable = false;
            this.gradientLabel33.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel33.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel33.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel33.Location = new System.Drawing.Point(797, 322);
            this.gradientLabel33.Name = "gradientLabel33";
            this.gradientLabel33.ShowAccelChar = false;
            this.gradientLabel33.Size = new System.Drawing.Size(95, 29);
            this.gradientLabel33.TabIndex = 1684;
            this.gradientLabel33.Text = "Count";
            this.gradientLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTable2UseVacuumCount
            // 
            this.cbTable2UseVacuumCount.BackColor = System.Drawing.Color.White;
            this.cbTable2UseVacuumCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable2UseVacuumCount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbTable2UseVacuumCount.Frame.Bottom = false;
            this.cbTable2UseVacuumCount.Frame.CornerRound = 1;
            this.cbTable2UseVacuumCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbTable2UseVacuumCount.Frame.Top = false;
            this.cbTable2UseVacuumCount.Hint = null;
            this.cbTable2UseVacuumCount.ItemIndex = 0;
            this.cbTable2UseVacuumCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbTable2UseVacuumCount.Location = new System.Drawing.Point(797, 387);
            this.cbTable2UseVacuumCount.Name = "cbTable2UseVacuumCount";
            this.cbTable2UseVacuumCount.ShowHint = false;
            this.cbTable2UseVacuumCount.Size = new System.Drawing.Size(95, 29);
            this.cbTable2UseVacuumCount.TabIndex = 1683;
            this.cbTable2UseVacuumCount.Text = "1";
            this.cbTable2UseVacuumCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTable2UseVacuumCount.Click += new System.EventHandler(this.cbTable2UseVacuumCount_Click);
            // 
            // edTable2VacuumDelay
            // 
            this.edTable2VacuumDelay.BackColor = System.Drawing.Color.White;
            this.edTable2VacuumDelay.DataType = YujinTechnology.DataType.Double;
            this.edTable2VacuumDelay.Frame.CornerRound = 1;
            this.edTable2VacuumDelay.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2VacuumDelay.Hint = null;
            this.edTable2VacuumDelay.Location = new System.Drawing.Point(895, 387);
            this.edTable2VacuumDelay.Max = 0D;
            this.edTable2VacuumDelay.Min = 0D;
            this.edTable2VacuumDelay.Name = "edTable2VacuumDelay";
            this.edTable2VacuumDelay.NewText = "0.000";
            this.edTable2VacuumDelay.PrecisionDigits = 3;
            this.edTable2VacuumDelay.ShowHint = false;
            this.edTable2VacuumDelay.Size = new System.Drawing.Size(95, 29);
            this.edTable2VacuumDelay.TabIndex = 1682;
            this.edTable2VacuumDelay.Text = "0.000";
            this.edTable2VacuumDelay.Value = 0D;
            // 
            // gradientLabel34
            // 
            this.gradientLabel34.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel34.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel34.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel34.GradientEnable = false;
            this.gradientLabel34.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel34.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel34.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel34.Location = new System.Drawing.Point(895, 322);
            this.gradientLabel34.Name = "gradientLabel34";
            this.gradientLabel34.ShowAccelChar = false;
            this.gradientLabel34.Size = new System.Drawing.Size(95, 29);
            this.gradientLabel34.TabIndex = 1681;
            this.gradientLabel34.Text = "Delay (ms)";
            this.gradientLabel34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTable1UseVacuumCount
            // 
            this.cbTable1UseVacuumCount.BackColor = System.Drawing.Color.White;
            this.cbTable1UseVacuumCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable1UseVacuumCount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbTable1UseVacuumCount.Frame.Bottom = false;
            this.cbTable1UseVacuumCount.Frame.CornerRound = 1;
            this.cbTable1UseVacuumCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbTable1UseVacuumCount.Frame.Top = false;
            this.cbTable1UseVacuumCount.Hint = null;
            this.cbTable1UseVacuumCount.ItemIndex = 0;
            this.cbTable1UseVacuumCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbTable1UseVacuumCount.Location = new System.Drawing.Point(797, 355);
            this.cbTable1UseVacuumCount.Name = "cbTable1UseVacuumCount";
            this.cbTable1UseVacuumCount.ShowHint = false;
            this.cbTable1UseVacuumCount.Size = new System.Drawing.Size(95, 29);
            this.cbTable1UseVacuumCount.TabIndex = 1679;
            this.cbTable1UseVacuumCount.Text = "1";
            this.cbTable1UseVacuumCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTable1UseVacuumCount.Click += new System.EventHandler(this.cbTable1UseVacuumCount_Click);
            // 
            // edTable1VacuumDelay
            // 
            this.edTable1VacuumDelay.BackColor = System.Drawing.Color.White;
            this.edTable1VacuumDelay.DataType = YujinTechnology.DataType.Double;
            this.edTable1VacuumDelay.Frame.CornerRound = 1;
            this.edTable1VacuumDelay.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1VacuumDelay.Hint = null;
            this.edTable1VacuumDelay.Location = new System.Drawing.Point(895, 355);
            this.edTable1VacuumDelay.Max = 0D;
            this.edTable1VacuumDelay.Min = 0D;
            this.edTable1VacuumDelay.Name = "edTable1VacuumDelay";
            this.edTable1VacuumDelay.NewText = "0.000";
            this.edTable1VacuumDelay.PrecisionDigits = 3;
            this.edTable1VacuumDelay.ShowHint = false;
            this.edTable1VacuumDelay.Size = new System.Drawing.Size(95, 29);
            this.edTable1VacuumDelay.TabIndex = 1678;
            this.edTable1VacuumDelay.Text = "0.000";
            this.edTable1VacuumDelay.Value = 0D;
            // 
            // sunnyLine6
            // 
            this.sunnyLine6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine6.Direction = YujinTechnology.LineDirection.Horizontal;
            this.sunnyLine6.EndCap = YujinTechnology.UILineCap.None;
            this.sunnyLine6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine6.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine6.Frame.Visible = false;
            this.sunnyLine6.Hint = null;
            this.sunnyLine6.LineCapSize = 4;
            this.sunnyLine6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine6.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.sunnyLine6.LineWidth = 1F;
            this.sunnyLine6.Location = new System.Drawing.Point(682, 302);
            this.sunnyLine6.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine6.Name = "sunnyLine6";
            this.sunnyLine6.ShowHint = false;
            this.sunnyLine6.Size = new System.Drawing.Size(183, 17);
            this.sunnyLine6.StartCap = YujinTechnology.UILineCap.None;
            this.sunnyLine6.TabIndex = 1676;
            this.sunnyLine6.Text = "Vacuum Option";
            this.sunnyLine6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine6.TextInterval = 4;
            // 
            // edAccelerationG
            // 
            this.edAccelerationG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edAccelerationG.DataType = YujinTechnology.DataType.Double;
            this.edAccelerationG.Frame.CornerRound = 1;
            this.edAccelerationG.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edAccelerationG.Hint = null;
            this.edAccelerationG.Location = new System.Drawing.Point(800, 178);
            this.edAccelerationG.Max = 0D;
            this.edAccelerationG.Min = 0D;
            this.edAccelerationG.Name = "edAccelerationG";
            this.edAccelerationG.NewText = "0.000";
            this.edAccelerationG.PrecisionDigits = 3;
            this.edAccelerationG.ShowHint = false;
            this.edAccelerationG.Size = new System.Drawing.Size(95, 29);
            this.edAccelerationG.TabIndex = 1675;
            this.edAccelerationG.Text = "0.000";
            this.edAccelerationG.Value = 0D;
            // 
            // gradientLabel27
            // 
            this.gradientLabel27.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel27.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel27.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel27.GradientEnable = false;
            this.gradientLabel27.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel27.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel27.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel27.Location = new System.Drawing.Point(681, 178);
            this.gradientLabel27.Name = "gradientLabel27";
            this.gradientLabel27.ShowAccelChar = false;
            this.gradientLabel27.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel27.TabIndex = 1674;
            this.gradientLabel27.Text = "Acceleration(G)";
            this.gradientLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sunnyLine5
            // 
            this.sunnyLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine5.Direction = YujinTechnology.LineDirection.Horizontal;
            this.sunnyLine5.EndCap = YujinTechnology.UILineCap.None;
            this.sunnyLine5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine5.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine5.Frame.Visible = false;
            this.sunnyLine5.Hint = null;
            this.sunnyLine5.LineCapSize = 4;
            this.sunnyLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine5.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.sunnyLine5.LineWidth = 1F;
            this.sunnyLine5.Location = new System.Drawing.Point(684, 152);
            this.sunnyLine5.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine5.Name = "sunnyLine5";
            this.sunnyLine5.ShowHint = false;
            this.sunnyLine5.Size = new System.Drawing.Size(183, 17);
            this.sunnyLine5.StartCap = YujinTechnology.UILineCap.None;
            this.sunnyLine5.TabIndex = 1673;
            this.sunnyLine5.Text = "Equip Acceleration";
            this.sunnyLine5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine5.TextInterval = 4;
            // 
            // gradientLabel26
            // 
            this.gradientLabel26.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel26.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel26.GradientEnable = false;
            this.gradientLabel26.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel26.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel26.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel26.Location = new System.Drawing.Point(681, 109);
            this.gradientLabel26.Name = "gradientLabel26";
            this.gradientLabel26.ShowAccelChar = false;
            this.gradientLabel26.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel26.TabIndex = 1671;
            this.gradientLabel26.Text = "Vacuum";
            this.gradientLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel25
            // 
            this.gradientLabel25.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel25.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel25.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel25.GradientEnable = false;
            this.gradientLabel25.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel25.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel25.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel25.Location = new System.Drawing.Point(681, 76);
            this.gradientLabel25.Name = "gradientLabel25";
            this.gradientLabel25.ShowAccelChar = false;
            this.gradientLabel25.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel25.TabIndex = 1669;
            this.gradientLabel25.Text = "Area Sensor";
            this.gradientLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sunnyLine2
            // 
            this.sunnyLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine2.Direction = YujinTechnology.LineDirection.Horizontal;
            this.sunnyLine2.EndCap = YujinTechnology.UILineCap.None;
            this.sunnyLine2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine2.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine2.Frame.Visible = false;
            this.sunnyLine2.Hint = null;
            this.sunnyLine2.LineCapSize = 4;
            this.sunnyLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine2.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.sunnyLine2.LineWidth = 1F;
            this.sunnyLine2.Location = new System.Drawing.Point(692, 59);
            this.sunnyLine2.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine2.Name = "sunnyLine2";
            this.sunnyLine2.ShowHint = false;
            this.sunnyLine2.Size = new System.Drawing.Size(183, 17);
            this.sunnyLine2.StartCap = YujinTechnology.UILineCap.None;
            this.sunnyLine2.TabIndex = 1668;
            this.sunnyLine2.Text = "Area Sensor";
            this.sunnyLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine2.TextInterval = 4;
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine2.Direction = YujinTechnology.LineDirection.Horizontal;
            this.uiLine2.EndCap = YujinTechnology.UILineCap.None;
            this.uiLine2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine2.ForeColor = System.Drawing.Color.Black;
            this.uiLine2.Frame.Visible = false;
            this.uiLine2.Hint = null;
            this.uiLine2.LineCapSize = 4;
            this.uiLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine2.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.uiLine2.LineWidth = 1F;
            this.uiLine2.Location = new System.Drawing.Point(369, 152);
            this.uiLine2.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.ShowHint = false;
            this.uiLine2.Size = new System.Drawing.Size(183, 17);
            this.uiLine2.StartCap = YujinTechnology.UILineCap.None;
            this.uiLine2.TabIndex = 1639;
            this.uiLine2.Text = "Release";
            this.uiLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine2.TextInterval = 4;
            // 
            // gradLabel3
            // 
            this.gradLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel3.GradientEnable = false;
            this.gradLabel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel3.Location = new System.Drawing.Point(370, 178);
            this.gradLabel3.Name = "gradLabel3";
            this.gradLabel3.ShowAccelChar = false;
            this.gradLabel3.Size = new System.Drawing.Size(115, 29);
            this.gradLabel3.TabIndex = 1638;
            this.gradLabel3.Text = "Vacuum";
            this.gradLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLine3
            // 
            this.uiLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine3.Direction = YujinTechnology.LineDirection.Horizontal;
            this.uiLine3.EndCap = YujinTechnology.UILineCap.None;
            this.uiLine3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine3.ForeColor = System.Drawing.Color.Black;
            this.uiLine3.Frame.Visible = false;
            this.uiLine3.Hint = null;
            this.uiLine3.LineCapSize = 4;
            this.uiLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine3.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.uiLine3.LineWidth = 1F;
            this.uiLine3.Location = new System.Drawing.Point(369, 59);
            this.uiLine3.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.ShowHint = false;
            this.uiLine3.Size = new System.Drawing.Size(183, 17);
            this.uiLine3.StartCap = YujinTechnology.UILineCap.None;
            this.uiLine3.TabIndex = 1634;
            this.uiLine3.Text = "Alarm";
            this.uiLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine3.TextInterval = 4;
            // 
            // gradLabel38
            // 
            this.gradLabel38.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel38.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel38.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel38.GradientEnable = false;
            this.gradLabel38.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel38.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel38.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel38.Location = new System.Drawing.Point(370, 109);
            this.gradLabel38.Name = "gradLabel38";
            this.gradLabel38.ShowAccelChar = false;
            this.gradLabel38.Size = new System.Drawing.Size(115, 29);
            this.gradLabel38.TabIndex = 1632;
            this.gradLabel38.Text = "Vacuum";
            this.gradLabel38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel37
            // 
            this.gradLabel37.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel37.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel37.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel37.GradientEnable = false;
            this.gradLabel37.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel37.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel37.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel37.Location = new System.Drawing.Point(370, 76);
            this.gradLabel37.Name = "gradLabel37";
            this.gradLabel37.ShowAccelChar = false;
            this.gradLabel37.Size = new System.Drawing.Size(115, 29);
            this.gradLabel37.TabIndex = 1633;
            this.gradLabel37.Text = "Center Door";
            this.gradLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTableSizeX
            // 
            this.edTableSizeX.BackColor = System.Drawing.Color.White;
            this.edTableSizeX.DataType = YujinTechnology.DataType.Double;
            this.edTableSizeX.Frame.CornerRound = 1;
            this.edTableSizeX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTableSizeX.Hint = null;
            this.edTableSizeX.Location = new System.Drawing.Point(390, 385);
            this.edTableSizeX.Max = 0D;
            this.edTableSizeX.Min = 0D;
            this.edTableSizeX.Name = "edTableSizeX";
            this.edTableSizeX.NewText = "0.000";
            this.edTableSizeX.PrecisionDigits = 3;
            this.edTableSizeX.ShowHint = false;
            this.edTableSizeX.Size = new System.Drawing.Size(95, 29);
            this.edTableSizeX.TabIndex = 1628;
            this.edTableSizeX.Text = "0.000";
            this.edTableSizeX.Value = 0D;
            // 
            // edTableSizeY
            // 
            this.edTableSizeY.BackColor = System.Drawing.Color.White;
            this.edTableSizeY.DataType = YujinTechnology.DataType.Double;
            this.edTableSizeY.Frame.CornerRound = 1;
            this.edTableSizeY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTableSizeY.Hint = null;
            this.edTableSizeY.Location = new System.Drawing.Point(488, 385);
            this.edTableSizeY.Max = 0D;
            this.edTableSizeY.Min = 0D;
            this.edTableSizeY.Name = "edTableSizeY";
            this.edTableSizeY.NewText = "0.000";
            this.edTableSizeY.PrecisionDigits = 3;
            this.edTableSizeY.ShowHint = false;
            this.edTableSizeY.Size = new System.Drawing.Size(95, 29);
            this.edTableSizeY.TabIndex = 1627;
            this.edTableSizeY.Text = "0.000";
            this.edTableSizeY.Value = 0D;
            // 
            // gradLabel5
            // 
            this.gradLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel5.GradientEnable = false;
            this.gradLabel5.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel5.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel5.Location = new System.Drawing.Point(491, 351);
            this.gradLabel5.Name = "gradLabel5";
            this.gradLabel5.ShowAccelChar = false;
            this.gradLabel5.Size = new System.Drawing.Size(93, 29);
            this.gradLabel5.TabIndex = 1626;
            this.gradLabel5.Text = "Y";
            this.gradLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel2
            // 
            this.gradLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel2.GradientEnable = false;
            this.gradLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel2.Location = new System.Drawing.Point(390, 351);
            this.gradLabel2.Name = "gradLabel2";
            this.gradLabel2.ShowAccelChar = false;
            this.gradLabel2.Size = new System.Drawing.Size(95, 29);
            this.gradLabel2.TabIndex = 1625;
            this.gradLabel2.Text = "X";
            this.gradLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine1.Direction = YujinTechnology.LineDirection.Horizontal;
            this.uiLine1.EndCap = YujinTechnology.UILineCap.None;
            this.uiLine1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine1.ForeColor = System.Drawing.Color.Black;
            this.uiLine1.Frame.Visible = false;
            this.uiLine1.Hint = null;
            this.uiLine1.LineCapSize = 4;
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.LineDashStyle = YujinTechnology.UILineDashStyle.Solid;
            this.uiLine1.LineWidth = 1F;
            this.uiLine1.Location = new System.Drawing.Point(357, 334);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.ShowHint = false;
            this.uiLine1.Size = new System.Drawing.Size(183, 17);
            this.uiLine1.StartCap = YujinTechnology.UILineCap.None;
            this.uiLine1.TabIndex = 1624;
            this.uiLine1.Text = "Table Size";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine1.TextInterval = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.gradientLabel10);
            this.tabPage5.Controls.Add(this.gradientLabel35);
            this.tabPage5.Controls.Add(this.gradientLabel37);
            this.tabPage5.Controls.Add(this.edTable2LoadingPosX);
            this.tabPage5.Controls.Add(this.edTable2LoadingPosY);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.gradientLabel11);
            this.tabPage5.Controls.Add(this.gradientLabel12);
            this.tabPage5.Controls.Add(this.gradientLabel13);
            this.tabPage5.Controls.Add(this.edTable1LoadingPosX);
            this.tabPage5.Controls.Add(this.edTable1LoadingPosY);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1324, 675);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "  Loading  ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.label3.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.label3.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.label3.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Frame.Visible = false;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(322, 582);
            this.label3.Name = "label3";
            this.label3.ShowAccelChar = false;
            this.label3.Size = new System.Drawing.Size(701, 70);
            this.label3.TabIndex = 1701;
            this.label3.Text = "Position 변경시\r\n현재 작업중인 Job File을 다시 로딩 해야 변경된 값이 반영.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel10
            // 
            this.gradientLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel10.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel10.Frame.Visible = false;
            this.gradientLabel10.GradientEnable = false;
            this.gradientLabel10.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel10.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel10.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel10.Location = new System.Drawing.Point(905, 490);
            this.gradientLabel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel10.Name = "gradientLabel10";
            this.gradientLabel10.ShowAccelChar = false;
            this.gradientLabel10.Size = new System.Drawing.Size(95, 29);
            this.gradientLabel10.TabIndex = 1664;
            this.gradientLabel10.Text = "Y";
            this.gradientLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel35
            // 
            this.gradientLabel35.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel35.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel35.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel35.Frame.Visible = false;
            this.gradientLabel35.GradientEnable = false;
            this.gradientLabel35.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel35.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel35.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel35.Location = new System.Drawing.Point(805, 490);
            this.gradientLabel35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel35.Name = "gradientLabel35";
            this.gradientLabel35.ShowAccelChar = false;
            this.gradientLabel35.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel35.TabIndex = 1663;
            this.gradientLabel35.Text = "X";
            this.gradientLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel37
            // 
            this.gradientLabel37.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel37.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel37.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel37.Frame.Visible = false;
            this.gradientLabel37.GradientEnable = false;
            this.gradientLabel37.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel37.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel37.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel37.Location = new System.Drawing.Point(731, 525);
            this.gradientLabel37.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel37.Name = "gradientLabel37";
            this.gradientLabel37.ShowAccelChar = false;
            this.gradientLabel37.Size = new System.Drawing.Size(67, 29);
            this.gradientLabel37.TabIndex = 1662;
            this.gradientLabel37.Text = "Load Pos";
            this.gradientLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable2LoadingPosX
            // 
            this.edTable2LoadingPosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable2LoadingPosX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edTable2LoadingPosX.DataType = YujinTechnology.DataType.Double;
            this.edTable2LoadingPosX.Enabled = false;
            this.edTable2LoadingPosX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2LoadingPosX.Frame.Bottom = false;
            this.edTable2LoadingPosX.Frame.CornerRound = 1;
            this.edTable2LoadingPosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LoadingPosX.Frame.Top = false;
            this.edTable2LoadingPosX.Hint = null;
            this.edTable2LoadingPosX.Location = new System.Drawing.Point(805, 525);
            this.edTable2LoadingPosX.Margin = new System.Windows.Forms.Padding(4);
            this.edTable2LoadingPosX.Max = 0D;
            this.edTable2LoadingPosX.Min = 0D;
            this.edTable2LoadingPosX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edTable2LoadingPosX.Name = "edTable2LoadingPosX";
            this.edTable2LoadingPosX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edTable2LoadingPosX.PrecisionDigits = 3;
            this.edTable2LoadingPosX.ShowHint = false;
            this.edTable2LoadingPosX.Size = new System.Drawing.Size(95, 29);
            this.edTable2LoadingPosX.TabIndex = 1661;
            this.edTable2LoadingPosX.Text = "0.000";
            this.edTable2LoadingPosX.Value = 0D;
            // 
            // edTable2LoadingPosY
            // 
            this.edTable2LoadingPosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable2LoadingPosY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edTable2LoadingPosY.DataType = YujinTechnology.DataType.Double;
            this.edTable2LoadingPosY.Enabled = false;
            this.edTable2LoadingPosY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2LoadingPosY.Frame.Bottom = false;
            this.edTable2LoadingPosY.Frame.CornerRound = 1;
            this.edTable2LoadingPosY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LoadingPosY.Frame.Top = false;
            this.edTable2LoadingPosY.Hint = null;
            this.edTable2LoadingPosY.Location = new System.Drawing.Point(905, 525);
            this.edTable2LoadingPosY.Margin = new System.Windows.Forms.Padding(4);
            this.edTable2LoadingPosY.Max = 0D;
            this.edTable2LoadingPosY.Min = 0D;
            this.edTable2LoadingPosY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edTable2LoadingPosY.Name = "edTable2LoadingPosY";
            this.edTable2LoadingPosY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edTable2LoadingPosY.PrecisionDigits = 3;
            this.edTable2LoadingPosY.ShowHint = false;
            this.edTable2LoadingPosY.Size = new System.Drawing.Size(95, 29);
            this.edTable2LoadingPosY.TabIndex = 1660;
            this.edTable2LoadingPosY.Text = "0.000";
            this.edTable2LoadingPosY.Value = 0D;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ledTable2Center);
            this.groupBox3.Controls.Add(this.cbTable2LoadDir);
            this.groupBox3.Controls.Add(this.ledTable2RightBottom);
            this.groupBox3.Controls.Add(this.ledTable2RightTop);
            this.groupBox3.Controls.Add(this.ledTable2LeftBottom);
            this.groupBox3.Controls.Add(this.ledTable2LeftTop);
            this.groupBox3.Location = new System.Drawing.Point(735, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 460);
            this.groupBox3.TabIndex = 1659;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table #2  제품 투입 위치  ";
            // 
            // ledTable2Center
            // 
            this.ledTable2Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable2Center.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2Center.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable2Center.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable2Center.ForeColor = System.Drawing.Color.Black;
            this.ledTable2Center.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable2Center.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable2Center.Location = new System.Drawing.Point(198, 172);
            this.ledTable2Center.Margin2 = 10;
            this.ledTable2Center.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable2Center.Name = "ledTable2Center";
            this.ledTable2Center.ShowAccelChar = false;
            this.ledTable2Center.Size = new System.Drawing.Size(141, 78);
            this.ledTable2Center.TabIndex = 1656;
            this.ledTable2Center.Text = "중앙";
            this.ledTable2Center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable2Center.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2Center_LEDValueChanged);
            this.ledTable2Center.Click += new System.EventHandler(this.ledTable2Center_Click);
            // 
            // cbTable2LoadDir
            // 
            this.cbTable2LoadDir.BackColor = System.Drawing.Color.White;
            this.cbTable2LoadDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable2LoadDir.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbTable2LoadDir.Hint = null;
            this.cbTable2LoadDir.ItemIndex = 5;
            this.cbTable2LoadDir.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbTable2LoadDir.Location = new System.Drawing.Point(15, 428);
            this.cbTable2LoadDir.Name = "cbTable2LoadDir";
            this.cbTable2LoadDir.ShowHint = false;
            this.cbTable2LoadDir.Size = new System.Drawing.Size(121, 26);
            this.cbTable2LoadDir.TabIndex = 1666;
            this.cbTable2LoadDir.Text = "5";
            this.cbTable2LoadDir.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTable2LoadDir.Visible = false;
            this.cbTable2LoadDir.OnSelectedIndexChanged += new System.EventHandler(this.cbTable2LoadDir_OnSelectedIndexChanged);
            // 
            // ledTable2RightBottom
            // 
            this.ledTable2RightBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable2RightBottom.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2RightBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable2RightBottom.Enabled = false;
            this.ledTable2RightBottom.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable2RightBottom.ForeColor = System.Drawing.Color.Silver;
            this.ledTable2RightBottom.LED.Layout = YujinTechnology.LEDLayout.Right;
            this.ledTable2RightBottom.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable2RightBottom.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable2RightBottom.Location = new System.Drawing.Point(374, 332);
            this.ledTable2RightBottom.Margin2 = 10;
            this.ledTable2RightBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable2RightBottom.Name = "ledTable2RightBottom";
            this.ledTable2RightBottom.ShowAccelChar = false;
            this.ledTable2RightBottom.Size = new System.Drawing.Size(141, 78);
            this.ledTable2RightBottom.TabIndex = 1655;
            this.ledTable2RightBottom.Text = "우측, 하단";
            this.ledTable2RightBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ledTable2RightBottom.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2RightBottom_LEDValueChanged);
            this.ledTable2RightBottom.Click += new System.EventHandler(this.ledTable2RightBottom_Click);
            // 
            // ledTable2RightTop
            // 
            this.ledTable2RightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable2RightTop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2RightTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable2RightTop.Enabled = false;
            this.ledTable2RightTop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable2RightTop.ForeColor = System.Drawing.Color.Silver;
            this.ledTable2RightTop.LED.Layout = YujinTechnology.LEDLayout.Right;
            this.ledTable2RightTop.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable2RightTop.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable2RightTop.Location = new System.Drawing.Point(374, 40);
            this.ledTable2RightTop.Margin2 = 10;
            this.ledTable2RightTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable2RightTop.Name = "ledTable2RightTop";
            this.ledTable2RightTop.ShowAccelChar = false;
            this.ledTable2RightTop.Size = new System.Drawing.Size(141, 78);
            this.ledTable2RightTop.TabIndex = 1654;
            this.ledTable2RightTop.Text = "우측, 상단";
            this.ledTable2RightTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ledTable2RightTop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2RightTop_LEDValueChanged);
            this.ledTable2RightTop.Click += new System.EventHandler(this.ledTable2RightTop_Click);
            // 
            // ledTable2LeftBottom
            // 
            this.ledTable2LeftBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable2LeftBottom.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2LeftBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable2LeftBottom.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable2LeftBottom.ForeColor = System.Drawing.Color.Black;
            this.ledTable2LeftBottom.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable2LeftBottom.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable2LeftBottom.Location = new System.Drawing.Point(28, 332);
            this.ledTable2LeftBottom.Margin2 = 10;
            this.ledTable2LeftBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable2LeftBottom.Name = "ledTable2LeftBottom";
            this.ledTable2LeftBottom.ShowAccelChar = false;
            this.ledTable2LeftBottom.Size = new System.Drawing.Size(141, 78);
            this.ledTable2LeftBottom.TabIndex = 1653;
            this.ledTable2LeftBottom.Text = "좌측, 하단";
            this.ledTable2LeftBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable2LeftBottom.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2LeftBottom_LEDValueChanged);
            this.ledTable2LeftBottom.Click += new System.EventHandler(this.ledTable2LeftBottom_Click);
            // 
            // ledTable2LeftTop
            // 
            this.ledTable2LeftTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable2LeftTop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2LeftTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable2LeftTop.Enabled = false;
            this.ledTable2LeftTop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable2LeftTop.ForeColor = System.Drawing.Color.Silver;
            this.ledTable2LeftTop.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable2LeftTop.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable2LeftTop.Location = new System.Drawing.Point(28, 40);
            this.ledTable2LeftTop.Margin2 = 10;
            this.ledTable2LeftTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable2LeftTop.Name = "ledTable2LeftTop";
            this.ledTable2LeftTop.ShowAccelChar = false;
            this.ledTable2LeftTop.Size = new System.Drawing.Size(141, 78);
            this.ledTable2LeftTop.TabIndex = 1651;
            this.ledTable2LeftTop.Text = "좌측, 상단";
            this.ledTable2LeftTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable2LeftTop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2LeftTop_LEDValueChanged);
            this.ledTable2LeftTop.Click += new System.EventHandler(this.ledTable2LeftTop_Click);
            // 
            // gradientLabel11
            // 
            this.gradientLabel11.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel11.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel11.Frame.Visible = false;
            this.gradientLabel11.GradientEnable = false;
            this.gradientLabel11.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel11.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel11.Location = new System.Drawing.Point(194, 490);
            this.gradientLabel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel11.Name = "gradientLabel11";
            this.gradientLabel11.ShowAccelChar = false;
            this.gradientLabel11.Size = new System.Drawing.Size(95, 29);
            this.gradientLabel11.TabIndex = 1658;
            this.gradientLabel11.Text = "Y";
            this.gradientLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel12
            // 
            this.gradientLabel12.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel12.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel12.Frame.Visible = false;
            this.gradientLabel12.GradientEnable = false;
            this.gradientLabel12.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel12.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel12.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel12.Location = new System.Drawing.Point(94, 490);
            this.gradientLabel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel12.Name = "gradientLabel12";
            this.gradientLabel12.ShowAccelChar = false;
            this.gradientLabel12.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel12.TabIndex = 1657;
            this.gradientLabel12.Text = "X";
            this.gradientLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel13
            // 
            this.gradientLabel13.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel13.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel13.Frame.Visible = false;
            this.gradientLabel13.GradientEnable = false;
            this.gradientLabel13.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel13.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel13.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel13.Location = new System.Drawing.Point(20, 525);
            this.gradientLabel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel13.Name = "gradientLabel13";
            this.gradientLabel13.ShowAccelChar = false;
            this.gradientLabel13.Size = new System.Drawing.Size(67, 29);
            this.gradientLabel13.TabIndex = 1656;
            this.gradientLabel13.Text = "Load Pos";
            this.gradientLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1LoadingPosX
            // 
            this.edTable1LoadingPosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable1LoadingPosX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edTable1LoadingPosX.DataType = YujinTechnology.DataType.Double;
            this.edTable1LoadingPosX.Enabled = false;
            this.edTable1LoadingPosX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1LoadingPosX.Frame.Bottom = false;
            this.edTable1LoadingPosX.Frame.CornerRound = 1;
            this.edTable1LoadingPosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LoadingPosX.Frame.Top = false;
            this.edTable1LoadingPosX.Hint = null;
            this.edTable1LoadingPosX.Location = new System.Drawing.Point(94, 525);
            this.edTable1LoadingPosX.Margin = new System.Windows.Forms.Padding(4);
            this.edTable1LoadingPosX.Max = 0D;
            this.edTable1LoadingPosX.Min = 0D;
            this.edTable1LoadingPosX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edTable1LoadingPosX.Name = "edTable1LoadingPosX";
            this.edTable1LoadingPosX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edTable1LoadingPosX.PrecisionDigits = 3;
            this.edTable1LoadingPosX.ShowHint = false;
            this.edTable1LoadingPosX.Size = new System.Drawing.Size(95, 29);
            this.edTable1LoadingPosX.TabIndex = 1655;
            this.edTable1LoadingPosX.Text = "0.000";
            this.edTable1LoadingPosX.Value = 0D;
            // 
            // edTable1LoadingPosY
            // 
            this.edTable1LoadingPosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edTable1LoadingPosY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edTable1LoadingPosY.DataType = YujinTechnology.DataType.Double;
            this.edTable1LoadingPosY.Enabled = false;
            this.edTable1LoadingPosY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1LoadingPosY.Frame.Bottom = false;
            this.edTable1LoadingPosY.Frame.CornerRound = 1;
            this.edTable1LoadingPosY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LoadingPosY.Frame.Top = false;
            this.edTable1LoadingPosY.Hint = null;
            this.edTable1LoadingPosY.Location = new System.Drawing.Point(194, 525);
            this.edTable1LoadingPosY.Margin = new System.Windows.Forms.Padding(4);
            this.edTable1LoadingPosY.Max = 0D;
            this.edTable1LoadingPosY.Min = 0D;
            this.edTable1LoadingPosY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edTable1LoadingPosY.Name = "edTable1LoadingPosY";
            this.edTable1LoadingPosY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edTable1LoadingPosY.PrecisionDigits = 3;
            this.edTable1LoadingPosY.ShowHint = false;
            this.edTable1LoadingPosY.Size = new System.Drawing.Size(95, 29);
            this.edTable1LoadingPosY.TabIndex = 1654;
            this.edTable1LoadingPosY.Text = "0.000";
            this.edTable1LoadingPosY.Value = 0D;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ledTable1Center);
            this.groupBox6.Controls.Add(this.cbTable1LoadDir);
            this.groupBox6.Controls.Add(this.ledTable1RightBottom);
            this.groupBox6.Controls.Add(this.ledTable1RightTop);
            this.groupBox6.Controls.Add(this.ledTable1LeftBottom);
            this.groupBox6.Controls.Add(this.ledTable1LeftTop);
            this.groupBox6.Location = new System.Drawing.Point(27, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(553, 460);
            this.groupBox6.TabIndex = 1653;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Table #1  제품 투입 위치  ";
            // 
            // ledTable1Center
            // 
            this.ledTable1Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable1Center.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1Center.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable1Center.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable1Center.ForeColor = System.Drawing.Color.Black;
            this.ledTable1Center.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable1Center.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable1Center.Location = new System.Drawing.Point(198, 172);
            this.ledTable1Center.Margin2 = 10;
            this.ledTable1Center.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable1Center.Name = "ledTable1Center";
            this.ledTable1Center.ShowAccelChar = false;
            this.ledTable1Center.Size = new System.Drawing.Size(141, 78);
            this.ledTable1Center.TabIndex = 1656;
            this.ledTable1Center.Text = "중앙";
            this.ledTable1Center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable1Center.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1Center_LEDValueChanged);
            this.ledTable1Center.Click += new System.EventHandler(this.ledCenter_Click);
            // 
            // cbTable1LoadDir
            // 
            this.cbTable1LoadDir.BackColor = System.Drawing.Color.White;
            this.cbTable1LoadDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable1LoadDir.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbTable1LoadDir.Hint = null;
            this.cbTable1LoadDir.ItemIndex = 5;
            this.cbTable1LoadDir.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbTable1LoadDir.Location = new System.Drawing.Point(17, 428);
            this.cbTable1LoadDir.Name = "cbTable1LoadDir";
            this.cbTable1LoadDir.ShowHint = false;
            this.cbTable1LoadDir.Size = new System.Drawing.Size(121, 26);
            this.cbTable1LoadDir.TabIndex = 1665;
            this.cbTable1LoadDir.Text = "5";
            this.cbTable1LoadDir.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTable1LoadDir.Visible = false;
            this.cbTable1LoadDir.OnSelectedIndexChanged += new System.EventHandler(this.cbTable1LoadDir_OnSelectedIndexChanged);
            // 
            // ledTable1RightBottom
            // 
            this.ledTable1RightBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable1RightBottom.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1RightBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable1RightBottom.Enabled = false;
            this.ledTable1RightBottom.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable1RightBottom.ForeColor = System.Drawing.Color.Silver;
            this.ledTable1RightBottom.LED.Layout = YujinTechnology.LEDLayout.Right;
            this.ledTable1RightBottom.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable1RightBottom.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable1RightBottom.Location = new System.Drawing.Point(374, 332);
            this.ledTable1RightBottom.Margin2 = 10;
            this.ledTable1RightBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable1RightBottom.Name = "ledTable1RightBottom";
            this.ledTable1RightBottom.ShowAccelChar = false;
            this.ledTable1RightBottom.Size = new System.Drawing.Size(141, 78);
            this.ledTable1RightBottom.TabIndex = 1655;
            this.ledTable1RightBottom.Text = "우측, 하단";
            this.ledTable1RightBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ledTable1RightBottom.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1RightBottom_LEDValueChanged);
            this.ledTable1RightBottom.Click += new System.EventHandler(this.ledRightBottom_Click);
            // 
            // ledTable1RightTop
            // 
            this.ledTable1RightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable1RightTop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1RightTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable1RightTop.Enabled = false;
            this.ledTable1RightTop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable1RightTop.ForeColor = System.Drawing.Color.Silver;
            this.ledTable1RightTop.LED.Layout = YujinTechnology.LEDLayout.Right;
            this.ledTable1RightTop.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable1RightTop.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable1RightTop.Location = new System.Drawing.Point(374, 40);
            this.ledTable1RightTop.Margin2 = 10;
            this.ledTable1RightTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable1RightTop.Name = "ledTable1RightTop";
            this.ledTable1RightTop.ShowAccelChar = false;
            this.ledTable1RightTop.Size = new System.Drawing.Size(141, 78);
            this.ledTable1RightTop.TabIndex = 1654;
            this.ledTable1RightTop.Text = "우측, 상단";
            this.ledTable1RightTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ledTable1RightTop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1RightTop_LEDValueChanged);
            this.ledTable1RightTop.Click += new System.EventHandler(this.ledRightTop_Click);
            // 
            // ledTable1LeftBottom
            // 
            this.ledTable1LeftBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable1LeftBottom.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1LeftBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable1LeftBottom.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable1LeftBottom.ForeColor = System.Drawing.Color.Black;
            this.ledTable1LeftBottom.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable1LeftBottom.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable1LeftBottom.Location = new System.Drawing.Point(28, 332);
            this.ledTable1LeftBottom.Margin2 = 10;
            this.ledTable1LeftBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable1LeftBottom.Name = "ledTable1LeftBottom";
            this.ledTable1LeftBottom.ShowAccelChar = false;
            this.ledTable1LeftBottom.Size = new System.Drawing.Size(141, 78);
            this.ledTable1LeftBottom.TabIndex = 1653;
            this.ledTable1LeftBottom.Text = "좌측, 하단";
            this.ledTable1LeftBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable1LeftBottom.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1LeftBottom_LEDValueChanged);
            this.ledTable1LeftBottom.Click += new System.EventHandler(this.ledLeftBottom_Click);
            // 
            // ledTable1LeftTop
            // 
            this.ledTable1LeftTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledTable1LeftTop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1LeftTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledTable1LeftTop.Enabled = false;
            this.ledTable1LeftTop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledTable1LeftTop.ForeColor = System.Drawing.Color.Silver;
            this.ledTable1LeftTop.LED.Size = new System.Drawing.Size(16, 26);
            this.ledTable1LeftTop.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.ledTable1LeftTop.Location = new System.Drawing.Point(28, 40);
            this.ledTable1LeftTop.Margin2 = 10;
            this.ledTable1LeftTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledTable1LeftTop.Name = "ledTable1LeftTop";
            this.ledTable1LeftTop.ShowAccelChar = false;
            this.ledTable1LeftTop.Size = new System.Drawing.Size(141, 78);
            this.ledTable1LeftTop.TabIndex = 1651;
            this.ledTable1LeftTop.Text = "좌측, 상단";
            this.ledTable1LeftTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable1LeftTop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1LeftTop_LEDValueChanged);
            this.ledTable1LeftTop.Click += new System.EventHandler(this.ledLeftTop_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.lblInfom);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1324, 667);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "  Loading.Position  ";
            // 
            // lblInfom
            // 
            this.lblInfom.BackColor = System.Drawing.Color.Transparent;
            this.lblInfom.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfom.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblInfom.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblInfom.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblInfom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblInfom.ForeColor = System.Drawing.Color.Red;
            this.lblInfom.Frame.Visible = false;
            this.lblInfom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfom.Location = new System.Drawing.Point(322, 582);
            this.lblInfom.Name = "lblInfom";
            this.lblInfom.ShowAccelChar = false;
            this.lblInfom.Size = new System.Drawing.Size(701, 70);
            this.lblInfom.TabIndex = 1700;
            this.lblInfom.Text = "Position 변경시\r\n현재 작업중인 Job File을 다시 로딩 해야 변경된 값이 반영.";
            this.lblInfom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMoveTable2Pos5);
            this.groupBox5.Controls.Add(this.btnMoveTable2Pos4);
            this.groupBox5.Controls.Add(this.btnMoveTable2Pos3);
            this.groupBox5.Controls.Add(this.btnMoveTable2Pos2);
            this.groupBox5.Controls.Add(this.btnMoveTable2Pos1);
            this.groupBox5.Controls.Add(this.btnSetTable2Pos5);
            this.groupBox5.Controls.Add(this.btnSetTable2Pos4);
            this.groupBox5.Controls.Add(this.btnSetTable2Pos3);
            this.groupBox5.Controls.Add(this.btnSetTable2Pos2);
            this.groupBox5.Controls.Add(this.btnSetTable2Pos1);
            this.groupBox5.Controls.Add(this.gradientLabel19);
            this.groupBox5.Controls.Add(this.gradientLabel21);
            this.groupBox5.Controls.Add(this.edTable2CenterYPos);
            this.groupBox5.Controls.Add(this.edTable2CenterXPos);
            this.groupBox5.Controls.Add(this.edTable2RightBottomYPos);
            this.groupBox5.Controls.Add(this.edTable2RightBottomXPos);
            this.groupBox5.Controls.Add(this.edTable2RightTopYPos);
            this.groupBox5.Controls.Add(this.edTable2RightTopXPos);
            this.groupBox5.Controls.Add(this.edTable2LeftTopYPos);
            this.groupBox5.Controls.Add(this.edTable2LeftTopXPos);
            this.groupBox5.Controls.Add(this.edTable2LeftBottomYPos);
            this.groupBox5.Controls.Add(this.edTable2LeftBottomXPos);
            this.groupBox5.Location = new System.Drawing.Point(693, 170);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 284);
            this.groupBox5.TabIndex = 1692;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "  Table #2  ";
            // 
            // btnMoveTable2Pos5
            // 
            this.btnMoveTable2Pos5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2Pos5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2Pos5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable2Pos5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2Pos5.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable2Pos5.Location = new System.Drawing.Point(270, 218);
            this.btnMoveTable2Pos5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable2Pos5.Name = "btnMoveTable2Pos5";
            this.btnMoveTable2Pos5.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2Pos5.TabIndex = 1708;
            this.btnMoveTable2Pos5.Text = "▷";
            this.btnMoveTable2Pos5.UseVisualStyleBackColor = false;
            this.btnMoveTable2Pos5.Click += new System.EventHandler(this.btnMoveTable2Pos5_Click);
            // 
            // btnMoveTable2Pos4
            // 
            this.btnMoveTable2Pos4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2Pos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2Pos4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable2Pos4.Enabled = false;
            this.btnMoveTable2Pos4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2Pos4.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable2Pos4.Location = new System.Drawing.Point(270, 183);
            this.btnMoveTable2Pos4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable2Pos4.Name = "btnMoveTable2Pos4";
            this.btnMoveTable2Pos4.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2Pos4.TabIndex = 1707;
            this.btnMoveTable2Pos4.Text = "▷";
            this.btnMoveTable2Pos4.UseVisualStyleBackColor = false;
            this.btnMoveTable2Pos4.Click += new System.EventHandler(this.btnMoveTable2Pos4_Click);
            // 
            // btnMoveTable2Pos3
            // 
            this.btnMoveTable2Pos3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2Pos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2Pos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable2Pos3.Enabled = false;
            this.btnMoveTable2Pos3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2Pos3.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable2Pos3.Location = new System.Drawing.Point(270, 148);
            this.btnMoveTable2Pos3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable2Pos3.Name = "btnMoveTable2Pos3";
            this.btnMoveTable2Pos3.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2Pos3.TabIndex = 1706;
            this.btnMoveTable2Pos3.Text = "▷";
            this.btnMoveTable2Pos3.UseVisualStyleBackColor = false;
            this.btnMoveTable2Pos3.Click += new System.EventHandler(this.btnMoveTable2Pos3_Click);
            // 
            // btnMoveTable2Pos2
            // 
            this.btnMoveTable2Pos2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2Pos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2Pos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable2Pos2.Enabled = false;
            this.btnMoveTable2Pos2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2Pos2.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable2Pos2.Location = new System.Drawing.Point(270, 113);
            this.btnMoveTable2Pos2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable2Pos2.Name = "btnMoveTable2Pos2";
            this.btnMoveTable2Pos2.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2Pos2.TabIndex = 1705;
            this.btnMoveTable2Pos2.Text = "▷";
            this.btnMoveTable2Pos2.UseVisualStyleBackColor = false;
            this.btnMoveTable2Pos2.Click += new System.EventHandler(this.btnMoveTable2Pos2_Click);
            // 
            // btnMoveTable2Pos1
            // 
            this.btnMoveTable2Pos1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2Pos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2Pos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable2Pos1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2Pos1.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable2Pos1.Location = new System.Drawing.Point(270, 78);
            this.btnMoveTable2Pos1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable2Pos1.Name = "btnMoveTable2Pos1";
            this.btnMoveTable2Pos1.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2Pos1.TabIndex = 1704;
            this.btnMoveTable2Pos1.Text = "▷";
            this.btnMoveTable2Pos1.UseVisualStyleBackColor = false;
            this.btnMoveTable2Pos1.Click += new System.EventHandler(this.btnMoveTable2Pos1_Click);
            // 
            // btnSetTable2Pos5
            // 
            this.btnSetTable2Pos5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2Pos5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2Pos5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable2Pos5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2Pos5.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable2Pos5.Location = new System.Drawing.Point(234, 218);
            this.btnSetTable2Pos5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable2Pos5.Name = "btnSetTable2Pos5";
            this.btnSetTable2Pos5.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2Pos5.TabIndex = 1703;
            this.btnSetTable2Pos5.Text = "Set";
            this.btnSetTable2Pos5.UseVisualStyleBackColor = false;
            this.btnSetTable2Pos5.Click += new System.EventHandler(this.btnSetTable2Pos5_Click);
            // 
            // btnSetTable2Pos4
            // 
            this.btnSetTable2Pos4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2Pos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2Pos4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable2Pos4.Enabled = false;
            this.btnSetTable2Pos4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2Pos4.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable2Pos4.Location = new System.Drawing.Point(234, 183);
            this.btnSetTable2Pos4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable2Pos4.Name = "btnSetTable2Pos4";
            this.btnSetTable2Pos4.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2Pos4.TabIndex = 1702;
            this.btnSetTable2Pos4.Text = "Set";
            this.btnSetTable2Pos4.UseVisualStyleBackColor = false;
            this.btnSetTable2Pos4.Click += new System.EventHandler(this.btnSetTable2Pos4_Click);
            // 
            // btnSetTable2Pos3
            // 
            this.btnSetTable2Pos3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2Pos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2Pos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable2Pos3.Enabled = false;
            this.btnSetTable2Pos3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2Pos3.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable2Pos3.Location = new System.Drawing.Point(234, 148);
            this.btnSetTable2Pos3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable2Pos3.Name = "btnSetTable2Pos3";
            this.btnSetTable2Pos3.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2Pos3.TabIndex = 1701;
            this.btnSetTable2Pos3.Text = "Set";
            this.btnSetTable2Pos3.UseVisualStyleBackColor = false;
            this.btnSetTable2Pos3.Click += new System.EventHandler(this.btnSetTable2Pos3_Click);
            // 
            // btnSetTable2Pos2
            // 
            this.btnSetTable2Pos2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2Pos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2Pos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable2Pos2.Enabled = false;
            this.btnSetTable2Pos2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2Pos2.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable2Pos2.Location = new System.Drawing.Point(234, 113);
            this.btnSetTable2Pos2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable2Pos2.Name = "btnSetTable2Pos2";
            this.btnSetTable2Pos2.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2Pos2.TabIndex = 1700;
            this.btnSetTable2Pos2.Text = "Set";
            this.btnSetTable2Pos2.UseVisualStyleBackColor = false;
            this.btnSetTable2Pos2.Click += new System.EventHandler(this.btnSetTable2Pos2_Click);
            // 
            // btnSetTable2Pos1
            // 
            this.btnSetTable2Pos1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2Pos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2Pos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable2Pos1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2Pos1.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable2Pos1.Location = new System.Drawing.Point(234, 78);
            this.btnSetTable2Pos1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable2Pos1.Name = "btnSetTable2Pos1";
            this.btnSetTable2Pos1.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2Pos1.TabIndex = 1699;
            this.btnSetTable2Pos1.Text = "Set";
            this.btnSetTable2Pos1.UseVisualStyleBackColor = false;
            this.btnSetTable2Pos1.Click += new System.EventHandler(this.btnSetTable2Pos1_Click);
            // 
            // gradientLabel19
            // 
            this.gradientLabel19.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel19.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel19.Frame.Visible = false;
            this.gradientLabel19.GradientEnable = false;
            this.gradientLabel19.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel19.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel19.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel19.Location = new System.Drawing.Point(133, 49);
            this.gradientLabel19.Name = "gradientLabel19";
            this.gradientLabel19.ShowAccelChar = false;
            this.gradientLabel19.Size = new System.Drawing.Size(94, 26);
            this.gradientLabel19.TabIndex = 1689;
            this.gradientLabel19.Text = "Y Pos";
            this.gradientLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel21
            // 
            this.gradientLabel21.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel21.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel21.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel21.Frame.Visible = false;
            this.gradientLabel21.GradientEnable = false;
            this.gradientLabel21.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel21.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel21.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel21.Location = new System.Drawing.Point(33, 49);
            this.gradientLabel21.Name = "gradientLabel21";
            this.gradientLabel21.ShowAccelChar = false;
            this.gradientLabel21.Size = new System.Drawing.Size(94, 26);
            this.gradientLabel21.TabIndex = 1690;
            this.gradientLabel21.Text = "X Pos";
            this.gradientLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable2CenterYPos
            // 
            this.edTable2CenterYPos.BackColor = System.Drawing.Color.White;
            this.edTable2CenterYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2CenterYPos.Frame.CornerRound = 1;
            this.edTable2CenterYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2CenterYPos.Hint = null;
            this.edTable2CenterYPos.Location = new System.Drawing.Point(133, 220);
            this.edTable2CenterYPos.Max = 0D;
            this.edTable2CenterYPos.Min = 0D;
            this.edTable2CenterYPos.Name = "edTable2CenterYPos";
            this.edTable2CenterYPos.NewText = "0.000";
            this.edTable2CenterYPos.PrecisionDigits = 3;
            this.edTable2CenterYPos.ShowHint = false;
            this.edTable2CenterYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2CenterYPos.TabIndex = 1686;
            this.edTable2CenterYPos.Text = "0.000";
            this.edTable2CenterYPos.Value = 0D;
            // 
            // edTable2CenterXPos
            // 
            this.edTable2CenterXPos.BackColor = System.Drawing.Color.White;
            this.edTable2CenterXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2CenterXPos.Frame.CornerRound = 1;
            this.edTable2CenterXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2CenterXPos.Hint = null;
            this.edTable2CenterXPos.Location = new System.Drawing.Point(33, 220);
            this.edTable2CenterXPos.Max = 0D;
            this.edTable2CenterXPos.Min = 0D;
            this.edTable2CenterXPos.Name = "edTable2CenterXPos";
            this.edTable2CenterXPos.NewText = "0.000";
            this.edTable2CenterXPos.PrecisionDigits = 3;
            this.edTable2CenterXPos.ShowHint = false;
            this.edTable2CenterXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2CenterXPos.TabIndex = 1685;
            this.edTable2CenterXPos.Text = "0.000";
            this.edTable2CenterXPos.Value = 0D;
            // 
            // edTable2RightBottomYPos
            // 
            this.edTable2RightBottomYPos.BackColor = System.Drawing.Color.Gray;
            this.edTable2RightBottomYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2RightBottomYPos.Enabled = false;
            this.edTable2RightBottomYPos.Frame.CornerRound = 1;
            this.edTable2RightBottomYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2RightBottomYPos.Hint = null;
            this.edTable2RightBottomYPos.Location = new System.Drawing.Point(133, 185);
            this.edTable2RightBottomYPos.Max = 0D;
            this.edTable2RightBottomYPos.Min = 0D;
            this.edTable2RightBottomYPos.Name = "edTable2RightBottomYPos";
            this.edTable2RightBottomYPos.NewText = "0.000";
            this.edTable2RightBottomYPos.PrecisionDigits = 3;
            this.edTable2RightBottomYPos.ShowHint = false;
            this.edTable2RightBottomYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2RightBottomYPos.TabIndex = 1677;
            this.edTable2RightBottomYPos.Text = "0.000";
            this.edTable2RightBottomYPos.Value = 0D;
            // 
            // edTable2RightBottomXPos
            // 
            this.edTable2RightBottomXPos.BackColor = System.Drawing.Color.Gray;
            this.edTable2RightBottomXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2RightBottomXPos.Enabled = false;
            this.edTable2RightBottomXPos.Frame.CornerRound = 1;
            this.edTable2RightBottomXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2RightBottomXPos.Hint = null;
            this.edTable2RightBottomXPos.Location = new System.Drawing.Point(33, 185);
            this.edTable2RightBottomXPos.Max = 0D;
            this.edTable2RightBottomXPos.Min = 0D;
            this.edTable2RightBottomXPos.Name = "edTable2RightBottomXPos";
            this.edTable2RightBottomXPos.NewText = "0.000";
            this.edTable2RightBottomXPos.PrecisionDigits = 3;
            this.edTable2RightBottomXPos.ShowHint = false;
            this.edTable2RightBottomXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2RightBottomXPos.TabIndex = 1676;
            this.edTable2RightBottomXPos.Text = "0.000";
            this.edTable2RightBottomXPos.Value = 0D;
            // 
            // edTable2RightTopYPos
            // 
            this.edTable2RightTopYPos.BackColor = System.Drawing.Color.Gray;
            this.edTable2RightTopYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2RightTopYPos.Enabled = false;
            this.edTable2RightTopYPos.Frame.CornerRound = 1;
            this.edTable2RightTopYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2RightTopYPos.Hint = null;
            this.edTable2RightTopYPos.Location = new System.Drawing.Point(133, 150);
            this.edTable2RightTopYPos.Max = 0D;
            this.edTable2RightTopYPos.Min = 0D;
            this.edTable2RightTopYPos.Name = "edTable2RightTopYPos";
            this.edTable2RightTopYPos.NewText = "0.000";
            this.edTable2RightTopYPos.PrecisionDigits = 3;
            this.edTable2RightTopYPos.ShowHint = false;
            this.edTable2RightTopYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2RightTopYPos.TabIndex = 1663;
            this.edTable2RightTopYPos.Text = "0.000";
            this.edTable2RightTopYPos.Value = 0D;
            // 
            // edTable2RightTopXPos
            // 
            this.edTable2RightTopXPos.BackColor = System.Drawing.Color.Gray;
            this.edTable2RightTopXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2RightTopXPos.Enabled = false;
            this.edTable2RightTopXPos.Frame.CornerRound = 1;
            this.edTable2RightTopXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2RightTopXPos.Hint = null;
            this.edTable2RightTopXPos.Location = new System.Drawing.Point(33, 150);
            this.edTable2RightTopXPos.Max = 0D;
            this.edTable2RightTopXPos.Min = 0D;
            this.edTable2RightTopXPos.Name = "edTable2RightTopXPos";
            this.edTable2RightTopXPos.NewText = "0.000";
            this.edTable2RightTopXPos.PrecisionDigits = 3;
            this.edTable2RightTopXPos.ShowHint = false;
            this.edTable2RightTopXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2RightTopXPos.TabIndex = 1662;
            this.edTable2RightTopXPos.Text = "0.000";
            this.edTable2RightTopXPos.Value = 0D;
            // 
            // edTable2LeftTopYPos
            // 
            this.edTable2LeftTopYPos.BackColor = System.Drawing.Color.Gray;
            this.edTable2LeftTopYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2LeftTopYPos.Enabled = false;
            this.edTable2LeftTopYPos.Frame.CornerRound = 1;
            this.edTable2LeftTopYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LeftTopYPos.Hint = null;
            this.edTable2LeftTopYPos.Location = new System.Drawing.Point(133, 115);
            this.edTable2LeftTopYPos.Max = 0D;
            this.edTable2LeftTopYPos.Min = 0D;
            this.edTable2LeftTopYPos.Name = "edTable2LeftTopYPos";
            this.edTable2LeftTopYPos.NewText = "0.000";
            this.edTable2LeftTopYPos.PrecisionDigits = 3;
            this.edTable2LeftTopYPos.ShowHint = false;
            this.edTable2LeftTopYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2LeftTopYPos.TabIndex = 1656;
            this.edTable2LeftTopYPos.Text = "0.000";
            this.edTable2LeftTopYPos.Value = 0D;
            // 
            // edTable2LeftTopXPos
            // 
            this.edTable2LeftTopXPos.BackColor = System.Drawing.Color.Gray;
            this.edTable2LeftTopXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2LeftTopXPos.Enabled = false;
            this.edTable2LeftTopXPos.Frame.CornerRound = 1;
            this.edTable2LeftTopXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LeftTopXPos.Hint = null;
            this.edTable2LeftTopXPos.Location = new System.Drawing.Point(33, 115);
            this.edTable2LeftTopXPos.Max = 0D;
            this.edTable2LeftTopXPos.Min = 0D;
            this.edTable2LeftTopXPos.Name = "edTable2LeftTopXPos";
            this.edTable2LeftTopXPos.NewText = "0.000";
            this.edTable2LeftTopXPos.PrecisionDigits = 3;
            this.edTable2LeftTopXPos.ShowHint = false;
            this.edTable2LeftTopXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2LeftTopXPos.TabIndex = 1655;
            this.edTable2LeftTopXPos.Text = "0.000";
            this.edTable2LeftTopXPos.Value = 0D;
            // 
            // edTable2LeftBottomYPos
            // 
            this.edTable2LeftBottomYPos.BackColor = System.Drawing.Color.White;
            this.edTable2LeftBottomYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2LeftBottomYPos.Frame.CornerRound = 1;
            this.edTable2LeftBottomYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LeftBottomYPos.Hint = null;
            this.edTable2LeftBottomYPos.Location = new System.Drawing.Point(133, 80);
            this.edTable2LeftBottomYPos.Max = 0D;
            this.edTable2LeftBottomYPos.Min = 0D;
            this.edTable2LeftBottomYPos.Name = "edTable2LeftBottomYPos";
            this.edTable2LeftBottomYPos.NewText = "0.000";
            this.edTable2LeftBottomYPos.PrecisionDigits = 3;
            this.edTable2LeftBottomYPos.ShowHint = false;
            this.edTable2LeftBottomYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2LeftBottomYPos.TabIndex = 1652;
            this.edTable2LeftBottomYPos.Text = "0.000";
            this.edTable2LeftBottomYPos.Value = 0D;
            // 
            // edTable2LeftBottomXPos
            // 
            this.edTable2LeftBottomXPos.BackColor = System.Drawing.Color.White;
            this.edTable2LeftBottomXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable2LeftBottomXPos.Frame.CornerRound = 1;
            this.edTable2LeftBottomXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LeftBottomXPos.Hint = null;
            this.edTable2LeftBottomXPos.Location = new System.Drawing.Point(33, 80);
            this.edTable2LeftBottomXPos.Max = 0D;
            this.edTable2LeftBottomXPos.Min = 0D;
            this.edTable2LeftBottomXPos.Name = "edTable2LeftBottomXPos";
            this.edTable2LeftBottomXPos.NewText = "0.000";
            this.edTable2LeftBottomXPos.PrecisionDigits = 3;
            this.edTable2LeftBottomXPos.ShowHint = false;
            this.edTable2LeftBottomXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable2LeftBottomXPos.TabIndex = 1651;
            this.edTable2LeftBottomXPos.Text = "0.000";
            this.edTable2LeftBottomXPos.Value = 0D;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gradientLabel23);
            this.groupBox4.Controls.Add(this.btnMoveTable1Pos5);
            this.groupBox4.Controls.Add(this.btnMoveTable1Pos4);
            this.groupBox4.Controls.Add(this.btnMoveTable1Pos3);
            this.groupBox4.Controls.Add(this.btnMoveTable1Pos2);
            this.groupBox4.Controls.Add(this.btnMoveTable1Pos1);
            this.groupBox4.Controls.Add(this.btnSetTable1Pos5);
            this.groupBox4.Controls.Add(this.btnSetTable1Pos4);
            this.groupBox4.Controls.Add(this.btnSetTable1Pos3);
            this.groupBox4.Controls.Add(this.btnSetTable1Pos2);
            this.groupBox4.Controls.Add(this.btnSetTable1Pos1);
            this.groupBox4.Controls.Add(this.gradientLabel36);
            this.groupBox4.Controls.Add(this.edTable1CenterYPos);
            this.groupBox4.Controls.Add(this.edTable1CenterXPos);
            this.groupBox4.Controls.Add(this.gradientLabel32);
            this.groupBox4.Controls.Add(this.edTable1RightBottomYPos);
            this.groupBox4.Controls.Add(this.edTable1RightBottomXPos);
            this.groupBox4.Controls.Add(this.gradientLabel20);
            this.groupBox4.Controls.Add(this.gradientLabel22);
            this.groupBox4.Controls.Add(this.gradientLabel24);
            this.groupBox4.Controls.Add(this.edTable1RightTopYPos);
            this.groupBox4.Controls.Add(this.edTable1RightTopXPos);
            this.groupBox4.Controls.Add(this.edTable1LeftTopYPos);
            this.groupBox4.Controls.Add(this.edTable1LeftTopXPos);
            this.groupBox4.Controls.Add(this.edTable1LeftBottomYPos);
            this.groupBox4.Controls.Add(this.edTable1LeftBottomXPos);
            this.groupBox4.Controls.Add(this.gradientLabel28);
            this.groupBox4.Controls.Add(this.gradientLabel30);
            this.groupBox4.Location = new System.Drawing.Point(195, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 284);
            this.groupBox4.TabIndex = 1691;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "  Table #1  ";
            // 
            // gradientLabel23
            // 
            this.gradientLabel23.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel23.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel23.GradientEnable = false;
            this.gradientLabel23.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel23.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel23.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel23.Location = new System.Drawing.Point(410, 21);
            this.gradientLabel23.Name = "gradientLabel23";
            this.gradientLabel23.ShowAccelChar = false;
            this.gradientLabel23.Size = new System.Drawing.Size(76, 29);
            this.gradientLabel23.TabIndex = 1699;
            this.gradientLabel23.Text = "단위 mm";
            this.gradientLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveTable1Pos5
            // 
            this.btnMoveTable1Pos5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1Pos5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1Pos5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable1Pos5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1Pos5.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable1Pos5.Location = new System.Drawing.Point(398, 220);
            this.btnMoveTable1Pos5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable1Pos5.Name = "btnMoveTable1Pos5";
            this.btnMoveTable1Pos5.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1Pos5.TabIndex = 1698;
            this.btnMoveTable1Pos5.Text = "▷";
            this.btnMoveTable1Pos5.UseVisualStyleBackColor = false;
            this.btnMoveTable1Pos5.Click += new System.EventHandler(this.btnMoveTable1Pos5_Click);
            // 
            // btnMoveTable1Pos4
            // 
            this.btnMoveTable1Pos4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1Pos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1Pos4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable1Pos4.Enabled = false;
            this.btnMoveTable1Pos4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1Pos4.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable1Pos4.Location = new System.Drawing.Point(398, 183);
            this.btnMoveTable1Pos4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable1Pos4.Name = "btnMoveTable1Pos4";
            this.btnMoveTable1Pos4.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1Pos4.TabIndex = 1697;
            this.btnMoveTable1Pos4.Text = "▷";
            this.btnMoveTable1Pos4.UseVisualStyleBackColor = false;
            this.btnMoveTable1Pos4.Click += new System.EventHandler(this.btnMoveTable1Pos4_Click);
            // 
            // btnMoveTable1Pos3
            // 
            this.btnMoveTable1Pos3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1Pos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1Pos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable1Pos3.Enabled = false;
            this.btnMoveTable1Pos3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1Pos3.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable1Pos3.Location = new System.Drawing.Point(398, 148);
            this.btnMoveTable1Pos3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable1Pos3.Name = "btnMoveTable1Pos3";
            this.btnMoveTable1Pos3.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1Pos3.TabIndex = 1696;
            this.btnMoveTable1Pos3.Text = "▷";
            this.btnMoveTable1Pos3.UseVisualStyleBackColor = false;
            this.btnMoveTable1Pos3.Click += new System.EventHandler(this.btnMoveTable1Pos3_Click);
            // 
            // btnMoveTable1Pos2
            // 
            this.btnMoveTable1Pos2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1Pos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1Pos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable1Pos2.Enabled = false;
            this.btnMoveTable1Pos2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1Pos2.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable1Pos2.Location = new System.Drawing.Point(398, 113);
            this.btnMoveTable1Pos2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable1Pos2.Name = "btnMoveTable1Pos2";
            this.btnMoveTable1Pos2.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1Pos2.TabIndex = 1695;
            this.btnMoveTable1Pos2.Text = "▷";
            this.btnMoveTable1Pos2.UseVisualStyleBackColor = false;
            this.btnMoveTable1Pos2.Click += new System.EventHandler(this.btnMoveTable1Pos2_Click);
            // 
            // btnMoveTable1Pos1
            // 
            this.btnMoveTable1Pos1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1Pos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1Pos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable1Pos1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1Pos1.ForeColor = System.Drawing.Color.Black;
            this.btnMoveTable1Pos1.Location = new System.Drawing.Point(398, 80);
            this.btnMoveTable1Pos1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveTable1Pos1.Name = "btnMoveTable1Pos1";
            this.btnMoveTable1Pos1.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1Pos1.TabIndex = 1694;
            this.btnMoveTable1Pos1.Text = "▷";
            this.btnMoveTable1Pos1.UseVisualStyleBackColor = false;
            this.btnMoveTable1Pos1.Click += new System.EventHandler(this.btnMoveTable1Pos1_Click);
            // 
            // btnSetTable1Pos5
            // 
            this.btnSetTable1Pos5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1Pos5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1Pos5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable1Pos5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1Pos5.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable1Pos5.Location = new System.Drawing.Point(362, 220);
            this.btnSetTable1Pos5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable1Pos5.Name = "btnSetTable1Pos5";
            this.btnSetTable1Pos5.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1Pos5.TabIndex = 1693;
            this.btnSetTable1Pos5.Text = "Set";
            this.btnSetTable1Pos5.UseVisualStyleBackColor = false;
            this.btnSetTable1Pos5.Click += new System.EventHandler(this.btnSetTable1Pos5_Click);
            // 
            // btnSetTable1Pos4
            // 
            this.btnSetTable1Pos4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1Pos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1Pos4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable1Pos4.Enabled = false;
            this.btnSetTable1Pos4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1Pos4.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable1Pos4.Location = new System.Drawing.Point(362, 183);
            this.btnSetTable1Pos4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable1Pos4.Name = "btnSetTable1Pos4";
            this.btnSetTable1Pos4.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1Pos4.TabIndex = 1692;
            this.btnSetTable1Pos4.Text = "Set";
            this.btnSetTable1Pos4.UseVisualStyleBackColor = false;
            this.btnSetTable1Pos4.Click += new System.EventHandler(this.btnSetTable1Pos4_Click);
            // 
            // btnSetTable1Pos3
            // 
            this.btnSetTable1Pos3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1Pos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1Pos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable1Pos3.Enabled = false;
            this.btnSetTable1Pos3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1Pos3.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable1Pos3.Location = new System.Drawing.Point(362, 148);
            this.btnSetTable1Pos3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable1Pos3.Name = "btnSetTable1Pos3";
            this.btnSetTable1Pos3.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1Pos3.TabIndex = 1691;
            this.btnSetTable1Pos3.Text = "Set";
            this.btnSetTable1Pos3.UseVisualStyleBackColor = false;
            this.btnSetTable1Pos3.Click += new System.EventHandler(this.btnSetTable1Pos3_Click);
            // 
            // btnSetTable1Pos2
            // 
            this.btnSetTable1Pos2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1Pos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1Pos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable1Pos2.Enabled = false;
            this.btnSetTable1Pos2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1Pos2.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable1Pos2.Location = new System.Drawing.Point(362, 113);
            this.btnSetTable1Pos2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable1Pos2.Name = "btnSetTable1Pos2";
            this.btnSetTable1Pos2.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1Pos2.TabIndex = 1690;
            this.btnSetTable1Pos2.Text = "Set";
            this.btnSetTable1Pos2.UseVisualStyleBackColor = false;
            this.btnSetTable1Pos2.Click += new System.EventHandler(this.btnSetTable1Pos2_Click);
            // 
            // btnSetTable1Pos1
            // 
            this.btnSetTable1Pos1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1Pos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1Pos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTable1Pos1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1Pos1.ForeColor = System.Drawing.Color.Black;
            this.btnSetTable1Pos1.Location = new System.Drawing.Point(362, 80);
            this.btnSetTable1Pos1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetTable1Pos1.Name = "btnSetTable1Pos1";
            this.btnSetTable1Pos1.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1Pos1.TabIndex = 1689;
            this.btnSetTable1Pos1.Text = "Set";
            this.btnSetTable1Pos1.UseVisualStyleBackColor = false;
            this.btnSetTable1Pos1.Click += new System.EventHandler(this.btnSetTable1Pos1_Click);
            // 
            // gradientLabel36
            // 
            this.gradientLabel36.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel36.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel36.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel36.Frame.Visible = false;
            this.gradientLabel36.GradientEnable = false;
            this.gradientLabel36.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel36.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel36.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel36.Location = new System.Drawing.Point(41, 220);
            this.gradientLabel36.Name = "gradientLabel36";
            this.gradientLabel36.ShowAccelChar = false;
            this.gradientLabel36.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel36.TabIndex = 1688;
            this.gradientLabel36.Text = "중앙";
            this.gradientLabel36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1CenterYPos
            // 
            this.edTable1CenterYPos.BackColor = System.Drawing.Color.White;
            this.edTable1CenterYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1CenterYPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1CenterYPos.Frame.CornerRound = 1;
            this.edTable1CenterYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1CenterYPos.Hint = null;
            this.edTable1CenterYPos.Location = new System.Drawing.Point(261, 220);
            this.edTable1CenterYPos.Max = 0D;
            this.edTable1CenterYPos.Min = 0D;
            this.edTable1CenterYPos.Name = "edTable1CenterYPos";
            this.edTable1CenterYPos.NewText = "0.000";
            this.edTable1CenterYPos.PrecisionDigits = 3;
            this.edTable1CenterYPos.ShowHint = false;
            this.edTable1CenterYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1CenterYPos.TabIndex = 1684;
            this.edTable1CenterYPos.Text = "0.000";
            this.edTable1CenterYPos.Value = 0D;
            // 
            // edTable1CenterXPos
            // 
            this.edTable1CenterXPos.BackColor = System.Drawing.Color.White;
            this.edTable1CenterXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1CenterXPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1CenterXPos.Frame.CornerRound = 1;
            this.edTable1CenterXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1CenterXPos.Hint = null;
            this.edTable1CenterXPos.Location = new System.Drawing.Point(161, 220);
            this.edTable1CenterXPos.Max = 0D;
            this.edTable1CenterXPos.Min = 0D;
            this.edTable1CenterXPos.Name = "edTable1CenterXPos";
            this.edTable1CenterXPos.NewText = "0.000";
            this.edTable1CenterXPos.PrecisionDigits = 3;
            this.edTable1CenterXPos.ShowHint = false;
            this.edTable1CenterXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1CenterXPos.TabIndex = 1683;
            this.edTable1CenterXPos.Text = "0.000";
            this.edTable1CenterXPos.Value = 0D;
            // 
            // gradientLabel32
            // 
            this.gradientLabel32.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel32.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel32.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel32.Frame.Visible = false;
            this.gradientLabel32.GradientEnable = false;
            this.gradientLabel32.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel32.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel32.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel32.Location = new System.Drawing.Point(41, 185);
            this.gradientLabel32.Name = "gradientLabel32";
            this.gradientLabel32.ShowAccelChar = false;
            this.gradientLabel32.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel32.TabIndex = 1679;
            this.gradientLabel32.Text = "우측 하단";
            this.gradientLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1RightBottomYPos
            // 
            this.edTable1RightBottomYPos.BackColor = System.Drawing.Color.Gray;
            this.edTable1RightBottomYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1RightBottomYPos.Enabled = false;
            this.edTable1RightBottomYPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1RightBottomYPos.Frame.CornerRound = 1;
            this.edTable1RightBottomYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1RightBottomYPos.Hint = null;
            this.edTable1RightBottomYPos.Location = new System.Drawing.Point(261, 185);
            this.edTable1RightBottomYPos.Max = 0D;
            this.edTable1RightBottomYPos.Min = 0D;
            this.edTable1RightBottomYPos.Name = "edTable1RightBottomYPos";
            this.edTable1RightBottomYPos.NewText = "0.000";
            this.edTable1RightBottomYPos.PrecisionDigits = 3;
            this.edTable1RightBottomYPos.ShowHint = false;
            this.edTable1RightBottomYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1RightBottomYPos.TabIndex = 1675;
            this.edTable1RightBottomYPos.Text = "0.000";
            this.edTable1RightBottomYPos.Value = 0D;
            // 
            // edTable1RightBottomXPos
            // 
            this.edTable1RightBottomXPos.BackColor = System.Drawing.Color.Gray;
            this.edTable1RightBottomXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1RightBottomXPos.Enabled = false;
            this.edTable1RightBottomXPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1RightBottomXPos.Frame.CornerRound = 1;
            this.edTable1RightBottomXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1RightBottomXPos.Hint = null;
            this.edTable1RightBottomXPos.Location = new System.Drawing.Point(161, 185);
            this.edTable1RightBottomXPos.Max = 0D;
            this.edTable1RightBottomXPos.Min = 0D;
            this.edTable1RightBottomXPos.Name = "edTable1RightBottomXPos";
            this.edTable1RightBottomXPos.NewText = "0.000";
            this.edTable1RightBottomXPos.PrecisionDigits = 3;
            this.edTable1RightBottomXPos.ShowHint = false;
            this.edTable1RightBottomXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1RightBottomXPos.TabIndex = 1674;
            this.edTable1RightBottomXPos.Text = "0.000";
            this.edTable1RightBottomXPos.Value = 0D;
            // 
            // gradientLabel20
            // 
            this.gradientLabel20.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel20.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel20.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel20.Frame.Visible = false;
            this.gradientLabel20.GradientEnable = false;
            this.gradientLabel20.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel20.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel20.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel20.Location = new System.Drawing.Point(41, 150);
            this.gradientLabel20.Name = "gradientLabel20";
            this.gradientLabel20.ShowAccelChar = false;
            this.gradientLabel20.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel20.TabIndex = 1669;
            this.gradientLabel20.Text = "우측 상단";
            this.gradientLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel22
            // 
            this.gradientLabel22.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel22.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel22.Frame.Visible = false;
            this.gradientLabel22.GradientEnable = false;
            this.gradientLabel22.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel22.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel22.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel22.Location = new System.Drawing.Point(41, 115);
            this.gradientLabel22.Name = "gradientLabel22";
            this.gradientLabel22.ShowAccelChar = false;
            this.gradientLabel22.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel22.TabIndex = 1667;
            this.gradientLabel22.Text = "좌측 상단";
            this.gradientLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel24
            // 
            this.gradientLabel24.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel24.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel24.Frame.Visible = false;
            this.gradientLabel24.GradientEnable = false;
            this.gradientLabel24.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel24.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel24.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel24.Location = new System.Drawing.Point(41, 80);
            this.gradientLabel24.Name = "gradientLabel24";
            this.gradientLabel24.ShowAccelChar = false;
            this.gradientLabel24.Size = new System.Drawing.Size(115, 29);
            this.gradientLabel24.TabIndex = 1665;
            this.gradientLabel24.Text = "좌측 하단";
            this.gradientLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1RightTopYPos
            // 
            this.edTable1RightTopYPos.BackColor = System.Drawing.Color.Gray;
            this.edTable1RightTopYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1RightTopYPos.Enabled = false;
            this.edTable1RightTopYPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1RightTopYPos.Frame.CornerRound = 1;
            this.edTable1RightTopYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1RightTopYPos.Hint = null;
            this.edTable1RightTopYPos.Location = new System.Drawing.Point(261, 150);
            this.edTable1RightTopYPos.Max = 0D;
            this.edTable1RightTopYPos.Min = 0D;
            this.edTable1RightTopYPos.Name = "edTable1RightTopYPos";
            this.edTable1RightTopYPos.NewText = "0.000";
            this.edTable1RightTopYPos.PrecisionDigits = 3;
            this.edTable1RightTopYPos.ShowHint = false;
            this.edTable1RightTopYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1RightTopYPos.TabIndex = 1661;
            this.edTable1RightTopYPos.Text = "0.000";
            this.edTable1RightTopYPos.Value = 0D;
            // 
            // edTable1RightTopXPos
            // 
            this.edTable1RightTopXPos.BackColor = System.Drawing.Color.Gray;
            this.edTable1RightTopXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1RightTopXPos.Enabled = false;
            this.edTable1RightTopXPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1RightTopXPos.Frame.CornerRound = 1;
            this.edTable1RightTopXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1RightTopXPos.Hint = null;
            this.edTable1RightTopXPos.Location = new System.Drawing.Point(161, 150);
            this.edTable1RightTopXPos.Max = 0D;
            this.edTable1RightTopXPos.Min = 0D;
            this.edTable1RightTopXPos.Name = "edTable1RightTopXPos";
            this.edTable1RightTopXPos.NewText = "0.000";
            this.edTable1RightTopXPos.PrecisionDigits = 3;
            this.edTable1RightTopXPos.ShowHint = false;
            this.edTable1RightTopXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1RightTopXPos.TabIndex = 1660;
            this.edTable1RightTopXPos.Text = "0.000";
            this.edTable1RightTopXPos.Value = 0D;
            // 
            // edTable1LeftTopYPos
            // 
            this.edTable1LeftTopYPos.BackColor = System.Drawing.Color.Gray;
            this.edTable1LeftTopYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1LeftTopYPos.Enabled = false;
            this.edTable1LeftTopYPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1LeftTopYPos.Frame.CornerRound = 1;
            this.edTable1LeftTopYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LeftTopYPos.Hint = null;
            this.edTable1LeftTopYPos.Location = new System.Drawing.Point(261, 115);
            this.edTable1LeftTopYPos.Max = 0D;
            this.edTable1LeftTopYPos.Min = 0D;
            this.edTable1LeftTopYPos.Name = "edTable1LeftTopYPos";
            this.edTable1LeftTopYPos.NewText = "0.000";
            this.edTable1LeftTopYPos.PrecisionDigits = 3;
            this.edTable1LeftTopYPos.ShowHint = false;
            this.edTable1LeftTopYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1LeftTopYPos.TabIndex = 1654;
            this.edTable1LeftTopYPos.Text = "0.000";
            this.edTable1LeftTopYPos.Value = 0D;
            // 
            // edTable1LeftTopXPos
            // 
            this.edTable1LeftTopXPos.BackColor = System.Drawing.Color.Gray;
            this.edTable1LeftTopXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1LeftTopXPos.Enabled = false;
            this.edTable1LeftTopXPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1LeftTopXPos.Frame.CornerRound = 1;
            this.edTable1LeftTopXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LeftTopXPos.Hint = null;
            this.edTable1LeftTopXPos.Location = new System.Drawing.Point(161, 115);
            this.edTable1LeftTopXPos.Max = 0D;
            this.edTable1LeftTopXPos.Min = 0D;
            this.edTable1LeftTopXPos.Name = "edTable1LeftTopXPos";
            this.edTable1LeftTopXPos.NewText = "0.000";
            this.edTable1LeftTopXPos.PrecisionDigits = 3;
            this.edTable1LeftTopXPos.ShowHint = false;
            this.edTable1LeftTopXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1LeftTopXPos.TabIndex = 1653;
            this.edTable1LeftTopXPos.Text = "0.000";
            this.edTable1LeftTopXPos.Value = 0D;
            // 
            // edTable1LeftBottomYPos
            // 
            this.edTable1LeftBottomYPos.BackColor = System.Drawing.Color.White;
            this.edTable1LeftBottomYPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1LeftBottomYPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1LeftBottomYPos.Frame.CornerRound = 1;
            this.edTable1LeftBottomYPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LeftBottomYPos.Hint = null;
            this.edTable1LeftBottomYPos.Location = new System.Drawing.Point(261, 80);
            this.edTable1LeftBottomYPos.Max = 0D;
            this.edTable1LeftBottomYPos.Min = 0D;
            this.edTable1LeftBottomYPos.Name = "edTable1LeftBottomYPos";
            this.edTable1LeftBottomYPos.NewText = "0.000";
            this.edTable1LeftBottomYPos.PrecisionDigits = 3;
            this.edTable1LeftBottomYPos.ShowHint = false;
            this.edTable1LeftBottomYPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1LeftBottomYPos.TabIndex = 1650;
            this.edTable1LeftBottomYPos.Text = "0.000";
            this.edTable1LeftBottomYPos.Value = 0D;
            // 
            // edTable1LeftBottomXPos
            // 
            this.edTable1LeftBottomXPos.BackColor = System.Drawing.Color.White;
            this.edTable1LeftBottomXPos.DataType = YujinTechnology.DataType.Double;
            this.edTable1LeftBottomXPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1LeftBottomXPos.Frame.CornerRound = 1;
            this.edTable1LeftBottomXPos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LeftBottomXPos.Hint = null;
            this.edTable1LeftBottomXPos.Location = new System.Drawing.Point(161, 80);
            this.edTable1LeftBottomXPos.Max = 0D;
            this.edTable1LeftBottomXPos.Min = 0D;
            this.edTable1LeftBottomXPos.Name = "edTable1LeftBottomXPos";
            this.edTable1LeftBottomXPos.NewText = "0.000";
            this.edTable1LeftBottomXPos.PrecisionDigits = 3;
            this.edTable1LeftBottomXPos.ShowHint = false;
            this.edTable1LeftBottomXPos.Size = new System.Drawing.Size(95, 29);
            this.edTable1LeftBottomXPos.TabIndex = 1649;
            this.edTable1LeftBottomXPos.Text = "0.000";
            this.edTable1LeftBottomXPos.Value = 0D;
            // 
            // gradientLabel28
            // 
            this.gradientLabel28.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel28.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel28.Frame.Visible = false;
            this.gradientLabel28.GradientEnable = false;
            this.gradientLabel28.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel28.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel28.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel28.Location = new System.Drawing.Point(261, 49);
            this.gradientLabel28.Name = "gradientLabel28";
            this.gradientLabel28.ShowAccelChar = false;
            this.gradientLabel28.Size = new System.Drawing.Size(94, 26);
            this.gradientLabel28.TabIndex = 1645;
            this.gradientLabel28.Text = "Y Pos";
            this.gradientLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel30
            // 
            this.gradientLabel30.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel30.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel30.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel30.Frame.Visible = false;
            this.gradientLabel30.GradientEnable = false;
            this.gradientLabel30.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel30.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel30.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel30.Location = new System.Drawing.Point(161, 49);
            this.gradientLabel30.Name = "gradientLabel30";
            this.gradientLabel30.ShowAccelChar = false;
            this.gradientLabel30.Size = new System.Drawing.Size(94, 26);
            this.gradientLabel30.TabIndex = 1647;
            this.gradientLabel30.Text = "X Pos";
            this.gradientLabel30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage6.Controls.Add(this.tabControl2);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1324, 675);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "  Focus  ";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Location = new System.Drawing.Point(189, 69);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.ShowActiveCloseButton = false;
            this.tabControl2.ShowCloseButton = false;
            this.tabControl2.Size = new System.Drawing.Size(924, 537);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControl2.TabIndex = 1743;
            this.tabControl2.TabSelectedColor = System.Drawing.Color.Lime;
            this.tabControl2.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tabControl2.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabControl2.TabSelectedHighColorSize = 4;
            this.tabControl2.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tabControl2.TabVisible = true;
            this.tabControl2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabControl2.TipsColor = System.Drawing.Color.Red;
            this.tabControl2.TipsFont = new System.Drawing.Font("Arial", 8F);
            this.tabControl2.TipsForeColor = System.Drawing.Color.White;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage7.Controls.Add(this.gradientLabel67);
            this.tabPage7.Controls.Add(this.edTable1VisionFocusLightValue);
            this.tabPage7.Controls.Add(this.edTable1LaserFocusLightValue);
            this.tabPage7.Controls.Add(this.gradientLabel62);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.gradientLabel57);
            this.tabPage7.Controls.Add(this.gradientLabel58);
            this.tabPage7.Controls.Add(this.gradientLabel59);
            this.tabPage7.Controls.Add(this.btnMoveTable1LaserZFocus);
            this.tabPage7.Controls.Add(this.keypadEdit2);
            this.tabPage7.Controls.Add(this.keypadEdit1);
            this.tabPage7.Controls.Add(this.keypadEdit6);
            this.tabPage7.Controls.Add(this.keypadEdit7);
            this.tabPage7.Controls.Add(this.keypadEdit5);
            this.tabPage7.Controls.Add(this.keypadEdit4);
            this.tabPage7.Controls.Add(this.gradientLabel46);
            this.tabPage7.Controls.Add(this.edTable1StartX);
            this.tabPage7.Controls.Add(this.btnTable1Start);
            this.tabPage7.Controls.Add(this.edTable1DrawX);
            this.tabPage7.Controls.Add(this.gradientLabel43);
            this.tabPage7.Controls.Add(this.edTable1StepZ);
            this.tabPage7.Controls.Add(this.gradientLabel42);
            this.tabPage7.Controls.Add(this.edTable1PitchZ);
            this.tabPage7.Controls.Add(this.edTable1PitchY);
            this.tabPage7.Controls.Add(this.gradientLabel41);
            this.tabPage7.Controls.Add(this.gradientLabel40);
            this.tabPage7.Controls.Add(this.edTable1StartZ);
            this.tabPage7.Controls.Add(this.gradientLabel31);
            this.tabPage7.Controls.Add(this.btnSetTable1StartPos);
            this.tabPage7.Controls.Add(this.btnMoveTable1StartPos);
            this.tabPage7.Controls.Add(this.edTable1StartY);
            this.tabPage7.Controls.Add(this.gradientLabel9);
            this.tabPage7.Controls.Add(this.btnSetTable1VisionZFocus);
            this.tabPage7.Controls.Add(this.btnSetTable1LaserZFocus);
            this.tabPage7.Controls.Add(this.btnMoveTable1VisionZFocus);
            this.tabPage7.Controls.Add(this.gradientLabel4);
            this.tabPage7.Controls.Add(this.gradientLabel5);
            this.tabPage7.Controls.Add(this.edTable1VisionZFocus);
            this.tabPage7.Controls.Add(this.edTable1LaserZFocus);
            this.tabPage7.Location = new System.Drawing.Point(4, 34);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(916, 499);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "  Table#1  ";
            // 
            // gradientLabel67
            // 
            this.gradientLabel67.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel67.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel67.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel67.GradientEnable = false;
            this.gradientLabel67.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel67.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel67.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel67.Location = new System.Drawing.Point(740, 63);
            this.gradientLabel67.Name = "gradientLabel67";
            this.gradientLabel67.ShowAccelChar = false;
            this.gradientLabel67.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel67.TabIndex = 1785;
            this.gradientLabel67.Text = "Light Value";
            this.gradientLabel67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable1VisionFocusLightValue
            // 
            this.edTable1VisionFocusLightValue.BackColor = System.Drawing.Color.White;
            this.edTable1VisionFocusLightValue.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1VisionFocusLightValue.Frame.CornerRound = 1;
            this.edTable1VisionFocusLightValue.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1VisionFocusLightValue.Hint = null;
            this.edTable1VisionFocusLightValue.Location = new System.Drawing.Point(739, 96);
            this.edTable1VisionFocusLightValue.Max = 0D;
            this.edTable1VisionFocusLightValue.Min = 0D;
            this.edTable1VisionFocusLightValue.Name = "edTable1VisionFocusLightValue";
            this.edTable1VisionFocusLightValue.NewText = "0.000";
            this.edTable1VisionFocusLightValue.PrecisionDigits = 3;
            this.edTable1VisionFocusLightValue.ShowHint = false;
            this.edTable1VisionFocusLightValue.Size = new System.Drawing.Size(95, 29);
            this.edTable1VisionFocusLightValue.TabIndex = 1784;
            this.edTable1VisionFocusLightValue.Text = "0";
            this.edTable1VisionFocusLightValue.Value = 0D;
            // 
            // edTable1LaserFocusLightValue
            // 
            this.edTable1LaserFocusLightValue.BackColor = System.Drawing.Color.White;
            this.edTable1LaserFocusLightValue.Frame.CornerRound = 1;
            this.edTable1LaserFocusLightValue.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LaserFocusLightValue.Hint = null;
            this.edTable1LaserFocusLightValue.Location = new System.Drawing.Point(739, 130);
            this.edTable1LaserFocusLightValue.Max = 0D;
            this.edTable1LaserFocusLightValue.Min = 0D;
            this.edTable1LaserFocusLightValue.Name = "edTable1LaserFocusLightValue";
            this.edTable1LaserFocusLightValue.NewText = "0.000";
            this.edTable1LaserFocusLightValue.PrecisionDigits = 3;
            this.edTable1LaserFocusLightValue.ShowHint = false;
            this.edTable1LaserFocusLightValue.Size = new System.Drawing.Size(95, 29);
            this.edTable1LaserFocusLightValue.TabIndex = 1783;
            this.edTable1LaserFocusLightValue.Text = "0";
            this.edTable1LaserFocusLightValue.Value = 0D;
            // 
            // gradientLabel62
            // 
            this.gradientLabel62.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel62.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel62.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.gradientLabel62.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.gradientLabel62.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gradientLabel62.ForeColor = System.Drawing.Color.Red;
            this.gradientLabel62.Frame.Visible = false;
            this.gradientLabel62.GradientEnable = false;
            this.gradientLabel62.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel62.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel62.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel62.Location = new System.Drawing.Point(625, 296);
            this.gradientLabel62.Name = "gradientLabel62";
            this.gradientLabel62.ShowAccelChar = false;
            this.gradientLabel62.Size = new System.Drawing.Size(188, 42);
            this.gradientLabel62.TabIndex = 1782;
            this.gradientLabel62.Text = "Z축은 바닥에서 시작하여 \r\nPitch 만큼 위로 올라갑니다.";
            this.gradientLabel62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1780;
            this.label1.Text = "(mm) ";
            // 
            // gradientLabel57
            // 
            this.gradientLabel57.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel57.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel57.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel57.GradientEnable = false;
            this.gradientLabel57.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel57.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel57.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel57.Location = new System.Drawing.Point(324, 63);
            this.gradientLabel57.Name = "gradientLabel57";
            this.gradientLabel57.ShowAccelChar = false;
            this.gradientLabel57.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel57.TabIndex = 1779;
            this.gradientLabel57.Text = "X";
            this.gradientLabel57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel58
            // 
            this.gradientLabel58.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel58.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel58.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel58.GradientEnable = false;
            this.gradientLabel58.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel58.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel58.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel58.Location = new System.Drawing.Point(524, 63);
            this.gradientLabel58.Name = "gradientLabel58";
            this.gradientLabel58.ShowAccelChar = false;
            this.gradientLabel58.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel58.TabIndex = 1778;
            this.gradientLabel58.Text = "Z";
            this.gradientLabel58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel59
            // 
            this.gradientLabel59.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel59.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel59.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel59.GradientEnable = false;
            this.gradientLabel59.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel59.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel59.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel59.Location = new System.Drawing.Point(424, 63);
            this.gradientLabel59.Name = "gradientLabel59";
            this.gradientLabel59.ShowAccelChar = false;
            this.gradientLabel59.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel59.TabIndex = 1777;
            this.gradientLabel59.Text = "Y";
            this.gradientLabel59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveTable1LaserZFocus
            // 
            this.btnMoveTable1LaserZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1LaserZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1LaserZFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1LaserZFocus.Location = new System.Drawing.Point(659, 130);
            this.btnMoveTable1LaserZFocus.Name = "btnMoveTable1LaserZFocus";
            this.btnMoveTable1LaserZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1LaserZFocus.TabIndex = 1774;
            this.btnMoveTable1LaserZFocus.Text = "▷";
            this.btnMoveTable1LaserZFocus.UseVisualStyleBackColor = false;
            this.btnMoveTable1LaserZFocus.Click += new System.EventHandler(this.btnMoveTable1LaserZFocus_Click);
            // 
            // keypadEdit2
            // 
            this.keypadEdit2.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit2.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit2.Enabled = false;
            this.keypadEdit2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit2.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit2.Frame.CornerRound = 1;
            this.keypadEdit2.Hint = null;
            this.keypadEdit2.Location = new System.Drawing.Point(424, 336);
            this.keypadEdit2.Max = 0D;
            this.keypadEdit2.Min = 0D;
            this.keypadEdit2.Name = "keypadEdit2";
            this.keypadEdit2.NewText = "0.000";
            this.keypadEdit2.PrecisionDigits = 3;
            this.keypadEdit2.ShowHint = false;
            this.keypadEdit2.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit2.TabIndex = 1773;
            this.keypadEdit2.Text = "0.000";
            this.keypadEdit2.Value = 0D;
            // 
            // keypadEdit1
            // 
            this.keypadEdit1.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit1.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit1.Enabled = false;
            this.keypadEdit1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit1.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit1.Frame.CornerRound = 1;
            this.keypadEdit1.Hint = null;
            this.keypadEdit1.Location = new System.Drawing.Point(524, 336);
            this.keypadEdit1.Max = 0D;
            this.keypadEdit1.Min = 0D;
            this.keypadEdit1.Name = "keypadEdit1";
            this.keypadEdit1.NewText = "0.000";
            this.keypadEdit1.PrecisionDigits = 3;
            this.keypadEdit1.ShowHint = false;
            this.keypadEdit1.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit1.TabIndex = 1772;
            this.keypadEdit1.Text = "0.000";
            this.keypadEdit1.Value = 0D;
            // 
            // keypadEdit6
            // 
            this.keypadEdit6.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit6.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit6.Enabled = false;
            this.keypadEdit6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit6.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit6.Frame.CornerRound = 1;
            this.keypadEdit6.Hint = null;
            this.keypadEdit6.Location = new System.Drawing.Point(424, 130);
            this.keypadEdit6.Max = 0D;
            this.keypadEdit6.Min = 0D;
            this.keypadEdit6.Name = "keypadEdit6";
            this.keypadEdit6.NewText = "0.000";
            this.keypadEdit6.PrecisionDigits = 3;
            this.keypadEdit6.ShowHint = false;
            this.keypadEdit6.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit6.TabIndex = 1771;
            this.keypadEdit6.Text = "0.000";
            this.keypadEdit6.Value = 0D;
            // 
            // keypadEdit7
            // 
            this.keypadEdit7.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit7.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit7.Enabled = false;
            this.keypadEdit7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit7.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit7.Frame.CornerRound = 1;
            this.keypadEdit7.Hint = null;
            this.keypadEdit7.Location = new System.Drawing.Point(424, 96);
            this.keypadEdit7.Max = 0D;
            this.keypadEdit7.Min = 0D;
            this.keypadEdit7.Name = "keypadEdit7";
            this.keypadEdit7.NewText = "0.000";
            this.keypadEdit7.PrecisionDigits = 3;
            this.keypadEdit7.ShowHint = false;
            this.keypadEdit7.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit7.TabIndex = 1770;
            this.keypadEdit7.Text = "0.000";
            this.keypadEdit7.Value = 0D;
            // 
            // keypadEdit5
            // 
            this.keypadEdit5.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit5.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit5.Enabled = false;
            this.keypadEdit5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit5.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit5.Frame.CornerRound = 1;
            this.keypadEdit5.Hint = null;
            this.keypadEdit5.Location = new System.Drawing.Point(324, 130);
            this.keypadEdit5.Max = 0D;
            this.keypadEdit5.Min = 0D;
            this.keypadEdit5.Name = "keypadEdit5";
            this.keypadEdit5.NewText = "0.000";
            this.keypadEdit5.PrecisionDigits = 3;
            this.keypadEdit5.ShowHint = false;
            this.keypadEdit5.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit5.TabIndex = 1769;
            this.keypadEdit5.Text = "0.000";
            this.keypadEdit5.Value = 0D;
            // 
            // keypadEdit4
            // 
            this.keypadEdit4.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit4.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit4.Enabled = false;
            this.keypadEdit4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit4.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit4.Frame.CornerRound = 1;
            this.keypadEdit4.Hint = null;
            this.keypadEdit4.Location = new System.Drawing.Point(324, 96);
            this.keypadEdit4.Max = 0D;
            this.keypadEdit4.Min = 0D;
            this.keypadEdit4.Name = "keypadEdit4";
            this.keypadEdit4.NewText = "0.000";
            this.keypadEdit4.PrecisionDigits = 3;
            this.keypadEdit4.ShowHint = false;
            this.keypadEdit4.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit4.TabIndex = 1768;
            this.keypadEdit4.Text = "0.000";
            this.keypadEdit4.Value = 0D;
            // 
            // gradientLabel46
            // 
            this.gradientLabel46.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel46.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel46.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel46.GradientEnable = false;
            this.gradientLabel46.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel46.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel46.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel46.Location = new System.Drawing.Point(324, 203);
            this.gradientLabel46.Name = "gradientLabel46";
            this.gradientLabel46.ShowAccelChar = false;
            this.gradientLabel46.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel46.TabIndex = 1767;
            this.gradientLabel46.Text = "X";
            this.gradientLabel46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable1StartX
            // 
            this.edTable1StartX.BackColor = System.Drawing.Color.White;
            this.edTable1StartX.DataType = YujinTechnology.DataType.Double;
            this.edTable1StartX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1StartX.Frame.CornerRound = 1;
            this.edTable1StartX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1StartX.Hint = null;
            this.edTable1StartX.Location = new System.Drawing.Point(324, 237);
            this.edTable1StartX.Max = 0D;
            this.edTable1StartX.Min = 0D;
            this.edTable1StartX.Name = "edTable1StartX";
            this.edTable1StartX.NewText = "0.000";
            this.edTable1StartX.PrecisionDigits = 3;
            this.edTable1StartX.ShowHint = false;
            this.edTable1StartX.Size = new System.Drawing.Size(95, 29);
            this.edTable1StartX.TabIndex = 1766;
            this.edTable1StartX.Text = "0.000";
            this.edTable1StartX.Value = 0D;
            // 
            // btnTable1Start
            // 
            this.btnTable1Start.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnTable1Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnTable1Start.Location = new System.Drawing.Point(424, 402);
            this.btnTable1Start.Name = "btnTable1Start";
            this.btnTable1Start.Size = new System.Drawing.Size(95, 42);
            this.btnTable1Start.TabIndex = 1765;
            this.btnTable1Start.Text = "Mark Start";
            this.btnTable1Start.UseVisualStyleBackColor = false;
            this.btnTable1Start.Click += new System.EventHandler(this.btnTable1Start_Click);
            // 
            // edTable1DrawX
            // 
            this.edTable1DrawX.BackColor = System.Drawing.Color.White;
            this.edTable1DrawX.DataType = YujinTechnology.DataType.Double;
            this.edTable1DrawX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1DrawX.Frame.CornerRound = 1;
            this.edTable1DrawX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1DrawX.Hint = null;
            this.edTable1DrawX.Location = new System.Drawing.Point(324, 336);
            this.edTable1DrawX.Max = 0D;
            this.edTable1DrawX.Min = 0D;
            this.edTable1DrawX.Name = "edTable1DrawX";
            this.edTable1DrawX.NewText = "0.000";
            this.edTable1DrawX.PrecisionDigits = 3;
            this.edTable1DrawX.ShowHint = false;
            this.edTable1DrawX.Size = new System.Drawing.Size(95, 29);
            this.edTable1DrawX.TabIndex = 1764;
            this.edTable1DrawX.Text = "0.000";
            this.edTable1DrawX.Value = 0D;
            // 
            // gradientLabel43
            // 
            this.gradientLabel43.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel43.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel43.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel43.GradientEnable = false;
            this.gradientLabel43.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel43.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel43.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel43.Location = new System.Drawing.Point(226, 336);
            this.gradientLabel43.Name = "gradientLabel43";
            this.gradientLabel43.ShowAccelChar = false;
            this.gradientLabel43.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel43.TabIndex = 1763;
            this.gradientLabel43.Text = "Draw Length";
            this.gradientLabel43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1StepZ
            // 
            this.edTable1StepZ.BackColor = System.Drawing.Color.White;
            this.edTable1StepZ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1StepZ.Frame.CornerRound = 1;
            this.edTable1StepZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1StepZ.Hint = null;
            this.edTable1StepZ.Location = new System.Drawing.Point(524, 303);
            this.edTable1StepZ.Max = 0D;
            this.edTable1StepZ.Min = 0D;
            this.edTable1StepZ.Name = "edTable1StepZ";
            this.edTable1StepZ.NewText = "0.000";
            this.edTable1StepZ.PrecisionDigits = 3;
            this.edTable1StepZ.ShowHint = false;
            this.edTable1StepZ.Size = new System.Drawing.Size(95, 29);
            this.edTable1StepZ.TabIndex = 1762;
            this.edTable1StepZ.Text = "0";
            this.edTable1StepZ.Value = 0D;
            // 
            // gradientLabel42
            // 
            this.gradientLabel42.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel42.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel42.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel42.GradientEnable = false;
            this.gradientLabel42.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel42.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel42.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel42.Location = new System.Drawing.Point(226, 303);
            this.gradientLabel42.Name = "gradientLabel42";
            this.gradientLabel42.ShowAccelChar = false;
            this.gradientLabel42.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel42.TabIndex = 1761;
            this.gradientLabel42.Text = "Step";
            this.gradientLabel42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1PitchZ
            // 
            this.edTable1PitchZ.BackColor = System.Drawing.Color.White;
            this.edTable1PitchZ.DataType = YujinTechnology.DataType.Double;
            this.edTable1PitchZ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1PitchZ.Frame.CornerRound = 1;
            this.edTable1PitchZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1PitchZ.Hint = null;
            this.edTable1PitchZ.Location = new System.Drawing.Point(524, 270);
            this.edTable1PitchZ.Max = 0D;
            this.edTable1PitchZ.Min = 0D;
            this.edTable1PitchZ.Name = "edTable1PitchZ";
            this.edTable1PitchZ.NewText = "0.000";
            this.edTable1PitchZ.PrecisionDigits = 3;
            this.edTable1PitchZ.ShowHint = false;
            this.edTable1PitchZ.Size = new System.Drawing.Size(95, 29);
            this.edTable1PitchZ.TabIndex = 1760;
            this.edTable1PitchZ.Text = "0.000";
            this.edTable1PitchZ.Value = 0D;
            // 
            // edTable1PitchY
            // 
            this.edTable1PitchY.BackColor = System.Drawing.Color.White;
            this.edTable1PitchY.DataType = YujinTechnology.DataType.Double;
            this.edTable1PitchY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1PitchY.Frame.CornerRound = 1;
            this.edTable1PitchY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1PitchY.Hint = null;
            this.edTable1PitchY.Location = new System.Drawing.Point(424, 270);
            this.edTable1PitchY.Max = 0D;
            this.edTable1PitchY.Min = 0D;
            this.edTable1PitchY.Name = "edTable1PitchY";
            this.edTable1PitchY.NewText = "0.000";
            this.edTable1PitchY.PrecisionDigits = 3;
            this.edTable1PitchY.ShowHint = false;
            this.edTable1PitchY.Size = new System.Drawing.Size(95, 29);
            this.edTable1PitchY.TabIndex = 1759;
            this.edTable1PitchY.Text = "0.000";
            this.edTable1PitchY.Value = 0D;
            // 
            // gradientLabel41
            // 
            this.gradientLabel41.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel41.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel41.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel41.GradientEnable = false;
            this.gradientLabel41.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel41.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel41.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel41.Location = new System.Drawing.Point(226, 270);
            this.gradientLabel41.Name = "gradientLabel41";
            this.gradientLabel41.ShowAccelChar = false;
            this.gradientLabel41.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel41.TabIndex = 1758;
            this.gradientLabel41.Text = "Pitch";
            this.gradientLabel41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel40
            // 
            this.gradientLabel40.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel40.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel40.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel40.GradientEnable = false;
            this.gradientLabel40.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel40.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel40.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel40.Location = new System.Drawing.Point(524, 203);
            this.gradientLabel40.Name = "gradientLabel40";
            this.gradientLabel40.ShowAccelChar = false;
            this.gradientLabel40.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel40.TabIndex = 1757;
            this.gradientLabel40.Text = "Z";
            this.gradientLabel40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable1StartZ
            // 
            this.edTable1StartZ.BackColor = System.Drawing.Color.White;
            this.edTable1StartZ.DataType = YujinTechnology.DataType.Double;
            this.edTable1StartZ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1StartZ.Frame.CornerRound = 1;
            this.edTable1StartZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1StartZ.Hint = null;
            this.edTable1StartZ.Location = new System.Drawing.Point(524, 237);
            this.edTable1StartZ.Max = 0D;
            this.edTable1StartZ.Min = 0D;
            this.edTable1StartZ.Name = "edTable1StartZ";
            this.edTable1StartZ.NewText = "0.000";
            this.edTable1StartZ.PrecisionDigits = 3;
            this.edTable1StartZ.ShowHint = false;
            this.edTable1StartZ.Size = new System.Drawing.Size(95, 29);
            this.edTable1StartZ.TabIndex = 1756;
            this.edTable1StartZ.Text = "0.000";
            this.edTable1StartZ.Value = 0D;
            // 
            // gradientLabel31
            // 
            this.gradientLabel31.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel31.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel31.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel31.GradientEnable = false;
            this.gradientLabel31.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel31.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel31.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel31.Location = new System.Drawing.Point(424, 203);
            this.gradientLabel31.Name = "gradientLabel31";
            this.gradientLabel31.ShowAccelChar = false;
            this.gradientLabel31.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel31.TabIndex = 1755;
            this.gradientLabel31.Text = "Y";
            this.gradientLabel31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetTable1StartPos
            // 
            this.btnSetTable1StartPos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1StartPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1StartPos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1StartPos.Location = new System.Drawing.Point(624, 237);
            this.btnSetTable1StartPos.Name = "btnSetTable1StartPos";
            this.btnSetTable1StartPos.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1StartPos.TabIndex = 1754;
            this.btnSetTable1StartPos.Text = "Set";
            this.btnSetTable1StartPos.UseVisualStyleBackColor = false;
            this.btnSetTable1StartPos.Click += new System.EventHandler(this.btnSetTable1StartPos_Click);
            // 
            // btnMoveTable1StartPos
            // 
            this.btnMoveTable1StartPos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1StartPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1StartPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1StartPos.Location = new System.Drawing.Point(659, 237);
            this.btnMoveTable1StartPos.Name = "btnMoveTable1StartPos";
            this.btnMoveTable1StartPos.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1StartPos.TabIndex = 1753;
            this.btnMoveTable1StartPos.Text = "▷";
            this.btnMoveTable1StartPos.UseVisualStyleBackColor = false;
            this.btnMoveTable1StartPos.Click += new System.EventHandler(this.btnMoveTable1StartPos_Click);
            // 
            // edTable1StartY
            // 
            this.edTable1StartY.BackColor = System.Drawing.Color.White;
            this.edTable1StartY.DataType = YujinTechnology.DataType.Double;
            this.edTable1StartY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1StartY.Frame.CornerRound = 1;
            this.edTable1StartY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1StartY.Hint = null;
            this.edTable1StartY.Location = new System.Drawing.Point(424, 237);
            this.edTable1StartY.Max = 0D;
            this.edTable1StartY.Min = 0D;
            this.edTable1StartY.Name = "edTable1StartY";
            this.edTable1StartY.NewText = "0.000";
            this.edTable1StartY.PrecisionDigits = 3;
            this.edTable1StartY.ShowHint = false;
            this.edTable1StartY.Size = new System.Drawing.Size(95, 29);
            this.edTable1StartY.TabIndex = 1752;
            this.edTable1StartY.Text = "0.000";
            this.edTable1StartY.Value = 0D;
            // 
            // gradientLabel9
            // 
            this.gradientLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel9.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel9.GradientEnable = false;
            this.gradientLabel9.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel9.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel9.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel9.Location = new System.Drawing.Point(226, 237);
            this.gradientLabel9.Name = "gradientLabel9";
            this.gradientLabel9.ShowAccelChar = false;
            this.gradientLabel9.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel9.TabIndex = 1751;
            this.gradientLabel9.Text = "Start Pos";
            this.gradientLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetTable1VisionZFocus
            // 
            this.btnSetTable1VisionZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1VisionZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1VisionZFocus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1VisionZFocus.Location = new System.Drawing.Point(624, 96);
            this.btnSetTable1VisionZFocus.Name = "btnSetTable1VisionZFocus";
            this.btnSetTable1VisionZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1VisionZFocus.TabIndex = 1750;
            this.btnSetTable1VisionZFocus.Text = "Set";
            this.btnSetTable1VisionZFocus.UseVisualStyleBackColor = false;
            this.btnSetTable1VisionZFocus.Click += new System.EventHandler(this.btnSetTable1VisionZFocus_Click);
            // 
            // btnSetTable1LaserZFocus
            // 
            this.btnSetTable1LaserZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable1LaserZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable1LaserZFocus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable1LaserZFocus.Location = new System.Drawing.Point(624, 130);
            this.btnSetTable1LaserZFocus.Name = "btnSetTable1LaserZFocus";
            this.btnSetTable1LaserZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable1LaserZFocus.TabIndex = 1749;
            this.btnSetTable1LaserZFocus.Text = "Set";
            this.btnSetTable1LaserZFocus.UseVisualStyleBackColor = false;
            this.btnSetTable1LaserZFocus.Click += new System.EventHandler(this.btnSetTable1LaserZFocus_Click);
            // 
            // btnMoveTable1VisionZFocus
            // 
            this.btnMoveTable1VisionZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable1VisionZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable1VisionZFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable1VisionZFocus.Location = new System.Drawing.Point(659, 96);
            this.btnMoveTable1VisionZFocus.Name = "btnMoveTable1VisionZFocus";
            this.btnMoveTable1VisionZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable1VisionZFocus.TabIndex = 1748;
            this.btnMoveTable1VisionZFocus.Text = "▷";
            this.btnMoveTable1VisionZFocus.UseVisualStyleBackColor = false;
            this.btnMoveTable1VisionZFocus.Click += new System.EventHandler(this.btnMoveTable1VisionZFocus_Click);
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel4.GradientEnable = false;
            this.gradientLabel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel4.Location = new System.Drawing.Point(226, 96);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.ShowAccelChar = false;
            this.gradientLabel4.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel4.TabIndex = 1746;
            this.gradientLabel4.Text = "Vision Focus";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel5.GradientEnable = false;
            this.gradientLabel5.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel5.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel5.Location = new System.Drawing.Point(226, 130);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.ShowAccelChar = false;
            this.gradientLabel5.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel5.TabIndex = 1747;
            this.gradientLabel5.Text = "Laser Focus";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edTable1VisionZFocus
            // 
            this.edTable1VisionZFocus.BackColor = System.Drawing.Color.White;
            this.edTable1VisionZFocus.DataType = YujinTechnology.DataType.Double;
            this.edTable1VisionZFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable1VisionZFocus.Frame.CornerRound = 1;
            this.edTable1VisionZFocus.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1VisionZFocus.Hint = null;
            this.edTable1VisionZFocus.Location = new System.Drawing.Point(524, 96);
            this.edTable1VisionZFocus.Max = 0D;
            this.edTable1VisionZFocus.Min = 0D;
            this.edTable1VisionZFocus.Name = "edTable1VisionZFocus";
            this.edTable1VisionZFocus.NewText = "0.000";
            this.edTable1VisionZFocus.PrecisionDigits = 3;
            this.edTable1VisionZFocus.ShowHint = false;
            this.edTable1VisionZFocus.Size = new System.Drawing.Size(95, 29);
            this.edTable1VisionZFocus.TabIndex = 1745;
            this.edTable1VisionZFocus.Text = "0.000";
            this.edTable1VisionZFocus.Value = 0D;
            // 
            // edTable1LaserZFocus
            // 
            this.edTable1LaserZFocus.BackColor = System.Drawing.Color.White;
            this.edTable1LaserZFocus.DataType = YujinTechnology.DataType.Double;
            this.edTable1LaserZFocus.Frame.CornerRound = 1;
            this.edTable1LaserZFocus.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable1LaserZFocus.Hint = null;
            this.edTable1LaserZFocus.Location = new System.Drawing.Point(524, 130);
            this.edTable1LaserZFocus.Max = 0D;
            this.edTable1LaserZFocus.Min = 0D;
            this.edTable1LaserZFocus.Name = "edTable1LaserZFocus";
            this.edTable1LaserZFocus.NewText = "0.000";
            this.edTable1LaserZFocus.PrecisionDigits = 3;
            this.edTable1LaserZFocus.ShowHint = false;
            this.edTable1LaserZFocus.Size = new System.Drawing.Size(95, 29);
            this.edTable1LaserZFocus.TabIndex = 1744;
            this.edTable1LaserZFocus.Text = "0.000";
            this.edTable1LaserZFocus.Value = 0D;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage8.Controls.Add(this.gradientLabel68);
            this.tabPage8.Controls.Add(this.edTable2VisionFocusLightValue);
            this.tabPage8.Controls.Add(this.edTable2LaserFocusLightValue);
            this.tabPage8.Controls.Add(this.gradientLabel66);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.gradientLabel54);
            this.tabPage8.Controls.Add(this.gradientLabel55);
            this.tabPage8.Controls.Add(this.gradientLabel56);
            this.tabPage8.Controls.Add(this.keypadEdit3);
            this.tabPage8.Controls.Add(this.keypadEdit12);
            this.tabPage8.Controls.Add(this.keypadEdit8);
            this.tabPage8.Controls.Add(this.keypadEdit9);
            this.tabPage8.Controls.Add(this.keypadEdit10);
            this.tabPage8.Controls.Add(this.keypadEdit11);
            this.tabPage8.Controls.Add(this.gradientLabel48);
            this.tabPage8.Controls.Add(this.gradientLabel49);
            this.tabPage8.Controls.Add(this.gradientLabel50);
            this.tabPage8.Controls.Add(this.gradientLabel51);
            this.tabPage8.Controls.Add(this.gradientLabel52);
            this.tabPage8.Controls.Add(this.gradientLabel53);
            this.tabPage8.Controls.Add(this.gradientLabel47);
            this.tabPage8.Controls.Add(this.edTable2StartX);
            this.tabPage8.Controls.Add(this.btnTable2Start);
            this.tabPage8.Controls.Add(this.edTable2DrawX);
            this.tabPage8.Controls.Add(this.edTable2StepZ);
            this.tabPage8.Controls.Add(this.edTable2PitchZ);
            this.tabPage8.Controls.Add(this.edTable2PitchY);
            this.tabPage8.Controls.Add(this.gradientLabel44);
            this.tabPage8.Controls.Add(this.edTable2StartZ);
            this.tabPage8.Controls.Add(this.gradientLabel45);
            this.tabPage8.Controls.Add(this.btnSetTable2StartPos);
            this.tabPage8.Controls.Add(this.btnMoveTable2StartPos);
            this.tabPage8.Controls.Add(this.edTable2StartY);
            this.tabPage8.Controls.Add(this.btnSetTable2VisionZFocus);
            this.tabPage8.Controls.Add(this.btnSetTable2LaserZFocus);
            this.tabPage8.Controls.Add(this.btnMoveTable2VisionZFocus);
            this.tabPage8.Controls.Add(this.btnMoveTable2LaserZFocus);
            this.tabPage8.Controls.Add(this.edTable2VisionZFocus);
            this.tabPage8.Controls.Add(this.edTable2LaserZFocus);
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(916, 507);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "  Table#2  ";
            // 
            // gradientLabel68
            // 
            this.gradientLabel68.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel68.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel68.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel68.GradientEnable = false;
            this.gradientLabel68.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel68.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel68.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel68.Location = new System.Drawing.Point(740, 63);
            this.gradientLabel68.Name = "gradientLabel68";
            this.gradientLabel68.ShowAccelChar = false;
            this.gradientLabel68.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel68.TabIndex = 1788;
            this.gradientLabel68.Text = "Light Value";
            this.gradientLabel68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable2VisionFocusLightValue
            // 
            this.edTable2VisionFocusLightValue.BackColor = System.Drawing.Color.White;
            this.edTable2VisionFocusLightValue.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2VisionFocusLightValue.Frame.CornerRound = 1;
            this.edTable2VisionFocusLightValue.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2VisionFocusLightValue.Hint = null;
            this.edTable2VisionFocusLightValue.Location = new System.Drawing.Point(739, 96);
            this.edTable2VisionFocusLightValue.Max = 0D;
            this.edTable2VisionFocusLightValue.Min = 0D;
            this.edTable2VisionFocusLightValue.Name = "edTable2VisionFocusLightValue";
            this.edTable2VisionFocusLightValue.NewText = "0.000";
            this.edTable2VisionFocusLightValue.PrecisionDigits = 3;
            this.edTable2VisionFocusLightValue.ShowHint = false;
            this.edTable2VisionFocusLightValue.Size = new System.Drawing.Size(95, 29);
            this.edTable2VisionFocusLightValue.TabIndex = 1787;
            this.edTable2VisionFocusLightValue.Text = "0";
            this.edTable2VisionFocusLightValue.Value = 0D;
            // 
            // edTable2LaserFocusLightValue
            // 
            this.edTable2LaserFocusLightValue.BackColor = System.Drawing.Color.White;
            this.edTable2LaserFocusLightValue.Frame.CornerRound = 1;
            this.edTable2LaserFocusLightValue.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LaserFocusLightValue.Hint = null;
            this.edTable2LaserFocusLightValue.Location = new System.Drawing.Point(739, 130);
            this.edTable2LaserFocusLightValue.Max = 0D;
            this.edTable2LaserFocusLightValue.Min = 0D;
            this.edTable2LaserFocusLightValue.Name = "edTable2LaserFocusLightValue";
            this.edTable2LaserFocusLightValue.NewText = "0.000";
            this.edTable2LaserFocusLightValue.PrecisionDigits = 3;
            this.edTable2LaserFocusLightValue.ShowHint = false;
            this.edTable2LaserFocusLightValue.Size = new System.Drawing.Size(95, 29);
            this.edTable2LaserFocusLightValue.TabIndex = 1786;
            this.edTable2LaserFocusLightValue.Text = "0";
            this.edTable2LaserFocusLightValue.Value = 0D;
            // 
            // gradientLabel66
            // 
            this.gradientLabel66.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel66.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel66.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.gradientLabel66.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.gradientLabel66.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gradientLabel66.ForeColor = System.Drawing.Color.Red;
            this.gradientLabel66.Frame.Visible = false;
            this.gradientLabel66.GradientEnable = false;
            this.gradientLabel66.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel66.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel66.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel66.Location = new System.Drawing.Point(625, 296);
            this.gradientLabel66.Name = "gradientLabel66";
            this.gradientLabel66.ShowAccelChar = false;
            this.gradientLabel66.Size = new System.Drawing.Size(188, 42);
            this.gradientLabel66.TabIndex = 1784;
            this.gradientLabel66.Text = "Z축은 바닥에서 시작하여 \r\nPitch 만큼 위로 올라갑니다.";
            this.gradientLabel66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1783;
            this.label2.Text = "(mm) ";
            // 
            // gradientLabel54
            // 
            this.gradientLabel54.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel54.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel54.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel54.GradientEnable = false;
            this.gradientLabel54.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel54.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel54.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel54.Location = new System.Drawing.Point(324, 63);
            this.gradientLabel54.Name = "gradientLabel54";
            this.gradientLabel54.ShowAccelChar = false;
            this.gradientLabel54.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel54.TabIndex = 1776;
            this.gradientLabel54.Text = "X";
            this.gradientLabel54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel55
            // 
            this.gradientLabel55.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel55.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel55.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel55.GradientEnable = false;
            this.gradientLabel55.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel55.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel55.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel55.Location = new System.Drawing.Point(524, 63);
            this.gradientLabel55.Name = "gradientLabel55";
            this.gradientLabel55.ShowAccelChar = false;
            this.gradientLabel55.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel55.TabIndex = 1775;
            this.gradientLabel55.Text = "Z";
            this.gradientLabel55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel56
            // 
            this.gradientLabel56.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel56.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel56.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel56.GradientEnable = false;
            this.gradientLabel56.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel56.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel56.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel56.Location = new System.Drawing.Point(424, 63);
            this.gradientLabel56.Name = "gradientLabel56";
            this.gradientLabel56.ShowAccelChar = false;
            this.gradientLabel56.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel56.TabIndex = 1774;
            this.gradientLabel56.Text = "Y";
            this.gradientLabel56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keypadEdit3
            // 
            this.keypadEdit3.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit3.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit3.Enabled = false;
            this.keypadEdit3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit3.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit3.Frame.CornerRound = 1;
            this.keypadEdit3.Hint = null;
            this.keypadEdit3.Location = new System.Drawing.Point(424, 336);
            this.keypadEdit3.Max = 0D;
            this.keypadEdit3.Min = 0D;
            this.keypadEdit3.Name = "keypadEdit3";
            this.keypadEdit3.NewText = "0.000";
            this.keypadEdit3.PrecisionDigits = 3;
            this.keypadEdit3.ShowHint = false;
            this.keypadEdit3.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit3.TabIndex = 1773;
            this.keypadEdit3.Text = "0.000";
            this.keypadEdit3.Value = 0D;
            // 
            // keypadEdit12
            // 
            this.keypadEdit12.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit12.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit12.Enabled = false;
            this.keypadEdit12.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit12.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit12.Frame.CornerRound = 1;
            this.keypadEdit12.Hint = null;
            this.keypadEdit12.Location = new System.Drawing.Point(524, 336);
            this.keypadEdit12.Max = 0D;
            this.keypadEdit12.Min = 0D;
            this.keypadEdit12.Name = "keypadEdit12";
            this.keypadEdit12.NewText = "0.000";
            this.keypadEdit12.PrecisionDigits = 3;
            this.keypadEdit12.ShowHint = false;
            this.keypadEdit12.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit12.TabIndex = 1772;
            this.keypadEdit12.Text = "0.000";
            this.keypadEdit12.Value = 0D;
            // 
            // keypadEdit8
            // 
            this.keypadEdit8.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit8.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit8.Enabled = false;
            this.keypadEdit8.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit8.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit8.Frame.CornerRound = 1;
            this.keypadEdit8.Hint = null;
            this.keypadEdit8.Location = new System.Drawing.Point(424, 130);
            this.keypadEdit8.Max = 0D;
            this.keypadEdit8.Min = 0D;
            this.keypadEdit8.Name = "keypadEdit8";
            this.keypadEdit8.NewText = "0.000";
            this.keypadEdit8.PrecisionDigits = 3;
            this.keypadEdit8.ShowHint = false;
            this.keypadEdit8.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit8.TabIndex = 1771;
            this.keypadEdit8.Text = "0.000";
            this.keypadEdit8.Value = 0D;
            // 
            // keypadEdit9
            // 
            this.keypadEdit9.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit9.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit9.Enabled = false;
            this.keypadEdit9.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit9.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit9.Frame.CornerRound = 1;
            this.keypadEdit9.Hint = null;
            this.keypadEdit9.Location = new System.Drawing.Point(424, 96);
            this.keypadEdit9.Max = 0D;
            this.keypadEdit9.Min = 0D;
            this.keypadEdit9.Name = "keypadEdit9";
            this.keypadEdit9.NewText = "0.000";
            this.keypadEdit9.PrecisionDigits = 3;
            this.keypadEdit9.ShowHint = false;
            this.keypadEdit9.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit9.TabIndex = 1770;
            this.keypadEdit9.Text = "0.000";
            this.keypadEdit9.Value = 0D;
            // 
            // keypadEdit10
            // 
            this.keypadEdit10.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit10.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit10.Enabled = false;
            this.keypadEdit10.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit10.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit10.Frame.CornerRound = 1;
            this.keypadEdit10.Hint = null;
            this.keypadEdit10.Location = new System.Drawing.Point(324, 130);
            this.keypadEdit10.Max = 0D;
            this.keypadEdit10.Min = 0D;
            this.keypadEdit10.Name = "keypadEdit10";
            this.keypadEdit10.NewText = "0.000";
            this.keypadEdit10.PrecisionDigits = 3;
            this.keypadEdit10.ShowHint = false;
            this.keypadEdit10.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit10.TabIndex = 1769;
            this.keypadEdit10.Text = "0.000";
            this.keypadEdit10.Value = 0D;
            // 
            // keypadEdit11
            // 
            this.keypadEdit11.BackColor = System.Drawing.Color.LightGray;
            this.keypadEdit11.DataType = YujinTechnology.DataType.Double;
            this.keypadEdit11.Enabled = false;
            this.keypadEdit11.Font = new System.Drawing.Font("Tahoma", 11F);
            this.keypadEdit11.ForeColor = System.Drawing.Color.Gray;
            this.keypadEdit11.Frame.CornerRound = 1;
            this.keypadEdit11.Hint = null;
            this.keypadEdit11.Location = new System.Drawing.Point(324, 96);
            this.keypadEdit11.Max = 0D;
            this.keypadEdit11.Min = 0D;
            this.keypadEdit11.Name = "keypadEdit11";
            this.keypadEdit11.NewText = "0.000";
            this.keypadEdit11.PrecisionDigits = 3;
            this.keypadEdit11.ShowHint = false;
            this.keypadEdit11.Size = new System.Drawing.Size(95, 29);
            this.keypadEdit11.TabIndex = 1768;
            this.keypadEdit11.Text = "0.000";
            this.keypadEdit11.Value = 0D;
            // 
            // gradientLabel48
            // 
            this.gradientLabel48.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel48.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel48.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel48.GradientEnable = false;
            this.gradientLabel48.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel48.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel48.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel48.Location = new System.Drawing.Point(226, 336);
            this.gradientLabel48.Name = "gradientLabel48";
            this.gradientLabel48.ShowAccelChar = false;
            this.gradientLabel48.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel48.TabIndex = 1767;
            this.gradientLabel48.Text = "Draw Length";
            this.gradientLabel48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel49
            // 
            this.gradientLabel49.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel49.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel49.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel49.GradientEnable = false;
            this.gradientLabel49.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel49.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel49.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel49.Location = new System.Drawing.Point(226, 303);
            this.gradientLabel49.Name = "gradientLabel49";
            this.gradientLabel49.ShowAccelChar = false;
            this.gradientLabel49.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel49.TabIndex = 1766;
            this.gradientLabel49.Text = "Step";
            this.gradientLabel49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel50
            // 
            this.gradientLabel50.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel50.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel50.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel50.GradientEnable = false;
            this.gradientLabel50.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel50.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel50.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel50.Location = new System.Drawing.Point(226, 270);
            this.gradientLabel50.Name = "gradientLabel50";
            this.gradientLabel50.ShowAccelChar = false;
            this.gradientLabel50.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel50.TabIndex = 1765;
            this.gradientLabel50.Text = "Pitch";
            this.gradientLabel50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel51
            // 
            this.gradientLabel51.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel51.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel51.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel51.GradientEnable = false;
            this.gradientLabel51.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel51.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel51.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel51.Location = new System.Drawing.Point(226, 237);
            this.gradientLabel51.Name = "gradientLabel51";
            this.gradientLabel51.ShowAccelChar = false;
            this.gradientLabel51.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel51.TabIndex = 1764;
            this.gradientLabel51.Text = "Start Pos";
            this.gradientLabel51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel52
            // 
            this.gradientLabel52.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel52.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel52.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel52.GradientEnable = false;
            this.gradientLabel52.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel52.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel52.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel52.Location = new System.Drawing.Point(226, 96);
            this.gradientLabel52.Name = "gradientLabel52";
            this.gradientLabel52.ShowAccelChar = false;
            this.gradientLabel52.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel52.TabIndex = 1762;
            this.gradientLabel52.Text = "Vision Focus";
            this.gradientLabel52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel53
            // 
            this.gradientLabel53.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel53.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel53.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel53.GradientEnable = false;
            this.gradientLabel53.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel53.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel53.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel53.Location = new System.Drawing.Point(226, 130);
            this.gradientLabel53.Name = "gradientLabel53";
            this.gradientLabel53.ShowAccelChar = false;
            this.gradientLabel53.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel53.TabIndex = 1763;
            this.gradientLabel53.Text = "Laser Focus";
            this.gradientLabel53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel47
            // 
            this.gradientLabel47.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel47.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel47.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel47.GradientEnable = false;
            this.gradientLabel47.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel47.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel47.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel47.Location = new System.Drawing.Point(324, 203);
            this.gradientLabel47.Name = "gradientLabel47";
            this.gradientLabel47.ShowAccelChar = false;
            this.gradientLabel47.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel47.TabIndex = 1761;
            this.gradientLabel47.Text = "X";
            this.gradientLabel47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable2StartX
            // 
            this.edTable2StartX.BackColor = System.Drawing.Color.White;
            this.edTable2StartX.DataType = YujinTechnology.DataType.Double;
            this.edTable2StartX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2StartX.Frame.CornerRound = 1;
            this.edTable2StartX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2StartX.Hint = null;
            this.edTable2StartX.Location = new System.Drawing.Point(324, 237);
            this.edTable2StartX.Max = 0D;
            this.edTable2StartX.Min = 0D;
            this.edTable2StartX.Name = "edTable2StartX";
            this.edTable2StartX.NewText = "0.000";
            this.edTable2StartX.PrecisionDigits = 3;
            this.edTable2StartX.ShowHint = false;
            this.edTable2StartX.Size = new System.Drawing.Size(95, 29);
            this.edTable2StartX.TabIndex = 1760;
            this.edTable2StartX.Text = "0.000";
            this.edTable2StartX.Value = 0D;
            // 
            // btnTable2Start
            // 
            this.btnTable2Start.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnTable2Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnTable2Start.Location = new System.Drawing.Point(424, 402);
            this.btnTable2Start.Name = "btnTable2Start";
            this.btnTable2Start.Size = new System.Drawing.Size(95, 42);
            this.btnTable2Start.TabIndex = 1759;
            this.btnTable2Start.Text = "Mark Start";
            this.btnTable2Start.UseVisualStyleBackColor = false;
            this.btnTable2Start.Click += new System.EventHandler(this.btnTable2Start_Click);
            // 
            // edTable2DrawX
            // 
            this.edTable2DrawX.BackColor = System.Drawing.Color.White;
            this.edTable2DrawX.DataType = YujinTechnology.DataType.Double;
            this.edTable2DrawX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2DrawX.Frame.CornerRound = 1;
            this.edTable2DrawX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2DrawX.Hint = null;
            this.edTable2DrawX.Location = new System.Drawing.Point(324, 336);
            this.edTable2DrawX.Max = 0D;
            this.edTable2DrawX.Min = 0D;
            this.edTable2DrawX.Name = "edTable2DrawX";
            this.edTable2DrawX.NewText = "0.000";
            this.edTable2DrawX.PrecisionDigits = 3;
            this.edTable2DrawX.ShowHint = false;
            this.edTable2DrawX.Size = new System.Drawing.Size(95, 29);
            this.edTable2DrawX.TabIndex = 1758;
            this.edTable2DrawX.Text = "0.000";
            this.edTable2DrawX.Value = 0D;
            // 
            // edTable2StepZ
            // 
            this.edTable2StepZ.BackColor = System.Drawing.Color.White;
            this.edTable2StepZ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2StepZ.Frame.CornerRound = 1;
            this.edTable2StepZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2StepZ.Hint = null;
            this.edTable2StepZ.Location = new System.Drawing.Point(524, 303);
            this.edTable2StepZ.Max = 0D;
            this.edTable2StepZ.Min = 0D;
            this.edTable2StepZ.Name = "edTable2StepZ";
            this.edTable2StepZ.NewText = "0.000";
            this.edTable2StepZ.PrecisionDigits = 3;
            this.edTable2StepZ.ShowHint = false;
            this.edTable2StepZ.Size = new System.Drawing.Size(95, 29);
            this.edTable2StepZ.TabIndex = 1757;
            this.edTable2StepZ.Text = "0";
            this.edTable2StepZ.Value = 0D;
            // 
            // edTable2PitchZ
            // 
            this.edTable2PitchZ.BackColor = System.Drawing.Color.White;
            this.edTable2PitchZ.DataType = YujinTechnology.DataType.Double;
            this.edTable2PitchZ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2PitchZ.Frame.CornerRound = 1;
            this.edTable2PitchZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2PitchZ.Hint = null;
            this.edTable2PitchZ.Location = new System.Drawing.Point(524, 270);
            this.edTable2PitchZ.Max = 0D;
            this.edTable2PitchZ.Min = 0D;
            this.edTable2PitchZ.Name = "edTable2PitchZ";
            this.edTable2PitchZ.NewText = "0.000";
            this.edTable2PitchZ.PrecisionDigits = 3;
            this.edTable2PitchZ.ShowHint = false;
            this.edTable2PitchZ.Size = new System.Drawing.Size(95, 29);
            this.edTable2PitchZ.TabIndex = 1756;
            this.edTable2PitchZ.Text = "0.000";
            this.edTable2PitchZ.Value = 0D;
            // 
            // edTable2PitchY
            // 
            this.edTable2PitchY.BackColor = System.Drawing.Color.White;
            this.edTable2PitchY.DataType = YujinTechnology.DataType.Double;
            this.edTable2PitchY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2PitchY.Frame.CornerRound = 1;
            this.edTable2PitchY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2PitchY.Hint = null;
            this.edTable2PitchY.Location = new System.Drawing.Point(424, 270);
            this.edTable2PitchY.Max = 0D;
            this.edTable2PitchY.Min = 0D;
            this.edTable2PitchY.Name = "edTable2PitchY";
            this.edTable2PitchY.NewText = "0.000";
            this.edTable2PitchY.PrecisionDigits = 3;
            this.edTable2PitchY.ShowHint = false;
            this.edTable2PitchY.Size = new System.Drawing.Size(95, 29);
            this.edTable2PitchY.TabIndex = 1755;
            this.edTable2PitchY.Text = "0.000";
            this.edTable2PitchY.Value = 0D;
            // 
            // gradientLabel44
            // 
            this.gradientLabel44.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel44.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel44.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel44.GradientEnable = false;
            this.gradientLabel44.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel44.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel44.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel44.Location = new System.Drawing.Point(524, 203);
            this.gradientLabel44.Name = "gradientLabel44";
            this.gradientLabel44.ShowAccelChar = false;
            this.gradientLabel44.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel44.TabIndex = 1754;
            this.gradientLabel44.Text = "Z";
            this.gradientLabel44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edTable2StartZ
            // 
            this.edTable2StartZ.BackColor = System.Drawing.Color.White;
            this.edTable2StartZ.DataType = YujinTechnology.DataType.Double;
            this.edTable2StartZ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2StartZ.Frame.CornerRound = 1;
            this.edTable2StartZ.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2StartZ.Hint = null;
            this.edTable2StartZ.Location = new System.Drawing.Point(524, 237);
            this.edTable2StartZ.Max = 0D;
            this.edTable2StartZ.Min = 0D;
            this.edTable2StartZ.Name = "edTable2StartZ";
            this.edTable2StartZ.NewText = "0.000";
            this.edTable2StartZ.PrecisionDigits = 3;
            this.edTable2StartZ.ShowHint = false;
            this.edTable2StartZ.Size = new System.Drawing.Size(95, 29);
            this.edTable2StartZ.TabIndex = 1753;
            this.edTable2StartZ.Text = "0.000";
            this.edTable2StartZ.Value = 0D;
            // 
            // gradientLabel45
            // 
            this.gradientLabel45.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel45.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel45.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel45.GradientEnable = false;
            this.gradientLabel45.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel45.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel45.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel45.Location = new System.Drawing.Point(424, 203);
            this.gradientLabel45.Name = "gradientLabel45";
            this.gradientLabel45.ShowAccelChar = false;
            this.gradientLabel45.Size = new System.Drawing.Size(94, 29);
            this.gradientLabel45.TabIndex = 1752;
            this.gradientLabel45.Text = "Y";
            this.gradientLabel45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetTable2StartPos
            // 
            this.btnSetTable2StartPos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2StartPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2StartPos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2StartPos.Location = new System.Drawing.Point(624, 237);
            this.btnSetTable2StartPos.Name = "btnSetTable2StartPos";
            this.btnSetTable2StartPos.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2StartPos.TabIndex = 1751;
            this.btnSetTable2StartPos.Text = "Set";
            this.btnSetTable2StartPos.UseVisualStyleBackColor = false;
            this.btnSetTable2StartPos.Click += new System.EventHandler(this.btnSetTable2StartPos_Click);
            // 
            // btnMoveTable2StartPos
            // 
            this.btnMoveTable2StartPos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2StartPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2StartPos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2StartPos.Location = new System.Drawing.Point(659, 237);
            this.btnMoveTable2StartPos.Name = "btnMoveTable2StartPos";
            this.btnMoveTable2StartPos.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2StartPos.TabIndex = 1750;
            this.btnMoveTable2StartPos.Text = "▷";
            this.btnMoveTable2StartPos.UseVisualStyleBackColor = false;
            this.btnMoveTable2StartPos.Click += new System.EventHandler(this.btnMoveTable2StartPos_Click);
            // 
            // edTable2StartY
            // 
            this.edTable2StartY.BackColor = System.Drawing.Color.White;
            this.edTable2StartY.DataType = YujinTechnology.DataType.Double;
            this.edTable2StartY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2StartY.Frame.CornerRound = 1;
            this.edTable2StartY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2StartY.Hint = null;
            this.edTable2StartY.Location = new System.Drawing.Point(424, 237);
            this.edTable2StartY.Max = 0D;
            this.edTable2StartY.Min = 0D;
            this.edTable2StartY.Name = "edTable2StartY";
            this.edTable2StartY.NewText = "0.000";
            this.edTable2StartY.PrecisionDigits = 3;
            this.edTable2StartY.ShowHint = false;
            this.edTable2StartY.Size = new System.Drawing.Size(95, 29);
            this.edTable2StartY.TabIndex = 1749;
            this.edTable2StartY.Text = "0.000";
            this.edTable2StartY.Value = 0D;
            // 
            // btnSetTable2VisionZFocus
            // 
            this.btnSetTable2VisionZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2VisionZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2VisionZFocus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2VisionZFocus.Location = new System.Drawing.Point(624, 96);
            this.btnSetTable2VisionZFocus.Name = "btnSetTable2VisionZFocus";
            this.btnSetTable2VisionZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2VisionZFocus.TabIndex = 1748;
            this.btnSetTable2VisionZFocus.Text = "Set";
            this.btnSetTable2VisionZFocus.UseVisualStyleBackColor = false;
            this.btnSetTable2VisionZFocus.Click += new System.EventHandler(this.btnSetTable2VisionZFocus_Click);
            // 
            // btnSetTable2LaserZFocus
            // 
            this.btnSetTable2LaserZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetTable2LaserZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetTable2LaserZFocus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSetTable2LaserZFocus.Location = new System.Drawing.Point(624, 130);
            this.btnSetTable2LaserZFocus.Name = "btnSetTable2LaserZFocus";
            this.btnSetTable2LaserZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnSetTable2LaserZFocus.TabIndex = 1747;
            this.btnSetTable2LaserZFocus.Text = "Set";
            this.btnSetTable2LaserZFocus.UseVisualStyleBackColor = false;
            this.btnSetTable2LaserZFocus.Click += new System.EventHandler(this.btnSetTable2LaserZFocus_Click);
            // 
            // btnMoveTable2VisionZFocus
            // 
            this.btnMoveTable2VisionZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2VisionZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2VisionZFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2VisionZFocus.Location = new System.Drawing.Point(659, 96);
            this.btnMoveTable2VisionZFocus.Name = "btnMoveTable2VisionZFocus";
            this.btnMoveTable2VisionZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2VisionZFocus.TabIndex = 1746;
            this.btnMoveTable2VisionZFocus.Text = "▷";
            this.btnMoveTable2VisionZFocus.UseVisualStyleBackColor = false;
            this.btnMoveTable2VisionZFocus.Click += new System.EventHandler(this.btnMoveTable2VisionZFocus_Click);
            // 
            // btnMoveTable2LaserZFocus
            // 
            this.btnMoveTable2LaserZFocus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveTable2LaserZFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveTable2LaserZFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMoveTable2LaserZFocus.Location = new System.Drawing.Point(659, 130);
            this.btnMoveTable2LaserZFocus.Name = "btnMoveTable2LaserZFocus";
            this.btnMoveTable2LaserZFocus.Size = new System.Drawing.Size(32, 29);
            this.btnMoveTable2LaserZFocus.TabIndex = 1745;
            this.btnMoveTable2LaserZFocus.Text = "▷";
            this.btnMoveTable2LaserZFocus.UseVisualStyleBackColor = false;
            this.btnMoveTable2LaserZFocus.Click += new System.EventHandler(this.btnMoveTable2LaserZFocus_Click);
            // 
            // edTable2VisionZFocus
            // 
            this.edTable2VisionZFocus.BackColor = System.Drawing.Color.White;
            this.edTable2VisionZFocus.DataType = YujinTechnology.DataType.Double;
            this.edTable2VisionZFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTable2VisionZFocus.Frame.CornerRound = 1;
            this.edTable2VisionZFocus.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2VisionZFocus.Hint = null;
            this.edTable2VisionZFocus.Location = new System.Drawing.Point(524, 96);
            this.edTable2VisionZFocus.Max = 0D;
            this.edTable2VisionZFocus.Min = 0D;
            this.edTable2VisionZFocus.Name = "edTable2VisionZFocus";
            this.edTable2VisionZFocus.NewText = "0.000";
            this.edTable2VisionZFocus.PrecisionDigits = 3;
            this.edTable2VisionZFocus.ShowHint = false;
            this.edTable2VisionZFocus.Size = new System.Drawing.Size(95, 29);
            this.edTable2VisionZFocus.TabIndex = 1744;
            this.edTable2VisionZFocus.Text = "0.000";
            this.edTable2VisionZFocus.Value = 0D;
            // 
            // edTable2LaserZFocus
            // 
            this.edTable2LaserZFocus.BackColor = System.Drawing.Color.White;
            this.edTable2LaserZFocus.DataType = YujinTechnology.DataType.Double;
            this.edTable2LaserZFocus.Frame.CornerRound = 1;
            this.edTable2LaserZFocus.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTable2LaserZFocus.Hint = null;
            this.edTable2LaserZFocus.Location = new System.Drawing.Point(524, 130);
            this.edTable2LaserZFocus.Max = 0D;
            this.edTable2LaserZFocus.Min = 0D;
            this.edTable2LaserZFocus.Name = "edTable2LaserZFocus";
            this.edTable2LaserZFocus.NewText = "0.000";
            this.edTable2LaserZFocus.PrecisionDigits = 3;
            this.edTable2LaserZFocus.ShowHint = false;
            this.edTable2LaserZFocus.Size = new System.Drawing.Size(95, 29);
            this.edTable2LaserZFocus.TabIndex = 1743;
            this.edTable2LaserZFocus.Text = "0.000";
            this.edTable2LaserZFocus.Value = 0D;
            // 
            // btnAllSave
            // 
            this.btnAllSave.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAllSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAllSave.Location = new System.Drawing.Point(1213, 771);
            this.btnAllSave.Name = "btnAllSave";
            this.btnAllSave.Size = new System.Drawing.Size(132, 57);
            this.btnAllSave.TabIndex = 1562;
            this.btnAllSave.Text = "Save";
            this.btnAllSave.UseVisualStyleBackColor = false;
            this.btnAllSave.Click += new System.EventHandler(this.btnAllSave_Click);
            // 
            // panConfigCommon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panClient);
            this.Name = "panConfigCommon";
            this.Size = new System.Drawing.Size(1373, 849);
            this.Load += new System.EventHandler(this.panConfigCommon_Load);
            this.panClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private sjPanel panClient;
        private YujinTechnology.BitBtn btnAllSave;
        public YujinTechnology.PropSaver propSaver1;
        private YujinTechnology.DataServer DataServer;
        private YujinTechnology.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private YujinTechnology.KeypadEdit edPowerMeterZPos;
        private YujinTechnology.KeypadEdit edPowerMeterXPos;
        private YujinTechnology.GradientLabel gradLabel28;
        private YujinTechnology.GradientLabel gradLabel30;
        private YujinTechnology.SunnyLine sunnyLine3;
        private YujinTechnology.GradientLabel gradLabel39;
        private YujinTechnology.GradientLabel gradLabel15;
        private YujinTechnology.GradientLabel gradientLabel3;
        private YujinTechnology.GradientLabel gradientLabel2;
        private YujinTechnology.GradientLabel gradientLabel1;
        private YujinTechnology.GradientLabel gradLabel7;
        private YujinTechnology.GradientLabel gradLabel6;
        private YujinTechnology.BitBtn btnSet;
        private YujinTechnology.GradientLabel gradientLabel14;
        private YujinTechnology.GradientLabel gradientLabel15;
        private YujinTechnology.GradientLabel gradientLabel16;
        private YujinTechnology.KeypadEdit edHomeOffsetPosZ;
        private YujinTechnology.KeypadEdit edHomeOffsetPosY1;
        private YujinTechnology.KeypadEdit edHomeOffsetPosY2;
        private YujinTechnology.KeypadEdit edHomeOffsetPosX;
        private YujinTechnology.GradientLabel gradientLabel17;
        private YujinTechnology.GradientLabel gradientLabel18;
        private YujinTechnology.SunnyLine sunnyLine1;
        private YujinTechnology.SunnyLine uiLine5;
        private System.Windows.Forms.TabPage tabPage4;
        private YujinTechnology.SunnyLine uiLine2;
        private YujinTechnology.GradientLabel gradLabel3;
        private YujinTechnology.SunnyLine uiLine3;
        private YujinTechnology.GradientLabel gradLabel38;
        private YujinTechnology.GradientLabel gradLabel37;
        private YujinTechnology.KeypadEdit edTableSizeX;
        private YujinTechnology.KeypadEdit edTableSizeY;
        private YujinTechnology.GradientLabel gradLabel5;
        private YujinTechnology.GradientLabel gradLabel2;
        private YujinTechnology.SunnyLine uiLine1;
        private System.Windows.Forms.TabPage tabPage3;
        private YujinTechnology.GradientLabel gradientLabel19;
        private YujinTechnology.GradientLabel gradientLabel21;
        private YujinTechnology.GradientLabel gradientLabel36;

        private YujinTechnology.GradientLabel gradientLabel32;
        private YujinTechnology.GradientLabel gradientLabel20;
        private YujinTechnology.GradientLabel gradientLabel22;
        private YujinTechnology.GradientLabel gradientLabel24;
        private YujinTechnology.KeypadEdit edTable2RightBottomYPos;
        private YujinTechnology.KeypadEdit edTable2RightBottomXPos;
        private YujinTechnology.KeypadEdit edTable1RightBottomYPos;
        private YujinTechnology.KeypadEdit edTable1RightBottomXPos;
        private YujinTechnology.KeypadEdit edTable2CenterYPos;
        private YujinTechnology.KeypadEdit edTable2CenterXPos;
        private YujinTechnology.KeypadEdit edTable1CenterYPos;
        private YujinTechnology.KeypadEdit edTable1CenterXPos;
        private YujinTechnology.KeypadEdit edTable2RightTopYPos;
        private YujinTechnology.KeypadEdit edTable2RightTopXPos;
        private YujinTechnology.KeypadEdit edTable1RightTopYPos;
        private YujinTechnology.KeypadEdit edTable1RightTopXPos;
        private YujinTechnology.KeypadEdit edTable2LeftTopYPos;
        private YujinTechnology.KeypadEdit edTable2LeftTopXPos;
        private YujinTechnology.KeypadEdit edTable1LeftTopYPos;
        private YujinTechnology.KeypadEdit edTable1LeftTopXPos;
        private YujinTechnology.KeypadEdit edTable2LeftBottomYPos;
        private YujinTechnology.KeypadEdit edTable2LeftBottomXPos;
        private YujinTechnology.KeypadEdit edTable1LeftBottomYPos;
        private YujinTechnology.KeypadEdit edTable1LeftBottomXPos;
        private YujinTechnology.GradientLabel gradientLabel28;
        private YujinTechnology.GradientLabel gradientLabel30;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private YujinTechnology.BitBtn btnMoveTable2Pos5;
        private YujinTechnology.BitBtn btnMoveTable2Pos4;
        private YujinTechnology.BitBtn btnMoveTable2Pos3;
        private YujinTechnology.BitBtn btnMoveTable2Pos2;
        private YujinTechnology.BitBtn btnMoveTable2Pos1;
        private YujinTechnology.BitBtn btnSetTable2Pos5;
        private YujinTechnology.BitBtn btnSetTable2Pos4;
        private YujinTechnology.BitBtn btnSetTable2Pos3;
        private YujinTechnology.BitBtn btnSetTable2Pos2;
        private YujinTechnology.BitBtn btnSetTable2Pos1;
        private YujinTechnology.BitBtn btnMoveTable1Pos5;
        private YujinTechnology.BitBtn btnMoveTable1Pos4;
        private YujinTechnology.BitBtn btnMoveTable1Pos3;
        private YujinTechnology.BitBtn btnMoveTable1Pos2;
        private YujinTechnology.BitBtn btnMoveTable1Pos1;
        private YujinTechnology.BitBtn btnSetTable1Pos5;
        private YujinTechnology.BitBtn btnSetTable1Pos4;
        private YujinTechnology.BitBtn btnSetTable1Pos3;
        private YujinTechnology.BitBtn btnSetTable1Pos2;
        private YujinTechnology.BitBtn btnSetTable1Pos1;
        private YujinTechnology.GradientLabel gradientLabel23;
        private System.Windows.Forms.TabPage tabPage5;
        private YujinTechnology.GradientLabel gradientLabel11;
        private YujinTechnology.GradientLabel gradientLabel12;
        private YujinTechnology.GradientLabel gradientLabel13;
        public YujinTechnology.NumberEdit edTable1LoadingPosX;
        public YujinTechnology.NumberEdit edTable1LoadingPosY;
        private System.Windows.Forms.GroupBox groupBox6;
        private YujinTechnology.LEDLabel ledTable1Center;
        private YujinTechnology.LEDLabel ledTable1RightBottom;
        private YujinTechnology.LEDLabel ledTable1RightTop;
        private YujinTechnology.LEDLabel ledTable1LeftBottom;
        private YujinTechnology.LEDLabel ledTable1LeftTop;
        private YujinTechnology.GradientLabel gradientLabel25;
        private YujinTechnology.SunnyLine sunnyLine2;
        private YujinTechnology.GradientLabel gradientLabel27;
        private YujinTechnology.SunnyLine sunnyLine5;
        private YujinTechnology.GradientLabel gradientLabel26;
        private YujinTechnology.KeypadEdit edAccelerationG;
        private YujinTechnology.KeypadEdit edTable1VacuumDelay;
        private YujinTechnology.GradientLabel gradientLabel33;
        public YujinTechnology.ComboBox cbTable2UseVacuumCount;
        private YujinTechnology.KeypadEdit edTable2VacuumDelay;
        private YujinTechnology.GradientLabel gradientLabel34;
        public YujinTechnology.ComboBox cbTable1UseVacuumCount;
        private YujinTechnology.BitBtn btnCancel;
        private YujinTechnology.GradientLabel gradientLabel10;
        private YujinTechnology.GradientLabel gradientLabel35;
        private YujinTechnology.GradientLabel gradientLabel37;
        public YujinTechnology.NumberEdit edTable2LoadingPosX;
        public YujinTechnology.NumberEdit edTable2LoadingPosY;
        private System.Windows.Forms.GroupBox groupBox3;
        private YujinTechnology.LEDLabel ledTable2Center;
        private YujinTechnology.LEDLabel ledTable2RightBottom;
        private YujinTechnology.LEDLabel ledTable2RightTop;
        private YujinTechnology.LEDLabel ledTable2LeftBottom;
        private YujinTechnology.LEDLabel ledTable2LeftTop;
        private YujinTechnology.ComboBox cbTable2LoadDir;
        private YujinTechnology.ComboBox cbTable1LoadDir;
        private YujinTechnology.LEDButton btnMeasure;
        private System.Windows.Forms.Timer tmr_SearchOffset;
        private YujinTechnology.MultiLanguage multiLanguage1;
        private YujinTechnology.GradientLabel gradientLabel38;
        private YujinTechnology.GradientLabel gradientLabel39;
        private YujinTechnology.GradientLabel gradientLabel7;
        private YujinTechnology.GradientLabel gradientLabel6;
        private YujinTechnology.KeypadEdit edTable2MarkCenterY;
        private YujinTechnology.KeypadEdit edTable2MarkCenterX;
        private YujinTechnology.BitBtn btnMove;
        private YujinTechnology.GradientLabel gradientLabel29;
        private YujinTechnology.KeypadEdit edTable2YOffset;
        private YujinTechnology.KeypadEdit edTable2XOffset;
        private YujinTechnology.LEDButton btnMark;
        public YujinTechnology.KeypadEdit edTable2NozzleYOffset;
        public YujinTechnology.KeypadEdit edTable2NozzleXOffset;
        private YujinTechnology.BitBtn btnMoveMeasurePos;
        private YujinTechnology.GradientLabel gradientLabel8;
        private YujinTechnology.BitBtn btnSetMeasurePos;
        private System.Windows.Forms.TabPage tabPage6;
        private YujinTechnology.Thread AutoThread;
        private YujinTechnology.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private YujinTechnology.BitBtn btnMoveTable1LaserZFocus;
        private YujinTechnology.KeypadEdit keypadEdit2;
        private YujinTechnology.KeypadEdit keypadEdit1;
        private YujinTechnology.KeypadEdit keypadEdit6;
        private YujinTechnology.KeypadEdit keypadEdit7;
        private YujinTechnology.KeypadEdit keypadEdit5;
        private YujinTechnology.KeypadEdit keypadEdit4;
        private YujinTechnology.GradientLabel gradientLabel46;
        private YujinTechnology.KeypadEdit edTable1StartX;
        private YujinTechnology.BitBtn btnTable1Start;
        private YujinTechnology.KeypadEdit edTable1DrawX;
        private YujinTechnology.GradientLabel gradientLabel43;
        private YujinTechnology.KeypadEdit edTable1StepZ;
        private YujinTechnology.GradientLabel gradientLabel42;
        private YujinTechnology.KeypadEdit edTable1PitchZ;
        private YujinTechnology.KeypadEdit edTable1PitchY;
        private YujinTechnology.GradientLabel gradientLabel41;
        private YujinTechnology.GradientLabel gradientLabel40;
        private YujinTechnology.KeypadEdit edTable1StartZ;
        private YujinTechnology.GradientLabel gradientLabel31;
        private YujinTechnology.BitBtn btnSetTable1StartPos;
        private YujinTechnology.BitBtn btnMoveTable1StartPos;
        private YujinTechnology.KeypadEdit edTable1StartY;
        private YujinTechnology.GradientLabel gradientLabel9;
        private YujinTechnology.BitBtn btnSetTable1VisionZFocus;
        private YujinTechnology.BitBtn btnSetTable1LaserZFocus;
        private YujinTechnology.BitBtn btnMoveTable1VisionZFocus;
        private YujinTechnology.GradientLabel gradientLabel4;
        private YujinTechnology.GradientLabel gradientLabel5;
        private YujinTechnology.KeypadEdit keypadEdit3;
        private YujinTechnology.KeypadEdit keypadEdit12;
        private YujinTechnology.KeypadEdit keypadEdit8;
        private YujinTechnology.KeypadEdit keypadEdit9;
        private YujinTechnology.KeypadEdit keypadEdit10;
        private YujinTechnology.KeypadEdit keypadEdit11;
        private YujinTechnology.GradientLabel gradientLabel48;
        private YujinTechnology.GradientLabel gradientLabel49;
        private YujinTechnology.GradientLabel gradientLabel50;
        private YujinTechnology.GradientLabel gradientLabel51;
        private YujinTechnology.GradientLabel gradientLabel52;
        private YujinTechnology.GradientLabel gradientLabel53;
        private YujinTechnology.GradientLabel gradientLabel47;
        private YujinTechnology.KeypadEdit edTable2StartX;
        private YujinTechnology.BitBtn btnTable2Start;
        private YujinTechnology.KeypadEdit edTable2DrawX;
        private YujinTechnology.KeypadEdit edTable2StepZ;
        private YujinTechnology.KeypadEdit edTable2PitchZ;
        private YujinTechnology.KeypadEdit edTable2PitchY;
        private YujinTechnology.GradientLabel gradientLabel44;
        private YujinTechnology.KeypadEdit edTable2StartZ;
        private YujinTechnology.GradientLabel gradientLabel45;
        private YujinTechnology.BitBtn btnSetTable2StartPos;
        private YujinTechnology.BitBtn btnMoveTable2StartPos;
        private YujinTechnology.KeypadEdit edTable2StartY;
        private YujinTechnology.BitBtn btnSetTable2VisionZFocus;
        private YujinTechnology.BitBtn btnSetTable2LaserZFocus;
        private YujinTechnology.BitBtn btnMoveTable2VisionZFocus;
        private YujinTechnology.BitBtn btnMoveTable2LaserZFocus;
        private YujinTechnology.GradientLabel gradientLabel57;
        private YujinTechnology.GradientLabel gradientLabel58;
        private YujinTechnology.GradientLabel gradientLabel59;
        private YujinTechnology.GradientLabel gradientLabel54;
        private YujinTechnology.GradientLabel gradientLabel55;
        private YujinTechnology.GradientLabel gradientLabel56;
        private YujinTechnology.GradientLabel gradientLabel60;
        private YujinTechnology.GradientLabel gradientLabel61;
        private YujinTechnology.SunnyLine uiLine17;
        public YujinTechnology.KeypadEdit edMode0Period;
        public YujinTechnology.KeypadEdit edMode0PulseWidth;
        private YujinTechnology.KeypadEdit edAutoRunTA;
        private YujinTechnology.GradientLabel gradientLabel64;
        private YujinTechnology.GradientLabel gradientLabel65;
        private YujinTechnology.KeypadEdit edJumpTA;
        private YujinTechnology.KeypadEdit edArcTA;
        private YujinTechnology.KeypadEdit edLineTA;
        private YujinTechnology.GradientLabel gradLabel52;
        private YujinTechnology.GradientLabel gradLabel50;
        private YujinTechnology.GradientLabel gradLabel22;
        private YujinTechnology.KeypadEdit edArcSpeed;
        private YujinTechnology.KeypadEdit edLineSpeed;
        private YujinTechnology.GradientLabel gradLabel51;
        private YujinTechnology.GradientLabel gradLabel35;
        private YujinTechnology.GradientLabel gradLabel29;
        private System.Windows.Forms.Label label1;
        private YujinTechnology.GradientLabel gradientLabel62;
        private YujinTechnology.GradientLabel gradientLabel63;
        public YujinTechnology.KeypadEdit edAutoRunSpeedStage;
        public YujinTechnology.KeypadEdit edAutoRunSpeedZ;
        private YujinTechnology.BitBtn btnSetLoadPos;
        private YujinTechnology.BitBtn btnMoveLoadPos;
        public YujinTechnology.KeypadEdit edLoadPosZ;
        public YujinTechnology.KeypadEdit edLoadPosY1;
        public YujinTechnology.KeypadEdit edLoadPosY2;
        public YujinTechnology.KeypadEdit edLoadPosX;
        private YujinTechnology.SunnyLine sunnyLine6;
        private YujinTechnology.SunnyLine sunnyLine4;
        private YujinTechnology.GradientLabel gradientLabel66;
        private System.Windows.Forms.Label label2;
        public YujinTechnology.Label lblInfom;
        public YujinTechnology.Label label3;
        public YujinTechnology.KeypadEdit edJumpSpeed;
        private YujinTechnology.GradientLabel gradientLabel67;
        private YujinTechnology.GradientLabel gradientLabel68;
        public YujinTechnology.KeypadEdit edTable1VisionFocusLightValue;
        public YujinTechnology.KeypadEdit edTable1LaserFocusLightValue;
        public YujinTechnology.KeypadEdit edTable2VisionFocusLightValue;
        public YujinTechnology.KeypadEdit edTable2LaserFocusLightValue;
        public YujinTechnology.KeypadEdit edTable1VisionZFocus;
        public YujinTechnology.KeypadEdit edTable1LaserZFocus;
        public YujinTechnology.KeypadEdit edTable2VisionZFocus;
        public YujinTechnology.KeypadEdit edTable2LaserZFocus;
        public YujinTechnology.CheckBox chkDustCollectorAutoRun;
        public YujinTechnology.CheckBox chkIOnizoerAutoRun;
        public YujinTechnology.CheckBox chkAreaSensorVacuumUse;
        public YujinTechnology.CheckBox chkAreaSensorUse;
        public YujinTechnology.CheckBox chkVacuumAutoRelease;
        public YujinTechnology.CheckBox chkVacAlarmUse;
        public YujinTechnology.CheckBox chkDoorAlarmUse;
    }
}
