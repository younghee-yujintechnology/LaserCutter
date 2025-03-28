using DaekhonSystem;

namespace LaserCutter
{
    partial class panManualCarbide
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
            this.dsLaser = new DaekhonSystem.DataServer();
            this.tmr_LaserStatus = new System.Windows.Forms.Timer(this.components);
            this.ReadThread = new DaekhonSystem.Thread();
            this.panClient = new LaserCutter.sjPanel();
            this.edBurstControlP = new DaekhonSystem.NumberEdit();
            this.btnBurstControlP = new DaekhonSystem.BitBtn();
            this.gradientLabel4 = new DaekhonSystem.GradientLabel();
            this.viBurstControlP = new DaekhonSystem.ValueIndicator();
            this.edBurstEnvelopeControlP = new DaekhonSystem.NumberEdit();
            this.btnBurstEnvelopeControlP = new DaekhonSystem.BitBtn();
            this.gradientLabel3 = new DaekhonSystem.GradientLabel();
            this.viBurstEnvelopeControlP = new DaekhonSystem.ValueIndicator();
            this.edBurstEnvelopeControlN = new DaekhonSystem.NumberEdit();
            this.btnBurstEnvelopeControlN = new DaekhonSystem.BitBtn();
            this.gradientLabel7 = new DaekhonSystem.GradientLabel();
            this.viBurstEnvelopeControlN = new DaekhonSystem.ValueIndicator();
            this.btnExternalLow = new DaekhonSystem.LEDButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExternalHigh = new DaekhonSystem.LEDButton();
            this.btnInternal = new DaekhonSystem.LEDButton();
            this.lblShutterStatus = new DaekhonSystem.Label();
            this.lblEmissionStatus = new DaekhonSystem.Label();
            this.lblLaserStatus = new DaekhonSystem.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edTargetTemp = new DaekhonSystem.NumberEdit();
            this.btnChillerTempSet = new DaekhonSystem.BitBtn();
            this.lbChillerStatus = new System.Windows.Forms.Label();
            this.btnChillerOff = new DaekhonSystem.LEDButton();
            this.btnchillerOn = new DaekhonSystem.LEDButton();
            this.edBurstControlN = new DaekhonSystem.NumberEdit();
            this.btnBurstControlN = new DaekhonSystem.BitBtn();
            this.gradientLabel2 = new DaekhonSystem.GradientLabel();
            this.viBurstControlN = new DaekhonSystem.ValueIndicator();
            this.edPPDivider = new DaekhonSystem.NumberEdit();
            this.btnPPDivider = new DaekhonSystem.BitBtn();
            this.gradientLabel1 = new DaekhonSystem.GradientLabel();
            this.viPPDivider = new DaekhonSystem.ValueIndicator();
            this.btnApply = new DaekhonSystem.BitBtn();
            this.btnStandBy = new DaekhonSystem.BitBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.switchChirp = new DaekhonSystem.SunnySwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.edPulseduration = new DaekhonSystem.NumberEdit();
            this.btnPulseduration = new DaekhonSystem.BitBtn();
            this.lbCurrentPulseDuration = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShutterClose = new DaekhonSystem.LEDButton();
            this.btnShutterOpen = new DaekhonSystem.LEDButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new DaekhonSystem.LEDButton();
            this.btnConnect = new DaekhonSystem.LEDButton();
            this.cbLaserSet = new DaekhonSystem.ComboBox();
            this.lblCurLaserParam = new System.Windows.Forms.Label();
            this.gradLabel57 = new DaekhonSystem.GradientLabel();
            this.btnLogClear = new DaekhonSystem.BitBtn();
            this.ListBoxStatus = new DaekhonSystem.ListBox();
            this.uiLine26 = new DaekhonSystem.SunnyLine();
            this.edAttenuator = new DaekhonSystem.NumberEdit();
            this.btnSetAttenuator = new DaekhonSystem.BitBtn();
            this.Attenuotor = new DaekhonSystem.GradientLabel();
            this.gradLabel15 = new DaekhonSystem.GradientLabel();
            this.gradLabel16 = new DaekhonSystem.GradientLabel();
            this.viFrequency = new DaekhonSystem.ValueIndicator();
            this.viPower = new DaekhonSystem.ValueIndicator();
            this.label36 = new System.Windows.Forms.Label();
            this.viAttenuator = new DaekhonSystem.ValueIndicator();
            this.label50 = new System.Windows.Forms.Label();
            this.uiLine25 = new DaekhonSystem.SunnyLine();
            this.uiLine23 = new DaekhonSystem.SunnyLine();
            this.panClient.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsLaser
            // 
            this.dsLaser.OnError += new DaekhonSystem.ErrorEventHandler(this.dataServer1_OnError);
            // 
            // tmr_LaserStatus
            // 
            this.tmr_LaserStatus.Enabled = true;
            this.tmr_LaserStatus.Interval = 200;
            this.tmr_LaserStatus.Tick += new System.EventHandler(this.tmr_LaserStatus_Tick);
            // 
            // ReadThread
            // 
            this.ReadThread.Enabled = true;
            this.ReadThread.Interval = 100;
            this.ReadThread.OnExecute += new System.EventHandler(this.ReadThread_OnExecute);
            // 
            // panClient
            // 
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.edBurstControlP);
            this.panClient.Controls.Add(this.btnBurstControlP);
            this.panClient.Controls.Add(this.gradientLabel4);
            this.panClient.Controls.Add(this.viBurstControlP);
            this.panClient.Controls.Add(this.edBurstEnvelopeControlP);
            this.panClient.Controls.Add(this.btnBurstEnvelopeControlP);
            this.panClient.Controls.Add(this.gradientLabel3);
            this.panClient.Controls.Add(this.viBurstEnvelopeControlP);
            this.panClient.Controls.Add(this.edBurstEnvelopeControlN);
            this.panClient.Controls.Add(this.btnBurstEnvelopeControlN);
            this.panClient.Controls.Add(this.gradientLabel7);
            this.panClient.Controls.Add(this.viBurstEnvelopeControlN);
            this.panClient.Controls.Add(this.btnExternalLow);
            this.panClient.Controls.Add(this.groupBox5);
            this.panClient.Controls.Add(this.lblShutterStatus);
            this.panClient.Controls.Add(this.lblEmissionStatus);
            this.panClient.Controls.Add(this.lblLaserStatus);
            this.panClient.Controls.Add(this.groupBox4);
            this.panClient.Controls.Add(this.edBurstControlN);
            this.panClient.Controls.Add(this.btnBurstControlN);
            this.panClient.Controls.Add(this.gradientLabel2);
            this.panClient.Controls.Add(this.viBurstControlN);
            this.panClient.Controls.Add(this.edPPDivider);
            this.panClient.Controls.Add(this.btnPPDivider);
            this.panClient.Controls.Add(this.gradientLabel1);
            this.panClient.Controls.Add(this.viPPDivider);
            this.panClient.Controls.Add(this.btnApply);
            this.panClient.Controls.Add(this.btnStandBy);
            this.panClient.Controls.Add(this.label1);
            this.panClient.Controls.Add(this.groupBox3);
            this.panClient.Controls.Add(this.groupBox2);
            this.panClient.Controls.Add(this.groupBox1);
            this.panClient.Controls.Add(this.cbLaserSet);
            this.panClient.Controls.Add(this.lblCurLaserParam);
            this.panClient.Controls.Add(this.gradLabel57);
            this.panClient.Controls.Add(this.btnLogClear);
            this.panClient.Controls.Add(this.ListBoxStatus);
            this.panClient.Controls.Add(this.uiLine26);
            this.panClient.Controls.Add(this.edAttenuator);
            this.panClient.Controls.Add(this.btnSetAttenuator);
            this.panClient.Controls.Add(this.Attenuotor);
            this.panClient.Controls.Add(this.gradLabel15);
            this.panClient.Controls.Add(this.gradLabel16);
            this.panClient.Controls.Add(this.viFrequency);
            this.panClient.Controls.Add(this.viPower);
            this.panClient.Controls.Add(this.label36);
            this.panClient.Controls.Add(this.viAttenuator);
            this.panClient.Controls.Add(this.label50);
            this.panClient.Controls.Add(this.uiLine25);
            this.panClient.Controls.Add(this.uiLine23);
            this.panClient.Location = new System.Drawing.Point(3, 3);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(936, 843);
            this.panClient.TabIndex = 1279;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.Color.Black;
            this.panClient.TitleText = "Laser - Carbide";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edBurstControlP
            // 
            this.edBurstControlP.BackColor = System.Drawing.Color.White;
            this.edBurstControlP.Cursor = System.Windows.Forms.Cursors.Default;
            this.edBurstControlP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edBurstControlP.Frame.Bottom = false;
            this.edBurstControlP.Frame.CornerRound = 1;
            this.edBurstControlP.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edBurstControlP.Frame.Top = false;
            this.edBurstControlP.Hint = null;
            this.edBurstControlP.Location = new System.Drawing.Point(594, 310);
            this.edBurstControlP.Margin = new System.Windows.Forms.Padding(4);
            this.edBurstControlP.Max = 0D;
            this.edBurstControlP.Min = 0D;
            this.edBurstControlP.MinimumSize = new System.Drawing.Size(1, 1);
            this.edBurstControlP.Name = "edBurstControlP";
            this.edBurstControlP.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edBurstControlP.PrecisionDigits = 3;
            this.edBurstControlP.ShowHint = false;
            this.edBurstControlP.Size = new System.Drawing.Size(95, 29);
            this.edBurstControlP.TabIndex = 1376;
            this.edBurstControlP.Text = "0";
            // 
            // btnBurstControlP
            // 
            this.btnBurstControlP.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnBurstControlP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBurstControlP.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnBurstControlP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurstControlP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBurstControlP.ForeColor = System.Drawing.Color.Black;
            this.btnBurstControlP.Location = new System.Drawing.Point(692, 309);
            this.btnBurstControlP.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBurstControlP.Name = "btnBurstControlP";
            this.btnBurstControlP.Size = new System.Drawing.Size(77, 30);
            this.btnBurstControlP.TabIndex = 1377;
            this.btnBurstControlP.Text = "Set";
            this.btnBurstControlP.UseVisualStyleBackColor = false;
            this.btnBurstControlP.Click += new System.EventHandler(this.btnBurstControlP_Click);
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gradientLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gradientLabel4.Frame.Visible = false;
            this.gradientLabel4.GradientEnable = false;
            this.gradientLabel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel4.Location = new System.Drawing.Point(377, 311);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(99, 26);
            this.gradientLabel4.TabIndex = 1374;
            this.gradientLabel4.Text = "Burst Control P";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viBurstControlP
            // 
            this.viBurstControlP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viBurstControlP.Cursor = System.Windows.Forms.Cursors.Default;
            this.viBurstControlP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viBurstControlP.ForeColor = System.Drawing.Color.Black;
            this.viBurstControlP.Location = new System.Drawing.Point(480, 311);
            this.viBurstControlP.Name = "viBurstControlP";
            this.viBurstControlP.Size = new System.Drawing.Size(81, 26);
            this.viBurstControlP.TabIndex = 1375;
            this.viBurstControlP.Text = "0";
            this.viBurstControlP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edBurstEnvelopeControlP
            // 
            this.edBurstEnvelopeControlP.BackColor = System.Drawing.Color.White;
            this.edBurstEnvelopeControlP.Cursor = System.Windows.Forms.Cursors.Default;
            this.edBurstEnvelopeControlP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edBurstEnvelopeControlP.Frame.Bottom = false;
            this.edBurstEnvelopeControlP.Frame.CornerRound = 1;
            this.edBurstEnvelopeControlP.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edBurstEnvelopeControlP.Frame.Top = false;
            this.edBurstEnvelopeControlP.Hint = null;
            this.edBurstEnvelopeControlP.Location = new System.Drawing.Point(594, 346);
            this.edBurstEnvelopeControlP.Margin = new System.Windows.Forms.Padding(4);
            this.edBurstEnvelopeControlP.Max = 0D;
            this.edBurstEnvelopeControlP.Min = 0D;
            this.edBurstEnvelopeControlP.MinimumSize = new System.Drawing.Size(1, 1);
            this.edBurstEnvelopeControlP.Name = "edBurstEnvelopeControlP";
            this.edBurstEnvelopeControlP.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edBurstEnvelopeControlP.PrecisionDigits = 3;
            this.edBurstEnvelopeControlP.ShowHint = false;
            this.edBurstEnvelopeControlP.Size = new System.Drawing.Size(95, 29);
            this.edBurstEnvelopeControlP.TabIndex = 1372;
            this.edBurstEnvelopeControlP.Text = "0";
            // 
            // btnBurstEnvelopeControlP
            // 
            this.btnBurstEnvelopeControlP.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnBurstEnvelopeControlP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBurstEnvelopeControlP.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnBurstEnvelopeControlP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurstEnvelopeControlP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBurstEnvelopeControlP.ForeColor = System.Drawing.Color.Black;
            this.btnBurstEnvelopeControlP.Location = new System.Drawing.Point(692, 345);
            this.btnBurstEnvelopeControlP.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBurstEnvelopeControlP.Name = "btnBurstEnvelopeControlP";
            this.btnBurstEnvelopeControlP.Size = new System.Drawing.Size(77, 30);
            this.btnBurstEnvelopeControlP.TabIndex = 1373;
            this.btnBurstEnvelopeControlP.Text = "Set";
            this.btnBurstEnvelopeControlP.UseVisualStyleBackColor = false;
            this.btnBurstEnvelopeControlP.Click += new System.EventHandler(this.btnBurstEnvelopeControlP_Click);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gradientLabel3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gradientLabel3.Frame.Visible = false;
            this.gradientLabel3.GradientEnable = false;
            this.gradientLabel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel3.Location = new System.Drawing.Point(355, 347);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(121, 26);
            this.gradientLabel3.TabIndex = 1370;
            this.gradientLabel3.Text = "Envelope Control P";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viBurstEnvelopeControlP
            // 
            this.viBurstEnvelopeControlP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viBurstEnvelopeControlP.Cursor = System.Windows.Forms.Cursors.Default;
            this.viBurstEnvelopeControlP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viBurstEnvelopeControlP.ForeColor = System.Drawing.Color.Black;
            this.viBurstEnvelopeControlP.Location = new System.Drawing.Point(480, 347);
            this.viBurstEnvelopeControlP.Name = "viBurstEnvelopeControlP";
            this.viBurstEnvelopeControlP.Size = new System.Drawing.Size(81, 26);
            this.viBurstEnvelopeControlP.TabIndex = 1371;
            this.viBurstEnvelopeControlP.Text = "0";
            this.viBurstEnvelopeControlP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edBurstEnvelopeControlN
            // 
            this.edBurstEnvelopeControlN.BackColor = System.Drawing.Color.White;
            this.edBurstEnvelopeControlN.Cursor = System.Windows.Forms.Cursors.Default;
            this.edBurstEnvelopeControlN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edBurstEnvelopeControlN.Frame.Bottom = false;
            this.edBurstEnvelopeControlN.Frame.CornerRound = 1;
            this.edBurstEnvelopeControlN.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edBurstEnvelopeControlN.Frame.Top = false;
            this.edBurstEnvelopeControlN.Hint = null;
            this.edBurstEnvelopeControlN.Location = new System.Drawing.Point(594, 424);
            this.edBurstEnvelopeControlN.Margin = new System.Windows.Forms.Padding(4);
            this.edBurstEnvelopeControlN.Max = 0D;
            this.edBurstEnvelopeControlN.Min = 0D;
            this.edBurstEnvelopeControlN.MinimumSize = new System.Drawing.Size(1, 1);
            this.edBurstEnvelopeControlN.Name = "edBurstEnvelopeControlN";
            this.edBurstEnvelopeControlN.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edBurstEnvelopeControlN.PrecisionDigits = 3;
            this.edBurstEnvelopeControlN.ShowHint = false;
            this.edBurstEnvelopeControlN.Size = new System.Drawing.Size(95, 29);
            this.edBurstEnvelopeControlN.TabIndex = 1368;
            this.edBurstEnvelopeControlN.Text = "0";
            // 
            // btnBurstEnvelopeControlN
            // 
            this.btnBurstEnvelopeControlN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnBurstEnvelopeControlN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBurstEnvelopeControlN.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnBurstEnvelopeControlN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurstEnvelopeControlN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBurstEnvelopeControlN.ForeColor = System.Drawing.Color.Black;
            this.btnBurstEnvelopeControlN.Location = new System.Drawing.Point(692, 423);
            this.btnBurstEnvelopeControlN.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBurstEnvelopeControlN.Name = "btnBurstEnvelopeControlN";
            this.btnBurstEnvelopeControlN.Size = new System.Drawing.Size(77, 30);
            this.btnBurstEnvelopeControlN.TabIndex = 1369;
            this.btnBurstEnvelopeControlN.Text = "Set";
            this.btnBurstEnvelopeControlN.UseVisualStyleBackColor = false;
            this.btnBurstEnvelopeControlN.Click += new System.EventHandler(this.btnBurstEnvelopeControlN_Click);
            // 
            // gradientLabel7
            // 
            this.gradientLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gradientLabel7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gradientLabel7.Frame.Visible = false;
            this.gradientLabel7.GradientEnable = false;
            this.gradientLabel7.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel7.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel7.Location = new System.Drawing.Point(358, 425);
            this.gradientLabel7.Name = "gradientLabel7";
            this.gradientLabel7.Size = new System.Drawing.Size(118, 26);
            this.gradientLabel7.TabIndex = 1366;
            this.gradientLabel7.Text = "Envelope Control N";
            this.gradientLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viBurstEnvelopeControlN
            // 
            this.viBurstEnvelopeControlN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viBurstEnvelopeControlN.Cursor = System.Windows.Forms.Cursors.Default;
            this.viBurstEnvelopeControlN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viBurstEnvelopeControlN.ForeColor = System.Drawing.Color.Black;
            this.viBurstEnvelopeControlN.Location = new System.Drawing.Point(480, 425);
            this.viBurstEnvelopeControlN.Name = "viBurstEnvelopeControlN";
            this.viBurstEnvelopeControlN.Size = new System.Drawing.Size(81, 26);
            this.viBurstEnvelopeControlN.TabIndex = 1367;
            this.viBurstEnvelopeControlN.Text = "0";
            this.viBurstEnvelopeControlN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExternalLow
            // 
            this.btnExternalLow.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnExternalLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnExternalLow.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnExternalLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExternalLow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExternalLow.ForeColor = System.Drawing.Color.Black;
            this.btnExternalLow.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnExternalLow.LED.Size = new System.Drawing.Size(70, 26);
            this.btnExternalLow.Location = new System.Drawing.Point(508, 765);
            this.btnExternalLow.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExternalLow.Name = "btnExternalLow";
            this.btnExternalLow.Size = new System.Drawing.Size(89, 46);
            this.btnExternalLow.TabIndex = 1365;
            this.btnExternalLow.Text = "Ext-Low";
            this.btnExternalLow.UseVisualStyleBackColor = false;
            this.btnExternalLow.Visible = false;
            this.btnExternalLow.Click += new System.EventHandler(this.btnExternalLow_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExternalHigh);
            this.groupBox5.Controls.Add(this.btnInternal);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox5.Location = new System.Drawing.Point(107, 503);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 87);
            this.groupBox5.TabIndex = 1363;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "  Trigger Internal/External  ";
            // 
            // btnExternalHigh
            // 
            this.btnExternalHigh.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnExternalHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnExternalHigh.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnExternalHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExternalHigh.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExternalHigh.ForeColor = System.Drawing.Color.Black;
            this.btnExternalHigh.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnExternalHigh.LED.Size = new System.Drawing.Size(70, 26);
            this.btnExternalHigh.Location = new System.Drawing.Point(130, 27);
            this.btnExternalHigh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExternalHigh.Name = "btnExternalHigh";
            this.btnExternalHigh.Size = new System.Drawing.Size(89, 46);
            this.btnExternalHigh.TabIndex = 1366;
            this.btnExternalHigh.Text = "External";
            this.btnExternalHigh.UseVisualStyleBackColor = false;
            this.btnExternalHigh.Click += new System.EventHandler(this.btnExternalHigh_Click);
            // 
            // btnInternal
            // 
            this.btnInternal.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnInternal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnInternal.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnInternal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnInternal.ForeColor = System.Drawing.Color.Black;
            this.btnInternal.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnInternal.LED.Size = new System.Drawing.Size(70, 26);
            this.btnInternal.Location = new System.Drawing.Point(24, 27);
            this.btnInternal.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnInternal.Name = "btnInternal";
            this.btnInternal.Size = new System.Drawing.Size(89, 46);
            this.btnInternal.TabIndex = 1364;
            this.btnInternal.Text = "Internal";
            this.btnInternal.UseVisualStyleBackColor = false;
            this.btnInternal.Click += new System.EventHandler(this.btnInternal_Click);
            // 
            // lblShutterStatus
            // 
            this.lblShutterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblShutterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblShutterStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblShutterStatus.ForeColor = System.Drawing.Color.Black;
            this.lblShutterStatus.Location = new System.Drawing.Point(490, 109);
            this.lblShutterStatus.Name = "lblShutterStatus";
            this.lblShutterStatus.Size = new System.Drawing.Size(295, 33);
            this.lblShutterStatus.TabIndex = 1362;
            this.lblShutterStatus.Text = "Main Output is closed";
            this.lblShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmissionStatus
            // 
            this.lblEmissionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmissionStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmissionStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEmissionStatus.ForeColor = System.Drawing.Color.Black;
            this.lblEmissionStatus.Location = new System.Drawing.Point(490, 70);
            this.lblEmissionStatus.Name = "lblEmissionStatus";
            this.lblEmissionStatus.Size = new System.Drawing.Size(295, 33);
            this.lblEmissionStatus.TabIndex = 1361;
            this.lblEmissionStatus.Text = "No emission";
            this.lblEmissionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserStatus
            // 
            this.lblLaserStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLaserStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLaserStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLaserStatus.ForeColor = System.Drawing.Color.Black;
            this.lblLaserStatus.Location = new System.Drawing.Point(107, 70);
            this.lblLaserStatus.Name = "lblLaserStatus";
            this.lblLaserStatus.Size = new System.Drawing.Size(372, 72);
            this.lblLaserStatus.TabIndex = 1360;
            this.lblLaserStatus.Text = "Standing by";
            this.lblLaserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.edTargetTemp);
            this.groupBox4.Controls.Add(this.btnChillerTempSet);
            this.groupBox4.Controls.Add(this.lbChillerStatus);
            this.groupBox4.Controls.Add(this.btnChillerOff);
            this.groupBox4.Controls.Add(this.btnchillerOn);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox4.Location = new System.Drawing.Point(107, 601);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 158);
            this.groupBox4.TabIndex = 1359;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "  Chiller  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.Location = new System.Drawing.Point(117, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1362;
            this.label4.Text = "℃";
            // 
            // edTargetTemp
            // 
            this.edTargetTemp.BackColor = System.Drawing.Color.White;
            this.edTargetTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.edTargetTemp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edTargetTemp.Frame.Bottom = false;
            this.edTargetTemp.Frame.CornerRound = 1;
            this.edTargetTemp.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edTargetTemp.Frame.Top = false;
            this.edTargetTemp.Hint = null;
            this.edTargetTemp.Location = new System.Drawing.Point(24, 118);
            this.edTargetTemp.Margin = new System.Windows.Forms.Padding(4);
            this.edTargetTemp.Max = 0D;
            this.edTargetTemp.Min = 0D;
            this.edTargetTemp.MinimumSize = new System.Drawing.Size(1, 1);
            this.edTargetTemp.Name = "edTargetTemp";
            this.edTargetTemp.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edTargetTemp.PrecisionDigits = 3;
            this.edTargetTemp.ShowHint = false;
            this.edTargetTemp.Size = new System.Drawing.Size(89, 29);
            this.edTargetTemp.TabIndex = 1359;
            this.edTargetTemp.Text = "0";
            // 
            // btnChillerTempSet
            // 
            this.btnChillerTempSet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChillerTempSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnChillerTempSet.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnChillerTempSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChillerTempSet.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChillerTempSet.ForeColor = System.Drawing.Color.Black;
            this.btnChillerTempSet.Location = new System.Drawing.Point(142, 118);
            this.btnChillerTempSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChillerTempSet.Name = "btnChillerTempSet";
            this.btnChillerTempSet.Size = new System.Drawing.Size(77, 30);
            this.btnChillerTempSet.TabIndex = 1360;
            this.btnChillerTempSet.Text = "Set";
            this.btnChillerTempSet.UseVisualStyleBackColor = false;
            this.btnChillerTempSet.Click += new System.EventHandler(this.btnChillerTempSet_Click);
            // 
            // lbChillerStatus
            // 
            this.lbChillerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbChillerStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbChillerStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbChillerStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbChillerStatus.ForeColor = System.Drawing.Color.Black;
            this.lbChillerStatus.Location = new System.Drawing.Point(18, 22);
            this.lbChillerStatus.Name = "lbChillerStatus";
            this.lbChillerStatus.Size = new System.Drawing.Size(227, 26);
            this.lbChillerStatus.TabIndex = 1331;
            this.lbChillerStatus.Text = "Off (24.23℃)";
            this.lbChillerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChillerOff
            // 
            this.btnChillerOff.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnChillerOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnChillerOff.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnChillerOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChillerOff.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChillerOff.ForeColor = System.Drawing.Color.Black;
            this.btnChillerOff.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnChillerOff.LED.Size = new System.Drawing.Size(70, 26);
            this.btnChillerOff.Location = new System.Drawing.Point(130, 57);
            this.btnChillerOff.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChillerOff.Name = "btnChillerOff";
            this.btnChillerOff.Size = new System.Drawing.Size(89, 46);
            this.btnChillerOff.TabIndex = 1292;
            this.btnChillerOff.Text = "Chiller Off";
            this.btnChillerOff.UseVisualStyleBackColor = false;
            this.btnChillerOff.Click += new System.EventHandler(this.btnChillerOff_Click);
            // 
            // btnchillerOn
            // 
            this.btnchillerOn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnchillerOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnchillerOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnchillerOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchillerOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnchillerOn.ForeColor = System.Drawing.Color.Black;
            this.btnchillerOn.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnchillerOn.LED.Size = new System.Drawing.Size(70, 26);
            this.btnchillerOn.Location = new System.Drawing.Point(24, 57);
            this.btnchillerOn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnchillerOn.Name = "btnchillerOn";
            this.btnchillerOn.Size = new System.Drawing.Size(89, 46);
            this.btnchillerOn.TabIndex = 1293;
            this.btnchillerOn.Text = "Chiller On";
            this.btnchillerOn.UseVisualStyleBackColor = false;
            this.btnchillerOn.Click += new System.EventHandler(this.btnchillerOn_Click);
            // 
            // edBurstControlN
            // 
            this.edBurstControlN.BackColor = System.Drawing.Color.White;
            this.edBurstControlN.Cursor = System.Windows.Forms.Cursors.Default;
            this.edBurstControlN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edBurstControlN.Frame.Bottom = false;
            this.edBurstControlN.Frame.CornerRound = 1;
            this.edBurstControlN.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edBurstControlN.Frame.Top = false;
            this.edBurstControlN.Hint = null;
            this.edBurstControlN.Location = new System.Drawing.Point(594, 388);
            this.edBurstControlN.Margin = new System.Windows.Forms.Padding(4);
            this.edBurstControlN.Max = 0D;
            this.edBurstControlN.Min = 0D;
            this.edBurstControlN.MinimumSize = new System.Drawing.Size(1, 1);
            this.edBurstControlN.Name = "edBurstControlN";
            this.edBurstControlN.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edBurstControlN.PrecisionDigits = 3;
            this.edBurstControlN.ShowHint = false;
            this.edBurstControlN.Size = new System.Drawing.Size(95, 29);
            this.edBurstControlN.TabIndex = 1357;
            this.edBurstControlN.Text = "0";
            // 
            // btnBurstControlN
            // 
            this.btnBurstControlN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnBurstControlN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBurstControlN.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnBurstControlN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurstControlN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBurstControlN.ForeColor = System.Drawing.Color.Black;
            this.btnBurstControlN.Location = new System.Drawing.Point(692, 387);
            this.btnBurstControlN.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBurstControlN.Name = "btnBurstControlN";
            this.btnBurstControlN.Size = new System.Drawing.Size(77, 30);
            this.btnBurstControlN.TabIndex = 1358;
            this.btnBurstControlN.Text = "Set";
            this.btnBurstControlN.UseVisualStyleBackColor = false;
            this.btnBurstControlN.Click += new System.EventHandler(this.btnBurstControl_Click);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gradientLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gradientLabel2.Frame.Visible = false;
            this.gradientLabel2.GradientEnable = false;
            this.gradientLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel2.Location = new System.Drawing.Point(377, 389);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(99, 26);
            this.gradientLabel2.TabIndex = 1355;
            this.gradientLabel2.Text = "Burst Control N";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viBurstControlN
            // 
            this.viBurstControlN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viBurstControlN.Cursor = System.Windows.Forms.Cursors.Default;
            this.viBurstControlN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viBurstControlN.ForeColor = System.Drawing.Color.Black;
            this.viBurstControlN.Location = new System.Drawing.Point(480, 389);
            this.viBurstControlN.Name = "viBurstControlN";
            this.viBurstControlN.Size = new System.Drawing.Size(81, 26);
            this.viBurstControlN.TabIndex = 1356;
            this.viBurstControlN.Text = "0";
            this.viBurstControlN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edPPDivider
            // 
            this.edPPDivider.BackColor = System.Drawing.Color.White;
            this.edPPDivider.Cursor = System.Windows.Forms.Cursors.Default;
            this.edPPDivider.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPPDivider.Frame.Bottom = false;
            this.edPPDivider.Frame.CornerRound = 1;
            this.edPPDivider.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPPDivider.Frame.Top = false;
            this.edPPDivider.Hint = null;
            this.edPPDivider.Location = new System.Drawing.Point(594, 267);
            this.edPPDivider.Margin = new System.Windows.Forms.Padding(4);
            this.edPPDivider.Max = 0D;
            this.edPPDivider.Min = 0D;
            this.edPPDivider.MinimumSize = new System.Drawing.Size(1, 1);
            this.edPPDivider.Name = "edPPDivider";
            this.edPPDivider.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edPPDivider.PrecisionDigits = 3;
            this.edPPDivider.ShowHint = false;
            this.edPPDivider.Size = new System.Drawing.Size(95, 29);
            this.edPPDivider.TabIndex = 1353;
            this.edPPDivider.Text = "0";
            // 
            // btnPPDivider
            // 
            this.btnPPDivider.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPPDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPPDivider.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnPPDivider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPPDivider.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPPDivider.ForeColor = System.Drawing.Color.Black;
            this.btnPPDivider.Location = new System.Drawing.Point(692, 266);
            this.btnPPDivider.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPPDivider.Name = "btnPPDivider";
            this.btnPPDivider.Size = new System.Drawing.Size(77, 30);
            this.btnPPDivider.TabIndex = 1354;
            this.btnPPDivider.Text = "Set";
            this.btnPPDivider.UseVisualStyleBackColor = false;
            this.btnPPDivider.Click += new System.EventHandler(this.btnPPDivider_Click);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel1.Frame.Visible = false;
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(377, 268);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(99, 26);
            this.gradientLabel1.TabIndex = 1351;
            this.gradientLabel1.Text = "PP Divider";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viPPDivider
            // 
            this.viPPDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viPPDivider.Cursor = System.Windows.Forms.Cursors.Default;
            this.viPPDivider.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viPPDivider.ForeColor = System.Drawing.Color.Black;
            this.viPPDivider.Location = new System.Drawing.Point(480, 268);
            this.viPPDivider.Name = "viPPDivider";
            this.viPPDivider.Size = new System.Drawing.Size(81, 26);
            this.viPPDivider.TabIndex = 1352;
            this.viPPDivider.Text = "0";
            this.viPPDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            this.btnApply.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnApply.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(608, 565);
            this.btnApply.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(77, 30);
            this.btnApply.TabIndex = 1350;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnStandBy
            // 
            this.btnStandBy.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStandBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStandBy.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnStandBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStandBy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnStandBy.ForeColor = System.Drawing.Color.Black;
            this.btnStandBy.Location = new System.Drawing.Point(691, 565);
            this.btnStandBy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStandBy.Name = "btnStandBy";
            this.btnStandBy.Size = new System.Drawing.Size(77, 30);
            this.btnStandBy.TabIndex = 1349;
            this.btnStandBy.Text = "StandBy";
            this.btnStandBy.UseVisualStyleBackColor = false;
            this.btnStandBy.Click += new System.EventHandler(this.btnStandBy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.Location = new System.Drawing.Point(568, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 1348;
            this.label1.Text = "%";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.switchChirp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.edPulseduration);
            this.groupBox3.Controls.Add(this.btnPulseduration);
            this.groupBox3.Controls.Add(this.lbCurrentPulseDuration);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(107, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 125);
            this.groupBox3.TabIndex = 1346;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Other  ";
            // 
            // switchChirp
            // 
            this.switchChirp.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchChirp.Channel = null;
            this.switchChirp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchChirp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchChirp.Hint = null;
            this.switchChirp.Location = new System.Drawing.Point(13, 52);
            this.switchChirp.Name = "switchChirp";
            this.switchChirp.ShowHint = false;
            this.switchChirp.Size = new System.Drawing.Size(128, 23);
            this.switchChirp.SwitchShape = DaekhonSystem.SwitchShape.Square;
            this.switchChirp.TabIndex = 1362;
            this.switchChirp.Text = "Negative Chirp";
            this.switchChirp.Click += new System.EventHandler(this.switchChirp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(113, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 1361;
            this.label3.Text = "fs";
            // 
            // edPulseduration
            // 
            this.edPulseduration.BackColor = System.Drawing.Color.White;
            this.edPulseduration.Cursor = System.Windows.Forms.Cursors.Default;
            this.edPulseduration.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPulseduration.Frame.Bottom = false;
            this.edPulseduration.Frame.CornerRound = 1;
            this.edPulseduration.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPulseduration.Frame.Top = false;
            this.edPulseduration.Hint = null;
            this.edPulseduration.Location = new System.Drawing.Point(13, 82);
            this.edPulseduration.Margin = new System.Windows.Forms.Padding(4);
            this.edPulseduration.Max = 0D;
            this.edPulseduration.Min = 0D;
            this.edPulseduration.MinimumSize = new System.Drawing.Size(1, 1);
            this.edPulseduration.Name = "edPulseduration";
            this.edPulseduration.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edPulseduration.PrecisionDigits = 3;
            this.edPulseduration.ShowHint = false;
            this.edPulseduration.Size = new System.Drawing.Size(95, 29);
            this.edPulseduration.TabIndex = 1359;
            this.edPulseduration.Text = "0";
            // 
            // btnPulseduration
            // 
            this.btnPulseduration.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPulseduration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPulseduration.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnPulseduration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPulseduration.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPulseduration.ForeColor = System.Drawing.Color.Black;
            this.btnPulseduration.Location = new System.Drawing.Point(142, 81);
            this.btnPulseduration.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPulseduration.Name = "btnPulseduration";
            this.btnPulseduration.Size = new System.Drawing.Size(77, 30);
            this.btnPulseduration.TabIndex = 1360;
            this.btnPulseduration.Text = "Set";
            this.btnPulseduration.UseVisualStyleBackColor = false;
            this.btnPulseduration.Click += new System.EventHandler(this.btnPulseduration_Click);
            // 
            // lbCurrentPulseDuration
            // 
            this.lbCurrentPulseDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbCurrentPulseDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentPulseDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCurrentPulseDuration.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbCurrentPulseDuration.ForeColor = System.Drawing.Color.Black;
            this.lbCurrentPulseDuration.Location = new System.Drawing.Point(13, 22);
            this.lbCurrentPulseDuration.Name = "lbCurrentPulseDuration";
            this.lbCurrentPulseDuration.Size = new System.Drawing.Size(227, 26);
            this.lbCurrentPulseDuration.TabIndex = 1331;
            this.lbCurrentPulseDuration.Text = "Pulse duration 0.0 fs";
            this.lbCurrentPulseDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShutterClose);
            this.groupBox2.Controls.Add(this.btnShutterOpen);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(107, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 104);
            this.groupBox2.TabIndex = 1345;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Inner-Shutter  ";
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
            this.btnShutterClose.Size = new System.Drawing.Size(89, 46);
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
            this.groupBox1.Location = new System.Drawing.Point(107, 145);
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
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
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
            this.btnConnect.LED.Value = true;
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
            this.cbLaserSet.ItemIndex = 1;
            this.cbLaserSet.Location = new System.Drawing.Point(375, 531);
            this.cbLaserSet.Margin = new System.Windows.Forms.Padding(4);
            this.cbLaserSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbLaserSet.Name = "cbLaserSet";
            this.cbLaserSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbLaserSet.ShowHint = false;
            this.cbLaserSet.Size = new System.Drawing.Size(395, 27);
            this.cbLaserSet.TabIndex = 1331;
            // 
            // lblCurLaserParam
            // 
            this.lblCurLaserParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCurLaserParam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurLaserParam.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCurLaserParam.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCurLaserParam.ForeColor = System.Drawing.Color.Black;
            this.lblCurLaserParam.Location = new System.Drawing.Point(479, 501);
            this.lblCurLaserParam.Name = "lblCurLaserParam";
            this.lblCurLaserParam.Size = new System.Drawing.Size(292, 26);
            this.lblCurLaserParam.TabIndex = 1330;
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
            this.gradLabel57.Location = new System.Drawing.Point(375, 501);
            this.gradLabel57.Name = "gradLabel57";
            this.gradLabel57.Size = new System.Drawing.Size(99, 26);
            this.gradLabel57.TabIndex = 1329;
            this.gradLabel57.Text = "Current";
            this.gradLabel57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogClear
            // 
            this.btnLogClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLogClear.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnLogClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLogClear.ForeColor = System.Drawing.Color.Black;
            this.btnLogClear.Location = new System.Drawing.Point(691, 753);
            this.btnLogClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(77, 30);
            this.btnLogClear.TabIndex = 1313;
            this.btnLogClear.Text = "Clear";
            this.btnLogClear.UseVisualStyleBackColor = false;
            this.btnLogClear.Visible = false;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // ListBoxStatus
            // 
            this.ListBoxStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListBoxStatus.Font = new System.Drawing.Font("굴림", 9F);
            this.ListBoxStatus.Location = new System.Drawing.Point(375, 631);
            this.ListBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.ListBoxStatus.Name = "ListBoxStatus";
            this.ListBoxStatus.Padding = new System.Windows.Forms.Padding(2);
            this.ListBoxStatus.Size = new System.Drawing.Size(392, 118);
            this.ListBoxStatus.TabIndex = 1311;
            this.ListBoxStatus.Text = "uiListBox3";
            this.ListBoxStatus.Visible = false;
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
            this.uiLine26.Location = new System.Drawing.Point(375, 603);
            this.uiLine26.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine26.Name = "uiLine26";
            this.uiLine26.ShowHint = false;
            this.uiLine26.Size = new System.Drawing.Size(393, 17);
            this.uiLine26.StartCap = DaekhonSystem.UILineCap.None;
            this.uiLine26.TabIndex = 1312;
            this.uiLine26.Text = "Status Log";
            this.uiLine26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLine26.TextInterval = 4;
            this.uiLine26.Visible = false;
            // 
            // edAttenuator
            // 
            this.edAttenuator.BackColor = System.Drawing.Color.White;
            this.edAttenuator.Cursor = System.Windows.Forms.Cursors.Default;
            this.edAttenuator.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edAttenuator.Frame.Bottom = false;
            this.edAttenuator.Frame.CornerRound = 1;
            this.edAttenuator.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edAttenuator.Frame.Top = false;
            this.edAttenuator.Hint = null;
            this.edAttenuator.Location = new System.Drawing.Point(594, 230);
            this.edAttenuator.Margin = new System.Windows.Forms.Padding(4);
            this.edAttenuator.Max = 0D;
            this.edAttenuator.Min = 0D;
            this.edAttenuator.MinimumSize = new System.Drawing.Size(1, 1);
            this.edAttenuator.Name = "edAttenuator";
            this.edAttenuator.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edAttenuator.PrecisionDigits = 3;
            this.edAttenuator.ShowHint = false;
            this.edAttenuator.Size = new System.Drawing.Size(95, 29);
            this.edAttenuator.TabIndex = 1305;
            this.edAttenuator.Text = "0";
            // 
            // btnSetAttenuator
            // 
            this.btnSetAttenuator.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetAttenuator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetAttenuator.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSetAttenuator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetAttenuator.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSetAttenuator.ForeColor = System.Drawing.Color.Black;
            this.btnSetAttenuator.Location = new System.Drawing.Point(692, 229);
            this.btnSetAttenuator.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetAttenuator.Name = "btnSetAttenuator";
            this.btnSetAttenuator.Size = new System.Drawing.Size(77, 30);
            this.btnSetAttenuator.TabIndex = 1307;
            this.btnSetAttenuator.Text = "Set";
            this.btnSetAttenuator.UseVisualStyleBackColor = false;
            this.btnSetAttenuator.Click += new System.EventHandler(this.btnSetAttenuator_Click);
            // 
            // Attenuotor
            // 
            this.Attenuotor.BackColor = System.Drawing.Color.Transparent;
            this.Attenuotor.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.Attenuotor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Attenuotor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Attenuotor.Frame.Visible = false;
            this.Attenuotor.GradientEnable = false;
            this.Attenuotor.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.Attenuotor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Attenuotor.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.Attenuotor.Location = new System.Drawing.Point(377, 231);
            this.Attenuotor.Name = "Attenuotor";
            this.Attenuotor.Size = new System.Drawing.Size(99, 26);
            this.Attenuotor.TabIndex = 1299;
            this.Attenuotor.Text = "Attenuator";
            this.Attenuotor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel15
            // 
            this.gradLabel15.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel15.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gradLabel15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel15.Frame.Visible = false;
            this.gradLabel15.GradientEnable = false;
            this.gradLabel15.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel15.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel15.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel15.Location = new System.Drawing.Point(377, 175);
            this.gradLabel15.Name = "gradLabel15";
            this.gradLabel15.Size = new System.Drawing.Size(99, 26);
            this.gradLabel15.TabIndex = 1300;
            this.gradLabel15.Text = "Power";
            this.gradLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.gradLabel16.Location = new System.Drawing.Point(594, 175);
            this.gradLabel16.Name = "gradLabel16";
            this.gradLabel16.Size = new System.Drawing.Size(95, 26);
            this.gradLabel16.TabIndex = 1301;
            this.gradLabel16.Text = "Freq";
            this.gradLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viFrequency
            // 
            this.viFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viFrequency.Cursor = System.Windows.Forms.Cursors.Default;
            this.viFrequency.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viFrequency.ForeColor = System.Drawing.Color.Black;
            this.viFrequency.FormatString = "{0:F1}";
            this.viFrequency.Location = new System.Drawing.Point(692, 175);
            this.viFrequency.Name = "viFrequency";
            this.viFrequency.Size = new System.Drawing.Size(74, 26);
            this.viFrequency.TabIndex = 1302;
            this.viFrequency.Text = "0";
            this.viFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viPower
            // 
            this.viPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viPower.Cursor = System.Windows.Forms.Cursors.Default;
            this.viPower.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viPower.ForeColor = System.Drawing.Color.Black;
            this.viPower.FormatString = "{0:F3}";
            this.viPower.Location = new System.Drawing.Point(480, 175);
            this.viPower.Name = "viPower";
            this.viPower.Size = new System.Drawing.Size(81, 26);
            this.viPower.TabIndex = 1303;
            this.viPower.Text = "0";
            this.viPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.label36.Font = new System.Drawing.Font("굴림", 9F);
            this.label36.Location = new System.Drawing.Point(767, 187);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(26, 12);
            this.label36.TabIndex = 1297;
            this.label36.Text = "kHz";
            // 
            // viAttenuator
            // 
            this.viAttenuator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAttenuator.Cursor = System.Windows.Forms.Cursors.Default;
            this.viAttenuator.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAttenuator.ForeColor = System.Drawing.Color.Black;
            this.viAttenuator.FormatString = "{0:F1}";
            this.viAttenuator.Location = new System.Drawing.Point(480, 231);
            this.viAttenuator.Name = "viAttenuator";
            this.viAttenuator.Size = new System.Drawing.Size(81, 26);
            this.viAttenuator.TabIndex = 1304;
            this.viAttenuator.Text = "0";
            this.viAttenuator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Cursor = System.Windows.Forms.Cursors.Default;
            this.label50.Font = new System.Drawing.Font("굴림", 9F);
            this.label50.Location = new System.Drawing.Point(568, 187);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(15, 12);
            this.label50.TabIndex = 1298;
            this.label50.Text = "W";
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
            this.uiLine25.Location = new System.Drawing.Point(375, 145);
            this.uiLine25.MinimumSize = new System.Drawing.Size(16, 14);
            this.uiLine25.Name = "uiLine25";
            this.uiLine25.ShowHint = false;
            this.uiLine25.Size = new System.Drawing.Size(415, 17);
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
            this.uiLine23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uiLine23.ForeColor = System.Drawing.Color.Black;
            this.uiLine23.Frame.Visible = false;
            this.uiLine23.Hint = null;
            this.uiLine23.LineCapSize = 4;
            this.uiLine23.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLine23.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.uiLine23.LineWidth = 1F;
            this.uiLine23.Location = new System.Drawing.Point(375, 475);
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
            // panManualCarbide
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Name = "panManualCarbide";
            this.Size = new System.Drawing.Size(940, 849);
            this.panClient.ResumeLayout(false);
            this.panClient.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataServer dsLaser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private sjPanel panClient;
        private ComboBox cbLaserSet;
        private System.Windows.Forms.Label lblCurLaserParam;
        private GradientLabel gradLabel57;
        private BitBtn btnLogClear;
        private DaekhonSystem.ListBox ListBoxStatus;
        private SunnyLine uiLine26;
        private NumberEdit edAttenuator;
        private BitBtn btnSetAttenuator;
        private GradientLabel Attenuotor;
        private GradientLabel gradLabel15;
        private GradientLabel gradLabel16;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label50;
        private SunnyLine uiLine25;
        private SunnyLine uiLine23;
        private System.Windows.Forms.Label label1;
        private BitBtn btnApply;
        private BitBtn btnStandBy;
        private NumberEdit edPPDivider;
        private BitBtn btnPPDivider;
        private GradientLabel gradientLabel1;
        private NumberEdit edBurstControlN;
        private BitBtn btnBurstControlN;
        private GradientLabel gradientLabel2;
        private System.Windows.Forms.Label lbCurrentPulseDuration;
        private System.Windows.Forms.Label label3;
        private NumberEdit edPulseduration;
        private BitBtn btnPulseduration;
        private System.Windows.Forms.GroupBox groupBox4;
        private NumberEdit edTargetTemp;
        private BitBtn btnChillerTempSet;
        private System.Windows.Forms.Label lbChillerStatus;
        private System.Windows.Forms.Label label4;
        private DaekhonSystem.Label lblLaserStatus;
        private DaekhonSystem.Label lblShutterStatus;
        private DaekhonSystem.Label lblEmissionStatus;
        private System.Windows.Forms.Timer tmr_LaserStatus;

        private ValueIndicator viFrequency;
        private ValueIndicator viPower;
        private ValueIndicator viBurstControlN;
        private ValueIndicator viAttenuator;
        private ValueIndicator viPPDivider;
        private LEDButton btnChillerOff;
        private LEDButton btnchillerOn;
        private Thread ReadThread;
        private SunnySwitch switchChirp;
        private System.Windows.Forms.GroupBox groupBox5;
        private LEDButton btnExternalHigh;
        private LEDButton btnExternalLow;
        private LEDButton btnInternal;
        private NumberEdit edBurstEnvelopeControlN;
        private BitBtn btnBurstEnvelopeControlN;
        private GradientLabel gradientLabel7;
        private ValueIndicator viBurstEnvelopeControlN;
        public LEDButton btnShutterClose;
        public LEDButton btnShutterOpen;
        private NumberEdit edBurstEnvelopeControlP;
        private BitBtn btnBurstEnvelopeControlP;
        private GradientLabel gradientLabel3;
        private ValueIndicator viBurstEnvelopeControlP;
        private NumberEdit edBurstControlP;
        private BitBtn btnBurstControlP;
        private GradientLabel gradientLabel4;
        private ValueIndicator viBurstControlP;
        public LEDButton btnDisconnect;
        public LEDButton btnConnect;
    }
}
