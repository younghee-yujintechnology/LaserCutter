namespace LaserCutter
{
    partial class panTable
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panClient = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGroupName = new DaekhonSystem.Label();
            this.gradientLabel1 = new DaekhonSystem.GradientLabel();
            this.btnClose = new DaekhonSystem.BitBtn();
            this.btnOpenJobFile = new DaekhonSystem.BitBtn();
            this.lblModelName = new DaekhonSystem.Label();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.label1);
            this.panClient.Controls.Add(this.lblGroupName);
            this.panClient.Controls.Add(this.gradientLabel1);
            this.panClient.Controls.Add(this.btnClose);
            this.panClient.Controls.Add(this.btnOpenJobFile);
            this.panClient.Controls.Add(this.lblModelName);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1195, 800);
            this.panClient.TabIndex = 1141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.label1.Location = new System.Drawing.Point(396, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 801;
            this.label1.Text = "\\";
            // 
            // lblGroupName
            // 
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblGroupName.ForeColor = System.Drawing.Color.Black;
            this.lblGroupName.Frame.Left = false;
            this.lblGroupName.Frame.Right = false;
            this.lblGroupName.Frame.Top = false;
            this.lblGroupName.Location = new System.Drawing.Point(104, 3);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.ShowAccelChar = false;
            this.lblGroupName.Size = new System.Drawing.Size(296, 30);
            this.lblGroupName.TabIndex = 798;
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(3, 3);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.ShowAccelChar = false;
            this.gradientLabel1.Size = new System.Drawing.Size(95, 30);
            this.gradientLabel1.TabIndex = 797;
            this.gradientLabel1.Text = "Job File";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1125, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 28);
            this.btnClose.TabIndex = 796;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenJobFile
            // 
            this.btnOpenJobFile.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOpenJobFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOpenJobFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenJobFile.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpenJobFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenJobFile.Location = new System.Drawing.Point(1059, 4);
            this.btnOpenJobFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenJobFile.Name = "btnOpenJobFile";
            this.btnOpenJobFile.Size = new System.Drawing.Size(64, 28);
            this.btnOpenJobFile.TabIndex = 646;
            this.btnOpenJobFile.Text = "Open";
            this.btnOpenJobFile.UseVisualStyleBackColor = false;
            this.btnOpenJobFile.Click += new System.EventHandler(this.btnOpenJobFile_Click);
            // 
            // lblModelName
            // 
            this.lblModelName.BackColor = System.Drawing.Color.Transparent;
            this.lblModelName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblModelName.ForeColor = System.Drawing.Color.Black;
            this.lblModelName.Frame.Left = false;
            this.lblModelName.Frame.Right = false;
            this.lblModelName.Frame.Top = false;
            this.lblModelName.Location = new System.Drawing.Point(406, 3);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.ShowAccelChar = false;
            this.lblModelName.Size = new System.Drawing.Size(651, 30);
            this.lblModelName.TabIndex = 33;
            this.lblModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Name = "panTable";
            this.Size = new System.Drawing.Size(1195, 800);
            this.panClient.ResumeLayout(false);
            this.panClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panClient;
        private DaekhonSystem.GradientLabel gradientLabel1;
        private System.Windows.Forms.Label label1;
        public DaekhonSystem.BitBtn btnOpenJobFile;
        public DaekhonSystem.BitBtn btnClose;
        public DaekhonSystem.Label lblModelName;
        public DaekhonSystem.Label lblGroupName;
    }
}
