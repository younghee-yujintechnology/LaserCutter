namespace LaserCutter
{
    partial class frmRunStatus
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
            this.AutoThread = new YujinTechnology.Thread();
            this.btnStop = new YujinTechnology.BitBtn();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.LightGray;
            this.lblMessage.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.lblMessage.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 23F);
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(547, 116);
            this.lblMessage.TabIndex = 786;
            this.lblMessage.Text = "자동 운전 중입니다.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = true;
            this.AutoThread.Interval = 250;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // btnStop
            // 
            this.btnStop.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnStop.Location = new System.Drawing.Point(230, 137);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 42);
            this.btnStop.TabIndex = 1766;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmRunStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(571, 193);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRunStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunStatus";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public YujinTechnology.Label lblMessage;
        private YujinTechnology.Thread AutoThread;
        private YujinTechnology.BitBtn btnStop;
    }
}