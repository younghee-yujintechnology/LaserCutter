namespace LaserCutter
{
    partial class panAuto
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.TabControl1 = new YujinTechnology.TabControl();
            this.tabTable1 = new System.Windows.Forms.TabPage();
            this.tabTable2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AutoThread = new YujinTechnology.Thread();
            this.ledLabel5 = new YujinTechnology.LEDLabel();
            this.ledLabel6 = new YujinTechnology.LEDLabel();
            this.errorProcessor1 = new YujinTechnology.ErrorProcessor();
            this.ledLabel7 = new YujinTechnology.LEDLabel();
            this.ledLabel4 = new YujinTechnology.LEDLabel();
            this.ledLabel3 = new YujinTechnology.LEDLabel();
            this.BlinkThread = new YujinTechnology.Thread();
            this.panRight = new LaserCutter.sjPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ledShowStep = new YujinTechnology.LEDLabel();
            this.lblShutterStatus = new YujinTechnology.Label();
            this.lblEmissionStatus = new YujinTechnology.Label();
            this.lblLaserStatus = new YujinTechnology.Label();
            this.LabelLaserStatus = new YujinTechnology.Label();
            this.LabelLaserSet = new YujinTechnology.Label();
            this.lblLaserSet = new YujinTechnology.Label();
            this.ledMVS = new YujinTechnology.LEDLabel();
            this.ledLight = new YujinTechnology.LEDLabel();
            this.ledTable2JobFileLoad = new YujinTechnology.LEDLabel();
            this.lblLabelTable2JobFile = new YujinTechnology.Label();
            this.lblLabelTable1JobFile = new YujinTechnology.Label();
            this.btnClear = new YujinTechnology.LEDButton();
            this.viTable2CycleTime = new YujinTechnology.ValueIndicator();
            this.viTable1CycleTime = new YujinTechnology.ValueIndicator();
            this.lblLabelCycleTime = new YujinTechnology.Label();
            this.viTable2InputCount = new YujinTechnology.ValueIndicator();
            this.viTable1InputCount = new YujinTechnology.ValueIndicator();
            this.lblLabelInputCount = new YujinTechnology.Label();
            this.ledTable2AreaSensor = new YujinTechnology.LEDLabel();
            this.ledTable1AreaSensor = new YujinTechnology.LEDLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ledTable2MakeCell = new YujinTechnology.LEDLabel();
            this.ledTable2DXFArray = new YujinTechnology.LEDLabel();
            this.ledTable2DXF = new YujinTechnology.LEDLabel();
            this.ledTable1MakeCell = new YujinTechnology.LEDLabel();
            this.ledTable1DXFArray = new YujinTechnology.LEDLabel();
            this.ledTable1DXF = new YujinTechnology.LEDLabel();
            this.viZVelocity = new YujinTechnology.ValueIndicator();
            this.viXVelocity = new YujinTechnology.ValueIndicator();
            this.viXPosition = new YujinTechnology.ValueIndicator();
            this.viY1Position = new YujinTechnology.ValueIndicator();
            this.viY2Position = new YujinTechnology.ValueIndicator();
            this.viZPosition = new YujinTechnology.ValueIndicator();
            this.viY1Velocity = new YujinTechnology.ValueIndicator();
            this.viY2Velocity = new YujinTechnology.ValueIndicator();
            this.gradLabel26 = new YujinTechnology.GradientLabel();
            this.gradLabel24 = new YujinTechnology.GradientLabel();
            this.gradLabel19 = new YujinTechnology.GradientLabel();
            this.gradLabel21 = new YujinTechnology.GradientLabel();
            this.gradLabel28 = new YujinTechnology.GradientLabel();
            this.gradLabel17 = new YujinTechnology.GradientLabel();
            this.gradLabel29 = new YujinTechnology.GradientLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTable2New = new YujinTechnology.LEDButton();
            this.btnLaserRun = new YujinTechnology.LEDButton();
            this.btnDryRun = new YujinTechnology.LEDButton();
            this.ledButton2 = new YujinTechnology.LEDButton();
            this.btnReset = new YujinTechnology.LEDButton();
            this.btnTable1New = new YujinTechnology.LEDButton();
            this.ledRunStatus = new YujinTechnology.LEDLabel();
            this.ledTable1JobFileLoad = new YujinTechnology.LEDLabel();
            this.ledVision = new YujinTechnology.LEDLabel();
            this.ledLaser = new YujinTechnology.LEDLabel();
            this.ledADV = new YujinTechnology.LEDLabel();
            this.ledMotion = new YujinTechnology.LEDLabel();
            this.ledCoord1ProgRunning = new YujinTechnology.LEDLabel();
            this.lblPageCount = new YujinTechnology.GradientLabel();
            this.lblPageIndex = new YujinTechnology.GradientLabel();
            this.ledButton1 = new YujinTechnology.LEDButton();
            this.btnAutoReady = new YujinTechnology.LEDButton();
            this.btnStop = new YujinTechnology.LEDButton();
            this.btnStart = new YujinTechnology.LEDButton();
            this.panRunStatus = new System.Windows.Forms.Panel();
            this.lblMachineNo = new YujinTechnology.Label();
            this.ledTable1Error = new YujinTechnology.LEDLabel();
            this.lblTable2ErrorStep = new YujinTechnology.GradientLabel();
            this.ledTable1CycleStop = new YujinTechnology.LEDLabel();
            this.lblTable1ErrorStep = new YujinTechnology.GradientLabel();
            this.ledTable2CycleStop = new YujinTechnology.LEDLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ledTable1Stop = new YujinTechnology.LEDLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ledTable2Stop = new YujinTechnology.LEDLabel();
            this.lblTable2Step = new YujinTechnology.GradientLabel();
            this.lblTable1Step = new YujinTechnology.GradientLabel();
            this.ledTable2Error = new YujinTechnology.LEDLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TabControl1.SuspendLayout();
            this.panRight.SuspendLayout();
            this.panRunStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabTable1);
            this.TabControl1.Controls.Add(this.tabTable2);
            this.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.TabControl1.ImageList = this.imageList1;
            this.TabControl1.Location = new System.Drawing.Point(3, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl1.ShowActiveCloseButton = false;
            this.TabControl1.ShowCloseButton = false;
            this.TabControl1.Size = new System.Drawing.Size(1253, 844);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TabControl1.TabIndex = 1339;
            this.TabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.TabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.TabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.TabControl1.TabSelectedHighColorSize = 4;
            this.TabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.TabControl1.TabVisible = true;
            this.TabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TabControl1.TipsColor = System.Drawing.Color.Red;
            this.TabControl1.TipsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.TipsForeColor = System.Drawing.Color.White;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.uiTabControl1_SelectedIndexChanged);
            this.TabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1_Selecting);
            // 
            // tabTable1
            // 
            this.tabTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabTable1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabTable1.Location = new System.Drawing.Point(4, 34);
            this.tabTable1.Name = "tabTable1";
            this.tabTable1.Size = new System.Drawing.Size(1245, 806);
            this.tabTable1.TabIndex = 0;
            this.tabTable1.Text = "Tabel #1";
            // 
            // tabTable2
            // 
            this.tabTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabTable2.Location = new System.Drawing.Point(4, 34);
            this.tabTable2.Name = "tabTable2";
            this.tabTable2.Size = new System.Drawing.Size(1245, 806);
            this.tabTable2.TabIndex = 1;
            this.tabTable2.Text = "Tabel #2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = true;
            this.AutoThread.Interval = 50;
            this.AutoThread.OnExecute += new System.EventHandler(this.Thread_OnExecute);
            // 
            // ledLabel5
            // 
            this.ledLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLabel5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledLabel5.Frame.Visible = false;
            this.ledLabel5.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLabel5.LED.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ledLabel5.LED.Size = new System.Drawing.Size(28, 100);
            this.ledLabel5.Location = new System.Drawing.Point(13, 478);
            this.ledLabel5.Name = "ledLabel5";
            this.ledLabel5.ShowAccelChar = false;
            this.ledLabel5.Size = new System.Drawing.Size(29, 107);
            this.ledLabel5.TabIndex = 1451;
            this.ledLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledLabel6
            // 
            this.ledLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLabel6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledLabel6.Frame.Visible = false;
            this.ledLabel6.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLabel6.LED.OffColor = System.Drawing.SystemColors.Control;
            this.ledLabel6.LED.Size = new System.Drawing.Size(12, 220);
            this.ledLabel6.Location = new System.Drawing.Point(20, 587);
            this.ledLabel6.Name = "ledLabel6";
            this.ledLabel6.ShowAccelChar = false;
            this.ledLabel6.Size = new System.Drawing.Size(14, 225);
            this.ledLabel6.TabIndex = 1452;
            this.ledLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProcessor1
            // 
            this.errorProcessor1.ErrorFile = null;
            this.errorProcessor1.Monitor = false;
            this.errorProcessor1.MonitorInterval = 500;
            this.errorProcessor1.OnAlarmOccured += new System.Action<object, string>(this.errorProcessor1_OnAlarmOccured);
            this.errorProcessor1.OnAlarmReleased += new System.Action<object, string>(this.errorProcessor1_OnAlarmReleased);
            this.errorProcessor1.OnErrorOccured += new System.Action<object, string>(this.errorProcessor1_OnErrorOccured);
            this.errorProcessor1.OnErrorReleased += new System.Action<object, string>(this.errorProcessor1_OnErrorReleased);
            // 
            // ledLabel7
            // 
            this.ledLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLabel7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledLabel7.Frame.Visible = false;
            this.ledLabel7.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLabel7.LED.OffColor = System.Drawing.Color.Silver;
            this.ledLabel7.LED.OnColor = System.Drawing.SystemColors.Control;
            this.ledLabel7.LED.Size = new System.Drawing.Size(28, 20);
            this.ledLabel7.LED.Value = true;
            this.ledLabel7.Location = new System.Drawing.Point(13, 813);
            this.ledLabel7.Name = "ledLabel7";
            this.ledLabel7.ShowAccelChar = false;
            this.ledLabel7.Size = new System.Drawing.Size(29, 24);
            this.ledLabel7.TabIndex = 1454;
            this.ledLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledLabel4
            // 
            this.ledLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLabel4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledLabel4.Frame.Visible = false;
            this.ledLabel4.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLabel4.LED.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ledLabel4.LED.OnColor = System.Drawing.Color.Red;
            this.ledLabel4.LED.Size = new System.Drawing.Size(28, 100);
            this.ledLabel4.Location = new System.Drawing.Point(13, 269);
            this.ledLabel4.Name = "ledLabel4";
            this.ledLabel4.ShowAccelChar = false;
            this.ledLabel4.Size = new System.Drawing.Size(29, 107);
            this.ledLabel4.TabIndex = 1456;
            this.ledLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledLabel3
            // 
            this.ledLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledLabel3.Frame.Visible = false;
            this.ledLabel3.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLabel3.LED.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ledLabel3.LED.OnColor = System.Drawing.Color.Yellow;
            this.ledLabel3.LED.Size = new System.Drawing.Size(28, 100);
            this.ledLabel3.Location = new System.Drawing.Point(13, 375);
            this.ledLabel3.Name = "ledLabel3";
            this.ledLabel3.ShowAccelChar = false;
            this.ledLabel3.Size = new System.Drawing.Size(29, 102);
            this.ledLabel3.TabIndex = 1455;
            this.ledLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlinkThread
            // 
            this.BlinkThread.Enabled = false;
            this.BlinkThread.Interval = 250;
            this.BlinkThread.OnExecute += new System.EventHandler(this.BlinkThread_OnExecute);
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panRight.Controls.Add(this.button2);
            this.panRight.Controls.Add(this.button1);
            this.panRight.Controls.Add(this.ledShowStep);
            this.panRight.Controls.Add(this.lblShutterStatus);
            this.panRight.Controls.Add(this.lblEmissionStatus);
            this.panRight.Controls.Add(this.lblLaserStatus);
            this.panRight.Controls.Add(this.LabelLaserStatus);
            this.panRight.Controls.Add(this.LabelLaserSet);
            this.panRight.Controls.Add(this.lblLaserSet);
            this.panRight.Controls.Add(this.ledMVS);
            this.panRight.Controls.Add(this.ledLight);
            this.panRight.Controls.Add(this.ledTable2JobFileLoad);
            this.panRight.Controls.Add(this.lblLabelTable2JobFile);
            this.panRight.Controls.Add(this.lblLabelTable1JobFile);
            this.panRight.Controls.Add(this.btnClear);
            this.panRight.Controls.Add(this.viTable2CycleTime);
            this.panRight.Controls.Add(this.viTable1CycleTime);
            this.panRight.Controls.Add(this.lblLabelCycleTime);
            this.panRight.Controls.Add(this.viTable2InputCount);
            this.panRight.Controls.Add(this.viTable1InputCount);
            this.panRight.Controls.Add(this.lblLabelInputCount);
            this.panRight.Controls.Add(this.ledTable2AreaSensor);
            this.panRight.Controls.Add(this.ledTable1AreaSensor);
            this.panRight.Controls.Add(this.label6);
            this.panRight.Controls.Add(this.label5);
            this.panRight.Controls.Add(this.ledTable2MakeCell);
            this.panRight.Controls.Add(this.ledTable2DXFArray);
            this.panRight.Controls.Add(this.ledTable2DXF);
            this.panRight.Controls.Add(this.ledTable1MakeCell);
            this.panRight.Controls.Add(this.ledTable1DXFArray);
            this.panRight.Controls.Add(this.ledTable1DXF);
            this.panRight.Controls.Add(this.viZVelocity);
            this.panRight.Controls.Add(this.viXVelocity);
            this.panRight.Controls.Add(this.viXPosition);
            this.panRight.Controls.Add(this.viY1Position);
            this.panRight.Controls.Add(this.viY2Position);
            this.panRight.Controls.Add(this.viZPosition);
            this.panRight.Controls.Add(this.viY1Velocity);
            this.panRight.Controls.Add(this.viY2Velocity);
            this.panRight.Controls.Add(this.gradLabel26);
            this.panRight.Controls.Add(this.gradLabel24);
            this.panRight.Controls.Add(this.gradLabel19);
            this.panRight.Controls.Add(this.gradLabel21);
            this.panRight.Controls.Add(this.gradLabel28);
            this.panRight.Controls.Add(this.gradLabel17);
            this.panRight.Controls.Add(this.gradLabel29);
            this.panRight.Controls.Add(this.label4);
            this.panRight.Controls.Add(this.label3);
            this.panRight.Controls.Add(this.btnTable2New);
            this.panRight.Controls.Add(this.btnLaserRun);
            this.panRight.Controls.Add(this.btnDryRun);
            this.panRight.Controls.Add(this.ledButton2);
            this.panRight.Controls.Add(this.btnReset);
            this.panRight.Controls.Add(this.btnTable1New);
            this.panRight.Controls.Add(this.ledRunStatus);
            this.panRight.Controls.Add(this.ledTable1JobFileLoad);
            this.panRight.Controls.Add(this.ledVision);
            this.panRight.Controls.Add(this.ledLaser);
            this.panRight.Controls.Add(this.ledADV);
            this.panRight.Controls.Add(this.ledMotion);
            this.panRight.Controls.Add(this.ledCoord1ProgRunning);
            this.panRight.Controls.Add(this.lblPageCount);
            this.panRight.Controls.Add(this.lblPageIndex);
            this.panRight.Controls.Add(this.ledButton1);
            this.panRight.Controls.Add(this.btnAutoReady);
            this.panRight.Controls.Add(this.btnStop);
            this.panRight.Controls.Add(this.btnStart);
            this.panRight.Controls.Add(this.panRunStatus);
            this.panRight.Controls.Add(this.listView1);
            this.panRight.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panRight.Location = new System.Drawing.Point(1260, 3);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(650, 844);
            this.panRight.TabIndex = 1340;
            this.panRight.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panRight.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panRight.TitleText = "Status";
            this.panRight.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 33);
            this.button2.TabIndex = 1649;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 1648;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ledShowStep
            // 
            this.ledShowStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledShowStep.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledShowStep.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledShowStep.ForeColor = System.Drawing.Color.Black;
            this.ledShowStep.Frame.Visible = false;
            this.ledShowStep.LED.OffColor = System.Drawing.Color.Gray;
            this.ledShowStep.LED.Size = new System.Drawing.Size(12, 12);
            this.ledShowStep.LED.Value = true;
            this.ledShowStep.Location = new System.Drawing.Point(317, 252);
            this.ledShowStep.Name = "ledShowStep";
            this.ledShowStep.ShowAccelChar = false;
            this.ledShowStep.Size = new System.Drawing.Size(107, 21);
            this.ledShowStep.TabIndex = 1647;
            this.ledShowStep.Text = "ShowStep";
            this.ledShowStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledShowStep.DoubleClick += new System.EventHandler(this.ledShowStep_DoubleClick);
            // 
            // lblShutterStatus
            // 
            this.lblShutterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblShutterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblShutterStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblShutterStatus.ForeColor = System.Drawing.Color.Black;
            this.lblShutterStatus.Location = new System.Drawing.Point(445, 200);
            this.lblShutterStatus.Name = "lblShutterStatus";
            this.lblShutterStatus.ShowAccelChar = false;
            this.lblShutterStatus.Size = new System.Drawing.Size(160, 50);
            this.lblShutterStatus.TabIndex = 1645;
            this.lblShutterStatus.Text = "Main Output is closed";
            this.lblShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmissionStatus
            // 
            this.lblEmissionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmissionStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmissionStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEmissionStatus.ForeColor = System.Drawing.Color.Black;
            this.lblEmissionStatus.Location = new System.Drawing.Point(445, 166);
            this.lblEmissionStatus.Name = "lblEmissionStatus";
            this.lblEmissionStatus.ShowAccelChar = false;
            this.lblEmissionStatus.Size = new System.Drawing.Size(160, 30);
            this.lblEmissionStatus.TabIndex = 1644;
            this.lblEmissionStatus.Text = "No emission";
            this.lblEmissionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserStatus
            // 
            this.lblLaserStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLaserStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLaserStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLaserStatus.ForeColor = System.Drawing.Color.Black;
            this.lblLaserStatus.Location = new System.Drawing.Point(164, 166);
            this.lblLaserStatus.Name = "lblLaserStatus";
            this.lblLaserStatus.ShowAccelChar = false;
            this.lblLaserStatus.Size = new System.Drawing.Size(277, 30);
            this.lblLaserStatus.TabIndex = 1643;
            this.lblLaserStatus.Text = "Standing by";
            this.lblLaserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLaserStatus
            // 
            this.LabelLaserStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LabelLaserStatus.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelLaserStatus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.LabelLaserStatus.Frame.Visible = false;
            this.LabelLaserStatus.Location = new System.Drawing.Point(47, 170);
            this.LabelLaserStatus.Name = "LabelLaserStatus";
            this.LabelLaserStatus.ShowAccelChar = false;
            this.LabelLaserStatus.Size = new System.Drawing.Size(115, 21);
            this.LabelLaserStatus.TabIndex = 1642;
            this.LabelLaserStatus.Text = "LaserStatus:";
            this.LabelLaserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelLaserSet
            // 
            this.LabelLaserSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LabelLaserSet.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelLaserSet.Font = new System.Drawing.Font("Tahoma", 11F);
            this.LabelLaserSet.Frame.Visible = false;
            this.LabelLaserSet.Location = new System.Drawing.Point(47, 214);
            this.LabelLaserSet.Name = "LabelLaserSet";
            this.LabelLaserSet.ShowAccelChar = false;
            this.LabelLaserSet.Size = new System.Drawing.Size(112, 21);
            this.LabelLaserSet.TabIndex = 1640;
            this.LabelLaserSet.Text = "LaserSet:";
            this.LabelLaserSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLaserSet
            // 
            this.lblLaserSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lblLaserSet.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblLaserSet.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblLaserSet.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblLaserSet.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblLaserSet.ForeColor = System.Drawing.Color.Red;
            this.lblLaserSet.Frame.Left = false;
            this.lblLaserSet.Frame.Right = false;
            this.lblLaserSet.Frame.Top = false;
            this.lblLaserSet.Location = new System.Drawing.Point(167, 199);
            this.lblLaserSet.Name = "lblLaserSet";
            this.lblLaserSet.ShowAccelChar = false;
            this.lblLaserSet.Size = new System.Drawing.Size(273, 51);
            this.lblLaserSet.TabIndex = 1639;
            this.lblLaserSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledMVS
            // 
            this.ledMVS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledMVS.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledMVS.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledMVS.Frame.Visible = false;
            this.ledMVS.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledMVS.LED.OffColor = System.Drawing.Color.Red;
            this.ledMVS.LED.Size = new System.Drawing.Size(54, 20);
            this.ledMVS.LED.Value = true;
            this.ledMVS.Location = new System.Drawing.Point(464, 8);
            this.ledMVS.Name = "ledMVS";
            this.ledMVS.ShowAccelChar = false;
            this.ledMVS.Size = new System.Drawing.Size(58, 23);
            this.ledMVS.TabIndex = 1638;
            this.ledMVS.Text = "MVS";
            this.ledMVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledLight
            // 
            this.ledLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLight.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLight.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledLight.Frame.Visible = false;
            this.ledLight.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLight.LED.OffColor = System.Drawing.Color.Red;
            this.ledLight.LED.Size = new System.Drawing.Size(54, 20);
            this.ledLight.LED.Value = true;
            this.ledLight.Location = new System.Drawing.Point(585, 8);
            this.ledLight.Name = "ledLight";
            this.ledLight.ShowAccelChar = false;
            this.ledLight.Size = new System.Drawing.Size(58, 23);
            this.ledLight.TabIndex = 1637;
            this.ledLight.Text = "Light";
            this.ledLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTable2JobFileLoad
            // 
            this.ledTable2JobFileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2JobFileLoad.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2JobFileLoad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2JobFileLoad.Frame.Visible = false;
            this.ledTable2JobFileLoad.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledTable2JobFileLoad.LED.OffColor = System.Drawing.Color.Red;
            this.ledTable2JobFileLoad.LED.Size = new System.Drawing.Size(110, 24);
            this.ledTable2JobFileLoad.Location = new System.Drawing.Point(442, 440);
            this.ledTable2JobFileLoad.Name = "ledTable2JobFileLoad";
            this.ledTable2JobFileLoad.ShowAccelChar = false;
            this.ledTable2JobFileLoad.Size = new System.Drawing.Size(111, 26);
            this.ledTable2JobFileLoad.TabIndex = 1636;
            this.ledTable2JobFileLoad.Text = "Load Error";
            this.ledTable2JobFileLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledTable2JobFileLoad.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2JobFileLoad_LEDValueChanged);
            // 
            // lblLabelTable2JobFile
            // 
            this.lblLabelTable2JobFile.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelTable2JobFile.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblLabelTable2JobFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabelTable2JobFile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLabelTable2JobFile.Frame.Visible = false;
            this.lblLabelTable2JobFile.Location = new System.Drawing.Point(332, 438);
            this.lblLabelTable2JobFile.Name = "lblLabelTable2JobFile";
            this.lblLabelTable2JobFile.ShowAccelChar = false;
            this.lblLabelTable2JobFile.Size = new System.Drawing.Size(104, 30);
            this.lblLabelTable2JobFile.TabIndex = 1635;
            this.lblLabelTable2JobFile.Text = "Table2.JobFile";
            this.lblLabelTable2JobFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabelTable1JobFile
            // 
            this.lblLabelTable1JobFile.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelTable1JobFile.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblLabelTable1JobFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabelTable1JobFile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLabelTable1JobFile.Frame.Visible = false;
            this.lblLabelTable1JobFile.Location = new System.Drawing.Point(22, 438);
            this.lblLabelTable1JobFile.Name = "lblLabelTable1JobFile";
            this.lblLabelTable1JobFile.ShowAccelChar = false;
            this.lblLabelTable1JobFile.Size = new System.Drawing.Size(104, 30);
            this.lblLabelTable1JobFile.TabIndex = 1634;
            this.lblLabelTable1JobFile.Text = "Table1.JobFile";
            this.lblLabelTable1JobFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.btnClear.LED.Size = new System.Drawing.Size(80, 32);
            this.btnClear.LED.Visible = false;
            this.btnClear.Location = new System.Drawing.Point(432, 562);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 67);
            this.btnClear.TabIndex = 1633;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCompatibleTextRendering = true;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // viTable2CycleTime
            // 
            this.viTable2CycleTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viTable2CycleTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viTable2CycleTime.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viTable2CycleTime.ForeColor = System.Drawing.Color.Black;
            this.viTable2CycleTime.FormatString = "0.000";
            this.viTable2CycleTime.Frame.Bottom = false;
            this.viTable2CycleTime.Frame.CornerRound = 1;
            this.viTable2CycleTime.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viTable2CycleTime.Frame.Top = false;
            this.viTable2CycleTime.Location = new System.Drawing.Point(329, 600);
            this.viTable2CycleTime.Margin = new System.Windows.Forms.Padding(4);
            this.viTable2CycleTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.viTable2CycleTime.Name = "viTable2CycleTime";
            this.viTable2CycleTime.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viTable2CycleTime.ShowAccelChar = false;
            this.viTable2CycleTime.Size = new System.Drawing.Size(95, 29);
            this.viTable2CycleTime.TabIndex = 1632;
            this.viTable2CycleTime.Text = "0";
            this.viTable2CycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viTable1CycleTime
            // 
            this.viTable1CycleTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viTable1CycleTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viTable1CycleTime.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viTable1CycleTime.FormatString = "0.000";
            this.viTable1CycleTime.Frame.Bottom = false;
            this.viTable1CycleTime.Frame.CornerRound = 1;
            this.viTable1CycleTime.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viTable1CycleTime.Frame.Top = false;
            this.viTable1CycleTime.Location = new System.Drawing.Point(224, 600);
            this.viTable1CycleTime.Margin = new System.Windows.Forms.Padding(4);
            this.viTable1CycleTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.viTable1CycleTime.Name = "viTable1CycleTime";
            this.viTable1CycleTime.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viTable1CycleTime.ShowAccelChar = false;
            this.viTable1CycleTime.Size = new System.Drawing.Size(95, 29);
            this.viTable1CycleTime.TabIndex = 1631;
            this.viTable1CycleTime.Text = "0";
            this.viTable1CycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelCycleTime
            // 
            this.lblLabelCycleTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelCycleTime.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblLabelCycleTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabelCycleTime.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLabelCycleTime.Frame.Visible = false;
            this.lblLabelCycleTime.Location = new System.Drawing.Point(113, 599);
            this.lblLabelCycleTime.Name = "lblLabelCycleTime";
            this.lblLabelCycleTime.ShowAccelChar = false;
            this.lblLabelCycleTime.Size = new System.Drawing.Size(104, 30);
            this.lblLabelCycleTime.TabIndex = 1630;
            this.lblLabelCycleTime.Text = "Cycle Time";
            this.lblLabelCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viTable2InputCount
            // 
            this.viTable2InputCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viTable2InputCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viTable2InputCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viTable2InputCount.FormatString = "0";
            this.viTable2InputCount.Frame.Bottom = false;
            this.viTable2InputCount.Frame.CornerRound = 1;
            this.viTable2InputCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viTable2InputCount.Frame.Top = false;
            this.viTable2InputCount.Location = new System.Drawing.Point(329, 562);
            this.viTable2InputCount.Margin = new System.Windows.Forms.Padding(4);
            this.viTable2InputCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.viTable2InputCount.Name = "viTable2InputCount";
            this.viTable2InputCount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viTable2InputCount.ShowAccelChar = false;
            this.viTable2InputCount.Size = new System.Drawing.Size(95, 29);
            this.viTable2InputCount.TabIndex = 1629;
            this.viTable2InputCount.Text = "0";
            this.viTable2InputCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viTable1InputCount
            // 
            this.viTable1InputCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viTable1InputCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viTable1InputCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viTable1InputCount.FormatString = "0";
            this.viTable1InputCount.Frame.Bottom = false;
            this.viTable1InputCount.Frame.CornerRound = 1;
            this.viTable1InputCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viTable1InputCount.Frame.Top = false;
            this.viTable1InputCount.Location = new System.Drawing.Point(224, 562);
            this.viTable1InputCount.Margin = new System.Windows.Forms.Padding(4);
            this.viTable1InputCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.viTable1InputCount.Name = "viTable1InputCount";
            this.viTable1InputCount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viTable1InputCount.ShowAccelChar = false;
            this.viTable1InputCount.Size = new System.Drawing.Size(95, 29);
            this.viTable1InputCount.TabIndex = 1628;
            this.viTable1InputCount.Text = "0";
            this.viTable1InputCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelInputCount
            // 
            this.lblLabelInputCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelInputCount.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblLabelInputCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLabelInputCount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLabelInputCount.Frame.Visible = false;
            this.lblLabelInputCount.Location = new System.Drawing.Point(113, 561);
            this.lblLabelInputCount.Name = "lblLabelInputCount";
            this.lblLabelInputCount.ShowAccelChar = false;
            this.lblLabelInputCount.Size = new System.Drawing.Size(102, 30);
            this.lblLabelInputCount.TabIndex = 1519;
            this.lblLabelInputCount.Text = "투입";
            this.lblLabelInputCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledTable2AreaSensor
            // 
            this.ledTable2AreaSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2AreaSensor.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2AreaSensor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2AreaSensor.ForeColor = System.Drawing.Color.Black;
            this.ledTable2AreaSensor.Frame.Visible = false;
            this.ledTable2AreaSensor.LED.OffColor = System.Drawing.Color.Red;
            this.ledTable2AreaSensor.LED.Shape = YujinTechnology.LEDShape.Circle;
            this.ledTable2AreaSensor.LED.Size = new System.Drawing.Size(16, 16);
            this.ledTable2AreaSensor.Location = new System.Drawing.Point(349, 498);
            this.ledTable2AreaSensor.Name = "ledTable2AreaSensor";
            this.ledTable2AreaSensor.ShowAccelChar = false;
            this.ledTable2AreaSensor.Size = new System.Drawing.Size(104, 28);
            this.ledTable2AreaSensor.TabIndex = 1513;
            this.ledTable2AreaSensor.Text = "AreaSensor";
            this.ledTable2AreaSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledTable2AreaSensor.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2AreaSensor_LEDValueChanged);
            // 
            // ledTable1AreaSensor
            // 
            this.ledTable1AreaSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1AreaSensor.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1AreaSensor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1AreaSensor.ForeColor = System.Drawing.Color.Black;
            this.ledTable1AreaSensor.Frame.Visible = false;
            this.ledTable1AreaSensor.LED.OffColor = System.Drawing.Color.Red;
            this.ledTable1AreaSensor.LED.Shape = YujinTechnology.LEDShape.Circle;
            this.ledTable1AreaSensor.LED.Size = new System.Drawing.Size(16, 16);
            this.ledTable1AreaSensor.Location = new System.Drawing.Point(38, 498);
            this.ledTable1AreaSensor.Name = "ledTable1AreaSensor";
            this.ledTable1AreaSensor.ShowAccelChar = false;
            this.ledTable1AreaSensor.Size = new System.Drawing.Size(104, 28);
            this.ledTable1AreaSensor.TabIndex = 1512;
            this.ledTable1AreaSensor.Text = "AreaSensor";
            this.ledTable1AreaSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledTable1AreaSensor.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1AreaSensor_LEDValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 1511;
            this.label6.Text = "Table2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1510;
            this.label5.Text = "Table1";
            // 
            // ledTable2MakeCell
            // 
            this.ledTable2MakeCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2MakeCell.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2MakeCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2MakeCell.ForeColor = System.Drawing.Color.Black;
            this.ledTable2MakeCell.Frame.Visible = false;
            this.ledTable2MakeCell.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable2MakeCell.LED.OnColor = System.Drawing.Color.Yellow;
            this.ledTable2MakeCell.LED.Size = new System.Drawing.Size(16, 20);
            this.ledTable2MakeCell.Location = new System.Drawing.Point(539, 466);
            this.ledTable2MakeCell.Name = "ledTable2MakeCell";
            this.ledTable2MakeCell.ShowAccelChar = false;
            this.ledTable2MakeCell.Size = new System.Drawing.Size(91, 28);
            this.ledTable2MakeCell.TabIndex = 1509;
            this.ledTable2MakeCell.Text = "MakeCell";
            this.ledTable2MakeCell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTable2DXFArray
            // 
            this.ledTable2DXFArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2DXFArray.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2DXFArray.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2DXFArray.ForeColor = System.Drawing.Color.Black;
            this.ledTable2DXFArray.Frame.Visible = false;
            this.ledTable2DXFArray.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable2DXFArray.LED.OnColor = System.Drawing.Color.Yellow;
            this.ledTable2DXFArray.LED.Size = new System.Drawing.Size(16, 20);
            this.ledTable2DXFArray.Location = new System.Drawing.Point(443, 466);
            this.ledTable2DXFArray.Name = "ledTable2DXFArray";
            this.ledTable2DXFArray.ShowAccelChar = false;
            this.ledTable2DXFArray.Size = new System.Drawing.Size(91, 28);
            this.ledTable2DXFArray.TabIndex = 1508;
            this.ledTable2DXFArray.Text = "DXF Array";
            this.ledTable2DXFArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTable2DXF
            // 
            this.ledTable2DXF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2DXF.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2DXF.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2DXF.ForeColor = System.Drawing.Color.Black;
            this.ledTable2DXF.Frame.Visible = false;
            this.ledTable2DXF.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable2DXF.LED.OnColor = System.Drawing.Color.Yellow;
            this.ledTable2DXF.LED.Size = new System.Drawing.Size(16, 20);
            this.ledTable2DXF.Location = new System.Drawing.Point(349, 466);
            this.ledTable2DXF.Name = "ledTable2DXF";
            this.ledTable2DXF.ShowAccelChar = false;
            this.ledTable2DXF.Size = new System.Drawing.Size(91, 28);
            this.ledTable2DXF.TabIndex = 1507;
            this.ledTable2DXF.Text = "DXF";
            this.ledTable2DXF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTable1MakeCell
            // 
            this.ledTable1MakeCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1MakeCell.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1MakeCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1MakeCell.ForeColor = System.Drawing.Color.Black;
            this.ledTable1MakeCell.Frame.Visible = false;
            this.ledTable1MakeCell.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable1MakeCell.LED.Size = new System.Drawing.Size(16, 20);
            this.ledTable1MakeCell.Location = new System.Drawing.Point(228, 466);
            this.ledTable1MakeCell.Name = "ledTable1MakeCell";
            this.ledTable1MakeCell.ShowAccelChar = false;
            this.ledTable1MakeCell.Size = new System.Drawing.Size(91, 28);
            this.ledTable1MakeCell.TabIndex = 1506;
            this.ledTable1MakeCell.Text = "MakeCell";
            this.ledTable1MakeCell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTable1DXFArray
            // 
            this.ledTable1DXFArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1DXFArray.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1DXFArray.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1DXFArray.ForeColor = System.Drawing.Color.Black;
            this.ledTable1DXFArray.Frame.Visible = false;
            this.ledTable1DXFArray.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable1DXFArray.LED.Size = new System.Drawing.Size(16, 20);
            this.ledTable1DXFArray.Location = new System.Drawing.Point(132, 466);
            this.ledTable1DXFArray.Name = "ledTable1DXFArray";
            this.ledTable1DXFArray.ShowAccelChar = false;
            this.ledTable1DXFArray.Size = new System.Drawing.Size(91, 28);
            this.ledTable1DXFArray.TabIndex = 1505;
            this.ledTable1DXFArray.Text = "DXF Array";
            this.ledTable1DXFArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTable1DXF
            // 
            this.ledTable1DXF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1DXF.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1DXF.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1DXF.ForeColor = System.Drawing.Color.Black;
            this.ledTable1DXF.Frame.Visible = false;
            this.ledTable1DXF.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable1DXF.LED.Size = new System.Drawing.Size(16, 20);
            this.ledTable1DXF.Location = new System.Drawing.Point(38, 466);
            this.ledTable1DXF.Name = "ledTable1DXF";
            this.ledTable1DXF.ShowAccelChar = false;
            this.ledTable1DXF.Size = new System.Drawing.Size(91, 28);
            this.ledTable1DXF.TabIndex = 1504;
            this.ledTable1DXF.Text = "DXF";
            this.ledTable1DXF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viZVelocity
            // 
            this.viZVelocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viZVelocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viZVelocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viZVelocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viZVelocity.ForeColor = System.Drawing.Color.Black;
            this.viZVelocity.FormatString = "{0:F3}";
            this.viZVelocity.Location = new System.Drawing.Point(497, 93);
            this.viZVelocity.Name = "viZVelocity";
            this.viZVelocity.ShowAccelChar = false;
            this.viZVelocity.Size = new System.Drawing.Size(108, 30);
            this.viZVelocity.TabIndex = 1496;
            this.viZVelocity.Text = "0";
            this.viZVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viXVelocity
            // 
            this.viXVelocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viXVelocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viXVelocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viXVelocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viXVelocity.ForeColor = System.Drawing.Color.Black;
            this.viXVelocity.FormatString = "{0:F3}";
            this.viXVelocity.Location = new System.Drawing.Point(164, 93);
            this.viXVelocity.Name = "viXVelocity";
            this.viXVelocity.ShowAccelChar = false;
            this.viXVelocity.Size = new System.Drawing.Size(108, 30);
            this.viXVelocity.TabIndex = 1497;
            this.viXVelocity.Text = "0";
            this.viXVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viXPosition
            // 
            this.viXPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viXPosition.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viXPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.viXPosition.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viXPosition.ForeColor = System.Drawing.Color.Black;
            this.viXPosition.FormatString = "{0:F3}";
            this.viXPosition.Location = new System.Drawing.Point(164, 126);
            this.viXPosition.Name = "viXPosition";
            this.viXPosition.ShowAccelChar = false;
            this.viXPosition.Size = new System.Drawing.Size(108, 30);
            this.viXPosition.TabIndex = 1498;
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
            this.viY1Position.Location = new System.Drawing.Point(275, 126);
            this.viY1Position.Name = "viY1Position";
            this.viY1Position.ShowAccelChar = false;
            this.viY1Position.Size = new System.Drawing.Size(108, 30);
            this.viY1Position.TabIndex = 1499;
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
            this.viY2Position.Location = new System.Drawing.Point(386, 126);
            this.viY2Position.Name = "viY2Position";
            this.viY2Position.ShowAccelChar = false;
            this.viY2Position.Size = new System.Drawing.Size(108, 30);
            this.viY2Position.TabIndex = 1500;
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
            this.viZPosition.Location = new System.Drawing.Point(497, 126);
            this.viZPosition.Name = "viZPosition";
            this.viZPosition.ShowAccelChar = false;
            this.viZPosition.Size = new System.Drawing.Size(108, 30);
            this.viZPosition.TabIndex = 1501;
            this.viZPosition.Text = "0";
            this.viZPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viY1Velocity
            // 
            this.viY1Velocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viY1Velocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viY1Velocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viY1Velocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viY1Velocity.ForeColor = System.Drawing.Color.Black;
            this.viY1Velocity.FormatString = "{0:F3}";
            this.viY1Velocity.Location = new System.Drawing.Point(275, 93);
            this.viY1Velocity.Name = "viY1Velocity";
            this.viY1Velocity.ShowAccelChar = false;
            this.viY1Velocity.Size = new System.Drawing.Size(108, 30);
            this.viY1Velocity.TabIndex = 1502;
            this.viY1Velocity.Text = "0";
            this.viY1Velocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viY2Velocity
            // 
            this.viY2Velocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viY2Velocity.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viY2Velocity.Cursor = System.Windows.Forms.Cursors.Default;
            this.viY2Velocity.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viY2Velocity.ForeColor = System.Drawing.Color.Black;
            this.viY2Velocity.FormatString = "{0:F3}";
            this.viY2Velocity.Location = new System.Drawing.Point(386, 93);
            this.viY2Velocity.Name = "viY2Velocity";
            this.viY2Velocity.ShowAccelChar = false;
            this.viY2Velocity.Size = new System.Drawing.Size(108, 30);
            this.viY2Velocity.TabIndex = 1503;
            this.viY2Velocity.Text = "0";
            this.viY2Velocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel26
            // 
            this.gradLabel26.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel26.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel26.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel26.GradientEnable = false;
            this.gradLabel26.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel26.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel26.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel26.Location = new System.Drawing.Point(57, 93);
            this.gradLabel26.Name = "gradLabel26";
            this.gradLabel26.ShowAccelChar = false;
            this.gradLabel26.Size = new System.Drawing.Size(104, 30);
            this.gradLabel26.TabIndex = 1484;
            this.gradLabel26.Text = "Velocity";
            this.gradLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel24
            // 
            this.gradLabel24.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel24.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel24.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel24.GradientEnable = false;
            this.gradLabel24.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel24.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel24.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel24.Location = new System.Drawing.Point(164, 60);
            this.gradLabel24.Name = "gradLabel24";
            this.gradLabel24.ShowAccelChar = false;
            this.gradLabel24.Size = new System.Drawing.Size(108, 30);
            this.gradLabel24.TabIndex = 1483;
            this.gradLabel24.Text = "X";
            this.gradLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel19
            // 
            this.gradLabel19.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel19.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel19.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel19.GradientEnable = false;
            this.gradLabel19.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel19.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel19.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel19.Location = new System.Drawing.Point(275, 60);
            this.gradLabel19.Name = "gradLabel19";
            this.gradLabel19.ShowAccelChar = false;
            this.gradLabel19.Size = new System.Drawing.Size(108, 30);
            this.gradLabel19.TabIndex = 1482;
            this.gradLabel19.Text = "Y1";
            this.gradLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel21
            // 
            this.gradLabel21.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel21.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel21.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel21.Font = new System.Drawing.Font("굴림", 9F);
            this.gradLabel21.GradientEnable = false;
            this.gradLabel21.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel21.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel21.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel21.Location = new System.Drawing.Point(57, 60);
            this.gradLabel21.Name = "gradLabel21";
            this.gradLabel21.ShowAccelChar = false;
            this.gradLabel21.Size = new System.Drawing.Size(104, 30);
            this.gradLabel21.TabIndex = 1479;
            this.gradLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel28
            // 
            this.gradLabel28.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel28.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel28.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel28.GradientEnable = false;
            this.gradLabel28.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel28.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel28.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel28.Location = new System.Drawing.Point(386, 60);
            this.gradLabel28.Name = "gradLabel28";
            this.gradLabel28.ShowAccelChar = false;
            this.gradLabel28.Size = new System.Drawing.Size(108, 30);
            this.gradLabel28.TabIndex = 1480;
            this.gradLabel28.Text = "Y2";
            this.gradLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel17
            // 
            this.gradLabel17.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel17.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel17.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel17.GradientEnable = false;
            this.gradLabel17.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel17.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel17.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel17.Location = new System.Drawing.Point(57, 126);
            this.gradLabel17.Name = "gradLabel17";
            this.gradLabel17.ShowAccelChar = false;
            this.gradLabel17.Size = new System.Drawing.Size(104, 30);
            this.gradLabel17.TabIndex = 1485;
            this.gradLabel17.Text = "Position";
            this.gradLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradLabel29
            // 
            this.gradLabel29.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel29.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel29.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradLabel29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel29.GradientEnable = false;
            this.gradLabel29.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel29.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel29.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel29.Location = new System.Drawing.Point(497, 60);
            this.gradLabel29.Name = "gradLabel29";
            this.gradLabel29.ShowAccelChar = false;
            this.gradLabel29.Size = new System.Drawing.Size(108, 30);
            this.gradLabel29.TabIndex = 1481;
            this.gradLabel29.Text = "Z";
            this.gradLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 1477;
            this.label4.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 1476;
            this.label3.Text = "가공";
            // 
            // btnTable2New
            // 
            this.btnTable2New.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnTable2New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnTable2New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable2New.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTable2New.ForeColor = System.Drawing.Color.Black;
            this.btnTable2New.LED.OnColor = System.Drawing.Color.Yellow;
            this.btnTable2New.LED.Size = new System.Drawing.Size(20, 32);
            this.btnTable2New.LED.Value = true;
            this.btnTable2New.Location = new System.Drawing.Point(506, 683);
            this.btnTable2New.Margin2 = 10;
            this.btnTable2New.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTable2New.Name = "btnTable2New";
            this.btnTable2New.Size = new System.Drawing.Size(107, 62);
            this.btnTable2New.TabIndex = 1469;
            this.btnTable2New.Text = "New";
            this.btnTable2New.UseVisualStyleBackColor = false;
            this.btnTable2New.Click += new System.EventHandler(this.btnTable2New_Click);
            // 
            // btnLaserRun
            // 
            this.btnLaserRun.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLaserRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLaserRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaserRun.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLaserRun.ForeColor = System.Drawing.Color.Black;
            this.btnLaserRun.LED.Size = new System.Drawing.Size(20, 32);
            this.btnLaserRun.Location = new System.Drawing.Point(216, 683);
            this.btnLaserRun.Margin2 = 10;
            this.btnLaserRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLaserRun.Name = "btnLaserRun";
            this.btnLaserRun.Size = new System.Drawing.Size(107, 62);
            this.btnLaserRun.TabIndex = 1468;
            this.btnLaserRun.Text = "with Laser";
            this.btnLaserRun.UseVisualStyleBackColor = false;
            this.btnLaserRun.Click += new System.EventHandler(this.btnLaserRun_Click);
            // 
            // btnDryRun
            // 
            this.btnDryRun.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnDryRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDryRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDryRun.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDryRun.ForeColor = System.Drawing.Color.Black;
            this.btnDryRun.LED.Size = new System.Drawing.Size(20, 32);
            this.btnDryRun.LED.Value = true;
            this.btnDryRun.Location = new System.Drawing.Point(329, 683);
            this.btnDryRun.Margin2 = 10;
            this.btnDryRun.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDryRun.Name = "btnDryRun";
            this.btnDryRun.Size = new System.Drawing.Size(107, 62);
            this.btnDryRun.TabIndex = 1467;
            this.btnDryRun.Text = "DryRun";
            this.btnDryRun.UseVisualStyleBackColor = false;
            this.btnDryRun.Click += new System.EventHandler(this.btnDryRun_Click);
            // 
            // ledButton2
            // 
            this.ledButton2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.ledButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledButton2.Enabled = false;
            this.ledButton2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledButton2.ForeColor = System.Drawing.Color.Black;
            this.ledButton2.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledButton2.LED.Size = new System.Drawing.Size(80, 32);
            this.ledButton2.LED.Visible = false;
            this.ledButton2.Location = new System.Drawing.Point(442, 751);
            this.ledButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledButton2.Name = "ledButton2";
            this.ledButton2.Size = new System.Drawing.Size(58, 62);
            this.ledButton2.TabIndex = 1466;
            this.ledButton2.UseCompatibleTextRendering = true;
            this.ledButton2.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.btnReset.LED.OffColor = System.Drawing.Color.Lime;
            this.btnReset.LED.OnColor = System.Drawing.Color.Red;
            this.btnReset.LED.Size = new System.Drawing.Size(80, 32);
            this.btnReset.Location = new System.Drawing.Point(506, 751);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 62);
            this.btnReset.TabIndex = 1465;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTable1New
            // 
            this.btnTable1New.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnTable1New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnTable1New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable1New.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTable1New.ForeColor = System.Drawing.Color.Black;
            this.btnTable1New.LED.OnColor = System.Drawing.Color.Yellow;
            this.btnTable1New.LED.Size = new System.Drawing.Size(20, 32);
            this.btnTable1New.LED.Value = true;
            this.btnTable1New.Location = new System.Drawing.Point(39, 683);
            this.btnTable1New.Margin2 = 10;
            this.btnTable1New.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTable1New.Name = "btnTable1New";
            this.btnTable1New.Size = new System.Drawing.Size(107, 62);
            this.btnTable1New.TabIndex = 1463;
            this.btnTable1New.Text = "New";
            this.btnTable1New.UseVisualStyleBackColor = false;
            this.btnTable1New.Click += new System.EventHandler(this.btnTable1New_Click);
            // 
            // ledRunStatus
            // 
            this.ledRunStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledRunStatus.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledRunStatus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledRunStatus.ForeColor = System.Drawing.Color.Black;
            this.ledRunStatus.Frame.Visible = false;
            this.ledRunStatus.LED.OffColor = System.Drawing.Color.Gray;
            this.ledRunStatus.LED.OnColor = System.Drawing.Color.Gray;
            this.ledRunStatus.LED.Shape = YujinTechnology.LEDShape.Triangle;
            this.ledRunStatus.LED.Size = new System.Drawing.Size(12, 12);
            this.ledRunStatus.Location = new System.Drawing.Point(7, 250);
            this.ledRunStatus.Name = "ledRunStatus";
            this.ledRunStatus.ShowAccelChar = false;
            this.ledRunStatus.ShowChannelName = true;
            this.ledRunStatus.Size = new System.Drawing.Size(107, 21);
            this.ledRunStatus.TabIndex = 1459;
            this.ledRunStatus.Text = "Run.Status";
            this.ledRunStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledRunStatus.DoubleClick += new System.EventHandler(this.ledRunStatus_DoubleClick);
            // 
            // ledTable1JobFileLoad
            // 
            this.ledTable1JobFileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1JobFileLoad.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1JobFileLoad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1JobFileLoad.Frame.Visible = false;
            this.ledTable1JobFileLoad.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledTable1JobFileLoad.LED.OffColor = System.Drawing.Color.Red;
            this.ledTable1JobFileLoad.LED.Size = new System.Drawing.Size(110, 24);
            this.ledTable1JobFileLoad.Location = new System.Drawing.Point(132, 440);
            this.ledTable1JobFileLoad.Name = "ledTable1JobFileLoad";
            this.ledTable1JobFileLoad.ShowAccelChar = false;
            this.ledTable1JobFileLoad.Size = new System.Drawing.Size(111, 26);
            this.ledTable1JobFileLoad.TabIndex = 1455;
            this.ledTable1JobFileLoad.Text = "Load Error";
            this.ledTable1JobFileLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledTable1JobFileLoad.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1JobFileLoad_LEDValueChanged);
            // 
            // ledVision
            // 
            this.ledVision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledVision.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledVision.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledVision.Frame.Visible = false;
            this.ledVision.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledVision.LED.OffColor = System.Drawing.Color.Red;
            this.ledVision.LED.Size = new System.Drawing.Size(54, 20);
            this.ledVision.LED.Value = true;
            this.ledVision.Location = new System.Drawing.Point(401, 8);
            this.ledVision.Name = "ledVision";
            this.ledVision.ShowAccelChar = false;
            this.ledVision.Size = new System.Drawing.Size(58, 23);
            this.ledVision.TabIndex = 1450;
            this.ledVision.Text = "Vision";
            this.ledVision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledLaser
            // 
            this.ledLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledLaser.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledLaser.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledLaser.Frame.Visible = false;
            this.ledLaser.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledLaser.LED.OffColor = System.Drawing.Color.Red;
            this.ledLaser.LED.Size = new System.Drawing.Size(54, 20);
            this.ledLaser.LED.Value = true;
            this.ledLaser.Location = new System.Drawing.Point(339, 8);
            this.ledLaser.Name = "ledLaser";
            this.ledLaser.ShowAccelChar = false;
            this.ledLaser.Size = new System.Drawing.Size(58, 23);
            this.ledLaser.TabIndex = 1447;
            this.ledLaser.Text = "Laser";
            this.ledLaser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledADV
            // 
            this.ledADV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledADV.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledADV.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledADV.Frame.Visible = false;
            this.ledADV.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledADV.LED.OffColor = System.Drawing.Color.Red;
            this.ledADV.LED.Size = new System.Drawing.Size(54, 20);
            this.ledADV.LED.Value = true;
            this.ledADV.Location = new System.Drawing.Point(525, 8);
            this.ledADV.Name = "ledADV";
            this.ledADV.ShowAccelChar = false;
            this.ledADV.Size = new System.Drawing.Size(58, 23);
            this.ledADV.TabIndex = 1449;
            this.ledADV.Text = "ADV";
            this.ledADV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledMotion
            // 
            this.ledMotion.BackColor = System.Drawing.Color.Transparent;
            this.ledMotion.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledMotion.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledMotion.Frame.Visible = false;
            this.ledMotion.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledMotion.LED.OffColor = System.Drawing.Color.Red;
            this.ledMotion.LED.Size = new System.Drawing.Size(54, 20);
            this.ledMotion.LED.Value = true;
            this.ledMotion.Location = new System.Drawing.Point(276, 8);
            this.ledMotion.Name = "ledMotion";
            this.ledMotion.ShowAccelChar = false;
            this.ledMotion.Size = new System.Drawing.Size(58, 23);
            this.ledMotion.TabIndex = 1448;
            this.ledMotion.Text = "Motion";
            this.ledMotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledCoord1ProgRunning
            // 
            this.ledCoord1ProgRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledCoord1ProgRunning.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledCoord1ProgRunning.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledCoord1ProgRunning.ForeColor = System.Drawing.Color.Black;
            this.ledCoord1ProgRunning.Frame.Visible = false;
            this.ledCoord1ProgRunning.LED.OffColor = System.Drawing.Color.Gray;
            this.ledCoord1ProgRunning.LED.Shape = YujinTechnology.LEDShape.Circle;
            this.ledCoord1ProgRunning.LED.Size = new System.Drawing.Size(12, 12);
            this.ledCoord1ProgRunning.Location = new System.Drawing.Point(132, 250);
            this.ledCoord1ProgRunning.Name = "ledCoord1ProgRunning";
            this.ledCoord1ProgRunning.ShowAccelChar = false;
            this.ledCoord1ProgRunning.Size = new System.Drawing.Size(166, 21);
            this.ledCoord1ProgRunning.TabIndex = 1451;
            this.ledCoord1ProgRunning.Text = "Coord[1].ProgRunning";
            this.ledCoord1ProgRunning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPageCount
            // 
            this.lblPageCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPageCount.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblPageCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPageCount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPageCount.Frame.Left = false;
            this.lblPageCount.Frame.Right = false;
            this.lblPageCount.Frame.Top = false;
            this.lblPageCount.GradientEnable = false;
            this.lblPageCount.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblPageCount.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblPageCount.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblPageCount.Location = new System.Drawing.Point(568, 252);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.ShowAccelChar = false;
            this.lblPageCount.Size = new System.Drawing.Size(48, 21);
            this.lblPageCount.TabIndex = 1444;
            this.lblPageCount.Text = "1";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPageIndex
            // 
            this.lblPageIndex.BackColor = System.Drawing.Color.Transparent;
            this.lblPageIndex.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblPageIndex.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPageIndex.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPageIndex.Frame.Left = false;
            this.lblPageIndex.Frame.Right = false;
            this.lblPageIndex.Frame.Top = false;
            this.lblPageIndex.GradientEnable = false;
            this.lblPageIndex.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblPageIndex.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblPageIndex.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblPageIndex.Location = new System.Drawing.Point(511, 252);
            this.lblPageIndex.Name = "lblPageIndex";
            this.lblPageIndex.ShowAccelChar = false;
            this.lblPageIndex.Size = new System.Drawing.Size(48, 21);
            this.lblPageIndex.TabIndex = 1443;
            this.lblPageIndex.Text = "0";
            this.lblPageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledButton1
            // 
            this.ledButton1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.ledButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ledButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledButton1.Enabled = false;
            this.ledButton1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ledButton1.ForeColor = System.Drawing.Color.Black;
            this.ledButton1.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledButton1.LED.Size = new System.Drawing.Size(80, 32);
            this.ledButton1.LED.Visible = false;
            this.ledButton1.Location = new System.Drawing.Point(152, 751);
            this.ledButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledButton1.Name = "ledButton1";
            this.ledButton1.Size = new System.Drawing.Size(58, 62);
            this.ledButton1.TabIndex = 1435;
            this.ledButton1.UseCompatibleTextRendering = true;
            this.ledButton1.UseVisualStyleBackColor = false;
            // 
            // btnAutoReady
            // 
            this.btnAutoReady.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAutoReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAutoReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoReady.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAutoReady.ForeColor = System.Drawing.Color.Black;
            this.btnAutoReady.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.btnAutoReady.LED.OnColor = System.Drawing.Color.Yellow;
            this.btnAutoReady.LED.Size = new System.Drawing.Size(80, 32);
            this.btnAutoReady.Location = new System.Drawing.Point(39, 751);
            this.btnAutoReady.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAutoReady.Name = "btnAutoReady";
            this.btnAutoReady.Size = new System.Drawing.Size(107, 62);
            this.btnAutoReady.TabIndex = 1433;
            this.btnAutoReady.Text = "Ready";
            this.btnAutoReady.UseVisualStyleBackColor = false;
            this.btnAutoReady.Click += new System.EventHandler(this.btnAutoReady_Click);
            // 
            // btnStop
            // 
            this.btnStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.btnStop.LED.Size = new System.Drawing.Size(80, 32);
            this.btnStop.Location = new System.Drawing.Point(329, 751);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 62);
            this.btnStop.TabIndex = 1407;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.btnStart.LED.Size = new System.Drawing.Size(80, 32);
            this.btnStart.Location = new System.Drawing.Point(216, 751);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 62);
            this.btnStart.TabIndex = 1301;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panRunStatus
            // 
            this.panRunStatus.Controls.Add(this.lblMachineNo);
            this.panRunStatus.Controls.Add(this.ledTable1Error);
            this.panRunStatus.Controls.Add(this.lblTable2ErrorStep);
            this.panRunStatus.Controls.Add(this.ledTable1CycleStop);
            this.panRunStatus.Controls.Add(this.lblTable1ErrorStep);
            this.panRunStatus.Controls.Add(this.ledTable2CycleStop);
            this.panRunStatus.Controls.Add(this.label2);
            this.panRunStatus.Controls.Add(this.ledTable1Stop);
            this.panRunStatus.Controls.Add(this.label1);
            this.panRunStatus.Controls.Add(this.ledTable2Stop);
            this.panRunStatus.Controls.Add(this.lblTable2Step);
            this.panRunStatus.Controls.Add(this.lblTable1Step);
            this.panRunStatus.Controls.Add(this.ledTable2Error);
            this.panRunStatus.Location = new System.Drawing.Point(16, 286);
            this.panRunStatus.Name = "panRunStatus";
            this.panRunStatus.Size = new System.Drawing.Size(616, 125);
            this.panRunStatus.TabIndex = 1478;
            this.panRunStatus.Visible = false;
            // 
            // lblMachineNo
            // 
            this.lblMachineNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMachineNo.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblMachineNo.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblMachineNo.CaptionStyle.ShadowDepth = 4;
            this.lblMachineNo.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblMachineNo.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblMachineNo.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.lblMachineNo.ForeColor = System.Drawing.Color.Orange;
            this.lblMachineNo.Frame.Visible = false;
            this.lblMachineNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMachineNo.Location = new System.Drawing.Point(361, 17);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.ShowAccelChar = false;
            this.lblMachineNo.Size = new System.Drawing.Size(239, 82);
            this.lblMachineNo.TabIndex = 1634;
            this.lblMachineNo.Text = "No: 01";
            this.lblMachineNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTable1Error
            // 
            this.ledTable1Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1Error.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1Error.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1Error.Frame.Visible = false;
            this.ledTable1Error.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable1Error.LED.OnColor = System.Drawing.Color.Red;
            this.ledTable1Error.LED.Size = new System.Drawing.Size(12, 12);
            this.ledTable1Error.Location = new System.Drawing.Point(20, 99);
            this.ledTable1Error.Name = "ledTable1Error";
            this.ledTable1Error.ShowAccelChar = false;
            this.ledTable1Error.Size = new System.Drawing.Size(106, 21);
            this.ledTable1Error.TabIndex = 1445;
            this.ledTable1Error.Text = "Table1.Error=";
            this.ledTable1Error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTable2ErrorStep
            // 
            this.lblTable2ErrorStep.BackColor = System.Drawing.Color.Transparent;
            this.lblTable2ErrorStep.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblTable2ErrorStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTable2ErrorStep.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTable2ErrorStep.Frame.Left = false;
            this.lblTable2ErrorStep.Frame.Right = false;
            this.lblTable2ErrorStep.Frame.Top = false;
            this.lblTable2ErrorStep.GradientEnable = false;
            this.lblTable2ErrorStep.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTable2ErrorStep.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTable2ErrorStep.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblTable2ErrorStep.Location = new System.Drawing.Point(313, 99);
            this.lblTable2ErrorStep.Name = "lblTable2ErrorStep";
            this.lblTable2ErrorStep.ShowAccelChar = false;
            this.lblTable2ErrorStep.Size = new System.Drawing.Size(57, 21);
            this.lblTable2ErrorStep.TabIndex = 1475;
            this.lblTable2ErrorStep.Text = "0";
            this.lblTable2ErrorStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTable1CycleStop
            // 
            this.ledTable1CycleStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1CycleStop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1CycleStop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1CycleStop.ForeColor = System.Drawing.Color.Gray;
            this.ledTable1CycleStop.Frame.Visible = false;
            this.ledTable1CycleStop.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable1CycleStop.LED.OnColor = System.Drawing.Color.Red;
            this.ledTable1CycleStop.LED.Size = new System.Drawing.Size(12, 12);
            this.ledTable1CycleStop.Location = new System.Drawing.Point(20, 29);
            this.ledTable1CycleStop.Name = "ledTable1CycleStop";
            this.ledTable1CycleStop.ShowAccelChar = false;
            this.ledTable1CycleStop.Size = new System.Drawing.Size(131, 21);
            this.ledTable1CycleStop.TabIndex = 1438;
            this.ledTable1CycleStop.Text = "Table1.CycleStop";
            this.ledTable1CycleStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable1CycleStop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1CycleStop_LEDValueChanged);
            // 
            // lblTable1ErrorStep
            // 
            this.lblTable1ErrorStep.BackColor = System.Drawing.Color.Transparent;
            this.lblTable1ErrorStep.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblTable1ErrorStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTable1ErrorStep.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTable1ErrorStep.Frame.Left = false;
            this.lblTable1ErrorStep.Frame.Right = false;
            this.lblTable1ErrorStep.Frame.Top = false;
            this.lblTable1ErrorStep.GradientEnable = false;
            this.lblTable1ErrorStep.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTable1ErrorStep.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTable1ErrorStep.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblTable1ErrorStep.Location = new System.Drawing.Point(125, 99);
            this.lblTable1ErrorStep.Name = "lblTable1ErrorStep";
            this.lblTable1ErrorStep.ShowAccelChar = false;
            this.lblTable1ErrorStep.Size = new System.Drawing.Size(57, 21);
            this.lblTable1ErrorStep.TabIndex = 1474;
            this.lblTable1ErrorStep.Text = "0";
            this.lblTable1ErrorStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTable2CycleStop
            // 
            this.ledTable2CycleStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2CycleStop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2CycleStop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2CycleStop.ForeColor = System.Drawing.Color.Gray;
            this.ledTable2CycleStop.Frame.Visible = false;
            this.ledTable2CycleStop.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable2CycleStop.LED.OnColor = System.Drawing.Color.Red;
            this.ledTable2CycleStop.LED.Size = new System.Drawing.Size(12, 12);
            this.ledTable2CycleStop.Location = new System.Drawing.Point(209, 29);
            this.ledTable2CycleStop.Name = "ledTable2CycleStop";
            this.ledTable2CycleStop.ShowAccelChar = false;
            this.ledTable2CycleStop.Size = new System.Drawing.Size(146, 21);
            this.ledTable2CycleStop.TabIndex = 1439;
            this.ledTable2CycleStop.Text = "Table2.CycleStop";
            this.ledTable2CycleStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable2CycleStop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2CycleStop_LEDValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(224, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1473;
            this.label2.Text = "Table2.Step=";
            // 
            // ledTable1Stop
            // 
            this.ledTable1Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable1Stop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable1Stop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable1Stop.Frame.Visible = false;
            this.ledTable1Stop.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable1Stop.LED.OnColor = System.Drawing.Color.Red;
            this.ledTable1Stop.LED.Size = new System.Drawing.Size(12, 12);
            this.ledTable1Stop.Location = new System.Drawing.Point(20, 52);
            this.ledTable1Stop.Name = "ledTable1Stop";
            this.ledTable1Stop.ShowAccelChar = false;
            this.ledTable1Stop.Size = new System.Drawing.Size(131, 21);
            this.ledTable1Stop.TabIndex = 1440;
            this.ledTable1Stop.Text = "Table1.Stop";
            this.ledTable1Stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable1Stop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable1Stop_LEDValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1472;
            this.label1.Text = "Table1.Step=";
            // 
            // ledTable2Stop
            // 
            this.ledTable2Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2Stop.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2Stop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2Stop.Frame.Visible = false;
            this.ledTable2Stop.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable2Stop.LED.OnColor = System.Drawing.Color.Red;
            this.ledTable2Stop.LED.Size = new System.Drawing.Size(12, 12);
            this.ledTable2Stop.Location = new System.Drawing.Point(209, 52);
            this.ledTable2Stop.Name = "ledTable2Stop";
            this.ledTable2Stop.ShowAccelChar = false;
            this.ledTable2Stop.Size = new System.Drawing.Size(146, 21);
            this.ledTable2Stop.TabIndex = 1441;
            this.ledTable2Stop.Text = "Table2.Stop";
            this.ledTable2Stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledTable2Stop.LEDValueChanged += new System.EventHandler<YujinTechnology.LEDValueChangedEventArgs>(this.ledTable2Stop_LEDValueChanged);
            // 
            // lblTable2Step
            // 
            this.lblTable2Step.BackColor = System.Drawing.Color.Transparent;
            this.lblTable2Step.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblTable2Step.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTable2Step.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTable2Step.Frame.Left = false;
            this.lblTable2Step.Frame.Right = false;
            this.lblTable2Step.Frame.Top = false;
            this.lblTable2Step.GradientEnable = false;
            this.lblTable2Step.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTable2Step.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTable2Step.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblTable2Step.Location = new System.Drawing.Point(313, 74);
            this.lblTable2Step.Name = "lblTable2Step";
            this.lblTable2Step.ShowAccelChar = false;
            this.lblTable2Step.Size = new System.Drawing.Size(57, 21);
            this.lblTable2Step.TabIndex = 1471;
            this.lblTable2Step.Text = "0";
            this.lblTable2Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTable1Step
            // 
            this.lblTable1Step.BackColor = System.Drawing.Color.Transparent;
            this.lblTable1Step.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblTable1Step.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTable1Step.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTable1Step.Frame.Left = false;
            this.lblTable1Step.Frame.Right = false;
            this.lblTable1Step.Frame.Top = false;
            this.lblTable1Step.GradientEnable = false;
            this.lblTable1Step.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTable1Step.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTable1Step.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblTable1Step.Location = new System.Drawing.Point(125, 74);
            this.lblTable1Step.Name = "lblTable1Step";
            this.lblTable1Step.ShowAccelChar = false;
            this.lblTable1Step.Size = new System.Drawing.Size(57, 21);
            this.lblTable1Step.TabIndex = 1442;
            this.lblTable1Step.Text = "0";
            this.lblTable1Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTable2Error
            // 
            this.ledTable2Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledTable2Error.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledTable2Error.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTable2Error.Frame.Visible = false;
            this.ledTable2Error.LED.OffColor = System.Drawing.Color.Silver;
            this.ledTable2Error.LED.OnColor = System.Drawing.Color.Red;
            this.ledTable2Error.LED.Size = new System.Drawing.Size(12, 12);
            this.ledTable2Error.Location = new System.Drawing.Point(209, 99);
            this.ledTable2Error.Name = "ledTable2Error";
            this.ledTable2Error.ShowAccelChar = false;
            this.ledTable2Error.Size = new System.Drawing.Size(105, 21);
            this.ledTable2Error.TabIndex = 1446;
            this.ledTable2Error.Text = "Table2.Error=";
            this.ledTable2Error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(10, 281);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 137);
            this.listView1.TabIndex = 1434;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panAuto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ledLabel4);
            this.Controls.Add(this.ledLabel3);
            this.Controls.Add(this.ledLabel6);
            this.Controls.Add(this.ledLabel5);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.ledLabel7);
            this.Controls.Add(this.TabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "panAuto";
            this.Size = new System.Drawing.Size(1915, 852);
            this.Load += new System.EventHandler(this.panMain_Load);
            this.TabControl1.ResumeLayout(false);
            this.panRight.ResumeLayout(false);
            this.panRight.PerformLayout();
            this.panRunStatus.ResumeLayout(false);
            this.panRunStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabTable1;
        private System.Windows.Forms.TabPage tabTable2;
        private System.Windows.Forms.ImageList imageList1;
        public YujinTechnology.TabControl TabControl1;
        private YujinTechnology.LEDLabel ledLabel5;
        private YujinTechnology.LEDLabel ledLabel6;
        private YujinTechnology.ErrorProcessor errorProcessor1;
        private YujinTechnology.LEDButton btnStart;
        private YujinTechnology.LEDButton btnStop;
        private YujinTechnology.LEDButton btnAutoReady;
        public System.Windows.Forms.ListView listView1;
        private YujinTechnology.LEDButton ledButton1;
        public YujinTechnology.LEDLabel ledTable1CycleStop;
        public YujinTechnology.LEDLabel ledTable2CycleStop;
        public YujinTechnology.LEDLabel ledTable1Stop;
        public YujinTechnology.LEDLabel ledTable2Stop;
        public YujinTechnology.GradientLabel lblTable1Step;
        public YujinTechnology.GradientLabel lblPageIndex;
        public YujinTechnology.GradientLabel lblPageCount;
        public YujinTechnology.LEDLabel ledTable1Error;
        public YujinTechnology.LEDLabel ledTable2Error;
        private YujinTechnology.LEDLabel ledCoord1ProgRunning;
        private YujinTechnology.LEDLabel ledMotion;
        private YujinTechnology.LEDLabel ledADV;
        private YujinTechnology.LEDLabel ledLaser;
        private YujinTechnology.LEDLabel ledVision;
        public YujinTechnology.LEDLabel ledTable1JobFileLoad;
        private YujinTechnology.LEDLabel ledRunStatus;
        private YujinTechnology.LEDButton btnTable1New;
        private sjPanel panRight;
        private YujinTechnology.LEDButton btnReset;
        private YujinTechnology.LEDLabel ledLabel7;
        private YujinTechnology.LEDButton ledButton2;
        private YujinTechnology.LEDButton btnTable2New;
        public YujinTechnology.LEDButton btnLaserRun;
        public YujinTechnology.LEDButton btnDryRun;
        private YujinTechnology.LEDLabel ledLabel4;
        private YujinTechnology.LEDLabel ledLabel3;
        public YujinTechnology.GradientLabel lblTable2Step;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public YujinTechnology.GradientLabel lblTable2ErrorStep;
        public YujinTechnology.GradientLabel lblTable1ErrorStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panRunStatus;
        private YujinTechnology.GradientLabel gradLabel26;
        private YujinTechnology.GradientLabel gradLabel24;
        private YujinTechnology.GradientLabel gradLabel19;
        private YujinTechnology.GradientLabel gradLabel21;
        private YujinTechnology.GradientLabel gradLabel28;
        private YujinTechnology.GradientLabel gradLabel17;
        private YujinTechnology.GradientLabel gradLabel29;
        private YujinTechnology.ValueIndicator viZVelocity;
        private YujinTechnology.ValueIndicator viXVelocity;
        private YujinTechnology.ValueIndicator viXPosition;
        private YujinTechnology.ValueIndicator viY1Position;
        private YujinTechnology.ValueIndicator viY2Position;
        private YujinTechnology.ValueIndicator viZPosition;
        private YujinTechnology.ValueIndicator viY1Velocity;
        private YujinTechnology.ValueIndicator viY2Velocity;
        public YujinTechnology.LEDLabel ledTable1DXFArray;
        public YujinTechnology.LEDLabel ledTable1DXF;
        public YujinTechnology.LEDLabel ledTable1MakeCell;
        public YujinTechnology.LEDLabel ledTable2MakeCell;
        public YujinTechnology.LEDLabel ledTable2DXFArray;
        public YujinTechnology.LEDLabel ledTable2DXF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public YujinTechnology.LEDLabel ledTable2AreaSensor;
        public YujinTechnology.LEDLabel ledTable1AreaSensor;
        private YujinTechnology.Thread BlinkThread;
        private YujinTechnology.Label lblLabelInputCount;
        private YujinTechnology.Label lblLabelCycleTime;
        public YujinTechnology.ValueIndicator viTable2InputCount;
        public YujinTechnology.ValueIndicator viTable1InputCount;
        public YujinTechnology.ValueIndicator viTable2CycleTime;
        public YujinTechnology.ValueIndicator viTable1CycleTime;
        private YujinTechnology.LEDButton btnClear;
        public YujinTechnology.Label lblMachineNo;
        private YujinTechnology.Label lblLabelTable1JobFile;
        public YujinTechnology.LEDLabel ledTable2JobFileLoad;
        private YujinTechnology.Label lblLabelTable2JobFile;
        private YujinTechnology.LEDLabel ledLight;
        private YujinTechnology.LEDLabel ledMVS;
        public YujinTechnology.Thread AutoThread;
        private YujinTechnology.Label LabelLaserSet;
        public YujinTechnology.Label lblLaserSet;
        private YujinTechnology.Label LabelLaserStatus;
        public YujinTechnology.Label lblEmissionStatus;
        public YujinTechnology.Label lblLaserStatus;
        public YujinTechnology.Label lblShutterStatus;
        private YujinTechnology.LEDLabel ledShowStep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
