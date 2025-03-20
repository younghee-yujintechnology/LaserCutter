using DaekhonSystem;

namespace LaserCutter
{
    partial class panManualLight
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
            this.ReadThread = new DaekhonSystem.Thread();
            this.panClient = new LaserCutter.sjPanel();
            this.ledTX = new DaekhonSystem.LEDLabel();
            this.ledRX = new DaekhonSystem.LEDLabel();
            this.btnLightOn = new DaekhonSystem.LEDButton();
            this.viCurrentValue = new DaekhonSystem.ValueIndicator();
            this.gradientLabel4 = new DaekhonSystem.GradientLabel();
            this.btnConnect = new DaekhonSystem.LEDButton();
            this.btnSet = new DaekhonSystem.BitBtn();
            this.edLightValue = new DaekhonSystem.KeypadEdit();
            this.gradientLabel2 = new DaekhonSystem.GradientLabel();
            this.gradientLabel3 = new DaekhonSystem.GradientLabel();
            this.cbComPort = new DaekhonSystem.ComboBox();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // Comm
            // 
            this.Comm.BaudRate = DaekhonSystem.BaudRate._19200;
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
            // ReadThread
            // 
            this.ReadThread.Enabled = false;
            this.ReadThread.Interval = 500;
            this.ReadThread.OnExecute += new System.EventHandler(this.ReadThread_OnExecute);
            // 
            // panClient
            // 
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.ledTX);
            this.panClient.Controls.Add(this.ledRX);
            this.panClient.Controls.Add(this.btnLightOn);
            this.panClient.Controls.Add(this.viCurrentValue);
            this.panClient.Controls.Add(this.gradientLabel4);
            this.panClient.Controls.Add(this.btnConnect);
            this.panClient.Controls.Add(this.btnSet);
            this.panClient.Controls.Add(this.edLightValue);
            this.panClient.Controls.Add(this.gradientLabel2);
            this.panClient.Controls.Add(this.gradientLabel3);
            this.panClient.Controls.Add(this.cbComPort);
            this.panClient.Location = new System.Drawing.Point(3, 3);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(427, 843);
            this.panClient.TabIndex = 1295;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panClient.TitleText = "Light Control";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledTX
            // 
            this.ledTX.BackColor = System.Drawing.Color.Transparent;
            this.ledTX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledTX.Frame.Visible = false;
            this.ledTX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledTX.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledTX.LED.OffColor = System.Drawing.Color.Gray;
            this.ledTX.Location = new System.Drawing.Point(402, 12);
            this.ledTX.Name = "ledTX";
            this.ledTX.ShowChannelName = false;
            this.ledTX.Size = new System.Drawing.Size(15, 16);
            this.ledTX.TabIndex = 1491;
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
            this.ledRX.Location = new System.Drawing.Point(384, 12);
            this.ledRX.Name = "ledRX";
            this.ledRX.ShowChannelName = false;
            this.ledRX.Size = new System.Drawing.Size(15, 16);
            this.ledRX.TabIndex = 1490;
            this.ledRX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLightOn
            // 
            this.btnLightOn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLightOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLightOn.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnLightOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightOn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLightOn.ForeColor = System.Drawing.Color.Black;
            this.btnLightOn.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.btnLightOn.LED.Size = new System.Drawing.Size(70, 26);
            this.btnLightOn.Location = new System.Drawing.Point(282, 340);
            this.btnLightOn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(92, 46);
            this.btnLightOn.TabIndex = 1336;
            this.btnLightOn.Text = "On";
            this.btnLightOn.UseVisualStyleBackColor = false;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // viCurrentValue
            // 
            this.viCurrentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viCurrentValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.viCurrentValue.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viCurrentValue.ForeColor = System.Drawing.Color.Black;
            this.viCurrentValue.FormatString = "0";
            this.viCurrentValue.Location = new System.Drawing.Point(181, 233);
            this.viCurrentValue.Name = "viCurrentValue";
            this.viCurrentValue.Size = new System.Drawing.Size(95, 29);
            this.viCurrentValue.TabIndex = 1334;
            this.viCurrentValue.Text = "0";
            this.viCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gradientLabel4.Location = new System.Drawing.Point(83, 234);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(93, 26);
            this.gradientLabel4.TabIndex = 1333;
            this.gradientLabel4.Text = "Current";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnConnect.TabIndex = 1332;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSet
            // 
            this.btnSet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSet.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Location = new System.Drawing.Point(282, 288);
            this.btnSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(92, 46);
            this.btnSet.TabIndex = 1330;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // edLightValue
            // 
            this.edLightValue.BackColor = System.Drawing.Color.White;
            this.edLightValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edLightValue.DataType = DaekhonSystem.DataType.Integer;
            this.edLightValue.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edLightValue.ForeColor = System.Drawing.Color.Black;
            this.edLightValue.Frame.CornerRound = 1;
            this.edLightValue.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLightValue.Hint = null;
            this.edLightValue.Location = new System.Drawing.Point(181, 297);
            this.edLightValue.Max = 0D;
            this.edLightValue.Min = 0D;
            this.edLightValue.Name = "edLightValue";
            this.edLightValue.PrecisionDigits = 3;
            this.edLightValue.ShowHint = false;
            this.edLightValue.Size = new System.Drawing.Size(95, 29);
            this.edLightValue.TabIndex = 1329;
            this.edLightValue.TabStop = false;
            this.edLightValue.Text = "0";
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
            this.gradientLabel2.Location = new System.Drawing.Point(83, 298);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(92, 26);
            this.gradientLabel2.TabIndex = 1328;
            this.gradientLabel2.Text = "Light Value";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.gradientLabel3.Location = new System.Drawing.Point(83, 74);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(92, 26);
            this.gradientLabel3.TabIndex = 1324;
            this.gradientLabel3.Text = "Port";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cbComPort.Location = new System.Drawing.Point(181, 73);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbComPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbComPort.ShowHint = false;
            this.cbComPort.Size = new System.Drawing.Size(95, 29);
            this.cbComPort.TabIndex = 1323;
            this.cbComPort.Text = "COM01";
            // 
            // panManualLight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Location = new System.Drawing.Point(3, 3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panManualLight";
            this.Size = new System.Drawing.Size(433, 849);
            this.panClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private sjPanel panClient;
        private KeypadEdit edLightValue;
        private GradientLabel gradientLabel2;
        private GradientLabel gradientLabel3;
        private ComboBox cbComPort;
        public Comm Comm;
        private BitBtn btnSet;
        private ValueIndicator viCurrentValue;
        private GradientLabel gradientLabel4;
        private LEDButton btnConnect;
        private LEDButton btnLightOn;
        public Thread ReadThread;
        private LEDLabel ledTX;
        private LEDLabel ledRX;
    }
}
