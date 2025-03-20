using DaekhonSystem;
using Raize.CodeSiteLogging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Management.Instrumentation;
using System.Windows.Forms;
using static LaserCutter.Advanced;

namespace LaserCutter
{
    public partial class panJobType3 : UserControl
    {
        public panAuto Auto = null;
        public panConfigCommon Common = null;
        public LaserProject LaserProject = null;
        public panTable Table;

        DoublePoint ptMax = new DoublePoint();
        DoublePoint ptMin = new DoublePoint();
        DoublePoint ptCenter = new DoublePoint();

        bool is1stReadyPos = false;
        public DoublePoint ReadyPos = new DoublePoint(-30, -30);

        public ztCad Cad3;
        public ztMarkPage cad3Data;

        public DoublePoint CenterPos = new DoublePoint();
        public DoublePoint WorkCenter = new DoublePoint(0, 0);

        public PageList PageList;
        public panJobType3()
        {
            // logger.SendMsg("panJobType3()");

            InitializeComponent();

            Global.ChangeDaekhonControlColor(this.Controls, typeof(DaekhonSystem.ComboBox), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));

            InitDataGridViewControl();
            InitializeControl();

            PageList = new PageList();
        }

        public void InitializeControl()
        {
            Cad3 = new ztCad();

            Cad3.CadStyle.FileTabs = false;
            Cad3.CadStyle.Rulers = true;
            Cad3.CadStyle.Scrolls = true;
            Cad3.CadStyle.StatusBar = true;
            Cad3.CadStyle.ViewTab3D = false;
            Cad3.CadStyle.ViewTabs = false;

            Cad3.Location = new System.Drawing.Point(0, 0);
            Cad3.Size = new System.Drawing.Size(panCad.Width, panCad.Height);
            Cad3.Enabled = false;

            panCad.Controls.Add(Cad3);

            cad3Data = new ztMarkPage();

            rdoCell.Checked = true;
        }

        #region public void InitDataGridViewControl()
        // DataGridView Column 동적 생성

