namespace LaserCutter
{
    partial class frmVision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVision));
            this.panTop = new YujinTechnology.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new YujinTechnology.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateTime = new YujinTechnology.Label();
            this.panEqpTitle = new YujinTechnology.GradientPanel();
            this.lblVersion = new YujinTechnology.Label();
            this.lblTitle = new YujinTechnology.GradientLabel();
            this.gradLabel14 = new YujinTechnology.GradientLabel();
            this.panClient = new YujinTechnology.Panel();
            this.AutoThread = new YujinTechnology.Thread();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panEqpTitle.SuspendLayout();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
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
            this.metroPanel1.Controls.Add(this.lblStatus);
            this.metroPanel1.Controls.Add(this.lblUser);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.lblDateTime);
            this.metroPanel1.FrameInner.Visible = false;
            this.metroPanel1.FrameOuter.Visible = false;
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Name = "metroPanel1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
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
            this.lblDateTime.CaptionStyle.ShadowDepth = 2;
            this.lblDateTime.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblDateTime.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Name = "lblDateTime";
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
            this.panEqpTitle.Controls.Add(this.lblTitle);
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
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Frame.Visible = false;
            this.lblVersion.Name = "lblVersion";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblTitle.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblTitle.CaptionStyle.ShadowDepth = 3;
            this.lblTitle.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.lblTitle.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblTitle.CausesValidation = false;
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Frame.Visible = false;
            this.lblTitle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.DoubleClick += new System.EventHandler(this.lblMainTitle_DoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMainTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMainTitle_MouseMove);
            // 
            // gradLabel14
            // 
            this.gradLabel14.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.gradLabel14, "gradLabel14");
            this.gradLabel14.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel14.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel14.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gradLabel14.Name = "gradLabel14";
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.gradLabel14);
            resources.ApplyResources(this.panClient, "panClient");
            this.panClient.FrameInner.Visible = false;
            this.panClient.FrameOuter.Visible = false;
            this.panClient.Name = "panClient";
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = true;
            this.AutoThread.Interval = 100;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // frmVision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panClient);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmVision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVision_FormClosing);
            this.panTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.panEqpTitle.ResumeLayout(false);
            this.panClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private YujinTechnology.Panel panTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private YujinTechnology.Panel metroPanel1;
        private YujinTechnology.GradientPanel panEqpTitle;
        private YujinTechnology.GradientLabel gradLabel14;
        private YujinTechnology.Panel panClient;
        private YujinTechnology.Thread AutoThread;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private YujinTechnology.Label lblDateTime;
        private YujinTechnology.Label lblVersion;
        private System.Windows.Forms.Label lblStatus;
        public YujinTechnology.GradientLabel lblTitle;
    }
}

