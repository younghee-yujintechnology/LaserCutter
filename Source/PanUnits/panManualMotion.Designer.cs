using DaekhonSystem;
using System.Collections.Generic;

namespace LaserCutter
{
    partial class panManualMotion
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>`
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
            System.Windows.Forms.ImageList imageList2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panManualMotion));
            this.dsIO = new DaekhonSystem.DataServer();
            this.dsMotion = new DaekhonSystem.DataServer();
            this.ReadThread = new DaekhonSystem.Thread();
            this.panJogMove = new LaserCutter.sjPanel();
            this.btnJogMinus = new DaekhonSystem.BitBtn();
            this.btnReset = new DaekhonSystem.BitBtn();
            this.uiLine22 = new DaekhonSystem.SunnyLine();
            this.uiLine6 = new DaekhonSystem.SunnyLine();
            this.uiLine5 = new DaekhonSystem.SunnyLine();
            this.viCurPosition = new DaekhonSystem.ValueIndicator();
            this.gradLabel7 = new DaekhonSystem.GradientLabel();
            this.gradLabel9 = new DaekhonSystem.GradientLabel();
            this.gradLabel8 = new DaekhonSystem.GradientLabel();
            this.cbSpeed = new DaekhonSystem.ComboBox();
            this.edMovePos = new DaekhonSystem.NumberEdit();
            this.btnABS = new DaekhonSystem.BitBtn();
            this.btnStop = new DaekhonSystem.BitBtn();
            this.btnRelPlus = new DaekhonSystem.BitBtn();
            this.btnOrigin = new DaekhonSystem.BitBtn();
            this.btnRelMinus = new DaekhonSystem.BitBtn();
            this.btnServoOff = new DaekhonSystem.BitBtn();
            this.btnServoOn = new DaekhonSystem.BitBtn();
            this.btnJogPlus = new DaekhonSystem.BitBtn();
            this.btnAllAxis = new DaekhonSystem.LEDButton();
            this.btnZAxis = new DaekhonSystem.LEDButton();
            this.btnY2Axis = new DaekhonSystem.LEDButton();
            this.btnY1Axis = new DaekhonSystem.LEDButton();
            this.btnXAxis = new DaekhonSystem.LEDButton();
            this.panIOMap = new LaserCutter.sjPanel();
            this.uiTabControl1 = new DaekhonSystem.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ledIn31 = new DaekhonSystem.LEDImageLabel();
            this.ledIn30 = new DaekhonSystem.LEDImageLabel();
            this.ledIn29 = new DaekhonSystem.LEDImageLabel();
            this.ledIn28 = new DaekhonSystem.LEDImageLabel();
            this.ledIn27 = new DaekhonSystem.LEDImageLabel();
            this.ledIn26 = new DaekhonSystem.LEDImageLabel();
            this.ledIn25 = new DaekhonSystem.LEDImageLabel();
            this.ledIn24 = new DaekhonSystem.LEDImageLabel();
            this.ledIn23 = new DaekhonSystem.LEDImageLabel();
            this.ledDoor5 = new DaekhonSystem.LEDImageLabel();
            this.ledDoor4 = new DaekhonSystem.LEDImageLabel();
            this.ledDoor3 = new DaekhonSystem.LEDImageLabel();
            this.ledDoor2 = new DaekhonSystem.LEDImageLabel();
            this.ledDoor1 = new DaekhonSystem.LEDImageLabel();
            this.ledIn17 = new DaekhonSystem.LEDImageLabel();
            this.ledIn16 = new DaekhonSystem.LEDImageLabel();
            this.ledIn15 = new DaekhonSystem.LEDImageLabel();
            this.ledIn14 = new DaekhonSystem.LEDImageLabel();
            this.ledIn13 = new DaekhonSystem.LEDImageLabel();
            this.ledIn12 = new DaekhonSystem.LEDImageLabel();
            this.ledIn11 = new DaekhonSystem.LEDImageLabel();
            this.ledIn10 = new DaekhonSystem.LEDImageLabel();
            this.ledIn09 = new DaekhonSystem.LEDImageLabel();
            this.ledIn08 = new DaekhonSystem.LEDImageLabel();
            this.ledIn07 = new DaekhonSystem.LEDImageLabel();
            this.ledIn06 = new DaekhonSystem.LEDImageLabel();
            this.ledIn05 = new DaekhonSystem.LEDImageLabel();
            this.ledIn04 = new DaekhonSystem.LEDImageLabel();
            this.ledIn03 = new DaekhonSystem.LEDImageLabel();
            this.ledIn02 = new DaekhonSystem.LEDImageLabel();
            this.ledIn01 = new DaekhonSystem.LEDImageLabel();
            this.ledIn00 = new DaekhonSystem.LEDImageLabel();
            this.ledArray8 = new DaekhonSystem.LEDImageArray();
            this.ledArray7 = new DaekhonSystem.LEDImageArray();
            this.ledArray6 = new DaekhonSystem.LEDImageArray();
            this.ledArray5 = new DaekhonSystem.LEDImageArray();
            this.lblInputPort7 = new DaekhonSystem.Label();
            this.lblInputPort3 = new DaekhonSystem.Label();
            this.lblInputPort6 = new DaekhonSystem.Label();
            this.lblInputPort2 = new DaekhonSystem.Label();
            this.lblInputPort5 = new DaekhonSystem.Label();
            this.lblInputPort1 = new DaekhonSystem.Label();
            this.lblInputPort4 = new DaekhonSystem.Label();
            this.lblInputPort0 = new DaekhonSystem.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.switchOut63 = new DaekhonSystem.SunnySwitch();
            this.switchOut62 = new DaekhonSystem.SunnySwitch();
            this.switchOut61 = new DaekhonSystem.SunnySwitch();
            this.switchOut60 = new DaekhonSystem.SunnySwitch();
            this.switchOut59 = new DaekhonSystem.SunnySwitch();
            this.switchOut58 = new DaekhonSystem.SunnySwitch();
            this.switchOut57 = new DaekhonSystem.SunnySwitch();
            this.switchOut56 = new DaekhonSystem.SunnySwitch();
            this.switchOut55 = new DaekhonSystem.SunnySwitch();
            this.switchOut54 = new DaekhonSystem.SunnySwitch();
            this.switchOut53 = new DaekhonSystem.SunnySwitch();
            this.switchOut52 = new DaekhonSystem.SunnySwitch();
            this.switchOut51 = new DaekhonSystem.SunnySwitch();
            this.switchOut50 = new DaekhonSystem.SunnySwitch();
            this.switchOut49 = new DaekhonSystem.SunnySwitch();
            this.switchOut48 = new DaekhonSystem.SunnySwitch();
            this.switchOut47 = new DaekhonSystem.SunnySwitch();
            this.switchOut46 = new DaekhonSystem.SunnySwitch();
            this.switchOut45 = new DaekhonSystem.SunnySwitch();
            this.switchOut44 = new DaekhonSystem.SunnySwitch();
            this.switchOut43 = new DaekhonSystem.SunnySwitch();
            this.switchOut42 = new DaekhonSystem.SunnySwitch();
            this.switchOut41 = new DaekhonSystem.SunnySwitch();
            this.switchOut40 = new DaekhonSystem.SunnySwitch();
            this.switchOut39 = new DaekhonSystem.SunnySwitch();
            this.switchOut38 = new DaekhonSystem.SunnySwitch();
            this.switchOut37 = new DaekhonSystem.SunnySwitch();
            this.switchOut36 = new DaekhonSystem.SunnySwitch();
            this.switchOut35 = new DaekhonSystem.SunnySwitch();
            this.switchOut34 = new DaekhonSystem.SunnySwitch();
            this.switchOut33 = new DaekhonSystem.SunnySwitch();
            this.switchOut32 = new DaekhonSystem.SunnySwitch();
            this.switchOut31 = new DaekhonSystem.SunnySwitch();
            this.switchOut30 = new DaekhonSystem.SunnySwitch();
            this.switchOut29 = new DaekhonSystem.SunnySwitch();
            this.switchOut28 = new DaekhonSystem.SunnySwitch();
            this.switchOut27 = new DaekhonSystem.SunnySwitch();
            this.switchOut26 = new DaekhonSystem.SunnySwitch();
            this.switchOut25 = new DaekhonSystem.SunnySwitch();
            this.switchOut24 = new DaekhonSystem.SunnySwitch();
            this.switchOut23 = new DaekhonSystem.SunnySwitch();
            this.switchOut22 = new DaekhonSystem.SunnySwitch();
            this.switchOut21 = new DaekhonSystem.SunnySwitch();
            this.switchOut20 = new DaekhonSystem.SunnySwitch();
            this.switchOut19 = new DaekhonSystem.SunnySwitch();
            this.switchOut18 = new DaekhonSystem.SunnySwitch();
            this.switchOut17 = new DaekhonSystem.SunnySwitch();
            this.switchOut16 = new DaekhonSystem.SunnySwitch();
            this.switchOut15 = new DaekhonSystem.SunnySwitch();
            this.switchOut14 = new DaekhonSystem.SunnySwitch();
            this.switchOut13 = new DaekhonSystem.SunnySwitch();
            this.switchOut12 = new DaekhonSystem.SunnySwitch();
            this.switchOut11 = new DaekhonSystem.SunnySwitch();
            this.switchOut10 = new DaekhonSystem.SunnySwitch();
            this.switchOut9 = new DaekhonSystem.SunnySwitch();
            this.switchOut8 = new DaekhonSystem.SunnySwitch();
            this.switchOut7 = new DaekhonSystem.SunnySwitch();
            this.switchOut6 = new DaekhonSystem.SunnySwitch();
            this.switchOut5 = new DaekhonSystem.SunnySwitch();
            this.switchOut4 = new DaekhonSystem.SunnySwitch();
            this.switchOut3 = new DaekhonSystem.SunnySwitch();
            this.switchOut2 = new DaekhonSystem.SunnySwitch();
            this.switchOut1 = new DaekhonSystem.SunnySwitch();
            this.switchOut0 = new DaekhonSystem.SunnySwitch();
            this.lblOutputPort7 = new DaekhonSystem.Label();
            this.lblOutputPort3 = new DaekhonSystem.Label();
            this.lblOutputPort6 = new DaekhonSystem.Label();
            this.lblOutputPort2 = new DaekhonSystem.Label();
            this.lblOutputPort5 = new DaekhonSystem.Label();
            this.lblOutputPort1 = new DaekhonSystem.Label();
            this.lblOutputPort4 = new DaekhonSystem.Label();
            this.lblOutputPort0 = new DaekhonSystem.Label();
            this.panStatus = new LaserCutter.sjPanel();
            this.ledZMotionDone = new DaekhonSystem.LEDLabel();
            this.ledY2MotionDone = new DaekhonSystem.LEDLabel();
            this.ledY1MotionDone = new DaekhonSystem.LEDLabel();
            this.ledXMotionDone = new DaekhonSystem.LEDLabel();
            this.gradientLabel1 = new DaekhonSystem.GradientLabel();
            this.ledXServo = new DaekhonSystem.LEDLabel();
            this.gradLabel26 = new DaekhonSystem.GradientLabel();
            this.gradLabel24 = new DaekhonSystem.GradientLabel();
            this.gradLabel31 = new DaekhonSystem.GradientLabel();
            this.gradLabel19 = new DaekhonSystem.GradientLabel();
            this.gradLabel40 = new DaekhonSystem.GradientLabel();
            this.gradLabel32 = new DaekhonSystem.GradientLabel();
            this.gradLabel21 = new DaekhonSystem.GradientLabel();
            this.gradLabel33 = new DaekhonSystem.GradientLabel();
            this.gradLabel34 = new DaekhonSystem.GradientLabel();
            this.gradLabel28 = new DaekhonSystem.GradientLabel();
            this.gradLabel35 = new DaekhonSystem.GradientLabel();
            this.gradLabel17 = new DaekhonSystem.GradientLabel();
            this.gradLabel36 = new DaekhonSystem.GradientLabel();
            this.gradLabel41 = new DaekhonSystem.GradientLabel();
            this.ledZHome = new DaekhonSystem.LEDLabel();
            this.gradLabel39 = new DaekhonSystem.GradientLabel();
            this.ledZAlarm = new DaekhonSystem.LEDLabel();
            this.gradLabel42 = new DaekhonSystem.GradientLabel();
            this.gradLabel29 = new DaekhonSystem.GradientLabel();
            this.ledZInposition = new DaekhonSystem.LEDLabel();
            this.gradLabel37 = new DaekhonSystem.GradientLabel();
            this.viZVelocity = new DaekhonSystem.ValueIndicator();
            this.ledZCW = new DaekhonSystem.LEDLabel();
            this.ledZServo = new DaekhonSystem.LEDLabel();
            this.ledXCCW = new DaekhonSystem.LEDLabel();
            this.ledZCCW = new DaekhonSystem.LEDLabel();
            this.ledY1CCW = new DaekhonSystem.LEDLabel();
            this.ledY2Home = new DaekhonSystem.LEDLabel();
            this.ledY2Alarm = new DaekhonSystem.LEDLabel();
            this.ledXCW = new DaekhonSystem.LEDLabel();
            this.ledY1Home = new DaekhonSystem.LEDLabel();
            this.viXVelocity = new DaekhonSystem.ValueIndicator();
            this.ledY1Alarm = new DaekhonSystem.LEDLabel();
            this.ledY1Servo = new DaekhonSystem.LEDLabel();
            this.ledY2Inposition = new DaekhonSystem.LEDLabel();
            this.viXPosition = new DaekhonSystem.ValueIndicator();
            this.viY1Position = new DaekhonSystem.ValueIndicator();
            this.viY2Position = new DaekhonSystem.ValueIndicator();
            this.viZPosition = new DaekhonSystem.ValueIndicator();
            this.ledY2CW = new DaekhonSystem.LEDLabel();
            this.ledY2CCW = new DaekhonSystem.LEDLabel();
            this.ledY1Inposition = new DaekhonSystem.LEDLabel();
            this.viY1Velocity = new DaekhonSystem.ValueIndicator();
            this.ledY1CW = new DaekhonSystem.LEDLabel();
            this.ledXInposition = new DaekhonSystem.LEDLabel();
            this.ledXHome = new DaekhonSystem.LEDLabel();
            this.ledY2Servo = new DaekhonSystem.LEDLabel();
            this.viY2Velocity = new DaekhonSystem.ValueIndicator();
            this.ledXAlarm = new DaekhonSystem.LEDLabel();
            this.uiLine20 = new DaekhonSystem.SunnyLine();
            imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panJogMove.SuspendLayout();
            this.panIOMap.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "image_1.bmp");
            imageList2.Images.SetKeyName(1, "image_2.bmp");
            imageList2.Images.SetKeyName(2, "Gray.png");
            // 
            // dsIO
            // 
            this.dsIO.OnError += new DaekhonSystem.ErrorEventHandler(this.dsIO_OnError);
            // 
            // dsMotion
            // 
            this.dsMotion.OnError += new DaekhonSystem.ErrorEventHandler(this.dsMotion_OnError);
            // 
            // ReadThread
            // 
            this.ReadThread.Enabled = true;
            this.ReadThread.Interval = 100;
            this.ReadThread.OnExecute += new System.EventHandler(this.ReadThread_OnExecute);
            // 
            // panJogMove
            // 
            this.panJogMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panJogMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panJogMove.Controls.Add(this.btnJogMinus);
            this.panJogMove.Controls.Add(this.btnReset);
            this.panJogMove.Controls.Add(this.uiLine22);
            this.panJogMove.Controls.Add(this.uiLine6);
            this.panJogMove.Controls.Add(this.uiLine5);
            this.panJogMove.Controls.Add(this.viCurPosition);
            this.panJogMove.Controls.Add(this.gradLabel7);
            this.panJogMove.Controls.Add(this.gradLabel9);
            this.panJogMove.Controls.Add(this.gradLabel8);
            this.panJogMove.Controls.Add(this.cbSpeed);
            this.panJogMove.Controls.Add(this.edMovePos);
            this.panJogMove.Controls.Add(this.btnABS);
            this.panJogMove.Controls.Add(this.btnStop);
            this.panJogMove.Controls.Add(this.btnRelPlus);
            this.panJogMove.Controls.Add(this.btnOrigin);
            this.panJogMove.Controls.Add(this.btnRelMinus);
            this.panJogMove.Controls.Add(this.btnServoOff);
            this.panJogMove.Controls.Add(this.btnServoOn);
            this.panJogMove.Controls.Add(this.btnJogPlus);
            this.panJogMove.Controls.Add(this.btnAllAxis);
            this.panJogMove.Controls.Add(this.btnZAxis);
            this.panJogMove.Controls.Add(this.btnY2Axis);
            this.panJogMove.Controls.Add(this.btnY1Axis);
            this.panJogMove.Controls.Add(this.btnXAxis);
            this.panJogMove.Location = new System.Drawing.Point(3, 413);
            this.panJogMove.Margin = new System.Windows.Forms.Padding(0);
            this.panJogMove.Name = "panJogMove";
            this.panJogMove.Size = new System.Drawing.Size(486, 433);
            this.panJogMove.TabIndex = 1130;
            this.panJogMove.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panJogMove.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panJogMove.TitleText = "Move";
            this.panJogMove.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnJogMinus
            // 
            this.btnJogMinus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnJogMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnJogMinus.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnJogMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogMinus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnJogMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJogMinus.Location = new System.Drawing.Point(5, 248);
            this.btnJogMinus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnJogMinus.Name = "btnJogMinus";
            this.btnJogMinus.Size = new System.Drawing.Size(182, 55);
            this.btnJogMinus.TabIndex = 888;
            this.btnJogMinus.Text = "JOG(-)";
            this.btnJogMinus.UseVisualStyleBackColor = false;
            this.btnJogMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogMinus_MouseDown);
            this.btnJogMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogMinus_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnReset.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(282, 307);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 43);
            this.btnReset.TabIndex = 886;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // uiLine22
            // 
            this.uiLine22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine22.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine22.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine22.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine22.ForeColor = System.Drawing.Color.Black;
            this.uiLine22.Frame.Visible = false;
            this.uiLine22.Hint = null;
            this.uiLine22.LineCapSize = 4;
            this.uiLine22.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine22.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine22.LineWidth = 1F;
            this.uiLine22.Location = new System.Drawing.Point(5, 231);
            this.uiLine22.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine22.Name = "uiLine22";
            this.uiLine22.ShowHint = false;
            this.uiLine22.Size = new System.Drawing.Size(476, 17);
            this.uiLine22.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine22.TabIndex = 722;
            this.uiLine22.Text = "Control";
            this.uiLine22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine22.TextInterval = 4;
            // 
            // uiLine6
            // 
            this.uiLine6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine6.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine6.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine6.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine6.ForeColor = System.Drawing.Color.Black;
            this.uiLine6.Frame.Visible = false;
            this.uiLine6.Hint = null;
            this.uiLine6.LineCapSize = 4;
            this.uiLine6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine6.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine6.LineWidth = 1F;
            this.uiLine6.Location = new System.Drawing.Point(4, 165);
            this.uiLine6.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine6.Name = "uiLine6";
            this.uiLine6.ShowHint = false;
            this.uiLine6.Size = new System.Drawing.Size(478, 17);
            this.uiLine6.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine6.TabIndex = 722;
            this.uiLine6.Text = "ABS & REL";
            this.uiLine6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine6.TextInterval = 4;
            // 
            // uiLine5
            // 
            this.uiLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine5.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine5.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine5.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine5.ForeColor = System.Drawing.Color.Black;
            this.uiLine5.Frame.Visible = false;
            this.uiLine5.Hint = null;
            this.uiLine5.LineCapSize = 4;
            this.uiLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine5.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine5.LineWidth = 1F;
            this.uiLine5.Location = new System.Drawing.Point(4, 52);
            this.uiLine5.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.ShowHint = false;
            this.uiLine5.Size = new System.Drawing.Size(478, 17);
            this.uiLine5.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine5.TabIndex = 722;
            this.uiLine5.Text = "Axis Select";
            this.uiLine5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine5.TextInterval = 4;
            // 
            // viCurPosition
            // 
            this.viCurPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viCurPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.viCurPosition.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viCurPosition.ForeColor = System.Drawing.Color.Black;
            this.viCurPosition.FormatString = "{0:F3}";
            this.viCurPosition.Location = new System.Drawing.Point(117, 129);
            this.viCurPosition.Name = "viCurPosition";
            this.viCurPosition.ShowAccelChar = false;
            this.viCurPosition.Size = new System.Drawing.Size(137, 31);
            this.viCurPosition.TabIndex = 718;
            this.viCurPosition.Text = "0";
            this.viCurPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gradLabel7.Location = new System.Drawing.Point(9, 129);
            this.gradLabel7.Name = "gradLabel7";
            this.gradLabel7.ShowAccelChar = false;
            this.gradLabel7.Size = new System.Drawing.Size(101, 29);
            this.gradLabel7.TabIndex = 628;
            this.gradLabel7.Text = "Pos(mm)";
            this.gradLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel9
            // 
            this.gradLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel9.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel9.GradientEnable = false;
            this.gradLabel9.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel9.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel9.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel9.Location = new System.Drawing.Point(9, 189);
            this.gradLabel9.Name = "gradLabel9";
            this.gradLabel9.ShowAccelChar = false;
            this.gradLabel9.Size = new System.Drawing.Size(101, 29);
            this.gradLabel9.TabIndex = 629;
            this.gradLabel9.Text = "Move Abs / Rel";
            this.gradLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel8
            // 
            this.gradLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel8.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel8.GradientEnable = false;
            this.gradLabel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel8.Location = new System.Drawing.Point(260, 129);
            this.gradLabel8.Name = "gradLabel8";
            this.gradLabel8.ShowAccelChar = false;
            this.gradLabel8.Size = new System.Drawing.Size(101, 29);
            this.gradLabel8.TabIndex = 630;
            this.gradLabel8.Text = "Speed";
            this.gradLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSpeed
            // 
            this.cbSpeed.BackColor = System.Drawing.Color.White;
            this.cbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeed.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbSpeed.Frame.Bottom = false;
            this.cbSpeed.Frame.CornerRound = 1;
            this.cbSpeed.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbSpeed.Frame.Top = false;
            this.cbSpeed.Hint = null;
            this.cbSpeed.ItemIndex = 2;
            this.cbSpeed.Items.AddRange(new object[] {
            "Low",
            "Middle",
            "Fast"});
            this.cbSpeed.Location = new System.Drawing.Point(372, 129);
            this.cbSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpeed.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSpeed.ShowHint = false;
            this.cbSpeed.Size = new System.Drawing.Size(105, 30);
            this.cbSpeed.TabIndex = 632;
            this.cbSpeed.Text = "Fast";
            this.cbSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSpeed.OnSelectedIndexChanged += new System.EventHandler(this.cbSpeed_OnSelectedIndexChanged);
            // 
            // edMovePos
            // 
            this.edMovePos.BackColor = System.Drawing.Color.White;
            this.edMovePos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edMovePos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMovePos.ForeColor = System.Drawing.Color.Black;
            this.edMovePos.Frame.Bottom = false;
            this.edMovePos.Frame.CornerRound = 1;
            this.edMovePos.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMovePos.Frame.Top = false;
            this.edMovePos.Hint = null;
            this.edMovePos.Location = new System.Drawing.Point(115, 189);
            this.edMovePos.Margin = new System.Windows.Forms.Padding(4);
            this.edMovePos.Max = 0D;
            this.edMovePos.Min = 0D;
            this.edMovePos.MinimumSize = new System.Drawing.Size(1, 1);
            this.edMovePos.Name = "edMovePos";
            this.edMovePos.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edMovePos.PrecisionDigits = 3;
            this.edMovePos.ShowHint = false;
            this.edMovePos.Size = new System.Drawing.Size(124, 30);
            this.edMovePos.TabIndex = 633;
            this.edMovePos.Text = "0";
            this.edMovePos.Value = 0D;
            // 
            // btnABS
            // 
            this.btnABS.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnABS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnABS.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnABS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnABS.Font = new System.Drawing.Font("굴림", 9F);
            this.btnABS.ForeColor = System.Drawing.Color.Black;
            this.btnABS.Location = new System.Drawing.Point(278, 189);
            this.btnABS.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnABS.Name = "btnABS";
            this.btnABS.Size = new System.Drawing.Size(73, 30);
            this.btnABS.TabIndex = 641;
            this.btnABS.Text = "ABS";
            this.btnABS.UseVisualStyleBackColor = false;
            this.btnABS.Click += new System.EventHandler(this.btnABS_Click);
            // 
            // btnStop
            // 
            this.btnStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(377, 248);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 102);
            this.btnStop.TabIndex = 648;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRelPlus
            // 
            this.btnRelPlus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnRelPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRelPlus.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnRelPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelPlus.Font = new System.Drawing.Font("굴림", 9F);
            this.btnRelPlus.ForeColor = System.Drawing.Color.Black;
            this.btnRelPlus.Location = new System.Drawing.Point(422, 189);
            this.btnRelPlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRelPlus.Name = "btnRelPlus";
            this.btnRelPlus.Size = new System.Drawing.Size(57, 30);
            this.btnRelPlus.TabIndex = 640;
            this.btnRelPlus.Text = "+";
            this.btnRelPlus.UseVisualStyleBackColor = false;
            this.btnRelPlus.Click += new System.EventHandler(this.btnRelPlus_Click);
            // 
            // btnOrigin
            // 
            this.btnOrigin.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOrigin.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrigin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOrigin.ForeColor = System.Drawing.Color.Black;
            this.btnOrigin.Location = new System.Drawing.Point(190, 307);
            this.btnOrigin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(90, 43);
            this.btnOrigin.TabIndex = 647;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = false;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // btnRelMinus
            // 
            this.btnRelMinus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnRelMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRelMinus.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnRelMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelMinus.Font = new System.Drawing.Font("굴림", 9F);
            this.btnRelMinus.ForeColor = System.Drawing.Color.Black;
            this.btnRelMinus.Location = new System.Drawing.Point(358, 189);
            this.btnRelMinus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRelMinus.Name = "btnRelMinus";
            this.btnRelMinus.Size = new System.Drawing.Size(58, 30);
            this.btnRelMinus.TabIndex = 642;
            this.btnRelMinus.Text = "-";
            this.btnRelMinus.UseVisualStyleBackColor = false;
            this.btnRelMinus.Click += new System.EventHandler(this.btnRelMinus_Click);
            // 
            // btnServoOff
            // 
            this.btnServoOff.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnServoOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnServoOff.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnServoOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServoOff.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnServoOff.ForeColor = System.Drawing.Color.Black;
            this.btnServoOff.Location = new System.Drawing.Point(97, 307);
            this.btnServoOff.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnServoOff.Name = "btnServoOff";
            this.btnServoOff.Size = new System.Drawing.Size(90, 43);
            this.btnServoOff.TabIndex = 646;
            this.btnServoOff.Text = "Servo Off";
            this.btnServoOff.UseVisualStyleBackColor = false;
            this.btnServoOff.Click += new System.EventHandler(this.btnServoOff_Click);
            // 
            // btnServoOn
            // 
            this.btnServoOn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnServoOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnServoOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnServoOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServoOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnServoOn.ForeColor = System.Drawing.Color.Black;
            this.btnServoOn.Location = new System.Drawing.Point(5, 307);
            this.btnServoOn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(90, 43);
            this.btnServoOn.TabIndex = 645;
            this.btnServoOn.Text = "Servo On";
            this.btnServoOn.UseVisualStyleBackColor = false;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // btnJogPlus
            // 
            this.btnJogPlus.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnJogPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnJogPlus.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnJogPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogPlus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnJogPlus.ForeColor = System.Drawing.Color.Black;
            this.btnJogPlus.Location = new System.Drawing.Point(190, 248);
            this.btnJogPlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnJogPlus.Name = "btnJogPlus";
            this.btnJogPlus.Size = new System.Drawing.Size(182, 55);
            this.btnJogPlus.TabIndex = 643;
            this.btnJogPlus.Text = "JOG(+)";
            this.btnJogPlus.UseVisualStyleBackColor = false;
            this.btnJogPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogPlus_MouseDown);
            this.btnJogPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogPlus_MouseUp);
            // 
            // btnAllAxis
            // 
            this.btnAllAxis.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAllAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAllAxis.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnAllAxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllAxis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAllAxis.ForeColor = System.Drawing.Color.Black;
            this.btnAllAxis.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnAllAxis.LED.Size = new System.Drawing.Size(68, 24);
            this.btnAllAxis.Location = new System.Drawing.Point(385, 75);
            this.btnAllAxis.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAllAxis.Name = "btnAllAxis";
            this.btnAllAxis.Size = new System.Drawing.Size(92, 44);
            this.btnAllAxis.TabIndex = 624;
            this.btnAllAxis.Text = "All";
            this.btnAllAxis.UseVisualStyleBackColor = false;
            this.btnAllAxis.Click += new System.EventHandler(this.ChangeAxis);
            // 
            // btnZAxis
            // 
            this.btnZAxis.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnZAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnZAxis.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnZAxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZAxis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnZAxis.ForeColor = System.Drawing.Color.Black;
            this.btnZAxis.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnZAxis.LED.Size = new System.Drawing.Size(68, 24);
            this.btnZAxis.Location = new System.Drawing.Point(290, 75);
            this.btnZAxis.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZAxis.Name = "btnZAxis";
            this.btnZAxis.Size = new System.Drawing.Size(92, 44);
            this.btnZAxis.TabIndex = 623;
            this.btnZAxis.Text = "Z";
            this.btnZAxis.UseVisualStyleBackColor = false;
            this.btnZAxis.Click += new System.EventHandler(this.ChangeAxis);
            // 
            // btnY2Axis
            // 
            this.btnY2Axis.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnY2Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnY2Axis.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnY2Axis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY2Axis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnY2Axis.ForeColor = System.Drawing.Color.Black;
            this.btnY2Axis.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnY2Axis.LED.Size = new System.Drawing.Size(68, 24);
            this.btnY2Axis.Location = new System.Drawing.Point(195, 75);
            this.btnY2Axis.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnY2Axis.Name = "btnY2Axis";
            this.btnY2Axis.Size = new System.Drawing.Size(92, 44);
            this.btnY2Axis.TabIndex = 627;
            this.btnY2Axis.Text = "Y2";
            this.btnY2Axis.UseVisualStyleBackColor = false;
            this.btnY2Axis.Click += new System.EventHandler(this.ChangeAxis);
            // 
            // btnY1Axis
            // 
            this.btnY1Axis.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnY1Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnY1Axis.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnY1Axis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY1Axis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnY1Axis.ForeColor = System.Drawing.Color.Black;
            this.btnY1Axis.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnY1Axis.LED.Size = new System.Drawing.Size(68, 24);
            this.btnY1Axis.Location = new System.Drawing.Point(100, 75);
            this.btnY1Axis.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnY1Axis.Name = "btnY1Axis";
            this.btnY1Axis.Size = new System.Drawing.Size(92, 44);
            this.btnY1Axis.TabIndex = 625;
            this.btnY1Axis.Text = "Y1";
            this.btnY1Axis.UseVisualStyleBackColor = false;
            this.btnY1Axis.Click += new System.EventHandler(this.ChangeAxis);
            // 
            // btnXAxis
            // 
            this.btnXAxis.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnXAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnXAxis.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnXAxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXAxis.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXAxis.ForeColor = System.Drawing.Color.Black;
            this.btnXAxis.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnXAxis.LED.Size = new System.Drawing.Size(68, 24);
            this.btnXAxis.Location = new System.Drawing.Point(5, 75);
            this.btnXAxis.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXAxis.Name = "btnXAxis";
            this.btnXAxis.Size = new System.Drawing.Size(92, 44);
            this.btnXAxis.TabIndex = 626;
            this.btnXAxis.Text = "X";
            this.btnXAxis.UseVisualStyleBackColor = false;
            this.btnXAxis.Click += new System.EventHandler(this.ChangeAxis);
            // 
            // panIOMap
            // 
            this.panIOMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panIOMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panIOMap.Controls.Add(this.uiTabControl1);
            this.panIOMap.Location = new System.Drawing.Point(494, 3);
            this.panIOMap.Margin = new System.Windows.Forms.Padding(0);
            this.panIOMap.Name = "panIOMap";
            this.panIOMap.Size = new System.Drawing.Size(876, 843);
            this.panIOMap.TabIndex = 1129;
            this.panIOMap.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panIOMap.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panIOMap.TitleText = "Input/Output";
            this.panIOMap.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 46);
            this.uiTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTabControl1.ShowActiveCloseButton = false;
            this.uiTabControl1.ShowCloseButton = false;
            this.uiTabControl1.Size = new System.Drawing.Size(874, 795);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uiTabControl1.TabIndex = 1336;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.uiTabControl1.TabSelectedHighColorSize = 4;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Black;
            this.uiTabControl1.TabVisible = true;
            this.uiTabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTabControl1.TipsColor = System.Drawing.Color.Red;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTabControl1.TipsForeColor = System.Drawing.Color.White;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.ledIn31);
            this.tabPage2.Controls.Add(this.ledIn30);
            this.tabPage2.Controls.Add(this.ledIn29);
            this.tabPage2.Controls.Add(this.ledIn28);
            this.tabPage2.Controls.Add(this.ledIn27);
            this.tabPage2.Controls.Add(this.ledIn26);
            this.tabPage2.Controls.Add(this.ledIn25);
            this.tabPage2.Controls.Add(this.ledIn24);
            this.tabPage2.Controls.Add(this.ledIn23);
            this.tabPage2.Controls.Add(this.ledDoor5);
            this.tabPage2.Controls.Add(this.ledDoor4);
            this.tabPage2.Controls.Add(this.ledDoor3);
            this.tabPage2.Controls.Add(this.ledDoor2);
            this.tabPage2.Controls.Add(this.ledDoor1);
            this.tabPage2.Controls.Add(this.ledIn17);
            this.tabPage2.Controls.Add(this.ledIn16);
            this.tabPage2.Controls.Add(this.ledIn15);
            this.tabPage2.Controls.Add(this.ledIn14);
            this.tabPage2.Controls.Add(this.ledIn13);
            this.tabPage2.Controls.Add(this.ledIn12);
            this.tabPage2.Controls.Add(this.ledIn11);
            this.tabPage2.Controls.Add(this.ledIn10);
            this.tabPage2.Controls.Add(this.ledIn09);
            this.tabPage2.Controls.Add(this.ledIn08);
            this.tabPage2.Controls.Add(this.ledIn07);
            this.tabPage2.Controls.Add(this.ledIn06);
            this.tabPage2.Controls.Add(this.ledIn05);
            this.tabPage2.Controls.Add(this.ledIn04);
            this.tabPage2.Controls.Add(this.ledIn03);
            this.tabPage2.Controls.Add(this.ledIn02);
            this.tabPage2.Controls.Add(this.ledIn01);
            this.tabPage2.Controls.Add(this.ledIn00);
            this.tabPage2.Controls.Add(this.ledArray8);
            this.tabPage2.Controls.Add(this.ledArray7);
            this.tabPage2.Controls.Add(this.ledArray6);
            this.tabPage2.Controls.Add(this.ledArray5);
            this.tabPage2.Controls.Add(this.lblInputPort7);
            this.tabPage2.Controls.Add(this.lblInputPort3);
            this.tabPage2.Controls.Add(this.lblInputPort6);
            this.tabPage2.Controls.Add(this.lblInputPort2);
            this.tabPage2.Controls.Add(this.lblInputPort5);
            this.tabPage2.Controls.Add(this.lblInputPort1);
            this.tabPage2.Controls.Add(this.lblInputPort4);
            this.tabPage2.Controls.Add(this.lblInputPort0);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(866, 757);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "INPUT";
            // 
            // ledIn31
            // 
            this.ledIn31.BackColor = System.Drawing.Color.Transparent;
            this.ledIn31.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn31.ImageList = imageList2;
            this.ledIn31.Location = new System.Drawing.Point(662, 325);
            this.ledIn31.Name = "ledIn31";
            this.ledIn31.OffImageIndex = 1;
            this.ledIn31.ShowAccelChar = false;
            this.ledIn31.Size = new System.Drawing.Size(195, 37);
            this.ledIn31.TabIndex = 1731;
            this.ledIn31.Text = "X31: Area Sensor T2";
            this.ledIn31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn31.Value = false;
            this.ledIn31.ValueChanged += new System.EventHandler(this.ledIn31_ValueChanged);
            // 
            // ledIn30
            // 
            this.ledIn30.BackColor = System.Drawing.Color.Transparent;
            this.ledIn30.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn30.ImageList = imageList2;
            this.ledIn30.Location = new System.Drawing.Point(662, 285);
            this.ledIn30.Name = "ledIn30";
            this.ledIn30.OffImageIndex = 1;
            this.ledIn30.ShowAccelChar = false;
            this.ledIn30.Size = new System.Drawing.Size(195, 37);
            this.ledIn30.TabIndex = 1730;
            this.ledIn30.Text = "X30: Area Sensor T1";
            this.ledIn30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn30.Value = false;
            this.ledIn30.ValueChanged += new System.EventHandler(this.ledIn30_ValueChanged);
            // 
            // ledIn29
            // 
            this.ledIn29.BackColor = System.Drawing.Color.Transparent;
            this.ledIn29.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn29.ImageList = imageList2;
            this.ledIn29.Location = new System.Drawing.Point(662, 245);
            this.ledIn29.Name = "ledIn29";
            this.ledIn29.OffImageIndex = 1;
            this.ledIn29.ShowAccelChar = false;
            this.ledIn29.Size = new System.Drawing.Size(195, 37);
            this.ledIn29.TabIndex = 1729;
            this.ledIn29.Text = "ledImageLabel29";
            this.ledIn29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn29.Value = false;
            // 
            // ledIn28
            // 
            this.ledIn28.BackColor = System.Drawing.Color.Transparent;
            this.ledIn28.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn28.ImageList = imageList2;
            this.ledIn28.Location = new System.Drawing.Point(662, 205);
            this.ledIn28.Name = "ledIn28";
            this.ledIn28.OffImageIndex = 1;
            this.ledIn28.ShowAccelChar = false;
            this.ledIn28.Size = new System.Drawing.Size(195, 37);
            this.ledIn28.TabIndex = 1728;
            this.ledIn28.Text = "ledImageLabel28";
            this.ledIn28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn28.Value = false;
            // 
            // ledIn27
            // 
            this.ledIn27.BackColor = System.Drawing.Color.Transparent;
            this.ledIn27.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn27.ImageList = imageList2;
            this.ledIn27.Location = new System.Drawing.Point(662, 165);
            this.ledIn27.Name = "ledIn27";
            this.ledIn27.OffImageIndex = 1;
            this.ledIn27.ShowAccelChar = false;
            this.ledIn27.Size = new System.Drawing.Size(195, 37);
            this.ledIn27.TabIndex = 1727;
            this.ledIn27.Text = "ledImageLabel27";
            this.ledIn27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn27.Value = false;
            // 
            // ledIn26
            // 
            this.ledIn26.BackColor = System.Drawing.Color.Transparent;
            this.ledIn26.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn26.ImageList = imageList2;
            this.ledIn26.Location = new System.Drawing.Point(662, 125);
            this.ledIn26.Name = "ledIn26";
            this.ledIn26.OffImageIndex = 1;
            this.ledIn26.ShowAccelChar = false;
            this.ledIn26.Size = new System.Drawing.Size(195, 37);
            this.ledIn26.TabIndex = 1726;
            this.ledIn26.Text = "ledImageLabel26";
            this.ledIn26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn26.Value = false;
            // 
            // ledIn25
            // 
            this.ledIn25.BackColor = System.Drawing.Color.Transparent;
            this.ledIn25.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn25.ImageList = imageList2;
            this.ledIn25.Location = new System.Drawing.Point(662, 85);
            this.ledIn25.Name = "ledIn25";
            this.ledIn25.OffImageIndex = 1;
            this.ledIn25.ShowAccelChar = false;
            this.ledIn25.Size = new System.Drawing.Size(195, 37);
            this.ledIn25.TabIndex = 1725;
            this.ledIn25.Text = "ledImageLabel25";
            this.ledIn25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn25.Value = false;
            // 
            // ledIn24
            // 
            this.ledIn24.BackColor = System.Drawing.Color.Transparent;
            this.ledIn24.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn24.ImageList = imageList2;
            this.ledIn24.Location = new System.Drawing.Point(662, 45);
            this.ledIn24.Name = "ledIn24";
            this.ledIn24.OffImageIndex = 1;
            this.ledIn24.ShowAccelChar = false;
            this.ledIn24.Size = new System.Drawing.Size(195, 37);
            this.ledIn24.TabIndex = 1724;
            this.ledIn24.Text = "ledImageLabel24";
            this.ledIn24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn24.Value = false;
            // 
            // ledIn23
            // 
            this.ledIn23.BackColor = System.Drawing.Color.Transparent;
            this.ledIn23.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn23.ImageList = imageList2;
            this.ledIn23.Location = new System.Drawing.Point(439, 325);
            this.ledIn23.Name = "ledIn23";
            this.ledIn23.OffImageIndex = 2;
            this.ledIn23.ShowAccelChar = false;
            this.ledIn23.Size = new System.Drawing.Size(199, 37);
            this.ledIn23.TabIndex = 1723;
            this.ledIn23.Text = "X23:";
            this.ledIn23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn23.Value = false;
            // 
            // ledDoor5
            // 
            this.ledDoor5.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor5.ImageList = imageList2;
            this.ledDoor5.Location = new System.Drawing.Point(439, 285);
            this.ledDoor5.Name = "ledDoor5";
            this.ledDoor5.OffImageIndex = 1;
            this.ledDoor5.ShowAccelChar = false;
            this.ledDoor5.Size = new System.Drawing.Size(199, 37);
            this.ledDoor5.TabIndex = 1722;
            this.ledDoor5.Text = "X22: Door Sensor #5";
            this.ledDoor5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledDoor5.ValueChanged += new System.EventHandler(this.ledIn22_ValueChanged);
            // 
            // ledDoor4
            // 
            this.ledDoor4.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor4.ImageList = imageList2;
            this.ledDoor4.Location = new System.Drawing.Point(439, 245);
            this.ledDoor4.Name = "ledDoor4";
            this.ledDoor4.OffImageIndex = 1;
            this.ledDoor4.ShowAccelChar = false;
            this.ledDoor4.Size = new System.Drawing.Size(199, 37);
            this.ledDoor4.TabIndex = 1721;
            this.ledDoor4.Text = "X21: Door Sensor #4";
            this.ledDoor4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledDoor4.ValueChanged += new System.EventHandler(this.ledIn21_ValueChanged);
            // 
            // ledDoor3
            // 
            this.ledDoor3.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor3.ImageList = imageList2;
            this.ledDoor3.Location = new System.Drawing.Point(439, 205);
            this.ledDoor3.Name = "ledDoor3";
            this.ledDoor3.OffImageIndex = 1;
            this.ledDoor3.ShowAccelChar = false;
            this.ledDoor3.Size = new System.Drawing.Size(199, 37);
            this.ledDoor3.TabIndex = 1720;
            this.ledDoor3.Text = "X20: Door Sensor #3";
            this.ledDoor3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledDoor3.ValueChanged += new System.EventHandler(this.ledIn20_ValueChanged);
            // 
            // ledDoor2
            // 
            this.ledDoor2.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor2.ImageList = imageList2;
            this.ledDoor2.Location = new System.Drawing.Point(439, 165);
            this.ledDoor2.Name = "ledDoor2";
            this.ledDoor2.OffImageIndex = 1;
            this.ledDoor2.ShowAccelChar = false;
            this.ledDoor2.Size = new System.Drawing.Size(199, 37);
            this.ledDoor2.TabIndex = 1719;
            this.ledDoor2.Text = "X19: Door Sensor #2";
            this.ledDoor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledDoor2.ValueChanged += new System.EventHandler(this.ledIn19_ValueChanged);
            // 
            // ledDoor1
            // 
            this.ledDoor1.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor1.ImageList = imageList2;
            this.ledDoor1.Location = new System.Drawing.Point(439, 125);
            this.ledDoor1.Name = "ledDoor1";
            this.ledDoor1.OffImageIndex = 1;
            this.ledDoor1.ShowAccelChar = false;
            this.ledDoor1.Size = new System.Drawing.Size(199, 37);
            this.ledDoor1.TabIndex = 1718;
            this.ledDoor1.Text = "X18: Door Sensor #1";
            this.ledDoor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledDoor1.ValueChanged += new System.EventHandler(this.ledIn18_ValueChanged);
            // 
            // ledIn17
            // 
            this.ledIn17.BackColor = System.Drawing.Color.Transparent;
            this.ledIn17.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn17.ImageList = imageList2;
            this.ledIn17.Location = new System.Drawing.Point(439, 85);
            this.ledIn17.Name = "ledIn17";
            this.ledIn17.OffImageIndex = 1;
            this.ledIn17.ShowAccelChar = false;
            this.ledIn17.Size = new System.Drawing.Size(199, 37);
            this.ledIn17.TabIndex = 1717;
            this.ledIn17.Text = "X17: Leak Sensor";
            this.ledIn17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn17.Value = false;
            // 
            // ledIn16
            // 
            this.ledIn16.BackColor = System.Drawing.Color.Transparent;
            this.ledIn16.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn16.ImageList = imageList2;
            this.ledIn16.Location = new System.Drawing.Point(439, 45);
            this.ledIn16.Name = "ledIn16";
            this.ledIn16.OffImageIndex = 1;
            this.ledIn16.ShowAccelChar = false;
            this.ledIn16.Size = new System.Drawing.Size(199, 37);
            this.ledIn16.TabIndex = 1716;
            this.ledIn16.Text = "X16: Stage Power";
            this.ledIn16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn16.Value = false;
            // 
            // ledIn15
            // 
            this.ledIn15.BackColor = System.Drawing.Color.Transparent;
            this.ledIn15.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn15.ImageList = imageList2;
            this.ledIn15.Location = new System.Drawing.Point(221, 325);
            this.ledIn15.Name = "ledIn15";
            this.ledIn15.OffImageIndex = 1;
            this.ledIn15.ShowAccelChar = false;
            this.ledIn15.Size = new System.Drawing.Size(199, 37);
            this.ledIn15.TabIndex = 1715;
            this.ledIn15.Text = "ledImageLabel15";
            this.ledIn15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn15.Value = false;
            // 
            // ledIn14
            // 
            this.ledIn14.BackColor = System.Drawing.Color.Transparent;
            this.ledIn14.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn14.ImageList = imageList2;
            this.ledIn14.Location = new System.Drawing.Point(221, 285);
            this.ledIn14.Name = "ledIn14";
            this.ledIn14.OffImageIndex = 1;
            this.ledIn14.ShowAccelChar = false;
            this.ledIn14.Size = new System.Drawing.Size(199, 37);
            this.ledIn14.TabIndex = 1714;
            this.ledIn14.Text = "ledImageLabel14";
            this.ledIn14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn14.Value = false;
            // 
            // ledIn13
            // 
            this.ledIn13.BackColor = System.Drawing.Color.Transparent;
            this.ledIn13.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn13.ImageList = imageList2;
            this.ledIn13.Location = new System.Drawing.Point(221, 245);
            this.ledIn13.Name = "ledIn13";
            this.ledIn13.OffImageIndex = 1;
            this.ledIn13.ShowAccelChar = false;
            this.ledIn13.Size = new System.Drawing.Size(199, 37);
            this.ledIn13.TabIndex = 1713;
            this.ledIn13.Text = "X13: T2 Reset Switch";
            this.ledIn13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn13.Value = false;
            this.ledIn13.ValueChanged += new System.EventHandler(this.ledIn13_ValueChanged);
            // 
            // ledIn12
            // 
            this.ledIn12.BackColor = System.Drawing.Color.Transparent;
            this.ledIn12.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn12.ImageList = imageList2;
            this.ledIn12.Location = new System.Drawing.Point(221, 205);
            this.ledIn12.Name = "ledIn12";
            this.ledIn12.OffImageIndex = 1;
            this.ledIn12.ShowAccelChar = false;
            this.ledIn12.Size = new System.Drawing.Size(199, 37);
            this.ledIn12.TabIndex = 1712;
            this.ledIn12.Text = "ledImageLabel12";
            this.ledIn12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn12.Value = false;
            // 
            // ledIn11
            // 
            this.ledIn11.BackColor = System.Drawing.Color.Transparent;
            this.ledIn11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn11.ImageList = imageList2;
            this.ledIn11.Location = new System.Drawing.Point(221, 165);
            this.ledIn11.Name = "ledIn11";
            this.ledIn11.OffImageIndex = 1;
            this.ledIn11.ShowAccelChar = false;
            this.ledIn11.Size = new System.Drawing.Size(199, 37);
            this.ledIn11.TabIndex = 1711;
            this.ledIn11.Text = "ledImageLabel11";
            this.ledIn11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn11.Value = false;
            // 
            // ledIn10
            // 
            this.ledIn10.BackColor = System.Drawing.Color.Transparent;
            this.ledIn10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn10.ImageList = imageList2;
            this.ledIn10.Location = new System.Drawing.Point(221, 125);
            this.ledIn10.Name = "ledIn10";
            this.ledIn10.OffImageIndex = 1;
            this.ledIn10.ShowAccelChar = false;
            this.ledIn10.Size = new System.Drawing.Size(199, 37);
            this.ledIn10.TabIndex = 1710;
            this.ledIn10.Text = "ledImageLabel10";
            this.ledIn10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn10.Value = false;
            // 
            // ledIn09
            // 
            this.ledIn09.BackColor = System.Drawing.Color.Transparent;
            this.ledIn09.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn09.ImageList = imageList2;
            this.ledIn09.Location = new System.Drawing.Point(221, 85);
            this.ledIn09.Name = "ledIn09";
            this.ledIn09.OffImageIndex = 1;
            this.ledIn09.ShowAccelChar = false;
            this.ledIn09.Size = new System.Drawing.Size(199, 37);
            this.ledIn09.TabIndex = 1709;
            this.ledIn09.Text = "ledImageLabel09";
            this.ledIn09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn09.Value = false;
            // 
            // ledIn08
            // 
            this.ledIn08.BackColor = System.Drawing.Color.Transparent;
            this.ledIn08.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn08.ImageList = imageList2;
            this.ledIn08.Location = new System.Drawing.Point(221, 45);
            this.ledIn08.Name = "ledIn08";
            this.ledIn08.OffImageIndex = 1;
            this.ledIn08.ShowAccelChar = false;
            this.ledIn08.Size = new System.Drawing.Size(199, 37);
            this.ledIn08.TabIndex = 1708;
            this.ledIn08.Text = "ledImageLabel08";
            this.ledIn08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn08.Value = false;
            // 
            // ledIn07
            // 
            this.ledIn07.BackColor = System.Drawing.Color.Transparent;
            this.ledIn07.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn07.ImageList = imageList2;
            this.ledIn07.Location = new System.Drawing.Point(7, 325);
            this.ledIn07.Name = "ledIn07";
            this.ledIn07.OffImageIndex = 1;
            this.ledIn07.ShowAccelChar = false;
            this.ledIn07.Size = new System.Drawing.Size(199, 37);
            this.ledIn07.TabIndex = 1707;
            this.ledIn07.Text = "X07: T1 Reset Switch";
            this.ledIn07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn07.Value = false;
            this.ledIn07.ValueChanged += new System.EventHandler(this.ledIn07_ValueChanged);
            // 
            // ledIn06
            // 
            this.ledIn06.BackColor = System.Drawing.Color.Transparent;
            this.ledIn06.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn06.ImageList = imageList2;
            this.ledIn06.Location = new System.Drawing.Point(7, 285);
            this.ledIn06.Name = "ledIn06";
            this.ledIn06.OffImageIndex = 1;
            this.ledIn06.ShowAccelChar = false;
            this.ledIn06.Size = new System.Drawing.Size(199, 37);
            this.ledIn06.TabIndex = 1706;
            this.ledIn06.Text = "ledImageLabel6";
            this.ledIn06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn06.Value = false;
            // 
            // ledIn05
            // 
            this.ledIn05.BackColor = System.Drawing.Color.Transparent;
            this.ledIn05.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn05.ImageList = imageList2;
            this.ledIn05.Location = new System.Drawing.Point(7, 245);
            this.ledIn05.Name = "ledIn05";
            this.ledIn05.OffImageIndex = 1;
            this.ledIn05.ShowAccelChar = false;
            this.ledIn05.Size = new System.Drawing.Size(199, 37);
            this.ledIn05.TabIndex = 1705;
            this.ledIn05.Text = "ledImageLabel5";
            this.ledIn05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn05.Value = false;
            // 
            // ledIn04
            // 
            this.ledIn04.BackColor = System.Drawing.Color.Transparent;
            this.ledIn04.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn04.ImageList = imageList2;
            this.ledIn04.Location = new System.Drawing.Point(7, 205);
            this.ledIn04.Name = "ledIn04";
            this.ledIn04.OffImageIndex = 1;
            this.ledIn04.ShowAccelChar = false;
            this.ledIn04.Size = new System.Drawing.Size(199, 37);
            this.ledIn04.TabIndex = 1704;
            this.ledIn04.Text = "ledImageLabel4";
            this.ledIn04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn04.Value = false;
            // 
            // ledIn03
            // 
            this.ledIn03.BackColor = System.Drawing.Color.Transparent;
            this.ledIn03.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn03.ImageList = imageList2;
            this.ledIn03.Location = new System.Drawing.Point(7, 165);
            this.ledIn03.Name = "ledIn03";
            this.ledIn03.OffImageIndex = 1;
            this.ledIn03.ShowAccelChar = false;
            this.ledIn03.Size = new System.Drawing.Size(199, 37);
            this.ledIn03.TabIndex = 1703;
            this.ledIn03.Text = "X03: EMO #3";
            this.ledIn03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn03.Value = false;
            this.ledIn03.ValueChanged += new System.EventHandler(this.ledIn03_ValueChanged);
            // 
            // ledIn02
            // 
            this.ledIn02.BackColor = System.Drawing.Color.Transparent;
            this.ledIn02.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn02.ImageList = imageList2;
            this.ledIn02.Location = new System.Drawing.Point(7, 125);
            this.ledIn02.Name = "ledIn02";
            this.ledIn02.OffImageIndex = 1;
            this.ledIn02.ShowAccelChar = false;
            this.ledIn02.Size = new System.Drawing.Size(199, 37);
            this.ledIn02.TabIndex = 1702;
            this.ledIn02.Text = "X02: EMO #2";
            this.ledIn02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn02.Value = false;
            this.ledIn02.ValueChanged += new System.EventHandler(this.ledIn02_ValueChanged);
            // 
            // ledIn01
            // 
            this.ledIn01.BackColor = System.Drawing.Color.Transparent;
            this.ledIn01.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn01.ImageList = imageList2;
            this.ledIn01.Location = new System.Drawing.Point(7, 85);
            this.ledIn01.Name = "ledIn01";
            this.ledIn01.OffImageIndex = 1;
            this.ledIn01.ShowAccelChar = false;
            this.ledIn01.Size = new System.Drawing.Size(199, 37);
            this.ledIn01.TabIndex = 1701;
            this.ledIn01.Text = "X01: EMO #1";
            this.ledIn01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn01.Value = false;
            this.ledIn01.ValueChanged += new System.EventHandler(this.ledIn01_ValueChanged);
            // 
            // ledIn00
            // 
            this.ledIn00.BackColor = System.Drawing.Color.Transparent;
            this.ledIn00.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn00.ImageList = imageList2;
            this.ledIn00.Location = new System.Drawing.Point(7, 45);
            this.ledIn00.Name = "ledIn00";
            this.ledIn00.OffImageIndex = 1;
            this.ledIn00.ShowAccelChar = false;
            this.ledIn00.Size = new System.Drawing.Size(199, 37);
            this.ledIn00.TabIndex = 1700;
            this.ledIn00.Text = "X00: Main Power";
            this.ledIn00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn00.Value = false;
            this.ledIn00.ValueChanged += new System.EventHandler(this.ledIn00_ValueChanged);
            // 
            // ledArray8
            // 
            this.ledArray8.DataServer = this.dsIO;
            this.ledArray8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray8.ImageList = imageList2;
            this.ledArray8.LEDCount = 8;
            this.ledArray8.Location = new System.Drawing.Point(662, 416);
            this.ledArray8.Name = "ledArray8";
            this.ledArray8.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray8.OnImageIndices = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray8.Size = new System.Drawing.Size(203, 322);
            this.ledArray8.TabIndex = 1387;
            this.ledArray8.Text = "ledImageArray3";
            this.ledArray8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray8.Value = false;
            // 
            // ledArray7
            // 
            this.ledArray7.DataServer = this.dsIO;
            this.ledArray7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray7.ImageList = imageList2;
            this.ledArray7.LEDCount = 8;
            this.ledArray7.Location = new System.Drawing.Point(439, 411);
            this.ledArray7.Name = "ledArray7";
            this.ledArray7.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray7.OnImageIndices = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray7.Size = new System.Drawing.Size(203, 322);
            this.ledArray7.TabIndex = 1386;
            this.ledArray7.Text = "ledImageArray3";
            this.ledArray7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray7.Value = false;
            // 
            // ledArray6
            // 
            this.ledArray6.DataServer = this.dsIO;
            this.ledArray6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray6.ImageList = imageList2;
            this.ledArray6.LEDCount = 8;
            this.ledArray6.Location = new System.Drawing.Point(221, 416);
            this.ledArray6.Name = "ledArray6";
            this.ledArray6.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray6.OnImageIndices = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray6.Size = new System.Drawing.Size(203, 322);
            this.ledArray6.TabIndex = 1385;
            this.ledArray6.Text = "ledImageArray3";
            this.ledArray6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray6.Value = false;
            // 
            // ledArray5
            // 
            this.ledArray5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledArray5.DataServer = this.dsIO;
            this.ledArray5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray5.ImageList = imageList2;
            this.ledArray5.LEDCount = 8;
            this.ledArray5.Location = new System.Drawing.Point(9, 416);
            this.ledArray5.Name = "ledArray5";
            this.ledArray5.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray5.OnImageIndices = new int[] {
        2,
        2,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray5.Size = new System.Drawing.Size(203, 322);
            this.ledArray5.TabIndex = 1384;
            this.ledArray5.Text = "ledImageArray3";
            this.ledArray5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray5.Value = false;
            // 
            // lblInputPort7
            // 
            this.lblInputPort7.BackColor = System.Drawing.Color.White;
            this.lblInputPort7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort7.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort7.Frame.CornerRound = 1;
            this.lblInputPort7.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort7.Location = new System.Drawing.Point(659, 378);
            this.lblInputPort7.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort7.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort7.Name = "lblInputPort7";
            this.lblInputPort7.ShowAccelChar = false;
            this.lblInputPort7.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort7.TabIndex = 1378;
            this.lblInputPort7.Text = "Port 7";
            this.lblInputPort7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort3
            // 
            this.lblInputPort3.BackColor = System.Drawing.Color.White;
            this.lblInputPort3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort3.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort3.Frame.CornerRound = 1;
            this.lblInputPort3.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort3.Location = new System.Drawing.Point(659, 6);
            this.lblInputPort3.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort3.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort3.Name = "lblInputPort3";
            this.lblInputPort3.ShowAccelChar = false;
            this.lblInputPort3.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort3.TabIndex = 1379;
            this.lblInputPort3.Text = "Port 3";
            this.lblInputPort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort6
            // 
            this.lblInputPort6.BackColor = System.Drawing.Color.White;
            this.lblInputPort6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort6.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort6.Frame.CornerRound = 1;
            this.lblInputPort6.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort6.Location = new System.Drawing.Point(439, 378);
            this.lblInputPort6.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort6.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort6.Name = "lblInputPort6";
            this.lblInputPort6.ShowAccelChar = false;
            this.lblInputPort6.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort6.TabIndex = 1376;
            this.lblInputPort6.Text = "Port 6";
            this.lblInputPort6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort2
            // 
            this.lblInputPort2.BackColor = System.Drawing.Color.White;
            this.lblInputPort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort2.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort2.Frame.CornerRound = 1;
            this.lblInputPort2.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort2.Location = new System.Drawing.Point(439, 6);
            this.lblInputPort2.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort2.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort2.Name = "lblInputPort2";
            this.lblInputPort2.ShowAccelChar = false;
            this.lblInputPort2.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort2.TabIndex = 1377;
            this.lblInputPort2.Text = "Port 2";
            this.lblInputPort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort5
            // 
            this.lblInputPort5.BackColor = System.Drawing.Color.White;
            this.lblInputPort5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort5.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort5.Frame.CornerRound = 1;
            this.lblInputPort5.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort5.Location = new System.Drawing.Point(222, 378);
            this.lblInputPort5.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort5.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort5.Name = "lblInputPort5";
            this.lblInputPort5.ShowAccelChar = false;
            this.lblInputPort5.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort5.TabIndex = 1374;
            this.lblInputPort5.Text = "Port 5";
            this.lblInputPort5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort1
            // 
            this.lblInputPort1.BackColor = System.Drawing.Color.White;
            this.lblInputPort1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort1.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort1.Frame.CornerRound = 1;
            this.lblInputPort1.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort1.Location = new System.Drawing.Point(222, 6);
            this.lblInputPort1.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort1.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort1.Name = "lblInputPort1";
            this.lblInputPort1.ShowAccelChar = false;
            this.lblInputPort1.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort1.TabIndex = 1375;
            this.lblInputPort1.Text = "Port 1";
            this.lblInputPort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort4
            // 
            this.lblInputPort4.BackColor = System.Drawing.Color.White;
            this.lblInputPort4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort4.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort4.Frame.CornerRound = 1;
            this.lblInputPort4.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort4.Location = new System.Drawing.Point(7, 378);
            this.lblInputPort4.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort4.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort4.Name = "lblInputPort4";
            this.lblInputPort4.ShowAccelChar = false;
            this.lblInputPort4.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort4.TabIndex = 1372;
            this.lblInputPort4.Text = "Port 4";
            this.lblInputPort4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort0
            // 
            this.lblInputPort0.BackColor = System.Drawing.Color.White;
            this.lblInputPort0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort0.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort0.Frame.CornerRound = 1;
            this.lblInputPort0.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort0.Location = new System.Drawing.Point(7, 6);
            this.lblInputPort0.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort0.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort0.Name = "lblInputPort0";
            this.lblInputPort0.ShowAccelChar = false;
            this.lblInputPort0.Size = new System.Drawing.Size(200, 29);
            this.lblInputPort0.TabIndex = 1373;
            this.lblInputPort0.Text = "Port 0";
            this.lblInputPort0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.switchOut63);
            this.tabPage3.Controls.Add(this.switchOut62);
            this.tabPage3.Controls.Add(this.switchOut61);
            this.tabPage3.Controls.Add(this.switchOut60);
            this.tabPage3.Controls.Add(this.switchOut59);
            this.tabPage3.Controls.Add(this.switchOut58);
            this.tabPage3.Controls.Add(this.switchOut57);
            this.tabPage3.Controls.Add(this.switchOut56);
            this.tabPage3.Controls.Add(this.switchOut55);
            this.tabPage3.Controls.Add(this.switchOut54);
            this.tabPage3.Controls.Add(this.switchOut53);
            this.tabPage3.Controls.Add(this.switchOut52);
            this.tabPage3.Controls.Add(this.switchOut51);
            this.tabPage3.Controls.Add(this.switchOut50);
            this.tabPage3.Controls.Add(this.switchOut49);
            this.tabPage3.Controls.Add(this.switchOut48);
            this.tabPage3.Controls.Add(this.switchOut47);
            this.tabPage3.Controls.Add(this.switchOut46);
            this.tabPage3.Controls.Add(this.switchOut45);
            this.tabPage3.Controls.Add(this.switchOut44);
            this.tabPage3.Controls.Add(this.switchOut43);
            this.tabPage3.Controls.Add(this.switchOut42);
            this.tabPage3.Controls.Add(this.switchOut41);
            this.tabPage3.Controls.Add(this.switchOut40);
            this.tabPage3.Controls.Add(this.switchOut39);
            this.tabPage3.Controls.Add(this.switchOut38);
            this.tabPage3.Controls.Add(this.switchOut37);
            this.tabPage3.Controls.Add(this.switchOut36);
            this.tabPage3.Controls.Add(this.switchOut35);
            this.tabPage3.Controls.Add(this.switchOut34);
            this.tabPage3.Controls.Add(this.switchOut33);
            this.tabPage3.Controls.Add(this.switchOut32);
            this.tabPage3.Controls.Add(this.switchOut31);
            this.tabPage3.Controls.Add(this.switchOut30);
            this.tabPage3.Controls.Add(this.switchOut29);
            this.tabPage3.Controls.Add(this.switchOut28);
            this.tabPage3.Controls.Add(this.switchOut27);
            this.tabPage3.Controls.Add(this.switchOut26);
            this.tabPage3.Controls.Add(this.switchOut25);
            this.tabPage3.Controls.Add(this.switchOut24);
            this.tabPage3.Controls.Add(this.switchOut23);
            this.tabPage3.Controls.Add(this.switchOut22);
            this.tabPage3.Controls.Add(this.switchOut21);
            this.tabPage3.Controls.Add(this.switchOut20);
            this.tabPage3.Controls.Add(this.switchOut19);
            this.tabPage3.Controls.Add(this.switchOut18);
            this.tabPage3.Controls.Add(this.switchOut17);
            this.tabPage3.Controls.Add(this.switchOut16);
            this.tabPage3.Controls.Add(this.switchOut15);
            this.tabPage3.Controls.Add(this.switchOut14);
            this.tabPage3.Controls.Add(this.switchOut13);
            this.tabPage3.Controls.Add(this.switchOut12);
            this.tabPage3.Controls.Add(this.switchOut11);
            this.tabPage3.Controls.Add(this.switchOut10);
            this.tabPage3.Controls.Add(this.switchOut9);
            this.tabPage3.Controls.Add(this.switchOut8);
            this.tabPage3.Controls.Add(this.switchOut7);
            this.tabPage3.Controls.Add(this.switchOut6);
            this.tabPage3.Controls.Add(this.switchOut5);
            this.tabPage3.Controls.Add(this.switchOut4);
            this.tabPage3.Controls.Add(this.switchOut3);
            this.tabPage3.Controls.Add(this.switchOut2);
            this.tabPage3.Controls.Add(this.switchOut1);
            this.tabPage3.Controls.Add(this.switchOut0);
            this.tabPage3.Controls.Add(this.lblOutputPort7);
            this.tabPage3.Controls.Add(this.lblOutputPort3);
            this.tabPage3.Controls.Add(this.lblOutputPort6);
            this.tabPage3.Controls.Add(this.lblOutputPort2);
            this.tabPage3.Controls.Add(this.lblOutputPort5);
            this.tabPage3.Controls.Add(this.lblOutputPort1);
            this.tabPage3.Controls.Add(this.lblOutputPort4);
            this.tabPage3.Controls.Add(this.lblOutputPort0);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 765);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "OUTPUT";
            // 
            // switchOut63
            // 
            this.switchOut63.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut63.Channel = null;
            this.switchOut63.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut63.Hint = null;
            this.switchOut63.Location = new System.Drawing.Point(658, 694);
            this.switchOut63.Name = "switchOut63";
            this.switchOut63.ShowHint = false;
            this.switchOut63.Size = new System.Drawing.Size(200, 38);
            this.switchOut63.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut63.TabIndex = 794;
            this.switchOut63.Text = "uiSwitch5";
            // 
            // switchOut62
            // 
            this.switchOut62.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut62.Channel = null;
            this.switchOut62.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut62.Hint = null;
            this.switchOut62.Location = new System.Drawing.Point(658, 654);
            this.switchOut62.Name = "switchOut62";
            this.switchOut62.ShowHint = false;
            this.switchOut62.Size = new System.Drawing.Size(200, 38);
            this.switchOut62.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut62.TabIndex = 793;
            this.switchOut62.Text = "uiSwitch6";
            // 
            // switchOut61
            // 
            this.switchOut61.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut61.Channel = null;
            this.switchOut61.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut61.Hint = null;
            this.switchOut61.Location = new System.Drawing.Point(658, 614);
            this.switchOut61.Name = "switchOut61";
            this.switchOut61.ShowHint = false;
            this.switchOut61.Size = new System.Drawing.Size(200, 38);
            this.switchOut61.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut61.TabIndex = 792;
            this.switchOut61.Text = "uiSwitch7";
            // 
            // switchOut60
            // 
            this.switchOut60.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut60.Channel = null;
            this.switchOut60.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut60.Hint = null;
            this.switchOut60.Location = new System.Drawing.Point(658, 574);
            this.switchOut60.Name = "switchOut60";
            this.switchOut60.ShowHint = false;
            this.switchOut60.Size = new System.Drawing.Size(200, 38);
            this.switchOut60.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut60.TabIndex = 791;
            this.switchOut60.Text = "uiSwitch8";
            // 
            // switchOut59
            // 
            this.switchOut59.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut59.Channel = null;
            this.switchOut59.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut59.Hint = null;
            this.switchOut59.Location = new System.Drawing.Point(658, 534);
            this.switchOut59.Name = "switchOut59";
            this.switchOut59.ShowHint = false;
            this.switchOut59.Size = new System.Drawing.Size(200, 38);
            this.switchOut59.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut59.TabIndex = 790;
            this.switchOut59.Text = "uiSwitch3";
            // 
            // switchOut58
            // 
            this.switchOut58.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut58.Channel = null;
            this.switchOut58.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut58.Hint = null;
            this.switchOut58.Location = new System.Drawing.Point(658, 494);
            this.switchOut58.Name = "switchOut58";
            this.switchOut58.ShowHint = false;
            this.switchOut58.Size = new System.Drawing.Size(200, 38);
            this.switchOut58.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut58.TabIndex = 789;
            this.switchOut58.Text = "uiSwitch4";
            // 
            // switchOut57
            // 
            this.switchOut57.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut57.Channel = null;
            this.switchOut57.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut57.Hint = null;
            this.switchOut57.Location = new System.Drawing.Point(658, 454);
            this.switchOut57.Name = "switchOut57";
            this.switchOut57.ShowHint = false;
            this.switchOut57.Size = new System.Drawing.Size(200, 38);
            this.switchOut57.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut57.TabIndex = 788;
            this.switchOut57.Text = "uiSwitch2";
            // 
            // switchOut56
            // 
            this.switchOut56.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut56.Channel = null;
            this.switchOut56.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut56.Hint = null;
            this.switchOut56.Location = new System.Drawing.Point(658, 415);
            this.switchOut56.Name = "switchOut56";
            this.switchOut56.ShowHint = false;
            this.switchOut56.Size = new System.Drawing.Size(200, 38);
            this.switchOut56.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut56.TabIndex = 787;
            this.switchOut56.Text = "uiSwitch1";
            // 
            // switchOut55
            // 
            this.switchOut55.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut55.Channel = null;
            this.switchOut55.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut55.Hint = null;
            this.switchOut55.Location = new System.Drawing.Point(441, 694);
            this.switchOut55.Name = "switchOut55";
            this.switchOut55.ShowHint = false;
            this.switchOut55.Size = new System.Drawing.Size(200, 38);
            this.switchOut55.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut55.TabIndex = 778;
            this.switchOut55.Text = "uiSwitch5";
            // 
            // switchOut54
            // 
            this.switchOut54.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut54.Channel = null;
            this.switchOut54.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut54.Hint = null;
            this.switchOut54.Location = new System.Drawing.Point(441, 654);
            this.switchOut54.Name = "switchOut54";
            this.switchOut54.ShowHint = false;
            this.switchOut54.Size = new System.Drawing.Size(200, 38);
            this.switchOut54.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut54.TabIndex = 777;
            this.switchOut54.Text = "uiSwitch6";
            // 
            // switchOut53
            // 
            this.switchOut53.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut53.Channel = null;
            this.switchOut53.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut53.Hint = null;
            this.switchOut53.Location = new System.Drawing.Point(441, 614);
            this.switchOut53.Name = "switchOut53";
            this.switchOut53.ShowHint = false;
            this.switchOut53.Size = new System.Drawing.Size(200, 38);
            this.switchOut53.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut53.TabIndex = 776;
            this.switchOut53.Text = "uiSwitch7";
            // 
            // switchOut52
            // 
            this.switchOut52.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut52.Channel = null;
            this.switchOut52.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut52.Hint = null;
            this.switchOut52.Location = new System.Drawing.Point(441, 574);
            this.switchOut52.Name = "switchOut52";
            this.switchOut52.ShowHint = false;
            this.switchOut52.Size = new System.Drawing.Size(200, 38);
            this.switchOut52.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut52.TabIndex = 775;
            this.switchOut52.Text = "uiSwitch8";
            // 
            // switchOut51
            // 
            this.switchOut51.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut51.Channel = null;
            this.switchOut51.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut51.Hint = null;
            this.switchOut51.Location = new System.Drawing.Point(441, 534);
            this.switchOut51.Name = "switchOut51";
            this.switchOut51.ShowHint = false;
            this.switchOut51.Size = new System.Drawing.Size(200, 38);
            this.switchOut51.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut51.TabIndex = 774;
            this.switchOut51.Text = "uiSwitch3";
            // 
            // switchOut50
            // 
            this.switchOut50.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut50.Channel = null;
            this.switchOut50.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut50.Hint = null;
            this.switchOut50.Location = new System.Drawing.Point(441, 494);
            this.switchOut50.Name = "switchOut50";
            this.switchOut50.ShowHint = false;
            this.switchOut50.Size = new System.Drawing.Size(200, 38);
            this.switchOut50.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut50.TabIndex = 773;
            this.switchOut50.Text = "uiSwitch4";
            // 
            // switchOut49
            // 
            this.switchOut49.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut49.Channel = null;
            this.switchOut49.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut49.Hint = null;
            this.switchOut49.Location = new System.Drawing.Point(441, 454);
            this.switchOut49.Name = "switchOut49";
            this.switchOut49.ShowHint = false;
            this.switchOut49.Size = new System.Drawing.Size(200, 38);
            this.switchOut49.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut49.TabIndex = 772;
            this.switchOut49.Text = "uiSwitch2";
            // 
            // switchOut48
            // 
            this.switchOut48.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut48.Channel = null;
            this.switchOut48.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut48.Hint = null;
            this.switchOut48.Location = new System.Drawing.Point(441, 415);
            this.switchOut48.Name = "switchOut48";
            this.switchOut48.ShowHint = false;
            this.switchOut48.Size = new System.Drawing.Size(200, 38);
            this.switchOut48.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut48.TabIndex = 771;
            this.switchOut48.Text = "uiSwitch1";
            // 
            // switchOut47
            // 
            this.switchOut47.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut47.Channel = null;
            this.switchOut47.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut47.Hint = null;
            this.switchOut47.Location = new System.Drawing.Point(223, 694);
            this.switchOut47.Name = "switchOut47";
            this.switchOut47.ShowHint = false;
            this.switchOut47.Size = new System.Drawing.Size(200, 38);
            this.switchOut47.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut47.TabIndex = 786;
            this.switchOut47.Text = "uiSwitch5";
            // 
            // switchOut46
            // 
            this.switchOut46.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut46.Channel = null;
            this.switchOut46.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut46.Hint = null;
            this.switchOut46.Location = new System.Drawing.Point(223, 654);
            this.switchOut46.Name = "switchOut46";
            this.switchOut46.ShowHint = false;
            this.switchOut46.Size = new System.Drawing.Size(200, 38);
            this.switchOut46.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut46.TabIndex = 785;
            this.switchOut46.Text = "uiSwitch6";
            // 
            // switchOut45
            // 
            this.switchOut45.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut45.Channel = null;
            this.switchOut45.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut45.Hint = null;
            this.switchOut45.Location = new System.Drawing.Point(223, 614);
            this.switchOut45.Name = "switchOut45";
            this.switchOut45.ShowHint = false;
            this.switchOut45.Size = new System.Drawing.Size(200, 38);
            this.switchOut45.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut45.TabIndex = 784;
            this.switchOut45.Text = "uiSwitch7";
            // 
            // switchOut44
            // 
            this.switchOut44.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut44.Channel = null;
            this.switchOut44.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut44.Hint = null;
            this.switchOut44.Location = new System.Drawing.Point(223, 574);
            this.switchOut44.Name = "switchOut44";
            this.switchOut44.ShowHint = false;
            this.switchOut44.Size = new System.Drawing.Size(200, 38);
            this.switchOut44.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut44.TabIndex = 783;
            this.switchOut44.Text = "uiSwitch8";
            // 
            // switchOut43
            // 
            this.switchOut43.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut43.Channel = null;
            this.switchOut43.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut43.Hint = null;
            this.switchOut43.Location = new System.Drawing.Point(223, 534);
            this.switchOut43.Name = "switchOut43";
            this.switchOut43.ShowHint = false;
            this.switchOut43.Size = new System.Drawing.Size(200, 38);
            this.switchOut43.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut43.TabIndex = 782;
            this.switchOut43.Text = "uiSwitch3";
            // 
            // switchOut42
            // 
            this.switchOut42.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut42.Channel = null;
            this.switchOut42.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut42.Hint = null;
            this.switchOut42.Location = new System.Drawing.Point(223, 494);
            this.switchOut42.Name = "switchOut42";
            this.switchOut42.ShowHint = false;
            this.switchOut42.Size = new System.Drawing.Size(200, 38);
            this.switchOut42.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut42.TabIndex = 781;
            this.switchOut42.Text = "uiSwitch4";
            // 
            // switchOut41
            // 
            this.switchOut41.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut41.Channel = null;
            this.switchOut41.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut41.Hint = null;
            this.switchOut41.Location = new System.Drawing.Point(223, 454);
            this.switchOut41.Name = "switchOut41";
            this.switchOut41.ShowHint = false;
            this.switchOut41.Size = new System.Drawing.Size(200, 38);
            this.switchOut41.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut41.TabIndex = 780;
            this.switchOut41.Text = "uiSwitch2";
            // 
            // switchOut40
            // 
            this.switchOut40.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut40.Channel = null;
            this.switchOut40.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut40.Hint = null;
            this.switchOut40.Location = new System.Drawing.Point(223, 414);
            this.switchOut40.Name = "switchOut40";
            this.switchOut40.ShowHint = false;
            this.switchOut40.Size = new System.Drawing.Size(200, 38);
            this.switchOut40.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut40.TabIndex = 779;
            this.switchOut40.Text = "uiSwitch1";
            // 
            // switchOut39
            // 
            this.switchOut39.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut39.Channel = null;
            this.switchOut39.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut39.Hint = null;
            this.switchOut39.Location = new System.Drawing.Point(7, 694);
            this.switchOut39.Name = "switchOut39";
            this.switchOut39.ShowHint = false;
            this.switchOut39.Size = new System.Drawing.Size(200, 38);
            this.switchOut39.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut39.TabIndex = 770;
            this.switchOut39.Text = "uiSwitch5";
            // 
            // switchOut38
            // 
            this.switchOut38.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut38.Channel = null;
            this.switchOut38.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut38.Hint = null;
            this.switchOut38.Location = new System.Drawing.Point(7, 654);
            this.switchOut38.Name = "switchOut38";
            this.switchOut38.ShowHint = false;
            this.switchOut38.Size = new System.Drawing.Size(200, 38);
            this.switchOut38.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut38.TabIndex = 769;
            this.switchOut38.Text = "uiSwitch6";
            // 
            // switchOut37
            // 
            this.switchOut37.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut37.Channel = null;
            this.switchOut37.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut37.Hint = null;
            this.switchOut37.Location = new System.Drawing.Point(7, 614);
            this.switchOut37.Name = "switchOut37";
            this.switchOut37.ShowHint = false;
            this.switchOut37.Size = new System.Drawing.Size(200, 38);
            this.switchOut37.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut37.TabIndex = 768;
            this.switchOut37.Text = "uiSwitch7";
            // 
            // switchOut36
            // 
            this.switchOut36.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut36.Channel = null;
            this.switchOut36.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut36.Hint = null;
            this.switchOut36.Location = new System.Drawing.Point(7, 574);
            this.switchOut36.Name = "switchOut36";
            this.switchOut36.ShowHint = false;
            this.switchOut36.Size = new System.Drawing.Size(200, 38);
            this.switchOut36.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut36.TabIndex = 767;
            this.switchOut36.Text = "uiSwitch8";
            // 
            // switchOut35
            // 
            this.switchOut35.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut35.Channel = null;
            this.switchOut35.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut35.Hint = null;
            this.switchOut35.Location = new System.Drawing.Point(7, 534);
            this.switchOut35.Name = "switchOut35";
            this.switchOut35.ShowHint = false;
            this.switchOut35.Size = new System.Drawing.Size(200, 38);
            this.switchOut35.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut35.TabIndex = 766;
            this.switchOut35.Text = "uiSwitch3";
            // 
            // switchOut34
            // 
            this.switchOut34.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut34.Channel = null;
            this.switchOut34.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut34.Hint = null;
            this.switchOut34.Location = new System.Drawing.Point(7, 494);
            this.switchOut34.Name = "switchOut34";
            this.switchOut34.ShowHint = false;
            this.switchOut34.Size = new System.Drawing.Size(200, 38);
            this.switchOut34.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut34.TabIndex = 765;
            this.switchOut34.Text = "uiSwitch4";
            // 
            // switchOut33
            // 
            this.switchOut33.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut33.Channel = null;
            this.switchOut33.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut33.Hint = null;
            this.switchOut33.Location = new System.Drawing.Point(7, 454);
            this.switchOut33.Name = "switchOut33";
            this.switchOut33.ShowHint = false;
            this.switchOut33.Size = new System.Drawing.Size(200, 38);
            this.switchOut33.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut33.TabIndex = 764;
            this.switchOut33.Text = "uiSwitch2";
            // 
            // switchOut32
            // 
            this.switchOut32.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut32.Channel = null;
            this.switchOut32.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut32.Hint = null;
            this.switchOut32.Location = new System.Drawing.Point(7, 414);
            this.switchOut32.Name = "switchOut32";
            this.switchOut32.ShowHint = false;
            this.switchOut32.Size = new System.Drawing.Size(200, 38);
            this.switchOut32.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut32.TabIndex = 763;
            this.switchOut32.Text = "uiSwitch1";
            // 
            // switchOut31
            // 
            this.switchOut31.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut31.Channel = null;
            this.switchOut31.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut31.Hint = null;
            this.switchOut31.Location = new System.Drawing.Point(657, 321);
            this.switchOut31.Name = "switchOut31";
            this.switchOut31.ShowHint = false;
            this.switchOut31.Size = new System.Drawing.Size(200, 38);
            this.switchOut31.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut31.TabIndex = 762;
            this.switchOut31.Text = "uiSwitch5";
            // 
            // switchOut30
            // 
            this.switchOut30.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut30.Channel = null;
            this.switchOut30.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut30.Hint = null;
            this.switchOut30.Location = new System.Drawing.Point(657, 281);
            this.switchOut30.Name = "switchOut30";
            this.switchOut30.ShowHint = false;
            this.switchOut30.Size = new System.Drawing.Size(200, 38);
            this.switchOut30.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut30.TabIndex = 761;
            this.switchOut30.Text = "uiSwitch6";
            // 
            // switchOut29
            // 
            this.switchOut29.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut29.Channel = null;
            this.switchOut29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut29.Hint = null;
            this.switchOut29.Location = new System.Drawing.Point(657, 241);
            this.switchOut29.Name = "switchOut29";
            this.switchOut29.ShowHint = false;
            this.switchOut29.Size = new System.Drawing.Size(200, 38);
            this.switchOut29.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut29.TabIndex = 760;
            this.switchOut29.Text = "uiSwitch7";
            // 
            // switchOut28
            // 
            this.switchOut28.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut28.Channel = null;
            this.switchOut28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut28.Hint = null;
            this.switchOut28.Location = new System.Drawing.Point(657, 201);
            this.switchOut28.Name = "switchOut28";
            this.switchOut28.ShowHint = false;
            this.switchOut28.Size = new System.Drawing.Size(200, 38);
            this.switchOut28.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut28.TabIndex = 759;
            this.switchOut28.Text = "uiSwitch8";
            // 
            // switchOut27
            // 
            this.switchOut27.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut27.Channel = null;
            this.switchOut27.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut27.Hint = null;
            this.switchOut27.Location = new System.Drawing.Point(657, 161);
            this.switchOut27.Name = "switchOut27";
            this.switchOut27.ShowHint = false;
            this.switchOut27.Size = new System.Drawing.Size(200, 38);
            this.switchOut27.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut27.TabIndex = 758;
            this.switchOut27.Text = "uiSwitch3";
            // 
            // switchOut26
            // 
            this.switchOut26.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut26.Channel = null;
            this.switchOut26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut26.Hint = null;
            this.switchOut26.Location = new System.Drawing.Point(657, 121);
            this.switchOut26.Name = "switchOut26";
            this.switchOut26.ShowHint = false;
            this.switchOut26.Size = new System.Drawing.Size(200, 38);
            this.switchOut26.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut26.TabIndex = 757;
            this.switchOut26.Text = "uiSwitch4";
            // 
            // switchOut25
            // 
            this.switchOut25.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut25.Channel = null;
            this.switchOut25.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut25.Hint = null;
            this.switchOut25.Location = new System.Drawing.Point(657, 81);
            this.switchOut25.Name = "switchOut25";
            this.switchOut25.ShowHint = false;
            this.switchOut25.Size = new System.Drawing.Size(200, 38);
            this.switchOut25.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut25.TabIndex = 756;
            this.switchOut25.Text = "uiSwitch2";
            // 
            // switchOut24
            // 
            this.switchOut24.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut24.Channel = null;
            this.switchOut24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut24.Hint = null;
            this.switchOut24.Location = new System.Drawing.Point(657, 41);
            this.switchOut24.Name = "switchOut24";
            this.switchOut24.ShowHint = false;
            this.switchOut24.Size = new System.Drawing.Size(200, 38);
            this.switchOut24.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut24.TabIndex = 755;
            this.switchOut24.Text = "uiSwitch1";
            // 
            // switchOut23
            // 
            this.switchOut23.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut23.Channel = null;
            this.switchOut23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut23.Hint = null;
            this.switchOut23.Location = new System.Drawing.Point(440, 321);
            this.switchOut23.Name = "switchOut23";
            this.switchOut23.ShowHint = false;
            this.switchOut23.Size = new System.Drawing.Size(200, 38);
            this.switchOut23.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut23.TabIndex = 746;
            this.switchOut23.Text = "uiSwitch5";
            // 
            // switchOut22
            // 
            this.switchOut22.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut22.Channel = null;
            this.switchOut22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut22.Hint = null;
            this.switchOut22.Location = new System.Drawing.Point(440, 281);
            this.switchOut22.Name = "switchOut22";
            this.switchOut22.ShowHint = false;
            this.switchOut22.Size = new System.Drawing.Size(200, 38);
            this.switchOut22.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut22.TabIndex = 745;
            this.switchOut22.Text = "uiSwitch6";
            // 
            // switchOut21
            // 
            this.switchOut21.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut21.Channel = null;
            this.switchOut21.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut21.Hint = null;
            this.switchOut21.Location = new System.Drawing.Point(440, 241);
            this.switchOut21.Name = "switchOut21";
            this.switchOut21.ShowHint = false;
            this.switchOut21.Size = new System.Drawing.Size(200, 38);
            this.switchOut21.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut21.TabIndex = 744;
            this.switchOut21.Text = "uiSwitch7";
            // 
            // switchOut20
            // 
            this.switchOut20.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut20.Channel = null;
            this.switchOut20.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut20.Hint = null;
            this.switchOut20.Location = new System.Drawing.Point(440, 201);
            this.switchOut20.Name = "switchOut20";
            this.switchOut20.ShowHint = false;
            this.switchOut20.Size = new System.Drawing.Size(200, 38);
            this.switchOut20.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut20.TabIndex = 743;
            this.switchOut20.Text = "uiSwitch8";
            // 
            // switchOut19
            // 
            this.switchOut19.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut19.Channel = null;
            this.switchOut19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut19.Hint = null;
            this.switchOut19.Location = new System.Drawing.Point(440, 161);
            this.switchOut19.Name = "switchOut19";
            this.switchOut19.ShowHint = false;
            this.switchOut19.Size = new System.Drawing.Size(200, 38);
            this.switchOut19.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut19.TabIndex = 742;
            this.switchOut19.Text = "uiSwitch3";
            // 
            // switchOut18
            // 
            this.switchOut18.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut18.Channel = null;
            this.switchOut18.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut18.Hint = null;
            this.switchOut18.Location = new System.Drawing.Point(440, 121);
            this.switchOut18.Name = "switchOut18";
            this.switchOut18.ShowHint = false;
            this.switchOut18.Size = new System.Drawing.Size(200, 38);
            this.switchOut18.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut18.TabIndex = 741;
            this.switchOut18.Text = "uiSwitch4";
            // 
            // switchOut17
            // 
            this.switchOut17.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut17.Channel = null;
            this.switchOut17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut17.Hint = null;
            this.switchOut17.Location = new System.Drawing.Point(440, 81);
            this.switchOut17.Name = "switchOut17";
            this.switchOut17.ShowHint = false;
            this.switchOut17.Size = new System.Drawing.Size(200, 38);
            this.switchOut17.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut17.TabIndex = 740;
            this.switchOut17.Text = "uiSwitch2";
            // 
            // switchOut16
            // 
            this.switchOut16.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut16.Channel = null;
            this.switchOut16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut16.Hint = null;
            this.switchOut16.Location = new System.Drawing.Point(440, 41);
            this.switchOut16.Name = "switchOut16";
            this.switchOut16.ShowHint = false;
            this.switchOut16.Size = new System.Drawing.Size(200, 38);
            this.switchOut16.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut16.TabIndex = 739;
            this.switchOut16.Text = "uiSwitch1";
            // 
            // switchOut15
            // 
            this.switchOut15.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut15.Channel = null;
            this.switchOut15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut15.Hint = null;
            this.switchOut15.Location = new System.Drawing.Point(222, 321);
            this.switchOut15.Name = "switchOut15";
            this.switchOut15.ShowHint = false;
            this.switchOut15.Size = new System.Drawing.Size(200, 38);
            this.switchOut15.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut15.TabIndex = 754;
            this.switchOut15.Text = "uiSwitch5";
            // 
            // switchOut14
            // 
            this.switchOut14.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut14.Channel = null;
            this.switchOut14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut14.Hint = null;
            this.switchOut14.Location = new System.Drawing.Point(222, 281);
            this.switchOut14.Name = "switchOut14";
            this.switchOut14.ShowHint = false;
            this.switchOut14.Size = new System.Drawing.Size(200, 38);
            this.switchOut14.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut14.TabIndex = 753;
            this.switchOut14.Text = "uiSwitch6";
            // 
            // switchOut13
            // 
            this.switchOut13.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut13.Channel = null;
            this.switchOut13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut13.Hint = null;
            this.switchOut13.Location = new System.Drawing.Point(222, 241);
            this.switchOut13.Name = "switchOut13";
            this.switchOut13.ShowHint = false;
            this.switchOut13.Size = new System.Drawing.Size(200, 38);
            this.switchOut13.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut13.TabIndex = 752;
            this.switchOut13.Text = "uiSwitch7";
            // 
            // switchOut12
            // 
            this.switchOut12.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut12.Channel = null;
            this.switchOut12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut12.Hint = null;
            this.switchOut12.Location = new System.Drawing.Point(222, 201);
            this.switchOut12.Name = "switchOut12";
            this.switchOut12.ShowHint = false;
            this.switchOut12.Size = new System.Drawing.Size(200, 38);
            this.switchOut12.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut12.TabIndex = 751;
            this.switchOut12.Text = "uiSwitch8";
            // 
            // switchOut11
            // 
            this.switchOut11.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut11.Channel = null;
            this.switchOut11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut11.Hint = null;
            this.switchOut11.Location = new System.Drawing.Point(222, 161);
            this.switchOut11.Name = "switchOut11";
            this.switchOut11.ShowHint = false;
            this.switchOut11.Size = new System.Drawing.Size(200, 38);
            this.switchOut11.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut11.TabIndex = 750;
            this.switchOut11.Text = "uiSwitch3";
            // 
            // switchOut10
            // 
            this.switchOut10.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut10.Channel = null;
            this.switchOut10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut10.Hint = null;
            this.switchOut10.Location = new System.Drawing.Point(222, 121);
            this.switchOut10.Name = "switchOut10";
            this.switchOut10.ShowHint = false;
            this.switchOut10.Size = new System.Drawing.Size(200, 38);
            this.switchOut10.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut10.TabIndex = 749;
            this.switchOut10.Text = "uiSwitch4";
            // 
            // switchOut9
            // 
            this.switchOut9.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut9.Channel = null;
            this.switchOut9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut9.Hint = null;
            this.switchOut9.Location = new System.Drawing.Point(222, 81);
            this.switchOut9.Name = "switchOut9";
            this.switchOut9.ShowHint = false;
            this.switchOut9.Size = new System.Drawing.Size(200, 38);
            this.switchOut9.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut9.TabIndex = 748;
            this.switchOut9.Text = "uiSwitch2";
            // 
            // switchOut8
            // 
            this.switchOut8.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut8.Channel = null;
            this.switchOut8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut8.Hint = null;
            this.switchOut8.Location = new System.Drawing.Point(222, 41);
            this.switchOut8.Name = "switchOut8";
            this.switchOut8.ShowHint = false;
            this.switchOut8.Size = new System.Drawing.Size(200, 38);
            this.switchOut8.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut8.TabIndex = 747;
            this.switchOut8.Text = "uiSwitch1";
            // 
            // switchOut7
            // 
            this.switchOut7.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut7.Channel = null;
            this.switchOut7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut7.Hint = null;
            this.switchOut7.Location = new System.Drawing.Point(6, 321);
            this.switchOut7.Name = "switchOut7";
            this.switchOut7.ShowHint = false;
            this.switchOut7.Size = new System.Drawing.Size(200, 38);
            this.switchOut7.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut7.TabIndex = 738;
            this.switchOut7.Text = "uiSwitch７";
            // 
            // switchOut6
            // 
            this.switchOut6.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut6.Channel = null;
            this.switchOut6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut6.Hint = null;
            this.switchOut6.Location = new System.Drawing.Point(6, 281);
            this.switchOut6.Name = "switchOut6";
            this.switchOut6.ShowHint = false;
            this.switchOut6.Size = new System.Drawing.Size(200, 38);
            this.switchOut6.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut6.TabIndex = 737;
            this.switchOut6.Text = "uiSwitch6";
            // 
            // switchOut5
            // 
            this.switchOut5.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut5.Channel = null;
            this.switchOut5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut5.Hint = null;
            this.switchOut5.Location = new System.Drawing.Point(6, 241);
            this.switchOut5.Name = "switchOut5";
            this.switchOut5.ShowHint = false;
            this.switchOut5.Size = new System.Drawing.Size(200, 38);
            this.switchOut5.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut5.TabIndex = 736;
            this.switchOut5.Text = "uiSwitch５";
            // 
            // switchOut4
            // 
            this.switchOut4.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut4.Channel = null;
            this.switchOut4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut4.Hint = null;
            this.switchOut4.Location = new System.Drawing.Point(6, 201);
            this.switchOut4.Name = "switchOut4";
            this.switchOut4.ShowHint = false;
            this.switchOut4.Size = new System.Drawing.Size(200, 38);
            this.switchOut4.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut4.TabIndex = 735;
            this.switchOut4.Text = "uiSwitch４";
            // 
            // switchOut3
            // 
            this.switchOut3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut3.Channel = null;
            this.switchOut3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut3.Hint = null;
            this.switchOut3.Location = new System.Drawing.Point(6, 161);
            this.switchOut3.Name = "switchOut3";
            this.switchOut3.ShowHint = false;
            this.switchOut3.Size = new System.Drawing.Size(200, 38);
            this.switchOut3.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut3.TabIndex = 734;
            this.switchOut3.Text = "uiSwitch3";
            // 
            // switchOut2
            // 
            this.switchOut2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut2.Channel = null;
            this.switchOut2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut2.Hint = null;
            this.switchOut2.Location = new System.Drawing.Point(6, 121);
            this.switchOut2.Name = "switchOut2";
            this.switchOut2.ShowHint = false;
            this.switchOut2.Size = new System.Drawing.Size(200, 38);
            this.switchOut2.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut2.TabIndex = 733;
            this.switchOut2.Text = "uiSwitch２";
            // 
            // switchOut1
            // 
            this.switchOut1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut1.Channel = null;
            this.switchOut1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut1.Hint = null;
            this.switchOut1.Location = new System.Drawing.Point(6, 81);
            this.switchOut1.Name = "switchOut1";
            this.switchOut1.ShowHint = false;
            this.switchOut1.Size = new System.Drawing.Size(200, 38);
            this.switchOut1.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut1.TabIndex = 732;
            this.switchOut1.Text = "uiSwitch１";
            // 
            // switchOut0
            // 
            this.switchOut0.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut0.Channel = null;
            this.switchOut0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut0.Hint = null;
            this.switchOut0.Location = new System.Drawing.Point(6, 41);
            this.switchOut0.Name = "switchOut0";
            this.switchOut0.ShowHint = false;
            this.switchOut0.Size = new System.Drawing.Size(200, 38);
            this.switchOut0.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchOut0.TabIndex = 731;
            this.switchOut0.Text = "uiSwitch０";
            // 
            // lblOutputPort7
            // 
            this.lblOutputPort7.BackColor = System.Drawing.Color.White;
            this.lblOutputPort7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort7.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort7.Location = new System.Drawing.Point(659, 378);
            this.lblOutputPort7.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort7.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort7.Name = "lblOutputPort7";
            this.lblOutputPort7.ShowAccelChar = false;
            this.lblOutputPort7.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort7.TabIndex = 730;
            this.lblOutputPort7.Text = "Port 7";
            this.lblOutputPort7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort3
            // 
            this.lblOutputPort3.BackColor = System.Drawing.Color.White;
            this.lblOutputPort3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort3.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort3.Location = new System.Drawing.Point(659, 6);
            this.lblOutputPort3.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort3.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort3.Name = "lblOutputPort3";
            this.lblOutputPort3.ShowAccelChar = false;
            this.lblOutputPort3.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort3.TabIndex = 729;
            this.lblOutputPort3.Text = "Port 3";
            this.lblOutputPort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort6
            // 
            this.lblOutputPort6.BackColor = System.Drawing.Color.White;
            this.lblOutputPort6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort6.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort6.Location = new System.Drawing.Point(439, 378);
            this.lblOutputPort6.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort6.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort6.Name = "lblOutputPort6";
            this.lblOutputPort6.ShowAccelChar = false;
            this.lblOutputPort6.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort6.TabIndex = 728;
            this.lblOutputPort6.Text = "Port 6";
            this.lblOutputPort6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort2
            // 
            this.lblOutputPort2.BackColor = System.Drawing.Color.White;
            this.lblOutputPort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort2.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort2.Location = new System.Drawing.Point(439, 6);
            this.lblOutputPort2.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort2.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort2.Name = "lblOutputPort2";
            this.lblOutputPort2.ShowAccelChar = false;
            this.lblOutputPort2.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort2.TabIndex = 727;
            this.lblOutputPort2.Text = "Port 2";
            this.lblOutputPort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort5
            // 
            this.lblOutputPort5.BackColor = System.Drawing.Color.White;
            this.lblOutputPort5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort5.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort5.Location = new System.Drawing.Point(222, 378);
            this.lblOutputPort5.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort5.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort5.Name = "lblOutputPort5";
            this.lblOutputPort5.ShowAccelChar = false;
            this.lblOutputPort5.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort5.TabIndex = 725;
            this.lblOutputPort5.Text = "Port 5";
            this.lblOutputPort5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort1
            // 
            this.lblOutputPort1.BackColor = System.Drawing.Color.White;
            this.lblOutputPort1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort1.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort1.Location = new System.Drawing.Point(222, 6);
            this.lblOutputPort1.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort1.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort1.Name = "lblOutputPort1";
            this.lblOutputPort1.ShowAccelChar = false;
            this.lblOutputPort1.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort1.TabIndex = 726;
            this.lblOutputPort1.Text = "Port 1";
            this.lblOutputPort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort4
            // 
            this.lblOutputPort4.BackColor = System.Drawing.Color.White;
            this.lblOutputPort4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort4.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort4.Location = new System.Drawing.Point(7, 378);
            this.lblOutputPort4.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort4.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort4.Name = "lblOutputPort4";
            this.lblOutputPort4.ShowAccelChar = false;
            this.lblOutputPort4.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort4.TabIndex = 724;
            this.lblOutputPort4.Text = "Port 4";
            this.lblOutputPort4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort0
            // 
            this.lblOutputPort0.BackColor = System.Drawing.Color.White;
            this.lblOutputPort0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort0.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort0.Location = new System.Drawing.Point(7, 6);
            this.lblOutputPort0.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort0.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort0.Name = "lblOutputPort0";
            this.lblOutputPort0.ShowAccelChar = false;
            this.lblOutputPort0.Size = new System.Drawing.Size(200, 29);
            this.lblOutputPort0.TabIndex = 723;
            this.lblOutputPort0.Text = "Port 0";
            this.lblOutputPort0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panStatus
            // 
            this.panStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panStatus.Controls.Add(this.ledZMotionDone);
            this.panStatus.Controls.Add(this.ledY2MotionDone);
            this.panStatus.Controls.Add(this.ledY1MotionDone);
            this.panStatus.Controls.Add(this.ledXMotionDone);
            this.panStatus.Controls.Add(this.gradientLabel1);
            this.panStatus.Controls.Add(this.ledXServo);
            this.panStatus.Controls.Add(this.gradLabel26);
            this.panStatus.Controls.Add(this.gradLabel24);
            this.panStatus.Controls.Add(this.gradLabel31);
            this.panStatus.Controls.Add(this.gradLabel19);
            this.panStatus.Controls.Add(this.gradLabel40);
            this.panStatus.Controls.Add(this.gradLabel32);
            this.panStatus.Controls.Add(this.gradLabel21);
            this.panStatus.Controls.Add(this.gradLabel33);
            this.panStatus.Controls.Add(this.gradLabel34);
            this.panStatus.Controls.Add(this.gradLabel28);
            this.panStatus.Controls.Add(this.gradLabel35);
            this.panStatus.Controls.Add(this.gradLabel17);
            this.panStatus.Controls.Add(this.gradLabel36);
            this.panStatus.Controls.Add(this.gradLabel41);
            this.panStatus.Controls.Add(this.ledZHome);
            this.panStatus.Controls.Add(this.gradLabel39);
            this.panStatus.Controls.Add(this.ledZAlarm);
            this.panStatus.Controls.Add(this.gradLabel42);
            this.panStatus.Controls.Add(this.gradLabel29);
            this.panStatus.Controls.Add(this.ledZInposition);
            this.panStatus.Controls.Add(this.gradLabel37);
            this.panStatus.Controls.Add(this.viZVelocity);
            this.panStatus.Controls.Add(this.ledZCW);
            this.panStatus.Controls.Add(this.ledZServo);
            this.panStatus.Controls.Add(this.ledXCCW);
            this.panStatus.Controls.Add(this.ledZCCW);
            this.panStatus.Controls.Add(this.ledY1CCW);
            this.panStatus.Controls.Add(this.ledY2Home);
            this.panStatus.Controls.Add(this.ledY2Alarm);
            this.panStatus.Controls.Add(this.ledXCW);
            this.panStatus.Controls.Add(this.ledY1Home);
            this.panStatus.Controls.Add(this.viXVelocity);
            this.panStatus.Controls.Add(this.ledY1Alarm);
            this.panStatus.Controls.Add(this.ledY1Servo);
            this.panStatus.Controls.Add(this.ledY2Inposition);
            this.panStatus.Controls.Add(this.viXPosition);
            this.panStatus.Controls.Add(this.viY1Position);
            this.panStatus.Controls.Add(this.viY2Position);
            this.panStatus.Controls.Add(this.viZPosition);
            this.panStatus.Controls.Add(this.ledY2CW);
            this.panStatus.Controls.Add(this.ledY2CCW);
            this.panStatus.Controls.Add(this.ledY1Inposition);
            this.panStatus.Controls.Add(this.viY1Velocity);
            this.panStatus.Controls.Add(this.ledY1CW);
            this.panStatus.Controls.Add(this.ledXInposition);
            this.panStatus.Controls.Add(this.ledXHome);
            this.panStatus.Controls.Add(this.ledY2Servo);
            this.panStatus.Controls.Add(this.viY2Velocity);
            this.panStatus.Controls.Add(this.ledXAlarm);
            this.panStatus.Controls.Add(this.uiLine20);
            this.panStatus.Location = new System.Drawing.Point(3, 3);
            this.panStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(486, 400);
            this.panStatus.TabIndex = 1128;
            this.panStatus.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panStatus.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panStatus.TitleText = "Motor Status";
            this.panStatus.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledZMotionDone
            // 
            this.ledZMotionDone.BackColor = System.Drawing.Color.Transparent;
            this.ledZMotionDone.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZMotionDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZMotionDone.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZMotionDone.ForeColor = System.Drawing.Color.White;
            this.ledZMotionDone.Frame.Visible = false;
            this.ledZMotionDone.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZMotionDone.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZMotionDone.Location = new System.Drawing.Point(386, 221);
            this.ledZMotionDone.Name = "ledZMotionDone";
            this.ledZMotionDone.ShowAccelChar = false;
            this.ledZMotionDone.Size = new System.Drawing.Size(89, 26);
            this.ledZMotionDone.TabIndex = 889;
            this.ledZMotionDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2MotionDone
            // 
            this.ledY2MotionDone.BackColor = System.Drawing.Color.Transparent;
            this.ledY2MotionDone.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2MotionDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2MotionDone.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2MotionDone.ForeColor = System.Drawing.Color.White;
            this.ledY2MotionDone.Frame.Visible = false;
            this.ledY2MotionDone.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2MotionDone.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2MotionDone.Location = new System.Drawing.Point(295, 221);
            this.ledY2MotionDone.Name = "ledY2MotionDone";
            this.ledY2MotionDone.ShowAccelChar = false;
            this.ledY2MotionDone.Size = new System.Drawing.Size(89, 26);
            this.ledY2MotionDone.TabIndex = 890;
            this.ledY2MotionDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1MotionDone
            // 
            this.ledY1MotionDone.BackColor = System.Drawing.Color.Transparent;
            this.ledY1MotionDone.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1MotionDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1MotionDone.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1MotionDone.ForeColor = System.Drawing.Color.White;
            this.ledY1MotionDone.Frame.Visible = false;
            this.ledY1MotionDone.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1MotionDone.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1MotionDone.Location = new System.Drawing.Point(204, 221);
            this.ledY1MotionDone.Name = "ledY1MotionDone";
            this.ledY1MotionDone.ShowAccelChar = false;
            this.ledY1MotionDone.Size = new System.Drawing.Size(89, 26);
            this.ledY1MotionDone.TabIndex = 891;
            this.ledY1MotionDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXMotionDone
            // 
            this.ledXMotionDone.BackColor = System.Drawing.Color.Transparent;
            this.ledXMotionDone.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXMotionDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXMotionDone.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXMotionDone.ForeColor = System.Drawing.Color.White;
            this.ledXMotionDone.Frame.Visible = false;
            this.ledXMotionDone.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXMotionDone.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXMotionDone.Location = new System.Drawing.Point(113, 221);
            this.ledXMotionDone.Name = "ledXMotionDone";
            this.ledXMotionDone.ShowAccelChar = false;
            this.ledXMotionDone.Size = new System.Drawing.Size(89, 26);
            this.ledXMotionDone.TabIndex = 892;
            this.ledXMotionDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gradientLabel1.Location = new System.Drawing.Point(9, 221);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.ShowAccelChar = false;
            this.gradientLabel1.Size = new System.Drawing.Size(101, 26);
            this.gradientLabel1.TabIndex = 888;
            this.gradientLabel1.Text = "MotionDone";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledXServo
            // 
            this.ledXServo.BackColor = System.Drawing.Color.Transparent;
            this.ledXServo.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXServo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXServo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXServo.ForeColor = System.Drawing.Color.White;
            this.ledXServo.Frame.Visible = false;
            this.ledXServo.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXServo.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXServo.Location = new System.Drawing.Point(113, 192);
            this.ledXServo.Name = "ledXServo";
            this.ledXServo.ShowAccelChar = false;
            this.ledXServo.Size = new System.Drawing.Size(89, 26);
            this.ledXServo.TabIndex = 887;
            this.ledXServo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel26
            // 
            this.gradLabel26.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel26.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel26.GradientEnable = false;
            this.gradLabel26.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel26.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel26.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel26.Location = new System.Drawing.Point(9, 97);
            this.gradLabel26.Name = "gradLabel26";
            this.gradLabel26.ShowAccelChar = false;
            this.gradLabel26.Size = new System.Drawing.Size(101, 26);
            this.gradLabel26.TabIndex = 663;
            this.gradLabel26.Text = "Velocity";
            this.gradLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel24
            // 
            this.gradLabel24.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel24.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel24.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel24.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel24.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel24.Location = new System.Drawing.Point(113, 68);
            this.gradLabel24.Name = "gradLabel24";
            this.gradLabel24.ShowAccelChar = false;
            this.gradLabel24.Size = new System.Drawing.Size(89, 26);
            this.gradLabel24.TabIndex = 659;
            this.gradLabel24.Text = "X";
            this.gradLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel31
            // 
            this.gradLabel31.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel31.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel31.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel31.GradientEnable = false;
            this.gradLabel31.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel31.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel31.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel31.Location = new System.Drawing.Point(9, 192);
            this.gradLabel31.Name = "gradLabel31";
            this.gradLabel31.ShowAccelChar = false;
            this.gradLabel31.Size = new System.Drawing.Size(101, 26);
            this.gradLabel31.TabIndex = 662;
            this.gradLabel31.Text = "Servo On";
            this.gradLabel31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel19
            // 
            this.gradLabel19.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel19.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel19.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel19.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel19.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel19.Location = new System.Drawing.Point(205, 68);
            this.gradLabel19.Name = "gradLabel19";
            this.gradLabel19.ShowAccelChar = false;
            this.gradLabel19.Size = new System.Drawing.Size(89, 26);
            this.gradLabel19.TabIndex = 658;
            this.gradLabel19.Text = "Y1";
            this.gradLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel40
            // 
            this.gradLabel40.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel40.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel40.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel40.GradientEnable = false;
            this.gradLabel40.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel40.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel40.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel40.Location = new System.Drawing.Point(9, 308);
            this.gradLabel40.Name = "gradLabel40";
            this.gradLabel40.ShowAccelChar = false;
            this.gradLabel40.Size = new System.Drawing.Size(101, 26);
            this.gradLabel40.TabIndex = 661;
            this.gradLabel40.Text = "CCW (-)";
            this.gradLabel40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel32
            // 
            this.gradLabel32.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel32.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel32.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel32.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel32.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel32.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel32.Location = new System.Drawing.Point(113, 163);
            this.gradLabel32.Name = "gradLabel32";
            this.gradLabel32.ShowAccelChar = false;
            this.gradLabel32.Size = new System.Drawing.Size(89, 26);
            this.gradLabel32.TabIndex = 657;
            this.gradLabel32.Text = "X";
            this.gradLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel21
            // 
            this.gradLabel21.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel21.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel21.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel21.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel21.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel21.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel21.Location = new System.Drawing.Point(9, 68);
            this.gradLabel21.Name = "gradLabel21";
            this.gradLabel21.ShowAccelChar = false;
            this.gradLabel21.Size = new System.Drawing.Size(101, 26);
            this.gradLabel21.TabIndex = 650;
            this.gradLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel33
            // 
            this.gradLabel33.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel33.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel33.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel33.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel33.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel33.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel33.Location = new System.Drawing.Point(204, 163);
            this.gradLabel33.Name = "gradLabel33";
            this.gradLabel33.ShowAccelChar = false;
            this.gradLabel33.Size = new System.Drawing.Size(89, 26);
            this.gradLabel33.TabIndex = 660;
            this.gradLabel33.Text = "Y1";
            this.gradLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel34
            // 
            this.gradLabel34.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel34.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel34.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel34.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel34.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel34.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel34.Location = new System.Drawing.Point(9, 163);
            this.gradLabel34.Name = "gradLabel34";
            this.gradLabel34.ShowAccelChar = false;
            this.gradLabel34.Size = new System.Drawing.Size(101, 26);
            this.gradLabel34.TabIndex = 649;
            this.gradLabel34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel28
            // 
            this.gradLabel28.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel28.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel28.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel28.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel28.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel28.Location = new System.Drawing.Point(296, 68);
            this.gradLabel28.Name = "gradLabel28";
            this.gradLabel28.ShowAccelChar = false;
            this.gradLabel28.Size = new System.Drawing.Size(89, 26);
            this.gradLabel28.TabIndex = 655;
            this.gradLabel28.Text = "Y2";
            this.gradLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel35
            // 
            this.gradLabel35.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel35.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel35.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel35.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel35.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel35.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel35.Location = new System.Drawing.Point(295, 163);
            this.gradLabel35.Name = "gradLabel35";
            this.gradLabel35.ShowAccelChar = false;
            this.gradLabel35.Size = new System.Drawing.Size(89, 26);
            this.gradLabel35.TabIndex = 654;
            this.gradLabel35.Text = "Y2";
            this.gradLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel17
            // 
            this.gradLabel17.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel17.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel17.GradientEnable = false;
            this.gradLabel17.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel17.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel17.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel17.Location = new System.Drawing.Point(9, 126);
            this.gradLabel17.Name = "gradLabel17";
            this.gradLabel17.ShowAccelChar = false;
            this.gradLabel17.Size = new System.Drawing.Size(101, 26);
            this.gradLabel17.TabIndex = 664;
            this.gradLabel17.Text = "Position";
            this.gradLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel36
            // 
            this.gradLabel36.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel36.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel36.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel36.GradientEnable = false;
            this.gradLabel36.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel36.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel36.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel36.Location = new System.Drawing.Point(9, 250);
            this.gradLabel36.Name = "gradLabel36";
            this.gradLabel36.ShowAccelChar = false;
            this.gradLabel36.Size = new System.Drawing.Size(101, 26);
            this.gradLabel36.TabIndex = 668;
            this.gradLabel36.Text = "Inposition";
            this.gradLabel36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel41
            // 
            this.gradLabel41.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel41.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel41.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel41.GradientEnable = false;
            this.gradLabel41.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel41.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel41.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel41.Location = new System.Drawing.Point(9, 337);
            this.gradLabel41.Name = "gradLabel41";
            this.gradLabel41.ShowAccelChar = false;
            this.gradLabel41.Size = new System.Drawing.Size(101, 26);
            this.gradLabel41.TabIndex = 665;
            this.gradLabel41.Text = "CW (+)";
            this.gradLabel41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledZHome
            // 
            this.ledZHome.BackColor = System.Drawing.Color.Transparent;
            this.ledZHome.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZHome.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZHome.ForeColor = System.Drawing.Color.White;
            this.ledZHome.Frame.Visible = false;
            this.ledZHome.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZHome.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZHome.Location = new System.Drawing.Point(386, 277);
            this.ledZHome.Name = "ledZHome";
            this.ledZHome.ShowAccelChar = false;
            this.ledZHome.Size = new System.Drawing.Size(89, 29);
            this.ledZHome.TabIndex = 717;
            this.ledZHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gradLabel39.Location = new System.Drawing.Point(9, 279);
            this.gradLabel39.Name = "gradLabel39";
            this.gradLabel39.ShowAccelChar = false;
            this.gradLabel39.Size = new System.Drawing.Size(101, 26);
            this.gradLabel39.TabIndex = 667;
            this.gradLabel39.Text = "Home";
            this.gradLabel39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledZAlarm
            // 
            this.ledZAlarm.BackColor = System.Drawing.Color.Transparent;
            this.ledZAlarm.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZAlarm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZAlarm.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZAlarm.ForeColor = System.Drawing.Color.White;
            this.ledZAlarm.Frame.Visible = false;
            this.ledZAlarm.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZAlarm.LED.OnColor = System.Drawing.Color.Red;
            this.ledZAlarm.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZAlarm.Location = new System.Drawing.Point(386, 366);
            this.ledZAlarm.Name = "ledZAlarm";
            this.ledZAlarm.ShowAccelChar = false;
            this.ledZAlarm.Size = new System.Drawing.Size(89, 26);
            this.ledZAlarm.TabIndex = 717;
            this.ledZAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel42
            // 
            this.gradLabel42.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel42.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel42.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel42.GradientEnable = false;
            this.gradLabel42.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel42.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel42.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel42.Location = new System.Drawing.Point(9, 366);
            this.gradLabel42.Name = "gradLabel42";
            this.gradLabel42.ShowAccelChar = false;
            this.gradLabel42.Size = new System.Drawing.Size(101, 26);
            this.gradLabel42.TabIndex = 666;
            this.gradLabel42.Text = "Alarm";
            this.gradLabel42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel29
            // 
            this.gradLabel29.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel29.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel29.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel29.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel29.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel29.Location = new System.Drawing.Point(386, 68);
            this.gradLabel29.Name = "gradLabel29";
            this.gradLabel29.ShowAccelChar = false;
            this.gradLabel29.Size = new System.Drawing.Size(89, 26);
            this.gradLabel29.TabIndex = 656;
            this.gradLabel29.Text = "Z";
            this.gradLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZInposition
            // 
            this.ledZInposition.BackColor = System.Drawing.Color.Transparent;
            this.ledZInposition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZInposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZInposition.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZInposition.ForeColor = System.Drawing.Color.White;
            this.ledZInposition.Frame.Visible = false;
            this.ledZInposition.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZInposition.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZInposition.Location = new System.Drawing.Point(386, 250);
            this.ledZInposition.Name = "ledZInposition";
            this.ledZInposition.ShowAccelChar = false;
            this.ledZInposition.Size = new System.Drawing.Size(89, 26);
            this.ledZInposition.TabIndex = 717;
            this.ledZInposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel37
            // 
            this.gradLabel37.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel37.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel37.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel37.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel37.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel37.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel37.Location = new System.Drawing.Point(386, 163);
            this.gradLabel37.Name = "gradLabel37";
            this.gradLabel37.ShowAccelChar = false;
            this.gradLabel37.Size = new System.Drawing.Size(89, 26);
            this.gradLabel37.TabIndex = 651;
            this.gradLabel37.Text = "Z";
            this.gradLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viZVelocity
            // 
            this.viZVelocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viZVelocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viZVelocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viZVelocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viZVelocity.ForeColor = System.Drawing.Color.Black;
            this.viZVelocity.FormatString = "{0:F3}";
            this.viZVelocity.Location = new System.Drawing.Point(386, 97);
            this.viZVelocity.Name = "viZVelocity";
            this.viZVelocity.ShowAccelChar = false;
            this.viZVelocity.Size = new System.Drawing.Size(89, 26);
            this.viZVelocity.TabIndex = 717;
            this.viZVelocity.Text = "0";
            this.viZVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZCW
            // 
            this.ledZCW.BackColor = System.Drawing.Color.Transparent;
            this.ledZCW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZCW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZCW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZCW.ForeColor = System.Drawing.Color.White;
            this.ledZCW.Frame.Visible = false;
            this.ledZCW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZCW.LED.OnColor = System.Drawing.Color.Red;
            this.ledZCW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZCW.Location = new System.Drawing.Point(386, 337);
            this.ledZCW.Name = "ledZCW";
            this.ledZCW.ShowAccelChar = false;
            this.ledZCW.Size = new System.Drawing.Size(89, 26);
            this.ledZCW.TabIndex = 717;
            this.ledZCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZServo
            // 
            this.ledZServo.BackColor = System.Drawing.Color.Transparent;
            this.ledZServo.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZServo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZServo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZServo.ForeColor = System.Drawing.Color.White;
            this.ledZServo.Frame.Visible = false;
            this.ledZServo.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZServo.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZServo.Location = new System.Drawing.Point(386, 192);
            this.ledZServo.Name = "ledZServo";
            this.ledZServo.ShowAccelChar = false;
            this.ledZServo.Size = new System.Drawing.Size(89, 26);
            this.ledZServo.TabIndex = 717;
            this.ledZServo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXCCW
            // 
            this.ledXCCW.BackColor = System.Drawing.Color.Transparent;
            this.ledXCCW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXCCW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXCCW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXCCW.ForeColor = System.Drawing.Color.White;
            this.ledXCCW.Frame.Visible = false;
            this.ledXCCW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXCCW.LED.OnColor = System.Drawing.Color.Red;
            this.ledXCCW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXCCW.Location = new System.Drawing.Point(113, 308);
            this.ledXCCW.Name = "ledXCCW";
            this.ledXCCW.ShowAccelChar = false;
            this.ledXCCW.Size = new System.Drawing.Size(89, 26);
            this.ledXCCW.TabIndex = 717;
            this.ledXCCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledZCCW
            // 
            this.ledZCCW.BackColor = System.Drawing.Color.Transparent;
            this.ledZCCW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledZCCW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledZCCW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledZCCW.ForeColor = System.Drawing.Color.White;
            this.ledZCCW.Frame.Visible = false;
            this.ledZCCW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledZCCW.LED.OnColor = System.Drawing.Color.Red;
            this.ledZCCW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledZCCW.Location = new System.Drawing.Point(386, 308);
            this.ledZCCW.Name = "ledZCCW";
            this.ledZCCW.ShowAccelChar = false;
            this.ledZCCW.Size = new System.Drawing.Size(89, 26);
            this.ledZCCW.TabIndex = 717;
            this.ledZCCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1CCW
            // 
            this.ledY1CCW.BackColor = System.Drawing.Color.Transparent;
            this.ledY1CCW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1CCW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1CCW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1CCW.ForeColor = System.Drawing.Color.White;
            this.ledY1CCW.Frame.Visible = false;
            this.ledY1CCW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1CCW.LED.OnColor = System.Drawing.Color.Red;
            this.ledY1CCW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1CCW.Location = new System.Drawing.Point(204, 308);
            this.ledY1CCW.Name = "ledY1CCW";
            this.ledY1CCW.ShowAccelChar = false;
            this.ledY1CCW.Size = new System.Drawing.Size(89, 26);
            this.ledY1CCW.TabIndex = 717;
            this.ledY1CCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2Home
            // 
            this.ledY2Home.BackColor = System.Drawing.Color.Transparent;
            this.ledY2Home.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2Home.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2Home.ForeColor = System.Drawing.Color.White;
            this.ledY2Home.Frame.Visible = false;
            this.ledY2Home.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2Home.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2Home.Location = new System.Drawing.Point(295, 279);
            this.ledY2Home.Name = "ledY2Home";
            this.ledY2Home.ShowAccelChar = false;
            this.ledY2Home.Size = new System.Drawing.Size(89, 26);
            this.ledY2Home.TabIndex = 717;
            this.ledY2Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2Alarm
            // 
            this.ledY2Alarm.BackColor = System.Drawing.Color.Transparent;
            this.ledY2Alarm.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2Alarm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2Alarm.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2Alarm.ForeColor = System.Drawing.Color.White;
            this.ledY2Alarm.Frame.Visible = false;
            this.ledY2Alarm.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2Alarm.LED.OnColor = System.Drawing.Color.Red;
            this.ledY2Alarm.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2Alarm.Location = new System.Drawing.Point(295, 366);
            this.ledY2Alarm.Name = "ledY2Alarm";
            this.ledY2Alarm.ShowAccelChar = false;
            this.ledY2Alarm.Size = new System.Drawing.Size(89, 26);
            this.ledY2Alarm.TabIndex = 717;
            this.ledY2Alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXCW
            // 
            this.ledXCW.BackColor = System.Drawing.Color.Transparent;
            this.ledXCW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXCW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXCW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXCW.ForeColor = System.Drawing.Color.White;
            this.ledXCW.Frame.Visible = false;
            this.ledXCW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXCW.LED.OnColor = System.Drawing.Color.Red;
            this.ledXCW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXCW.Location = new System.Drawing.Point(113, 337);
            this.ledXCW.Name = "ledXCW";
            this.ledXCW.ShowAccelChar = false;
            this.ledXCW.Size = new System.Drawing.Size(89, 26);
            this.ledXCW.TabIndex = 717;
            this.ledXCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1Home
            // 
            this.ledY1Home.BackColor = System.Drawing.Color.Transparent;
            this.ledY1Home.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1Home.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1Home.ForeColor = System.Drawing.Color.White;
            this.ledY1Home.Frame.Visible = false;
            this.ledY1Home.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1Home.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1Home.Location = new System.Drawing.Point(204, 279);
            this.ledY1Home.Name = "ledY1Home";
            this.ledY1Home.ShowAccelChar = false;
            this.ledY1Home.Size = new System.Drawing.Size(89, 26);
            this.ledY1Home.TabIndex = 717;
            this.ledY1Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viXVelocity
            // 
            this.viXVelocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viXVelocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viXVelocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viXVelocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viXVelocity.ForeColor = System.Drawing.Color.Black;
            this.viXVelocity.FormatString = "{0:F3}";
            this.viXVelocity.Location = new System.Drawing.Point(113, 97);
            this.viXVelocity.Name = "viXVelocity";
            this.viXVelocity.ShowAccelChar = false;
            this.viXVelocity.Size = new System.Drawing.Size(89, 26);
            this.viXVelocity.TabIndex = 717;
            this.viXVelocity.Text = "0";
            this.viXVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1Alarm
            // 
            this.ledY1Alarm.BackColor = System.Drawing.Color.Transparent;
            this.ledY1Alarm.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1Alarm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1Alarm.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1Alarm.ForeColor = System.Drawing.Color.White;
            this.ledY1Alarm.Frame.Visible = false;
            this.ledY1Alarm.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1Alarm.LED.OnColor = System.Drawing.Color.Red;
            this.ledY1Alarm.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1Alarm.Location = new System.Drawing.Point(204, 366);
            this.ledY1Alarm.Name = "ledY1Alarm";
            this.ledY1Alarm.ShowAccelChar = false;
            this.ledY1Alarm.Size = new System.Drawing.Size(89, 26);
            this.ledY1Alarm.TabIndex = 717;
            this.ledY1Alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1Servo
            // 
            this.ledY1Servo.BackColor = System.Drawing.Color.Transparent;
            this.ledY1Servo.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1Servo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1Servo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1Servo.ForeColor = System.Drawing.Color.White;
            this.ledY1Servo.Frame.Visible = false;
            this.ledY1Servo.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1Servo.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1Servo.Location = new System.Drawing.Point(204, 192);
            this.ledY1Servo.Name = "ledY1Servo";
            this.ledY1Servo.ShowAccelChar = false;
            this.ledY1Servo.Size = new System.Drawing.Size(89, 26);
            this.ledY1Servo.TabIndex = 717;
            this.ledY1Servo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2Inposition
            // 
            this.ledY2Inposition.BackColor = System.Drawing.Color.Transparent;
            this.ledY2Inposition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2Inposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2Inposition.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2Inposition.ForeColor = System.Drawing.Color.White;
            this.ledY2Inposition.Frame.Visible = false;
            this.ledY2Inposition.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2Inposition.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2Inposition.Location = new System.Drawing.Point(295, 250);
            this.ledY2Inposition.Name = "ledY2Inposition";
            this.ledY2Inposition.ShowAccelChar = false;
            this.ledY2Inposition.Size = new System.Drawing.Size(89, 26);
            this.ledY2Inposition.TabIndex = 717;
            this.ledY2Inposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viXPosition
            // 
            this.viXPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viXPosition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viXPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.viXPosition.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viXPosition.ForeColor = System.Drawing.Color.Black;
            this.viXPosition.FormatString = "{0:F3}";
            this.viXPosition.Location = new System.Drawing.Point(113, 126);
            this.viXPosition.Name = "viXPosition";
            this.viXPosition.ShowAccelChar = false;
            this.viXPosition.Size = new System.Drawing.Size(89, 26);
            this.viXPosition.TabIndex = 717;
            this.viXPosition.Text = "0";
            this.viXPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viY1Position
            // 
            this.viY1Position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viY1Position.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viY1Position.Cursor = System.Windows.Forms.Cursors.Default;
            this.viY1Position.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viY1Position.ForeColor = System.Drawing.Color.Black;
            this.viY1Position.FormatString = "{0:F3}";
            this.viY1Position.Location = new System.Drawing.Point(204, 126);
            this.viY1Position.Name = "viY1Position";
            this.viY1Position.ShowAccelChar = false;
            this.viY1Position.Size = new System.Drawing.Size(89, 26);
            this.viY1Position.TabIndex = 717;
            this.viY1Position.Text = "0";
            this.viY1Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viY2Position
            // 
            this.viY2Position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viY2Position.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viY2Position.Cursor = System.Windows.Forms.Cursors.Default;
            this.viY2Position.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viY2Position.ForeColor = System.Drawing.Color.Black;
            this.viY2Position.FormatString = "{0:F3}";
            this.viY2Position.Location = new System.Drawing.Point(295, 126);
            this.viY2Position.Name = "viY2Position";
            this.viY2Position.ShowAccelChar = false;
            this.viY2Position.Size = new System.Drawing.Size(89, 26);
            this.viY2Position.TabIndex = 717;
            this.viY2Position.Text = "0";
            this.viY2Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viZPosition
            // 
            this.viZPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viZPosition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viZPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.viZPosition.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viZPosition.ForeColor = System.Drawing.Color.Black;
            this.viZPosition.FormatString = "{0:F3}";
            this.viZPosition.Location = new System.Drawing.Point(386, 126);
            this.viZPosition.Name = "viZPosition";
            this.viZPosition.ShowAccelChar = false;
            this.viZPosition.Size = new System.Drawing.Size(89, 26);
            this.viZPosition.TabIndex = 717;
            this.viZPosition.Text = "0";
            this.viZPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2CW
            // 
            this.ledY2CW.BackColor = System.Drawing.Color.Transparent;
            this.ledY2CW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2CW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2CW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2CW.ForeColor = System.Drawing.Color.White;
            this.ledY2CW.Frame.Visible = false;
            this.ledY2CW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2CW.LED.OnColor = System.Drawing.Color.Red;
            this.ledY2CW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2CW.Location = new System.Drawing.Point(295, 337);
            this.ledY2CW.Name = "ledY2CW";
            this.ledY2CW.ShowAccelChar = false;
            this.ledY2CW.Size = new System.Drawing.Size(89, 26);
            this.ledY2CW.TabIndex = 717;
            this.ledY2CW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2CCW
            // 
            this.ledY2CCW.BackColor = System.Drawing.Color.Transparent;
            this.ledY2CCW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2CCW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2CCW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2CCW.ForeColor = System.Drawing.Color.White;
            this.ledY2CCW.Frame.Visible = false;
            this.ledY2CCW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2CCW.LED.OnColor = System.Drawing.Color.Red;
            this.ledY2CCW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2CCW.Location = new System.Drawing.Point(295, 308);
            this.ledY2CCW.Name = "ledY2CCW";
            this.ledY2CCW.ShowAccelChar = false;
            this.ledY2CCW.Size = new System.Drawing.Size(89, 26);
            this.ledY2CCW.TabIndex = 717;
            this.ledY2CCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1Inposition
            // 
            this.ledY1Inposition.BackColor = System.Drawing.Color.Transparent;
            this.ledY1Inposition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1Inposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1Inposition.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1Inposition.ForeColor = System.Drawing.Color.White;
            this.ledY1Inposition.Frame.Visible = false;
            this.ledY1Inposition.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1Inposition.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1Inposition.Location = new System.Drawing.Point(204, 250);
            this.ledY1Inposition.Name = "ledY1Inposition";
            this.ledY1Inposition.ShowAccelChar = false;
            this.ledY1Inposition.Size = new System.Drawing.Size(89, 26);
            this.ledY1Inposition.TabIndex = 717;
            this.ledY1Inposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viY1Velocity
            // 
            this.viY1Velocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viY1Velocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viY1Velocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viY1Velocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viY1Velocity.ForeColor = System.Drawing.Color.Black;
            this.viY1Velocity.FormatString = "{0:F3}";
            this.viY1Velocity.Location = new System.Drawing.Point(204, 97);
            this.viY1Velocity.Name = "viY1Velocity";
            this.viY1Velocity.ShowAccelChar = false;
            this.viY1Velocity.Size = new System.Drawing.Size(89, 26);
            this.viY1Velocity.TabIndex = 717;
            this.viY1Velocity.Text = "0";
            this.viY1Velocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY1CW
            // 
            this.ledY1CW.BackColor = System.Drawing.Color.Transparent;
            this.ledY1CW.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY1CW.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY1CW.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY1CW.ForeColor = System.Drawing.Color.White;
            this.ledY1CW.Frame.Visible = false;
            this.ledY1CW.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY1CW.LED.OnColor = System.Drawing.Color.Red;
            this.ledY1CW.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY1CW.Location = new System.Drawing.Point(204, 337);
            this.ledY1CW.Name = "ledY1CW";
            this.ledY1CW.ShowAccelChar = false;
            this.ledY1CW.Size = new System.Drawing.Size(89, 26);
            this.ledY1CW.TabIndex = 717;
            this.ledY1CW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXInposition
            // 
            this.ledXInposition.BackColor = System.Drawing.Color.Transparent;
            this.ledXInposition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXInposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXInposition.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXInposition.ForeColor = System.Drawing.Color.White;
            this.ledXInposition.Frame.Visible = false;
            this.ledXInposition.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXInposition.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXInposition.Location = new System.Drawing.Point(113, 250);
            this.ledXInposition.Name = "ledXInposition";
            this.ledXInposition.ShowAccelChar = false;
            this.ledXInposition.Size = new System.Drawing.Size(89, 26);
            this.ledXInposition.TabIndex = 717;
            this.ledXInposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXHome
            // 
            this.ledXHome.BackColor = System.Drawing.Color.Transparent;
            this.ledXHome.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXHome.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXHome.ForeColor = System.Drawing.Color.White;
            this.ledXHome.Frame.Visible = false;
            this.ledXHome.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXHome.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXHome.Location = new System.Drawing.Point(113, 279);
            this.ledXHome.Name = "ledXHome";
            this.ledXHome.ShowAccelChar = false;
            this.ledXHome.Size = new System.Drawing.Size(89, 26);
            this.ledXHome.TabIndex = 717;
            this.ledXHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledY2Servo
            // 
            this.ledY2Servo.BackColor = System.Drawing.Color.Transparent;
            this.ledY2Servo.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledY2Servo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledY2Servo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledY2Servo.ForeColor = System.Drawing.Color.White;
            this.ledY2Servo.Frame.Visible = false;
            this.ledY2Servo.LED.OffColor = System.Drawing.Color.Silver;
            this.ledY2Servo.LED.Size = new System.Drawing.Size(88, 25);
            this.ledY2Servo.Location = new System.Drawing.Point(295, 192);
            this.ledY2Servo.Name = "ledY2Servo";
            this.ledY2Servo.ShowAccelChar = false;
            this.ledY2Servo.Size = new System.Drawing.Size(89, 26);
            this.ledY2Servo.TabIndex = 717;
            this.ledY2Servo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viY2Velocity
            // 
            this.viY2Velocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viY2Velocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viY2Velocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viY2Velocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viY2Velocity.ForeColor = System.Drawing.Color.Black;
            this.viY2Velocity.FormatString = "{0:F3}";
            this.viY2Velocity.Location = new System.Drawing.Point(295, 97);
            this.viY2Velocity.Name = "viY2Velocity";
            this.viY2Velocity.ShowAccelChar = false;
            this.viY2Velocity.Size = new System.Drawing.Size(89, 26);
            this.viY2Velocity.TabIndex = 717;
            this.viY2Velocity.Text = "0";
            this.viY2Velocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledXAlarm
            // 
            this.ledXAlarm.BackColor = System.Drawing.Color.Transparent;
            this.ledXAlarm.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledXAlarm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledXAlarm.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledXAlarm.ForeColor = System.Drawing.Color.White;
            this.ledXAlarm.Frame.Visible = false;
            this.ledXAlarm.LED.OffColor = System.Drawing.Color.Silver;
            this.ledXAlarm.LED.OnColor = System.Drawing.Color.Red;
            this.ledXAlarm.LED.Size = new System.Drawing.Size(88, 25);
            this.ledXAlarm.Location = new System.Drawing.Point(113, 366);
            this.ledXAlarm.Name = "ledXAlarm";
            this.ledXAlarm.ShowAccelChar = false;
            this.ledXAlarm.Size = new System.Drawing.Size(89, 26);
            this.ledXAlarm.TabIndex = 717;
            this.ledXAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine20
            // 
            this.uiLine20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine20.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine20.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine20.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine20.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine20.ForeColor = System.Drawing.Color.Black;
            this.uiLine20.Frame.Visible = false;
            this.uiLine20.Hint = null;
            this.uiLine20.LineCapSize = 4;
            this.uiLine20.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine20.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine20.LineWidth = 1F;
            this.uiLine20.Location = new System.Drawing.Point(9, 49);
            this.uiLine20.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine20.Name = "uiLine20";
            this.uiLine20.ShowHint = false;
            this.uiLine20.Size = new System.Drawing.Size(459, 17);
            this.uiLine20.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine20.TabIndex = 722;
            this.uiLine20.Text = "Vel & Pos";
            this.uiLine20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine20.TextInterval = 4;
            // 
            // panManualMotion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panJogMove);
            this.Controls.Add(this.panIOMap);
            this.Controls.Add(this.panStatus);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panManualMotion";
            this.Size = new System.Drawing.Size(1375, 851);
            this.panJogMove.ResumeLayout(false);
            this.panIOMap.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        #endregion
        private sjPanel panStatus;
        private SunnyLine uiLine20;
        private GradientLabel gradLabel26;
        private GradientLabel gradLabel24;
        private GradientLabel gradLabel31;
        private GradientLabel gradLabel19;
        private GradientLabel gradLabel40;
        private GradientLabel gradLabel32;
        private GradientLabel gradLabel21;
        private GradientLabel gradLabel33;
        private GradientLabel gradLabel34;
        private GradientLabel gradLabel28;
        private GradientLabel gradLabel35;
        private GradientLabel gradLabel17;
        private GradientLabel gradLabel36;
        private GradientLabel gradLabel41;
        private GradientLabel gradLabel39;
        private GradientLabel gradLabel42;        
        private GradientLabel gradLabel29;
        private GradientLabel gradLabel37;
        
        private ValueIndicator viXVelocity;
        private ValueIndicator viY1Velocity;
        private ValueIndicator viY2Velocity;
        private ValueIndicator viZVelocity;
        private ValueIndicator viCurPosition;

        private ValueIndicator viXPosition;
        private ValueIndicator viY1Position;
        private ValueIndicator viY2Position;
        private ValueIndicator viZPosition;

        private LEDLabel ledXServo;
        private LEDLabel ledXInposition;
        private LEDLabel ledXHome;
        private LEDLabel ledXCCW;
        private LEDLabel ledXCW;
        private LEDLabel ledXAlarm;
        private LEDLabel ledZHome;
        private LEDLabel ledZAlarm;
        private LEDLabel ledZInposition;
        private LEDLabel ledZCW;
        private LEDLabel ledZServo;
        private LEDLabel ledZCCW;
        private LEDLabel ledY1CCW;
        private LEDLabel ledY2Home;
        private LEDLabel ledY2Alarm;
        private LEDLabel ledY1Home;
        private LEDLabel ledY1Alarm;
        private LEDLabel ledY1Servo;
        private LEDLabel ledY2Inposition;
        private LEDLabel ledY2CW;
        private LEDLabel ledY2CCW;
        private LEDLabel ledY1Inposition;
        private LEDLabel ledY1CW;
        private LEDLabel ledY2Servo; 
        private sjPanel panIOMap;
        private DataServer dsIO;
        private DataServer dsMotion;
        private LEDButton btnXAxis;
        private LEDButton btnY1Axis;
        private LEDButton btnY2Axis;
        private LEDButton btnZAxis;
        private LEDButton btnAllAxis;
        private BitBtn btnJogPlus;
        private BitBtn btnServoOn;
        private BitBtn btnServoOff;
        private BitBtn btnRelMinus;
        private BitBtn btnOrigin;
        private BitBtn btnRelPlus;
        private BitBtn btnStop;
        private BitBtn btnABS;
        private NumberEdit edMovePos;
        private GradientLabel gradLabel8;
        private GradientLabel gradLabel9;
        private GradientLabel gradLabel7;        
        private SunnyLine uiLine5;
        private SunnyLine uiLine6;
        private SunnyLine uiLine22;
        private BitBtn btnReset;
        private BitBtn btnJogMinus;
        private sjPanel panJogMove;
        public DaekhonSystem.ComboBox cbSpeed;
        private DaekhonSystem.TabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private LEDImageArray ledArray8;
        private LEDImageArray ledArray7;
        private LEDImageArray ledArray6;
        private LEDImageArray ledArray5;
        private Label lblInputPort7;
        private Label lblInputPort3;
        private Label lblInputPort6;
        private Label lblInputPort2;
        private Label lblInputPort5;
        private Label lblInputPort1;
        private Label lblInputPort4;
        private Label lblInputPort0;
        private SunnySwitch switchOut63;
        private SunnySwitch switchOut62;
        private SunnySwitch switchOut61;
        private SunnySwitch switchOut60;
        private SunnySwitch switchOut59;
        private SunnySwitch switchOut58;
        private SunnySwitch switchOut57;
        private SunnySwitch switchOut56;
        private SunnySwitch switchOut55;
        private SunnySwitch switchOut54;
        private SunnySwitch switchOut53;
        private SunnySwitch switchOut52;
        private SunnySwitch switchOut51;
        private SunnySwitch switchOut50;
        private SunnySwitch switchOut49;
        private SunnySwitch switchOut48;
        private SunnySwitch switchOut47;
        private SunnySwitch switchOut46;
        private SunnySwitch switchOut45;
        private SunnySwitch switchOut44;
        private SunnySwitch switchOut43;
        private SunnySwitch switchOut42;
        private SunnySwitch switchOut41;
        private SunnySwitch switchOut40;
        private SunnySwitch switchOut39;
        private SunnySwitch switchOut38;
        private SunnySwitch switchOut37;
        private SunnySwitch switchOut36;
        private SunnySwitch switchOut35;
        private SunnySwitch switchOut34;
        private SunnySwitch switchOut33;
        private SunnySwitch switchOut32;
        private SunnySwitch switchOut31;
        private SunnySwitch switchOut30;
        private SunnySwitch switchOut29;
        private SunnySwitch switchOut28;
        private SunnySwitch switchOut27;
        private SunnySwitch switchOut26;
        private SunnySwitch switchOut25;
        private SunnySwitch switchOut24;
        private SunnySwitch switchOut23;
        private SunnySwitch switchOut22;
        private SunnySwitch switchOut21;
        private SunnySwitch switchOut20;
        private SunnySwitch switchOut19;
        private SunnySwitch switchOut18;
        private SunnySwitch switchOut17;
        private SunnySwitch switchOut16;
        private SunnySwitch switchOut15;
        private SunnySwitch switchOut14;
        private SunnySwitch switchOut13;
        private SunnySwitch switchOut12;
        private SunnySwitch switchOut11;
        private SunnySwitch switchOut10;
        private SunnySwitch switchOut9;
        private SunnySwitch switchOut8;
        private SunnySwitch switchOut7;
        private SunnySwitch switchOut6;
        private SunnySwitch switchOut5;
        private SunnySwitch switchOut4;
        private SunnySwitch switchOut3;
        private SunnySwitch switchOut2;
        private SunnySwitch switchOut1;
        private SunnySwitch switchOut0;
        private Label lblOutputPort7;
        private Label lblOutputPort3;
        private Label lblOutputPort6;
        private Label lblOutputPort2;
        private Label lblOutputPort5;
        private Label lblOutputPort1;
        private Label lblOutputPort4;
        private Label lblOutputPort0;
        private GradientLabel gradientLabel1;
        private LEDLabel ledZMotionDone;
        private LEDLabel ledY2MotionDone;
        private LEDLabel ledY1MotionDone;
        private LEDLabel ledXMotionDone;
        private Thread ReadThread;
        private LEDImageLabel ledIn07;
        private LEDImageLabel ledIn06;
        private LEDImageLabel ledIn05;
        private LEDImageLabel ledIn04;
        private LEDImageLabel ledIn03;
        private LEDImageLabel ledIn02;
        private LEDImageLabel ledIn01;
        private LEDImageLabel ledIn00;
        private LEDImageLabel ledIn15;
        private LEDImageLabel ledIn14;
        private LEDImageLabel ledIn13;
        private LEDImageLabel ledIn12;
        private LEDImageLabel ledIn11;
        private LEDImageLabel ledIn10;
        private LEDImageLabel ledIn09;
        private LEDImageLabel ledIn08;
        private LEDImageLabel ledIn31;
        private LEDImageLabel ledIn30;
        private LEDImageLabel ledIn29;
        private LEDImageLabel ledIn28;
        private LEDImageLabel ledIn27;
        private LEDImageLabel ledIn26;
        private LEDImageLabel ledIn25;
        private LEDImageLabel ledIn24;
        private LEDImageLabel ledIn23;
        private LEDImageLabel ledIn17;
        private LEDImageLabel ledIn16;
        public LEDImageLabel ledDoor5;
        public LEDImageLabel ledDoor4;
        public LEDImageLabel ledDoor3;
        public LEDImageLabel ledDoor2;
        public LEDImageLabel ledDoor1;
    }
}
