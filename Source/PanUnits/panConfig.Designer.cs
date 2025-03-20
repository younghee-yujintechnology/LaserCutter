namespace LaserCutter
{
    partial class panConfig
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
            this.propSaver1 = new DaekhonSystem.PropSaver();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabConfig = new DaekhonSystem.TabControl();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // propSaver1
            // 
            this.propSaver1.Active = false;
            this.propSaver1.FormStateSection = "";
            this.propSaver1.ManageFormState = false;
            this.propSaver1.ParentControl = this;
            this.propSaver1.PropList = new string[] {
        "edTable1LaserZFocus;Text;Table1;LaserZFocus;0",
        "edTable1NozzleXOffset;Text;Table1;NozzleXOffset;0",
        "edTable1VisionZFocus;Text;Table1;VisionZFocus;0",
        "edTable2LaserZFocus;Text;Table2;LaserZFocus;0",
        "edTable2NozzleXOffset;Text;Table2;NozzleXOffset;0",
        "edTable2VisionZFocus;Text;Table2;VisionZFocus;0",
        "edLoadPosX;Text;LoadPos;LoadXPos;0",
        "edLoadPosY1;Text;LoadPos;LoadY1Pos;0",
        "edLoadPosY2;Text;LoadPos;LoadY2Pos;0",
        "chkDoorAlarmUse;Checked;Option;DoorAlarmUse;true",
        "chkStartReserved;Checked;Option;StartReserved;true",
        "edLoadPosZ;Text;LoadPos;LoadZPos;0",
        "edSafetyPosY1;Text;LoadPos;SafetyY1Pos;0",
        "edSafetyPosY2;Text;LoadPos;SafetyY2Pos;0",
        "edTableSizeX;Text;Tablesize;TableXSize;0",
        "edTableSizeY;Text;TableSize;TableYSize;0",
        "edLineSpeed;Text;Line&ArcSpeed;LineSpeed;0",
        "edArcSpeed;Text;Line&ArcSpeed;ArcSpeed;0",
        "edJumpSpeed;Text;Line&ArcSpeed;JumpSpeed;0",
        "edPowerMeterXPos;Text;PowerMeterPos;PowerMeterXPos;0",
        "edPowerMeterZPo;Text;PowerMeterPos;PowerMeterZPos;0",
        "edLineTA;Text;Line&ArcSpeed;LineTA;0",
        "edArcTA;Text;Line&ArcSpeed;ArcTA;0",
        "edJumpTA;Text;Line&ArcSpeed;JumpTA;0",
        "edAlignScore;Text;Vision;AlignScore;0",
        "chkVacAlarmUse;Checked;Option;VacAlarmUse;true",
        "chkVacuumRelease;Checked;Option;VacReleaseUse;true",
        "cbFocusTopBottomUse;Checked;VariableFocus;FocusTopBottomUse;true",
        "edFocusLX;Text;VariableFocus;FocusLX;0",
        "edFocusRX;Text;VariableFocus;FocusRX;0",
        "cbFocusLeftRightUse;Checked;VariableFocus;FocusTopBottomUse;true",
        "edFocusTY;Text;VariableFocus;FocusTY;0",
        "edFocusBY;Text;VariableFocus;FocusBY;0",
        "edFocusZOffset;Text;VariableFocus;ZFocusOffset;0",
        "edFocusZSpeed;Text;VariableFocus;ZFocusSpeed;0",
        "edCircleYOffset;Text;CircleYOffset;YOffset;0",
        "edTable1NozzleYOffset;Text;Table1;NozzleYOffset;0",
        "edTable2NozzleYOffset;Text;Table2;NozzleYOffset;0",
        "edTable1NozzleXCenterPos;Text;Table1;CenterPosNozzleXPos;0",
        "edTable1NozzleYCenterPos;Text;Table1;CenterPosNozzleYPos;0",
        "edTable2NozzleXCenterPos;Text;Table2;CenterPosNozzleXPos;0",
        "edTable2NozzleYCenterPos;Text;Table2;CenterPosNozzleYPos;0",
        "edTable1VisionXCenterPos;Text;Table1;CenterPosVisionXPos;0",
        "edTable1VisionYCenterPos;Text;Table1;CenterPosVisionYPos;0",
        "edTable2VisionXCenterPos;Text;Table2;CenterPosVisionXPos;0",
        "edTable2VisionYCenterPos;Text;Table2;CenterPosVisionYPos;0",
        "edTable1GuideCornerXPos;Text;Table1;GuideCornerXPos;0",
        "edTable1GuideCornerYPos;Text;Table1;GuideCornerYPos;0",
        "edTable2GuideCornerXPos;Text;Table2;GuideCornerXPos;0",
        "edTable2GuideCornerYPos;Text;Table2;GuideCornerYPos;0"};
            this.propSaver1.RootKey = DaekhonSystem.RootKey.artHKEY_CURRENT_USER;
            this.propSaver1.SaveToRegistry = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabPage2.Location = new System.Drawing.Point(179, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1370, 844);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Motor";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabPage1.Location = new System.Drawing.Point(179, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1370, 844);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Common";
            // 
            // tabConfig
            // 
            this.tabConfig.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Controls.Add(this.tabPage2);
            this.tabConfig.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabConfig.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.tabConfig.ItemSize = new System.Drawing.Size(175, 80);
            this.tabConfig.Location = new System.Drawing.Point(0, 0);
            this.tabConfig.Margin = new System.Windows.Forms.Padding(0);
            this.tabConfig.Multiline = true;
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabConfig.ShowActiveCloseButton = false;
            this.tabConfig.ShowCloseButton = false;
            this.tabConfig.Size = new System.Drawing.Size(1553, 852);
            this.tabConfig.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConfig.TabBackColor = System.Drawing.Color.LightSlateGray;
            this.tabConfig.TabIndex = 1127;
            this.tabConfig.TabSelectedColor = System.Drawing.Color.White;
            this.tabConfig.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tabConfig.TabSelectedHighColor = System.Drawing.Color.Red;
            this.tabConfig.TabSelectedHighColorSize = 6;
            this.tabConfig.TabUnSelectedForeColor = System.Drawing.Color.White;
            this.tabConfig.TabVisible = true;
            this.tabConfig.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabConfig.TipsColor = System.Drawing.Color.Red;
            this.tabConfig.TipsFont = new System.Drawing.Font("Arial", 8F);
            this.tabConfig.TipsForeColor = System.Drawing.Color.White;
            // 
            // panConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabConfig);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "panConfig";
            this.Size = new System.Drawing.Size(1552, 852);
            this.tabConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        public DaekhonSystem.PropSaver propSaver1;
        private DaekhonSystem.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
