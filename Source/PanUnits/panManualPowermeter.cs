using YujinTechnology;
using Raize.CodeSiteLogging;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class panManualPowermeter : UserControl, IDisposable
    {
        CodeSiteLogger logger = new CodeSiteLogger();
        
        private frmChannelSpy frmChannelSpy;
        private frmRunStatus frmRunStatus;

        public panManual Manual;
        public panConfigCommon Common;

        public int LastStep = 0;
        public int ErrorCode = 0;
    #region <<< Command & CurrentStep >>>
        private Command mCommand;
        private Command mOldCommand;
        private int mCurrentStep;

        private double mMaesureStartPosX;
        private double mMaesureStartPosZ;

        public bool ShowStep = false;
        public bool ShowCommand = false;
    #endregion
       
        uint MotorMoveStartTimeOut = 300;
        uint MotorMoveTimeOut = 15000;

        double TotalPower = 0.0;
        double MinPower = 900.0;
        double MaxPower = 0.0;

        TimeCounter Counter = new TimeCounter();

        public panManualPowermeter()
        {
            InitializeComponent();

            frmChannelSpy = frmChannelSpy.StaticInstance;
            Common = panConfigCommon.StaticInstance;
            frmRunStatus = frmRunStatus.StaticInstance;

            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));

            logger.Category = "Manual.PowerMeter";

            cbComPort.SelectedIndex = 1;            
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

        private void btnPowerMeterConnect_Click(object sender, EventArgs e)
        {
            btnConnect.LED.Value = !btnConnect.LED.Value;

            if (btnConnect.LED.Value)
            {
                Connect();
            }
            else
            {
                DisConnect();
            }
        }

        public void Connect()
        {
#if _POWERMETER
            Comm.Port = (YujinTechnology.Port)cbComPort.SelectedIndex;
            btnConnect.LED.Value = Comm.OpenComm();
#endif
        }

        public void DisConnect()
        {
            btnConnect.LED.Value = false;

            Comm.CloseComm();
        }
   
        private double ReadPower()
        {
 #if _POWERMETER
            int nPower;
            int nPos;
            int nFirstPos;
            double dPower = 0.0;

            string szStr = String.Format("$SP\r");
            szStr = String.Format("{0}", yjCommon.RemoveCRLF(Comm.QueryCommand(szStr)));

            if (szStr.IndexOf("OVER") > 0)
            {
                dPower = -1;
            }
            else
            if (szStr.IndexOf("SAT") > 0)
            {
                dPower = -2;
            }
            else
            {
                nPos = szStr.IndexOf('E');
                nFirstPos = szStr.IndexOf('*');
                nPower = szStr.Substring(nPos + 1, 1).ToInt();
                string str = szStr.Substring(nFirstPos + 1, nPos - 1);
                dPower = szStr.Substring(nFirstPos + 1, nPos - 1).ToDouble() * Math.Pow(10, nPower);

            }          
            return dPower;
#else
           return 0;
#endif
        }

        public void PowerMeterCoverOpen()
        {
#if _PMAC
            Pmac.QueryCommand("doPowerMeterCoverOpen=true");
            Pmac.QueryCommand("doPowerMeterCoverClose=false");
#endif
        }

        public void PowerMeterCoverClose()
        {
#if _PMAC
            Pmac.QueryCommand("doPowerMeterCoverOpen=false");
            Pmac.QueryCommand("doPowerMeterCoverClose=true");
#endif
        }

        private void MeasureThread_OnExecute(object sender, EventArgs e)
        {
            viCurrentStep.AsInteger = CurrentStep;
            viLastStep.AsInteger = LastStep;

            if (frmRunStatus.Abort)
            {
                CurrentStep = Const.CASE_ABORT;
            }

            switch (CurrentStep)
            {
                // @@ 
                case 0: // PowerMeter Position으로 이동

                    viLastStep.AsInteger = 0;
                    viCurrentStep.AsInteger = 0;

                    frmRunStatus.TopMost = true;
                    frmRunStatus.Show();

                    mMaesureStartPosX = Global.chXActualPos.AsDouble;
                    mMaesureStartPosZ = Global.chZActualPos.AsDouble;

                    Manual.Motion.SetMoveVel();
                    Manual.Motion.SetMoveTATS();

                    Pmac.XMoveAbs(Global.chConPowerMeterPosX.AsDouble);
                    Pmac.ZMoveAbs(Global.chConPowerMeterPosZ.AsDouble);

                    frmRunStatus.lblMessage.Text = "측정 위치로 이동중입니다.";

                    Counter.Start();

                    CurrentStep = 10;
                    break;

                case 10:
                    if (Counter.isTimeOver(MotorMoveStartTimeOut)) // Motor 기동 시간 < Sys.Time)
                    {
                        Counter.Stop();

                        Counter.Start();
                    }

                    CurrentStep = 20;
                    break;

                case 20:
#if _PMAC
                    if ((Global.chXMotionDone.AsBoolean) && (Global.chZMotionDone.AsBoolean)
                            && (Pmac.XInTargetPos(Global.chConPowerMeterPosX.AsDouble)) 
                                && (Pmac.ZInTargetPos(Global.chConPowerMeterPosZ.AsDouble)))
                    {
                        Counter.Start();

                        CurrentStep = 30;
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut)) // Align#1 pos 이동 최대 5.0초
                    {
                        LastStep = CurrentStep;
                        ErrorCode = Const.ERROR_MOVE_POWER_METER_POS_TIME_OVER;         // 도착 시간 TIME OVER

                        CurrentStep = Const.CASE_ERROR;
                    }
#else
                    Counter.Start();
                    CurrentStep = 30;
#endif
                    break;

                case 30: // ADV  Setting & On
                    Manual.Laser.ShutterOpen();

                    Pmac.QueryCommand("doBeamShutterOpen=true");
                    Pmac.QueryCommand("PowerMeterBusy=true");
                    Manual.ADV.Mode0Set(Common.edMode0Period.Value, Common.edMode0PulseWidth.Value);

                    frmRunStatus.lblMessage.Text = "Beam ShutterOpen.";

                    Counter.Start();

                    CurrentStep = 31;
                    break;

                case 31:
                    if (Counter.isTimeOver(300)) // 통신시간
                    {
                        Counter.Stop();

                        Counter.Start();

                        CurrentStep = 32;
                    }
                    break;

                case 32:
                    Manual.ADV.ResetEncoder();
                    Counter.Start();

                    CurrentStep = 33;
                    break;

                case 33:
                    if (Counter.isTimeOver(300)) // 통신시간
                    {
                        Counter.Stop();

                        Counter.Start();

                        CurrentStep = 34;
                    }
                    break;

                case 34:
                    Manual.ADV.ResetTrigger();
                    Counter.Start();

                    CurrentStep = 35;
                    break;

                case 35:
                    if (Counter.isTimeOver(300)) // 통신시간
                    {
                        Counter.Stop();

                        Counter.Start();

                        CurrentStep = 40;
                    }
                    break;

                case 40: // PowerMeter Cover Open
                    PowerMeterCoverOpen();

                    frmRunStatus.lblMessage.Text = "PowerMeter Cover Open..";

                    Counter.Start();
                    CurrentStep = 41;
                    break;

                case 41:
                    if (Counter.isTimeOver(300)) // 통신시간
                    {
                        Counter.Stop();

                        Counter.Start();
#if _PMAC
                        Pmac.QueryCommand("doLaserTriggerOn=true");
#endif
                        CurrentStep = 50;
                    }
                    break;

                case 50: //측정 시작                
                    Counter.Start();

                    frmRunStatus.lblMessage.Text = "측정중입니다..";

                    CurrentStep = 60;  // 다음 단계로 이동              
                    break;

                case 60:
                    if (Counter.isTimeOver(5000))// 3초 대기 후 첫 측정 시작
                    {
                        Counter.Stop();

                        viReadCount.AsInteger = 0;
                        TotalPower = 0.0;

                        Counter.Start();
                        CurrentStep = 70;
                    }
                    break;

                case 70:
                    if (Counter.isTimeOver((uint) edScanTime.AsInteger * 1000))
                    {
                        CurrentStep = 80;
                    }
                    else
                    {
                        viReadCount.AsInteger = viReadCount.AsInteger + 1;
                        viCurrentValue.AsDouble = ReadPower();
                        if (viCurrentValue.AsDouble < MinPower) MinPower = viCurrentValue.AsDouble;
                        if (viCurrentValue.AsDouble > MaxPower) MaxPower = viCurrentValue.AsDouble;
                        TotalPower = TotalPower + viCurrentValue.AsDouble;
                    }
                    break;

                case 80:
                    // 마지막 측정값 저장
                    CurrentStep = 90;
                    break;

                case 90:
                    Manual.Laser.ShutterClose();

#if _PMAC
                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    Pmac.QueryCommand("doLaserTriggerOn=false");
#endif

                    frmRunStatus.lblMessage.Text = "Beam Shutter Close.";

                    Counter.Start();

                    CurrentStep = 110;
                    break;

                case 110: // Cover Close
                    PowerMeterCoverClose();

                    CurrentStep = 120;
                    break;

                case 120: // 대기 위치 이동
#if _PMAC
                    Manual.Motion.SetMoveVel();
                    Manual.Motion.SetMoveTATS();

                    Pmac.XMoveAbs(mMaesureStartPosX);
                    Pmac.ZMoveAbs(mMaesureStartPosZ);

                    frmRunStatus.lblMessage.Text = "초기 위치로 이동 중.";

                    Counter.Start();
#endif
                    CurrentStep = 121;
                    break;

                case 121:
                    if (Counter.isTimeOver(MotorMoveStartTimeOut)) // Motor 기동 시간 < Sys.Time)
                    {
                        Counter.Stop();

                        Counter.Start();
                        CurrentStep = 130;
                    }
                    break;

                case 130://이동완료 확인
#if _PMAC
                    if ((Global.chXMotionDone.AsBoolean) && (Global.chZMotionDone.AsBoolean)
                            && (Pmac.XInTargetPos(Global.chConPowerMeterPosX.AsDouble)) 
                                && (Pmac.ZInTargetPos(Global.chConPowerMeterPosZ.AsDouble)))
                    {
                        frmRunStatus.lblMessage.Text = "이동 완료.";

                        Counter.Stop();
                    }
                    else
                    if (Counter.isTimeOver(MotorMoveTimeOut)) // Align#1 pos 이동 최대 5.0초
                    {
                        LastStep = CurrentStep;
                        ErrorCode = Const.ERROR_MOVE_POWER_METER_POS_TIME_OVER;         // 도착 시간 TIME OVER
                        CurrentStep = Const.CASE_ERROR;
                    }
#else
#endif
                    CurrentStep = 140;
                    break;

                case 140:

                    viMin.AsDouble = MinPower;
                    viMax.AsDouble = MaxPower;
                    viAverage.AsDouble = TotalPower / viReadCount.AsInteger;

                    CurrentStep = Const.CASE_DONE;
                    break;

                case Const.CASE_ABORT:
                    frmRunStatus.Hide();

                    Manual.ADV.Mode2Set(Manual.ADV.edMode2PulsePitch.Value, Manual.ADV.edMode2PulseWidth.Value);

                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    Pmac.QueryCommand("doLaserTriggerOn=false");
                    Pmac.QueryCommand("PowerMeterBusy=false");

                    PowerMeterCoverClose();

                    btnMeasureStart.LED.Value = false;
                    MeasureThread.Enabled = btnMeasureStart.LED.Value;
                    break;

                case Const.CASE_ERROR:                    
                    frmRunStatus.Hide();

                    Manual.Laser.ShutterClose();
                    Manual.ADV.Mode2Set(Manual.ADV.edMode2PulsePitch.Value, Manual.ADV.edMode2PulseWidth.Value);
                    
                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    Pmac.QueryCommand("doLaserTriggerOn=false");
                    Pmac.QueryCommand("PowerMeterBusy=false");
                  
                    PowerMeterCoverClose();

                    btnMeasureStart.LED.Value = false;
                    MeasureThread.Enabled = btnMeasureStart.LED.Value;
                    break;

                case Const.CASE_DONE:
                    frmRunStatus.Hide();

                    Manual.Laser.ShutterClose();
                    Manual.ADV.Mode2Set(Manual.ADV.edMode2PulsePitch.Value, Manual.ADV.edMode2PulseWidth.Value);

                    Pmac.QueryCommand("doBeamShutterOpen=false");
                    Pmac.QueryCommand("doLaserTriggerOn=false");
                    Pmac.QueryCommand("PowerMeterBusy=false");

                    PowerMeterCoverClose();

                    btnMeasureStart.LED.Value = false;
                    MeasureThread.Enabled = btnMeasureStart.LED.Value;
                    break;
            }
        }

        private void btnMeasureStart_Click(object sender, EventArgs e)
        {
            edScanTime.Apply();

            btnMeasureStart.LED.Value = !btnMeasureStart.LED.Value;

            if (btnMeasureStart.LED.Value)
            {
                CurrentStep = 0;
                LastStep = 0;
            }

            frmRunStatus.Abort = false;
            MeasureThread.Enabled = btnMeasureStart.LED.Value;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            viCurrentValue.AsDouble = ReadPower();
        }

        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnConnect.Text = Global.iniEng.ReadString("panManualPowermeter", "btnConnect.Text", "Connect");
            btnRead.Text = Global.iniEng.ReadString("panManualPowermeter", "btnRead.Text", "Start");
            btnMeasureStart.Text = Global.iniEng.ReadString("panManualPowermeter", "btnMeasureStart.Text", "Measure");
        }

        public void ChangeLanguageKorea()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualPowermeter", "btnConnect.Text");
            btnRead.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualPowermeter", "btnRead.Text");
            btnMeasureStart.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualPowermeter", "btnMeasureStart.Text");
        }

        public void ChangeLanguageVietnam()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualPowermeter", "btnConnect.Text");
            btnRead.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualPowermeter", "btnRead.Text");
            btnMeasureStart.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualPowermeter", "btnMeasureStart.Text");
        }
        #endregion
    }
}
