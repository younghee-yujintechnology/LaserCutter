using Raize.CodeSiteLogging;

namespace LaserCutter
{
    partial class panJobFile
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
            // logger.SendMsg("panJobFile.Dispose()");

            if (disposing)
            {
                // panJobInfo 객체 해제
                if (Table1 != null)
                {
                    Table1.Dispose();
                    Table1 = null;
                }

                if (Table2 != null)
                {
                    Table2.Dispose();
                    Table2 = null;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panJobFile));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panClient = new yjTech.Panel();
            this.tabControl1 = new yjTech.TabControl();
            this.tabTable1 = new System.Windows.Forms.TabPage();
            this.tabTable2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1.SuspendLayout();
            this.panClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "탐색기에서 폴더 열기";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "0.bmp");
            this.imageList1.Images.SetKeyName(1, "1.bmp");
            this.imageList1.Images.SetKeyName(2, "2.bmp");
            this.imageList1.Images.SetKeyName(3, "3.bmp");
            this.imageList1.Images.SetKeyName(4, "4.bmp");
            this.imageList1.Images.SetKeyName(5, "5.bmp");
            this.imageList1.Images.SetKeyName(6, "6.bmp");
            this.imageList1.Images.SetKeyName(7, "7.bmp");
            this.imageList1.Images.SetKeyName(8, "8.bmp");
            this.imageList1.Images.SetKeyName(9, "9.bmp");
            this.imageList1.Images.SetKeyName(10, "10.bmp");
            this.imageList1.Images.SetKeyName(11, "11.bmp");
            this.imageList1.Images.SetKeyName(12, "12.bmp");
            this.imageList1.Images.SetKeyName(13, "13.bmp");
            this.imageList1.Images.SetKeyName(14, "14.bmp");
            this.imageList1.Images.SetKeyName(15, "15.bmp");
            this.imageList1.Images.SetKeyName(16, "16.bmp");
            this.imageList1.Images.SetKeyName(17, "17.bmp");
            this.imageList1.Images.SetKeyName(18, "18.bmp");
            this.imageList1.Images.SetKeyName(19, "19.bmp");
            this.imageList1.Images.SetKeyName(20, "20.bmp");
            this.imageList1.Images.SetKeyName(21, "21.bmp");
            this.imageList1.Images.SetKeyName(22, "22.bmp");
            this.imageList1.Images.SetKeyName(23, "23.bmp");
            this.imageList1.Images.SetKeyName(24, "24.bmp");
            this.imageList1.Images.SetKeyName(25, "25.bmp");
            // 
            // panClient
            // 
            this.panClient.Controls.Add(this.tabControl1);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.FrameInner.Visible = false;
            this.panClient.FrameOuter.Visible = false;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1223, 939);
            this.panClient.TabIndex = 1381;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTable1);
            this.tabControl1.Controls.Add(this.tabTable2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(600, 36);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.ShowActiveCloseButton = false;
            this.tabControl1.ShowCloseButton = false;
            this.tabControl1.Size = new System.Drawing.Size(1216, 930);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControl1.TabIndex = 1422;
            this.tabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.tabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabControl1.TabSelectedHighColorSize = 4;
            this.tabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tabControl1.TabVisible = true;
            this.tabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabControl1.TipsColor = System.Drawing.Color.Red;
            this.tabControl1.TipsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.TipsForeColor = System.Drawing.Color.White;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTable1
            // 
            this.tabTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabTable1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabTable1.Location = new System.Drawing.Point(4, 40);
            this.tabTable1.Name = "tabTable1";
            this.tabTable1.Size = new System.Drawing.Size(1208, 886);
            this.tabTable1.TabIndex = 0;
            this.tabTable1.Text = "Tabel #1";
            // 
            // tabTable2
            // 
            this.tabTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabTable2.Location = new System.Drawing.Point(4, 40);
            this.tabTable2.Name = "tabTable2";
            this.tabTable2.Size = new System.Drawing.Size(1208, 886);
            this.tabTable2.TabIndex = 1;
            this.tabTable2.Text = "Tabel #2";
            // 
            // panJobFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobFile";
            this.Size = new System.Drawing.Size(1223, 939);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private yjTech.Panel panClient;
        public yjTech.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTable1;
        private System.Windows.Forms.TabPage tabTable2;
    }
}
