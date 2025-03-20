using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using DaekhonSystem;

namespace LaserCutter
{
    public partial class panJobInfo : UserControl
    {
        public panJobType1 Type1;
        public panJobType2 Type2;
        public panJobType3 Type3;

        public frmMain frmMain;

        public panJobInfo()
        {
            // logger.SendMsg("panJobInfo()");
            InitializeComponent();

            Type1 = new panJobType1();
            Type1.Auto = panAuto.StaticInstance;
            Type1.EnableControl(false);

            Type2 = new panJobType2();
            Type2.Auto = panAuto.StaticInstance;
            Type2.EnableControl(false);

            Type3 = new panJobType3();
            Type3.Auto = panAuto.StaticInstance;
            Type3.EnableControl(false);

            frmMain = frmMain.StaticInstance;

            tabPage1.Controls.Add(Type1);                        
            tabPage2.Controls.Add(Type2);
            tabPage3.Controls.Add(Type3);

            Type1.Location = new Point(2, 0);
            Type2.Location = new Point(2, 0);
            Type3.Location = new Point(2, 0);
        }

        #region private TableNo TableNo
        private TableNo mTableNo;

        public TableNo TableNo
        {
            get
            {
                return mTableNo;
            }

            set
            {
                mTableNo = value;
            }
        }
        #endregion

        private void TabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.ChangeAutoTitle();
            SetEventProc();
        }

        public void SetEventProc()
        {
            switch (TabControl2.SelectedIndex)
            {
                case 0:
                    if (Type1.Cad1 != null)
                    {
                        Type1.Cad1.SetEventProc();
                    }
                    break;

                case 1:
                    if (Type2.Cad2 != null)
                    {
                        Type2.Cad2.SetEventProc();
                    }
                    break;

                case 2:
                    if (Type3.Cad3 != null)
                    {
                        Type3.Cad3.SetEventProc();
                    }
                    break;
            }
        }

        public DoublePoint MakeLineType(ztLineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptS = new DoublePoint(OffsetX + (pItem.X0 + ShiftX), OffsetY - (pItem.Y0 + ShiftY));
                DoublePoint ptE = new DoublePoint(OffsetX + (pItem.X1 + ShiftX), OffsetY - (pItem.Y1 + ShiftY));

                rr = ptS;
            }

