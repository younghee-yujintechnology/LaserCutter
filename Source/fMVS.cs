using YujinTechnology;
using MvCamCtrl.NET;
using MvCameraControl;
using Raize.CodeSiteLogging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class frmMVS : Form
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public static readonly int frameWidth = 2448; // 고정된 프레임 너비
        public static readonly int frameHeight = 2048; // 고정된 프레임 높이
        public static readonly int frameSize = frameWidth * frameHeight; // 고정된 프레임 크기
        public static byte[] imageData = new byte[frameSize]; // 고정된 크기의 배열

        public static Bitmap UpdateBitmap = Create8BitBitmap(frameWidth, frameHeight);

        readonly DeviceTLayerType enumTLayerType = DeviceTLayerType.MvGigEDevice
                                                 | DeviceTLayerType.MvUsbDevice
                                                 | DeviceTLayerType.MvGenTLGigEDevice
                                                 | DeviceTLayerType.MvGenTLCXPDevice
                                                 | DeviceTLayerType.MvGenTLCameraLinkDevice
                                                 | DeviceTLayerType.MvGenTLXoFDevice;

        public List<IDeviceInfo> cameraList = new List<IDeviceInfo>();

        public readonly object bitmapLock = new object();

        public IDevice camera = null;
        public int LiveIndex = 0;

        public frmMVS()
        {
            InitializeComponent();

            staticForm = this;

            FormClosing += _FormClosing;
        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        #region public static frmMVS StaticInstance
        private static frmMVS staticForm;
        public static frmMVS StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmMVS();
                }
                return staticForm;
            }
        }
        #endregion

        public void btnConnect_Click(object sender, EventArgs e)
        {
#if _MVS
            if (cameraList.Count == 0 || cbCamera.SelectedIndex == -1)
            {
                ShowErrorMsg("No device, please select", 0);
                return;
            }

            // en:Get selected device information
            IDeviceInfo deviceInfo = cameraList[cbCamera.SelectedIndex];

            try
            {
                camera = DeviceFactory.CreateDevice(deviceInfo);
                camera.StreamGrabber.FrameGrabedEvent += FrameGrabedEventHandler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create Device fail!" + ex.Message);
                return;
            }

            int result = camera.Open();
            if (result != MvError.MV_OK)
            {
                ShowErrorMsg("Open Device fail!", result);
                return;
            }

            //Determine whether it is a GigE device
            if (camera is IGigEDevice)
            {
                //Convert to Gige device
                IGigEDevice gigEDevice = camera as IGigEDevice;

                // Detection network optimal package size(It only works for the GigE camera)
                int optionPacketSize;
                result = gigEDevice.GetOptimalPacketSize(out optionPacketSize);
                if (result != MvError.MV_OK)
                {
                    ShowErrorMsg("Warning: Get Packet Size failed!", result);
                }
                else
                {
                    result = camera.Parameters.SetIntValue("GevSCPSPacketSize", (long)optionPacketSize);
                    if (result != MvError.MV_OK)
                    {
                        ShowErrorMsg("Warning: Set Packet Size failed!", result);
                    }
                }
            }

            SetCtrlWhenOpen();
            btnGetParam_Click(null, null);

            btnGrabStart_Click(null, null);

            Global.CameraInitial = true;

#endif
            btnConnect.LED.Value = true;
        }

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
#if _MVS
            if (btnGrabStart.LED.Value)
            {
                btnGrabStart_Click(null, null);
            }

            CloseCameraConnection();

            // Control Operation
            SetCtrlWhenClose();

            Global.CameraInitial = false;
