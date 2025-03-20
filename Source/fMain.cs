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

using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro;

using MvCameraControl;

using Raize.CodeSiteLogging;
using YujinTechnology;

//using IniP

namespace LaserCutter
{
    public partial class frmMain : Form
    {
        CodeSiteLogger logger;

        public static frmVision frmVision;
        private static frmMVS frmMVS;

        public frmChannelSpy frmChannelSpy;
        public frmCarbide frmCarbide;

        private frmProgress frmProgress = new frmProgress();
        private frmMotionFile frmMotionFile = new frmMotionFile();

        public panConfig Config;
        public panAuto Auto;
        public panManual Manual;
        public panJobFile JobFile;
        public panSideMenu SideMenu;

        private panLog panLog;
        private panAlarm panAlarm;

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

#if _VERSION1
            lblVersion.Text = "Version:1.2";
#elif _VERSION2
            lblVersion.Text = "Version:2.2";
#elif _VERSION3
            lblVersion.Text = "Version:3.0";
#endif

            FormClosing += frmMain_FormClosing;

            staticForm = this;

            SetBuildVersion();

            String szStr = String.Format("{0}UTI_Logo.png", yjCommon.AppPath());
            pictureBox1.BackgroundImage = Image.FromFile(szStr);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

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

            frmVision = frmVision.StaticInstance;
            frmChannelSpy = frmChannelSpy.StaticInstance;

		#if _VERSION2
            frmCarbide = frmCarbide.StaticInstance;
		#endif

            frmMVS.btnConnect_Click(null, null);

            //       Config.Motor.SetSoftLimit();
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
                        if (Auto.TabControl1.SelectedIndex == 0)
                        {
                            Auto.Table1.PageIndex = Auto.Table1.GetFirstPage();

                            Auto.Table1.MakeMotionFile(0, new DoublePoint(0.0, 0.0), false);
                            Pmac.DownloadFile1(Handle);
                        }
                        else
                        if (Auto.TabControl1.SelectedIndex == 1)
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
                        if (frmCarbide.Visible)
                        {
                            frmCarbide.Close();
                        }

                        frmCarbide.TopMost = true;
                        frmCarbide.ReadThread.Enabled = true;
                        frmCarbide.Show();
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
            Auto.frmVision = frmVision.StaticInstance;
            Auto.frmMVS = frmMVS.StaticInstance;
            Auto.Vision1.frmMVS = frmMVS.StaticInstance;
            Auto.Vision2.frmMVS = frmMVS.StaticInstance;

            Auto.frmRestart = frmRestart.StaticInstance;
            Auto.frmMain = this;

            Auto.Common = panConfigCommon.StaticInstance;
            Auto.SideMenu = panSideMenu.StaticInstance;

            Auto.Table1.JobInfo.Type1.Common = panConfigCommon.StaticInstance;
            Auto.Table1.JobInfo.Type2.Common = panConfigCommon.StaticInstance;
            Auto.Table1.JobInfo.Type3.Common = panConfigCommon.StaticInstance;

            Auto.Table2.JobInfo.Type1.Common = panConfigCommon.StaticInstance;
            Auto.Table2.JobInfo.Type2.Common = panConfigCommon.StaticInstance;
            Auto.Table2.JobInfo.Type3.Common = panConfigCommon.StaticInstance;
            
            Auto.ChannelAssign();

#if _VERSION1
            Auto.lblMachineNo.Text = "No: 01";
#elif _VERSION2
            Auto.lblMachineNo.Text = "No: 02";
#endif

            /*
             * 2. Manual
             */
            Manual = panManual.StaticInstance;
            Manual.Laser.btnConnectLaser_Click(null, null);
            Manual.Laser.ShutterClose();
            Pmac.QueryCommand("doBeamShutterOpen=false");

            /*
             * 3. Config
             */
            Config = new panConfig();

            /*
             * 4. JobFile
             */
            JobFile = new panJobFile();

