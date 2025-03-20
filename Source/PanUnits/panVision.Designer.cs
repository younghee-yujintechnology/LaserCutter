namespace LaserCutter
{
    partial class panVision
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
            this.panClient = new DaekhonSystem.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.lblInfo = new DaekhonSystem.Label();
            this.lblCogResult = new System.Windows.Forms.Label();
            this.btnSave24Image = new DaekhonSystem.BitBtn();
            this.ledModel4Trained = new DaekhonSystem.LEDLabel();
            this.ledModel4Enabled = new DaekhonSystem.LEDLabel();
            this.ledModel3Trained = new DaekhonSystem.LEDLabel();
            this.ledModel3Enabled = new DaekhonSystem.LEDLabel();
            this.ledModel2Trained = new DaekhonSystem.LEDLabel();
            this.ledModel2Enabled = new DaekhonSystem.LEDLabel();
            this.ledModel1Trained = new DaekhonSystem.LEDLabel();
            this.ledModel1Enabled = new DaekhonSystem.LEDLabel();
            this.ledCogPMAlignTool = new DaekhonSystem.LEDLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bitBtn4 = new DaekhonSystem.BitBtn();
            this.label25 = new System.Windows.Forms.Label();
            this.edZoomRate = new DaekhonSystem.KeypadEdit();
            this.btnZoomX3 = new DaekhonSystem.LEDButton();
            this.btnZoomX2_5 = new DaekhonSystem.LEDButton();
            this.btnZoomX2 = new DaekhonSystem.LEDButton();
            this.btnZoomX1_5 = new DaekhonSystem.LEDButton();
            this.btnZoomX1 = new DaekhonSystem.LEDButton();
            this.lblCogModel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnManualSet = new DaekhonSystem.LEDButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ledSearchResultGood = new DaekhonSystem.LEDLabel();
            this.ledSearchResultBad = new DaekhonSystem.LEDLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.viSearchResultScore = new DaekhonSystem.ValueIndicator();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.viSearchResultYPos = new DaekhonSystem.ValueIndicator();
            this.viSearchResultXPos = new DaekhonSystem.ValueIndicator();
            this.viAlign4OffsetY = new DaekhonSystem.ValueIndicator();
            this.viAlign3OffsetY = new DaekhonSystem.ValueIndicator();
            this.viAlign2OffsetY = new DaekhonSystem.ValueIndicator();
            this.viAlign1OffsetY = new DaekhonSystem.ValueIndicator();
            this.viAlign4OffsetX = new DaekhonSystem.ValueIndicator();
            this.viAlign3OffsetX = new DaekhonSystem.ValueIndicator();
            this.viAlign2OffsetX = new DaekhonSystem.ValueIndicator();
            this.viAlign1OffsetX = new DaekhonSystem.ValueIndicator();
            this.label11 = new System.Windows.Forms.Label();
            this.viAngleDiff = new DaekhonSystem.ValueIndicator();
            this.label4 = new System.Windows.Forms.Label();
            this.viAngle0 = new DaekhonSystem.ValueIndicator();
            this.label3 = new System.Windows.Forms.Label();
            this.viAngle = new DaekhonSystem.ValueIndicator();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bitBtn1 = new DaekhonSystem.BitBtn();
            this.bitBtn2 = new DaekhonSystem.BitBtn();
            this.btnSelectProject = new DaekhonSystem.BitBtn();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ledAlign4SearchResultGood = new DaekhonSystem.LEDLabel();
            this.ledAlign4SearchResultBad = new DaekhonSystem.LEDLabel();
            this.ledAlign3SearchResultGood = new DaekhonSystem.LEDLabel();
            this.ledAlign3SearchResultBad = new DaekhonSystem.LEDLabel();
            this.ledAlign2SearchResultGood = new DaekhonSystem.LEDLabel();
            this.ledAlign2SearchResultBad = new DaekhonSystem.LEDLabel();
            this.ledAlign1SearchResultGood = new DaekhonSystem.LEDLabel();
            this.viAlign4SearchScore = new DaekhonSystem.ValueIndicator();
            this.viAlign4SearchResultYPos = new DaekhonSystem.ValueIndicator();
            this.viAlign4SearchResultXPos = new DaekhonSystem.ValueIndicator();
            this.viAlign3SearchScore = new DaekhonSystem.ValueIndicator();
            this.viAlign3SearchResultYPos = new DaekhonSystem.ValueIndicator();
            this.viAlign3SearchResultXPos = new DaekhonSystem.ValueIndicator();
            this.viAlign2SearchScore = new DaekhonSystem.ValueIndicator();
            this.viAlign2SearchResultYPos = new DaekhonSystem.ValueIndicator();
            this.viAlign2SearchResultXPos = new DaekhonSystem.ValueIndicator();
            this.viAlign1SearchScore = new DaekhonSystem.ValueIndicator();
            this.viAlign1SearchResultYPos = new DaekhonSystem.ValueIndicator();
            this.viAlign1SearchResultXPos = new DaekhonSystem.ValueIndicator();
            this.ledAlign1SearchResultBad = new DaekhonSystem.LEDLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlignIndex = new System.Windows.Forms.ComboBox();
            this.btnShowMVS = new DaekhonSystem.BitBtn();
            this.lblCogDisplay1 = new System.Windows.Forms.Label();
            this.btnShowROI = new DaekhonSystem.LEDButton();
            this.btnSaveProject = new DaekhonSystem.BitBtn();
            this.btnLoadProject = new DaekhonSystem.BitBtn();
            this.btnSave8Image = new DaekhonSystem.BitBtn();
            this.btnOpenImage = new DaekhonSystem.BitBtn();
            this.btnSearch = new DaekhonSystem.BitBtn();
            this.btnModelTrain = new DaekhonSystem.BitBtn();
            this.btnGrab = new DaekhonSystem.LEDButton();
            this.btnShowCross = new DaekhonSystem.LEDButton();
            this.btnLive = new DaekhonSystem.LEDButton();
            this.gradLabel14 = new DaekhonSystem.GradientLabel();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.label26);
            this.panClient.Controls.Add(this.lblInfo);
            this.panClient.Controls.Add(this.lblCogResult);
            this.panClient.Controls.Add(this.btnSave24Image);
            this.panClient.Controls.Add(this.ledModel4Trained);
            this.panClient.Controls.Add(this.ledModel4Enabled);
            this.panClient.Controls.Add(this.ledModel3Trained);
            this.panClient.Controls.Add(this.ledModel3Enabled);
            this.panClient.Controls.Add(this.ledModel2Trained);
            this.panClient.Controls.Add(this.ledModel2Enabled);
            this.panClient.Controls.Add(this.ledModel1Trained);
            this.panClient.Controls.Add(this.ledModel1Enabled);
            this.panClient.Controls.Add(this.ledCogPMAlignTool);
            this.panClient.Controls.Add(this.label6);
            this.panClient.Controls.Add(this.label7);
            this.panClient.Controls.Add(this.label5);
            this.panClient.Controls.Add(this.label2);
            this.panClient.Controls.Add(this.bitBtn4);
            this.panClient.Controls.Add(this.label25);
            this.panClient.Controls.Add(this.edZoomRate);
            this.panClient.Controls.Add(this.btnZoomX3);
            this.panClient.Controls.Add(this.btnZoomX2_5);
            this.panClient.Controls.Add(this.btnZoomX2);
            this.panClient.Controls.Add(this.btnZoomX1_5);
            this.panClient.Controls.Add(this.btnZoomX1);
            this.panClient.Controls.Add(this.lblCogModel);
            this.panClient.Controls.Add(this.label24);
            this.panClient.Controls.Add(this.label23);
            this.panClient.Controls.Add(this.btnManualSet);
            this.panClient.Controls.Add(this.label21);
            this.panClient.Controls.Add(this.label22);
            this.panClient.Controls.Add(this.ledSearchResultGood);
            this.panClient.Controls.Add(this.ledSearchResultBad);
            this.panClient.Controls.Add(this.label20);
            this.panClient.Controls.Add(this.viSearchResultScore);
            this.panClient.Controls.Add(this.label19);
            this.panClient.Controls.Add(this.label18);
            this.panClient.Controls.Add(this.label17);
            this.panClient.Controls.Add(this.label15);
            this.panClient.Controls.Add(this.label13);
            this.panClient.Controls.Add(this.label14);
            this.panClient.Controls.Add(this.viSearchResultYPos);
            this.panClient.Controls.Add(this.viSearchResultXPos);
            this.panClient.Controls.Add(this.viAlign4OffsetY);
            this.panClient.Controls.Add(this.viAlign3OffsetY);
            this.panClient.Controls.Add(this.viAlign2OffsetY);
            this.panClient.Controls.Add(this.viAlign1OffsetY);
            this.panClient.Controls.Add(this.viAlign4OffsetX);
            this.panClient.Controls.Add(this.viAlign3OffsetX);
            this.panClient.Controls.Add(this.viAlign2OffsetX);
            this.panClient.Controls.Add(this.viAlign1OffsetX);
            this.panClient.Controls.Add(this.label11);
            this.panClient.Controls.Add(this.viAngleDiff);
            this.panClient.Controls.Add(this.label4);
            this.panClient.Controls.Add(this.viAngle0);
            this.panClient.Controls.Add(this.label3);
            this.panClient.Controls.Add(this.viAngle);
            this.panClient.Controls.Add(this.label16);
            this.panClient.Controls.Add(this.label8);
            this.panClient.Controls.Add(this.bitBtn1);
            this.panClient.Controls.Add(this.bitBtn2);
            this.panClient.Controls.Add(this.btnSelectProject);
            this.panClient.Controls.Add(this.label12);
            this.panClient.Controls.Add(this.label10);
            this.panClient.Controls.Add(this.label9);
            this.panClient.Controls.Add(this.ledAlign4SearchResultGood);
            this.panClient.Controls.Add(this.ledAlign4SearchResultBad);
            this.panClient.Controls.Add(this.ledAlign3SearchResultGood);
            this.panClient.Controls.Add(this.ledAlign3SearchResultBad);
            this.panClient.Controls.Add(this.ledAlign2SearchResultGood);
            this.panClient.Controls.Add(this.ledAlign2SearchResultBad);
            this.panClient.Controls.Add(this.ledAlign1SearchResultGood);
            this.panClient.Controls.Add(this.viAlign4SearchScore);
            this.panClient.Controls.Add(this.viAlign4SearchResultYPos);
            this.panClient.Controls.Add(this.viAlign4SearchResultXPos);
            this.panClient.Controls.Add(this.viAlign3SearchScore);
            this.panClient.Controls.Add(this.viAlign3SearchResultYPos);
            this.panClient.Controls.Add(this.viAlign3SearchResultXPos);
            this.panClient.Controls.Add(this.viAlign2SearchScore);
            this.panClient.Controls.Add(this.viAlign2SearchResultYPos);
            this.panClient.Controls.Add(this.viAlign2SearchResultXPos);
            this.panClient.Controls.Add(this.viAlign1SearchScore);
            this.panClient.Controls.Add(this.viAlign1SearchResultYPos);
            this.panClient.Controls.Add(this.viAlign1SearchResultXPos);
            this.panClient.Controls.Add(this.ledAlign1SearchResultBad);
            this.panClient.Controls.Add(this.label1);
            this.panClient.Controls.Add(this.cbAlignIndex);
            this.panClient.Controls.Add(this.btnShowMVS);
            this.panClient.Controls.Add(this.lblCogDisplay1);
            this.panClient.Controls.Add(this.btnShowROI);
            this.panClient.Controls.Add(this.btnSaveProject);
            this.panClient.Controls.Add(this.btnLoadProject);
            this.panClient.Controls.Add(this.btnSave8Image);
            this.panClient.Controls.Add(this.btnOpenImage);
            this.panClient.Controls.Add(this.btnSearch);
            this.panClient.Controls.Add(this.btnModelTrain);
            this.panClient.Controls.Add(this.btnGrab);
            this.panClient.Controls.Add(this.btnShowCross);
            this.panClient.Controls.Add(this.btnLive);
            this.panClient.Controls.Add(this.gradLabel14);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(1920, 930);
            this.panClient.TabIndex = 1436;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(1445, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 17);
            this.label26.TabIndex = 1647;
            this.label26.Text = "Search Result";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInfo.Frame.FlatColor = System.Drawing.Color.Black;
            this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(937, 40);
            this.lblInfo.TabIndex = 1646;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCogResult
            // 
            this.lblCogResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCogResult.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblCogResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCogResult.Location = new System.Drawing.Point(1448, 135);
            this.lblCogResult.Name = "lblCogResult";
            this.lblCogResult.Size = new System.Drawing.Size(225, 212);
            this.lblCogResult.TabIndex = 1645;
            this.lblCogResult.Text = "CogDisplay는 동적으로 생성\r\n\r\n이 메세지가 보이면 Control이 정상적으로 설치가 되지 않았습니다.";
            this.lblCogResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave24Image
            // 
            this.btnSave24Image.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSave24Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSave24Image.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSave24Image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave24Image.Location = new System.Drawing.Point(1813, 625);
            this.btnSave24Image.Name = "btnSave24Image";
            this.btnSave24Image.Size = new System.Drawing.Size(94, 62);
            this.btnSave24Image.TabIndex = 1644;
            this.btnSave24Image.Text = "Save 24bit Image";
            this.btnSave24Image.UseVisualStyleBackColor = true;
            this.btnSave24Image.Click += new System.EventHandler(this.btnSave24Image_Click);
            // 
            // ledModel4Trained
            // 
            this.ledModel4Trained.BackColor = System.Drawing.Color.Transparent;
            this.ledModel4Trained.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel4Trained.Frame.Visible = false;
            this.ledModel4Trained.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel4Trained.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel4Trained.Location = new System.Drawing.Point(1512, 53);
            this.ledModel4Trained.Name = "ledModel4Trained";
            this.ledModel4Trained.ShowChannelName = false;
            this.ledModel4Trained.Size = new System.Drawing.Size(78, 17);
            this.ledModel4Trained.TabIndex = 1643;
            this.ledModel4Trained.Text = "Trained";
            this.ledModel4Trained.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel4Enabled
            // 
            this.ledModel4Enabled.BackColor = System.Drawing.Color.Transparent;
            this.ledModel4Enabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel4Enabled.Frame.Visible = false;
            this.ledModel4Enabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel4Enabled.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel4Enabled.Location = new System.Drawing.Point(1512, 36);
            this.ledModel4Enabled.Name = "ledModel4Enabled";
            this.ledModel4Enabled.ShowChannelName = false;
            this.ledModel4Enabled.Size = new System.Drawing.Size(65, 17);
            this.ledModel4Enabled.TabIndex = 1642;
            this.ledModel4Enabled.Text = "Enabled";
            this.ledModel4Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel3Trained
            // 
            this.ledModel3Trained.BackColor = System.Drawing.Color.Transparent;
            this.ledModel3Trained.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel3Trained.Frame.Visible = false;
            this.ledModel3Trained.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel3Trained.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel3Trained.Location = new System.Drawing.Point(1428, 53);
            this.ledModel3Trained.Name = "ledModel3Trained";
            this.ledModel3Trained.ShowChannelName = false;
            this.ledModel3Trained.Size = new System.Drawing.Size(78, 17);
            this.ledModel3Trained.TabIndex = 1641;
            this.ledModel3Trained.Text = "Trained";
            this.ledModel3Trained.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel3Enabled
            // 
            this.ledModel3Enabled.BackColor = System.Drawing.Color.Transparent;
            this.ledModel3Enabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel3Enabled.Frame.Visible = false;
            this.ledModel3Enabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel3Enabled.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel3Enabled.Location = new System.Drawing.Point(1428, 36);
            this.ledModel3Enabled.Name = "ledModel3Enabled";
            this.ledModel3Enabled.ShowChannelName = false;
            this.ledModel3Enabled.Size = new System.Drawing.Size(65, 17);
            this.ledModel3Enabled.TabIndex = 1640;
            this.ledModel3Enabled.Text = "Enabled";
            this.ledModel3Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel2Trained
            // 
            this.ledModel2Trained.BackColor = System.Drawing.Color.Transparent;
            this.ledModel2Trained.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel2Trained.Frame.Visible = false;
            this.ledModel2Trained.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel2Trained.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel2Trained.Location = new System.Drawing.Point(1346, 53);
            this.ledModel2Trained.Name = "ledModel2Trained";
            this.ledModel2Trained.ShowChannelName = false;
            this.ledModel2Trained.Size = new System.Drawing.Size(78, 17);
            this.ledModel2Trained.TabIndex = 1639;
            this.ledModel2Trained.Text = "Trained";
            this.ledModel2Trained.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel2Enabled
            // 
            this.ledModel2Enabled.BackColor = System.Drawing.Color.Transparent;
            this.ledModel2Enabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel2Enabled.Frame.Visible = false;
            this.ledModel2Enabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel2Enabled.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel2Enabled.Location = new System.Drawing.Point(1346, 36);
            this.ledModel2Enabled.Name = "ledModel2Enabled";
            this.ledModel2Enabled.ShowChannelName = false;
            this.ledModel2Enabled.Size = new System.Drawing.Size(65, 17);
            this.ledModel2Enabled.TabIndex = 1638;
            this.ledModel2Enabled.Text = "Enabled";
            this.ledModel2Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel1Trained
            // 
            this.ledModel1Trained.BackColor = System.Drawing.Color.Transparent;
            this.ledModel1Trained.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel1Trained.Frame.Visible = false;
            this.ledModel1Trained.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel1Trained.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel1Trained.Location = new System.Drawing.Point(1262, 53);
            this.ledModel1Trained.Name = "ledModel1Trained";
            this.ledModel1Trained.ShowChannelName = false;
            this.ledModel1Trained.Size = new System.Drawing.Size(78, 17);
            this.ledModel1Trained.TabIndex = 1637;
            this.ledModel1Trained.Text = "Trained";
            this.ledModel1Trained.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledModel1Enabled
            // 
            this.ledModel1Enabled.BackColor = System.Drawing.Color.Transparent;
            this.ledModel1Enabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledModel1Enabled.Frame.Visible = false;
            this.ledModel1Enabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledModel1Enabled.LED.OffColor = System.Drawing.Color.Gray;
            this.ledModel1Enabled.Location = new System.Drawing.Point(1262, 36);
            this.ledModel1Enabled.Name = "ledModel1Enabled";
            this.ledModel1Enabled.ShowChannelName = false;
            this.ledModel1Enabled.Size = new System.Drawing.Size(65, 17);
            this.ledModel1Enabled.TabIndex = 1636;
            this.ledModel1Enabled.Text = "Enabled";
            this.ledModel1Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledCogPMAlignTool
            // 
            this.ledCogPMAlignTool.BackColor = System.Drawing.Color.Transparent;
            this.ledCogPMAlignTool.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledCogPMAlignTool.Frame.Visible = false;
            this.ledCogPMAlignTool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledCogPMAlignTool.LED.OffColor = System.Drawing.Color.Gray;
            this.ledCogPMAlignTool.Location = new System.Drawing.Point(1133, 13);
            this.ledCogPMAlignTool.Name = "ledCogPMAlignTool";
            this.ledCogPMAlignTool.ShowChannelName = false;
            this.ledCogPMAlignTool.Size = new System.Drawing.Size(117, 17);
            this.ledCogPMAlignTool.TabIndex = 1635;
            this.ledCogPMAlignTool.Text = "CogPMAlignTool";
            this.ledCogPMAlignTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(1512, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 1634;
            this.label6.Text = "Align #4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1428, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 1631;
            this.label7.Text = "Align #3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1346, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 1628;
            this.label5.Text = "Align #2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1262, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1625;
            this.label2.Text = "Align #1";
            // 
            // bitBtn4
            // 
            this.bitBtn4.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn4.Enabled = false;
            this.bitBtn4.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.bitBtn4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bitBtn4.Location = new System.Drawing.Point(1813, 421);
            this.bitBtn4.Name = "bitBtn4";
            this.bitBtn4.Size = new System.Drawing.Size(94, 62);
            this.bitBtn4.TabIndex = 1622;
            this.bitBtn4.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(1826, 719);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 1621;
            this.label25.Text = "ZoomRate";
            this.label25.Visible = false;
            // 
            // edZoomRate
            // 
            this.edZoomRate.BackColor = System.Drawing.Color.White;
            this.edZoomRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edZoomRate.DataType = DaekhonSystem.DataType.Double;
            this.edZoomRate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.edZoomRate.Frame.CornerRound = 1;
            this.edZoomRate.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.edZoomRate.Hint = "0.0 < Thickness < 34mm";
            this.edZoomRate.Location = new System.Drawing.Point(1781, 740);
            this.edZoomRate.Margin = new System.Windows.Forms.Padding(4);
            this.edZoomRate.Max = 0D;
            this.edZoomRate.Min = 0D;
            this.edZoomRate.MinimumSize = new System.Drawing.Size(1, 1);
            this.edZoomRate.Name = "edZoomRate";
            this.edZoomRate.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edZoomRate.PrecisionDigits = 3;
            this.edZoomRate.ShowHint = true;
            this.edZoomRate.Size = new System.Drawing.Size(126, 29);
            this.edZoomRate.TabIndex = 1620;
            this.edZoomRate.Text = "0.3740234375";
            this.edZoomRate.Visible = false;
            // 
            // btnZoomX3
            // 
            this.btnZoomX3.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnZoomX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnZoomX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomX3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnZoomX3.ForeColor = System.Drawing.Color.Black;
            this.btnZoomX3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZoomX3.LED.Size = new System.Drawing.Size(16, 40);
            this.btnZoomX3.Location = new System.Drawing.Point(755, 851);
            this.btnZoomX3.Margin2 = 10;
            this.btnZoomX3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZoomX3.Name = "btnZoomX3";
            this.btnZoomX3.Size = new System.Drawing.Size(94, 62);
            this.btnZoomX3.TabIndex = 1577;
            this.btnZoomX3.Text = "X3.0";
            this.btnZoomX3.UseVisualStyleBackColor = false;
            this.btnZoomX3.Click += new System.EventHandler(this.btnZoomX3_Click);
            // 
            // btnZoomX2_5
            // 
            this.btnZoomX2_5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnZoomX2_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnZoomX2_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomX2_5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnZoomX2_5.ForeColor = System.Drawing.Color.Black;
            this.btnZoomX2_5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZoomX2_5.LED.Size = new System.Drawing.Size(16, 40);
            this.btnZoomX2_5.Location = new System.Drawing.Point(655, 851);
            this.btnZoomX2_5.Margin2 = 10;
            this.btnZoomX2_5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZoomX2_5.Name = "btnZoomX2_5";
            this.btnZoomX2_5.Size = new System.Drawing.Size(94, 62);
            this.btnZoomX2_5.TabIndex = 1576;
            this.btnZoomX2_5.Text = "X2.5";
            this.btnZoomX2_5.UseVisualStyleBackColor = false;
            this.btnZoomX2_5.Click += new System.EventHandler(this.btnZoomX2_5_Click);
            // 
            // btnZoomX2
            // 
            this.btnZoomX2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnZoomX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnZoomX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomX2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnZoomX2.ForeColor = System.Drawing.Color.Black;
            this.btnZoomX2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZoomX2.LED.Size = new System.Drawing.Size(16, 40);
            this.btnZoomX2.Location = new System.Drawing.Point(555, 851);
            this.btnZoomX2.Margin2 = 10;
            this.btnZoomX2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZoomX2.Name = "btnZoomX2";
            this.btnZoomX2.Size = new System.Drawing.Size(94, 62);
            this.btnZoomX2.TabIndex = 1575;
            this.btnZoomX2.Text = "X2.0";
            this.btnZoomX2.UseVisualStyleBackColor = false;
            this.btnZoomX2.Click += new System.EventHandler(this.btnZoomX2_Click);
            // 
            // btnZoomX1_5
            // 
            this.btnZoomX1_5.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnZoomX1_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnZoomX1_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomX1_5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnZoomX1_5.ForeColor = System.Drawing.Color.Black;
            this.btnZoomX1_5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZoomX1_5.LED.Size = new System.Drawing.Size(16, 40);
            this.btnZoomX1_5.Location = new System.Drawing.Point(455, 851);
            this.btnZoomX1_5.Margin2 = 10;
            this.btnZoomX1_5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZoomX1_5.Name = "btnZoomX1_5";
            this.btnZoomX1_5.Size = new System.Drawing.Size(94, 62);
            this.btnZoomX1_5.TabIndex = 1574;
            this.btnZoomX1_5.Text = "X1.5";
            this.btnZoomX1_5.UseVisualStyleBackColor = false;
            this.btnZoomX1_5.Click += new System.EventHandler(this.btnZoomX1_5_Click);
            // 
            // btnZoomX1
            // 
            this.btnZoomX1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnZoomX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnZoomX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomX1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnZoomX1.ForeColor = System.Drawing.Color.Black;
            this.btnZoomX1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZoomX1.LED.Size = new System.Drawing.Size(16, 40);
            this.btnZoomX1.LED.Value = true;
            this.btnZoomX1.Location = new System.Drawing.Point(355, 851);
            this.btnZoomX1.Margin2 = 10;
            this.btnZoomX1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZoomX1.Name = "btnZoomX1";
            this.btnZoomX1.Size = new System.Drawing.Size(94, 62);
            this.btnZoomX1.TabIndex = 1573;
            this.btnZoomX1.Text = "X1.0";
            this.btnZoomX1.UseVisualStyleBackColor = false;
            this.btnZoomX1.Click += new System.EventHandler(this.btnZoomX1_Click);
            // 
            // lblCogModel
            // 
            this.lblCogModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCogModel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblCogModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCogModel.Location = new System.Drawing.Point(1002, 135);
            this.lblCogModel.Name = "lblCogModel";
            this.lblCogModel.Size = new System.Drawing.Size(225, 212);
            this.lblCogModel.TabIndex = 1572;
            this.lblCogModel.Text = "CogDisplay는 동적으로 생성\r\n\r\n이 메세지가 보이면 Control이 정상적으로 설치가 되지 않았습니다.";
            this.lblCogModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(1614, 662);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 28);
            this.label24.TabIndex = 1570;
            this.label24.Text = "Offset Y";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(1512, 662);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 28);
            this.label23.TabIndex = 1569;
            this.label23.Text = "Offset X";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManualSet
            // 
            this.btnManualSet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnManualSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnManualSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManualSet.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnManualSet.ForeColor = System.Drawing.Color.Black;
            this.btnManualSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManualSet.LED.Size = new System.Drawing.Size(16, 40);
            this.btnManualSet.Location = new System.Drawing.Point(1133, 353);
            this.btnManualSet.Margin2 = 10;
            this.btnManualSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnManualSet.Name = "btnManualSet";
            this.btnManualSet.Size = new System.Drawing.Size(94, 62);
            this.btnManualSet.TabIndex = 1568;
            this.btnManualSet.Text = "Manual\r\nSet";
            this.btnManualSet.UseVisualStyleBackColor = false;
            this.btnManualSet.Click += new System.EventHandler(this.btnManualSet_Click);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(1389, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 28);
            this.label21.TabIndex = 1567;
            this.label21.Text = "Bad";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(1343, 353);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 28);
            this.label22.TabIndex = 1566;
            this.label22.Text = "Good";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledSearchResultGood
            // 
            this.ledSearchResultGood.BackColor = System.Drawing.Color.Transparent;
            this.ledSearchResultGood.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledSearchResultGood.Frame.Visible = false;
            this.ledSearchResultGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledSearchResultGood.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledSearchResultGood.LED.Size = new System.Drawing.Size(28, 28);
            this.ledSearchResultGood.Location = new System.Drawing.Point(1350, 384);
            this.ledSearchResultGood.Name = "ledSearchResultGood";
            this.ledSearchResultGood.ShowChannelName = false;
            this.ledSearchResultGood.Size = new System.Drawing.Size(33, 32);
            this.ledSearchResultGood.TabIndex = 1565;
            this.ledSearchResultGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledSearchResultBad
            // 
            this.ledSearchResultBad.BackColor = System.Drawing.Color.Transparent;
            this.ledSearchResultBad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledSearchResultBad.Frame.Visible = false;
            this.ledSearchResultBad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledSearchResultBad.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledSearchResultBad.LED.OnColor = System.Drawing.Color.Red;
            this.ledSearchResultBad.LED.Size = new System.Drawing.Size(28, 28);
            this.ledSearchResultBad.Location = new System.Drawing.Point(1389, 384);
            this.ledSearchResultBad.Name = "ledSearchResultBad";
            this.ledSearchResultBad.ShowChannelName = false;
            this.ledSearchResultBad.Size = new System.Drawing.Size(33, 32);
            this.ledSearchResultBad.TabIndex = 1564;
            this.ledSearchResultBad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(1628, 353);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 28);
            this.label20.TabIndex = 1563;
            this.label20.Text = "Score";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viSearchResultScore
            // 
            this.viSearchResultScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viSearchResultScore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viSearchResultScore.ForeColor = System.Drawing.Color.Black;
            this.viSearchResultScore.FormatString = "0.000";
            this.viSearchResultScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viSearchResultScore.Location = new System.Drawing.Point(1627, 385);
            this.viSearchResultScore.Name = "viSearchResultScore";
            this.viSearchResultScore.Size = new System.Drawing.Size(94, 31);
            this.viSearchResultScore.TabIndex = 1562;
            this.viSearchResultScore.Text = "0";
            this.viSearchResultScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1058, 816);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 1560;
            this.label19.Text = "Align #4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1058, 777);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 1559;
            this.label18.Text = "Align #3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1059, 739);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 17);
            this.label17.TabIndex = 1558;
            this.label17.Text = "Align #2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1059, 701);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 1557;
            this.label15.Text = "Align #1";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(1528, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 28);
            this.label13.TabIndex = 1556;
            this.label13.Text = "Y";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(1430, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 28);
            this.label14.TabIndex = 1555;
            this.label14.Text = "X";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viSearchResultYPos
            // 
            this.viSearchResultYPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viSearchResultYPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viSearchResultYPos.ForeColor = System.Drawing.Color.Black;
            this.viSearchResultYPos.FormatString = "0.000";
            this.viSearchResultYPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viSearchResultYPos.Location = new System.Drawing.Point(1528, 385);
            this.viSearchResultYPos.Name = "viSearchResultYPos";
            this.viSearchResultYPos.Size = new System.Drawing.Size(94, 31);
            this.viSearchResultYPos.TabIndex = 1554;
            this.viSearchResultYPos.Text = "0";
            this.viSearchResultYPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viSearchResultXPos
            // 
            this.viSearchResultXPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viSearchResultXPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viSearchResultXPos.ForeColor = System.Drawing.Color.Black;
            this.viSearchResultXPos.FormatString = "0.000";
            this.viSearchResultXPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viSearchResultXPos.Location = new System.Drawing.Point(1428, 385);
            this.viSearchResultXPos.Name = "viSearchResultXPos";
            this.viSearchResultXPos.Size = new System.Drawing.Size(94, 31);
            this.viSearchResultXPos.TabIndex = 1553;
            this.viSearchResultXPos.Text = "0";
            this.viSearchResultXPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign4OffsetY
            // 
            this.viAlign4OffsetY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4OffsetY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign4OffsetY.ForeColor = System.Drawing.Color.Black;
            this.viAlign4OffsetY.FormatString = "0.000";
            this.viAlign4OffsetY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign4OffsetY.Location = new System.Drawing.Point(1614, 808);
            this.viAlign4OffsetY.Name = "viAlign4OffsetY";
            this.viAlign4OffsetY.Size = new System.Drawing.Size(94, 31);
            this.viAlign4OffsetY.TabIndex = 1552;
            this.viAlign4OffsetY.Text = "0";
            this.viAlign4OffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3OffsetY
            // 
            this.viAlign3OffsetY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3OffsetY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign3OffsetY.ForeColor = System.Drawing.Color.Black;
            this.viAlign3OffsetY.FormatString = "0.000";
            this.viAlign3OffsetY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign3OffsetY.Location = new System.Drawing.Point(1614, 769);
            this.viAlign3OffsetY.Name = "viAlign3OffsetY";
            this.viAlign3OffsetY.Size = new System.Drawing.Size(94, 31);
            this.viAlign3OffsetY.TabIndex = 1551;
            this.viAlign3OffsetY.Text = "0";
            this.viAlign3OffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2OffsetY
            // 
            this.viAlign2OffsetY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2OffsetY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign2OffsetY.ForeColor = System.Drawing.Color.Black;
            this.viAlign2OffsetY.FormatString = "0.000";
            this.viAlign2OffsetY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign2OffsetY.Location = new System.Drawing.Point(1614, 731);
            this.viAlign2OffsetY.Name = "viAlign2OffsetY";
            this.viAlign2OffsetY.Size = new System.Drawing.Size(94, 31);
            this.viAlign2OffsetY.TabIndex = 1550;
            this.viAlign2OffsetY.Text = "0";
            this.viAlign2OffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign1OffsetY
            // 
            this.viAlign1OffsetY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1OffsetY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign1OffsetY.ForeColor = System.Drawing.Color.Black;
            this.viAlign1OffsetY.FormatString = "0.000";
            this.viAlign1OffsetY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign1OffsetY.Location = new System.Drawing.Point(1614, 693);
            this.viAlign1OffsetY.Name = "viAlign1OffsetY";
            this.viAlign1OffsetY.Size = new System.Drawing.Size(94, 31);
            this.viAlign1OffsetY.TabIndex = 1549;
            this.viAlign1OffsetY.Text = "0";
            this.viAlign1OffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign4OffsetX
            // 
            this.viAlign4OffsetX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4OffsetX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign4OffsetX.ForeColor = System.Drawing.Color.Black;
            this.viAlign4OffsetX.FormatString = "0.000";
            this.viAlign4OffsetX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign4OffsetX.Location = new System.Drawing.Point(1514, 809);
            this.viAlign4OffsetX.Name = "viAlign4OffsetX";
            this.viAlign4OffsetX.Size = new System.Drawing.Size(94, 31);
            this.viAlign4OffsetX.TabIndex = 1548;
            this.viAlign4OffsetX.Text = "0";
            this.viAlign4OffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3OffsetX
            // 
            this.viAlign3OffsetX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3OffsetX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign3OffsetX.ForeColor = System.Drawing.Color.Black;
            this.viAlign3OffsetX.FormatString = "0.000";
            this.viAlign3OffsetX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign3OffsetX.Location = new System.Drawing.Point(1514, 770);
            this.viAlign3OffsetX.Name = "viAlign3OffsetX";
            this.viAlign3OffsetX.Size = new System.Drawing.Size(94, 31);
            this.viAlign3OffsetX.TabIndex = 1547;
            this.viAlign3OffsetX.Text = "0";
            this.viAlign3OffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2OffsetX
            // 
            this.viAlign2OffsetX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2OffsetX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign2OffsetX.ForeColor = System.Drawing.Color.Black;
            this.viAlign2OffsetX.FormatString = "0.000";
            this.viAlign2OffsetX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign2OffsetX.Location = new System.Drawing.Point(1514, 732);
            this.viAlign2OffsetX.Name = "viAlign2OffsetX";
            this.viAlign2OffsetX.Size = new System.Drawing.Size(94, 31);
            this.viAlign2OffsetX.TabIndex = 1546;
            this.viAlign2OffsetX.Text = "0";
            this.viAlign2OffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign1OffsetX
            // 
            this.viAlign1OffsetX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1OffsetX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign1OffsetX.ForeColor = System.Drawing.Color.Black;
            this.viAlign1OffsetX.FormatString = "0.000";
            this.viAlign1OffsetX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign1OffsetX.Location = new System.Drawing.Point(1514, 694);
            this.viAlign1OffsetX.Name = "viAlign1OffsetX";
            this.viAlign1OffsetX.Size = new System.Drawing.Size(94, 31);
            this.viAlign1OffsetX.TabIndex = 1545;
            this.viAlign1OffsetX.Text = "0";
            this.viAlign1OffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(1400, 581);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 31);
            this.label11.TabIndex = 1544;
            this.label11.Text = "편차";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAngleDiff
            // 
            this.viAngleDiff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAngleDiff.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAngleDiff.ForeColor = System.Drawing.Color.Black;
            this.viAngleDiff.FormatString = "0.000";
            this.viAngleDiff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAngleDiff.Location = new System.Drawing.Point(1400, 612);
            this.viAngleDiff.Name = "viAngleDiff";
            this.viAngleDiff.Size = new System.Drawing.Size(94, 31);
            this.viAngleDiff.TabIndex = 1543;
            this.viAngleDiff.Text = "0";
            this.viAngleDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(1300, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 1542;
            this.label4.Text = "측정 각도";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAngle0
            // 
            this.viAngle0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAngle0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAngle0.ForeColor = System.Drawing.Color.Black;
            this.viAngle0.FormatString = "0.000";
            this.viAngle0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAngle0.Location = new System.Drawing.Point(1200, 612);
            this.viAngle0.Name = "viAngle0";
            this.viAngle0.Size = new System.Drawing.Size(94, 31);
            this.viAngle0.TabIndex = 1541;
            this.viAngle0.Text = "0";
            this.viAngle0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1200, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 1540;
            this.label3.Text = "기준 각도";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAngle
            // 
            this.viAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAngle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAngle.ForeColor = System.Drawing.Color.Black;
            this.viAngle.FormatString = "0.000";
            this.viAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAngle.Location = new System.Drawing.Point(1300, 612);
            this.viAngle.Name = "viAngle";
            this.viAngle.Size = new System.Drawing.Size(94, 31);
            this.viAngle.TabIndex = 1539;
            this.viAngle.Text = "0";
            this.viAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(1161, 662);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 28);
            this.label16.TabIndex = 1538;
            this.label16.Text = "Bad";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(1115, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 28);
            this.label8.TabIndex = 1537;
            this.label8.Text = "Good";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bitBtn1
            // 
            this.bitBtn1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn1.Enabled = false;
            this.bitBtn1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.bitBtn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bitBtn1.Location = new System.Drawing.Point(1813, 285);
            this.bitBtn1.Name = "bitBtn1";
            this.bitBtn1.Size = new System.Drawing.Size(94, 62);
            this.bitBtn1.TabIndex = 1536;
            this.bitBtn1.UseVisualStyleBackColor = true;
            // 
            // bitBtn2
            // 
            this.bitBtn2.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.bitBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bitBtn2.Enabled = false;
            this.bitBtn2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.bitBtn2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bitBtn2.Location = new System.Drawing.Point(1813, 81);
            this.bitBtn2.Name = "bitBtn2";
            this.bitBtn2.Size = new System.Drawing.Size(94, 62);
            this.bitBtn2.TabIndex = 1535;
            this.bitBtn2.UseVisualStyleBackColor = true;
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSelectProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSelectProject.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSelectProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectProject.Location = new System.Drawing.Point(1813, 13);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(94, 62);
            this.btnSelectProject.TabIndex = 1534;
            this.btnSelectProject.Text = "Select Project";
            this.btnSelectProject.UseVisualStyleBackColor = true;
            this.btnSelectProject.Click += new System.EventHandler(this.btnSelectProject_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(1399, 662);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 28);
            this.label12.TabIndex = 1531;
            this.label12.Text = "Score";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(1300, 662);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 28);
            this.label10.TabIndex = 1530;
            this.label10.Text = "Y";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(1202, 662);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 1529;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledAlign4SearchResultGood
            // 
            this.ledAlign4SearchResultGood.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign4SearchResultGood.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign4SearchResultGood.Frame.Visible = false;
            this.ledAlign4SearchResultGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign4SearchResultGood.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign4SearchResultGood.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign4SearchResultGood.Location = new System.Drawing.Point(1122, 808);
            this.ledAlign4SearchResultGood.Name = "ledAlign4SearchResultGood";
            this.ledAlign4SearchResultGood.ShowChannelName = false;
            this.ledAlign4SearchResultGood.Size = new System.Drawing.Size(33, 32);
            this.ledAlign4SearchResultGood.TabIndex = 1525;
            this.ledAlign4SearchResultGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign4SearchResultBad
            // 
            this.ledAlign4SearchResultBad.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign4SearchResultBad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign4SearchResultBad.Frame.Visible = false;
            this.ledAlign4SearchResultBad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign4SearchResultBad.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign4SearchResultBad.LED.OnColor = System.Drawing.Color.Red;
            this.ledAlign4SearchResultBad.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign4SearchResultBad.Location = new System.Drawing.Point(1161, 808);
            this.ledAlign4SearchResultBad.Name = "ledAlign4SearchResultBad";
            this.ledAlign4SearchResultBad.ShowChannelName = false;
            this.ledAlign4SearchResultBad.Size = new System.Drawing.Size(33, 32);
            this.ledAlign4SearchResultBad.TabIndex = 1524;
            this.ledAlign4SearchResultBad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign3SearchResultGood
            // 
            this.ledAlign3SearchResultGood.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign3SearchResultGood.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign3SearchResultGood.Frame.Visible = false;
            this.ledAlign3SearchResultGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign3SearchResultGood.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign3SearchResultGood.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign3SearchResultGood.Location = new System.Drawing.Point(1122, 769);
            this.ledAlign3SearchResultGood.Name = "ledAlign3SearchResultGood";
            this.ledAlign3SearchResultGood.ShowChannelName = false;
            this.ledAlign3SearchResultGood.Size = new System.Drawing.Size(33, 32);
            this.ledAlign3SearchResultGood.TabIndex = 1523;
            this.ledAlign3SearchResultGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign3SearchResultBad
            // 
            this.ledAlign3SearchResultBad.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign3SearchResultBad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign3SearchResultBad.Frame.Visible = false;
            this.ledAlign3SearchResultBad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign3SearchResultBad.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign3SearchResultBad.LED.OnColor = System.Drawing.Color.Red;
            this.ledAlign3SearchResultBad.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign3SearchResultBad.Location = new System.Drawing.Point(1161, 769);
            this.ledAlign3SearchResultBad.Name = "ledAlign3SearchResultBad";
            this.ledAlign3SearchResultBad.ShowChannelName = false;
            this.ledAlign3SearchResultBad.Size = new System.Drawing.Size(33, 32);
            this.ledAlign3SearchResultBad.TabIndex = 1522;
            this.ledAlign3SearchResultBad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign2SearchResultGood
            // 
            this.ledAlign2SearchResultGood.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign2SearchResultGood.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign2SearchResultGood.Frame.Visible = false;
            this.ledAlign2SearchResultGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign2SearchResultGood.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign2SearchResultGood.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign2SearchResultGood.Location = new System.Drawing.Point(1122, 731);
            this.ledAlign2SearchResultGood.Name = "ledAlign2SearchResultGood";
            this.ledAlign2SearchResultGood.ShowChannelName = false;
            this.ledAlign2SearchResultGood.Size = new System.Drawing.Size(33, 32);
            this.ledAlign2SearchResultGood.TabIndex = 1521;
            this.ledAlign2SearchResultGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign2SearchResultBad
            // 
            this.ledAlign2SearchResultBad.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign2SearchResultBad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign2SearchResultBad.Frame.Visible = false;
            this.ledAlign2SearchResultBad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign2SearchResultBad.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign2SearchResultBad.LED.OnColor = System.Drawing.Color.Red;
            this.ledAlign2SearchResultBad.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign2SearchResultBad.Location = new System.Drawing.Point(1161, 731);
            this.ledAlign2SearchResultBad.Name = "ledAlign2SearchResultBad";
            this.ledAlign2SearchResultBad.ShowChannelName = false;
            this.ledAlign2SearchResultBad.Size = new System.Drawing.Size(33, 32);
            this.ledAlign2SearchResultBad.TabIndex = 1520;
            this.ledAlign2SearchResultBad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledAlign1SearchResultGood
            // 
            this.ledAlign1SearchResultGood.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign1SearchResultGood.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign1SearchResultGood.Frame.Visible = false;
            this.ledAlign1SearchResultGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign1SearchResultGood.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign1SearchResultGood.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign1SearchResultGood.Location = new System.Drawing.Point(1122, 693);
            this.ledAlign1SearchResultGood.Name = "ledAlign1SearchResultGood";
            this.ledAlign1SearchResultGood.ShowChannelName = false;
            this.ledAlign1SearchResultGood.Size = new System.Drawing.Size(33, 32);
            this.ledAlign1SearchResultGood.TabIndex = 1519;
            this.ledAlign1SearchResultGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viAlign4SearchScore
            // 
            this.viAlign4SearchScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4SearchScore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign4SearchScore.ForeColor = System.Drawing.Color.Black;
            this.viAlign4SearchScore.FormatString = "0.000";
            this.viAlign4SearchScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign4SearchScore.Location = new System.Drawing.Point(1399, 809);
            this.viAlign4SearchScore.Name = "viAlign4SearchScore";
            this.viAlign4SearchScore.Size = new System.Drawing.Size(94, 31);
            this.viAlign4SearchScore.TabIndex = 1513;
            this.viAlign4SearchScore.Text = "0";
            this.viAlign4SearchScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign4SearchResultYPos
            // 
            this.viAlign4SearchResultYPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4SearchResultYPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign4SearchResultYPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign4SearchResultYPos.FormatString = "0.000";
            this.viAlign4SearchResultYPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign4SearchResultYPos.Location = new System.Drawing.Point(1300, 809);
            this.viAlign4SearchResultYPos.Name = "viAlign4SearchResultYPos";
            this.viAlign4SearchResultYPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign4SearchResultYPos.TabIndex = 1512;
            this.viAlign4SearchResultYPos.Text = "0";
            this.viAlign4SearchResultYPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign4SearchResultXPos
            // 
            this.viAlign4SearchResultXPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign4SearchResultXPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign4SearchResultXPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign4SearchResultXPos.FormatString = "0.000";
            this.viAlign4SearchResultXPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign4SearchResultXPos.Location = new System.Drawing.Point(1200, 809);
            this.viAlign4SearchResultXPos.Name = "viAlign4SearchResultXPos";
            this.viAlign4SearchResultXPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign4SearchResultXPos.TabIndex = 1511;
            this.viAlign4SearchResultXPos.Text = "0";
            this.viAlign4SearchResultXPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3SearchScore
            // 
            this.viAlign3SearchScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3SearchScore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign3SearchScore.ForeColor = System.Drawing.Color.Black;
            this.viAlign3SearchScore.FormatString = "0.000";
            this.viAlign3SearchScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign3SearchScore.Location = new System.Drawing.Point(1399, 770);
            this.viAlign3SearchScore.Name = "viAlign3SearchScore";
            this.viAlign3SearchScore.Size = new System.Drawing.Size(94, 31);
            this.viAlign3SearchScore.TabIndex = 1510;
            this.viAlign3SearchScore.Text = "0";
            this.viAlign3SearchScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3SearchResultYPos
            // 
            this.viAlign3SearchResultYPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3SearchResultYPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign3SearchResultYPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign3SearchResultYPos.FormatString = "0.000";
            this.viAlign3SearchResultYPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign3SearchResultYPos.Location = new System.Drawing.Point(1300, 770);
            this.viAlign3SearchResultYPos.Name = "viAlign3SearchResultYPos";
            this.viAlign3SearchResultYPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign3SearchResultYPos.TabIndex = 1509;
            this.viAlign3SearchResultYPos.Text = "0";
            this.viAlign3SearchResultYPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign3SearchResultXPos
            // 
            this.viAlign3SearchResultXPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign3SearchResultXPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign3SearchResultXPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign3SearchResultXPos.FormatString = "0.000";
            this.viAlign3SearchResultXPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign3SearchResultXPos.Location = new System.Drawing.Point(1200, 770);
            this.viAlign3SearchResultXPos.Name = "viAlign3SearchResultXPos";
            this.viAlign3SearchResultXPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign3SearchResultXPos.TabIndex = 1508;
            this.viAlign3SearchResultXPos.Text = "0";
            this.viAlign3SearchResultXPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2SearchScore
            // 
            this.viAlign2SearchScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2SearchScore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign2SearchScore.ForeColor = System.Drawing.Color.Black;
            this.viAlign2SearchScore.FormatString = "0.000";
            this.viAlign2SearchScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign2SearchScore.Location = new System.Drawing.Point(1399, 732);
            this.viAlign2SearchScore.Name = "viAlign2SearchScore";
            this.viAlign2SearchScore.Size = new System.Drawing.Size(94, 31);
            this.viAlign2SearchScore.TabIndex = 1507;
            this.viAlign2SearchScore.Text = "0";
            this.viAlign2SearchScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2SearchResultYPos
            // 
            this.viAlign2SearchResultYPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2SearchResultYPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign2SearchResultYPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign2SearchResultYPos.FormatString = "0.000";
            this.viAlign2SearchResultYPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign2SearchResultYPos.Location = new System.Drawing.Point(1300, 732);
            this.viAlign2SearchResultYPos.Name = "viAlign2SearchResultYPos";
            this.viAlign2SearchResultYPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign2SearchResultYPos.TabIndex = 1506;
            this.viAlign2SearchResultYPos.Text = "0";
            this.viAlign2SearchResultYPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign2SearchResultXPos
            // 
            this.viAlign2SearchResultXPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign2SearchResultXPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign2SearchResultXPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign2SearchResultXPos.FormatString = "0.000";
            this.viAlign2SearchResultXPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign2SearchResultXPos.Location = new System.Drawing.Point(1200, 732);
            this.viAlign2SearchResultXPos.Name = "viAlign2SearchResultXPos";
            this.viAlign2SearchResultXPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign2SearchResultXPos.TabIndex = 1505;
            this.viAlign2SearchResultXPos.Text = "0";
            this.viAlign2SearchResultXPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign1SearchScore
            // 
            this.viAlign1SearchScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1SearchScore.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign1SearchScore.ForeColor = System.Drawing.Color.Black;
            this.viAlign1SearchScore.FormatString = "0.000";
            this.viAlign1SearchScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign1SearchScore.Location = new System.Drawing.Point(1399, 694);
            this.viAlign1SearchScore.Name = "viAlign1SearchScore";
            this.viAlign1SearchScore.Size = new System.Drawing.Size(94, 31);
            this.viAlign1SearchScore.TabIndex = 1504;
            this.viAlign1SearchScore.Text = "0";
            this.viAlign1SearchScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign1SearchResultYPos
            // 
            this.viAlign1SearchResultYPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1SearchResultYPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign1SearchResultYPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign1SearchResultYPos.FormatString = "0.000";
            this.viAlign1SearchResultYPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign1SearchResultYPos.Location = new System.Drawing.Point(1300, 694);
            this.viAlign1SearchResultYPos.Name = "viAlign1SearchResultYPos";
            this.viAlign1SearchResultYPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign1SearchResultYPos.TabIndex = 1503;
            this.viAlign1SearchResultYPos.Text = "0";
            this.viAlign1SearchResultYPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viAlign1SearchResultXPos
            // 
            this.viAlign1SearchResultXPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viAlign1SearchResultXPos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viAlign1SearchResultXPos.ForeColor = System.Drawing.Color.Black;
            this.viAlign1SearchResultXPos.FormatString = "0.000";
            this.viAlign1SearchResultXPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viAlign1SearchResultXPos.Location = new System.Drawing.Point(1200, 694);
            this.viAlign1SearchResultXPos.Name = "viAlign1SearchResultXPos";
            this.viAlign1SearchResultXPos.Size = new System.Drawing.Size(94, 31);
            this.viAlign1SearchResultXPos.TabIndex = 1502;
            this.viAlign1SearchResultXPos.Text = "0";
            this.viAlign1SearchResultXPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledAlign1SearchResultBad
            // 
            this.ledAlign1SearchResultBad.BackColor = System.Drawing.Color.Transparent;
            this.ledAlign1SearchResultBad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ledAlign1SearchResultBad.Frame.Visible = false;
            this.ledAlign1SearchResultBad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledAlign1SearchResultBad.LED.Layout = DaekhonSystem.LEDLayout.Center;
            this.ledAlign1SearchResultBad.LED.OnColor = System.Drawing.Color.Red;
            this.ledAlign1SearchResultBad.LED.Size = new System.Drawing.Size(28, 28);
            this.ledAlign1SearchResultBad.Location = new System.Drawing.Point(1161, 693);
            this.ledAlign1SearchResultBad.Name = "ledAlign1SearchResultBad";
            this.ledAlign1SearchResultBad.ShowChannelName = false;
            this.ledAlign1SearchResultBad.Size = new System.Drawing.Size(33, 32);
            this.ledAlign1SearchResultBad.TabIndex = 1489;
            this.ledAlign1SearchResultBad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(999, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1450;
            this.label1.Text = "Registered Model";
            // 
            // cbAlignIndex
            // 
            this.cbAlignIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlignIndex.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbAlignIndex.FormattingEnabled = true;
            this.cbAlignIndex.Items.AddRange(new object[] {
            "Align #1",
            "Align #2",
            "Align #3",
            "Align #4"});
            this.cbAlignIndex.Location = new System.Drawing.Point(1114, 102);
            this.cbAlignIndex.Name = "cbAlignIndex";
            this.cbAlignIndex.Size = new System.Drawing.Size(91, 24);
            this.cbAlignIndex.TabIndex = 1449;
            this.cbAlignIndex.SelectedIndexChanged += new System.EventHandler(this.cbAlignIndex_SelectedIndexChanged);
            // 
            // btnShowMVS
            // 
            this.btnShowMVS.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnShowMVS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnShowMVS.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnShowMVS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowMVS.Location = new System.Drawing.Point(1813, 353);
            this.btnShowMVS.Name = "btnShowMVS";
            this.btnShowMVS.Size = new System.Drawing.Size(94, 62);
            this.btnShowMVS.TabIndex = 1432;
            this.btnShowMVS.Text = "MVS";
            this.btnShowMVS.UseVisualStyleBackColor = true;
            this.btnShowMVS.Click += new System.EventHandler(this.btnShowMVS_Click);
            // 
            // lblCogDisplay1
            // 
            this.lblCogDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCogDisplay1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblCogDisplay1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCogDisplay1.Location = new System.Drawing.Point(12, 60);
            this.lblCogDisplay1.Name = "lblCogDisplay1";
            this.lblCogDisplay1.Size = new System.Drawing.Size(937, 783);
            this.lblCogDisplay1.TabIndex = 1439;
            this.lblCogDisplay1.Text = "CogDisplay는 동적으로 생성\r\n\r\n이 메세지가 보이면 Control이 정상적으로 설치가 되지 않았습니다.";
            this.lblCogDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCogDisplay1.Click += new System.EventHandler(this.lblCogDisplay1_Click);
            this.lblCogDisplay1.DoubleClick += new System.EventHandler(this.lblCogDisplay1_DoubleClick);
            this.lblCogDisplay1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCogDisplay1_MouseDown);
            this.lblCogDisplay1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCogDisplay1_MouseMove);
            this.lblCogDisplay1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblCogDisplay1_MouseUp);
            // 
            // btnShowROI
            // 
            this.btnShowROI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnShowROI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnShowROI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowROI.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnShowROI.ForeColor = System.Drawing.Color.Black;
            this.btnShowROI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowROI.Location = new System.Drawing.Point(1234, 203);
            this.btnShowROI.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowROI.Name = "btnShowROI";
            this.btnShowROI.Size = new System.Drawing.Size(94, 62);
            this.btnShowROI.TabIndex = 1438;
            this.btnShowROI.Text = "Show ROI";
            this.btnShowROI.UseVisualStyleBackColor = false;
            this.btnShowROI.Click += new System.EventHandler(this.btnShowROI_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSaveProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSaveProject.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSaveProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveProject.Location = new System.Drawing.Point(1813, 217);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(94, 62);
            this.btnSaveProject.TabIndex = 1437;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLoadProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLoadProject.Enabled = false;
            this.btnLoadProject.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnLoadProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadProject.Location = new System.Drawing.Point(1813, 149);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(94, 62);
            this.btnLoadProject.TabIndex = 1436;
            this.btnLoadProject.Text = "Load Project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // btnSave8Image
            // 
            this.btnSave8Image.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSave8Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSave8Image.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSave8Image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave8Image.Location = new System.Drawing.Point(1813, 557);
            this.btnSave8Image.Name = "btnSave8Image";
            this.btnSave8Image.Size = new System.Drawing.Size(94, 62);
            this.btnSave8Image.TabIndex = 1435;
            this.btnSave8Image.Text = "Save 8bit Image";
            this.btnSave8Image.UseVisualStyleBackColor = true;
            this.btnSave8Image.Click += new System.EventHandler(this.btnSave8Image_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOpenImage.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnOpenImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenImage.Location = new System.Drawing.Point(1813, 489);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(94, 62);
            this.btnOpenImage.TabIndex = 1434;
            this.btnOpenImage.Text = "Open 8bit Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(1002, 353);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 62);
            this.btnSearch.TabIndex = 1433;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModelTrain
            // 
            this.btnModelTrain.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnModelTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnModelTrain.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnModelTrain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModelTrain.Location = new System.Drawing.Point(1234, 135);
            this.btnModelTrain.Name = "btnModelTrain";
            this.btnModelTrain.Size = new System.Drawing.Size(94, 62);
            this.btnModelTrain.TabIndex = 1432;
            this.btnModelTrain.Text = "Model Train";
            this.btnModelTrain.UseVisualStyleBackColor = true;
            this.btnModelTrain.Click += new System.EventHandler(this.btnModelTrain_Click);
            // 
            // btnGrab
            // 
            this.btnGrab.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrab.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnGrab.ForeColor = System.Drawing.Color.Black;
            this.btnGrab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGrab.LED.Size = new System.Drawing.Size(16, 40);
            this.btnGrab.Location = new System.Drawing.Point(112, 851);
            this.btnGrab.Margin2 = 10;
            this.btnGrab.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(94, 62);
            this.btnGrab.TabIndex = 1318;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = false;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // btnShowCross
            // 
            this.btnShowCross.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnShowCross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnShowCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCross.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnShowCross.ForeColor = System.Drawing.Color.Black;
            this.btnShowCross.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowCross.Location = new System.Drawing.Point(855, 851);
            this.btnShowCross.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowCross.Name = "btnShowCross";
            this.btnShowCross.Size = new System.Drawing.Size(94, 62);
            this.btnShowCross.TabIndex = 1203;
            this.btnShowCross.Text = "Cross Line";
            this.btnShowCross.UseVisualStyleBackColor = false;
            this.btnShowCross.Click += new System.EventHandler(this.btnShowCross_Click);
            // 
            // btnLive
            // 
            this.btnLive.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnLive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLive.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLive.ForeColor = System.Drawing.Color.Black;
            this.btnLive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLive.LED.Size = new System.Drawing.Size(16, 40);
            this.btnLive.Location = new System.Drawing.Point(12, 851);
            this.btnLive.Margin2 = 10;
            this.btnLive.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(94, 62);
            this.btnLive.TabIndex = 1203;
            this.btnLive.Text = "Live";
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // gradLabel14
            // 
            this.gradLabel14.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradLabel14.Font = new System.Drawing.Font("굴림", 9F);
            this.gradLabel14.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel14.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel14.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gradLabel14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gradLabel14.Location = new System.Drawing.Point(-15, -202);
            this.gradLabel14.Name = "gradLabel14";
            this.gradLabel14.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.gradLabel14.Size = new System.Drawing.Size(1638, 93);
            this.gradLabel14.TabIndex = 1201;
            this.gradLabel14.Text = "DISPLAY";
            this.gradLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panVision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panClient);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "panVision";
            this.Size = new System.Drawing.Size(1920, 930);
            this.Load += new System.EventHandler(this.panVision1_Load);
            this.panClient.ResumeLayout(false);
            this.panClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DaekhonSystem.Panel panClient;
        private DaekhonSystem.BitBtn bitBtn1;
        private DaekhonSystem.BitBtn bitBtn2;
        private DaekhonSystem.BitBtn btnSelectProject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlignIndex;
        private DaekhonSystem.BitBtn btnShowMVS;
        private System.Windows.Forms.Label lblCogDisplay1;
        private DaekhonSystem.LEDButton btnShowROI;
        private DaekhonSystem.BitBtn btnSave8Image;
        private DaekhonSystem.BitBtn btnOpenImage;
        private DaekhonSystem.BitBtn btnSearch;
        private DaekhonSystem.BitBtn btnModelTrain;
        private DaekhonSystem.LEDButton btnGrab;
        private DaekhonSystem.LEDButton btnLive;
        private DaekhonSystem.GradientLabel gradLabel14;
        public DaekhonSystem.BitBtn btnSaveProject;
        public DaekhonSystem.BitBtn btnLoadProject;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        public DaekhonSystem.ValueIndicator viAlign4SearchResultYPos;
        public DaekhonSystem.ValueIndicator viAlign4SearchResultXPos;
        public DaekhonSystem.ValueIndicator viAlign3SearchResultYPos;
        public DaekhonSystem.ValueIndicator viAlign3SearchResultXPos;
        public DaekhonSystem.ValueIndicator viAlign2SearchResultYPos;
        public DaekhonSystem.ValueIndicator viAlign2SearchResultXPos;
        public DaekhonSystem.ValueIndicator viAlign1SearchResultYPos;
        public DaekhonSystem.ValueIndicator viAlign1SearchResultXPos;
        public DaekhonSystem.ValueIndicator viAngle;
        private System.Windows.Forms.Label label4;
        public DaekhonSystem.ValueIndicator viAngle0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        public DaekhonSystem.ValueIndicator viAngleDiff;
        public DaekhonSystem.ValueIndicator viAlign4OffsetY;
        public DaekhonSystem.ValueIndicator viAlign3OffsetY;
        public DaekhonSystem.ValueIndicator viAlign2OffsetY;
        public DaekhonSystem.ValueIndicator viAlign1OffsetY;
        public DaekhonSystem.ValueIndicator viAlign4OffsetX;
        public DaekhonSystem.ValueIndicator viAlign3OffsetX;
        public DaekhonSystem.ValueIndicator viAlign2OffsetX;
        public DaekhonSystem.ValueIndicator viAlign1OffsetX;
        public DaekhonSystem.ValueIndicator viAlign4SearchScore;
        public DaekhonSystem.ValueIndicator viAlign3SearchScore;
        public DaekhonSystem.ValueIndicator viAlign2SearchScore;
        public DaekhonSystem.ValueIndicator viAlign1SearchScore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public DaekhonSystem.ValueIndicator viSearchResultYPos;
        public DaekhonSystem.ValueIndicator viSearchResultXPos;
        private System.Windows.Forms.Label label15;
        public DaekhonSystem.LEDLabel ledAlign4SearchResultGood;
        public DaekhonSystem.LEDLabel ledAlign4SearchResultBad;
        public DaekhonSystem.LEDLabel ledAlign3SearchResultGood;
        public DaekhonSystem.LEDLabel ledAlign3SearchResultBad;
        public DaekhonSystem.LEDLabel ledAlign2SearchResultGood;
        public DaekhonSystem.LEDLabel ledAlign2SearchResultBad;
        public DaekhonSystem.LEDLabel ledAlign1SearchResultGood;
        public DaekhonSystem.LEDLabel ledAlign1SearchResultBad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        public DaekhonSystem.ValueIndicator viSearchResultScore;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public DaekhonSystem.LEDLabel ledSearchResultGood;
        public DaekhonSystem.LEDLabel ledSearchResultBad;
        public DaekhonSystem.LEDButton btnManualSet;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        public DaekhonSystem.LEDButton btnShowCross;
        private DaekhonSystem.LEDButton btnZoomX3;
        private DaekhonSystem.LEDButton btnZoomX2_5;
        private DaekhonSystem.LEDButton btnZoomX2;
        private DaekhonSystem.LEDButton btnZoomX1_5;
        private DaekhonSystem.LEDButton btnZoomX1;
        public DaekhonSystem.KeypadEdit edZoomRate;
        private System.Windows.Forms.Label label25;
        private DaekhonSystem.BitBtn bitBtn4;
        public DaekhonSystem.LEDLabel ledCogPMAlignTool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DaekhonSystem.LEDLabel ledModel4Trained;
        private DaekhonSystem.LEDLabel ledModel4Enabled;
        private DaekhonSystem.LEDLabel ledModel3Trained;
        private DaekhonSystem.LEDLabel ledModel3Enabled;
        private DaekhonSystem.LEDLabel ledModel2Trained;
        private DaekhonSystem.LEDLabel ledModel2Enabled;
        private DaekhonSystem.LEDLabel ledModel1Trained;
        private DaekhonSystem.LEDLabel ledModel1Enabled;
        private DaekhonSystem.BitBtn btnSave24Image;
        private System.Windows.Forms.Label lblCogModel;
        private System.Windows.Forms.Label lblCogResult;
        private DaekhonSystem.Label lblInfo;
        private System.Windows.Forms.Label label26;
    }
}
