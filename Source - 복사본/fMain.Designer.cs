namespace LaserCutter
{
    partial class frmMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panBottom = new YujinTechnology.GradientPanel();
            this.lblSelectedMenu = new System.Windows.Forms.Label();
            this.btnVietnam = new System.Windows.Forms.Button();
            this.btnKorea = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnAuto = new YujinTechnology.BitBtn();
            this.btnManual = new YujinTechnology.BitBtn();
            this.btnConfig = new YujinTechnology.BitBtn();
            this.btnAlarm = new YujinTechnology.BitBtn();
            this.btnJobFile = new YujinTechnology.BitBtn();
            this.btnVision = new YujinTechnology.BitBtn();
            this.btnLog = new YujinTechnology.BitBtn();
            this.btnExit = new YujinTechnology.BitBtn();
            this.panTop = new YujinTechnology.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new YujinTechnology.Panel();
            this.btnLogIn = new YujinTechnology.BitBtn();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateTime = new YujinTechnology.Label();
            this.panEqpTitle = new YujinTechnology.GradientPanel();
            this.lblVersion = new YujinTechnology.Label();
            this.lblBuildVersion = new YujinTechnology.Label();
            this.lblMainTitle = new YujinTechnology.GradientLabel();
            this.AutoThread = new YujinTechnology.Thread();
            this.panRight = new System.Windows.Forms.Panel();
            this.panClient = new System.Windows.Forms.Panel();
            this.panBottom.SuspendLayout();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panEqpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.lblSelectedMenu);
            this.panBottom.Controls.Add(this.btnVietnam);
            this.panBottom.Controls.Add(this.btnKorea);
            this.panBottom.Controls.Add(this.btnEnglish);
            this.panBottom.Controls.Add(this.btnAuto);
            this.panBottom.Controls.Add(this.btnManual);
            this.panBottom.Controls.Add(this.btnConfig);
            this.panBottom.Controls.Add(this.btnAlarm);
            this.panBottom.Controls.Add(this.btnJobFile);
            this.panBottom.Controls.Add(this.btnVision);
            this.panBottom.Controls.Add(this.btnLog);
            this.panBottom.Controls.Add(this.btnExit);
            resources.ApplyResources(this.panBottom, "panBottom");
            this.panBottom.FrameInner.Visible = false;
            this.panBottom.FrameOuter.Visible = false;
            this.panBottom.GradientEnable = true;
            this.panBottom.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.panBottom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panBottom.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.panBottom.Name = "panBottom";
            // 
            // lblSelectedMenu
            // 
            this.lblSelectedMenu.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.lblSelectedMenu, "lblSelectedMenu");
            this.lblSelectedMenu.ForeColor = System.Drawing.Color.White;
            this.lblSelectedMenu.Name = "lblSelectedMenu";
            // 
            // btnVietnam
            // 
            resources.ApplyResources(this.btnVietnam, "btnVietnam");
            this.btnVietnam.Name = "btnVietnam";
            this.btnVietnam.UseVisualStyleBackColor = true;
            this.btnVietnam.Click += new System.EventHandler(this.btnVietnam_Click);
            // 
            // btnKorea
            // 
            resources.ApplyResources(this.btnKorea, "btnKorea");
            this.btnKorea.Name = "btnKorea";
            this.btnKorea.UseVisualStyleBackColor = true;
            this.btnKorea.Click += new System.EventHandler(this.btnKorea_Click);
            // 
            // btnEnglish
            // 
            resources.ApplyResources(this.btnEnglish, "btnEnglish");
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAuto.BackColor = System.Drawing.Color.Transparent;
            this.btnAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAuto, "btnAuto");
            this.btnAuto.ForeColor = System.Drawing.Color.Black;
            this.btnAuto.Margin2 = 10;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Tag = "10";
            this.btnAuto.UseVisualStyleBackColor = false;
            // 
            // btnManual
            // 
            this.btnManual.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnManual.BackColor = System.Drawing.Color.Wheat;
            this.btnManual.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnManual, "btnManual");
            this.btnManual.ForeColor = System.Drawing.Color.Black;
            this.btnManual.Name = "btnManual";
            this.btnManual.Tag = "11";
            this.btnManual.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnConfig, "btnConfig");
            this.btnConfig.ForeColor = System.Drawing.Color.Black;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Tag = "12";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnAlarm
            // 
            this.btnAlarm.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAlarm.BackColor = System.Drawing.Color.Transparent;
            this.btnAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAlarm, "btnAlarm");
            this.btnAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAlarm.Image = global::LaserCutter.Properties.Resources.Alarm;
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Tag = "13";
            this.btnAlarm.UseVisualStyleBackColor = false;
            // 
            // btnJobFile
            // 
            this.btnJobFile.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnJobFile.BackColor = System.Drawing.Color.Transparent;
            this.btnJobFile.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnJobFile, "btnJobFile");
            this.btnJobFile.ForeColor = System.Drawing.Color.Black;
            this.btnJobFile.Margin2 = 10;
            this.btnJobFile.Name = "btnJobFile";
            this.btnJobFile.Tag = "14";
            this.btnJobFile.UseVisualStyleBackColor = false;
            // 
            // btnVision
            // 
            this.btnVision.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnVision.BackColor = System.Drawing.Color.Transparent;
            this.btnVision.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnVision, "btnVision");
            this.btnVision.ForeColor = System.Drawing.Color.Black;
            this.btnVision.Name = "btnVision";
            this.btnVision.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            this.btnLog.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLog, "btnLog");
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Image = global::LaserCutter.Properties.Resources.Log;
            this.btnLog.Name = "btnLog";
            this.btnLog.Tag = "16";
            this.btnLog.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Name = "btnExit";
            this.btnExit.Tag = "17";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTop.Controls.Add(this.pictureBox1);
            this.panTop.Controls.Add(this.metroPanel1);
            this.panTop.Controls.Add(this.panEqpTitle);
            resources.ApplyResources(this.panTop, "panTop");
            this.panTop.FrameInner.Visible = false;
            this.panTop.Name = "panTop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.btnLogIn);
            this.metroPanel1.Controls.Add(this.lblUser);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.lblDateTime);
            this.metroPanel1.FrameInner.Visible = false;
            this.metroPanel1.FrameOuter.Visible = false;
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Name = "metroPanel1";
            // 
            // btnLogIn
            // 
            this.btnLogIn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Image = global::LaserCutter.Properties.Resources.LogN;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Tag = "20";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.LightGray;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Name = "lblUser";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.LightGray;
            this.lblDateTime.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblDateTime.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblDateTime.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblDateTime.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.ShowAccelChar = false;
            // 
            // panEqpTitle
            // 
            this.panEqpTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panEqpTitle.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.panEqpTitle.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.panEqpTitle.CaptionStyle.ShadowDepth = 3;
            this.panEqpTitle.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.panEqpTitle.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.panEqpTitle.Controls.Add(this.lblVersion);
            this.panEqpTitle.Controls.Add(this.lblBuildVersion);
            this.panEqpTitle.Controls.Add(this.lblMainTitle);
            resources.ApplyResources(this.panEqpTitle, "panEqpTitle");
            this.panEqpTitle.GradientEnable = true;
            this.panEqpTitle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.panEqpTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panEqpTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.panEqpTitle.Name = "panEqpTitle";
            this.panEqpTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblVersion.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblVersion.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblVersion.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.ForeColor = System.Drawing.Color.Red;
            this.lblVersion.Frame.Visible = false;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.ShowAccelChar = false;
            // 
            // lblBuildVersion
            // 
            this.lblBuildVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildVersion.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuildVersion.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblBuildVersion.CaptionStyle.ShadowDepth = 2;
            this.lblBuildVersion.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblBuildVersion.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            resources.ApplyResources(this.lblBuildVersion, "lblBuildVersion");
            this.lblBuildVersion.ForeColor = System.Drawing.Color.Gold;
            this.lblBuildVersion.Frame.Visible = false;
            this.lblBuildVersion.Name = "lblBuildVersion";
            this.lblBuildVersion.ShowAccelChar = false;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblMainTitle.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblMainTitle.CaptionStyle.ShadowDepth = 3;
            this.lblMainTitle.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblMainTitle.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblMainTitle.CausesValidation = false;
            resources.ApplyResources(this.lblMainTitle, "lblMainTitle");
            this.lblMainTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblMainTitle.Frame.Visible = false;
            this.lblMainTitle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblMainTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblMainTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.ShowAccelChar = false;
            this.lblMainTitle.DoubleClick += new System.EventHandler(this.lblMainTitle_DoubleClick);
            this.lblMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMainTitle_MouseDown);
            this.lblMainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMainTitle_MouseMove);
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = false;
            this.AutoThread.Interval = 100;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // panRight
            // 
            resources.ApplyResources(this.panRight, "panRight");
            this.panRight.Name = "panRight";
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.panClient, "panClient");
            this.panClient.Name = "panClient";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panClient);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panBottom.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.panEqpTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private YujinTechnology.GradientPanel panBottom;
        private YujinTechnology.Panel panTop;
        private System.Windows.Forms.Label lblSelectedMenu;
        private YujinTechnology.BitBtn btnAuto;
        private YujinTechnology.BitBtn btnAlarm;
        private YujinTechnology.BitBtn btnManual;
        private YujinTechnology.Thread AutoThread;
        private YujinTechnology.Panel metroPanel1;
        private YujinTechnology.Label lblDateTime;
        private YujinTechnology.GradientPanel panEqpTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private YujinTechnology.Label lblBuildVersion;
        private System.Windows.Forms.Button btnVietnam;
        private System.Windows.Forms.Button btnKorea;
        private System.Windows.Forms.Button btnEnglish;
        public System.Windows.Forms.Panel panClient;
        public YujinTechnology.GradientLabel lblMainTitle;
        private YujinTechnology.Label lblVersion;
        private YujinTechnology.BitBtn btnJobFile;
        private YujinTechnology.BitBtn btnConfig;
        private YujinTechnology.BitBtn btnExit;
        private YujinTechnology.BitBtn btnLog;
        private YujinTechnology.BitBtn btnVision;
        private YujinTechnology.BitBtn btnLogIn;
    }
}

