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

using YujinTechnology;
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

            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(YujinTechnology.ComboBox), System.Drawing.Color.FromArgb(80, 160, 255));

            logger.Category = "Manual.Motion";

            bPmacConnected = Pmac.Open("192.168.0.200");

            SetLEDValueEvent();

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
                if (control is YujinTechnology.ComboBox)
                {
                    ((YujinTechnology.ComboBox)control).DataServer = dsMotion;
                }
                if (control.HasChildren)
                {
                    SetDataServer(control.Controls);
                }
            }
        }
        #endregion

#if _VERSION1
        public void LoadVersion1ChannelInfo()
        {
            if (frmChannelSpy != null)
            {
                dsIO.Channels.RemoveAll();

                Global.ciMainPower          = AddInput("General Input1", Const._X00);
                Global.ciEMO1               = AddInput("General Input1", Const._X01);
                Global.ciEMO2               = AddInput("General Input1", Const._X02);
                Global.ciEMO3               = AddInput("General Input1", Const._X03);
                Global.ciTable1StartSwitch  = AddInput("General Input1", Const._X04);
                Global.ciTable1VacuumSwitch = AddInput("General Input1", Const._X05);
                Global.ciTable1StopSwitch   = AddInput("General Input1", Const._X06);
                Global.ciTable1ResetSwitch  = AddInput("General Input1", Const._X07);

                Global.ciTable1PressureSensor   = AddInput("General Input2", Const._X08);
                Global.ciTable1VacuumSensor     = AddInput("General Input2", Const._X09);
                Global.ciTable2StartSwitch      = AddInput("General Input2", Const._X10);
                Global.ciTable2VacuumSwitch     = AddInput("General Input2", Const._X11);
                Global.ciTable2StopSwitch       = AddInput("General Input2", Const._X12);
                Global.ciTable2ResetSwitch      = AddInput("General Input2", Const._X13);
                Global.ciTable2PressureSensor   = AddInput("General Input2", Const._X14);
                Global.ciTable2VacuumSensor     = AddInput("General Input2", Const._X15);

                Global.ciStagePower     = AddInput("General Input3", Const._X16);
                Global.ciLeakSensor     = AddInput("General Input3", Const._X17);
                Global.ciDoorSensor1    = AddInput("General Input3", Const._X18);
                Global.ciDoorSensor2    = AddInput("General Input3", Const._X19);
                Global.ciDoorSensor3    = AddInput("General Input3", Const._X20);
                Global.ciDoorSensor4    = AddInput("General Input3", Const._X21);
                Global.ciDoorSensor5    = AddInput("General Input3", Const._X22);
                                          AddInput("General Input3", Const._X23);

                Global.ciTable1IonizerRun   = AddInput("General Input4", Const._X24);
                Global.ciTable2IonizerRun   = AddInput("General Input4", Const._X25);
                Global.ciBeamShutterOpen    = AddInput("General Input4", Const._X26);
                Global.ciBeamShutterClose   = AddInput("General Input4", Const._X27);
                Global.ciPowerMeterClose    = AddInput("General Input4", Const._X28);
                Global.ciPowerMeterOpen     = AddInput("General Input4", Const._X29);
                Global.ciTable2AreaSensor   = AddInput("General Input4", Const._X30);
                Global.ciTable1AreaSensor   = AddInput("General Input4", Const._X31);

                AddOutput("General Output1", Const._Y00);
                AddOutput("General Output1", Const._Y01);
                AddOutput("General Output1", Const._Y02);
                AddOutput("General Output1", Const._Y03);
                AddOutput("General Output1", Const._Y04);
                AddOutput("General Output1", Const._Y05);
                AddOutput("General Output1", Const._Y06);
                AddOutput("General Output1", Const._Y07);

                AddOutput("General Output2", Const._Y08);
                AddOutput("General Output2", Const._Y09);
                AddOutput("General Output2", Const._Y10);
                AddOutput("General Output2", Const._Y11);
                AddOutput("General Output2", Const._Y12);
                AddOutput("General Output2", Const._Y13);
                AddOutput("General Output2", Const._Y14);
                AddOutput("General Output2", Const._Y15);

                AddOutput("General Output3", Const._Y16);
                AddOutput("General Output3", Const._Y17);
                AddOutput("General Output3", Const._Y18);
                AddOutput("General Output3", Const._Y19);
                AddOutput("General Output3", Const._Y20);
                AddOutput("General Output3", Const._Y21);
                AddOutput("General Output3", Const._Y22);
                AddOutput("General Output3", Const._Y23);

                AddOutput("General Output4", Const._Y24);
                AddOutput("General Output4", Const._Y25);
                AddOutput("General Output4", Const._Y26);
                AddOutput("General Output4", Const._Y27);
                AddOutput("General Output4", Const._Y28);
                AddOutput("General Output4", Const._Y29);
                AddOutput("General Output4", Const._Y30);
                AddOutput("General Output4", Const._Y31);

                frmChannelSpy.propGridIO.DataServer = dsIO;
                frmChannelSpy.propGridIO.Active = true;

                // 
                String szPath = String.Format("{0}Config\\MotionChannels.csv", yjCommon.AppPath());
                if (yjCommon.FileExists(szPath))
                {
                    dsMotion.LoadFromCSV(szPath);

                    frmChannelSpy.propGridMotion.DataServer = dsMotion;
                    frmChannelSpy.propGridMotion.Active = true;
                }
            }
    }
//#endif


#elif _VERSION2
        public void LoadVersion2ChannelInfo()
        {
            if (frmChannelSpy != null)
            {
                dsIO.Channels.RemoveAll();

                Global.ciMainPower              = AddInput("Input1", Const._X00);
                Global.ciEMO1                   = AddInput("Input1", Const._X01);
                Global.ciEMO2                   = AddInput("Input1", Const._X02);
                Global.ciEMO3                   = AddInput("Input1", Const._X03);
                Global.ciTable1StartSwitch      = AddInput("Input1", Const._X04);
                Global.ciTable1VacuumSwitch     = AddInput("Input1", Const._X05);
                Global.ciTable1StopSwitch       = AddInput("Input1", Const._X06);
                Global.ciTable1ResetSwitch      = AddInput("Input1", Const._X07);

                Global.ciTable1PressureSensor   = AddInput("Input2", Const._X08);
                Global.ciTable1VacuumSensor     = AddInput("Input2", Const._X09);
                Global.ciTable2StartSwitch      = AddInput("Input2", Const._X10);
                Global.ciTable2VacuumSwitch     = AddInput("Input2", Const._X11);
                Global.ciTable2StopSwitch       = AddInput("Input2", Const._X12);
                Global.ciTable2ResetSwitch      = AddInput("Input2", Const._X13);
                Global.ciTable2PressureSensor   = AddInput("Input2", Const._X14);
                Global.ciTable2VacuumSensor     = AddInput("Input2", Const._X15);

                Global.ciStagePower             = AddInput("Input3", Const._X16);
                Global.ciLeakSensor             = AddInput("Input3", Const._X17);
                Global.ciDoorSensor1            = AddInput("Input3", Const._X18);
                Global.ciDoorSensor2            = AddInput("Input3", Const._X19);
                Global.ciDoorSensor3            = AddInput("Input3", Const._X20);
                Global.ciDoorSensor4            = AddInput("Input3", Const._X21);
                Global.ciDoorSensor5            = AddInput("Input3", Const._X22);
                                                  AddInput("Input3", Const._X23_RESERVED);

                Global.ciTable1IonizerRun       = AddInput("Input4", Const._X24);
                Global.ciTable2IonizerRun       = AddInput("Input4", Const._X25);
                Global.ciBeamShutterClose       = AddInput("Input4", Const._X26);
                Global.ciBeamShutterOpen        = AddInput("Input4", Const._X27);
                Global.ciPowerMeterOpen         = AddInput("Input4", Const._X28);
                Global.ciPowerMeterClose        = AddInput("Input4", Const._X29);
                Global.ciTable1AreaSensor       = AddInput("Input4", Const._X30);
                Global.ciTable2AreaSensor       = AddInput("Input4", Const._X31);

                Global.coSoftPowerOff           = AddOutput("Output1", Const._Y00);
                Global.coLEDLightOn             = AddOutput("Output1", Const._Y01);
                Global.coTowerLampRed           = AddOutput("Output1", Const._Y02);
                Global.coTowerLampYellow        = AddOutput("Output1", Const._Y03);
                Global.coTowerLampGreen         = AddOutput("Output1", Const._Y04);
                Global.coTowerLampBuzzer        = AddOutput("Output1", Const._Y05);
                Global.coTable1StartLamp        = AddOutput("Output1", Const._Y06);
                Global.coTable1VacuumLamp       = AddOutput("Output1", Const._Y07);

                Global.coTable1StopLamp         = AddOutput("Output2", Const._Y08);
                Global.coTable1ResetLamp        = AddOutput("Output2", Const._Y09);
                Global.coTable2StartLamp        = AddOutput("Output2", Const._Y10);
                Global.coTable2VacuumLamp       = AddOutput("Output2", Const._Y11);
                Global.coTable2StopLamp         = AddOutput("Output2", Const._Y12);
                Global.coTable2ResetLamp        = AddOutput("Output2", Const._Y13);
                Global.coTable1IonizerRun       = AddOutput("Output2", Const._Y14);
                Global.coTable1IonizerSol       = AddOutput("Output2", Const._Y15);

                Global.coTable2IonizerRun       = AddOutput("Output3", Const._Y16);
                Global.coTable2IonizerSol       = AddOutput("Output3", Const._Y17);
                Global.doBeamShutterOpen        = AddOutput("Output3", Const._Y18);
                Global.coDustCollector          = AddOutput("Output3", Const._Y19);
                Global.coOpticBoxPurge          = AddOutput("Output3", Const._Y20);
                Global.coPowerMeterCoverClose   = AddOutput("Output3", Const._Y21);
                Global.coPowerMeterCoverOpen    = AddOutput("Output3", Const._Y22);
                Global.coSelectBoard            = AddOutput("Output3", Const._Y23);

                Global.coADVON          = AddOutput("Output4", Const._Y24);
                Global.coTable1Pump1    = AddOutput("Output4", Const._Y25);
                Global.coTable1Vacuum11 = AddOutput("Output4", Const._Y26);
                Global.coTable1Vacuum12 = AddOutput("Output4", Const._Y27);
                Global.coTable1Pump2    = AddOutput("Output4", Const._Y28);
                Global.coTable1Vacuum21 = AddOutput("Output4", Const._Y29);
                Global.coTable1Vacuum22 = AddOutput("Output4", Const._Y30);
                Global.coTable2Pump1    = AddOutput("Output4", Const._Y31);

                Global.coTable2Vacuum11 = AddOutput("Output5", Const._Y32);
                Global.coTable2Vacuum12 = AddOutput("Output5", Const._Y33);
                Global.coTable2Pump2    = AddOutput("Output5", Const._Y34);
                Global.coTable2Vacuum21 = AddOutput("Output5", Const._Y35);
                Global.coTable2Vacuum22 = AddOutput("Output5", Const._Y36);

                frmChannelSpy.propGridIO.DataServer = dsIO;
                frmChannelSpy.propGridIO.Active = true;

                // 
                String szPath = String.Format("{0}Config\\MotionChannels.csv", yjCommon.AppPath());
                if (yjCommon.FileExists(szPath))
                {
                    dsMotion.LoadFromCSV(szPath);

                    frmChannelSpy.propGridMotion.DataServer = dsMotion;
                    frmChannelSpy.propGridMotion.Active = true;
                }
            }
        }
#else
      public void LoadDefaultChannelInfo()
        {
            if (frmChannelSpy != null)
            {
                dsIO.Channels.RemoveAll();

                Global.ciMainPower          = AddInput("General Input1", Const._X00);
                Global.ciEMO1               = AddInput("General Input1", Const._X01);
                Global.ciEMO2               = AddInput("General Input1", Const._X02);
                Global.ciEMO3               = AddInput("General Input1", Const._X03);
                Global.ciTable1StartSwitch  = AddInput("General Input1", Const._X04);
                Global.ciTable1VacuumSwitch = AddInput("General Input1", Const._X05);
                Global.ciTable1StopSwitch   = AddInput("General Input1", Const._X06);
                Global.ciTable1ResetSwitch  = AddInput("General Input1", Const._X07);

                Global.ciTable1PressureSensor   = AddInput("General Input2", Const._X08);
                Global.ciTable1VacuumSensor     = AddInput("General Input2", Const._X09);
                Global.ciTable2StartSwitch      = AddInput("General Input2", Const._X10);
                Global.ciTable2VacuumSwitch     = AddInput("General Input2", Const._X11);
                Global.ciTable2StopSwitch       = AddInput("General Input2", Const._X12);
                Global.ciTable2ResetSwitch      = AddInput("General Input2", Const._X13);
                Global.ciTable2PressureSensor   = AddInput("General Input2", Const._X14);
                Global.ciTable2VacuumSensor     = AddInput("General Input2", Const._X15);

                Global.ciStagePower     = AddInput("General Input3", Const._X16);
                Global.ciLeakSensor     = AddInput("General Input3", Const._X17);
                Global.ciDoorSensor1    = AddInput("General Input3", Const._X18);
                Global.ciDoorSensor2    = AddInput("General Input3", Const._X19);
                Global.ciDoorSensor3    = AddInput("General Input3", Const._X20);
                Global.ciDoorSensor4    = AddInput("General Input3", Const._X21);
                Global.ciDoorSensor5    = AddInput("General Input3", Const._X22);
                                          AddInput("General Input3", Const._X23);

                Global.ciTable1IonizerRun   = AddInput("General Input4", Const._X24);
                Global.ciTable2IonizerRun   = AddInput("General Input4", Const._X25);
                Global.ciBeamShutterOpen    = AddInput("General Input4", Const._X26);
                Global.ciBeamShutterClose   = AddInput("General Input4", Const._X27);
                Global.ciPowerMeterClose    = AddInput("General Input4", Const._X28);
                Global.ciPowerMeterOpen     = AddInput("General Input4", Const._X29);
                Global.ciTable1AreaSensor   = AddInput("General Input4", Const._X30);
                Global.ciTable2AreaSensor   = AddInput("General Input4", Const._X31);

                AddOutput("General Output1", Const._Y00);
                AddOutput("General Output1", Const._Y01);
                AddOutput("General Output1", Const._Y02);
                AddOutput("General Output1", Const._Y03);
                AddOutput("General Output1", Const._Y04);
                AddOutput("General Output1", Const._Y05);
                AddOutput("General Output1", Const._Y06);
                AddOutput("General Output1", Const._Y07);

                AddOutput("General Output2", Const._Y08);
                AddOutput("General Output2", Const._Y09);
                AddOutput("General Output2", Const._Y10);
                AddOutput("General Output2", Const._Y11);
                AddOutput("General Output2", Const._Y12);
                AddOutput("General Output2", Const._Y13);
                AddOutput("General Output2", Const._Y14);
                AddOutput("General Output2", Const._Y15);

                AddOutput("General Output3", Const._Y16);
                AddOutput("General Output3", Const._Y17);
                AddOutput("General Output3", Const._Y18);
                AddOutput("General Output3", Const._Y19);
                AddOutput("General Output3", Const._Y20);
                AddOutput("General Output3", Const._Y21);
                AddOutput("General Output3", Const._Y22);
                AddOutput("General Output3", Const._Y23);

                AddOutput("General Output4", Const._Y24);
                AddOutput("General Output4", Const._Y25);
                AddOutput("General Output4", Const._Y26);
                AddOutput("General Output4", Const._Y27);
                AddOutput("General Output4", Const._Y28);
                AddOutput("General Output4", Const._Y29);
                AddOutput("General Output4", Const._Y30);
                AddOutput("General Output4", Const._Y31);

                frmChannelSpy.propGridIO.DataServer = dsIO;
                frmChannelSpy.propGridIO.Active = true;

                // 
                String szPath = String.Format("{0}Config\\MotionChannels.csv", yjCommon.AppPath());
                if (yjCommon.FileExists(szPath))
                {
                    dsMotion.LoadFromCSV(szPath);

                    frmChannelSpy.propGridMotion.DataServer = dsMotion;
                    frmChannelSpy.propGridMotion.Active = true;
                }
            }
    }
#endif

