using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

using System.Security.Permissions;
using System.CodeDom;
using System.Linq;

using RestSharp;
using Raize.CodeSiteLogging;
using YujinTechnology;
using static LaserCutter.Advanced;

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

            Global.ChangeControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));

            logger.Category = "Control.Carbide";

            InitLaserStatus();
        }

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Manual.Laser";

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
            if (frmChannelSpy != null)
            {
                dsLaser.Channels.RemoveAll();

                using (Global.chLaserConnected = dsLaser.Channels.Add())
                {
                    Global.chLaserConnected.Category = "Carbide Laser";
                    Global.chLaserConnected.Kind = ChannelKind.Virtual;
                    Global.chLaserConnected.DataType = ChannelDataType.Boolean;
                    Global.chLaserConnected.Name = "Connected";
                }

                using (Global.chLaserDisConnected = dsLaser.Channels.Add())
                {
                    Global.chLaserDisConnected.Category = "Carbide Laser";
                    Global.chLaserDisConnected.Kind = ChannelKind.Virtual;
                    Global.chLaserDisConnected.DataType = ChannelDataType.Boolean;
                    Global.chLaserDisConnected.Name = "DisConnected";
                }

                using (Global.chLaserShutterOpen = dsLaser.Channels.Add())
                {
                    Global.chLaserShutterOpen.Category = "Carbide Laser";
                    Global.chLaserShutterOpen.Kind = ChannelKind.Virtual;
                    Global.chLaserShutterOpen.DataType = ChannelDataType.Boolean;
                    Global.chLaserShutterOpen.Name = "ShutterOpen";
                }

                using (Global.chLaserShutterClose = dsLaser.Channels.Add())
                {
                    Global.chLaserShutterClose.Category = "Carbide Laser";
                    Global.chLaserShutterClose.Kind = ChannelKind.Virtual;
                    Global.chLaserShutterClose.DataType = ChannelDataType.Boolean;
                    Global.chLaserShutterClose.Name = "ShutterClose";
                }

                using (Global.chLaserChillerOn = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerOn.Category = "Carbide Laser";
                    Global.chLaserChillerOn.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerOn.DataType = ChannelDataType.Boolean;
                    Global.chLaserChillerOn.Name = "ChillerOn";
                }

                using (Global.chLaserChillerOff = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerOff.Category = "Carbide Laser";
                    Global.chLaserChillerOff.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerOff.DataType = ChannelDataType.Boolean;
                    Global.chLaserChillerOff.Name = "ChillerOff";
                }

                using (Global.chLaserPower = dsLaser.Channels.Add())
                {
                    Global.chLaserPower.Category = "Carbide Laser";
                    Global.chLaserPower.Kind = ChannelKind.Virtual;
                    Global.chLaserPower.DataType = ChannelDataType.Double;
                    Global.chLaserPower.Name = "LaserPower";
                }
                
                using (Global.chLaserFreq = dsLaser.Channels.Add())
                {
                    Global.chLaserFreq.Category = "Carbide Laser";
                    Global.chLaserFreq.Kind = ChannelKind.Virtual;
                    Global.chLaserFreq.DataType = ChannelDataType.Double;
                    Global.chLaserFreq.Name = "LaserFreq";
                }

                using (Global.chLaserAttenuator = dsLaser.Channels.Add())
                {
                    Global.chLaserAttenuator.Category = "Carbide Laser";
                    Global.chLaserAttenuator.Kind = ChannelKind.Virtual;
                    Global.chLaserAttenuator.DataType = ChannelDataType.Double;
                    Global.chLaserAttenuator.Name = "LaserAttenuator";
                }

                using (Global.chLaserPPDivider = dsLaser.Channels.Add())
                {
                    Global.chLaserPPDivider.Category = "Carbide Laser";
                    Global.chLaserPPDivider.Kind = ChannelKind.Virtual;
                    Global.chLaserPPDivider.DataType = ChannelDataType.Integer;
                    Global.chLaserPPDivider.Name = "LaserPPDivider";
                }

                using (Global.chLaserBurstControlN = dsLaser.Channels.Add())
                {
                    Global.chLaserBurstControlN.Category = "Carbide Laser";
                    Global.chLaserBurstControlN.Kind = ChannelKind.Virtual;
                    Global.chLaserBurstControlN.DataType = ChannelDataType.Integer;
                    Global.chLaserBurstControlN.Name = "LaserBurstControlN";
                }

                using (Global.chLaserBurstControlP = dsLaser.Channels.Add())
                {
                    Global.chLaserBurstControlP.Category = "Carbide Laser";
                    Global.chLaserBurstControlP.Kind = ChannelKind.Virtual;
                    Global.chLaserBurstControlP.DataType = ChannelDataType.Integer;
                    Global.chLaserBurstControlP.Name = "LaserBurstControlP";
                }

                using (Global.chLaserActualEnvelopeParameterN = dsLaser.Channels.Add())
                {
                    Global.chLaserActualEnvelopeParameterN.Category = "Carbide Laser";
                    Global.chLaserActualEnvelopeParameterN.Kind = ChannelKind.Virtual;
                    Global.chLaserActualEnvelopeParameterN.DataType = ChannelDataType.Double;
                    Global.chLaserActualEnvelopeParameterN.Name = "ActualEnvelopeParameterN";
                }

                using (Global.chLaserActualEnvelopeParameterP = dsLaser.Channels.Add())
                {
                    Global.chLaserActualEnvelopeParameterP.Category = "Carbide Laser";
                    Global.chLaserActualEnvelopeParameterP.Kind = ChannelKind.Virtual;
                    Global.chLaserActualEnvelopeParameterP.DataType = ChannelDataType.Double;
                    Global.chLaserActualEnvelopeParameterP.Name = "ActualEnvelopeParameterP";
                }

                frmChannelSpy.propGridLaser.DataServer = dsLaser;
                frmChannelSpy.propGridLaser.Active = true;
            }
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

                yjCommon.Warning(szMsg, Global.MESSAGE_BOX_TITLE);
            }
        }
        #endregion

        public async void InitLaserStatus()
        {
#if _CARBIDE
            frmCarbide.Basic.ReadAsync();

            await Task.Delay(40);
            frmCarbide.Advanced.ReadAsync();

            await Task.Delay(40);
            frmCarbide.Burst.ReadAsync();

            await Task.Delay(40);
            frmCarbide.StretcherCompressor.ReadAsync();

            await Task.Delay(40);
            frmCarbide.Chiller.ReadAsync();

            await Task.Delay(40);
            frmCarbide.ExternalControl.ReadAsync();

            ReadPresets();
            //frmCarbide.
            GetTargetBurstEnvelopeParameterN();
            GetChillerTargetTemp();
            GetShutterState();
            GetTagetAttenuator();
            GetTagetPpDivider();
            GetTagetBurstControl();
            GetTagetPulseDuration();
            External_GetTriggerSource();
            GetBurstEnvelopeParameterN();
#endif
        }

        public void btnConnectLaser_Click(object sender, EventArgs e)
        {
            btnConnect.LED.Value = true;
            btnDisconnect.LED.Value = false;

            frmCarbide.Connect();

            ReadThread.Enabled = btnConnect.LED.Value;
        }
 
        private void UpdateLaserStatus()
        {
#if _CARBIDE

            string strStatus;

            if ((frmCarbide.Basic != null) && (frmCarbide.Basic.ActualStateName != null))
            {
                if (frmCarbide.Basic.ActualStateName.Equals("Initializing", StringComparison.OrdinalIgnoreCase))
                {
                    ;
                } 
                else
                if (frmCarbide.Basic.ActualStateName.Equals("Service", StringComparison.OrdinalIgnoreCase))
                {
                    ;
                }
                else
                if (frmCarbide.Basic.ActualStateName.Equals("InFieldUpdate", StringComparison.OrdinalIgnoreCase))
                {
                    ;
                }
                else
                if (frmCarbide.Basic.ActualStateName.Equals("StandingBy", StringComparison.OrdinalIgnoreCase))
                {
                    lblLaserStatus.Text = "Standing By";
                    lblLaserStatus.BackColor = Color.Gray;
                }
                else 
                if (frmCarbide.Basic.ActualStateName.Equals("GoingToStandby", StringComparison.OrdinalIgnoreCase))
                {
                    lblLaserStatus.Text = "Going To Stand By...";
                    lblLaserStatus.BackColor = Color.Orange;
                }
                else 
                if (frmCarbide.Basic.ActualStateName.Equals("Failure", StringComparison.OrdinalIgnoreCase))
                {
                    lblLaserStatus.Text = "Failure";
                    lblLaserStatus.BackColor = Color.Red;

                    Global.LaserError = true;
                }
                else 
                if (frmCarbide.Basic.ActualStateName.Equals("Housekeeping", StringComparison.OrdinalIgnoreCase))
                {
                    strStatus = string.Format("Housekeeping...\r\n {0}", frmCarbide.Basic.GeneralStatus);
                    lblLaserStatus.Text = strStatus;// "Housekeeping...";
                    lblLaserStatus.BackColor = Color.Orange;
                    lblLaserStatus.ForeColor = Color.White;
                }
                else 
                if (frmCarbide.Basic.ActualStateName.Equals("Operational", StringComparison.OrdinalIgnoreCase))
                {
                    lblLaserStatus.Text = "Operational";
                    lblLaserStatus.BackColor = Color.Green;
                    lblLaserStatus.ForeColor = Color.White;

                    Global.LaserError = false;
                }

                Auto.lblLaserStatus.Text = lblLaserStatus.Text;
                Auto.lblLaserStatus.BackColor = lblLaserStatus.BackColor;
                Auto.lblLaserStatus.ForeColor = Color.White;
            }

            if (frmCarbide.Basic.IsEmissionWarningActive)
            {
                lblEmissionStatus.Text = "Emission Warning";
                lblEmissionStatus.BackColor = Color.Orange;
            }
            else
            {
                lblEmissionStatus.Text = "No Emission";
                lblEmissionStatus.BackColor = Color.Gray;
            }

            Auto.lblEmissionStatus.Text = lblEmissionStatus.Text;
            Auto.lblEmissionStatus.BackColor = lblEmissionStatus.BackColor;

            if ((frmCarbide.Basic != null) && (frmCarbide.Basic.ActualShutterState != null))
            {
                if (frmCarbide.Basic.ActualShutterState.Equals("Opened", StringComparison.OrdinalIgnoreCase))
                {
                    lblShutterStatus.Text = "Shutter Opened";
                    lblShutterStatus.BackColor = Color.Orange;
                }
                else
                {
                    lblShutterStatus.Text = "Shutter Closed";
                    lblShutterStatus.BackColor = Color.Gray;
                }

                Auto.lblShutterStatus.Text = lblShutterStatus.Text;
                Auto.lblShutterStatus.BackColor = lblShutterStatus.BackColor;
            }

            Global.chLaserPower.AsDouble = frmCarbide.Basic.ActualOutputPower;
            Global.chLaserFreq.AsDouble = frmCarbide.Basic.ActualOutputFrequency;
            Global.chLaserAttenuator.AsDouble = frmCarbide.Basic.ActualAttenuatorPercentage;
            Global.chLaserPPDivider.AsInteger = frmCarbide.Basic.ActualPpDivider;
            Global.chLaserBurstControlN.AsInteger = frmCarbide.Burst.ActualParameterN.ToInt();
            Global.chLaserBurstControlP.AsInteger = frmCarbide.Burst.ActualParameterP.ToInt();
            Global.chLaserActualEnvelopeParameterN.AsDouble = frmCarbide.Burst.ActualEnvelopeParameterN.ToDouble();
            Global.chLaserActualEnvelopeParameterP.AsDouble = frmCarbide.Burst.ActualEnvelopeParameterP.ToDouble();

            if (frmCarbide.Basic.ActualPulseDuration < 0)
            {
                strStatus = string.Format("Pulse duration {0:F1}fs(negative chirp)", Math.Abs(frmCarbide.Basic.ActualPulseDuration));
            }
            else
            {
                strStatus = string.Format("Pulse duration {0:F1}fs(positive chirp)", Math.Abs(frmCarbide.Basic.ActualPulseDuration));
            }

            GetShutterState();
            GetBurstEnvelopeParameterN();
            lbCurrentPulseDuration.Text = strStatus; 
            if(frmCarbide.Advanced.PresetList != null)
            {
                frmCarbide.Advanced.PresetList = frmCarbide.Advanced.ReadPresets("Presets");
                if (frmCarbide.Advanced.PresetList.Count > 0)
                {
                    int nIndex = frmCarbide.Basic.SelectedPresetIndex;
                    var Preset = frmCarbide.Advanced.PresetList[nIndex];
                    lblCurLaserParam.Text = Preset.Name;
                }
            }
            else
            {
                int nIndex = frmCarbide.Basic.SelectedPresetIndex;
                if ((nIndex >= 0) && (nIndex < cbLaserSet.Items.Count))
                {
                    lblCurLaserParam.Text = cbLaserSet.Items[nIndex].ToString();
                    Auto.lblLaserSet.Text = lblCurLaserParam.Text;
                }
            }
#else
            /*lblLaserStatus.Text = "Operational";
            lblLaserStatus.BackColor = Color.Green;
            lblLaserStatus.ForeColor = Color.White;

            Auto.lblLaserStatus.Text = lblLaserStatus.Text;
            Auto.lblLaserStatus.BackColor = lblLaserStatus.BackColor;
            Auto.lblLaserStatus.ForeColor = Color.White;

            lblEmissionStatus.Text = "Emission Warning";
            lblEmissionStatus.BackColor = Color.Orange;

            Auto.lblEmissionStatus.Text = lblEmissionStatus.Text;
            Auto.lblEmissionStatus.BackColor = lblEmissionStatus.BackColor;

            lblShutterStatus.Text = "Shutter Opened";
            lblShutterStatus.BackColor = Color.Orange;

            Auto.lblShutterStatus.Text = lblShutterStatus.Text;
            Auto.lblShutterStatus.BackColor = lblShutterStatus.BackColor;

            btnShutterOpen.LED.Value = true;
            btnExternalHigh.LED.Value = true;

            lbChillerStatus.ForeColor = System.Drawing.Color.Green;
            lbChillerStatus.Text = string.Format("Chiller Turn ON 24℃");
            btnchillerOn.LED.Value = true;*/

#endif
        }

        private void ReadChillerStatus()
        {
            frmCarbide.Chiller.Read();
        }

        public void btnShutterOpen_Click(object sender, EventArgs e)
        {
            ShutterOpen();
        }
        public void ShutterOpen()
        {
#if _CARBIDE
            frmCarbide.Basic.ShutterOpen();
#endif
        }

        public void btnShutterClose_Click(object sender, EventArgs e)
        {
            ShutterClose();
        }

        public void ShutterClose()
        {
#if _CARBIDE
            frmCarbide.Basic.ShutterClose();
#endif
        }

        private void btnchillerOn_Click(object sender, EventArgs e)
        {
            frmCarbide.Chiller.TurnOn();
            btnchillerOn.LED.Value = true;
            btnChillerOff.LED.Value = false;
        }
        private void UpdateChillerStatus()
        {
            string strStauts;
            {
                double dActualTemp = frmCarbide.Chiller.ActualTemperature;
                double dTargetlTemp = frmCarbide.Chiller.TargetTemperature;

                strStauts = string.Format("Chiller is {0} {1}℃", frmCarbide.Chiller.IsOn ? "Chiller Turn ON" : "Chiller Turn OFF", dActualTemp);
                lbChillerStatus.Text = strStauts;//isOutputEnabled ? "Chiller Turn ON" : "Chiller Turn OFF";
                lbChillerStatus.ForeColor = frmCarbide.Chiller.IsOn ? System.Drawing.Color.Green : System.Drawing.Color.Red;

                Global.chLaserChillerOn.Value = frmCarbide.Chiller.IsOn;
                Global.chLaserChillerOff.Value = !frmCarbide.Chiller.IsOn;
            }
        }

        private void btnChillerOff_Click(object sender, EventArgs e)
        {
            frmCarbide.Chiller.TurnOff();
            btnchillerOn.LED.Value = false;
            btnChillerOff.LED.Value = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            frmCarbide.Basic.SetSelectedPresetIndex(cbLaserSet.SelectedIndex);
            frmCarbide.Basic.ApplySelectedPreset();
        }

        private void btnStandBy_Click(object sender, EventArgs e)
        {
            frmCarbide.Basic.Standby();
        }

        private void btnPulseduration_Click(object sender, EventArgs e)
        {
            if (switchChirp.Active)
            {
                frmCarbide.Basic.SetTargetPulseDuration(-edPulseduration.Value);
            }
            else
            {
                frmCarbide.Basic.SetTargetPulseDuration(edPulseduration.Value);
            }
        }

        private void btnChillerTempSet_Click(object sender, EventArgs e)
        {
            frmCarbide.Chiller.SetTargetTemperature(edTargetTemp.Value);
        }

        private void btnBurstEnvelopeControlN_Click(object sender, EventArgs e)
        {
            frmCarbide.Burst.SetTargetEnvelopeParameterN(edBurstEnvelopeControlN.Value);
        }

        private void btnSetAttenuator_Click(object sender, EventArgs e)
        {
            SetAttenuator(edAttenuator.Value);
        }
        public void SetAttenuator(double dAttenuator)
        {
            frmCarbide.Basic.SetTargetAttenuatorPercentage(dAttenuator);
        }

        private void btnPPDivider_Click(object sender, EventArgs e)
        {
            frmCarbide.Basic.SetTargetPpDivider(edPPDivider.AsInteger);
        }

        private void btnBurstControl_Click(object sender, EventArgs e)
        {
            frmCarbide.Burst.SetTargetParameterN(edBurstControlN.Value);
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
        }

        private void tmr_LaserStatus_Tick(object sender, EventArgs e)
        {
//#if _CARBIDE
            UpdateLaserStatus();
#if _CARBIDE
            UpdateChillerStatus();

#endif
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmCarbide.StretcherCompressor.Read();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCarbide.ExternalControl.Read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCarbide.Advanced.Read();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCarbide.Chiller.Read();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCarbide.Chiller.TurnOn();
        }

        private void ReadThread_OnExecute(object sender, EventArgs e)
        {
#if _CARBIDE
            switch (nIndex)
            {
                case 0:
                    frmCarbide.Basic.ReadAsync();
                    Counter.Start();
                    nIndex = 5;
                    
                    break;

                case 5:
                    if (!frmCarbide.Basic.waitFlag)
                    {
                        Counter.Stop();
                        nIndex = 10;
                    }
                    else 
                    if (Counter.isTimeOver(1000)) // Motor 기동 시간 < Sys.Time)
                    {
                        Counter.Stop();
                        nIndex = 10;
                    }   
                    break;

                case 10:
                    frmCarbide.Burst.ReadAsync();
                    Counter.Start();
                    nIndex = 15;
                    break;
                
                case 15:
                    if (!frmCarbide.Burst.waitFlag)
                    {
                        Counter.Stop();
                        nIndex = 20;
                    }                        
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                        nIndex = 20;
                    } 
                    break;

                case 20:
                    frmCarbide.ExternalControl.ReadAsync();
                    Counter.Start();
                    nIndex = 25;
                    break;

                case 25:
                    if (!frmCarbide.ExternalControl.waitFlag)
                    {
                        Counter.Stop();
                        nIndex = 30;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                        nIndex = 30;
                    }
                    break;

                case 30:
                    frmCarbide.Advanced.ReadAsync();
                    Counter.Start();
                    nIndex = 35;
                    break;

                case 35:
                    if (!frmCarbide.Advanced.waitFlag)
                    {
                        Counter.Stop();
                        nIndex = 40;
                    }                        
                    else 
                    if(Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                        nIndex = 40;
                    }
                    break;

                case 40:
                    frmCarbide.StretcherCompressor.ReadAsync();
                    Counter.Start();
                    nIndex = 45;
                    break;

                case 45:
                    if (!frmCarbide.StretcherCompressor.waitFlag)
                    {
                        Counter.Stop();
                        nIndex = 50;
                    }                        
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                        nIndex = 50;
                    }
                    break;
                case 50:
                    frmCarbide.Chiller.ReadAsync();
                    Counter.Start();
                    nIndex = 55;
                    break;

                case 55:
                    if (!frmCarbide.StretcherCompressor.waitFlag)
                    {
                        Counter.Stop();
                        nIndex = 60;
                    }                        
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                        nIndex = 60;
                    }
                    break;
                case 60:
                    Burst_GetBurstControl();
                    nIndex = 70; 
                    break;

                case 70:
                    //ParsingCrtStatus();
                    nIndex = 80;
                    break;

                case 80:
                    Chiller_GetChillerTemp();
                    nIndex = 90;
                    break;

                case 90:
                    Chiller_GetChillerStatus();
                    nIndex = 100;
                    break;

                case 100:
                    GetShutterState();
                    nIndex = 120;
                    break;

                case 120:
                    External_GetTriggerSource();
                    nIndex = 0;
                    break;
                    
            }
