using YujinTechnology;
using Newtonsoft.Json.Linq;
using Raize.CodeSiteLogging;
using System;
using System.Drawing;
using System.Reflection;
using System.Security.Claims;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LaserCutter
{
    public partial class panManualCoherent : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();
        
        private frmChannelSpy frmChannelSpy;
        private panManual panControl;
        public panAuto Auto;

        #region <<< Command & CurrentStep >>>
        private Command mCommand;
        private Command mOldCommand;
        private int mCurrentStep;

        public bool ShowStep = false;
        public bool ShowCommand = false;
        #endregion
        TimeCounter Counter = new TimeCounter();

        public bool bPulseEQMode;

        String receivedValue1;
        String receivedValue2;

        public panManualCoherent(panManual _panControl)
        {
            InitializeComponent();

            SetCodeSitelogger();

            frmChannelSpy = frmChannelSpy.StaticInstance;

            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));

            panControl = _panControl;
            bPulseEQMode = false;
            logger.Category = "Control.CoherentLaser";
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
            SetDataServer(this.Controls);

            #region Display Set
            btnConnect.ChannelName = "Connected";
            btnDisconnect.ChannelName = "DisConnected";
            btnShutterOpen.ChannelName = "ShutterOpen";
            btnShutterClose.ChannelName = "ShutterClose";
            btnPulseOn.ChannelName = "PulsingOn";
            btnPulseOff.ChannelName = "PulsingOff";

            ledKeyOn.ChannelName = "KeyOn";

            ledStandbyOn.ChannelName = "StandbyOn";
            ledSystemLaserOn.ChannelName = "LaserOn";
            ledSystemFault.ChannelName = "LaserFault";

            btnChillerRun.ChannelName = "ChillerRun";
            btnChillerStop.ChannelName = "ChillerStop";
            btnChillerFault.ChannelName = "ChillerFault";

            viLaserPower.ChannelName = "LaserPower";
            viRRD.ChannelName = "LaserRRD";
            viPulseWidth.ChannelName = "LaserPulseWidth";
            viChillerSetTemp.ChannelName = "ChillerSetTemp";
            viChillerCurrTemp.ChannelName = "ChillerCurrTemp";            

            Global.chLaserShutterOpen       = dsLaser.Channels.Find(btnShutterOpen.ChannelName);
            Global.chLaserShutterClose      = dsLaser.Channels.Find(btnShutterClose.ChannelName);
            Global.chLaserPulsingOn         = dsLaser.Channels.Find(btnPulseOn.ChannelName);
            Global.chLaserPulsingOff        = dsLaser.Channels.Find(btnPulseOff.ChannelName);

            Global.chLaserKeyOn             = dsLaser.Channels.Find(ledKeyOn.ChannelName);           
            Global.chLaserStandby           = dsLaser.Channels.Find(ledStandbyOn.ChannelName);
            Global.chLaserOn                = dsLaser.Channels.Find(ledSystemLaserOn.ChannelName);
            Global.chLaserFault             = dsLaser.Channels.Find(ledSystemFault.ChannelName);

            Global.chLaserChillerRun        = dsLaser.Channels.Find(btnChillerRun.ChannelName);
            Global.chLaserChillerStop       = dsLaser.Channels.Find(btnChillerStop.ChannelName);
            Global.chLaserChillerFault      = dsLaser.Channels.Find(btnChillerFault.ChannelName);

            Global.chLaserPower             = dsLaser.Channels.Find(viLaserPower.ChannelName);
            Global.chLaserRRD               = dsLaser.Channels.Find(viRRD.ChannelName);
            Global.chLaserPulseWidth        = dsLaser.Channels.Find(viPulseWidth.ChannelName);
            Global.chLaserChillerCurrTemp   = dsLaser.Channels.Find(viChillerCurrTemp.ChannelName);
            Global.chLaserChillerSetTemp    = dsLaser.Channels.Find(viChillerSetTemp.ChannelName);
            #endregion
        }
        #endregion

  
        #region public void LoadChannelInfo()
        public void LoadChannelInfo()
        {
            if (frmChannelSpy != null)
            {
                logger.EnterMethod("LoadChannelInfo(Coherent)");
                
                dsLaser.Channels.RemoveAll();

                using (Global.chLaserConnected = dsLaser.Channels.Add())
                {
                    Global.chLaserConnected.Category = "Coherent Laser";
                    Global.chLaserConnected.Kind = ChannelKind.Virtual;
                    Global.chLaserConnected.DataType = ChannelDataType.Boolean;
                    Global.chLaserConnected.Name = "Connected";
                }

                using (Global.chLaserDisConnected = dsLaser.Channels.Add())
                {
                    Global.chLaserDisConnected.Category = "Coherent Laser";
                    Global.chLaserDisConnected.Kind = ChannelKind.Virtual;
                    Global.chLaserDisConnected.DataType = ChannelDataType.Boolean;
                    Global.chLaserDisConnected.Name = "DisConnected";
                }

                using (Global.chLaserShutterOpen = dsLaser.Channels.Add())
                {
                    Global.chLaserShutterOpen.Category = "Coherent Laser";
                    Global.chLaserShutterOpen.Kind = ChannelKind.Virtual;
                    Global.chLaserShutterOpen.DataType = ChannelDataType.Boolean;
                    Global.chLaserShutterOpen.Name = "ShutterOpen";
                }

                using (Global.chLaserShutterClose = dsLaser.Channels.Add())
                {
                    Global.chLaserShutterClose.Category = "Coherent Laser";
                    Global.chLaserShutterClose.Kind = ChannelKind.Virtual;
                    Global.chLaserShutterClose.DataType = ChannelDataType.Boolean;
                    Global.chLaserShutterClose.Name = "ShutterClose";
                }

                using (Global.chLaserPulsingOn = dsLaser.Channels.Add())
                {
                    Global.chLaserPulsingOn.Category = "Coherent Laser";
                    Global.chLaserPulsingOn.Kind = ChannelKind.Virtual;
                    Global.chLaserPulsingOn.DataType = ChannelDataType.Boolean;
                    Global.chLaserPulsingOn.Name = "PulsingOn";
                }

                using (Global.chLaserPulsingOff = dsLaser.Channels.Add())
                {
                    Global.chLaserPulsingOff.Category = "Coherent Laser";
                    Global.chLaserPulsingOff.Kind = ChannelKind.Virtual;
                    Global.chLaserPulsingOff.DataType = ChannelDataType.Boolean;
                    Global.chLaserPulsingOff.Name = "PulsingOff";
                }

                using (Global.chLaserKeyOn = dsLaser.Channels.Add())
                {
                    Global.chLaserKeyOn.Category = "Coherent Laser";
                    Global.chLaserKeyOn.Kind = ChannelKind.Virtual;
                    Global.chLaserKeyOn.DataType = ChannelDataType.Boolean;
                    Global.chLaserKeyOn.Name = "KeyOn";
                }

                using (Global.chLaserStandby = dsLaser.Channels.Add())
                {
                    Global.chLaserStandby.Category = "Coherent Laser";
                    Global.chLaserStandby.Kind = ChannelKind.Virtual;
                    Global.chLaserStandby.DataType = ChannelDataType.Boolean;
                    Global.chLaserStandby.Name = "StandbyOn";
                }

                using (Global.chLaserOn = dsLaser.Channels.Add())
                {
                    Global.chLaserOn.Category = "Coherent Laser";
                    Global.chLaserOn.Kind = ChannelKind.Virtual;
                    Global.chLaserOn.DataType = ChannelDataType.Boolean;
                    Global.chLaserOn.Name = "LaserOn";
                }

                using (Global.chLaserFault = dsLaser.Channels.Add())
                {
                    Global.chLaserFault.Category = "Coherent Laser";
                    Global.chLaserFault.Kind = ChannelKind.Virtual;
                    Global.chLaserFault.DataType = ChannelDataType.Boolean;
                    Global.chLaserFault.Name = "LaserFault";
                }

                using (Global.chLaserChillerRun = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerRun.Category = "Coherent Laser";
                    Global.chLaserChillerRun.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerRun.DataType = ChannelDataType.Boolean;
                    Global.chLaserChillerRun.Name = "ChillerRun";
                }

                using (Global.chLaserChillerStop = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerStop.Category = "Coherent Laser";
                    Global.chLaserChillerStop.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerStop.DataType = ChannelDataType.Boolean;
                    Global.chLaserChillerStop.Name = "ChillerStop";
                }

                using (Global.chLaserChillerFault = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerFault.Category = "Coherent Laser";
                    Global.chLaserChillerFault.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerFault.DataType = ChannelDataType.Boolean;
                    Global.chLaserChillerFault.Name = "ChillerFault";
                }

                using (Global.chLaserPower = dsLaser.Channels.Add())
                {
                    Global.chLaserPower.Category = "Coherent Laser";
                    Global.chLaserPower.Kind = ChannelKind.Virtual;
                    Global.chLaserPower.DataType = ChannelDataType.Double;
                    Global.chLaserPower.Name = "LaserPower";
                }

                using (Global.chLaserRRD = dsLaser.Channels.Add())
                {
                    Global.chLaserRRD.Category = "Coherent Laser";
                    Global.chLaserRRD.Kind = ChannelKind.Virtual;
                    Global.chLaserRRD.DataType = ChannelDataType.Integer;
                    Global.chLaserRRD.Name = "LaserRRD";
                }

                using (Global.chLaserPulseWidth = dsLaser.Channels.Add())
                {
                    Global.chLaserPulseWidth.Category = "Coherent Laser";
                    Global.chLaserPulseWidth.Kind = ChannelKind.Virtual;
                    Global.chLaserPulseWidth.DataType = ChannelDataType.Integer;
                    Global.chLaserPulseWidth.Name = "LaserPulseWidth";
                }

                using (Global.chLaserChillerSetTemp = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerSetTemp.Category = "Coherent Laser";
                    Global.chLaserChillerSetTemp.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerSetTemp.DataType = ChannelDataType.Double;
                    Global.chLaserChillerSetTemp.Name = "ChillerSetTemp";
                }

                using (Global.chLaserChillerCurrTemp = dsLaser.Channels.Add())
                {
                    Global.chLaserChillerCurrTemp.Category = "Coherent Laser";
                    Global.chLaserChillerCurrTemp.Kind = ChannelKind.Virtual;
                    Global.chLaserChillerCurrTemp.DataType = ChannelDataType.Double;
                    Global.chLaserChillerCurrTemp.Name = "ChillerCurrTemp";
                }

                frmChannelSpy.propGridLaser.DataServer = dsLaser;
                frmChannelSpy.propGridLaser.Active = true;

                logger.ExitMethod("LoadChannelInfo(Coherent)");
            }
        }
        #endregion

        public bool CoherentOpen(String szAddress, int nPort)
        {
            bool bReadSessionCon = false;
            bool bWriteSessionCon = false;

            if (!ReadSession.isConnect())
            {
                bReadSessionCon = ReadSession.Connect(szAddress, nPort);
            }

            if (!WriteSession.isConnect())
            {
                bWriteSessionCon = WriteSession.Connect(szAddress, nPort);
            }

            return bReadSessionCon && bWriteSessionCon;            
        }

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
    
        private void ReadThread_OnExecute(object sender, EventArgs e)
        {
#if _COHERENT
            switch (CurrentStep)
            {
                case 0:
                    CurrentStep = 10;
                    break;

                case 10:
                    ReadSession.Send("?SV" + "\r\n");

                    Counter.Start();

                    CurrentStep = 11;
                    break;

                case 11:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        CurrentStep = 20;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 20://external shutter status
                    ReadSession.Send("?S" + "\r\n");

                    Counter.Start();

                    CurrentStep = 21;
                    break;

                case 21:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        bool bClosed;
                        string result = PassingReadData(receivedValue1);
                        bClosed = (yjCommon.StrToIntDef(result, 0) == 0);

                        Global.chLaserShutterOpen.AsBoolean = !bClosed;
                        Global.chLaserShutterClose.AsBoolean = bClosed;

                        CurrentStep = 30;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 30:// Pulse control
                    ReadSession.Send("?PC" + "\r\n");

                    Counter.Start();

                    CurrentStep = 31;
                    break;

                case 31:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        bool bPulsingOff;
                        string result = PassingReadData(receivedValue1);
                        bPulsingOff = (yjCommon.StrToIntDef(result, 0) == 0);
                        
                        Global.chLaserPulsingOn.AsBoolean = !bPulsingOff;
                        Global.chLaserPulsingOff.AsBoolean = bPulsingOff;
                        
                        btnPulseOn.LED.Value = Global.chLaserPulsingOn.AsBoolean;
                        btnPulseOff.LED.Value = Global.chLaserPulsingOff.AsBoolean;

                        CurrentStep = 40;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 40://Power control
                    ReadSession.Send("?RL" + "\r\n");

                    Counter.Start();

                    CurrentStep = 41;
                    break;

                case 41:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        Global.chLaserPower.AsDouble = PassingReadData(receivedValue1).ToDouble();
                        viLaserPower.AsDouble = Global.chLaserPower.AsDouble;

                        CurrentStep = 50;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 50:
                    ReadSession.Send("?BT" + "\r\n");

                    Counter.Start();

                    CurrentStep = 51;
                    break;

                case 51:
                    if (ReadSession.WaitReply == false)
                    {
                        CurrentStep = 60;       

                        Counter.Stop();
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 60:
                    ReadSession.Send("?ST" + "\r\n");

                    Counter.Start();

                    CurrentStep = 61;
                    break;

                case 61:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        CurrentStep = 70;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 70: 
                    // Laser enable keyswitch
                    ReadSession.Send("?K" + "\r\n");

                    Counter.Start();
             
                    CurrentStep = 71;
                    break;

                case 71:
                    if (ReadSession.WaitReply == false) 
                    {
                        Counter.Stop();
                        
                        bool bKeyOff;
                        string result = PassingReadData(receivedValue1);
                        bKeyOff = (yjCommon.StrToIntDef(result, 0) == 0);

                        Global.chLaserKeyOn.AsBoolean = !bKeyOff;

                        CurrentStep = 80;
                    }
                    else 
                    if(Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 80: // Print Laser State
                    ReadSession.Send("?L" + "\r\n");

                    Counter.Start();
                    
                    CurrentStep = 81;
                    break;

                case 81:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        int nVal;
                        string result = PassingReadData(receivedValue1);
                        nVal = result.ToInt();

                        Global.chLaserStandby.AsBoolean = (nVal == 0);
                        Global.chLaserOn.AsBoolean = (nVal == 1);
                        Global.chLaserFault.AsBoolean = !(Global.chLaserStandby.AsBoolean || Global.chLaserOn.AsBoolean);

                        CurrentStep = 90;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 90:
                    ReadSession.Send("?RRD" + "\r\n");

                    Counter.Start();
 
                    CurrentStep = 91;
                    break;

                case 91:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        Global.chLaserRRD.AsInteger = PassingReadData(receivedValue1).ToInt();

                        CurrentStep = 100;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 100:
                    ReadSession.Send("?PWS" + "\r\n");

                    Counter.Start();

                    CurrentStep = 101;
                    break;

                case 101:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        CurrentStep = 110;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();

                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 110:
                    ReadSession.Send("?SET" + "\r\n");

                    Counter.Start();

                    CurrentStep = 111;
                    break;

                case 111:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        SetDataPassing(PassingReadData(receivedValue1));

                        CurrentStep = 120;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                
                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 120:
                    ReadSession.Send("?CHT" + "\r\n");

                    Counter.Start();
                
                    CurrentStep = 121;
                    break;

                case 121:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        Global.chLaserChillerCurrTemp.AsDouble = PassingReadData(receivedValue1).ToDouble();                        

                        CurrentStep = 130;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                    
                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 130: // ?Returns chiller set Point
                    ReadSession.Send("?CHST" + "\r\n");

                    Counter.Start();

                    CurrentStep = 131;
                    break;

                case 131:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        Global.chLaserChillerSetTemp.AsDouble = PassingReadData(receivedValue1).ToDouble();

                        CurrentStep = 140;
                    }
                    else if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                 
                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 140: // returns chiller enable
                    ReadSession.Send("?CHEN" + "\r\n");

                    Counter.Start();
    
                    CurrentStep = 141;
                    break;

                case 141:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        bool bVal;
                        string result = PassingReadData(receivedValue1);
                        bVal = Convert.ToBoolean(int.Parse(result));

                        Global.chLaserChillerRun.AsBoolean = bVal;
                        Global.chLaserChillerStop.AsBoolean = !bVal;

                        CurrentStep = 150;
                    }
                    else
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                   
                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 150:
                    ReadSession.Send("?CHFAULT" + "\r\n");

                    Counter.Start();
           
                    CurrentStep = 151;
                    break;

                case 151:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        bool bVal;
                        string result = PassingReadData(receivedValue1);
                        //  bVal = Convert.ToBoolean(int.Parse(result));                        
                        // yhbyun  Global.chLaserChillerFault.AsBoolean = bVal;

                        CurrentStep = 160;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                       
                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;

                case 160: //Print Pulse Mode
                    ReadSession.Send("?PM" + "\r\n");

                    Counter.Start();
                    
                    CurrentStep = 161;
                    break;

                case 161:
                    if (ReadSession.WaitReply == false)
                    {
                        Counter.Stop();

                        int nVal;
                        string result = PassingReadData(receivedValue1);
                        nVal = Convert.ToInt32(result);

                        if(nVal == 6)
                        {
                            bPulseEQMode = true;
                            chkPulseEQ.Checked = true;
                        }
                        else
                        {
                            bPulseEQMode = false;
                            chkPulseEQ.Checked = false; 
                        }

                        /*
                         * 
                         * 
                        if (nValue == 6)
                        {
                            cData.Config.Laser.PulseEQ = true;
                        }
                        else
                            cData.Config.Laser.PulseEQ = false;
                        if (nValue == 1 || nValue == 3 || nValue == 6)
                        {
                            cData.Config.Laser.ExternalGate = true;
                        }
                        else
                        {
                            cData.Config.Laser.ExternalGate = false;
                        }

                         */

                        CurrentStep = 0;
                    }
                    else 
                    if (Counter.isTimeOver(1000))
                    {
                        Counter.Stop();
                  
                        CurrentStep = Const.CASE_ERROR;
                    }
                    break;
            }
#endif
        }

        //viChillerTemp
        private void ReadSession_OnReceive(object sender, AsyncSocketReceiveEventArgs e)
        {            
            //receivedData1 = String.Format("ReadSession.Data {0} Received = \"{1}\"", e.ReceiveBytes, System.Text.Encoding.Default.GetString(e.ReceiveData, 0, e.ReceiveBytes));
            receivedValue1 = System.Text.Encoding.Default.GetString(e.ReceiveData, 0, e.ReceiveBytes);
            // logger.SendMsg(String.Format("ReadSession: {0}", receivedValue1));
        }

        private void WriteSession_OnReceive(object sender, AsyncSocketReceiveEventArgs e)
        {
           // receivedData1 = String.Format("WriteSession.Data {0} Received = \"{1}\"", e.ReceiveBytes, System.Text.Encoding.Default.GetString(e.ReceiveData, 0, e.ReceiveBytes));
            receivedValue2 = System.Text.Encoding.Default.GetString(e.ReceiveData, 0, e.ReceiveBytes);
            // logger.SendMsg(String.Format("WriteSession: {0}", receivedValue2));
        }

        private string PassingReadData(string str)
        {
            string ret = string.Empty;

            if (str != null)
            {
                ret = str.Split(new[] { "Monaco>" }, StringSplitOptions.None)[0].Trim();
            }
            return ret;
        }

        #region private void dataServer1_OnError(object sender, int code, string channelName, Channel channel)
        private void dataServer1_OnError(object sender, int code, string channelName, Channel channel)
        {
            var dataServer = sender as DataServer;
            if (dataServer != null)
            {
                string szName = "Laser.dataServer1"; // dataServer의 이름을 가져올수 없음..

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

        private void btnSetRRD_Click(object sender, EventArgs e)
        {
            SetRRD(edRRD.AsInteger);

        }

        public void SetRRD(int nRRD)
        {
            WriteSession.Send(string.Format("RRD={0}" + '\r', nRRD));
        }

        public void btnShutterOpen_Click(object sender, EventArgs e)
        {
            ShutterOpen();
        }

        public void btnShutterClose_Click(object sender, EventArgs e)
        {
            ShutterClose();
        }

        private void btnPulseOn_Click(object sender, EventArgs e)
        {
            PulseOn();
        }

        public void PulseOn()
        {
            WriteSession.Send(string.Format("PC=1"+'\r'));
        }

        private void btnPulseOff_Click(object sender, EventArgs e)
        {
            PulseOff();
        }
        
        public void PulseOff()
        {
            WriteSession.Send(string.Format("PC=0" + '\r'));
        }

        private void btnSystemStart_Click(object sender, EventArgs e)
        {
            WriteSession.Send(string.Format("L=1"));
        }

        private void btnSystemStop_Click(object sender, EventArgs e)
        {

            WriteSession.Send(string.Format("L=0"));
        }

        private void btnSetPower_Click(object sender, EventArgs e)
        {
            SetPower(edPower.Value);
        }

        public void SetPower(double dPower)
        {
            WriteSession.Send(string.Format("RL={0}" + '\r', dPower));

        }
        private void btnSetPulseWidth_Click(object sender, EventArgs e)
        {
            SetPulseWidth(edPulseWidth.AsInteger);
        }

        public void SetPulseWidth(int nPulseWidth)
        {
            WriteSession.Send(string.Format("PW={0}" + '\r', nPulseWidth));

        }
        /*public void SetChillerRun()
         {
             SendCommand("CHEN=1");
         }*/
        private void btnChillerRun_Click(object sender, EventArgs e)
        {
            ChillerRun();
        }

        public void ChillerRun()
        {
            WriteSession.Send(string.Format("CHEN=1"+'\r'));
        }

        private void btnChillerStop_Click(object sender, EventArgs e)
        {
            ChillerStop();
        }

        public void ChillerStop()
        {
            WriteSession.Send(string.Format("CHEN=0" + '\r'));
        }

        private void btnChillerReset_Click(object sender, EventArgs e)
        {
            WriteSession.Send(string.Format("CHSERVICED=1"));
        }

        private bool parsingSetData(string msg, out double dAmp, out double dBurst)
        {
            string[] First = msg.Split(' ');          

            double dvalue;
            double.TryParse(First[0], out dvalue);
            dAmp = dvalue;        

            if (First.Length > 3)
            {
                double.TryParse(First[3], out dvalue);
                dBurst = dvalue;
            }
            else
            {
                dBurst = 0;
                return false;
            }

            return true;
        }      
        private void SetDataPassing(string str)
        {
            // 쉼표를 기준으로 문자열을 분리
            string[] parts = str.Split(',');
            string strParam;

            // 각 요소를 개별 변수에 저장
            int.TryParse(parts[0], out int nRapRate);
            int.TryParse(parts[1], out int nPulseWidth);
            int.TryParse(parts[2], out int nRRD);
            int.TryParse(parts[3], out int nBusrt);
            string strPulseEQ = parts[4];

            Global.chLaserPulseWidth.AsInteger = nPulseWidth;
            viPulseWidth.AsInteger = nPulseWidth;

            viRRD.AsInteger = nRRD;
            //strCurrLaserSet = string.Format("")
            //String.Format("{0}Config\\LaserChannels.csv", yjCommon.AppPath());
            if(bPulseEQMode)
            {
                strParam = string.Format("{0} kHz {1}x80 uj Burst{2} PulseEQ", nRRD, nPulseWidth, nBusrt);
            }
            else
            {
                strParam = string.Format("{0} kHz {1}x80 uj Burst{2}", nRRD, nPulseWidth, nBusrt);
            }

            lblCurLaserParam.Text = strParam;

        }

        public void btnConnectLaser_Click(object sender, EventArgs e)
        {
            btnConnect.LED.Value = CoherentOpen("169.254.46.204", 23);

            ReadThread.Enabled = btnConnect.LED.Value;
        }

        private void btnDisconnectLaser_Click(object sender, EventArgs e)
        {
            btnConnect.LED.Value = false;
            ReadThread.Enabled = btnConnect.LED.Value;

            ReadSession.Close();
            WriteSession.Close();
        }

        public void ShutterOpen()
        {
            WriteSession.Send(string.Format("S=1" + '\r'));
        }

        public void ShutterClose()
        {
            WriteSession.Send(string.Format("S=0" + '\r'));
        }

        private void ledbtnReset_Click(object sender, EventArgs e)
        {
            WriteSession.Send(string.Format("CHSERVICED=1" + '\r'));
        }

        private void cbLaserSet_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = cbLaserSet.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(msg))
            {
                double damp, dBurst, dPW, dRRD;
                bool bEq;
                if (true == parsingSetMessage(msg, out damp, out dPW, out dRRD, out dBurst, out bEq)) //msg = 750 khz Burst 1
                {
                    //cMain.Sequecne.GetLaserOperation.SynRun(OpModeLaserMonaco.SetLaserParam.ToString(), damp, dPW, dRRD, dBurst, bEq);
                    SetLaserParam(damp, dPW, dRRD, dBurst, bEq);
                }
            }
        }

        private bool parsingSetMessage(string msg, out double dAmp, out double PW, out double RRD, out double dBurst, out bool bEqMode)
        {
            string[] First = msg.Split(' ');

            /* 
             * 왜 이렇게 코딩하지..?
             */

            if (chkPulseEQ.Checked == true)
                bEqMode = true;
            else
                bEqMode = false;

            double dvalue;
            double.TryParse(First[0], out dvalue);
            dAmp = dvalue;
            PW = viPulseWidth.AsInteger;
            RRD = viRRD.AsInteger;

            if (First.Length > 3)
            {
                double.TryParse(First[3], out dvalue);
                dBurst = dvalue;
            }
            else
            {
                dBurst = 0;
                return false;
            }

            return true;
        }

        public void SetLaserParam(double RepRate, double PW, double RRD, double Burst, bool PulseEQ)
        {
            double dRepRate = RepRate;
            double dPW = PW;
            double dRRD = RRD;
            double dBurst = Burst;
            bool bPulseEQ = PulseEQ == true ? true : false;


            string cmdFormat = string.Format("SET={0},", dRepRate);

            if (bPulseEQ == true)
            {
                cmdFormat += string.Format("{0},{1},{2},PulseEQ", dPW, dRRD, dBurst);
            }
            else
            {
                cmdFormat += string.Format("{0},{1},{2},", dPW, dRRD, dBurst);
            }

            WriteSession.Send(string.Format(cmdFormat + '\r'));
        }

        public void ChangeLanguageVietnam()
        {

        }

        public void ChangeLanguageKorea()
        {

        }
        public void ChangeLanguageEnglish()
        {

        }

        public bool isLaserOn()
        {
            return true;
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            WriteSession.Send(string.Format("FACK = 1" + '\r'));
        }
    }
}