        public void InitDataGridViewControl()
        {
            dataGridView3.RowHeadersVisible = true;
            dataGridView3.RowHeadersWidth = 20;

            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            // 1.Color
            dataGridView3.Columns.Add("Color", "Color");
            dataGridView3.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["Color"].Width = 40;

            // 2. Name
            dataGridView3.Columns.Add("Name", "Name");
            dataGridView3.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["Name"].Width = 180;

            // 3. Use
            DataGridViewCheckBoxColumn ColumnCheckBox = new DataGridViewCheckBoxColumn();
            ColumnCheckBox.ReadOnly = true;
            ColumnCheckBox.Name = "Use";
            ColumnCheckBox.HeaderText = "Use";
            ColumnCheckBox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnCheckBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns.Add(ColumnCheckBox);
            dataGridView3.Columns["Use"].Width = 50;

            // 4. ComboBoxColumn for ColumnTool
            DataGridViewComboBoxColumn ColumnTool = new DataGridViewComboBoxColumn();
            ColumnTool.Name = "Tool";
            ColumnTool.HeaderText = "Tool";
            ColumnTool.Items.AddRange("Scanner", "Nozzle");
            ColumnTool.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnTool.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns.Add(ColumnTool);
            dataGridView3.Columns["Tool"].Width = 90;

            // 5. ComboBoxColumn for Direction
            DataGridViewComboBoxColumn ColumnDir = new DataGridViewComboBoxColumn();
            ColumnDir.Name = "Dir";
            ColumnDir.HeaderText = "Dir";
            ColumnDir.Items.AddRange("CW", "CCW");
            ColumnDir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnDir.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns.Add(ColumnDir);
            dataGridView3.Columns["Dir"].Width = 60;

            // 6. Power
            dataGridView3.Columns.Add("p~.offset", "p~.offset");
            dataGridView3.Columns["p~.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["p~.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["p~.offset"].ReadOnly = true;
            dataGridView3.Columns["p~.offset"].Width = 75;

            // 7. Pitch
            dataGridView3.Columns.Add("z.offset", "z.offset");
            dataGridView3.Columns["z.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["z.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["z.offset"].ReadOnly = true;
            dataGridView3.Columns["z.offset"].Width = 75;

            dataGridView3.AllowUserToResizeRows = false;
        }
        #endregion
        
        double CalculateBulge(double angleInDegrees)
        {
            // 각도를 라디안으로 변환
            double angleInRadians = angleInDegrees * (Math.PI / 180.0);

            // Bulge 값 계산
            double bulge = Math.Tan(angleInRadians / 4.0);

            return bulge;
        }

        private void MakeCell()
        {
            IntPtr hLayer = IntPtr.Zero;
            double dBulge;

            double angle = 90.0;
            dBulge = CalculateBulge(angle);

            Cad3.Clear();

            hLayer = Lcad.DrwAddLayer(Cad3.GetDrwHandle(), "Cell", "0, 255, 0", IntPtr.Zero, 0);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
            Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");

            if (chkUseBreakLine.Checked)
            {     
                hLayer = Lcad.DrwAddLayer(Cad3.GetDrwHandle(), "BreakLine", "255, 255, 0", IntPtr.Zero, 0);
                Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
                Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
                Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");
            }

            DrawPolylineForCell(0, 0, edCellWidth.Value, edCellHeight.Value, edCellRadius.Value, dBulge, chkUseBreakLine.Checked, edBreakLineOffset.Value, edBreakLineLength.Value, chkBreakLineOutDir.Checked);
        }

        private void DrawPolylineForCell(double x, double y, double width, double height, double radius, double dBulge, bool Breakline, double offset, double length, bool OutDir = true)
        {
            IntPtr hPolyLine = Cad3.AddPolyline();

            // Set color and layer for the polyline
            Lcad.PropPutStr(hPolyLine, Lcad.LC_PROP_ENT_COLOR, "0, 255, 0");
            Lcad.PropPutStr(hPolyLine, Lcad.LC_PROP_ENT_LAYER, "Cell");

            // Add vertices with bulge for rounded corners
            AddBulge(hPolyLine, x + radius, y, -dBulge);                  // #0 Bottom-left corner
            AddVertex(hPolyLine, x, y + radius);                          // #1 Left side

            if (Breakline)
            {
                AddBreakLine(x + radius, y + radius, x + radius, y, offset, length, OutDir);
                AddBreakLine(x + radius, y + radius, x, y + radius, offset, length, OutDir);
            }

            AddBulge(hPolyLine, x, y + height - radius, -dBulge);         // #2 Top-left corner\
            AddVertex(hPolyLine, x + radius, y + height);                 // #3 Top-left side

            if (Breakline)
            {
                AddBreakLine(x + radius, y + height - radius, x, y + height - radius, offset, length, OutDir);
                AddBreakLine(x + radius, y + height - radius, x + radius, y + height, offset, length, OutDir);
            }

            AddBulge(hPolyLine, x + width - radius, y + height, -dBulge); // #4 Top-right corner
            AddVertex(hPolyLine, x + width, y + height - radius);         // #5 Right side

            if (Breakline)
            {
                AddBreakLine(x + width - radius, y + height - radius, x + width - radius, y + height, offset, length, OutDir);
                AddBreakLine(x + width - radius, y + height - radius, x + width, y + height - radius, offset, length, OutDir);
            }

            AddBulge(hPolyLine, x + width, y + radius, -dBulge);          // #6 Bottom-right corner
            AddVertex(hPolyLine, x + width - radius, y);                  // #7 Bottom-right side

            if (Breakline)
            {
                AddBreakLine(x + width - radius, y + radius, x + width, y + radius, offset, length, OutDir);
                AddBreakLine(x + width - radius, y + radius, x + width - radius, y, offset, length, OutDir);
            }

            // End polyline
            Cad3.EndPolyline();
        }

        private void AddBreakLine(double centerX, double centerY, double pointX, double pointY, double offset, double length, bool OutDir)
        {
            // Calculate the angle from the bulge center to the point
            double angle = Math.Atan2(pointY - centerY, pointX - centerX);

            // Adjust offset and length based on OutDir
            if (!OutDir)
            {
                offset = offset + length;
                length = -length;
            }

            // Calculate the start point of the break line
            double startX = pointX + offset * Math.Cos(angle);
            double startY = pointY + offset * Math.Sin(angle);

            // Calculate the end point of the break line
            double endX = startX + length * Math.Cos(angle);
            double endY = startY + length * Math.Sin(angle);

            // Draw the break line
            IntPtr hEnt = Cad3.AddLine(startX, startY, endX, endY);
            Lcad.PropPutStr(hEnt, Lcad.LC_PROP_ENT_LAYER, "BreakLine");
        }

        private void AddBulge(IntPtr polyline, double x, double y, double bulge)
        {
            IntPtr hVertex = Cad3.AddPolylineVertex(x, y);
            Lcad.PropPutFloat(hVertex, Lcad.LC_PROP_VER_BULGE, bulge);
        }

        // Helper method to add vertex with optional bulge
        private void AddVertex(IntPtr polyline, double x, double y)
        {
            Cad3.AddPolylineVertex(x, y);
        }

        private void MakeCircle()
        {
            IntPtr hLayer = IntPtr.Zero;

            Cad3.Clear();

            hLayer = Lcad.DrwAddLayer(Cad3.GetDrwHandle(), "Circle", "0, 255, 0", IntPtr.Zero, 0);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
            Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");

            if (chkUseBreakLine.Checked)
            {
                hLayer = Lcad.DrwAddLayer(Cad3.GetDrwHandle(), "BreakLine", "255, 255, 0", IntPtr.Zero, 0);
                Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
                Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
                Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");
            }

            DrawCircle(0, 0, edCellRadius.Value, chkUseBreakLine.Checked, edBreakLineOffset.Value, edBreakLineLength.Value, true);
        }

        void DrawCircle(double x, double y, double Radius, bool Breakline, double offset, double length, bool OutDir = true)
        {
            IntPtr hCircle = Cad3.AddCircle(x, y, Radius);
            Lcad.PropPutStr(hCircle, Lcad.LC_PROP_ENT_COLOR, "0, 255, 0");
            Lcad.PropPutStr(hCircle, Lcad.LC_PROP_ENT_LAYER, "Circle");

            // Adjust offset and length if the direction is inward
            if (!OutDir)
            {
                offset += length; // Offset을 length만큼 확장
                length = -length; // 길이를 반대로 설정
            }

            // Define angles for 0°, 90°, 180°, 270°
            double[] angles = { 0, Math.PI / 2, Math.PI, 3 * Math.PI / 2 };

            if (Breakline)
            {
                IntPtr hEnt = IntPtr.Zero;
                // Draw lines at each angle
                foreach (double angle in angles)
                {
                    // Calculate the starting point for the line with offset
                    double startX = x + (Radius + offset) * Math.Cos(angle);
                    double startY = y + (Radius + offset) * Math.Sin(angle);

                    // Calculate the end point for the line with length
                    double endX = startX + length * Math.Cos(angle);
                    double endY = startY + length * Math.Sin(angle);

                    // Draw the line
                    hEnt = Cad3.AddLine(startX, startY, endX, endY);
                    Lcad.PropPutStr(hEnt, Lcad.LC_PROP_ENT_LAYER, "BreakLine");
                }
            }
        }

        public void EnableControl(bool bEnabled)
        {
            Cad3.Enabled = bEnabled;
            edLaserPower.Enabled = bEnabled;
            edPulsePitch.Enabled = bEnabled;
            cbStartPoint.Enabled = bEnabled;

            dataGridView3.Enabled = bEnabled;

            ledSortMethod1.Enabled = bEnabled;
            ledSortMethod2.Enabled = bEnabled;
            ledSortMethod3.Enabled = bEnabled;
            ledSortMethod4.Enabled = bEnabled;

            edXCount.Enabled = bEnabled;
            edYCount.Enabled = bEnabled;
            edGapX.Enabled = bEnabled;
            edGapY.Enabled = bEnabled;

            edGlassSizeX.Enabled = bEnabled;
            edGlassSizeY.Enabled = bEnabled;    

            rdoCell.Enabled = bEnabled;
            rdoCircle.Enabled = bEnabled;

            edCellHeight.Enabled = bEnabled;
            edCellWidth.Enabled = bEnabled; 
            edCellRadius.Enabled = bEnabled;

            chkBreakLineOutDir.Enabled = bEnabled;  
            chkUseBreakLine.Enabled = bEnabled;
            edBreakLineLength.Enabled = bEnabled;
            edBreakLineOffset.Enabled = bEnabled;  
            
            btnMoveUp.Enabled = bEnabled;
            btnMoveDown.Enabled = bEnabled;

            edThickness.Enabled = bEnabled;
            edZOffset.Enabled = bEnabled;

            btnApply.Enabled = bEnabled;
            btnSave.Enabled = bEnabled;
            btnCancel.Enabled = bEnabled;
        }

        public void ClearControlValue()
        {
            Cad3.Clear();
            Cad3.ReDraw();

            edLaserPower.Value = 0.0;
            edPulsePitch.Value = 0.0;

            edZOffset.Value = 0.0;

            edXCount.AsInteger = 0;
            edYCount.AsInteger = 0;
            edGapX.Value = 0.0;
            edGapY.Value = 0.0;

            edCellWidth.Value = 0.0;
            edCellHeight.Value = 0.0;
            edCellRadius.Value = 0.0;

            chkBreakLineOutDir.Checked = false;
            chkUseBreakLine.Checked = false;

            edBreakLineLength.Value = 0.0;
            edBreakLineOffset.Value = 0.0;

            btnUse.LED.Value = false;

            dataGridView3.Rows.Clear();
        }

        public void LoadLayerInfo()
        {
            ztCadLayerList list = new ztCadLayerList();

            // 도면을 새로 불러오면 기존 Data를 지운다
            LaserProject.Model3.Layers.Clear();

            LayerInfo layerInfo;

            Cad3.GetLayers(list);

            dataGridView3.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                // Layer를 생성하고..
                layerInfo = new LayerInfo();
                layerInfo.Name = list[i].Name;
                layerInfo.szColor = list[i].szColor;
                layerInfo.Direction = Direction.CW;
                layerInfo.Used = !(layerInfo.Name == "0");
                layerInfo.LaserPower = 10.0;
                layerInfo.PulsePitch = 1.0;
                layerInfo.ZOffset = 0.0;

                LaserProject.Model3.Layers.Add(layerInfo);

                // GridRow Data를 생성하고..
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView3);
                row.Cells[1].Value = layerInfo.Name;
                row.Cells[2].Value = layerInfo.Used.ToString();
                row.Cells[3].Value = layerInfo.Tool.ToString();
                row.Cells[4].Value = layerInfo.Direction.ToString();
                row.Cells[5].Value = layerInfo.LaserPower.ToString("F3");
                row.Cells[6].Value = layerInfo.ZOffset.ToString("F3");
                dataGridView3.Rows.Add(row);
            }
        }

