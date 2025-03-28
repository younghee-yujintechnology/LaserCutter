namespace LaserCutter
{
    partial class panConfigMotor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panClient = new LaserCutter.sjPanel();
            this.dgMotorParameter = new System.Windows.Forms.DataGridView();
            this.columnAxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnJogSpdLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogSpeedMid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogSpeedHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogTALow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogTAMid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogTAHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogTSLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogTSMid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJogTSHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLimitM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLimitP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new yjTech.BitBtn();
            this.panClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMotorParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.btnSave);
            this.panClient.Controls.Add(this.dgMotorParameter);
            this.panClient.Location = new System.Drawing.Point(3, 3);
            this.panClient.Margin = new System.Windows.Forms.Padding(0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1209, 800);
            this.panClient.TabIndex = 0;
            this.panClient.TitleFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.panClient.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.panClient.TitleText = "Motor Parameter";
            this.panClient.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgMotorParameter
            // 
            this.dgMotorParameter.AllowUserToAddRows = false;
            this.dgMotorParameter.AllowUserToDeleteRows = false;
            this.dgMotorParameter.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgMotorParameter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgMotorParameter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMotorParameter.BackgroundColor = System.Drawing.Color.White;
            this.dgMotorParameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMotorParameter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMotorParameter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgMotorParameter.ColumnHeadersHeight = 45;
            this.dgMotorParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMotorParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAxis,
            this.columnJogSpdLow,
            this.ColumnJogSpeedMid,
            this.ColumnJogSpeedHigh,
            this.ColumnJogTALow,
            this.ColumnJogTAMid,
            this.ColumnJogTAHigh,
            this.ColumnJogTSLow,
            this.ColumnJogTSMid,
            this.ColumnJogTSHigh,
            this.ColumnLimitM,
            this.ColumnLimitP});
            this.dgMotorParameter.EnableHeadersVisualStyles = false;
            this.dgMotorParameter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgMotorParameter.GridColor = System.Drawing.Color.LightGray;
            this.dgMotorParameter.Location = new System.Drawing.Point(4, 50);
            this.dgMotorParameter.MultiSelect = false;
            this.dgMotorParameter.Name = "dgMotorParameter";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMotorParameter.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgMotorParameter.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMotorParameter.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgMotorParameter.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMotorParameter.RowTemplate.Height = 28;
            this.dgMotorParameter.Size = new System.Drawing.Size(1199, 302);
            this.dgMotorParameter.TabIndex = 1499;
            this.dgMotorParameter.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgMotorParameter_EditingControlShowing);
            // 
            // columnAxis
            // 
            this.columnAxis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnAxis.FillWeight = 12.61547F;
            this.columnAxis.Frozen = true;
            this.columnAxis.HeaderText = "Axis";
            this.columnAxis.Name = "columnAxis";
            this.columnAxis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnAxis.Width = 38;
            // 
            // columnJogSpdLow
            // 
            this.columnJogSpdLow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnJogSpdLow.FillWeight = 31.53867F;
            this.columnJogSpdLow.Frozen = true;
            this.columnJogSpdLow.HeaderText = "Speed #1";
            this.columnJogSpdLow.Name = "columnJogSpdLow";
            this.columnJogSpdLow.Width = 120;
            // 
            // ColumnJogSpeedMid
            // 
            this.ColumnJogSpeedMid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogSpeedMid.FillWeight = 31.53867F;
            this.ColumnJogSpeedMid.Frozen = true;
            this.ColumnJogSpeedMid.HeaderText = "Speed #2";
            this.ColumnJogSpeedMid.Name = "ColumnJogSpeedMid";
            this.ColumnJogSpeedMid.Width = 120;
            // 
            // ColumnJogSpeedHigh
            // 
            this.ColumnJogSpeedHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogSpeedHigh.FillWeight = 31.53867F;
            this.ColumnJogSpeedHigh.Frozen = true;
            this.ColumnJogSpeedHigh.HeaderText = "Speed #3";
            this.ColumnJogSpeedHigh.Name = "ColumnJogSpeedHigh";
            this.ColumnJogSpeedHigh.Width = 120;
            // 
            // ColumnJogTALow
            // 
            this.ColumnJogTALow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnJogTALow.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnJogTALow.FillWeight = 31.53867F;
            this.ColumnJogTALow.Frozen = true;
            this.ColumnJogTALow.HeaderText = "Accel #1";
            this.ColumnJogTALow.Name = "ColumnJogTALow";
            this.ColumnJogTALow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnJogTALow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnJogTALow.Width = 120;
            // 
            // ColumnJogTAMid
            // 
            this.ColumnJogTAMid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogTAMid.FillWeight = 31.53867F;
            this.ColumnJogTAMid.Frozen = true;
            this.ColumnJogTAMid.HeaderText = "Accel #2";
            this.ColumnJogTAMid.Name = "ColumnJogTAMid";
            this.ColumnJogTAMid.Width = 120;
            // 
            // ColumnJogTAHigh
            // 
            this.ColumnJogTAHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogTAHigh.FillWeight = 31.53867F;
            this.ColumnJogTAHigh.Frozen = true;
            this.ColumnJogTAHigh.HeaderText = "Accel #3";
            this.ColumnJogTAHigh.Name = "ColumnJogTAHigh";
            this.ColumnJogTAHigh.Width = 120;
            // 
            // ColumnJogTSLow
            // 
            this.ColumnJogTSLow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogTSLow.FillWeight = 31.53867F;
            this.ColumnJogTSLow.Frozen = true;
            this.ColumnJogTSLow.HeaderText = "S-Curve #1";
            this.ColumnJogTSLow.Name = "ColumnJogTSLow";
            this.ColumnJogTSLow.Width = 120;
            // 
            // ColumnJogTSMid
            // 
            this.ColumnJogTSMid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogTSMid.FillWeight = 31.53867F;
            this.ColumnJogTSMid.Frozen = true;
            this.ColumnJogTSMid.HeaderText = "S-Curve #2";
            this.ColumnJogTSMid.Name = "ColumnJogTSMid";
            this.ColumnJogTSMid.Width = 120;
            // 
            // ColumnJogTSHigh
            // 
            this.ColumnJogTSHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnJogTSHigh.FillWeight = 31.53867F;
            this.ColumnJogTSHigh.Frozen = true;
            this.ColumnJogTSHigh.HeaderText = "S-Curve #3";
            this.ColumnJogTSHigh.Name = "ColumnJogTSHigh";
            this.ColumnJogTSHigh.Width = 120;
            // 
            // ColumnLimitM
            // 
            this.ColumnLimitM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnLimitM.FillWeight = 57.20251F;
            this.ColumnLimitM.Frozen = true;
            this.ColumnLimitM.HeaderText = "Soft Limit (-)";
            this.ColumnLimitM.Name = "ColumnLimitM";
            this.ColumnLimitM.Width = 120;
            // 
            // ColumnLimitP
            // 
            this.ColumnLimitP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnLimitP.Frozen = true;
            this.ColumnLimitP.HeaderText = "Soft Limit (+)";
            this.ColumnLimitP.Name = "ColumnLimitP";
            this.ColumnLimitP.Width = 120;
            // 
            // btnSave
            // 
            this.btnSave.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSave.Location = new System.Drawing.Point(1099, 752);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 43);
            this.btnSave.TabIndex = 1563;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panConfigMotor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panClient);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panConfigMotor";
            this.Size = new System.Drawing.Size(1214, 805);
            this.panClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMotorParameter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sjPanel panClient;
        private System.Windows.Forms.DataGridView dgMotorParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnJogSpdLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogSpeedMid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogSpeedHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogTALow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogTAMid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogTAHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogTSLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogTSMid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogTSHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLimitM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLimitP;
        private yjTech.BitBtn btnSave;
    }
}