#if _VERSION1
        public void Version1ChannelAssign()
        {
            SetDataServer(this.Controls);

            #region Input Set
            Global.ciMainPower          = dsIO.Channels.Find(Const._X00);
            Global.ciEMO1               = dsIO.Channels.Find(Const._X01);
            Global.ciEMO2               = dsIO.Channels.Find(Const._X02);
            Global.ciEMO3               = dsIO.Channels.Find(Const._X03);
            Global.ciTable1StartSwitch  = dsIO.Channels.Find(Const._X04);
            Global.ciTable1VacuumSwitch = dsIO.Channels.Find(Const._X05);
            Global.ciTable1StopSwitch   = dsIO.Channels.Find(Const._X06);
            Global.ciTable1ResetSwitch  = dsIO.Channels.Find(Const._X07);

            ledIn00.ChannelName = Global.ciMainPower.Name;
            ledIn01.ChannelName = Global.ciEMO1.Name;
            ledIn02.ChannelName = Global.ciEMO2.Name;
            ledIn03.ChannelName = Global.ciEMO3.Name;
            ledIn04.ChannelName = Global.ciTable1StartSwitch.Name;
            ledIn05.ChannelName = Global.ciTable1VacuumSwitch.Name;
            ledIn06.ChannelName = Global.ciTable1StopSwitch.Name;
            ledIn07.ChannelName = Global.ciTable1ResetSwitch.Name;

            ledIn00.OffImageIndex = gray_index_2;
            ledIn01.OffImageIndex = gray_index_2;
            ledIn02.OffImageIndex = gray_index_2;
            ledIn03.OffImageIndex = gray_index_2;
            ledIn04.OffImageIndex = gray_index_2;
            ledIn05.OffImageIndex = gray_index_2;
            ledIn06.OffImageIndex = gray_index_2;
            ledIn07.OffImageIndex = gray_index_2;

            ledIn00.OnImageIndex = green_index_0;
            ledIn01.OnImageIndex = red_index_1;
            ledIn02.OnImageIndex = red_index_1;
            ledIn03.OnImageIndex = red_index_1;
            ledIn04.OnImageIndex = green_index_0;
            ledIn05.OnImageIndex = green_index_0;
            ledIn06.OnImageIndex = green_index_0;
            ledIn07.OnImageIndex = green_index_0;

            Global.ciTable1PressureSensor   = dsIO.Channels.Find(Const._X08);
            Global.ciTable1VacuumSensor     = dsIO.Channels.Find(Const._X09);
            Global.ciTable2StartSwitch      = dsIO.Channels.Find(Const._X10);
            Global.ciTable2VacuumSwitch     = dsIO.Channels.Find(Const._X11);
            Global.ciTable2StopSwitch       = dsIO.Channels.Find(Const._X12);
            Global.ciTable2ResetSwitch      = dsIO.Channels.Find(Const._X13);
            Global.ciTable2PressureSensor   = dsIO.Channels.Find(Const._X14);
            Global.ciTable2VacuumSensor     = dsIO.Channels.Find(Const._X15);

            ledIn08.ChannelName = Global.ciTable1PressureSensor.Name;
            ledIn09.ChannelName = Global.ciTable1VacuumSensor.Name;
            ledIn10.ChannelName = Global.ciTable2StartSwitch.Name;
            ledIn11.ChannelName = Global.ciTable2VacuumSwitch.Name;
            ledIn12.ChannelName = Global.ciTable2StopSwitch.Name;
            ledIn13.ChannelName = Global.ciTable2ResetSwitch.Name;
            ledIn14.ChannelName = Global.ciTable2PressureSensor.Name;
            ledIn15.ChannelName = Global.ciTable2VacuumSensor.Name;

            ledIn08.OffImageIndex = gray_index_2;
            ledIn09.OffImageIndex = gray_index_2;
            ledIn10.OffImageIndex = gray_index_2;
            ledIn11.OffImageIndex = gray_index_2;
            ledIn12.OffImageIndex = gray_index_2;
            ledIn13.OffImageIndex = gray_index_2;
            ledIn14.OffImageIndex = gray_index_2;
            ledIn15.OffImageIndex = gray_index_2;

            ledIn08.OnImageIndex = green_index_0;
            ledIn09.OnImageIndex = green_index_0;
            ledIn10.OnImageIndex = green_index_0;
            ledIn11.OnImageIndex = green_index_0;
            ledIn12.OnImageIndex = green_index_0;
            ledIn13.OnImageIndex = green_index_0;
            ledIn14.OnImageIndex = green_index_0;
            ledIn15.OnImageIndex = green_index_0;

            Global.ciStagePower     = dsIO.Channels.Find(Const._X16);
            Global.ciLeakSensor     = dsIO.Channels.Find(Const._X17);
            Global.ciDoorSensor1    = dsIO.Channels.Find(Const._X18);
            Global.ciDoorSensor2    = dsIO.Channels.Find(Const._X19);
            Global.ciDoorSensor3    = dsIO.Channels.Find(Const._X20);
            Global.ciDoorSensor4    = dsIO.Channels.Find(Const._X21);
            Global.ciDoorSensor5    = dsIO.Channels.Find(Const._X22);

            ledIn16.Text = "Reserved";
            ledIn16.ChannelName = "Reserved";
            ledIn16.OffImageIndex = gray_index_2;
            ledIn17.ChannelName = Global.ciLeakSensor.Name;
            ledDoor1.ChannelName = Global.ciDoorSensor1.Name;
            ledDoor2.ChannelName = Global.ciDoorSensor2.Name;
            ledDoor3.ChannelName = Global.ciDoorSensor3.Name;
            ledDoor4.ChannelName = Global.ciDoorSensor4.Name;
            ledDoor5.ChannelName = Global.ciDoorSensor5.Name;
            ledIn23.ChannelName = "";

            ledIn16.OffImageIndex = green_index_0;
            ledIn17.OffImageIndex = red_index_1;
            ledDoor1.OffImageIndex = red_index_1;
            ledDoor2.OffImageIndex = red_index_1;
            ledDoor3.OffImageIndex = red_index_1;
            ledDoor4.OffImageIndex = red_index_1;
            ledDoor5.OffImageIndex = red_index_1;
            ledIn23.Text = "Reserved";
            ledIn23.ChannelName = "Reserved";
            ledIn23.OffImageIndex = gray_index_2;

            ledIn16.OnImageIndex = green_index_0;
            ledIn17.OnImageIndex = green_index_0;
            ledDoor1.OnImageIndex = green_index_0;
            ledDoor2.OnImageIndex = green_index_0;
            ledDoor3.OnImageIndex = green_index_0;
            ledDoor4.OnImageIndex = green_index_0;
            ledDoor5.OnImageIndex = green_index_0;
            ledIn23.OnImageIndex = green_index_0;

            //// Reserved

            Global.ciTable1IonizerRun   = dsIO.Channels.Find(Const._X24);
            Global.ciTable2IonizerRun   = dsIO.Channels.Find(Const._X25);
            Global.ciBeamShutterOpen    = dsIO.Channels.Find(Const._X26);
            Global.ciBeamShutterClose   = dsIO.Channels.Find(Const._X27);
            Global.ciPowerMeterClose    = dsIO.Channels.Find(Const._X28);
            Global.ciPowerMeterOpen     = dsIO.Channels.Find(Const._X29);
            Global.ciTable2AreaSensor   = dsIO.Channels.Find(Const._X30);
            Global.ciTable1AreaSensor   = dsIO.Channels.Find(Const._X31);

            ledIn24.ChannelName = Global.ciTable1IonizerRun.Name;
            ledIn25.ChannelName = Global.ciTable2IonizerRun.Name;
            ledIn26.ChannelName = Global.ciBeamShutterClose.Name;
            ledIn27.ChannelName = Global.ciBeamShutterOpen.Name;
            ledIn28.ChannelName = Global.ciPowerMeterClose.Name;
            ledIn29.ChannelName = Global.ciPowerMeterOpen.Name;
            ledIn30.ChannelName = Global.ciTable2AreaSensor.Name;
            ledIn31.ChannelName = Global.ciTable1AreaSensor.Name;

            ledIn24.OffImageIndex = 2;
            ledIn25.OffImageIndex = 2;
            ledIn26.OffImageIndex = 2;
            ledIn27.OffImageIndex = 2;
            ledIn28.OffImageIndex = 2;
            ledIn29.OffImageIndex = 2;
            ledIn30.OffImageIndex = 1;
            ledIn31.OffImageIndex = 1;

            ledIn24.OnImageIndex = green_index_0;
            ledIn25.OnImageIndex = green_index_0;
            ledIn26.OnImageIndex = green_index_0;
            ledIn27.OnImageIndex = green_index_0;
            ledIn28.OnImageIndex = green_index_0;
            ledIn29.OnImageIndex = green_index_0;
            ledIn30.OnImageIndex = green_index_0;
            ledIn31.OnImageIndex = green_index_0;

            ledArray5.OnImageIndices[0] = 0;
            ledArray5.OffImageIndices[0] = 1;
            ledArray5.OnImageIndices[1] = 1;
            ledArray5.OffImageIndices[1] = 2;
            ledArray5.OnImageIndices[2] = 0;
            ledArray5.OffImageIndices[2] = 2;
            ledArray5.OnImageIndices[3] = 0;
            ledArray5.OffImageIndices[3] = 2;
            ledArray5.OnImageIndices[4] = 0;
            ledArray5.OffImageIndices[4] = 2;
            ledArray5.OnImageIndices[5] = 0;
            ledArray5.OffImageIndices[5] = 2;
            ledArray5.OnImageIndices[6] = 0;
            ledArray5.OffImageIndices[6] = 1;
            ledArray5.OnImageIndices[7] = 0;
            ledArray5.OffImageIndices[7] = 1;

            #endregion

            #region Output Set
            switchOut0.ChannelName = Const._Y00;
            switchOut1.ChannelName = Const._Y01;
            switchOut2.ChannelName = Const._Y02;
            switchOut3.ChannelName = Const._Y03;
            switchOut4.ChannelName = Const._Y04;
            switchOut5.ChannelName = Const._Y05;
            switchOut6.ChannelName = Const._Y06;
            switchOut7.ChannelName = Const._Y07;
                                    
            switchOut8.ChannelName = Const._Y08;
            switchOut9.ChannelName = Const._Y09;
            switchOut10.ChannelName = Const._Y10;
            switchOut11.ChannelName = Const._Y11;
            switchOut12.ChannelName = Const._Y12;
            switchOut13.ChannelName = Const._Y13;
            switchOut14.ChannelName = Const._Y14;
            switchOut15.ChannelName = Const._Y15;

            switchOut16.ChannelName = Const._Y16;
            switchOut17.ChannelName = Const._Y17;
            switchOut18.ChannelName = Const._Y18;
            switchOut19.ChannelName = Const._Y19;
            switchOut20.ChannelName = Const._Y20;
            switchOut21.ChannelName = Const._Y21;
            switchOut22.ChannelName = Const._Y22;
            switchOut23.ChannelName = Const._Y23;

            switchOut24.ChannelName = Const._Y24;
            switchOut25.ChannelName = Const._Y25;
            switchOut26.ChannelName = Const._Y26;
            switchOut27.ChannelName = Const._Y27;
            switchOut28.ChannelName = Const._Y28;
            switchOut29.ChannelName = Const._Y29;
            switchOut30.ChannelName = Const._Y30;
            switchOut31.ChannelName = Const._Y31;

            // Reserved
            Global.coLEDLightOn = dsIO.Channels.Find(switchOut1.ChannelName);
            Global.coTowerLampRed = dsIO.Channels.Find(switchOut2.ChannelName);
            Global.coTowerLampYellow = dsIO.Channels.Find(switchOut3.ChannelName);
            Global.coTowerLampGreen = dsIO.Channels.Find(switchOut4.ChannelName);
            Global.coTowerLampBuzzer = dsIO.Channels.Find(switchOut5.ChannelName);
            Global.coTable1IonizerSol = dsIO.Channels.Find(switchOut6.ChannelName);
            Global.coTable2IonizerSol = dsIO.Channels.Find(switchOut7.ChannelName);

            Global.coTable1StartLamp = dsIO.Channels.Find(switchOut8.ChannelName);
            Global.coTable1VacuumLamp = dsIO.Channels.Find(switchOut9.ChannelName);
            Global.coTable1StopLamp = dsIO.Channels.Find(switchOut10.ChannelName);
            Global.coTable1ResetLamp = dsIO.Channels.Find(switchOut11.ChannelName);
            Global.coTable2StartLamp = dsIO.Channels.Find(switchOut12.ChannelName);
            Global.coTable2VacuumLamp = dsIO.Channels.Find(switchOut13.ChannelName);
            Global.coTable2StopLamp = dsIO.Channels.Find(switchOut14.ChannelName);
            Global.coTable2ResetLamp = dsIO.Channels.Find(switchOut15.ChannelName);

            // Reserved
            Global.coTable1IonizerRun = dsIO.Channels.Find(switchOut17.ChannelName);
            Global.coTable2IonizerRun = dsIO.Channels.Find(switchOut18.ChannelName);
            Global.coTable1IonizerSol = dsIO.Channels.Find(switchOut19.ChannelName);
            Global.coTable2IonizerSol = dsIO.Channels.Find(switchOut20.ChannelName);
            Global.doBeamShutterOpen = dsIO.Channels.Find(switchOut21.ChannelName);
            // Reserved
            Global.coDustCollector = dsIO.Channels.Find(switchOut23.ChannelName);

            // OpticBoxSolOn
            // OpticBoxSolOff
            Global.coPowerMeterCoverClose = dsIO.Channels.Find(switchOut24.ChannelName);
            Global.coPowerMeterCoverOpen = dsIO.Channels.Find(switchOut25.ChannelName);
            Global.coADVON = dsIO.Channels.Find(switchOut26.ChannelName);
            Global.coSelectBoard = dsIO.Channels.Find(switchOut27.ChannelName);
            // Reserved
            // Reserved

            viXVelocity.ChannelName = "X.Velocity";
            viY1Velocity.ChannelName = "Y1.Velocity";
            viY2Velocity.ChannelName = "Y2.Velocity";
            viZVelocity.ChannelName = "Z.Velocity";

            viXPosition.ChannelName = "X.Position";
            viY1Position.ChannelName = "Y1.Position";
            viY2Position.ChannelName = "Y2.Position";
            viZPosition.ChannelName = "Z.Position";
            viCurPosition.ChannelName = "Jog_CurPos";

            ledXServo.ChannelName = "X.ServoOn";
            ledXMotionDone.ChannelName = "X.MotionDone";
            ledXInposition.ChannelName = "X.InPosition";
            ledXHome.ChannelName = "X.Home";
            ledXCCW.ChannelName = "X.CCW";
            ledXCW.ChannelName = "X.CW";
            ledXAlarm.ChannelName = "X.Alarm";

            ledY1Servo.ChannelName = "Y1.ServoOn";
            ledY1MotionDone.ChannelName = "Y1.MotionDone";
            ledY1Inposition.ChannelName = "Y1.InPosition";
            ledY1Home.ChannelName = "Y1.Home";
            ledY1CCW.ChannelName = "Y1.CCW";
            ledY1CW.ChannelName = "Y1.CW";
            ledY1Alarm.ChannelName = "Y1.Alarm";

            ledY2Servo.ChannelName = "Y2.ServoOn";
            ledY2MotionDone.ChannelName = "Y2.MotionDone";
            ledY2Inposition.ChannelName = "Y2.InPosition";
            ledY2Home.ChannelName = "Y2.Home";
            ledY2CCW.ChannelName = "Y2.CCW";
            ledY2CW.ChannelName = "Y2.CW";
            ledY2Alarm.ChannelName = "Y2.Alarm";

            ledZServo.ChannelName = "Z.ServoOn";
            ledZMotionDone.ChannelName = "Z.MotionDone";
            ledZInposition.ChannelName = "Z.Inposition";
            ledZHome.ChannelName = "Z.Home";
            ledZCW.ChannelName = "Z.CCW";
            ledZCCW.ChannelName = "Z.CW";
            ledZAlarm.ChannelName = "Z.Alarm";

            cbSpeed.ChannelName = "SelectSpeed";

            Global.chXActualVel = dsMotion.Channels.Find(viXVelocity.ChannelName);
            Global.chY1ActualVel = dsMotion.Channels.Find(viY1Velocity.ChannelName);
            Global.chY2ActualVel = dsMotion.Channels.Find(viY2Velocity.ChannelName);
            Global.chZActualVel = dsMotion.Channels.Find(viZVelocity.ChannelName);
            Global.chXActualPos = dsMotion.Channels.Find(viXPosition.ChannelName);
            Global.chY1ActualPos = dsMotion.Channels.Find(viY1Position.ChannelName);
            Global.chY2ActualPos = dsMotion.Channels.Find(viY2Position.ChannelName);
            Global.chZActualPos = dsMotion.Channels.Find(viZPosition.ChannelName);

            Global.chXServoOn = dsMotion.Channels.Find(ledXServo.ChannelName);
            Global.chY1ServoOn = dsMotion.Channels.Find(ledY1Servo.ChannelName);
            Global.chY2ServoOn = dsMotion.Channels.Find(ledY2Servo.ChannelName);
            Global.chZServoOn = dsMotion.Channels.Find(ledZServo.ChannelName);

            Global.chXServoOn.AsBoolean = true;
            Global.chY1ServoOn.AsBoolean = true;
            Global.chY2ServoOn.AsBoolean = true;
            Global.chZServoOn.AsBoolean = true;

            Global.chXMotionDone = dsMotion.Channels.Find(ledXMotionDone.ChannelName);
            Global.chY1MotionDone = dsMotion.Channels.Find(ledY1MotionDone.ChannelName);
            Global.chY2MotionDone = dsMotion.Channels.Find(ledY2MotionDone.ChannelName);
            Global.chZMotionDone = dsMotion.Channels.Find(ledZMotionDone.ChannelName);

            Global.chXInPosition = dsMotion.Channels.Find(ledXInposition.ChannelName);
            Global.chY1InPosition = dsMotion.Channels.Find(ledY1Inposition.ChannelName);
            Global.chY2InPosition = dsMotion.Channels.Find(ledY2Inposition.ChannelName);
            Global.chZInPosition = dsMotion.Channels.Find(ledZInposition.ChannelName);

            Global.chXHome = dsMotion.Channels.Find(ledXHome.ChannelName);
            Global.chY1Home = dsMotion.Channels.Find(ledY1Home.ChannelName);
            Global.chY2Home = dsMotion.Channels.Find(ledY2Home.ChannelName);
            Global.chZHome = dsMotion.Channels.Find(ledZHome.ChannelName);

            Global.chXCCW = dsMotion.Channels.Find(ledXCCW.ChannelName);
            Global.chY1CCW = dsMotion.Channels.Find(ledY1CCW.ChannelName);
            Global.chY2CCW = dsMotion.Channels.Find(ledY2CCW.ChannelName);
            Global.chZCCW = dsMotion.Channels.Find(ledZCCW.ChannelName);

            Global.chXCCW.AsBoolean = false;
            Global.chY1CCW.AsBoolean = false;
            Global.chY2CCW.AsBoolean = false;
            Global.chZCCW.AsBoolean = false;

            Global.chXCW = dsMotion.Channels.Find(ledXCW.ChannelName);
            Global.chY1CW = dsMotion.Channels.Find(ledY1CW.ChannelName);
            Global.chY2CW = dsMotion.Channels.Find(ledY2CW.ChannelName);
            Global.chZCW = dsMotion.Channels.Find(ledZCW.ChannelName);

            Global.chXCW.AsBoolean = false;
            Global.chY1CW.AsBoolean = false;
            Global.chY2CW.AsBoolean = false;
            Global.chZCW.AsBoolean = false;

            Global.chXAlarm = dsMotion.Channels.Find(ledXAlarm.ChannelName);
            Global.chY1Alarm = dsMotion.Channels.Find(ledY1Alarm.ChannelName);
            Global.chY2Alarm = dsMotion.Channels.Find(ledY2Alarm.ChannelName);
            Global.chZAlarm = dsMotion.Channels.Find(ledZAlarm.ChannelName);

            Global.chXAlarm.AsBoolean = false;
            Global.chY1Alarm.AsBoolean = false;
            Global.chY2Alarm.AsBoolean = false;
            Global.chZAlarm.AsBoolean = false;

            Global.chCurPosition = dsMotion.Channels.Find(viCurPosition.ChannelName);
            Global.chSelectSpeed = dsMotion.Channels.Find(cbSpeed.ChannelName);

            #endregion

            if (bPmacConnected )
            {
                ReadVersion1Input();
                ReadVersion1Output();
                ReadMotorStatus();
            }

        }
