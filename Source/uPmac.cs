using System;
using System.Text;
using System.Runtime.InteropServices;

public static class PowerPMac
{
    public const int DM_GPASCII = 0;
    public const int DM_GETSENDS_0 = 1;
    public const int DM_GETSENDS_1 = 2;
    public const int DM_GETSENDS_2 = 3;
    public const int DM_GETSENDS_3 = 4;
    public const int DM_GETSENDS_4 = 5;
    public const int DM_SECURE_SHELL = 10;

    public const int DS_Ok = 0;
    public const int DS_Exception = 1;
    public const int DS_TimeOut = 2;
    public const int DS_Connected = 3;
    public const int DS_NotConnected = 4;
    public const int DS_Failed = 5;
    public const int DS_InvalidDevice = 11;
    public const int DS_LengthExceeds = 21;
    public const int DS_RunningDownload = 22;
    public const int DS_RunningRead = 23;
    public const int DS_ResLengthExceeds = 24;
    public const int DS_DATimeOut = 102;
    public const int DS_DANotConnected = 104;
    public const int DS_DAFailed = 105;

    public const int DR_Reset = 0;
    public const int DR_FullReset = 1;

    public const int WM_MESSAGE_DOWNLOAD = 0x1216;

    public const int DT_Progress = 0;
    public const int DT_StringA = 1;
    public const int DT_StringW = 2;

#if _PMAC
    private const string DLLName = "PowerPmac64.dll";

    public static void SetDllPath(string path)
    {
        if (!SetDllDirectory(path))
        {
            throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
        }
    }

    // DLL 경로 설정 함수
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool SetDllDirectory(string lpPathName);

    // 델파이 함수 선언
    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKPowerPmacOpen(uint dwIPAddress, uint uMode);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKPowerPmacClose(uint uDeviceID);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKGetDeviceCount(out int pnDeviceCount);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKGetIPAddress(uint uDeviceID, out uint pdwIPAddress);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKConnect(uint uDeviceID);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKDisconnect(uint uDeviceID);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKIsConnected(uint uDeviceID, out bool pbConnected);

    //[DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    //public static extern uint DTKGetResponseA(uint uDeviceID, string lpCommand, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpResponse, int nLength);

    [DllImport(DLLName, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKGetResponseA(uint uDeviceID, byte[] lpCommand, byte[] lpResponse, int nLength);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKGetResponseW(uint uDeviceID, [MarshalAs(UnmanagedType.LPWStr)] string lpwCommand, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpwResponse, int nLength);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKSendCommandA(uint uDeviceID, [MarshalAs(UnmanagedType.LPStr)] string lpCommand);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKSendCommandW(uint uDeviceID, [MarshalAs(UnmanagedType.LPWStr)] string lpwCommand);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKAbort(uint uDeviceID);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKDownloadA(uint uDeviceID, [MarshalAs(UnmanagedType.LPStr)] string lpDownload, bool bDownload, IntPtr hDownloadWnd, IntPtr lpDownloadProgress, IntPtr lpDownloadMessage);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern uint DTKDownloadW(uint uDeviceID, [MarshalAs(UnmanagedType.LPWStr)] string lpwDownload, bool bDownload, IntPtr hDownloadWnd, IntPtr lpDownloadProgress, IntPtr lpwDownloadMessage);

#endif

//#if _UPMAC
    private const string DLLName = "PComm64.dll";

    public static void SetDllPath(string path)
    {
        if (!SetDllDirectory(path))
        {
            throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
        }
    }

    // DLL 경로 설정 함수
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool SetDllDirectory(string lpPathName);

    // 델파이 함수 선언
    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int32 OpenPmacDevice(UInt32 dwDevice);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int32 PmacSelect(UInt32 dwDevice);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern UInt32 ClosePmacDevice(UInt32 dwDevice);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int32 PmacGetResponseA(UInt32 dwDevice, byte[] lpResponse, int nLength, byte[] lpCommand);


    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int32 PmacDownloadA(UInt32 dwDevice, IntPtr msgp, IntPtr getp, IntPtr pprg, StringBuilder filename, Int32 macro, Int32 map, Int32 log, Int32 dnld);
    

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int16 PmacDPRRotBufChange(UInt32 dwDevice, UInt16 bufnum, UInt16 size);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int16 PmacDPRRotBufRemove(UInt32 dwDevice, UInt16 bufnum);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern Int32 PmacDPRBufLast(UInt32 dwDevice);

    [DllImport(DLLName, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    //		public static extern Int16 PmacDPRAsciiStrToRotA(UInt32 dwDevice, [MarshalAs(UnmanagedType.LPStr)]String inpstr, UInt16 bufnum);
    public static extern Int16 PmacDPRAsciiStrToRotA(UInt32 dwDevice, Byte[] inpstr, UInt16 bufnum);

    //#endif
}



