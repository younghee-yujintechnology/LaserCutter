namespace LaserCutter
{
    partial class frmAlarm
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
            this.txbContent = new System.Windows.Forms.TextBox();
            this.lblTitle = new DaekhonSystem.GradientLabel();
            this.btOk = new DaekhonSystem.BitBtn();
            this.lblBottom = new DaekhonSystem.GradientLabel();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // txbContent
            // 
            this.txbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.txbContent.Font = new System.Drawing.Font("굴림", 9F);
            this.txbContent.Location = new System.Drawing.Point(2, 62);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.ReadOnly = true;
            this.txbContent.Size = new System.Drawing.Size(482, 236);
            this.txbContent.TabIndex = 2;
            this.txbContent.Text = "알람코드";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 9F);
            this.lblTitle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 57);
            this.lblTitle.TabIndex = 786;
            this.lblTitle.TabStop = false;
            this.lblTitle.Text = "알람명";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOk
            // 
            this.btOk.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.btOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOk.Font = new System.Drawing.Font("굴림", 9F);
            this.btOk.ForeColor = System.Drawing.Color.Black;
            this.btOk.Location = new System.Drawing.Point(109, 306);
            this.btOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(255, 65);
            this.btOk.TabIndex = 887;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.Transparent;
            this.lblBottom.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblBottom.Font = new System.Drawing.Font("굴림", 9F);
            this.lblBottom.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblBottom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblBottom.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblBottom.Location = new System.Drawing.Point(2, 301);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(482, 75);
            this.lblBottom.TabIndex = 886;
            this.lblBottom.TabStop = false;
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbContent;
        private DaekhonSystem.GradientLabel lblTitle;
        private DaekhonSystem.BitBtn btOk;
        private DaekhonSystem.GradientLabel lblBottom;
        private System.Windows.Forms.Timer timer1;
    }
}