namespace LaserCutter
{
    partial class frmMVS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new YujinTechnology.BitBtn();
            this.btnConnect = new YujinTechnology.LEDButton();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnGetCameraList = new YujinTechnology.BitBtn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPixelFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetParameter = new YujinTechnology.BitBtn();
            this.btnGetParam = new YujinTechnology.BitBtn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edFrameRate = new System.Windows.Forms.TextBox();
            this.edGain = new System.Windows.Forms.TextBox();
            this.edExposure = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUpdateThread = new System.Windows.Forms.CheckBox();
            this.btnSoftTrigger = new YujinTechnology.BitBtn();
            this.chkSoftTrigger = new System.Windows.Forms.CheckBox();
            this.btnGrabStop = new YujinTechnology.LEDButton();
            this.btnGrabStart = new YujinTechnology.LEDButton();
            this.rdoTriggerMode = new System.Windows.Forms.RadioButton();
            this.rdoContinuesMode = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateThread1 = new YujinTechnology.Thread();
            this.UpdateThread2 = new YujinTechnology.Thread();
            this.btnSaveBmp = new YujinTechnology.BitBtn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(231, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDisconnect.Location = new System.Drawing.Point(118, 20);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 38);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConnect.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnect.LED.OffColor = System.Drawing.Color.Red;
            this.btnConnect.Location = new System.Drawing.Point(12, 20);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Margin2 = 10;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 38);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(88, 11);
            this.cbCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(350, 22);
            this.cbCamera.TabIndex = 10;
            // 
            // btnGetCameraList
            // 
            this.btnGetCameraList.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGetCameraList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGetCameraList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetCameraList.Location = new System.Drawing.Point(446, 11);
            this.btnGetCameraList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCameraList.Name = "btnGetCameraList";
            this.btnGetCameraList.Size = new System.Drawing.Size(37, 23);
            this.btnGetCameraList.TabIndex = 12;
            this.btnGetCameraList.Text = "...";
            this.btnGetCameraList.UseVisualStyleBackColor = true;
            this.btnGetCameraList.Click += new System.EventHandler(this.btnGetCameraList_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPixelFormat);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnSetParameter);
            this.groupBox4.Controls.Add(this.btnGetParam);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.edFrameRate);
            this.groupBox4.Controls.Add(this.edGain);
            this.groupBox4.Controls.Add(this.edExposure);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox4.Location = new System.Drawing.Point(14, 121);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(231, 178);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "  Parameters  ";
            // 
            // cbPixelFormat
            // 
            this.cbPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPixelFormat.FormattingEnabled = true;
            this.cbPixelFormat.Location = new System.Drawing.Point(116, 103);
            this.cbPixelFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPixelFormat.Name = "cbPixelFormat";
            this.cbPixelFormat.Size = new System.Drawing.Size(103, 22);
            this.cbPixelFormat.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pixel Format";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetParameter
            // 
            this.btnSetParameter.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSetParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSetParameter.Enabled = false;
            this.btnSetParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetParameter.Location = new System.Drawing.Point(117, 130);
            this.btnSetParameter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetParameter.Name = "btnSetParameter";
            this.btnSetParameter.Size = new System.Drawing.Size(96, 38);
            this.btnSetParameter.TabIndex = 7;
            this.btnSetParameter.Text = "Set";
            this.btnSetParameter.UseVisualStyleBackColor = true;
            this.btnSetParameter.Click += new System.EventHandler(this.btnSetParameter_Click);
            // 
            // btnGetParam
            // 
            this.btnGetParam.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGetParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGetParam.Enabled = false;
            this.btnGetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetParam.Location = new System.Drawing.Point(12, 130);
            this.btnGetParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetParam.Name = "btnGetParam";
            this.btnGetParam.Size = new System.Drawing.Size(96, 38);
            this.btnGetParam.TabIndex = 6;
            this.btnGetParam.Text = "Get";
            this.btnGetParam.UseVisualStyleBackColor = true;
            this.btnGetParam.Click += new System.EventHandler(this.btnGetParam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frame Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(78, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gain";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exposure Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edFrameRate
            // 
            this.edFrameRate.Enabled = false;
            this.edFrameRate.Location = new System.Drawing.Point(116, 74);
            this.edFrameRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edFrameRate.Name = "edFrameRate";
            this.edFrameRate.Size = new System.Drawing.Size(103, 22);
            this.edFrameRate.TabIndex = 2;
            this.edFrameRate.Text = "0";
            // 
            // edGain
            // 
            this.edGain.Enabled = false;
            this.edGain.Location = new System.Drawing.Point(116, 47);
            this.edGain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edGain.Name = "edGain";
            this.edGain.Size = new System.Drawing.Size(103, 22);
            this.edGain.TabIndex = 1;
            this.edGain.Text = "0";
            // 
            // edExposure
            // 
            this.edExposure.Enabled = false;
            this.edExposure.Location = new System.Drawing.Point(116, 20);
            this.edExposure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edExposure.Name = "edExposure";
            this.edExposure.Size = new System.Drawing.Size(103, 22);
            this.edExposure.TabIndex = 0;
            this.edExposure.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUpdateThread);
            this.groupBox2.Controls.Add(this.btnSoftTrigger);
            this.groupBox2.Controls.Add(this.chkSoftTrigger);
            this.groupBox2.Controls.Add(this.btnGrabStop);
            this.groupBox2.Controls.Add(this.btnGrabStart);
            this.groupBox2.Controls.Add(this.rdoTriggerMode);
            this.groupBox2.Controls.Add(this.rdoContinuesMode);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox2.Location = new System.Drawing.Point(253, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(231, 178);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Acquisition";
            // 
            // chkUpdateThread
            // 
            this.chkUpdateThread.AutoSize = true;
            this.chkUpdateThread.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkUpdateThread.Location = new System.Drawing.Point(19, 125);
            this.chkUpdateThread.Name = "chkUpdateThread";
            this.chkUpdateThread.Size = new System.Drawing.Size(70, 18);
            this.chkUpdateThread.TabIndex = 10;
            this.chkUpdateThread.Text = "화면 갱신";
            this.chkUpdateThread.UseVisualStyleBackColor = true;
            this.chkUpdateThread.CheckedChanged += new System.EventHandler(this.chkThreadEnabled_CheckedChanged);
            // 
            // btnSoftTrigger
            // 
            this.btnSoftTrigger.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSoftTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSoftTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSoftTrigger.Location = new System.Drawing.Point(118, 114);
            this.btnSoftTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSoftTrigger.Name = "btnSoftTrigger";
            this.btnSoftTrigger.Size = new System.Drawing.Size(96, 38);
            this.btnSoftTrigger.TabIndex = 8;
            this.btnSoftTrigger.Text = "Soft Trigger";
            this.btnSoftTrigger.UseVisualStyleBackColor = true;
            this.btnSoftTrigger.Click += new System.EventHandler(this.btnSoftTrigger_Click);
            // 
            // chkSoftTrigger
            // 
            this.chkSoftTrigger.AutoSize = true;
            this.chkSoftTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSoftTrigger.Location = new System.Drawing.Point(116, 42);
            this.chkSoftTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSoftTrigger.Name = "chkSoftTrigger";
            this.chkSoftTrigger.Size = new System.Drawing.Size(93, 18);
            this.chkSoftTrigger.TabIndex = 4;
            this.chkSoftTrigger.Text = "by Software";
            this.chkSoftTrigger.UseVisualStyleBackColor = true;
            this.chkSoftTrigger.CheckedChanged += new System.EventHandler(this.chkSoftTrigger_CheckedChanged);
            // 
            // btnGrabStop
            // 
            this.btnGrabStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGrabStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGrabStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGrabStop.Location = new System.Drawing.Point(118, 70);
            this.btnGrabStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabStop.Margin2 = 10;
            this.btnGrabStop.Name = "btnGrabStop";
            this.btnGrabStop.Size = new System.Drawing.Size(96, 38);
            this.btnGrabStop.TabIndex = 3;
            this.btnGrabStop.Text = "Grab Stop";
            this.btnGrabStop.UseVisualStyleBackColor = true;
            this.btnGrabStop.Click += new System.EventHandler(this.btnGrabStop_Click);
            // 
            // btnGrabStart
            // 
            this.btnGrabStart.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGrabStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGrabStart.Enabled = false;
            this.btnGrabStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGrabStart.Location = new System.Drawing.Point(12, 70);
            this.btnGrabStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabStart.Margin2 = 10;
            this.btnGrabStart.Name = "btnGrabStart";
            this.btnGrabStart.Size = new System.Drawing.Size(96, 38);
            this.btnGrabStart.TabIndex = 2;
            this.btnGrabStart.Text = "Grab Start";
            this.btnGrabStart.UseVisualStyleBackColor = true;
            this.btnGrabStart.Click += new System.EventHandler(this.btnGrabStart_Click);
            // 
            // rdoTriggerMode
            // 
            this.rdoTriggerMode.AutoSize = true;
            this.rdoTriggerMode.Enabled = false;
            this.rdoTriggerMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoTriggerMode.Location = new System.Drawing.Point(116, 20);
            this.rdoTriggerMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoTriggerMode.Name = "rdoTriggerMode";
            this.rdoTriggerMode.Size = new System.Drawing.Size(98, 18);
            this.rdoTriggerMode.TabIndex = 1;
            this.rdoTriggerMode.Text = "Trigger Mode";
            this.rdoTriggerMode.UseMnemonic = false;
            this.rdoTriggerMode.UseVisualStyleBackColor = true;
            this.rdoTriggerMode.CheckedChanged += new System.EventHandler(this.rdoTriggerMode_CheckedChanged);
            // 
            // rdoContinuesMode
            // 
            this.rdoContinuesMode.AutoSize = true;
            this.rdoContinuesMode.Checked = true;
            this.rdoContinuesMode.Enabled = false;
            this.rdoContinuesMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoContinuesMode.Location = new System.Drawing.Point(19, 20);
            this.rdoContinuesMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoContinuesMode.Name = "rdoContinuesMode";
            this.rdoContinuesMode.Size = new System.Drawing.Size(86, 18);
            this.rdoContinuesMode.TabIndex = 0;
            this.rdoContinuesMode.TabStop = true;
            this.rdoContinuesMode.Text = "Continuous";
            this.rdoContinuesMode.UseVisualStyleBackColor = true;
            this.rdoContinuesMode.CheckedChanged += new System.EventHandler(this.rdoContinuesMode_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 14);
            this.label7.TabIndex = 1434;
            this.label7.Text = "Camera List";
            // 
            // UpdateThread1
            // 
            this.UpdateThread1.Enabled = false;
            this.UpdateThread1.Interval = 100;
            // 
            // UpdateThread2
            // 
            this.UpdateThread2.Enabled = false;
            this.UpdateThread2.Interval = 100;
            // 
            // btnSaveBmp
            // 
            this.btnSaveBmp.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSaveBmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSaveBmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveBmp.Location = new System.Drawing.Point(388, 60);
            this.btnSaveBmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveBmp.Name = "btnSaveBmp";
            this.btnSaveBmp.Size = new System.Drawing.Size(96, 38);
            this.btnSaveBmp.TabIndex = 1435;
            this.btnSaveBmp.Text = "to BMP";
            this.btnSaveBmp.UseVisualStyleBackColor = true;
            this.btnSaveBmp.Click += new System.EventHandler(this.btnSaveBmp_Click);
            // 
            // frmMVS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(496, 309);
            this.Controls.Add(this.btnSaveBmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGetCameraList);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMVS";
            this.Text = "MVS Camera Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public YujinTechnology.BitBtn btnDisconnect;
        public YujinTechnology.LEDButton btnConnect;
        private YujinTechnology.BitBtn btnGetCameraList;
        public System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbPixelFormat;
        private System.Windows.Forms.Label label4;
        private YujinTechnology.BitBtn btnSetParameter;
        private YujinTechnology.BitBtn btnGetParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edFrameRate;
        private System.Windows.Forms.TextBox edGain;
        private System.Windows.Forms.TextBox edExposure;
        private System.Windows.Forms.GroupBox groupBox2;
        public YujinTechnology.BitBtn btnSoftTrigger;
        public YujinTechnology.LEDButton btnGrabStop;
        public YujinTechnology.LEDButton btnGrabStart;
        public System.Windows.Forms.CheckBox chkUpdateThread;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox chkSoftTrigger;
        public System.Windows.Forms.RadioButton rdoTriggerMode;
        public System.Windows.Forms.RadioButton rdoContinuesMode;
        public YujinTechnology.Thread UpdateThread1;
        public YujinTechnology.Thread UpdateThread2;
        private YujinTechnology.BitBtn btnSaveBmp;
    }
}