            /*
             * 5. SideMenu
             */
            SideMenu = panSideMenu.StaticInstance;
#if _VERSION1
            SideMenu.Version1ChannelAssign();
#elif _VERSION2
            SideMenu.Version2ChannelAssign();
#endif

            /*
             * 6. Log
             */
            panLog = new panLog();

            /*
             * 7. Alarm
             */
            panAlarm = new panAlarm();

            /*
             * 8. MVS
             */
            SDKSystem.Initialize();

            frmMVS = frmMVS.StaticInstance;
            frmMVS.InitializeCamera();

            frmMVS.UpdateThread1.OnExecute += Auto.Vision1.UpdateThread_OnExecute;
            frmMVS.UpdateThread2.OnExecute += Auto.Vision2.UpdateThread_OnExecute;

            /*
             * 
             */
            AutoThread.Enabled = true;

            logger.ExitMethod("SystemInitialize");
        }

        public async void SystemFinalization()
        {
            logger.SendMsg("SystemFinalization()");
            
            frmMVS.UpdateThread1.Enabled = false;
            await Task.Delay(100); // 0.05초 동안 대기

            frmMVS.UpdateThread2.Enabled = false;
            await Task.Delay(100); // 0.05초 동안 대기

            frmMVS.btnGrabStop_Click(null, null);
            await Task.Delay(100); // 0.05초 동안 대기

            frmMVS.btnDisconnect_Click(null, null);
            await Task.Delay(100); // 0.05초 동안 대기

            SDKSystem.Finalize();

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
        {
            //ConfigCommon
            Config.Common.propSaver1.INIFileName = yjCommon.AppPath() + "Config\\LaserCutter.INI";
            Config.Common.propSaver1.SaveToRegistry = false;
            Config.Common.propSaver1.LoadProperty();

            //SideMenu
            SideMenu.PropSaver.INIFileName = yjCommon.AppPath() + "Config\\SideMenu.INI";
            SideMenu.PropSaver.SaveToRegistry = false;
            SideMenu.PropSaver.LoadProperty();

            Auto.SetTableBasePos();
            Config.SetTableBasePos();

            Manual.Light.Connect();
            Manual.ADV.Connect();
            Manual.PowerMeter.Connect();

            // panMain.Ini
            Config.Common.InitControls();

            if (Screen.AllScreens.Length > 1)
            {
                Screen sencondScreen = Screen.AllScreens[1];

                frmVision.StartPosition = FormStartPosition.Manual;
                frmVision.Location = sencondScreen.WorkingArea.Location;
                frmVision.Left = sencondScreen.WorkingArea.Left;
                frmVision.Top = sencondScreen.WorkingArea.Top;

#if _VISION
                String visionfile = String.Format("{0}Vision\\CogPMAlignTool(4Align).vpp", yjCommon.AppPath());
                frmVision.Vision1.cogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(visionfile);
                frmVision.Vision2.cogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(visionfile);
#endif
            }

#if _VISION
            frmVision.Show();
#endif

            frmMVS.UpdateThread1.OnExecute += frmVision.Vision1.UpdateThread_OnExecute;
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
            if (sender is YujinTechnology.BitBtn aButton)
            {
                ChangeMainPanel(aButton);
            }
        }

        public void ChangeAutoTitle()
        {
            Auto.ledTable1DXF.LED.Value = (Auto.Table1.JobInfo.TabControl2.SelectedIndex == 0);
            Auto.ledTable1DXFArray.LED.Value = (Auto.Table1.JobInfo.TabControl2.SelectedIndex == 1);
            Auto.ledTable1MakeCell.LED.Value = (Auto.Table1.JobInfo.TabControl2.SelectedIndex == 2);

            Auto.ledTable2DXF.LED.Value = (Auto.Table2.JobInfo.TabControl2.SelectedIndex == 0);
            Auto.ledTable2DXFArray.LED.Value = (Auto.Table2.JobInfo.TabControl2.SelectedIndex == 1);
            Auto.ledTable2MakeCell.LED.Value = (Auto.Table2.JobInfo.TabControl2.SelectedIndex == 2);

            if (MenuIndex == 10)
            {
                if (Auto.TabControl1.SelectedIndex == 0)
                {
                    lblMainTitle.ForeColor = Color.Red;
                    if (Auto.Table1.JobInfo.TabControl2.SelectedIndex == 0)
                    {
                        lblMainTitle.Text = "Table1 - Auto (DXF)";
                    }
                    else
                    if (Auto.Table1.JobInfo.TabControl2.SelectedIndex == 1)
                    {
                        lblMainTitle.Text = "Table1 - Auto (Array)";
                    }
                    else
                    if (Auto.Table1.JobInfo.TabControl2.SelectedIndex == 2)
                    {
                        lblMainTitle.Text = "Table1 - Auto (Make Cell)";
                    }
                }
                else
                if (Auto.TabControl1.SelectedIndex == 1)
                {
                    lblMainTitle.ForeColor = Color.Yellow;
                    if (Auto.Table2.JobInfo.TabControl2.SelectedIndex == 0)
                    {
                        lblMainTitle.Text = "Table2 - Auto (DXF)";
                    }
                    else
                    if (Auto.Table2.JobInfo.TabControl2.SelectedIndex == 1)
                    {
                        lblMainTitle.Text = "Table2 - Auto (Array)";
                    }
                    else
                    if (Auto.Table2.JobInfo.TabControl2.SelectedIndex == 2)
                    {
                        lblMainTitle.Text = "Table2 - Auto (Make Cell)";
                    }
                }
            }
        }

        public void ChangeMainPanel(YujinTechnology.BitBtn aButton)
        {
            if (MenuIndex == Convert.ToInt32(aButton.Tag)) return;

            int xpos = 0;

            MenuIndex = Convert.ToInt32(aButton.Tag);

            panClient.Controls.Clear();
            panClient.Location = new Point(0, 102);
            panClient.Height = 854;
            panClient.Width = 1556;

            panRight.Location = new Point(1556, 102);
            panRight.Size = new Size(360, 852);

            JobFile.Height = Auto.Height;
            Config.Height = Auto.Height;
            Manual.Height = Auto.Height;

            if (aButton == btnAuto)
            {
                ChangeAutoTitle();

                panClient.Width = 1920;
                panClient.Controls.Add(Auto);
            }
            else
            if (aButton == btnJobFile)
            {
                lblMainTitle.Text = "JobFile";

                panClient.Controls.Add(JobFile);

                JobFile.LoadRecentList(JobFile.lvRecentModel, (TableNo) JobFile.TabControl1.SelectedIndex + 1);
                JobFile.LoadModelList();

                panRight.Controls.Add(SideMenu);
                SideMenu.Left = 0;
            }
            else
            if (aButton == btnManual)
            {
                lblMainTitle.Text = "Manual";

                panClient.Controls.Add(Manual);
                panRight.Controls.Add(SideMenu);
                SideMenu.Left = 0;
                SideMenu.Left = 0;
            }
            else
            if (aButton == btnConfig)
            {
                lblMainTitle.Text = "Config";

                panClient.Controls.Add(Config);
                panRight.Controls.Add(SideMenu);
                SideMenu.Left = 0;
                SideMenu.Left = 0;
            }
            else
            if (aButton == btnLog)
            {
                lblMainTitle.Text = "Error Log";

                panClient.Width = 1920;
                panClient.Controls.Add(panLog);
            }
            else
            if (aButton == btnLogIn)
            {
            }
            else
            if (aButton == btnExit)
            {
            }
            else
            if (aButton == btnAlarm)
            {
                lblMainTitle.Text = "Alarm";

                panClient.Width = 1920;
                panClient.Controls.Add(panAlarm);
            }

            xpos = aButton.Location.X + 4;

            lblSelectedMenu.Location = new Point(xpos, lblSelectedMenu.Location.Y);
        }

        private async void btnExit_Click(object sender, EventArgs e)
        {
            frmUserConfirm frmUserConfirm = new frmUserConfirm();
            frmUserConfirm.lblMessage.Text = "프로그램을 종료합니다.";

            frmUserConfirm.StartPosition = FormStartPosition.CenterScreen;
            if (frmUserConfirm.ShowDialog() == DialogResult.OK)
            {
                Manual.Laser.ShutterClose();
                
                Auto.AutoThread.Enabled = false;
                Manual.ADV.ReadThread.Enabled = false;
                Manual.Light.ReadThread.Enabled = false;
                Manual.PowerMeter.MeasureThread.Enabled = false;

                await Task.Delay(100);

                Pmac.QueryCommand("doTowerLampBuzzer=false");
                Pmac.QueryCommand("doBeamShutterOpen=false");

                frmMVS.btnGrabStop_Click(null, null);
                frmMVS.btnDisconnect_Click(null, null);

                await Task.Delay(100);

                frmVision.exitConfirmed = true;
                frmVision.Vision1.exitConfirmed = true;
                frmVision.Vision2.exitConfirmed = true;
                frmVision.Finilization();

                await Task.Delay(100);

                Manual.ADV.Comm.CloseComm();
                Manual.Light.Comm.CloseComm();
                Manual.PowerMeter.Comm.CloseComm();

                await Task.Delay(100);

                Application.Exit();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
        }

        private void AutoThread_OnExecute(object sender, EventArgs e)
        {
            if (DateTime.Now.Date != currentDate.Date)
            {
                // 날짜가 변경되었으므로 Logger를 새로 초기화
                currentDate = DateTime.Now;

                String szStr = String.Format("{0}Log", yjCommon.AppPath());
                szStr = CreateDailyFolder(szStr);

                ChangeLogFilePath(szStr);
                Auto.ChangeLogFilePath(szStr);
                Auto.Table1.ChangeLogFilePath(szStr);
                Auto.Table2.ChangeLogFilePath(szStr);
                Auto.Vision1.ChangeLogFilePath(szStr);
                Auto.Vision2.ChangeLogFilePath(szStr);
                Manual.Motion.ChangeLogFilePath(szStr);
                SideMenu.ChangeLogFilePath(szStr);
                Manual.Laser.ChangeLogFilePath(szStr); 
                Manual.Light.ChangeLogFilePath(szStr);

                Pmac.ChangeLogFilePath(szStr);
            }
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void lblMainTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (yjCommon.IsCtrlKeyDown())
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    Location = new Point(Left - (mMousePoint.X - e.X), Top - (mMousePoint.Y - e.Y));
                }
            }
        }

