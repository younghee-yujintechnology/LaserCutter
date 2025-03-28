using System;
using System.Windows.Forms;

using RestSharp;
using Raize.CodeSiteLogging;
using DaekhonSystem;

namespace LaserCutter
{
    public partial class panManualCarbide : UserControl, IDisposable
    {
        CodeSiteLogger logger;
        
        private frmChannelSpy frmChannelSpy;
        private frmCarbide frmCarbide;
        private panManual panControl;
        public panAuto Auto;

        public int mStep = 0;
        public int LastStep = 0;
        public int ErrorCode = 0;

    #region <<< Command & CurrentStep >>>
        private Command mCommand;
        private Command mOldCommand;
        private int mCurrentStep;

        public bool ShowStep = false;
        public bool ShowCommand = false;
    #endregion

#if _CARBIDE
        int nIndex = 0;
        TimeCounter Counter = new TimeCounter();
#endif

        public panManualCarbide(panManual _panControl)
        {
            InitializeComponent();

            SetCodeSitelogger();

            frmChannelSpy = frmChannelSpy.StaticInstance;
            frmCarbide = frmCarbide.StaticInstance;

            panControl = _panControl;
            frmCarbide.Connect();

            logger.Category = "Control.Carbide";

            InitLaserStatus();
        }

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Manual.Laser";

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = dkCommon.AppPath();
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

        #region <<< Command & CurrentStep >>>
        public Command Command
        {
            get
            {
                return mCommand;
            }

            set
            {
                if (mCommand != value)
                {
                    ShowStep = false;
                    CurrentStep = 0;
                    ShowStep = true;

                    mOldCommand = Command;
                    mCommand = value;

                    String szStr;
                    if (ShowCommand)
                    {
                        if (value == Command.Stop)
                        {

                        }
                        else
                        if (value == Command.None)
                        {

                        }

                        logger.AddSeparator();

                        if (value == Command.Stop)
                        {
                            szStr = String.Format("Command = {0} -> {1}", mOldCommand.ToString(), Command.ToString());

                            logger.SendMsg(szStr);
                        }
                        else
                        if (value == Command.None)
                        {
                            szStr = String.Format("Command = {0} -> {1}", mOldCommand.ToString(), Command.ToString());

                            logger.SendMsg(szStr);
                        }
                        else
                        {
                            szStr = String.Format("Command = {0} -> {1}", mOldCommand.ToString(), Command.ToString());

                            logger.EnterMethod(szStr);
                        }
                    }
                }
            }
        }

        public int CurrentStep
        {
            get
            {
                return mCurrentStep;
            }

            set
            {
                if (mCurrentStep != value)
                {
                    mCurrentStep = value;

                    if (ShowStep)
                    {
                        String szStr;

                        if (value == Const.CASE_DONE)
                        {
                            szStr = String.Format("        CurrentStep = CASE_DONE");

                        }
                        else
                        if (value == Const.CASE_ERROR)
                        {
                            szStr = String.Format("        CurrentStep = CASE_ERROR");

                        }
                        else
                        if (value == Const.CASE_ABORT)
                        {
                            szStr = String.Format("        CurrentStep = CASE_ABORT");

                        }
                        else
                        {
                            szStr = String.Format("        CurrentStep = {0}", mCurrentStep);
                        }

                        logger.SendMsg(szStr);
                    }

                    if (ShowCommand && ShowStep)
                    {
                        if (CurrentStep == Const.CASE_ABORT)
                        {
                            String szStr = String.Format("Command = {0}", Command.ToString());
                            logger.ExitMethod(szStr);
                        }
                        else
                        if (CurrentStep == Const.CASE_DONE)
                        {
                            String szStr = String.Format("Command = {0}", Command.ToString());
                            logger.ExitMethod(szStr);
                        }
                        else
                        if (CurrentStep == Const.CASE_ERROR)
                        {
                            String szStr = String.Format("Command = {0}", Command.ToString());
                            logger.ExitMethod(szStr);
                        }
                    }
                }
            }
        }
        #endregion

