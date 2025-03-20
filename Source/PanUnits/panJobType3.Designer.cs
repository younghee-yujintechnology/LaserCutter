using Raize.CodeSiteLogging;

namespace LaserCutter
{
    partial class panJobType3
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
            // logger.SendMsg("panJobType3.Dispose()");

            if (disposing)
            {
                // Cad3 리소스 해제
                if (Cad3 != null)
                {
                    Cad3.Dispose();
                    Cad3 = null;
                }

                // Cad3Data 리소스 해제
                if (cad3Data != null)
                {
                    cad3Data.Clear();
                    cad3Data = null;
                }

                // 데이터 그리드 해제
                if (dataGridView3 != null)
                {
                    dataGridView3.Rows.Clear();
                    dataGridView3.Dispose();
                    dataGridView3 = null;
                }

                // 기존 Designer에서 생성된 components 리소스 해제
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panJobType3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bitBtn3 = new YujinTechnology.BitBtn();
            this.tabControl1 = new YujinTechnology.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkShowJumpline = new System.Windows.Forms.CheckBox();
            this.viLaserFocus = new YujinTechnology.ValueIndicator();
            this.viZPosition2 = new YujinTechnology.Label();
            this.label6 = new YujinTechnology.Label();
            this.label7 = new YujinTechnology.Label();
            this.label1 = new YujinTechnology.Label();
            this.edThickness = new YujinTechnology.KeypadEdit();
            this.gradLabel66 = new YujinTechnology.GradientLabel();
            this.edCellRadius = new YujinTechnology.KeypadEdit();
            this.rdoCircle = new YujinTechnology.SunnyRadioButton();
            this.chkBreakLineOutDir = new YujinTechnology.SunnyCheckBox();
            this.chkUseBreakLine = new YujinTechnology.SunnyCheckBox();
            this.edBreakLineOffset = new YujinTechnology.KeypadEdit();
            this.edBreakLineLength = new YujinTechnology.KeypadEdit();
            this.gradLabel76 = new YujinTechnology.GradientLabel();
            this.gradLabel77 = new YujinTechnology.GradientLabel();
            this.edCellHeight = new YujinTechnology.KeypadEdit();
            this.edCellWidth = new YujinTechnology.KeypadEdit();
            this.lblLabelSize = new YujinTechnology.GradientLabel();
            this.rdoCell = new YujinTechnology.SunnyRadioButton();
            this.cbStartPoint = new YujinTechnology.ComboBox();
            this.label4 = new YujinTechnology.Label();
            this.edPulsePitch = new YujinTechnology.KeypadEdit();
            this.edLaserPower = new YujinTechnology.KeypadEdit();
            this.label2 = new YujinTechnology.Label();
            this.label3 = new YujinTechnology.Label();
            this.edZOffset = new YujinTechnology.KeypadEdit();
            this.LabelZOffset = new YujinTechnology.Label();
            this.label5 = new YujinTechnology.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreView = new YujinTechnology.BitBtn();
            this.edGlassSizeX = new YujinTechnology.KeypadEdit();
            this.edGlassSizeY = new YujinTechnology.KeypadEdit();
            this.LabelGlassSizeX = new YujinTechnology.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ledSortMethod4 = new YujinTechnology.LEDLabel();
            this.ledSortMethod3 = new YujinTechnology.LEDLabel();
            this.ledSortMethod2 = new YujinTechnology.LEDLabel();
            this.ledSortMethod1 = new YujinTechnology.LEDLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradLabel58 = new YujinTechnology.GradientLabel();
            this.gradLabel62 = new YujinTechnology.GradientLabel();
            this.btnApply = new YujinTechnology.BitBtn();
            this.edGapY = new YujinTechnology.KeypadEdit();
            this.edYCount = new YujinTechnology.KeypadEdit();
            this.edGapX = new YujinTechnology.KeypadEdit();
            this.edXCount = new YujinTechnology.KeypadEdit();
            this.gradientLabel2 = new YujinTechnology.GradientLabel();
            this.gradientLabel1 = new YujinTechnology.GradientLabel();
            this.bitBtn1 = new YujinTechnology.BitBtn();
            this.btnCancel = new YujinTechnology.BitBtn();
            this.btnSave = new YujinTechnology.BitBtn();
            this.lblSizeY = new System.Windows.Forms.Label();
            this.lblSizeX = new System.Windows.Forms.Label();
            this.gradLabel33 = new YujinTechnology.GradientLabel();
            this.bitBtn2 = new YujinTechnology.BitBtn();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDir = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnStartPoint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panCad = new YujinTechnology.Panel();
            this.btnClear = new YujinTechnology.BitBtn();
            this.btnOpenFile = new YujinTechnology.BitBtn();
            this.lblDxfPath = new YujinTechnology.Label();
            this.gradLabel13 = new YujinTechnology.GradientLabel();
            this.btnUse = new YujinTechnology.LEDButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // bitBtn3
            // 
            this.bitBtn3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.bitBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bitBtn3.Enabled = false;
            this.bitBtn3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bitBtn3.ForeColor = System.Drawing.Color.Black;
            this.bitBtn3.Location = new System.Drawing.Point(929, 648);
            this.bitBtn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitBtn3.MinimumSize = new System.Drawing.Size(1, 1);
            this.bitBtn3.Name = "bitBtn3";
            this.bitBtn3.Size = new System.Drawing.Size(77, 32);
            this.bitBtn3.TabIndex = 1693;
            this.bitBtn3.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(640, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.ShowActiveCloseButton = false;
            this.tabControl1.ShowCloseButton = false;
            this.tabControl1.Size = new System.Drawing.Size(532, 638);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabControl1.TabIndex = 1692;
            this.tabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.tabControl1.TabSelectedForeColor = System.Drawing.Color.Blue;
            this.tabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabControl1.TabSelectedHighColorSize = 4;
            this.tabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tabControl1.TabVisible = true;
            this.tabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tabControl1.TipsColor = System.Drawing.Color.Red;
            this.tabControl1.TipsFont = new System.Drawing.Font("Arial", 8F);
            this.tabControl1.TipsForeColor = System.Drawing.Color.White;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.chkShowJumpline);
            this.tabPage1.Controls.Add(this.viLaserFocus);
            this.tabPage1.Controls.Add(this.viZPosition2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edThickness);
            this.tabPage1.Controls.Add(this.gradLabel66);
            this.tabPage1.Controls.Add(this.edCellRadius);
            this.tabPage1.Controls.Add(this.rdoCircle);
            this.tabPage1.Controls.Add(this.chkBreakLineOutDir);
            this.tabPage1.Controls.Add(this.chkUseBreakLine);
            this.tabPage1.Controls.Add(this.edBreakLineOffset);
            this.tabPage1.Controls.Add(this.edBreakLineLength);
            this.tabPage1.Controls.Add(this.gradLabel76);
            this.tabPage1.Controls.Add(this.gradLabel77);
            this.tabPage1.Controls.Add(this.edCellHeight);
            this.tabPage1.Controls.Add(this.edCellWidth);
            this.tabPage1.Controls.Add(this.lblLabelSize);
            this.tabPage1.Controls.Add(this.rdoCell);
            this.tabPage1.Controls.Add(this.cbStartPoint);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.edPulsePitch);
            this.tabPage1.Controls.Add(this.edLaserPower);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edZOffset);
            this.tabPage1.Controls.Add(this.LabelZOffset);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  가공 속성  ";
            // 
            // chkShowJumpline
            // 
            this.chkShowJumpline.AutoSize = true;
            this.chkShowJumpline.Location = new System.Drawing.Point(10, 398);
            this.chkShowJumpline.Name = "chkShowJumpline";
            this.chkShowJumpline.Size = new System.Drawing.Size(131, 22);
            this.chkShowJumpline.TabIndex = 1838;
            this.chkShowJumpline.Text = "Show Jump Line";
            this.chkShowJumpline.UseVisualStyleBackColor = true;
            this.chkShowJumpline.CheckedChanged += new System.EventHandler(this.chkShowJumpline_CheckedChanged);
            // 
            // viLaserFocus
            // 
            this.viLaserFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viLaserFocus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viLaserFocus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viLaserFocus.FormatString = "0.000";
            this.viLaserFocus.Frame.Bottom = false;
            this.viLaserFocus.Frame.CornerRound = 1;
            this.viLaserFocus.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viLaserFocus.Frame.Top = false;
            this.viLaserFocus.Location = new System.Drawing.Point(367, 104);
            this.viLaserFocus.Margin = new System.Windows.Forms.Padding(4);
            this.viLaserFocus.MinimumSize = new System.Drawing.Size(1, 1);
            this.viLaserFocus.Name = "viLaserFocus";
            this.viLaserFocus.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viLaserFocus.ShowAccelChar = false;
            this.viLaserFocus.Size = new System.Drawing.Size(95, 29);
            this.viLaserFocus.TabIndex = 1837;
            this.viLaserFocus.Text = "0";
            this.viLaserFocus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viZPosition2
            // 
            this.viZPosition2.BackColor = System.Drawing.Color.Transparent;
            this.viZPosition2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.viZPosition2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viZPosition2.Frame.Visible = false;
            this.viZPosition2.Location = new System.Drawing.Point(265, 104);
            this.viZPosition2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viZPosition2.Name = "viZPosition2";
            this.viZPosition2.ShowAccelChar = false;
            this.viZPosition2.Size = new System.Drawing.Size(100, 29);
            this.viZPosition2.TabIndex = 1836;
            this.viZPosition2.Text = "Laser.Focus";
            this.viZPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label6.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.label6.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.label6.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Frame.Visible = false;
            this.label6.Location = new System.Drawing.Point(479, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Name = "label6";
            this.label6.ShowAccelChar = false;
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 1835;
            this.label6.Text = "↑";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label7.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.label7.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.label7.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Frame.Visible = false;
            this.label7.Location = new System.Drawing.Point(270, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Name = "label7";
            this.label7.ShowAccelChar = false;
            this.label7.Size = new System.Drawing.Size(213, 29);
            this.label7.TabIndex = 1834;
            this.label7.Text = "Z.Focus : (Thickness + Z.Offset)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Frame.Visible = false;
            this.label1.Location = new System.Drawing.Point(453, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.ShowAccelChar = false;
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 1833;
            this.label1.Text = "[단위 mm]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edThickness
            // 
            this.edThickness.BackColor = System.Drawing.Color.White;
            this.edThickness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edThickness.DataType = YujinTechnology.DataType.Double;
            this.edThickness.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edThickness.Frame.CornerRound = 1;
            this.edThickness.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edThickness.Hint = null;
            this.edThickness.Location = new System.Drawing.Point(367, 71);
            this.edThickness.Margin = new System.Windows.Forms.Padding(4);
            this.edThickness.Max = 0D;
            this.edThickness.Min = 0D;
            this.edThickness.MinimumSize = new System.Drawing.Size(1, 1);
            this.edThickness.Name = "edThickness";
            this.edThickness.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edThickness.PrecisionDigits = 3;
            this.edThickness.ShowHint = true;
            this.edThickness.Size = new System.Drawing.Size(95, 29);
            this.edThickness.TabIndex = 1832;
            this.edThickness.Text = "0.000";
            this.edThickness.Value = 0D;
            // 
            // gradLabel66
            // 
            this.gradLabel66.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel66.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel66.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel66.Frame.Visible = false;
            this.gradLabel66.GradientEnable = false;
            this.gradLabel66.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel66.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel66.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel66.Location = new System.Drawing.Point(211, 252);
            this.gradLabel66.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradLabel66.Name = "gradLabel66";
            this.gradLabel66.ShowAccelChar = false;
            this.gradLabel66.Size = new System.Drawing.Size(54, 29);
            this.gradLabel66.TabIndex = 1820;
            this.gradLabel66.Text = "R";
            this.gradLabel66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edCellRadius
            // 
            this.edCellRadius.BackColor = System.Drawing.Color.White;
            this.edCellRadius.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edCellRadius.DataType = YujinTechnology.DataType.Double;
            this.edCellRadius.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edCellRadius.Frame.CornerRound = 1;
            this.edCellRadius.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edCellRadius.Hint = null;
            this.edCellRadius.Location = new System.Drawing.Point(269, 252);
            this.edCellRadius.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edCellRadius.Max = 50D;
            this.edCellRadius.Min = 0.001D;
            this.edCellRadius.MinimumSize = new System.Drawing.Size(1, 1);
            this.edCellRadius.Name = "edCellRadius";
            this.edCellRadius.NewText = "0.001";
            this.edCellRadius.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edCellRadius.PrecisionDigits = 3;
            this.edCellRadius.ShowHint = false;
            this.edCellRadius.Size = new System.Drawing.Size(95, 29);
            this.edCellRadius.TabIndex = 1821;
            this.edCellRadius.Text = "0.001";
            this.edCellRadius.Value = 0.001D;
            // 
            // rdoCircle
            // 
            this.rdoCircle.Checked = false;
            this.rdoCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCircle.Enabled = false;
            this.rdoCircle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoCircle.ForeColor = System.Drawing.Color.Black;
            this.rdoCircle.foreDisableColor = System.Drawing.Color.Gray;
            this.rdoCircle.Frame.Visible = false;
            this.rdoCircle.GroupName = null;
            this.rdoCircle.Hint = null;
            this.rdoCircle.ImageInterval = 4;
            this.rdoCircle.ImageSize = 16;
            this.rdoCircle.Location = new System.Drawing.Point(119, 180);
            this.rdoCircle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoCircle.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.rdoCircle.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rdoCircle.ShowHint = false;
            this.rdoCircle.Size = new System.Drawing.Size(73, 29);
            this.rdoCircle.TabIndex = 1819;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoCircle.Click += new System.EventHandler(this.rdoCircle_Click);
            // 
            // chkBreakLineOutDir
            // 
            this.chkBreakLineOutDir.Channel = null;
            this.chkBreakLineOutDir.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.chkBreakLineOutDir.Checked = false;
            this.chkBreakLineOutDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBreakLineOutDir.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chkBreakLineOutDir.ForeColor = System.Drawing.Color.Black;
            this.chkBreakLineOutDir.foreDisableColor = System.Drawing.Color.Gray;
            this.chkBreakLineOutDir.Frame.Visible = false;
            this.chkBreakLineOutDir.Hint = null;
            this.chkBreakLineOutDir.ImageInterval = 4;
            this.chkBreakLineOutDir.ImageSize = 16;
            this.chkBreakLineOutDir.Location = new System.Drawing.Point(118, 318);
            this.chkBreakLineOutDir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkBreakLineOutDir.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkBreakLineOutDir.Name = "chkBreakLineOutDir";
            this.chkBreakLineOutDir.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.chkBreakLineOutDir.ShowHint = false;
            this.chkBreakLineOutDir.Size = new System.Drawing.Size(177, 25);
            this.chkBreakLineOutDir.TabIndex = 1830;
            this.chkBreakLineOutDir.Text = "Line Direction (In -> Out)";
            this.chkBreakLineOutDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUseBreakLine
            // 
            this.chkUseBreakLine.Channel = null;
            this.chkUseBreakLine.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.chkUseBreakLine.Checked = false;
            this.chkUseBreakLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUseBreakLine.Font = new System.Drawing.Font("굴림", 9F);
            this.chkUseBreakLine.ForeColor = System.Drawing.Color.Black;
            this.chkUseBreakLine.foreDisableColor = System.Drawing.Color.Gray;
            this.chkUseBreakLine.Frame.Visible = false;
            this.chkUseBreakLine.Hint = null;
            this.chkUseBreakLine.ImageInterval = 4;
            this.chkUseBreakLine.ImageSize = 16;
            this.chkUseBreakLine.Location = new System.Drawing.Point(55, 318);
            this.chkUseBreakLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkUseBreakLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkUseBreakLine.Name = "chkUseBreakLine";
            this.chkUseBreakLine.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.chkUseBreakLine.ShowHint = false;
            this.chkUseBreakLine.Size = new System.Drawing.Size(67, 25);
            this.chkUseBreakLine.TabIndex = 1829;
            this.chkUseBreakLine.Text = "Line";
            this.chkUseBreakLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkUseBreakLine.Click += new System.EventHandler(this.chkUseBreakingLine_CheckedChanged);
            // 
            // edBreakLineOffset
            // 
            this.edBreakLineOffset.BackColor = System.Drawing.Color.White;
            this.edBreakLineOffset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edBreakLineOffset.DataType = YujinTechnology.DataType.Double;
            this.edBreakLineOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edBreakLineOffset.Frame.CornerRound = 1;
            this.edBreakLineOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edBreakLineOffset.Hint = null;
            this.edBreakLineOffset.Location = new System.Drawing.Point(170, 348);
            this.edBreakLineOffset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edBreakLineOffset.Max = 0D;
            this.edBreakLineOffset.Min = 0D;
            this.edBreakLineOffset.MinimumSize = new System.Drawing.Size(1, 1);
            this.edBreakLineOffset.Name = "edBreakLineOffset";
            this.edBreakLineOffset.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edBreakLineOffset.PrecisionDigits = 3;
            this.edBreakLineOffset.ShowHint = false;
            this.edBreakLineOffset.Size = new System.Drawing.Size(95, 29);
            this.edBreakLineOffset.TabIndex = 1827;
            this.edBreakLineOffset.Text = "0.000";
            this.edBreakLineOffset.Value = 0D;
            // 
            // edBreakLineLength
            // 
            this.edBreakLineLength.BackColor = System.Drawing.Color.White;
            this.edBreakLineLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edBreakLineLength.DataType = YujinTechnology.DataType.Double;
            this.edBreakLineLength.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edBreakLineLength.Frame.CornerRound = 1;
            this.edBreakLineLength.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edBreakLineLength.Hint = null;
            this.edBreakLineLength.Location = new System.Drawing.Point(368, 348);
            this.edBreakLineLength.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edBreakLineLength.Max = 0D;
            this.edBreakLineLength.Min = 0D;
            this.edBreakLineLength.MinimumSize = new System.Drawing.Size(1, 1);
            this.edBreakLineLength.Name = "edBreakLineLength";
            this.edBreakLineLength.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edBreakLineLength.PrecisionDigits = 3;
            this.edBreakLineLength.ShowHint = false;
            this.edBreakLineLength.Size = new System.Drawing.Size(95, 29);
            this.edBreakLineLength.TabIndex = 1828;
            this.edBreakLineLength.Text = "0.000";
            this.edBreakLineLength.Value = 0D;
            // 
            // gradLabel76
            // 
            this.gradLabel76.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel76.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel76.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel76.Frame.Visible = false;
            this.gradLabel76.GradientEnable = false;
            this.gradLabel76.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel76.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel76.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel76.Location = new System.Drawing.Point(260, 348);
            this.gradLabel76.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradLabel76.Name = "gradLabel76";
            this.gradLabel76.ShowAccelChar = false;
            this.gradLabel76.Size = new System.Drawing.Size(103, 29);
            this.gradLabel76.TabIndex = 1825;
            this.gradLabel76.Text = "Length";
            this.gradLabel76.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel77
            // 
            this.gradLabel77.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel77.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel77.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel77.Frame.Visible = false;
            this.gradLabel77.GradientEnable = false;
            this.gradLabel77.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel77.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel77.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel77.Location = new System.Drawing.Point(62, 348);
            this.gradLabel77.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradLabel77.Name = "gradLabel77";
            this.gradLabel77.ShowAccelChar = false;
            this.gradLabel77.Size = new System.Drawing.Size(103, 29);
            this.gradLabel77.TabIndex = 1826;
            this.gradLabel77.Text = "Offset";
            this.gradLabel77.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edCellHeight
            // 
            this.edCellHeight.BackColor = System.Drawing.Color.White;
            this.edCellHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edCellHeight.DataType = YujinTechnology.DataType.Double;
            this.edCellHeight.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edCellHeight.Frame.CornerRound = 1;
            this.edCellHeight.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edCellHeight.Hint = null;
            this.edCellHeight.Location = new System.Drawing.Point(269, 219);
            this.edCellHeight.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edCellHeight.Max = 0D;
            this.edCellHeight.Min = 0D;
            this.edCellHeight.MinimumSize = new System.Drawing.Size(1, 1);
            this.edCellHeight.Name = "edCellHeight";
            this.edCellHeight.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edCellHeight.PrecisionDigits = 3;
            this.edCellHeight.ShowHint = false;
            this.edCellHeight.Size = new System.Drawing.Size(95, 29);
            this.edCellHeight.TabIndex = 1824;
            this.edCellHeight.Text = "0.000";
            this.edCellHeight.Value = 0D;
            // 
            // edCellWidth
            // 
            this.edCellWidth.BackColor = System.Drawing.Color.White;
            this.edCellWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edCellWidth.DataType = YujinTechnology.DataType.Double;
            this.edCellWidth.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edCellWidth.Frame.CornerRound = 1;
            this.edCellWidth.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edCellWidth.Hint = null;
            this.edCellWidth.Location = new System.Drawing.Point(170, 219);
            this.edCellWidth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edCellWidth.Max = 0D;
            this.edCellWidth.Min = 0D;
            this.edCellWidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.edCellWidth.Name = "edCellWidth";
            this.edCellWidth.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edCellWidth.PrecisionDigits = 3;
            this.edCellWidth.ShowHint = false;
            this.edCellWidth.Size = new System.Drawing.Size(95, 29);
            this.edCellWidth.TabIndex = 1823;
            this.edCellWidth.Text = "0.000";
            this.edCellWidth.Value = 0D;
            // 
            // lblLabelSize
            // 
            this.lblLabelSize.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelSize.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblLabelSize.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLabelSize.Frame.Visible = false;
            this.lblLabelSize.GradientEnable = false;
            this.lblLabelSize.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblLabelSize.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblLabelSize.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblLabelSize.Location = new System.Drawing.Point(112, 219);
            this.lblLabelSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblLabelSize.Name = "lblLabelSize";
            this.lblLabelSize.ShowAccelChar = false;
            this.lblLabelSize.Size = new System.Drawing.Size(54, 29);
            this.lblLabelSize.TabIndex = 1822;
            this.lblLabelSize.Text = "Size";
            this.lblLabelSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdoCell
            // 
            this.rdoCell.Checked = false;
            this.rdoCell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCell.Enabled = false;
            this.rdoCell.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoCell.ForeColor = System.Drawing.Color.Black;
            this.rdoCell.foreDisableColor = System.Drawing.Color.Gray;
            this.rdoCell.Frame.Visible = false;
            this.rdoCell.GroupName = null;
            this.rdoCell.Hint = null;
            this.rdoCell.ImageInterval = 4;
            this.rdoCell.ImageSize = 16;
            this.rdoCell.Location = new System.Drawing.Point(56, 180);
            this.rdoCell.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoCell.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoCell.Name = "rdoCell";
            this.rdoCell.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.rdoCell.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rdoCell.ShowHint = false;
            this.rdoCell.Size = new System.Drawing.Size(67, 29);
            this.rdoCell.TabIndex = 1818;
            this.rdoCell.Text = "Cell";
            this.rdoCell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdoCell.Click += new System.EventHandler(this.rdoCell_Click);
            // 
            // cbStartPoint
            // 
            this.cbStartPoint.BackColor = System.Drawing.Color.White;
            this.cbStartPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartPoint.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbStartPoint.Frame.Bottom = false;
            this.cbStartPoint.Frame.CornerRound = 1;
            this.cbStartPoint.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbStartPoint.Frame.Top = false;
            this.cbStartPoint.Hint = null;
            this.cbStartPoint.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom"});
            this.cbStartPoint.Location = new System.Drawing.Point(169, 104);
            this.cbStartPoint.Name = "cbStartPoint";
            this.cbStartPoint.ShowHint = false;
            this.cbStartPoint.Size = new System.Drawing.Size(95, 29);
            this.cbStartPoint.TabIndex = 1817;
            this.cbStartPoint.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Frame.Visible = false;
            this.label4.Location = new System.Drawing.Point(64, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Name = "label4";
            this.label4.ShowAccelChar = false;
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 1816;
            this.label4.Text = "Start Point";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edPulsePitch
            // 
            this.edPulsePitch.BackColor = System.Drawing.Color.White;
            this.edPulsePitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edPulsePitch.DataType = YujinTechnology.DataType.Double;
            this.edPulsePitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPulsePitch.Frame.CornerRound = 1;
            this.edPulsePitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPulsePitch.Hint = null;
            this.edPulsePitch.Location = new System.Drawing.Point(169, 71);
            this.edPulsePitch.Margin = new System.Windows.Forms.Padding(4);
            this.edPulsePitch.Max = 0D;
            this.edPulsePitch.Min = 0D;
            this.edPulsePitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.edPulsePitch.Name = "edPulsePitch";
            this.edPulsePitch.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edPulsePitch.PrecisionDigits = 3;
            this.edPulsePitch.ShowHint = true;
            this.edPulsePitch.Size = new System.Drawing.Size(95, 29);
            this.edPulsePitch.TabIndex = 1814;
            this.edPulsePitch.Text = "0.000";
            this.edPulsePitch.Value = 0D;
            // 
            // edLaserPower
            // 
            this.edLaserPower.BackColor = System.Drawing.Color.White;
            this.edLaserPower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edLaserPower.DataType = YujinTechnology.DataType.Double;
            this.edLaserPower.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edLaserPower.Frame.CornerRound = 1;
            this.edLaserPower.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLaserPower.Hint = null;
            this.edLaserPower.Location = new System.Drawing.Point(169, 38);
            this.edLaserPower.Margin = new System.Windows.Forms.Padding(4);
            this.edLaserPower.Max = 100D;
            this.edLaserPower.Min = 0.1D;
            this.edLaserPower.MinimumSize = new System.Drawing.Size(1, 1);
            this.edLaserPower.Name = "edLaserPower";
            this.edLaserPower.NewText = "0.1";
            this.edLaserPower.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edLaserPower.PrecisionDigits = 3;
            this.edLaserPower.ShowHint = true;
            this.edLaserPower.Size = new System.Drawing.Size(95, 29);
            this.edLaserPower.TabIndex = 1815;
            this.edLaserPower.Text = "0.100";
            this.edLaserPower.Value = 0.1D;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Frame.Visible = false;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.ShowAccelChar = false;
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 1813;
            this.label2.Text = "Pulse.Pitch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Frame.Visible = false;
            this.label3.Location = new System.Drawing.Point(64, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.ShowAccelChar = false;
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 1812;
            this.label3.Text = "Laser.Power";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edZOffset
            // 
            this.edZOffset.BackColor = System.Drawing.Color.White;
            this.edZOffset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edZOffset.DataType = YujinTechnology.DataType.Double;
            this.edZOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edZOffset.Frame.CornerRound = 1;
            this.edZOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edZOffset.Hint = null;
            this.edZOffset.Location = new System.Drawing.Point(367, 38);
            this.edZOffset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edZOffset.Max = 0D;
            this.edZOffset.Min = 0D;
            this.edZOffset.MinimumSize = new System.Drawing.Size(1, 1);
            this.edZOffset.Name = "edZOffset";
            this.edZOffset.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edZOffset.PrecisionDigits = 3;
            this.edZOffset.ShowHint = true;
            this.edZOffset.Size = new System.Drawing.Size(95, 29);
            this.edZOffset.TabIndex = 1811;
            this.edZOffset.Text = "0.000";
            this.edZOffset.Value = 0D;
            // 
            // LabelZOffset
            // 
            this.LabelZOffset.BackColor = System.Drawing.Color.Transparent;
            this.LabelZOffset.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelZOffset.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelZOffset.Frame.Visible = false;
            this.LabelZOffset.Location = new System.Drawing.Point(262, 38);
            this.LabelZOffset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelZOffset.Name = "LabelZOffset";
            this.LabelZOffset.ShowAccelChar = false;
            this.LabelZOffset.Size = new System.Drawing.Size(103, 29);
            this.LabelZOffset.TabIndex = 1810;
            this.LabelZOffset.Text = "Z.Offset";
            this.LabelZOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Frame.Visible = false;
            this.label5.Location = new System.Drawing.Point(262, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.ShowAccelChar = false;
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 1831;
            this.label5.Text = "Thickness";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.gradientLabel2);
            this.tabPage2.Controls.Add(this.gradientLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Array Info  ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnPreView);
            this.panel1.Controls.Add(this.edGlassSizeX);
            this.panel1.Controls.Add(this.edGlassSizeY);
            this.panel1.Controls.Add(this.LabelGlassSizeX);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.ledSortMethod4);
            this.panel1.Controls.Add(this.ledSortMethod3);
            this.panel1.Controls.Add(this.ledSortMethod2);
            this.panel1.Controls.Add(this.ledSortMethod1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gradLabel58);
            this.panel1.Controls.Add(this.gradLabel62);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.edGapY);
            this.panel1.Controls.Add(this.edYCount);
            this.panel1.Controls.Add(this.edGapX);
            this.panel1.Controls.Add(this.edXCount);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 578);
            this.panel1.TabIndex = 1822;
            // 
            // btnPreView
            // 
            this.btnPreView.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPreView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPreView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreView.Enabled = false;
            this.btnPreView.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPreView.ForeColor = System.Drawing.Color.Black;
            this.btnPreView.Location = new System.Drawing.Point(11, 228);
            this.btnPreView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(77, 32);
            this.btnPreView.TabIndex = 1839;
            this.btnPreView.Text = "미리보기";
            this.btnPreView.UseVisualStyleBackColor = false;
            // 
            // edGlassSizeX
            // 
            this.edGlassSizeX.BackColor = System.Drawing.Color.White;
            this.edGlassSizeX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGlassSizeX.DataType = YujinTechnology.DataType.Double;
            this.edGlassSizeX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGlassSizeX.Frame.CornerRound = 1;
            this.edGlassSizeX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGlassSizeX.Hint = null;
            this.edGlassSizeX.Location = new System.Drawing.Point(166, 128);
            this.edGlassSizeX.Margin = new System.Windows.Forms.Padding(4);
            this.edGlassSizeX.Max = 0D;
            this.edGlassSizeX.Min = 0D;
            this.edGlassSizeX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGlassSizeX.Name = "edGlassSizeX";
            this.edGlassSizeX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGlassSizeX.PrecisionDigits = 3;
            this.edGlassSizeX.ShowHint = true;
            this.edGlassSizeX.Size = new System.Drawing.Size(95, 29);
            this.edGlassSizeX.TabIndex = 1820;
            this.edGlassSizeX.Text = "0.000";
            this.edGlassSizeX.Value = 0D;
            // 
            // edGlassSizeY
            // 
            this.edGlassSizeY.BackColor = System.Drawing.Color.White;
            this.edGlassSizeY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGlassSizeY.DataType = YujinTechnology.DataType.Double;
            this.edGlassSizeY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGlassSizeY.Frame.CornerRound = 1;
            this.edGlassSizeY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGlassSizeY.Hint = null;
            this.edGlassSizeY.Location = new System.Drawing.Point(265, 128);
            this.edGlassSizeY.Margin = new System.Windows.Forms.Padding(4);
            this.edGlassSizeY.Max = 0D;
            this.edGlassSizeY.Min = 0D;
            this.edGlassSizeY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGlassSizeY.Name = "edGlassSizeY";
            this.edGlassSizeY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGlassSizeY.PrecisionDigits = 3;
            this.edGlassSizeY.ShowHint = true;
            this.edGlassSizeY.Size = new System.Drawing.Size(95, 29);
            this.edGlassSizeY.TabIndex = 1821;
            this.edGlassSizeY.Text = "0.000";
            this.edGlassSizeY.Value = 0D;
            // 
            // LabelGlassSizeX
            // 
            this.LabelGlassSizeX.BackColor = System.Drawing.Color.Transparent;
            this.LabelGlassSizeX.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelGlassSizeX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelGlassSizeX.Frame.Visible = false;
            this.LabelGlassSizeX.Location = new System.Drawing.Point(59, 128);
            this.LabelGlassSizeX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelGlassSizeX.Name = "LabelGlassSizeX";
            this.LabelGlassSizeX.ShowAccelChar = false;
            this.LabelGlassSizeX.Size = new System.Drawing.Size(103, 29);
            this.LabelGlassSizeX.TabIndex = 1818;
            this.LabelGlassSizeX.Text = "Glass Size";
            this.LabelGlassSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.TabIndex = 1817;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(188, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 64);
            this.pictureBox2.TabIndex = 1814;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(296, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 1815;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(403, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 1816;
            this.pictureBox4.TabStop = false;
            // 
            // ledSortMethod4
            // 
            this.ledSortMethod4.BackColor = System.Drawing.Color.Transparent;
            this.ledSortMethod4.Enabled = false;
            this.ledSortMethod4.Frame.Visible = false;
            this.ledSortMethod4.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledSortMethod4.LED.Size = new System.Drawing.Size(20, 64);
            this.ledSortMethod4.Location = new System.Drawing.Point(376, 265);
            this.ledSortMethod4.Name = "ledSortMethod4";
            this.ledSortMethod4.ShowAccelChar = false;
            this.ledSortMethod4.Size = new System.Drawing.Size(24, 66);
            this.ledSortMethod4.TabIndex = 1813;
            this.ledSortMethod4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod4.Click += new System.EventHandler(this.ledSortMethod4_Click);
            // 
            // ledSortMethod3
            // 
            this.ledSortMethod3.BackColor = System.Drawing.Color.Transparent;
            this.ledSortMethod3.Enabled = false;
            this.ledSortMethod3.Frame.Visible = false;
            this.ledSortMethod3.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledSortMethod3.LED.Size = new System.Drawing.Size(20, 64);
            this.ledSortMethod3.Location = new System.Drawing.Point(269, 265);
            this.ledSortMethod3.Name = "ledSortMethod3";
            this.ledSortMethod3.ShowAccelChar = false;
            this.ledSortMethod3.Size = new System.Drawing.Size(24, 66);
            this.ledSortMethod3.TabIndex = 1812;
            this.ledSortMethod3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod3.Click += new System.EventHandler(this.ledSortMethod3_Click);
            // 
            // ledSortMethod2
            // 
            this.ledSortMethod2.BackColor = System.Drawing.Color.Transparent;
            this.ledSortMethod2.Enabled = false;
            this.ledSortMethod2.Frame.Visible = false;
            this.ledSortMethod2.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledSortMethod2.LED.Size = new System.Drawing.Size(20, 64);
            this.ledSortMethod2.Location = new System.Drawing.Point(162, 265);
            this.ledSortMethod2.Name = "ledSortMethod2";
            this.ledSortMethod2.ShowAccelChar = false;
            this.ledSortMethod2.Size = new System.Drawing.Size(24, 66);
            this.ledSortMethod2.TabIndex = 1811;
            this.ledSortMethod2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod2.Click += new System.EventHandler(this.ledSortMethod2_Click);
            // 
            // ledSortMethod1
            // 
            this.ledSortMethod1.BackColor = System.Drawing.Color.Transparent;
            this.ledSortMethod1.Enabled = false;
            this.ledSortMethod1.Frame.Visible = false;
            this.ledSortMethod1.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledSortMethod1.LED.Size = new System.Drawing.Size(20, 64);
            this.ledSortMethod1.LED.Value = true;
            this.ledSortMethod1.Location = new System.Drawing.Point(55, 265);
            this.ledSortMethod1.Name = "ledSortMethod1";
            this.ledSortMethod1.ShowAccelChar = false;
            this.ledSortMethod1.Size = new System.Drawing.Size(24, 66);
            this.ledSortMethod1.TabIndex = 1810;
            this.ledSortMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod1.Click += new System.EventHandler(this.ledSortMethod1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(11, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 220);
            this.panel2.TabIndex = 1809;
            // 
            // gradLabel58
            // 
            this.gradLabel58.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel58.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel58.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel58.Frame.Visible = false;
            this.gradLabel58.GradientEnable = false;
            this.gradLabel58.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel58.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel58.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel58.Location = new System.Drawing.Point(59, 62);
            this.gradLabel58.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradLabel58.Name = "gradLabel58";
            this.gradLabel58.ShowAccelChar = false;
            this.gradLabel58.Size = new System.Drawing.Size(103, 29);
            this.gradLabel58.TabIndex = 1799;
            this.gradLabel58.Text = "Gap";
            this.gradLabel58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradLabel62
            // 
            this.gradLabel62.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel62.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel62.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel62.GradientEnable = false;
            this.gradLabel62.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel62.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel62.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel62.Location = new System.Drawing.Point(59, 29);
            this.gradLabel62.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradLabel62.Name = "gradLabel62";
            this.gradLabel62.ShowAccelChar = false;
            this.gradLabel62.Size = new System.Drawing.Size(103, 29);
            this.gradLabel62.TabIndex = 1796;
            this.gradLabel62.Text = "Array";
            this.gradLabel62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnApply
            // 
            this.btnApply.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Enabled = false;
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(364, 27);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnApply.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(77, 32);
            this.btnApply.TabIndex = 1791;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // edGapY
            // 
            this.edGapY.BackColor = System.Drawing.Color.White;
            this.edGapY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGapY.DataType = YujinTechnology.DataType.Double;
            this.edGapY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGapY.Frame.CornerRound = 1;
            this.edGapY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGapY.Hint = null;
            this.edGapY.Location = new System.Drawing.Point(265, 62);
            this.edGapY.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edGapY.Max = 100D;
            this.edGapY.Min = 0D;
            this.edGapY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGapY.Name = "edGapY";
            this.edGapY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGapY.PrecisionDigits = 3;
            this.edGapY.ShowHint = false;
            this.edGapY.Size = new System.Drawing.Size(95, 29);
            this.edGapY.TabIndex = 1793;
            this.edGapY.Text = "0.000";
            this.edGapY.Value = 0D;
            // 
            // edYCount
            // 
            this.edYCount.BackColor = System.Drawing.Color.White;
            this.edYCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edYCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edYCount.Frame.CornerRound = 1;
            this.edYCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edYCount.Hint = null;
            this.edYCount.Location = new System.Drawing.Point(265, 29);
            this.edYCount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edYCount.Max = 10D;
            this.edYCount.Min = 0D;
            this.edYCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.edYCount.Name = "edYCount";
            this.edYCount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edYCount.PrecisionDigits = 3;
            this.edYCount.ShowHint = false;
            this.edYCount.Size = new System.Drawing.Size(95, 29);
            this.edYCount.TabIndex = 1794;
            this.edYCount.Text = "0";
            this.edYCount.Value = 0D;
            // 
            // edGapX
            // 
            this.edGapX.BackColor = System.Drawing.Color.White;
            this.edGapX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGapX.DataType = YujinTechnology.DataType.Double;
            this.edGapX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGapX.Frame.CornerRound = 1;
            this.edGapX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGapX.Hint = null;
            this.edGapX.Location = new System.Drawing.Point(166, 62);
            this.edGapX.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edGapX.Max = 100D;
            this.edGapX.Min = 0D;
            this.edGapX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGapX.Name = "edGapX";
            this.edGapX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGapX.PrecisionDigits = 3;
            this.edGapX.ShowHint = false;
            this.edGapX.Size = new System.Drawing.Size(95, 29);
            this.edGapX.TabIndex = 1795;
            this.edGapX.Text = "0.000";
            this.edGapX.Value = 0D;
            // 
            // edXCount
            // 
            this.edXCount.BackColor = System.Drawing.Color.White;
            this.edXCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edXCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edXCount.Frame.CornerRound = 1;
            this.edXCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edXCount.Hint = null;
            this.edXCount.Location = new System.Drawing.Point(166, 29);
            this.edXCount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edXCount.Max = 10D;
            this.edXCount.Min = 0D;
            this.edXCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.edXCount.Name = "edXCount";
            this.edXCount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edXCount.PrecisionDigits = 3;
            this.edXCount.ShowHint = false;
            this.edXCount.Size = new System.Drawing.Size(95, 29);
            this.edXCount.TabIndex = 1792;
            this.edXCount.Text = "0";
            this.edXCount.Value = 0D;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel2.Frame.Visible = false;
            this.gradientLabel2.GradientEnable = false;
            this.gradientLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel2.Location = new System.Drawing.Point(178, 2);
            this.gradientLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.ShowAccelChar = false;
            this.gradientLabel2.Size = new System.Drawing.Size(95, 29);
            this.gradientLabel2.TabIndex = 1798;
            this.gradientLabel2.Text = "X";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientLabel1.Frame.Visible = false;
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(277, 2);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.ShowAccelChar = false;
            this.gradientLabel1.Size = new System.Drawing.Size(95, 29);
            this.gradientLabel1.TabIndex = 1797;
            this.gradientLabel1.Text = "Y";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bitBtn1
            // 
            this.bitBtn1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.bitBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bitBtn1.Enabled = false;
            this.bitBtn1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bitBtn1.ForeColor = System.Drawing.Color.Black;
            this.bitBtn1.Location = new System.Drawing.Point(1095, 648);
            this.bitBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitBtn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bitBtn1.Name = "bitBtn1";
            this.bitBtn1.Size = new System.Drawing.Size(77, 32);
            this.bitBtn1.TabIndex = 1690;
            this.bitBtn1.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1095, 684);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 32);
            this.btnCancel.TabIndex = 1689;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSave.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1012, 648);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 32);
            this.btnSave.TabIndex = 1688;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSizeY
            // 
            this.lblSizeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSizeY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSizeY.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSizeY.Font = new System.Drawing.Font("굴림", 9F);
            this.lblSizeY.ForeColor = System.Drawing.Color.Black;
            this.lblSizeY.Location = new System.Drawing.Point(987, 595);
            this.lblSizeY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSizeY.Name = "lblSizeY";
            this.lblSizeY.Size = new System.Drawing.Size(156, 39);
            this.lblSizeY.TabIndex = 1686;
            this.lblSizeY.Text = "Y : 1000.000";
            this.lblSizeY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSizeY.Visible = false;
            // 
            // lblSizeX
            // 
            this.lblSizeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSizeX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSizeX.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSizeX.Font = new System.Drawing.Font("굴림", 9F);
            this.lblSizeX.ForeColor = System.Drawing.Color.Black;
            this.lblSizeX.Location = new System.Drawing.Point(827, 595);
            this.lblSizeX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSizeX.Name = "lblSizeX";
            this.lblSizeX.Size = new System.Drawing.Size(156, 39);
            this.lblSizeX.TabIndex = 1685;
            this.lblSizeX.Text = "X : 1000.000";
            this.lblSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSizeX.Visible = false;
            // 
            // gradLabel33
            // 
            this.gradLabel33.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel33.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel33.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel33.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel33.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel33.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel33.Location = new System.Drawing.Point(645, 599);
            this.gradLabel33.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradLabel33.Name = "gradLabel33";
            this.gradLabel33.ShowAccelChar = false;
            this.gradLabel33.Size = new System.Drawing.Size(103, 29);
            this.gradLabel33.TabIndex = 1687;
            this.gradLabel33.Text = "Total Size";
            this.gradLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradLabel33.Visible = false;
            // 
            // bitBtn2
            // 
            this.bitBtn2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.bitBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bitBtn2.Enabled = false;
            this.bitBtn2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bitBtn2.ForeColor = System.Drawing.Color.Black;
            this.bitBtn2.Location = new System.Drawing.Point(1012, 684);
            this.bitBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitBtn2.MinimumSize = new System.Drawing.Size(1, 1);
            this.bitBtn2.Name = "bitBtn2";
            this.bitBtn2.Size = new System.Drawing.Size(77, 32);
            this.bitBtn2.TabIndex = 1694;
            this.bitBtn2.UseVisualStyleBackColor = false;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMoveUp.Location = new System.Drawing.Point(600, 465);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(34, 122);
            this.btnMoveUp.TabIndex = 1698;
            this.btnMoveUp.Text = "△";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMoveDown.Location = new System.Drawing.Point(600, 592);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(34, 122);
            this.btnMoveDown.TabIndex = 1697;
            this.btnMoveDown.Text = "▼";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeight = 40;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnColor,
            this.ColumnName,
            this.ColumnUse,
            this.ColumnDir,
            this.ColumnStartPoint});
            this.dataGridView3.Enabled = false;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView3.Location = new System.Drawing.Point(4, 465);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 20;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(591, 249);
            this.dataGridView3.TabIndex = 1696;
            this.dataGridView3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView3_CellFormatting);
            // 
            // ColumnColor
            // 
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.Width = 75;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.Width = 200;
            // 
            // ColumnUse
            // 
            this.ColumnUse.HeaderText = "Use";
            this.ColumnUse.Name = "ColumnUse";
            this.ColumnUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUse.Width = 50;
            // 
            // ColumnDir
            // 
            this.ColumnDir.HeaderText = "Dir";
            this.ColumnDir.Name = "ColumnDir";
            this.ColumnDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDir.Width = 75;
            // 
            // ColumnStartPoint
            // 
            this.ColumnStartPoint.HeaderText = "S.Point";
            this.ColumnStartPoint.Name = "ColumnStartPoint";
            this.ColumnStartPoint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStartPoint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panCad
            // 
            this.panCad.BackColor = System.Drawing.Color.Black;
            this.panCad.Font = new System.Drawing.Font("Tahoma", 11F);
            this.panCad.ForeColor = System.Drawing.Color.White;
            this.panCad.Location = new System.Drawing.Point(4, 38);
            this.panCad.Name = "panCad";
            this.panCad.Size = new System.Drawing.Size(630, 420);
            this.panCad.TabIndex = 1695;
            this.panCad.Text = "CAD는 동적으로 생성";
            // 
            // btnClear
            // 
            this.btnClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(595, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 29);
            this.btnClear.TabIndex = 1702;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOpenFile.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Font = new System.Drawing.Font("굴림", 9F);
            this.btnOpenFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFile.Location = new System.Drawing.Point(554, 4);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(39, 29);
            this.btnOpenFile.TabIndex = 1701;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // lblDxfPath
            // 
            this.lblDxfPath.BackColor = System.Drawing.Color.Transparent;
            this.lblDxfPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDxfPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDxfPath.ForeColor = System.Drawing.Color.Red;
            this.lblDxfPath.Location = new System.Drawing.Point(73, 4);
            this.lblDxfPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDxfPath.MinimizeCaption = true;
            this.lblDxfPath.Name = "lblDxfPath";
            this.lblDxfPath.ShowAccelChar = false;
            this.lblDxfPath.Size = new System.Drawing.Size(475, 29);
            this.lblDxfPath.TabIndex = 1700;
            this.lblDxfPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradLabel13
            // 
            this.gradLabel13.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel13.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel13.Frame.Visible = false;
            this.gradLabel13.GradientEnable = false;
            this.gradLabel13.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel13.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel13.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel13.Location = new System.Drawing.Point(4, 4);
            this.gradLabel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradLabel13.Name = "gradLabel13";
            this.gradLabel13.ShowAccelChar = false;
            this.gradLabel13.Size = new System.Drawing.Size(65, 29);
            this.gradLabel13.TabIndex = 1699;
            this.gradLabel13.Text = "Drawing";
            this.gradLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUse
            // 
            this.btnUse.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUse.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnUse.ForeColor = System.Drawing.Color.Black;
            this.btnUse.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.btnUse.LED.OffColor = System.Drawing.Color.Silver;
            this.btnUse.LED.Size = new System.Drawing.Size(80, 32);
            this.btnUse.Location = new System.Drawing.Point(644, 650);
            this.btnUse.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(107, 62);
            this.btnUse.TabIndex = 1703;
            this.btnUse.Text = "사용";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // panJobType3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblDxfPath);
            this.Controls.Add(this.gradLabel13);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panCad);
            this.Controls.Add(this.bitBtn2);
            this.Controls.Add(this.bitBtn3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bitBtn1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSizeY);
            this.Controls.Add(this.lblSizeX);
            this.Controls.Add(this.gradLabel33);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobType3";
            this.Size = new System.Drawing.Size(1176, 718);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YujinTechnology.BitBtn bitBtn3;
        private YujinTechnology.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private YujinTechnology.Label label1;
        public YujinTechnology.KeypadEdit edThickness;
        private YujinTechnology.GradientLabel gradLabel66;
        public YujinTechnology.KeypadEdit edCellRadius;
        public YujinTechnology.SunnyRadioButton rdoCircle;
        public YujinTechnology.SunnyCheckBox chkBreakLineOutDir;
        public YujinTechnology.SunnyCheckBox chkUseBreakLine;
        public YujinTechnology.KeypadEdit edBreakLineOffset;
        public YujinTechnology.KeypadEdit edBreakLineLength;
        private YujinTechnology.GradientLabel gradLabel76;
        private YujinTechnology.GradientLabel gradLabel77;
        public YujinTechnology.KeypadEdit edCellHeight;
        public YujinTechnology.KeypadEdit edCellWidth;
        private YujinTechnology.GradientLabel lblLabelSize;
        public YujinTechnology.SunnyRadioButton rdoCell;
        public YujinTechnology.ComboBox cbStartPoint;
        private YujinTechnology.Label label4;
        public YujinTechnology.KeypadEdit edPulsePitch;
        public YujinTechnology.KeypadEdit edLaserPower;
        private YujinTechnology.Label label2;
        private YujinTechnology.Label label3;
        public YujinTechnology.KeypadEdit edZOffset;
        private YujinTechnology.Label LabelZOffset;
        private YujinTechnology.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        public YujinTechnology.KeypadEdit edGlassSizeX;
        public YujinTechnology.KeypadEdit edGlassSizeY;
        private YujinTechnology.Label LabelGlassSizeX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public YujinTechnology.LEDLabel ledSortMethod4;
        public YujinTechnology.LEDLabel ledSortMethod3;
        public YujinTechnology.LEDLabel ledSortMethod2;
        public YujinTechnology.LEDLabel ledSortMethod1;
        private System.Windows.Forms.Panel panel2;
        private YujinTechnology.GradientLabel gradLabel58;
        private YujinTechnology.GradientLabel gradLabel62;
        public YujinTechnology.BitBtn btnApply;
        public YujinTechnology.KeypadEdit edGapY;
        public YujinTechnology.KeypadEdit edYCount;
        public YujinTechnology.KeypadEdit edGapX;
        public YujinTechnology.KeypadEdit edXCount;
        private YujinTechnology.GradientLabel gradientLabel2;
        private YujinTechnology.GradientLabel gradientLabel1;
        private YujinTechnology.BitBtn bitBtn1;
        private YujinTechnology.BitBtn btnCancel;
        public YujinTechnology.BitBtn btnSave;
        private System.Windows.Forms.Label lblSizeY;
        private System.Windows.Forms.Label lblSizeX;
        private YujinTechnology.GradientLabel gradLabel33;
        private YujinTechnology.BitBtn bitBtn2;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUse;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDir;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStartPoint;
        public YujinTechnology.Panel panCad;
        private YujinTechnology.Label label6;
        private YujinTechnology.Label label7;
        public YujinTechnology.ValueIndicator viLaserFocus;
        private YujinTechnology.Label viZPosition2;
        public YujinTechnology.BitBtn btnClear;
        public YujinTechnology.BitBtn btnOpenFile;
        public YujinTechnology.Label lblDxfPath;
        private YujinTechnology.GradientLabel gradLabel13;
        public YujinTechnology.LEDButton btnUse;
        public YujinTechnology.BitBtn btnPreView;
        private System.Windows.Forms.CheckBox chkShowJumpline;
    }
}
