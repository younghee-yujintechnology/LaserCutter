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
            this.panClient = new yjTech.Panel();
            this.gradientLabel1 = new yjTech.GradientLabel();
            this.btnClose = new yjTech.BitBtn();
            this.btnOpenJobFile = new yjTech.BitBtn();
            this.tabControl1 = new yjTech.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblGroupName = new yjTech.Label();
            this.lblModelName = new yjTech.Label();
            this.panClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.gradientLabel1);
            this.panClient.Controls.Add(this.btnClose);
            this.panClient.Controls.Add(this.btnOpenJobFile);
            this.panClient.Controls.Add(this.tabControl1);
            this.panClient.Controls.Add(this.lblGroupName);
            this.panClient.Controls.Add(this.lblModelName);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.FrameInner.Visible = false;
            this.panClient.FrameOuter.Visible = false;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1203, 799);
            this.panClient.TabIndex = 1141;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gradientLabel1.Frame.Visible = false;
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(8, 6);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.ShowAccelChar = false;
            this.gradientLabel1.Size = new System.Drawing.Size(95, 26);
            this.gradientLabel1.TabIndex = 797;
            this.gradientLabel1.Text = "Job File:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1134, 8);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 28);
            this.btnClose.TabIndex = 796;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnOpenJobFile
            // 
            this.btnOpenJobFile.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOpenJobFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOpenJobFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenJobFile.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpenJobFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenJobFile.Location = new System.Drawing.Point(1068, 8);
            this.btnOpenJobFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenJobFile.Name = "btnOpenJobFile";
            this.btnOpenJobFile.Size = new System.Drawing.Size(64, 28);
            this.btnOpenJobFile.TabIndex = 646;
            this.btnOpenJobFile.Text = "Open";
            this.btnOpenJobFile.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(4, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.ShowActiveCloseButton = false;
            this.tabControl1.ShowCloseButton = false;
            this.tabControl1.Size = new System.Drawing.Size(1193, 756);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabSelectedColor = System.Drawing.Color.Yellow;
            this.tabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabControl1.TabSelectedHighColorSize = 4;
            this.tabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tabControl1.TabVisible = true;
            this.tabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabControl1.TipsColor = System.Drawing.Color.Red;
            this.tabControl1.TipsFont = new System.Drawing.Font("Tahoma", 9F);
            this.tabControl1.TipsForeColor = System.Drawing.Color.White;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1185, 718);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DXF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1185, 718);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DXF Array";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1185, 718);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Make Cell";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblGroupName
            // 
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblGroupName.ForeColor = System.Drawing.Color.Black;
            this.lblGroupName.Frame.Left = false;
            this.lblGroupName.Frame.Right = false;
            this.lblGroupName.Frame.Top = false;
            this.lblGroupName.Location = new System.Drawing.Point(104, 9);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.ShowAccelChar = false;
            this.lblGroupName.Size = new System.Drawing.Size(296, 26);
            this.lblGroupName.TabIndex = 798;
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelName
            // 
            this.lblModelName.BackColor = System.Drawing.Color.Transparent;
            this.lblModelName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblModelName.ForeColor = System.Drawing.Color.Black;
            this.lblModelName.Frame.Left = false;
            this.lblModelName.Frame.Right = false;
            this.lblModelName.Frame.Top = false;
            this.lblModelName.Location = new System.Drawing.Point(406, 9);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.ShowAccelChar = false;
            this.lblModelName.Size = new System.Drawing.Size(651, 26);
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
            this.Size = new System.Drawing.Size(1203, 799);
            this.panClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private yjTech.Panel panClient;
        private yjTech.TabControl tabControl1;
        private yjTech.GradientLabel gradientLabel1;
        public yjTech.BitBtn btnOpenJobFile;
        public yjTech.BitBtn btnClose;
        public yjTech.Label lblModelName;
        public yjTech.Label lblGroupName;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
