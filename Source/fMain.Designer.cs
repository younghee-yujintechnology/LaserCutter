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
            this.panClient = new System.Windows.Forms.Panel();
            this.lblSelectedMenu = new System.Windows.Forms.Label();
            this.btnManual = new yjTech.BitBtn();
            this.bitBtn1 = new yjTech.BitBtn();
            this.bitBtn6 = new yjTech.BitBtn();
            this.bitBtn5 = new yjTech.BitBtn();
            this.bitBtn4 = new yjTech.BitBtn();
            this.btnExit = new yjTech.BitBtn();
            this.btnLog = new yjTech.BitBtn();
            this.btnVision = new yjTech.BitBtn();
            this.btnJobFile = new yjTech.BitBtn();
            this.btnAuto = new yjTech.BitBtn();
            this.panTop = new yjTech.Panel();
            this.lblMainTitle = new yjTech.GradientLabel();
            this.lblBuildVersion = new yjTech.Label();
            this.lblDateTime = new yjTech.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AutoThread = new yjTech.Thread();
            this.bitBtn2 = new yjTech.BitBtn();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.panClient, "panClient");
            this.panClient.Name = "panClient";
            // 
            // lblSelectedMenu
            // 
            this.lblSelectedMenu.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.lblSelectedMenu, "lblSelectedMenu");
            this.lblSelectedMenu.ForeColor = System.Drawing.Color.White;
            this.lblSelectedMenu.Name = "lblSelectedMenu";
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
            // bitBtn1
            // 
            this.bitBtn1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn1.BackColor = System.Drawing.Color.Transparent;
            this.bitBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bitBtn1, "bitBtn1");
            this.bitBtn1.ForeColor = System.Drawing.Color.Black;
            this.bitBtn1.Margin2 = 10;
            this.bitBtn1.Name = "bitBtn1";
            this.bitBtn1.Tag = "10";
            this.bitBtn1.UseVisualStyleBackColor = false;
            // 
            // bitBtn6
            // 
            this.bitBtn6.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn6.BackColor = System.Drawing.Color.Transparent;
            this.bitBtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bitBtn6, "bitBtn6");
            this.bitBtn6.ForeColor = System.Drawing.Color.Black;
            this.bitBtn6.Margin2 = 10;
            this.bitBtn6.Name = "bitBtn6";
            this.bitBtn6.Tag = "10";
            this.bitBtn6.UseVisualStyleBackColor = false;
            // 
            // bitBtn5
            // 
            this.bitBtn5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn5.BackColor = System.Drawing.Color.Transparent;
            this.bitBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bitBtn5, "bitBtn5");
            this.bitBtn5.ForeColor = System.Drawing.Color.Black;
            this.bitBtn5.Margin2 = 10;
            this.bitBtn5.Name = "bitBtn5";
            this.bitBtn5.Tag = "10";
            this.bitBtn5.UseVisualStyleBackColor = false;
            // 
            // bitBtn4
            // 
            this.bitBtn4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn4.BackColor = System.Drawing.Color.Transparent;
            this.bitBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bitBtn4, "bitBtn4");
            this.bitBtn4.ForeColor = System.Drawing.Color.Black;
            this.bitBtn4.Margin2 = 10;
            this.bitBtn4.Name = "bitBtn4";
            this.bitBtn4.Tag = "10";
            this.bitBtn4.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Margin2 = 10;
            this.btnExit.Name = "btnExit";
            this.btnExit.Tag = "17";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTop.Controls.Add(this.lblMainTitle);
            this.panTop.Controls.Add(this.lblBuildVersion);
            this.panTop.Controls.Add(this.lblDateTime);
            this.panTop.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panTop, "panTop");
            this.panTop.FrameInner.Visible = false;
            this.panTop.FrameOuter.Visible = false;
            this.panTop.Name = "panTop";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblMainTitle.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblMainTitle.CaptionStyle.ShadowDepth = 3;
            this.lblMainTitle.CaptionStyle.ShadowDirection = yjTech.ShadowDirection.BottomRight;
            this.lblMainTitle.CaptionStyle.TextStyle = yjTech.TextStyle.Shadow;
            this.lblMainTitle.CausesValidation = false;
            resources.ApplyResources(this.lblMainTitle, "lblMainTitle");
            this.lblMainTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblMainTitle.Frame.Visible = false;
            this.lblMainTitle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblMainTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblMainTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.ShowAccelChar = false;
            // 
            // lblBuildVersion
            // 
            this.lblBuildVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildVersion.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuildVersion.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblBuildVersion.CaptionStyle.ShadowDirection = yjTech.ShadowDirection.BottomRight;
            this.lblBuildVersion.CaptionStyle.TextStyle = yjTech.TextStyle.Shadow;
            resources.ApplyResources(this.lblBuildVersion, "lblBuildVersion");
            this.lblBuildVersion.ForeColor = System.Drawing.Color.Gold;
            this.lblBuildVersion.Frame.Visible = false;
            this.lblBuildVersion.Name = "lblBuildVersion";
            this.lblBuildVersion.ShowAccelChar = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.CaptionStyle.OutlineFillColor = System.Drawing.Color.WhiteSmoke;
            this.lblDateTime.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblDateTime.CaptionStyle.ShadowDirection = yjTech.ShadowDirection.BottomRight;
            this.lblDateTime.CaptionStyle.TextStyle = yjTech.TextStyle.Shadow;
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Frame.Visible = false;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.ShowAccelChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = false;
            this.AutoThread.Interval = 100;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // bitBtn2
            // 
            this.bitBtn2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn2.BackColor = System.Drawing.Color.Transparent;
            this.bitBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bitBtn2, "bitBtn2");
            this.bitBtn2.ForeColor = System.Drawing.Color.Black;
            this.bitBtn2.Margin2 = 10;
            this.bitBtn2.Name = "bitBtn2";
            this.bitBtn2.Tag = "10";
            this.bitBtn2.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblSelectedMenu);
            this.Controls.Add(this.bitBtn1);
            this.Controls.Add(this.bitBtn6);
            this.Controls.Add(this.bitBtn5);
            this.Controls.Add(this.bitBtn4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnVision);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panClient);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.bitBtn2);
            this.Controls.Add(this.btnJobFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private yjTech.Thread AutoThread;
        public System.Windows.Forms.Panel panClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectedMenu;
        private yjTech.BitBtn btnAuto;
        private yjTech.BitBtn btnJobFile;
        private yjTech.BitBtn btnVision;
        private yjTech.BitBtn btnLog;
        private yjTech.BitBtn btnExit;
        private yjTech.BitBtn bitBtn4;
        private yjTech.BitBtn bitBtn5;
        private yjTech.BitBtn bitBtn6;
        private yjTech.Panel panTop;
        private yjTech.BitBtn bitBtn1;
        private yjTech.Label lblBuildVersion;
        private yjTech.Label lblDateTime;
        public yjTech.GradientLabel lblMainTitle;
        private yjTech.BitBtn btnManual;
        private yjTech.BitBtn bitBtn2;
    }
}