//#endif
#elif _VERSION2
        public void Version2ChannelAssign()
        {
            SetDataServer(this.Controls);

            #region Input Set
            Global.ciMainPower          = dsIO.Channels.Find(Const._X00);
            Global.ciEMO1               = dsIO.Channels.Find(Const._X01);
            Global.ciEMO2               = dsIO.Channels.Find(Const._X02);
            Global.ciEMO3               = dsIO.Channels.Find(Const._X03);
            Global.ciTable1StartSwitch  = dsIO.Channels.Find(Const._X04);
            Global.ciTable1VacuumSwitch = dsIO.Channels.Find(Const._X05);
            Global.ciTable1StopSwitch   = dsIO.Channels.Find(Const._X06);
            Global.ciTable1ResetSwitch  = dsIO.Channels.Find(Const._X07);

            ledIn00.ChannelName = Global.ciMainPower.Name;
            ledIn01.ChannelName = Global.ciEMO1.Name;
            ledIn02.ChannelName = Global.ciEMO2.Name;
            ledIn03.ChannelName = Global.ciEMO3.Name;
            ledIn04.ChannelName = Global.ciTable1StartSwitch.Name;
            ledIn05.ChannelName = Global.ciTable1VacuumSwitch.Name;
            ledIn06.ChannelName = Global.ciTable1StopSwitch.Name;
            ledIn07.ChannelName = Global.ciTable1ResetSwitch.Name;

            ledIn00.OffImageIndex = gray_index_2;
            ledIn01.OffImageIndex = gray_index_2;
            ledIn02.OffImageIndex = gray_index_2;
            ledIn03.OffImageIndex = gray_index_2;
            ledIn04.OffImageIndex = gray_index_2;
            ledIn05.OffImageIndex = gray_index_2;
            ledIn06.OffImageIndex = gray_index_2;
            ledIn07.OffImageIndex = gray_index_2;

            ledIn00.OnImageIndex = green_index_0;
            ledIn01.OnImageIndex = red_index_1;
            ledIn02.OnImageIndex = red_index_1;
            ledIn03.OnImageIndex = red_index_1;
            ledIn04.OnImageIndex = green_index_0;
            ledIn05.OnImageIndex = green_index_0;
            ledIn06.OnImageIndex = green_index_0;
            ledIn07.OnImageIndex = green_index_0;

            Global.ciTable1PressureSensor = dsIO.Channels.Find(Const._X08);
            Global.ciTable1VacuumSensor = dsIO.Channels.Find(Const._X09);
            Global.ciTable2StartSwitch = dsIO.Channels.Find(Const._X10);
            Global.ciTable2VacuumSwitch = dsIO.Channels.Find(Const._X11);
            Global.ciTable2StopSwitch = dsIO.Channels.Find(Const._X12);
            Global.ciTable2ResetSwitch = dsIO.Channels.Find(Const._X13);
            Global.ciTable2PressureSensor = dsIO.Channels.Find(Const._X14);
            Global.ciTable2VacuumSensor = dsIO.Channels.Find(Const._X15);

            ledIn08.ChannelName = Global.ciTable1PressureSensor.Name;
            ledIn09.ChannelName = Global.ciTable1VacuumSensor.Name;
            ledIn10.ChannelName = Global.ciTable2StartSwitch.Name;
            ledIn11.ChannelName = Global.ciTable2VacuumSwitch.Name;
            ledIn12.ChannelName = Global.ciTable2StopSwitch.Name;
            ledIn13.ChannelName = Global.ciTable2ResetSwitch.Name;
            ledIn14.ChannelName = Global.ciTable2PressureSensor.Name;
            ledIn15.ChannelName = Global.ciTable2VacuumSensor.Name;

            ledIn08.OffImageIndex = gray_index_2;
            ledIn09.OffImageIndex = gray_index_2;
            ledIn10.OffImageIndex = gray_index_2;
            ledIn11.OffImageIndex = gray_index_2;
            ledIn12.OffImageIndex = gray_index_2;
            ledIn13.OffImageIndex = gray_index_2;
            ledIn14.OffImageIndex = gray_index_2;
            ledIn15.OffImageIndex = gray_index_2;

            ledIn08.OnImageIndex = green_index_0;
            ledIn09.OnImageIndex = green_index_0;
            ledIn10.OnImageIndex = green_index_0;
            ledIn11.OnImageIndex = green_index_0;
            ledIn12.OnImageIndex = green_index_0;
            ledIn13.OnImageIndex = green_index_0;
            ledIn14.OnImageIndex = green_index_0;
            ledIn15.OnImageIndex = green_index_0;

            Global.ciStagePower = dsIO.Channels.Find(Const._X16);
            Global.ciLeakSensor = dsIO.Channels.Find(Const._X17);
            Global.ciDoorSensor1 = dsIO.Channels.Find(Const._X18);
            Global.ciDoorSensor2 = dsIO.Channels.Find(Const._X19);
            Global.ciDoorSensor3 = dsIO.Channels.Find(Const._X20);
            Global.ciDoorSensor4 = dsIO.Channels.Find(Const._X21);
            Global.ciDoorSensor5 = dsIO.Channels.Find(Const._X22);

            ledIn16.ChannelName = Global.ciStagePower.Name;
            ledIn17.ChannelName = Global.ciLeakSensor.Name;
            ledDoor1.ChannelName = Global.ciDoorSensor1.Name;
            ledDoor2.ChannelName = Global.ciDoorSensor2.Name;
            ledDoor3.ChannelName = Global.ciDoorSensor3.Name;
            ledDoor4.ChannelName = Global.ciDoorSensor4.Name;
            ledDoor5.ChannelName = Global.ciDoorSensor5.Name;
            ledIn23.ChannelName = "";

            ledIn16.OffImageIndex = green_index_0;
            ledIn17.OffImageIndex = red_index_1;
            ledDoor1.OffImageIndex = red_index_1;
            ledDoor2.OffImageIndex = red_index_1;
            ledDoor3.OffImageIndex = red_index_1;
            ledDoor4.OffImageIndex = red_index_1;
            ledDoor5.OffImageIndex = red_index_1;
            ledIn23.OffImageIndex = gray_index_2;

            ledIn16.OnImageIndex = green_index_0;
            ledIn17.OnImageIndex = green_index_0;
            ledDoor1.OnImageIndex = green_index_0;
            ledDoor2.OnImageIndex = green_index_0;
            ledDoor3.OnImageIndex = green_index_0;
            ledDoor4.OnImageIndex = green_index_0;
            ledDoor5.OnImageIndex = green_index_0;
            ledIn23.OnImageIndex = green_index_0;

            //// Reserved

            Global.ciTable1IonizerRun = dsIO.Channels.Find(Const._X24);
            Global.ciTable2IonizerRun = dsIO.Channels.Find(Const._X25);
            Global.ciBeamShutterClose = dsIO.Channels.Find(Const._X26);
            Global.ciBeamShutterOpen = dsIO.Channels.Find(Const._X27);
            Global.ciPowerMeterOpen = dsIO.Channels.Find(Const._X28);
            Global.ciPowerMeterClose = dsIO.Channels.Find(Const._X29);
            Global.ciTable1AreaSensor = dsIO.Channels.Find(Const._X30);
            Global.ciTable2AreaSensor = dsIO.Channels.Find(Const._X31);

            ledIn24.ChannelName = Global.ciTable1IonizerRun.Name;
            ledIn25.ChannelName = Global.ciTable2IonizerRun.Name;
            ledIn26.ChannelName = Global.ciBeamShutterClose.Name;
            ledIn27.ChannelName = Global.ciBeamShutterOpen.Name;
            ledIn28.ChannelName = Global.ciPowerMeterOpen.Name;
            ledIn29.ChannelName = Global.ciPowerMeterClose.Name;
            ledIn30.ChannelName = Global.ciTable1AreaSensor.Name;
            ledIn31.ChannelName = Global.ciTable2AreaSensor.Name;

            ledIn24.OffImageIndex = 2;
            ledIn25.OffImageIndex = 2;
            ledIn26.OffImageIndex = 2;
            ledIn27.OffImageIndex = 2;
            ledIn28.OffImageIndex = 2;
            ledIn29.OffImageIndex = 2;
            ledIn30.OffImageIndex = 1;
            ledIn31.OffImageIndex = 1;

            ledIn24.OnImageIndex = green_index_0;
            ledIn25.OnImageIndex = green_index_0;
            ledIn26.OnImageIndex = green_index_0;
            ledIn27.OnImageIndex = green_index_0;
            ledIn28.OnImageIndex = green_index_0;
            ledIn29.OnImageIndex = green_index_0;
            ledIn30.OnImageIndex = green_index_0;
            ledIn31.OnImageIndex = green_index_0;

            ledArray5.OnImageIndices[0] = gray_index_2;
            ledArray5.OffImageIndices[0] = gray_index_2;
            ledArray5.OnImageIndices[1] = gray_index_2;
            ledArray5.OffImageIndices[1] = gray_index_2;
            ledArray5.OnImageIndices[2] = gray_index_2;
            ledArray5.OffImageIndices[2] = gray_index_2;
            ledArray5.OnImageIndices[3] = gray_index_2;
            ledArray5.OffImageIndices[3] = gray_index_2;
            ledArray5.OnImageIndices[4] = gray_index_2;
            ledArray5.OffImageIndices[4] = gray_index_2;
            ledArray5.OnImageIndices[5] = gray_index_2;
            ledArray5.OffImageIndices[5] = gray_index_2;
            ledArray5.OnImageIndices[6] = gray_index_2;
            ledArray5.OffImageIndices[6] = gray_index_2;
            ledArray5.OnImageIndices[7] = gray_index_2;
            ledArray5.OffImageIndices[7] = gray_index_2;

            ledArray6.OnImageIndices[0] = gray_index_2;
            ledArray6.OffImageIndices[0] = gray_index_2;
            ledArray6.OnImageIndices[1] = gray_index_2;
            ledArray6.OffImageIndices[1] = gray_index_2;
            ledArray6.OnImageIndices[2] = gray_index_2;
            ledArray6.OffImageIndices[2] = gray_index_2;
            ledArray6.OnImageIndices[3] = gray_index_2;
            ledArray6.OffImageIndices[3] = gray_index_2;
            ledArray6.OnImageIndices[4] = gray_index_2;
            ledArray6.OffImageIndices[4] = gray_index_2;
            ledArray6.OnImageIndices[5] = gray_index_2;
            ledArray6.OffImageIndices[5] = gray_index_2;
            ledArray6.OnImageIndices[6] = gray_index_2;
            ledArray6.OffImageIndices[6] = gray_index_2;
            ledArray6.OnImageIndices[7] = gray_index_2;
            ledArray6.OffImageIndices[7] = gray_index_2;

            ledArray7.OnImageIndices[0] = gray_index_2;
            ledArray7.OffImageIndices[0] = gray_index_2;
            ledArray7.OnImageIndices[1] = gray_index_2;
            ledArray7.OffImageIndices[1] = gray_index_2;
            ledArray7.OnImageIndices[2] = gray_index_2;
            ledArray7.OffImageIndices[2] = gray_index_2;
            ledArray7.OnImageIndices[3] = gray_index_2;
            ledArray7.OffImageIndices[3] = gray_index_2;
            ledArray7.OnImageIndices[4] = gray_index_2;
            ledArray7.OffImageIndices[4] = gray_index_2;
            ledArray7.OnImageIndices[5] = gray_index_2;
            ledArray7.OffImageIndices[5] = gray_index_2;
            ledArray7.OnImageIndices[6] = gray_index_2;
            ledArray7.OffImageIndices[6] = gray_index_2;
            ledArray7.OnImageIndices[7] = gray_index_2;
            ledArray7.OffImageIndices[7] = gray_index_2;

            ledArray8.OnImageIndices[0] = gray_index_2;
            ledArray8.OffImageIndices[0] = gray_index_2;
            ledArray8.OnImageIndices[1] = gray_index_2;
            ledArray8.OffImageIndices[1] = gray_index_2;
            ledArray8.OnImageIndices[2] = gray_index_2;
            ledArray8.OffImageIndices[2] = gray_index_2;
            ledArray8.OnImageIndices[3] = gray_index_2;
            ledArray8.OffImageIndices[3] = gray_index_2;
            ledArray8.OnImageIndices[4] = gray_index_2;
            ledArray8.OffImageIndices[4] = gray_index_2;
            ledArray8.OnImageIndices[5] = gray_index_2;
            ledArray8.OffImageIndices[5] = gray_index_2;
            ledArray8.OnImageIndices[6] = gray_index_2;
            ledArray8.OffImageIndices[6] = gray_index_2;
            ledArray8.OnImageIndices[7] = gray_index_2;
            ledArray8.OffImageIndices[7] = gray_index_2;
            #endregion

            #region Output Set
            switchOut0.ChannelName = Const._Y00;
            switchOut1.ChannelName = Const._Y01;
            switchOut2.ChannelName = Const._Y02;
            switchOut3.ChannelName = Const._Y03;
            switchOut4.ChannelName = Const._Y04;
            switchOut5.ChannelName = Const._Y05;
            switchOut6.ChannelName = Const._Y06;
            switchOut7.ChannelName = Const._Y07;

            switchOut8.ChannelName = Const._Y08;
            switchOut9.ChannelName = Const._Y09;
            switchOut10.ChannelName = Const._Y10;
            switchOut11.ChannelName = Const._Y11;
            switchOut12.ChannelName = Const._Y12;
            switchOut13.ChannelName = Const._Y13;
            switchOut14.ChannelName = Const._Y14;
            switchOut15.ChannelName = Const._Y15;

            switchOut16.ChannelName = Const._Y16;
            switchOut17.ChannelName = Const._Y17;
            switchOut18.ChannelName = Const._Y18;
            switchOut19.ChannelName = Const._Y19;
            switchOut20.ChannelName = Const._Y20;
            switchOut21.ChannelName = Const._Y21;
            switchOut22.ChannelName = Const._Y22;
            switchOut23.ChannelName = Const._Y23;

            switchOut24.ChannelName = Const._Y24;
            switchOut25.ChannelName = Const._Y25;
            switchOut26.ChannelName = Const._Y26;
            switchOut27.ChannelName = Const._Y27;
            switchOut28.ChannelName = Const._Y28;
            switchOut29.ChannelName = Const._Y29;
            switchOut30.ChannelName = Const._Y30;
            switchOut31.ChannelName = Const._Y31;

            switchOut32.ChannelName = Const._Y32;
            switchOut33.ChannelName = Const._Y33;
            switchOut34.ChannelName = Const._Y34;
            switchOut35.ChannelName = Const._Y35;
            switchOut36.ChannelName = Const._Y36;
            switchOut37.ChannelName = Const._Y37;
            switchOut38.ChannelName = Const._Y38;    

            Global.coSoftPowerOff = dsIO.Channels.Find(switchOut0.ChannelName);
            Global.coLEDLightOn = dsIO.Channels.Find(switchOut1.ChannelName);
            Global.coTowerLampRed = dsIO.Channels.Find(switchOut2.ChannelName);
            Global.coTowerLampYellow = dsIO.Channels.Find(switchOut3.ChannelName);
            Global.coTowerLampGreen = dsIO.Channels.Find(switchOut4.ChannelName);
            Global.coTowerLampBuzzer = dsIO.Channels.Find(switchOut5.ChannelName);
            Global.coTable1StartLamp = dsIO.Channels.Find(switchOut6.ChannelName);
            Global.coTable1VacuumLamp = dsIO.Channels.Find(switchOut7.ChannelName);

            Global.coTable1StopLamp = dsIO.Channels.Find(switchOut8.ChannelName);
            Global.coTable1ResetLamp = dsIO.Channels.Find(switchOut9.ChannelName);
            Global.coTable2StartLamp = dsIO.Channels.Find(switchOut10.ChannelName);
            Global.coTable2VacuumLamp = dsIO.Channels.Find(switchOut11.ChannelName);
            Global.coTable2StopLamp = dsIO.Channels.Find(switchOut12.ChannelName);
            Global.coTable2ResetLamp = dsIO.Channels.Find(switchOut13.ChannelName);
            Global.coTable1IonizerRun = dsIO.Channels.Find(switchOut14.ChannelName);
            Global.coTable1IonizerSol = dsIO.Channels.Find(switchOut15.ChannelName);

            Global.coTable2IonizerRun = dsIO.Channels.Find(switchOut16.ChannelName);
            Global.coTable2IonizerSol = dsIO.Channels.Find(switchOut17.ChannelName);
            Global.doBeamShutterOpen = dsIO.Channels.Find(switchOut18.ChannelName);
            Global.coDustCollector = dsIO.Channels.Find(switchOut19.ChannelName);
            Global.coOpticBoxPurge = dsIO.Channels.Find(switchOut20.ChannelName);
            Global.coPowerMeterCoverClose = dsIO.Channels.Find(switchOut21.ChannelName);
            Global.coPowerMeterCoverOpen = dsIO.Channels.Find(switchOut22.ChannelName);
            Global.coSelectBoard = dsIO.Channels.Find(switchOut23.ChannelName);

            Global.coADVON = dsIO.Channels.Find(switchOut24.ChannelName);
            Global.coTable1Pump1 = dsIO.Channels.Find(switchOut25.ChannelName);
            Global.coTable1Vacuum11 = dsIO.Channels.Find(switchOut26.ChannelName);
            Global.coTable1Vacuum12 = dsIO.Channels.Find(switchOut27.ChannelName);
            Global.coTable1Pump2 = dsIO.Channels.Find(switchOut28.ChannelName);
            Global.coTable1Vacuum21 = dsIO.Channels.Find(switchOut29.ChannelName);
            Global.coTable1Vacuum22 = dsIO.Channels.Find(switchOut30.ChannelName);
            Global.coTable2Pump1 = dsIO.Channels.Find(switchOut31.ChannelName);

            Global.coTable2Vacuum11 = dsIO.Channels.Find(switchOut32.ChannelName);
            Global.coTable2Vacuum12 = dsIO.Channels.Find(switchOut33.ChannelName);
            Global.coTable2Pump2 = dsIO.Channels.Find(switchOut34.ChannelName);
            Global.coTable2Vacuum21 = dsIO.Channels.Find(switchOut35.ChannelName);
            Global.coTable2Vacuum22 = dsIO.Channels.Find(switchOut36.ChannelName);

            switchOut37.Text = switchOut37.ChannelName;
            switchOut38.Text = switchOut38.ChannelName;
            switchOut39.Text = switchOut39.ChannelName;
            switchOut40.Text = switchOut40.ChannelName;
            switchOut41.Text = switchOut41.ChannelName;
            switchOut42.Text = switchOut42.ChannelName;
            switchOut43.Text = switchOut43.ChannelName;
            switchOut44.Text = switchOut44.ChannelName;
            switchOut45.Text = switchOut45.ChannelName;
            switchOut46.Text = switchOut46.ChannelName;
            switchOut47.Text = switchOut47.ChannelName;
            switchOut48.Text = switchOut48.ChannelName;
            switchOut49.Text = switchOut49.ChannelName;
            switchOut50.Text = switchOut50.ChannelName;
            switchOut51.Text = switchOut51.ChannelName;
            switchOut52.Text = switchOut52.ChannelName;
            switchOut53.Text = switchOut53.ChannelName;
            switchOut54.Text = switchOut54.ChannelName;
            switchOut55.Text = switchOut55.ChannelName;
            switchOut56.Text = switchOut56.ChannelName;
            switchOut57.Text = switchOut57.ChannelName;
            switchOut58.Text = switchOut58.ChannelName;
            switchOut59.Text = switchOut59.ChannelName;
            switchOut60.Text = switchOut60.ChannelName;
            switchOut61.Text = switchOut61.ChannelName;
            switchOut62.Text = switchOut62.ChannelName;
            switchOut63.Text = switchOut63.ChannelName;

            viXVelocity.ChannelName = "X.Velocity";
            viY1Velocity.ChannelName = "Y1.Velocity";
            viY2Velocity.ChannelName = "Y2.Velocity";
            viZVelocity.ChannelName = "Z.Velocity";

            viXPosition.ChannelName = "X.Position";
            viY1Position.ChannelName = "Y1.Position";
            viY2Position.ChannelName = "Y2.Position";
            viZPosition.ChannelName = "Z.Position";
            viCurPosition.ChannelName = "Jog_CurPos";

            ledXServo.ChannelName = "X.ServoOn";
            ledXMotionDone.ChannelName = "X.MotionDone";
            ledXInposition.ChannelName = "X.InPosition";
            ledXHome.ChannelName = "X.Home";
            ledXCCW.ChannelName = "X.CCW";
            ledXCW.ChannelName = "X.CW";
            ledXAlarm.ChannelName = "X.Alarm";

            ledY1Servo.ChannelName = "Y1.ServoOn";
            ledY1MotionDone.ChannelName = "Y1.MotionDone";
            ledY1Inposition.ChannelName = "Y1.InPosition";
            ledY1Home.ChannelName = "Y1.Home";
            ledY1CCW.ChannelName = "Y1.CCW";
            ledY1CW.ChannelName = "Y1.CW";
            ledY1Alarm.ChannelName = "Y1.Alarm";

            ledY2Servo.ChannelName = "Y2.ServoOn";
            ledY2MotionDone.ChannelName = "Y2.MotionDone";
            ledY2Inposition.ChannelName = "Y2.InPosition";
            ledY2Home.ChannelName = "Y2.Home";
            ledY2CCW.ChannelName = "Y2.CCW";
            ledY2CW.ChannelName = "Y2.CW";
            ledY2Alarm.ChannelName = "Y2.Alarm";

            ledZServo.ChannelName = "Z.ServoOn";
            ledZMotionDone.ChannelName = "Z.MotionDone";
            ledZInposition.ChannelName = "Z.Inposition";
            ledZHome.ChannelName = "Z.Home";
            ledZCW.ChannelName = "Z.CCW";
            ledZCCW.ChannelName = "Z.CW";
            ledZAlarm.ChannelName = "Z.Alarm";

            cbSpeed.ChannelName = "SelectSpeed";

            Global.chXActualVel = dsMotion.Channels.Find(viXVelocity.ChannelName);
            Global.chY1ActualVel = dsMotion.Channels.Find(viY1Velocity.ChannelName);
            Global.chY2ActualVel = dsMotion.Channels.Find(viY2Velocity.ChannelName);
            Global.chZActualVel = dsMotion.Channels.Find(viZVelocity.ChannelName);
            Global.chXActualPos = dsMotion.Channels.Find(viXPosition.ChannelName);
            Global.chY1ActualPos = dsMotion.Channels.Find(viY1Position.ChannelName);
            Global.chY2ActualPos = dsMotion.Channels.Find(viY2Position.ChannelName);
            Global.chZActualPos = dsMotion.Channels.Find(viZPosition.ChannelName);

            Global.chXServoOn = dsMotion.Channels.Find(ledXServo.ChannelName);
            Global.chY1ServoOn = dsMotion.Channels.Find(ledY1Servo.ChannelName);
            Global.chY2ServoOn = dsMotion.Channels.Find(ledY2Servo.ChannelName);
            Global.chZServoOn = dsMotion.Channels.Find(ledZServo.ChannelName);

            Global.chXServoOn.AsBoolean = true;
            Global.chY1ServoOn.AsBoolean = true;
            Global.chY2ServoOn.AsBoolean = true;
            Global.chZServoOn.AsBoolean = true;

            Global.chXMotionDone = dsMotion.Channels.Find(ledXMotionDone.ChannelName);
            Global.chY1MotionDone = dsMotion.Channels.Find(ledY1MotionDone.ChannelName);
            Global.chY2MotionDone = dsMotion.Channels.Find(ledY2MotionDone.ChannelName);
            Global.chZMotionDone = dsMotion.Channels.Find(ledZMotionDone.ChannelName);

            Global.chXInPosition = dsMotion.Channels.Find(ledXInposition.ChannelName);
            Global.chY1InPosition = dsMotion.Channels.Find(ledY1Inposition.ChannelName);
            Global.chY2InPosition = dsMotion.Channels.Find(ledY2Inposition.ChannelName);
            Global.chZInPosition = dsMotion.Channels.Find(ledZInposition.ChannelName);

            Global.chXHome = dsMotion.Channels.Find(ledXHome.ChannelName);
            Global.chY1Home = dsMotion.Channels.Find(ledY1Home.ChannelName);
            Global.chY2Home = dsMotion.Channels.Find(ledY2Home.ChannelName);
            Global.chZHome = dsMotion.Channels.Find(ledZHome.ChannelName);

            Global.chXCCW = dsMotion.Channels.Find(ledXCCW.ChannelName);
            Global.chY1CCW = dsMotion.Channels.Find(ledY1CCW.ChannelName);
            Global.chY2CCW = dsMotion.Channels.Find(ledY2CCW.ChannelName);
            Global.chZCCW = dsMotion.Channels.Find(ledZCCW.ChannelName);

            Global.chXCCW.AsBoolean = false;
            Global.chY1CCW.AsBoolean = false;
            Global.chY2CCW.AsBoolean = false;
            Global.chZCCW.AsBoolean = false;

            Global.chXCW = dsMotion.Channels.Find(ledXCW.ChannelName);
            Global.chY1CW = dsMotion.Channels.Find(ledY1CW.ChannelName);
            Global.chY2CW = dsMotion.Channels.Find(ledY2CW.ChannelName);
            Global.chZCW = dsMotion.Channels.Find(ledZCW.ChannelName);

            Global.chXCW.AsBoolean = false;
            Global.chY1CW.AsBoolean = false;
            Global.chY2CW.AsBoolean = false;
            Global.chZCW.AsBoolean = false;

            Global.chXAlarm = dsMotion.Channels.Find(ledXAlarm.ChannelName);
            Global.chY1Alarm = dsMotion.Channels.Find(ledY1Alarm.ChannelName);
            Global.chY2Alarm = dsMotion.Channels.Find(ledY2Alarm.ChannelName);
            Global.chZAlarm = dsMotion.Channels.Find(ledZAlarm.ChannelName);

            Global.chXAlarm.AsBoolean = false;
            Global.chY1Alarm.AsBoolean = false;
            Global.chY2Alarm.AsBoolean = false;
            Global.chZAlarm.AsBoolean = false;

            Global.chCurPosition = dsMotion.Channels.Find(viCurPosition.ChannelName);
            Global.chSelectSpeed = dsMotion.Channels.Find(cbSpeed.ChannelName);

            #endregion

            if (bPmacConnected)
            {
                ReadVersion2Input();
                ReadVersion2Output();
                ReadMotorStatus();
            }
        }