#endif
            btnConnect.LED.Value = false;
        }

        #region private void InitializeCamera() 
        public void InitializeCamera()
        {
#if _MVS
            // 카메라 초기화 로직 
            GetCameraList();

            if (cameraList.Count > 0)
            {
                // 첫 번째 카메라를 자동으로 선택하여 연결 시도 
                cbCamera.SelectedIndex = 0;
            }
#endif
        }
        #endregion

        #region private void GetCameraList()
        public void GetCameraList()
        {
#if _MVS
            int nRet = DeviceEnumerator.EnumDevices(enumTLayerType, out cameraList);
             if (nRet != MvError.MV_OK)
            {
                ShowErrorMsg("Enumerate devices fail!", nRet);
                return;
            }

            cbCamera.Items.Clear();
            for (int i = 0; i < cameraList.Count; i++)
            {
                IDeviceInfo deviceInfo = cameraList[i];
                if (deviceInfo.UserDefinedName != "")
                {
                    cbCamera.Items.Add(deviceInfo.TLayerType.ToString() + ": " + deviceInfo.UserDefinedName + " (" + deviceInfo.SerialNumber + ")");
                }
                else
                {
                    cbCamera.Items.Add(deviceInfo.TLayerType.ToString() + ": " + deviceInfo.ManufacturerName + " " + deviceInfo.ModelName + " (" + deviceInfo.SerialNumber + ")");
                }
            }

            // Select the first item
            if (cameraList.Count != 0)
            {
                cbCamera.SelectedIndex = 0;
            }
#endif
        }
        #endregion

        #region private void CloseCameraConnection()
        private void CloseCameraConnection()
        {
#if _MVS

            // 카메라 연결 해제 로직 
            if (camera != null)
            {
                camera.Close();
                camera.Dispose();
                camera = null;
            }
#endif
        }
        #endregion

        #region private void FrameGrabedEventHandler(object sender, FrameGrabbedEventArgs e)
        public void FrameGrabedEventHandler(object sender, FrameGrabbedEventArgs e)
        {
#if _MVS

            lock (bitmapLock)
            {
                // IntPtr에서 byte[] 배열로 데이터 복사
                System.Runtime.InteropServices.Marshal.Copy(e.FrameOut.Image.PixelDataPtr, imageData, 0, frameSize);

                LiveIndex = LiveIndex + 1;
                LiveIndex = LiveIndex % 4;
            }
#endif

        }
        #endregion

        public void GetTriggerMode()
        {
#if _MVS

            IEnumValue enumValue;
            int result = camera.Parameters.GetEnumValue("TriggerMode", out enumValue);
            if (result == MvError.MV_OK)
            {
                if (enumValue.CurEnumEntry.Symbolic == "On")
                {
                    rdoTriggerMode.Checked = true;
                    rdoContinuesMode.Checked = false;

                    result = camera.Parameters.GetEnumValue("TriggerSource", out enumValue);
                    if (result == MvError.MV_OK)
                    {
                        if (enumValue.CurEnumEntry.Symbolic == "TriggerSoftware")
                        {
                            chkSoftTrigger.Enabled = true;
                            chkSoftTrigger.Checked = true;
                        }
                    }
                }
                else
                {
                    rdoContinuesMode.Checked = true;
                    rdoTriggerMode.Checked = false;
                }
            }
#endif
        }

        public void cbPixelFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
#if _MVS
            int result = camera.Parameters.SetEnumValueByString("PixelFormat", cbPixelFormat.Text);
            if (result != MvError.MV_OK)
            {
                ShowErrorMsg("Set PixelFormat failed!", result);
            }
