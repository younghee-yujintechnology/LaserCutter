using System;
using System.Windows.Forms;

using DaekhonSystem;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panManualADV : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        private panAuto Auto;

        private const UInt32 ENC_BASEPOS = 2147483648;
#if _ADV
        int nIndex = 0;
#endif
        public panManualADV()
        {
            InitializeComponent();

            cbComPort.Items.Clear();

            cbComPort.Items.Add(DaekhonSystem.Port.COM01.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM02.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM03.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM04.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM05.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM06.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM07.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM08.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM09.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM10.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM11.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM12.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM13.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM14.ToString());
            cbComPort.Items.Add(DaekhonSystem.Port.COM15.ToString());

            cbComPort.ItemIndex = 7;

            viBaudRate.AsString = Comm.BaudRate.ToString().TrimStart('_');
            btnConnect.LED.Value = false;

            Auto = panAuto.StaticInstance;
        }

        #region private void dataServer1_OnError(object sender, int code, string channelName, Channel channel)
        private void dataServer1_OnError(object sender, int code, string channelName, Channel channel)
        {
            var dataServer = sender as DataServer;
            if (dataServer != null)
            {
                string szName = "ADV.dataServer1"; // dataServer의 이름을 가져올수 없음..

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


        private void btnMode0Set_Click(object sender, EventArgs e)
        {
            Mode0Set(edMode0Period.Value, edMode0PulseWidth.Value);

            propSaver1.SaveProperty();
        }

        public void Mode0Set(double dPeriod, double dPulse)
        {
            listBox.Items.Add("");

            edMode0Period.Apply();
            edMode0PulseWidth.Apply();

            string szStr = String.Format("/tm0/");
            szStr = String.Format("Command Mode = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Add(szStr);

            szStr = String.Format("/s00/");
            szStr = String.Format("Command Trigger Mode = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);


            long period_1 = 0;
            if (dPeriod <= 0) period_1 = 0;

            else if (dPeriod > 4000000000)
                period_1 = 4000000000;      //0.025hz=40s --> 40s/10ns = 4000000000 cnt
            else
                period_1 = (long)(dPeriod * 100.0 + 0.005);

            string strValue = Convert.ToString(period_1, 16);
            szStr = string.Format("/0d{0}/", strValue.PadLeft(8, '0'));
            szStr = String.Format("Period = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);

            long pulse_1 = 0;
            if (dPulse < 0)
            {
                pulse_1 = 0;
            }
            else
            {
                pulse_1 = (long)(dPulse * 100 + 0.005);
            }
            
            strValue = Convert.ToString(pulse_1, 16);
            szStr = string.Format("/0w{0}/", strValue.PadLeft(8, '0'));
            szStr = String.Format("Pulse Width = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        public void btnMode2Set_Click(object sender, EventArgs e)
        {
            Mode2Set(edMode2PulsePitch.Value, edMode2PulseWidth.Value);
           
            propSaver1.SaveProperty();
        }

        public void Mode2Set(double dPitch, double dPulseWidth)
        { 
            listBox.Items.Insert(0, "");

            edMode2PulseWidth.Apply();
            edMode2PulsePitch.Apply();

            string szStr = String.Format("/tm2/");
            szStr = String.Format("Command Mode = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Add(szStr);

            szStr = String.Format("/s02/");
            szStr = String.Format("Command Trigger Mode = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);

            long pulse_1 = 0;
            if (dPulseWidth < 0)
                pulse_1 = 0;
            else
                pulse_1 = (long)(dPulseWidth * 100 + 0.005);

            szStr = Convert.ToString(pulse_1, 16);

            szStr = string.Format("/2w{0}/", szStr.PadLeft(8, '0'));
            szStr = String.Format("Pulse Width = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);

            SetMode2Pitch(dPitch);
        }

        public void SetMode2Pitch(double dPitch)
        {
            string szStr;
            char pad = '0';
            long PitchSquare = 0;
            uint n_SquarePitchCntLow;
            uint n_SquarePitchCntHigh;
            double dEncResolution = 0.1;//Convert.ToDouble(txtEncoderResolution.Text);   

            if (dPitch < 0) PitchSquare = 0;
            else PitchSquare = (long)((dPitch / dEncResolution) * (dPitch / dEncResolution) + 0.5);

            n_SquarePitchCntHigh = (uint)(PitchSquare >> 32);
            n_SquarePitchCntLow = (uint)(PitchSquare & 0xffffffff);

            szStr = string.Format("/2p1{0}/", n_SquarePitchCntHigh.ToString("X").PadLeft(8, pad));
            szStr = String.Format("PulsePicth High = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);

            szStr = string.Format("/2p0{0}/", n_SquarePitchCntLow.ToString("X").PadLeft(8, pad));
            szStr = String.Format("PulsePitch Low = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        private void btnGetVersion_Click(object sender, EventArgs e)
        {
            lblVersion.Text = ReadVersion();
        }

        private String ReadVersion()
        {
            string szStr = String.Format("/giff/");

            return dkCommon.RemoveCRLF(Comm.QueryCommand(szStr));
        }

        private void btnResetTrigger_Click(object sender, EventArgs e)
        {
            ResetTrigger();
        }
        public void ResetTrigger()
        {
            string szStr = String.Format("/rt/");

            szStr = String.Format("Reset Trigger = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }
  
        private void btnGetEncorderY_Click(object sender, EventArgs e)
        {
            string szStr = String.Format("/gia1/");

            szStr = String.Format("Get Encorder Y = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        private void btnGetTrigger_Click(object sender, EventArgs e)
        {
            string szStr = String.Format("/gib0/");

            szStr = String.Format("Get Trigger = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        private void btnGetEncorderX_Click(object sender, EventArgs e)
        {
            string szStr = String.Format("/gia0/");

            szStr = String.Format("Get Encorder X = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        private void btnResetEncoder_Click(object sender, EventArgs e)
        {
            ResetEncoder();
        }

        public void ResetEncoder()
        {
            string szStr = String.Format("/re/");

            szStr = String.Format("Reset Encoder = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        private void btnOperatingOn_Click(object sender, EventArgs e)
        {
            btnOperatingOn.LED.Value = !btnOperatingOn.LED.Value;

            if (btnOperatingOn.LED.Value)
            {
                OperationOn();
            }
            else
            {
                OperationOff();
            }
        }

        public void OperationOn()
        {
            string szStr = String.Format("/on/");

            szStr = String.Format("Operation On = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        public void OperationOff()
        {
            string szStr = String.Format("/off/");

            szStr = String.Format("Operation Off = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            listBox.Items.Insert(0, szStr);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.LED.Value = !btnConnect.LED.Value;

            if (btnConnect.LED.Value)
            {
                Connect();

            }
            else
            {
                Disconnect();
            }
        }

        public void Connect()
        {
#if _ADV
            Comm.Port = (DaekhonSystem.Port)cbComPort.SelectedIndex;
            btnConnect.LED.Value = Comm.OpenComm();

            ReadThread.Enabled = true;
#endif
        }

        public void Disconnect()
        {
#if _ADV
            btnConnect.LED.Value = false;
        
            Comm.CloseComm();
#endif
        }

        public bool IsConnected()
        {
            return btnConnect.LED.Value;
        }

        private void Comm_OnEventCharReceived(object sender, int count)
        {
            string szStr = String.Format("/giff/");

            szStr = String.Format("Version = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            logger.SendMsg(szStr);
        }

        private void Comm_OnCommError(object Sender, int nErrCode, string szErrDesc)
        {
            logger.SendMsg(szErrDesc);
        }

        private void Comm_OnOpenStatus(object sender, bool e)
        {
            String szStr;
            if (e)
            {
                szStr = String.Format("{0} Open Success", Comm.Port.ToString());
                logger.SendMsg(szStr);          
            }
            else
            {
                szStr = String.Format("{0} Open Close", Comm.Port.ToString());
                logger.SendMsg(szStr);                              
            }
        }

        private void ReadThread_OnExecute(object sender, EventArgs e)
        {
                
#if _ADV
            if (!btnConnect.LED.Value) return;

            switch (nIndex)
            {
                case 0:
                    ledRX.LED.Value = true;
                    ledTX.LED.Value = false;

                    GetEncorderX();
                    nIndex = 10;
                    break;

                case 10:
                    GetEncorderY();
                    nIndex = 20;
                    break;

                case 20:
                    GetTrigger();
                    nIndex = 30;
                    break;

                case 30:
                    ledRX.LED.Value = false;
                    ledTX.LED.Value = true;

                    GetMode0PulseWidth();
                    nIndex = 40;
                    break;

                case 40:
                    GetMode0Period();                    
                    nIndex = 50;
                    break;

                case 50:
                    GetMode2PulseWidth();
                    nIndex = 60;
                    break;

                case 60:
                    GetMode2PulsePitch();
                    nIndex = 70;
                    break;

                case 70:
                    ParsingCrtStatus();
                    nIndex = 80;
                    break;

                case 80:
                    if (ReadVersion() == "")
                    {
                        Auto.AddError(Const.ERROR_LASER_TRIGGER_ADV_COMMUNICATION_ERROR);
                    }
                    
                    nIndex = 0;
                    break;
            }
#endif
        }

        private void GetEncorderY()
        {
            string szStr = String.Format("/gia1/");

            szStr = String.Format("Get Encorder Y = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));

            if (szStr.Length < 18 )
                return;

            long longData = Convert.ToInt64(szStr.Substring(szStr.Length - 8), 16);

            //if (index == 0)
            longData = longData < 0x80000000 ? longData - 0x80000000 : longData; //확인해야함....
            //else
            //    longData = longData > 0x80000000 ? longData - 0x80000000 : longData;

            if (longData < ENC_BASEPOS)
                longData = ENC_BASEPOS;

            longData = Convert.ToInt64(longData.ToString("X").Substring(1), 16);

            viEnc1.AsDouble = Math.Round((longData * 0.1) / 1000, 3); // (Cnt * Enc(0.1um))/1000 = mm     
        }

        private void GetTrigger()
        {
            string szStr = String.Format("/gib0/");

            szStr = String.Format("Get Trigger = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            if (szStr.Length < 15)
                return;
            long longData = Convert.ToInt64(szStr.Substring(szStr.Length - 8), 16);
            viTrigger.Text = longData.ToString();        
        }

        private void GetEncorderX()
        {
            string szStr = String.Format("/gia0/");

            szStr = String.Format("Get Encorder X = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            int a = szStr.Length;
            if (szStr.Length != 28 && szStr.Contains("ec") == false)
                return;

            long longData = Convert.ToInt64(szStr.Substring(szStr.Length - 8), 16);
            
            longData = longData < 0x80000000 ? longData - 0x80000000 : longData;//확인해야함....

            if (longData < ENC_BASEPOS)
                longData = ENC_BASEPOS;

            longData = Convert.ToInt64(longData.ToString("X").Substring(1), 16);

            viEnc0.AsDouble = Math.Round((longData * 0.1) / 1000, 3); // (Cnt * Enc(0.1um))/1000 = mm     
        }  
   
        public void GetMode0PulseWidth()
        {           
            string szStr = String.Format("/gi52/");
      
            szStr = String.Format("Get M0 PW = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            if (szStr.Length < 14) return;

            long longData = Convert.ToInt64(szStr.Substring(szStr.Length - 8), 16) / 100;  
            viGetM0PW.Text = longData.ToString();      
        }

        public void GetMode0Period()
        {
            string szStr = String.Format("/gi51/");
            szStr = String.Format("Get M0 Period = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            if (szStr.Length < 17) return;

            long longData = Convert.ToInt64(szStr.Substring(szStr.Length - 8), 16) / 100;
            viGetM0Period.Text = longData.ToString();
        }

        public void GetMode2PulseWidth()
        {
            string szStr = String.Format("/gi65/");
            szStr = String.Format("Get M2 PW = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            if (szStr.Length < 13)return;

            long longData = Convert.ToInt64(szStr.Substring(szStr.Length - 8), 16)/100;
            viGetM2PW.Text = longData.ToString();             
        }

        public void GetMode2PulsePitch()
        {
            string szStr = String.Format("/gi61/");
            szStr = String.Format("Get M2 Pitch = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            if (szStr.Length < 16)
                return;

            // 결과 값에서 하위 8글자 추출 후 16진수에서 10진수로 변환
            uint n_SquarePitchCntLow = Convert.ToUInt32(szStr.Substring(szStr.Length - 8), 16);

            // 결과 값에서 상위 8글자 추출 후 16진수에서 10진수로 변환
            uint n_SquarePitchCntHigh = Convert.ToUInt32(szStr.Substring(szStr.Length - 16, 8), 16);

            // 계산된 pitch 값 계산
            double dPitch = CalculatePitch(n_SquarePitchCntHigh, n_SquarePitchCntLow);
            viGetM2Pitch.Text = dPitch.ToString(); //longData.ToString();
        }
        public double CalculatePitch(uint n_SquarePitchCntHigh, uint n_SquarePitchCntLow, double dEncResolution = 0.1)
        {
            // 고차 및 저차 비트 결합하여 PitchSquare 값 복원
            long PitchSquare = ((long)n_SquarePitchCntHigh << 32) | n_SquarePitchCntLow;

            // 역 계산을 통해 dPitch 값 복원
            double dPitch = Math.Sqrt(PitchSquare) * dEncResolution;

            return dPitch;
        }

        public void ParsingCrtStatus()
        {
            string szStr = String.Format("/gi00/");
            szStr = String.Format("Get Status = {0}", dkCommon.RemoveCRLF(Comm.QueryCommand(szStr)));
            if (szStr.Length < 15) return;

            string data = szStr.Substring(szStr.Length - 14); // "ss" 제거
            int intData = int.Parse(data.Substring(data.Length - 4, 4), System.Globalization.NumberStyles.HexNumber); // 16진수로 변환

            bool bBoundMode = data[0] == '1'; // Bound On/Off
            bool bOperating = data[3] == '1'; // Operating On/Off
            int nTriggerMode = data[1] - '0'; // Trigger Mode (0, 2)

            viGetMode.Text = nTriggerMode.ToString();
            viGetOperating.Text = bOperating.ToString();
            viGetBoundMode.Text = bBoundMode.ToString();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnConnect.Text = Global.iniEng.ReadString("panManualADV", "btnConnect.Text", "Connect");
            btnMode0Set.Text = Global.iniEng.ReadString("panManualADV", "btnMode0Set.Text", "Set");
            btnMode2Set.Text = Global.iniEng.ReadString("panManualADV", "btnMode2Set.Text", "Set");
        }
        public void ChangeLanguageKorea()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualADV", "btnConnect.Text");
            btnMode0Set.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualADV", "btnMode0Set.Text");
            btnMode2Set.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualADV", "btnMode2Set.Text");
        }
        public void ChangeLanguageVietnam()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualADV", "btnConnect.Text");
            btnMode0Set.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualADV", "btnMode0Set.Text");
            btnMode2Set.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualADV", "btnMode2Set.Text");
        }
        #endregion

        private void btnSelectTable1_Click(object sender, EventArgs e)
        {
            btnSelectTable1.LED.Value = true;
            btnSelectTable2.LED.Value = false;

            Pmac.QueryCommand("doSelectTable=TABLE1");
        }

        private void btnSelectTable2_Click(object sender, EventArgs e)
        {
            btnSelectTable1.LED.Value = false;
            btnSelectTable2.LED.Value = true;

            Pmac.QueryCommand("doSelectTable=TABLE2");
        }
    }
}
