using yjTech;
using Raize.CodeSiteLogging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class panJobType4 : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public LaserProject LaserProject = null;

        public panAuto Auto = null;
        public panAutoMenu AutoMenu = null;
        public panConfigCommon Common = null;

        public panTable Table;

        public ztCad Cad4;
        public ztMarkPage cad4Data;

        bool is1stReadyPos = false;
        public DoublePoint ReadyPos = new DoublePoint(-30, -30);

        public DoublePoint CenterPos = new DoublePoint();
        public DoublePoint WorkCenter = new DoublePoint(0, 0);

        public panJobType4()
        {
            InitializeComponent();

            InitDataGridViewControl();
            InitializeControl();
        }

        public void InitializeControl()
        {
            Cad4 = new ztCad();

            Cad4.CadStyle.FileTabs = false;
            Cad4.CadStyle.Rulers = true;
            Cad4.CadStyle.Scrolls = true;
            Cad4.CadStyle.StatusBar = true;
            Cad4.CadStyle.ViewTab3D = false;
            Cad4.CadStyle.ViewTabs = false;

            Cad4.Location = new System.Drawing.Point(0, 0);
            Cad4.Size = new System.Drawing.Size(panCad.Width, panCad.Height);
            Cad4.Enabled = false;

            panCad.Controls.Add(Cad4);

            cad4Data = new ztMarkPage();
        }

        #region public void InitDataGridViewControl()
        // DataGridView Column 동적 생성

        public void InitDataGridViewControl()
        {
            dataGridView4.RowHeadersVisible = true;
            dataGridView4.RowHeadersWidth = 20;

            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();

            // 1.Color
            dataGridView4.Columns.Add("Color", "Color");
            dataGridView4.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["Color"].Width = 40;

            // 2. Name
            dataGridView4.Columns.Add("Name", "Name");
            dataGridView4.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["Name"].Width = 250;

            // 3. Use
            DataGridViewCheckBoxColumn ColumnCheckBox = new DataGridViewCheckBoxColumn();
            ColumnCheckBox.ReadOnly = false;
            ColumnCheckBox.Name = "Use";
            ColumnCheckBox.HeaderText = "Use";
            ColumnCheckBox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnCheckBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns.Add(ColumnCheckBox);
            dataGridView4.Columns["Use"].Width = 50;

            // 4. ComboBoxColumn for ColumnTool
            DataGridViewComboBoxColumn ColumnTool = new DataGridViewComboBoxColumn();
            ColumnTool.Name = "Tool";
            ColumnTool.HeaderText = "Tool";
            ColumnTool.Items.AddRange("Scanner", "Nozzle");
            ColumnTool.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnTool.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns.Add(ColumnTool);
            dataGridView4.Columns["Tool"].Width = 90;

            // 5. ComboBoxColumn for Direction
            DataGridViewComboBoxColumn ColumnDir = new DataGridViewComboBoxColumn();
            ColumnDir.Name = "Dir";
            ColumnDir.HeaderText = "Dir";
            ColumnDir.Items.AddRange("CW", "CCW");
            ColumnDir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnDir.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns.Add(ColumnDir);
            dataGridView4.Columns["Dir"].Width = 60;

            // 6. power.offset
            dataGridView4.Columns.Add("laser.power\r\noffset", "laser.power\r\noffset");
            dataGridView4.Columns["laser.power\r\noffset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["laser.power\r\noffset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["laser.power\r\noffset"].Width = 100;

            // 7. z.offset
            dataGridView4.Columns.Add("z.offset", "z.offset");
            dataGridView4.Columns["z.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["z.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["z.offset"].Width = 75;

            // 8. Pitch.offset
            dataGridView4.Columns.Add("pulse.pitch\r\noffset", "pulse.pitch\r\noffset");
            dataGridView4.Columns["pulse.pitch\r\noffset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["pulse.pitch\r\noffset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.Columns["pulse.pitch\r\noffset"].Width = 100;

            dataGridView4.AllowUserToResizeRows = false;
        }
        #endregion

        public void EnableControl(bool bEnabled)
        {
            Cad4.Enabled = bEnabled;
            edLaserPower.Enabled = bEnabled;
            edPulsePitch.Enabled = bEnabled;

            dataGridView4.Enabled = bEnabled;

            btnMoveUp.Enabled = bEnabled;
            btnMoveDown.Enabled = bEnabled;

            edThickness.Enabled = bEnabled;
            edZOffset.Enabled = bEnabled;
            edGuideLength.Enabled = bEnabled;
            edGuidePitch.Enabled = bEnabled;
            edXLength.Enabled = bEnabled;
            edYPitch.Enabled = bEnabled;
            edYLength.Enabled = bEnabled;
            edXPitch.Enabled = bEnabled;

            btnSave.Enabled = bEnabled;
            btnCancel.Enabled = bEnabled;
        }

        public void ClearControlValue()
        {
            Cad4.Clear();
            Cad4.ReDraw();

            edLaserPower.Value = 0.0;
            edPulsePitch.Value = 0.0;

            edZOffset.Value = 0.0;
            edGuideLength.Value = 0.0;
            edGuidePitch.Value = 0.0;
            edXLength.Value = 0.0;
            edYPitch.Value = 0.0;
            edYLength.Value = 0.0;
            edXPitch.Value = 0.0;

            btnUse.LED.Value = false;

            dataGridView4.Rows.Clear();

        }

        public void LoadLayerInfo()
        {
            ztCadLayerList list = new ztCadLayerList();

            // 도면을 새로 불러오면 기존 Data를 지운다
            LaserProject.Model4.Layers.Clear();

            LayerInfo layerInfo;

            Cad4.GetLayers(list);

            dataGridView4.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                // Layer를 생성하고..
                layerInfo = new LayerInfo();
                layerInfo.Name = list[i].Name;
                layerInfo.szColor = list[i].szColor;
                layerInfo.Direction = Direction.CW;
                layerInfo.Used = !(layerInfo.Name == "0");
                layerInfo.LaserPower = 10.0;
                layerInfo.ZOffset = 1.1;
                layerInfo.PulsePitch = 1.2;

                LaserProject.Model4.Layers.Add(layerInfo);

                // GridRow Data를 생성하고..
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView4);
                row.Cells[1].Value = layerInfo.Name;
                row.Cells[2].Value = layerInfo.Used.ToString();
                row.Cells[3].Value = layerInfo.Tool.ToString();
                row.Cells[4].Value = layerInfo.Direction.ToString();
                row.Cells[5].Value = layerInfo.LaserPower.ToString("F3");
                row.Cells[6].Value = layerInfo.ZOffset.ToString("F3");
                row.Cells[7].Value = layerInfo.PulsePitch.ToString("F3");
                dataGridView4.Rows.Add(row);
            }
        }

        public void UpdateLayerInfo()
        {
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                // 유효한 행인지 확인
                if (i < LaserProject.Model4.Layers.Count)
                {
                    // 현재 행의 데이터 가져오기
                    DataGridViewRow row = dataGridView4.Rows[i];

                    // LaserProject의 LayerInfo 업데이트
                    LaserProject.Model4.Layers[i].Name = row.Cells[1].Value?.ToString(); // 레이어 이름
                    LaserProject.Model4.Layers[i].Used = Convert.ToBoolean(row.Cells[2].Value); // 사용 여부
                    LaserProject.Model4.Layers[i].szColor = row.Cells[3].Value?.ToString(); // 색상 정보
                    LaserProject.Model4.Layers[i].Direction = (Direction)Enum.Parse(typeof(Direction), row.Cells[4].Value?.ToString()); // 방향
                    LaserProject.Model4.Layers[i].LaserPower = yjCommon.StrToDoubleDef(row.Cells[5].Value?.ToString(), 0.0);
                    LaserProject.Model4.Layers[i].ZOffset = yjCommon.StrToDoubleDef(row.Cells[6].Value?.ToString(), 0.0);
                    LaserProject.Model4.Layers[i].PulsePitch = yjCommon.StrToDoubleDef(row.Cells[7].Value?.ToString(), 0.0);
                }
            }
        }


        public void CheckLayerInfo()
        {
            bool error1 = false;

            ztCadLayerList list = new ztCadLayerList();
            Table.Type4.Cad4.GetLayers(list);

            // Layer 갯수가 같은지 체크
            error1 = (list.Count != LaserProject.Model4.Layers.Count);

            // Layer의 이름이 다른지 체크
            int ii = 0;
            for (int nIndex = 0; nIndex < LaserProject.Model4.Layers.Count; nIndex++)
            {
                var szName = LaserProject.Model4.Layers[nIndex].Name;

                for (int nIndex2 = 0; nIndex2 < list.Count; nIndex2++)
                {
                    if (szName.ToLower() == list[nIndex2].Name.ToLower())
                    {
                        cad4Data.Clear();
                        Cad4.CurLayerName = szName;
                        Cad4.GetPage(cad4Data);

                        LaserProject.Model4.Layers[nIndex].Count = cad4Data.Count;
                        //  CodeSite.SendMsg(String.Format("Type3.Cad4.Layer[{0}] = {1}", szName, cad4Data.Count));

                        ii = ii + 1;
                        break;
                    }
                }
            }

            if (error1 || LaserProject.Model4.Layers.Count == 0)
            {
                ;
            }
            else
            {
            }

            for (int nIndex = 0; nIndex < LaserProject.Model4.Layers.Count; nIndex++)
            {
                LaserProject.Model4.Layers[nIndex].szColor = list.GetColor(LaserProject.Model4.Layers[nIndex].Name);
            }
        }


        public void DisplayLayerInfo()
        {
            LayerInfo layerInfo;

            dataGridView4.Rows.Clear();
            for (int nIndex = 0; nIndex < LaserProject.Model4.Layers.Count; nIndex++)
            {
                layerInfo = LaserProject.Model4.Layers[nIndex];

                // GridRow Data를 생성하고..
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView4);
                //  row.Cells[0].Value = nIndex.ToString();
                row.Cells[1].Value = layerInfo.Name;
                row.Cells[2].Value = layerInfo.Used.ToString();
                row.Cells[3].Value = layerInfo.Tool.ToString();
                row.Cells[4].Value = layerInfo.Direction.ToString();
                row.Cells[5].Value = layerInfo.LaserPower.ToString("F3");
                row.Cells[6].Value = layerInfo.ZOffset.ToString("F3");
                row.Cells[7].Value = layerInfo.PulsePitch.ToString("F3");
                dataGridView4.Rows.Add(row);
            }
        }

        public void GetReadyPos()
        {
            is1stReadyPos = true;

            /*
             * 현재 도면의 Min, Max..
             */
            DoublePoint tempReadyPos = new DoublePoint(0, 0);

            SetGrid4Value();

            double offsetX = WorkCenter.x - CenterPos.x;
            double offsetY = WorkCenter.y + CenterPos.y;

            if (AutoMenu.btnLaserRun.LED.Value)
            {
                offsetX += Common.edTable2NozzleXOffset.Value;
                offsetY += Common.edTable2NozzleYOffset.Value;
            }

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model4.Layers.Count; nIndex++)
            {
                if (LaserProject.Model4.Layers[nIndex].Used)
                {
                    cad4Data.Clear();
                    Cad4.CurLayerName = LaserProject.Model4.Layers[nIndex].Name;
                    Cad4.GetPage(cad4Data);

                    var pMarkPage = cad4Data;

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
                                    tempReadyPos = Table.MakeLineType((ztLineItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_POLYLINE:
                                    tempReadyPos = Table.MakePolylineType((ztPolylineItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_ARC:
                                    tempReadyPos = Table.MakeArcType((ztArcItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_CIRCLE:
                                    tempReadyPos = Table.MakeCircleType((ztCircleItem)pItem, 0, 0, offsetX, offsetY);

                                    if (is1stReadyPos)
                                    {
                                        is1stReadyPos = false;

                                        ReadyPos = tempReadyPos;
                                    }
                                    break;

                                case Lcad.LC_ENT_RECT:
                                    tempReadyPos = Table.MakeRectType((ztRectItem)pItem, 0, 0, offsetX, offsetY);

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

            cad4Data.Clear();
            Cad4.CurLayerName = "";
            Cad4.GetPage(cad4Data);
        }

        public void GetWorkCenter(int APageIndex)
        {
        }

        public void MakeMotionFile(TableNo tableNo, int ACellIndex, double shiftX, double shiftY, bool LaserRun)
        {
            GetWorkCenter(ACellIndex);

            yjTech.StringList szList = new yjTech.StringList();

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

            if (AutoMenu.btnLaserRun.LED.Value)
            {
                offsetX += Common.edTable2NozzleXOffset.Value;
                offsetY += Common.edTable2NozzleYOffset.Value;
            }

            SetGrid4Value();

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model4.Layers.Count; nIndex++)
            {
                if (LaserProject.Model4.Layers[nIndex].Used)
                {
                    cad4Data.Clear();
                    Cad4.CurLayerName = LaserProject.Model4.Layers[nIndex].Name;
                    Cad4.GetPage(cad4Data);

                    if (cad4Data.Count <= 0) continue;

                    szList.Add("");
                    szList.Add(String.Format("Open Prog {0}", nIndex + 100 * (int)tableNo));

                    szList.Add("Linear");
                    szList.Add("ABS");
                    szList.Add("Frax(X,Y)");

                    cad4Data.Rotate(CenterPos.x, CenterPos.y, 0);

                    var pMarkPage = cad4Data;

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
                                    Table.MakeLineType(LaserRun, ref szList, (ztLineItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_POLYLINE:
                                    szList.Add($"// Polyline {nEntityIndex}");
                                    Table.MakePolylineType(LaserRun, ref szList, (ztPolylineItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_ARC:
                                    szList.Add($"// Arc {nEntityIndex}");
                                    Table.MakeArcType(LaserRun, ref szList, (ztArcItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_CIRCLE:
                                    szList.Add($"// Circle {nEntityIndex}");
                                    Table.MakeCircleType(LaserRun, ref szList, (ztCircleItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;

                                case Lcad.LC_ENT_RECT:
                                    szList.Add($"// Rect {nEntityIndex}");
                                    Table.MakeRectType(LaserRun, ref szList, (ztRectItem)pItem, shiftX, shiftY, offsetX, offsetY);
                                    break;
                            }
                        }
                    }

                    szList.Add("Close");
                }
            }

            Cad4.CurLayerName = "";

            String szStr = String.Format("{0}Program{1}.pmc", yjCommon.AppPath(), (int)tableNo);
            szList.SaveToFile(szStr);
            szList.Clear();
        }

        /*
        * 달리 방법이 없네..
        */
        public void SetGrid4Value()
        {
            if ((dataGridView4.Rows.Count - 1) != LaserProject.Model4.Layers.Count) return;

            for (int nRowIndex = 0; nRowIndex < LaserProject.Model4.Layers.Count; nRowIndex++)
            {
                // Use
                if (dataGridView4.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "true")
                {
                    LaserProject.Model4.Layers[nRowIndex].Used = true;
                }
                else
                if (dataGridView4.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "false")
                {
                    LaserProject.Model4.Layers[nRowIndex].Used = false;
                }

                // Tool
                if (dataGridView4.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "scanner")
                {
                    LaserProject.Model4.Layers[nRowIndex].Tool = Tool.Scanner;
                }
                else
                if (dataGridView4.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "nozzle")
                {
                    LaserProject.Model4.Layers[nRowIndex].Tool = Tool.Nozzle;
                }

                // Direction
                if (dataGridView4.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "ccw")
                {
                    LaserProject.Model4.Layers[nRowIndex].Direction = Direction.CCW;
                }
                else
                if (dataGridView4.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "cw")
                {
                    LaserProject.Model4.Layers[nRowIndex].Direction = Direction.CW;
                }
            }

            IntPtr hEnt = IntPtr.Zero;

            Cad4.CurLayerName = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            edLaserPower.Apply();
            edPulsePitch.Apply();

            edThickness.Apply();
            edZOffset.Apply();

            edGuideLength.Apply();
            edGuidePitch.Apply();
            edXLength.Apply();
            edYLength.Apply();
            edYPitch.Apply();
            edXPitch.Apply();

            CreateUserCell();
            CheckLayerInfo();
            SetGrid4Value();

            Table.SaveJobFile();

            yjTech.StringList ss = LaserProject.Model4.ToStringList();

            GetWorkCenter(0);

            CodeSite.SendMsg("");
            CodeSite.SendMsg(String.Format("    {0}.Type4.SaveJobFile()", Table.TableNo));
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

        public void btnApply_Click(object sender, EventArgs e)
        {
        }

        public void MakeBeadCut()
        {
            IntPtr hLayer = IntPtr.Zero;

            Cad4.Clear();

            hLayer = Lcad.DrwAddLayer(Cad4.GetDrwHandle(), "Guide Line", "0, 255, 0", IntPtr.Zero, 0);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
            Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");

            hLayer = Lcad.DrwAddLayer(Cad4.GetDrwHandle(), "X Line", "255, 0, 0", IntPtr.Zero, 0);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
            Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");

            hLayer = Lcad.DrwAddLayer(Cad4.GetDrwHandle(), "Y Line", "0, 0, 255", IntPtr.Zero, 0);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_VISIBLE, true);
            Lcad.PropPutBool(hLayer, Lcad.LC_PROP_LAYER_LOCKED, false);
            Lcad.PropPutStr(hLayer, Lcad.LC_PROP_LAYER_DESC, "");

            // GuideLine Top
            double x1 = 0.0, x2 = 0.0, y1 = 0.0, y2 = 0.0;

            x1 = -edGuideLength.Value / 2.0;
            x2 = edGuideLength.Value / 2.0;

            y1 = edGuidePitch.Value / 2.0;
            y2 = edGuidePitch.Value / 2.0;

            IntPtr hLine = Cad4.AddLine(x1, y1, x2, y2);

            // Set color and layer for the polyline
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_COLOR, "0, 255, 0");
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_LAYER, "Guide Line");

            // GuideLine Bottom
            x1 = -edGuideLength.Value / 2.0;
            x2 = edGuideLength.Value / 2.0;

            y1 = -edGuidePitch.Value / 2.0;
            y2 = -edGuidePitch.Value / 2.0;

            hLine = Cad4.AddLine(x1, y1, x2, y2);

            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_COLOR, "0, 255, 0");
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_LAYER, "Guide Line");

            // X Line
            x1 = -edXLength.Value / 2.0;
            x2 = edXLength.Value / 2.0;

            y1 = edXPitch.Value / 2.0;
            y2 = edXPitch.Value / 2.0;

            hLine = Cad4.AddLine(x1, y1, x2, y2);

            // Set color and layer for the polyline
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_COLOR, "255, 0, 0");
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_LAYER, "X Line");

            // GuideLine Bottom
            x1 = -edXLength.Value / 2.0;
            x2 = edXLength.Value / 2.0;

            y1 = -edXPitch.Value / 2.0;
            y2 = -edXPitch.Value / 2.0;

            hLine = Cad4.AddLine(x1, y1, x2, y2);

            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_COLOR, "255, 0, 0");
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_LAYER, "X Line");

            // Y Line
            y1 = edYLength.Value / 2.0;
            y2 = -edYLength.Value / 2.0;

            x1 = -edYPitch.Value / 2.0;
            x2 = -edYPitch.Value / 2.0;

            hLine = Cad4.AddLine(x1, y1, x2, y2);

            // Set color and layer for the polyline
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_COLOR, "0, 0, 255");
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_LAYER, "Y Line");

            // GuideLine Bottom
            y1 = edYLength.Value / 2.0;
            y2 = -edYLength.Value / 2.0;

            x1 = edYPitch.Value / 2.0;
            x2 = edYPitch.Value / 2.0;

            hLine = Cad4.AddLine(x1, y1, x2, y2);

            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_COLOR, "0, 0, 255");
            Lcad.PropPutStr(hLine, Lcad.LC_PROP_ENT_LAYER, "Y Line");
        }

        public void CreateUserCell()
        {
            MakeBeadCut();

            LoadLayerInfo();

            /*
             * 2. Cad1 도면 전체를 데이타를 불러들인다.
             */
            cad4Data.Clear();

            Table.Type4.Cad4.GetPage(cad4Data);
            Table.Type4.SetPageSize();

            Cad4.BlockUpdate();
            Cad4.ZoomExtend();
            Cad4.ZoomScale(0.8);
        }

        public void SetPageSize()
        {
            cad4Data.Width = cad4Data.MarkList.Width;
            cad4Data.Height = cad4Data.MarkList.Height;
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (LaserProject == null) return;
            // 셀이 유효한지 확인
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // CheckBox 열이 2번 컬럼이라 가정
            {
                int rowIndex = e.RowIndex;

                // CheckBox 값 처리 (true 또는 false)
                bool isUsed = Convert.ToBoolean(dataGridView4.Rows[rowIndex].Cells[2].Value);
                LaserProject.Model4.Layers[rowIndex].Used = isUsed;
            }

            UpdateLayerInfo();
        }

        private void dataGridView4_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView4.IsCurrentCellDirty && dataGridView4.CurrentCell.ColumnIndex == 2) // CheckBox 열만 처리
            {
                // 셀 값이 변경되었을 때 즉시 커밋하여 CellValueChanged 이벤트를 발생시킴
                dataGridView4.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            UpdateLayerInfo();
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if ((LaserProject != null) && (LaserProject.Model4.Layers.Count > 0))
            {
                int bRGB, iColor, R, G, B;

                if (e.RowIndex < LaserProject.Model4.Layers.Count)
                {
                    if (dataGridView.Columns[e.ColumnIndex].Name == "Color")
                    {
                        String szColor = LaserProject.Model4.Layers[e.RowIndex].szColor;

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
            if (ASelectedIndex <= 0 || ASelectedIndex >= dataGridView4.Rows.Count) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView4.Rows[ASelectedIndex];
            dataGridView4.Rows.RemoveAt(ASelectedIndex);
            dataGridView4.Rows.Insert(ASelectedIndex - 1, selectedRow);

            // 선택 상태 유지
            dataGridView4.ClearSelection();
            dataGridView4.Rows[ASelectedIndex - 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0) return;

            int nIndex = dataGridView4.SelectedRows[0].Index;

            if (MoveUp(nIndex))
            {
                LaserProject.Model4.Layers.MoveUp(nIndex);
                DisplayLayerInfo();
                dataGridView4.Rows[nIndex - 1].Selected = true;
            }
        }

        private bool MoveDown(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex < 0 || ASelectedIndex >= dataGridView4.Rows.Count - 2) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView4.Rows[ASelectedIndex];
            dataGridView4.Rows.RemoveAt(ASelectedIndex);
            dataGridView4.Rows.Insert(ASelectedIndex + 1, selectedRow);

            // 선택 상태 유지
            dataGridView4.ClearSelection();
            dataGridView4.Rows[ASelectedIndex + 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0) return;

            int nIndex = dataGridView4.SelectedRows[0].Index;

            if (MoveDown(nIndex))
            {
                LaserProject.Model4.Layers.MoveDown(nIndex);
                DisplayLayerInfo();
                dataGridView4.Rows[nIndex + 1].Selected = true;
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.LaserProject.MenuIndex = 3;

            Table.Type1.btnUse.LED.Value = false;
            Table.Type2.btnUse.LED.Value = false;
            Table.Type3.btnUse.LED.Value = false;
            Table.Type4.btnUse.LED.Value = true;

            Table.SaveJobFile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            edLaserPower.Cancel();
            edPulsePitch.Cancel();

            edThickness.Cancel();
            edZOffset.Cancel();

            edGuideLength.Cancel();
            edGuidePitch.Cancel();
            edXLength.Cancel();
            edYPitch.Cancel();
            edYLength.Cancel();
            edXPitch.Cancel();
        }

        private void chkShowJumpline_CheckedChanged(object sender, EventArgs e)
        {
            Cad4.ShowJumpLine = chkShowJumpline.Checked;
        }

        private void btnPreView_Click(object sender, EventArgs e)
        {
            frmPreview frmPreview = frmPreview.StaticInstance;

            if (frmPreview.ShowDialog() == DialogResult.OK)
            {
            }
        }

    }
}
