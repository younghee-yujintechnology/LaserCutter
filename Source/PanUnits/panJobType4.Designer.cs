using Raize.CodeSiteLogging;

namespace LaserCutter
{
    partial class panJobType4
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
                // 데이터 그리드 해제
                if (dataGridView4 != null)
                {
                    dataGridView4.Rows.Clear();
                    dataGridView4.Dispose();
                    dataGridView4 = null;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new yjTech.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new yjTech.Label();
            this.label6 = new yjTech.Label();
            this.label4 = new yjTech.Label();
            this.edGuideLength = new yjTech.KeypadEdit();
            this.edXLength = new yjTech.KeypadEdit();
            this.edYLength = new yjTech.KeypadEdit();
            this.edXPitch = new yjTech.KeypadEdit();
            this.edGuidePitch = new yjTech.KeypadEdit();
            this.edYPitch = new yjTech.KeypadEdit();
            this.chkShowJumpline = new System.Windows.Forms.CheckBox();
            this.viLaserFocus = new yjTech.ValueIndicator();
            this.viZPosition2 = new yjTech.Label();
            this.label1 = new yjTech.Label();
            this.edThickness = new yjTech.KeypadEdit();
            this.edPulsePitch = new yjTech.KeypadEdit();
            this.edLaserPower = new yjTech.KeypadEdit();
            this.label2 = new yjTech.Label();
            this.label3 = new yjTech.Label();
            this.edZOffset = new yjTech.KeypadEdit();
            this.LabelZOffset = new yjTech.Label();
            this.label5 = new yjTech.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreView = new yjTech.BitBtn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientLabel2 = new yjTech.GradientLabel();
            this.gradientLabel1 = new yjTech.GradientLabel();
            this.btnCancel = new yjTech.BitBtn();
            this.btnSave = new yjTech.BitBtn();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDir = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnStartPoint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panCad = new yjTech.Panel();
            this.btnClear = new yjTech.BitBtn();
            this.btnOpenFile = new yjTech.BitBtn();
            this.lblDxfPath = new yjTech.Label();
            this.gradLabel13 = new yjTech.GradientLabel();
            this.btnUse = new yjTech.LEDButton();
            this.bitBtn1 = new yjTech.BitBtn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(542, 536);
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
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.edGuideLength);
            this.tabPage1.Controls.Add(this.edXLength);
            this.tabPage1.Controls.Add(this.edYLength);
            this.tabPage1.Controls.Add(this.edXPitch);
            this.tabPage1.Controls.Add(this.edGuidePitch);
            this.tabPage1.Controls.Add(this.edYPitch);
            this.tabPage1.Controls.Add(this.chkShowJumpline);
            this.tabPage1.Controls.Add(this.viLaserFocus);
            this.tabPage1.Controls.Add(this.viZPosition2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edThickness);
            this.tabPage1.Controls.Add(this.edPulsePitch);
            this.tabPage1.Controls.Add(this.edLaserPower);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edZOffset);
            this.tabPage1.Controls.Add(this.LabelZOffset);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  가공 속성  ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Frame.Visible = false;
            this.label7.Location = new System.Drawing.Point(262, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Name = "label7";
            this.label7.ShowAccelChar = false;
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 1848;
            this.label7.Text = "X Line";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Frame.Visible = false;
            this.label6.Location = new System.Drawing.Point(174, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Name = "label6";
            this.label6.ShowAccelChar = false;
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 1847;
            this.label6.Text = "Y Line";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Frame.Visible = false;
            this.label4.Location = new System.Drawing.Point(457, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Name = "label4";
            this.label4.ShowAccelChar = false;
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 1846;
            this.label4.Text = "Guide";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edGuideLength
            // 
            this.edGuideLength.BackColor = System.Drawing.Color.White;
            this.edGuideLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGuideLength.DataType = yjTech.DataType.Double;
            this.edGuideLength.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGuideLength.Frame.CornerRound = 1;
            this.edGuideLength.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGuideLength.Hint = "Guide line length";
            this.edGuideLength.Location = new System.Drawing.Point(242, 235);
            this.edGuideLength.Margin = new System.Windows.Forms.Padding(4);
            this.edGuideLength.Max = 100D;
            this.edGuideLength.Min = 0D;
            this.edGuideLength.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGuideLength.Name = "edGuideLength";
            this.edGuideLength.NewText = "0.1";
            this.edGuideLength.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGuideLength.PrecisionDigits = 3;
            this.edGuideLength.ShowHint = true;
            this.edGuideLength.Size = new System.Drawing.Size(95, 29);
            this.edGuideLength.TabIndex = 1845;
            this.edGuideLength.Text = "0.000";
            this.edGuideLength.Value = 0D;
            // 
            // edXLength
            // 
            this.edXLength.BackColor = System.Drawing.Color.White;
            this.edXLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edXLength.DataType = yjTech.DataType.Double;
            this.edXLength.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edXLength.Frame.CornerRound = 1;
            this.edXLength.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edXLength.Hint = "X line length";
            this.edXLength.Location = new System.Drawing.Point(242, 291);
            this.edXLength.Margin = new System.Windows.Forms.Padding(4);
            this.edXLength.Max = 100D;
            this.edXLength.Min = 0D;
            this.edXLength.MinimumSize = new System.Drawing.Size(1, 1);
            this.edXLength.Name = "edXLength";
            this.edXLength.NewText = "0.1";
            this.edXLength.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edXLength.PrecisionDigits = 3;
            this.edXLength.ShowHint = true;
            this.edXLength.Size = new System.Drawing.Size(95, 29);
            this.edXLength.TabIndex = 1844;
            this.edXLength.Text = "0.000";
            this.edXLength.Value = 0D;
            // 
            // edYLength
            // 
            this.edYLength.BackColor = System.Drawing.Color.White;
            this.edYLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edYLength.DataType = yjTech.DataType.Double;
            this.edYLength.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edYLength.Frame.CornerRound = 1;
            this.edYLength.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edYLength.Hint = "Y line length";
            this.edYLength.Location = new System.Drawing.Point(398, 341);
            this.edYLength.Margin = new System.Windows.Forms.Padding(4);
            this.edYLength.Max = 100D;
            this.edYLength.Min = 0D;
            this.edYLength.MinimumSize = new System.Drawing.Size(1, 1);
            this.edYLength.Name = "edYLength";
            this.edYLength.NewText = "0.1";
            this.edYLength.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edYLength.PrecisionDigits = 3;
            this.edYLength.ShowHint = true;
            this.edYLength.Size = new System.Drawing.Size(95, 29);
            this.edYLength.TabIndex = 1843;
            this.edYLength.Text = "0.000";
            this.edYLength.Value = 0D;
            // 
            // edXPitch
            // 
            this.edXPitch.BackColor = System.Drawing.Color.White;
            this.edXPitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edXPitch.DataType = yjTech.DataType.Double;
            this.edXPitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edXPitch.Frame.CornerRound = 1;
            this.edXPitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edXPitch.Hint = "X line pitch";
            this.edXPitch.Location = new System.Drawing.Point(242, 393);
            this.edXPitch.Margin = new System.Windows.Forms.Padding(4);
            this.edXPitch.Max = 100D;
            this.edXPitch.Min = 0D;
            this.edXPitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.edXPitch.Name = "edXPitch";
            this.edXPitch.NewText = "0.1";
            this.edXPitch.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edXPitch.PrecisionDigits = 3;
            this.edXPitch.ShowHint = true;
            this.edXPitch.Size = new System.Drawing.Size(95, 29);
            this.edXPitch.TabIndex = 1842;
            this.edXPitch.Text = "0.000";
            this.edXPitch.Value = 0D;
            // 
            // edGuidePitch
            // 
            this.edGuidePitch.BackColor = System.Drawing.Color.White;
            this.edGuidePitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edGuidePitch.DataType = yjTech.DataType.Double;
            this.edGuidePitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edGuidePitch.Frame.CornerRound = 1;
            this.edGuidePitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edGuidePitch.Hint = "Guide pitch";
            this.edGuidePitch.Location = new System.Drawing.Point(14, 340);
            this.edGuidePitch.Margin = new System.Windows.Forms.Padding(4);
            this.edGuidePitch.Max = 100D;
            this.edGuidePitch.Min = 0D;
            this.edGuidePitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.edGuidePitch.Name = "edGuidePitch";
            this.edGuidePitch.NewText = "0.1";
            this.edGuidePitch.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edGuidePitch.PrecisionDigits = 3;
            this.edGuidePitch.ShowHint = true;
            this.edGuidePitch.Size = new System.Drawing.Size(95, 29);
            this.edGuidePitch.TabIndex = 1841;
            this.edGuidePitch.Text = "0.000";
            this.edGuidePitch.Value = 0D;
            // 
            // edYPitch
            // 
            this.edYPitch.BackColor = System.Drawing.Color.White;
            this.edYPitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edYPitch.DataType = yjTech.DataType.Double;
            this.edYPitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edYPitch.Frame.CornerRound = 1;
            this.edYPitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edYPitch.Hint = "Y line pitch";
            this.edYPitch.Location = new System.Drawing.Point(14, 385);
            this.edYPitch.Margin = new System.Windows.Forms.Padding(4);
            this.edYPitch.Max = 100D;
            this.edYPitch.Min = 0D;
            this.edYPitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.edYPitch.Name = "edYPitch";
            this.edYPitch.NewText = "0.1";
            this.edYPitch.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edYPitch.PrecisionDigits = 3;
            this.edYPitch.ShowHint = true;
            this.edYPitch.Size = new System.Drawing.Size(95, 29);
            this.edYPitch.TabIndex = 1840;
            this.edYPitch.Text = "0.000";
            this.edYPitch.Value = 0D;
            // 
            // chkShowJumpline
            // 
            this.chkShowJumpline.AutoSize = true;
            this.chkShowJumpline.Location = new System.Drawing.Point(6, 470);
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
            this.viLaserFocus.Location = new System.Drawing.Point(350, 104);
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
            this.viZPosition2.Location = new System.Drawing.Point(248, 104);
            this.viZPosition2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viZPosition2.Name = "viZPosition2";
            this.viZPosition2.ShowAccelChar = false;
            this.viZPosition2.Size = new System.Drawing.Size(100, 29);
            this.viZPosition2.TabIndex = 1836;
            this.viZPosition2.Text = "Laser.Focus";
            this.viZPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Frame.Visible = false;
            this.label1.Location = new System.Drawing.Point(477, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.ShowAccelChar = false;
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 1833;
            this.label1.Text = "[mm]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edThickness
            // 
            this.edThickness.BackColor = System.Drawing.Color.White;
            this.edThickness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edThickness.DataType = yjTech.DataType.Double;
            this.edThickness.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edThickness.Frame.CornerRound = 1;
            this.edThickness.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edThickness.Hint = null;
            this.edThickness.Location = new System.Drawing.Point(350, 71);
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
            // edPulsePitch
            // 
            this.edPulsePitch.BackColor = System.Drawing.Color.White;
            this.edPulsePitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edPulsePitch.DataType = yjTech.DataType.Double;
            this.edPulsePitch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edPulsePitch.Frame.CornerRound = 1;
            this.edPulsePitch.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edPulsePitch.Hint = null;
            this.edPulsePitch.Location = new System.Drawing.Point(152, 71);
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
            this.edLaserPower.DataType = yjTech.DataType.Double;
            this.edLaserPower.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edLaserPower.Frame.CornerRound = 1;
            this.edLaserPower.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edLaserPower.Hint = null;
            this.edLaserPower.Location = new System.Drawing.Point(152, 38);
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
            this.label2.Location = new System.Drawing.Point(53, 71);
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
            this.label3.Location = new System.Drawing.Point(47, 38);
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
            this.edZOffset.DataType = yjTech.DataType.Double;
            this.edZOffset.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edZOffset.Frame.CornerRound = 1;
            this.edZOffset.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edZOffset.Hint = null;
            this.edZOffset.Location = new System.Drawing.Point(350, 38);
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
            this.LabelZOffset.Location = new System.Drawing.Point(245, 38);
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
            this.label5.Location = new System.Drawing.Point(245, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.ShowAccelChar = false;
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 1831;
            this.label5.Text = "Thickness";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::LaserCutter.Properties.Resources.BeadCut1;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(89, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(374, 238);
            this.pictureBox5.TabIndex = 1839;
            this.pictureBox5.TabStop = false;
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
            this.tabPage2.Size = new System.Drawing.Size(534, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Processing Path  ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnPreView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 488);
            this.panel1.TabIndex = 1822;
            // 
            // btnPreView
            // 
            this.btnPreView.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPreView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPreView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreView.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPreView.ForeColor = System.Drawing.Color.Black;
            this.btnPreView.Location = new System.Drawing.Point(11, 101);
            this.btnPreView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPreView.Name = "btnPreView";
            this.btnPreView.Size = new System.Drawing.Size(77, 32);
            this.btnPreView.TabIndex = 1839;
            this.btnPreView.Text = "미리보기";
            this.btnPreView.UseVisualStyleBackColor = false;
            this.btnPreView.Click += new System.EventHandler(this.btnPreView_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(11, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 229);
            this.panel2.TabIndex = 1809;
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
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1104, 764);
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
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1104, 696);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 32);
            this.btnSave.TabIndex = 1688;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMoveUp.Location = new System.Drawing.Point(1066, 546);
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
            this.btnMoveDown.Location = new System.Drawing.Point(1066, 673);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(34, 122);
            this.btnMoveDown.TabIndex = 1697;
            this.btnMoveDown.Text = "▼";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView4.ColumnHeadersHeight = 40;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnColor,
            this.ColumnName,
            this.ColumnUse,
            this.ColumnDir,
            this.ColumnStartPoint});
            this.dataGridView4.Enabled = false;
            this.dataGridView4.EnableHeadersVisualStyles = false;
            this.dataGridView4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView4.Location = new System.Drawing.Point(4, 546);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 20;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(1056, 249);
            this.dataGridView4.TabIndex = 1696;
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
            this.panCad.Size = new System.Drawing.Size(630, 503);
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
            this.btnUse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUse.ForeColor = System.Drawing.Color.Black;
            this.btnUse.LED.Layout = yjTech.LEDLayout.Center;
            this.btnUse.LED.OffColor = System.Drawing.Color.Silver;
            this.btnUse.LED.Size = new System.Drawing.Size(58, 16);
            this.btnUse.Location = new System.Drawing.Point(1104, 545);
            this.btnUse.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(77, 32);
            this.btnUse.TabIndex = 1703;
            this.btnUse.Text = "Active";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
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
            this.bitBtn1.Location = new System.Drawing.Point(1104, 730);
            this.bitBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitBtn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bitBtn1.Name = "bitBtn1";
            this.bitBtn1.Size = new System.Drawing.Size(77, 32);
            this.bitBtn1.TabIndex = 1690;
            this.bitBtn1.UseVisualStyleBackColor = false;
            // 
            // panJobType4
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
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.panCad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bitBtn1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panJobType4";
            this.Size = new System.Drawing.Size(1185, 799);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private yjTech.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private yjTech.Label label1;
        public yjTech.KeypadEdit edThickness;
        public yjTech.KeypadEdit edPulsePitch;
        public yjTech.KeypadEdit edLaserPower;
        private yjTech.Label label2;
        private yjTech.Label label3;
        public yjTech.KeypadEdit edZOffset;
        private yjTech.Label LabelZOffset;
        private yjTech.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private yjTech.GradientLabel gradientLabel2;
        private yjTech.GradientLabel gradientLabel1;
        private yjTech.BitBtn btnCancel;
        public yjTech.BitBtn btnSave;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUse;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDir;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStartPoint;
        public yjTech.Panel panCad;
        public yjTech.ValueIndicator viLaserFocus;
        private yjTech.Label viZPosition2;
        public yjTech.BitBtn btnClear;
        public yjTech.BitBtn btnOpenFile;
        public yjTech.Label lblDxfPath;
        private yjTech.GradientLabel gradLabel13;
        public yjTech.LEDButton btnUse;
        public yjTech.BitBtn btnPreView;
        private System.Windows.Forms.CheckBox chkShowJumpline;
        private yjTech.BitBtn bitBtn1;
        private System.Windows.Forms.PictureBox pictureBox5;
        public yjTech.KeypadEdit edGuideLength;
        public yjTech.KeypadEdit edXLength;
        public yjTech.KeypadEdit edYLength;
        public yjTech.KeypadEdit edXPitch;
        public yjTech.KeypadEdit edGuidePitch;
        public yjTech.KeypadEdit edYPitch;
        private yjTech.Label label7;
        private yjTech.Label label6;
        private yjTech.Label label4;
    }
}
