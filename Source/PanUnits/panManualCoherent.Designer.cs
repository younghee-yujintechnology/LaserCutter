using DaekhonSystem;

namespace LaserCutter
{
    partial class panManualCoherent
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
            this.dsLaser = new DaekhonSystem.DataServer();
            this.ReadSession = new DaekhonSystem.AsyncClient();
            this.WriteSession = new DaekhonSystem.AsyncClient();
            this.ReadThread = new DaekhonSystem.Thread();
            this.panClient = new LaserCutter.sjPanel();
            this.ledbtnReset = new DaekhonSystem.LEDButton();
            this.btnChillerFault = new DaekhonSystem.LEDButton();
            this.btnChillerStop = new DaekhonSystem.LEDButton();
            this.btnChillerRun = new DaekhonSystem.LEDButton();
            this.ledSystemFault = new DaekhonSystem.LEDLabel();
            this.ledSystemLaserOn = new DaekhonSystem.LEDLabel();
            this.ledStandbyOn = new DaekhonSystem.LEDLabel();
            this.ledKeyOn = new DaekhonSystem.LEDLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPulseOff = new DaekhonSystem.LEDButton();
            this.btnPulseOn = new DaekhonSystem.LEDButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShutterClose = new DaekhonSystem.LEDButton();
            this.btnShutterOpen = new DaekhonSystem.LEDButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new DaekhonSystem.LEDButton();
            this.btnConnect = new DaekhonSystem.LEDButton();
            this.cbLaserSet = new DaekhonSystem.ComboBox();
            this.lblCurLaserParam = new System.Windows.Forms.Label();
            this.gradLabel57 = new DaekhonSystem.GradientLabel();
            this.gradLabel44 = new DaekhonSystem.GradientLabel();
            this.gradLabel23 = new DaekhonSystem.GradientLabel();
            this.uiLine36 = new DaekhonSystem.SunnyLine();
            this.viChillerSetTemp = new DaekhonSystem.ValueIndicator();
            this.viChillerCurrTemp = new DaekhonSystem.ValueIndicator();
            this.gradLabel38 = new DaekhonSystem.GradientLabel();
            this.gradLabel43 = new DaekhonSystem.GradientLabel();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.btnLogClear = new DaekhonSystem.BitBtn();
            this.ListBoxStatus = new DaekhonSystem.ListBox();
            this.uiLine26 = new DaekhonSystem.SunnyLine();
            this.btnSetPulseWidth = new DaekhonSystem.BitBtn();
            this.btnSetPower = new DaekhonSystem.BitBtn();
            this.edPulseWidth = new DaekhonSystem.NumberEdit();
            this.edRRD = new DaekhonSystem.NumberEdit();
            this.edPower = new DaekhonSystem.NumberEdit();
            this.btnSetRRD = new DaekhonSystem.BitBtn();
            this.gradLabel12 = new DaekhonSystem.GradientLabel();
            this.gradLabel15 = new DaekhonSystem.GradientLabel();
            this.gradLabel16 = new DaekhonSystem.GradientLabel();
            this.viPulseWidth = new DaekhonSystem.ValueIndicator();
            this.viLaserPower = new DaekhonSystem.ValueIndicator();
            this.label36 = new System.Windows.Forms.Label();
            this.viRRD = new DaekhonSystem.ValueIndicator();
            this.label50 = new System.Windows.Forms.Label();
            this.uiLine25 = new DaekhonSystem.SunnyLine();
            this.uiLine23 = new DaekhonSystem.SunnyLine();
            this.chkPulseEQ = new System.Windows.Forms.CheckBox();
            this.btnSystemStop = new DaekhonSystem.BitBtn();
            this.btnSystemStart = new DaekhonSystem.BitBtn();
            this.uiLine19 = new DaekhonSystem.SunnyLine();
            this.uiLine1 = new DaekhonSystem.SunnyLine();
            this.panClient.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsLaser
            // 
            this.dsLaser.OnError += new DaekhonSystem.ErrorEventHandler(this.dataServer1_OnError);
            // 
            // ReadSession
            // 
            this.ReadSession.Connection = null;
            this.ReadSession.WaitReply = false;
            this.ReadSession.OnReceive += new DaekhonSystem.AsyncSocketReceiveEventHandler(this.ReadSession_OnReceive);
            // 
            // WriteSession
            // 
            this.WriteSession.Connection = null;
            this.WriteSession.WaitReply = false;
            this.WriteSession.OnReceive += new DaekhonSystem.AsyncSocketReceiveEventHandler(this.WriteSession_OnReceive);
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
            this.panClient.Controls.Add(this.ledbtnReset);
            this.panClient.Controls.Add(this.btnChillerFault);
            this.panClient.Controls.Add(this.btnChillerStop);
            this.panClient.Controls.Add(this.btnChillerRun);
            this.panClient.Controls.Add(this.ledSystemFault);
            this.panClient.Controls.Add(this.ledSystemLaserOn);
            this.panClient.Controls.Add(this.ledStandbyOn);
            this.panClient.Controls.Add(this.ledKeyOn);
            this.panClient.Controls.Add(this.groupBox3);
            this.panClient.Controls.Add(this.groupBox2);
            this.panClient.Controls.Add(this.groupBox1);
            this.panClient.Controls.Add(this.cbLaserSet);
            this.panClient.Controls.Add(this.lblCurLaserParam);
            this.panClient.Controls.Add(this.gradLabel57);
            this.panClient.Controls.Add(this.gradLabel44);
            this.panClient.Controls.Add(this.gradLabel23);
            this.panClient.Controls.Add(this.uiLine36);
            this.panClient.Controls.Add(this.viChillerSetTemp);
            this.panClient.Controls.Add(this.viChillerCurrTemp);
            this.panClient.Controls.Add(this.gradLabel38);
            this.panClient.Controls.Add(this.gradLabel43);
            this.panClient.Controls.Add(this.label53);
            this.panClient.Controls.Add(this.label54);
            this.panClient.Controls.Add(this.btnLogClear);
            this.panClient.Controls.Add(this.ListBoxStatus);
            this.panClient.Controls.Add(this.uiLine26);
            this.panClient.Controls.Add(this.btnSetPulseWidth);
            this.panClient.Controls.Add(this.btnSetPower);
            this.panClient.Controls.Add(this.edPulseWidth);
            this.panClient.Controls.Add(this.edRRD);
            this.panClient.Controls.Add(this.edPower);
            this.panClient.Controls.Add(this.btnSetRRD);
            this.panClient.Controls.Add(this.gradLabel12);
            this.panClient.Controls.Add(this.gradLabel15);
            this.panClient.Controls.Add(this.gradLabel16);
            this.panClient.Controls.Add(this.viPulseWidth);
            this.panClient.Controls.Add(this.viLaserPower);
            this.panClient.Controls.Add(this.label36);
            this.panClient.Controls.Add(this.viRRD);
            this.panClient.Controls.Add(this.label50);
            this.panClient.Controls.Add(this.uiLine25);
            this.panClient.Controls.Add(this.uiLine23);
            this.panClient.Controls.Add(this.chkPulseEQ);
            this.panClient.Controls.Add(this.btnSystemStop);
            this.panClient.Controls.Add(this.btnSystemStart);
            this.panClient.Controls.Add(this.uiLine19);
            this.panClient.Controls.Add(this.uiLine1);
            this.panClient.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panClient.Location = new System.Drawing.Point(3, 3);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(936, 843);
            this.panClient.TabIndex = 1279;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.Color.Black;
            this.panClient.TitleText = "Laser - Coherent";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledbtnReset
            // 
            this.ledbtnReset.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.ledbtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledbtnReset.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledbtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledbtnReset.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledbtnReset.ForeColor = System.Drawing.Color.Black;
            this.ledbtnReset.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledbtnReset.LED.Size = new System.Drawing.Size(70, 26);
            this.ledbtnReset.Location = new System.Drawing.Point(236, 712);
            this.ledbtnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledbtnReset.Name = "ledbtnReset";
            this.ledbtnReset.Size = new System.Drawing.Size(92, 46);
            this.ledbtnReset.TabIndex = 1357;
            this.ledbtnReset.Text = "Reset";
            this.ledbtnReset.UseVisualStyleBackColor = false;
            this.ledbtnReset.Click += new System.EventHandler(this.ledbtnReset_Click);
            // 
            // btnChillerFault
            // 
            this.btnChillerFault.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChillerFault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnChillerFault.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnChillerFault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChillerFault.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChillerFault.ForeColor = System.Drawing.Color.Black;
            this.btnChillerFault.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnChillerFault.LED.Size = new System.Drawing.Size(70, 26);
            this.btnChillerFault.Location = new System.Drawing.Point(124, 712);
            this.btnChillerFault.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChillerFault.Name = "btnChillerFault";
            this.btnChillerFault.Size = new System.Drawing.Size(92, 46);
            this.btnChillerFault.TabIndex = 1356;
            this.btnChillerFault.Text = "Fault";
            this.btnChillerFault.UseVisualStyleBackColor = false;
            // 
            // btnChillerStop
            // 
            this.btnChillerStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChillerStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnChillerStop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnChillerStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChillerStop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChillerStop.ForeColor = System.Drawing.Color.Black;
            this.btnChillerStop.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnChillerStop.LED.Size = new System.Drawing.Size(70, 26);
            this.btnChillerStop.Location = new System.Drawing.Point(236, 660);
            this.btnChillerStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChillerStop.Name = "btnChillerStop";
            this.btnChillerStop.Size = new System.Drawing.Size(92, 46);
            this.btnChillerStop.TabIndex = 1354;
            this.btnChillerStop.Text = "Stop";
            this.btnChillerStop.UseVisualStyleBackColor = false;
            this.btnChillerStop.Click += new System.EventHandler(this.btnChillerStop_Click);
            // 
            // btnChillerRun
            // 
            this.btnChillerRun.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChillerRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnChillerRun.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnChillerRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChillerRun.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChillerRun.ForeColor = System.Drawing.Color.Black;
            this.btnChillerRun.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnChillerRun.LED.Size = new System.Drawing.Size(70, 26);
            this.btnChillerRun.Location = new System.Drawing.Point(124, 660);
            this.btnChillerRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChillerRun.Name = "btnChillerRun";
            this.btnChillerRun.Size = new System.Drawing.Size(92, 46);
            this.btnChillerRun.TabIndex = 1355;
            this.btnChillerRun.Text = "Run";
            this.btnChillerRun.UseVisualStyleBackColor = false;
            this.btnChillerRun.Click += new System.EventHandler(this.btnChillerRun_Click);
            // 
            // ledSystemFault
            // 
            this.ledSystemFault.BackColor = System.Drawing.Color.Transparent;
            this.ledSystemFault.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledSystemFault.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledSystemFault.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledSystemFault.ForeColor = System.Drawing.Color.Black;
            this.ledSystemFault.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledSystemFault.Frame.Visible = false;
            this.ledSystemFault.LED.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledSystemFault.LED.OffColor = System.Drawing.Color.Silver;
            this.ledSystemFault.LED.Size = new System.Drawing.Size(16, 14);
            this.ledSystemFault.Location = new System.Drawing.Point(23, 530);
            this.ledSystemFault.Name = "ledSystemFault";
            this.ledSystemFault.ShowChannelName = false;
            this.ledSystemFault.Size = new System.Drawing.Size(95, 15);
            this.ledSystemFault.TabIndex = 1350;
            this.ledSystemFault.Text = "Fault";
            this.ledSystemFault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledSystemLaserOn
            // 
            this.ledSystemLaserOn.BackColor = System.Drawing.Color.Transparent;
            this.ledSystemLaserOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledSystemLaserOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledSystemLaserOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledSystemLaserOn.ForeColor = System.Drawing.Color.Black;
            this.ledSystemLaserOn.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledSystemLaserOn.Frame.Visible = false;
            this.ledSystemLaserOn.LED.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledSystemLaserOn.LED.OffColor = System.Drawing.Color.Silver;
            this.ledSystemLaserOn.LED.Size = new System.Drawing.Size(16, 14);
            this.ledSystemLaserOn.Location = new System.Drawing.Point(143, 499);
            this.ledSystemLaserOn.Name = "ledSystemLaserOn";
            this.ledSystemLaserOn.ShowChannelName = false;
            this.ledSystemLaserOn.Size = new System.Drawing.Size(86, 15);
            this.ledSystemLaserOn.TabIndex = 1349;
            this.ledSystemLaserOn.Text = "Laser On";
            this.ledSystemLaserOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledStandbyOn
            // 
            this.ledStandbyOn.BackColor = System.Drawing.Color.Transparent;
            this.ledStandbyOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledStandbyOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledStandbyOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledStandbyOn.ForeColor = System.Drawing.Color.Black;
            this.ledStandbyOn.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledStandbyOn.Frame.Visible = false;
            this.ledStandbyOn.LED.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledStandbyOn.LED.OffColor = System.Drawing.Color.Silver;
            this.ledStandbyOn.LED.Size = new System.Drawing.Size(16, 14);
            this.ledStandbyOn.Location = new System.Drawing.Point(23, 499);
            this.ledStandbyOn.Name = "ledStandbyOn";
            this.ledStandbyOn.ShowChannelName = false;
            this.ledStandbyOn.Size = new System.Drawing.Size(95, 15);
            this.ledStandbyOn.TabIndex = 1348;
            this.ledStandbyOn.Text = "Standby On";
            this.ledStandbyOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledKeyOn
            // 
            this.ledKeyOn.BackColor = System.Drawing.Color.Transparent;
            this.ledKeyOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledKeyOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ledKeyOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledKeyOn.ForeColor = System.Drawing.Color.Black;
            this.ledKeyOn.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledKeyOn.Frame.Visible = false;
            this.ledKeyOn.LED.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ledKeyOn.LED.OffColor = System.Drawing.Color.Silver;
            this.ledKeyOn.LED.Size = new System.Drawing.Size(16, 14);
            this.ledKeyOn.Location = new System.Drawing.Point(23, 430);
            this.ledKeyOn.Name = "ledKeyOn";
            this.ledKeyOn.ShowChannelName = false;
            this.ledKeyOn.Size = new System.Drawing.Size(53, 15);
            this.ledKeyOn.TabIndex = 1347;
            this.ledKeyOn.Text = "On";
            this.ledKeyOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPulseOff);
            this.groupBox3.Controls.Add(this.btnPulseOn);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(15, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 104);
            this.groupBox3.TabIndex = 1346;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Pulse  ";
            // 
            // btnPulseOff
            // 
            this.btnPulseOff.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPulseOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPulseOff.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnPulseOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPulseOff.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPulseOff.ForeColor = System.Drawing.Color.Black;
            this.btnPulseOff.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnPulseOff.LED.Size = new System.Drawing.Size(70, 26);
            this.btnPulseOff.Location = new System.Drawing.Point(130, 33);
            this.btnPulseOff.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPulseOff.Name = "btnPulseOff";
            this.btnPulseOff.Size = new System.Drawing.Size(92, 46);
            this.btnPulseOff.TabIndex = 1292;
            this.btnPulseOff.Text = "Off";
            this.btnPulseOff.UseVisualStyleBackColor = false;
            this.btnPulseOff.Click += new System.EventHandler(this.btnPulseOff_Click);
            // 
            // btnPulseOn
            // 
            this.btnPulseOn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPulseOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPulseOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnPulseOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPulseOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPulseOn.ForeColor = System.Drawing.Color.Black;
            this.btnPulseOn.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnPulseOn.LED.Size = new System.Drawing.Size(70, 26);
            this.btnPulseOn.Location = new System.Drawing.Point(24, 33);
            this.btnPulseOn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPulseOn.Name = "btnPulseOn";
            this.btnPulseOn.Size = new System.Drawing.Size(92, 46);
            this.btnPulseOn.TabIndex = 1293;
            this.btnPulseOn.Text = "On";
            this.btnPulseOn.UseVisualStyleBackColor = false;
            this.btnPulseOn.Click += new System.EventHandler(this.btnPulseOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShutterClose);
            this.groupBox2.Controls.Add(this.btnShutterOpen);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 104);
            this.groupBox2.TabIndex = 1345;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Shutter  ";
            // 
            // btnShutterClose
            // 
            this.btnShutterClose.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnShutterClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnShutterClose.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnShutterClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutterClose.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnShutterClose.ForeColor = System.Drawing.Color.Black;
            this.btnShutterClose.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnShutterClose.LED.Size = new System.Drawing.Size(70, 26);
            this.btnShutterClose.Location = new System.Drawing.Point(130, 33);
            this.btnShutterClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShutterClose.Name = "btnShutterClose";
            this.btnShutterClose.Size = new System.Drawing.Size(92, 46);
            this.btnShutterClose.TabIndex = 1291;
            this.btnShutterClose.Text = "Close";
            this.btnShutterClose.UseVisualStyleBackColor = false;
            this.btnShutterClose.Click += new System.EventHandler(this.btnShutterClose_Click);
            // 
            // btnShutterOpen
            // 
            this.btnShutterOpen.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnShutterOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnShutterOpen.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnShutterOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutterOpen.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnShutterOpen.ForeColor = System.Drawing.Color.Black;
            this.btnShutterOpen.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnShutterOpen.LED.Size = new System.Drawing.Size(70, 26);
            this.btnShutterOpen.Location = new System.Drawing.Point(24, 33);
            this.btnShutterOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShutterOpen.Name = "btnShutterOpen";
            this.btnShutterOpen.Size = new System.Drawing.Size(92, 46);
            this.btnShutterOpen.TabIndex = 1292;
            this.btnShutterOpen.Text = "Open";
            this.btnShutterOpen.UseVisualStyleBackColor = false;
            this.btnShutterOpen.Click += new System.EventHandler(this.btnShutterOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 104);
            this.groupBox1.TabIndex = 1344;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Connect  ";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDisconnect.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnDisconnect.LED.Size = new System.Drawing.Size(70, 26);
            this.btnDisconnect.Location = new System.Drawing.Point(130, 33);
            this.btnDisconnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(89, 46);
            this.btnDisconnect.TabIndex = 1283;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnectLaser_Click);
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
            this.btnConnect.Location = new System.Drawing.Point(24, 33);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 46);
            this.btnConnect.TabIndex = 1284;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnectLaser_Click);
            // 
            // cbLaserSet
            // 
            this.cbLaserSet.BackColor = System.Drawing.Color.White;
            this.cbLaserSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLaserSet.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbLaserSet.Frame.CornerRound = 1;
            this.cbLaserSet.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbLaserSet.Hint = null;
            this.cbLaserSet.ItemIndex = 0;
            this.cbLaserSet.Items.AddRange(new object[] {
            "250 khz Burst 3",
            "250 khz Burst 4",
            "750 khz Burst 1",
            "1000 khz Burst 1"});
            this.cbLaserSet.Location = new System.Drawing.Point(465, 262);
            this.cbLaserSet.Margin = new System.Windows.Forms.Padding(4);
            this.cbLaserSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbLaserSet.Name = "cbLaserSet";
            this.cbLaserSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbLaserSet.ShowHint = false;
            this.cbLaserSet.Size = new System.Drawing.Size(395, 27);
            this.cbLaserSet.TabIndex = 1331;
            this.cbLaserSet.Text = "12345";
            this.cbLaserSet.OnSelectedIndexChanged += new System.EventHandler(this.cbLaserSet_OnSelectedIndexChanged);
            // 
            // lblCurLaserParam
            // 
            this.lblCurLaserParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCurLaserParam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurLaserParam.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCurLaserParam.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCurLaserParam.ForeColor = System.Drawing.Color.Black;
            this.lblCurLaserParam.Location = new System.Drawing.Point(568, 232);
            this.lblCurLaserParam.Name = "lblCurLaserParam";
            this.lblCurLaserParam.Size = new System.Drawing.Size(292, 26);
            this.lblCurLaserParam.TabIndex = 1330;
            this.lblCurLaserParam.Text = "750 kHz 1x80 uj";
            this.lblCurLaserParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel57
            // 
            this.gradLabel57.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel57.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel57.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel57.GradientEnable = false;
            this.gradLabel57.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel57.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel57.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel57.Location = new System.Drawing.Point(465, 232);
            this.gradLabel57.Name = "gradLabel57";
            this.gradLabel57.Size = new System.Drawing.Size(99, 26);
            this.gradLabel57.TabIndex = 1329;
            this.gradLabel57.Text = "Current";
            this.gradLabel57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel44
            // 
            this.gradLabel44.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel44.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel44.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel44.Frame.Visible = false;
            this.gradLabel44.GradientEnable = false;
            this.gradLabel44.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel44.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel44.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel44.Location = new System.Drawing.Point(14, 721);
            this.gradLabel44.Name = "gradLabel44";
            this.gradLabel44.Size = new System.Drawing.Size(105, 29);
            this.gradLabel44.TabIndex = 1326;
            this.gradLabel44.Text = "Enable";
            this.gradLabel44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel23
            // 
            this.gradLabel23.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel23.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel23.Frame.Visible = false;
            this.gradLabel23.GradientEnable = false;
            this.gradLabel23.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel23.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel23.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel23.Location = new System.Drawing.Point(14, 669);
            this.gradLabel23.Name = "gradLabel23";
            this.gradLabel23.Size = new System.Drawing.Size(105, 29);
            this.gradLabel23.TabIndex = 1325;
            this.gradLabel23.Text = "Run";
            this.gradLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLine36
            // 
            this.uiLine36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine36.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine36.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine36.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine36.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine36.ForeColor = System.Drawing.Color.Black;
            this.uiLine36.Frame.Visible = false;
            this.uiLine36.Hint = null;
            this.uiLine36.LineCapSize = 4;
            this.uiLine36.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine36.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine36.LineWidth = 1F;
            this.uiLine36.Location = new System.Drawing.Point(17, 591);
            this.uiLine36.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine36.Name = "uiLine36";
            this.uiLine36.ShowHint = false;
            this.uiLine36.Size = new System.Drawing.Size(401, 17);
            this.uiLine36.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine36.TabIndex = 1322;
            this.uiLine36.Text = "Chiller";
            this.uiLine36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine36.TextInterval = 4;
            // 
            // viChillerSetTemp
            // 
            this.viChillerSetTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viChillerSetTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.viChillerSetTemp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viChillerSetTemp.ForeColor = System.Drawing.Color.Black;
            this.viChillerSetTemp.Location = new System.Drawing.Point(338, 619);
            this.viChillerSetTemp.Name = "viChillerSetTemp";
            this.viChillerSetTemp.Size = new System.Drawing.Size(68, 29);
            this.viChillerSetTemp.TabIndex = 1320;
            this.viChillerSetTemp.Text = "0.0";
            this.viChillerSetTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viChillerCurrTemp
            // 
            this.viChillerCurrTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viChillerCurrTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.viChillerCurrTemp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viChillerCurrTemp.ForeColor = System.Drawing.Color.Black;
            this.viChillerCurrTemp.Location = new System.Drawing.Point(124, 619);
            this.viChillerCurrTemp.Name = "viChillerCurrTemp";
            this.viChillerCurrTemp.Size = new System.Drawing.Size(80, 29);
            this.viChillerCurrTemp.TabIndex = 1321;
            this.viChillerCurrTemp.Text = "0.0";
            this.viChillerCurrTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel38
            // 
            this.gradLabel38.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel38.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel38.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel38.Frame.Visible = false;
            this.gradLabel38.GradientEnable = false;
            this.gradLabel38.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel38.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel38.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel38.Location = new System.Drawing.Point(14, 619);
            this.gradLabel38.Name = "gradLabel38";
            this.gradLabel38.Size = new System.Drawing.Size(105, 29);
            this.gradLabel38.TabIndex = 1316;
            this.gradLabel38.Text = "Temperature";
            this.gradLabel38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel43
            // 
            this.gradLabel43.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel43.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel43.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel43.Frame.Visible = false;
            this.gradLabel43.GradientEnable = false;
            this.gradLabel43.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel43.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel43.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel43.Location = new System.Drawing.Point(237, 619);
            this.gradLabel43.Name = "gradLabel43";
            this.gradLabel43.Size = new System.Drawing.Size(96, 29);
            this.gradLabel43.TabIndex = 1317;
            this.gradLabel43.Text = "Set Point";
            this.gradLabel43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Cursor = System.Windows.Forms.Cursors.Default;
            this.label53.Font = new System.Drawing.Font("굴림", 9F);
            this.label53.Location = new System.Drawing.Point(204, 620);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(18, 12);
            this.label53.TabIndex = 1318;
            this.label53.Text = "°C";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Cursor = System.Windows.Forms.Cursors.Default;
            this.label54.Font = new System.Drawing.Font("굴림", 9F);
            this.label54.Location = new System.Drawing.Point(405, 608);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(18, 12);
            this.label54.TabIndex = 1319;
            this.label54.Text = "°C";
            // 
            // btnLogClear
            // 
            this.btnLogClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLogClear.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnLogClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLogClear.ForeColor = System.Drawing.Color.Black;
            this.btnLogClear.Location = new System.Drawing.Point(765, 598);
            this.btnLogClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(92, 46);
            this.btnLogClear.TabIndex = 1313;
            this.btnLogClear.Text = "Clear";
            this.btnLogClear.UseVisualStyleBackColor = false;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // ListBoxStatus
            // 
            this.ListBoxStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListBoxStatus.Font = new System.Drawing.Font("굴림", 9F);
            this.ListBoxStatus.Location = new System.Drawing.Point(465, 375);
            this.ListBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.ListBoxStatus.Name = "ListBoxStatus";
            this.ListBoxStatus.Padding = new System.Windows.Forms.Padding(2);
            this.ListBoxStatus.Size = new System.Drawing.Size(392, 216);
            this.ListBoxStatus.TabIndex = 1311;
            this.ListBoxStatus.Text = "uiListBox3";
            // 
            // uiLine26
            // 
            this.uiLine26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine26.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine26.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine26.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine26.ForeColor = System.Drawing.Color.Black;
            this.uiLine26.Frame.Visible = false;
            this.uiLine26.Hint = null;
            this.uiLine26.LineCapSize = 4;
            this.uiLine26.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine26.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine26.LineWidth = 1F;
            this.uiLine26.Location = new System.Drawing.Point(464, 347);
            this.uiLine26.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine26.Name = "uiLine26";
            this.uiLine26.ShowHint = false;
            this.uiLine26.Size = new System.Drawing.Size(393, 17);
            this.uiLine26.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine26.TabIndex = 1312;
            this.uiLine26.Text = "Status Log";
            this.uiLine26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine26.TextInterval = 4;
            // 
            // btnSetPulseWidth
            // 
            this.btnSetPulseWidth.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetPulseWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetPulseWidth.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSetPulseWidth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetPulseWidth.Font = new System.Drawing.Font("굴림", 9F);
            this.btnSetPulseWidth.ForeColor = System.Drawing.Color.Black;
            this.btnSetPulseWidth.Location = new System.Drawing.Point(780, 151);
            this.btnSetPulseWidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetPulseWidth.Name = "btnSetPulseWidth";
            this.btnSetPulseWidth.Size = new System.Drawing.Size(77, 30);
            this.btnSetPulseWidth.TabIndex = 1310;
            this.btnSetPulseWidth.Text = "Set";
            this.btnSetPulseWidth.UseVisualStyleBackColor = false;
            this.btnSetPulseWidth.Click += new System.EventHandler(this.btnSetPulseWidth_Click);
            // 
            // btnSetPower
            // 
            this.btnSetPower.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetPower.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSetPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetPower.Font = new System.Drawing.Font("굴림", 9F);
            this.btnSetPower.ForeColor = System.Drawing.Color.Black;
            this.btnSetPower.Location = new System.Drawing.Point(780, 119);
            this.btnSetPower.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetPower.Name = "btnSetPower";
            this.btnSetPower.Size = new System.Drawing.Size(77, 30);
            this.btnSetPower.TabIndex = 1308;
            this.btnSetPower.Text = "Set";
            this.btnSetPower.UseVisualStyleBackColor = false;
            this.btnSetPower.Click += new System.EventHandler(this.btnSetPower_Click);
            // 
            // edPulseWidth
            // 
            this.edPulseWidth.BackColor = System.Drawing.Color.White;
            this.edPulseWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edPulseWidth.DataType = DaekhonSystem.DataType.Double;
            this.edPulseWidth.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPulseWidth.Frame.Bottom = false;
            this.edPulseWidth.Frame.CornerRound = 1;
            this.edPulseWidth.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPulseWidth.Frame.Top = false;
            this.edPulseWidth.Hint = null;
            this.edPulseWidth.Location = new System.Drawing.Point(678, 153);
            this.edPulseWidth.Margin = new System.Windows.Forms.Padding(4);
            this.edPulseWidth.Max = 0D;
            this.edPulseWidth.Min = 0D;
            this.edPulseWidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.edPulseWidth.Name = "edPulseWidth";
            this.edPulseWidth.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edPulseWidth.PrecisionDigits = 3;
            this.edPulseWidth.ShowHint = false;
            this.edPulseWidth.Size = new System.Drawing.Size(95, 29);
            this.edPulseWidth.TabIndex = 1309;
            this.edPulseWidth.Text = "0";
            // 
            // edRRD
            // 
            this.edRRD.BackColor = System.Drawing.Color.White;
            this.edRRD.Cursor = System.Windows.Forms.Cursors.Default;
            this.edRRD.DataType = DaekhonSystem.DataType.Integer;
            this.edRRD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edRRD.Frame.Bottom = false;
            this.edRRD.Frame.CornerRound = 1;
            this.edRRD.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edRRD.Frame.Top = false;
            this.edRRD.Hint = null;
            this.edRRD.Location = new System.Drawing.Point(678, 89);
            this.edRRD.Margin = new System.Windows.Forms.Padding(4);
            this.edRRD.Max = 0D;
            this.edRRD.Min = 0D;
            this.edRRD.MinimumSize = new System.Drawing.Size(1, 1);
            this.edRRD.Name = "edRRD";
            this.edRRD.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edRRD.PrecisionDigits = 3;
            this.edRRD.ShowHint = false;
            this.edRRD.Size = new System.Drawing.Size(95, 29);
            this.edRRD.TabIndex = 1305;
            this.edRRD.Text = "0";
            // 
            // edPower
            // 
            this.edPower.BackColor = System.Drawing.Color.White;
            this.edPower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edPower.DataType = DaekhonSystem.DataType.Double;
            this.edPower.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPower.Frame.Bottom = false;
            this.edPower.Frame.CornerRound = 1;
            this.edPower.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPower.Frame.Top = false;
            this.edPower.Hint = null;
            this.edPower.Location = new System.Drawing.Point(678, 121);
            this.edPower.Margin = new System.Windows.Forms.Padding(4);
            this.edPower.Max = 0D;
            this.edPower.Min = 0D;
            this.edPower.MinimumSize = new System.Drawing.Size(1, 1);
            this.edPower.Name = "edPower";
            this.edPower.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edPower.PrecisionDigits = 3;
            this.edPower.ShowHint = false;
            this.edPower.Size = new System.Drawing.Size(95, 29);
            this.edPower.TabIndex = 1306;
            this.edPower.Text = "0";
            // 
            // btnSetRRD
            // 
            this.btnSetRRD.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetRRD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetRRD.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSetRRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetRRD.Font = new System.Drawing.Font("굴림", 9F);
            this.btnSetRRD.ForeColor = System.Drawing.Color.Black;
            this.btnSetRRD.Location = new System.Drawing.Point(780, 87);
            this.btnSetRRD.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetRRD.Name = "btnSetRRD";
            this.btnSetRRD.Size = new System.Drawing.Size(77, 30);
            this.btnSetRRD.TabIndex = 1307;
            this.btnSetRRD.Text = "Set";
            this.btnSetRRD.UseVisualStyleBackColor = false;
            this.btnSetRRD.Click += new System.EventHandler(this.btnSetRRD_Click);
            // 
            // gradLabel12
            // 
            this.gradLabel12.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel12.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel12.GradientEnable = false;
            this.gradLabel12.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel12.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel12.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel12.Location = new System.Drawing.Point(464, 89);
            this.gradLabel12.Name = "gradLabel12";
            this.gradLabel12.Size = new System.Drawing.Size(96, 27);
            this.gradLabel12.TabIndex = 1299;
            this.gradLabel12.Text = "RRD";
            this.gradLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gradLabel15.Location = new System.Drawing.Point(464, 121);
            this.gradLabel15.Name = "gradLabel15";
            this.gradLabel15.Size = new System.Drawing.Size(96, 26);
            this.gradLabel15.TabIndex = 1300;
            this.gradLabel15.Text = "Power";
            this.gradLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel16
            // 
            this.gradLabel16.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel16.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel16.GradientEnable = false;
            this.gradLabel16.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel16.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel16.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel16.Location = new System.Drawing.Point(464, 153);
            this.gradLabel16.Name = "gradLabel16";
            this.gradLabel16.Size = new System.Drawing.Size(96, 26);
            this.gradLabel16.TabIndex = 1301;
            this.gradLabel16.Text = "PulseWidth";
            this.gradLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viPulseWidth
            // 
            this.viPulseWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viPulseWidth.Cursor = System.Windows.Forms.Cursors.Default;
            this.viPulseWidth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viPulseWidth.ForeColor = System.Drawing.Color.Black;
            this.viPulseWidth.FormatString = "0";
            this.viPulseWidth.Location = new System.Drawing.Point(562, 153);
            this.viPulseWidth.Name = "viPulseWidth";
            this.viPulseWidth.Size = new System.Drawing.Size(81, 26);
            this.viPulseWidth.TabIndex = 1302;
            this.viPulseWidth.Text = "0";
            this.viPulseWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viLaserPower
            // 
            this.viLaserPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viLaserPower.Cursor = System.Windows.Forms.Cursors.Default;
            this.viLaserPower.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viLaserPower.ForeColor = System.Drawing.Color.Black;
            this.viLaserPower.FormatString = "0.0";
            this.viLaserPower.Location = new System.Drawing.Point(562, 121);
            this.viLaserPower.Name = "viLaserPower";
            this.viLaserPower.Size = new System.Drawing.Size(81, 26);
            this.viLaserPower.TabIndex = 1303;
            this.viLaserPower.Text = "0";
            this.viLaserPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.label36.Font = new System.Drawing.Font("굴림", 9F);
            this.label36.Location = new System.Drawing.Point(644, 162);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(15, 12);
            this.label36.TabIndex = 1297;
            this.label36.Text = "fs";
            // 
            // viRRD
            // 
            this.viRRD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viRRD.Cursor = System.Windows.Forms.Cursors.Default;
            this.viRRD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viRRD.ForeColor = System.Drawing.Color.Black;
            this.viRRD.FormatString = "0";
            this.viRRD.Location = new System.Drawing.Point(562, 89);
            this.viRRD.Name = "viRRD";
            this.viRRD.Size = new System.Drawing.Size(81, 27);
            this.viRRD.TabIndex = 1304;
            this.viRRD.Text = "0";
            this.viRRD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Cursor = System.Windows.Forms.Cursors.Default;
            this.label50.Font = new System.Drawing.Font("굴림", 9F);
            this.label50.Location = new System.Drawing.Point(644, 128);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(15, 12);
            this.label50.TabIndex = 1298;
            this.label50.Text = "%";
            // 
            // uiLine25
            // 
            this.uiLine25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine25.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine25.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine25.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine25.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine25.ForeColor = System.Drawing.Color.Black;
            this.uiLine25.Frame.Visible = false;
            this.uiLine25.Hint = null;
            this.uiLine25.LineCapSize = 4;
            this.uiLine25.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine25.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine25.LineWidth = 1F;
            this.uiLine25.Location = new System.Drawing.Point(467, 60);
            this.uiLine25.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine25.Name = "uiLine25";
            this.uiLine25.ShowHint = false;
            this.uiLine25.Size = new System.Drawing.Size(393, 17);
            this.uiLine25.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine25.TabIndex = 1296;
            this.uiLine25.Text = "Status & Set";
            this.uiLine25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLine25.TextInterval = 4;
            // 
            // uiLine23
            // 
            this.uiLine23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine23.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine23.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine23.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.uiLine23.ForeColor = System.Drawing.Color.Black;
            this.uiLine23.Frame.Visible = false;
            this.uiLine23.Hint = null;
            this.uiLine23.LineCapSize = 4;
            this.uiLine23.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine23.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine23.LineWidth = 1F;
            this.uiLine23.Location = new System.Drawing.Point(467, 201);
            this.uiLine23.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine23.Name = "uiLine23";
            this.uiLine23.ShowHint = false;
            this.uiLine23.Size = new System.Drawing.Size(393, 17);
            this.uiLine23.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine23.TabIndex = 1294;
            this.uiLine23.Text = "Laser Set";
            this.uiLine23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine23.TextInterval = 4;
            // 
            // chkPulseEQ
            // 
            this.chkPulseEQ.Font = new System.Drawing.Font("굴림", 9F);
            this.chkPulseEQ.Location = new System.Drawing.Point(469, 293);
            this.chkPulseEQ.Name = "chkPulseEQ";
            this.chkPulseEQ.Size = new System.Drawing.Size(356, 21);
            this.chkPulseEQ.TabIndex = 1293;
            this.chkPulseEQ.Text = "PulseEQ Mode";
            this.chkPulseEQ.UseVisualStyleBackColor = true;
            // 
            // btnSystemStop
            // 
            this.btnSystemStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSystemStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSystemStop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSystemStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemStop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSystemStop.ForeColor = System.Drawing.Color.Black;
            this.btnSystemStop.Location = new System.Drawing.Point(265, 542);
            this.btnSystemStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSystemStop.Name = "btnSystemStop";
            this.btnSystemStop.Size = new System.Drawing.Size(92, 46);
            this.btnSystemStop.TabIndex = 1289;
            this.btnSystemStop.Text = "Stop";
            this.btnSystemStop.UseVisualStyleBackColor = false;
            this.btnSystemStop.Click += new System.EventHandler(this.btnSystemStop_Click);
            // 
            // btnSystemStart
            // 
            this.btnSystemStart.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSystemStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSystemStart.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSystemStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSystemStart.ForeColor = System.Drawing.Color.Black;
            this.btnSystemStart.Location = new System.Drawing.Point(265, 491);
            this.btnSystemStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSystemStart.Name = "btnSystemStart";
            this.btnSystemStart.Size = new System.Drawing.Size(92, 46);
            this.btnSystemStart.TabIndex = 1292;
            this.btnSystemStart.Text = "Start";
            this.btnSystemStart.UseVisualStyleBackColor = false;
            this.btnSystemStart.Click += new System.EventHandler(this.btnSystemStart_Click);
            // 
            // uiLine19
            // 
            this.uiLine19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine19.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine19.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine19.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine19.ForeColor = System.Drawing.Color.Black;
            this.uiLine19.Frame.Visible = false;
            this.uiLine19.Hint = null;
            this.uiLine19.LineCapSize = 4;
            this.uiLine19.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine19.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine19.LineWidth = 1F;
            this.uiLine19.Location = new System.Drawing.Point(15, 465);
            this.uiLine19.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine19.Name = "uiLine19";
            this.uiLine19.ShowHint = false;
            this.uiLine19.Size = new System.Drawing.Size(401, 17);
            this.uiLine19.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine19.TabIndex = 1284;
            this.uiLine19.Text = "System Status";
            this.uiLine19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine19.TextInterval = 4;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLine1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiLine1.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.uiLine1.EndCap = DaekhonSystem.UILineCap.None;
            this.uiLine1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine1.ForeColor = System.Drawing.Color.Black;
            this.uiLine1.Frame.Visible = false;
            this.uiLine1.Hint = null;
            this.uiLine1.LineCapSize = 4;
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine1.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine1.LineWidth = 1F;
            this.uiLine1.Location = new System.Drawing.Point(15, 399);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.ShowHint = false;
            this.uiLine1.Size = new System.Drawing.Size(401, 17);
            this.uiLine1.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine1.TabIndex = 1285;
            this.uiLine1.Text = "Key Switch";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine1.TextInterval = 4;
            // 
            // panManualCoherent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "panManualCoherent";
            this.Size = new System.Drawing.Size(940, 849);
            this.panClient.ResumeLayout(false);
            this.panClient.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataServer dsLaser;
        private AsyncClient ReadSession;
        private AsyncClient WriteSession;
        private Thread ReadThread;
        private sjPanel panClient;
        private DaekhonSystem.ComboBox cbLaserSet;
        private System.Windows.Forms.Label lblCurLaserParam;
        private GradientLabel gradLabel57;
        private GradientLabel gradLabel44;
        private GradientLabel gradLabel23; 
        private SunnyLine uiLine36; 
        private GradientLabel gradLabel38;
        private GradientLabel gradLabel43;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private BitBtn btnLogClear;
        private DaekhonSystem.ListBox ListBoxStatus;
        private SunnyLine uiLine26;
        private BitBtn btnSetPulseWidth;
        private BitBtn btnSetPower;
        private NumberEdit edPulseWidth;
        private NumberEdit edRRD;
        private NumberEdit edPower;
        private BitBtn btnSetRRD;
        private GradientLabel gradLabel12;
        private GradientLabel gradLabel15;
        private GradientLabel gradLabel16;
        private ValueIndicator viPulseWidth;
        private ValueIndicator viLaserPower;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label50;
        private SunnyLine uiLine25;
        private SunnyLine uiLine23;
        private System.Windows.Forms.CheckBox chkPulseEQ;
        private BitBtn btnSystemStop;
        private BitBtn btnSystemStart;
        private SunnyLine uiLine19;
        private SunnyLine uiLine1;
        private ValueIndicator viChillerSetTemp;
        private ValueIndicator viChillerCurrTemp;
        private ValueIndicator viRRD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private LEDLabel ledKeyOn;
        private LEDLabel ledStandbyOn;
        private LEDLabel ledSystemLaserOn;
        private LEDLabel ledSystemFault;
        private LEDButton btnChillerStop;
        private LEDButton btnChillerRun;
        private LEDButton btnChillerFault;
        private LEDButton ledbtnReset;
        public LEDButton btnDisconnect;
        public LEDButton btnConnect;
        public LEDButton btnShutterClose;
        public LEDButton btnShutterOpen;
        public LEDButton btnPulseOff;
        public LEDButton btnPulseOn;
    }
}