        #region public void ChannelAssign()
        public void ChannelAssign()
        {
#if _CARBIDE
            SetDataServer(this.Controls);

            btnConnect.ChannelName = "Connected";
            btnDisconnect.ChannelName = "DisConnected";
            btnShutterOpen.ChannelName = "ShutterOpen";
            btnShutterClose.ChannelName = "ShutterClose";
            btnchillerOn.ChannelName = "ChillerOn";
            btnChillerOff.ChannelName = "ChillerOff";

            viPower.ChannelName = "LaserPower";
            viFrequency.ChannelName = "LaserFreq";
            viAttenuator.ChannelName = "LaserAttenuator";
            viPPDivider.ChannelName = "LaserPPDivider";

            viBurstControlN.ChannelName = "LaserBurstControlN";
            viBurstEnvelopeControlN.ChannelName = "ActualEnvelopeParameterN";

            viBurstControlP.ChannelName = "LaserBurstControlP";
            viBurstEnvelopeControlP.ChannelName = "ActualEnvelopeParameterP";

            // LoadChannelInfo()에서 이미 할당했는데..?
            // 이것을 해야 하나..??
            Global.chLaserConnected = dsLaser.Channels.Find(btnConnect.ChannelName);
            Global.chLaserDisConnected = dsLaser.Channels.Find(btnDisconnect.ChannelName);
            Global.chLaserShutterOpen = dsLaser.Channels.Find(btnShutterOpen.ChannelName);
            Global.chLaserShutterClose = dsLaser.Channels.Find(btnShutterClose.ChannelName);
            Global.chLaserChillerOn = dsLaser.Channels.Find(btnchillerOn.ChannelName);
            Global.chLaserChillerOff = dsLaser.Channels.Find(btnChillerOff.ChannelName);

            Global.chLaserPower = dsLaser.Channels.Find(viPower.ChannelName);
            Global.chLaserFreq = dsLaser.Channels.Find(viFrequency.ChannelName);
            Global.chLaserAttenuator = dsLaser.Channels.Find(viAttenuator.ChannelName);
            Global.chLaserPPDivider = dsLaser.Channels.Find(viPPDivider.ChannelName);
            Global.chLaserBurstControlN = dsLaser.Channels.Find(viBurstControlN.ChannelName);
            Global.chLaserActualEnvelopeParameterN = dsLaser.Channels.Find(viBurstEnvelopeControlN.ChannelName);
            Global.chLaserBurstControlP = dsLaser.Channels.Find(viBurstControlP.ChannelName);
            Global.chLaserActualEnvelopeParameterP = dsLaser.Channels.Find(viBurstEnvelopeControlP.ChannelName);
#endif
        }
#endregion

        #region public void LoadChannelInfo()
        public void LoadChannelInfo()
        {

        }
        #endregion

        #region public void SetDataServer(Control.ControlCollection controls)
        public void SetDataServer(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is LEDLabel)
                {
                    ((LEDLabel)control).DataServer = dsLaser;
                }
                else
                if (control is ValueIndicator)
                {
                    ((ValueIndicator)control).DataServer = dsLaser;
                }
                else
                if (control is LEDButton)
                {
                    ((LEDButton)control).DataServer = dsLaser;
                }