#else
  public void DefaultChannelAssign()
        {
            SetDataServer(this.Controls);

            #region Input Set
            Global.ciMainPower          = dsIO.Channels.Find(Const._X00);
            Global.ciEMO1               = dsIO.Channels.Find(Const._X01);
            Global.ciEMO2               = dsIO.Channels.Find(Const._X02);
            Global.ciEMO3               = dsIO.Channels.Find(Const._X03);
            Global.ciTable1StartSwitch  = dsIO.Channels.Find(Const._X04);
            Global.ciTable1VacuumSwitch = dsIO.Channels.Find(Const._X05);
            Global.ciTable1StopSwitch   = dsIO.Channels.Find(Const._X06);
            Global.ciTable1ResetSwitch  = dsIO.Channels.Find(Const._X07);

            ledIn00.ChannelName = Global.ciMainPower.Name;
            ledIn01.ChannelName = Global.ciEMO1.Name;
            ledIn02.ChannelName = Global.ciEMO2.Name;
            ledIn03.ChannelName = Global.ciEMO3.Name;
            ledIn04.ChannelName = Global.ciTable1StartSwitch.Name;
            ledIn05.ChannelName = Global.ciTable1VacuumSwitch.Name;
            ledIn06.ChannelName = Global.ciTable1StopSwitch.Name;
            ledIn07.ChannelName = Global.ciTable1ResetSwitch.Name;

            ledIn00.OffImageIndex = gray_index_2;
            ledIn01.OffImageIndex = gray_index_2;
            ledIn02.OffImageIndex = gray_index_2;
            ledIn03.OffImageIndex = gray_index_2;
            ledIn04.OffImageIndex = gray_index_2;
            ledIn05.OffImageIndex = gray_index_2;
            ledIn06.OffImageIndex = gray_index_2;
            ledIn07.OffImageIndex = gray_index_2;

            ledIn00.OnImageIndex = green_index_0;
            ledIn01.OnImageIndex = red_index_1;
            ledIn02.OnImageIndex = red_index_1;
            ledIn03.OnImageIndex = red_index_1;
            ledIn04.OnImageIndex = green_index_0;
            ledIn05.OnImageIndex = green_index_0;
            ledIn06.OnImageIndex = green_index_0;
            ledIn07.OnImageIndex = green_index_0;

            Global.ciTable1PressureSensor   = dsIO.Channels.Find(Const._X08);
            Global.ciTable1VacuumSensor     = dsIO.Channels.Find(Const._X09);
            Global.ciTable2StartSwitch      = dsIO.Channels.Find(Const._X10);
            Global.ciTable2VacuumSwitch     = dsIO.Channels.Find(Const._X11);
            Global.ciTable2StopSwitch       = dsIO.Channels.Find(Const._X12);
            Global.ciTable2ResetSwitch      = dsIO.Channels.Find(Const._X13);
            Global.ciTable2PressureSensor   = dsIO.Channels.Find(Const._X14);
            Global.ciTable2VacuumSensor     = dsIO.Channels.Find(Const._X15);

            ledIn08.ChannelName = Global.ciTable1PressureSensor.Name;
            ledIn09.ChannelName = Global.ciTable1VacuumSensor.Name;
            ledIn10.ChannelName = Global.ciTable2StartSwitch.Name;
            ledIn11.ChannelName = Global.ciTable2VacuumSwitch.Name;
            ledIn12.ChannelName = Global.ciTable2StopSwitch.Name;
            ledIn13.ChannelName = Global.ciTable2ResetSwitch.Name;
            ledIn14.ChannelName = Global.ciTable2PressureSensor.Name;
            ledIn15.ChannelName = Global.ciTable2VacuumSensor.Name;

            ledIn08.OffImageIndex = gray_index_2;
            ledIn09.OffImageIndex = gray_index_2;
            ledIn10.OffImageIndex = gray_index_2;
            ledIn11.OffImageIndex = gray_index_2;
            ledIn12.OffImageIndex = gray_index_2;
            ledIn13.OffImageIndex = gray_index_2;
            ledIn14.OffImageIndex = gray_index_2;
            ledIn15.OffImageIndex = gray_index_2;

            ledIn08.OnImageIndex = green_index_0;
            ledIn09.OnImageIndex = green_index_0;
            ledIn10.OnImageIndex = green_index_0;
            ledIn11.OnImageIndex = green_index_0;
            ledIn12.OnImageIndex = green_index_0;
            ledIn13.OnImageIndex = green_index_0;
            ledIn14.OnImageIndex = green_index_0;
            ledIn15.OnImageIndex = green_index_0;

            Global.ciStagePower     = dsIO.Channels.Find(Const._X16);
            Global.ciLeakSensor     = dsIO.Channels.Find(Const._X17);
            Global.ciDoorSensor1    = dsIO.Channels.Find(Const._X18);
            Global.ciDoorSensor2    = dsIO.Channels.Find(Const._X19);
            Global.ciDoorSensor3    = dsIO.Channels.Find(Const._X20);
            Global.ciDoorSensor4    = dsIO.Channels.Find(Const._X21);
            Global.ciDoorSensor5    = dsIO.Channels.Find(Const._X22);

            ledIn16.Text = "Reserved";
            ledIn16.ChannelName = "Reserved";
            ledIn16.OffImageIndex = gray_index_2;
            ledIn17.ChannelName = Global.ciLeakSensor.Name;
            ledDoor1.ChannelName = Global.ciDoorSensor1.Name;
            ledDoor2.ChannelName = Global.ciDoorSensor2.Name;
            ledDoor3.ChannelName = Global.ciDoorSensor3.Name;
            ledDoor4.ChannelName = Global.ciDoorSensor4.Name;
            ledDoor5.ChannelName = Global.ciDoorSensor5.Name;
            ledIn23.ChannelName = "";

            ledIn16.OffImageIndex = green_index_0;
            ledIn17.OffImageIndex = red_index_1;
            ledDoor1.OffImageIndex = red_index_1;
            ledDoor2.OffImageIndex = red_index_1;
            ledDoor3.OffImageIndex = red_index_1;
            ledDoor4.OffImageIndex = red_index_1;
            ledDoor5.OffImageIndex = red_index_1;
            ledIn23.Text = "Reserved";
            ledIn23.ChannelName = "Reserved";
            ledIn23.OffImageIndex = gray_index_2;

            ledIn16.OnImageIndex = green_index_0;
            ledIn17.OnImageIndex = green_index_0;
            ledDoor1.OnImageIndex = green_index_0;
            ledDoor2.OnImageIndex = green_index_0;
            ledDoor3.OnImageIndex = green_index_0;
            ledDoor4.OnImageIndex = green_index_0;
            ledDoor5.OnImageIndex = green_index_0;
            ledIn23.OnImageIndex = green_index_0;

            //// Reserved

            Global.ciTable1IonizerRun   = dsIO.Channels.Find(Const._X24);
            Global.ciTable2IonizerRun   = dsIO.Channels.Find(Const._X25);
            Global.ciBeamShutterOpen    = dsIO.Channels.Find(Const._X26);
            Global.ciBeamShutterClose   = dsIO.Channels.Find(Const._X27);
            Global.ciPowerMeterClose    = dsIO.Channels.Find(Const._X28);
            Global.ciPowerMeterOpen     = dsIO.Channels.Find(Const._X29);
            Global.ciTable1AreaSensor   = dsIO.Channels.Find(Const._X30);
            Global.ciTable2AreaSensor   = dsIO.Channels.Find(Const._X31);

            ledIn24.ChannelName = Global.ciTable1IonizerRun.Name;
            ledIn25.ChannelName = Global.ciTable2IonizerRun.Name;
            ledIn26.ChannelName = Global.ciBeamShutterClose.Name;
            ledIn27.ChannelName = Global.ciBeamShutterOpen.Name;
            ledIn28.ChannelName = Global.ciPowerMeterClose.Name;
            ledIn29.ChannelName = Global.ciPowerMeterOpen.Name;
            ledIn30.ChannelName = Global.ciTable1AreaSensor.Name;
            ledIn31.ChannelName = Global.ciTable2AreaSensor.Name;

            ledIn24.OffImageIndex = 2;
            ledIn25.OffImageIndex = 2;
            ledIn26.OffImageIndex = 2;
            ledIn27.OffImageIndex = 2;
            ledIn28.OffImageIndex = 2;
            ledIn29.OffImageIndex = 2;
            ledIn30.OffImageIndex = 1;
            ledIn31.OffImageIndex = 1;

            ledIn24.OnImageIndex = green_index_0;
            ledIn25.OnImageIndex = green_index_0;
            ledIn26.OnImageIndex = green_index_0;
            ledIn27.OnImageIndex = green_index_0;
            ledIn28.OnImageIndex = green_index_0;
            ledIn29.OnImageIndex = green_index_0;
            ledIn30.OnImageIndex = green_index_0;
            ledIn31.OnImageIndex = green_index_0;

            ledArray5.OnImageIndices[0] = 0;
            ledArray5.OffImageIndices[0] = 1;
            ledArray5.OnImageIndices[1] = 1;
            ledArray5.OffImageIndices[1] = 2;
            ledArray5.OnImageIndices[2] = 0;
            ledArray5.OffImageIndices[2] = 2;
            ledArray5.OnImageIndices[3] = 0;
            ledArray5.OffImageIndices[3] = 2;
            ledArray5.OnImageIndices[4] = 0;
            ledArray5.OffImageIndices[4] = 2;
            ledArray5.OnImageIndices[5] = 0;
            ledArray5.OffImageIndices[5] = 2;
            ledArray5.OnImageIndices[6] = 0;
            ledArray5.OffImageIndices[6] = 1;
            ledArray5.OnImageIndices[7] = 0;
            ledArray5.OffImageIndices[7] = 1;

            #endregion

            #region Output Set
            switchOut0.ChannelName = Const._Y00;
            switchOut1.ChannelName = Const._Y01;
            switchOut2.ChannelName = Const._Y02;
            switchOut3.ChannelName = Const._Y03;
            switchOut4.ChannelName = Const._Y04;
            switchOut5.ChannelName = Const._Y05;
            switchOut6.ChannelName = Const._Y06;
            switchOut7.ChannelName = Const._Y07;
                                    
            switchOut8.ChannelName = Const._Y08;
            switchOut9.ChannelName = Const._Y09;
            switchOut10.ChannelName = Const._Y10;
            switchOut11.ChannelName = Const._Y11;
            switchOut12.ChannelName = Const._Y12;
            switchOut13.ChannelName = Const._Y13;
            switchOut14.ChannelName = Const._Y14;
            switchOut15.ChannelName = Const._Y15;

            switchOut16.ChannelName = Const._Y16;
            switchOut17.ChannelName = Const._Y17;
            switchOut18.ChannelName = Const._Y18;
            switchOut19.ChannelName = Const._Y19;
            switchOut20.ChannelName = Const._Y20;
            switchOut21.ChannelName = Const._Y21;
            switchOut22.ChannelName = Const._Y22;
            switchOut23.ChannelName = Const._Y23;

            switchOut24.ChannelName = Const._Y24;
            switchOut25.ChannelName = Const._Y25;
            switchOut26.ChannelName = Const._Y26;
            switchOut27.ChannelName = Const._Y27;
            switchOut28.ChannelName = Const._Y28;
            switchOut29.ChannelName = Const._Y29;
            switchOut30.ChannelName = Const._Y30;
            switchOut31.ChannelName = Const._Y31;

            // Reserved
            Global.coLEDLightOn = dsIO.Channels.Find(switchOut1.ChannelName);
            Global.coTowerLampRed = dsIO.Channels.Find(switchOut2.ChannelName);
            Global.coTowerLampYellow = dsIO.Channels.Find(switchOut3.ChannelName);
            Global.coTowerLampGreen = dsIO.Channels.Find(switchOut4.ChannelName);
            Global.coTowerLampBuzzer = dsIO.Channels.Find(switchOut5.ChannelName);
            Global.coTable1IonizerSol = dsIO.Channels.Find(switchOut6.ChannelName);
            Global.coTable2IonizerSol = dsIO.Channels.Find(switchOut7.ChannelName);

            Global.coTable1StartLamp = dsIO.Channels.Find(switchOut8.ChannelName);
            Global.coTable1VacuumLamp = dsIO.Channels.Find(switchOut9.ChannelName);
            Global.coTable1StopLamp = dsIO.Channels.Find(switchOut10.ChannelName);
            Global.coTable1ResetLamp = dsIO.Channels.Find(switchOut11.ChannelName);
            Global.coTable2StartLamp = dsIO.Channels.Find(switchOut12.ChannelName);
            Global.coTable2VacuumLamp = dsIO.Channels.Find(switchOut13.ChannelName);
            Global.coTable2StopLamp = dsIO.Channels.Find(switchOut14.ChannelName);
            Global.coTable2ResetLamp = dsIO.Channels.Find(switchOut15.ChannelName);

            // Reserved
            Global.coTable1IonizerRun = dsIO.Channels.Find(switchOut17.ChannelName);
            Global.coTable2IonizerRun = dsIO.Channels.Find(switchOut18.ChannelName);
            Global.coTable1IonizerSol = dsIO.Channels.Find(switchOut19.ChannelName);
            Global.coTable2IonizerSol = dsIO.Channels.Find(switchOut20.ChannelName);
            Global.doBeamShutterOpen = dsIO.Channels.Find(switchOut21.ChannelName);
            // Reserved
            Global.coDustCollector = dsIO.Channels.Find(switchOut23.ChannelName);

            // OpticBoxSolOn
            // OpticBoxSolOff
            Global.coPowerMeterCoverClose = dsIO.Channels.Find(switchOut24.ChannelName);
            Global.coPowerMeterCoverOpen = dsIO.Channels.Find(switchOut25.ChannelName);
            Global.coADVON = dsIO.Channels.Find(switchOut26.ChannelName);
            Global.coSelectBoard = dsIO.Channels.Find(switchOut27.ChannelName);
            // Reserved
            // Reserved

            viXVelocity.ChannelName = "X.Velocity";
            viY1Velocity.ChannelName = "Y1.Velocity";
            viY2Velocity.ChannelName = "Y2.Velocity";
            viZVelocity.ChannelName = "Z.Velocity";

            viXPosition.ChannelName = "X.Position";
            viY1Position.ChannelName = "Y1.Position";
            viY2Position.ChannelName = "Y2.Position";
            viZPosition.ChannelName = "Z.Position";
            viCurPosition.ChannelName = "Jog_CurPos";

            ledXServo.ChannelName = "X.ServoOn";
            ledXMotionDone.ChannelName = "X.MotionDone";
            ledXInposition.ChannelName = "X.InPosition";
            ledXHome.ChannelName = "X.Home";
            ledXCCW.ChannelName = "X.CCW";
            ledXCW.ChannelName = "X.CW";
            ledXAlarm.ChannelName = "X.Alarm";

            ledY1Servo.ChannelName = "Y1.ServoOn";
            ledY1MotionDone.ChannelName = "Y1.MotionDone";
            ledY1Inposition.ChannelName = "Y1.InPosition";
            ledY1Home.ChannelName = "Y1.Home";
            ledY1CCW.ChannelName = "Y1.CCW";
            ledY1CW.ChannelName = "Y1.CW";
            ledY1Alarm.ChannelName = "Y1.Alarm";

            ledY2Servo.ChannelName = "Y2.ServoOn";
            ledY2MotionDone.ChannelName = "Y2.MotionDone";
            ledY2Inposition.ChannelName = "Y2.InPosition";
            ledY2Home.ChannelName = "Y2.Home";
            ledY2CCW.ChannelName = "Y2.CCW";
            ledY2CW.ChannelName = "Y2.CW";
            ledY2Alarm.ChannelName = "Y2.Alarm";

            ledZServo.ChannelName = "Z.ServoOn";
            ledZMotionDone.ChannelName = "Z.MotionDone";
            ledZInposition.ChannelName = "Z.Inposition";
            ledZHome.ChannelName = "Z.Home";
            ledZCW.ChannelName = "Z.CCW";
            ledZCCW.ChannelName = "Z.CW";
            ledZAlarm.ChannelName = "Z.Alarm";

            cbSpeed.ChannelName = "SelectSpeed";

            Global.chXActualVel = dsMotion.Channels.Find(viXVelocity.ChannelName);
            Global.chY1ActualVel = dsMotion.Channels.Find(viY1Velocity.ChannelName);
            Global.chY2ActualVel = dsMotion.Channels.Find(viY2Velocity.ChannelName);
            Global.chZActualVel = dsMotion.Channels.Find(viZVelocity.ChannelName);
            Global.chXActualPos = dsMotion.Channels.Find(viXPosition.ChannelName);
            Global.chY1ActualPos = dsMotion.Channels.Find(viY1Position.ChannelName);
            Global.chY2ActualPos = dsMotion.Channels.Find(viY2Position.ChannelName);
            Global.chZActualPos = dsMotion.Channels.Find(viZPosition.ChannelName);

            Global.chXServoOn = dsMotion.Channels.Find(ledXServo.ChannelName);
            Global.chY1ServoOn = dsMotion.Channels.Find(ledY1Servo.ChannelName);
            Global.chY2ServoOn = dsMotion.Channels.Find(ledY2Servo.ChannelName);
            Global.chZServoOn = dsMotion.Channels.Find(ledZServo.ChannelName);

            Global.chXServoOn.AsBoolean = true;
            Global.chY1ServoOn.AsBoolean = true;
            Global.chY2ServoOn.AsBoolean = true;
            Global.chZServoOn.AsBoolean = true;

            Global.chXMotionDone = dsMotion.Channels.Find(ledXMotionDone.ChannelName);
            Global.chY1MotionDone = dsMotion.Channels.Find(ledY1MotionDone.ChannelName);
            Global.chY2MotionDone = dsMotion.Channels.Find(ledY2MotionDone.ChannelName);
            Global.chZMotionDone = dsMotion.Channels.Find(ledZMotionDone.ChannelName);

            Global.chXInPosition = dsMotion.Channels.Find(ledXInposition.ChannelName);
            Global.chY1InPosition = dsMotion.Channels.Find(ledY1Inposition.ChannelName);
            Global.chY2InPosition = dsMotion.Channels.Find(ledY2Inposition.ChannelName);
            Global.chZInPosition = dsMotion.Channels.Find(ledZInposition.ChannelName);

            Global.chXHome = dsMotion.Channels.Find(ledXHome.ChannelName);
            Global.chY1Home = dsMotion.Channels.Find(ledY1Home.ChannelName);
            Global.chY2Home = dsMotion.Channels.Find(ledY2Home.ChannelName);
            Global.chZHome = dsMotion.Channels.Find(ledZHome.ChannelName);

            Global.chXCCW = dsMotion.Channels.Find(ledXCCW.ChannelName);
            Global.chY1CCW = dsMotion.Channels.Find(ledY1CCW.ChannelName);
            Global.chY2CCW = dsMotion.Channels.Find(ledY2CCW.ChannelName);
            Global.chZCCW = dsMotion.Channels.Find(ledZCCW.ChannelName);

            Global.chXCCW.AsBoolean = false;
            Global.chY1CCW.AsBoolean = false;
            Global.chY2CCW.AsBoolean = false;
            Global.chZCCW.AsBoolean = false;

            Global.chXCW = dsMotion.Channels.Find(ledXCW.ChannelName);
            Global.chY1CW = dsMotion.Channels.Find(ledY1CW.ChannelName);
            Global.chY2CW = dsMotion.Channels.Find(ledY2CW.ChannelName);
            Global.chZCW = dsMotion.Channels.Find(ledZCW.ChannelName);

            Global.chXCW.AsBoolean = false;
            Global.chY1CW.AsBoolean = false;
            Global.chY2CW.AsBoolean = false;
            Global.chZCW.AsBoolean = false;

            Global.chXAlarm = dsMotion.Channels.Find(ledXAlarm.ChannelName);
            Global.chY1Alarm = dsMotion.Channels.Find(ledY1Alarm.ChannelName);
            Global.chY2Alarm = dsMotion.Channels.Find(ledY2Alarm.ChannelName);
            Global.chZAlarm = dsMotion.Channels.Find(ledZAlarm.ChannelName);

            Global.chXAlarm.AsBoolean = false;
            Global.chY1Alarm.AsBoolean = false;
            Global.chY2Alarm.AsBoolean = false;
            Global.chZAlarm.AsBoolean = false;

            Global.chCurPosition = dsMotion.Channels.Find(viCurPosition.ChannelName);
            Global.chSelectSpeed = dsMotion.Channels.Find(cbSpeed.ChannelName);

            #endregion

            if (bPmacConnected )
            {
                //ReadVersion1Input();
                //ReadVersion1Output();
                ReadMotorStatus();
            }

        }
