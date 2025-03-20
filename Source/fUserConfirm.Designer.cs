namespace LaserCutter
{
    partial class frmUserConfirm
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
            this.btnOK = new YujinTechnology.BitBtn();
            this.btnCancel = new YujinTechnology.BitBtn();
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
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(504, 165);
            this.lblMessage.TabIndex = 787;
            this.lblMessage.Text = "자동 운전 중입니다.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(164, 188);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 45);
            this.btnOK.TabIndex = 1536;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(265, 188);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 45);
            this.btnCancel.TabIndex = 1537;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = true;
            this.AutoThread.Interval = 250;
            this.AutoThread.OnExecute += new System.EventHandler(this.AutoThread_OnExecute);
            // 
            // frmUserConfirm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(528, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserConfirm";
            this.Text = "UserConfirm";
            this.ResumeLayout(false);

        }

        #endregion

        public YujinTechnology.Label lblMessage;
        private YujinTechnology.BitBtn btnOK;
        private YujinTechnology.BitBtn btnCancel;
        private YujinTechnology.Thread AutoThread;
    }
}