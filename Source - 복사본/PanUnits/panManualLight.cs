using YujinTechnology;
using Newtonsoft.Json.Linq;
using Raize.CodeSiteLogging;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaserCutter
{
    public partial class panManualLight : UserControl
    {
        private panAuto Auto;
        private const UInt32 ENC_BASEPOS = 2147483648;
        private int mStep = -1;

        CodeSiteLogger logger;

        public panManualLight()
        {
            InitializeComponent();
            SetCodeSitelogger();

            cbComPort.SelectedIndex = 0;

            Auto = panAuto.StaticInstance;
        }

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Manual.Light";

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


        #region public static panManualLight StaticInstance
        private static panManualLight staticInstance;
        public static panManualLight StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panManualLight();
                }
                return staticInstance;
            }
        }
        #endregion

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
#if _LIGHT
#if _VERSION1
            cbComPort.SelectedIndex = 2;
#elif _VERSION2
            cbComPort.SelectedIndex = 0;
#endif
            Comm.Port = (YujinTechnology.Port)cbComPort.SelectedIndex;

            btnConnect.LED.Value = Comm.OpenComm();

            ReadThread.Enabled = true;
            mStep = 0;
#endif
        }

        public void Disconnect()
        {
#if _LIGHT
            btnConnect.LED.Value = false;
            mStep = -1;

            ReadThread.Enabled = false;
            Comm.CloseComm();

            ledRX.LED.Value = false;
            ledTX.LED.Value = false;
#endif
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            WriteChannelValue(1, edLightValue.AsInteger);
            edLightValue.Apply();
            ReadChannelValue();
        }

        public bool WriteChannelValue(int ch, int Value)
        {
#if _LIGHT
            logger.SendMsg(String.Format("        Light.WriteChannelValue({0}, {1})", ch, Value));

            bool bRet = false;
            byte[] msg = new byte[8];

            msg[0] = 0x01; // SOH
            msg[1] = 0x00; // Write:0x00, Read 0x01
            msg[2] = 0x03; // data count
            msg[3] = 0x21; // address

            // 채널 설정
            if (ch >= 1 && ch <= 8)
            {
                msg[4] = 0x00;
                msg[5] = (byte)ch;
            }
            else 
            if (ch >= 9 && ch <= 16)
            {
                msg[4] = 0xFF;
                msg[5] = (byte)(ch - 8);
            }
            else
            {
                Console.WriteLine("Channel Error");
                bRet = false;
            }

            msg[6] = (byte)Value;
            msg[7] = 0x04; // EOT

            // QueryCommand를 사용하여 바이트 배열로 명령 전송 및 응답 받기
            byte[] response = Comm.QueryCommand(msg);

            // 응답이 있는 경우 처리
            if (response != null && response.Length > 0)
            {
                // 필요에 따라 응답 데이터 처리 (예: 성공 여부 확인)
                bRet = true; // 예시로 성공 플래그 설정
            }

            return bRet;
#else
            return true;
#endif
        }

        public bool ReadChannelValue()
        {
#if _LIGHT
            int nValue;
            bool bRet = false;

            byte[] msg = new byte[5];

            msg[0] = 0x01; // SOH
            msg[1] = 0x01; // Write:0x00, Read 0x01
            msg[2] = 0x00; // data count <-- yhbyun 0x02 넣어야 하는데??
            msg[3] = 0x21; // address
            msg[4] = 0x04; // EOT
                           // 
            byte[] response = Comm.QueryCommand(msg);
            // 응답이 있는 경우 처리
            if (response != null && response.Length > 0)
            {
                // 필요에 따라 응답 데이터 처리 (예: 성공 여부 확인)
                nValue = (int)response[4];
                viCurrentValue.Text = nValue.ToString();
                bRet = true; // 예시로 성공 플래그 설정
            } 
            else
            {
                Auto.AddError(Const.ERROR_LIGHT_CONTROLLER_COMMUNICATION_ERROR);
            }
            return bRet;
#else
            return true;
#endif
        }

        private void btnLightOn_Click(object sender, EventArgs e)
        {
            btnLightOn.LED.Value = !btnLightOn.LED.Value;

            if (btnLightOn.LED.Value)
            {
                LightOn();
            } 
            else
            {
                LightOff();
            }
        }

        public bool ReadChannelStatus()
        {         
            int nValue;
            bool bRet = false;

            byte[] msg = new byte[7];

            msg[0] = 0x01; // SOH
            msg[1] = 0x01; // Write:0x00, Read 0x01
            msg[2] = 0x02; // data count
            msg[3] = 0x34; // address
            msg[4] = 0x00; // data[0]
            msg[5] = 0x02; // data[1]
            msg[6] = 0x04; // EOT
            //int nValue = (int)szValue[4];
            byte[] response = Comm.QueryCommand(msg);
            // 응답이 있는 경우 처리
            if (response != null && response.Length > 0)
            {
                nValue = (int)response[4];
                for(int i=7; i >= 0; i--)
                {
                    int bit = (nValue >> i) & 1;
                    if (i == 0)
                    {
                        btnLightOn.LED.Value = (bit == 1);
                    }
                }
                // 필요에 따라 응답 데이터 처리 (예: 성공 여부 확인)   
                bRet = true; // 예시로 성공 플래그 설정
            }
            return bRet;
        }

        public bool LightOn()
        {
            bool bRet = false;

            byte[] msg = new byte[7];

            msg[0] = 0x01; // SOH
            msg[1] = 0x00; // Write:0x00, Read 0x01
            msg[2] = 0x02; // Data  Length
            msg[3] = 0x34; // address
            msg[4] = 0x00; // 
            msg[5] = 0x01; // 1CH --> ON
            msg[6] = 0x04; // EOT

            //int nValue = (int)szValue[4];
            byte[] response = Comm.QueryCommand(msg);
            // 응답이 있는 경우 처리
            if (response != null && response.Length > 0)
            {
                // 필요에 따라 응답 데이터 처리 (예: 성공 여부 확인)   
                bRet = true; // 예시로 성공 플래그 설정
            }

            return bRet;
        }

        public bool LightOff()
        {
            bool bRet = false;

            byte[] msg = new byte[7];

            msg[0] = 0x01; // SOH
            msg[1] = 0x00; // Write:0x00, Read 0x01
            msg[2] = 0x02; // Data  Length
            msg[3] = 0x34; // address
            msg[4] = 0x00; // 
            msg[5] = 0x00; // 0CH --> OFF
            msg[6] = 0x04; // EOT

            //int nValue = (int)szValue[4];
            byte[] response = Comm.QueryCommand(msg);
            // 응답이 있는 경우 처리
            if (response != null && response.Length > 0)
            {
                // 필요에 따라 응답 데이터 처리 (예: 성공 여부 확인)   
                bRet = true; // 예시로 성공 플래그 설정
            }
            return bRet;
        }
        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnConnect.Text = Global.iniEng.ReadString("panManualLight", "btnConnect.Text", "Connect");
            btnSet.Text = Global.iniEng.ReadString("panManualLight", "btnSet.Text", "Set");
            btnLightOn.Text = Global.iniEng.ReadString("panManualLight", "btnLightOn.Text", "On");
        }

        public void ChangeLanguageKorea()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualLight", "btnConnect.Text");
            btnSet.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualLight", "btnSet.Text");
            btnLightOn.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualLight", "btnLightOn.Text");
        }

        public void ChangeLanguageVietnam()
        {
            btnConnect.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualLight", "btnConnect.Text");
            btnSet.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualLight", "btnSet.Text");
            btnLightOn.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualLight", "btnLightOn.Text");
        }
        #endregion

        private void ReadThread_OnExecute(object sender, EventArgs e)
        {
            if (btnConnect.LED.Value)
            {
                switch (mStep)
                {
                    case 0:
                        ReadChannelValue();
                        mStep = 1;

                        ledRX.LED.Value = true;
                        ledTX.LED.Value = false;
                        break;

                    case 1:
                        ReadChannelStatus();
                        mStep = 0;

                        ledRX.LED.Value = false;
                        ledTX.LED.Value = true;
                        break;
                }
            }
        }
    }
}
