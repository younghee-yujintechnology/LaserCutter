using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using yjTech;
using Newtonsoft.Json.Linq;
using Raize.CodeSiteLogging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LaserCutter
{
    public partial class panManualMotion : UserControl
    {
        CodeSiteLogger logger;
        
        private frmMain frmMain;
        private frmChannelSpy frmChannelSpy;

        private const int INIT_ADDRESS = 1000;

        private TimeCounter Counter = new TimeCounter();
        public bool bPmacConnected = false;

        public const int green_index_0 = 0;
        public const int red_index_1 = 1;
        public const int gray_index_2 = 2;

        public panManualMotion()
        {
            InitializeComponent();

            SetCodeSitelogger();

            frmMain = frmMain.StaticInstance;
            frmChannelSpy = frmChannelSpy.StaticInstance;

            logger.Category = "Manual.Motion";

            ////bPmacConnected = Pmac.Open("192.168.0.200");

            cbSpeed.SelectedIndex = 2;  
        }

        #region staticInstance
        private static panManualMotion staticInstance;
        public static panManualMotion StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panManualMotion();
                }
                return staticInstance;
            }
        }
        #endregion

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "Manual.Motion";

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

        #region public void SetDataServer(Control.ControlCollection controls)
        public void SetDataServer(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is SunnySwitch)
                {
                    ((SunnySwitch)control).DataServer = dsIO;
                }
                else
                if (control is LEDImageLabel)
                {
                    ((LEDImageLabel)control).DataServer = dsIO;
                }
                else
                if (control is LEDImageArray)
                {
                    ((LEDImageArray)control).DataServer = dsIO;
                }
                else
                if (control is ValueIndicator)
                {
                    ((ValueIndicator)control).DataServer = dsMotion;
                }
                else
                if (control is LEDLabel)
                {
                    ((LEDLabel)control).DataServer = dsMotion;
                }
                else
                if (control is yjTech.ComboBox)
                {
                    ((yjTech.ComboBox)control).DataServer = dsMotion;
                }
                if (control.HasChildren)
                {
                    SetDataServer(control.Controls);
                }
            }
        }
        #endregion

        public void LoadVersion2ChannelInfo()
        {
        }


        public void ReadThread_OnExecute(object sender, EventArgs e)
        {

        }

        private void btnABS_Click(object sender, EventArgs e)
        {

        }

        public void SetMoveVel()
        {

        }

        public void SetMoveTATS()
        {

        }

        private void btnRelMinus_Click(object sender, EventArgs e)
        {
        }

        private void btnRelPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnServoOn_Click(object sender, EventArgs e)
        {

        }

        private void btnServoOff_Click(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnJogMinus_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnJogMinus_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnJogPlus_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnJogPlus_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void cbSpeed_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {

        }

        private void ChangeAxis(object sender, EventArgs e)
        {

        }

        private void ledIn31_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn30_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn22_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn21_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn20_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn19_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn18_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn07_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn03_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn02_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn01_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledIn00_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
Stroke

X :-3.2mm ~ 1704mm
Y1:-45.3mm ~ 864mm
Y2:-44mm ~ 866mm
Z :-13.5mm ~ 35mm

*/
