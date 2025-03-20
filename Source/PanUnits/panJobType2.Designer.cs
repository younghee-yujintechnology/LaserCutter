using Raize.CodeSiteLogging;

namespace LaserCutter
{
    partial class panJobType2
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
            // logger.SendMsg("panJobType2.Dispose()");

            if (disposing)
            {
                // Cad2 리소스 해제
                if (Cad2 != null)
                {
                    Cad2.Dispose();
                    Cad2 = null;
                }

                // cad1Data 리소스 해제
                if (cad2Data != null)
                {
                    cad2Data.Clear();
                    cad2Data = null;
                }

                // 데이터 그리드 해제
                if (dataGridView2 != null)
                {
                    dataGridView2.Rows.Clear();
                    dataGridView2.Dispose();
                    dataGridView2 = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panJobType2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bitBtn2 = new YujinTechnology.BitBtn();
            this.bitBtn3 = new YujinTechnology.BitBtn();
            this.tabControl1 = new YujinTechnology.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkShowJumpline = new System.Windows.Forms.CheckBox();
            this.viLaserFocus = new YujinTechnology.ValueIndicator();
            this.viZPosition2 = new YujinTechnology.Label();
            this.ledUseVision = new YujinTechnology.LEDLabel();
            this.label6 = new YujinTechnology.Label();
            this.label5 = new YujinTechnology.Label();
            this.edThickness = new YujinTechnology.KeypadEdit();
            this.edManualShiftY = new YujinTechnology.KeypadEdit();
            this.edManualShiftX = new YujinTechnology.KeypadEdit();
            this.edZOffset = new YujinTechnology.KeypadEdit();
            this.LabelShiftY = new YujinTechnology.Label();
            this.LabelShiftX = new YujinTechnology.Label();
            this.LabelZOffset = new YujinTechnology.Label();
            this.label2 = new YujinTechnology.Label();
            this.cbStartPoint = new YujinTechnology.ComboBox();
            this.label4 = new YujinTechnology.Label();
            this.edPulsePitch = new YujinTechnology.KeypadEdit();
            this.edLaserPower = new YujinTechnology.KeypadEdit();
            this.LabelPitch = new YujinTechnology.Label();
            this.LabelPower = new YujinTechnology.Label();
            this.label3 = new YujinTechnology.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreView = new YujinTechnology.BitBtn();
            this.edGlassSizeX = new YujinTechnology.KeypadEdit();
            this.edGlassSizeY = new YujinTechnology.KeypadEdit();
            this.LabelGlassSizeX = new YujinTechnology.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edXCount = new YujinTechnology.KeypadEdit();
            this.edYCount = new YujinTechnology.KeypadEdit();
            this.btnApply = new YujinTechnology.BitBtn();
            this.edGapY = new YujinTechnology.KeypadEdit();
            this.edGapX = new YujinTechnology.KeypadEdit();
            this.gradLabel62 = new YujinTechnology.GradientLabel();
            this.gradLabel58 = new YujinTechnology.GradientLabel();
            this.ledSortMethod4 = new YujinTechnology.LEDLabel();
            this.ledSortMethod3 = new YujinTechnology.LEDLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ledSortMethod2 = new YujinTechnology.LEDLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ledSortMethod1 = new YujinTechnology.LEDLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gradientLabel2 = new YujinTechnology.GradientLabel();
            this.gradientLabel1 = new YujinTechnology.GradientLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkUseIndividualAlign = new System.Windows.Forms.CheckBox();
            this.rdoAlign4P = new System.Windows.Forms.RadioButton();
            this.rdoAlign2P_1_4 = new System.Windows.Forms.RadioButton();
            this.rdoAlign2P_1_3 = new System.Windows.Forms.RadioButton();
            this.rdoAlign2P_1_2 = new System.Windows.Forms.RadioButton();
            this.chkAlignUse = new System.Windows.Forms.CheckBox();
            this.Label1 = new YujinTechnology.Label();
            this.cbCellIndex = new YujinTechnology.ComboBox();
            this.ledAlign1Pos = new YujinTechnology.LEDLabel();
            this.ledAlign2Pos = new YujinTechnology.LEDLabel();
            this.ledAlign4Pos = new YujinTechnology.LEDLabel();
            this.ledAlign3Pos = new YujinTechnology.LEDLabel();
            this.viAlign1PosX = new YujinTechnology.ValueIndicator();
            this.viAlign1PosY = new YujinTechnology.ValueIndicator();
            this.viAlign3PosX = new YujinTechnology.ValueIndicator();
            this.viAlign3PosY = new YujinTechnology.ValueIndicator();
            this.viAlign2PosX = new YujinTechnology.ValueIndicator();
            this.viAlign4PosX = new YujinTechnology.ValueIndicator();
            this.viAlign2PosY = new YujinTechnology.ValueIndicator();
            this.viAlign4PosY = new YujinTechnology.ValueIndicator();
            this.btnMoveAlign1Pos = new YujinTechnology.BitBtn();
            this.btnMoveAlign3Pos = new YujinTechnology.BitBtn();
            this.gradLabel32 = new YujinTechnology.GradientLabel();
            this.btnMoveAlign2Pos = new YujinTechnology.BitBtn();
            this.btnMoveAlign4Pos = new YujinTechnology.BitBtn();
            this.lblAxisY1Y2 = new YujinTechnology.GradientLabel();
            this.ledPMAlignTool = new YujinTechnology.LEDLabel();
            this.bitBtn1 = new YujinTechnology.BitBtn();
            this.btnCancel = new YujinTechnology.BitBtn();
            this.btnSave = new YujinTechnology.BitBtn();
            this.btnClear = new YujinTechnology.BitBtn();
            this.btnOpenFile = new YujinTechnology.BitBtn();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.lblDxfPath = new YujinTechnology.Label();
            this.gradLabel13 = new YujinTechnology.GradientLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDir = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnStartPoint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panCad2 = new YujinTechnology.Panel();
            this.btnUse = new YujinTechnology.LEDButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.bitBtn2.TabIndex = 1686;
            this.bitBtn2.UseVisualStyleBackColor = false;
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
            this.bitBtn3.TabIndex = 1685;
            this.bitBtn3.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabControl1.TabIndex = 1684;
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
            this.tabPage1.Controls.Add(this.ledUseVision);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.edThickness);
            this.tabPage1.Controls.Add(this.edManualShiftY);
            this.tabPage1.Controls.Add(this.edManualShiftX);
            this.tabPage1.Controls.Add(this.edZOffset);
            this.tabPage1.Controls.Add(this.LabelShiftY);
            this.tabPage1.Controls.Add(this.LabelShiftX);
            this.tabPage1.Controls.Add(this.LabelZOffset);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbStartPoint);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.edPulsePitch);
            this.tabPage1.Controls.Add(this.edLaserPower);
            this.tabPage1.Controls.Add(this.LabelPitch);
            this.tabPage1.Controls.Add(this.LabelPower);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 600);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "  가공 속성  ";
            // 
            // chkShowJumpline
            // 
            this.chkShowJumpline.AutoSize = true;
            this.chkShowJumpline.Location = new System.Drawing.Point(10, 398);
            this.chkShowJumpline.Name = "chkShowJumpline";
            this.chkShowJumpline.Size = new System.Drawing.Size(131, 22);
            this.chkShowJumpline.TabIndex = 1781;
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
            this.viLaserFocus.TabIndex = 1780;
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
            this.viZPosition2.TabIndex = 1779;
            this.viZPosition2.Text = "Laser.Focus";
            this.viZPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledUseVision
            // 
            this.ledUseVision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledUseVision.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledUseVision.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledUseVision.Frame.Visible = false;
            this.ledUseVision.LED.OffColor = System.Drawing.Color.Silver;
            this.ledUseVision.LED.Size = new System.Drawing.Size(20, 20);
            this.ledUseVision.Location = new System.Drawing.Point(169, 278);
            this.ledUseVision.Name = "ledUseVision";
            this.ledUseVision.ShowAccelChar = false;
            this.ledUseVision.Size = new System.Drawing.Size(95, 29);
            this.ledUseVision.TabIndex = 1778;
            this.ledUseVision.Text = "Use Vision";
            this.ledUseVision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label6.TabIndex = 1777;
            this.label6.Text = "↑";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label5.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.label5.CaptionStyle.ShadowDirection = YujinTechnology.ShadowDirection.BottomRight;
            this.label5.CaptionStyle.TextStyle = YujinTechnology.TextStyle.Shadow;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Frame.Visible = false;
            this.label5.Location = new System.Drawing.Point(270, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.ShowAccelChar = false;
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 1776;
            this.label5.Text = "Z.Focus : (Thickness + Z.Offset)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edThickness
            // 
            this.edThickness.BackColor = System.Drawing.Color.White;
            this.edThickness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edThickness.DataType = YujinTechnology.DataType.Double;
            this.edThickness.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edThickness.Frame.Bottom = false;
            this.edThickness.Frame.CornerRound = 1;
            this.edThickness.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edThickness.Frame.Top = false;
            this.edThickness.Hint = null;
            this.edThickness.Location = new System.Drawing.Point(367, 71);
            this.edThickness.Margin = new System.Windows.Forms.Padding(4);
            this.edThickness.Max = 0D;
            this.edThickness.Min = 0D;
            this.edThickness.MinimumSize = new System.Drawing.Size(1, 1);
            this.edThickness.Name = "edThickness";
            this.edThickness.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edThickness.PrecisionDigits = 3;
            this.edThickness.ShowHint = false;
            this.edThickness.Size = new System.Drawing.Size(95, 29);
            this.edThickness.TabIndex = 1775;
            this.edThickness.Text = "0.000";
            this.edThickness.Value = 0D;
            // 
            // edManualShiftY
            // 
            this.edManualShiftY.BackColor = System.Drawing.Color.White;
            this.edManualShiftY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edManualShiftY.DataType = YujinTechnology.DataType.Double;
            this.edManualShiftY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edManualShiftY.Frame.Bottom = false;
            this.edManualShiftY.Frame.CornerRound = 1;
            this.edManualShiftY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edManualShiftY.Frame.Top = false;
            this.edManualShiftY.Hint = null;
            this.edManualShiftY.Location = new System.Drawing.Point(367, 203);
            this.edManualShiftY.Margin = new System.Windows.Forms.Padding(4);
            this.edManualShiftY.Max = 0D;
            this.edManualShiftY.Min = 0D;
            this.edManualShiftY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edManualShiftY.Name = "edManualShiftY";
            this.edManualShiftY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edManualShiftY.PrecisionDigits = 3;
            this.edManualShiftY.ShowHint = false;
            this.edManualShiftY.Size = new System.Drawing.Size(95, 29);
            this.edManualShiftY.TabIndex = 1772;
            this.edManualShiftY.Text = "0.000";
            this.edManualShiftY.Value = 0D;
            // 
            // edManualShiftX
            // 
            this.edManualShiftX.BackColor = System.Drawing.Color.White;
            this.edManualShiftX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edManualShiftX.DataType = YujinTechnology.DataType.Double;
            this.edManualShiftX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edManualShiftX.Frame.Bottom = false;
            this.edManualShiftX.Frame.CornerRound = 1;
            this.edManualShiftX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edManualShiftX.Frame.Top = false;
            this.edManualShiftX.Hint = null;
            this.edManualShiftX.Location = new System.Drawing.Point(169, 203);
            this.edManualShiftX.Margin = new System.Windows.Forms.Padding(4);
            this.edManualShiftX.Max = 0D;
            this.edManualShiftX.Min = 0D;
            this.edManualShiftX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edManualShiftX.Name = "edManualShiftX";
            this.edManualShiftX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edManualShiftX.PrecisionDigits = 3;
            this.edManualShiftX.ShowHint = false;
            this.edManualShiftX.Size = new System.Drawing.Size(95, 29);
            this.edManualShiftX.TabIndex = 1771;
            this.edManualShiftX.Text = "0.000";
            this.edManualShiftX.Value = 0D;
            // 
            // edZOffset
            // 
            this.edZOffset.BackColor = System.Drawing.Color.White;
            this.edZOffset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edZOffset.DataType = YujinTechnology.DataType.Double;
            this.edZOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edZOffset.Frame.Bottom = false;
            this.edZOffset.Frame.CornerRound = 1;
            this.edZOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edZOffset.Frame.Top = false;
            this.edZOffset.Hint = null;
            this.edZOffset.Location = new System.Drawing.Point(367, 38);
            this.edZOffset.Margin = new System.Windows.Forms.Padding(4);
            this.edZOffset.Max = 0D;
            this.edZOffset.Min = 0D;
            this.edZOffset.MinimumSize = new System.Drawing.Size(1, 1);
            this.edZOffset.Name = "edZOffset";
            this.edZOffset.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edZOffset.PrecisionDigits = 3;
            this.edZOffset.ShowHint = false;
            this.edZOffset.Size = new System.Drawing.Size(95, 29);
            this.edZOffset.TabIndex = 1773;
            this.edZOffset.Text = "0.000";
            this.edZOffset.Value = 0D;
            // 
            // LabelShiftY
            // 
            this.LabelShiftY.BackColor = System.Drawing.Color.Transparent;
            this.LabelShiftY.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelShiftY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelShiftY.Frame.Visible = false;
            this.LabelShiftY.Location = new System.Drawing.Point(260, 203);
            this.LabelShiftY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelShiftY.Name = "LabelShiftY";
            this.LabelShiftY.ShowAccelChar = false;
            this.LabelShiftY.Size = new System.Drawing.Size(103, 29);
            this.LabelShiftY.TabIndex = 1770;
            this.LabelShiftY.Text = "Shift Y";
            this.LabelShiftY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelShiftX
            // 
            this.LabelShiftX.BackColor = System.Drawing.Color.Transparent;
            this.LabelShiftX.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelShiftX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelShiftX.Frame.Visible = false;
            this.LabelShiftX.Location = new System.Drawing.Point(64, 203);
            this.LabelShiftX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelShiftX.Name = "LabelShiftX";
            this.LabelShiftX.ShowAccelChar = false;
            this.LabelShiftX.Size = new System.Drawing.Size(103, 29);
            this.LabelShiftX.TabIndex = 1768;
            this.LabelShiftX.Text = "Shift X";
            this.LabelShiftX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelZOffset
            // 
            this.LabelZOffset.BackColor = System.Drawing.Color.Transparent;
            this.LabelZOffset.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelZOffset.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelZOffset.Frame.Visible = false;
            this.LabelZOffset.Location = new System.Drawing.Point(271, 38);
            this.LabelZOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelZOffset.Name = "LabelZOffset";
            this.LabelZOffset.ShowAccelChar = false;
            this.LabelZOffset.Size = new System.Drawing.Size(94, 29);
            this.LabelZOffset.TabIndex = 1769;
            this.LabelZOffset.Text = "Z.Offset";
            this.LabelZOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Frame.Visible = false;
            this.label2.Location = new System.Drawing.Point(453, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.ShowAccelChar = false;
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1767;
            this.label2.Text = "[단위 mm]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbStartPoint.TabIndex = 1766;
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
            this.label4.TabIndex = 1765;
            this.label4.Text = "Start Point";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edPulsePitch
            // 
            this.edPulsePitch.BackColor = System.Drawing.Color.White;
            this.edPulsePitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edPulsePitch.DataType = YujinTechnology.DataType.Double;
            this.edPulsePitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPulsePitch.Frame.Bottom = false;
            this.edPulsePitch.Frame.CornerRound = 1;
            this.edPulsePitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPulsePitch.Frame.Top = false;
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
            this.edPulsePitch.TabIndex = 1763;
            this.edPulsePitch.Text = "0.000";
            this.edPulsePitch.Value = 0D;
            // 
            // edLaserPower
            // 
            this.edLaserPower.BackColor = System.Drawing.Color.White;
            this.edLaserPower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edLaserPower.DataType = YujinTechnology.DataType.Double;
            this.edLaserPower.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edLaserPower.Frame.Bottom = false;
            this.edLaserPower.Frame.CornerRound = 1;
            this.edLaserPower.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLaserPower.Frame.Top = false;
            this.edLaserPower.Hint = null;
            this.edLaserPower.Location = new System.Drawing.Point(169, 38);
            this.edLaserPower.Margin = new System.Windows.Forms.Padding(4);
            this.edLaserPower.Max = 0D;
            this.edLaserPower.Min = 0D;
            this.edLaserPower.MinimumSize = new System.Drawing.Size(1, 1);
            this.edLaserPower.Name = "edLaserPower";
            this.edLaserPower.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edLaserPower.PrecisionDigits = 3;
            this.edLaserPower.ShowHint = true;
            this.edLaserPower.Size = new System.Drawing.Size(95, 29);
            this.edLaserPower.TabIndex = 1764;
            this.edLaserPower.Text = "0.000";
            this.edLaserPower.Value = 0D;
            // 
            // LabelPitch
            // 
            this.LabelPitch.BackColor = System.Drawing.Color.Transparent;
            this.LabelPitch.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelPitch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelPitch.Frame.Visible = false;
            this.LabelPitch.Location = new System.Drawing.Point(62, 71);
            this.LabelPitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelPitch.Name = "LabelPitch";
            this.LabelPitch.ShowAccelChar = false;
            this.LabelPitch.Size = new System.Drawing.Size(103, 29);
            this.LabelPitch.TabIndex = 1762;
            this.LabelPitch.Text = "Pulse.Pitch";
            this.LabelPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPower
            // 
            this.LabelPower.BackColor = System.Drawing.Color.Transparent;
            this.LabelPower.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelPower.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelPower.Frame.Visible = false;
            this.LabelPower.Location = new System.Drawing.Point(64, 38);
            this.LabelPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelPower.Name = "LabelPower";
            this.LabelPower.ShowAccelChar = false;
            this.LabelPower.Size = new System.Drawing.Size(103, 29);
            this.LabelPower.TabIndex = 1761;
            this.LabelPower.Text = "Laser.Power";
            this.LabelPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Frame.Visible = false;
            this.label3.Location = new System.Drawing.Point(262, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.ShowAccelChar = false;
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 1774;
            this.label3.Text = "Thickness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "    Array Info    ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnPreView);
            this.panel1.Controls.Add(this.edGlassSizeX);
            this.panel1.Controls.Add(this.edGlassSizeY);
            this.panel1.Controls.Add(this.LabelGlassSizeX);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.edXCount);
            this.panel1.Controls.Add(this.edYCount);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.edGapY);
            this.panel1.Controls.Add(this.edGapX);
            this.panel1.Controls.Add(this.gradLabel62);
            this.panel1.Controls.Add(this.gradLabel58);
            this.panel1.Controls.Add(this.ledSortMethod4);
            this.panel1.Controls.Add(this.ledSortMethod3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ledSortMethod2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ledSortMethod1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 578);
            this.panel1.TabIndex = 1763;
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
            this.btnPreView.TabIndex = 1840;
            this.btnPreView.Text = "미리보기";
            this.btnPreView.UseVisualStyleBackColor = false;
            // 
            // edGlassSizeX
            // 
            this.edGlassSizeX.BackColor = System.Drawing.Color.White;
            this.edGlassSizeX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGlassSizeX.DataType = YujinTechnology.DataType.Double;
            this.edGlassSizeX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGlassSizeX.Frame.Bottom = false;
            this.edGlassSizeX.Frame.CornerRound = 1;
            this.edGlassSizeX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGlassSizeX.Frame.Top = false;
            this.edGlassSizeX.Hint = null;
            this.edGlassSizeX.Location = new System.Drawing.Point(166, 128);
            this.edGlassSizeX.Margin = new System.Windows.Forms.Padding(4);
            this.edGlassSizeX.Max = 0D;
            this.edGlassSizeX.Min = 0D;
            this.edGlassSizeX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGlassSizeX.Name = "edGlassSizeX";
            this.edGlassSizeX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGlassSizeX.PrecisionDigits = 3;
            this.edGlassSizeX.ShowHint = false;
            this.edGlassSizeX.Size = new System.Drawing.Size(95, 29);
            this.edGlassSizeX.TabIndex = 1761;
            this.edGlassSizeX.Text = "0.000";
            this.edGlassSizeX.Value = 0D;
            // 
            // edGlassSizeY
            // 
            this.edGlassSizeY.BackColor = System.Drawing.Color.White;
            this.edGlassSizeY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGlassSizeY.DataType = YujinTechnology.DataType.Double;
            this.edGlassSizeY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGlassSizeY.Frame.Bottom = false;
            this.edGlassSizeY.Frame.CornerRound = 1;
            this.edGlassSizeY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGlassSizeY.Frame.Top = false;
            this.edGlassSizeY.Hint = null;
            this.edGlassSizeY.Location = new System.Drawing.Point(265, 128);
            this.edGlassSizeY.Margin = new System.Windows.Forms.Padding(4);
            this.edGlassSizeY.Max = 0D;
            this.edGlassSizeY.Min = 0D;
            this.edGlassSizeY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGlassSizeY.Name = "edGlassSizeY";
            this.edGlassSizeY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGlassSizeY.PrecisionDigits = 3;
            this.edGlassSizeY.ShowHint = false;
            this.edGlassSizeY.Size = new System.Drawing.Size(95, 29);
            this.edGlassSizeY.TabIndex = 1762;
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
            this.LabelGlassSizeX.Size = new System.Drawing.Size(104, 29);
            this.LabelGlassSizeX.TabIndex = 1759;
            this.LabelGlassSizeX.Text = "Glass Size";
            this.LabelGlassSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(11, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 220);
            this.panel2.TabIndex = 1753;
            // 
            // edXCount
            // 
            this.edXCount.BackColor = System.Drawing.Color.White;
            this.edXCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edXCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edXCount.Frame.Bottom = false;
            this.edXCount.Frame.CornerRound = 1;
            this.edXCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edXCount.Frame.Top = false;
            this.edXCount.Hint = null;
            this.edXCount.Location = new System.Drawing.Point(166, 29);
            this.edXCount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edXCount.Max = 0D;
            this.edXCount.Min = 0D;
            this.edXCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.edXCount.Name = "edXCount";
            this.edXCount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edXCount.PrecisionDigits = 3;
            this.edXCount.ShowHint = true;
            this.edXCount.Size = new System.Drawing.Size(95, 29);
            this.edXCount.TabIndex = 1752;
            this.edXCount.Text = "0";
            this.edXCount.Value = 0D;
            // 
            // edYCount
            // 
            this.edYCount.BackColor = System.Drawing.Color.White;
            this.edYCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edYCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edYCount.Frame.Bottom = false;
            this.edYCount.Frame.CornerRound = 1;
            this.edYCount.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edYCount.Frame.Top = false;
            this.edYCount.Hint = null;
            this.edYCount.Location = new System.Drawing.Point(265, 29);
            this.edYCount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edYCount.Max = 0D;
            this.edYCount.Min = 0D;
            this.edYCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.edYCount.Name = "edYCount";
            this.edYCount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edYCount.PrecisionDigits = 3;
            this.edYCount.ShowHint = true;
            this.edYCount.Size = new System.Drawing.Size(95, 29);
            this.edYCount.TabIndex = 1751;
            this.edYCount.Text = "0";
            this.edYCount.Value = 0D;
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
            this.btnApply.TabIndex = 1750;
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
            this.edGapY.Frame.Bottom = false;
            this.edGapY.Frame.CornerRound = 1;
            this.edGapY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGapY.Frame.Top = false;
            this.edGapY.Hint = null;
            this.edGapY.Location = new System.Drawing.Point(265, 62);
            this.edGapY.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edGapY.Max = 0D;
            this.edGapY.Min = 0D;
            this.edGapY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGapY.Name = "edGapY";
            this.edGapY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGapY.PrecisionDigits = 3;
            this.edGapY.ShowHint = true;
            this.edGapY.Size = new System.Drawing.Size(95, 29);
            this.edGapY.TabIndex = 1746;
            this.edGapY.Text = "0.000";
            this.edGapY.Value = 0D;
            // 
            // edGapX
            // 
            this.edGapX.BackColor = System.Drawing.Color.White;
            this.edGapX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGapX.DataType = YujinTechnology.DataType.Double;
            this.edGapX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGapX.Frame.Bottom = false;
            this.edGapX.Frame.CornerRound = 1;
            this.edGapX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGapX.Frame.Top = false;
            this.edGapX.Hint = null;
            this.edGapX.Location = new System.Drawing.Point(166, 62);
            this.edGapX.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.edGapX.Max = 0D;
            this.edGapX.Min = 0D;
            this.edGapX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGapX.Name = "edGapX";
            this.edGapX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGapX.PrecisionDigits = 3;
            this.edGapX.ShowHint = true;
            this.edGapX.Size = new System.Drawing.Size(95, 29);
            this.edGapX.TabIndex = 1747;
            this.edGapX.Text = "0.000";
            this.edGapX.Value = 0D;
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
            this.gradLabel62.TabIndex = 1744;
            this.gradLabel62.Text = "Array";
            this.gradLabel62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.gradLabel58.TabIndex = 1745;
            this.gradLabel58.Text = "Gap";
            this.gradLabel58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ledSortMethod4.TabIndex = 1743;
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
            this.ledSortMethod3.TabIndex = 1742;
            this.ledSortMethod3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod3.Click += new System.EventHandler(this.ledSortMethod3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.TabIndex = 1739;
            this.pictureBox1.TabStop = false;
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
            this.ledSortMethod2.TabIndex = 1741;
            this.ledSortMethod2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod2.Click += new System.EventHandler(this.ledSortMethod2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(188, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 64);
            this.pictureBox2.TabIndex = 1736;
            this.pictureBox2.TabStop = false;
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
            this.ledSortMethod1.TabIndex = 1740;
            this.ledSortMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledSortMethod1.Click += new System.EventHandler(this.ledSortMethod1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(296, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 1737;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(403, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 1738;
            this.pictureBox4.TabStop = false;
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
            this.gradientLabel2.TabIndex = 1749;
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
            this.gradientLabel1.TabIndex = 1748;
            this.gradientLabel1.Text = "Y";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.chkUseIndividualAlign);
            this.tabPage3.Controls.Add(this.rdoAlign4P);
            this.tabPage3.Controls.Add(this.rdoAlign2P_1_4);
            this.tabPage3.Controls.Add(this.rdoAlign2P_1_3);
            this.tabPage3.Controls.Add(this.rdoAlign2P_1_2);
            this.tabPage3.Controls.Add(this.chkAlignUse);
            this.tabPage3.Controls.Add(this.Label1);
            this.tabPage3.Controls.Add(this.cbCellIndex);
            this.tabPage3.Controls.Add(this.ledAlign1Pos);
            this.tabPage3.Controls.Add(this.ledAlign2Pos);
            this.tabPage3.Controls.Add(this.ledAlign4Pos);
            this.tabPage3.Controls.Add(this.ledAlign3Pos);
            this.tabPage3.Controls.Add(this.viAlign1PosX);
            this.tabPage3.Controls.Add(this.viAlign1PosY);
            this.tabPage3.Controls.Add(this.viAlign3PosX);
            this.tabPage3.Controls.Add(this.viAlign3PosY);
            this.tabPage3.Controls.Add(this.viAlign2PosX);
            this.tabPage3.Controls.Add(this.viAlign4PosX);
            this.tabPage3.Controls.Add(this.viAlign2PosY);
            this.tabPage3.Controls.Add(this.viAlign4PosY);
            this.tabPage3.Controls.Add(this.btnMoveAlign1Pos);
            this.tabPage3.Controls.Add(this.btnMoveAlign3Pos);
            this.tabPage3.Controls.Add(this.gradLabel32);
            this.tabPage3.Controls.Add(this.btnMoveAlign2Pos);
            this.tabPage3.Controls.Add(this.btnMoveAlign4Pos);
            this.tabPage3.Controls.Add(this.lblAxisY1Y2);
            this.tabPage3.Controls.Add(this.ledPMAlignTool);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 600);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "  Vision Align  ";
            // 
            // chkUseIndividualAlign
            // 
            this.chkUseIndividualAlign.AutoSize = true;
            this.chkUseIndividualAlign.Location = new System.Drawing.Point(329, 86);
            this.chkUseIndividualAlign.Name = "chkUseIndividualAlign";
            this.chkUseIndividualAlign.Size = new System.Drawing.Size(118, 22);
            this.chkUseIndividualAlign.TabIndex = 1663;
            this.chkUseIndividualAlign.Text = "개별 Align 사용";
            this.chkUseIndividualAlign.UseVisualStyleBackColor = true;
            // 
            // rdoAlign4P
            // 
            this.rdoAlign4P.AutoSize = true;
            this.rdoAlign4P.Location = new System.Drawing.Point(174, 223);
            this.rdoAlign4P.Name = "rdoAlign4P";
            this.rdoAlign4P.Size = new System.Drawing.Size(183, 22);
            this.rdoAlign4P.TabIndex = 1662;
            this.rdoAlign4P.TabStop = true;
            this.rdoAlign4P.Text = "Align 4P(Align1 ~ Align4)";
            this.rdoAlign4P.UseVisualStyleBackColor = true;
            // 
            // rdoAlign2P_1_4
            // 
            this.rdoAlign2P_1_4.AutoSize = true;
            this.rdoAlign2P_1_4.Location = new System.Drawing.Point(174, 170);
            this.rdoAlign2P_1_4.Name = "rdoAlign2P_1_4";
            this.rdoAlign2P_1_4.Size = new System.Drawing.Size(177, 22);
            this.rdoAlign2P_1_4.TabIndex = 1661;
            this.rdoAlign2P_1_4.TabStop = true;
            this.rdoAlign2P_1_4.Text = "Align 2P(Align1 - Align4)";
            this.rdoAlign2P_1_4.UseVisualStyleBackColor = true;
            // 
            // rdoAlign2P_1_3
            // 
            this.rdoAlign2P_1_3.AutoSize = true;
            this.rdoAlign2P_1_3.Location = new System.Drawing.Point(174, 142);
            this.rdoAlign2P_1_3.Name = "rdoAlign2P_1_3";
            this.rdoAlign2P_1_3.Size = new System.Drawing.Size(177, 22);
            this.rdoAlign2P_1_3.TabIndex = 1660;
            this.rdoAlign2P_1_3.TabStop = true;
            this.rdoAlign2P_1_3.Text = "Align 2P(Align1 - Align3)";
            this.rdoAlign2P_1_3.UseVisualStyleBackColor = true;
            // 
            // rdoAlign2P_1_2
            // 
            this.rdoAlign2P_1_2.AutoSize = true;
            this.rdoAlign2P_1_2.Location = new System.Drawing.Point(174, 114);
            this.rdoAlign2P_1_2.Name = "rdoAlign2P_1_2";
            this.rdoAlign2P_1_2.Size = new System.Drawing.Size(177, 22);
            this.rdoAlign2P_1_2.TabIndex = 1659;
            this.rdoAlign2P_1_2.TabStop = true;
            this.rdoAlign2P_1_2.Text = "Align 2P(Align1 - Align2)";
            this.rdoAlign2P_1_2.UseVisualStyleBackColor = true;
            // 
            // chkAlignUse
            // 
            this.chkAlignUse.AutoSize = true;
            this.chkAlignUse.Location = new System.Drawing.Point(147, 86);
            this.chkAlignUse.Name = "chkAlignUse";
            this.chkAlignUse.Size = new System.Drawing.Size(86, 22);
            this.chkAlignUse.TabIndex = 1658;
            this.chkAlignUse.Text = "Align Use";
            this.chkAlignUse.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Label1.Frame.Visible = false;
            this.Label1.Location = new System.Drawing.Point(68, 283);
            this.Label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Label1.Name = "Label1";
            this.Label1.ShowAccelChar = false;
            this.Label1.Size = new System.Drawing.Size(103, 29);
            this.Label1.TabIndex = 1657;
            this.Label1.Text = "Cell Index";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCellIndex
            // 
            this.cbCellIndex.BackColor = System.Drawing.Color.White;
            this.cbCellIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCellIndex.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbCellIndex.Frame.Bottom = false;
            this.cbCellIndex.Frame.CornerRound = 1;
            this.cbCellIndex.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cbCellIndex.Frame.Top = false;
            this.cbCellIndex.Hint = null;
            this.cbCellIndex.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom"});
            this.cbCellIndex.Location = new System.Drawing.Point(176, 283);
            this.cbCellIndex.Name = "cbCellIndex";
            this.cbCellIndex.ShowHint = false;
            this.cbCellIndex.Size = new System.Drawing.Size(95, 29);
            this.cbCellIndex.TabIndex = 1656;
            this.cbCellIndex.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledAlign1Pos
            // 
            this.ledAlign1Pos.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign1Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledAlign1Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign1Pos.Frame.Visible = false;
            this.ledAlign1Pos.LED.Size = new System.Drawing.Size(10, 20);
            this.ledAlign1Pos.Location = new System.Drawing.Point(109, 350);
            this.ledAlign1Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ledAlign1Pos.Name = "ledAlign1Pos";
            this.ledAlign1Pos.ShowAccelChar = false;
            this.ledAlign1Pos.Size = new System.Drawing.Size(62, 29);
            this.ledAlign1Pos.TabIndex = 1653;
            this.ledAlign1Pos.Text = "Align 1";
            this.ledAlign1Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign2Pos
            // 
            this.ledAlign2Pos.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign2Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledAlign2Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign2Pos.Frame.Visible = false;
            this.ledAlign2Pos.LED.Size = new System.Drawing.Size(10, 20);
            this.ledAlign2Pos.Location = new System.Drawing.Point(109, 383);
            this.ledAlign2Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ledAlign2Pos.Name = "ledAlign2Pos";
            this.ledAlign2Pos.ShowAccelChar = false;
            this.ledAlign2Pos.Size = new System.Drawing.Size(62, 29);
            this.ledAlign2Pos.TabIndex = 1652;
            this.ledAlign2Pos.Text = "Align 2";
            this.ledAlign2Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign4Pos
            // 
            this.ledAlign4Pos.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign4Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledAlign4Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign4Pos.Frame.Visible = false;
            this.ledAlign4Pos.LED.Size = new System.Drawing.Size(10, 20);
            this.ledAlign4Pos.Location = new System.Drawing.Point(109, 449);
            this.ledAlign4Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ledAlign4Pos.Name = "ledAlign4Pos";
            this.ledAlign4Pos.ShowAccelChar = false;
            this.ledAlign4Pos.Size = new System.Drawing.Size(62, 29);
            this.ledAlign4Pos.TabIndex = 1654;
            this.ledAlign4Pos.Text = "Align 4";
            this.ledAlign4Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign3Pos
            // 
            this.ledAlign3Pos.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign3Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledAlign3Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign3Pos.Frame.Visible = false;
            this.ledAlign3Pos.LED.Size = new System.Drawing.Size(10, 20);
            this.ledAlign3Pos.Location = new System.Drawing.Point(109, 416);
            this.ledAlign3Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ledAlign3Pos.Name = "ledAlign3Pos";
            this.ledAlign3Pos.ShowAccelChar = false;
            this.ledAlign3Pos.Size = new System.Drawing.Size(62, 29);
            this.ledAlign3Pos.TabIndex = 1655;
            this.ledAlign3Pos.Text = "Align 3";
            this.ledAlign3Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viAlign1PosX
            // 
            this.viAlign1PosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1PosX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign1PosX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign1PosX.FormatString = "0.000";
            this.viAlign1PosX.Frame.Bottom = false;
            this.viAlign1PosX.Frame.CornerRound = 1;
            this.viAlign1PosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign1PosX.Frame.Top = false;
            this.viAlign1PosX.Location = new System.Drawing.Point(176, 350);
            this.viAlign1PosX.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign1PosX.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign1PosX.Name = "viAlign1PosX";
            this.viAlign1PosX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign1PosX.ShowAccelChar = false;
            this.viAlign1PosX.Size = new System.Drawing.Size(95, 29);
            this.viAlign1PosX.TabIndex = 1645;
            this.viAlign1PosX.Text = "0";
            this.viAlign1PosX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign1PosY
            // 
            this.viAlign1PosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1PosY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign1PosY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign1PosY.FormatString = "0.000";
            this.viAlign1PosY.Frame.Bottom = false;
            this.viAlign1PosY.Frame.CornerRound = 1;
            this.viAlign1PosY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign1PosY.Frame.Top = false;
            this.viAlign1PosY.Location = new System.Drawing.Point(275, 350);
            this.viAlign1PosY.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign1PosY.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign1PosY.Name = "viAlign1PosY";
            this.viAlign1PosY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign1PosY.ShowAccelChar = false;
            this.viAlign1PosY.Size = new System.Drawing.Size(95, 29);
            this.viAlign1PosY.TabIndex = 1644;
            this.viAlign1PosY.Text = "0";
            this.viAlign1PosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3PosX
            // 
            this.viAlign3PosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3PosX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign3PosX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign3PosX.FormatString = "0.000";
            this.viAlign3PosX.Frame.Bottom = false;
            this.viAlign3PosX.Frame.CornerRound = 1;
            this.viAlign3PosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign3PosX.Frame.Top = false;
            this.viAlign3PosX.Location = new System.Drawing.Point(176, 416);
            this.viAlign3PosX.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign3PosX.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign3PosX.Name = "viAlign3PosX";
            this.viAlign3PosX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign3PosX.ShowAccelChar = false;
            this.viAlign3PosX.Size = new System.Drawing.Size(95, 29);
            this.viAlign3PosX.TabIndex = 1649;
            this.viAlign3PosX.Text = "0";
            this.viAlign3PosX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3PosY
            // 
            this.viAlign3PosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3PosY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign3PosY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign3PosY.FormatString = "0.000";
            this.viAlign3PosY.Frame.Bottom = false;
            this.viAlign3PosY.Frame.CornerRound = 1;
            this.viAlign3PosY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign3PosY.Frame.Top = false;
            this.viAlign3PosY.Location = new System.Drawing.Point(275, 416);
            this.viAlign3PosY.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign3PosY.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign3PosY.Name = "viAlign3PosY";
            this.viAlign3PosY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign3PosY.ShowAccelChar = false;
            this.viAlign3PosY.Size = new System.Drawing.Size(95, 29);
            this.viAlign3PosY.TabIndex = 1648;
            this.viAlign3PosY.Text = "0";
            this.viAlign3PosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2PosX
            // 
            this.viAlign2PosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2PosX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign2PosX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign2PosX.FormatString = "0.000";
            this.viAlign2PosX.Frame.Bottom = false;
            this.viAlign2PosX.Frame.CornerRound = 1;
            this.viAlign2PosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign2PosX.Frame.Top = false;
            this.viAlign2PosX.Location = new System.Drawing.Point(176, 383);
            this.viAlign2PosX.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign2PosX.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign2PosX.Name = "viAlign2PosX";
            this.viAlign2PosX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign2PosX.ShowAccelChar = false;
            this.viAlign2PosX.Size = new System.Drawing.Size(95, 29);
            this.viAlign2PosX.TabIndex = 1647;
            this.viAlign2PosX.Text = "0";
            this.viAlign2PosX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign4PosX
            // 
            this.viAlign4PosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4PosX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign4PosX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign4PosX.FormatString = "0.000";
            this.viAlign4PosX.Frame.Bottom = false;
            this.viAlign4PosX.Frame.CornerRound = 1;
            this.viAlign4PosX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign4PosX.Frame.Top = false;
            this.viAlign4PosX.Location = new System.Drawing.Point(176, 449);
            this.viAlign4PosX.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign4PosX.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign4PosX.Name = "viAlign4PosX";
            this.viAlign4PosX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign4PosX.ShowAccelChar = false;
            this.viAlign4PosX.Size = new System.Drawing.Size(95, 29);
            this.viAlign4PosX.TabIndex = 1651;
            this.viAlign4PosX.Text = "0";
            this.viAlign4PosX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2PosY
            // 
            this.viAlign2PosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2PosY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign2PosY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign2PosY.FormatString = "0.000";
            this.viAlign2PosY.Frame.Bottom = false;
            this.viAlign2PosY.Frame.CornerRound = 1;
            this.viAlign2PosY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign2PosY.Frame.Top = false;
            this.viAlign2PosY.Location = new System.Drawing.Point(275, 383);
            this.viAlign2PosY.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign2PosY.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign2PosY.Name = "viAlign2PosY";
            this.viAlign2PosY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign2PosY.ShowAccelChar = false;
            this.viAlign2PosY.Size = new System.Drawing.Size(95, 29);
            this.viAlign2PosY.TabIndex = 1646;
            this.viAlign2PosY.Text = "0";
            this.viAlign2PosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign4PosY
            // 
            this.viAlign4PosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4PosY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viAlign4PosY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.viAlign4PosY.FormatString = "0.000";
            this.viAlign4PosY.Frame.Bottom = false;
            this.viAlign4PosY.Frame.CornerRound = 1;
            this.viAlign4PosY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viAlign4PosY.Frame.Top = false;
            this.viAlign4PosY.Location = new System.Drawing.Point(275, 449);
            this.viAlign4PosY.Margin = new System.Windows.Forms.Padding(4);
            this.viAlign4PosY.MinimumSize = new System.Drawing.Size(1, 1);
            this.viAlign4PosY.Name = "viAlign4PosY";
            this.viAlign4PosY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viAlign4PosY.ShowAccelChar = false;
            this.viAlign4PosY.Size = new System.Drawing.Size(95, 29);
            this.viAlign4PosY.TabIndex = 1650;
            this.viAlign4PosY.Text = "0";
            this.viAlign4PosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveAlign1Pos
            // 
            this.btnMoveAlign1Pos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveAlign1Pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveAlign1Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMoveAlign1Pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAlign1Pos.Enabled = false;
            this.btnMoveAlign1Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign1Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign1Pos.Location = new System.Drawing.Point(373, 349);
            this.btnMoveAlign1Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign1Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign1Pos.Name = "btnMoveAlign1Pos";
            this.btnMoveAlign1Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign1Pos.TabIndex = 1638;
            this.btnMoveAlign1Pos.Text = "Move";
            this.btnMoveAlign1Pos.UseVisualStyleBackColor = false;
            this.btnMoveAlign1Pos.Click += new System.EventHandler(this.btnMoveAlign1Pos_Click);
            // 
            // btnMoveAlign3Pos
            // 
            this.btnMoveAlign3Pos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveAlign3Pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveAlign3Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMoveAlign3Pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAlign3Pos.Enabled = false;
            this.btnMoveAlign3Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign3Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign3Pos.Location = new System.Drawing.Point(373, 415);
            this.btnMoveAlign3Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign3Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign3Pos.Name = "btnMoveAlign3Pos";
            this.btnMoveAlign3Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign3Pos.TabIndex = 1642;
            this.btnMoveAlign3Pos.Text = "Move";
            this.btnMoveAlign3Pos.UseVisualStyleBackColor = false;
            this.btnMoveAlign3Pos.Click += new System.EventHandler(this.btnMoveAlign3Pos_Click);
            // 
            // gradLabel32
            // 
            this.gradLabel32.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel32.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel32.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradLabel32.GradientEnable = false;
            this.gradLabel32.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel32.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel32.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel32.Location = new System.Drawing.Point(176, 317);
            this.gradLabel32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradLabel32.Name = "gradLabel32";
            this.gradLabel32.ShowAccelChar = false;
            this.gradLabel32.Size = new System.Drawing.Size(95, 29);
            this.gradLabel32.TabIndex = 1639;
            this.gradLabel32.Text = "X";
            this.gradLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveAlign2Pos
            // 
            this.btnMoveAlign2Pos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveAlign2Pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveAlign2Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMoveAlign2Pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAlign2Pos.Enabled = false;
            this.btnMoveAlign2Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign2Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign2Pos.Location = new System.Drawing.Point(373, 382);
            this.btnMoveAlign2Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign2Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign2Pos.Name = "btnMoveAlign2Pos";
            this.btnMoveAlign2Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign2Pos.TabIndex = 1641;
            this.btnMoveAlign2Pos.Text = "Move";
            this.btnMoveAlign2Pos.UseVisualStyleBackColor = false;
            this.btnMoveAlign2Pos.Click += new System.EventHandler(this.btnMoveAlign2Pos_Click);
            // 
            // btnMoveAlign4Pos
            // 
            this.btnMoveAlign4Pos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveAlign4Pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveAlign4Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMoveAlign4Pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAlign4Pos.Enabled = false;
            this.btnMoveAlign4Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign4Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign4Pos.Location = new System.Drawing.Point(373, 448);
            this.btnMoveAlign4Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign4Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign4Pos.Name = "btnMoveAlign4Pos";
            this.btnMoveAlign4Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign4Pos.TabIndex = 1643;
            this.btnMoveAlign4Pos.Text = "Move";
            this.btnMoveAlign4Pos.UseVisualStyleBackColor = false;
            this.btnMoveAlign4Pos.Click += new System.EventHandler(this.btnMoveAlign4Pos_Click);
            // 
            // lblAxisY1Y2
            // 
            this.lblAxisY1Y2.BackColor = System.Drawing.Color.Transparent;
            this.lblAxisY1Y2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.lblAxisY1Y2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblAxisY1Y2.GradientEnable = false;
            this.lblAxisY1Y2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.lblAxisY1Y2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblAxisY1Y2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.lblAxisY1Y2.Location = new System.Drawing.Point(275, 317);
            this.lblAxisY1Y2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAxisY1Y2.Name = "lblAxisY1Y2";
            this.lblAxisY1Y2.ShowAccelChar = false;
            this.lblAxisY1Y2.Size = new System.Drawing.Size(95, 29);
            this.lblAxisY1Y2.TabIndex = 1640;
            this.lblAxisY1Y2.Text = "Y";
            this.lblAxisY1Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledPMAlignTool
            // 
            this.ledPMAlignTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledPMAlignTool.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledPMAlignTool.Enabled = false;
            this.ledPMAlignTool.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledPMAlignTool.Frame.Visible = false;
            this.ledPMAlignTool.LED.OffColor = System.Drawing.Color.Red;
            this.ledPMAlignTool.LED.Size = new System.Drawing.Size(20, 20);
            this.ledPMAlignTool.LED.Value = true;
            this.ledPMAlignTool.Location = new System.Drawing.Point(67, 53);
            this.ledPMAlignTool.Name = "ledPMAlignTool";
            this.ledPMAlignTool.ShowAccelChar = false;
            this.ledPMAlignTool.Size = new System.Drawing.Size(104, 30);
            this.ledPMAlignTool.TabIndex = 1621;
            this.ledPMAlignTool.Text = "PMAlignTool";
            this.ledPMAlignTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bitBtn1.TabIndex = 1682;
            this.bitBtn1.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1095, 684);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 32);
            this.btnCancel.TabIndex = 1681;
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
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1012, 648);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 32);
            this.btnSave.TabIndex = 1680;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClear.Location = new System.Drawing.Point(595, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 29);
            this.btnClear.TabIndex = 1694;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOpenFile.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOpenFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFile.Location = new System.Drawing.Point(554, 4);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(39, 29);
            this.btnOpenFile.TabIndex = 1693;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMoveUp.Location = new System.Drawing.Point(600, 465);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(34, 122);
            this.btnMoveUp.TabIndex = 1692;
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
            this.btnMoveDown.TabIndex = 1691;
            this.btnMoveDown.Text = "▼";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
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
            this.lblDxfPath.TabIndex = 1690;
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
            this.gradLabel13.TabIndex = 1689;
            this.gradLabel13.Text = "Drawing";
            this.gradLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnColor,
            this.ColumnName,
            this.ColumnUse,
            this.ColumnDir,
            this.ColumnStartPoint});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.Location = new System.Drawing.Point(4, 465);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(591, 249);
            this.dataGridView2.TabIndex = 1688;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // ColumnColor
            // 
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.Width = 150;
            // 
            // ColumnUse
            // 
            this.ColumnUse.HeaderText = "Use";
            this.ColumnUse.Name = "ColumnUse";
            this.ColumnUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnUse.Width = 50;
            // 
            // ColumnDir
            // 
            this.ColumnDir.HeaderText = "Dir";
            this.ColumnDir.Name = "ColumnDir";
            this.ColumnDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnStartPoint
            // 
            this.ColumnStartPoint.HeaderText = "S.Point";
            this.ColumnStartPoint.Name = "ColumnStartPoint";
            this.ColumnStartPoint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStartPoint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panCad2
            // 
            this.panCad2.BackColor = System.Drawing.Color.Black;
            this.panCad2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.panCad2.ForeColor = System.Drawing.Color.White;
            this.panCad2.Location = new System.Drawing.Point(4, 38);
            this.panCad2.Name = "panCad2";
            this.panCad2.Size = new System.Drawing.Size(630, 420);
            this.panCad2.TabIndex = 1687;
            this.panCad2.Text = "CAD는 동적으로 생성";
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
            this.btnUse.TabIndex = 1704;
            this.btnUse.Text = "사용";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // panJobType2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.lblDxfPath);
            this.Controls.Add(this.gradLabel13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panCad2);
            this.Controls.Add(this.bitBtn2);
            this.Controls.Add(this.bitBtn3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bitBtn1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobType2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1176, 718);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YujinTechnology.BitBtn bitBtn2;
        private YujinTechnology.BitBtn bitBtn3;
        private YujinTechnology.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public YujinTechnology.KeypadEdit edThickness;
        public YujinTechnology.KeypadEdit edManualShiftY;
        public YujinTechnology.KeypadEdit edManualShiftX;
        public YujinTechnology.KeypadEdit edZOffset;
        private YujinTechnology.Label LabelShiftY;
        private YujinTechnology.Label LabelShiftX;
        private YujinTechnology.Label LabelZOffset;
        private YujinTechnology.Label label2;
        public YujinTechnology.ComboBox cbStartPoint;
        private YujinTechnology.Label label4;
        public YujinTechnology.KeypadEdit edPulsePitch;
        public YujinTechnology.KeypadEdit edLaserPower;
        private YujinTechnology.Label LabelPitch;
        private YujinTechnology.Label LabelPower;
        private YujinTechnology.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        public YujinTechnology.KeypadEdit edGlassSizeX;
        public YujinTechnology.KeypadEdit edGlassSizeY;
        private YujinTechnology.Label LabelGlassSizeX;
        private System.Windows.Forms.Panel panel2;
        public YujinTechnology.KeypadEdit edXCount;
        public YujinTechnology.KeypadEdit edYCount;
        public YujinTechnology.BitBtn btnApply;
        public YujinTechnology.KeypadEdit edGapY;
        public YujinTechnology.KeypadEdit edGapX;
        private YujinTechnology.GradientLabel gradLabel62;
        private YujinTechnology.GradientLabel gradLabel58;
        public YujinTechnology.LEDLabel ledSortMethod4;
        public YujinTechnology.LEDLabel ledSortMethod3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public YujinTechnology.LEDLabel ledSortMethod2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public YujinTechnology.LEDLabel ledSortMethod1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private YujinTechnology.GradientLabel gradientLabel2;
        private YujinTechnology.GradientLabel gradientLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private YujinTechnology.Label Label1;
        public YujinTechnology.ComboBox cbCellIndex;
        public YujinTechnology.LEDLabel ledAlign1Pos;
        public YujinTechnology.LEDLabel ledAlign2Pos;
        public YujinTechnology.LEDLabel ledAlign4Pos;
        public YujinTechnology.LEDLabel ledAlign3Pos;
        public YujinTechnology.ValueIndicator viAlign1PosX;
        public YujinTechnology.ValueIndicator viAlign1PosY;
        public YujinTechnology.ValueIndicator viAlign3PosX;
        public YujinTechnology.ValueIndicator viAlign3PosY;
        public YujinTechnology.ValueIndicator viAlign2PosX;
        public YujinTechnology.ValueIndicator viAlign4PosX;
        public YujinTechnology.ValueIndicator viAlign2PosY;
        public YujinTechnology.ValueIndicator viAlign4PosY;
        private YujinTechnology.BitBtn btnMoveAlign1Pos;
        private YujinTechnology.BitBtn btnMoveAlign3Pos;
        private YujinTechnology.GradientLabel gradLabel32;
        private YujinTechnology.BitBtn btnMoveAlign2Pos;
        private YujinTechnology.BitBtn btnMoveAlign4Pos;
        private YujinTechnology.GradientLabel lblAxisY1Y2;
        public YujinTechnology.LEDLabel ledPMAlignTool;
        private YujinTechnology.BitBtn bitBtn1;
        private YujinTechnology.BitBtn btnCancel;
        public YujinTechnology.BitBtn btnClear;
        public YujinTechnology.BitBtn btnOpenFile;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        public YujinTechnology.Label lblDxfPath;
        private YujinTechnology.GradientLabel gradLabel13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnUse;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDir;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStartPoint;
        public YujinTechnology.Panel panCad2;
        private YujinTechnology.Label label6;
        private YujinTechnology.Label label5;
        public YujinTechnology.LEDLabel ledUseVision;
        public YujinTechnology.BitBtn btnSave;
        public YujinTechnology.ValueIndicator viLaserFocus;
        private YujinTechnology.Label viZPosition2;
        public YujinTechnology.LEDButton btnUse;
        public System.Windows.Forms.CheckBox chkUseIndividualAlign;
        public System.Windows.Forms.RadioButton rdoAlign4P;
        public System.Windows.Forms.RadioButton rdoAlign2P_1_4;
        public System.Windows.Forms.RadioButton rdoAlign2P_1_3;
        public System.Windows.Forms.RadioButton rdoAlign2P_1_2;
        public System.Windows.Forms.CheckBox chkAlignUse;
        public YujinTechnology.BitBtn btnPreView;
        private System.Windows.Forms.CheckBox chkShowJumpline;
    }
}