#endif

        public Channel AddInput(String category, String name)
        {
            var channel = dsIO.Channels.Add();
            channel.Category = category;
            channel.DataType = ChannelDataType.Boolean;
            channel.Kind = ChannelKind.Input;
            channel.Name = name;

            return channel;
        }

        public Channel AddOutput(String category, String name)
        {
            var channel = dsIO.Channels.Add();
            channel.Category = category;
            channel.DataType = ChannelDataType.Boolean;
            channel.Kind = ChannelKind.Output;
            channel.Name = name;

            return channel;
        }

        public void ReadThread_OnExecute(object sender, EventArgs e)
        {
#if _VERSION1
            ReadVersion1Input();
            ReadVersion1Output();
#elif _VERSION2
            ReadVersion2Input();
            ReadVersion2Output();
#endif
            ReadMotorStatus();
            ReadAAA();
        }

#if _VERSION1
        private void ReadVersion1Input()
        {
#if _PMAC
            YujinTechnology.StringList szList = new YujinTechnology.StringList();

            szList.Text = Pmac.QueryCommand("M7000, 48");

            if (szList.Count == 48)
            {
                Global.ciMainPower.AsBoolean = CheckMValue("M7000", "1", szList[0]);
                Global.ciEMO1.AsBoolean = CheckMValue("M7001", "1", szList[1]);
                Global.ciEMO2.AsBoolean = CheckMValue("M7002", "1", szList[2]);
                Global.ciEMO3.AsBoolean = CheckMValue("M7003", "1", szList[3]);
                Global.ciTable1StartSwitch.AsBoolean = CheckMValue("M7004", "1", szList[4]);
                Global.ciTable1VacuumSwitch.AsBoolean = CheckMValue("M7005", "1", szList[5]);
                Global.ciTable1StopSwitch.AsBoolean = CheckMValue("M7006", "1", szList[6]);
                Global.ciTable1ResetSwitch.AsBoolean = CheckMValue("M7007", "1", szList[7]);

                Global.ciTable1PressureSensor.AsBoolean = CheckMValue("M7008", "1", szList[8]);
                Global.ciTable1VacuumSensor.AsBoolean = CheckMValue("M7009", "1", szList[9]);
                Global.ciTable2StartSwitch.AsBoolean = CheckMValue("M7010", "1", szList[10]);
                Global.ciTable2VacuumSwitch.AsBoolean = CheckMValue("M7011", "1", szList[11]);
                Global.ciTable2StopSwitch.AsBoolean = CheckMValue("M7012", "1", szList[12]);
                Global.ciTable2ResetSwitch.AsBoolean = CheckMValue("M7013", "1", szList[13]);
                Global.ciTable2PressureSensor.AsBoolean = CheckMValue("M7014", "1", szList[14]);
                Global.ciTable2VacuumSensor.AsBoolean = CheckMValue("M7015", "1", szList[15]);

                // Spare                        CheckMValue("M7016", "1", szList[16]);
                Global.ciLeakSensor.AsBoolean = CheckMValue("M7017", "1", szList[17]);
                Global.ciDoorSensor1.AsBoolean = CheckMValue("M7018", "1", szList[18]);
                Global.ciDoorSensor2.AsBoolean = CheckMValue("M7019", "1", szList[19]);
                Global.ciDoorSensor3.AsBoolean = CheckMValue("M7020", "1", szList[20]);
                Global.ciDoorSensor4.AsBoolean = CheckMValue("M7021", "1", szList[21]);
                Global.ciDoorSensor5.AsBoolean = CheckMValue("M7022", "1", szList[22]);
                // Spare

                Global.ciTable1IonizerRun.AsBoolean = CheckMValue("M7024", "1", szList[24]);
                Global.ciTable2IonizerRun.AsBoolean = CheckMValue("M7025", "1", szList[25]);
                Global.ciBeamShutterOpen.AsBoolean = CheckMValue("M7026", "1", szList[26]);
                Global.ciBeamShutterClose.AsBoolean = CheckMValue("M7027", "1", szList[27]);
                Global.ciPowerMeterClose.AsBoolean  = CheckMValue("M7028", "1", szList[28]);
                Global.ciPowerMeterOpen.AsBoolean   = CheckMValue("M7029", "1", szList[29]);
                Global.ciTable2AreaSensor.AsBoolean = CheckMValue("M7030", "1", szList[30]);
                Global.ciTable1AreaSensor.AsBoolean = CheckMValue("M7031", "1", szList[31]);
            }
#else
            //Global.ciBeamShutterClose.AsBoolean = true;
            //Global.ciBeamShutterOpen.AsBoolean = false;

            //Global.ciPowerMeterClose.AsBoolean = false;
            //Global.ciPowerMeterOpen.AsBoolean = true;
#endif
        }
