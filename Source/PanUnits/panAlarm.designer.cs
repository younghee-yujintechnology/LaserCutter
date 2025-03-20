namespace LaserCutter
{
    partial class panAlarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panClient = new LaserCutter.sjPanel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDir = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnStartPoint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRepeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLast = new DaekhonSystem.BitBtn();
            this.btnNext = new DaekhonSystem.BitBtn();
            this.btnPrevious = new DaekhonSystem.BitBtn();
            this.btnFirst = new DaekhonSystem.BitBtn();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnFilter = new DaekhonSystem.BitBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnClearAlarm = new DaekhonSystem.BitBtn();
            this.bitBtn1 = new DaekhonSystem.BitBtn();
            this.btnAlertAlarm = new DaekhonSystem.BitBtn();
            this.btnAllAlarm = new DaekhonSystem.BitBtn();
            this.panClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.DataGridView1);
            this.panClient.Controls.Add(this.btnLast);
            this.panClient.Controls.Add(this.btnNext);
            this.panClient.Controls.Add(this.btnPrevious);
            this.panClient.Controls.Add(this.btnFirst);
            this.panClient.Controls.Add(this.lblPageInfo);
            this.panClient.Controls.Add(this.btnFilter);
            this.panClient.Controls.Add(this.label2);
            this.panClient.Controls.Add(this.label1);
            this.panClient.Controls.Add(this.endDatePicker);
            this.panClient.Controls.Add(this.startDatePicker);
            this.panClient.Controls.Add(this.btnClearAlarm);
            this.panClient.Controls.Add(this.bitBtn1);
            this.panClient.Controls.Add(this.btnAlertAlarm);
            this.panClient.Controls.Add(this.btnAllAlarm);
            this.panClient.Location = new System.Drawing.Point(8, 7);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1902, 715);
            this.panClient.TabIndex = 1138;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panClient.TitleText = "Title";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 40;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNo,
            this.ColumnName,
            this.ColumnUse,
            this.ColumnColor,
            this.ColumnDir,
            this.ColumnStartPoint,
            this.ColumnPower,
            this.ColumnPitch,
            this.ColumnRepeat});
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.Location = new System.Drawing.Point(8, 53);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(1880, 596);
            this.DataGridView1.TabIndex = 1586;
            // 
            // columnNo
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnNo.HeaderText = "No";
            this.columnNo.Name = "columnNo";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnUse
            // 
            this.ColumnUse.HeaderText = "Use";
            this.ColumnUse.Name = "ColumnUse";
            this.ColumnUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnColor
            // 
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
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
            // ColumnPower
            // 
            this.ColumnPower.HeaderText = "Power";
            this.ColumnPower.Name = "ColumnPower";
            // 
            // ColumnPitch
            // 
            this.ColumnPitch.HeaderText = "Pitch";
            this.ColumnPitch.Name = "ColumnPitch";
            // 
            // ColumnRepeat
            // 
            this.ColumnRepeat.HeaderText = "Repeat";
            this.ColumnRepeat.Name = "ColumnRepeat";
            // 
            // btnLast
            // 
            this.btnLast.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.Black;
            this.btnLast.Location = new System.Drawing.Point(1663, 661);
            this.btnLast.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 40);
            this.btnLast.TabIndex = 901;
            this.btnLast.Text = "▶▌";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(1583, 661);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 40);
            this.btnNext.TabIndex = 900;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(1502, 661);
            this.btnPrevious.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(74, 40);
            this.btnPrevious.TabIndex = 899;
            this.btnPrevious.Text = "◀";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.Black;
            this.btnFirst.Location = new System.Drawing.Point(1422, 661);
            this.btnFirst.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(74, 40);
            this.btnFirst.TabIndex = 898;
            this.btnFirst.Text = "▐◀";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblPageInfo.Location = new System.Drawing.Point(783, 672);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(39, 18);
            this.lblPageInfo.TabIndex = 897;
            this.lblPageInfo.Text = "Date";
            // 
            // btnFilter
            // 
            this.btnFilter.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(1324, 661);
            this.btnFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(74, 40);
            this.btnFilter.TabIndex = 896;
            this.btnFilter.Text = "▷▷";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.bitBtn3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(1088, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 895;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(860, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 894;
            this.label1.Text = "Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Tahoma", 11F);
            this.endDatePicker.Location = new System.Drawing.Point(1113, 669);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(177, 25);
            this.endDatePicker.TabIndex = 893;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Tahoma", 11F);
            this.startDatePicker.Location = new System.Drawing.Point(905, 669);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(177, 25);
            this.startDatePicker.TabIndex = 892;
            // 
            // btnClearAlarm
            // 
            this.btnClearAlarm.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnClearAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnClearAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAlarm.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnClearAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnClearAlarm.Location = new System.Drawing.Point(1608, 3);
            this.btnClearAlarm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearAlarm.Name = "btnClearAlarm";
            this.btnClearAlarm.Size = new System.Drawing.Size(129, 40);
            this.btnClearAlarm.TabIndex = 891;
            this.btnClearAlarm.Text = "Clear Alarm";
            this.btnClearAlarm.UseVisualStyleBackColor = false;
            this.btnClearAlarm.Click += new System.EventHandler(this.bitBtn2_Click);
            // 
            // bitBtn1
            // 
            this.bitBtn1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bitBtn1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.bitBtn1.ForeColor = System.Drawing.Color.Black;
            this.bitBtn1.Location = new System.Drawing.Point(1260, 4);
            this.bitBtn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bitBtn1.Name = "bitBtn1";
            this.bitBtn1.Size = new System.Drawing.Size(101, 40);
            this.bitBtn1.TabIndex = 890;
            this.bitBtn1.Text = "All Alarm";
            this.bitBtn1.UseVisualStyleBackColor = false;
            this.bitBtn1.Visible = false;
            this.bitBtn1.Click += new System.EventHandler(this.bitBtn1_Click);
            // 
            // btnAlertAlarm
            // 
            this.btnAlertAlarm.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAlertAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAlertAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertAlarm.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAlertAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAlertAlarm.Location = new System.Drawing.Point(1501, 4);
            this.btnAlertAlarm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAlertAlarm.Name = "btnAlertAlarm";
            this.btnAlertAlarm.Size = new System.Drawing.Size(101, 40);
            this.btnAlertAlarm.TabIndex = 887;
            this.btnAlertAlarm.Text = "Alert Alarm";
            this.btnAlertAlarm.UseVisualStyleBackColor = false;
            // 
            // btnAllAlarm
            // 
            this.btnAllAlarm.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAllAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAllAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllAlarm.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAllAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAllAlarm.Location = new System.Drawing.Point(1386, 4);
            this.btnAllAlarm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAllAlarm.Name = "btnAllAlarm";
            this.btnAllAlarm.Size = new System.Drawing.Size(101, 40);
            this.btnAllAlarm.TabIndex = 886;
            this.btnAllAlarm.Text = "All Alarm";
            this.btnAllAlarm.UseVisualStyleBackColor = false;
            // 
            // panAlarm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panClient);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "panAlarm";
            this.Size = new System.Drawing.Size(1920, 730);
            this.panClient.ResumeLayout(false);
            this.panClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sjPanel panClient;
        private DaekhonSystem.BitBtn btnAlertAlarm;
        private DaekhonSystem.BitBtn btnAllAlarm;
        private DaekhonSystem.BitBtn bitBtn1;
        private DaekhonSystem.BitBtn btnClearAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label2;
        private DaekhonSystem.BitBtn btnFilter;
        private System.Windows.Forms.Label lblPageInfo;
        private DaekhonSystem.BitBtn btnLast;
        private DaekhonSystem.BitBtn btnNext;
        private DaekhonSystem.BitBtn btnPrevious;
        private DaekhonSystem.BitBtn btnFirst;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDir;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStartPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRepeat;
    }
}
