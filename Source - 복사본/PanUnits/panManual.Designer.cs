namespace LaserCutter
{
    partial class panManual
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>`
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
            this.uiTabControlMenu1 = new YujinTechnology.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiTabControlMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Controls.Add(this.tabPage3);
            this.uiTabControlMenu1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(175, 80);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTabControlMenu1.ShowActiveCloseButton = false;
            this.uiTabControlMenu1.ShowCloseButton = false;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(1552, 852);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.LightSlateGray;
            this.uiTabControlMenu1.TabIndex = 1127;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.WhiteSmoke;
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.uiTabControlMenu1.TabSelectedHighColorSize = 6;
            this.uiTabControlMenu1.TabUnSelectedForeColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabVisible = true;
            this.uiTabControlMenu1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTabControlMenu1.TipsColor = System.Drawing.Color.Red;
            this.uiTabControlMenu1.TipsFont = new System.Drawing.Font("Arial", 8F);
            this.uiTabControlMenu1.TipsForeColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.SelectedIndexChanged += new System.EventHandler(this.uiTabControlMenu1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(179, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1369, 844);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Motion";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(179, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1369, 844);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Laser";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(179, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1369, 844);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Trigger";
            // 
            // panManual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.uiTabControlMenu1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panManual";
            this.Size = new System.Drawing.Size(1552, 852);
            this.Load += new System.EventHandler(this.panManual_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private YujinTechnology.TabControl uiTabControlMenu1;


        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