#endif

#if _VERSION2
        private void ReadVersion2Input()
        {
#if _PMAC
            YujinTechnology.StringList szList = new YujinTechnology.StringList();

            szList.Text = Pmac.QueryCommand("M7000, 48");

            if (szList.Count == 48)
            {
                Global.ciMainPower.AsBoolean            = CheckMValue("M7000", "1", szList[0]);                
                Global.ciEMO1.AsBoolean                 = CheckMValue("M7001", "1", szList[1]);
                Global.ciEMO2.AsBoolean                 = CheckMValue("M7002", "1", szList[2]);
                Global.ciEMO3.AsBoolean                 = CheckMValue("M7003", "1", szList[3]);
                Global.ciTable1StartSwitch.AsBoolean    = CheckMValue("M7004", "1", szList[4]);
                Global.ciTable1VacuumSwitch.AsBoolean   = CheckMValue("M7005", "1", szList[5]);
                Global.ciTable1StopSwitch.AsBoolean     = CheckMValue("M7006", "1", szList[6]);
                Global.ciTable1ResetSwitch.AsBoolean    = CheckMValue("M7007", "1", szList[7]);

                Global.ciTable1PressureSensor.AsBoolean = CheckMValue("M7008", "1", szList[8]);
                Global.ciTable1VacuumSensor.AsBoolean   = CheckMValue("M7009", "1", szList[9]);
                Global.ciTable2StartSwitch.AsBoolean    = CheckMValue("M7010", "1", szList[10]);
                Global.ciTable2VacuumSwitch.AsBoolean   = CheckMValue("M7011", "1", szList[11]);
                Global.ciTable2StopSwitch.AsBoolean     = CheckMValue("M7012", "1", szList[12]);
                Global.ciTable2ResetSwitch.AsBoolean    = CheckMValue("M7013", "1", szList[13]);
                Global.ciTable2PressureSensor.AsBoolean = CheckMValue("M7014", "1", szList[14]);
                Global.ciTable2VacuumSensor.AsBoolean   = CheckMValue("M7015", "1", szList[15]);

                Global.ciStagePower.AsBoolean = CheckMValue("M7016", "1", szList[16]);
                Global.ciLeakSensor.AsBoolean = CheckMValue("M7017", "1", szList[17]);
                Global.ciDoorSensor1.AsBoolean = CheckMValue("M7018", "1", szList[18]);
                Global.ciDoorSensor2.AsBoolean = CheckMValue("M7019", "1", szList[19]);
                Global.ciDoorSensor3.AsBoolean = CheckMValue("M7020", "1", szList[20]);
                Global.ciDoorSensor4.AsBoolean = CheckMValue("M7021", "1", szList[21]);
                Global.ciDoorSensor5.AsBoolean = CheckMValue("M7022", "1", szList[22]);

                Global.ciTable1IonizerRun.AsBoolean = CheckMValue("M7024", "1", szList[24]);
                Global.ciTable2IonizerRun.AsBoolean = CheckMValue("M7025", "1", szList[25]);
                Global.ciBeamShutterClose.AsBoolean = CheckMValue("M7026", "1", szList[26]);
                Global.ciBeamShutterOpen.AsBoolean = CheckMValue("M7027", "1", szList[27]);
                Global.ciPowerMeterOpen.AsBoolean = CheckMValue("M7028", "1", szList[28]);
                Global.ciPowerMeterClose.AsBoolean = CheckMValue("M7029", "1", szList[29]);
                Global.ciTable1AreaSensor.AsBoolean = CheckMValue("M7030", "1", szList[30]);
                Global.ciTable2AreaSensor.AsBoolean = CheckMValue("M7031", "1", szList[31]);
            }
#else
            //Global.ciBeamShutterClose.AsBoolean = true;
            //Global.ciBeamShutterOpen.AsBoolean = false;

            //Global.ciPowerMeterClose.AsBoolean = false;
            //Global.ciPowerMeterOpen.AsBoolean = true;
#endif
        }
#endif

#if _VERSION1
        private void ReadVersion1Output()
        {

#if _PMAC
            YujinTechnology.StringList szList = new YujinTechnology.StringList();

            szList.Text = Pmac.QueryCommand("M7100, 48");
            {
                if (szList.Count == 48)
                {
                    // Reserved                     CheckMValue("M7100", "1", szList[0]);
                    Global.coLEDLightOn.AsBoolean = CheckMValue("M7101", "1", szList[1]);
                    Global.coTowerLampRed.AsBoolean = CheckMValue("M7102", "1", szList[2]);
                    Global.coTowerLampYellow.AsBoolean = CheckMValue("M7103", "1", szList[3]);
                    Global.coTowerLampGreen.AsBoolean = CheckMValue("M7104", "1", szList[4]);
                    Global.coTowerLampBuzzer.AsBoolean = CheckMValue("M7105", "1", szList[5]);
                    Global.coTable1IonizerSol.AsBoolean = CheckMValue("M7106", "1", szList[6]);
                    Global.coTable2IonizerSol.AsBoolean = CheckMValue("M7107", "1", szList[7]);

                    Global.coTable1StartLamp.AsBoolean = CheckMValue("M7108", "1", szList[8]);
                    Global.coTable1VacuumLamp.AsBoolean = CheckMValue("M7109", "1", szList[9]);
                    Global.coTable1StopLamp.AsBoolean = CheckMValue("M7100", "1", szList[10]);
                    Global.coTable1ResetLamp.AsBoolean = CheckMValue("M7111", "1", szList[11]);
                    Global.coTable2StartLamp.AsBoolean = CheckMValue("M7112", "1", szList[12]);
                    Global.coTable2VacuumLamp.AsBoolean = CheckMValue("M7113", "1", szList[13]);
                    Global.coTable2StopLamp.AsBoolean = CheckMValue("M7114", "1", szList[14]);
                    Global.coTable2ResetLamp.AsBoolean = CheckMValue("M7115", "1", szList[15]);

                    // Reserved                             CheckMValue("M7116", "1", szList[16]);
                    Global.coTable1IonizerRun.AsBoolean = CheckMValue("M7117", "1", szList[17]);
                    Global.coTable2IonizerRun.AsBoolean = CheckMValue("M7118", "1", szList[18]);
                    Global.coTable1IonizerSol.AsBoolean = CheckMValue("M7119", "1", szList[19]);
                    Global.coTable2IonizerSol.AsBoolean = CheckMValue("M7120", "1", szList[20]);
                    Global.doBeamShutterOpen.AsBoolean  = CheckMValue("M7121", "1", szList[21]);
                    // Reserved                         CheckMValue("M7122", "1", szList[22]);
                    Global.coDustCollector.AsBoolean    = CheckMValue("M7123", "1", szList[23]);

                    // yhbyun
                    // Global.coOpticBoxPurge.AsBoolean    = CheckMValue("M7124", "1", szList[24]);
                    // Global.coOpticBoxPurge.AsBoolean    = CheckMValue("M7125", "1", szList[25]);
                    Global.coPowerMeterCoverClose.AsBoolean = CheckMValue("M7126", "1", szList[26]);
                    Global.coPowerMeterCoverOpen.AsBoolean = CheckMValue("M7127", "1", szList[27]);
                    Global.coADVON.AsBoolean = CheckMValue("M7128", "1", szList[28]);
                    Global.coSelectBoard.AsBoolean = CheckMValue("M7129", "1", szList[29]);
                }
            }
#endif

        }
#endif

#if _VERSION2
        private void ReadVersion2Output()
        {

#if _PMAC
            YujinTechnology.StringList szList = new YujinTechnology.StringList();

            szList.Text = Pmac.QueryCommand("M7100, 48");
            {
                if (szList.Count == 48)
                {
                    Global.coSoftPowerOff.AsBoolean = CheckMValue("M7100", "1", szList[0]);
                    Global.coLEDLightOn.AsBoolean = CheckMValue("M7101", "1", szList[1]);
                    Global.coTowerLampRed.AsBoolean = CheckMValue("M7102", "1", szList[2]);
                    Global.coTowerLampYellow.AsBoolean = CheckMValue("M7103", "1", szList[3]);
                    Global.coTowerLampGreen.AsBoolean = CheckMValue("M7104", "1", szList[4]);
                    Global.coTowerLampBuzzer.AsBoolean = CheckMValue("M7105", "1", szList[5]);
                    Global.coTable1StartLamp.AsBoolean = CheckMValue("M7106", "1", szList[6]);
                    Global.coTable1VacuumLamp.AsBoolean = CheckMValue("M7107", "1", szList[7]);

                    Global.coTable1StopLamp.AsBoolean = CheckMValue("M7108", "1", szList[8]);
                    Global.coTable1ResetLamp.AsBoolean = CheckMValue("M7109", "1", szList[9]);
                    Global.coTable2StartLamp.AsBoolean = CheckMValue("M7100", "1", szList[10]);
                    Global.coTable2VacuumLamp.AsBoolean = CheckMValue("M7111", "1", szList[11]);
                    Global.coTable2StopLamp.AsBoolean = CheckMValue("M7112", "1", szList[12]);
                    Global.coTable2ResetLamp.AsBoolean = CheckMValue("M7113", "1", szList[13]);
                    Global.coTable1IonizerRun.AsBoolean = CheckMValue("M7114", "1", szList[14]);
                    Global.coTable1IonizerSol.AsBoolean = CheckMValue("M7115", "1", szList[15]);

                    Global.coTable2IonizerRun.AsBoolean = CheckMValue("M7116", "1", szList[16]);
                    Global.coTable2IonizerSol.AsBoolean = CheckMValue("M7117", "1", szList[17]);
                    Global.doBeamShutterOpen.AsBoolean = CheckMValue("M7118", "1", szList[18]);
                    Global.coDustCollector.AsBoolean = CheckMValue("M7119", "1", szList[19]);
                    Global.coOpticBoxPurge.AsBoolean = CheckMValue("M7120", "1", szList[20]);
                    Global.coPowerMeterCoverClose.AsBoolean = CheckMValue("M7121", "1", szList[21]);
                    Global.coPowerMeterCoverOpen.AsBoolean = CheckMValue("M7122", "1", szList[22]);
                    Global.coSelectBoard.AsBoolean = CheckMValue("M7123", "1", szList[23]);

                    Global.coADVON.AsBoolean = CheckMValue("M7124", "1", szList[24]);
                    Global.coTable1Pump1.AsBoolean = CheckMValue("M7125", "1", szList[25]);
                    Global.coTable1Vacuum11.AsBoolean = CheckMValue("M7126", "1", szList[26]);
                    Global.coTable1Vacuum12.AsBoolean = CheckMValue("M7127", "1", szList[27]);
                    Global.coTable1Pump2.AsBoolean = CheckMValue("M7128", "1", szList[28]);
                    Global.coTable1Vacuum21.AsBoolean = CheckMValue("M7129", "1", szList[29]);
                    Global.coTable1Vacuum22.AsBoolean = CheckMValue("M7130", "1", szList[30]);
                    Global.coTable2Pump1.AsBoolean = CheckMValue("M7131", "1", szList[31]);

                    Global.coTable2Vacuum11.AsBoolean = CheckMValue("M7132", "1", szList[32]);
                    Global.coTable2Vacuum12.AsBoolean = CheckMValue("M7133", "1", szList[33]);
                    Global.coTable2Pump2.AsBoolean = CheckMValue("M7134", "1", szList[34]);
                    Global.coTable2Vacuum21.AsBoolean = CheckMValue("M7135", "1", szList[35]);
                    Global.coTable2Vacuum22.AsBoolean = CheckMValue("M7136", "1", szList[36]);
                }
            }
#endif

        }
#endif

        #region ReadMotorStatus()
        /*
            423687.0678710938
            0.0048828125
            9.960937500000001e-05
            0
        */
        //private string PassingFunc(string str) 
        //{
        //    int nIdx;
        //    string strTemp;
        //    nIdx = str.IndexOf('=') + 1;
        //    strTemp = str.Substring(nIdx);
        //    return strTemp; 
        //}

        private string PassingFunc(string str)
        {
            int nIdx = str.IndexOf('=') + 1;
            if (nIdx == 0 || nIdx > str.Length)
            {
                return ""; // '=' 문자가 없을 경우 빈 문자열 반환
            }

            // '=' 이후의 문자열을 추출한 후 double로 변환
            double value = yjCommon.StrToDoubleDef(str.Substring(nIdx), 0.0);
            // 소수점 3자리까지 포맷팅하여 문자열로 변환 후 반환
            return value.ToString("F3");
        }


        private const string _X_SERVO_STATUS = "Motor[1].AmpEna";
        private const string _Y1_SERVO_STATUS = "Motor[2].AmpEna";
        private const string _Y2_SERVO_STATUS = "Motor[3].AmpEna";
        private const string _Z_SERVO_STATUS = "Motor[5].AmpEna";

        private const string _X_MOTION_DONE = "Motor[1].DesVelZero";
        private const string _Y1_MOTION_DONE = "Motor[2].DesVelZero";
        private const string _Y2_MOTION_DONE = "Motor[3].DesVelZero";
        private const string _Z_MOTION_DONE = "Motor[5].DesVelZero";

        private const string _X_ORIGIN_DONE = "Motor[1].HomeComplete";
        private const string _Y1_ORIGIN_DONE = "Motor[2].HomeComplete";
        private const string _Y2_ORIGIN_DONE = "Motor[3].HomeComplete";
        private const string _Z_ORIGIN_DONE = "Motor[5].HomeComplete";

        private const string _X_INPOSITION = "Motor[1].InPos";
        private const string _Y1_INPOSITION = "Motor[2].InPos";
        private const string _Y2_INPOSITION = "Motor[3].InPos";
        private const string _Z_INPOSITION = "Motor[5].InPos";

        private const string _X_CW = "Motor[1].PlusLimit";
        private const string _Y1_CW = "Motor[2].PlusLimit";
        private const string _Y2_CW = "Motor[3].PlusLimit";
        private const string _Z_CW = "Motor[5].PlusLimit";

        private const string _X_CCW = "Motor[1].MinusLimit";
        private const string _Y1_CCW = "Motor[2].MinusLimit";
        private const string _Y2_CCW = "Motor[3].MinusLimit";
        private const string _Z_CCW = "Motor[5].MinusLimit";

        private const string _X_AMP_ERROR = "Motor[1].AmpFault";
        private const string _Y1_AMP_ERROR = "Motor[2].AmpFault";
        private const string _Y2_AMP_ERROR = "Motor[3].AmpFault";
        private const string _Z_AMP_ERROR = "Motor[5].AmpFault";

        //     'Plc[0].Running', 'Plc[1].Running', 'Plc[2].Running', 'Plc[3].Running', 'Coord[1].ProgRunning',
        private void ReadMotorStatus()
        {
#if _PMAC
            YujinTechnology.StringList szList = new YujinTechnology.StringList();
            szList.Text = Pmac.QueryCommand("XVelocity XCurPos Y1Velocity Y1CurPos Y2Velocity Y2CurPos ZVelocity ZCurPos ");
            if (szList.Count == 8)
            {
                Global.chXActualVel.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[0]), 0.0);
                Global.chXActualPos.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[1]), 0.0) / Const.XY_LINEAR_SCALE;

                Global.chY1ActualVel.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[2]), 0.0);
                Global.chY1ActualPos.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[3]), 0.0) / Const.XY_LINEAR_SCALE;

                Global.chY2ActualVel.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[4]), 0.0);
                Global.chY2ActualPos.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[5]), 0.0) / Const.XY_LINEAR_SCALE;

                Global.chZActualVel.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[6]), 0.0);
                Global.chZActualPos.AsDouble = yjCommon.StrToDoubleDef(PassingFunc(szList[7]), 0.0) / Const.Z_AXIS_SCALE;
            }
#else
            Global.chXActualVel.AsDouble = 98.0;
            Global.chXActualPos.AsDouble = 123.4000;
            Global.chY1ActualPos.AsDouble = 4444.0;
            Global.chY2ActualPos.AsDouble = 5555.2;
#endif
            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO: 
                    Global.chCurPosition.AsDouble = Global.chXActualPos.AsDouble; 
                    break;

                case Pmac.Y1_AXIS_NO: 
                    Global.chCurPosition.AsDouble = Global.chY1ActualPos.AsDouble; 
                    break;

                case Pmac.Y2_AXIS_NO: 
                    Global.chCurPosition.AsDouble = Global.chY2ActualPos.AsDouble; 
                    break;

                case Pmac.Z_AXIS_NO: 
                    Global.chCurPosition.AsDouble = Global.chZActualPos.AsDouble; 
                    break;
            }

