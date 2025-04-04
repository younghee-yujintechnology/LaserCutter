namespace LaserCutter.PanUnits
{
    partial class panJobList
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "[현대자동차][쏘나타][2차]",
            "2024-06-22, 오후 3:06"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "[삼성자동차][르노]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "[현대자동차][쏘나타]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "[현대자동차][갤로퍼]"}, -1);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("4차");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("3차");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("2차");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1차");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("쏘나타", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("갤로퍼");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("현대자동차", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("QMC");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("삼성자동차", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("BMW");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("FORD");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("대우");
            this.tabControlSelectJobFile = new yjTech.TabControl();
            this.tabPageRecentModel = new System.Windows.Forms.TabPage();
            this.lvRecentModel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new yjTech.BitBtn();
            this.tabPageRegisteredModel = new System.Windows.Forms.TabPage();
            this.tvModel = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCopyModel = new yjTech.BitBtn();
            this.label1 = new yjTech.Label();
            this.LabelGroup = new yjTech.Label();
            this.btnDeleteModel = new yjTech.BitBtn();
            this.btnRenameModel = new yjTech.BitBtn();
            this.btnAddModel = new yjTech.BitBtn();
            this.btnDeleteGroup = new yjTech.BitBtn();
            this.btnRenameGroup = new yjTech.BitBtn();
            this.btnAddGroup = new yjTech.BitBtn();
            this.tabControlSelectJobFile.SuspendLayout();
            this.tabPageRecentModel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRegisteredModel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSelectJobFile
            // 
            this.tabControlSelectJobFile.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlSelectJobFile.Controls.Add(this.tabPageRecentModel);
            this.tabControlSelectJobFile.Controls.Add(this.tabPageRegisteredModel);
            this.tabControlSelectJobFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSelectJobFile.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlSelectJobFile.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControlSelectJobFile.ItemSize = new System.Drawing.Size(30, 150);
            this.tabControlSelectJobFile.Location = new System.Drawing.Point(0, 0);
            this.tabControlSelectJobFile.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSelectJobFile.Multiline = true;
            this.tabControlSelectJobFile.Name = "tabControlSelectJobFile";
            this.tabControlSelectJobFile.ShowActiveCloseButton = false;
            this.tabControlSelectJobFile.ShowCloseButton = false;
            this.tabControlSelectJobFile.Size = new System.Drawing.Size(560, 852);
            this.tabControlSelectJobFile.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlSelectJobFile.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControlSelectJobFile.TabIndex = 2;
            this.tabControlSelectJobFile.TabSelectedColor = System.Drawing.Color.Lime;
            this.tabControlSelectJobFile.TabSelectedForeColor = System.Drawing.Color.Blue;
            this.tabControlSelectJobFile.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabControlSelectJobFile.TabSelectedHighColorSize = 4;
            this.tabControlSelectJobFile.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tabControlSelectJobFile.TabVisible = true;
            this.tabControlSelectJobFile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabControlSelectJobFile.TipsColor = System.Drawing.Color.Red;
            this.tabControlSelectJobFile.TipsFont = new System.Drawing.Font("Arial", 8F);
            this.tabControlSelectJobFile.TipsForeColor = System.Drawing.Color.White;
            // 
            // tabPageRecentModel
            // 
            this.tabPageRecentModel.Controls.Add(this.lvRecentModel);
            this.tabPageRecentModel.Controls.Add(this.panel1);
            this.tabPageRecentModel.Location = new System.Drawing.Point(34, 4);
            this.tabPageRecentModel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageRecentModel.Name = "tabPageRecentModel";
            this.tabPageRecentModel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRecentModel.Size = new System.Drawing.Size(522, 844);
            this.tabPageRecentModel.TabIndex = 0;
            this.tabPageRecentModel.Text = "  Recent Model  ";
            this.tabPageRecentModel.UseVisualStyleBackColor = true;
            // 
            // lvRecentModel
            // 
            this.lvRecentModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lvRecentModel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRecentModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRecentModel.FullRowSelect = true;
            this.lvRecentModel.HideSelection = false;
            this.lvRecentModel.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvRecentModel.Location = new System.Drawing.Point(4, 3);
            this.lvRecentModel.Margin = new System.Windows.Forms.Padding(0);
            this.lvRecentModel.Name = "lvRecentModel";
            this.lvRecentModel.Size = new System.Drawing.Size(514, 805);
            this.lvRecentModel.TabIndex = 1366;
            this.lvRecentModel.UseCompatibleStateImageBehavior = false;
            this.lvRecentModel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 358;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 808);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 33);
            this.panel1.TabIndex = 1365;
            // 
            // btnClear
            // 
            this.btnClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClear.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnClear.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ImageKey = "12.bmp";
            this.btnClear.Location = new System.Drawing.Point(479, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 30);
            this.btnClear.TabIndex = 1364;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // tabPageRegisteredModel
            // 
            this.tabPageRegisteredModel.Controls.Add(this.tvModel);
            this.tabPageRegisteredModel.Controls.Add(this.panel2);
            this.tabPageRegisteredModel.Location = new System.Drawing.Point(34, 4);
            this.tabPageRegisteredModel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageRegisteredModel.Name = "tabPageRegisteredModel";
            this.tabPageRegisteredModel.Size = new System.Drawing.Size(522, 844);
            this.tabPageRegisteredModel.TabIndex = 1;
            this.tabPageRegisteredModel.Text = "  Registered Model  ";
            this.tabPageRegisteredModel.UseVisualStyleBackColor = true;
            // 
            // tvModel
            // 
            this.tvModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvModel.Location = new System.Drawing.Point(0, 0);
            this.tvModel.Margin = new System.Windows.Forms.Padding(0);
            this.tvModel.Name = "tvModel";
            treeNode1.Name = "노드8";
            treeNode1.Text = "4차";
            treeNode2.Name = "노드9";
            treeNode2.Text = "3차";
            treeNode3.Name = "노드10";
            treeNode3.Text = "2차";
            treeNode4.Name = "노드11";
            treeNode4.Text = "1차";
            treeNode5.Name = "노드5";
            treeNode5.Text = "쏘나타";
            treeNode6.Name = "노드7";
            treeNode6.Text = "갤로퍼";
            treeNode7.Name = "노드0";
            treeNode7.Text = "현대자동차";
            treeNode8.Name = "노드6";
            treeNode8.Text = "QMC";
            treeNode9.Name = "노드1";
            treeNode9.Text = "삼성자동차";
            treeNode10.Name = "노드2";
            treeNode10.Text = "BMW";
            treeNode11.Name = "노드3";
            treeNode11.Text = "FORD";
            treeNode12.Name = "노드4";
            treeNode12.Text = "대우";
            this.tvModel.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.tvModel.Size = new System.Drawing.Size(522, 736);
            this.tvModel.TabIndex = 1369;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnCopyModel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LabelGroup);
            this.panel2.Controls.Add(this.btnDeleteModel);
            this.panel2.Controls.Add(this.btnRenameModel);
            this.panel2.Controls.Add(this.btnAddModel);
            this.panel2.Controls.Add(this.btnDeleteGroup);
            this.panel2.Controls.Add(this.btnRenameGroup);
            this.panel2.Controls.Add(this.btnAddGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 736);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 108);
            this.panel2.TabIndex = 1368;
            // 
            // btnCopyModel
            // 
            this.btnCopyModel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCopyModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCopyModel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnCopyModel.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCopyModel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCopyModel.ImageIndex = 8;
            this.btnCopyModel.Location = new System.Drawing.Point(218, 67);
            this.btnCopyModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyModel.Name = "btnCopyModel";
            this.btnCopyModel.Size = new System.Drawing.Size(32, 30);
            this.btnCopyModel.TabIndex = 1638;
            this.btnCopyModel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Frame.Visible = false;
            this.label1.Location = new System.Drawing.Point(174, 3);
            this.label1.Name = "label1";
            this.label1.ShowAccelChar = false;
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1637;
            this.label1.Text = "-. Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelGroup
            // 
            this.LabelGroup.BackColor = System.Drawing.Color.Transparent;
            this.LabelGroup.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGroup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelGroup.Frame.Visible = false;
            this.LabelGroup.Location = new System.Drawing.Point(7, 3);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.ShowAccelChar = false;
            this.LabelGroup.Size = new System.Drawing.Size(110, 25);
            this.LabelGroup.TabIndex = 1636;
            this.LabelGroup.Text = "-. Group";
            this.LabelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnDeleteModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDeleteModel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnDeleteModel.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDeleteModel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteModel.ImageKey = "7.bmp";
            this.btnDeleteModel.Location = new System.Drawing.Point(255, 31);
            this.btnDeleteModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteModel.TabIndex = 1370;
            this.btnDeleteModel.UseVisualStyleBackColor = false;
            // 
            // btnRenameModel
            // 
            this.btnRenameModel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnRenameModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRenameModel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnRenameModel.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRenameModel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRenameModel.ImageKey = "13.bmp";
            this.btnRenameModel.Location = new System.Drawing.Point(217, 31);
            this.btnRenameModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRenameModel.Name = "btnRenameModel";
            this.btnRenameModel.Size = new System.Drawing.Size(32, 30);
            this.btnRenameModel.TabIndex = 1369;
            this.btnRenameModel.UseVisualStyleBackColor = false;
            // 
            // btnAddModel
            // 
            this.btnAddModel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAddModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAddModel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnAddModel.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAddModel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddModel.ImageIndex = 8;
            this.btnAddModel.Location = new System.Drawing.Point(178, 31);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(32, 30);
            this.btnAddModel.TabIndex = 1368;
            this.btnAddModel.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnDeleteGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDeleteGroup.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnDeleteGroup.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDeleteGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteGroup.ImageKey = "7.bmp";
            this.btnDeleteGroup.Location = new System.Drawing.Point(98, 31);
            this.btnDeleteGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteGroup.TabIndex = 1367;
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            // 
            // btnRenameGroup
            // 
            this.btnRenameGroup.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnRenameGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRenameGroup.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnRenameGroup.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRenameGroup.Enabled = false;
            this.btnRenameGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRenameGroup.ImageKey = "13.bmp";
            this.btnRenameGroup.Location = new System.Drawing.Point(59, 31);
            this.btnRenameGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRenameGroup.Name = "btnRenameGroup";
            this.btnRenameGroup.Size = new System.Drawing.Size(32, 30);
            this.btnRenameGroup.TabIndex = 1366;
            this.btnRenameGroup.UseVisualStyleBackColor = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAddGroup.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnAddGroup.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAddGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddGroup.ImageIndex = 8;
            this.btnAddGroup.Location = new System.Drawing.Point(20, 31);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(32, 30);
            this.btnAddGroup.TabIndex = 1365;
            this.btnAddGroup.UseVisualStyleBackColor = false;
            // 
            // panJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlSelectJobFile);
            this.Name = "panJobList";
            this.Size = new System.Drawing.Size(560, 852);
            this.tabControlSelectJobFile.ResumeLayout(false);
            this.tabPageRecentModel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageRegisteredModel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public yjTech.TabControl tabControlSelectJobFile;
        public System.Windows.Forms.TabPage tabPageRecentModel;
        public System.Windows.Forms.ListView lvRecentModel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private yjTech.BitBtn btnClear;
        private System.Windows.Forms.TabPage tabPageRegisteredModel;
        private System.Windows.Forms.TreeView tvModel;
        private System.Windows.Forms.Panel panel2;
        private yjTech.BitBtn btnCopyModel;
        private yjTech.Label label1;
        private yjTech.Label LabelGroup;
        private yjTech.BitBtn btnDeleteModel;
        private yjTech.BitBtn btnRenameModel;
        private yjTech.BitBtn btnAddModel;
        private yjTech.BitBtn btnDeleteGroup;
        private yjTech.BitBtn btnRenameGroup;
        private yjTech.BitBtn btnAddGroup;
    }
}
