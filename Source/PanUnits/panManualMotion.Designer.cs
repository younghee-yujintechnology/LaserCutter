using yjTech;
using System.Collections.Generic;

namespace LaserCutter
{
    partial class panManualMotion
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>`
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ImageList imageList2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panManualMotion));
            this.dsIO = new yjTech.DataServer();
            this.dsMotion = new yjTech.DataServer();
            this.ReadThread = new yjTech.Thread();
            this.uiTabControl1 = new yjTech.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ledIn31 = new yjTech.LEDImageLabel();
            this.ledIn30 = new yjTech.LEDImageLabel();
            this.ledIn29 = new yjTech.LEDImageLabel();
            this.ledIn28 = new yjTech.LEDImageLabel();
            this.ledIn27 = new yjTech.LEDImageLabel();
            this.ledIn26 = new yjTech.LEDImageLabel();
            this.ledIn25 = new yjTech.LEDImageLabel();
            this.ledIn24 = new yjTech.LEDImageLabel();
            this.ledIn23 = new yjTech.LEDImageLabel();
            this.ledDoor5 = new yjTech.LEDImageLabel();
            this.ledDoor4 = new yjTech.LEDImageLabel();
            this.ledDoor3 = new yjTech.LEDImageLabel();
            this.ledDoor2 = new yjTech.LEDImageLabel();
            this.ledDoor1 = new yjTech.LEDImageLabel();
            this.ledIn17 = new yjTech.LEDImageLabel();
            this.ledIn16 = new yjTech.LEDImageLabel();
            this.ledIn15 = new yjTech.LEDImageLabel();
            this.ledIn14 = new yjTech.LEDImageLabel();
            this.ledIn13 = new yjTech.LEDImageLabel();
            this.ledIn12 = new yjTech.LEDImageLabel();
            this.ledIn11 = new yjTech.LEDImageLabel();
            this.ledIn10 = new yjTech.LEDImageLabel();
            this.ledIn09 = new yjTech.LEDImageLabel();
            this.ledIn08 = new yjTech.LEDImageLabel();
            this.ledIn07 = new yjTech.LEDImageLabel();
            this.ledIn06 = new yjTech.LEDImageLabel();
            this.ledIn05 = new yjTech.LEDImageLabel();
            this.ledIn04 = new yjTech.LEDImageLabel();
            this.ledIn03 = new yjTech.LEDImageLabel();
            this.ledIn02 = new yjTech.LEDImageLabel();
            this.ledIn01 = new yjTech.LEDImageLabel();
            this.ledIn00 = new yjTech.LEDImageLabel();
            this.ledArray8 = new yjTech.LEDImageArray();
            this.ledArray7 = new yjTech.LEDImageArray();
            this.ledArray6 = new yjTech.LEDImageArray();
            this.ledArray5 = new yjTech.LEDImageArray();
            this.lblInputPort7 = new yjTech.Label();
            this.lblInputPort3 = new yjTech.Label();
            this.lblInputPort6 = new yjTech.Label();
            this.lblInputPort2 = new yjTech.Label();
            this.lblInputPort5 = new yjTech.Label();
            this.lblInputPort1 = new yjTech.Label();
            this.lblInputPort4 = new yjTech.Label();
            this.lblInputPort0 = new yjTech.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.switchOut63 = new yjTech.SunnySwitch();
            this.switchOut62 = new yjTech.SunnySwitch();
            this.switchOut61 = new yjTech.SunnySwitch();
            this.switchOut60 = new yjTech.SunnySwitch();
            this.switchOut59 = new yjTech.SunnySwitch();
            this.switchOut58 = new yjTech.SunnySwitch();
            this.switchOut57 = new yjTech.SunnySwitch();
            this.switchOut56 = new yjTech.SunnySwitch();
            this.switchOut55 = new yjTech.SunnySwitch();
            this.switchOut54 = new yjTech.SunnySwitch();
            this.switchOut53 = new yjTech.SunnySwitch();
            this.switchOut52 = new yjTech.SunnySwitch();
            this.switchOut51 = new yjTech.SunnySwitch();
            this.switchOut50 = new yjTech.SunnySwitch();
            this.switchOut49 = new yjTech.SunnySwitch();
            this.switchOut48 = new yjTech.SunnySwitch();
            this.switchOut47 = new yjTech.SunnySwitch();
            this.switchOut46 = new yjTech.SunnySwitch();
            this.switchOut45 = new yjTech.SunnySwitch();
            this.switchOut44 = new yjTech.SunnySwitch();
            this.switchOut43 = new yjTech.SunnySwitch();
            this.switchOut42 = new yjTech.SunnySwitch();
            this.switchOut41 = new yjTech.SunnySwitch();
            this.switchOut40 = new yjTech.SunnySwitch();
            this.switchOut39 = new yjTech.SunnySwitch();
            this.switchOut38 = new yjTech.SunnySwitch();
            this.switchOut37 = new yjTech.SunnySwitch();
            this.switchOut36 = new yjTech.SunnySwitch();
            this.switchOut35 = new yjTech.SunnySwitch();
            this.switchOut34 = new yjTech.SunnySwitch();
            this.switchOut33 = new yjTech.SunnySwitch();
            this.switchOut32 = new yjTech.SunnySwitch();
            this.switchOut31 = new yjTech.SunnySwitch();
            this.switchOut30 = new yjTech.SunnySwitch();
            this.switchOut29 = new yjTech.SunnySwitch();
            this.switchOut28 = new yjTech.SunnySwitch();
            this.switchOut27 = new yjTech.SunnySwitch();
            this.switchOut26 = new yjTech.SunnySwitch();
            this.switchOut25 = new yjTech.SunnySwitch();
            this.switchOut24 = new yjTech.SunnySwitch();
            this.switchOut23 = new yjTech.SunnySwitch();
            this.switchOut22 = new yjTech.SunnySwitch();
            this.switchOut21 = new yjTech.SunnySwitch();
            this.switchOut20 = new yjTech.SunnySwitch();
            this.switchOut19 = new yjTech.SunnySwitch();
            this.switchOut18 = new yjTech.SunnySwitch();
            this.switchOut17 = new yjTech.SunnySwitch();
            this.switchOut16 = new yjTech.SunnySwitch();
            this.switchOut15 = new yjTech.SunnySwitch();
            this.switchOut14 = new yjTech.SunnySwitch();
            this.switchOut13 = new yjTech.SunnySwitch();
            this.switchOut12 = new yjTech.SunnySwitch();
            this.switchOut11 = new yjTech.SunnySwitch();
            this.switchOut10 = new yjTech.SunnySwitch();
            this.switchOut9 = new yjTech.SunnySwitch();
            this.switchOut8 = new yjTech.SunnySwitch();
            this.switchOut7 = new yjTech.SunnySwitch();
            this.switchOut6 = new yjTech.SunnySwitch();
            this.switchOut5 = new yjTech.SunnySwitch();
            this.switchOut4 = new yjTech.SunnySwitch();
            this.switchOut3 = new yjTech.SunnySwitch();
            this.switchOut2 = new yjTech.SunnySwitch();
            this.switchOut1 = new yjTech.SunnySwitch();
            this.switchOut0 = new yjTech.SunnySwitch();
            this.lblOutputPort7 = new yjTech.Label();
            this.lblOutputPort3 = new yjTech.Label();
            this.lblOutputPort6 = new yjTech.Label();
            this.lblOutputPort2 = new yjTech.Label();
            this.lblOutputPort5 = new yjTech.Label();
            this.lblOutputPort1 = new yjTech.Label();
            this.lblOutputPort4 = new yjTech.Label();
            this.lblOutputPort0 = new yjTech.Label();
            imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.uiTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "image_1.bmp");
            imageList2.Images.SetKeyName(1, "image_2.bmp");
            imageList2.Images.SetKeyName(2, "Gray.png");
            // 
            // ReadThread
            // 
            this.ReadThread.Enabled = true;
            this.ReadThread.Interval = 100;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 3);
            this.uiTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiTabControl1.ShowActiveCloseButton = false;
            this.uiTabControl1.ShowCloseButton = false;
            this.uiTabControl1.Size = new System.Drawing.Size(1202, 876);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uiTabControl1.TabIndex = 1337;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.Lime;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.Black;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.Red;
            this.uiTabControl1.TabSelectedHighColorSize = 4;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Black;
            this.uiTabControl1.TabVisible = true;
            this.uiTabControl1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTabControl1.TipsColor = System.Drawing.Color.Red;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTabControl1.TipsForeColor = System.Drawing.Color.White;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.ledIn31);
            this.tabPage2.Controls.Add(this.ledIn30);
            this.tabPage2.Controls.Add(this.ledIn29);
            this.tabPage2.Controls.Add(this.ledIn28);
            this.tabPage2.Controls.Add(this.ledIn27);
            this.tabPage2.Controls.Add(this.ledIn26);
            this.tabPage2.Controls.Add(this.ledIn25);
            this.tabPage2.Controls.Add(this.ledIn24);
            this.tabPage2.Controls.Add(this.ledIn23);
            this.tabPage2.Controls.Add(this.ledDoor5);
            this.tabPage2.Controls.Add(this.ledDoor4);
            this.tabPage2.Controls.Add(this.ledDoor3);
            this.tabPage2.Controls.Add(this.ledDoor2);
            this.tabPage2.Controls.Add(this.ledDoor1);
            this.tabPage2.Controls.Add(this.ledIn17);
            this.tabPage2.Controls.Add(this.ledIn16);
            this.tabPage2.Controls.Add(this.ledIn15);
            this.tabPage2.Controls.Add(this.ledIn14);
            this.tabPage2.Controls.Add(this.ledIn13);
            this.tabPage2.Controls.Add(this.ledIn12);
            this.tabPage2.Controls.Add(this.ledIn11);
            this.tabPage2.Controls.Add(this.ledIn10);
            this.tabPage2.Controls.Add(this.ledIn09);
            this.tabPage2.Controls.Add(this.ledIn08);
            this.tabPage2.Controls.Add(this.ledIn07);
            this.tabPage2.Controls.Add(this.ledIn06);
            this.tabPage2.Controls.Add(this.ledIn05);
            this.tabPage2.Controls.Add(this.ledIn04);
            this.tabPage2.Controls.Add(this.ledIn03);
            this.tabPage2.Controls.Add(this.ledIn02);
            this.tabPage2.Controls.Add(this.ledIn01);
            this.tabPage2.Controls.Add(this.ledIn00);
            this.tabPage2.Controls.Add(this.ledArray8);
            this.tabPage2.Controls.Add(this.ledArray7);
            this.tabPage2.Controls.Add(this.ledArray6);
            this.tabPage2.Controls.Add(this.ledArray5);
            this.tabPage2.Controls.Add(this.lblInputPort7);
            this.tabPage2.Controls.Add(this.lblInputPort3);
            this.tabPage2.Controls.Add(this.lblInputPort6);
            this.tabPage2.Controls.Add(this.lblInputPort2);
            this.tabPage2.Controls.Add(this.lblInputPort5);
            this.tabPage2.Controls.Add(this.lblInputPort1);
            this.tabPage2.Controls.Add(this.lblInputPort4);
            this.tabPage2.Controls.Add(this.lblInputPort0);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1194, 838);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "INPUT";
            // 
            // ledIn31
            // 
            this.ledIn31.BackColor = System.Drawing.Color.Transparent;
            this.ledIn31.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn31.ImageList = imageList2;
            this.ledIn31.Location = new System.Drawing.Point(905, 325);
            this.ledIn31.Name = "ledIn31";
            this.ledIn31.OffImageIndex = 1;
            this.ledIn31.ShowAccelChar = false;
            this.ledIn31.Size = new System.Drawing.Size(280, 37);
            this.ledIn31.TabIndex = 1731;
            this.ledIn31.Text = "X31: Area Sensor T2";
            this.ledIn31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn31.Value = false;
            // 
            // ledIn30
            // 
            this.ledIn30.BackColor = System.Drawing.Color.Transparent;
            this.ledIn30.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn30.ImageList = imageList2;
            this.ledIn30.Location = new System.Drawing.Point(905, 285);
            this.ledIn30.Name = "ledIn30";
            this.ledIn30.OffImageIndex = 1;
            this.ledIn30.ShowAccelChar = false;
            this.ledIn30.Size = new System.Drawing.Size(280, 37);
            this.ledIn30.TabIndex = 1730;
            this.ledIn30.Text = "X30: Area Sensor T1";
            this.ledIn30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn30.Value = false;
            // 
            // ledIn29
            // 
            this.ledIn29.BackColor = System.Drawing.Color.Transparent;
            this.ledIn29.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn29.ImageList = imageList2;
            this.ledIn29.Location = new System.Drawing.Point(905, 245);
            this.ledIn29.Name = "ledIn29";
            this.ledIn29.OffImageIndex = 1;
            this.ledIn29.ShowAccelChar = false;
            this.ledIn29.Size = new System.Drawing.Size(280, 37);
            this.ledIn29.TabIndex = 1729;
            this.ledIn29.Text = "ledImageLabel29";
            this.ledIn29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn29.Value = false;
            // 
            // ledIn28
            // 
            this.ledIn28.BackColor = System.Drawing.Color.Transparent;
            this.ledIn28.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn28.ImageList = imageList2;
            this.ledIn28.Location = new System.Drawing.Point(905, 205);
            this.ledIn28.Name = "ledIn28";
            this.ledIn28.OffImageIndex = 1;
            this.ledIn28.ShowAccelChar = false;
            this.ledIn28.Size = new System.Drawing.Size(280, 37);
            this.ledIn28.TabIndex = 1728;
            this.ledIn28.Text = "ledImageLabel28";
            this.ledIn28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn28.Value = false;
            // 
            // ledIn27
            // 
            this.ledIn27.BackColor = System.Drawing.Color.Transparent;
            this.ledIn27.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn27.ImageList = imageList2;
            this.ledIn27.Location = new System.Drawing.Point(905, 165);
            this.ledIn27.Name = "ledIn27";
            this.ledIn27.OffImageIndex = 1;
            this.ledIn27.ShowAccelChar = false;
            this.ledIn27.Size = new System.Drawing.Size(280, 37);
            this.ledIn27.TabIndex = 1727;
            this.ledIn27.Text = "ledImageLabel27";
            this.ledIn27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn27.Value = false;
            // 
            // ledIn26
            // 
            this.ledIn26.BackColor = System.Drawing.Color.Transparent;
            this.ledIn26.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn26.ImageList = imageList2;
            this.ledIn26.Location = new System.Drawing.Point(905, 125);
            this.ledIn26.Name = "ledIn26";
            this.ledIn26.OffImageIndex = 1;
            this.ledIn26.ShowAccelChar = false;
            this.ledIn26.Size = new System.Drawing.Size(280, 37);
            this.ledIn26.TabIndex = 1726;
            this.ledIn26.Text = "ledImageLabel26";
            this.ledIn26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn26.Value = false;
            // 
            // ledIn25
            // 
            this.ledIn25.BackColor = System.Drawing.Color.Transparent;
            this.ledIn25.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn25.ImageList = imageList2;
            this.ledIn25.Location = new System.Drawing.Point(905, 85);
            this.ledIn25.Name = "ledIn25";
            this.ledIn25.OffImageIndex = 1;
            this.ledIn25.ShowAccelChar = false;
            this.ledIn25.Size = new System.Drawing.Size(280, 37);
            this.ledIn25.TabIndex = 1725;
            this.ledIn25.Text = "ledImageLabel25";
            this.ledIn25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn25.Value = false;
            // 
            // ledIn24
            // 
            this.ledIn24.BackColor = System.Drawing.Color.Transparent;
            this.ledIn24.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn24.ImageList = imageList2;
            this.ledIn24.Location = new System.Drawing.Point(905, 45);
            this.ledIn24.Name = "ledIn24";
            this.ledIn24.OffImageIndex = 1;
            this.ledIn24.ShowAccelChar = false;
            this.ledIn24.Size = new System.Drawing.Size(280, 37);
            this.ledIn24.TabIndex = 1724;
            this.ledIn24.Text = "ledImageLabel24";
            this.ledIn24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn24.Value = false;
            // 
            // ledIn23
            // 
            this.ledIn23.BackColor = System.Drawing.Color.Transparent;
            this.ledIn23.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn23.ImageList = imageList2;
            this.ledIn23.Location = new System.Drawing.Point(607, 325);
            this.ledIn23.Name = "ledIn23";
            this.ledIn23.OffImageIndex = 2;
            this.ledIn23.ShowAccelChar = false;
            this.ledIn23.Size = new System.Drawing.Size(284, 37);
            this.ledIn23.TabIndex = 1723;
            this.ledIn23.Text = "X23:";
            this.ledIn23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn23.Value = false;
            // 
            // ledDoor5
            // 
            this.ledDoor5.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor5.ImageList = imageList2;
            this.ledDoor5.Location = new System.Drawing.Point(607, 285);
            this.ledDoor5.Name = "ledDoor5";
            this.ledDoor5.OffImageIndex = 1;
            this.ledDoor5.ShowAccelChar = false;
            this.ledDoor5.Size = new System.Drawing.Size(284, 37);
            this.ledDoor5.TabIndex = 1722;
            this.ledDoor5.Text = "X22: Door Sensor #5";
            this.ledDoor5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledDoor4
            // 
            this.ledDoor4.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor4.ImageList = imageList2;
            this.ledDoor4.Location = new System.Drawing.Point(607, 245);
            this.ledDoor4.Name = "ledDoor4";
            this.ledDoor4.OffImageIndex = 1;
            this.ledDoor4.ShowAccelChar = false;
            this.ledDoor4.Size = new System.Drawing.Size(284, 37);
            this.ledDoor4.TabIndex = 1721;
            this.ledDoor4.Text = "X21: Door Sensor #4";
            this.ledDoor4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledDoor3
            // 
            this.ledDoor3.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor3.ImageList = imageList2;
            this.ledDoor3.Location = new System.Drawing.Point(607, 205);
            this.ledDoor3.Name = "ledDoor3";
            this.ledDoor3.OffImageIndex = 1;
            this.ledDoor3.ShowAccelChar = false;
            this.ledDoor3.Size = new System.Drawing.Size(284, 37);
            this.ledDoor3.TabIndex = 1720;
            this.ledDoor3.Text = "X20: Door Sensor #3";
            this.ledDoor3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledDoor2
            // 
            this.ledDoor2.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor2.ImageList = imageList2;
            this.ledDoor2.Location = new System.Drawing.Point(607, 165);
            this.ledDoor2.Name = "ledDoor2";
            this.ledDoor2.OffImageIndex = 1;
            this.ledDoor2.ShowAccelChar = false;
            this.ledDoor2.Size = new System.Drawing.Size(284, 37);
            this.ledDoor2.TabIndex = 1719;
            this.ledDoor2.Text = "X19: Door Sensor #2";
            this.ledDoor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledDoor1
            // 
            this.ledDoor1.BackColor = System.Drawing.Color.Transparent;
            this.ledDoor1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledDoor1.ImageList = imageList2;
            this.ledDoor1.Location = new System.Drawing.Point(607, 125);
            this.ledDoor1.Name = "ledDoor1";
            this.ledDoor1.OffImageIndex = 1;
            this.ledDoor1.ShowAccelChar = false;
            this.ledDoor1.Size = new System.Drawing.Size(284, 37);
            this.ledDoor1.TabIndex = 1718;
            this.ledDoor1.Text = "X18: Door Sensor #1";
            this.ledDoor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledIn17
            // 
            this.ledIn17.BackColor = System.Drawing.Color.Transparent;
            this.ledIn17.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn17.ImageList = imageList2;
            this.ledIn17.Location = new System.Drawing.Point(607, 85);
            this.ledIn17.Name = "ledIn17";
            this.ledIn17.OffImageIndex = 1;
            this.ledIn17.ShowAccelChar = false;
            this.ledIn17.Size = new System.Drawing.Size(284, 37);
            this.ledIn17.TabIndex = 1717;
            this.ledIn17.Text = "X17: Leak Sensor";
            this.ledIn17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn17.Value = false;
            // 
            // ledIn16
            // 
            this.ledIn16.BackColor = System.Drawing.Color.Transparent;
            this.ledIn16.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn16.ImageList = imageList2;
            this.ledIn16.Location = new System.Drawing.Point(607, 45);
            this.ledIn16.Name = "ledIn16";
            this.ledIn16.OffImageIndex = 1;
            this.ledIn16.ShowAccelChar = false;
            this.ledIn16.Size = new System.Drawing.Size(284, 37);
            this.ledIn16.TabIndex = 1716;
            this.ledIn16.Text = "X16: Stage Power";
            this.ledIn16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn16.Value = false;
            // 
            // ledIn15
            // 
            this.ledIn15.BackColor = System.Drawing.Color.Transparent;
            this.ledIn15.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn15.ImageList = imageList2;
            this.ledIn15.Location = new System.Drawing.Point(309, 325);
            this.ledIn15.Name = "ledIn15";
            this.ledIn15.OffImageIndex = 1;
            this.ledIn15.ShowAccelChar = false;
            this.ledIn15.Size = new System.Drawing.Size(284, 37);
            this.ledIn15.TabIndex = 1715;
            this.ledIn15.Text = "ledImageLabel15";
            this.ledIn15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn15.Value = false;
            // 
            // ledIn14
            // 
            this.ledIn14.BackColor = System.Drawing.Color.Transparent;
            this.ledIn14.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn14.ImageList = imageList2;
            this.ledIn14.Location = new System.Drawing.Point(309, 285);
            this.ledIn14.Name = "ledIn14";
            this.ledIn14.OffImageIndex = 1;
            this.ledIn14.ShowAccelChar = false;
            this.ledIn14.Size = new System.Drawing.Size(284, 37);
            this.ledIn14.TabIndex = 1714;
            this.ledIn14.Text = "ledImageLabel14";
            this.ledIn14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn14.Value = false;
            // 
            // ledIn13
            // 
            this.ledIn13.BackColor = System.Drawing.Color.Transparent;
            this.ledIn13.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn13.ImageList = imageList2;
            this.ledIn13.Location = new System.Drawing.Point(309, 245);
            this.ledIn13.Name = "ledIn13";
            this.ledIn13.OffImageIndex = 1;
            this.ledIn13.ShowAccelChar = false;
            this.ledIn13.Size = new System.Drawing.Size(284, 37);
            this.ledIn13.TabIndex = 1713;
            this.ledIn13.Text = "X13: T2 Reset Switch";
            this.ledIn13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn13.Value = false;
            // 
            // ledIn12
            // 
            this.ledIn12.BackColor = System.Drawing.Color.Transparent;
            this.ledIn12.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn12.ImageList = imageList2;
            this.ledIn12.Location = new System.Drawing.Point(309, 205);
            this.ledIn12.Name = "ledIn12";
            this.ledIn12.OffImageIndex = 1;
            this.ledIn12.ShowAccelChar = false;
            this.ledIn12.Size = new System.Drawing.Size(284, 37);
            this.ledIn12.TabIndex = 1712;
            this.ledIn12.Text = "ledImageLabel12";
            this.ledIn12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn12.Value = false;
            // 
            // ledIn11
            // 
            this.ledIn11.BackColor = System.Drawing.Color.Transparent;
            this.ledIn11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn11.ImageList = imageList2;
            this.ledIn11.Location = new System.Drawing.Point(309, 165);
            this.ledIn11.Name = "ledIn11";
            this.ledIn11.OffImageIndex = 1;
            this.ledIn11.ShowAccelChar = false;
            this.ledIn11.Size = new System.Drawing.Size(284, 37);
            this.ledIn11.TabIndex = 1711;
            this.ledIn11.Text = "ledImageLabel11";
            this.ledIn11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn11.Value = false;
            // 
            // ledIn10
            // 
            this.ledIn10.BackColor = System.Drawing.Color.Transparent;
            this.ledIn10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn10.ImageList = imageList2;
            this.ledIn10.Location = new System.Drawing.Point(309, 125);
            this.ledIn10.Name = "ledIn10";
            this.ledIn10.OffImageIndex = 1;
            this.ledIn10.ShowAccelChar = false;
            this.ledIn10.Size = new System.Drawing.Size(284, 37);
            this.ledIn10.TabIndex = 1710;
            this.ledIn10.Text = "ledImageLabel10";
            this.ledIn10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn10.Value = false;
            // 
            // ledIn09
            // 
            this.ledIn09.BackColor = System.Drawing.Color.Transparent;
            this.ledIn09.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn09.ImageList = imageList2;
            this.ledIn09.Location = new System.Drawing.Point(309, 85);
            this.ledIn09.Name = "ledIn09";
            this.ledIn09.OffImageIndex = 1;
            this.ledIn09.ShowAccelChar = false;
            this.ledIn09.Size = new System.Drawing.Size(284, 37);
            this.ledIn09.TabIndex = 1709;
            this.ledIn09.Text = "ledImageLabel09";
            this.ledIn09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn09.Value = false;
            // 
            // ledIn08
            // 
            this.ledIn08.BackColor = System.Drawing.Color.Transparent;
            this.ledIn08.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn08.ImageList = imageList2;
            this.ledIn08.Location = new System.Drawing.Point(309, 45);
            this.ledIn08.Name = "ledIn08";
            this.ledIn08.OffImageIndex = 1;
            this.ledIn08.ShowAccelChar = false;
            this.ledIn08.Size = new System.Drawing.Size(284, 37);
            this.ledIn08.TabIndex = 1708;
            this.ledIn08.Text = "ledImageLabel08";
            this.ledIn08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn08.Value = false;
            // 
            // ledIn07
            // 
            this.ledIn07.BackColor = System.Drawing.Color.Transparent;
            this.ledIn07.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn07.ImageList = imageList2;
            this.ledIn07.Location = new System.Drawing.Point(11, 325);
            this.ledIn07.Name = "ledIn07";
            this.ledIn07.OffImageIndex = 1;
            this.ledIn07.ShowAccelChar = false;
            this.ledIn07.Size = new System.Drawing.Size(284, 37);
            this.ledIn07.TabIndex = 1707;
            this.ledIn07.Text = "X07: T1 Reset Switch";
            this.ledIn07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn07.Value = false;
            // 
            // ledIn06
            // 
            this.ledIn06.BackColor = System.Drawing.Color.Transparent;
            this.ledIn06.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn06.ImageList = imageList2;
            this.ledIn06.Location = new System.Drawing.Point(11, 285);
            this.ledIn06.Name = "ledIn06";
            this.ledIn06.OffImageIndex = 1;
            this.ledIn06.ShowAccelChar = false;
            this.ledIn06.Size = new System.Drawing.Size(284, 37);
            this.ledIn06.TabIndex = 1706;
            this.ledIn06.Text = "ledImageLabel6";
            this.ledIn06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn06.Value = false;
            // 
            // ledIn05
            // 
            this.ledIn05.BackColor = System.Drawing.Color.Transparent;
            this.ledIn05.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn05.ImageList = imageList2;
            this.ledIn05.Location = new System.Drawing.Point(11, 245);
            this.ledIn05.Name = "ledIn05";
            this.ledIn05.OffImageIndex = 1;
            this.ledIn05.ShowAccelChar = false;
            this.ledIn05.Size = new System.Drawing.Size(284, 37);
            this.ledIn05.TabIndex = 1705;
            this.ledIn05.Text = "ledImageLabel5";
            this.ledIn05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn05.Value = false;
            // 
            // ledIn04
            // 
            this.ledIn04.BackColor = System.Drawing.Color.Transparent;
            this.ledIn04.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn04.ImageList = imageList2;
            this.ledIn04.Location = new System.Drawing.Point(11, 205);
            this.ledIn04.Name = "ledIn04";
            this.ledIn04.OffImageIndex = 1;
            this.ledIn04.ShowAccelChar = false;
            this.ledIn04.Size = new System.Drawing.Size(284, 37);
            this.ledIn04.TabIndex = 1704;
            this.ledIn04.Text = "ledImageLabel4";
            this.ledIn04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn04.Value = false;
            // 
            // ledIn03
            // 
            this.ledIn03.BackColor = System.Drawing.Color.Transparent;
            this.ledIn03.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn03.ImageList = imageList2;
            this.ledIn03.Location = new System.Drawing.Point(11, 165);
            this.ledIn03.Name = "ledIn03";
            this.ledIn03.OffImageIndex = 1;
            this.ledIn03.ShowAccelChar = false;
            this.ledIn03.Size = new System.Drawing.Size(284, 37);
            this.ledIn03.TabIndex = 1703;
            this.ledIn03.Text = "X03: EMO #3";
            this.ledIn03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn03.Value = false;
            // 
            // ledIn02
            // 
            this.ledIn02.BackColor = System.Drawing.Color.Transparent;
            this.ledIn02.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn02.ImageList = imageList2;
            this.ledIn02.Location = new System.Drawing.Point(11, 125);
            this.ledIn02.Name = "ledIn02";
            this.ledIn02.OffImageIndex = 1;
            this.ledIn02.ShowAccelChar = false;
            this.ledIn02.Size = new System.Drawing.Size(284, 37);
            this.ledIn02.TabIndex = 1702;
            this.ledIn02.Text = "X02: EMO #2";
            this.ledIn02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn02.Value = false;
            // 
            // ledIn01
            // 
            this.ledIn01.BackColor = System.Drawing.Color.Transparent;
            this.ledIn01.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn01.ImageList = imageList2;
            this.ledIn01.Location = new System.Drawing.Point(11, 85);
            this.ledIn01.Name = "ledIn01";
            this.ledIn01.OffImageIndex = 1;
            this.ledIn01.ShowAccelChar = false;
            this.ledIn01.Size = new System.Drawing.Size(284, 37);
            this.ledIn01.TabIndex = 1701;
            this.ledIn01.Text = "X01: EMO #1";
            this.ledIn01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn01.Value = false;
            // 
            // ledIn00
            // 
            this.ledIn00.BackColor = System.Drawing.Color.Transparent;
            this.ledIn00.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledIn00.ImageList = imageList2;
            this.ledIn00.Location = new System.Drawing.Point(11, 45);
            this.ledIn00.Name = "ledIn00";
            this.ledIn00.OffImageIndex = 1;
            this.ledIn00.ShowAccelChar = false;
            this.ledIn00.Size = new System.Drawing.Size(284, 37);
            this.ledIn00.TabIndex = 1700;
            this.ledIn00.Text = "X00: Main Power";
            this.ledIn00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledIn00.Value = false;
            // 
            // ledArray8
            // 
            this.ledArray8.DataServer = this.dsIO;
            this.ledArray8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray8.ImageList = imageList2;
            this.ledArray8.LEDCount = 8;
            this.ledArray8.Location = new System.Drawing.Point(905, 474);
            this.ledArray8.Name = "ledArray8";
            this.ledArray8.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray8.OnImageIndices = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray8.Size = new System.Drawing.Size(280, 320);
            this.ledArray8.TabIndex = 1387;
            this.ledArray8.Text = "ledImageArray3";
            this.ledArray8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray8.Value = false;
            // 
            // ledArray7
            // 
            this.ledArray7.DataServer = this.dsIO;
            this.ledArray7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray7.ImageList = imageList2;
            this.ledArray7.LEDCount = 8;
            this.ledArray7.Location = new System.Drawing.Point(607, 472);
            this.ledArray7.Name = "ledArray7";
            this.ledArray7.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray7.OnImageIndices = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray7.Size = new System.Drawing.Size(280, 320);
            this.ledArray7.TabIndex = 1386;
            this.ledArray7.Text = "ledImageArray3";
            this.ledArray7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray7.Value = false;
            // 
            // ledArray6
            // 
            this.ledArray6.DataServer = this.dsIO;
            this.ledArray6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray6.ImageList = imageList2;
            this.ledArray6.LEDCount = 8;
            this.ledArray6.Location = new System.Drawing.Point(309, 472);
            this.ledArray6.Name = "ledArray6";
            this.ledArray6.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray6.OnImageIndices = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray6.Size = new System.Drawing.Size(280, 320);
            this.ledArray6.TabIndex = 1385;
            this.ledArray6.Text = "ledImageArray3";
            this.ledArray6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray6.Value = false;
            // 
            // ledArray5
            // 
            this.ledArray5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ledArray5.DataServer = this.dsIO;
            this.ledArray5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ledArray5.ImageList = imageList2;
            this.ledArray5.LEDCount = 8;
            this.ledArray5.Location = new System.Drawing.Point(11, 474);
            this.ledArray5.Name = "ledArray5";
            this.ledArray5.OffImageIndices = new int[] {
        2,
        2,
        2,
        2,
        2,
        2,
        2,
        2};
            this.ledArray5.OnImageIndices = new int[] {
        2,
        2,
        0,
        0,
        0,
        0,
        0,
        0};
            this.ledArray5.Size = new System.Drawing.Size(280, 320);
            this.ledArray5.TabIndex = 1384;
            this.ledArray5.Text = "ledImageArray3";
            this.ledArray5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ledArray5.Value = false;
            // 
            // lblInputPort7
            // 
            this.lblInputPort7.BackColor = System.Drawing.Color.White;
            this.lblInputPort7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort7.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort7.Frame.CornerRound = 1;
            this.lblInputPort7.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort7.Location = new System.Drawing.Point(901, 436);
            this.lblInputPort7.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort7.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort7.Name = "lblInputPort7";
            this.lblInputPort7.ShowAccelChar = false;
            this.lblInputPort7.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort7.TabIndex = 1378;
            this.lblInputPort7.Text = "Port 7";
            this.lblInputPort7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort3
            // 
            this.lblInputPort3.BackColor = System.Drawing.Color.White;
            this.lblInputPort3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort3.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort3.Frame.CornerRound = 1;
            this.lblInputPort3.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort3.Location = new System.Drawing.Point(901, 6);
            this.lblInputPort3.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort3.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort3.Name = "lblInputPort3";
            this.lblInputPort3.ShowAccelChar = false;
            this.lblInputPort3.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort3.TabIndex = 1379;
            this.lblInputPort3.Text = "Port 3";
            this.lblInputPort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort6
            // 
            this.lblInputPort6.BackColor = System.Drawing.Color.White;
            this.lblInputPort6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort6.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort6.Frame.CornerRound = 1;
            this.lblInputPort6.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort6.Location = new System.Drawing.Point(603, 436);
            this.lblInputPort6.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort6.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort6.Name = "lblInputPort6";
            this.lblInputPort6.ShowAccelChar = false;
            this.lblInputPort6.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort6.TabIndex = 1376;
            this.lblInputPort6.Text = "Port 6";
            this.lblInputPort6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort2
            // 
            this.lblInputPort2.BackColor = System.Drawing.Color.White;
            this.lblInputPort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort2.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort2.Frame.CornerRound = 1;
            this.lblInputPort2.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort2.Location = new System.Drawing.Point(603, 6);
            this.lblInputPort2.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort2.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort2.Name = "lblInputPort2";
            this.lblInputPort2.ShowAccelChar = false;
            this.lblInputPort2.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort2.TabIndex = 1377;
            this.lblInputPort2.Text = "Port 2";
            this.lblInputPort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort5
            // 
            this.lblInputPort5.BackColor = System.Drawing.Color.White;
            this.lblInputPort5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort5.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort5.Frame.CornerRound = 1;
            this.lblInputPort5.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort5.Location = new System.Drawing.Point(305, 436);
            this.lblInputPort5.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort5.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort5.Name = "lblInputPort5";
            this.lblInputPort5.ShowAccelChar = false;
            this.lblInputPort5.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort5.TabIndex = 1374;
            this.lblInputPort5.Text = "Port 5";
            this.lblInputPort5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort1
            // 
            this.lblInputPort1.BackColor = System.Drawing.Color.White;
            this.lblInputPort1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort1.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort1.Frame.CornerRound = 1;
            this.lblInputPort1.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort1.Location = new System.Drawing.Point(305, 6);
            this.lblInputPort1.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort1.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort1.Name = "lblInputPort1";
            this.lblInputPort1.ShowAccelChar = false;
            this.lblInputPort1.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort1.TabIndex = 1375;
            this.lblInputPort1.Text = "Port 1";
            this.lblInputPort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort4
            // 
            this.lblInputPort4.BackColor = System.Drawing.Color.White;
            this.lblInputPort4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort4.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort4.Frame.CornerRound = 1;
            this.lblInputPort4.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort4.Location = new System.Drawing.Point(7, 436);
            this.lblInputPort4.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort4.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort4.Name = "lblInputPort4";
            this.lblInputPort4.ShowAccelChar = false;
            this.lblInputPort4.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort4.TabIndex = 1372;
            this.lblInputPort4.Text = "Port 4";
            this.lblInputPort4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputPort0
            // 
            this.lblInputPort0.BackColor = System.Drawing.Color.White;
            this.lblInputPort0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblInputPort0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInputPort0.ForeColor = System.Drawing.Color.Black;
            this.lblInputPort0.Frame.CornerRound = 1;
            this.lblInputPort0.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblInputPort0.Location = new System.Drawing.Point(7, 6);
            this.lblInputPort0.Margin = new System.Windows.Forms.Padding(4);
            this.lblInputPort0.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblInputPort0.Name = "lblInputPort0";
            this.lblInputPort0.ShowAccelChar = false;
            this.lblInputPort0.Size = new System.Drawing.Size(287, 29);
            this.lblInputPort0.TabIndex = 1373;
            this.lblInputPort0.Text = "Port 0";
            this.lblInputPort0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.switchOut63);
            this.tabPage3.Controls.Add(this.switchOut62);
            this.tabPage3.Controls.Add(this.switchOut61);
            this.tabPage3.Controls.Add(this.switchOut60);
            this.tabPage3.Controls.Add(this.switchOut59);
            this.tabPage3.Controls.Add(this.switchOut58);
            this.tabPage3.Controls.Add(this.switchOut57);
            this.tabPage3.Controls.Add(this.switchOut56);
            this.tabPage3.Controls.Add(this.switchOut55);
            this.tabPage3.Controls.Add(this.switchOut54);
            this.tabPage3.Controls.Add(this.switchOut53);
            this.tabPage3.Controls.Add(this.switchOut52);
            this.tabPage3.Controls.Add(this.switchOut51);
            this.tabPage3.Controls.Add(this.switchOut50);
            this.tabPage3.Controls.Add(this.switchOut49);
            this.tabPage3.Controls.Add(this.switchOut48);
            this.tabPage3.Controls.Add(this.switchOut47);
            this.tabPage3.Controls.Add(this.switchOut46);
            this.tabPage3.Controls.Add(this.switchOut45);
            this.tabPage3.Controls.Add(this.switchOut44);
            this.tabPage3.Controls.Add(this.switchOut43);
            this.tabPage3.Controls.Add(this.switchOut42);
            this.tabPage3.Controls.Add(this.switchOut41);
            this.tabPage3.Controls.Add(this.switchOut40);
            this.tabPage3.Controls.Add(this.switchOut39);
            this.tabPage3.Controls.Add(this.switchOut38);
            this.tabPage3.Controls.Add(this.switchOut37);
            this.tabPage3.Controls.Add(this.switchOut36);
            this.tabPage3.Controls.Add(this.switchOut35);
            this.tabPage3.Controls.Add(this.switchOut34);
            this.tabPage3.Controls.Add(this.switchOut33);
            this.tabPage3.Controls.Add(this.switchOut32);
            this.tabPage3.Controls.Add(this.switchOut31);
            this.tabPage3.Controls.Add(this.switchOut30);
            this.tabPage3.Controls.Add(this.switchOut29);
            this.tabPage3.Controls.Add(this.switchOut28);
            this.tabPage3.Controls.Add(this.switchOut27);
            this.tabPage3.Controls.Add(this.switchOut26);
            this.tabPage3.Controls.Add(this.switchOut25);
            this.tabPage3.Controls.Add(this.switchOut24);
            this.tabPage3.Controls.Add(this.switchOut23);
            this.tabPage3.Controls.Add(this.switchOut22);
            this.tabPage3.Controls.Add(this.switchOut21);
            this.tabPage3.Controls.Add(this.switchOut20);
            this.tabPage3.Controls.Add(this.switchOut19);
            this.tabPage3.Controls.Add(this.switchOut18);
            this.tabPage3.Controls.Add(this.switchOut17);
            this.tabPage3.Controls.Add(this.switchOut16);
            this.tabPage3.Controls.Add(this.switchOut15);
            this.tabPage3.Controls.Add(this.switchOut14);
            this.tabPage3.Controls.Add(this.switchOut13);
            this.tabPage3.Controls.Add(this.switchOut12);
            this.tabPage3.Controls.Add(this.switchOut11);
            this.tabPage3.Controls.Add(this.switchOut10);
            this.tabPage3.Controls.Add(this.switchOut9);
            this.tabPage3.Controls.Add(this.switchOut8);
            this.tabPage3.Controls.Add(this.switchOut7);
            this.tabPage3.Controls.Add(this.switchOut6);
            this.tabPage3.Controls.Add(this.switchOut5);
            this.tabPage3.Controls.Add(this.switchOut4);
            this.tabPage3.Controls.Add(this.switchOut3);
            this.tabPage3.Controls.Add(this.switchOut2);
            this.tabPage3.Controls.Add(this.switchOut1);
            this.tabPage3.Controls.Add(this.switchOut0);
            this.tabPage3.Controls.Add(this.lblOutputPort7);
            this.tabPage3.Controls.Add(this.lblOutputPort3);
            this.tabPage3.Controls.Add(this.lblOutputPort6);
            this.tabPage3.Controls.Add(this.lblOutputPort2);
            this.tabPage3.Controls.Add(this.lblOutputPort5);
            this.tabPage3.Controls.Add(this.lblOutputPort1);
            this.tabPage3.Controls.Add(this.lblOutputPort4);
            this.tabPage3.Controls.Add(this.lblOutputPort0);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1199, 851);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "OUTPUT";
            // 
            // switchOut63
            // 
            this.switchOut63.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut63.Channel = null;
            this.switchOut63.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut63.Hint = null;
            this.switchOut63.Location = new System.Drawing.Point(901, 694);
            this.switchOut63.Name = "switchOut63";
            this.switchOut63.ShowHint = false;
            this.switchOut63.Size = new System.Drawing.Size(282, 38);
            this.switchOut63.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut63.TabIndex = 794;
            this.switchOut63.Text = "uiSwitch5";
            // 
            // switchOut62
            // 
            this.switchOut62.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut62.Channel = null;
            this.switchOut62.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut62.Hint = null;
            this.switchOut62.Location = new System.Drawing.Point(901, 654);
            this.switchOut62.Name = "switchOut62";
            this.switchOut62.ShowHint = false;
            this.switchOut62.Size = new System.Drawing.Size(282, 38);
            this.switchOut62.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut62.TabIndex = 793;
            this.switchOut62.Text = "uiSwitch6";
            // 
            // switchOut61
            // 
            this.switchOut61.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut61.Channel = null;
            this.switchOut61.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut61.Hint = null;
            this.switchOut61.Location = new System.Drawing.Point(901, 614);
            this.switchOut61.Name = "switchOut61";
            this.switchOut61.ShowHint = false;
            this.switchOut61.Size = new System.Drawing.Size(282, 38);
            this.switchOut61.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut61.TabIndex = 792;
            this.switchOut61.Text = "uiSwitch7";
            // 
            // switchOut60
            // 
            this.switchOut60.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut60.Channel = null;
            this.switchOut60.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut60.Hint = null;
            this.switchOut60.Location = new System.Drawing.Point(901, 574);
            this.switchOut60.Name = "switchOut60";
            this.switchOut60.ShowHint = false;
            this.switchOut60.Size = new System.Drawing.Size(282, 38);
            this.switchOut60.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut60.TabIndex = 791;
            this.switchOut60.Text = "uiSwitch8";
            // 
            // switchOut59
            // 
            this.switchOut59.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut59.Channel = null;
            this.switchOut59.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut59.Hint = null;
            this.switchOut59.Location = new System.Drawing.Point(901, 534);
            this.switchOut59.Name = "switchOut59";
            this.switchOut59.ShowHint = false;
            this.switchOut59.Size = new System.Drawing.Size(282, 38);
            this.switchOut59.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut59.TabIndex = 790;
            this.switchOut59.Text = "uiSwitch3";
            // 
            // switchOut58
            // 
            this.switchOut58.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut58.Channel = null;
            this.switchOut58.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut58.Hint = null;
            this.switchOut58.Location = new System.Drawing.Point(901, 494);
            this.switchOut58.Name = "switchOut58";
            this.switchOut58.ShowHint = false;
            this.switchOut58.Size = new System.Drawing.Size(282, 38);
            this.switchOut58.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut58.TabIndex = 789;
            this.switchOut58.Text = "uiSwitch4";
            // 
            // switchOut57
            // 
            this.switchOut57.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut57.Channel = null;
            this.switchOut57.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut57.Hint = null;
            this.switchOut57.Location = new System.Drawing.Point(901, 454);
            this.switchOut57.Name = "switchOut57";
            this.switchOut57.ShowHint = false;
            this.switchOut57.Size = new System.Drawing.Size(282, 38);
            this.switchOut57.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut57.TabIndex = 788;
            this.switchOut57.Text = "uiSwitch2";
            // 
            // switchOut56
            // 
            this.switchOut56.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut56.Channel = null;
            this.switchOut56.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut56.Hint = null;
            this.switchOut56.Location = new System.Drawing.Point(901, 415);
            this.switchOut56.Name = "switchOut56";
            this.switchOut56.ShowHint = false;
            this.switchOut56.Size = new System.Drawing.Size(282, 38);
            this.switchOut56.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut56.TabIndex = 787;
            this.switchOut56.Text = "uiSwitch1";
            // 
            // switchOut55
            // 
            this.switchOut55.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut55.Channel = null;
            this.switchOut55.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut55.Hint = null;
            this.switchOut55.Location = new System.Drawing.Point(603, 694);
            this.switchOut55.Name = "switchOut55";
            this.switchOut55.ShowHint = false;
            this.switchOut55.Size = new System.Drawing.Size(282, 38);
            this.switchOut55.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut55.TabIndex = 778;
            this.switchOut55.Text = "uiSwitch5";
            // 
            // switchOut54
            // 
            this.switchOut54.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut54.Channel = null;
            this.switchOut54.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut54.Hint = null;
            this.switchOut54.Location = new System.Drawing.Point(603, 654);
            this.switchOut54.Name = "switchOut54";
            this.switchOut54.ShowHint = false;
            this.switchOut54.Size = new System.Drawing.Size(282, 38);
            this.switchOut54.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut54.TabIndex = 777;
            this.switchOut54.Text = "uiSwitch6";
            // 
            // switchOut53
            // 
            this.switchOut53.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut53.Channel = null;
            this.switchOut53.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut53.Hint = null;
            this.switchOut53.Location = new System.Drawing.Point(603, 614);
            this.switchOut53.Name = "switchOut53";
            this.switchOut53.ShowHint = false;
            this.switchOut53.Size = new System.Drawing.Size(282, 38);
            this.switchOut53.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut53.TabIndex = 776;
            this.switchOut53.Text = "uiSwitch7";
            // 
            // switchOut52
            // 
            this.switchOut52.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut52.Channel = null;
            this.switchOut52.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut52.Hint = null;
            this.switchOut52.Location = new System.Drawing.Point(603, 574);
            this.switchOut52.Name = "switchOut52";
            this.switchOut52.ShowHint = false;
            this.switchOut52.Size = new System.Drawing.Size(282, 38);
            this.switchOut52.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut52.TabIndex = 775;
            this.switchOut52.Text = "uiSwitch8";
            // 
            // switchOut51
            // 
            this.switchOut51.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut51.Channel = null;
            this.switchOut51.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut51.Hint = null;
            this.switchOut51.Location = new System.Drawing.Point(603, 534);
            this.switchOut51.Name = "switchOut51";
            this.switchOut51.ShowHint = false;
            this.switchOut51.Size = new System.Drawing.Size(282, 38);
            this.switchOut51.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut51.TabIndex = 774;
            this.switchOut51.Text = "uiSwitch3";
            // 
            // switchOut50
            // 
            this.switchOut50.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut50.Channel = null;
            this.switchOut50.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut50.Hint = null;
            this.switchOut50.Location = new System.Drawing.Point(603, 494);
            this.switchOut50.Name = "switchOut50";
            this.switchOut50.ShowHint = false;
            this.switchOut50.Size = new System.Drawing.Size(282, 38);
            this.switchOut50.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut50.TabIndex = 773;
            this.switchOut50.Text = "uiSwitch4";
            // 
            // switchOut49
            // 
            this.switchOut49.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut49.Channel = null;
            this.switchOut49.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut49.Hint = null;
            this.switchOut49.Location = new System.Drawing.Point(603, 454);
            this.switchOut49.Name = "switchOut49";
            this.switchOut49.ShowHint = false;
            this.switchOut49.Size = new System.Drawing.Size(282, 38);
            this.switchOut49.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut49.TabIndex = 772;
            this.switchOut49.Text = "uiSwitch2";
            // 
            // switchOut48
            // 
            this.switchOut48.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut48.Channel = null;
            this.switchOut48.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut48.Hint = null;
            this.switchOut48.Location = new System.Drawing.Point(603, 415);
            this.switchOut48.Name = "switchOut48";
            this.switchOut48.ShowHint = false;
            this.switchOut48.Size = new System.Drawing.Size(282, 38);
            this.switchOut48.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut48.TabIndex = 771;
            this.switchOut48.Text = "uiSwitch1";
            // 
            // switchOut47
            // 
            this.switchOut47.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut47.Channel = null;
            this.switchOut47.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut47.Hint = null;
            this.switchOut47.Location = new System.Drawing.Point(305, 694);
            this.switchOut47.Name = "switchOut47";
            this.switchOut47.ShowHint = false;
            this.switchOut47.Size = new System.Drawing.Size(282, 38);
            this.switchOut47.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut47.TabIndex = 786;
            this.switchOut47.Text = "uiSwitch5";
            // 
            // switchOut46
            // 
            this.switchOut46.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut46.Channel = null;
            this.switchOut46.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut46.Hint = null;
            this.switchOut46.Location = new System.Drawing.Point(305, 654);
            this.switchOut46.Name = "switchOut46";
            this.switchOut46.ShowHint = false;
            this.switchOut46.Size = new System.Drawing.Size(282, 38);
            this.switchOut46.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut46.TabIndex = 785;
            this.switchOut46.Text = "uiSwitch6";
            // 
            // switchOut45
            // 
            this.switchOut45.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut45.Channel = null;
            this.switchOut45.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut45.Hint = null;
            this.switchOut45.Location = new System.Drawing.Point(305, 614);
            this.switchOut45.Name = "switchOut45";
            this.switchOut45.ShowHint = false;
            this.switchOut45.Size = new System.Drawing.Size(282, 38);
            this.switchOut45.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut45.TabIndex = 784;
            this.switchOut45.Text = "uiSwitch7";
            // 
            // switchOut44
            // 
            this.switchOut44.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut44.Channel = null;
            this.switchOut44.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut44.Hint = null;
            this.switchOut44.Location = new System.Drawing.Point(305, 574);
            this.switchOut44.Name = "switchOut44";
            this.switchOut44.ShowHint = false;
            this.switchOut44.Size = new System.Drawing.Size(282, 38);
            this.switchOut44.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut44.TabIndex = 783;
            this.switchOut44.Text = "uiSwitch8";
            // 
            // switchOut43
            // 
            this.switchOut43.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut43.Channel = null;
            this.switchOut43.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut43.Hint = null;
            this.switchOut43.Location = new System.Drawing.Point(305, 534);
            this.switchOut43.Name = "switchOut43";
            this.switchOut43.ShowHint = false;
            this.switchOut43.Size = new System.Drawing.Size(282, 38);
            this.switchOut43.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut43.TabIndex = 782;
            this.switchOut43.Text = "uiSwitch3";
            // 
            // switchOut42
            // 
            this.switchOut42.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut42.Channel = null;
            this.switchOut42.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut42.Hint = null;
            this.switchOut42.Location = new System.Drawing.Point(305, 494);
            this.switchOut42.Name = "switchOut42";
            this.switchOut42.ShowHint = false;
            this.switchOut42.Size = new System.Drawing.Size(282, 38);
            this.switchOut42.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut42.TabIndex = 781;
            this.switchOut42.Text = "uiSwitch4";
            // 
            // switchOut41
            // 
            this.switchOut41.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut41.Channel = null;
            this.switchOut41.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut41.Hint = null;
            this.switchOut41.Location = new System.Drawing.Point(305, 454);
            this.switchOut41.Name = "switchOut41";
            this.switchOut41.ShowHint = false;
            this.switchOut41.Size = new System.Drawing.Size(282, 38);
            this.switchOut41.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut41.TabIndex = 780;
            this.switchOut41.Text = "uiSwitch2";
            // 
            // switchOut40
            // 
            this.switchOut40.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut40.Channel = null;
            this.switchOut40.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut40.Hint = null;
            this.switchOut40.Location = new System.Drawing.Point(305, 414);
            this.switchOut40.Name = "switchOut40";
            this.switchOut40.ShowHint = false;
            this.switchOut40.Size = new System.Drawing.Size(282, 38);
            this.switchOut40.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut40.TabIndex = 779;
            this.switchOut40.Text = "uiSwitch1";
            // 
            // switchOut39
            // 
            this.switchOut39.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut39.Channel = null;
            this.switchOut39.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut39.Hint = null;
            this.switchOut39.Location = new System.Drawing.Point(7, 694);
            this.switchOut39.Name = "switchOut39";
            this.switchOut39.ShowHint = false;
            this.switchOut39.Size = new System.Drawing.Size(282, 38);
            this.switchOut39.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut39.TabIndex = 770;
            this.switchOut39.Text = "uiSwitch5";
            // 
            // switchOut38
            // 
            this.switchOut38.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut38.Channel = null;
            this.switchOut38.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut38.Hint = null;
            this.switchOut38.Location = new System.Drawing.Point(7, 654);
            this.switchOut38.Name = "switchOut38";
            this.switchOut38.ShowHint = false;
            this.switchOut38.Size = new System.Drawing.Size(282, 38);
            this.switchOut38.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut38.TabIndex = 769;
            this.switchOut38.Text = "uiSwitch6";
            // 
            // switchOut37
            // 
            this.switchOut37.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut37.Channel = null;
            this.switchOut37.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut37.Hint = null;
            this.switchOut37.Location = new System.Drawing.Point(7, 614);
            this.switchOut37.Name = "switchOut37";
            this.switchOut37.ShowHint = false;
            this.switchOut37.Size = new System.Drawing.Size(282, 38);
            this.switchOut37.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut37.TabIndex = 768;
            this.switchOut37.Text = "uiSwitch7";
            // 
            // switchOut36
            // 
            this.switchOut36.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut36.Channel = null;
            this.switchOut36.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut36.Hint = null;
            this.switchOut36.Location = new System.Drawing.Point(7, 574);
            this.switchOut36.Name = "switchOut36";
            this.switchOut36.ShowHint = false;
            this.switchOut36.Size = new System.Drawing.Size(282, 38);
            this.switchOut36.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut36.TabIndex = 767;
            this.switchOut36.Text = "uiSwitch8";
            // 
            // switchOut35
            // 
            this.switchOut35.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut35.Channel = null;
            this.switchOut35.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut35.Hint = null;
            this.switchOut35.Location = new System.Drawing.Point(7, 534);
            this.switchOut35.Name = "switchOut35";
            this.switchOut35.ShowHint = false;
            this.switchOut35.Size = new System.Drawing.Size(282, 38);
            this.switchOut35.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut35.TabIndex = 766;
            this.switchOut35.Text = "uiSwitch3";
            // 
            // switchOut34
            // 
            this.switchOut34.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut34.Channel = null;
            this.switchOut34.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut34.Hint = null;
            this.switchOut34.Location = new System.Drawing.Point(7, 494);
            this.switchOut34.Name = "switchOut34";
            this.switchOut34.ShowHint = false;
            this.switchOut34.Size = new System.Drawing.Size(282, 38);
            this.switchOut34.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut34.TabIndex = 765;
            this.switchOut34.Text = "uiSwitch4";
            // 
            // switchOut33
            // 
            this.switchOut33.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut33.Channel = null;
            this.switchOut33.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut33.Hint = null;
            this.switchOut33.Location = new System.Drawing.Point(7, 454);
            this.switchOut33.Name = "switchOut33";
            this.switchOut33.ShowHint = false;
            this.switchOut33.Size = new System.Drawing.Size(282, 38);
            this.switchOut33.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut33.TabIndex = 764;
            this.switchOut33.Text = "uiSwitch2";
            // 
            // switchOut32
            // 
            this.switchOut32.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut32.Channel = null;
            this.switchOut32.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut32.Hint = null;
            this.switchOut32.Location = new System.Drawing.Point(7, 414);
            this.switchOut32.Name = "switchOut32";
            this.switchOut32.ShowHint = false;
            this.switchOut32.Size = new System.Drawing.Size(282, 38);
            this.switchOut32.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut32.TabIndex = 763;
            this.switchOut32.Text = "uiSwitch1";
            // 
            // switchOut31
            // 
            this.switchOut31.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut31.Channel = null;
            this.switchOut31.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut31.Hint = null;
            this.switchOut31.Location = new System.Drawing.Point(901, 321);
            this.switchOut31.Name = "switchOut31";
            this.switchOut31.ShowHint = false;
            this.switchOut31.Size = new System.Drawing.Size(282, 38);
            this.switchOut31.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut31.TabIndex = 762;
            this.switchOut31.Text = "uiSwitch5";
            // 
            // switchOut30
            // 
            this.switchOut30.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut30.Channel = null;
            this.switchOut30.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut30.Hint = null;
            this.switchOut30.Location = new System.Drawing.Point(901, 281);
            this.switchOut30.Name = "switchOut30";
            this.switchOut30.ShowHint = false;
            this.switchOut30.Size = new System.Drawing.Size(282, 38);
            this.switchOut30.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut30.TabIndex = 761;
            this.switchOut30.Text = "uiSwitch6";
            // 
            // switchOut29
            // 
            this.switchOut29.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut29.Channel = null;
            this.switchOut29.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut29.Hint = null;
            this.switchOut29.Location = new System.Drawing.Point(901, 241);
            this.switchOut29.Name = "switchOut29";
            this.switchOut29.ShowHint = false;
            this.switchOut29.Size = new System.Drawing.Size(282, 38);
            this.switchOut29.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut29.TabIndex = 760;
            this.switchOut29.Text = "uiSwitch7";
            // 
            // switchOut28
            // 
            this.switchOut28.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut28.Channel = null;
            this.switchOut28.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut28.Hint = null;
            this.switchOut28.Location = new System.Drawing.Point(901, 201);
            this.switchOut28.Name = "switchOut28";
            this.switchOut28.ShowHint = false;
            this.switchOut28.Size = new System.Drawing.Size(282, 38);
            this.switchOut28.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut28.TabIndex = 759;
            this.switchOut28.Text = "uiSwitch8";
            // 
            // switchOut27
            // 
            this.switchOut27.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut27.Channel = null;
            this.switchOut27.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut27.Hint = null;
            this.switchOut27.Location = new System.Drawing.Point(901, 161);
            this.switchOut27.Name = "switchOut27";
            this.switchOut27.ShowHint = false;
            this.switchOut27.Size = new System.Drawing.Size(282, 38);
            this.switchOut27.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut27.TabIndex = 758;
            this.switchOut27.Text = "uiSwitch3";
            // 
            // switchOut26
            // 
            this.switchOut26.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut26.Channel = null;
            this.switchOut26.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut26.Hint = null;
            this.switchOut26.Location = new System.Drawing.Point(901, 121);
            this.switchOut26.Name = "switchOut26";
            this.switchOut26.ShowHint = false;
            this.switchOut26.Size = new System.Drawing.Size(282, 38);
            this.switchOut26.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut26.TabIndex = 757;
            this.switchOut26.Text = "uiSwitch4";
            // 
            // switchOut25
            // 
            this.switchOut25.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut25.Channel = null;
            this.switchOut25.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut25.Hint = null;
            this.switchOut25.Location = new System.Drawing.Point(901, 81);
            this.switchOut25.Name = "switchOut25";
            this.switchOut25.ShowHint = false;
            this.switchOut25.Size = new System.Drawing.Size(282, 38);
            this.switchOut25.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut25.TabIndex = 756;
            this.switchOut25.Text = "uiSwitch2";
            // 
            // switchOut24
            // 
            this.switchOut24.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut24.Channel = null;
            this.switchOut24.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut24.Hint = null;
            this.switchOut24.Location = new System.Drawing.Point(901, 41);
            this.switchOut24.Name = "switchOut24";
            this.switchOut24.ShowHint = false;
            this.switchOut24.Size = new System.Drawing.Size(282, 38);
            this.switchOut24.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut24.TabIndex = 755;
            this.switchOut24.Text = "uiSwitch1";
            // 
            // switchOut23
            // 
            this.switchOut23.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut23.Channel = null;
            this.switchOut23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut23.Hint = null;
            this.switchOut23.Location = new System.Drawing.Point(603, 321);
            this.switchOut23.Name = "switchOut23";
            this.switchOut23.ShowHint = false;
            this.switchOut23.Size = new System.Drawing.Size(282, 38);
            this.switchOut23.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut23.TabIndex = 746;
            this.switchOut23.Text = "uiSwitch5";
            // 
            // switchOut22
            // 
            this.switchOut22.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut22.Channel = null;
            this.switchOut22.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut22.Hint = null;
            this.switchOut22.Location = new System.Drawing.Point(603, 281);
            this.switchOut22.Name = "switchOut22";
            this.switchOut22.ShowHint = false;
            this.switchOut22.Size = new System.Drawing.Size(282, 38);
            this.switchOut22.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut22.TabIndex = 745;
            this.switchOut22.Text = "uiSwitch6";
            // 
            // switchOut21
            // 
            this.switchOut21.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut21.Channel = null;
            this.switchOut21.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut21.Hint = null;
            this.switchOut21.Location = new System.Drawing.Point(603, 241);
            this.switchOut21.Name = "switchOut21";
            this.switchOut21.ShowHint = false;
            this.switchOut21.Size = new System.Drawing.Size(282, 38);
            this.switchOut21.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut21.TabIndex = 744;
            this.switchOut21.Text = "uiSwitch7";
            // 
            // switchOut20
            // 
            this.switchOut20.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut20.Channel = null;
            this.switchOut20.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut20.Hint = null;
            this.switchOut20.Location = new System.Drawing.Point(603, 201);
            this.switchOut20.Name = "switchOut20";
            this.switchOut20.ShowHint = false;
            this.switchOut20.Size = new System.Drawing.Size(282, 38);
            this.switchOut20.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut20.TabIndex = 743;
            this.switchOut20.Text = "uiSwitch8";
            // 
            // switchOut19
            // 
            this.switchOut19.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut19.Channel = null;
            this.switchOut19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut19.Hint = null;
            this.switchOut19.Location = new System.Drawing.Point(603, 161);
            this.switchOut19.Name = "switchOut19";
            this.switchOut19.ShowHint = false;
            this.switchOut19.Size = new System.Drawing.Size(282, 38);
            this.switchOut19.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut19.TabIndex = 742;
            this.switchOut19.Text = "uiSwitch3";
            // 
            // switchOut18
            // 
            this.switchOut18.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut18.Channel = null;
            this.switchOut18.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut18.Hint = null;
            this.switchOut18.Location = new System.Drawing.Point(603, 121);
            this.switchOut18.Name = "switchOut18";
            this.switchOut18.ShowHint = false;
            this.switchOut18.Size = new System.Drawing.Size(282, 38);
            this.switchOut18.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut18.TabIndex = 741;
            this.switchOut18.Text = "uiSwitch4";
            // 
            // switchOut17
            // 
            this.switchOut17.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut17.Channel = null;
            this.switchOut17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut17.Hint = null;
            this.switchOut17.Location = new System.Drawing.Point(603, 81);
            this.switchOut17.Name = "switchOut17";
            this.switchOut17.ShowHint = false;
            this.switchOut17.Size = new System.Drawing.Size(282, 38);
            this.switchOut17.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut17.TabIndex = 740;
            this.switchOut17.Text = "uiSwitch2";
            // 
            // switchOut16
            // 
            this.switchOut16.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut16.Channel = null;
            this.switchOut16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut16.Hint = null;
            this.switchOut16.Location = new System.Drawing.Point(603, 41);
            this.switchOut16.Name = "switchOut16";
            this.switchOut16.ShowHint = false;
            this.switchOut16.Size = new System.Drawing.Size(282, 38);
            this.switchOut16.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut16.TabIndex = 739;
            this.switchOut16.Text = "uiSwitch1";
            // 
            // switchOut15
            // 
            this.switchOut15.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut15.Channel = null;
            this.switchOut15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut15.Hint = null;
            this.switchOut15.Location = new System.Drawing.Point(305, 321);
            this.switchOut15.Name = "switchOut15";
            this.switchOut15.ShowHint = false;
            this.switchOut15.Size = new System.Drawing.Size(282, 38);
            this.switchOut15.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut15.TabIndex = 754;
            this.switchOut15.Text = "uiSwitch5";
            // 
            // switchOut14
            // 
            this.switchOut14.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut14.Channel = null;
            this.switchOut14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut14.Hint = null;
            this.switchOut14.Location = new System.Drawing.Point(305, 281);
            this.switchOut14.Name = "switchOut14";
            this.switchOut14.ShowHint = false;
            this.switchOut14.Size = new System.Drawing.Size(282, 38);
            this.switchOut14.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut14.TabIndex = 753;
            this.switchOut14.Text = "uiSwitch6";
            // 
            // switchOut13
            // 
            this.switchOut13.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut13.Channel = null;
            this.switchOut13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut13.Hint = null;
            this.switchOut13.Location = new System.Drawing.Point(305, 241);
            this.switchOut13.Name = "switchOut13";
            this.switchOut13.ShowHint = false;
            this.switchOut13.Size = new System.Drawing.Size(282, 38);
            this.switchOut13.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut13.TabIndex = 752;
            this.switchOut13.Text = "uiSwitch7";
            // 
            // switchOut12
            // 
            this.switchOut12.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut12.Channel = null;
            this.switchOut12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut12.Hint = null;
            this.switchOut12.Location = new System.Drawing.Point(305, 201);
            this.switchOut12.Name = "switchOut12";
            this.switchOut12.ShowHint = false;
            this.switchOut12.Size = new System.Drawing.Size(282, 38);
            this.switchOut12.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut12.TabIndex = 751;
            this.switchOut12.Text = "uiSwitch8";
            // 
            // switchOut11
            // 
            this.switchOut11.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut11.Channel = null;
            this.switchOut11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut11.Hint = null;
            this.switchOut11.Location = new System.Drawing.Point(305, 161);
            this.switchOut11.Name = "switchOut11";
            this.switchOut11.ShowHint = false;
            this.switchOut11.Size = new System.Drawing.Size(282, 38);
            this.switchOut11.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut11.TabIndex = 750;
            this.switchOut11.Text = "uiSwitch3";
            // 
            // switchOut10
            // 
            this.switchOut10.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut10.Channel = null;
            this.switchOut10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut10.Hint = null;
            this.switchOut10.Location = new System.Drawing.Point(305, 121);
            this.switchOut10.Name = "switchOut10";
            this.switchOut10.ShowHint = false;
            this.switchOut10.Size = new System.Drawing.Size(282, 38);
            this.switchOut10.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut10.TabIndex = 749;
            this.switchOut10.Text = "uiSwitch4";
            // 
            // switchOut9
            // 
            this.switchOut9.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut9.Channel = null;
            this.switchOut9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut9.Hint = null;
            this.switchOut9.Location = new System.Drawing.Point(305, 81);
            this.switchOut9.Name = "switchOut9";
            this.switchOut9.ShowHint = false;
            this.switchOut9.Size = new System.Drawing.Size(282, 38);
            this.switchOut9.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut9.TabIndex = 748;
            this.switchOut9.Text = "uiSwitch2";
            // 
            // switchOut8
            // 
            this.switchOut8.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut8.Channel = null;
            this.switchOut8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut8.Hint = null;
            this.switchOut8.Location = new System.Drawing.Point(305, 41);
            this.switchOut8.Name = "switchOut8";
            this.switchOut8.ShowHint = false;
            this.switchOut8.Size = new System.Drawing.Size(282, 38);
            this.switchOut8.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut8.TabIndex = 747;
            this.switchOut8.Text = "uiSwitch1";
            // 
            // switchOut7
            // 
            this.switchOut7.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut7.Channel = null;
            this.switchOut7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut7.Hint = null;
            this.switchOut7.Location = new System.Drawing.Point(6, 321);
            this.switchOut7.Name = "switchOut7";
            this.switchOut7.ShowHint = false;
            this.switchOut7.Size = new System.Drawing.Size(282, 38);
            this.switchOut7.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut7.TabIndex = 738;
            this.switchOut7.Text = "uiSwitch７";
            // 
            // switchOut6
            // 
            this.switchOut6.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut6.Channel = null;
            this.switchOut6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut6.Hint = null;
            this.switchOut6.Location = new System.Drawing.Point(6, 281);
            this.switchOut6.Name = "switchOut6";
            this.switchOut6.ShowHint = false;
            this.switchOut6.Size = new System.Drawing.Size(282, 38);
            this.switchOut6.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut6.TabIndex = 737;
            this.switchOut6.Text = "uiSwitch6";
            // 
            // switchOut5
            // 
            this.switchOut5.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut5.Channel = null;
            this.switchOut5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut5.Hint = null;
            this.switchOut5.Location = new System.Drawing.Point(6, 241);
            this.switchOut5.Name = "switchOut5";
            this.switchOut5.ShowHint = false;
            this.switchOut5.Size = new System.Drawing.Size(282, 38);
            this.switchOut5.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut5.TabIndex = 736;
            this.switchOut5.Text = "uiSwitch５";
            // 
            // switchOut4
            // 
            this.switchOut4.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut4.Channel = null;
            this.switchOut4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut4.Hint = null;
            this.switchOut4.Location = new System.Drawing.Point(6, 201);
            this.switchOut4.Name = "switchOut4";
            this.switchOut4.ShowHint = false;
            this.switchOut4.Size = new System.Drawing.Size(282, 38);
            this.switchOut4.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut4.TabIndex = 735;
            this.switchOut4.Text = "uiSwitch４";
            // 
            // switchOut3
            // 
            this.switchOut3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut3.Channel = null;
            this.switchOut3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut3.Hint = null;
            this.switchOut3.Location = new System.Drawing.Point(6, 161);
            this.switchOut3.Name = "switchOut3";
            this.switchOut3.ShowHint = false;
            this.switchOut3.Size = new System.Drawing.Size(282, 38);
            this.switchOut3.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut3.TabIndex = 734;
            this.switchOut3.Text = "uiSwitch3";
            // 
            // switchOut2
            // 
            this.switchOut2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut2.Channel = null;
            this.switchOut2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut2.Hint = null;
            this.switchOut2.Location = new System.Drawing.Point(6, 121);
            this.switchOut2.Name = "switchOut2";
            this.switchOut2.ShowHint = false;
            this.switchOut2.Size = new System.Drawing.Size(282, 38);
            this.switchOut2.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut2.TabIndex = 733;
            this.switchOut2.Text = "uiSwitch２";
            // 
            // switchOut1
            // 
            this.switchOut1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut1.Channel = null;
            this.switchOut1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut1.Hint = null;
            this.switchOut1.Location = new System.Drawing.Point(6, 81);
            this.switchOut1.Name = "switchOut1";
            this.switchOut1.ShowHint = false;
            this.switchOut1.Size = new System.Drawing.Size(282, 38);
            this.switchOut1.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut1.TabIndex = 732;
            this.switchOut1.Text = "uiSwitch１";
            // 
            // switchOut0
            // 
            this.switchOut0.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.switchOut0.Channel = null;
            this.switchOut0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.switchOut0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.switchOut0.Hint = null;
            this.switchOut0.Location = new System.Drawing.Point(6, 41);
            this.switchOut0.Name = "switchOut0";
            this.switchOut0.ShowHint = false;
            this.switchOut0.Size = new System.Drawing.Size(282, 38);
            this.switchOut0.SwitchShape = yjTech.SwitchShape.Square;
            this.switchOut0.TabIndex = 731;
            this.switchOut0.Text = "uiSwitch０";
            // 
            // lblOutputPort7
            // 
            this.lblOutputPort7.BackColor = System.Drawing.Color.White;
            this.lblOutputPort7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort7.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort7.Location = new System.Drawing.Point(901, 382);
            this.lblOutputPort7.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort7.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort7.Name = "lblOutputPort7";
            this.lblOutputPort7.ShowAccelChar = false;
            this.lblOutputPort7.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort7.TabIndex = 730;
            this.lblOutputPort7.Text = "Port 7";
            this.lblOutputPort7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort3
            // 
            this.lblOutputPort3.BackColor = System.Drawing.Color.White;
            this.lblOutputPort3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort3.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort3.Location = new System.Drawing.Point(901, 6);
            this.lblOutputPort3.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort3.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort3.Name = "lblOutputPort3";
            this.lblOutputPort3.ShowAccelChar = false;
            this.lblOutputPort3.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort3.TabIndex = 729;
            this.lblOutputPort3.Text = "Port 3";
            this.lblOutputPort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort6
            // 
            this.lblOutputPort6.BackColor = System.Drawing.Color.White;
            this.lblOutputPort6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort6.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort6.Location = new System.Drawing.Point(603, 382);
            this.lblOutputPort6.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort6.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort6.Name = "lblOutputPort6";
            this.lblOutputPort6.ShowAccelChar = false;
            this.lblOutputPort6.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort6.TabIndex = 728;
            this.lblOutputPort6.Text = "Port 6";
            this.lblOutputPort6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort2
            // 
            this.lblOutputPort2.BackColor = System.Drawing.Color.White;
            this.lblOutputPort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort2.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort2.Location = new System.Drawing.Point(603, 6);
            this.lblOutputPort2.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort2.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort2.Name = "lblOutputPort2";
            this.lblOutputPort2.ShowAccelChar = false;
            this.lblOutputPort2.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort2.TabIndex = 727;
            this.lblOutputPort2.Text = "Port 2";
            this.lblOutputPort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort5
            // 
            this.lblOutputPort5.BackColor = System.Drawing.Color.White;
            this.lblOutputPort5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort5.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort5.Location = new System.Drawing.Point(305, 382);
            this.lblOutputPort5.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort5.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort5.Name = "lblOutputPort5";
            this.lblOutputPort5.ShowAccelChar = false;
            this.lblOutputPort5.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort5.TabIndex = 725;
            this.lblOutputPort5.Text = "Port 5";
            this.lblOutputPort5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort1
            // 
            this.lblOutputPort1.BackColor = System.Drawing.Color.White;
            this.lblOutputPort1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort1.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort1.Location = new System.Drawing.Point(305, 6);
            this.lblOutputPort1.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort1.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort1.Name = "lblOutputPort1";
            this.lblOutputPort1.ShowAccelChar = false;
            this.lblOutputPort1.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort1.TabIndex = 726;
            this.lblOutputPort1.Text = "Port 1";
            this.lblOutputPort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort4
            // 
            this.lblOutputPort4.BackColor = System.Drawing.Color.White;
            this.lblOutputPort4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort4.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort4.Location = new System.Drawing.Point(7, 382);
            this.lblOutputPort4.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort4.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort4.Name = "lblOutputPort4";
            this.lblOutputPort4.ShowAccelChar = false;
            this.lblOutputPort4.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort4.TabIndex = 724;
            this.lblOutputPort4.Text = "Port 4";
            this.lblOutputPort4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPort0
            // 
            this.lblOutputPort0.BackColor = System.Drawing.Color.White;
            this.lblOutputPort0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOutputPort0.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOutputPort0.Frame.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblOutputPort0.Location = new System.Drawing.Point(7, 6);
            this.lblOutputPort0.Margin = new System.Windows.Forms.Padding(4);
            this.lblOutputPort0.MinimumSize = new System.Drawing.Size(1, 14);
            this.lblOutputPort0.Name = "lblOutputPort0";
            this.lblOutputPort0.ShowAccelChar = false;
            this.lblOutputPort0.Size = new System.Drawing.Size(287, 29);
            this.lblOutputPort0.TabIndex = 723;
            this.lblOutputPort0.Text = "Port 0";
            this.lblOutputPort0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panManualMotion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.uiTabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panManualMotion";
            this.Size = new System.Drawing.Size(1774, 889);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        #endregion
        private DataServer dsIO;
        private DataServer dsMotion;
        private Thread ReadThread;
        private TabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private LEDImageLabel ledIn31;
        private LEDImageLabel ledIn30;
        private LEDImageLabel ledIn29;
        private LEDImageLabel ledIn28;
        private LEDImageLabel ledIn27;
        private LEDImageLabel ledIn26;
        private LEDImageLabel ledIn25;
        private LEDImageLabel ledIn24;
        private LEDImageLabel ledIn23;
        public LEDImageLabel ledDoor5;
        public LEDImageLabel ledDoor4;
        public LEDImageLabel ledDoor3;
        public LEDImageLabel ledDoor2;
        public LEDImageLabel ledDoor1;
        private LEDImageLabel ledIn17;
        private LEDImageLabel ledIn16;
        private LEDImageLabel ledIn15;
        private LEDImageLabel ledIn14;
        private LEDImageLabel ledIn13;
        private LEDImageLabel ledIn12;
        private LEDImageLabel ledIn11;
        private LEDImageLabel ledIn10;
        private LEDImageLabel ledIn09;
        private LEDImageLabel ledIn08;
        private LEDImageLabel ledIn07;
        private LEDImageLabel ledIn06;
        private LEDImageLabel ledIn05;
        private LEDImageLabel ledIn04;
        private LEDImageLabel ledIn03;
        private LEDImageLabel ledIn02;
        private LEDImageLabel ledIn01;
        private LEDImageLabel ledIn00;
        private LEDImageArray ledArray8;
        private LEDImageArray ledArray7;
        private LEDImageArray ledArray6;
        private LEDImageArray ledArray5;
        private Label lblInputPort7;
        private Label lblInputPort3;
        private Label lblInputPort6;
        private Label lblInputPort2;
        private Label lblInputPort5;
        private Label lblInputPort1;
        private Label lblInputPort4;
        private Label lblInputPort0;
        private System.Windows.Forms.TabPage tabPage3;
        private SunnySwitch switchOut63;
        private SunnySwitch switchOut62;
        private SunnySwitch switchOut61;
        private SunnySwitch switchOut60;
        private SunnySwitch switchOut59;
        private SunnySwitch switchOut58;
        private SunnySwitch switchOut57;
        private SunnySwitch switchOut56;
        private SunnySwitch switchOut55;
        private SunnySwitch switchOut54;
        private SunnySwitch switchOut53;
        private SunnySwitch switchOut52;
        private SunnySwitch switchOut51;
        private SunnySwitch switchOut50;
        private SunnySwitch switchOut49;
        private SunnySwitch switchOut48;
        private SunnySwitch switchOut47;
        private SunnySwitch switchOut46;
        private SunnySwitch switchOut45;
        private SunnySwitch switchOut44;
        private SunnySwitch switchOut43;
        private SunnySwitch switchOut42;
        private SunnySwitch switchOut41;
        private SunnySwitch switchOut40;
        private SunnySwitch switchOut39;
        private SunnySwitch switchOut38;
        private SunnySwitch switchOut37;
        private SunnySwitch switchOut36;
        private SunnySwitch switchOut35;
        private SunnySwitch switchOut34;
        private SunnySwitch switchOut33;
        private SunnySwitch switchOut32;
        private SunnySwitch switchOut31;
        private SunnySwitch switchOut30;
        private SunnySwitch switchOut29;
        private SunnySwitch switchOut28;
        private SunnySwitch switchOut27;
        private SunnySwitch switchOut26;
        private SunnySwitch switchOut25;
        private SunnySwitch switchOut24;
        private SunnySwitch switchOut23;
        private SunnySwitch switchOut22;
        private SunnySwitch switchOut21;
        private SunnySwitch switchOut20;
        private SunnySwitch switchOut19;
        private SunnySwitch switchOut18;
        private SunnySwitch switchOut17;
        private SunnySwitch switchOut16;
        private SunnySwitch switchOut15;
        private SunnySwitch switchOut14;
        private SunnySwitch switchOut13;
        private SunnySwitch switchOut12;
        private SunnySwitch switchOut11;
        private SunnySwitch switchOut10;
        private SunnySwitch switchOut9;
        private SunnySwitch switchOut8;
        private SunnySwitch switchOut7;
        private SunnySwitch switchOut6;
        private SunnySwitch switchOut5;
        private SunnySwitch switchOut4;
        private SunnySwitch switchOut3;
        private SunnySwitch switchOut2;
        private SunnySwitch switchOut1;
        private SunnySwitch switchOut0;
        private Label lblOutputPort7;
        private Label lblOutputPort3;
        private Label lblOutputPort6;
        private Label lblOutputPort2;
        private Label lblOutputPort5;
        private Label lblOutputPort1;
        private Label lblOutputPort4;
        private Label lblOutputPort0;
    }
}
