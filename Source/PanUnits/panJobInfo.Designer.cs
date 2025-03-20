using Raize.CodeSiteLogging;

namespace LaserCutter
{
    partial class panJobInfo
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
            // yhbyun logger.SendMsg("panJobInfo.Dispose()");

            if (disposing)

            {
                // panJobType1, panJobType2, panJobType3 객체들 해제
                if (Type1 != null)
                {
                    Type1.Dispose();
                    Type1 = null;
                }

                if (Type2 != null)
                {
                    Type2.Dispose();
                    Type2 = null;
                }

                if (Type3 != null)
                {
                    Type3.Dispose();
                    Type3 = null;
                }

                // Designer에서 생성된 components 해제
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.panClient = new YujinTechnology.Panel();
            this.TabControl2 = new YujinTechnology.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panClient.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.Controls.Add(this.TabControl2);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.FrameInner.Visible = false;
            this.panClient.FrameOuter.Visible = false;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1187, 759);
            this.panClient.TabIndex = 1379;
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.tabPage1);
            this.TabControl2.Controls.Add(this.tabPage2);
            this.TabControl2.Controls.Add(this.tabPage3);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl2.ItemSize = new System.Drawing.Size(150, 30);
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl2.Multiline = true;
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.Padding = new System.Drawing.Point(10, 3);
            this.TabControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.ShowActiveCloseButton = false;
            this.TabControl2.ShowCloseButton = false;
            this.TabControl2.Size = new System.Drawing.Size(1187, 759);
            this.TabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl2.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TabControl2.TabIndex = 1424;
            this.TabControl2.TabSelectedColor = System.Drawing.Color.Yellow;
            this.TabControl2.TabSelectedForeColor = System.Drawing.Color.Black;
            this.TabControl2.TabSelectedHighColor = System.Drawing.Color.Red;
            this.TabControl2.TabSelectedHighColorSize = 4;
            this.TabControl2.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.TabControl2.TabVisible = true;
            this.TabControl2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TabControl2.TipsColor = System.Drawing.Color.Red;
            this.TabControl2.TipsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl2.TipsForeColor = System.Drawing.Color.White;
            this.TabControl2.SelectedIndexChanged += new System.EventHandler(this.TabControl2_SelectedIndexChanged);
            this.TabControl2.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl2_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1179, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DXF";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1186, 721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DXF Array";
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1186, 721);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Make Cell";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panJobInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobInfo";
            this.Size = new System.Drawing.Size(1187, 759);
            this.panClient.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private YujinTechnology.Panel panClient;
        public YujinTechnology.TabControl TabControl2;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
    }
}
