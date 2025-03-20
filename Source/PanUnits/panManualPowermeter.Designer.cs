using DaekhonSystem;

namespace LaserCutter
{
    partial class panManualPowermeter
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
            this.Comm = new DaekhonSystem.Comm();
            this.MeasureThread = new DaekhonSystem.Thread();
            this.sjPanel1 = new LaserCutter.sjPanel();
            this.gradientLabel10 = new DaekhonSystem.GradientLabel();
            this.gradientLabel9 = new DaekhonSystem.GradientLabel();
            this.gradientLabel8 = new DaekhonSystem.GradientLabel();
            this.viLastStep = new DaekhonSystem.ValueIndicator();
            this.gradientLabel7 = new DaekhonSystem.GradientLabel();
            this.viCurrentStep = new DaekhonSystem.ValueIndicator();
            this.valueIndicator1 = new DaekhonSystem.ValueIndicator();
            this.gradientLabel2 = new DaekhonSystem.GradientLabel();
            this.viReadCount = new DaekhonSystem.ValueIndicator();
            this.bitClear = new DaekhonSystem.BitBtn();
            this.viCurrentValue = new DaekhonSystem.ValueIndicator();
            this.gradientLabel1 = new DaekhonSystem.GradientLabel();
            this.viAverage = new DaekhonSystem.ValueIndicator();
            this.viMax = new DaekhonSystem.ValueIndicator();
            this.viMin = new DaekhonSystem.ValueIndicator();
            this.btnMeasureStart = new DaekhonSystem.LEDButton();
            this.btnConnect = new DaekhonSystem.LEDButton();
            this.gradientLabel5 = new DaekhonSystem.GradientLabel();
            this.gradientLabel6 = new DaekhonSystem.GradientLabel();
            this.gradientLabel3 = new DaekhonSystem.GradientLabel();
            this.gradientLabel4 = new DaekhonSystem.GradientLabel();
            this.sunnyLine3 = new DaekhonSystem.SunnyLine();
            this.btnRead = new DaekhonSystem.BitBtn();
            this.sunnyLine1 = new DaekhonSystem.SunnyLine();
            this.edScanTime = new DaekhonSystem.KeypadEdit();
            this.gradLabel53 = new DaekhonSystem.GradientLabel();
            this.cbComPort = new DaekhonSystem.ComboBox();
            this.sjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Comm
            // 
            this.Comm.BaudRate = DaekhonSystem.BaudRate._9600;
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
            this.Comm.Port = DaekhonSystem.Port.COM03;
            this.Comm.Priority = System.Threading.ThreadPriority.Normal;
            this.Comm.RS485Mode = false;
            this.Comm.StopBits = DaekhonSystem.StopBits._1;
            this.Comm.TimeOut = ((uint)(1000u));
            // 
            // MeasureThread
            // 
            this.MeasureThread.Enabled = false;
            this.MeasureThread.Interval = 300;
            this.MeasureThread.OnExecute += new System.EventHandler(this.MeasureThread_OnExecute);
            // 
            // sjPanel1
            // 
            this.sjPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sjPanel1.Controls.Add(this.gradientLabel10);
            this.sjPanel1.Controls.Add(this.gradientLabel9);
            this.sjPanel1.Controls.Add(this.gradientLabel8);
            this.sjPanel1.Controls.Add(this.viLastStep);
            this.sjPanel1.Controls.Add(this.gradientLabel7);
            this.sjPanel1.Controls.Add(this.viCurrentStep);
            this.sjPanel1.Controls.Add(this.valueIndicator1);
            this.sjPanel1.Controls.Add(this.gradientLabel2);
            this.sjPanel1.Controls.Add(this.viReadCount);
            this.sjPanel1.Controls.Add(this.bitClear);
            this.sjPanel1.Controls.Add(this.viCurrentValue);
            this.sjPanel1.Controls.Add(this.gradientLabel1);
            this.sjPanel1.Controls.Add(this.viAverage);
            this.sjPanel1.Controls.Add(this.viMax);
            this.sjPanel1.Controls.Add(this.viMin);
            this.sjPanel1.Controls.Add(this.btnMeasureStart);
            this.sjPanel1.Controls.Add(this.btnConnect);
            this.sjPanel1.Controls.Add(this.gradientLabel5);
            this.sjPanel1.Controls.Add(this.gradientLabel6);
            this.sjPanel1.Controls.Add(this.gradientLabel3);
            this.sjPanel1.Controls.Add(this.gradientLabel4);
            this.sjPanel1.Controls.Add(this.sunnyLine3);
            this.sjPanel1.Controls.Add(this.btnRead);
            this.sjPanel1.Controls.Add(this.sunnyLine1);
            this.sjPanel1.Controls.Add(this.edScanTime);
            this.sjPanel1.Controls.Add(this.gradLabel53);
            this.sjPanel1.Controls.Add(this.cbComPort);
            this.sjPanel1.Location = new System.Drawing.Point(3, 3);
            this.sjPanel1.Name = "sjPanel1";
            this.sjPanel1.Size = new System.Drawing.Size(427, 843);
            this.sjPanel1.TabIndex = 1280;
            this.sjPanel1.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.sjPanel1.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.sjPanel1.TitleText = "Power Meter";
            this.sjPanel1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientLabel10
            // 
            this.gradientLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel10.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel10.Frame.Bottom = false;
            this.gradientLabel10.Frame.Left = false;
            this.gradientLabel10.Frame.Right = false;
            this.gradientLabel10.Frame.Top = false;
            this.gradientLabel10.Frame.Visible = false;
            this.gradientLabel10.GradientEnable = false;
            this.gradientLabel10.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel10.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel10.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel10.Location = new System.Drawing.Point(283, 627);
            this.gradientLabel10.Name = "gradientLabel10";
            this.gradientLabel10.Size = new System.Drawing.Size(89, 26);
            this.gradientLabel10.TabIndex = 1397;
            this.gradientLabel10.Text = "(w)";
            this.gradientLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientLabel9
            // 
            this.gradientLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel9.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel9.Frame.Visible = false;
            this.gradientLabel9.GradientEnable = false;
            this.gradientLabel9.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel9.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel9.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel9.Location = new System.Drawing.Point(83, 74);
            this.gradientLabel9.Name = "gradientLabel9";
            this.gradientLabel9.Size = new System.Drawing.Size(92, 26);
            this.gradientLabel9.TabIndex = 1396;
            this.gradientLabel9.Text = "Port";
            this.gradientLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel8
            // 
            this.gradientLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel8.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel8.Frame.Bottom = false;
            this.gradientLabel8.Frame.Left = false;
            this.gradientLabel8.Frame.Right = false;
            this.gradientLabel8.Frame.Top = false;
            this.gradientLabel8.Frame.Visible = false;
            this.gradientLabel8.GradientEnable = false;
            this.gradientLabel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel8.Location = new System.Drawing.Point(44, 457);
            this.gradientLabel8.Name = "gradientLabel8";
            this.gradientLabel8.Size = new System.Drawing.Size(135, 26);
            this.gradientLabel8.TabIndex = 1395;
            this.gradientLabel8.Text = "Last Step";
            this.gradientLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viLastStep
            // 
            this.viLastStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viLastStep.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viLastStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.viLastStep.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viLastStep.ForeColor = System.Drawing.Color.Black;
            this.viLastStep.FormatString = "0";
            this.viLastStep.Location = new System.Drawing.Point(181, 454);
            this.viLastStep.Name = "viLastStep";
            this.viLastStep.Size = new System.Drawing.Size(95, 29);
            this.viLastStep.TabIndex = 1394;
            this.viLastStep.Text = "0";
            this.viLastStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel7
            // 
            this.gradientLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel7.Frame.Bottom = false;
            this.gradientLabel7.Frame.Left = false;
            this.gradientLabel7.Frame.Right = false;
            this.gradientLabel7.Frame.Top = false;
            this.gradientLabel7.Frame.Visible = false;
            this.gradientLabel7.GradientEnable = false;
            this.gradientLabel7.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel7.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel7.Location = new System.Drawing.Point(44, 425);
            this.gradientLabel7.Name = "gradientLabel7";
            this.gradientLabel7.Size = new System.Drawing.Size(135, 26);
            this.gradientLabel7.TabIndex = 1393;
            this.gradientLabel7.Text = "Current Step";
            this.gradientLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viCurrentStep
            // 
            this.viCurrentStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viCurrentStep.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viCurrentStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.viCurrentStep.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viCurrentStep.ForeColor = System.Drawing.Color.Black;
            this.viCurrentStep.FormatString = "0";
            this.viCurrentStep.Location = new System.Drawing.Point(181, 422);
            this.viCurrentStep.Name = "viCurrentStep";
            this.viCurrentStep.Size = new System.Drawing.Size(95, 29);
            this.viCurrentStep.TabIndex = 1392;
            this.viCurrentStep.Text = "0";
            this.viCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueIndicator1
            // 
            this.valueIndicator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.valueIndicator1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.valueIndicator1.Cursor = System.Windows.Forms.Cursors.Default;
            this.valueIndicator1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.valueIndicator1.ForeColor = System.Drawing.Color.Black;
            this.valueIndicator1.FormatString = "{0:F3}";
            this.valueIndicator1.Location = new System.Drawing.Point(181, 329);
            this.valueIndicator1.Name = "valueIndicator1";
            this.valueIndicator1.Size = new System.Drawing.Size(95, 29);
            this.valueIndicator1.TabIndex = 1391;
            this.valueIndicator1.Text = "5.0";
            this.valueIndicator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel2.Frame.Bottom = false;
            this.gradientLabel2.Frame.Left = false;
            this.gradientLabel2.Frame.Right = false;
            this.gradientLabel2.Frame.Top = false;
            this.gradientLabel2.Frame.Visible = false;
            this.gradientLabel2.GradientEnable = false;
            this.gradientLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel2.Location = new System.Drawing.Point(41, 330);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(135, 26);
            this.gradientLabel2.TabIndex = 1390;
            this.gradientLabel2.Text = "First Delay Time(s)";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viReadCount
            // 
            this.viReadCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viReadCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.viReadCount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viReadCount.ForeColor = System.Drawing.Color.Black;
            this.viReadCount.FormatString = "0";
            this.viReadCount.Location = new System.Drawing.Point(184, 594);
            this.viReadCount.Name = "viReadCount";
            this.viReadCount.Size = new System.Drawing.Size(95, 29);
            this.viReadCount.TabIndex = 1389;
            this.viReadCount.Text = "0";
            this.viReadCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bitClear
            // 
            this.bitClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitClear.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.bitClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bitClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bitClear.ForeColor = System.Drawing.Color.Black;
            this.bitClear.Location = new System.Drawing.Point(286, 682);
            this.bitClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.bitClear.Name = "bitClear";
            this.bitClear.Size = new System.Drawing.Size(92, 45);
            this.bitClear.TabIndex = 1388;
            this.bitClear.Text = "Clear";
            this.bitClear.UseVisualStyleBackColor = false;
            // 
            // viCurrentValue
            // 
            this.viCurrentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viCurrentValue.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viCurrentValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.viCurrentValue.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viCurrentValue.ForeColor = System.Drawing.Color.Black;
            this.viCurrentValue.FormatString = "0.000";
            this.viCurrentValue.Location = new System.Drawing.Point(181, 233);
            this.viCurrentValue.Name = "viCurrentValue";
            this.viCurrentValue.Size = new System.Drawing.Size(95, 29);
            this.viCurrentValue.TabIndex = 1387;
            this.viCurrentValue.Text = "0";
            this.viCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel1.Frame.Bottom = false;
            this.gradientLabel1.Frame.Left = false;
            this.gradientLabel1.Frame.Right = false;
            this.gradientLabel1.Frame.Top = false;
            this.gradientLabel1.Frame.Visible = false;
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(83, 234);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(93, 26);
            this.gradientLabel1.TabIndex = 1386;
            this.gradientLabel1.Text = "Currrent";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viAverage
            // 
            this.viAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAverage.Cursor = System.Windows.Forms.Cursors.Default;
            this.viAverage.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAverage.ForeColor = System.Drawing.Color.Black;
            this.viAverage.FormatString = "0.000";
            this.viAverage.Location = new System.Drawing.Point(184, 626);
            this.viAverage.Name = "viAverage";
            this.viAverage.Size = new System.Drawing.Size(95, 29);
            this.viAverage.TabIndex = 1385;
            this.viAverage.Text = "0.000";
            this.viAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viMax
            // 
            this.viMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.viMax.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viMax.ForeColor = System.Drawing.Color.Black;
            this.viMax.FormatString = "0.000";
            this.viMax.Location = new System.Drawing.Point(184, 658);
            this.viMax.Name = "viMax";
            this.viMax.Size = new System.Drawing.Size(95, 29);
            this.viMax.TabIndex = 1384;
            this.viMax.Text = "0.000";
            this.viMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viMin
            // 
            this.viMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.viMin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viMin.ForeColor = System.Drawing.Color.Black;
            this.viMin.FormatString = "0.000";
            this.viMin.Location = new System.Drawing.Point(184, 690);
            this.viMin.Name = "viMin";
            this.viMin.Size = new System.Drawing.Size(95, 29);
            this.viMin.TabIndex = 1383;
            this.viMin.Text = "0.000";
            this.viMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMeasureStart
            // 
            this.btnMeasureStart.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMeasureStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMeasureStart.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMeasureStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeasureStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMeasureStart.ForeColor = System.Drawing.Color.Black;
            this.btnMeasureStart.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnMeasureStart.LED.Size = new System.Drawing.Size(70, 26);
            this.btnMeasureStart.Location = new System.Drawing.Point(286, 353);
            this.btnMeasureStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMeasureStart.Name = "btnMeasureStart";
            this.btnMeasureStart.Size = new System.Drawing.Size(92, 45);
            this.btnMeasureStart.TabIndex = 1381;
            this.btnMeasureStart.Text = "Measure";
            this.btnMeasureStart.UseVisualStyleBackColor = false;
            this.btnMeasureStart.Click += new System.EventHandler(this.btnMeasureStart_Click);
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
            this.btnConnect.Location = new System.Drawing.Point(282, 64);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 46);
            this.btnConnect.TabIndex = 1380;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnPowerMeterConnect_Click);
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel5.Frame.Visible = false;
            this.gradientLabel5.GradientEnable = false;
            this.gradientLabel5.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel5.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel5.Location = new System.Drawing.Point(90, 659);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.Size = new System.Drawing.Size(89, 26);
            this.gradientLabel5.TabIndex = 1368;
            this.gradientLabel5.Text = "MAX";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel6
            // 
            this.gradientLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel6.Frame.Visible = false;
            this.gradientLabel6.GradientEnable = false;
            this.gradientLabel6.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel6.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel6.Location = new System.Drawing.Point(90, 691);
            this.gradientLabel6.Name = "gradientLabel6";
            this.gradientLabel6.Size = new System.Drawing.Size(89, 26);
            this.gradientLabel6.TabIndex = 1369;
            this.gradientLabel6.Text = "MIN";
            this.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel3.Frame.Bottom = false;
            this.gradientLabel3.Frame.Left = false;
            this.gradientLabel3.Frame.Right = false;
            this.gradientLabel3.Frame.Top = false;
            this.gradientLabel3.Frame.Visible = false;
            this.gradientLabel3.GradientEnable = false;
            this.gradientLabel3.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel3.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel3.Location = new System.Drawing.Point(90, 595);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(89, 26);
            this.gradientLabel3.TabIndex = 1364;
            this.gradientLabel3.Text = "Count";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel4.Frame.Bottom = false;
            this.gradientLabel4.Frame.Left = false;
            this.gradientLabel4.Frame.Right = false;
            this.gradientLabel4.Frame.Top = false;
            this.gradientLabel4.Frame.Visible = false;
            this.gradientLabel4.GradientEnable = false;
            this.gradientLabel4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel4.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel4.Location = new System.Drawing.Point(90, 627);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(89, 26);
            this.gradientLabel4.TabIndex = 1365;
            this.gradientLabel4.Text = "Average";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sunnyLine3
            // 
            this.sunnyLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine3.Cursor = System.Windows.Forms.Cursors.Default;
            this.sunnyLine3.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.sunnyLine3.EndCap = DaekhonSystem.UILineCap.None;
            this.sunnyLine3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine3.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine3.Frame.Visible = false;
            this.sunnyLine3.LineCapSize = 4;
            this.sunnyLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine3.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.sunnyLine3.LineWidth = 1F;
            this.sunnyLine3.Location = new System.Drawing.Point(46, 570);
            this.sunnyLine3.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine3.Name = "sunnyLine3";
            this.sunnyLine3.Size = new System.Drawing.Size(250, 17);
            this.sunnyLine3.StartCap = DaekhonSystem.UILineCap.None;
            this.sunnyLine3.TabIndex = 1363;
            this.sunnyLine3.Text = "Result";
            this.sunnyLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine3.TextInterval = 4;
            // 
            // btnRead
            // 
            this.btnRead.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRead.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRead.ForeColor = System.Drawing.Color.Black;
            this.btnRead.Location = new System.Drawing.Point(286, 225);
            this.btnRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(92, 45);
            this.btnRead.TabIndex = 1336;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // sunnyLine1
            // 
            this.sunnyLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sunnyLine1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sunnyLine1.Direction = DaekhonSystem.LineDirection.Horizontal;
            this.sunnyLine1.EndCap = DaekhonSystem.UILineCap.None;
            this.sunnyLine1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sunnyLine1.ForeColor = System.Drawing.Color.Black;
            this.sunnyLine1.Frame.Visible = false;
            this.sunnyLine1.LineCapSize = 4;
            this.sunnyLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.sunnyLine1.LineDashStyle = DaekhonSystem.UILineDashStyle.Solid;
            this.sunnyLine1.LineWidth = 1F;
            this.sunnyLine1.Location = new System.Drawing.Point(690, 539);
            this.sunnyLine1.MinimumSize = new System.Drawing.Size(16, 14);
            this.sunnyLine1.Name = "sunnyLine1";
            this.sunnyLine1.Size = new System.Drawing.Size(269, 17);
            this.sunnyLine1.StartCap = DaekhonSystem.UILineCap.None;
            this.sunnyLine1.TabIndex = 1332;
            this.sunnyLine1.Text = "Laser Set";
            this.sunnyLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunnyLine1.TextInterval = 4;
            // 
            // edScanTime
            // 
            this.edScanTime.BackColor = System.Drawing.Color.White;
            this.edScanTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edScanTime.DataType = DaekhonSystem.DataType.Integer;
            this.edScanTime.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edScanTime.ForeColor = System.Drawing.Color.Black;
            this.edScanTime.Frame.CornerRound = 1;
            this.edScanTime.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edScanTime.Location = new System.Drawing.Point(181, 361);
            this.edScanTime.Max = 1.7976931348623157E+308D;
            this.edScanTime.Min = -1.7976931348623157E+308D;
            this.edScanTime.Name = "edScanTime";
            this.edScanTime.PrecisionDigits = 3;
            this.edScanTime.Size = new System.Drawing.Size(95, 29);
            this.edScanTime.TabIndex = 1321;
            this.edScanTime.TabStop = false;
            this.edScanTime.Text = "10";
            // 
            // gradLabel53
            // 
            this.gradLabel53.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel53.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel53.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel53.Frame.Bottom = false;
            this.gradLabel53.Frame.Left = false;
            this.gradLabel53.Frame.Right = false;
            this.gradLabel53.Frame.Top = false;
            this.gradLabel53.Frame.Visible = false;
            this.gradLabel53.GradientEnable = false;
            this.gradLabel53.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel53.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel53.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel53.Location = new System.Drawing.Point(87, 362);
            this.gradLabel53.Name = "gradLabel53";
            this.gradLabel53.Size = new System.Drawing.Size(89, 26);
            this.gradLabel53.TabIndex = 1319;
            this.gradLabel53.Text = "Scan Time(s)";
            this.gradLabel53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbComPort
            // 
            this.cbComPort.BackColor = System.Drawing.Color.White;
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbComPort.Frame.CornerRound = 1;
            this.cbComPort.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
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
            this.cbComPort.Location = new System.Drawing.Point(181, 73);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbComPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbComPort.Size = new System.Drawing.Size(95, 29);
            this.cbComPort.TabIndex = 1309;
            this.cbComPort.Text = "COM01";
            // 
            // panManualPowermeter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.sjPanel1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "panManualPowermeter";
            this.Size = new System.Drawing.Size(433, 849);
            this.sjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private sjPanel sjPanel1;
        private ComboBox cbComPort;
        private KeypadEdit edScanTime;
        private GradientLabel gradLabel53;
        private BitBtn btnRead;
        private SunnyLine sunnyLine1;
        private GradientLabel gradientLabel5;
        private GradientLabel gradientLabel6;
        private GradientLabel gradientLabel3;
        private GradientLabel gradientLabel4;
        private SunnyLine sunnyLine3;
        public Comm Comm;
        private LEDButton btnConnect;
        private LEDButton btnMeasureStart;
        public Thread MeasureThread;
        private ValueIndicator viMin;
        private ValueIndicator viMax;
        private ValueIndicator viAverage;
        private GradientLabel gradientLabel1;
        private ValueIndicator viCurrentValue;
        private BitBtn bitClear;
        private ValueIndicator viReadCount;
        private ValueIndicator valueIndicator1;
        private GradientLabel gradientLabel2;
        private ValueIndicator viCurrentStep;
        private GradientLabel gradientLabel7;
        private GradientLabel gradientLabel8;
        private ValueIndicator viLastStep;
        private GradientLabel gradientLabel9;
        private GradientLabel gradientLabel10;
    }
}