#if _PMAC
            szList.Text = Pmac.QueryCommand(String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21}" +
                "{22} {23} {24} {25} {26} {27}",
                                    _X_SERVO_STATUS, _Y1_SERVO_STATUS, _Y2_SERVO_STATUS, _Z_SERVO_STATUS,
                                    _X_MOTION_DONE, _Y1_MOTION_DONE, _Y2_MOTION_DONE, _Z_MOTION_DONE,
                                    _X_ORIGIN_DONE, _Y1_ORIGIN_DONE, _Y2_ORIGIN_DONE, _Z_ORIGIN_DONE,
                                    _X_CW, _Y1_CW, _Y2_CW, _Z_CW,
                                    _X_CCW, _Y1_CCW, _Y2_CCW, _Z_CCW,
                                    _X_INPOSITION, _Y1_INPOSITION, _Y2_INPOSITION, _Z_INPOSITION,
                                    _X_AMP_ERROR, _Y1_AMP_ERROR, _Y2_AMP_ERROR, _Z_AMP_ERROR));

            if (szList.Count == 28) 
            {
                //servo 관련
                Global.chXServoOn.AsBoolean = CheckMValue(_X_SERVO_STATUS, "1", szList[0]);
                Global.chY1ServoOn.AsBoolean = CheckMValue(_Y1_SERVO_STATUS, "1", szList[1]);
                Global.chY2ServoOn.AsBoolean = CheckMValue(_Y2_SERVO_STATUS, "1", szList[2]);
                Global.chZServoOn.AsBoolean = CheckMValue(_Z_SERVO_STATUS, "1", szList[3]);

                ledXServo.LED.Value = Global.chXServoOn.AsBoolean;
                ledY1Servo.LED.Value = Global.chY1ServoOn.AsBoolean;
                ledY2Servo.LED.Value = Global.chY2ServoOn.AsBoolean;
                ledZServo.LED.Value = Global.chZServoOn.AsBoolean;

                // yhbyun 정리해야 합니다..

                //Motion Done
                Global.chXMotionDone.AsBoolean  = CheckMValue(_X_MOTION_DONE, "1", szList[4]);
                Global.chY1MotionDone.AsBoolean = CheckMValue(_Y1_MOTION_DONE, "1", szList[5]);
                Global.chY2MotionDone.AsBoolean = CheckMValue(_Y2_MOTION_DONE, "1", szList[6]);
                Global.chZMotionDone.AsBoolean  = CheckMValue(_Z_MOTION_DONE, "1", szList[7]);
                //home동작 완료,  home구동중,  home동작완료
                Global.chXHome.AsBoolean        = CheckMValue(_X_ORIGIN_DONE, "1", szList[8]);                
                Global.chY1Home.AsBoolean       = CheckMValue(_Y1_ORIGIN_DONE, "1", szList[9]);
                Global.chY2Home.AsBoolean       = CheckMValue(_Y2_ORIGIN_DONE, "1", szList[10]);
                Global.chZHome.AsBoolean        = CheckMValue(_Z_ORIGIN_DONE, "1", szList[11]);
                
                Global.chXCW.AsBoolean          = CheckMValue(_X_CW, "1", szList[12]);
                Global.chY1CW.AsBoolean         = CheckMValue(_Y1_CW, "1", szList[13]);
                Global.chY2CW.AsBoolean         = CheckMValue(_Y2_CW, "1", szList[14]);
                Global.chZCW.AsBoolean          = CheckMValue(_Z_CW, "1", szList[15]);
                
                Global.chXCCW.AsBoolean         = CheckMValue(_X_CCW, "1", szList[16]);
                Global.chY1CCW.AsBoolean        = CheckMValue(_Y1_CCW, "1", szList[17]);
                Global.chY2CCW.AsBoolean        = CheckMValue(_Y2_CCW, "1", szList[18]);
                Global.chZCCW.AsBoolean         = CheckMValue(_Z_CCW, "1", szList[19]);
                
                Global.chXInPosition.AsBoolean  = CheckMValue(_X_INPOSITION, "1", szList[20]);
                Global.chY1InPosition.AsBoolean = CheckMValue(_Y1_INPOSITION, "1", szList[21]);
                Global.chY2InPosition.AsBoolean = CheckMValue(_Y2_INPOSITION, "1", szList[22]);
                Global.chZInPosition.AsBoolean  = CheckMValue(_Z_INPOSITION, "1", szList[23]);
                
                Global.chXAlarm.AsBoolean       = CheckMValue(_X_AMP_ERROR, "1", szList[24]);
                Global.chY1Alarm.AsBoolean      = CheckMValue(_Y1_AMP_ERROR, "1", szList[25]);
                Global.chY2Alarm.AsBoolean      = CheckMValue(_Y2_AMP_ERROR, "1", szList[26]);
                Global.chZAlarm.AsBoolean       = CheckMValue(_Z_AMP_ERROR, "1", szList[27]);

                ledXMotionDone.LED.Value = Global.chXMotionDone.AsBoolean;
                ledY1Inposition.LED.Value = Global.chY1MotionDone.AsBoolean;
                ledY2Inposition.LED.Value = Global.chY2MotionDone.AsBoolean;
                ledZMotionDone.LED.Value = Global.chZMotionDone.AsBoolean;
                
                ledXHome.LED.Value = Global.chXHome.AsBoolean;
                ledY1Home.LED.Value = Global.chY1Home.AsBoolean;
                ledY2Home.LED.Value = Global.chY2Home.AsBoolean;
                ledZHome.LED.Value = Global.chZHome.AsBoolean;

                ledXCW.LED.Value = Global.chXCW.AsBoolean;
                ledY1CW.LED.Value = Global.chY1CW.AsBoolean;
                ledY2CW.LED.Value = Global.chY2CW.AsBoolean;
                ledZCW.LED.Value = Global.chZCW.AsBoolean;

                ledXCCW.LED.Value = Global.chXCCW.AsBoolean;
                ledY1CCW.LED.Value = Global.chY1CCW.AsBoolean;
                ledY2CCW.LED.Value = Global.chY2CCW.AsBoolean;
                ledZCCW.LED.Value = Global.chZCCW.AsBoolean;
                
                ledXInposition.LED.Value = Global.chXInPosition.AsBoolean;
                ledY1Inposition.LED.Value = Global.chY1InPosition.AsBoolean;
                ledY2Inposition.LED.Value = Global.chY2InPosition.AsBoolean;
                ledZInposition.LED.Value = Global.chZInPosition.AsBoolean;
                
                ledXAlarm.LED.Value = Global.chXAlarm.AsBoolean;
                ledY1Alarm.LED.Value = Global.chY1Alarm.AsBoolean;
                ledY2Alarm.LED.Value = Global.chY2Alarm.AsBoolean;
                ledZAlarm.LED.Value = Global.chZAlarm.AsBoolean;
            }
#endif
        }
        #endregion

        #region ReadAAA()
        private void ReadAAA()
        {
#if _PMAC
            YujinTechnology.StringList szList = new YujinTechnology.StringList();

            szList.Text = Pmac.QueryCommand("Table1New Table2New Plc[15].Running Plc[16].Running Plc[17].Running Plc[18].Running Coord[1].ProgRunning Table1CycleStop Table2CycleStop Table1Stop Table2Stop");

            if (szList.Count == 11)
            {
                Global.Table1New            = (yjCommon.StrToIntDef(GetValue(szList[0]), 0) == 1);
                Global.Table2New            = (yjCommon.StrToIntDef(GetValue(szList[1]), 0) == 1);
                Global.XHoming            = (yjCommon.StrToIntDef(GetValue(szList[2]), 0) == 1);
                Global.Y1Homing           = (yjCommon.StrToIntDef(GetValue(szList[3]), 0) == 1);
                Global.Y2Homing           = (yjCommon.StrToIntDef(GetValue(szList[4]), 0) == 1);
                Global.ZHoming            = (yjCommon.StrToIntDef(GetValue(szList[5]), 0) == 1);
                Global.chCoord1Running      = (yjCommon.StrToIntDef(GetValue(szList[6]), 0) == 1);
                Global.diTable1CycleStop    = (yjCommon.StrToIntDef(GetValue(szList[7]), 0) == 1);
                Global.diTable2CycleStop    = (yjCommon.StrToIntDef(GetValue(szList[8]), 0) == 1);
                Global.diTable1Stop         = (yjCommon.StrToIntDef(GetValue(szList[9]), 0) == 1);
                Global.diTable2Stop         = (yjCommon.StrToIntDef(GetValue(szList[10]), 0) == 1);
            }
#endif
        }
        #endregion

        #region private void dsIO_OnError(object sender, int code, string channelName, Channel channel)
        private void dsIO_OnError(object sender, int code, string channelName, Channel channel)
        {
            var dataServer = sender as DataServer;
            if (dataServer != null)
            {
                string szName = "PMac.dsIO"; // dataServer의 이름을 가져올수 없음..

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

        #region private void dsMotion_OnError(object sender, int code, string channelName, Channel channel)
        private void dsMotion_OnError(object sender, int code, string channelName, Channel channel)
        {
            var dataServer = sender as DataServer;
            if (dataServer != null)
            {
                string szName = "PMac.dsMotion"; // dataServer의 이름을 가져올수 없음..

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


        #region PMac 통신 함수
        private bool CheckMValue(String szAddress, String szExpectValue, String szReturn)
        {
            string szStr = string.Format("{0}={1}", szAddress, szExpectValue);
            return string.Equals(szStr.ToLower(), szReturn.ToLower());
        }

        private bool CheckPValue(String szAddress, String szExpectValue, String szReturn)
        {
            string szStr = string.Format("{0}={1}", szAddress, szExpectValue);
            return string.Equals(szStr.ToLower(), szReturn.ToLower());
        }

        public string GetValue(string aStr)
        {
            int dot = aStr.IndexOf('=');

            if (dot > 0)
            {
                return aStr.Substring(dot + 1);
            }

            return string.Empty; // 디폴트 반환값, Delphi 코드에서는 if 조건이 거짓일 때의 반환값이 정의되지 않음
        }
        #endregion

        private void btnABS_Click(object sender, EventArgs e)
        {
#if _PMAC
            Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

            SetMoveVel();
            SetMoveTATS();

            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    if (Global.chXServoOn.AsBoolean)
                    {
                        Pmac.XMoveAbs(edMovePos.Value);
                    }
                    break;

                case Pmac.Y1_AXIS_NO:
                    if (Global.chY1ServoOn.AsBoolean)
                    {
                        Pmac.Y1MoveAbs(edMovePos.Value);
                    }
                    break;

                case Pmac.Y2_AXIS_NO:
                    if (Global.chY2ServoOn.AsBoolean)
                    {
                        Pmac.Y2MoveAbs(edMovePos.Value);
                    }
                    break;

                case Pmac.Z_AXIS_NO:
                    if (Global.chZServoOn.AsBoolean)
                    {
                        Pmac.ZMoveAbs(edMovePos.Value);
                    }
                    break;
        }
#endif
        }

        public void SetMoveVel()
        {
#if _PMAC
            double dSpeed = 0.0;

            if (CurrentAxis() == Pmac.ALL_AXIS) return;

            if (Global.chSelectSpeed.AsInteger == 0)//Low
            {
                switch(CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                        Pmac.XSetSpeed(dSpeed);
                        break;

                    case Pmac.Y1_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                        Pmac.Y1SetSpeed(dSpeed);
                        break;

                    case Pmac.Y2_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                        Pmac.Y2SetSpeed(dSpeed);
                        break;

                    case Pmac.Z_AXIS_NO:
                        dSpeed = Global.MotionParameters[3].JogSpeedLow * Const.Z_AXIS_SCALE / 1000;//speed * Scale값/1000;
                        Pmac.ZSetSpeed(dSpeed); 
                        break;
                }                      
            }
            else 
            if (Global.chSelectSpeed.AsInteger == 1)//Mid
            {
                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;
                        Pmac.XSetSpeed(dSpeed);
                        break;

                    case Pmac.Y1_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;
                        Pmac.Y1SetSpeed(dSpeed);
                        break;

                    case Pmac.Y2_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;
                        Pmac.Y2SetSpeed(dSpeed);
                        break;

                    case Pmac.Z_AXIS_NO:
                        dSpeed = Global.MotionParameters[3].JogSpeedMiddle * Const.Z_AXIS_SCALE / 1000;
                        Pmac.ZSetSpeed(dSpeed);
                        break;
                }
              }            
            else 
            if (Global.chSelectSpeed.AsInteger == 2)
            {
                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedHigh * Const.XY_LINEAR_SCALE / 1000;
                        Pmac.XSetSpeed(dSpeed);
                        break;

                    case Pmac.Y1_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedHigh * Const.XY_LINEAR_SCALE / 1000;
                        Pmac.Y1SetSpeed(dSpeed);
                        break;

                    case Pmac.Y2_AXIS_NO:
                        dSpeed = Global.MotionParameters[CurrentAxis() - 1].JogSpeedHigh * Const.XY_LINEAR_SCALE / 1000;
                        Pmac.Y2SetSpeed(dSpeed);
                        break;

                    case Pmac.Z_AXIS_NO:
                        dSpeed = Global.MotionParameters[3].JogSpeedHigh * Const.Z_AXIS_SCALE / 1000;
                        Pmac.ZSetSpeed(dSpeed);
                        break;
                }  
            }                    
#endif
        }

        public void SetMoveTATS()
        {
#if _PMAC
            double dTA = 0.0;

            if (CurrentAxis() == Pmac.ALL_AXIS) return;

            if (Global.chSelectSpeed.AsInteger == 0)//Low
            {
                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTALow / 2;//TA /2;
                        Pmac.XSetTA(dTA);
                        Pmac.XSetTS(dTA);
                        break;
         
                        case Pmac.Y1_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTALow  / 2;
                        Pmac.Y1SetTA(dTA);
                        Pmac.Y1SetTS(dTA);
                        break;

                    case Pmac.Y2_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTALow / 2;
                        Pmac.Y2SetTA(dTA);
                        Pmac.Y2SetTS(dTA);
                        break;

                    case Pmac.Z_AXIS_NO:
                        dTA = Global.MotionParameters[3].JogTALow /2;
                        Pmac.ZSetTA(dTA);
                        Pmac.ZSetTS(dTA);
                        break;
                }
            }
            else
            if (Global.chSelectSpeed.AsInteger == 1)//Mid
            {
                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTAMiddle / 2;
                        Pmac.XSetTA(dTA);
                        Pmac.XSetTS(dTA);
                        break;

                    case Pmac.Y1_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTAMiddle / 2;
                        Pmac.Y1SetTA(dTA);
                        Pmac.Y1SetTS(dTA);
                        break;

                    case Pmac.Y2_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTAMiddle / 2;
                        Pmac.Y2SetTA(dTA);
                        Pmac.Y2SetTS(dTA);
                        break;

                    case Pmac.Z_AXIS_NO:
                        dTA = Global.MotionParameters[3].JogTAMiddle / 2;
                        Pmac.ZSetTA(dTA);
                        Pmac.ZSetTS(dTA);
                        break;
                }
            }
            else
            if (Global.chSelectSpeed.AsInteger == 2)
            {
                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTAHigh / 2;
                        Pmac.XSetTA(dTA);
                        Pmac.XSetTS(dTA);
                        break;

                    case Pmac.Y1_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTAHigh / 2;
                        Pmac.Y1SetTA(dTA);
                        Pmac.Y1SetTS(dTA);
                        break;

                    case Pmac.Y2_AXIS_NO:
                        dTA = Global.MotionParameters[CurrentAxis() - 1].JogTAHigh / 2;
                        Pmac.Y2SetTA(dTA);
                        Pmac.Y2SetTS(dTA);
                        break;

                    case Pmac.Z_AXIS_NO:
                        dTA = Global.MotionParameters[3].JogTAHigh / 2;
                        Pmac.ZSetTA(dTA);
                        Pmac.ZSetTS(dTA);
                        break;
                }
            }             
#endif
        }

        private void btnRelMinus_Click(object sender, EventArgs e)
        {
#if _PMAC
            Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

            SetMoveVel();
            SetMoveTATS();

            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Pmac.XMoveInc(-edMovePos.Value);
                    break;

                case Pmac.Y1_AXIS_NO:
                    Pmac.Y1MoveInc(-edMovePos.Value);
                    break;

                case Pmac.Y2_AXIS_NO:
                    Pmac.Y2MoveInc(-edMovePos.Value); 
                    break;

                case Pmac.Z_AXIS_NO:
                    Pmac.ZMoveInc(-edMovePos.Value); 
                    break;
            }
#endif
        }

        private void btnRelPlus_Click(object sender, EventArgs e)
        {
#if _PMAC
            Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

            SetMoveVel();
            SetMoveTATS();

            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Pmac.XMoveInc(edMovePos.Value);
                    break;

                case Pmac.Y1_AXIS_NO:
                    Pmac.Y1MoveInc(edMovePos.Value);
                    break;

                case Pmac.Y2_AXIS_NO:
                    Pmac.Y2MoveInc(edMovePos.Value);
                    break;

                case Pmac.Z_AXIS_NO:
                    Pmac.ZMoveInc(edMovePos.Value);
                    break;
            }
#endif
        }

        private void btnServoOn_Click(object sender, EventArgs e)
        {
#if _PMAC
            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Pmac.XServoOn();
                    break;

                case Pmac.Y1_AXIS_NO:
                    Pmac.Y1ServoOn();
                    break;

                case Pmac.Y2_AXIS_NO:
                    Pmac.Y2ServoOn();
                    break;

                case Pmac.Z_AXIS_NO:
                    Pmac.ZServoOn();
                    break;
                case Pmac.ALL_AXIS:
                    Pmac.AllServoOn();
                    break;
            }