                if (control.HasChildren)
                {
                    SetDataServer(control.Controls);
                }
            }
        }
        #endregion

        #region private void dataServer1_OnError(object sender, int code, string channelName, Channel channel)
        private void dataServer1_OnError(object sender, int code, string channelName, Channel channel)
        {
            var dataServer = sender as DataServer;
            if (dataServer != null)
            {
                string szName = "Laser.dataServer1"; //dataServer.Name;
                //szName = "Laser.dataServer1"; // dataServer의 이름을 가져올수 없음..

                String szMsg;
                szMsg = String.Format("(DataServer.Name = {0} : {1})", szName, channelName);

                switch (code)
                {
                    case Channel.ERR_DIFFERENT_CHANNELTYPE:
                        szMsg = String.Format("Different Channel Type {0}", szMsg);
                        break;

                    case Channel.ERR_NON_EXIST_CHANNEL:
                        szMsg = String.Format("The channel does not exist {0}", szMsg);
                        break;
                }

                dkCommon.Warning(szMsg, Global.MESSAGE_BOX_TITLE);
            }
        }
        #endregion

        public async void InitLaserStatus()
        {

        }

        public void btnConnectLaser_Click(object sender, EventArgs e)
        {
        }
 
        private void UpdateLaserStatus()
        {

        }

        private void ReadChillerStatus()
        {
        }

        public void btnShutterOpen_Click(object sender, EventArgs e)
        {
        }
        public void ShutterOpen()
        {
        }

        public void btnShutterClose_Click(object sender, EventArgs e)
        {
        }

        public void ShutterClose()
        {
        }

        private void btnchillerOn_Click(object sender, EventArgs e)
        {
        }
        private void UpdateChillerStatus()
        {
        }

        private void btnChillerOff_Click(object sender, EventArgs e)
        {
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
        }

        private void btnStandBy_Click(object sender, EventArgs e)
        {
        }

        private void btnPulseduration_Click(object sender, EventArgs e)
        {
        }

        private void btnChillerTempSet_Click(object sender, EventArgs e)
        {
        }

        private void btnBurstEnvelopeControlN_Click(object sender, EventArgs e)
        {
        }

        private void btnSetAttenuator_Click(object sender, EventArgs e)
        {
        }
        public void SetAttenuator(double dAttenuator)
        {
        }

        private void btnPPDivider_Click(object sender, EventArgs e)
        {
        }

        private void btnBurstControl_Click(object sender, EventArgs e)
        {
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
        }

        private void tmr_LaserStatus_Tick(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void ReadThread_OnExecute(object sender, EventArgs e)
        {

        }
        private void GetPower()
        {
        }

        private void GetShutterState()
        {
        }    

        private void GetBurstEnvelopeParameterN()
        {
        }

        private void GetTargetBurstEnvelopeParameterN()
        {
        }


        private void GetAttenuator()
        {
        }

        //chLaserFreq
        private void GetFreq()
        {
        }

        private void GetPPDivider()
        {
        }

        private void Burst_GetBurstControl()
        {
        }

        private void GetActualStateName()
        {
        }

        private void GetActualPulseDuration()
        {
        }

        private void Chiller_GetChillerTemp()
        {
        }

        private void GetChillerTargetTemp()
        {
        }

        private void Chiller_GetChillerStatus()
        {
        }

        private void GetTagetAttenuator()
        {
        }

        private void GetIsEmissionWarning()
        {
        }

        private void GetTagetPpDivider()
        {
        }
        private void GetTagetBurstControl()
        {
            
        }
        private void GetTargetEnvelopeParameterN()
        {
        }

        private void GetTagetPulseDuration()
        {

        }
        private void ReadPresets()
        {
            cbLaserSet.Items.Clear();
#if _CARBIDE
            frmCarbide.Advanced.PresetList = frmCarbide.Advanced.ReadPresets("Presets");

            foreach(var Preset in frmCarbide.Advanced.PresetList)
            {
                cbLaserSet.Items.Add(Preset.Name);
            }
#endif
        }

        private void switchChirp_Click(object sender, EventArgs e)
        {
            if (!switchChirp.Active)
            {
                switchChirp.Text = "Positive chirp";
            }
            else
            {
                switchChirp.Text = "Negative chirp";
            }
        } 

        private void btnInternal_Click(object sender, EventArgs e)
        {
        }

        private void btnExternalLow_Click(object sender, EventArgs e)
        {
        }

        private void btnExternalHigh_Click(object sender, EventArgs e)
        {
        }

        private void External_GetTriggerSource()
        {
        }

        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnConnect.Text = Global.iniEng.ReadString("panManualCarbide", "btnConnect.Text", "Connect");
            btnDisconnect.Text = Global.iniEng.ReadString("panManualCarbide", "btnDisconnect.Text", "Disconnect");
            btnShutterOpen.Text = Global.iniEng.ReadString("panManualCarbide", "btnShutterOpen.Text", "Open");
            btnShutterClose.Text = Global.iniEng.ReadString("panManualCarbide", "btnShutterClose.Text", "Close");
            btnPulseduration.Text = Global.iniEng.ReadString("panManualCarbide", "btnPulseduration.Text", "Set");
            btnInternal.Text = Global.iniEng.ReadString("panManualCarbide", "btnInternal.Text", "Internal");
            btnExternalHigh.Text = Global.iniEng.ReadString("panManualCarbide", "btnExternalHigh.Text", "External");
            btnchillerOn.Text = Global.iniEng.ReadString("panManualCarbide", "btnchillerOn.Text", "Chiller On");
            btnChillerOff.Text = Global.iniEng.ReadString("panManualCarbide", "btnChillerOff.Text", "Chiller Off");
            btnChillerTempSet.Text = Global.iniEng.ReadString("panManualCarbide", "btnChillerTempSet.Text", "Set");
            btnSetAttenuator.Text = Global.iniEng.ReadString("panManualCarbide", "btnSetAttenuator.Text", "Set");
            btnPPDivider.Text = Global.iniEng.ReadString("panManualCarbide", "btnPPDivider.Text", "Set");
            btnBurstControlN.Text = Global.iniEng.ReadString("panManualCarbide", "btnBurstControl.Text", "Set");
            btnBurstEnvelopeControlN.Text = Global.iniEng.ReadString("panManualCarbide", "btnBurstEnvelopeControl.Text", "Set");
            btnApply.Text = Global.iniEng.ReadString("panManualCarbide", "btnApply.Text", "Apply");
            btnStandBy.Text = Global.iniEng.ReadString("panManualCarbide", "btnStandBy.Text", "StandBy");
            btnLogClear.Text = Global.iniEng.ReadString("panManualCarbide", "btnLogClear.Text", "Clear");
        }
        public void ChangeLanguageKorea()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnConnect.Text");
            btnDisconnect.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnDisconnect.Text");
            btnShutterOpen.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnShutterOpen.Text");
            btnShutterClose.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnShutterClose.Text");
            btnPulseduration.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnPulseduration.Text");
            btnInternal.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnInternal.Text");
            btnExternalHigh.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnExternalHigh.Text");
            btnchillerOn.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnchillerOn.Text");
            btnChillerOff.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnChillerOff.Text");
            btnChillerTempSet.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnChillerTempSet.Text");
            btnSetAttenuator.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnSetAttenuator.Text");
            btnPPDivider.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnPPDivider.Text");
            btnBurstControlN.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnBurstControl.Text");
            btnBurstEnvelopeControlN.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnBurstEnvelopeControl.Text");
            btnApply.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnApply.Text");
            btnStandBy.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnStandBy.Text");
            btnLogClear.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualCarbide", "btnLogClear.Text");
        }
        public void ChangeLanguageVietnam()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnConnect.Text");
            btnDisconnect.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnDisconnect.Text");
            btnShutterOpen.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnShutterOpen.Text");
            btnShutterClose.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnShutterClose.Text");
            btnPulseduration.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnPulseduration.Text");
            btnInternal.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnInternal.Text");
            btnExternalHigh.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnExternalHigh.Text");
            btnchillerOn.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnchillerOn.Text");
            btnChillerOff.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnChillerOff.Text");
            btnChillerTempSet.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnChillerTempSet.Text");
            btnSetAttenuator.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnSetAttenuator.Text");
            btnPPDivider.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnPPDivider.Text");
            btnBurstControlN.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnBurstControl.Text");
            btnBurstEnvelopeControlN.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnBurstEnvelopeControl.Text");
            btnApply.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnApply.Text");
            btnStandBy.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnStandBy.Text");
            btnLogClear.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualCarbide", "btnLogClear.Text");
        }
        #endregion

        private void btnBurstEnvelopeControlP_Click(object sender, EventArgs e)
        {
        }

        private void btnBurstControlP_Click(object sender, EventArgs e)
        {
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.LED.Value = false;
            btnDisconnect.LED.Value = true;

            frmCarbide.Disconnect();

            ReadThread.Enabled = btnConnect.LED.Value;
        }
    }
}