            return rr;
        }

        public DoublePoint MakeLineType(bool LaserRun, ref StringList List, ztLineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptS = new DoublePoint(OffsetX + (pItem.X0 + ShiftX), OffsetY - (pItem.Y0 + ShiftY));
                DoublePoint ptE = new DoublePoint(OffsetX + (pItem.X1 + ShiftX), OffsetY - (pItem.Y1 + ShiftY));

                rr = ptS;

                if (List != null)
                {
                    SetSpeed(ref List, Global.chConJumpSpeed.AsDouble, Global.chConJumpTA.AsDouble, 20, ptS, false);
                    List.Add($"    DWELL 7");
                    if (LaserRun)
                    {
                        List.Add($"    doLaserTriggerOn==true");// file.WriteLine($"M7122==1"); i/o확인 해야함!!!
                    } 
                    else
                    {
                        List.Add($"    doLaserTriggerOn==false"); // DryRun
                    }
                    List.Add($"    DWELL 7");
                    List.Add("");

                    SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptE, true);
                    List.Add($"    DWELL 7");
                    List.Add($"    doLaserTriggerOn==false");// file.WriteLine($"M7122==0"); i/o확인 해야함!!!
                    List.Add($"    DWELL 7");
                }
            }

            return rr;
        }

        public DoublePoint MakePolylineType(ztPolylineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                for (int nVertexIndex = 0; nVertexIndex < pItem.GetCount(); nVertexIndex++)
                {
                    ztPolylineVertex pVertex = pItem.GetVertex(nVertexIndex);
                    pVertex.CalculateArcCenter();

                    double dBulge = pItem.GetVertex(nVertexIndex).Bulge;
                    double dR = 0.0;

                    if (dBulge != 0.0)
                    {
                        dR = pItem.GetVertex(nVertexIndex).ArcRad;
                    }

                    if (nVertexIndex == 0)
                    {
                        if (dBulge != 0.0)
                        {
                            DoublePoint ptS, ptE;
                            DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                            DoublePoint ptC = new DoublePoint(0, 0);// = new DoublePoint { x = pVertex.cX, y = pVertex.cY };
                            DoublePoint ptTempC = new DoublePoint(0, 0);

                            ptS = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                            ptE = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));

                            rr = ptS;
                        }
                        else
                        {
                            DoublePoint ptS = new DoublePoint(OffsetX + (pVertex.X + ShiftX), OffsetY - (pVertex.Y + ShiftY));

                            rr = ptS;
                        }
                    }
                }
            }

            return rr;
        }

        public DoublePoint MakePolylineType(bool LaserRun, ref StringList List, ztPolylineItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint ptPrev = new DoublePoint(0, 0);
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                for (int nVertexIndex = 0; nVertexIndex < pItem.GetCount(); nVertexIndex++)
                {
                    ztPolylineVertex pVertex = pItem.GetVertex(nVertexIndex);
                    pVertex.CalculateArcCenter();

                    double dBulge = pItem.GetVertex(nVertexIndex).Bulge;
                    double dR = 0.0;

                    if (dBulge != 0.0)
                    {
                        dR = pItem.GetVertex(nVertexIndex).ArcRad;
                    }

                    if (nVertexIndex == 0)
                    {
                        if (dBulge != 0.0)
                        {
                            List.Add("");
                            List.Add($"    // Arc [{nVertexIndex}/{pItem.GetCount()}]");

                            double cx, cy;

                            DoublePoint ptStart, ptEnd;
                            DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                            DoublePoint ptCenter = new DoublePoint(0, 0);

                            ptStart = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                            ptEnd = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));

                            rr = ptStart;

                            cx = pVertex.cX;
                            cy = pVertex.cY;
                            ptCenter = new DoublePoint { x = OffsetX + (pVertex.cX + ptShift.x), y = OffsetY - (pVertex.cY + ptShift.y) };
                            SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptStart, false);

                            WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, (pVertex.Bulge < 0)); // Bulge값이 음수일때가 CountClock 방향
                            List.Add($"    DWELL 7");
                            if (LaserRun)
                            {
                                List.Add($"    doLaserTriggerOn==true");// file.WriteLine($"M7122==1"); i/o확인 해야함!!!
                            } 
                            else
                            {
                                List.Add($"    doLaserTriggerOn==false");// DryRun
                            }
                            List.Add($"    DWELL 7");
                        }
                        else
                        {
                            List.Add("");
                            List.Add($"    // Line [{nVertexIndex}/{pItem.GetCount()}]");

                            DoublePoint ptStart = new DoublePoint(OffsetX + (pVertex.X + ShiftX), OffsetY - (pVertex.Y + ShiftY));

                            rr = ptStart;

                            SetSpeed(ref List, Global.chConJumpSpeed.AsDouble, Global.chConJumpTA.AsDouble, 20, ptStart, false);
                            List.Add($"    DWELL 7");
                            if (LaserRun)
                            {
                                List.Add($"    doLaserTriggerOn==true");
                            } 
                            else
                            {
                                List.Add($"    doLaserTriggerOn==false"); // DryRun
                            }
                            List.Add($"    DWELL 7");

                            List.Add("");
                            DoublePoint ptEnd = new DoublePoint(OffsetX + (pVertex.X + pVertex.dX + ShiftX), OffsetY - (pVertex.Y + pVertex.dY + ShiftY));

                            SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptEnd, false);
                        }
                    }
                    else
                    if (nVertexIndex < (pItem.GetCount() - 1))
                    {
                        if (dBulge != 0.0)
                        {
                            List.Add("");
                            List.Add($"    // Arc [{nVertexIndex}/{pItem.GetCount()}]");

                            DoublePoint ptStart, ptEnd;
                            DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                            DoublePoint ptCenter = new DoublePoint(0, 0);

                            pVertex.CalculateArcCenter();

                            double cx, cy;
                            cx = pVertex.cX;
                            cy = pVertex.cY;

                            ptStart = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                            ptEnd = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));

                            ptCenter = new DoublePoint { x = OffsetX + (pVertex.cX + ptShift.x), y = OffsetY - (pVertex.cY + ptShift.y) };

                            ptPrev = ptEnd;
                            WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, (pVertex.Bulge < 0)); // Bulge값이 음수일때가 CountClock 방향
                        }
                        else
                        {
                            List.Add("");
                            List.Add($"    // Line [{nVertexIndex}/{pItem.GetCount()}]");

                            DoublePoint ptS = new DoublePoint(OffsetX + (pVertex.X + pVertex.dX + ShiftX), OffsetY - (pVertex.Y + pVertex.dY + ShiftY));

                            SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptS, false);
                        }
                    }
                    else
                    if (nVertexIndex == (pItem.GetCount() - 1))
                    {
                        if (pItem.Closed)
                        {
                            if (dBulge != 0.0)
                            {
                                List.Add("");
                                List.Add($"    // Arc [{nVertexIndex}/{pItem.GetCount()}]");
                                double cx, cy;
                                DoublePoint ptStart, ptEnd;
                                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                                DoublePoint ptCenter = new DoublePoint(0, 0);

                                pVertex.CalculateArcCenter();   
                                cx = pVertex.cX;
                                cy = pVertex.cY;
                                ptStart = new DoublePoint(OffsetX + (pVertex.X + ptShift.x), OffsetY - (pVertex.Y + ptShift.y));
                                ptEnd = new DoublePoint((OffsetX + (pVertex.X + pVertex.dX + ptShift.x)), OffsetY - (pVertex.Y + pVertex.dY + ptShift.y));
                                ptCenter = new DoublePoint { x = OffsetX + (pVertex.cX + ptShift.x), y = OffsetY - (pVertex.cY + ptShift.y)};
                                
                                WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, (pVertex.Bulge < 0)); // Bulge값이 음수일때가 CountClock 방향
                            }
                            else
                            {
                                List.Add("");
                                List.Add($"    // Line [{nVertexIndex}/{pItem.GetCount()}]");

                                DoublePoint ptEnd = new DoublePoint(OffsetX + (pVertex.X + pVertex.dX + ShiftX), OffsetY - (pVertex.Y + pVertex.dY + ShiftY));

                                DoublePoint ptEnd2 = ExtendLine(ptPrev, ptEnd, 0.004);

                                SetSpeed(ref List, Global.chConLineSpeed.AsDouble, Global.chConLineTA.AsDouble, 3, ptEnd2, false);
                                        
                                List.Add("");
                                List.Add($"    DWELL 7");
                                List.Add($"    doLaserTriggerOn==false");// file.WriteLine($"M7122==1"); i/o확인 해야함!!!
                                List.Add($"    DWELL 7");
                            }
                        }
                        else
                        {
                            List.Add($"    // Polyline.Open!!");
                        }
                    }
                }
            }

            return rr;
        }

        public DoublePoint ExtendLine(DoublePoint ptStart, DoublePoint ptEnd, double extendLength)
        {
            // ptStart에서 ptEnd까지의 차이를 구함
            double dx = ptEnd.x - ptStart.x;
            double dy = ptEnd.y - ptStart.y;

            // 두 점 사이의 거리를 계산
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // 새로운 거리 = 기존 거리 + 연장하고 싶은 길이 (예: 1mm)
            double newDistance = distance + extendLength;

            // 기울기를 유지하면서 새 점을 계산 (단위 벡터로 방향 유지)
            double scale = newDistance / distance;

            // ptEnd 위치를 확장된 거리만큼 이동
            double newX = ptStart.x + dx * scale;
            double newY = ptStart.y + dy * scale;

            return new DoublePoint(newX, newY);
        }

        public DoublePoint MakeArcType(ztArcItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                DoublePoint ptC = new DoublePoint { x = OffsetX + pItem.Xc, y = OffsetY - pItem.Yc };

                DoublePoint ptS = new DoublePoint(OffsetX + (pItem.X0 + ptShift.x), OffsetY - (pItem.Y0 + ptShift.y));
                DoublePoint ptE = new DoublePoint(OffsetX + (pItem.X1 + ptShift.x), OffsetY - (pItem.Y1 + ptShift.y));

                rr = ptS;
            }

            return rr;
        }  

        public DoublePoint MakeArcType(bool LaserRun, ref StringList List, ztArcItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
         //   CodeSite.SendMsg("MakeArcType");
            DoublePoint rr = new DoublePoint(0, 0);
            
            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);
                DoublePoint ptCenter = new DoublePoint { x = OffsetX + pItem.Xc, y = OffsetY - pItem.Yc };

                DoublePoint ptStart = new DoublePoint(OffsetX + (pItem.X0 + ptShift.x), OffsetY - (pItem.Y0 + ptShift.y));
                DoublePoint ptEnd = new DoublePoint(OffsetX + (pItem.X1 + ptShift.x), OffsetY - (pItem.Y1 + ptShift.y));

                rr = ptStart;

                SetSpeed(ref List, Global.chConArcSpeed.AsDouble, 0, 3, ptStart, false);

                WriteArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptEnd, ptCenter, !pItem.bCCW);
            }

            return rr;
        }

        public DoublePoint MakeCircleType(ztCircleItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

                rr = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                
            }

            return rr;
        }

        public DoublePoint MakeCircleType(bool LaserRun, ref StringList List, ztCircleItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptStart, ptEnd;
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

                DoublePoint ptCenter = new DoublePoint { x = OffsetX + pItem.CenterX + ptShift.x, y = OffsetY - (pItem.CenterY + ptShift.y) };
                ptStart = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                

                rr = ptStart;

                pItem.StartAngle = pItem.StartAngle + 180.0;
                DoublePoint ptHalf = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)               

                // Overlap 하는 거리만큼을 각으로 산출하여
                double additionalDistance = 0.00; // 원하는 추가 거리 (10 µm = 0.01 mm)
                double radius = pItem.R;     // pItem의 반지름 값

                // 추가 각도 계산 (라디안)
                double additionalAngle = additionalDistance / radius; // 라디안 값

                if (pItem.DirCW)
                {
                    pItem.StartAngle = pItem.StartAngle + 180 - additionalAngle * (180 / Math.PI);
                }
                else
                {
                    pItem.StartAngle = pItem.StartAngle + 180 + additionalAngle * (180 / Math.PI);
                }

                ptEnd = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)

                SetSpeed(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 20, ptStart, false);
                List.Add("");
                List.Add($"    DWELL 7");
                if (LaserRun)
                {
                    List.Add($"    doLaserTriggerOn==true");
                }
                else
                {
                    List.Add($"    doLaserTriggerOn==false"); // DryRun
                }
                List.Add($"    DWELL 7");
                List.Add("");
                WriteCircleToArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptStart, ptHalf, ptCenter, pItem.DirCW);
                List.Add("");

                // 두 번째 반원
                WriteCircleToArcGCode(ref List, Global.chConArcSpeed.AsDouble, Global.chConArcTA.AsDouble, 3, ptHalf, ptEnd, ptCenter, pItem.DirCW);

                List.Add($"    DWELL 7");
                List.Add($"    doLaserTriggerOn==false");
                List.Add($"    DWELL 7");
            }

            return rr;
        }

        public DoublePoint MakeRectType(ztRectItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

               // yhbyun rr = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                
            }

            return rr;
        }

        public DoublePoint MakeRectType(bool LaserRun, ref StringList List, ztRectItem pItem, double ShiftX, double ShiftY, double OffsetX, double OffsetY)
        {
            DoublePoint rr = new DoublePoint(0, 0);

            if (pItem != null)
            {
                DoublePoint ptShift = new DoublePoint(ShiftX, ShiftY);

                // yhbyun rr = new DoublePoint(OffsetX + (pItem.StartX + ptShift.x), OffsetY - (pItem.StartY + ptShift.y)); // 원의 시작점(0도)                
            }

            return rr;
        }

        public void SetSpeed(ref StringList List, double f, double ta, int ts, DoublePoint pt, bool isRapid)
        {
            List.Add($"    F({f}) TA({ta}) TS({ts})");
            List.Add($"    X{pt.x:F3} Y{pt.y:F3} // StartX, StartY");
        }

        private void WriteArcGCode(ref StringList List, double f, double ta, int ts, DoublePoint ptStart, DoublePoint ptEnd, DoublePoint ptCenter, bool ClockWiseDir)//arc인경우 ptE값은 ptS값임!!!!!
        {
            double i, j;

            i = ptCenter.x - ptStart.x;
            j = ptCenter.y - ptStart.y; 

            string command = ClockWiseDir ? "CIRCLE2" : "CIRCLE1";//"CIRCLE1" : "CIRCLE2";
            List.Add($"    F({f}) TA({ta}) TS({ts})");
            if (ClockWiseDir)
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // ClockWise, EndX, EndY, CenterX, CenterY");
            }
            else
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // CountClockWise, EndX, EndY, CenterX, CenterY");
            }
        }

        private void WriteCircleToArcGCode(ref StringList List, double f, double ta, int ts, DoublePoint ptStart, DoublePoint ptEnd, DoublePoint ptCenter, bool ClockWiseDir)//arc인경우 ptE값은 ptS값임!!!!!
        {
            double i, j;

            i = ptCenter.x - ptStart.x;
            j = ptCenter.y - ptStart.y;

            string command = ClockWiseDir ? "CIRCLE2" : "CIRCLE1";//"CIRCLE1" : "CIRCLE2";
            List.Add($"    F({f}) TA({ta}) TS({ts})");
            if (ClockWiseDir)
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // ClockWise, EndX, EndY, CenterX, CenterY");
            }
            else
            {
                List.Add($"    {command} X{ptEnd.x:F3} Y{ptEnd.y:F3} i{i:F3} j{j:F3} // CountClockWise, EndX, EndY, CenterX, CenterY");
            }
        }

        private void TabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = (Global.isAutoRun);
        }
    }

    public struct PageItem
    {
        public double x { get; set; }
        public double y { get; set; }
        public bool Used { get; set; }

        public PageItem(double x, double y, bool used)
        {
            this.x = x;
            this.y = y;
            this.Used = used;
        }

        public override string ToString()
        {
            return $"[{x}, {y}, {Used}]";
        }
    }

    public class PageList
    {
        private List<PageItem> positions; // 좌표 리스트

        private DoublePoint mPageSize; // 페이지 크기

        public PageList()
        {
            positions = new List<PageItem>();
        }

        // Clear: 리스트 초기화
        public void Clear()
        {
            positions.Clear();
        }

        // Add: x, y 값을 추가
        public void Add(double x, double y, bool used)
        {
            positions.Add(new PageItem(x, y, used));
        }

        // Count: 현재 리스트의 개수 반환
        public int Count => positions.Count;

        // SetCellSize: 셀 크기 설정
        public DoublePoint PageSize
        {
            get => mPageSize;
            set => mPageSize = value;
        }

        // XMin: x 좌표의 최소값 - PageSize.x / 2
        public double XMin
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double minX = double.MaxValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].x < minX)
                    {
                        minX = positions[i].x;
                    }
                }

                return minX - PageSize.x / 2;
            }
        }

        // XMax: x 좌표의 최대값 + PageSize.x / 2
        public double XMax
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double maxX = double.MinValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].x > maxX)
                    {
                        maxX = positions[i].x;
                    }
                }

                return maxX + PageSize.x / 2;
            }
        }

        // YMin: y 좌표의 최소값 - PageSize.y / 2
        public double YMin
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double minY = double.MaxValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].y < minY)
                    {
                        minY = positions[i].y;
                    }
                }

                return minY - PageSize.y / 2;
            }
        }

        // YMax: y 좌표의 최대값 + PageSize.y / 2
        public double YMax
        {
            get
            {
                if (positions.Count == 0) return 0.0;
                double maxY = double.MinValue;

                for (int i = 0; i < positions.Count; i++)
                {
                    if (positions[i].y > maxY)
                    {
                        maxY = positions[i].y;
                    }
                }

                return maxY + PageSize.y / 2;
            }
        }

        // Width: 전체 페이지의 너비 계산
        public double Width => XMax - XMin;

        // Height: 전체 페이지의 높이 계산
        public double Height => YMax - YMin;

        // 인덱서를 사용하여 특정 좌표를 참조
        public PageItem this[int index]
        {
            get
            {
                if (index < 0 || index >= positions.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                return positions[index];
            }
            set
            {
                if (index < 0 || index >= positions.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                positions[index] = value;
            }
        }

        // GetAll: 모든 좌표 반환
        public List<PageItem> GetAll()
        {
            return new List<PageItem>(positions);
        }

        public int SelectedCount()
        {
            int result = 0;

            for(int nIndex = 0; nIndex < Count; nIndex ++)
            {
                if (this[nIndex].Used) result = result + 1;
            }
            return result;
        }

        public int GetFirstPage()
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Used)
                {
                    return i;
                }
            }

            return -1; // 없으면 -1 반환
        }

        // GetNextPage: 지정된 인덱스 이후로 처음 Used == true인 인덱스 반환
        public int GetNextPage(int index)
        {
            for (int i = index; i < Count; i++)
            {
                if (this[i].Used)
                {
                    return i;
                }
            }

            return -1; // 없으면 -1 반환
        }
    }
}