        private void lblMainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (yjCommon.IsCtrlKeyDown())
            {
                mMousePoint = new Point(e.X, e.Y);
            }
        }

        public void SetBuildVersion()
        {
            lblBuildVersion.Text = "Build:20241203.001";
        }

        private void btnVision_Click(object sender, EventArgs e)
        {
            if (frmVision.Visible)
            {
                frmVision.Hide();
            }
            else
            {
                frmVision.Show();
            }
        }

        public void ButtonEnables(bool bEnable)
        {
            btnAuto.Enabled = bEnable;
            btnConfig.Enabled = bEnable;
            btnJobFile.Enabled = bEnable;
            btnManual.Enabled = bEnable;
            btnAlarm.Enabled = bEnable;
           // btnVision.Enabled = bEnable;
            btnLog.Enabled = bEnable;
            btnLogIn.Enabled = bEnable;
            btnExit.Enabled = bEnable;
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            strCulture = "en";
            ChangeLanguage("en");  // 영어로 변경
        }

        private void btnKorea_Click(object sender, EventArgs e)
        {
            strCulture = "ko";
            ChangeLanguage(strCulture);  // 한국어로 변경
        }

        private void btnVietnam_Click(object sender, EventArgs e)
        {
            strCulture = "vi";
            ChangeLanguage("vi");  // 한국어로 변경
        }

        // 언어 변경 메서드
        private void ChangeLanguage(string culture)
        {
            if (culture.ToLower() == "en")
            {
                ChangeLanguageEnglish();
            }
            else
            if (culture.ToLower() == "ko")
            {
                ChangeLanguageKorea();
            }
            if (culture.ToLower() == "vi")
            {
                ChangeLanguageVietnam();
            }
        }
        private void LoadLanguageFile()
        {
            //motionParameters.Clear();

            String szFileName = String.Format("{0}Config\\Language_English.ini", yjCommon.AppPath());

            Global.iniEng = new YujinTechnology.IniFile(szFileName);


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
            btnAuto.Text = Global.iniEng.ReadString("frmMain", "btnAuto.Text", "Auto");
            btnJobFile.Text = Global.iniEng.ReadString("frmMain", "btnJobFile.Text", "JobFile");
            btnManual.Text = Global.iniEng.ReadString("frmMain", "btnManual.Text", "Manual");
            btnConfig.Text = Global.iniEng.ReadString("frmMain", "btnConfig.Text", "Config");
            btnAlarm.Text = Global.iniEng.ReadString("frmMain", "btnAlarm.Text", "Alarm");
            btnVision.Text = Global.iniEng.ReadString("frmMain", "btnVision.Text", "Vision");
            btnLog.Text = Global.iniEng.ReadString("frmMain", "btnLog.Text", "Log");
            btnLogIn.Text = Global.iniEng.ReadString("frmMain", "btnLogIn.Text", "User");
            btnExit.Text = Global.iniEng.ReadString("frmMain", "btnExit.Text", "Exit");

            Auto.ChangeLanguageEnglish();
            Auto.Table1.ChangeLanguageEnglish();
            Auto.Table2.ChangeLanguageEnglish();
            Auto.Table1.JobInfo.Type1.ChangeLanguageEnglish();
            Auto.Table1.JobInfo.Type2.ChangeLanguageEnglish();
            Auto.Table1.JobInfo.Type3.ChangeLanguageEnglish();
            Auto.Table2.JobInfo.Type1.ChangeLanguageEnglish();
            Auto.Table2.JobInfo.Type2.ChangeLanguageEnglish();
            Auto.Table2.JobInfo.Type3.ChangeLanguageEnglish();

            JobFile.Table1.JobInfo.Type1.ChangeLanguageEnglish();
            JobFile.Table1.JobInfo.Type2.ChangeLanguageEnglish();
            JobFile.Table1.JobInfo.Type3.ChangeLanguageEnglish();
            JobFile.Table2.JobInfo.Type1.ChangeLanguageEnglish();
            JobFile.Table2.JobInfo.Type2.ChangeLanguageEnglish();
            JobFile.Table2.JobInfo.Type3.ChangeLanguageEnglish();

            SideMenu.ChangeLanguageEnglish();
            Config.Common.ChangeLanguageEnglish();
            frmVision.Vision1.ChangeLanguageEnglish();
            frmVision.Vision2.ChangeLanguageEnglish();
            Manual.Motion.ChangeLanguageEnglish();
            Manual.Laser.ChangeLanguageEnglish();
            Manual.Light.ChangeLanguageEnglish();
            Manual.ADV.ChangeLanguageEnglish();
            Manual.PowerMeter.ChangeLanguageEnglish();
            //panJobFile.Info.Type1.SetChangeLagEngData(INI, culture);
        }

        public void ChangeLanguageKorea()
        {
            // 섹션과 키를 사용하여 값 읽기            
            btnAuto.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnAuto.Text");
            btnJobFile.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnJobFile.Text");
            btnManual.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnManual.Text");
            btnConfig.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnConfig.Text");
            btnAlarm.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnAlarm.Text");
            btnVision.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnVision.Text");
            btnLog.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnLog.Text");
            btnLogIn.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnLogIn.Text");
            btnExit.Text = Global.GetIniLanguageValue(Global.iniKor, "frmMain", "btnExit.Text");

            Auto.ChangeLanguageKorea();
            Auto.Table1.ChangeLanguageKorea();
            Auto.Table2.ChangeLanguageKorea();
            Auto.Table1.JobInfo.Type1.ChangeLanguageKorea();
            Auto.Table1.JobInfo.Type2.ChangeLanguageKorea();
            Auto.Table1.JobInfo.Type3.ChangeLanguageKorea();
            Auto.Table2.JobInfo.Type1.ChangeLanguageKorea();
            Auto.Table2.JobInfo.Type2.ChangeLanguageKorea();
            Auto.Table2.JobInfo.Type3.ChangeLanguageKorea();

            JobFile.Table1.JobInfo.Type1.ChangeLanguageKorea();
            JobFile.Table1.JobInfo.Type2.ChangeLanguageKorea();
            JobFile.Table1.JobInfo.Type3.ChangeLanguageKorea();

            JobFile.Table2.JobInfo.Type1.ChangeLanguageKorea();
            JobFile.Table2.JobInfo.Type2.ChangeLanguageKorea();
            JobFile.Table2.JobInfo.Type3.ChangeLanguageKorea();

            SideMenu.ChangeLanguageKorea();
            Config.Common.ChangeLanguageKorea();
            Manual.Motion.ChangeLanguageKorea();
            Manual.Laser.ChangeLanguageKorea();
            Manual.Light.ChangeLanguageKorea();
            Manual.ADV.ChangeLanguageKorea();
            Manual.PowerMeter.ChangeLanguageKorea();
        }

        public void ChangeLanguageVietnam()
        {
            //// 섹션과 키를 사용하여 값 읽기
            btnAuto.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnAuto.Text");
            btnJobFile.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnJobFile.Text");
            btnManual.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnManual.Text");
            btnConfig.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnConfig.Text");
            btnAlarm.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnAlarm.Text");
            btnVision.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnVision.Text");
            btnLog.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnLog.Text");
            btnLogIn.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnLogIn.Text");
            btnExit.Text = Global.GetIniLanguageValue(Global.iniVie, "frmMain", "btnExit.Text");

            Auto.ChangeLanguageVietnam();
            Auto.Table1.ChangeLanguageVietnam();
            Auto.Table2.ChangeLanguageVietnam();
            Auto.Table1.JobInfo.Type1.ChangeLanguageVietnam();
            Auto.Table1.JobInfo.Type2.ChangeLanguageVietnam();
            Auto.Table1.JobInfo.Type3.ChangeLanguageVietnam();
            Auto.Table2.JobInfo.Type1.ChangeLanguageVietnam();
            Auto.Table2.JobInfo.Type2.ChangeLanguageVietnam();
            Auto.Table2.JobInfo.Type3.ChangeLanguageVietnam();

            JobFile.Table1.JobInfo.Type1.ChangeLanguageVietnam();
            JobFile.Table1.JobInfo.Type2.ChangeLanguageVietnam();
            JobFile.Table1.JobInfo.Type3.ChangeLanguageVietnam();
            JobFile.Table2.JobInfo.Type1.ChangeLanguageVietnam();
            JobFile.Table2.JobInfo.Type2.ChangeLanguageVietnam();
            JobFile.Table2.JobInfo.Type3.ChangeLanguageVietnam();

            SideMenu.ChangeLanguageVietnam();
            Config.Common.ChangeLanguageVietnam();
            Manual.Motion.ChangeLanguageVietnam();
            Manual.Laser.ChangeLanguageVietnam();
            Manual.Light.ChangeLanguageVietnam();
            Manual.ADV.ChangeLanguageVietnam();
            Manual.PowerMeter.ChangeLanguageVietnam();
        }
#endregion

        private void lblMainTitle_DoubleClick(object sender, EventArgs e)
        {
            if (yjCommon.IsCtrlKeyDown())
            {
                if (Screen.AllScreens.Length > 1)
                {
                    Screen firrstScreen = Screen.AllScreens[0];

                    StartPosition = FormStartPosition.Manual;
                    Location = firrstScreen.WorkingArea.Location;
                    Left = firrstScreen.WorkingArea.Left;
                    Top = firrstScreen.WorkingArea.Top;
                }

            }
        }
    }
}
