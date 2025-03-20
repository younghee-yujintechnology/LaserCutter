namespace LaserCutter
{
    partial class panLog
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
            this.panClient = new LaserCutter.sjPanel();
            this.btnSelectFolder = new YujinTechnology.BitBtn();
            this.btnCollapse = new YujinTechnology.BitBtn();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExpand = new YujinTechnology.BitBtn();
            this.TreeViewLog = new YujinTechnology.TreeView();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.Controls.Add(this.btnSelectFolder);
            this.panClient.Controls.Add(this.btnCollapse);
            this.panClient.Controls.Add(this.ListView1);
            this.panClient.Controls.Add(this.btnExpand);
            this.panClient.Controls.Add(this.TreeViewLog);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1920, 729);
            this.panClient.TabIndex = 1058;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panClient.TitleText = "Title";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSelectFolder.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.Font = new System.Drawing.Font("굴림", 9F);
            this.btnSelectFolder.ForeColor = System.Drawing.Color.Black;
            this.btnSelectFolder.Location = new System.Drawing.Point(333, 53);
            this.btnSelectFolder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(86, 29);
            this.btnSelectFolder.TabIndex = 1141;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            // 
            // btnCollapse
            // 
            this.btnCollapse.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCollapse.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapse.Font = new System.Drawing.Font("굴림", 9F);
            this.btnCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnCollapse.Location = new System.Drawing.Point(243, 53);
            this.btnCollapse.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(86, 29);
            this.btnCollapse.TabIndex = 1142;
            this.btnCollapse.Text = "Collapse All";
            this.btnCollapse.UseVisualStyleBackColor = false;
            // 
            // ListView1
            // 
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView1.Font = new System.Drawing.Font("굴림", 9F);
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(428, 88);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(1454, 617);
            this.ListView1.TabIndex = 1145;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Section";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contents";
            this.columnHeader3.Width = 1200;
            // 
            // btnExpand
            // 
            this.btnExpand.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnExpand.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.Font = new System.Drawing.Font("굴림", 9F);
            this.btnExpand.ForeColor = System.Drawing.Color.Black;
            this.btnExpand.Location = new System.Drawing.Point(153, 53);
            this.btnExpand.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(86, 29);
            this.btnExpand.TabIndex = 1143;
            this.btnExpand.Text = "Expand All";
            this.btnExpand.UseVisualStyleBackColor = false;
            // 
            // TreeViewLog
            // 
            this.TreeViewLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeViewLog.Location = new System.Drawing.Point(9, 88);
            this.TreeViewLog.Margin = new System.Windows.Forms.Padding(4);
            this.TreeViewLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.TreeViewLog.Name = "TreeViewLog";
            this.TreeViewLog.Size = new System.Drawing.Size(412, 617);
            this.TreeViewLog.TabIndex = 1144;
            this.TreeViewLog.Text = null;
            // 
            // panLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panClient);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "panLog";
            this.Size = new System.Drawing.Size(1920, 729);
            this.panClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private sjPanel panClient;
        private YujinTechnology.BitBtn btnSelectFolder;
        private YujinTechnology.BitBtn btnCollapse;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private YujinTechnology.BitBtn btnExpand;
        private YujinTechnology.TreeView TreeViewLog;
    }
}