#endif
        }

        private void btnServoOff_Click(object sender, EventArgs e)
        {
#if _PMAC
            if (yjCommon.Confirm("해당 축을 SERVO OFF 합니다.", "확인") == DialogResult.Yes)
            {

                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        Pmac.XServoOff();
                        break;

                    case Pmac.Y1_AXIS_NO:
                        Pmac.Y1ServoOff();
                        break;

                    case Pmac.Y2_AXIS_NO:
                        Pmac.Y2ServoOff();
                        break;

                    case Pmac.Z_AXIS_NO:
                        Pmac.ZServoOff();
                        break;
                    case Pmac.ALL_AXIS:
                        Pmac.AllServoOff();
                        break;
                }
            }
#endif
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
#if _PMAC
        switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Pmac.XStop();
                    break;

                case Pmac.Y1_AXIS_NO:
                    Pmac.Y1Stop();
                    break;

                case Pmac.Y2_AXIS_NO:
                    Pmac.Y2Stop();
                    break;

                case Pmac.Z_AXIS_NO:
                    Pmac.ZStop();
                    break;
                case Pmac.ALL_AXIS:
                    Pmac.AllStop();
                    break;
            }
#endif
        }

        private void btnJogMinus_MouseDown(object sender, MouseEventArgs e)
        {
#if _PMAC
            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:

                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.XJogCCW();
                    break;

                case Pmac.Y1_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.Y1JogCCW();
                    break;

                case Pmac.Y2_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.Y2JogCCW();
                    break;

                case Pmac.Z_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.ZJogCCW();
                    break;
            }
#endif
        }

        private void btnJogMinus_MouseUp(object sender, MouseEventArgs e)
        {
#if _PMAC
            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Pmac.XStop();
                    break;

                case Pmac.Y1_AXIS_NO:
                    Pmac.Y1Stop();
                    break;

                case Pmac.Y2_AXIS_NO:
                    Pmac.Y2Stop();
                    break;

                case Pmac.Z_AXIS_NO:
                    Pmac.ZStop();
                    break;
            }
#endif
        }

        private void btnJogPlus_MouseDown(object sender, MouseEventArgs e)
        {
#if _PMAC
            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();
                    
                    Pmac.XJogCW();
                    break;

                case Pmac.Y1_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.Y1JogCW();
                    break;

                case Pmac.Y2_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.Y2JogCW();
                    break;

                case Pmac.Z_AXIS_NO:
                    Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;

                    SetMoveVel();
                    SetMoveTATS();

                    Pmac.ZJogCW();
                    break;
            }
#endif
        }

        private void btnJogPlus_MouseUp(object sender, MouseEventArgs e)
        {
#if _PMAC
            switch (CurrentAxis())
            {
                case Pmac.X_AXIS_NO:
                    Pmac.XStop();
                    break;

                case Pmac.Y1_AXIS_NO:
                    Pmac.Y1Stop();
                    break;

                case Pmac.Y2_AXIS_NO:
                    Pmac.Y2Stop();
                    break;

                case Pmac.Z_AXIS_NO:
                    Pmac.ZStop();
                    break;
            }
#endif
        }

        public int CurrentAxis()
        {
            if (btnXAxis.LED.Value)
            {
                return Pmac.X_AXIS_NO;
            }
            else
            if (btnY1Axis.LED.Value)
            {
                return Pmac.Y1_AXIS_NO;
            }
            else
            if (btnY2Axis.LED.Value)
            {
                return Pmac.Y2_AXIS_NO;
            }
            else
            if (btnZAxis.LED.Value)
            {
                return Pmac.Z_AXIS_NO;
            }
            else
            {
                return Pmac.ALL_AXIS;
            }
        }
        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnServoOn.Text = Global.iniEng.ReadString("panManualMotion", "btnServoOn.Text", "Servo On");
            btnServoOff.Text = Global.iniEng.ReadString("panManualMotion", "btnServoOff.Text", "Servo Off");
            btnJogMinus.Text = Global.iniEng.ReadString("panManualMotion", "btnJogMinus.Text", "Jog(-)");
            btnJogPlus.Text = Global.iniEng.ReadString("panManualMotion", "btnJogPlus.Text", "Jog(+)");
            btnOrigin.Text = Global.iniEng.ReadString("panManualMotion", "btnOrigin.Text", "Origin");
            btnReset.Text = Global.iniEng.ReadString("panManualMotion", "btnReset.Text", "Reset");
            btnStop.Text = Global.iniEng.ReadString("panManualMotion", "btnStop.Text", "Stop");
        }
        #endregion
        #region public void ChangeLanguageKorea()
        public void ChangeLanguageKorea()
        {
            btnServoOn.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnServoOn.Text");
            btnServoOff.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnServoOff.Text");
            btnJogMinus.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnJogMinus.Text");
            btnJogPlus.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnJogPlus.Text");
            btnOrigin.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnOrigin.Text");
            btnReset.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnReset.Text");
            btnStop.Text = Global.GetIniLanguageValue(Global.iniKor, "panManualMotion", "btnStop.Text");
        }
        #endregion
        #region public void ChangeLanguageVietnam()
        public void ChangeLanguageVietnam()
        {
            btnServoOn.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnServoOn.Text");
            btnServoOff.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnServoOff.Text");
            btnJogMinus.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnJogMinus.Text");
            btnJogPlus.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnJogPlus.Text");
            btnOrigin.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnOrigin.Text");
            btnReset.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnReset.Text");
            btnStop.Text = Global.GetIniLanguageValue(Global.iniVie, "panManualMotion", "btnStop.Text");
        }
        #endregion
        public void ChangeAxis(object sender, EventArgs e)
        {
            btnABS.Enabled = (sender != btnAllAxis);
            btnRelMinus.Enabled = (sender != btnAllAxis);
            btnRelPlus.Enabled = (sender != btnAllAxis);
            btnJogMinus.Enabled = (sender != btnAllAxis);
            btnJogPlus.Enabled = (sender != btnAllAxis);
            cbSpeed.Enabled = (sender != btnAllAxis);

            if(sender == btnAllAxis)
            {
                btnXAxis.LED.Value = false;
                btnY1Axis.LED.Value = false;
                btnY2Axis.LED.Value = false;
                btnZAxis.LED.Value = false;
                btnAllAxis.LED.Value = true;
            }
            else
            {
                btnXAxis.LED.Value = (sender == btnXAxis);// || (sender == btnAllAxis);
                btnY1Axis.LED.Value = (sender == btnY1Axis);// || (sender == btnAllAxis);
                btnY2Axis.LED.Value = (sender == btnY2Axis);// || (sender == btnAllAxis);
                btnZAxis.LED.Value = (sender == btnZAxis);// || (sender == btnAllAxis);
                btnAllAxis.LED.Value = false;
            }
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("해당 축을 초기화 합니다.", "확인") == DialogResult.Yes)
            {
#if _PMAC
                switch (CurrentAxis())
                {
                    case Pmac.X_AXIS_NO:
                        Pmac.XOrigin();
                        break;

                    case Pmac.Y1_AXIS_NO:
                        Pmac.Y1Origin();
                        break;

                    case Pmac.Y2_AXIS_NO:
                        Pmac.Y2Origin();
                        break;

                    case Pmac.Z_AXIS_NO:
                        Pmac.ZOrigin();
                        break;

                    case Pmac.ALL_AXIS:
                        Pmac.AllOrigin();
                        break;
                }
#endif
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
#if _PMAC
            //switch (CurrentAxis())
            //{
            //    case Pmac.X_AXIS_NO:
            //        Pmac.XReset();
            //        break;

            //    case Pmac.Y1_AXIS_NO:
            //        Pmac.Y1Reset();
            //        break;

            //    case Pmac.Y2_AXIS_NO:
            //        Pmac.Y2Reset();
            //        break;

            //    case Pmac.Z_AXIS_NO:
            //        Pmac.ZOrigin();
            //        break;

            //    case Pmac.ALL_AXIS:
            //        Pmac.AllReset();
            //        break;
            //}
#endif
        }

        public void SetLEDValueEvent()
        {
            ledXServo.LEDValueChanged += LEDValueChanged;
            ledXCW.LEDValueChanged += LEDValueChanged;
            ledXCCW.LEDValueChanged += LEDValueChanged;
            ledXAlarm.LEDValueChanged += LEDValueChanged;

            ledY1Servo.LEDValueChanged += LEDValueChanged;
            ledY1CW.LEDValueChanged += LEDValueChanged;
            ledY1CCW.LEDValueChanged += LEDValueChanged;
            ledY1Alarm.LEDValueChanged += LEDValueChanged;

            ledY2Servo.LEDValueChanged += LEDValueChanged;
            ledY2CW.LEDValueChanged += LEDValueChanged;
            ledY2CCW.LEDValueChanged += LEDValueChanged;
            ledY2Alarm.LEDValueChanged += LEDValueChanged;

            ledZServo.LEDValueChanged += LEDValueChanged;
            ledZCW.LEDValueChanged += LEDValueChanged;
            ledZCCW.LEDValueChanged += LEDValueChanged;
            ledZAlarm.LEDValueChanged += LEDValueChanged;
        }

        private void LEDValueChanged(object sender, LEDValueChangedEventArgs e)
        {
            var control = sender as LEDLabel; // sender를 LEDControl로 캐스팅

            if (control != null)
            {
                if (control == ledXHome)
                {
                    if (!ledXHome.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_X_ORIGIN);
                    }
                } 
                else
                if (control == ledXServo)
                {
                    if (!ledXServo.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_X_SERVO_OFF);
                    }
                } 
                else
                if (control == ledXCCW)
                {
                    if (ledXCCW.LED.Value && !Global.XHoming)
                    {
                        frmMain.Auto.AddError(Const.ERROR_X_CCW_LIMIT);
                    }
                } 
                else
                if (control == ledXCW)
                {
                    if (ledXCW.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_X_CW_LIMIT);
                    }
                } 
                else
                if (control == ledXAlarm)
                {
                    if (ledXAlarm.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_X_AMP_FAULT);
                    }
                } 
                else
                if (control == ledY1Home)
                {
                    if (!ledY1Home.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y1_ORIGIN);
                    }
                } 
                else
                if (control == ledY1Servo)
                {
                    if (!ledY1Servo.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y1_SERVO_OFF);
                    }
                } 
                else
                if (control == ledY1CCW)
                {
                    if (ledY1CCW.LED.Value && !Global.Y1Homing)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y1_CCW_LIMIT);
                    }
                } 
                else
                if (control == ledY1CW)
                {
                    if (ledY1CW.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y1_CW_LIMIT);
                    }
                } 
                else
                if (control == ledY1Alarm)
                {
                    if (ledY1Alarm.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y1_AMP_FAULT);
                    }
                } 
                else
                if (control == ledY2Home)
                {
                    if (!ledY2Home.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y2_ORIGIN);
                    }
                } 
                else
                if (control == ledY2Servo)
                {
                    if (!ledY2Servo.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y2_SERVO_OFF);
                    }
                } 
                else
                if (control == ledY2CCW)
                {
                    if (ledY2CCW.LED.Value && !Global.Y2Homing)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y2_CCW_LIMIT);
                    }
                } 
                else
                if (control == ledY2CW)
                {
                    if (ledY2CW.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y2_CW_LIMIT);
                    }
                } 
                else
                if (control == ledY2Alarm)
                {
                    if (ledY2Alarm.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Y2_AMP_FAULT);
                    }
                } 
                else
                if (control == ledZHome)
                {
                    if (!ledZHome.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Z_ORIGIN);
                    }
                } 
                else
                if (control == ledZServo)
                {
                    if (!ledZServo.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Z_SERVO_OFF);
                    }
                } 
                else
                if (control == ledZCCW)
                {
                    if (ledZCCW.LED.Value && !Global.ZHoming)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Z_CCW_LIMIT);
                    }
                } 
                else
                if (control == ledZCW)
                {
                    if (ledZCW.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Z_CW_LIMIT);
                    }
                } 
                else
                if (control == ledZAlarm)
                {
                    if (ledZAlarm.LED.Value)
                    {
                        frmMain.Auto.AddError(Const.ERROR_Z_AMP_FAULT);
                    }
                }
            }
        }

        private void ledIn00_ValueChanged(object sender, EventArgs e)
        {
            if (!ledIn00.Value)
            {
                frmMain.Auto.AddError(Const.ERROR_MAIN_POWER);
            }
        }

        private void ledIn01_ValueChanged(object sender, EventArgs e)
        {
            if (ledIn01.Value)
            {
                frmMain.Auto.AddError(Const.ERROR_EMERGENCY_STOP1);
            }
        }

        private void ledIn02_ValueChanged(object sender, EventArgs e)
        {
            if (ledIn02.Value)
            {
                frmMain.Auto.AddError(Const.ERROR_EMERGENCY_STOP2);
            }
        }

        private void ledIn03_ValueChanged(object sender, EventArgs e)
        {
            if (ledIn03.Value)
            {
                frmMain.Auto.AddError(Const.ERROR_EMERGENCY_STOP3);
            }
        }

        private void ledIn18_ValueChanged(object sender, EventArgs e)
        {
            if (!ledDoor1.Value)
            {
                if ((frmMain.Config != null) && (frmMain.Config.Common.chkDoorAlarmUse.Checked))
                {
                    frmMain.Auto.AddError(Const.ERROR_DOOR1_OPEN);
                }
            }
        }

        private void ledIn19_ValueChanged(object sender, EventArgs e)
        {
            if (!ledDoor2.Value)
            {
                if ((frmMain.Config != null) && (frmMain.Config.Common.chkDoorAlarmUse.Checked))
                {
                    frmMain.Auto.AddError(Const.ERROR_DOOR2_OPEN);
                }
            }
        }

        private void ledIn20_ValueChanged(object sender, EventArgs e)
        {
            if (!ledDoor3.Value)
            {
                if ((frmMain.Config != null) && (frmMain.Config.Common.chkDoorAlarmUse.Checked))
                {
                    frmMain.Auto.AddError(Const.ERROR_DOOR3_OPEN);
                }
            }
        }

        private void ledIn21_ValueChanged(object sender, EventArgs e)
        {
            if (!ledDoor4.Value)
            {
                if ((frmMain.Config != null) && (frmMain.Config.Common.chkDoorAlarmUse.Checked))
                {
                    frmMain.Auto.AddError(Const.ERROR_DOOR4_OPEN);
                }
            }
        }

        private void ledIn22_ValueChanged(object sender, EventArgs e)
        {
            if (!ledDoor5.Value)
            {
                if ((frmMain.Config != null) && (frmMain.Config.Common.chkDoorAlarmUse.Checked))
                {
                    frmMain.Auto.AddError(Const.ERROR_DOOR5_OPEN);
                }
            }
        }

        /*
         * Area Sensor Error는 설비가 실 가동 중일때 발생한다.
         */
        private void ledIn30_ValueChanged(object sender, EventArgs e)
        {
            if (!ledIn30.Value)
            {
#if _VERSION1
                if (frmMain.Auto.isAutoRun(TableNo.Table2)
                    && (frmMain.Auto.Table2.Step > 0) && (frmMain.Auto.Table2.Step < Const.CASE_VISION_ERROR))
                {
                    if (frmMain.Config.Common.chkAreaSensorUse.Checked) frmMain.Auto.AddError(Const.ERROR_TABLE2_AREA_SENSOR);
                }
#elif _VERSION2
                if (frmMain.Auto.isAutoRun(TableNo.Table1)
                    && (frmMain.Auto.Table1.Step > 0) && (frmMain.Auto.Table1.Step < Const.CASE_VISION_ERROR))
                {
                    if (frmMain.Config.Common.chkAreaSensorUse.Checked) frmMain.Auto.AddError(Const.ERROR_TABLE1_AREA_SENSOR);
                }
#endif
            }
        }

        /*
        * Area Sensor Error는 설비가 실 가동 중일때 발생한다.
        */
        private void ledIn31_ValueChanged(object sender, EventArgs e)
        {
            if (!ledIn31.Value)
            {
#if _VERSION1
                if (frmMain.Auto.isAutoRun(TableNo.Table1) 
                    && (frmMain.Auto.Table1.Step > 0) && (frmMain.Auto.Table1.Step < Const.CASE_VISION_ERROR))
                {
                    if (frmMain.Config.Common.chkAreaSensorUse.Checked) frmMain.Auto.AddError(Const.ERROR_TABLE1_AREA_SENSOR);
                }
#elif _VERSION2
                if (frmMain.Auto.isAutoRun(TableNo.Table2)
                    && (frmMain.Auto.Table2.Step > 0) && (frmMain.Auto.Table2.Step < Const.CASE_VISION_ERROR))
                {
                    if (frmMain.Config.Common.chkAreaSensorUse.Checked) frmMain.Auto.AddError(Const.ERROR_TABLE2_AREA_SENSOR);
                }
#endif
            }
        }

        private void cbSpeed_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if ((frmMain != null) && (frmMain.SideMenu != null))
            {
                frmMain.SideMenu.cbSpeed.ItemIndex = cbSpeed.SelectedIndex;
            }
        }
        private void ledIn07_ValueChanged(object sender, EventArgs e)
        {
            if (ledIn07.Value)
            {
                frmMain.Auto.ErrorReset();
            }
        }

        private void ledIn13_ValueChanged(object sender, EventArgs e)
        {
            if (ledIn13.Value)
            {
                frmMain.Auto.ErrorReset();
            }
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
        static public YujinTechnology.Thread ReadThread;

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

            uIPAddress = yjCommon.IPAddress2Integer(szAddress);
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
