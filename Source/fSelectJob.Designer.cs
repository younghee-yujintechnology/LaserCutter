namespace LaserCutter
{
    partial class frmSelectJob
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectJob));
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new DaekhonSystem.BitBtn();
            this.btnCancel = new DaekhonSystem.BitBtn();
            this.tabControlSelectJobFile = new System.Windows.Forms.TabControl();
            this.tabPageRecentModel = new System.Windows.Forms.TabPage();
            this.lvRecentModel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new DaekhonSystem.BitBtn();
            this.tabPageRegisteredModel = new System.Windows.Forms.TabPage();
            this.tvModel = new System.Windows.Forms.TreeView();
            this.tabControlSelectJobFile.SuspendLayout();
            this.tabPageRecentModel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRegisteredModel.SuspendLayout();
            this.SuspendLayout();
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
            // btnOK
            // 
            this.btnOK.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.Location = new System.Drawing.Point(99, 738);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 50);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Location = new System.Drawing.Point(194, 738);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControlSelectJobFile
            // 
            this.tabControlSelectJobFile.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlSelectJobFile.Controls.Add(this.tabPageRecentModel);
            this.tabControlSelectJobFile.Controls.Add(this.tabPageRegisteredModel);
            this.tabControlSelectJobFile.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControlSelectJobFile.Location = new System.Drawing.Point(8, 8);
            this.tabControlSelectJobFile.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSelectJobFile.Multiline = true;
            this.tabControlSelectJobFile.Name = "tabControlSelectJobFile";
            this.tabControlSelectJobFile.SelectedIndex = 0;
            this.tabControlSelectJobFile.Size = new System.Drawing.Size(350, 724);
            this.tabControlSelectJobFile.TabIndex = 3;
            // 
            // tabPageRecentModel
            // 
            this.tabPageRecentModel.Controls.Add(this.lvRecentModel);
            this.tabPageRecentModel.Controls.Add(this.panel1);
            this.tabPageRecentModel.Location = new System.Drawing.Point(29, 4);
            this.tabPageRecentModel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageRecentModel.Name = "tabPageRecentModel";
            this.tabPageRecentModel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRecentModel.Size = new System.Drawing.Size(317, 716);
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
            this.lvRecentModel.Size = new System.Drawing.Size(309, 677);
            this.lvRecentModel.TabIndex = 1366;
            this.lvRecentModel.UseCompatibleStateImageBehavior = false;
            this.lvRecentModel.View = System.Windows.Forms.View.Details;
            this.lvRecentModel.DoubleClick += new System.EventHandler(this.lvRecentModel_DoubleClick);
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
            this.panel1.Location = new System.Drawing.Point(4, 680);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 33);
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
            this.btnClear.ImageList = this.imageList1;
            this.btnClear.Location = new System.Drawing.Point(274, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 30);
            this.btnClear.TabIndex = 1364;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabPageRegisteredModel
            // 
            this.tabPageRegisteredModel.Controls.Add(this.tvModel);
            this.tabPageRegisteredModel.Location = new System.Drawing.Point(29, 4);
            this.tabPageRegisteredModel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageRegisteredModel.Name = "tabPageRegisteredModel";
            this.tabPageRegisteredModel.Size = new System.Drawing.Size(317, 716);
            this.tabPageRegisteredModel.TabIndex = 1;
            this.tabPageRegisteredModel.Text = "  Registered Model  ";
            this.tabPageRegisteredModel.UseVisualStyleBackColor = true;
            // 
            // tvModel
            // 
            this.tvModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvModel.ImageIndex = 0;
            this.tvModel.ImageList = this.imageList1;
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
            this.tvModel.SelectedImageIndex = 0;
            this.tvModel.Size = new System.Drawing.Size(317, 716);
            this.tvModel.TabIndex = 1369;
            this.tvModel.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvModel_NodeMouseClick);
            this.tvModel.DoubleClick += new System.EventHandler(this.tvModel_DoubleClick);
            // 
            // frmSelectJob
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(366, 797);
            this.Controls.Add(this.tabControlSelectJobFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Model";
            this.Load += new System.EventHandler(this.frmSelectJob_Load);
            this.tabControlSelectJobFile.ResumeLayout(false);
            this.tabPageRecentModel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageRegisteredModel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DaekhonSystem.BitBtn btnOK;
        private DaekhonSystem.BitBtn btnCancel;
        public System.Windows.Forms.TabControl tabControlSelectJobFile;
        public System.Windows.Forms.TabPage tabPageRecentModel;
        private System.Windows.Forms.ListView lvRecentModel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private DaekhonSystem.BitBtn btnClear;
        private System.Windows.Forms.TabPage tabPageRegisteredModel;
        private System.Windows.Forms.TreeView tvModel;
    }
}