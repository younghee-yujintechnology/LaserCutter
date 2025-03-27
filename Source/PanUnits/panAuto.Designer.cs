namespace LaserCutter
{
    partial class panAuto
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
            this.AutoThread = new yjTech.Thread();
            this.tabControl1 = new yjTech.TabControl();
            this.tabTable1 = new System.Windows.Forms.TabPage();
            this.tabTable2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoThread
            // 
            this.AutoThread.Enabled = true;
            this.AutoThread.Interval = 250;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTable1);
            this.tabControl1.Controls.Add(this.tabTable2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tabControl1.ItemSize = new System.Drawing.Size(590, 36);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.ShowActiveCloseButton = false;
            this.tabControl1.ShowCloseButton = false;
            this.tabControl1.Size = new System.Drawing.Size(1216, 848);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabSelectedColor = System.Drawing.Color.Lime;
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
            // tabTable1
            // 
            this.tabTable1.Location = new System.Drawing.Point(4, 40);
            this.tabTable1.Name = "tabTable1";
            this.tabTable1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable1.Size = new System.Drawing.Size(1208, 804);
            this.tabTable1.TabIndex = 0;
            this.tabTable1.Text = "Tabel #1";
            this.tabTable1.UseVisualStyleBackColor = true;
            // 
            // tabTable2
            // 
            this.tabTable2.Location = new System.Drawing.Point(4, 40);
            this.tabTable2.Name = "tabTable2";
            this.tabTable2.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable2.Size = new System.Drawing.Size(1213, 800);
            this.tabTable2.TabIndex = 1;
            this.tabTable2.Text = "Tabel #2";
            this.tabTable2.UseVisualStyleBackColor = true;
            // 
            // panAuto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "panAuto";
            this.Size = new System.Drawing.Size(1913, 855);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public yjTech.Thread AutoThread;
        private yjTech.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTable1;
        private System.Windows.Forms.TabPage tabTable2;
    }
}
