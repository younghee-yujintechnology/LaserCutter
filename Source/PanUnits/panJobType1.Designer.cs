using Raize.CodeSiteLogging;
using System.Windows.Forms;

namespace LaserCutter
{
    partial class panJobType1
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
            // logger.SendMsg("panJobType1.Dispose()");

            if (disposing)
            {
                // Cad1 리소스 해제
                if (Cad1 != null)
                {
                    Cad1.Clear();
                    Cad1.Dispose();
                    Cad1 = null;
                }

                // Cad1Data 리소스 해제
                if (cad1Data != null)
                {
                    cad1Data.Clear();
                    cad1Data = null;
                }

                // 데이터 그리드 해제
                if (dataGridView1 != null)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Dispose();
                    dataGridView1 = null;
                }

                // 디자이너에서 생성된 components 해제
                if (components != null)
                {
                    components.Dispose();
                }
            }

            // 기반 클래스의 Dispose 호출
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bitBtn3 = new DaekhonSystem.BitBtn();
            this.bitBtn2 = new DaekhonSystem.BitBtn();
            this.bitBtn1 = new DaekhonSystem.BitBtn();
            this.btnCancel = new DaekhonSystem.BitBtn();
            this.btnSave = new DaekhonSystem.BitBtn();
            this.tabControl1 = new DaekhonSystem.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkShowJumpline = new System.Windows.Forms.CheckBox();
            this.viLaserFocus = new DaekhonSystem.ValueIndicator();
            this.viZPosition2 = new DaekhonSystem.Label();
            this.label6 = new DaekhonSystem.Label();
            this.edThickness = new DaekhonSystem.KeypadEdit();
            this.label2 = new DaekhonSystem.Label();
            this.label1 = new DaekhonSystem.Label();
            this.ledUseVision = new DaekhonSystem.LEDLabel();
            this.cbStartPoint = new DaekhonSystem.ComboBox();
            this.label4 = new DaekhonSystem.Label();
            this.edManualShiftY = new DaekhonSystem.KeypadEdit();
            this.edGlassSizeX = new DaekhonSystem.KeypadEdit();
            this.edGlassSizeY = new DaekhonSystem.KeypadEdit();
            this.edPulsePitch = new DaekhonSystem.KeypadEdit();
            this.edLaserPower = new DaekhonSystem.KeypadEdit();
            this.edManualShiftX = new DaekhonSystem.KeypadEdit();
            this.edZOffset = new DaekhonSystem.KeypadEdit();
            this.LabelGlassSizeY = new DaekhonSystem.Label();
            this.LabelPitch = new DaekhonSystem.Label();
            this.LabelManualShiftY = new DaekhonSystem.Label();
            this.LabelGlassSizeX = new DaekhonSystem.Label();
            this.LabelPower = new DaekhonSystem.Label();
            this.LabelManualShiftX = new DaekhonSystem.Label();
            this.LabelZOffset = new DaekhonSystem.Label();
            this.label5 = new DaekhonSystem.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkUseIndividualAlign = new System.Windows.Forms.CheckBox();
            this.rdoAlign4P = new System.Windows.Forms.RadioButton();
            this.rdoAlign2P_1_4 = new System.Windows.Forms.RadioButton();
            this.rdoAlign2P_1_3 = new System.Windows.Forms.RadioButton();
            this.rdoAlign2P_1_2 = new System.Windows.Forms.RadioButton();
            this.chkAlignUse = new System.Windows.Forms.CheckBox();
            this.ledAlign1Pos = new DaekhonSystem.LEDLabel();
            this.ledAlign2Pos = new DaekhonSystem.LEDLabel();
            this.ledAlign4Pos = new DaekhonSystem.LEDLabel();
            this.ledAlign3Pos = new DaekhonSystem.LEDLabel();
            this.viAlign1PosX = new DaekhonSystem.ValueIndicator();
            this.viAlign1PosY = new DaekhonSystem.ValueIndicator();
            this.viAlign3PosX = new DaekhonSystem.ValueIndicator();
            this.viAlign3PosY = new DaekhonSystem.ValueIndicator();
            this.viAlign2PosX = new DaekhonSystem.ValueIndicator();
            this.viAlign4PosX = new DaekhonSystem.ValueIndicator();
            this.viAlign2PosY = new DaekhonSystem.ValueIndicator();
            this.viAlign4PosY = new DaekhonSystem.ValueIndicator();
            this.btnMoveAlign1Pos = new DaekhonSystem.BitBtn();
            this.btnMoveAlign3Pos = new DaekhonSystem.BitBtn();
            this.gradLabel32 = new DaekhonSystem.GradientLabel();
            this.btnMoveAlign2Pos = new DaekhonSystem.BitBtn();
            this.btnMoveAlign4Pos = new DaekhonSystem.BitBtn();
            this.lblAxisY1Y2 = new DaekhonSystem.GradientLabel();
            this.ledPMAlignTool = new DaekhonSystem.LEDLabel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnClear = new DaekhonSystem.BitBtn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDir = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnStartPoint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panCad = new DaekhonSystem.Panel();
            this.btnOpenFile = new DaekhonSystem.BitBtn();
            this.lblDxfPath = new DaekhonSystem.Label();
            this.gradLabel13 = new DaekhonSystem.GradientLabel();
            this.btnUse = new DaekhonSystem.LEDButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.bitBtn3.TabIndex = 1610;
            this.bitBtn3.UseVisualStyleBackColor = false;
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
            this.bitBtn2.TabIndex = 1609;
            this.bitBtn2.UseVisualStyleBackColor = false;
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
            this.bitBtn1.TabIndex = 1608;
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
            this.btnCancel.TabIndex = 1607;
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
            this.btnSave.TabIndex = 1606;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.tabControl1.TabIndex = 1612;
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
            this.tabPage1.Controls.Add(this.edThickness);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ledUseVision);
            this.tabPage1.Controls.Add(this.cbStartPoint);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.edManualShiftY);
            this.tabPage1.Controls.Add(this.edGlassSizeX);
            this.tabPage1.Controls.Add(this.edGlassSizeY);
            this.tabPage1.Controls.Add(this.edPulsePitch);
            this.tabPage1.Controls.Add(this.edLaserPower);
            this.tabPage1.Controls.Add(this.edManualShiftX);
            this.tabPage1.Controls.Add(this.edZOffset);
            this.tabPage1.Controls.Add(this.LabelGlassSizeY);
            this.tabPage1.Controls.Add(this.LabelPitch);
            this.tabPage1.Controls.Add(this.LabelManualShiftY);
            this.tabPage1.Controls.Add(this.LabelGlassSizeX);
            this.tabPage1.Controls.Add(this.LabelPower);
            this.tabPage1.Controls.Add(this.LabelManualShiftX);
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
            this.chkShowJumpline.TabIndex = 1629;
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
            this.viLaserFocus.TabIndex = 1628;
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
            this.viZPosition2.TabIndex = 1622;
            this.viZPosition2.Text = "Laser.Focus";
            this.viZPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label6.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.label6.CaptionStyle.ShadowDirection = DaekhonSystem.ShadowDirection.BottomRight;
            this.label6.CaptionStyle.TextStyle = DaekhonSystem.TextStyle.Shadow;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Frame.Visible = false;
            this.label6.Location = new System.Drawing.Point(479, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Name = "label6";
            this.label6.ShowAccelChar = false;
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 1621;
            this.label6.Text = "↑";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edThickness
            // 
            this.edThickness.BackColor = System.Drawing.Color.White;
            this.edThickness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edThickness.DataType = DaekhonSystem.DataType.Double;
            this.edThickness.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edThickness.Frame.CornerRound = 1;
            this.edThickness.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edThickness.Hint = "0.0 < Thickness < 34mm";
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
            this.edThickness.TabIndex = 1619;
            this.edThickness.Text = "0.000";
            this.edThickness.Value = 0D;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Frame.Visible = false;
            this.label2.Location = new System.Drawing.Point(265, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.ShowAccelChar = false;
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1618;
            this.label2.Text = "Thickness";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label1.TabIndex = 1617;
            this.label1.Text = "[단위 mm]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ledUseVision.TabIndex = 1616;
            this.ledUseVision.Text = "Use Vision";
            this.ledUseVision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cbStartPoint.TabIndex = 1611;
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
            this.label4.TabIndex = 1610;
            this.label4.Text = "Start Point";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edManualShiftY
            // 
            this.edManualShiftY.BackColor = System.Drawing.Color.White;
            this.edManualShiftY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edManualShiftY.DataType = DaekhonSystem.DataType.Double;
            this.edManualShiftY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edManualShiftY.Frame.CornerRound = 1;
            this.edManualShiftY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edManualShiftY.Hint = "-5.0 < Shift Y < 5.0 mm";
            this.edManualShiftY.Location = new System.Drawing.Point(367, 203);
            this.edManualShiftY.Margin = new System.Windows.Forms.Padding(4);
            this.edManualShiftY.Max = 0D;
            this.edManualShiftY.Min = 0D;
            this.edManualShiftY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edManualShiftY.Name = "edManualShiftY";
            this.edManualShiftY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edManualShiftY.PrecisionDigits = 3;
            this.edManualShiftY.ShowHint = true;
            this.edManualShiftY.Size = new System.Drawing.Size(95, 29);
            this.edManualShiftY.TabIndex = 1589;
            this.edManualShiftY.Text = "0.000";
            this.edManualShiftY.Value = 0D;
            // 
            // edGlassSizeX
            // 
            this.edGlassSizeX.BackColor = System.Drawing.Color.White;
            this.edGlassSizeX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGlassSizeX.DataType = DaekhonSystem.DataType.Double;
            this.edGlassSizeX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGlassSizeX.Frame.CornerRound = 1;
            this.edGlassSizeX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGlassSizeX.Hint = null;
            this.edGlassSizeX.Location = new System.Drawing.Point(169, 236);
            this.edGlassSizeX.Margin = new System.Windows.Forms.Padding(4);
            this.edGlassSizeX.Max = 0D;
            this.edGlassSizeX.Min = 0D;
            this.edGlassSizeX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGlassSizeX.Name = "edGlassSizeX";
            this.edGlassSizeX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGlassSizeX.PrecisionDigits = 3;
            this.edGlassSizeX.ShowHint = true;
            this.edGlassSizeX.Size = new System.Drawing.Size(95, 29);
            this.edGlassSizeX.TabIndex = 1592;
            this.edGlassSizeX.Text = "0.000";
            this.edGlassSizeX.Value = 0D;
            // 
            // edGlassSizeY
            // 
            this.edGlassSizeY.BackColor = System.Drawing.Color.White;
            this.edGlassSizeY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGlassSizeY.DataType = DaekhonSystem.DataType.Double;
            this.edGlassSizeY.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGlassSizeY.Frame.CornerRound = 1;
            this.edGlassSizeY.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGlassSizeY.Hint = null;
            this.edGlassSizeY.Location = new System.Drawing.Point(367, 236);
            this.edGlassSizeY.Margin = new System.Windows.Forms.Padding(4);
            this.edGlassSizeY.Max = 0D;
            this.edGlassSizeY.Min = 0D;
            this.edGlassSizeY.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGlassSizeY.Name = "edGlassSizeY";
            this.edGlassSizeY.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGlassSizeY.PrecisionDigits = 3;
            this.edGlassSizeY.ShowHint = true;
            this.edGlassSizeY.Size = new System.Drawing.Size(95, 29);
            this.edGlassSizeY.TabIndex = 1593;
            this.edGlassSizeY.Text = "0.000";
            this.edGlassSizeY.Value = 0D;
            // 
            // edPulsePitch
            // 
            this.edPulsePitch.BackColor = System.Drawing.Color.White;
            this.edPulsePitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edPulsePitch.DataType = DaekhonSystem.DataType.Double;
            this.edPulsePitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPulsePitch.Frame.CornerRound = 1;
            this.edPulsePitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPulsePitch.Hint = "0.0 < PulsePitch < 3.0";
            this.edPulsePitch.Location = new System.Drawing.Point(169, 71);
            this.edPulsePitch.Margin = new System.Windows.Forms.Padding(4);
            this.edPulsePitch.Max = 0D;
            this.edPulsePitch.Min = 0D;
            this.edPulsePitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.edPulsePitch.Name = "edPulsePitch";
            this.edPulsePitch.NewText = "0.000";
            this.edPulsePitch.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edPulsePitch.PrecisionDigits = 3;
            this.edPulsePitch.ShowHint = true;
            this.edPulsePitch.Size = new System.Drawing.Size(95, 29);
            this.edPulsePitch.TabIndex = 1594;
            this.edPulsePitch.Text = "0.000";
            this.edPulsePitch.Value = 0D;
            // 
            // edLaserPower
            // 
            this.edLaserPower.BackColor = System.Drawing.Color.White;
            this.edLaserPower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edLaserPower.DataType = DaekhonSystem.DataType.Double;
            this.edLaserPower.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edLaserPower.Frame.CornerRound = 1;
            this.edLaserPower.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLaserPower.Hint = "0.0 < LaserPower (w) < 100.0";
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
            this.edLaserPower.TabIndex = 1595;
            this.edLaserPower.Text = "0.000";
            this.edLaserPower.Value = 0D;
            // 
            // edManualShiftX
            // 
            this.edManualShiftX.BackColor = System.Drawing.Color.White;
            this.edManualShiftX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edManualShiftX.DataType = DaekhonSystem.DataType.Double;
            this.edManualShiftX.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edManualShiftX.Frame.CornerRound = 1;
            this.edManualShiftX.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edManualShiftX.Hint = "-5.0 < Shift X < 5.0 mm";
            this.edManualShiftX.Location = new System.Drawing.Point(169, 203);
            this.edManualShiftX.Margin = new System.Windows.Forms.Padding(4);
            this.edManualShiftX.Max = 0D;
            this.edManualShiftX.Min = 0D;
            this.edManualShiftX.MinimumSize = new System.Drawing.Size(1, 1);
            this.edManualShiftX.Name = "edManualShiftX";
            this.edManualShiftX.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edManualShiftX.PrecisionDigits = 3;
            this.edManualShiftX.ShowHint = true;
            this.edManualShiftX.Size = new System.Drawing.Size(95, 29);
            this.edManualShiftX.TabIndex = 1588;
            this.edManualShiftX.Text = "0.000";
            this.edManualShiftX.Value = 0D;
            // 
            // edZOffset
            // 
            this.edZOffset.BackColor = System.Drawing.Color.White;
            this.edZOffset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edZOffset.DataType = DaekhonSystem.DataType.Double;
            this.edZOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edZOffset.Frame.CornerRound = 1;
            this.edZOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edZOffset.Hint = null;
            this.edZOffset.Location = new System.Drawing.Point(367, 38);
            this.edZOffset.Margin = new System.Windows.Forms.Padding(4);
            this.edZOffset.Max = 0D;
            this.edZOffset.Min = 0D;
            this.edZOffset.MinimumSize = new System.Drawing.Size(1, 1);
            this.edZOffset.Name = "edZOffset";
            this.edZOffset.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edZOffset.PrecisionDigits = 3;
            this.edZOffset.ShowHint = true;
            this.edZOffset.Size = new System.Drawing.Size(95, 29);
            this.edZOffset.TabIndex = 1590;
            this.edZOffset.Text = "0.000";
            this.edZOffset.Value = 0D;
            // 
            // LabelGlassSizeY
            // 
            this.LabelGlassSizeY.BackColor = System.Drawing.Color.Transparent;
            this.LabelGlassSizeY.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelGlassSizeY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelGlassSizeY.Frame.Visible = false;
            this.LabelGlassSizeY.Location = new System.Drawing.Point(286, 236);
            this.LabelGlassSizeY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelGlassSizeY.Name = "LabelGlassSizeY";
            this.LabelGlassSizeY.ShowAccelChar = false;
            this.LabelGlassSizeY.Size = new System.Drawing.Size(77, 29);
            this.LabelGlassSizeY.TabIndex = 1587;
            this.LabelGlassSizeY.Text = "Glass Size Y";
            this.LabelGlassSizeY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.LabelPitch.TabIndex = 1586;
            this.LabelPitch.Text = "Pulse.Pitch";
            this.LabelPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelManualShiftY
            // 
            this.LabelManualShiftY.BackColor = System.Drawing.Color.Transparent;
            this.LabelManualShiftY.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelManualShiftY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelManualShiftY.Frame.Visible = false;
            this.LabelManualShiftY.Location = new System.Drawing.Point(260, 203);
            this.LabelManualShiftY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelManualShiftY.Name = "LabelManualShiftY";
            this.LabelManualShiftY.ShowAccelChar = false;
            this.LabelManualShiftY.Size = new System.Drawing.Size(103, 29);
            this.LabelManualShiftY.TabIndex = 1584;
            this.LabelManualShiftY.Text = "Shift Y";
            this.LabelManualShiftY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelGlassSizeX
            // 
            this.LabelGlassSizeX.BackColor = System.Drawing.Color.Transparent;
            this.LabelGlassSizeX.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelGlassSizeX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelGlassSizeX.Frame.Visible = false;
            this.LabelGlassSizeX.Location = new System.Drawing.Point(64, 236);
            this.LabelGlassSizeX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelGlassSizeX.Name = "LabelGlassSizeX";
            this.LabelGlassSizeX.ShowAccelChar = false;
            this.LabelGlassSizeX.Size = new System.Drawing.Size(103, 29);
            this.LabelGlassSizeX.TabIndex = 1582;
            this.LabelGlassSizeX.Text = "Glass Size X";
            this.LabelGlassSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPower
            // 
            this.LabelPower.BackColor = System.Drawing.Color.Transparent;
            this.LabelPower.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelPower.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelPower.Frame.Visible = false;
            this.LabelPower.Location = new System.Drawing.Point(46, 38);
            this.LabelPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelPower.Name = "LabelPower";
            this.LabelPower.ShowAccelChar = false;
            this.LabelPower.Size = new System.Drawing.Size(121, 29);
            this.LabelPower.TabIndex = 1583;
            this.LabelPower.Text = "Laser.Power";
            this.LabelPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelManualShiftX
            // 
            this.LabelManualShiftX.BackColor = System.Drawing.Color.Transparent;
            this.LabelManualShiftX.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelManualShiftX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelManualShiftX.Frame.Visible = false;
            this.LabelManualShiftX.Location = new System.Drawing.Point(64, 203);
            this.LabelManualShiftX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelManualShiftX.Name = "LabelManualShiftX";
            this.LabelManualShiftX.ShowAccelChar = false;
            this.LabelManualShiftX.Size = new System.Drawing.Size(103, 29);
            this.LabelManualShiftX.TabIndex = 1580;
            this.LabelManualShiftX.Text = "Shift X";
            this.LabelManualShiftX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelZOffset
            // 
            this.LabelZOffset.BackColor = System.Drawing.Color.Transparent;
            this.LabelZOffset.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.LabelZOffset.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelZOffset.Frame.Visible = false;
            this.LabelZOffset.Location = new System.Drawing.Point(262, 38);
            this.LabelZOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelZOffset.Name = "LabelZOffset";
            this.LabelZOffset.ShowAccelChar = false;
            this.LabelZOffset.Size = new System.Drawing.Size(103, 29);
            this.LabelZOffset.TabIndex = 1581;
            this.LabelZOffset.Text = "Z.Offset";
            this.LabelZOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label5.CaptionStyle.ShadowColor = System.Drawing.Color.Black;
            this.label5.CaptionStyle.ShadowDirection = DaekhonSystem.ShadowDirection.BottomRight;
            this.label5.CaptionStyle.TextStyle = DaekhonSystem.TextStyle.Shadow;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Frame.Visible = false;
            this.label5.Location = new System.Drawing.Point(270, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.ShowAccelChar = false;
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 1620;
            this.label5.Text = "Z.Focus : (Thickness + Z.Offset)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.chkUseIndividualAlign);
            this.tabPage2.Controls.Add(this.rdoAlign4P);
            this.tabPage2.Controls.Add(this.rdoAlign2P_1_4);
            this.tabPage2.Controls.Add(this.rdoAlign2P_1_3);
            this.tabPage2.Controls.Add(this.rdoAlign2P_1_2);
            this.tabPage2.Controls.Add(this.chkAlignUse);
            this.tabPage2.Controls.Add(this.ledAlign1Pos);
            this.tabPage2.Controls.Add(this.ledAlign2Pos);
            this.tabPage2.Controls.Add(this.ledAlign4Pos);
            this.tabPage2.Controls.Add(this.ledAlign3Pos);
            this.tabPage2.Controls.Add(this.viAlign1PosX);
            this.tabPage2.Controls.Add(this.viAlign1PosY);
            this.tabPage2.Controls.Add(this.viAlign3PosX);
            this.tabPage2.Controls.Add(this.viAlign3PosY);
            this.tabPage2.Controls.Add(this.viAlign2PosX);
            this.tabPage2.Controls.Add(this.viAlign4PosX);
            this.tabPage2.Controls.Add(this.viAlign2PosY);
            this.tabPage2.Controls.Add(this.viAlign4PosY);
            this.tabPage2.Controls.Add(this.btnMoveAlign1Pos);
            this.tabPage2.Controls.Add(this.btnMoveAlign3Pos);
            this.tabPage2.Controls.Add(this.gradLabel32);
            this.tabPage2.Controls.Add(this.btnMoveAlign2Pos);
            this.tabPage2.Controls.Add(this.btnMoveAlign4Pos);
            this.tabPage2.Controls.Add(this.lblAxisY1Y2);
            this.tabPage2.Controls.Add(this.ledPMAlignTool);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Vision Align  ";
            // 
            // chkUseIndividualAlign
            // 
            this.chkUseIndividualAlign.AutoSize = true;
            this.chkUseIndividualAlign.Location = new System.Drawing.Point(329, 86);
            this.chkUseIndividualAlign.Name = "chkUseIndividualAlign";
            this.chkUseIndividualAlign.Size = new System.Drawing.Size(118, 22);
            this.chkUseIndividualAlign.TabIndex = 1644;
            this.chkUseIndividualAlign.Text = "개별 Align 사용";
            this.chkUseIndividualAlign.UseVisualStyleBackColor = true;
            // 
            // rdoAlign4P
            // 
            this.rdoAlign4P.AutoSize = true;
            this.rdoAlign4P.Location = new System.Drawing.Point(174, 223);
            this.rdoAlign4P.Name = "rdoAlign4P";
            this.rdoAlign4P.Size = new System.Drawing.Size(183, 22);
            this.rdoAlign4P.TabIndex = 1643;
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
            this.rdoAlign2P_1_4.TabIndex = 1642;
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
            this.rdoAlign2P_1_3.TabIndex = 1641;
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
            this.rdoAlign2P_1_2.TabIndex = 1640;
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
            this.chkAlignUse.TabIndex = 1639;
            this.chkAlignUse.Text = "Align Use";
            this.chkAlignUse.UseVisualStyleBackColor = true;
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
            this.ledAlign1Pos.TabIndex = 1635;
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
            this.ledAlign2Pos.TabIndex = 1634;
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
            this.ledAlign4Pos.TabIndex = 1636;
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
            this.ledAlign3Pos.TabIndex = 1637;
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
            this.viAlign1PosX.TabIndex = 1627;
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
            this.viAlign1PosY.TabIndex = 1626;
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
            this.viAlign3PosX.TabIndex = 1631;
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
            this.viAlign3PosY.TabIndex = 1630;
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
            this.viAlign2PosX.TabIndex = 1629;
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
            this.viAlign4PosX.TabIndex = 1633;
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
            this.viAlign2PosY.TabIndex = 1628;
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
            this.viAlign4PosY.TabIndex = 1632;
            this.viAlign4PosY.Text = "0";
            this.viAlign4PosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveAlign1Pos
            // 
            this.btnMoveAlign1Pos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveAlign1Pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveAlign1Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMoveAlign1Pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAlign1Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign1Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign1Pos.Location = new System.Drawing.Point(373, 349);
            this.btnMoveAlign1Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign1Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign1Pos.Name = "btnMoveAlign1Pos";
            this.btnMoveAlign1Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign1Pos.TabIndex = 1620;
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
            this.btnMoveAlign3Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign3Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign3Pos.Location = new System.Drawing.Point(373, 415);
            this.btnMoveAlign3Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign3Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign3Pos.Name = "btnMoveAlign3Pos";
            this.btnMoveAlign3Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign3Pos.TabIndex = 1624;
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
            this.gradLabel32.TabIndex = 1621;
            this.gradLabel32.Text = "X";
            this.gradLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveAlign2Pos
            // 
            this.btnMoveAlign2Pos.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnMoveAlign2Pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMoveAlign2Pos.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnMoveAlign2Pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAlign2Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign2Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign2Pos.Location = new System.Drawing.Point(373, 382);
            this.btnMoveAlign2Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign2Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign2Pos.Name = "btnMoveAlign2Pos";
            this.btnMoveAlign2Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign2Pos.TabIndex = 1623;
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
            this.btnMoveAlign4Pos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnMoveAlign4Pos.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAlign4Pos.Location = new System.Drawing.Point(373, 448);
            this.btnMoveAlign4Pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveAlign4Pos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveAlign4Pos.Name = "btnMoveAlign4Pos";
            this.btnMoveAlign4Pos.Size = new System.Drawing.Size(66, 30);
            this.btnMoveAlign4Pos.TabIndex = 1625;
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
            this.lblAxisY1Y2.TabIndex = 1622;
            this.lblAxisY1Y2.Text = "Y";
            this.lblAxisY1Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledPMAlignTool
            // 
            this.ledPMAlignTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledPMAlignTool.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.ledPMAlignTool.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledPMAlignTool.Frame.Visible = false;
            this.ledPMAlignTool.LED.OffColor = System.Drawing.Color.Red;
            this.ledPMAlignTool.LED.Size = new System.Drawing.Size(20, 20);
            this.ledPMAlignTool.LED.Value = true;
            this.ledPMAlignTool.Location = new System.Drawing.Point(67, 53);
            this.ledPMAlignTool.Name = "ledPMAlignTool";
            this.ledPMAlignTool.ShowAccelChar = false;
            this.ledPMAlignTool.Size = new System.Drawing.Size(104, 30);
            this.ledPMAlignTool.TabIndex = 1615;
            this.ledPMAlignTool.Text = "PMAlignTool";
            this.ledPMAlignTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMoveUp.Location = new System.Drawing.Point(600, 465);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(34, 122);
            this.btnMoveUp.TabIndex = 1620;
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
            this.btnMoveDown.TabIndex = 1619;
            this.btnMoveDown.Text = "▼";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnClear
            // 
            this.btnClear.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(595, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 29);
            this.btnClear.TabIndex = 1618;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnColor,
            this.ColumnName,
            this.ColumnUse,
            this.ColumnDir,
            this.ColumnStartPoint});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Location = new System.Drawing.Point(4, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(591, 249);
            this.dataGridView1.TabIndex = 1617;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            // panCad
            // 
            this.panCad.BackColor = System.Drawing.Color.Black;
            this.panCad.Font = new System.Drawing.Font("Tahoma", 11F);
            this.panCad.ForeColor = System.Drawing.Color.White;
            this.panCad.Location = new System.Drawing.Point(4, 38);
            this.panCad.Name = "panCad";
            this.panCad.Size = new System.Drawing.Size(630, 420);
            this.panCad.TabIndex = 1616;
            this.panCad.Text = "CAD는 동적으로 생성";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOpenFile.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOpenFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFile.Location = new System.Drawing.Point(554, 4);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(39, 29);
            this.btnOpenFile.TabIndex = 1615;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
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
            this.lblDxfPath.TabIndex = 1614;
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
            this.gradLabel13.TabIndex = 1613;
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
            this.btnUse.LED.Layout = DaekhonSystem.LEDLayout.Center;
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
            // panJobType1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panCad);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblDxfPath);
            this.Controls.Add(this.gradLabel13);
            this.Controls.Add(this.bitBtn3);
            this.Controls.Add(this.bitBtn2);
            this.Controls.Add(this.bitBtn1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobType1";
            this.Size = new System.Drawing.Size(1176, 718);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DaekhonSystem.BitBtn bitBtn3;
        private DaekhonSystem.BitBtn bitBtn2;
        private DaekhonSystem.BitBtn bitBtn1;
        private DaekhonSystem.BitBtn btnCancel;
        private DaekhonSystem.TabControl tabControl1;
        private TabPage tabPage1;
        public DaekhonSystem.KeypadEdit edThickness;
        private DaekhonSystem.Label label2;
        private DaekhonSystem.Label label1;
        public DaekhonSystem.LEDLabel ledUseVision;
        public DaekhonSystem.ComboBox cbStartPoint;
        private DaekhonSystem.Label label4;
        public DaekhonSystem.KeypadEdit edManualShiftY;
        public DaekhonSystem.KeypadEdit edGlassSizeX;
        public DaekhonSystem.KeypadEdit edGlassSizeY;
        public DaekhonSystem.KeypadEdit edPulsePitch;
        public DaekhonSystem.KeypadEdit edLaserPower;
        public DaekhonSystem.KeypadEdit edManualShiftX;
        public DaekhonSystem.KeypadEdit edZOffset;
        private DaekhonSystem.Label LabelGlassSizeY;
        private DaekhonSystem.Label LabelPitch;
        private DaekhonSystem.Label LabelManualShiftY;
        private DaekhonSystem.Label LabelGlassSizeX;
        private DaekhonSystem.Label LabelPower;
        private DaekhonSystem.Label LabelManualShiftX;
        private DaekhonSystem.Label LabelZOffset;
        private TabPage tabPage2;
        public DaekhonSystem.LEDLabel ledAlign1Pos;
        public DaekhonSystem.LEDLabel ledAlign2Pos;
        public DaekhonSystem.LEDLabel ledAlign4Pos;
        public DaekhonSystem.LEDLabel ledAlign3Pos;
        public DaekhonSystem.ValueIndicator viAlign1PosX;
        public DaekhonSystem.ValueIndicator viAlign1PosY;
        public DaekhonSystem.ValueIndicator viAlign3PosX;
        public DaekhonSystem.ValueIndicator viAlign3PosY;
        public DaekhonSystem.ValueIndicator viAlign2PosX;
        public DaekhonSystem.ValueIndicator viAlign4PosX;
        public DaekhonSystem.ValueIndicator viAlign2PosY;
        public DaekhonSystem.ValueIndicator viAlign4PosY;
        private DaekhonSystem.BitBtn btnMoveAlign1Pos;
        private DaekhonSystem.BitBtn btnMoveAlign3Pos;
        private DaekhonSystem.GradientLabel gradLabel32;
        private DaekhonSystem.BitBtn btnMoveAlign2Pos;
        private DaekhonSystem.BitBtn btnMoveAlign4Pos;
        private DaekhonSystem.GradientLabel lblAxisY1Y2;
        public DaekhonSystem.LEDLabel ledPMAlignTool;
        private Button btnMoveUp;
        private Button btnMoveDown;
        public DaekhonSystem.BitBtn btnClear;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnColor;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewCheckBoxColumn ColumnUse;
        private DataGridViewComboBoxColumn ColumnDir;
        private DataGridViewComboBoxColumn ColumnStartPoint;
        public DaekhonSystem.Panel panCad;
        public DaekhonSystem.BitBtn btnOpenFile;
        public DaekhonSystem.Label lblDxfPath;
        private DaekhonSystem.GradientLabel gradLabel13;
        private DaekhonSystem.Label label6;
        private DaekhonSystem.Label label5;
        public DaekhonSystem.BitBtn btnSave;
        public DaekhonSystem.ValueIndicator viLaserFocus;
        private DaekhonSystem.Label viZPosition2;
        public DaekhonSystem.LEDButton btnUse;
        public RadioButton rdoAlign2P_1_2;
        public CheckBox chkAlignUse;
        public RadioButton rdoAlign2P_1_4;
        public RadioButton rdoAlign2P_1_3;
        public CheckBox chkUseIndividualAlign;
        public RadioButton rdoAlign4P;
        private CheckBox chkShowJumpline;
    }
}