#endif
        }

        private void btnGetParam_Click(object sender, EventArgs e)
        {
#if _MVS
            GetTriggerMode();

            IFloatValue floatValue;
            int result = camera.Parameters.GetFloatValue("ExposureTime", out floatValue);
            if (result == MvError.MV_OK)
            {
                edExposure.Text = floatValue.CurValue.ToString("F1");
            }

            result = camera.Parameters.GetFloatValue("Gain", out floatValue);
            if (result == MvError.MV_OK)
            {
                edGain.Text = floatValue.CurValue.ToString("F1");
            }

            result = camera.Parameters.GetFloatValue("ResultingFrameRate", out floatValue);
            if (result == MvError.MV_OK)
            {
                edFrameRate.Text = floatValue.CurValue.ToString("F1");
            }

            cbPixelFormat.Items.Clear();
            IEnumValue enumValue;
            result = camera.Parameters.GetEnumValue("PixelFormat", out enumValue);
            if (result == MvError.MV_OK)
            {
                foreach (var item in enumValue.SupportEnumEntries)
                {
                    cbPixelFormat.Items.Add(item.Symbolic);
                    if (item.Symbolic == enumValue.CurEnumEntry.Symbolic)
                    {
                        cbPixelFormat.SelectedIndex = cbPixelFormat.Items.Count - 1;
                    }
                }

            }
#endif
        }

        private void btnSetParameter_Click(object sender, EventArgs e)
        {
#if _MVS
          
            try
            {
                float.Parse(edExposure.Text);
                float.Parse(edGain.Text);
                float.Parse(edFrameRate.Text);
            }
            catch
            {
                ShowErrorMsg("Please enter correct type!", 0);
                return;
            }

            camera.Parameters.SetEnumValue("ExposureAuto", 0);
            int result = camera.Parameters.SetFloatValue("ExposureTime", float.Parse(edExposure.Text));
            if (result != MvError.MV_OK)
            {
                ShowErrorMsg("Set Exposure Time Fail!", result);
            }

            camera.Parameters.SetEnumValue("GainAuto", 0);
            result = camera.Parameters.SetFloatValue("Gain", float.Parse(edGain.Text));
            if (result != MvError.MV_OK)
            {
                ShowErrorMsg("Set Gain Fail!", result);
            }

            result = camera.Parameters.SetFloatValue("AcquisitionFrameRate", float.Parse(edFrameRate.Text));
            if (result != MvError.MV_OK)
            {
                ShowErrorMsg("Set Frame Rate Fail!", result);
            }
#endif
        }


        private void btnGetCameraList_Click(object sender, EventArgs e)
        {
            GetCameraList();
        }

        private void btnGrabStart_Click(object sender, EventArgs e)
        {
            chkUpdateThread.Checked = true;

            if (!btnGrabStart.LED.Value)
            {
                if (rdoContinuesMode.Checked)
                {
                    camera.Parameters.SetEnumValueByString("AcquisitionMode", "Continuous");
                    camera.Parameters.SetEnumValueByString("TriggerMode", "Off");
                }
                else
                if (rdoTriggerMode.Checked)
                {
                    camera.Parameters.SetEnumValueByString("AcquisitionMode", "Continuous");
                    camera.Parameters.SetEnumValueByString("TriggerMode", "On");

                    if (chkSoftTrigger.Checked)
                    {
                        camera.Parameters.SetEnumValueByString("TriggerSource", "Software");
                    }
                    else
                    {
                        camera.Parameters.SetEnumValueByString("TriggerSource", "Line0");
                    }
                }

                int result = camera.StreamGrabber.StartGrabbing();

                btnGrabStart.LED.Value = true;
            }
            btnGrabStop.LED.Value = false;
        }

        public void btnGrabStop_Click(object sender, EventArgs e)
        {
            btnGrabStart.LED.Value = false;
            btnGrabStop.LED.Value = true;

            chkUpdateThread.Checked = false;

            if (camera != null)
            {
                int result = camera.StreamGrabber.StopGrabbing();
                if (result != MvError.MV_OK)
                {
                    ShowErrorMsg("Stop Grabbing Fail!", result);
                }
            }
        }

        public void btnSoftTrigger_Click(object sender, EventArgs e)
        {
            if (camera != null)
            {
                int result = camera.Parameters.SetCommandValue("TriggerSoftware");
                if (result != MvError.MV_OK)
                {
                    ShowErrorMsg("Trigger Software Fail!", result);
                }
            }
        }

        private void rdoContinuesMode_CheckedChanged(object sender, EventArgs e)
        {
            if (camera != null)
            {
                camera.Parameters.SetEnumValueByString("AcquisitionMode", "Continuous");
                camera.Parameters.SetEnumValueByString("TriggerMode", "Off");
            }
        }

        private void rdoTriggerMode_CheckedChanged(object sender, EventArgs e)
        {
            if (camera != null)
            {
                camera.Parameters.SetEnumValueByString("AcquisitionMode", "Continuous");
                camera.Parameters.SetEnumValueByString("TriggerMode", "On");
            }
        }

        private void chkSoftTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (camera != null)
            {
                if (chkSoftTrigger.Checked)
                {
                    camera.Parameters.SetEnumValueByString("TriggerSource", "Software");
                }
                else
                {
                    camera.Parameters.SetEnumValueByString("TriggerSource", "Line0");
                }
            }
        }

        private void btnSaveBmp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.InitialDirectory = "D:";
            sd.Title = "이미지 저장 위치 지정";
            sd.DefaultExt = "bmp";
            sd.Filter = "Bmp files(*.bmp)|*.bmp";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                // imageData를 8비트 Bitmap으로 저장
                Bitmap bitmap = RawData2Bitmap(frmMVS.imageData, frmMVS.frameWidth, frmMVS.frameHeight);

                string fname = sd.FileName;
                bitmap.Save(fname, ImageFormat.Bmp);

                // 리소스 해제
                bitmap.Dispose();
            }
        }

        private void chkThreadEnabled_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThread1.Enabled = chkUpdateThread.Checked;
        }

        #region public void SetCtrlWhenOpen()
        public void SetCtrlWhenOpen()
        {
            btnConnect.Enabled = false;

            btnDisconnect.Enabled = true;
            btnGrabStart.Enabled = true;
            rdoContinuesMode.Enabled = true;
            rdoContinuesMode.Checked = true;
            rdoTriggerMode.Enabled = true;

            btnGetParam.Enabled = true;
            btnSetParameter.Enabled = true;

            edExposure.Enabled = true;
            edGain.Enabled = true;
            edFrameRate.Enabled = true;
            cbPixelFormat.Enabled = true;
        }
        #endregion

        #region public void SetCtrlWhenClose()
        public void SetCtrlWhenClose()
        {
            btnConnect.Enabled = true;

            btnDisconnect.Enabled = false;
            btnGrabStart.Enabled = false;
            rdoContinuesMode.Enabled = false;
            rdoTriggerMode.Enabled = false;

            btnSaveBmp.Enabled = false;
            edExposure.Enabled = false;
            edGain.Enabled = false;
            edFrameRate.Enabled = false;
            btnGetParam.Enabled = false;
            btnSetParameter.Enabled = false;
            cbPixelFormat.Enabled = false;
        }
        #endregion

        #region public void SetCtrlWhenStartGrab()
        public void SetCtrlWhenStartGrab()
        {
            btnGrabStart.Enabled = false;
            cbPixelFormat.Enabled = false;
            btnGrabStop.Enabled = true;

            btnSaveBmp.Enabled = true;
        }
        #endregion

        #region public void SetCtrlWhenStopGrab()
        public void SetCtrlWhenStopGrab()
        {
            btnGrabStart.Enabled = true;
            cbPixelFormat.Enabled = true;

            btnSaveBmp.Enabled = false;
        }

        #endregion

        #region private static Bitmap Create8BitBitmap(int width, int height)
        private static Bitmap Create8BitBitmap(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            ColorPalette palette = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            bitmap.Palette = palette;
            return bitmap;
        }
        #endregion

        #region private void ShowErrorMsg(string message, int errorCode)
        private void ShowErrorMsg(string message, int errorCode)
        {
            string errorMsg;
            if (errorCode == 0)
            {
                errorMsg = message;
            }
            else
            {
                errorMsg = message + ": Error =" + String.Format("{0:X}", errorCode);
            }

            switch (errorCode)
            {
                case MvError.MV_E_HANDLE: errorMsg += " Error or invalid handle "; break;
                case MvError.MV_E_SUPPORT: errorMsg += " Not supported function "; break;
                case MvError.MV_E_BUFOVER: errorMsg += " Cache is full "; break;
                case MvError.MV_E_CALLORDER: errorMsg += " Function calling order error "; break;
                case MvError.MV_E_PARAMETER: errorMsg += " Incorrect parameter "; break;
                case MvError.MV_E_RESOURCE: errorMsg += " Applying resource failed "; break;
                case MvError.MV_E_NODATA: errorMsg += " No data "; break;
                case MvError.MV_E_PRECONDITION: errorMsg += " Precondition error, or running environment changed "; break;
                case MvError.MV_E_VERSION: errorMsg += " Version mismatches "; break;
                case MvError.MV_E_NOENOUGH_BUF: errorMsg += " Insufficient memory "; break;
                case MvError.MV_E_UNKNOW: errorMsg += " Unknown error "; break;
                case MvError.MV_E_GC_GENERIC: errorMsg += " General error "; break;
                case MvError.MV_E_GC_ACCESS: errorMsg += " Node accessing condition error "; break;
                case MvError.MV_E_ACCESS_DENIED: errorMsg += " No permission "; break;
                case MvError.MV_E_BUSY: errorMsg += " Device is busy, or network disconnected "; break;
                case MvError.MV_E_NETER: errorMsg += " Network error "; break;
            }

            logger.SendMsg(errorMsg);
        }
        #endregion

        #region private Bitmap RawData2Bitmap(byte[] imageData, int width, int height)
        public static Bitmap RawData2Bitmap(byte[] imageData, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

            // 그레이스케일 팔레트 설정
            ColorPalette palette = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            bitmap.Palette = palette;

            // 이미지 데이터를 Bitmap에 복사
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            IntPtr ptr = bitmapData.Scan0;
            Marshal.Copy(imageData, 0, ptr, imageData.Length);
            bitmap.UnlockBits(bitmapData);

            return bitmap;
        }
        #endregion
    }
}