#endif
        }
        private void GetPower()
        {
            string strValue = frmCarbide.Basic.Read("ActualOutputPower");
            frmCarbide.Basic.ActualOutputPower = yjCommon.StrToDoubleDef(strValue, 0.0);
        }

        private void GetShutterState()
        {
            btnShutterOpen.LED.Value = frmCarbide.Basic.IsOutputEnabled;
            btnShutterClose.LED.Value = !frmCarbide.Basic.IsOutputEnabled;
        }    

        private void GetBurstEnvelopeParameterN()
        {
            if (Global.chLaserActualEnvelopeParameterN != null)
            {
                Global.chLaserActualEnvelopeParameterN.AsDouble = yjCommon.StrToDoubleDef(frmCarbide.Burst.ActualEnvelopeParameterN, 0.0);
            }
        }

        private void GetTargetBurstEnvelopeParameterN()
        {
            edBurstEnvelopeControlN.Value = yjCommon.StrToDoubleDef(frmCarbide.Burst.TargetEnvelopeParameterN, 0.0); 
        }


        private void GetAttenuator()
        {
            string strValue = frmCarbide.Basic.Read("ActualAttenuatorPercentage");
            frmCarbide.Basic.ActualAttenuatorPercentage = yjCommon.StrToDoubleDef(strValue, 0.0);
        }

        //chLaserFreq
        private void GetFreq()
        {
            string strValue = frmCarbide.Basic.Read("ActualOutputFrequency");
            frmCarbide.Basic.ActualOutputFrequency = yjCommon.StrToDoubleDef(strValue, 0.0);
        }

        private void GetPPDivider()
        {
            string strValue = frmCarbide.Basic.Read("ActualPpDivider");
            frmCarbide.Basic.ActualPpDivider = yjCommon.StrToIntDef(strValue, 0);
        }

        private void Burst_GetBurstControl()
        {
            string strValue = frmCarbide.Burst.Read("ActualParameterN");//frmCarbide.Basic.Read("ActualBurstPulseCount");
            frmCarbide.Burst.ActualParameterN = strValue;
        }

        private void GetActualStateName()
        {
            string strValue = frmCarbide.Basic.Read("ActualStateName");
            frmCarbide.Basic.ActualStateName = strValue;
        }

        private void GetActualPulseDuration()
        {
            string strValue;
            strValue = frmCarbide.Basic.Read("ActualPulseDuration");
            frmCarbide.Basic.ActualPulseDuration = yjCommon.StrToDoubleDef(strValue, 0.0);           
        }

        private void Chiller_GetChillerTemp()
        {
            string strValue = frmCarbide.Chiller.Read("ActualTemperature");
            frmCarbide.Chiller.ActualTemperature = yjCommon.StrToDoubleDef(strValue, 0.0);            
        }

        private void GetChillerTargetTemp()
        {
            string strValue = frmCarbide.Chiller.Read("TargetTemperature");
            frmCarbide.Chiller.TargetTemperature = yjCommon.StrToDoubleDef(strValue, 0.0); 
            edTargetTemp.Value = yjCommon.StrToDoubleDef(strValue, 0.0);
        }

        private void Chiller_GetChillerStatus()
        {
            string strValue = frmCarbide.Chiller.Read("IsOn");
            frmCarbide.Chiller.IsOn = yjCommon.StrToIntDef(strValue, 0) == 1;  // yhbyun 나중에 값이 맞게 들어오는지 확인할것.
        }

        private void GetTagetAttenuator()
        {
            string strValue = frmCarbide.Basic.Read("TargetAttenuatorPercentage");
            frmCarbide.Basic.TargetAttenuatorPercentage = yjCommon.StrToDoubleDef(strValue, 0.0);
            edAttenuator.Value = yjCommon.StrToDoubleDef(strValue, 0.0);
        }

        private void GetIsEmissionWarning()
        {
            string strValue = frmCarbide.Basic.Read("IsEmissionWarningActive");
            if (strValue == "False")
                frmCarbide.Basic.IsEmissionWarningActive = false;
            else
                frmCarbide.Basic.IsEmissionWarningActive = true;
        }

        private void GetTagetPpDivider()
        {
            string strValue = frmCarbide.Basic.Read("TargetPpDivider");
            frmCarbide.Basic.TargetPpDivider = yjCommon.StrToIntDef(strValue, 0);
            edPPDivider.AsInteger = yjCommon.StrToIntDef(strValue, 0);
        }
        private void GetTagetBurstControl()
        {
            string strValue = frmCarbide.Burst.Read("TargetParameterN");
            edBurstControlN.AsInteger = yjCommon.StrToIntDef(frmCarbide.Burst.TargetParameterN, 0);
            
        }
        private void GetTargetEnvelopeParameterN()
        {
            string strValue = frmCarbide.Burst.Read("TargetParameterN");
            frmCarbide.Basic.TargetBurstPulseCount = yjCommon.StrToIntDef(strValue, 0);
            edBurstControlN.AsInteger = yjCommon.StrToIntDef(strValue, 0);
        }

        private void GetTagetPulseDuration()
        {
            string strValue = frmCarbide.Basic.Read("TargetPulseDuration");
            frmCarbide.Basic.TargetPulseDuration = yjCommon.StrToDoubleDef(strValue, 0.0);
            edPulseduration.Text = string.Format("{0:F1}", Math.Abs(frmCarbide.Basic.TargetPulseDuration)); 

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
            frmCarbide.ExternalControl.SetTriggerSource("Internal");
        }

        private void btnExternalLow_Click(object sender, EventArgs e)
        {
            frmCarbide.ExternalControl.SetTriggerSource("ExternalLow");
        }

        private void btnExternalHigh_Click(object sender, EventArgs e)
        {
            frmCarbide.ExternalControl.SetTriggerSource("ExternalHigh");
        }

        private void External_GetTriggerSource()
        {
            string strValue;
            strValue = frmCarbide.ExternalControl.Read("AomTriggerSource");
            frmCarbide.ExternalControl.AomTriggerSource = strValue;

            btnInternal.LED.Value = (strValue == "Internal");
            btnExternalLow.LED.Value = (strValue == "ExternalLow");
            btnExternalHigh.LED.Value = (strValue == "ExternalHigh");
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
            frmCarbide.Burst.SetTargetEnvelopeParameterP(edBurstEnvelopeControlP.Value);
        }

        private void btnBurstControlP_Click(object sender, EventArgs e)
        {
            frmCarbide.Burst.SetTargetParameterP(edBurstControlP.Value);
        }

        public bool isLaserOn()
        {
            return frmCarbide.Basic.IsEmissionWarningActive;
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
