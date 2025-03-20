using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YujinTechnology;
using Raize.CodeSiteLogging;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;
using IniParser.Model;

namespace LaserCutter
{
    public partial class panSideMenu : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();
        
        private frmChannelSpy frmChannelSpy;
        private frmMain frmMain;
        private panAuto Auto;

        private const int X_AXIS_NO = 1;
        private const int Y1_AXIS_NO = 2;
        private const int Y2_AXIS_NO = 3;
        private const int Z_AXIS_NO = 5;
        private const int ALL_AXIS = 6;

        public panSideMenu()
        {
            CodeSite.SendMsg("panSideMenu.Create()");

            InitializeComponent();

            SetCodeSitelogger();

            frmChannelSpy = frmChannelSpy.StaticInstance;
            frmMain = frmMain.StaticInstance;
            Auto = panAuto.StaticInstance;

            cbSpeed.SelectedIndex = 2;

            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));

            uiTabControl1.ItemSize = new Size(100, 40);
        }

        public void SetCodeSitelogger()
        {
            logger = new CodeSiteLogger();

            logger.Category = "SideMenu";

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

        #region staticInstance
        private static panSideMenu staticInstance;
        public static panSideMenu StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panSideMenu();
                }
                return staticInstance;
            }
        }
        #endregion

        #region public void SetDataServer(Control.ControlCollection controls)
        public void SetDataServer(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                //LEDLabel
                if (control is ValueIndicator)
                {
                    ((ValueIndicator)control).DataServer = frmChannelSpy.propGridMotion.DataServer;
                }
                else
                if (control is LEDLabel)
                {
                    ((LEDLabel)control).DataServer = frmChannelSpy.propGridMotion.DataServer;
                }
                if (control.HasChildren)
                {
                    SetDataServer(control.Controls);
                }
            }
        }
        #endregion

        public void Version1ChannelAssign()
        {
        #if _VERSION1
            SetDataServer(this.Controls);

            viXPosition.ChannelName = "X.Position";
            viY1Position.ChannelName = "Y1.Position";
            viY2Position.ChannelName = "Y2.Position";
            viZPosition.ChannelName = "Z.Position";

            ledXServo.ChannelName = "X.ServoOn";
            ledXInpos.ChannelName = "X.InPosition";
            ledY1Servo.ChannelName = "Y1.ServoOn";
            ledY1Inpos.ChannelName = "Y1.InPosition";
            ledY2Servo.ChannelName = "Y2.ServoOn";
            ledY2Inpos.ChannelName = "Y2.InPosition";
            ledZServo.ChannelName = "Z.ServoOn";
            ledZInpos.ChannelName = "Z.InPosition";

            btnLaserShutterOpen.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnLaserShutterOpen.ChannelName = Global.ciBeamShutterOpen.Name;

            btnLaserShutterClose.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnLaserShutterClose.ChannelName = Global.ciBeamShutterClose.Name;

            btnTable1Vacuum.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable1Vacuum.ChannelName = "Y07:Table1VacuumLamp";

            btnTable2Vacuum.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable2Vacuum.ChannelName = "Y11:Table2VacuumLamp";

            btnPowerMeterCoverClose.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnPowerMeterCoverClose.ChannelName = Global.ciPowerMeterClose.Name;

            btnPowerMeterCoverOpen.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnPowerMeterCoverOpen.ChannelName = Global.ciPowerMeterOpen.Name;

            btnDustCollectorOn.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnDustCollectorOn.ChannelName = Global.coDustCollector.Name;

            // yhbyun
            // btnOpticBoxPurgeOFF.DataServer = frmChannelSpy.propGridIO.DataServer;
            // btnOpticBoxPurgeOFF.ChannelName = Global.coOpticBoxPurge.Name;

            btnTable1Ionizer.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable1Ionizer.ChannelName = "Y17:Table1IonizerRun";

            btnTable2Ionizer.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable2Ionizer.ChannelName = "Y18:Table2IonizerRun";
        #endif
        }

        public void Version2ChannelAssign()
        {
         #if _VERSION2
            SetDataServer(this.Controls);

            viXPosition.ChannelName = "X.Position";
            viY1Position.ChannelName = "Y1.Position";
            viY2Position.ChannelName = "Y2.Position";
            viZPosition.ChannelName = "Z.Position";

            ledXServo.ChannelName = "X.ServoOn";
            ledXInpos.ChannelName = "X.InPosition";
            ledY1Servo.ChannelName = "Y1.ServoOn";
            ledY1Inpos.ChannelName = "Y1.InPosition";
            ledY2Servo.ChannelName = "Y2.ServoOn";
            ledY2Inpos.ChannelName = "Y2.InPosition";
            ledZServo.ChannelName = "Z.ServoOn";
            ledZInpos.ChannelName = "Z.InPosition";

            btnLaserShutterOpen.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnLaserShutterOpen.ChannelName = Global.ciBeamShutterOpen.Name;

            btnLaserShutterClose.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnLaserShutterClose.ChannelName = Global.ciBeamShutterClose.Name;

            btnTable1Vacuum.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable1Vacuum.ChannelName = "Y07:Table1VacuumLamp";
                                            
            btnTable2Vacuum.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable2Vacuum.ChannelName = "Y11:Table2VacuumLamp";

            btnPowerMeterCoverClose.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnPowerMeterCoverClose.ChannelName = Global.ciPowerMeterClose.Name;

            btnPowerMeterCoverOpen.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnPowerMeterCoverOpen.ChannelName = Global.ciPowerMeterOpen.Name;

            btnDustCollectorOn.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnDustCollectorOn.ChannelName = Global.coDustCollector.Name;

            btnOpticBoxPurgeOFF.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnOpticBoxPurgeOFF.ChannelName = Global.coOpticBoxPurge.Name;

            btnTable1Ionizer.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable1Ionizer.ChannelName = "Y14:Table1IonizerRun";

            btnTable2Ionizer.DataServer = frmChannelSpy.propGridIO.DataServer;
            btnTable2Ionizer.ChannelName = "Y16:Table2IonizerRun";
        #endif
        }

        public void SetVelocity(int nSelectAxis)
        {
            double dSpeed = 0.0;
            double dTA = 0.0;

            if (Global.chSelectSpeed.AsInteger == 0)//Low
            {
                if (nSelectAxis == Z_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[3].JogSpeedLow * 5;
                    dTA = Global.MotionParameters[3].JogTALow / 2;

                    Pmac.ZSetSpeed(dSpeed);
                    Pmac.ZSetTA(dTA);
                    Pmac.ZSetTS(dTA);
                }
                else
                if (nSelectAxis == X_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTALow / 2;//TA /2;

                    Pmac.XSetSpeed(dSpeed);
                    Pmac.XSetTA(dTA);
                    Pmac.XSetTS(dTA);
                }
                else if (nSelectAxis == Y1_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTALow / 2;//TA /2;

                    Pmac.Y1SetSpeed(dSpeed);
                    Pmac.Y1SetTA(dTA);
                    Pmac.Y1SetTS(dTA);
                }
                else
                if (nSelectAxis == Y2_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedLow * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTALow / 2;//TA /2;

                    Pmac.Y2SetSpeed(dSpeed);
                    Pmac.Y2SetTA(dTA);
                    Pmac.Y2SetTS(dTA);
                }
            }
            else
            if (Global.chSelectSpeed.AsInteger == 1)//Mid
            {
                if (nSelectAxis == Z_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[3].JogSpeedMiddle * 5;
                    dTA = Global.MotionParameters[3].JogTAMiddle / 2;

                    Pmac.ZSetSpeed(dSpeed);
                    Pmac.ZSetTA(dTA);
                    Pmac.ZSetTS(dTA);
                }
                else
                if (nSelectAxis == X_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAMiddle / 2;//TA /2;

                    Pmac.XSetSpeed(dSpeed);
                    Pmac.XSetTA(dTA);
                    Pmac.XSetTS(dTA);
                }
                else
                if (nSelectAxis == Y1_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAMiddle / 2;//TA /2;

                    Pmac.Y1SetSpeed(dSpeed);
                    Pmac.Y1SetTA(dTA);
                    Pmac.Y1SetTS(dTA);
                }
                else
                if (nSelectAxis == Y2_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedMiddle * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAMiddle / 2;//TA /2;

                    Pmac.Y2SetSpeed(dSpeed);
                    Pmac.Y2SetTA(dTA);
                    Pmac.Y2SetTS(dTA);
                }
            }
            else
            if (Global.chSelectSpeed.AsInteger == 2)
            {
                if (nSelectAxis == Z_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[3].JogSpeedHigh * 5;
                    dTA = Global.MotionParameters[3].JogTAHigh / 2;

                    Pmac.ZSetSpeed(dSpeed);
                    Pmac.ZSetTA(dTA);
                    Pmac.ZSetTS(dTA);
                }
                else
                if (nSelectAxis == X_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedHigh * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAHigh / 2;//TA /2;

                    Pmac.XSetSpeed(dSpeed);
                    Pmac.XSetTA(dTA);
                    Pmac.XSetTS(dTA);
                }
                else
                if (nSelectAxis == Y1_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedHigh * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAHigh / 2;//TA /2;

                    Pmac.Y1SetSpeed(dSpeed);
                    Pmac.Y1SetTA(dTA);
                    Pmac.Y1SetTS(dTA);
                }
                else
                if (nSelectAxis == Y2_AXIS_NO)
                {
                    dSpeed = Global.MotionParameters[nSelectAxis - 1].JogSpeedHigh * Const.XY_LINEAR_SCALE / 1000;//speed * Scale값/1000;
                    dTA = Global.MotionParameters[nSelectAxis - 1].JogTAHigh / 2;//TA /2;

                    Pmac.Y2SetSpeed(dSpeed);
                    Pmac.Y2SetTA(dTA);
                    Pmac.Y2SetTS(dTA);
                }
            }
        }

        private double CalcPosToCTS(int nSelectAxis, double dPos)
        {
            double dCts = 0;

            if (nSelectAxis == 0)//X
            {
                dCts = dPos * Const.XY_LINEAR_SCALE;
            }
            else
            if (nSelectAxis == 1 || nSelectAxis == 2)
            {
                dCts = dPos * Const.XY_LINEAR_SCALE;
            }
            else
            {
                dCts = dPos * Const.XY_LINEAR_SCALE;
            }

            return dCts;
        }

        private void btnXMoveAbs_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("X축을 이동합니다.", "확인"))
                {
                    logger.SendMsg("    SideMenu.btnXMoveAbs");

                    SetVelocity(X_AXIS_NO);

                    Pmac.XMoveAbs(edXOffset.Value);
                }
            }
        }

        private void btnY1MoveAbs_Click(object sender, EventArgs e)
        {
            if (Global.chY1ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Y1축을 이동합니다.", "확인"))
                {
                    logger.SendMsg("    SideMenu.btnY1MoveAbs");
                    
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.Y1MoveAbs(edY1Offset.Value);
                }
            }
        }

        private void btnY2MoveAbs_Click(object sender, EventArgs e)
        {
            if (Global.chY2ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Y2축을 이동합니다.", "확인"))
                {
                    logger.SendMsg("    SideMenu.btnY2MoveAbs");

                    SetVelocity(Y2_AXIS_NO);

                    Pmac.Y2MoveAbs(edY2Offset.Value);
                }
            }
        }

        private void btnZMoveAbs_Click(object sender, EventArgs e)
        {
            if (Global.chZServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Z축을 이동합니다.", "확인"))
                {
                    logger.SendMsg("    SideMenu.btnZMoveAbs");

                    SetVelocity(Z_AXIS_NO);

                    Pmac.ZMoveAbs(edZOffset.Value);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Pmac.AllStop();
        }

        private void btnXCCW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(X_AXIS_NO);

            Pmac.XJogCCW();
        }

        private void btnXCCW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.XStop();
        }

        private void btnXCW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(X_AXIS_NO);
            Pmac.XJogCW();
        }

        private void btnXCW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.XStop();
        }

        private void btnY1CW_MouseDown(object sender, MouseEventArgs e)
        {          
            SetVelocity(Y1_AXIS_NO);
            Pmac.Y1JogCW();
        }

        private void btnY1CW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.Y1Stop();
        }

        private void btnY1CCW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(Y1_AXIS_NO);
            Pmac.Y1JogCCW();
        }

        private void btnY1CCW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.Y1Stop();
        }

        private void btnY2CW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(Y2_AXIS_NO);
            Pmac.Y2JogCW();
        }

        private void btnY2CW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.Y2Stop();
        }

        private void btnY2CCW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(Y2_AXIS_NO);
            Pmac.Y2JogCCW();
        }

        private void btnY2CCW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.Y2Stop();
        }

        private void btnZCCW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(Z_AXIS_NO);
            Pmac.ZJogCCW();
        }

        private void btnZCCW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.ZStop();
        }

        private void btnZCW_MouseDown(object sender, MouseEventArgs e)
        {
            SetVelocity(Z_AXIS_NO);
            Pmac.ZJogCW();
        }

        private void btnZCW_MouseUp(object sender, MouseEventArgs e)
        {
            Pmac.ZStop();
        }

        private void btnXMoveCCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnXMoveCCW()");

            SetVelocity(X_AXIS_NO);

            Pmac.XMoveInc(-edXOffset.Value);
        }

        private void btnXMoveCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnXMoveCW()");

            SetVelocity(X_AXIS_NO);
            Pmac.XMoveInc(edXOffset.Value);
        }

        private void btnY1MoveCCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnY1MoveCCW()");

            SetVelocity(Y1_AXIS_NO);

            Pmac.Y1MoveInc(-edY1Offset.Value);
        }

        private void btnY1MoveCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnY1MoveCW()");

            SetVelocity(Y1_AXIS_NO);

            Pmac.Y1MoveInc(edY1Offset.Value);
        }

        private void btnY2MoveCCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnY2MoveCCW()");

            SetVelocity(Y2_AXIS_NO);

            Pmac.Y2MoveInc(-edY2Offset.Value);
        }

        private void btnY2MoveCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnY2MoveCW()");
            
            SetVelocity(Y2_AXIS_NO);

            Pmac.Y2MoveInc(edY2Offset.Value);
        }

        private void btnZMoveCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnZMoveCW()");
            
            SetVelocity(Z_AXIS_NO);

            Pmac.ZMoveInc(edZOffset.Value);
        }

        private void btnZMoveCCW_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    SideMenu.btnZMoveCCW()");

            SetVelocity(Z_AXIS_NO);

            Pmac.ZMoveInc(-edZOffset.Value);
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiTabControl1.SelectedTab == tabPage2)
            {
                cbSpeed.SelectedIndex = Global.chSelectSpeed.AsInteger;
            }
        }

        private void btnLaserShutterOpen_Click(object sender, EventArgs e)
        {
            Pmac.QueryCommand("doBeamShutterOpen=true");
        }

        private void btnLaserShutterClose_Click(object sender, EventArgs e)
        {
            Pmac.QueryCommand("doBeamShutterOpen=false");
        }


        private void btnTable1Vacuum_Click(object sender, EventArgs e)
        {
            if (btnTable1Vacuum.LED.Value)
            {
                Pmac.QueryCommand("Table1VacuumOff=true");
            }
            else
            {
                Pmac.QueryCommand("Table1VacuumOn=true");
            }
        }
        private void btnTable2Vacuum_Click(object sender, EventArgs e)
        {
            if (btnTable2Vacuum.LED.Value)
            {
                Pmac.QueryCommand("Table2VacuumOff=true");
            }
            else
            {
                Pmac.QueryCommand("Table2VacuumOn=true");
            }
        }
        
        public void PowerMeterCoverOpen()
        {
            Pmac.QueryCommand("doPowerMeterCoverOpen=true");
            Pmac.QueryCommand("doPowerMeterCoverClose=false");
        }

        private void btnPowerMeterCoverOpen_Click(object sender, EventArgs e)
        {
            PowerMeterCoverOpen();
        }

        public void PowerMeterCoverClose()
        {
            Pmac.QueryCommand("doPowerMeterCoverClose=true");
            Pmac.QueryCommand("doPowerMeterCoverOpen=false");
        }
        private void btnPowerMeterCoverClose_Click(object sender, EventArgs e)
        {
            PowerMeterCoverClose();
        }

        private void btnDustColOn_Click(object sender, EventArgs e)
        {
            btnDustCollectorOn.LED.Value = !btnDustCollectorOn.LED.Value;

            if (btnDustCollectorOn.LED.Value)
            {
                Pmac.QueryCommand("doDustCollectorOn=true");
            }
            else
            {
                Pmac.QueryCommand("doDustCollectorOn=false");
            }
        }

        private void btnTable1Ionizer_Click(object sender, EventArgs e)
        {
            btnTable1Ionizer.LED.Value = !btnTable1Ionizer.LED.Value;

            if (btnTable1Ionizer.LED.Value)
            {
                Pmac.QueryCommand("doTable1IonizerOn=true");
                Pmac.QueryCommand("doTable1IonizerSol=true");
            }
            else
            {
                Pmac.QueryCommand("doTable1IonizerOn=false");
                Pmac.QueryCommand("doTable1IonizerSol=false");
            }
        }

        private void btnTable2Ionizer_Click(object sender, EventArgs e)
        {
            btnTable2Ionizer.LED.Value = !btnTable2Ionizer.LED.Value;

            if (btnTable2Ionizer.LED.Value)
            {
                Pmac.QueryCommand("doTable2IonizerOn=true");
                Pmac.QueryCommand("doTable2IonizerSol=true");
            }
            else
            {
                Pmac.QueryCommand("doTable2IonizerOn=false");
                Pmac.QueryCommand("doTable2IonizerSol=false");
            }
        }

  

        private void btnTable1MoveLoadPos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                logger.SendMsg("    btnTable1MoveLoadPos.Click");

                if (yjCommon.Confirm("Table1 LoadPos으로 이동합니다.", "확인") == DialogResult.Yes)
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveAbs(Global.chLoadPosX.AsDouble);
                    Pmac.Y1MoveAbs(Global.chTable1LoadPosY.AsDouble);
                }
            }
        }


        private void btnMoveTable2Save2Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                logger.SendMsg("    btnMoveTable2Save2Pos.Click");
                
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table#2 저장위치#2 로 이동합니다.", "확인"))
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveAbs(edTable2Save2XPos.Value);
                    Pmac.Y2MoveAbs(edTable2Save2YPos.Value);
                }
            }
        }

        private void btnMoveTable2Save3Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                logger.SendMsg("    btnMoveTable2Save3Pos.Click");
                
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table#2 저장위치#3 로 이동합니다.", "확인"))
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveAbs(edTable2Save3XPos.Value);
                    Pmac.Y2MoveAbs(edTable2Save3YPos.Value);
                }
            }
        }

        private void btnMoveTable2Save4Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                logger.SendMsg("    btnMoveTable2Save4Pos.Click");

                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table#2 저장위치#4 로 이동합니다.", "확인"))
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveAbs(edTable2Save4XPos.Value);
                    Pmac.Y2MoveAbs(edTable2Save4YPos.Value);
                }
            }
        }

        private void btnMoveTable2Save5Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                logger.SendMsg("    btnMoveTable2Save5Pos.Click");

                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table#2 저장위치#5 로 이동합니다.", "확인"))
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveAbs(edTable2Save5XPos.Value);
                    Pmac.Y2MoveAbs(edTable2Save5YPos.Value);
                }
            }
        }

        private void btnTable1MoveCenterPos_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnTable1MoveCenterPos.Click");
            
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y1_AXIS_NO);
                Pmac.XMoveAbs(Global.chTable1CenterXPos.AsDouble);
                Pmac.Y1MoveAbs(Global.chTable1CenterYPos.AsDouble);
            }
        }

        private void btnTable2MoveCenterPos_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnTable2MoveCenterPos.Click");

            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                SetVelocity(X_AXIS_NO);
                SetVelocity(Y2_AXIS_NO);
                Pmac.XMoveAbs(Global.chTable2CenterXPos.AsDouble);
                Pmac.Y2MoveAbs(Global.chTable2CenterYPos.AsDouble);
            }
        }

        #region public void ChangeLanguageEnglish()
        public void ChangeLanguageEnglish()
        {
            btnTable1MoveCenterPos.Text     = Global.iniEng.ReadString("panSideMenu", "btnTable1MoveCenterPos.Text", "Stage Center Position");
            btnTable1VisionToNozzle.Text    = Global.iniEng.ReadString("panSideMenu", "btnTable1VisionToNozzle.Text", "Vision -> Nozzle");
            btnTable1NozzleToVision.Text    = Global.iniEng.ReadString("panSideMenu", "btnTable1NozzleToVision.Text", "Nozzle -> Vision");
            btnTable1ZMoveLaserFocus.Text   = Global.iniEng.ReadString("panSideMenu", "btnTable1ZMoveLaserFocus.Text", "Laser Focus");
            btnTable1MoveLoadPos.Text       = Global.iniEng.ReadString("panSideMenu", "btnTable1MoveLoadPos.Text", "Loading Position");
            btnTable2MoveCenterPos.Text     = Global.iniEng.ReadString("panSideMenu", "btnTable2MoveCenterPos.Text", "Stage Center Position");
            btnTable2VisionToNozzle.Text    = Global.iniEng.ReadString("panSideMenu", "btnTable2VisionToNozzle.Text", "Vision -> Nozzle");
            btnTable2NozzleToVision.Text    = Global.iniEng.ReadString("panSideMenu", "btnTable2NozzleToVision.Text", "Nozzle -> Vision");
            btnTable2ZMoveLaserFocus.Text   = Global.iniEng.ReadString("panSideMenu", "btnTable2ZMoveLaserFocus.Text", "Laser Focus");
            btnTable2MoveLoadPos.Text       = Global.iniEng.ReadString("panSideMenu", "btnTable2MoveLoadPos.Text", "Loading Position");

            btnSetTable1Save1Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable1Save1Pos.Text", "Set");
            btnMoveTable1Save1Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable1Save1Pos.Text", "Move");
            btnSetTable1Save2Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable1Save2Pos.Text", "Set");
            btnMoveTable1Save2Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable1Save2Pos.Text", "Move");
            btnSetTable1Save3Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable1Save3Pos.Text", "Set");
            btnMoveTable1Save3Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable1Save3Pos.Text", "Move");
            btnSetTable1Save4Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable1Save4Pos.Text", "Set");
            btnMoveTable1Save4Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable1Save4Pos.Text", "Move");
            btnSetTable1Save5Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable1Save5Pos.Text", "Set");
            btnMoveTable1Save5Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable1Save5Pos.Text", "Move");
            btnSetTable2Save1Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable2Save1Pos.Text", "Set");
            btnMoveTable2Save1Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable2Save1Pos.Text", "Move");
            btnSetTable2Save2Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable2Save2Pos.Text", "Set");
            btnMoveTable2Save2Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable2Save2Pos.Text", "Move");
            btnSetTable2Save3Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable2Save3Pos.Text", "Set");
            btnMoveTable2Save3Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable2Save3Pos.Text", "Move");
            btnSetTable2Save4Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable2Save4Pos.Text", "Set");
            btnMoveTable2Save4Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable2Save4Pos.Text", "Move");
            btnSetTable2Save5Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnSetTable2Save5Pos.Text", "Set");
            btnMoveTable2Save5Pos.Text = Global.iniEng.ReadString("panSideMenu", "btnMoveTable2Save5Pos.Text", "Move");

            btnZCCW.Text = Global.iniEng.ReadString("panSideMenu", "btnZCCW.Text", "Up");
            btnZCW.Text = Global.iniEng.ReadString("panSideMenu", "btnZCW.Text", "Down");

            btnXMoveAbs.Text = Global.iniEng.ReadString("panSideMenu", "btnXMoveAbs.Text", "ABS GO");
            btnY1MoveAbs.Text = Global.iniEng.ReadString("panSideMenu", "btnY1MoveAbs.Text", "ABS GO");
            btnY2MoveAbs.Text = Global.iniEng.ReadString("panSideMenu", "btnY2MoveAbs.Text", "ABS GO");
            btnZMoveAbs.Text = Global.iniEng.ReadString("panSideMenu", "btnZMoveAbs.Text", "ABS GO");
            btnStop.Text = Global.iniEng.ReadString("panSideMenu", "btnStop.Text", "ABS GO");

            btnLaserShutterOpen.Text = Global.iniEng.ReadString("panSideMenu", "btnLaserShutterOpen.Text", "Open");
            btnLaserShutterClose.Text = Global.iniEng.ReadString("panSideMenu", "btnLaserShutterClose.Text", "Close");
           btnPowerMeterCoverOpen.Text = Global.iniEng.ReadString("panSideMenu", "btnPowerMeterDown.Text", "Open");
            btnPowerMeterCoverClose.Text = Global.iniEng.ReadString("panSideMenu", "btnPowerMeterUp.Text", "Up");
            btnDustCollectorOn.Text = Global.iniEng.ReadString("panSideMenu", "btnDustColOn.Text", "On");
            btnTable1Ionizer.Text = Global.iniEng.ReadString("panSideMenu", "btnTable1Ionizer.Text", "ON");
            btnTable2Ionizer.Text = Global.iniEng.ReadString("panSideMenu", "btnTable2Ionizer.Text", "ON");
            btnOpticBoxPurgeOFF.Text = Global.iniEng.ReadString("panSideMenu", "btnOpticBoxPurgeOn.Text", "OFF");
        }
        public void ChangeLanguageKorea()
        {

            btnTable1MoveCenterPos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable1MoveCenterPos.Text");
            btnTable1VisionToNozzle.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable1VisionToNozzle.Text");
            btnTable1NozzleToVision.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable1NozzleToVision.Text");
            btnTable1ZMoveLaserFocus.Text     = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable1ZMoveLaserFocus.Text");
            btnTable1MoveLoadPos.Text         = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable1MoveLoadPos.Text");
            btnTable2MoveCenterPos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable2MoveCenterPos.Text");
            btnTable2VisionToNozzle.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable2VisionToNozzle.Text");
            btnTable2NozzleToVision.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable2NozzleToVision.Text");
            btnTable2ZMoveLaserFocus.Text     = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable2ZMoveLaserFocus.Text");
            btnTable2MoveLoadPos.Text         = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable2MoveLoadPos.Text");

            tabPage4.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "tabPage4.Text");
            tabPage5.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "tabPage5.Text");

            btnSetTable1Save1Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable1Save1Pos.Text" );
            btnMoveTable1Save1Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable1Save1Pos.Text");
            btnSetTable1Save2Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable1Save2Pos.Text" );
            btnMoveTable1Save2Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable1Save2Pos.Text");
            btnSetTable1Save3Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable1Save3Pos.Text" );
            btnMoveTable1Save3Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable1Save3Pos.Text");
            btnSetTable1Save4Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable1Save4Pos.Text" );
            btnMoveTable1Save4Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable1Save4Pos.Text");
            btnSetTable1Save5Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable1Save5Pos.Text" );
            btnMoveTable1Save5Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable1Save5Pos.Text");
            btnSetTable2Save1Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable2Save1Pos.Text" );
            btnMoveTable2Save1Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable2Save1Pos.Text");
            btnSetTable2Save2Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable2Save2Pos.Text" );
            btnMoveTable2Save2Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable2Save2Pos.Text");
            btnSetTable2Save3Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable2Save3Pos.Text" );
            btnMoveTable2Save3Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable2Save3Pos.Text");
            btnSetTable2Save4Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable2Save4Pos.Text" );
            btnMoveTable2Save4Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable2Save4Pos.Text");
            btnSetTable2Save5Pos.Text       = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnSetTable2Save5Pos.Text" );
            btnMoveTable2Save5Pos.Text      = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnMoveTable2Save5Pos.Text");

            btnZCCW.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnZCCW.Text");
            btnZCW.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnZCW.Text");
            btnXMoveAbs.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnXMoveAbs.Text");
            btnY1MoveAbs.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnY1MoveAbs.Text");
            btnY2MoveAbs.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnY2MoveAbs.Text");
            btnZMoveAbs.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnZMoveAbs.Text");
            btnStop.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnStop.Text");
            btnLaserShutterOpen.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnLaserShutterOpen.Text");
            btnLaserShutterClose.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnLaserShutterClose.Text");
            btnPowerMeterCoverOpen.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnPowerMeterDown.Text");
            btnPowerMeterCoverClose.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnPowerMeterUp.Text");
            btnDustCollectorOn.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnDustColOn.Text");
            btnTable1Ionizer.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable1Ionizer.Text");
            btnTable2Ionizer.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnTable2Ionizer.Text");
            btnOpticBoxPurgeOFF.Text = Global.GetIniLanguageValue(Global.iniKor, "panSideMenu", "btnOpticBoxPurgeOn.Text");
        }
        public void ChangeLanguageVietnam()
        {
            btnTable1MoveCenterPos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable1MoveCenterPos.Text");
            btnTable1VisionToNozzle.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable1VisionToNozzle.Text");
            btnTable1NozzleToVision.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable1NozzleToVision.Text");
            btnTable1ZMoveLaserFocus.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable1ZMoveLaserFocus.Text");
            btnTable1MoveLoadPos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable1MoveLoadPos.Text");
            btnTable2MoveCenterPos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable2MoveCenterPos.Text");
            btnTable2VisionToNozzle.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable2VisionToNozzle.Text");
            btnTable2NozzleToVision.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable2NozzleToVision.Text");
            btnTable2ZMoveLaserFocus.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable2ZMoveLaserFocus.Text");
            btnTable2MoveLoadPos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable2MoveLoadPos.Text");

            tabPage4.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "tabPage4.Text");
            tabPage5.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "tabPage5.Text");

            btnSetTable1Save1Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable1Save1Pos.Text");
            btnMoveTable1Save1Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable1Save1Pos.Text");
            btnSetTable1Save2Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable1Save2Pos.Text");
            btnMoveTable1Save2Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable1Save2Pos.Text");
            btnSetTable1Save3Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable1Save3Pos.Text");
            btnMoveTable1Save3Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable1Save3Pos.Text");
            btnSetTable1Save4Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable1Save4Pos.Text");
            btnMoveTable1Save4Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable1Save4Pos.Text");
            btnSetTable1Save5Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable1Save5Pos.Text");
            btnMoveTable1Save5Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable1Save5Pos.Text");
            btnSetTable2Save1Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable2Save1Pos.Text");
            btnMoveTable2Save1Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable2Save1Pos.Text");
            btnSetTable2Save2Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable2Save2Pos.Text");
            btnMoveTable2Save2Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable2Save2Pos.Text");
            btnSetTable2Save3Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable2Save3Pos.Text");
            btnMoveTable2Save3Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable2Save3Pos.Text");
            btnSetTable2Save4Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable2Save4Pos.Text");
            btnMoveTable2Save4Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable2Save4Pos.Text");
            btnSetTable2Save5Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnSetTable2Save5Pos.Text");
            btnMoveTable2Save5Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnMoveTable2Save5Pos.Text");

            btnZCCW.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnZCCW.Text");
            btnZCW.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnZCW.Text");
            btnXMoveAbs.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnXMoveAbs.Text");
            btnY1MoveAbs.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnY1MoveAbs.Text");
            btnY2MoveAbs.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnY2MoveAbs.Text");
            btnZMoveAbs.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnZMoveAbs.Text");
            btnStop.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnStop.Text");
            btnLaserShutterOpen.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnLaserShutterOpen.Text");
            btnLaserShutterClose.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnLaserShutterClose.Text");
            btnPowerMeterCoverOpen.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnPowerMeterDown.Text");
            btnPowerMeterCoverClose.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnPowerMeterUp.Text");
            btnDustCollectorOn.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnDustColOn.Text");
            btnTable1Ionizer.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable1Ionizer.Text");
            btnTable2Ionizer.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnTable2Ionizer.Text");
            btnOpticBoxPurgeOFF.Text = Global.GetIniLanguageValue(Global.iniVie, "panSideMenu", "btnOpticBoxPurgeOn.Text");
        }
        #endregion
        private void btnSetTable1Save1Pos_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnSetTable1Save1Pos.Click");

            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table1 저장위치1로 지정합니다.", "확인"))
            {
                edTable1Save1XPos.Value = Global.chXActualPos.AsDouble;
                edTable1Save1YPos.Value = Global.chY1ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable1Save2Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table1 저장위치2로 지정합니다.", "확인"))
            {
                edTable1Save2XPos.Value = Global.chXActualPos.AsDouble;
                edTable1Save2YPos.Value = Global.chY1ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnTable1VisionToNozzle_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean && Global.chZServoOn.AsBoolean)
            {
                if (yjCommon.Confirm("Table1 Nozzle 기점 위치로 이동합니다.", "확인") == DialogResult.Yes)
                {
                    logger.SendMsg("    btnTable1VisionToNozzle.Click()");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveInc(frmMain.Config.Common.edTable2NozzleXOffset.Value);
                    Pmac.Y1MoveInc(frmMain.Config.Common.edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(Global.chTable1LaserZFocus.AsDouble);
                }
            }
        }

        private void btnTable2VisionToNozzle_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean && Global.chZServoOn.AsBoolean)
            {
                if (yjCommon.Confirm("Table2 Nozzle 기점 위치로 이동합니다.", "확인") == DialogResult.Yes)
                {
                    logger.SendMsg("    btnTable2VisionToNozzle.Click()");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveInc(frmMain.Config.Common.edTable2NozzleXOffset.Value);
                    Pmac.Y2MoveInc(frmMain.Config.Common.edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(Global.chTable2LaserZFocus.AsDouble);
                }
            }
        }

        private void btnTable1NozzleToVision_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean && Global.chZServoOn.AsBoolean)
            {
                if (yjCommon.Confirm("Table1 Vision 기점 위치로 이동합니다.", "확인") == DialogResult.Yes)
                {
                    logger.SendMsg("    btnTable1NozzleToVision.Click()");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveInc(-frmMain.Config.Common.edTable2NozzleXOffset.Value);
                    Pmac.Y1MoveInc(-frmMain.Config.Common.edTable2NozzleYOffset.Value);
                    Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
                }
            }
        }

        private void btnTable2NozzleToVision_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean && Global.chZServoOn.AsBoolean)
            {
                if (yjCommon.Confirm("Table2 Vision 기점 위치로 이동합니다.", "확인") == DialogResult.Yes)
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveInc(-frmMain.Config.Common.edTable2NozzleXOffset.Value);
                    Pmac.Y2MoveInc(-frmMain.Config.Common.edTable2NozzleYOffset.Value);
                }   Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
        }

        private void btnSetTable1Save3Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table1 저장위치3로 지정합니다.", "확인"))
            {
                edTable1Save3XPos.Value = Global.chXActualPos.AsDouble;
                edTable1Save3YPos.Value = Global.chY1ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable1Save4Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table1 저장위치4로 지정합니다.", "확인"))
            {
                edTable1Save4XPos.Value = Global.chXActualPos.AsDouble;
                edTable1Save4YPos.Value = Global.chY1ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable1Save5Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table1 저장위치5로 지정합니다.", "확인"))
            {
                edTable1Save5XPos.Value = Global.chXActualPos.AsDouble;
                edTable1Save5YPos.Value = Global.chY1ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnMoveTable1Save1Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table1 저장위치1로 이동합니다.", "확인"))
                {
                    logger.SendMsg("    btnMoveTable1Save1Pos");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveAbs(edTable1Save1XPos.Value);
                    Pmac.Y1MoveAbs(edTable1Save1YPos.Value);
                }
            }
        }

        private void btnMoveTable1Save2Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table1 저장위치2로 이동합니다.", "확인"))
                {
                    logger.SendMsg("    btnMoveTable1Save2Pos");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveAbs(edTable1Save2XPos.Value);
                    Pmac.Y1MoveAbs(edTable1Save2YPos.Value);
                }
            }
        }

        private void btnMoveTable1Save3Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table1 저장위치3 로 이동합니다.", "확인"))
                {
                    logger.SendMsg("    btnMoveTable1Save3Pos");
                    
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveAbs(edTable1Save3XPos.Value);
                    Pmac.Y1MoveAbs(edTable1Save3YPos.Value);
                }
            }
        }

        private void btnMoveTable1Save4Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table1 저장위치4 로 이동합니다.", "확인"))
                {
                    logger.SendMsg("    btnMoveTable1Save4Pos");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveAbs(edTable1Save4XPos.Value);
                    Pmac.Y1MoveAbs(edTable1Save4YPos.Value);
                }
            }
        }

        private void btnMoveTable1Save5Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY1ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table1 저장위치5 로 이동합니다.", "확인"))
                {
                    logger.SendMsg("    btnMoveTable1Save5Pos");

                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y1_AXIS_NO);

                    Pmac.XMoveAbs(edTable1Save5XPos.Value);
                    Pmac.Y1MoveAbs(edTable1Save5YPos.Value);
                }
            }
        }

        private void btnSetTable2Save1Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table2 저장위치1로 지정합니다.", "확인"))
            {
                edTable2Save1XPos.Value = Global.chXActualPos.AsDouble;
                edTable2Save1YPos.Value = Global.chY2ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable2Save2Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table2 저장위치2로 지정합니다.", "확인"))
            {
                edTable2Save2XPos.Value = Global.chXActualPos.AsDouble;
                edTable2Save2YPos.Value = Global.chY2ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable2Save3Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table2 저장위치3로 지정합니다.", "확인"))
            {
                edTable2Save3XPos.Value = Global.chXActualPos.AsDouble;
                edTable2Save3YPos.Value = Global.chY2ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable2Save4Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table2 저장위치4로 지정합니다.", "확인"))
            {
                edTable2Save4XPos.Value = Global.chXActualPos.AsDouble;
                edTable2Save4YPos.Value = Global.chY2ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnSetTable2Save5Pos_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("현재 위치를 Table2 저장위치5로 지정합니다.", "확인"))
            {
                edTable2Save5XPos.Value = Global.chXActualPos.AsDouble;
                edTable2Save5YPos.Value = Global.chY2ActualPos.AsDouble;

                PropSaver.SaveProperty();
                PropSaver.LoadProperty();
            }
        }

        private void btnMoveTable2Save1Pos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                if (System.Windows.Forms.DialogResult.Yes == yjCommon.Confirm("Table#2 저장위치#1 로 이동합니다.", "확인"))
                {
                    logger.SendMsg("    btnMoveTable2Save1Pos");
                    
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveAbs(edTable2Save1XPos.Value);
                    Pmac.Y2MoveAbs(edTable2Save1YPos.Value);
                }
            }
        }

        private void cbSpeed_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Global.chSelectSpeed == null) return;

            Global.chSelectSpeed.AsInteger = cbSpeed.SelectedIndex;
            frmMain.Manual.Motion.cbSpeed.ItemIndex = cbSpeed.SelectedIndex;
        }

        private void btnTable1ZMoveLaserFocus_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnTable1ZMoveLaserFocus.Click()");

            if (Global.chZServoOn.AsBoolean)
            {
                SetVelocity(Z_AXIS_NO);
                Pmac.ZMoveAbs(Global.chTable1LaserZFocus.AsDouble);
            }
            else
            {
                // AddError()
            }
        }

        private void btnTable2ZMoveLaserFocus_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnTable2ZMoveLaserFocus.Click");
            
            if (Global.chZServoOn.AsBoolean)
            {
                SetVelocity(Z_AXIS_NO);
                Pmac.ZMoveAbs(Global.chTable2LaserZFocus.AsDouble);
            }
            else
            {
                // AddError()
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto.TabControl1.SelectedIndex = tabControl2.SelectedIndex;
        }

        private void btnTable2MoveLoadPos_Click(object sender, EventArgs e)
        {
            if (Global.chXServoOn.AsBoolean && Global.chY2ServoOn.AsBoolean)
            {
                if (yjCommon.Confirm("Table2 LoadPos으로 이동합니다.", "확인") == DialogResult.Yes)
                {
                    SetVelocity(X_AXIS_NO);
                    SetVelocity(Y2_AXIS_NO);

                    Pmac.XMoveAbs(Global.chLoadPosX.AsDouble);
                    Pmac.Y2MoveAbs(Global.chTable2LoadPosY.AsDouble);
                }
            }
        }

        private void btnOpticBoxPurgeOFF_Click(object sender, EventArgs e)
        {
            if (btnOpticBoxPurgeOFF.LED.Value)
            {
                Pmac.QueryCommand("doOpticBoxPurgeOff=false");
            }
            else
            {
                Pmac.QueryCommand("doOpticBoxPurgeOff=true");
            }
        }

        private void btnTable1ZMoveVisionFocus_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnTable1ZMoveVisionFocus.Click()");
            
            if (Global.chZServoOn.AsBoolean)
            {
                SetVelocity(Z_AXIS_NO);
                Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
            }
            else
            {
                // AddError()
            }
        }

        private void btnTable2ZMoveVisionFocus_Click(object sender, EventArgs e)
        {
            logger.SendMsg("    btnTable2ZMoveVisionFocus.Click()");

            if (Global.chZServoOn.AsBoolean)
            {
                SetVelocity(Z_AXIS_NO);
                Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
            }
            else
            {
                // AddError()
            }
        }
    }
}
