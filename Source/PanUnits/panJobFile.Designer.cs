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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "[현대자동차][쏘나타][2차]",
            "2024-06-22, 오후 3:06"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "[삼성자동차][르노]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "[현대자동차][쏘나타]"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "[현대자동차][갤로퍼]"}, -1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("4차");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("3차");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("2차");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("1차");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("쏘나타", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("갤로퍼");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("현대자동차", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("QMC");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("삼성자동차", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("BMW");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("FORD");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("대우");
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panLeft = new System.Windows.Forms.Panel();
            this.tabControlSelectJobFile = new System.Windows.Forms.TabControl();
            this.tabPageRecentModel = new System.Windows.Forms.TabPage();
            this.lvRecentModel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageRegisteredModel = new System.Windows.Forms.TabPage();
            this.tvModel = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panClient = new DaekhonSystem.Panel();
            this.TabControl1 = new DaekhonSystem.TabControl();
            this.tabTable1 = new System.Windows.Forms.TabPage();
            this.tabTable2 = new System.Windows.Forms.TabPage();
            this.btnClear = new DaekhonSystem.BitBtn();
            this.btnCopyModel = new DaekhonSystem.BitBtn();
            this.label1 = new DaekhonSystem.Label();
            this.LabelGroup = new DaekhonSystem.Label();
            this.btnDeleteModel = new DaekhonSystem.BitBtn();
            this.btnRenameModel = new DaekhonSystem.BitBtn();
            this.btnAddModel = new DaekhonSystem.BitBtn();
            this.btnDeleteGroup = new DaekhonSystem.BitBtn();
            this.btnRenameGroup = new DaekhonSystem.BitBtn();
            this.btnAddGroup = new DaekhonSystem.BitBtn();
            this.contextMenuStrip1.SuspendLayout();
            this.panLeft.SuspendLayout();
            this.tabControlSelectJobFile.SuspendLayout();
            this.tabPageRecentModel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRegisteredModel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panClient.SuspendLayout();
            this.TabControl1.SuspendLayout();
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
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            // panLeft
            // 
            this.panLeft.Controls.Add(this.tabControlSelectJobFile);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeft.Location = new System.Drawing.Point(0, 0);
            this.panLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(344, 852);
            this.panLeft.TabIndex = 1380;
            // 
            // tabControlSelectJobFile
            // 
            this.tabControlSelectJobFile.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlSelectJobFile.Controls.Add(this.tabPageRecentModel);
            this.tabControlSelectJobFile.Controls.Add(this.tabPageRegisteredModel);
            this.tabControlSelectJobFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSelectJobFile.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControlSelectJobFile.Location = new System.Drawing.Point(0, 0);
            this.tabControlSelectJobFile.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSelectJobFile.Multiline = true;
            this.tabControlSelectJobFile.Name = "tabControlSelectJobFile";
            this.tabControlSelectJobFile.SelectedIndex = 0;
            this.tabControlSelectJobFile.Size = new System.Drawing.Size(344, 852);
            this.tabControlSelectJobFile.TabIndex = 1;
            // 
            // tabPageRecentModel
            // 
            this.tabPageRecentModel.Controls.Add(this.lvRecentModel);
            this.tabPageRecentModel.Controls.Add(this.panel1);
            this.tabPageRecentModel.Location = new System.Drawing.Point(29, 4);
            this.tabPageRecentModel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageRecentModel.Name = "tabPageRecentModel";
            this.tabPageRecentModel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRecentModel.Size = new System.Drawing.Size(311, 844);
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
            this.lvRecentModel.ContextMenuStrip = this.contextMenuStrip1;
            this.lvRecentModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRecentModel.FullRowSelect = true;
            this.lvRecentModel.HideSelection = false;
            this.lvRecentModel.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvRecentModel.Location = new System.Drawing.Point(4, 3);
            this.lvRecentModel.Margin = new System.Windows.Forms.Padding(0);
            this.lvRecentModel.Name = "lvRecentModel";
            this.lvRecentModel.Size = new System.Drawing.Size(303, 805);
            this.lvRecentModel.TabIndex = 1366;
            this.lvRecentModel.UseCompatibleStateImageBehavior = false;
            this.lvRecentModel.View = System.Windows.Forms.View.Details;
            this.lvRecentModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRecentModel_KeyDown);
            this.lvRecentModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvRecentModel_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 300;
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
            this.panel1.Size = new System.Drawing.Size(303, 33);
            this.panel1.TabIndex = 1365;
            // 
            // tabPageRegisteredModel
            // 
            this.tabPageRegisteredModel.Controls.Add(this.tvModel);
            this.tabPageRegisteredModel.Controls.Add(this.panel2);
            this.tabPageRegisteredModel.Location = new System.Drawing.Point(29, 4);
            this.tabPageRegisteredModel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageRegisteredModel.Name = "tabPageRegisteredModel";
            this.tabPageRegisteredModel.Size = new System.Drawing.Size(311, 844);
            this.tabPageRegisteredModel.TabIndex = 1;
            this.tabPageRegisteredModel.Text = "  Registered Model  ";
            this.tabPageRegisteredModel.UseVisualStyleBackColor = true;
            // 
            // tvModel
            // 
            this.tvModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tvModel.ContextMenuStrip = this.contextMenuStrip1;
            this.tvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvModel.ImageIndex = 0;
            this.tvModel.ImageList = this.imageList1;
            this.tvModel.Location = new System.Drawing.Point(0, 0);
            this.tvModel.Margin = new System.Windows.Forms.Padding(0);
            this.tvModel.Name = "tvModel";
            treeNode13.Name = "노드8";
            treeNode13.Text = "4차";
            treeNode14.Name = "노드9";
            treeNode14.Text = "3차";
            treeNode15.Name = "노드10";
            treeNode15.Text = "2차";
            treeNode16.Name = "노드11";
            treeNode16.Text = "1차";
            treeNode17.Name = "노드5";
            treeNode17.Text = "쏘나타";
            treeNode18.Name = "노드7";
            treeNode18.Text = "갤로퍼";
            treeNode19.Name = "노드0";
            treeNode19.Text = "현대자동차";
            treeNode20.Name = "노드6";
            treeNode20.Text = "QMC";
            treeNode21.Name = "노드1";
            treeNode21.Text = "삼성자동차";
            treeNode22.Name = "노드2";
            treeNode22.Text = "BMW";
            treeNode23.Name = "노드3";
            treeNode23.Text = "FORD";
            treeNode24.Name = "노드4";
            treeNode24.Text = "대우";
            this.tvModel.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            this.tvModel.SelectedImageIndex = 0;
            this.tvModel.Size = new System.Drawing.Size(311, 736);
            this.tvModel.TabIndex = 1369;
            this.tvModel.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvModel_NodeMouseClick);
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
            this.panel2.Size = new System.Drawing.Size(311, 108);
            this.panel2.TabIndex = 1368;
            // 
            // panClient
            // 
            this.panClient.Controls.Add(this.TabControl1);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.FrameInner.Visible = false;
            this.panClient.FrameOuter.Visible = false;
            this.panClient.Location = new System.Drawing.Point(344, 0);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1208, 852);
            this.panClient.TabIndex = 1381;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabTable1);
            this.TabControl1.Controls.Add(this.tabTable2);
            this.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.TabControl1.ImageList = this.imageList1;
            this.TabControl1.ItemSize = new System.Drawing.Size(590, 40);
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl1.ShowActiveCloseButton = false;
            this.TabControl1.ShowCloseButton = false;
            this.TabControl1.Size = new System.Drawing.Size(1205, 849);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TabControl1.TabIndex = 1422;
            this.TabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.TabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.TabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.TabControl1.TabSelectedHighColorSize = 4;
            this.TabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.TabControl1.TabVisible = true;
            this.TabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TabControl1.TipsColor = System.Drawing.Color.Red;
            this.TabControl1.TipsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.TipsForeColor = System.Drawing.Color.White;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabTable1
            // 
            this.tabTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabTable1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabTable1.Location = new System.Drawing.Point(4, 44);
            this.tabTable1.Name = "tabTable1";
            this.tabTable1.Size = new System.Drawing.Size(1197, 801);
            this.tabTable1.TabIndex = 0;
            this.tabTable1.Text = "Tabel #1";
            // 
            // tabTable2
            // 
            this.tabTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabTable2.Location = new System.Drawing.Point(4, 26);
            this.tabTable2.Name = "tabTable2";
            this.tabTable2.Size = new System.Drawing.Size(1197, 819);
            this.tabTable2.TabIndex = 1;
            this.tabTable2.Text = "Tabel #2";
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
            this.btnClear.ImageList = this.imageList1;
            this.btnClear.Location = new System.Drawing.Point(268, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 30);
            this.btnClear.TabIndex = 1364;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnCopyModel.ImageList = this.imageList1;
            this.btnCopyModel.Location = new System.Drawing.Point(238, 67);
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
            this.label1.Location = new System.Drawing.Point(192, 4);
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
            this.btnDeleteModel.ImageList = this.imageList1;
            this.btnDeleteModel.Location = new System.Drawing.Point(275, 31);
            this.btnDeleteModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteModel.TabIndex = 1370;
            this.btnDeleteModel.UseVisualStyleBackColor = false;
            this.btnDeleteModel.Click += new System.EventHandler(this.btnDeleteModel_Click);
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
            this.btnRenameModel.ImageList = this.imageList1;
            this.btnRenameModel.Location = new System.Drawing.Point(237, 31);
            this.btnRenameModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRenameModel.Name = "btnRenameModel";
            this.btnRenameModel.Size = new System.Drawing.Size(32, 30);
            this.btnRenameModel.TabIndex = 1369;
            this.btnRenameModel.UseVisualStyleBackColor = false;
            this.btnRenameModel.Click += new System.EventHandler(this.btnRenameModel_Click);
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
            this.btnAddModel.ImageList = this.imageList1;
            this.btnAddModel.Location = new System.Drawing.Point(198, 31);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(32, 30);
            this.btnAddModel.TabIndex = 1368;
            this.btnAddModel.UseVisualStyleBackColor = false;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnDeleteGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDeleteGroup.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnDeleteGroup.CaptionStyle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDeleteGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteGroup.ImageKey = "7.bmp";
            this.btnDeleteGroup.ImageList = this.imageList1;
            this.btnDeleteGroup.Location = new System.Drawing.Point(98, 31);
            this.btnDeleteGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteGroup.TabIndex = 1367;
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
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
            this.btnRenameGroup.ImageList = this.imageList1;
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
            this.btnAddGroup.ImageList = this.imageList1;
            this.btnAddGroup.Location = new System.Drawing.Point(20, 31);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(32, 30);
            this.btnAddGroup.TabIndex = 1365;
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // panJobFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panClient);
            this.Controls.Add(this.panLeft);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobFile";
            this.Size = new System.Drawing.Size(1552, 852);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panLeft.ResumeLayout(false);
            this.tabControlSelectJobFile.ResumeLayout(false);
            this.tabPageRecentModel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageRegisteredModel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panClient.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panLeft;
        public System.Windows.Forms.TabControl tabControlSelectJobFile;
        public System.Windows.Forms.TabPage tabPageRecentModel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private DaekhonSystem.BitBtn btnClear;
        private System.Windows.Forms.TabPage tabPageRegisteredModel;
        private System.Windows.Forms.TreeView tvModel;
        private System.Windows.Forms.Panel panel2;
        private DaekhonSystem.BitBtn btnDeleteModel;
        private DaekhonSystem.BitBtn btnRenameModel;
        private DaekhonSystem.BitBtn btnAddModel;
        private DaekhonSystem.BitBtn btnDeleteGroup;
        private DaekhonSystem.BitBtn btnRenameGroup;
        private DaekhonSystem.BitBtn btnAddGroup;
        private DaekhonSystem.Panel panClient;
        public DaekhonSystem.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabTable1;
        private System.Windows.Forms.TabPage tabTable2;
        private DaekhonSystem.Label label1;
        private DaekhonSystem.Label LabelGroup;
        private DaekhonSystem.BitBtn btnCopyModel;
        public System.Windows.Forms.ListView lvRecentModel;
    }
}