        public void UpdateLayerInfo()
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                // 유효한 행인지 확인
                if (i < LaserProject.Model3.Layers.Count)
                {
                    // 현재 행의 데이터 가져오기
                    DataGridViewRow row = dataGridView3.Rows[i];

                    // LaserProject의 LayerInfo 업데이트
                    LaserProject.Model3.Layers[i].Name = row.Cells[1].Value?.ToString(); // 레이어 이름
                    LaserProject.Model3.Layers[i].Used = Convert.ToBoolean(row.Cells[2].Value); // 사용 여부
                    LaserProject.Model3.Layers[i].szColor = row.Cells[3].Value?.ToString(); // 색상 정보
                    LaserProject.Model3.Layers[i].Direction = (Direction)Enum.Parse(typeof(Direction), row.Cells[4].Value?.ToString()); // 방향
                }
            }
        }

        public void CheckLayerInfo()
        {
            bool error1 = false;

            ztCadLayerList list = new ztCadLayerList();
            Table.JobInfo.Type3.Cad3.GetLayers(list);

            // Layer 갯수가 같은지 체크
            error1 = (list.Count != LaserProject.Model3.Layers.Count);

            // Layer의 이름이 다른지 체크
            int ii = 0;
            for (int nIndex = 0; nIndex < LaserProject.Model3.Layers.Count; nIndex++)
            {
                var szName = LaserProject.Model3.Layers[nIndex].Name;

                for (int nIndex2 = 0; nIndex2 < list.Count; nIndex2++)
                {
                    if (szName.ToLower() == list[nIndex2].Name.ToLower())
                    {
                        cad3Data.Clear();
                        Cad3.CurLayerName = szName;
                        Cad3.GetPage(cad3Data);

                        LaserProject.Model3.Layers[nIndex].Count = cad3Data.Count;
                      //  CodeSite.SendMsg(String.Format("Type3.Cad3.Layer[{0}] = {1}", szName, cad3Data.Count));

                        ii = ii + 1;
                        break;
                    }
                }
            }

            if (error1 || LaserProject.Model3.Layers.Count == 0)
            {
                ;
            }
            else
            {
                CreateArrayButton();
                if (rdoCell.Checked)
                {
                    MakeCell();
                }
                else 
                if (rdoCircle.Checked)
                {
                    MakeCircle();
                }
            }

            for (int nIndex = 0; nIndex < LaserProject.Model3.Layers.Count; nIndex++)
            {
                LaserProject.Model3.Layers[nIndex].szColor = list.GetColor(LaserProject.Model3.Layers[nIndex].Name);
            }
        }


        public void DisplayLayerInfo()
        {
            LayerInfo layerInfo;

            dataGridView3.Rows.Clear();
            for (int nIndex = 0; nIndex < LaserProject.Model3.Layers.Count; nIndex++)
            {
                layerInfo = LaserProject.Model3.Layers[nIndex];

                // GridRow Data를 생성하고..
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView3);
                //  row.Cells[0].Value = nIndex.ToString();
                row.Cells[1].Value = layerInfo.Name;
                row.Cells[2].Value = layerInfo.Used.ToString();
                row.Cells[3].Value = layerInfo.Tool.ToString();
                row.Cells[4].Value = layerInfo.Direction.ToString();
                row.Cells[5].Value = layerInfo.LaserPower.ToString("F3");
                row.Cells[6].Value = layerInfo.ZOffset.ToString("F3");
                dataGridView3.Rows.Add(row);
            }
        }

        public void GetReadyPos()
        {
            is1stReadyPos = true;

            /*
             * 현재 도면의 Min, Max..
             */
            DoublePoint tempReadyPos = new DoublePoint(0, 0);

            SetGrid3Value();

            double offsetX = WorkCenter.x - CenterPos.x;
            double offsetY = WorkCenter.y + CenterPos.y;

            if (Auto.btnLaserRun.LED.Value)
            {
                offsetX += Common.edTable2NozzleXOffset.Value;
                offsetY += Common.edTable2NozzleYOffset.Value;
            }

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model3.Layers.Count; nIndex++)
            {
                if (LaserProject.Model3.Layers[nIndex].Used)
                {
                    cad3Data.Clear();
                    Cad3.CurLayerName = LaserProject.Model3.Layers[nIndex].Name;
                    Cad3.GetPage(cad3Data);

                    var pMarkPage = cad3Data;

                    if (pMarkPage.MarkList.Count > 0)
                    {
                        for (int nEntityIndex = 0; nEntityIndex < pMarkPage.Count; nEntityIndex++)
                        {
                            ztMarkData pMarkData = pMarkPage[nEntityIndex];
                            int nType = pMarkPage.GetData(nEntityIndex).Type;
                            ztVertexItem pItem = pMarkData.Vertices[0];

                            switch (nType)
                            {
                                case Lcad.LC_ENT_LINE:
                                    tempReadyPos = Table.JobInfo.MakeLineType((ztLineItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_POLYLINE:
                                    tempReadyPos = Table.JobInfo.MakePolylineType((ztPolylineItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_ARC:
                                    tempReadyPos = Table.JobInfo.MakeArcType((ztArcItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_CIRCLE:
                                    tempReadyPos = Table.JobInfo.MakeCircleType((ztCircleItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_RECT:
                                    tempReadyPos = Table.JobInfo.MakeRectType((ztRectItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                            }
                        }
                    }
                }
            }

            cad3Data.Clear();
            Cad3.CurLayerName = "";
            Cad3.GetPage(cad3Data);
        }

        public void GetWorkCenter(int APageIndex)
        {
            GetPageData();

            double xShift = 0.0, yShift = 0.0;
            if (edGlassSizeX.Value > (PageList.Width))
            {
                xShift = (edGlassSizeX.Value - PageList.Width) / 2.0;
            };

            if (edGlassSizeY.Value > (PageList.Width))
            {
                yShift = (edGlassSizeY.Value - PageList.Height) / 2.0;
            }

            CenterPos = new DoublePoint(cad3Data.CenterX, cad3Data.CenterY);
            // CodeSite.SendMsg(String.Format("    Type3.cadData.Center = {0:F3}, {1:F3}", cad3Data.CenterX, cad3Data.CenterY));

            double offsetX = 0.0;
            double offsetY = 0.0;
            Table.GetTableBaseOffset(PageList, APageIndex, xShift, yShift, cad3Data, ref offsetX, ref offsetY);

            WorkCenter.x = offsetX; WorkCenter.y = offsetY;
            //CodeSite.SendMsg(String.Format("        Type3.WorkCenter[{0}] = {1:F3}, {2:F3}", APageIndex, WorkCenter.x, WorkCenter.y));
        }

        public void MakeMotionFile(TableNo tableNo, int ACellIndex, double shiftX, double shiftY, bool LaserRun)
        {
            GetWorkCenter(ACellIndex);

            DaekhonSystem.StringList szList = new DaekhonSystem.StringList();

            szList.Add("undefine all");

            if (tableNo == TableNo.Table1)
            {
                szList.Add($"&1 #1->{Const.XY_LINEAR_SCALE}X #2->{Const.XY_LINEAR_SCALE}Y");
            }
            if (tableNo == TableNo.Table2)
            {
                szList.Add($"&1 #1->{Const.XY_LINEAR_SCALE}X #3->{Const.XY_LINEAR_SCALE}Y");
            }

            szList.Add("delete lookahead");
            szList.Add("define lookahead 7000");

            szList.Add("");
            szList.Add($"Motor[1].JogSpeed = {Const.XY_LINEAR_SCALE / 10}"); //{m_pPmacData[i].dLineSpd:F3}");
            szList.Add($"Motor[1].JogTa = 50");
            szList.Add($"Motor[1].JogTs = 50");

            if (tableNo == TableNo.Table1)
            {
                szList.Add("");
                szList.Add($"Motor[2].JogSpeed = {Const.XY_LINEAR_SCALE / 10}"); //{m_pPmacData[i].dLineSpd:F3}");
                szList.Add($"Motor[2].JogTa = 50");
                szList.Add($"Motor[2].JogTs = 50");
            }
            else
            if (tableNo == TableNo.Table2)
            {
                szList.Add("");
                szList.Add($"Motor[3].JogSpeed = {Const.XY_LINEAR_SCALE / 10}"); //{m_pPmacData[i].dLineSpd:F3}");
                szList.Add($"Motor[3].JogTa = 50");
                szList.Add($"Motor[3].JogTs = 50");
            }

            double offsetX = WorkCenter.x - CenterPos.x;
            double offsetY = WorkCenter.y + CenterPos.y;

            if (Auto.btnLaserRun.LED.Value)
            {
                offsetX += Common.edTable2NozzleXOffset.Value;
                offsetY += Common.edTable2NozzleYOffset.Value;
            }

            SetGrid3Value();

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model3.Layers.Count; nIndex++)
            {
                if (LaserProject.Model3.Layers[nIndex].Used)
                {
                    cad3Data.Clear();
                    Cad3.CurLayerName = LaserProject.Model3.Layers[nIndex].Name;
                    Cad3.GetPage(cad3Data);

                    if (cad3Data.Count <= 0) continue;

                    szList.Add("");
                    szList.Add(String.Format("Open Prog {0}", nIndex + 100 * (int)tableNo));

                    szList.Add("Linear");
                    szList.Add("ABS");
                    szList.Add("Frax(X,Y)");

                    cad3Data.Rotate(CenterPos.x, CenterPos.y, 0);

                    var pMarkPage = cad3Data;

                    if (pMarkPage.MarkList.Count > 0)
                    {
                        // logger.SendMsg(String.Format("LayerName=\"{0}\" Entity.Count = {1}", Cad2.CurLayerName, nCount));

                        szList.Add("");
                        szList.Add("// ================================================================================");
                        szList.Add($"// LayerName:[{LaserProject.Model2.Layers[nIndex].Name}]");
                        szList.Add($"//     EntityCount:{pMarkPage.MarkList.Count}");
                        szList.Add("// --------------------------------------------------------------------------------");

                        for (int nEntityIndex = 0; nEntityIndex < pMarkPage.Count; nEntityIndex++)
                        {
                            ztMarkData pMarkData = pMarkPage[nEntityIndex];
                            int nType = pMarkPage.GetData(nEntityIndex).Type;
                            ztVertexItem pItem = pMarkData.Vertices[0];

                            szList.Add("");

                            switch (nType)
                            {
                                case Lcad.LC_ENT_LINE:
                                    szList.Add($"// Line {nEntityIndex}");
                                    Table.JobInfo.MakeLineType(LaserRun, ref szList, (ztLineItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_POLYLINE:
                                    szList.Add($"// Polyline {nEntityIndex}");
                                    Table.JobInfo.MakePolylineType(LaserRun, ref szList, (ztPolylineItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_ARC:
                                    szList.Add($"// Arc {nEntityIndex}");
                                    Table.JobInfo.MakeArcType(LaserRun, ref szList, (ztArcItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_CIRCLE:
                                    szList.Add($"// Circle {nEntityIndex}");
                                    Table.JobInfo.MakeCircleType(LaserRun, ref szList, (ztCircleItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_RECT:
                                    szList.Add($"// Rect {nEntityIndex}");
                                    Table.JobInfo.MakeRectType(LaserRun, ref szList, (ztRectItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;
                            }
                        }
                    }

                    szList.Add("Close");
                }
            }

            Cad3.CurLayerName = "";

            String szStr = String.Format("{0}Program{1}.pmc", dkCommon.AppPath(), (int)tableNo);
            szList.SaveToFile(szStr);
            szList.Clear();
        }

        /*
        * 달리 방법이 없네..
        */
        public void SetGrid3Value()
        {
            if ((dataGridView3.Rows.Count - 1) != LaserProject.Model3.Layers.Count) return;

            for (int nRowIndex = 0; nRowIndex < LaserProject.Model3.Layers.Count; nRowIndex++)
            {
                // Use
                if (dataGridView3.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "true")
                {
                    LaserProject.Model3.Layers[nRowIndex].Used = true;
                }
                else
                if (dataGridView3.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "false")
                {
                    LaserProject.Model3.Layers[nRowIndex].Used = false;
                }

                // Tool
                if (dataGridView3.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "scanner")
                {
                    LaserProject.Model3.Layers[nRowIndex].Tool = Tool.Scanner;
                }
                else
                if (dataGridView3.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "nozzle")
                {
                    LaserProject.Model3.Layers[nRowIndex].Tool = Tool.Nozzle;
                }

                // Direction
                if (dataGridView3.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "ccw")
                {
                    LaserProject.Model3.Layers[nRowIndex].Direction = Direction.CCW;
                }
                else
                if (dataGridView3.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "cw")
                {
                    LaserProject.Model3.Layers[nRowIndex].Direction = Direction.CW;
                }
            }

            IntPtr hEnt = IntPtr.Zero;
            int nIndex;

            // 속성을 변경
            for (nIndex = 0; nIndex < LaserProject.Model3.Layers.Count; nIndex++)
            {
                if (LaserProject.Model3.Layers[nIndex].Used)
                {                    
                    /* Laser단위로 설정하고..
                     * Entity를 불러들여 속성을 변경한다.
                     * Direction, StartPoint..
                     */

                    Cad3.CurLayerName = LaserProject.Model3.Layers[nIndex].Name;

                    hEnt = Cad3.GetFirstEntity(false);
                    while (hEnt != IntPtr.Zero)
                    {
                        int nEntType = Lcad.PropGetInt(hEnt, Lcad.LC_PROP_ENT_TYPE);
                        if (nEntType == Lcad.LC_ENT_POLYLINE)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_PLINE_CW);
                            bool CCWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_PLINE_CCW);

                            if ((LaserProject.Model3.Layers[nIndex].Direction == Direction.CW) && CCWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            else
                            if ((LaserProject.Model3.Layers[nIndex].Direction == Direction.CCW) && CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            Lcad.EntUpdate(hEnt);

                            Cad3.SetStartPoint(hEnt, (StartPoint)cbStartPoint.ItemIndex);
                            Lcad.EntUpdate(hEnt);
                        }
                        else 
                        if (nEntType == Lcad.LC_ENT_CIRCLE)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_CIRCLE_DIRCW);

                            if ((LaserProject.Model3.Layers[nIndex].Direction == Direction.CW) && !CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            else
                            if ((LaserProject.Model3.Layers[nIndex].Direction == Direction.CCW) && CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }

                            switch ((StartPoint)cbStartPoint.ItemIndex)
                            {
                                case StartPoint.Left:
                                    Lcad.PropPutFloat(hEnt, Lcad.LC_PROP_CIRCLE_ANG0, 180.0 / 180.0 * Math.PI);
                                    break;

                                case StartPoint.Top:
                                    Lcad.PropPutFloat(hEnt, Lcad.LC_PROP_CIRCLE_ANG0, 90.0 / 180.0 * Math.PI);
                                    break;

                                case StartPoint.Right:
                                    Lcad.PropPutFloat(hEnt, Lcad.LC_PROP_CIRCLE_ANG0, 0 / 180.0 * Math.PI);
                                    break;

                                case StartPoint.Bottom:
                                    Lcad.PropPutFloat(hEnt, Lcad.LC_PROP_CIRCLE_ANG0, 270.0 / 180.0 * Math.PI);
                                    break;
                            }

                            double dd = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_CIRCLE_ANG0) * 180.0 / Math.PI;

                        }

                        Lcad.PropPutInt(hEnt, Lcad.LC_PROP_ENT_MARK_COUNT, 1);
                        Lcad.EntUpdate(hEnt);
                        hEnt = Cad3.GetNextEntity(false, hEnt);
                    }
                }
            }

            Cad3.CurLayerName = "";
        }

        public void btnSave_Click(object sender, EventArgs e)
        {        
            CreateUserCell();
            CheckLayerInfo();
            SetGrid3Value();

            edLaserPower.Apply();
            edPulsePitch.Apply();

            edThickness.Apply();
            edZOffset.Apply();

            edXCount.Apply();
            edYCount.Apply();
            edGapX.Apply();
            edGapY.Apply();

            edCellHeight.Apply();
            edCellWidth.Apply();
            edCellRadius.Apply();

            edGlassSizeX.Apply();
            edGlassSizeY.Apply();

            edBreakLineLength.Apply();
            edBreakLineOffset.Apply();

            Table.SaveJobFile();

            DaekhonSystem.StringList ss = LaserProject.Model3.ToStringList();

            GetWorkCenter(0);

            CodeSite.SendMsg("");
            CodeSite.SendMsg(String.Format("    {0}.Type3.SaveJobFile()", Table.TableNo));
            for (int nIndex = 0; nIndex < ss.Count; nIndex++)
            {
                CodeSite.SendMsg(ss[nIndex]);
            }

            //String szStr = String.Empty;
            //for (int nIndex = 0; nIndex < PageList.Count; nIndex++)
            //{
            //    if (PageList[nIndex].Used)
            //    {
            //        szStr = szStr + String.Format("{0}, ", nIndex + 1);
            //    }
            //}

            //CodeSite.SendMsg(String.Format("    PageList.SelectedCount = {0}, {1}", PageList.SelectedCount(), szStr));
        }

        public void GetPageData()
        {
            Cad3.CurLayerName = "";
            cad3Data.Clear();
            Cad3.GetPage(cad3Data);
        }

        public void CalcCellPosition()
        {
            int nRowIndex = 0, nColIndex = 0;

            SetPageSize();

            int ii = 1;
            switch (LaserProject.Model3.SortMethod)
            {
                case SortMethod.Method1:

                    for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                    {
                        if ((nColIndex % 2) == 0)
                        {
                            for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nRowIndex = edYCount.AsInteger - 1; nRowIndex >= 0; nRowIndex--)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                    }
                    break;

                case SortMethod.Method2:

                    for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                    {
                        if ((nColIndex % 2) == 0)
                        {
                            for (nRowIndex = edYCount.AsInteger - 1; nRowIndex >= 0; nRowIndex--)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                    }
                    break;

                case SortMethod.Method3:

                    for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                    {
                        if ((nRowIndex % 2) == 0)
                        {
                            for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * (edYCount.AsInteger - 1) - (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nColIndex = edXCount.AsInteger - 1; nColIndex >= 0; nColIndex--)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * (edYCount.AsInteger - 1) - (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                    }
                    break;

                case SortMethod.Method4:
                    for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                    {
                        if ((nRowIndex % 2) == 0)
                        {
                            for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nColIndex = edXCount.AsInteger - 1; nColIndex >= 0; nColIndex--)
                            {
                                double x = (cad3Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad3Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                    }
                    break;
            }

            //for (int nIndex = 0; nIndex < CellPos.Count; nIndex++)
            //{
            //    CodeSite.SendMsg(String.Format("CellPos[{0}] = {1}", nIndex, CellPos[nIndex].ToString()));
            //}

            //CodeSite.SendMsg(String.Format("CellPos.XMin, XMax = {0}, {1}", CellPos.XMin, CellPos.XMax));
            //CodeSite.SendMsg(String.Format("CellPos.YMin, YMax = {0}, {1}", CellPos.YMin, CellPos.YMax));
            //CodeSite.SendMsg(String.Format("CellPos.Size = {0}, {1}", CellPos.Width, CellPos.Height));
        }


        public void btnApply_Click(object sender, EventArgs e)
        {
            CreateArrayButton();

            GetPageData();

            PageList.Clear();
            PageList.PageSize = new DoublePoint(cad3Data.MarkList.Width, cad3Data.MarkList.Height);
            CalcCellPosition();

            edXCount.Apply();
            edYCount.Apply();
            edGapX.Apply();
            edGapY.Apply();
            edCellHeight.Apply();
            edCellWidth.Apply();
            edCellRadius.Apply();

            edBreakLineLength.Apply();
            edBreakLineOffset.Apply(); 
        }

        public void CreateUserCell()
        {
            if (rdoCell.Checked)
            {
                MakeCell();
            }
            else
            if (rdoCircle.Checked)
            {
                MakeCircle();
            }

            LoadLayerInfo();

            /*
             * 2. Cad1 도면 전체를 데이타를 불러들인다.
             */
            cad3Data.Clear();

            Table.JobInfo.Type3.Cad3.GetPage(cad3Data);
            Table.JobInfo.Type3.SetPageSize();

            Cad3.BlockUpdate();
            Cad3.ZoomExtend();
            Cad3.ZoomScale(0.8);
        }

        public void SetPageSize()
        {
            cad3Data.Width = cad3Data.MarkList.Width;
            cad3Data.Height = cad3Data.MarkList.Height;
        }

        private void ledShowJumpLine_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (LaserProject == null) return;
            // 셀이 유효한지 확인
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // CheckBox 열이 2번 컬럼이라 가정
            {
                int rowIndex = e.RowIndex;

                // CheckBox 값 처리 (true 또는 false)
                bool isUsed = Convert.ToBoolean(dataGridView3.Rows[rowIndex].Cells[2].Value);
                LaserProject.Model3.Layers[rowIndex].Used = isUsed;
            }

            UpdateLayerInfo();
        }

        private void dataGridView3_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView3.IsCurrentCellDirty && dataGridView3.CurrentCell.ColumnIndex == 2) // CheckBox 열만 처리
            {
                // 셀 값이 변경되었을 때 즉시 커밋하여 CellValueChanged 이벤트를 발생시킴
                dataGridView3.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
     
            UpdateLayerInfo();
        }

        private void ledSortMethod1_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = true;
            ledSortMethod2.LED.Value = false;
            ledSortMethod3.LED.Value = false;
            ledSortMethod4.LED.Value = false;

            LaserProject.Model3.SortMethod = SortMethod.Method1;
            btnApply.PerformClick();
        }

        private void ledSortMethod2_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = false;
            ledSortMethod2.LED.Value = true;
            ledSortMethod3.LED.Value = false;
            ledSortMethod4.LED.Value = false;

            LaserProject.Model3.SortMethod = SortMethod.Method2;

            btnApply.PerformClick();
        }

        private void ledSortMethod3_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = false;
            ledSortMethod2.LED.Value = false;
            ledSortMethod3.LED.Value = true;
            ledSortMethod4.LED.Value = false;

            LaserProject.Model3.SortMethod = SortMethod.Method3;

            btnApply.PerformClick();
        }

        private void ledSortMethod4_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = false;
            ledSortMethod2.LED.Value = false;
            ledSortMethod3.LED.Value = false;
            ledSortMethod4.LED.Value = true;

            LaserProject.Model3.SortMethod = SortMethod.Method4;

            btnApply.PerformClick();
        }

        private void ledLabel_Click(object sender, EventArgs e)
        {
            LEDLabel ledLabel = (LEDLabel)sender;

            ledLabel.LED.Value = !ledLabel.LED.Value;

            int nIndex = dkCommon.StrToIntDef(ledLabel.Text, -1);
            if (nIndex > -1)
            {
                var Item = PageList[nIndex - 1];
                Item.Used = ledLabel.LED.Value;
                PageList[nIndex - 1] = Item;
            }
        }


        public void CreateArrayButton()
        {
            // 패널에 있는 기존 컨트롤(버튼/라벨)을 모두 제거
            panel2.Controls.Clear();

            int buttonWidth = 50;  // 버튼의 너비
            int buttonHeight = 50; // 버튼의 높이
            int padding = 5;       // 버튼 간의 간격

            int totalWidth = buttonWidth + (edXCount.AsInteger * buttonWidth) + ((edXCount.AsInteger - 1) * padding) + buttonWidth;
            int totalHeight = buttonHeight + (edYCount.AsInteger * buttonHeight) + ((edYCount.AsInteger - 1) * padding) + buttonHeight;

            panel2.ClientSize = new Size(486, 203);
            panel2.ClientSize = new Size(Math.Max(panel2.ClientSize.Width, totalWidth), Math.Max(panel2.ClientSize.Height, totalHeight));

            // 버튼 배열이 패널 중앙에 위치하도록 시작 위치 계산 (양 끝 공백 포함)
            int startX = (panel2.ClientSize.Width - totalWidth) / 2 + buttonWidth;
            int startY = (panel2.ClientSize.Height - totalHeight) / 2 + buttonHeight;

            int nRowIndex = 0, nColIndex = 0;

            int ii = 1;
            switch (LaserProject.Model3.SortMethod)
            {
                case SortMethod.Method1:
                    for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                    {
                        if ((nColIndex % 2) == 0)
                        {
                            for (nRowIndex = edYCount.AsInteger - 1; nRowIndex >= 0; nRowIndex--)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + nRowIndex * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + nRowIndex * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                    }
                    break;

                case SortMethod.Method2:
                    for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                    {
                        if ((nColIndex % 2) == 0)
                        {
                            for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + nRowIndex * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nRowIndex = edYCount.AsInteger - 1; nRowIndex >= 0; nRowIndex--)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + nRowIndex * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                    }
                    break;

                case SortMethod.Method3:

                    for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                    {
                        if ((nRowIndex % 2) == 0)
                        {
                            for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + (nRowIndex) * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nColIndex = edXCount.AsInteger - 1; nColIndex >= 0; nColIndex--)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + (nRowIndex) * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                    }
                    break;

                case SortMethod.Method4:

                    for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                    {
                        if ((nRowIndex % 2) == 0)
                        {
                            for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + (edYCount.AsInteger - nRowIndex - 1) * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nColIndex = edXCount.AsInteger - 1; nColIndex >= 0; nColIndex--)
                            {
                                LEDLabel ledLabel = new LEDLabel();
                                ledLabel.LED.Size = new Size(10, 10);
                                ledLabel.LED.Value = true;
                                ledLabel.Margin2 = 10;
                                ledLabel.Click += ledLabel_Click;
                                ledLabel.Width = buttonWidth;
                                ledLabel.Height = buttonHeight;
                                ledLabel.Text = ii.ToString();

                                ledLabel.Left = startX + nColIndex * (buttonWidth + padding);
                                ledLabel.Top = startY + (edYCount.AsInteger - nRowIndex - 1) * (buttonHeight + padding);

                                panel2.Controls.Add(ledLabel);
                                ii = ii + 1;
                            }
                        }
                    }
                    break;
            }
        }

        private void AddLedLabel(int col, int row, ref int index, int buttonWidth, int buttonHeight, int padding, int startX, int startY)
        {
            LEDLabel ledLabel = new LEDLabel();
            ledLabel.LED.Size = new Size(10, 10);
            ledLabel.LED.Value = true;
            ledLabel.Margin2 = 10;
            ledLabel.Click += ledLabel_Click;
            ledLabel.Width = buttonWidth;
            ledLabel.Height = buttonHeight;
            ledLabel.Text = index.ToString();
            ledLabel.Tag = index;

            // 중앙 위치를 반영하여 버튼 위치 설정
            ledLabel.Left = startX + col * (buttonWidth + padding);
            ledLabel.Top = startY + row * (buttonHeight + padding);

            panel2.Controls.Add(ledLabel);
            index++;
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if ((LaserProject != null) && (LaserProject.Model3.Layers.Count > 0))
            {
                int bRGB, iColor, R, G, B;

                if (e.RowIndex < LaserProject.Model3.Layers.Count)
                {
                    if (dataGridView.Columns[e.ColumnIndex].Name == "Color")
                    {
                        String szColor = LaserProject.Model3.Layers[e.RowIndex].szColor;

                        if (!String.IsNullOrEmpty(szColor))
                        {
                            Lcad.ColorToVal(szColor, out bRGB, out iColor, out R, out G, out B);

                            e.CellStyle.BackColor = Color.FromArgb(R, G, B);
                            e.CellStyle.ForeColor = e.CellStyle.BackColor;
                        }
                    }
                }
            }
        }

        private bool MoveUp(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex <= 0 || ASelectedIndex >= dataGridView3.Rows.Count) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView3.Rows[ASelectedIndex];
            dataGridView3.Rows.RemoveAt(ASelectedIndex);
            dataGridView3.Rows.Insert(ASelectedIndex - 1, selectedRow);

            // 선택 상태 유지
            dataGridView3.ClearSelection();
            dataGridView3.Rows[ASelectedIndex - 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0) return;

            int nIndex = dataGridView3.SelectedRows[0].Index;

            if (MoveUp(nIndex))
            {
                LaserProject.Model3.Layers.MoveUp(nIndex);
                DisplayLayerInfo();
                dataGridView3.Rows[nIndex - 1].Selected = true;
            }
        }
        private bool MoveDown(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex < 0 || ASelectedIndex >= dataGridView3.Rows.Count - 2) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView3.Rows[ASelectedIndex];
            dataGridView3.Rows.RemoveAt(ASelectedIndex);
            dataGridView3.Rows.Insert(ASelectedIndex + 1, selectedRow);

            // 선택 상태 유지
            dataGridView3.ClearSelection();
            dataGridView3.Rows[ASelectedIndex + 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0) return;

            int nIndex = dataGridView3.SelectedRows[0].Index;

            if (MoveDown(nIndex))
            {
                LaserProject.Model3.Layers.MoveDown(nIndex);
                DisplayLayerInfo();
                dataGridView3.Rows[nIndex + 1].Selected = true;
            }
        }

        private void chkUseBreakingLine_CheckedChanged(object sender, EventArgs e)
        {
            edBreakLineLength.Enabled = chkUseBreakLine.Checked;
            edBreakLineOffset.Enabled = chkUseBreakLine.Checked;
            chkBreakLineOutDir.Enabled = chkUseBreakLine.Checked;
        }

        private void rdoCircle_Click(object sender, EventArgs e)
        {
            UpdateCellTypeUI(false);
        }

        private void rdoCell_Click(object sender, EventArgs e)
        {
            UpdateCellTypeUI(true);
        }

        public void UpdateCellTypeUI(bool bCell)
        {
            lblLabelSize.Visible = bCell;
            edCellHeight.Visible = bCell;
            edCellWidth.Visible = bCell;
        }

        public void ChangeLanguageEnglish()
        {
            tabPage1.Text = Global.iniEng.ReadString("panJobType3", "tabPage1.Text", "Machining Properties");
            btnSave.Text = Global.iniEng.ReadString("panJobType3", "btnSave.Text", "Save");
            btnCancel.Text = Global.iniEng.ReadString("panJobType3", "btnCancel.Text", "Cancel");
            btnApply.Text = Global.iniEng.ReadString("panJobType3", "btnApply.Text", "Apply");
        }

        public void ChangeLanguageKorea()
        {
            tabPage1.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType3", "tabPage1.Text");
            btnSave.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType3", "btnSave.Text");
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType3", "btnCancel.Text");
            btnApply.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType3", "btnApply.Text");
        }

        public void ChangeLanguageVietnam()
        {
            tabPage1.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType3", "tabPage1.Text");
            btnSave.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType3", "btnSave.Text");
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType3", "btnCancel.Text");
            btnApply.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType3", "btnApply.Text");
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.JobInfo.Type1.btnUse.LED.Value = false;
            Table.JobInfo.Type2.btnUse.LED.Value = false;
            Table.JobInfo.Type3.btnUse.LED.Value = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            edLaserPower.Cancel();
            edPulsePitch.Cancel();

            edThickness.Cancel();
            edZOffset.Cancel();

            edXCount.Cancel();
            edYCount.Cancel();
            edGapX.Cancel();
            edGapY.Cancel();

            edCellHeight.Cancel();
            edCellWidth.Cancel();
            edCellRadius.Cancel();

            edGlassSizeX.Cancel();
            edGlassSizeY.Cancel();

            edBreakLineLength.Cancel();
            edBreakLineOffset.Cancel();
        }

        private void chkShowJumpline_CheckedChanged(object sender, EventArgs e)
        {
            Cad3.ShowJumpLine = chkShowJumpline.Checked;
        }
    }
}
