using System;
using System.Text;
using System.Windows.Forms;

using yjTech;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panManualMotion : UserControl
    {
        CodeSiteLogger logger;

        public panManualMotion()
        {
            InitializeComponent();
        }
    }

    public static class Pmac
    {
        static public bool CommError = false;
#if _PMAC
        public const int X_AXIS_NO = 1;
        public const int Y1_AXIS_NO = 2;
        public const int Y2_AXIS_NO = 3;
        public const int Z_AXIS_NO = 5;
        public const int ALL_AXIS = 6;

        private static UInt32 mPMacID = 0;

#else
        public const int X_AXIS_NO = 1;
        public const int Y1_AXIS_NO = 2;
        public const int Y2_AXIS_NO = 3;
        public const int Z_AXIS_NO = 5;
        public const int ALL_AXIS = 6;
#endif

        static CodeSiteLogger logger;
        static public yjTech.Thread ReadThread;

        static Pmac()
        {
            SetCodeSitelogger();
        }

        public static void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Pmac";

            var fileDestination = new CodeSiteDestination();
            fileDestination.LogFile.FilePath = yjCommon.AppPath();
            fileDestination.LogFile.FileName = "LaserCutter";

            logger.Destination = fileDestination;
            logger.Destination.Viewer.Active = true;
        }

        public static void ChangeLogFilePath(String szPath)
        {
            logger.Destination.LogFile.LogByDate = false;
            logger.Destination.LogFile.Active = false;

            logger.Destination.LogFile.FilePath = szPath;

            logger.Destination.LogFile.LogByDate = true;
            logger.Destination.LogFile.Active = true;
        }

        public static bool Open(String szAddress)
        {
#if _PMAC
            UInt32 uRet;
            UInt32 uRet2;
            UInt32 uIPAddress;
            bool bConnected = false;

            uIPAddress = dkCommon.IPAddress2Integer(szAddress);
            mPMacID = PowerPMac.DTKPowerPmacOpen(uIPAddress, PowerPMac.DM_GPASCII);

            uRet2 = PowerPMac.DTKIsConnected(mPMacID, out bConnected);
            if (uRet2 == PowerPMac.DS_Ok)
            {
                if (!bConnected)
                {
                    uRet = PowerPMac.DTKConnect(mPMacID);

                    if (uRet != PowerPMac.DS_Ok)
                    {
                        PowerPMac.DTKPowerPmacClose(mPMacID);
                        mPMacID = 0xFFFFFFFF;

                        return false;
                    }
                }
            }
#endif
            return true;
        }

        /*
         * 
         */
        public static void XJogCW()
        {
            QueryCommand(String.Format("#{0}J+", X_AXIS_NO));

            return;
        }

        public static void XJogCCW()
        {
            QueryCommand(String.Format("#{0}J-", X_AXIS_NO));

            return;
        }

        public static void XMoveAbs(double APos)
        {
            logger.SendMsg(String.Format("        XMoveAbs({0:F3})", APos));

            QueryCommand(String.Format("#{0}J={1}/", X_AXIS_NO, APos * Const.XY_LINEAR_SCALE));

            return;
        }
        public static void XMoveInc(double AOffset)
        {
            logger.SendMsg(String.Format("        XMoveInc({0:F3})", AOffset));

            QueryCommand(String.Format("#{0}J:{1}/", X_AXIS_NO, AOffset * Const.XY_LINEAR_SCALE));

            return;
        }

        public static void XStop()
        {
            QueryCommand(String.Format("#{0}J/", X_AXIS_NO));

            return;
        }

        public static void XServoOn()
        {
            QueryCommand(String.Format("#{0}J/", X_AXIS_NO));

            return;
        }
        public static void XServoOff()
        {
            QueryCommand(String.Format("#{0}K", X_AXIS_NO));

            return;
        }

        public static void XSetSpeed(double dVel)
        {
            string str = string.Format("motor[{0}].JogSpeed = {1}", X_AXIS_NO, dVel);
            QueryCommand(String.Format("motor[{0}].JogSpeed = {1}", X_AXIS_NO, dVel));

            return;
        }

        public static void XSetTA(double dTA)
        {
            string str;

            str = string.Format("motor[{0}].JogTa = {1}", X_AXIS_NO, dTA);
            QueryCommand(String.Format("motor[{0}].JogTa = {1}", X_AXIS_NO, dTA));

            return;
        }
        public static void XSetTS(double dTS)
        {
            string str;

            str = string.Format("motor[{0}].JogTs = {1}", X_AXIS_NO, dTS);
            QueryCommand(String.Format("motor[{0}].JogTs = {1}", X_AXIS_NO, dTS));

            return;
        }

        public static bool XInTargetPos(double targetPos, double tolerance = 0.002)
        {
            return (Global.chXActualPos.AsDouble - tolerance < targetPos)
                    && (targetPos < Global.chXActualPos.AsDouble + tolerance);
        }

        public static bool Y1InTargetPos(double targetPos, double tolerance = 0.002)
        {
            return (Global.chY1ActualPos.AsDouble - tolerance < targetPos)
                    && (targetPos < Global.chY1ActualPos.AsDouble + tolerance);
        }

        public static bool Y2InTargetPos(double targetPos, double tolerance = 0.002)
        {
            return (Global.chY2ActualPos.AsDouble - tolerance < targetPos)
                    && (targetPos < Global.chY2ActualPos.AsDouble + tolerance);
        }

        public static bool ZInTargetPos(double targetPos, double tolerance = 0.002)
        {
            return (Global.chZActualPos.AsDouble - tolerance < targetPos)
                    && (targetPos < Global.chZActualPos.AsDouble + tolerance);
        }

        public static void XOrigin()
        {
            QueryCommand(String.Format("enable plc 15"));

            return;
        }

        /*
         * 
        */

        public static void Y1JogCW()
        {
           QueryCommand(String.Format("#{0}J+", Y1_AXIS_NO));

            return;
        }

        public static void Y1JogCCW()
        {
            QueryCommand(String.Format("#{0}J-", Y1_AXIS_NO));

            return;
        }

        public static void Y1MoveAbs(double APos)
        {
            logger.SendMsg(String.Format("        Y1MoveAbs({0:F3})", APos));
        
            QueryCommand(String.Format("#{0}J={1}/", Y1_AXIS_NO, APos * Const.XY_LINEAR_SCALE));

            return;
        }

        public static void Y1MoveInc(double AOffset)
        {            
            logger.SendMsg(String.Format("        Y1MoveInc({0:F3})", AOffset));
            QueryCommand(String.Format("#{0}J:{1}/", Y1_AXIS_NO, AOffset * Const.XY_LINEAR_SCALE));

            return;
        }

        public static void Y1Stop()
        {
            QueryCommand(String.Format("#{0}J/", Y1_AXIS_NO));

            return;
        }
        public static void Y1ServoOn()
        {
            QueryCommand(String.Format("#{0}J/", Y1_AXIS_NO));

            return;
        }
        public static void Y1ServoOff()
        {
            QueryCommand(String.Format("#{0}K", Y1_AXIS_NO));

            return;
        }
        public static void Y1SetSpeed(double dVel)
        {
            string str;

            str = string.Format("motor[{0}].JogSpeed = {1}", Y1_AXIS_NO, dVel);
            QueryCommand(String.Format("motor[{0}].JogSpeed = {1}", Y1_AXIS_NO, dVel));

            return;
        }
        public static void Y1SetTA(double dTA)
        {
            string str = string.Format("motor[{0}].JogTa = {1}", Y1_AXIS_NO, dTA);
            QueryCommand(String.Format("motor[{0}].JogTa = {1}", Y1_AXIS_NO, dTA));

            return;
        }
        public static void Y1SetTS(double dTS)
        {
            string str = string.Format("motor[{0}].JogTs = {1}", Y1_AXIS_NO, dTS);
            QueryCommand(String.Format("motor[{0}].JogTs = {1}", Y1_AXIS_NO, dTS));

            return;
        }
        public static void Y1Origin()
        {
            QueryCommand(String.Format("enable plc 16"));

            return;
        }

        /*
         * 
        */

        public static void Y2JogCW()
        {
            QueryCommand(String.Format("#{0}J+", Y2_AXIS_NO));

            return;
        }

        public static void Y2JogCCW()
        {
            QueryCommand(String.Format("#{0}J-", Y2_AXIS_NO));

            return;
        }

        public static void Y2MoveAbs(double APos)
        {
            logger.SendMsg(String.Format("        Y2MoveAbs({0:F3})", APos));
            QueryCommand(String.Format("#{0}J={1}/", Y2_AXIS_NO, APos * Const.XY_LINEAR_SCALE));
            return;
        }

        public static void Y2MoveInc(double AOffset)
        {
            logger.SendMsg(String.Format("        Y2MoveInc({0:F3})", AOffset));
            QueryCommand(String.Format("#{0}J:{1}/", Y2_AXIS_NO, AOffset * Const.XY_LINEAR_SCALE));
            return;
        }

        public static void Y2Stop()
        {
            QueryCommand(String.Format("#{0}J/", Y2_AXIS_NO));

            return;
        }
        public static void Y2ServoOn()
        {
            QueryCommand(String.Format("#{0}J/", Y2_AXIS_NO));

            return;
        }
        public static void Y2ServoOff()
        {
            QueryCommand(String.Format("#{0}K", Y2_AXIS_NO));

            return;
        }
        public static void Y2SetSpeed(double dVel)
        {
            string str = string.Format("motor[{0}].JogSpeed = {1}", Y2_AXIS_NO, dVel);
            QueryCommand(String.Format("motor[{0}].JogSpeed = {1}", Y2_AXIS_NO, dVel));

            return;
        }
        public static void Y2SetTA(double dTA)
        {
            string str = string.Format("motor[{0}].JogTa = {1}", Y2_AXIS_NO, dTA);
            QueryCommand(String.Format("motor[{0}].JogTa = {1}", Y2_AXIS_NO, dTA));

            return;
        }
        public static void Y2SetTS(double dTS)
        {
            string str = string.Format("motor[{0}].JogTs = {1}", Y2_AXIS_NO, dTS);
            QueryCommand(String.Format("motor[{0}].JogTs = {1}", Y2_AXIS_NO, dTS));

            return;
        }
        public static void Y2Origin()
        {
            QueryCommand(String.Format("enable plc 17"));

            return;
        }

        /*
         * 
        */

        public static void ZJogCW()
        {
            QueryCommand(String.Format("#{0}J+", Z_AXIS_NO));

            return;
        }

        public static void ZJogCCW()
        {
            QueryCommand(String.Format("#{0}J-", Z_AXIS_NO));

            return;
        }

        public static void ZMoveAbs(double APos)
        {
            logger.SendMsg(String.Format("        ZMoveAbs({0:F3})", APos));

            QueryCommand(String.Format("#{0}J={1}/", Z_AXIS_NO, APos * Const.Z_AXIS_SCALE));
            return;
        }

        public static void ZMoveInc(double AOffset)
        {
            logger.SendMsg(String.Format("        ZMoveInc({0:F3})", AOffset));

            QueryCommand(String.Format("#{0}J:{1}/", Z_AXIS_NO, AOffset * Const.Z_AXIS_SCALE));
            return;
        }

        public static void ZStop()
        {
            QueryCommand(String.Format("#{0}J/", Z_AXIS_NO));

            return;
        }
        public static void ZServoOn()
        {
            QueryCommand(String.Format("#{0}J/", Z_AXIS_NO));

            return;
        }
        public static void ZServoOff()
        {
            QueryCommand(String.Format("#{0}K", Z_AXIS_NO));

            return;
        }

        public static void ZSetSpeed(double dVel)
        {
            QueryCommand(String.Format("motor[{0}].JogSpeed = {1}", Z_AXIS_NO, dVel));

            return;
        }

        public static void ZSetTA(double dTA)
        {
            QueryCommand(String.Format("motor[{0}].JogTa = {1}", Z_AXIS_NO, dTA));
          
            return;
        }

        public static void ZSetTS(double dTS)
        {
            string str = string.Format("motor[{0}].JogTs = {1}", Z_AXIS_NO, dTS);
            QueryCommand(String.Format("motor[{0}].JogTs = {1}", Z_AXIS_NO, dTS));

            return;
        }

        public static void ZOrigin()
        {
            QueryCommand(String.Format("enable plc 18"));

            return;
        }

        /*
        * 
       */

        public static void AllServoOn()
        {
            QueryCommand(String.Format("#{0}..{1}j/", X_AXIS_NO, Z_AXIS_NO));

            return;
        }
        public static void AllServoOff()
        {
            QueryCommand(String.Format("#{0}..{1}K", X_AXIS_NO, Z_AXIS_NO));

            return;
        }
        public static void AllStop()
        {
            QueryCommand(String.Format("#{0}..{1}j/", X_AXIS_NO, Z_AXIS_NO));

            return;
        }
        public static void AllOrigin()
        {
            if (yjCommon.Confirm("설비를 초기화 합니다.", "확인") == DialogResult.Yes)
            {
                QueryCommand(String.Format("enable plc 15"));
                QueryCommand(String.Format("enable plc 16"));
                QueryCommand(String.Format("enable plc 17"));
                QueryCommand(String.Format("enable plc 18"));
            }
        }

  
        #region public string QueryCommand(String ACommand)
        public static string QueryCommand(String ACommand)
        {
#if _PMAC
           int r = 0;
            string Result = QueryCommand(ACommand, out r);
            
            return Result;
#else
            return "";
#endif
        }

        public static string QueryCommand(string command, out int returnValue)
        {
            string result = "";
            byte[] buffer1 = new byte[1025]; // 1024 + 1 for null terminator
            byte[] buffer2 = new byte[1025]; // 1024 + 1 for null terminator

            // 문자열을 바이트 배열로 변환 (ANSI 인코딩 사용)
            byte[] commandBytes = Encoding.Default.GetBytes(command);
            Array.Copy(commandBytes, buffer1, commandBytes.Length);

            // 외부 함수 호출
#if _PMAC
            returnValue = (int)PowerPMac.DTKGetResponseA(mPMacID, buffer1, buffer2, 1024);
            // 바이트 배열을 문자열로 변환 (null terminator를 고려)
            result = Encoding.Default.GetString(buffer2).TrimEnd('\0');

            CommError = (returnValue != 0);
#else
            returnValue = 0;
            result = "";
#endif
            return result;
        }
