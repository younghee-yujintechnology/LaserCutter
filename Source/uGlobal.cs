using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Windows.Forms;
 
using DaekhonSystem;
using IniParser.Model;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    static class Const
    {
        public const double VISION_ZOOM_FIT = 0.3740234375;

#if _VERSION1
        public const int XY_LINEAR_SCALE = 1000;
        public const int Z_AXIS_SCALE = 10000;

        public const string _X00 = "X00:Main Power";
        public const string _X01 = "X01:EMO #1";
        public const string _X02 = "X02:EMO #2";
        public const string _X03 = "X03:EMO #3";
        public const string _X04 = "X04:T1 Start Switch";
        public const string _X05 = "X05:T1 Vacuum Switch";
        public const string _X06 = "X06:T1 Stop Switch";
        public const string _X07 = "X07:T1 Reset Switch";

        public const string _X08 = "X08:T1 Pressure Sensor";
        public const string _X09 = "X09:T1 Vacuum Sensor";
        public const string _X10 = "X10:T2 Start Switch";
        public const string _X11 = "X11:T2 Vacuum Switch";
        public const string _X12 = "X12:T2 Stop Switch";
        public const string _X13 = "X13:T2 Reset Switch";
        public const string _X14 = "X14:T2 Pressure Sensor";
        public const string _X15 = "X15:T2 Vacuum Sensor";

        public const string _X16 = "X16:Stage Power";
        public const string _X17 = "X17:Leak Sensor";
        public const string _X18 = "X18:Door Sensor #1";
        public const string _X19 = "X19:Door Sensor #2";
        public const string _X20 = "X20:Door Sensor #3";
        public const string _X21 = "X21:Door Sensor #4";
        public const string _X22 = "X22:Door Sensor #5";
        public const string _X23 = "X23:Reserved";

        public const string _X24 = "X24:Ionizer Run T1";
        public const string _X25 = "X25:Ionizer Run T2";
        public const string _X26 = "X26:Beam Shutter Open";
        public const string _X27 = "X27:Beam Shutter Close";
        public const string _X28 = "X28:Power Meter Close";
        public const string _X29 = "X29:Power Meter Open";
        public const string _X30 = "X30:Area Sensor T2";
        public const string _X31 = "X31:Area Sensor T1";

        public const string _Y00 = "Y00:Reserved";
        public const string _Y01 = "Y01:LED Light";
        public const string _Y02 = "Y02:Signal Tower Red";
        public const string _Y03 = "Y03:Signal Tower Yellow";
        public const string _Y04 = "Y04:Signal Tower Green";
        public const string _Y05 = "Y05:Signal Tower Buzzer";
        public const string _Y06 = "Y06:Table1VacuumOn";
        public const string _Y07 = "Y07:Table2VacuumOn";

        public const string _Y08 = "Y08:Table1StartLamp";
        public const string _Y09 = "Y09:Table1VacuumLamp";
        public const string _Y10 = "Y10:Table1StopLamp";
        public const string _Y11 = "Y11:Table1ResetLamp";
        public const string _Y12 = "Y12:Table2StartLamp";
        public const string _Y13 = "Y13:Table2VacuumLamp";
        public const string _Y14 = "Y14:Table2StopLamp";
        public const string _Y15 = "Y15:Table2ResetLamp";

        public const string _Y16 = "Y16:Reserved";
        public const string _Y17 = "Y17:Table1IonizerRun";
        public const string _Y18 = "Y18:Table2IonizerRun";
        public const string _Y19 = "Y19:Table1IonizerSol";
        public const string _Y20 = "Y20:Table2IonizerSol";
        public const string _Y21 = "Y21:OuterBeamShutterOpen";
        public const string _Y22 = "Y22:Reserved";
        public const string _Y23 = "Y23:Dust Collector";

        public const string _Y24 = "Y24:Optic Box Sol On";
        public const string _Y25 = "Y25:Optic Box Sol Off";
        public const string _Y26 = "Y26:PowerMeterCoverClose";
        public const string _Y27 = "Y27:PowerMeterCoverOpen";
        public const string _Y28 = "Y28:ADV ON";
        public const string _Y29 = "Y29:SelectTable";
        public const string _Y30 = "Y30:Reserved";
        public const string _Y31 = "Y31:Reserved";

#elif _VERSION2
        public const int XY_LINEAR_SCALE = 10000;
        public const int Z_AXIS_SCALE = 10000;

        public const string _X00 = "X00:Main Power";
        public const string _X01 = "X01:EMO #1";
        public const string _X02 = "X02:EMO #2";
        public const string _X03 = "X03:EMO #3";
        public const string _X04 = "X04:T1 Start Switch";
        public const string _X05 = "X05:T1 Vacuum Switch";
        public const string _X06 = "X06:T1 Stop Switch";
        public const string _X07 = "X07:T1 Reset Switch";

        public const string _X08 = "X08:T1 Pressure Sensor";
        public const string _X09 = "X09:T1 Vacuum Sensor";
        public const string _X10 = "X10:T2 Start Switch";
        public const string _X11 = "X11:T2 Vacuum Switch";
        public const string _X12 = "X12:T2 Stop Switch";
        public const string _X13 = "X13:T2 Reset Switch";
        public const string _X14 = "X14:T2 Pressure Sensor";
        public const string _X15 = "X15:T2 Vacuum Sensor";

        public const string _X16 = "X16:Stage Power";
        public const string _X17 = "X17:Leak Sensor";
        public const string _X18 = "X18:Door Sensor #1";
        public const string _X19 = "X19:Door Sensor #2";
        public const string _X20 = "X20:Door Sensor #3";
        public const string _X21 = "X21:Door Sensor #4";
        public const string _X22 = "X22:Door Sensor #5";
        public const string _X23_RESERVED = "X23:Reserved";

        public const string _X24 = "X24:Table1IonizerRun";
        public const string _X25 = "X25:Table2IonizerRun";
        public const string _X26 = "X26:Beam Shutter Close";
        public const string _X27 = "X27:Beam Shutter Open";
        public const string _X28 = "X28:Power Meter Open";
        public const string _X29 = "X29:Power Meter Close";
        public const string _X30 = "X30:Area Sensor T1";
        public const string _X31 = "X31:Area Sensor T2";

        public const string _Y00 = "Y00:Soft Power";
        public const string _Y01 = "Y01:LED Light";
        public const string _Y02 = "Y02:Signal Tower Red";
        public const string _Y03 = "Y03:Signal Tower Yellow";
        public const string _Y04 = "Y04:Signal Tower Green";
        public const string _Y05 = "Y05:Signal Tower Buzzer";
        public const string _Y06 = "Y06:Table1StartLamp";
        public const string _Y07 = "Y07:Table1VacuumLamp";

        public const string _Y08 = "Y08:Table1StopLamp";
        public const string _Y09 = "Y09:Table1ResetLamp";
        public const string _Y10 = "Y10:Table2StartLamp";
        public const string _Y11 = "Y11:Table2VacuumLamp";
        public const string _Y12 = "Y12:Table2StopLamp";
        public const string _Y13 = "Y13:Table2ResetLamp";
        public const string _Y14 = "Y14:Table1IonizerRun";
        public const string _Y15 = "Y15:Table1IonizerSol";

        public const string _Y16 = "Y16:Table2IonizerRun";
        public const string _Y17 = "Y17:Table2IonizerSolOn";
        public const string _Y18 = "Y18:OuterBeamShutterOpen";
        public const string _Y19 = "Y19:Dust Collector";
        public const string _Y20 = "Y20:Optic Box Purge";
        public const string _Y21 = "Y21:PowerMeterCoverClose";
        public const string _Y22 = "Y22:PowerMeterCoverOpen";
        public const string _Y23 = "Y23:SelectTable";

        public const string _Y24 = "Y24:ADV ON";
        public const string _Y25 = "Y25:Table1Pump1On";
        public const string _Y26 = "Y26:Table1VacuumSol1";
        public const string _Y27 = "Y27:Table1VacuumSol2";
        public const string _Y28 = "Y28:Table1Pump2On";
        public const string _Y29 = "Y29:Table1Vacuum3";
        public const string _Y30 = "Y30:Table1Vacuum4";
        public const string _Y31 = "Y31:Table2Pump1On";

        public const string _Y32 = "Y32:Table2VacuumSol1";
        public const string _Y33 = "Y33:Table2VacuumSol2";
        public const string _Y34 = "Y34:Table2Pump2On";
        public const string _Y35 = "Y35:Table2VacuumSol3";
        public const string _Y36 = "Y36:Table2VacuumSol4";
        public const string _Y37 = "Y37:Reserved";
        public const string _Y38 = "Y38:Reserved";
        public const string _Y39 = "Y39:Reserved";

#elif (!_VERSION1 && !_VERSION2)
        public const int XY_LINEAR_SCALE = 10000;
        public const int Z_AXIS_SCALE = 10000;

        public const string _X00 = "X00:Main Power";
        public const string _X01 = "X01:EMO #1";
        public const string _X02 = "X02:EMO #2";
        public const string _X03 = "X03:EMO #3";
        public const string _X04 = "X04:T1 Start Switch";
        public const string _X05 = "X05:T1 Vacuum Switch";
        public const string _X06 = "X06:T1 Stop Switch";
        public const string _X07 = "X07:T1 Reset Switch";

        public const string _X08 = "X08:T1 Pressure Sensor";
        public const string _X09 = "X09:T1 Vacuum Sensor";
        public const string _X10 = "X10:T2 Start Switch";
        public const string _X11 = "X11:T2 Vacuum Switch";
        public const string _X12 = "X12:T2 Stop Switch";
        public const string _X13 = "X13:T2 Reset Switch";
        public const string _X14 = "X14:T2 Pressure Sensor";
        public const string _X15 = "X15:T2 Vacuum Sensor";

        public const string _X16 = "X16:Stage Power";
        public const string _X17 = "X17:Leak Sensor";
        public const string _X18 = "X18:Door Sensor #1";
        public const string _X19 = "X19:Door Sensor #2";
        public const string _X20 = "X20:Door Sensor #3";
        public const string _X21 = "X21:Door Sensor #4";
        public const string _X22 = "X22:Door Sensor #5";
        public const string _X23 = "X23:Reserved";

        public const string _X24 = "X24:Ionizer Run T1";
        public const string _X25 = "X25:Ionizer Run T2";
        public const string _X26 = "X26:Beam Shutter Open";
        public const string _X27 = "X27:Beam Shutter Close";
        public const string _X28 = "X28:Power Meter Close";
        public const string _X29 = "X29:Power Meter Open";
        public const string _X30 = "X30:Area Sensor T1";
        public const string _X31 = "X31:Area Sensor T2";

        public const string _Y00 = "Y00:Reserved";
        public const string _Y01 = "Y01:LED Light";
        public const string _Y02 = "Y02:Signal Tower Red";
        public const string _Y03 = "Y03:Signal Tower Yellow";
        public const string _Y04 = "Y04:Signal Tower Green";
        public const string _Y05 = "Y05:Signal Tower Buzzer";
        public const string _Y06 = "Y06:Table1VacuumOn";
        public const string _Y07 = "Y07:Table2VacuumOn";

        public const string _Y08 = "Y08:Table1StartLamp";
        public const string _Y09 = "Y09:Table1VacuumLamp";
        public const string _Y10 = "Y10:Table1StopLamp";
        public const string _Y11 = "Y11:Table1ResetLamp";
        public const string _Y12 = "Y12:Table2StartLamp";
        public const string _Y13 = "Y13:Table2VacuumLamp";
        public const string _Y14 = "Y14:Table2StopLamp";
        public const string _Y15 = "Y15:Table2ResetLamp";

        public const string _Y16 = "Y16:Reserved";
        public const string _Y17 = "Y17:Table1IonizerRun";
        public const string _Y18 = "Y18:Table2IonizerRun";
        public const string _Y19 = "Y19:Table1IonizerSol";
        public const string _Y20 = "Y20:Table2IonizerSol";
        public const string _Y21 = "Y21:OuterBeamShutterOpen";
        public const string _Y22 = "Y22:Reserved";
        public const string _Y23 = "Y23:Dust Collector";

        public const string _Y24 = "Y24:Optic Box Sol On";
        public const string _Y25 = "Y25:Optic Box Sol Off";
        public const string _Y26 = "Y26:PowerMeterCoverClose";
        public const string _Y27 = "Y27:PowerMeterCoverOpen";
        public const string _Y28 = "Y28:ADV ON";
        public const string _Y29 = "Y29:SelectTable";
        public const string _Y30 = "Y30:Reserved";
        public const string _Y31 = "Y31:Reserved";
#endif

        #region ErrorList

        public const int CASE_DONE                          = 10000;
        public const int CASE_ABORT                         = 20000;
        public const int CASE_ERROR                         = 30000;
        public const int CASE_VISION_ERROR                  = 40000;

        public const int ERROR_MAIN_POWER                   = 0;

        public const int ERROR_EMERGENCY_STOP1              = 1;
        public const int ERROR_EMERGENCY_STOP2              = 2;
        public const int ERROR_EMERGENCY_STOP3              = 3;

        public const int ERROR_MOTOR_FAULT                  = 10;

        public const int ERROR_X_SERVO_OFF                  = ERROR_MOTOR_FAULT + 01;
        public const int ERROR_X_AMP_FAULT                  = ERROR_MOTOR_FAULT + 02;
        public const int ERROR_X_CCW_LIMIT                  = ERROR_MOTOR_FAULT + 03;
        public const int ERROR_X_CW_LIMIT                   = ERROR_MOTOR_FAULT + 04;
        public const int ERROR_X_ENCODER_FAULT              = ERROR_MOTOR_FAULT + 05;

        public const int ERROR_Y1_SERVO_OFF                 = ERROR_MOTOR_FAULT + 11;
        public const int ERROR_Y1_AMP_FAULT                 = ERROR_MOTOR_FAULT + 12;
        public const int ERROR_Y1_CCW_LIMIT                 = ERROR_MOTOR_FAULT + 13;
        public const int ERROR_Y1_CW_LIMIT                  = ERROR_MOTOR_FAULT + 14;
        public const int ERROR_Y1_ENCODER_FAULT             = ERROR_MOTOR_FAULT + 15;

        public const int ERROR_Y2_SERVO_OFF                 = ERROR_MOTOR_FAULT + 21;
        public const int ERROR_Y2_AMP_FAULT                 = ERROR_MOTOR_FAULT + 22;
        public const int ERROR_Y2_CCW_LIMIT                 = ERROR_MOTOR_FAULT + 23;
        public const int ERROR_Y2_CW_LIMIT                  = ERROR_MOTOR_FAULT + 24;
        public const int ERROR_Y2_ENCODER_FAULT             = ERROR_MOTOR_FAULT + 25;

        public const int ERROR_Z_SERVO_OFF                  = ERROR_MOTOR_FAULT + 31;
        public const int ERROR_Z_AMP_FAULT                  = ERROR_MOTOR_FAULT + 32;
        public const int ERROR_Z_CCW_LIMIT                  = ERROR_MOTOR_FAULT + 33;
        public const int ERROR_Z_CW_LIMIT                   = ERROR_MOTOR_FAULT + 34;
        public const int ERROR_Z_ENCODER_FAULT              = ERROR_MOTOR_FAULT + 35;

        public const int ERROR_MAIN_AIR_PRESSUR             = 50;

        public const int ERROR_ORIGIN_ERROR                 = 60;

        public const int ERROR_X_ORIGIN                     = ERROR_ORIGIN_ERROR + 1;
        public const int ERROR_X_ORIGIN_TIME_OVER           = ERROR_ORIGIN_ERROR + 2;
        public const int ERROR_X_MOVE_START_OVER_TIME_OVER  = ERROR_ORIGIN_ERROR + 3;
        public const int ERROR_X_MOVE_TIME_OVER             = ERROR_ORIGIN_ERROR + 4;

        public const int ERROR_Y1_ORIGIN                    = ERROR_ORIGIN_ERROR + 11;
        public const int ERROR_Y1_ORIGIN_TIME_OVER          = ERROR_ORIGIN_ERROR + 12;
        public const int ERROR_Y1_MOVE_START_OVER_TIME_OVER = ERROR_ORIGIN_ERROR + 13;
        public const int ERROR_Y1_MOVE_TIME_OVER            = ERROR_ORIGIN_ERROR + 14;

        public const int ERROR_Y2_ORIGIN                    = ERROR_ORIGIN_ERROR + 21;
        public const int ERROR_Y2_ORIGIN_TIME_OVER          = ERROR_ORIGIN_ERROR + 22;
        public const int ERROR_Y2_MOVE_START_OVER_TIME_OVER = ERROR_ORIGIN_ERROR + 23;
        public const int ERROR_Y2_MOVE_TIME_OVER            = ERROR_ORIGIN_ERROR + 24;

        public const int ERROR_Z_ORIGIN                     = ERROR_ORIGIN_ERROR + 31;
        public const int ERROR_Z_ORIGIN_TIME_OVER           = ERROR_ORIGIN_ERROR + 32;
        public const int ERROR_Z_MOVE_START_TIME_OVER       = ERROR_ORIGIN_ERROR + 33;
        public const int ERROR_Z_MOVE_TIME_OVER             = ERROR_ORIGIN_ERROR + 34;

        public const int ERROR_TABLE1_MOVE_READY_POS_TIME_OVER          = 100;
        public const int ERROR_TABLE2_MOVE_READY_POS_TIME_OVER          = 101;
                            
        public const int ERROR_TABLE1_MOVE_ALIGN1_POS_TIME_OVER         = 111;
        public const int ERROR_TABLE1_MOVE_ALIGN2_POS_TIME_OVER         = 112;
        public const int ERROR_TABLE1_MOVE_ALIGN3_POS_TIME_OVER         = 113;
        public const int ERROR_TABLE1_MOVE_ALIGN4_POS_TIME_OVER         = 114;
                            
        public const int ERROR_TABLE2_MOVE_ALIGN1_POS_TIME_OVER         = 116;
        public const int ERROR_TABLE2_MOVE_ALIGN2_POS_TIME_OVER         = 117;
        public const int ERROR_TABLE2_MOVE_ALIGN3_POS_TIME_OVER         = 118;
        public const int ERROR_TABLE2_MOVE_ALIGN4_POS_TIME_OVER         = 119;
                            
        public const int ERROR_TABLE1_VISION_ALIGN1_SEARCH_FAIL         = 120;
        public const int ERROR_TABLE1_VISION_ALIGN2_SEARCH_FAIL         = 121;
        public const int ERROR_TABLE1_VISION_ALIGN3_SEARCH_FAIL         = 122;
        public const int ERROR_TABLE1_VISION_ALIGN4_SEARCH_FAIL         = 123;
                            
        public const int ERROR_TABLE2_VISION_ALIGN1_SEARCH_FAIL         = 130;
        public const int ERROR_TABLE2_VISION_ALIGN2_SEARCH_FAIL         = 131;
        public const int ERROR_TABLE2_VISION_ALIGN3_SEARCH_FAIL         = 132;
        public const int ERROR_TABLE2_VISION_ALIGN4_SEARCH_FAIL         = 133;
                            
        public const int ERROR_TABLE1_COORD1_START_TIME_OVER            = 140;
        public const int ERROR_TABLE1_COORD1_STOP_TIME_OVER             = 141;

        public const int ERROR_TABLE2_COORD1_START_TIME_OVER            = 142;
        public const int ERROR_TABLE2_COORD1_STOP_TIME_OVER             = 143;
                            
        public const int ERROR_MOVE_POWER_METER_POS_TIME_OVER           = 145;
                            
        public const int ERROR_DOOR1_OPEN                               = 201;
        public const int ERROR_DOOR2_OPEN                               = 202;
        public const int ERROR_DOOR3_OPEN                               = 203;
        public const int ERROR_DOOR4_OPEN                               = 204;
        public const int ERROR_DOOR5_OPEN                               = 205;
                            
        public const int ERROR_TABLE1_VACUUM                            = 210;
        public const int ERROR_TABLE2_VACUUM                            = 211;
                            
        public const int ERROR_TABLE1_AREA_SENSOR                       = 212;
        public const int ERROR_TABLE2_AREA_SENSOR                       = 213;

        public const int ERROR_LASER_POWER_OFF                          = 600;

        public const int ERROR_CAMERA_INITIAL_FAIL                      = 610;
        public const int ERROR_LASER_COMMUNICATION_ERROR                = 620;
        public const int ERROR_LIGHT_CONTROLLER_COMMUNICATION_ERROR     = 621;
        public const int ERROR_LASER_POWERMETER_COMMUNICATION_ERROR     = 622;
        public const int ERROR_LASER_TRIGGER_ADV_COMMUNICATION_ERROR    = 623;
        public const int ERROR_PMAC_CONTROLLER_COMMUNICATION_ERROR      = 624;

        public const int ERROR_LASER_INNER_SHUTTER_OPEN_ERROR           = 630;

        public const int ERROR_JOBFILE_INVALID_PARAMETER_LASER_POWER    = 710;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_PULSE_PITCH    = 711;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_SHIFT_VALUE    = 712;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_Z_POSITION     = 713;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_THICKNESS      = 714;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_LAYER_USED     = 715;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_SELECTION      = 716;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_GAP_VALUE      = 717;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_ARRAY_COUNT    = 718;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_SIZE_VALUE     = 719;
        public const int ERROR_JOBFILE_INVALID_PARAMETER_RADIUS_VALUE   = 720;

        public const int ERROR_TABLE1_JOBFILE_INVALID_PARAMETER         = 730;
        public const int ERROR_TABLE2_JOBFILE_INVALID_PARAMETER         = 731;

        public const int ERR0R_MOTIONFILE_INVALID_DATA                  = 740;

        public const int ERROR_TABLE1_VISION_SHIFT_OFFSET_OVER          = 750;
        public const int ERROR_TABLE2_VISION_SHIFT_OFFSET_OVER          = 751;

        public const int ERROR_JOBFILE_LOAD                             = 800;
        public const int ERROR_TABLE1_JOBFILE_LOAD                      = 801;
        public const int ERROR_TABLE2_JOBFILE_LOAD                      = 802;

        public const int ERROR_TABLE1_VISION_LOAD                       = 850;
        public const int ERROR_TABLE2_VISION_LOAD                       = 851;

        public const int NOW_START_READY                                = 997;
        public const int NOW_TABLE1_RUNNING                             = 998;
        public const int NOW_TABLE2_RUNNING                             = 999;
        public const int NOW_RUNNING                                    = 1000;
        #endregion
    }

    public enum TableNo
    {
        Table0 = 0,
        Table1 = 1,
        Table2 = 2
    }   

    public enum Command
    {
        None = 0,
        Origin,

        Start,
        Stop,
        AutoReady,
        Ready
    };

    public enum LoadDir
    {
        LeftBottom = 0,
        LeftTop,
        RightTop,
        RightBottom,
        Center
    }

    #region public struct DoubleRect
    public struct DoubleRect
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public DoubleRect(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public double Left => X;
        public double Right => X + Width;
        public double Top => Y;
        public double Bottom => Y + Height;

        public bool Contains(DoublePoint point)
        {
            return point.x >= Left && point.x <= Right && point.y >= Top && point.y <= Bottom;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Width: {Width}, Height: {Height}";
        }
    }
    #endregion

    public class Global
    {
        public const string MESSAGE_BOX_TITLE = "DaekhonCorporation.System";

        #region Define Channels {...}
        public static uint gDeviceNo = 0;
		
        //Motor Status
        public static Channel chXActualPos;
        public static Channel chY1ActualPos;
        public static Channel chY2ActualPos;
        public static Channel chZActualPos;

        public static Channel chXActualVel;
        public static Channel chY1ActualVel;
        public static Channel chY2ActualVel;
        public static Channel chZActualVel;
        
        public static Channel chXServoOn;
        public static Channel chY1ServoOn;
        public static Channel chY2ServoOn;
        public static Channel chZServoOn;

        public static Channel chXMotionDone;
        public static Channel chY1MotionDone;
        public static Channel chY2MotionDone;
        public static Channel chZMotionDone;

        public static Channel chXInPosition;
        public static Channel chY1InPosition;
        public static Channel chY2InPosition;
        public static Channel chZInPosition;
        
        public static Channel chXHome;
        public static Channel chY1Home;
        public static Channel chY2Home;
        public static Channel chZHome;
        
        public static Channel chXCCW;
        public static Channel chY1CCW;
        public static Channel chY2CCW;
        public static Channel chZCCW;
        
        public static Channel chXCW;
        public static Channel chY1CW;
        public static Channel chY2CW;
        public static Channel chZCW;
        
        public static Channel chXAlarm;
        public static Channel chY1Alarm;
        public static Channel chY2Alarm;
        public static Channel chZAlarm;

        public static Channel chCurPosition;
        public static Channel chSelectSpeed;

        public static Channel chADVEncoder1Count;
        public static Channel chADVEncoder2Count;
        public static Channel chADVTriggerCount;


        //Input #0
        public static Channel ciMainPower;
        public static Channel ciEMO1;
        public static Channel ciEMO2;
        public static Channel ciEMO3;
        public static Channel ciTable1StartSwitch;
        public static Channel ciTable1VacuumSwitch;
        public static Channel ciTable1StopSwitch;
        public static Channel ciTable1ResetSwitch;

        //Input #1
        public static Channel ciTable1PressureSensor;
        public static Channel ciTable1VacuumSensor;
        public static Channel ciTable2StartSwitch;
        public static Channel ciTable2VacuumSwitch;
        public static Channel ciTable2StopSwitch;
        public static Channel ciTable2ResetSwitch;
        public static Channel ciTable2PressureSensor;
        public static Channel ciTable2VacuumSensor;

        //Input #2
        public static Channel ciStagePower;
        public static Channel ciLeakSensor;
        public static Channel ciDoorSensor1;
        public static Channel ciDoorSensor2;
        public static Channel ciDoorSensor3;
        public static Channel ciDoorSensor4;
        public static Channel ciDoorSensor5;

        //Input #3
        public static Channel ciTable1IonizerRun;
        public static Channel ciTable2IonizerRun;
        public static Channel ciBeamShutterClose;
        public static Channel ciBeamShutterOpen;
        public static Channel ciPowerMeterOpen;
        public static Channel ciPowerMeterClose;
        public static Channel ciTable1AreaSensor;
        public static Channel ciTable2AreaSensor;

        //Output #0
        public static Channel coSoftPowerOff;
        public static Channel coLEDLightOn;
        public static Channel coTowerLampRed;
        public static Channel coTowerLampYellow;
        public static Channel coTowerLampGreen;
        public static Channel coTowerLampBuzzer;
        public static Channel coTable1StartLamp;
        public static Channel coTable1VacuumLamp;

        //Output #1
        public static Channel coTable1StopLamp;
        public static Channel coTable1ResetLamp;
        public static Channel coTable2StartLamp;
        public static Channel coTable2VacuumLamp;
        public static Channel coTable2StopLamp;
        public static Channel coTable2ResetLamp;
        public static Channel coTable1IonizerRun;
        public static Channel coTable1IonizerSol;

        //Output #2
        public static Channel coTable2IonizerRun;
        public static Channel coTable2IonizerSol;
        public static Channel doBeamShutterOpen;
        public static Channel coDustCollector;
        public static Channel coOpticBoxPurge;
        public static Channel coPowerMeterCoverClose;
        public static Channel coPowerMeterCoverOpen;
        public static Channel coSelectBoard;

        //Output #3
        public static Channel coADVON;
#if _VERSION1
        public static Channel coTable1Vacuum;
        public static Channel coTable2Vacuum;
#elif _VERSION2
        public static Channel coTable1Pump1;
        public static Channel coTable1Vacuum11;
        public static Channel coTable1Vacuum12;
        public static Channel coTable1Pump2;
        public static Channel coTable1Vacuum21;
        public static Channel coTable1Vacuum22;
        public static Channel coTable2Pump1;
        //Output #4
        public static Channel coTable2Vacuum11;
        public static Channel coTable2Vacuum12;
        public static Channel coTable2Pump2;
        public static Channel coTable2Vacuum21;
        public static Channel coTable2Vacuum22;
#endif


        //Coherent Laser
        public static Channel chLaserConnected;
        public static Channel chLaserDisConnected;
        public static Channel chLaserKeyOn;
        public static Channel chLaserKeyOff;
        public static Channel chLaserShutterOpen;
        public static Channel chLaserShutterClose;
        public static Channel chLaserPulsingOn;
        public static Channel chLaserPulsingOff;
        public static Channel chLaserStandby;
        public static Channel chLaserOn;
        public static Channel chLaserFault;
        public static Channel chLaserChillerRun;
        public static Channel chLaserChillerStop;
        public static Channel chLaserChillerFault;

        public static Channel chLaserRRD;
        public static Channel chLaserPower;
        public static Channel chLaserPulseWidth;
        public static Channel chLaserChillerCurrTemp;
        public static Channel chLaserChillerSetTemp;


        public static Channel chLaserChillerOn;
        public static Channel chLaserChillerOff;

        public static Channel chLaserFreq;
        public static Channel chLaserAttenuator;
        public static Channel chLaserPPDivider;
        public static Channel chLaserBurstControlN;
        public static Channel chLaserActualEnvelopeParameterN;
        public static Channel chLaserBurstControlP;
        public static Channel chLaserActualEnvelopeParameterP;

        //config
        public static Channel chConHomeOffsetPosX;
        public static Channel chConHomeOffsetPosY1;
        public static Channel chConHomeOffsetPosY2;
        public static Channel chConHomeOffsetPosZ;
        public static Channel chLoadPosX;
        public static Channel chTable1LoadPosY;
        public static Channel chTable2LoadPosY;
        public static Channel chConLoadPosZ;
        public static Channel chConTableSizeX;
        public static Channel chConTableSizeY;
        public static Channel chConLineSpeed;
        public static Channel chConLineTA;
        public static Channel chConArcSpeed;
        public static Channel chConArcTA;
        public static Channel chConJumpSpeed;
        public static Channel chConJumpTA;

        public static Channel chConPowerMeterPosX;
        public static Channel chConPowerMeterPosZ;

        public static Channel chConCenterDoorUse;
        public static Channel chConVacuumAlarmUse;
        public static Channel chConVacuumReleaseUse;
        public static Channel chConCircleYOffset;

        public static Channel chTable1LaserZFocus;
        public static Channel chTable1VisionZFocus;
        public static Channel chTable2LaserZFocus;
        public static Channel chTable2VisionZFocus;

        public static Channel chTable1NozzleXOffset;
        public static Channel chTable1NozzleYOffset;

        public static Channel chTable1LoadDir;

        public static Channel chTable1LeftBottomYPos;
        public static Channel chTable1LeftBottomXPos;

        public static Channel chTable1LeftTopYPos;
        public static Channel chTable1LeftTopXPos;

        public static Channel chTable1RightTopYPos;
        public static Channel chTable1RightTopXPos;

        public static Channel chTable1RightBottomYPos;
        public static Channel chTable1RightBottomXPos;

        public static Channel chTable1CenterYPos;
        public static Channel chTable1CenterXPos;

        public static Channel chTable2LoadDir;

        public static Channel chTable2LeftBottomYPos;
        public static Channel chTable2LeftBottomXPos;

        public static Channel chTable2LeftTopYPos;
        public static Channel chTable2LeftTopXPos;

        public static Channel chTable2RightTopYPos;
        public static Channel chTable2RightTopXPos;

        public static Channel chTable2RightBottomYPos;
        public static Channel chTable2RightBottomXPos;

        public static Channel chTable2CenterYPos;
        public static Channel chTable2CenterXPos;

        public static Channel chAreaSensorUse;
        public static Channel chAreaSensorVacuumUse;
        public static Channel chAccelerationG;

        public static Channel chAutoRunSpeedStage;
        public static Channel chAutoRunSpeedZ;

        public static bool XHoming = false;
        public static bool Y1Homing = false;
        public static bool Y2Homing = false;
        public static bool ZHoming = false;
        public static bool chCoord1Running = false;

        public static bool Table1New = false;
        public static bool Table2New = false;

        public static bool diTable1CycleStop = false;
        public static bool diTable2CycleStop = false;

        public static bool diTable1Stop = false;
        public static bool diTable2Stop = false;

        public static bool chShowStep = true;

        public static bool CameraInitial = false;
        public static bool LaserError = false;

        public static bool isAutoRun = false;
        public static bool isChangeAble = false;
        //config

#endregion

        public static List<MotionParameter> MotionParameters;

        public static DaekhonSystem.IniFile iniEng;
        public static IniData iniKor;
        public static IniData iniVie;


        #region public void ChangeNumberEditControlFrameColor()
        //
        // NumberEditControl.Frame.FrameColor를 지정색으로 변경
        //
        public static void ChangeDaekhonControlColor(Control.ControlCollection controls, Type targetType, Color color)
        {
            foreach (Control control in controls)
            {
                if (control.GetType() == targetType)
                {
                    if (control is Edit edit)
                    {
                        edit.Frame.FlatColor = color;
                    }
                    else
                    if (control is NumberEdit numberEdit)
                    {
                        numberEdit.Frame.FlatColor = color;
                    }
                    else
                    if (control is LEDLabel ledLabel)
                    {
                        ledLabel.Frame.FlatColor = color;
                    }
                    else
                    if (control is KeypadEdit keypadEdit)
                    {
                        keypadEdit.Frame.FlatColor = color;
                    }
                    else
                    if (control is DaekhonSystem.ComboBox comboBox)
                    {
                        comboBox.Frame.FlatColor = color;
                    }
                }

                if (control is DaekhonSystem.TabControl tabControl)
                {
                    foreach (TabPage tabPage in tabControl.TabPages)
                    {
                        ChangeDaekhonControlColor(control.Controls, targetType, color);
                    }
                }
                else 
                if (control is TabPage tabPage)
                {
                    ChangeDaekhonControlColor(control.Controls, targetType, color);
                }
                else
                if (control.HasChildren)
                {
                    ChangeDaekhonControlColor(control.Controls, targetType, color);
                }
            }
        }
        #endregion

        public static void SetDefaultFont(Form form)
        {
            if (CultureInfo.CurrentCulture.Name.StartsWith("ko"))
            {
                form.Font = new Font("굴림", 9);
            }
            else
            {
                form.Font = new Font("Gulim", 9);
            }
        }

        public static void SetDefaultFont(UserControl ctrl)
        {
            if (CultureInfo.CurrentCulture.Name.StartsWith("ko"))
            {
                ctrl.Font = new Font("굴림", 9);
            }
            else
            {
                ctrl.Font = new Font("Gulim", 9);
            }
        }

        public static void UpdateFontToGulim(Control control)
        {
            // 현재 컨트롤의 폰트가 '굴림'이면 'Gulim'으로 변경
            if (control.Font.Name == "굴림")
            {
                control.Font = new Font("Gulim", control.Font.Size, control.Font.Style);
            }

            // 모든 하위 컨트롤에 대해 동일한 작업 수행
            foreach (Control childControl in control.Controls)
            {
                UpdateFontToGulim(childControl);
            }
        }

        public static string GetIniLanguageValue(IniData data, string strSectionName, string Keyname)
        {
            string strValue = data[strSectionName][Keyname];

            return strValue;

        }
    }

    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}

