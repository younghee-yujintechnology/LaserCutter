using DaekhonSystem;

namespace LaserCutter
{
    partial class panManualADV
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
            this.dataServer1 = new DaekhonSystem.DataServer();
            this.Comm = new DaekhonSystem.Comm();
            this.propSaver1 = new DaekhonSystem.PropSaver();
            this.ReadThread = new DaekhonSystem.Thread();
            this.panClient = new LaserCutter.sjPanel();
            this.gradientLabel5 = new DaekhonSystem.GradientLabel();
            this.gradientLabel4 = new DaekhonSystem.GradientLabel();
            this.gradientLabel3 = new DaekhonSystem.GradientLabel();
            this.btnSelectTable1 = new DaekhonSystem.LEDButton();
            this.btnSelectTable2 = new DaekhonSystem.LEDButton();
            this.ledTX = new DaekhonSystem.LEDLabel();
            this.ledRX = new DaekhonSystem.LEDLabel();
            this.lblVersion = new DaekhonSystem.GradientLabel();
            this.gradientLabel2 = new DaekhonSystem.GradientLabel();
            this.viGetBoundMode = new DaekhonSystem.ValueIndicator();
            this.viGetOperating = new DaekhonSystem.ValueIndicator();
            this.viGetM2Pitch = new DaekhonSystem.ValueIndicator();
            this.viTrigger = new DaekhonSystem.ValueIndicator();
            this.viGetMode = new DaekhonSystem.ValueIndicator();
            this.viGetM0PW = new DaekhonSystem.ValueIndicator();
            this.viEnc1 = new DaekhonSystem.ValueIndicator();
            this.viGetM2PW = new DaekhonSystem.ValueIndicator();
            this.viGetM0Period = new DaekhonSystem.ValueIndicator();
            this.viEnc0 = new DaekhonSystem.ValueIndicator();
            this.gradLabel11 = new DaekhonSystem.GradientLabel();
            this.gradLabel10 = new DaekhonSystem.GradientLabel();
            this.gradLabel3 = new DaekhonSystem.GradientLabel();
            this.gradLabel75 = new DaekhonSystem.GradientLabel();
            this.gradLabel5 = new DaekhonSystem.GradientLabel();
            this.gradLabel2 = new DaekhonSystem.GradientLabel();
            this.gradLabel73 = new DaekhonSystem.GradientLabel();
            this.gradLabel4 = new DaekhonSystem.GradientLabel();
            this.gradLabel1 = new DaekhonSystem.GradientLabel();
            this.gradLabel72 = new DaekhonSystem.GradientLabel();
            this.viBaudRate = new DaekhonSystem.ValueIndicator();
            this.gradientLabel1 = new DaekhonSystem.GradientLabel();
            this.btnResetEncoder = new DaekhonSystem.BitBtn();
            this.btnGetEncorderY = new DaekhonSystem.BitBtn();
            this.btnGetEncorderX = new DaekhonSystem.BitBtn();
            this.btnGetTrigger = new DaekhonSystem.BitBtn();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnMode2Set = new DaekhonSystem.BitBtn();
            this.btnMode0Set = new DaekhonSystem.BitBtn();
            this.edMode0Period = new DaekhonSystem.KeypadEdit();
            this.edMode0PulseWidth = new DaekhonSystem.KeypadEdit();
            this.edMode2PulseWidth = new DaekhonSystem.KeypadEdit();
            this.edMode2PulsePitch = new DaekhonSystem.KeypadEdit();
            this.gradLabel53 = new DaekhonSystem.GradientLabel();
            this.gradLabel54 = new DaekhonSystem.GradientLabel();
            this.uiLine17 = new DaekhonSystem.SunnyLine();
            this.gradLabel60 = new DaekhonSystem.GradientLabel();
            this.gradLabel47 = new DaekhonSystem.GradientLabel();
            this.btnConnect = new DaekhonSystem.LEDButton();
            this.btnClearList = new DaekhonSystem.BitBtn();
            this.gradLabel74 = new DaekhonSystem.GradientLabel();
            this.cbComPort = new DaekhonSystem.ComboBox();
            this.uiLine2 = new DaekhonSystem.SunnyLine();
            this.btnGetVersion = new DaekhonSystem.BitBtn();
            this.btnResetTrigger = new DaekhonSystem.BitBtn();
            this.btnOperatingOn = new DaekhonSystem.LEDButton();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataServer1
            // 
            this.dataServer1.OnError += new DaekhonSystem.ErrorEventHandler(this.dataServer1_OnError);
            // 
            // Comm
            // 
            this.Comm.BaudRate = DaekhonSystem.BaudRate._115200;
            this.Comm.BinaryMode = false;
            this.Comm.ByteSize = DaekhonSystem.ByteSize._8;
            this.Comm.CheckParity = false;
            this.Comm.CommEvents = new DaekhonSystem.CommEvent[] {
        DaekhonSystem.CommEvent.EV_RXCHAR,
        DaekhonSystem.CommEvent.EV_RXFLAG,
        DaekhonSystem.CommEvent.EV_TXEMPTY};
            this.Comm.DiscardNull = false;
            this.Comm.EventChar = "0x0D";
            this.Comm.FlowControl = DaekhonSystem.FlowControl.FC_XONXOFF;
            this.Comm.MaxInQueue = 4096;
            this.Comm.MaxOutQueue = 2048;
            this.Comm.Parity = DaekhonSystem.Parity.NONE;
            this.Comm.Port = DaekhonSystem.Port.COM08;
            this.Comm.Priority = System.Threading.ThreadPriority.Normal;
            this.Comm.RS485Mode = false;
            this.Comm.StopBits = DaekhonSystem.StopBits._1;
            this.Comm.TimeOut = ((uint)(1000u));
            // 
            // propSaver1
            // 
            this.propSaver1.Active = false;
            this.propSaver1.FormStateSection = "";
            this.propSaver1.ManageFormState = false;
            this.propSaver1.ParentControl = this;
            this.propSaver1.PropList = new string[] {
        "cbADVPortNo;ItemIndex;Connect;PortNo;1",
        "edMode0Period;Text;Mode0Period;Text;0",
        "edMode0PulseWidth;Text;Mode0PulseWidth;Text;0",
        "edMode2PulseWidth;Text;Mode2PulseWidth;Text;2",
        "edMode2PulsePitch;Text;Mode2PulsePitch;Text;0"};
            this.propSaver1.RootKey = DaekhonSystem.RootKey.artHKEY_CURRENT_USER;
            // 
            // ReadThread
            // 
            this.ReadThread.Enabled = false;
            this.ReadThread.Interval = 100;
            this.ReadThread.OnExecute += new System.EventHandler(this.ReadThread_OnExecute);
            // 
            // panClient
            // 
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.gradientLabel5);
            this.panClient.Controls.Add(this.gradientLabel4);
            this.panClient.Controls.Add(this.gradientLabel3);
            this.panClient.Controls.Add(this.btnSelectTable1);
            this.panClient.Controls.Add(this.btnSelectTable2);
            this.panClient.Controls.Add(this.ledTX);
            this.panClient.Controls.Add(this.ledRX);
            this.panClient.Controls.Add(this.lblVersion);
            this.panClient.Controls.Add(this.gradientLabel2);
            this.panClient.Controls.Add(this.viGetBoundMode);
            this.panClient.Controls.Add(this.viGetOperating);
            this.panClient.Controls.Add(this.viGetM2Pitch);
            this.panClient.Controls.Add(this.viTrigger);
            this.panClient.Controls.Add(this.viGetMode);
            this.panClient.Controls.Add(this.viGetM0PW);
            this.panClient.Controls.Add(this.viEnc1);
            this.panClient.Controls.Add(this.viGetM2PW);
            this.panClient.Controls.Add(this.viGetM0Period);
            this.panClient.Controls.Add(this.viEnc0);
            this.panClient.Controls.Add(this.gradLabel11);
            this.panClient.Controls.Add(this.gradLabel10);
            this.panClient.Controls.Add(this.gradLabel3);
            this.panClient.Controls.Add(this.gradLabel75);
            this.panClient.Controls.Add(this.gradLabel5);
            this.panClient.Controls.Add(this.gradLabel2);
            this.panClient.Controls.Add(this.gradLabel73);
            this.panClient.Controls.Add(this.gradLabel4);
            this.panClient.Controls.Add(this.gradLabel1);
            this.panClient.Controls.Add(this.gradLabel72);
            this.panClient.Controls.Add(this.viBaudRate);
            this.panClient.Controls.Add(this.gradientLabel1);
            this.panClient.Controls.Add(this.btnResetEncoder);
            this.panClient.Controls.Add(this.btnGetEncorderY);
            this.panClient.Controls.Add(this.btnGetEncorderX);
            this.panClient.Controls.Add(this.btnGetTrigger);
            this.panClient.Controls.Add(this.listBox);
            this.panClient.Controls.Add(this.btnMode2Set);
            this.panClient.Controls.Add(this.btnMode0Set);
            this.panClient.Controls.Add(this.edMode0Period);
            this.panClient.Controls.Add(this.edMode0PulseWidth);
            this.panClient.Controls.Add(this.edMode2PulseWidth);
            this.panClient.Controls.Add(this.edMode2PulsePitch);
            this.panClient.Controls.Add(this.gradLabel53);
            this.panClient.Controls.Add(this.gradLabel54);
            this.panClient.Controls.Add(this.uiLine17);
            this.panClient.Controls.Add(this.gradLabel60);
            this.panClient.Controls.Add(this.gradLabel47);
            this.panClient.Controls.Add(this.btnConnect);
            this.panClient.Controls.Add(this.btnClearList);
            this.panClient.Controls.Add(this.gradLabel74);
            this.panClient.Controls.Add(this.cbComPort);
            this.panClient.Controls.Add(this.uiLine2);
            this.panClient.Controls.Add(this.btnGetVersion);
            this.panClient.Controls.Add(this.btnResetTrigger);
            this.panClient.Controls.Add(this.btnOperatingOn);
            this.panClient.Location = new System.Drawing.Point(3, 3);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(936, 843);
            this.panClient.TabIndex = 1294;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panClient.TitleText = "LaserTrigger(ADV)";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel5.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.gradientLabel5.CaptionStyle.TextStyle = DaekhonSystem.TextStyle.Shadow;
            this.gradientLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel5.ForeColor = System.Drawing.Color.Red;
            this.gradientLabel5.Frame.Visible = false;
            this.gradientLabel5.GradientEnable = false;
            this.gradientLabel5.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel5.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel5.Location = new System.Drawing.Point(578, 747);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.Size = new System.Drawing.Size(188, 29);
            this.gradientLabel5.TabIndex = 1498;
            this.gradientLabel5.Text = "(모드에 상관없이 Laser ON)";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel4.Frame.Visible = false;
            this.gradientLabel4.GradientEnable = false;
            this.gradientLabel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel4.Location = new System.Drawing.Point(332, 747);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(128, 29);
            this.gradientLabel4.TabIndex = 1497;
            this.gradientLabel4.Text = "강제 출력";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel3.Frame.Visible = false;
            this.gradientLabel3.GradientEnable = false;
            this.gradientLabel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel3.Location = new System.Drawing.Point(333, 694);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(128, 29);
            this.gradientLabel3.TabIndex = 1496;
            this.gradientLabel3.Text = "작업테이블";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectTable1
            // 
            this.btnSelectTable1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSelectTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSelectTable1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSelectTable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTable1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSelectTable1.ForeColor = System.Drawing.Color.Black;
            this.btnSelectTable1.Location = new System.Drawing.Point(467, 685);
            this.btnSelectTable1.Margin2 = 10;
            this.btnSelectTable1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectTable1.Name = "btnSelectTable1";
            this.btnSelectTable1.Size = new System.Drawing.Size(105, 47);
            this.btnSelectTable1.TabIndex = 1494;
            this.btnSelectTable1.Text = "Table1";
            this.btnSelectTable1.UseVisualStyleBackColor = false;
            this.btnSelectTable1.Click += new System.EventHandler(this.btnSelectTable1_Click);
            // 
            // btnSelectTable2
            // 
            this.btnSelectTable2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSelectTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSelectTable2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSelectTable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTable2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSelectTable2.ForeColor = System.Drawing.Color.Black;
            this.btnSelectTable2.Location = new System.Drawing.Point(581, 685);
            this.btnSelectTable2.Margin2 = 10;
            this.btnSelectTable2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectTable2.Name = "btnSelectTable2";
            this.btnSelectTable2.Size = new System.Drawing.Size(105, 47);
            this.btnSelectTable2.TabIndex = 1495;
            this.btnSelectTable2.Text = "Table2";
            this.btnSelectTable2.UseVisualStyleBackColor = false;
            this.btnSelectTable2.Click += new System.EventHandler(this.btnSelectTable2_Click);
            // 
            // ledTX
            // 
            this.ledTX.BackColor = System.Drawing.Color.Transparent;
            this.ledTX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTX.Frame.Visible = false;
            this.ledTX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledTX.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledTX.LED.OffColor = System.Drawing.Color.Gray;
            this.ledTX.Location = new System.Drawing.Point(910, 12);
            this.ledTX.Name = "ledTX";
            this.ledTX.ShowChannelName = false;
            this.ledTX.Size = new System.Drawing.Size(15, 16);
            this.ledTX.TabIndex = 1493;
            this.ledTX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledRX
            // 
            this.ledRX.BackColor = System.Drawing.Color.Transparent;
            this.ledRX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledRX.Frame.Visible = false;
            this.ledRX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledRX.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledRX.LED.OffColor = System.Drawing.Color.Gray;
            this.ledRX.LED.OnColor = System.Drawing.Color.Red;
            this.ledRX.Location = new System.Drawing.Point(892, 12);
            this.ledRX.Name = "ledRX";
            this.ledRX.ShowChannelName = false;
            this.ledRX.Size = new System.Drawing.Size(15, 16);
            this.ledRX.TabIndex = 1492;
            this.ledRX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVersion.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblVersion.GradientEnable = false;
            this.lblVersion.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblVersion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblVersion.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblVersion.Location = new System.Drawing.Point(244, 84);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(95, 29);
            this.lblVersion.TabIndex = 1351;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel2.Frame.Visible = false;
            this.gradientLabel2.GradientEnable = false;
            this.gradientLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel2.Location = new System.Drawing.Point(107, 84);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(128, 29);
            this.gradientLabel2.TabIndex = 1349;
            this.gradientLabel2.Text = "Version";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viGetBoundMode
            // 
            this.viGetBoundMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetBoundMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetBoundMode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetBoundMode.ForeColor = System.Drawing.Color.Black;
            this.viGetBoundMode.Location = new System.Drawing.Point(244, 530);
            this.viGetBoundMode.Name = "viGetBoundMode";
            this.viGetBoundMode.Size = new System.Drawing.Size(95, 29);
            this.viGetBoundMode.TabIndex = 1348;
            this.viGetBoundMode.Text = "OFF";
            this.viGetBoundMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viGetOperating
            // 
            this.viGetOperating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetOperating.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetOperating.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetOperating.ForeColor = System.Drawing.Color.Black;
            this.viGetOperating.Location = new System.Drawing.Point(244, 498);
            this.viGetOperating.Name = "viGetOperating";
            this.viGetOperating.Size = new System.Drawing.Size(95, 29);
            this.viGetOperating.TabIndex = 1346;
            this.viGetOperating.Text = "OFF";
            this.viGetOperating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viGetM2Pitch
            // 
            this.viGetM2Pitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetM2Pitch.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetM2Pitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetM2Pitch.ForeColor = System.Drawing.Color.Black;
            this.viGetM2Pitch.Location = new System.Drawing.Point(629, 215);
            this.viGetM2Pitch.Name = "viGetM2Pitch";
            this.viGetM2Pitch.Size = new System.Drawing.Size(95, 29);
            this.viGetM2Pitch.TabIndex = 1345;
            this.viGetM2Pitch.Text = "0.0";
            this.viGetM2Pitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viTrigger
            // 
            this.viTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viTrigger.Cursor = System.Windows.Forms.Cursors.Default;
            this.viTrigger.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viTrigger.ForeColor = System.Drawing.Color.Black;
            this.viTrigger.Location = new System.Drawing.Point(244, 439);
            this.viTrigger.Name = "viTrigger";
            this.viTrigger.Size = new System.Drawing.Size(95, 29);
            this.viTrigger.TabIndex = 1344;
            this.viTrigger.Text = "0.0";
            this.viTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viGetMode
            // 
            this.viGetMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetMode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetMode.ForeColor = System.Drawing.Color.Black;
            this.viGetMode.Location = new System.Drawing.Point(244, 147);
            this.viGetMode.Name = "viGetMode";
            this.viGetMode.Size = new System.Drawing.Size(95, 29);
            this.viGetMode.TabIndex = 1343;
            this.viGetMode.Text = "0";
            this.viGetMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viGetM0PW
            // 
            this.viGetM0PW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetM0PW.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetM0PW.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetM0PW.ForeColor = System.Drawing.Color.Black;
            this.viGetM0PW.Location = new System.Drawing.Point(244, 247);
            this.viGetM0PW.Name = "viGetM0PW";
            this.viGetM0PW.Size = new System.Drawing.Size(95, 29);
            this.viGetM0PW.TabIndex = 1342;
            this.viGetM0PW.Text = "0.0";
            this.viGetM0PW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viEnc1
            // 
            this.viEnc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viEnc1.Cursor = System.Windows.Forms.Cursors.Default;
            this.viEnc1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viEnc1.ForeColor = System.Drawing.Color.Black;
            this.viEnc1.FormatString = "0.0000";
            this.viEnc1.Location = new System.Drawing.Point(244, 407);
            this.viEnc1.Name = "viEnc1";
            this.viEnc1.Size = new System.Drawing.Size(95, 29);
            this.viEnc1.TabIndex = 1341;
            this.viEnc1.Text = "0";
            this.viEnc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viGetM2PW
            // 
            this.viGetM2PW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetM2PW.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetM2PW.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetM2PW.ForeColor = System.Drawing.Color.Black;
            this.viGetM2PW.Location = new System.Drawing.Point(629, 247);
            this.viGetM2PW.Name = "viGetM2PW";
            this.viGetM2PW.Size = new System.Drawing.Size(95, 29);
            this.viGetM2PW.TabIndex = 1340;
            this.viGetM2PW.Text = "0.0";
            this.viGetM2PW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viGetM0Period
            // 
            this.viGetM0Period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viGetM0Period.Cursor = System.Windows.Forms.Cursors.Default;
            this.viGetM0Period.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viGetM0Period.ForeColor = System.Drawing.Color.Black;
            this.viGetM0Period.Location = new System.Drawing.Point(244, 215);
            this.viGetM0Period.Name = "viGetM0Period";
            this.viGetM0Period.Size = new System.Drawing.Size(95, 29);
            this.viGetM0Period.TabIndex = 1347;
            this.viGetM0Period.Text = "0.0";
            this.viGetM0Period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viEnc0
            // 
            this.viEnc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viEnc0.Cursor = System.Windows.Forms.Cursors.Default;
            this.viEnc0.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viEnc0.ForeColor = System.Drawing.Color.Black;
            this.viEnc0.FormatString = "0.0000";
            this.viEnc0.Location = new System.Drawing.Point(244, 375);
            this.viEnc0.Name = "viEnc0";
            this.viEnc0.Size = new System.Drawing.Size(95, 29);
            this.viEnc0.TabIndex = 1339;
            this.viEnc0.Text = "0";
            this.viEnc0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel11
            // 
            this.gradLabel11.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel11.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel11.Frame.Visible = false;
            this.gradLabel11.GradientEnable = false;
            this.gradLabel11.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel11.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel11.Location = new System.Drawing.Point(110, 530);
            this.gradLabel11.Name = "gradLabel11";
            this.gradLabel11.Size = new System.Drawing.Size(128, 29);
            this.gradLabel11.TabIndex = 1337;
            this.gradLabel11.Text = "Bound Mode";
            this.gradLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel10
            // 
            this.gradLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel10.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel10.Frame.Visible = false;
            this.gradLabel10.GradientEnable = false;
            this.gradLabel10.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel10.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel10.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel10.Location = new System.Drawing.Point(110, 498);
            this.gradLabel10.Name = "gradLabel10";
            this.gradLabel10.Size = new System.Drawing.Size(128, 29);
            this.gradLabel10.TabIndex = 1336;
            this.gradLabel10.Text = "Operating";
            this.gradLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel3
            // 
            this.gradLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel3.Frame.Visible = false;
            this.gradLabel3.GradientEnable = false;
            this.gradLabel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel3.Location = new System.Drawing.Point(495, 215);
            this.gradLabel3.Name = "gradLabel3";
            this.gradLabel3.Size = new System.Drawing.Size(128, 29);
            this.gradLabel3.TabIndex = 1335;
            this.gradLabel3.Text = "Mode2 Pitch";
            this.gradLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel75
            // 
            this.gradLabel75.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel75.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel75.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel75.Frame.Visible = false;
            this.gradLabel75.GradientEnable = false;
            this.gradLabel75.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel75.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel75.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel75.Location = new System.Drawing.Point(110, 439);
            this.gradLabel75.Name = "gradLabel75";
            this.gradLabel75.Size = new System.Drawing.Size(128, 29);
            this.gradLabel75.TabIndex = 1334;
            this.gradLabel75.Text = "Trigger";
            this.gradLabel75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel5
            // 
            this.gradLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel5.Frame.Visible = false;
            this.gradLabel5.GradientEnable = false;
            this.gradLabel5.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel5.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel5.Location = new System.Drawing.Point(107, 148);
            this.gradLabel5.Name = "gradLabel5";
            this.gradLabel5.Size = new System.Drawing.Size(128, 29);
            this.gradLabel5.TabIndex = 1333;
            this.gradLabel5.Text = "Trigger Mode";
            this.gradLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel2
            // 
            this.gradLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel2.Frame.Visible = false;
            this.gradLabel2.GradientEnable = false;
            this.gradLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel2.Location = new System.Drawing.Point(110, 247);
            this.gradLabel2.Name = "gradLabel2";
            this.gradLabel2.Size = new System.Drawing.Size(128, 29);
            this.gradLabel2.TabIndex = 1332;
            this.gradLabel2.Text = "Mode0 PulseWidth";
            this.gradLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel73
            // 
            this.gradLabel73.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel73.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel73.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel73.Frame.Visible = false;
            this.gradLabel73.GradientEnable = false;
            this.gradLabel73.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel73.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel73.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel73.Location = new System.Drawing.Point(110, 407);
            this.gradLabel73.Name = "gradLabel73";
            this.gradLabel73.Size = new System.Drawing.Size(128, 29);
            this.gradLabel73.TabIndex = 1331;
            this.gradLabel73.Text = "Encoder 1 (Y)";
            this.gradLabel73.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel4
            // 
            this.gradLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel4.Frame.Visible = false;
            this.gradLabel4.GradientEnable = false;
            this.gradLabel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel4.Location = new System.Drawing.Point(495, 247);
            this.gradLabel4.Name = "gradLabel4";
            this.gradLabel4.Size = new System.Drawing.Size(128, 29);
            this.gradLabel4.TabIndex = 1330;
            this.gradLabel4.Text = "Mode2 PulseWidth";
            this.gradLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel1
            // 
            this.gradLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel1.Frame.Visible = false;
            this.gradLabel1.GradientEnable = false;
            this.gradLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel1.Location = new System.Drawing.Point(110, 215);
            this.gradLabel1.Name = "gradLabel1";
            this.gradLabel1.Size = new System.Drawing.Size(128, 29);
            this.gradLabel1.TabIndex = 1338;
            this.gradLabel1.Text = "Mode0 Period";
            this.gradLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel72
            // 
            this.gradLabel72.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel72.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel72.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel72.Frame.Visible = false;
            this.gradLabel72.GradientEnable = false;
            this.gradLabel72.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel72.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel72.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel72.Location = new System.Drawing.Point(110, 375);
            this.gradLabel72.Name = "gradLabel72";
            this.gradLabel72.Size = new System.Drawing.Size(128, 29);
            this.gradLabel72.TabIndex = 1329;
            this.gradLabel72.Text = "Encoder 0 (X)";
            this.gradLabel72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viBaudRate
            // 
            this.viBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.viBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.viBaudRate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viBaudRate.ForeColor = System.Drawing.Color.Black;
            this.viBaudRate.Location = new System.Drawing.Point(722, 104);
            this.viBaudRate.Name = "viBaudRate";
            this.viBaudRate.Size = new System.Drawing.Size(95, 29);
            this.viBaudRate.TabIndex = 1328;
            this.viBaudRate.Text = "1";
            this.viBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel1.Frame.Visible = false;
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(631, 103);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(88, 29);
            this.gradientLabel1.TabIndex = 1327;
            this.gradientLabel1.Text = "Baudrate";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnResetEncoder
            // 
            this.btnResetEncoder.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnResetEncoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnResetEncoder.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnResetEncoder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEncoder.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnResetEncoder.ForeColor = System.Drawing.Color.Black;
            this.btnResetEncoder.Location = new System.Drawing.Point(467, 632);
            this.btnResetEncoder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetEncoder.Name = "btnResetEncoder";
            this.btnResetEncoder.Size = new System.Drawing.Size(105, 47);
            this.btnResetEncoder.TabIndex = 1322;
            this.btnResetEncoder.Text = "Reset Encoder";
            this.btnResetEncoder.UseVisualStyleBackColor = false;
            this.btnResetEncoder.Click += new System.EventHandler(this.btnResetEncoder_Click);
            // 
            // btnGetEncorderY
            // 
            this.btnGetEncorderY.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGetEncorderY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGetEncorderY.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnGetEncorderY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetEncorderY.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnGetEncorderY.ForeColor = System.Drawing.Color.Black;
            this.btnGetEncorderY.Location = new System.Drawing.Point(695, 632);
            this.btnGetEncorderY.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetEncorderY.Name = "btnGetEncorderY";
            this.btnGetEncorderY.Size = new System.Drawing.Size(105, 47);
            this.btnGetEncorderY.TabIndex = 1321;
            this.btnGetEncorderY.Text = "Get Enc Y";
            this.btnGetEncorderY.UseVisualStyleBackColor = false;
            this.btnGetEncorderY.Click += new System.EventHandler(this.btnGetEncorderY_Click);
            // 
            // btnGetEncorderX
            // 
            this.btnGetEncorderX.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGetEncorderX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGetEncorderX.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnGetEncorderX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetEncorderX.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnGetEncorderX.ForeColor = System.Drawing.Color.Black;
            this.btnGetEncorderX.Location = new System.Drawing.Point(581, 632);
            this.btnGetEncorderX.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetEncorderX.Name = "btnGetEncorderX";
            this.btnGetEncorderX.Size = new System.Drawing.Size(105, 47);
            this.btnGetEncorderX.TabIndex = 1326;
            this.btnGetEncorderX.Text = "Get Enc X";
            this.btnGetEncorderX.UseVisualStyleBackColor = false;
            this.btnGetEncorderX.Click += new System.EventHandler(this.btnGetEncorderX_Click);
            // 
            // btnGetTrigger
            // 
            this.btnGetTrigger.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGetTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGetTrigger.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnGetTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetTrigger.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnGetTrigger.ForeColor = System.Drawing.Color.Black;
            this.btnGetTrigger.Location = new System.Drawing.Point(581, 577);
            this.btnGetTrigger.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetTrigger.Name = "btnGetTrigger";
            this.btnGetTrigger.Size = new System.Drawing.Size(105, 47);
            this.btnGetTrigger.TabIndex = 1320;
            this.btnGetTrigger.Text = "Get Trigger";
            this.btnGetTrigger.UseVisualStyleBackColor = false;
            this.btnGetTrigger.Click += new System.EventHandler(this.btnGetTrigger_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(467, 375);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(333, 196);
            this.listBox.TabIndex = 1319;
            // 
            // btnMode2Set
            // 
            this.btnMode2Set.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMode2Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMode2Set.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMode2Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode2Set.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnMode2Set.ForeColor = System.Drawing.Color.Black;
            this.btnMode2Set.Location = new System.Drawing.Point(730, 293);
            this.btnMode2Set.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMode2Set.Name = "btnMode2Set";
            this.btnMode2Set.Size = new System.Drawing.Size(61, 47);
            this.btnMode2Set.TabIndex = 1318;
            this.btnMode2Set.Text = "Set";
            this.btnMode2Set.UseVisualStyleBackColor = false;
            this.btnMode2Set.Click += new System.EventHandler(this.btnMode2Set_Click);
            // 
            // btnMode0Set
            // 
            this.btnMode0Set.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMode0Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMode0Set.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMode0Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode0Set.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnMode0Set.ForeColor = System.Drawing.Color.Black;
            this.btnMode0Set.Location = new System.Drawing.Point(345, 293);
            this.btnMode0Set.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMode0Set.Name = "btnMode0Set";
            this.btnMode0Set.Size = new System.Drawing.Size(61, 47);
            this.btnMode0Set.TabIndex = 1317;
            this.btnMode0Set.Text = "Set";
            this.btnMode0Set.UseVisualStyleBackColor = false;
            this.btnMode0Set.Click += new System.EventHandler(this.btnMode0Set_Click);
            // 
            // edMode0Period
            // 
            this.edMode0Period.BackColor = System.Drawing.Color.White;
            this.edMode0Period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edMode0Period.DataType = DaekhonSystem.DataType.Double;
            this.edMode0Period.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMode0Period.ForeColor = System.Drawing.Color.Black;
            this.edMode0Period.Frame.CornerRound = 1;
            this.edMode0Period.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMode0Period.Hint = null;
            this.edMode0Period.Location = new System.Drawing.Point(244, 279);
            this.edMode0Period.Max = 0D;
            this.edMode0Period.Min = 0D;
            this.edMode0Period.Name = "edMode0Period";
            this.edMode0Period.PrecisionDigits = 3;
            this.edMode0Period.ShowHint = false;
            this.edMode0Period.Size = new System.Drawing.Size(95, 29);
            this.edMode0Period.TabIndex = 1315;
            this.edMode0Period.TabStop = false;
            this.edMode0Period.Text = "0.000";
            // 
            // edMode0PulseWidth
            // 
            this.edMode0PulseWidth.BackColor = System.Drawing.Color.White;
            this.edMode0PulseWidth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edMode0PulseWidth.DataType = DaekhonSystem.DataType.Double;
            this.edMode0PulseWidth.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMode0PulseWidth.ForeColor = System.Drawing.Color.Black;
            this.edMode0PulseWidth.Frame.CornerRound = 1;
            this.edMode0PulseWidth.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMode0PulseWidth.Hint = null;
            this.edMode0PulseWidth.Location = new System.Drawing.Point(244, 311);
            this.edMode0PulseWidth.Max = 0D;
            this.edMode0PulseWidth.Min = 0D;
            this.edMode0PulseWidth.Name = "edMode0PulseWidth";
            this.edMode0PulseWidth.PrecisionDigits = 3;
            this.edMode0PulseWidth.ShowHint = false;
            this.edMode0PulseWidth.Size = new System.Drawing.Size(95, 29);
            this.edMode0PulseWidth.TabIndex = 1316;
            this.edMode0PulseWidth.TabStop = false;
            this.edMode0PulseWidth.Text = "0.000";
            // 
            // edMode2PulseWidth
            // 
            this.edMode2PulseWidth.BackColor = System.Drawing.Color.White;
            this.edMode2PulseWidth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edMode2PulseWidth.DataType = DaekhonSystem.DataType.Double;
            this.edMode2PulseWidth.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMode2PulseWidth.ForeColor = System.Drawing.Color.Black;
            this.edMode2PulseWidth.Frame.CornerRound = 1;
            this.edMode2PulseWidth.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMode2PulseWidth.Hint = null;
            this.edMode2PulseWidth.Location = new System.Drawing.Point(629, 311);
            this.edMode2PulseWidth.Max = 0D;
            this.edMode2PulseWidth.Min = 0D;
            this.edMode2PulseWidth.Name = "edMode2PulseWidth";
            this.edMode2PulseWidth.PrecisionDigits = 3;
            this.edMode2PulseWidth.ShowHint = false;
            this.edMode2PulseWidth.Size = new System.Drawing.Size(95, 29);
            this.edMode2PulseWidth.TabIndex = 1311;
            this.edMode2PulseWidth.TabStop = false;
            this.edMode2PulseWidth.Text = "2";
            // 
            // edMode2PulsePitch
            // 
            this.edMode2PulsePitch.BackColor = System.Drawing.Color.White;
            this.edMode2PulsePitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edMode2PulsePitch.DataType = DaekhonSystem.DataType.Double;
            this.edMode2PulsePitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edMode2PulsePitch.ForeColor = System.Drawing.Color.Black;
            this.edMode2PulsePitch.Frame.CornerRound = 1;
            this.edMode2PulsePitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edMode2PulsePitch.Hint = null;
            this.edMode2PulsePitch.Location = new System.Drawing.Point(629, 279);
            this.edMode2PulsePitch.Max = 0D;
            this.edMode2PulsePitch.Min = 0D;
            this.edMode2PulsePitch.Name = "edMode2PulsePitch";
            this.edMode2PulsePitch.PrecisionDigits = 3;
            this.edMode2PulsePitch.ShowHint = false;
            this.edMode2PulsePitch.Size = new System.Drawing.Size(95, 29);
            this.edMode2PulsePitch.TabIndex = 1310;
            this.edMode2PulsePitch.TabStop = false;
            this.edMode2PulsePitch.Text = "0.000";
            // 
            // gradLabel53
            // 
            this.gradLabel53.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel53.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel53.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel53.Frame.Visible = false;
            this.gradLabel53.GradientEnable = false;
            this.gradLabel53.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel53.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel53.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel53.Location = new System.Drawing.Point(110, 279);
            this.gradLabel53.Name = "gradLabel53";
            this.gradLabel53.Size = new System.Drawing.Size(128, 29);
            this.gradLabel53.TabIndex = 1313;
            this.gradLabel53.Text = "Pulse Period (us)";
            this.gradLabel53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel54
            // 
            this.gradLabel54.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel54.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel54.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel54.Frame.Visible = false;
            this.gradLabel54.GradientEnable = false;
            this.gradLabel54.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel54.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel54.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel54.Location = new System.Drawing.Point(110, 311);
            this.gradLabel54.Name = "gradLabel54";
            this.gradLabel54.Size = new System.Drawing.Size(128, 29);
            this.gradLabel54.TabIndex = 1314;
            this.gradLabel54.Text = "Pulse Width (us)";
            this.gradLabel54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLine17
            // 
            this.uiLine17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine17.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine17.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine17.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine17.Font = new System.Drawing.Font("Tahoma", 11F);
            this.uiLine17.ForeColor = System.Drawing.Color.Black;
            this.uiLine17.Frame.Visible = false;
            this.uiLine17.Hint = null;
            this.uiLine17.LineCapSize = 4;
            this.uiLine17.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine17.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine17.LineWidth = 1F;
            this.uiLine17.Location = new System.Drawing.Point(69, 185);
            this.uiLine17.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine17.Name = "uiLine17";
            this.uiLine17.ShowHint = false;
            this.uiLine17.Size = new System.Drawing.Size(183, 17);
            this.uiLine17.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine17.TabIndex = 1312;
            this.uiLine17.Text = "Mode 0 (Int - Encoder)";
            this.uiLine17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine17.TextInterval = 4;
            // 
            // gradLabel60
            // 
            this.gradLabel60.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel60.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel60.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel60.Frame.Visible = false;
            this.gradLabel60.GradientEnable = false;
            this.gradLabel60.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel60.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel60.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel60.Location = new System.Drawing.Point(510, 279);
            this.gradLabel60.Name = "gradLabel60";
            this.gradLabel60.Size = new System.Drawing.Size(114, 29);
            this.gradLabel60.TabIndex = 1308;
            this.gradLabel60.Text = "Pulse Pitch (um)";
            this.gradLabel60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel47
            // 
            this.gradLabel47.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel47.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel47.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel47.Frame.Visible = false;
            this.gradLabel47.GradientEnable = false;
            this.gradLabel47.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel47.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel47.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel47.Location = new System.Drawing.Point(513, 311);
            this.gradLabel47.Name = "gradLabel47";
            this.gradLabel47.Size = new System.Drawing.Size(111, 29);
            this.gradLabel47.TabIndex = 1309;
            this.gradLabel47.Text = "Pulse Width (us)";
            this.gradLabel47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConnect
            // 
            this.btnConnect.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConnect.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnConnect.LED.Size = new System.Drawing.Size(70, 26);
            this.btnConnect.Location = new System.Drawing.Point(823, 79);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 46);
            this.btnConnect.TabIndex = 1307;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClearList.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearList.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnClearList.ForeColor = System.Drawing.Color.Black;
            this.btnClearList.Location = new System.Drawing.Point(695, 577);
            this.btnClearList.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(105, 47);
            this.btnClearList.TabIndex = 1304;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // gradLabel74
            // 
            this.gradLabel74.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel74.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel74.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel74.Frame.Visible = false;
            this.gradLabel74.GradientEnable = false;
            this.gradLabel74.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel74.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel74.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel74.Location = new System.Drawing.Point(631, 73);
            this.gradLabel74.Name = "gradLabel74";
            this.gradLabel74.Size = new System.Drawing.Size(88, 29);
            this.gradLabel74.TabIndex = 1298;
            this.gradLabel74.Text = "Port";
            this.gradLabel74.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbComPort
            // 
            this.cbComPort.BackColor = System.Drawing.Color.White;
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbComPort.Frame.CornerRound = 1;
            this.cbComPort.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbComPort.Hint = null;
            this.cbComPort.ItemIndex = 0;
            this.cbComPort.Items.AddRange(new object[] {
            "COM01",
            "COM02",
            "COM03",
            "COM04",
            "COM05",
            "COM06",
            "COM07",
            "COM08",
            "COM09",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14"});
            this.cbComPort.Location = new System.Drawing.Point(722, 73);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbComPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbComPort.ShowHint = false;
            this.cbComPort.Size = new System.Drawing.Size(95, 26);
            this.cbComPort.TabIndex = 1297;
            this.cbComPort.Text = "COM01";
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine2.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine2.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine2.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.uiLine2.ForeColor = System.Drawing.Color.Black;
            this.uiLine2.Frame.Visible = false;
            this.uiLine2.Hint = null;
            this.uiLine2.LineCapSize = 4;
            this.uiLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine2.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine2.LineWidth = 1F;
            this.uiLine2.Location = new System.Drawing.Point(440, 185);
            this.uiLine2.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.ShowHint = false;
            this.uiLine2.Size = new System.Drawing.Size(183, 17);
            this.uiLine2.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine2.TabIndex = 1299;
            this.uiLine2.Text = "Mode 2 (Ext - Encoder)";
            this.uiLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine2.TextInterval = 4;
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGetVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGetVersion.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnGetVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetVersion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnGetVersion.ForeColor = System.Drawing.Color.Black;
            this.btnGetVersion.Location = new System.Drawing.Point(345, 77);
            this.btnGetVersion.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(61, 47);
            this.btnGetVersion.TabIndex = 1300;
            this.btnGetVersion.Text = "Read";
            this.btnGetVersion.UseVisualStyleBackColor = false;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // btnResetTrigger
            // 
            this.btnResetTrigger.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnResetTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnResetTrigger.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnResetTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetTrigger.Font = new System.Drawing.Font("Gulim", 9F);
            this.btnResetTrigger.ForeColor = System.Drawing.Color.Black;
            this.btnResetTrigger.Location = new System.Drawing.Point(467, 577);
            this.btnResetTrigger.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetTrigger.Name = "btnResetTrigger";
            this.btnResetTrigger.Size = new System.Drawing.Size(105, 47);
            this.btnResetTrigger.TabIndex = 1303;
            this.btnResetTrigger.Text = "Reset Trigger";
            this.btnResetTrigger.UseVisualStyleBackColor = false;
            this.btnResetTrigger.Click += new System.EventHandler(this.btnResetTrigger_Click);
            // 
            // btnOperatingOn
            // 
            this.btnOperatingOn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOperatingOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOperatingOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnOperatingOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperatingOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOperatingOn.ForeColor = System.Drawing.Color.Black;
            this.btnOperatingOn.Location = new System.Drawing.Point(467, 738);
            this.btnOperatingOn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOperatingOn.Name = "btnOperatingOn";
            this.btnOperatingOn.Size = new System.Drawing.Size(105, 47);
            this.btnOperatingOn.TabIndex = 1301;
            this.btnOperatingOn.Text = "ON";
            this.btnOperatingOn.UseVisualStyleBackColor = false;
            this.btnOperatingOn.Click += new System.EventHandler(this.btnOperatingOn_Click);
            // 
            // panManualADV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Gulim", 9F);
            this.Location = new System.Drawing.Point(3, 3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panManualADV";
            this.Size = new System.Drawing.Size(940, 849);
            this.panClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DaekhonSystem.DataServer dataServer1;
        private sjPanel panClient;
        private BitBtn btnResetEncoder;
        private BitBtn btnGetEncorderY;
        private BitBtn btnGetEncorderX;
        private BitBtn btnGetTrigger;
        private System.Windows.Forms.ListBox listBox;
        private BitBtn btnMode0Set;
        private KeypadEdit edMode0Period;
        private KeypadEdit edMode0PulseWidth;
        private GradientLabel gradLabel53;
        private GradientLabel gradLabel54;
        private SunnyLine uiLine17;
        private GradientLabel gradLabel60;
        private GradientLabel gradLabel47;
        private LEDButton btnConnect;
        private BitBtn btnClearList;
        private GradientLabel gradLabel74;
        private DaekhonSystem.ComboBox cbComPort;
        private SunnyLine uiLine2;
        private BitBtn btnGetVersion;
        private BitBtn btnResetTrigger;
        private LEDButton btnOperatingOn;
        public Comm Comm;
        private ValueIndicator viBaudRate;
        private GradientLabel gradientLabel1;
        private ValueIndicator viGetBoundMode;
        public ValueIndicator viGetOperating;
        private ValueIndicator viGetM2Pitch;
        private ValueIndicator viTrigger;
        private ValueIndicator viGetMode;
        private ValueIndicator viGetM0PW;
        private ValueIndicator viEnc1;
        private ValueIndicator viGetM2PW;
        private ValueIndicator viGetM0Period;
        private ValueIndicator viEnc0;
        private GradientLabel gradLabel11;
        private GradientLabel gradLabel10;
        private GradientLabel gradLabel3;
        private GradientLabel gradLabel75;
        private GradientLabel gradLabel5;
        private GradientLabel gradLabel2;
        private GradientLabel gradLabel73;
        private GradientLabel gradLabel4;
        private GradientLabel gradLabel1;
        private GradientLabel gradLabel72;
        public Thread ReadThread;
        public KeypadEdit edMode2PulseWidth;
        public KeypadEdit edMode2PulsePitch;
        public BitBtn btnMode2Set;
        public PropSaver propSaver1;
        private GradientLabel gradientLabel2;
        private GradientLabel lblVersion;
        private LEDLabel ledTX;
        private LEDLabel ledRX;
        private GradientLabel gradientLabel3;
        private LEDButton btnSelectTable1;
        private LEDButton btnSelectTable2;
        private GradientLabel gradientLabel4;
        private GradientLabel gradientLabel5;
    }
}
