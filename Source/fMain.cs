/*
/*

_VERSION1, _PMAC, _COHERENT, _ADV, _POWERMETER, _LIGHT, _VISION, _MVS

_VERSION2, _PMAC, _CARBIDE, _ADV, _POWERMETER, _LIGHT, _VISION, _MVS

 */

using System;

using System.Drawing;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using IniParser;

using Raize.CodeSiteLogging;
using yjTech;

//using IniP

namespace LaserCutter
{
    public partial class frmMain : Form
    {
        CodeSiteLogger logger;

        public frmChannelSpy frmChannelSpy;
        private frmProgress frmProgress = new frmProgress();
        private frmMotionFile frmMotionFile = new frmMotionFile();

        public panAuto Auto;
        public panAutoMenu AutoMenu;
        public panManual Manual;
        public panConfig Config;

        public panJobFile JobFile;

        private Point mMousePoint;

        private string strCulture;
        private DateTime currentDate;

        public int MenuIndex = 0;

        #region Atom을 정의합니다.

        // Ctrl + I 키 조합을 나타내는 키 코드입니다.
        private const int VK_F1 = 0x70;
        private const int VK_F2 = 0x71;
        private const int VK_F3 = 0x72;
        private const int VK_F4 = 0x73;
        private const int VK_F5 = 0x74;
        private const int VK_F6 = 0x75;
        private const int VK_I = 0x49;
        private const int VK_M = 0x4D;

        private const int MOD_ALT = 0x01;
        private const int MOD_CONTROL = 0x02;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;

        private ushort atomChannelSpy;
        private ushort atomCarbide;
        private ushort atomDownload;

        #endregion

        // 정적 필드로 싱글톤 인스턴스를 저장
        private static frmMain staticForm;