#endregion

        #region public void DownloadFile()
        /*
         * program.pmc File을 미리 만들어 놓고.. DownloadA()를 호출..
         * Dll Verion : PowerPmac64(2.3.16.25 Omron)에서 Download 확인

         Success:
         Upload File : D:\LaserCutter\bin\program0.pmc
         Download File : program0.pmcgpascii -2 -i"/var/ftp/usrflash/Temp/program0.pmc"// *** EOF root@192.168.0.200:/opt/ppmac# 
            
         Fail:
         Upload File : D:\LaserCutter\bin\program.pmc
         Download File : program.pmcgpascii -2 -i"/var/ftp/usrflash/Temp/program.pmc"/var/ftp/usrflash/Temp/program.pmc:3:1: error #31: invalid data:         ConveyorOffset = ((Motor[4].ActPos-Motor[4].HomePos) / Conv_sf - LastConveyorPos);root@192.168.0.200:/opt/ppmac# 
         */
        public static uint DownloadFile1(IntPtr hDownloadWnd)
        {
            String szStr = String.Format("{0}program1.pmc", yjCommon.AppPath());
#if _PMAC
            return PowerPMac.DTKDownloadA(mPMacID, szStr, true, hDownloadWnd, IntPtr.Zero, IntPtr.Zero);
#else
            return 0;
#endif
        }

        public static uint DownloadFile2(IntPtr hDownloadWnd)
        {
            String szStr = String.Format("{0}program2.pmc", yjCommon.AppPath());
#if _PMAC
            return PowerPMac.DTKDownloadA(mPMacID, szStr, true, hDownloadWnd, IntPtr.Zero, IntPtr.Zero);
#else
            return 0;
#endif
        }
        #endregion
    
    }
}

/*
Stroke

X :-3.2mm ~ 1704mm
Y1:-45.3mm ~ 864mm
Y2:-44mm ~ 866mm
Z :-13.5mm ~ 35mm

*/
