namespace LaserCutter
{
    partial class frmRestart
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
            this.lblMessage = new YujinTechnology.Label();
            this.btnStart = new YujinTechnology.BitBtn();
            this.btnStop = new YujinTechnology.BitBtn();
            this.AutoThread = new YujinTechnology.Thread();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.LightGray;
            this.lblMessage.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblMessage.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 23F);
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(14, 8);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(498, 77);
            this.lblMessage.TabIndex = 1773;
            this.lblMessage.Text = "자동 운전 중입니다.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnStart.Location = new System.Drawing.Point(145, 105);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 52);
            this.btnStart.TabIndex = 1772;
            this.btnStart.Text = "Re-Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnStop.Location = new System.Drawing.Point(263, 105);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 52);
            this.btnStop.TabIndex = 1771;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = false;
            this.AutoThread.Interval = 100;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // frmRestart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(521, 170);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestart";
            this.Text = "Re-Start";
            this.Load += new System.EventHandler(this.frmTable1Restart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public YujinTechnology.Label lblMessage;
        private YujinTechnology.BitBtn btnStart;
        private YujinTechnology.BitBtn btnStop;
        public YujinTechnology.Thread AutoThread;
    }
}