        public frmMain()
        {
            CodeSite.EnterMethod("frmMain.Create()");

            Global.SetDefaultFont(this);

            InitializeComponent();

            FormClosing += frmMain_FormClosing;

            staticForm = this;

            SetBuildVersion();

            String szStr = String.Format("{0}UTI_Logo.png", yjCommon.AppPath());
            if (yjCommon.FileExists(szStr))
            {
                pictureBox1.BackgroundImage = Image.FromFile(szStr);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }

            SetCodeSitelogger();

            szStr = String.Format("LaserCutter - Start: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            szStr = String.Format("{0}Dll\\", yjCommon.AppPath());
            Lcad.SetDllPath(szStr);
            PowerPMac.SetDllPath(szStr);

            /*
             * yhbyun 20240805.001
             * dll Version이 다를때 운전이 안되도록 수정해야 함.
             */
            szStr = String.Format("{0}Dll\\PowerPmac64.dll", yjCommon.AppPath());
            Version currentVersion = yjCommon.GetDllVersion(szStr);

            Version expectedVersion = new Version(2, 3, 16, 25);
            if (currentVersion.CompareTo(expectedVersion) < 0)
            {
                logger.SendMsg($"Warning: {szStr}. \r\nCurrent dll version \"{currentVersion}\" is lower than expected version \"{expectedVersion}\".");
            }

            btnAuto.Click += ChangeMainPanel;
            btnJobFile.Click += ChangeMainPanel;
            btnManual.Click += ChangeMainPanel;
            btnConfig.Click += ChangeMainPanel;
            btnAlarm.Click += ChangeMainPanel;
            btnLog.Click += ChangeMainPanel;
            btnLogIn.Click += ChangeMainPanel;

            SystemInitialize();

            ChangeMainPanel(btnAuto);

            ////frmVision = frmVision.StaticInstance;
            frmChannelSpy = frmChannelSpy.StaticInstance;

#if _VERSION2
            ////frmCarbide = frmCarbide.StaticInstance;
#endif

            ////frmMVS.btnConnect_Click(null, null);

            ////       Config.Motor.SetSoftLimit();
#if _VERSION1
            Pmac.QueryCommand("disable plc 10, 11, 20, 22, 26, 27");
            Pmac.QueryCommand("enable plc 8, 9");

            Pmac.QueryCommand("disable plc 10, 11, 20, 22, 26, 27");
            Pmac.QueryCommand("enable plc 8, 9");
#endif
            LoadLanguageFile();
            //영어로 초기화
            ChangeLanguageEnglish();

            Manual.Laser.ShutterClose();
            Pmac.QueryCommand("doBeamShutterOpen=false");

            CodeSite.ExitMethod("frmMain.Create()");
        }

        public static frmMain StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmMain();
                }
                return staticForm;
            }
        }

        #region protected override void WndProc(ref Message m)
        [StructLayout(LayoutKind.Sequential)]
        public struct CopyDataStruct
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }
        #endregion

        private void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Main";

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = yjCommon.AppPath();
            fileDestination.LogFile.FileName = "LaserCutter";

            logger.Destination = fileDestination;
            logger.Destination.Viewer.Active = true;
        }

        public void ChangeLogFilePath(String szPath)
        {
            logger.Destination.LogFile.LogByDate = false;
            logger.Destination.LogFile.Active = false;

            logger.Destination.LogFile.FilePath = szPath;

            logger.Destination.LogFile.LogByDate = true;
            logger.Destination.LogFile.Active = true;
        }

        #region HotKey ~~
        /// <summary>
        /// Hotkey를 등록하여 프로그램 구동시 Function Key를 설정
        /// </summary>
        private void RegisterHotKey()
        {
            atomChannelSpy = yjCommon.GlobalAddAtom("MyAtom");
            yjCommon.RegisterHotKey(this.Handle, atomChannelSpy, MOD_CONTROL, VK_F1);

            atomCarbide = yjCommon.GlobalAddAtom("Carbide");
            yjCommon.RegisterHotKey(this.Handle, atomCarbide, MOD_CONTROL, VK_F2);

            atomDownload = yjCommon.GlobalAddAtom("Download");
            yjCommon.RegisterHotKey(this.Handle, atomDownload, MOD_CONTROL, 'D');
        }

        private void UnregisterHotKey()
        {
            // 등록된 핫키를 해제합니다.
            yjCommon.UnregisterHotKey(this.Handle, atomChannelSpy);
            yjCommon.GlobalDeleteAtom(atomChannelSpy);

            yjCommon.UnregisterHotKey(this.Handle, atomCarbide);
            yjCommon.GlobalDeleteAtom(atomCarbide);

            yjCommon.UnregisterHotKey(this.Handle, atomDownload);
            yjCommon.GlobalDeleteAtom(atomDownload);
        }

        // Ctrl + I 키가 눌리면 호출되는 이벤트 핸들러입니다.
        const int WM_HOTKEY = 0x0312;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == PowerPMac.WM_MESSAGE_DOWNLOAD)
            {
                var cds = (CopyDataStruct)Marshal.PtrToStructure(m.LParam, typeof(CopyDataStruct));

                switch (cds.dwData.ToInt32())
                {
                    case PowerPMac.DT_Progress:

                        if (cds.cbData == 0)
                        {
                            frmProgress.Show();
                        }
                        else
                        if (cds.cbData == 100)
                        {
                            frmProgress.Close();
                        }

                        frmProgress.progressBar1.Value = cds.cbData;
                        frmProgress.lblMessage.Text = String.Format("Downloading..{0}", cds.cbData);

                        // logger.SendMsg(frmProgress.lblMessage.Text);
                        break;

                    case PowerPMac.DT_StringA:
                        string s = Marshal.PtrToStringAnsi(cds.lpData);
                        s = yjCommon.RemoveCRLF(s);
                        frmMotionFile.Memo1.AppendText(s + Environment.NewLine);
                        logger.SendMsg(s + Environment.NewLine);
                        break;

                    case PowerPMac.DT_StringW:
                        // Handle wide string case if needed
                        break;
                }

                frmMotionFile.MessageQueue.Add(m.WParam.ToInt32());
            }


            switch (m.Msg)
            {
                case WM_HOTKEY:
                    // 만약 등록된 핫키가 눌리면 이벤트가 발생합니다.
                    if (m.WParam.ToInt32() == atomChannelSpy)
                    {
                        if (frmChannelSpy.Visible)
                        {
                            frmChannelSpy.Close();
                        }

                        frmChannelSpy.TopMost = true;
                        frmChannelSpy.Show();
                    }
                    else
                    if (m.WParam.ToInt32() == atomDownload)
                    {
                        if (Auto.tabControl1.SelectedIndex == 0)
                        {
                            Auto.Table1.PageIndex = Auto.Table1.GetFirstPage();

                            Auto.Table1.MakeMotionFile(0, new DoublePoint(0.0, 0.0), false);
                            Pmac.DownloadFile1(Handle);
                        }
                        else
                        if (Auto.tabControl1.SelectedIndex == 1)
                        {
                            Auto.Table2.PageIndex = Auto.Table2.GetFirstPage();

                            Auto.Table2.MakeMotionFile(0, new DoublePoint(0.0, 0.0), false);
                            Pmac.DownloadFile2(Handle);
                        }
                    }
                    else
                    if (m.WParam.ToInt32() == atomCarbide)
                    {
#if _VERSION2
                        ////if (frmCarbide.Visible)
                        ////{
                        ////    frmCarbide.Close();
                        ////}

                        ////frmCarbide.TopMost = true;
                        ////frmCarbide.ReadThread.Enabled = true;
                        ////frmCarbide.Show();
#endif
                    }

                    break;
            }
        }

        #endregion

        private void SystemInitialize()
        {
            logger.EnterMethod("SystemInitialize");

            String szStr = String.Format("Application - Start: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            logger.SendMsg(szStr);

            RegisterHotKey();

            CheckSystemFile();

            /*
  * 1. Auto
  */
            Auto = new panAuto();
            Auto.frmChannelSpy = frmChannelSpy.StaticInstance;
            ////Auto.frmVision = frmVision.StaticInstance;
            ////Auto.frmMVS = frmMVS.StaticInstance;
            ////Auto.Vision1.frmMVS = frmMVS.StaticInstance;
            ////Auto.Vision2.frmMVS = frmMVS.StaticInstance;
        
            ////Auto.frmRestart = frmRestart.StaticInstance;
            Auto.frmMain = this;
            panClient.Controls.Add(Auto);

            AutoMenu = new panAutoMenu();
            AutoMenu.frmChannelSpy = frmChannelSpy.StaticInstance;

            panClient.Controls.Add(AutoMenu);
            AutoMenu.Location = new Point(Auto.Location.X + Auto.Width - 2, Auto.Location.Y);

            Auto.Common = panConfigCommon.StaticInstance;
            ////Auto.SideMenu = panSideMenu.StaticInstance;

            Auto.Table1.Type1.Common = panConfigCommon.StaticInstance;
            Auto.Table1.Type2.Common = panConfigCommon.StaticInstance;
            Auto.Table1.Type3.Common = panConfigCommon.StaticInstance;
            Auto.Table1.Type4.Common = panConfigCommon.StaticInstance;

            Auto.Table2.Type1.Common = panConfigCommon.StaticInstance;
            Auto.Table2.Type2.Common = panConfigCommon.StaticInstance;
            Auto.Table2.Type3.Common = panConfigCommon.StaticInstance;
            Auto.Table2.Type4.Common = panConfigCommon.StaticInstance;

            AutoMenu.ChannelAssign();

            /*
            * 2. Manual
            */
            Manual = panManual.StaticInstance;
            panClient.Controls.Add(Manual);
            ////Manual.Laser.btnConnectLaser_Click(null, null);
            ////Manual.Laser.ShutterClose();
            ////Pmac.QueryCommand("doBeamShutterOpen=false");

            /*
            * 3. Config
            */
            Config = new panConfig();
            panClient.Controls.Add(Config);

            /*
            * 4. JobFile
            */
            JobFile = new panJobFile();
            panClient.Controls.Add(JobFile);

            /*
             * 
             */
            AutoThread.Enabled = true;


            logger.ExitMethod("SystemInitialize");
        }

        public void SystemFinalization()
        {
            logger.SendMsg("SystemFinalization()");
                        
            UnregisterHotKey();
        }

        public bool CheckSystemFile()
        {
            String szStr;
            bool result = true;

            szStr = String.Format("{0}Config", yjCommon.AppPath());
            if (!yjCommon.DirectoryExists(szStr))
            {
                yjCommon.CreateDirectory(szStr);
                result = false;
            }

            szStr = String.Format("{0}Model", yjCommon.AppPath());
            if (!yjCommon.DirectoryExists(szStr))
            {
                yjCommon.CreateDirectory(szStr);
                result = false;
            }

            szStr = String.Format("{0}Log", yjCommon.AppPath());
            if (!yjCommon.DirectoryExists(szStr))
            {
                yjCommon.CreateDirectory(szStr);
                result = false;
            }

            CreateDailyFolder(szStr);

            return result;
        }

        public String CreateDailyFolder(string szBaseDir)
        {
            // 현재 날짜 정보
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");

            // 연도 폴더 생성
            string yearPath = Path.Combine(szBaseDir, year);
            if (!Directory.Exists(yearPath))
            {
                Directory.CreateDirectory(yearPath);
            }

            // 월 폴더 생성
            string monthPath = Path.Combine(yearPath, month);
            if (!Directory.Exists(monthPath))
            {
                Directory.CreateDirectory(monthPath);
            }

            return monthPath;
        }

        #region frmMain Event
        private void frmMain_Load(object sender, EventArgs e)
        {            //ConfigCommon
            Config.Common.propSaver1.INIFileName = yjCommon.AppPath() + "Config\\LaserCutter.INI";
            Config.Common.propSaver1.SaveToRegistry = false;
            Config.Common.propSaver1.LoadProperty();

            Auto.SetTableBasePos();
            Config.SetTableBasePos();

            ////Manual.Light.Connect();
            ////Manual.ADV.Connect();
            ////Manual.PowerMeter.Connect();

            // panMain.Ini
            Config.Common.InitControls();

            if (Screen.AllScreens.Length > 1)
            {
                Screen sencondScreen = Screen.AllScreens[1];

                ////frmVision.StartPosition = FormStartPosition.Manual;
                ////frmVision.Location = sencondScreen.WorkingArea.Location;
                ////frmVision.Left = sencondScreen.WorkingArea.Left;
                ////frmVision.Top = sencondScreen.WorkingArea.Top;

#if _VISION
                String visionfile = String.Format("{0}Vision\\CogPMAlignTool(4Align).vpp", dkCommon.AppPath());
                frmVision.Vision1.cogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(visionfile);
                frmVision.Vision2.cogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(visionfile);
#endif
            }

#if _VISION
            frmVision.Show();
#endif

            //// frmMVS.UpdateThread1.OnExecute += frmVision.Vision1.UpdateThread_OnExecute;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Common.propSaver1.SaveProperty();

            SystemFinalization();

            String szStr = String.Format("Application - Close: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            logger.SendMsg(szStr);
        }
        #endregion

        private void ChangeMainPanel(object sender, EventArgs e)
        {
            if (sender is yjTech.BitBtn aButton)
            {
                ChangeMainPanel(aButton);
            }
        }

        public void ChangeAutoTitle()
        {
            AutoMenu.ledTable1DXF.LED.Value = (Auto.Table1.tabControl1.SelectedIndex == 0);
            AutoMenu.ledTable1DXFArray.LED.Value = (Auto.Table1.tabControl1.SelectedIndex == 1);
            AutoMenu.ledTable1MakeCell.LED.Value = (Auto.Table1.tabControl1.SelectedIndex == 2);

            AutoMenu.ledTable2DXF.LED.Value = (Auto.Table2.tabControl1.SelectedIndex == 0);
            AutoMenu.ledTable2DXFArray.LED.Value = (Auto.Table2.tabControl1.SelectedIndex == 1);
            AutoMenu.ledTable2MakeCell.LED.Value = (Auto.Table2.tabControl1.SelectedIndex == 2);

            if (MenuIndex == 10)
            {
                if (Auto.tabControl1.SelectedIndex == 0)
                {
                    lblMainTitle.ForeColor = Color.Red;
                    if (Auto.Table1.tabControl1.SelectedIndex == 0)
                    {
                        lblMainTitle.Text = "Table1 - Auto (DXF)";
                    }
                    else
                    if (Auto.Table1.tabControl1.SelectedIndex == 1)
                    {
                        lblMainTitle.Text = "Table1 - Auto (Array)";
                    }
                    else
                    if (Auto.Table1.tabControl1.SelectedIndex == 2)
                    {
                        lblMainTitle.Text = "Table1 - Auto (Make Cell)";
                    }
                }
                else
                if (Auto.tabControl1.SelectedIndex == 1)
                {
                    lblMainTitle.ForeColor = Color.Yellow;
                    if (Auto.Table2.tabControl1.SelectedIndex == 0)
                    {
                        lblMainTitle.Text = "Table2 - Auto (DXF)";
                    }
                    else
                    if (Auto.Table2.tabControl1.SelectedIndex == 1)
                    {
                        lblMainTitle.Text = "Table2 - Auto (Array)";
                    }
                    else
                    if (Auto.Table2.tabControl1.SelectedIndex == 2)
                    {
                        lblMainTitle.Text = "Table2 - Auto (Make Cell)";
                    }
                }
            }
        }

        public void ChangeMainPanel(yjTech.BitBtn aButton)
        {
            if (MenuIndex == Convert.ToInt32(aButton.Tag)) return;

            int ypos = 0;

            MenuIndex = Convert.ToInt32(aButton.Tag);

            //////panClient.Controls.Clear();
            //////panClient.Location = new Point(5, 86);
            //////panClient.Width = 1787;
            //////panClient.Height = 937;

            //// JobFile.Height = Auto.Height;
            //// Config.Height = Auto.Height;
            Manual.Height = Auto.Height;

            if (aButton == btnAuto)
            {
                ChangeAutoTitle();

                Auto.BringToFront();
                AutoMenu.tabControlEx1.SelectedIndex = 0;

                AutoMenu.tabPage1.CancelLine = false;
                AutoMenu.tabPage2.CancelLine = false;
                AutoMenu.tabPage3.CancelLine = true;
            }
            else
            if (aButton == btnManual)
            {
                lblMainTitle.Text = "Manual";

                Manual.BringToFront();
                AutoMenu.tabControlEx1.SelectedIndex = 1;

                AutoMenu.tabPage1.CancelLine = true;
                AutoMenu.tabPage2.CancelLine = false;
                AutoMenu.tabPage3.CancelLine = true;
            }
            else
            if (aButton == btnConfig)
            {
                lblMainTitle.Text = "Config";

                Config.BringToFront();
                AutoMenu.tabControlEx1.SelectedIndex = 1;

                AutoMenu.tabPage1.CancelLine = true;
                AutoMenu.tabPage2.CancelLine = false;
                AutoMenu.tabPage3.CancelLine = true;
            }
            else
            if (aButton == btnJobFile)
            {
                lblMainTitle.Text = "JobFile";

                JobFile.BringToFront();
                AutoMenu.tabControlEx1.SelectedIndex = 2;

                AutoMenu.tabPage1.CancelLine = true;
                AutoMenu.tabPage2.CancelLine = true;
                AutoMenu.tabPage3.CancelLine = false;
            }
            else
            if (aButton == btnLog)
            {
                lblMainTitle.Text = "Log";

                // panLog.BringToFront();
            }
            else
            if (aButton == btnLogIn)
            {
                lblMainTitle.Text = "User";

                ////panClient.Width = 1920;
                ////panClient.Controls.Add(panLog);
            }
            else
            if (aButton == btnAlarm)
            {
                lblMainTitle.Text = "Alarm";

                ////panClient.Width = 1920;
                ////panClient.Controls.Add(panLog);
            }

            ypos = aButton.Location.Y + 4;

            lblSelectedMenu.Location = new Point(lblSelectedMenu.Location.X, ypos);
        }

        private async void btnExit_Click(object sender, EventArgs e)
        {
            frmUserConfirm frmUserConfirm = new frmUserConfirm();
            frmUserConfirm.lblMessage.Text = "프로그램을 종료합니다.";

            frmUserConfirm.StartPosition = FormStartPosition.CenterScreen;
            
            if (frmUserConfirm.ShowDialog() == DialogResult.OK)
            {
                //// Manual.Laser.ShutterClose();

                Auto.AutoThread.Enabled = false;
                //// Manual.ADV.ReadThread.Enabled = false;
                //// Manual.Light.ReadThread.Enabled = false;
                //// Manual.PowerMeter.MeasureThread.Enabled = false;
                await Task.Delay(100);

                ////Pmac.QueryCommand("doTowerLampBuzzer=false");
                ////Pmac.QueryCommand("doBeamShutterOpen=false");

                //// frmMVS.btnGrabStop_Click(null, null);
                //// frmMVS.btnDisconnect_Click(null, null);

                //// await Task.Delay(100);

                //// frmVision.exitConfirmed = true;
                //// frmVision.Vision1.exitConfirmed = true;
                //// frmVision.Vision2.exitConfirmed = true;
                //// frmVision.Finilization();

                //// await Task.Delay(100);

                //// Manual.ADV.Comm.CloseComm();
                //// Manual.Light.Comm.CloseComm();
                //// Manual.PowerMeter.Comm.CloseComm();

                await Task.Delay(100);

                Application.Exit();
            }

        }

        private void AutoThread_OnExecute(object sender, EventArgs e)
        {
            if (DateTime.Now.Date != currentDate.Date)
            {

            }
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void SetBuildVersion()
        {
            lblBuildVersion.Text = "Build:20241203.001";
        }

        private void LoadLanguageFile()
        {
            //motionParameters.Clear();

            String szFileName = String.Format("{0}Config\\Language_English.ini", yjCommon.AppPath());

            Global.iniEng = new yjTech.IniFile(szFileName);


            szFileName = String.Format("{0}Config\\Language_Korea.ini", yjCommon.AppPath());

            var parser = new FileIniDataParser();


            using (var reader = new StreamReader(szFileName, Encoding.UTF8))
            {
                Global.iniKor = parser.ReadData(reader);
            }


            szFileName = String.Format("{0}Config\\Language_Vietnam.ini", yjCommon.AppPath());

            parser = new FileIniDataParser();


            using (var reader = new StreamReader(szFileName, Encoding.UTF8))
            {
                Global.iniVie = parser.ReadData(reader);
            }
        }

        /*private string GetIniLanguageValue(IniData data, string strSectionName, string Keyname)
        {
            string strValue = data[strSectionName][Keyname];

            return strValue; 

        }*/

        #region public void ChangeLanguageEnglish() 
        public void ChangeLanguageEnglish()
        {

            //panJobFile.Info.Type1.SetChangeLagEngData(INI, culture);
        }

        public void ChangeLanguageKorea()
        {


        }

        public void ChangeLanguageVietnam()
        {
            //// 섹션과 키를 사용하여 값 읽기


        }
        #endregion

    }
}
