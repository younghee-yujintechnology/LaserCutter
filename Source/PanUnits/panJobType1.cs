/*
 * 1. 도면을 불러들이고
 * 2. 도면의 Center를 TableCenter에 위치한다.
 * 3. TabelCenter를 TableBasePos[]에 따라 조정한다.
 * 4. 가공한다.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using yjTech;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panJobType1 : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public panAuto Auto = null;
        public panAutoMenu AutoMenu = null;
        public panConfigCommon Common = null;

        public panTable Table;

        public ztCad Cad1;
        public ztMarkPage cad1Data;

        bool is1stReadyPos = false;

        public DoublePoint CenterPos = new DoublePoint();
        public DoublePoint ReadyPos = new DoublePoint(0, 0);
        public DoublePoint WorkCenter = new DoublePoint(0, 0);

        public LaserProject LaserProject = null;

        private AlignMethod mAlignMethod;

        private TreeNode draggedNode; // 드래그 중인 노드를 저장하는 변수
        private int originalIndex = -1;   // 드래그 시작 시 노드의 원래 위치 

        public panJobType1()
        {            
            InitializeComponent();

            InitDataGridViewControl();
            InitializeControl();
        }

        public void InitializeControl()
        {
            Cad1 = new ztCad();

            Cad1.CadStyle.FileTabs = false;
            Cad1.CadStyle.Rulers = true;
            Cad1.CadStyle.Scrolls = true;
            Cad1.CadStyle.StatusBar = true;
            Cad1.CadStyle.ViewTab3D = false;
            Cad1.CadStyle.ViewTabs = false;

            Cad1.Location = new System.Drawing.Point(0, 0);
            Cad1.Size = new System.Drawing.Size(panCad.Width, panCad.Height);

            Cad1.Enabled = false;

            panCad.Controls.Add(Cad1);

            cad1Data = new ztMarkPage();
        }

        #region public void InitDataGridViewControl() 
        // DataGridView Column 동적 생성
        public void InitDataGridViewControl()
        {
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.RowHeadersWidth = 20;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // 1.Color
            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Color"].Width = 40;

            // 2. Name
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Name"].Width = 250;

            // 3. Use
            DataGridViewCheckBoxColumn ColumnCheckBox = new DataGridViewCheckBoxColumn();
            ColumnCheckBox.ReadOnly = false;
            ColumnCheckBox.Name = "Use";
            ColumnCheckBox.HeaderText = "Use";
            ColumnCheckBox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnCheckBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(ColumnCheckBox);
            dataGridView1.Columns["Use"].Width = 50;

            // 4. ComboBoxColumn for ColumnTool
            DataGridViewComboBoxColumn ColumnTool = new DataGridViewComboBoxColumn();
            ColumnTool.Name = "Tool";
            ColumnTool.HeaderText = "Tool";
            ColumnTool.Items.AddRange("Scanner", "Nozzle");
            ColumnTool.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnTool.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(ColumnTool);
            dataGridView1.Columns["Tool"].Width = 90;

            // 5. ComboBoxColumn for Direction
            DataGridViewComboBoxColumn ColumnDir = new DataGridViewComboBoxColumn();
            ColumnDir.Name = "Dir";
            ColumnDir.HeaderText = "Dir";
            ColumnDir.Items.AddRange("CW", "CCW");
            ColumnDir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnDir.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(ColumnDir);
            dataGridView1.Columns["Dir"].Width = 60;

            // 6. power.offset
            dataGridView1.Columns.Add("laser.power\r\noffset", "laser.power\r\noffset");
            dataGridView1.Columns["laser.power\r\noffset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["laser.power\r\noffset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["laser.power\r\noffset"].Width = 100;

            // 7. z.offset
            dataGridView1.Columns.Add("z.offset", "z.offset");
            dataGridView1.Columns["z.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["z.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["z.offset"].Width = 75;

            // 8. Pitch.offset
            dataGridView1.Columns.Add("pulse.pitch\r\noffset", "pulse.pitch\r\noffset");
            dataGridView1.Columns["pulse.pitch\r\noffset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pulse.pitch\r\noffset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pulse.pitch\r\noffset"].Width = 100;

            dataGridView1.AllowUserToResizeRows = false;
        }
        #endregion

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (lblDxfPath.Text != "")
            {
                if (System.Windows.Forms.DialogResult.Yes != yjCommon.Confirm("도면 파일을 변경 하면 기존 데이타를 삭제합니다. 진행하시겠습니까?.", "확인"))
                {
                    return;
                }
            }

            // 현재
            String szFileName;
            if (Cad1.Open(""))
            {
                Cad1.ZoomExtend();
                Cad1.ZoomScale(0.8);

                Cad1.Visible = true;

                szFileName = yjCommon.ExtractFileName(Cad1.FileName);

                String szNewPath = String.Format("{0}{1}", Table.GetModelPath(), szFileName);

                if (Cad1.FileName != szNewPath)
                {
                    System.IO.File.Copy(Cad1.FileName, szNewPath, true);
                }

                lblDxfPath.Text = szFileName;

                if (Cad1.Open(szNewPath))
                {
                    Cad1.ZoomExtend();
                    Cad1.ZoomScale(0.8);
                }

                CheckLayerInfo();

                DisplayLayerInfo();

                if (Table.Type2.Cad2.Open(szNewPath))
                {
                    Table.Type2.Cad2.ZoomExtend();
                    Table.Type2.Cad2.ZoomScale(0.8);
                }

                Table.Type2.lblDxfPath.Text = szFileName;
                Table.Type2.CheckLayerInfo();
                Table.Type2.DisplayLayerInfo();
            }
        }

        public void GetWorkCenter()
        {
            double xShift = 0.0, yShift = 0.0;

            GetPageData();

            if (edGlassSizeX.Value > (cad1Data.MarkList.Width))
            {
                xShift = (edGlassSizeX.Value - cad1Data.MarkList.Width) / 2.0;
            }
;

            if (edGlassSizeY.Value > (cad1Data.MarkList.Height))
            {
                yShift = (edGlassSizeY.Value - cad1Data.MarkList.Height) / 2.0;
            }

            CenterPos = new DoublePoint(cad1Data.CenterX, cad1Data.CenterY);

            double offsetX = 0.0;
            double offsetY = 0.0;
            Table.GetTableBaseOffset(xShift, yShift, cad1Data, ref offsetX, ref offsetY);

            WorkCenter.x = offsetX; WorkCenter.y = offsetY;
            // CodeSite.SendMsg(String.Format("        Type1.WorkCenter = {0:F3}, {1:F3}", WorkCenter.x, WorkCenter.y));
        }

        public void CheckLayerInfo()
        {
            bool error1 = false;

            ztCadLayerList list = new ztCadLayerList();
            Cad1.GetLayers(list);

            // Layer 갯수가 같은지 체크
            error1 = (list.Count != LaserProject.Model1.Layers.Count);

            // Layer의 이름이 다른지 체크
            int ii = 0;
            for (int nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                var szName = LaserProject.Model1.Layers[nIndex].Name;

                for (int nIndex2 = 0; nIndex2 < list.Count; nIndex2++)
                {
                    if (szName.ToLower() == list[nIndex2].Name.ToLower())
                    {
                        cad1Data.Clear();
                        Cad1.CurLayerName = szName;
                        Cad1.GetPage(cad1Data);

                        LaserProject.Model1.Layers[nIndex].Count = cad1Data.Count;
                        //   CodeSite.SendMsg(String.Format("Type1.Cad1.Layer[{0}] = {1}", szName, cad1Data.Count));
                        ii = ii + 1;
                        break;
                    }
                }

                Cad1.CurLayerName = "";
            }

            if (error1 || (ii != list.Count))
            {
                MakeNewLayer();

                for (int nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
                {
                    var szName = LaserProject.Model1.Layers[nIndex].Name;

                    for (int nIndex2 = 0; nIndex2 < list.Count; nIndex2++)
                    {
                        if (szName.ToLower() == list[nIndex2].Name.ToLower())
                        {
                            cad1Data.Clear();
                            Cad1.CurLayerName = szName;
                            Cad1.GetPage(cad1Data);

                            LaserProject.Model1.Layers[nIndex].Count = cad1Data.Count;
                            ii = ii + 1;
                            break;
                        }
                    }

                    Cad1.CurLayerName = "";
                }
            }

            for (int nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                LaserProject.Model1.Layers[nIndex].szColor = list.GetColor(LaserProject.Model1.Layers[nIndex].Name);
            }

            /* 
             * Layer에 ALign 정보가 있는지 확인 
             */
            StringList szList1 = new StringList();
            StringList szList2 = new StringList();

            for (int nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                string szTmp = LaserProject.Model1.Layers[nIndex].Name.ToLower(); // szTmp를 적절히 초기화해야 합니다.
                int dot = szTmp.IndexOf("align");
                if (dot >= 0)
                {
                    szTmp = szTmp.Remove(0, "align".Length); // 'ALIGN' 문자열 제거
                    szTmp = szTmp.Trim(); // 문자열 앞뒤 공백 제거

                    int jj = -1;
                    if (int.TryParse(szTmp, out jj) && jj > -1)
                    {
                        szList1.Add(LaserProject.Model1.Layers[nIndex].Name);
                        szList2.Add(string.Format("ALIGN {0:D5}", jj)); // 정수 값을 5자리로 포맷
                    }
                }
            }

            ledAlign1Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00001");
            if (ii >= 0)
            {
                Cad1.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad1.GetFirstEntity(false);
                double xXMin = 0;
                double xYMin = 0;
                double xXMax = 0;
                double xYMax = 0;

                bool haveAlign = false;
                while (hEnt != IntPtr.Zero)
                {
                    xXMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMIN);
                    xXMin = Math.Round(xXMin * 1000) / 1000;

                    xYMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMIN);
                    xYMin = Math.Round(xYMin * 1000) / 1000;

                    xXMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMAX);
                    xXMax = Math.Round(xXMax * 1000) / 1000;

                    xYMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMAX);
                    xYMax = Math.Round(xYMax * 1000) / 1000;

                    haveAlign = true;
                    hEnt = Cad1.GetNextEntity(false, hEnt);
                }

                ledAlign1Pos.LED.Value = haveAlign;
                viAlign1PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign1PosY.AsDouble = (xYMin + xYMax) / 2;
            }

            ledAlign2Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00002");
            if (ii >= 0)
            {
                Cad1.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad1.GetFirstEntity(false);
                double xXMin = 0;
                double xYMin = 0;
                double xXMax = 0;
                double xYMax = 0;

                bool haveAlign = false;
                while (hEnt != IntPtr.Zero)
                {
                    xXMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMIN);
                    xXMin = Math.Round(xXMin * 1000) / 1000;

                    xYMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMIN);
                    xYMin = Math.Round(xYMin * 1000) / 1000;

                    xXMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMAX);
                    xXMax = Math.Round(xXMax * 1000) / 1000;

                    xYMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMAX);
                    xYMax = Math.Round(xYMax * 1000) / 1000;

                    haveAlign = true;
                    hEnt = Cad1.GetNextEntity(false, hEnt);
                }

                ledAlign2Pos.LED.Value = haveAlign;
                viAlign2PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign2PosY.AsDouble = (xYMin + xYMax) / 2;
            }

            ledAlign3Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00003");
            if (ii >= 0)
            {
                Cad1.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad1.GetFirstEntity(false);
                double xXMin = 0;
                double xYMin = 0;
                double xXMax = 0;
                double xYMax = 0;

                bool haveAlign = false;
                while (hEnt != IntPtr.Zero)
                {
                    xXMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMIN);
                    xXMin = Math.Round(xXMin * 1000) / 1000;

                    xYMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMIN);
                    xYMin = Math.Round(xYMin * 1000) / 1000;

                    xXMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMAX);
                    xXMax = Math.Round(xXMax * 1000) / 1000;

                    xYMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMAX);
                    xYMax = Math.Round(xYMax * 1000) / 1000;

                    haveAlign = true;
                    hEnt = Cad1.GetNextEntity(false, hEnt);
                }

                ledAlign3Pos.LED.Value = haveAlign;
                viAlign3PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign3PosY.AsDouble = (xYMin + xYMax) / 2;
            }

            ledAlign4Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00004");
            if (ii >= 0)
            {
                Cad1.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad1.GetFirstEntity(false);
                double xXMin = 0;
                double xYMin = 0;
                double xXMax = 0;
                double xYMax = 0;

                bool haveAlign = false;
                while (hEnt != IntPtr.Zero)
                {
                    xXMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMIN);
                    xXMin = Math.Round(xXMin * 1000) / 1000;

                    xYMin = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMIN);
                    xYMin = Math.Round(xYMin * 1000) / 1000;

                    xXMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_XMAX);
                    xXMax = Math.Round(xXMax * 1000) / 1000;

                    xYMax = Lcad.PropGetFloat(hEnt, Lcad.LC_PROP_ENT_YMAX);
                    xYMax = Math.Round(xYMax * 1000) / 1000;

                    haveAlign = true;
                    hEnt = Cad1.GetNextEntity(false, hEnt);
                }

                ledAlign4Pos.LED.Value = haveAlign;
                viAlign4PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign4PosY.AsDouble = (xYMin + xYMax) / 2;
            }
        }

        public void EnableControl(bool bEnabled)
        {
            btnOpenFile.Enabled = bEnabled;
            btnClear.Enabled = bEnabled;

            Cad1.Enabled = bEnabled;
            edLaserPower.Enabled = bEnabled;
            edPulsePitch.Enabled = bEnabled;
            cbStartPoint.Enabled = bEnabled;

            edManualShiftX.Enabled = bEnabled;
            edManualShiftY.Enabled = bEnabled;

            edGlassSizeX.Enabled = bEnabled;
            edGlassSizeY.Enabled = bEnabled;

            dataGridView1.Enabled = bEnabled;

            btnMoveAlign1Pos.Enabled = bEnabled;
            btnMoveAlign2Pos.Enabled = bEnabled;
            btnMoveAlign3Pos.Enabled = bEnabled;
            btnMoveAlign4Pos.Enabled = bEnabled;

            btnMoveUp.Enabled = bEnabled;
            btnMoveDown.Enabled = bEnabled;

            edThickness.Enabled = bEnabled;
            edZOffset.Enabled = bEnabled;

            chkAlignUse.Enabled = bEnabled;
            rdoAlign2P_1_2.Enabled = bEnabled;
            rdoAlign2P_1_3.Enabled = bEnabled;
            rdoAlign2P_1_4.Enabled = bEnabled;

            rdoAlign4P.Enabled = bEnabled;

            btnSave.Enabled = bEnabled;
            btnCancel.Enabled = bEnabled;
        }

        public void ClearControlValue()
        {
            lblDxfPath.Text = "";

            Cad1.Clear();
            Cad1.ReDraw();

            edLaserPower.Value = 0.0;
            edPulsePitch.Value = 0.000;

            edManualShiftX.Value = 0.0;
            edManualShiftY.Value = 0.0;

            edGlassSizeX.Value = 0.0;
            edGlassSizeY.Value = 0.0;

            //  dataGridView1.IEnabled = bEnabled;

            edZOffset.Value = 0.0;

            chkAlignUse.Checked = false;
            rdoAlign2P_1_2.Checked = false;
            rdoAlign2P_1_3.Checked = false;
            rdoAlign2P_1_4.Checked = false;

            ledAlign1Pos.LED.Value = false;
            viAlign1PosX.AsDouble = 0.0;
            viAlign1PosY.AsDouble = 0.0;

            ledAlign2Pos.LED.Value = false;
            viAlign2PosX.AsDouble = 0.0;
            viAlign2PosY.AsDouble = 0.0;

            ledAlign3Pos.LED.Value = false;
            viAlign3PosX.AsDouble = 0.0;
            viAlign3PosY.AsDouble = 0.0;

            ledAlign4Pos.LED.Value = false;
            viAlign4PosX.AsDouble = 0.0;
            viAlign4PosY.AsDouble = 0.0;

            btnUse.LED.Value = false;

            dataGridView1.Rows.Clear();
        }

        public void MakeNewLayer()
        {
            ztCadLayerList list = new ztCadLayerList();
            LayerInfo layerInfo;

            LaserProject.Model1.Layers.Clear();

            Cad1.GetLayers(list);

            for (int i = 0; i < list.Count; i++)
            {
                // Layer를 생성하고..
                layerInfo = new LayerInfo();
                layerInfo.Name = list[i].Name;
                layerInfo.Direction = Direction.CW;
                layerInfo.LaserPower = 10.0;
                layerInfo.PulsePitch = 1.0;
                layerInfo.ZOffset = 0.0;

                LaserProject.Model1.Layers.Add(layerInfo);
            }
        }

        public void DisplayLayerInfo()
        {
            LayerInfo layerInfo;

            dataGridView1.Rows.Clear();
            for (int nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                layerInfo = LaserProject.Model1.Layers[nIndex];

                // GridRow Data를 생성하고..
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                //  row.Cells[0].Value = nIndex.ToString();
                row.Cells[1].Value = layerInfo.Name;
                row.Cells[2].Value = layerInfo.Used.ToString();
                row.Cells[3].Value = layerInfo.Tool.ToString();
                row.Cells[4].Value = layerInfo.Direction.ToString();
                row.Cells[5].Value = layerInfo.LaserPower.ToString("F3");
                row.Cells[6].Value = layerInfo.ZOffset.ToString("F3");
                row.Cells[7].Value = layerInfo.PulsePitch.ToString("F3");
                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ClearSelection();
        }

        /*
        * ReadyPos: 가공 시작 전 대기 위치
        * 어떤 도형에서, 어떤 방향에서 시작할지 찾아야 한다.
        */
        public void GetReadyPos()
        {
            is1stReadyPos = true;

            /*
             * 현재 도면의 Min, Max..
             */
            DoublePoint tempReadyPos = new DoublePoint(0, 0);

            SetGrid1Value();

            double offsetX = WorkCenter.x - CenterPos.x;
            double offsetY = WorkCenter.y + CenterPos.y;

            if (AutoMenu.btnLaserRun.LED.Value)
            {
                offsetX += Common.edTable2NozzleXOffset.Value;
                offsetY += Common.edTable2NozzleYOffset.Value;
            }

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                if (LaserProject.Model1.Layers[nIndex].Used)
                {
                    cad1Data.Clear();
                    Cad1.CurLayerName = LaserProject.Model1.Layers[nIndex].Name;
                    Cad1.GetPage(cad1Data);

                    var pMarkPage = cad1Data;

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

            cad1Data.Clear();
            Cad1.CurLayerName = "";
            Cad1.GetPage(cad1Data);
        }

        /*
         * Table1: 100 부터 ~ 시작
         * Table2: 200 부터 ~ 시작
         */
        public void MakeMotionFile(TableNo tableNo, double Angle, double shiftX, double shiftY, bool LaserRun)
        {
            GetWorkCenter();

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

            Cad1.Open(Table.GetModelPath() + lblDxfPath.Text);
            Cad1.ZoomExtend();
            Cad1.ZoomScale(0.8);
            SetGrid1Value();
            Cad1.Rotate(CenterPos.x, CenterPos.y, Angle);

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                if (LaserProject.Model1.Layers[nIndex].Used)
                {
                    cad1Data.Clear();
                    Cad1.CurLayerName = LaserProject.Model1.Layers[nIndex].Name;
                    Cad1.GetPage(cad1Data);

                    if (cad1Data.Count <= 0) continue;

                    szList.Add("");
                    szList.Add(String.Format("Open Prog {0}", nIndex + 100 * (int)tableNo));

                    szList.Add("Linear");
                    szList.Add("ABS");
                    szList.Add("Frax(X,Y)");

                    var pMarkPage = cad1Data;

                    if (pMarkPage.MarkList.Count > 0)
                    {
                        // logger.SendMsg(String.Format("LayerName=\"{0}\" Entity.Count = {1}", Cad1.CurLayerName, nCount));

                        szList.Add("");
                        szList.Add("// ================================================================================");
                        szList.Add($"// LayerName:[{LaserProject.Model1.Layers[nIndex].Name}]");
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

            Cad1.CurLayerName = "";

            String szStr = String.Format("{0}Program{1}.pmc", yjCommon.AppPath(), (int)tableNo);
            szList.SaveToFile(szStr);
            szList.Clear();
        }

        /*
         * 달리 방법이 없네..
         */
        public void SetGrid1Value()
        {
            if ((dataGridView1.Rows.Count - 1) != LaserProject.Model1.Layers.Count) return;

            for (int nRowIndex = 0; nRowIndex < LaserProject.Model1.Layers.Count; nRowIndex++)
            {
                if (dataGridView1.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "true")
                {
                    LaserProject.Model1.Layers[nRowIndex].Used = true;
                }
                else
                if (dataGridView1.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "false")
                {
                    LaserProject.Model1.Layers[nRowIndex].Used = false;
                }

                // Tool
                if (dataGridView1.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "scanner")
                {
                    LaserProject.Model1.Layers[nRowIndex].Tool = Tool.Scanner;
                }
                else
                if (dataGridView1.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "nozzle")
                {
                    LaserProject.Model1.Layers[nRowIndex].Tool = Tool.Nozzle;
                }

                // Direction
                if (dataGridView1.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "ccw")
                {
                    LaserProject.Model1.Layers[nRowIndex].Direction = Direction.CCW;
                }
                else
                if (dataGridView1.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "cw")
                {
                    LaserProject.Model1.Layers[nRowIndex].Direction = Direction.CW;
                }

                LaserProject.Model1.Layers[nRowIndex].LaserPower = yjCommon.StrToDoubleDef(dataGridView1.Rows[nRowIndex].Cells[4].Value.ToString(), 0.0);
                LaserProject.Model1.Layers[nRowIndex].ZOffset = yjCommon.StrToDoubleDef(dataGridView1.Rows[nRowIndex].Cells[5].Value.ToString(), 0.0);
            }

            IntPtr hEnt = IntPtr.Zero;
            int nIndex;

            // 속성을 변경
            for (nIndex = 0; nIndex < LaserProject.Model1.Layers.Count; nIndex++)
            {
                if (LaserProject.Model1.Layers[nIndex].Used)
                {
                    /* Laser단위로 설정하고..
                     * Entity를 불러들여 속성을 변경한다.
                     * Direction, StartPoint..
                     */

                    Cad1.CurLayerName = LaserProject.Model1.Layers[nIndex].Name;

                    hEnt = Cad1.GetFirstEntity(false);
                    while (hEnt != IntPtr.Zero)
                    {
                        int nEntType = Lcad.PropGetInt(hEnt, Lcad.LC_PROP_ENT_TYPE);
                        if (nEntType == Lcad.LC_ENT_POLYLINE)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_PLINE_CW);
                            bool CCWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_PLINE_CCW);

                            if ((LaserProject.Model1.Layers[nIndex].Direction == Direction.CW) && CCWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            else
                            if ((LaserProject.Model1.Layers[nIndex].Direction == Direction.CCW) && CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            Lcad.EntUpdate(hEnt);

                            Cad1.SetStartPoint(hEnt, (StartPoint)cbStartPoint.ItemIndex);
                            Lcad.EntUpdate(hEnt);
                        }
                        else
                        if (nEntType == Lcad.LC_ENT_CIRCLE)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_CIRCLE_DIRCW);

                            if ((LaserProject.Model1.Layers[nIndex].Direction == Direction.CW) && !CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            else
                            if ((LaserProject.Model1.Layers[nIndex].Direction == Direction.CCW) && CWDir)
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
                        else
                        if (nEntType == Lcad.LC_ENT_RECT)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_RECT_DIRCW);

                            if ((LaserProject.Model1.Layers[nIndex].Direction == Direction.CW) && !CWDir)
                            {
                                Lcad.PropPutBool(hEnt, Lcad.LC_PROP_RECT_DIRCW, true);
                            }
                            else
                            if ((LaserProject.Model1.Layers[nIndex].Direction == Direction.CCW) && CWDir)
                            {
                                Lcad.PropPutBool(hEnt, Lcad.LC_PROP_RECT_DIRCW, false);
                            }

                            switch ((StartPoint)cbStartPoint.ItemIndex)
                            {
                                case StartPoint.Left:
                                    Lcad.PropPutInt(hEnt, Lcad.LC_PROP_RECT_START, 5); // Middle Left
                                    break;

                                case StartPoint.Top:
                                    Lcad.PropPutInt(hEnt, Lcad.LC_PROP_RECT_START, 6); // Middle Top
                                    break;

                                case StartPoint.Right:
                                    Lcad.PropPutInt(hEnt, Lcad.LC_PROP_RECT_START, 7); // Middle Right
                                    break;

                                case StartPoint.Bottom:
                                    Lcad.PropPutInt(hEnt, Lcad.LC_PROP_RECT_START, 4); // Middle Bottom
                                    break;
                            }
                        }

                        Lcad.PropPutInt(hEnt, Lcad.LC_PROP_ENT_MARK_COUNT, 1);
                        Lcad.EntUpdate(hEnt);

                        hEnt = Cad1.GetNextEntity(false, hEnt);
                    }
                }
            }

            Cad1.CurLayerName = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetGrid1Value();

            edLaserPower.Apply();
            edPulsePitch.Apply();

            edThickness.Apply();
            edZOffset.Apply();
            edManualShiftX.Apply();
            edManualShiftY.Apply();
            edGlassSizeX.Apply();
            edGlassSizeY.Apply();

            Table.SaveJobFile();

            yjTech.StringList ss = LaserProject.Model1.ToStringList();

            GetWorkCenter();

            CodeSite.SendMsg("");
            CodeSite.SendMsg(String.Format("    {0}.Type1.SaveJobFile()", Table.TableNo));
            for (int nIndex = 0; nIndex < ss.Count; nIndex++)
            {
                CodeSite.SendMsg(ss[nIndex]);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if ((LaserProject != null) && (LaserProject.Model1.Layers.Count > 0))
            {
                int bRGB, iColor, R, G, B;

                if (e.RowIndex < LaserProject.Model1.Layers.Count)
                {
                    if (dataGridView.Columns[e.ColumnIndex].Name == "Color")
                    {
                        String szColor = LaserProject.Model1.Layers[e.RowIndex].szColor;

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

        public void GetPageData()
        {
            Cad1.CurLayerName = "";
            cad1Data.Clear();
            Cad1.GetPage(cad1Data);
        }

        private bool MoveUp(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex <= 0 || ASelectedIndex >= dataGridView1.Rows.Count) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView1.Rows[ASelectedIndex];
            dataGridView1.Rows.RemoveAt(ASelectedIndex);
            dataGridView1.Rows.Insert(ASelectedIndex - 1, selectedRow);

            // 선택 상태 유지
            dataGridView1.ClearSelection();
            dataGridView1.Rows[ASelectedIndex - 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int nIndex = dataGridView1.SelectedRows[0].Index;

            if (MoveUp(nIndex))
            {
                LaserProject.Model1.Layers.MoveUp(nIndex);
                DisplayLayerInfo();
                dataGridView1.Rows[nIndex - 1].Selected = true;

                //logger.SendMsg("");
                //for (int i = 0; i < LaserProject.Model1.Layers.Count; i++)
                //{
                //    logger.SendMsg($"{LaserProject.Model1.Layers[i]}");
                //}
            }
        }

        private bool MoveDown(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex < 0 || ASelectedIndex >= dataGridView1.Rows.Count - 2) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView1.Rows[ASelectedIndex];
            dataGridView1.Rows.RemoveAt(ASelectedIndex);
            dataGridView1.Rows.Insert(ASelectedIndex + 1, selectedRow);

            // 선택 상태 유지
            dataGridView1.ClearSelection();
            dataGridView1.Rows[ASelectedIndex + 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int nIndex = dataGridView1.SelectedRows[0].Index;

            if (MoveDown(nIndex))
            {
                LaserProject.Model1.Layers.MoveDown(nIndex);
                DisplayLayerInfo();
                dataGridView1.Rows[nIndex + 1].Selected = true;

                //logger.SendMsg("");
                //for (int i = 0; i < LaserProject.Model1.Layers.Count; i++)
                //{
                //    logger.SendMsg($"{LaserProject.Model1.Layers[i]}");
                //}
            }
        }

        private void btnMoveAlign1Pos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Align1위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                if (ledAlign1Pos.LED.Value)
                {
                    Pmac.XMoveAbs(WorkCenter.x + (viAlign1PosX.AsDouble - CenterPos.x));

                    if (Table.TableNo == TableNo.Table1)
                    {
                        Pmac.Y1MoveAbs(WorkCenter.y - (viAlign1PosY.AsDouble - CenterPos.y));
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
                    }
                    else
                    if (Table.TableNo == TableNo.Table2)
                    {
                        Pmac.Y2MoveAbs(WorkCenter.y - (viAlign1PosY.AsDouble - CenterPos.y));
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
                    }

                }
                else
                {
                    yjCommon.Inform("ALIGN1 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        private void btnMoveAlign2Pos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Align2위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                if (ledAlign2Pos.LED.Value)
                {
                    Pmac.XMoveAbs(WorkCenter.x + (viAlign2PosX.AsDouble - CenterPos.x));

                    if (Table.TableNo == TableNo.Table1)
                    {
                        Pmac.Y1MoveAbs(WorkCenter.y - (viAlign2PosY.AsDouble - CenterPos.y));
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
                    }
                    else
                    if (Table.TableNo == TableNo.Table2)
                    {
                        Pmac.Y2MoveAbs(WorkCenter.y - (viAlign2PosY.AsDouble - CenterPos.y));
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
                    }
                }
                else
                {
                    yjCommon.Inform("ALIGN2 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        private void btnMoveAlign3Pos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Align3위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                if (ledAlign3Pos.LED.Value)
                {
                    Pmac.XMoveAbs(WorkCenter.x + viAlign3PosX.AsDouble);

                    if (Table.TableNo == TableNo.Table1)
                    {
                        Pmac.Y1MoveAbs(WorkCenter.y - viAlign3PosY.AsDouble);
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
                    }
                    else
                    if (Table.TableNo == TableNo.Table1)
                    {
                        Pmac.Y2MoveAbs(WorkCenter.y - viAlign3PosY.AsDouble);
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
                    }
                    ;
                }
                else
                {
                    yjCommon.Inform("ALIGN3 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        private void btnMoveAlign4Pos_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("Align4위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                if (ledAlign4Pos.LED.Value)
                {
                    Pmac.XMoveAbs(WorkCenter.x + viAlign4PosX.AsDouble);

                    if (Table.TableNo == TableNo.Table1)
                    {
                        Pmac.Y1MoveAbs(WorkCenter.y - viAlign4PosY.AsDouble);
                        Pmac.ZMoveAbs(Global.chTable1VisionZFocus.AsDouble);
                    }
                    else
                    if (Table.TableNo == TableNo.Table2)
                    {
                        Pmac.Y2MoveAbs(WorkCenter.y - viAlign4PosY.AsDouble);
                        Pmac.ZMoveAbs(Global.chTable2VisionZFocus.AsDouble);
                    }
                }
                else
                {
                    yjCommon.Inform("ALIGN4 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        public AlignMethod AlignMethod
        {
            get { return mAlignMethod; }
            set
            {
                mAlignMethod = value;

                rdoAlign2P_1_2.Checked = (value == AlignMethod.Align2P_1_2);
                rdoAlign2P_1_3.Checked = (value == AlignMethod.Align2P_1_3);
                rdoAlign2P_1_4.Checked = (value == AlignMethod.Align2P_1_4);
                rdoAlign4P.Checked = (value == AlignMethod.Align4P);
            }
        }

        private void rdoAlign2P_1_2_Click(object sender, EventArgs e)
        {
            AlignMethod = AlignMethod.Align2P_1_2;
        }

        private void rdoAlign2P_1_3_Click(object sender, EventArgs e)
        {
            AlignMethod = AlignMethod.Align2P_1_3;
        }

        private void rdoAlign2P_1_4_Click(object sender, EventArgs e)
        {
            AlignMethod = AlignMethod.Align2P_1_4;
        }

        private void rdoAlign4P_Click(object sender, EventArgs e)
        {
            AlignMethod = AlignMethod.Align4P;
        }

        private void chkAlignUse_Click(object sender, EventArgs e)
        {
            rdoAlign2P_1_2.Enabled = !chkAlignUse.Checked;
            rdoAlign2P_1_3.Enabled = !chkAlignUse.Checked;
            rdoAlign2P_1_4.Enabled = !chkAlignUse.Checked;
            rdoAlign4P.Enabled = !chkAlignUse.Checked;

            ledUseVision.LED.Value = !chkAlignUse.Checked;
        }


        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.Type1.btnUse.LED.Value = true;
            Table.Type2.btnUse.LED.Value = false;
            Table.Type3.btnUse.LED.Value = false;
            Table.Type4.btnUse.LED.Value = false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            edLaserPower.Cancel();
            edPulsePitch.Cancel();

            edThickness.Cancel();
            edZOffset.Cancel();
            edManualShiftX.Cancel();
            edManualShiftY.Cancel();
            edGlassSizeX.Cancel();
            edGlassSizeY.Cancel();
        }

        private void chkShowJumpline_CheckedChanged(object sender, EventArgs e)
        {
            Cad1.ShowJumpLine = chkShowJumpline.Checked;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (LaserProject == null) return;
            // 셀이 유효한지 확인
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // CheckBox 열이 2번 컬럼이라 가정
            {
                int rowIndex = e.RowIndex;

                // CheckBox 값 처리 (true 또는 false)
                bool isUsed = Convert.ToBoolean(dataGridView1.Rows[rowIndex].Cells[2].Value);
                LaserProject.Model3.Layers[rowIndex].Used = isUsed;
            }

            UpdateLayerInfo();
        }

        public void UpdateLayerInfo()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // 유효한 행인지 확인
                if (i < LaserProject.Model1.Layers.Count)
                {
                    // 현재 행의 데이터 가져오기
                    DataGridViewRow row = dataGridView1.Rows[i];

                    // LaserProject의 LayerInfo 업데이트
                    LaserProject.Model1.Layers[i].Name = row.Cells[1].Value?.ToString(); // 레이어 이름
                    LaserProject.Model1.Layers[i].Used = Convert.ToBoolean(row.Cells[2].Value); // 사용 여부
                    LaserProject.Model1.Layers[i].szColor = row.Cells[3].Value?.ToString(); // 색상 정보
                    LaserProject.Model1.Layers[i].Direction = (Direction)Enum.Parse(typeof(Direction), row.Cells[4].Value?.ToString()); // 방향
                    LaserProject.Model1.Layers[i].LaserPower = yjCommon.StrToDoubleDef(row.Cells[5].Value?.ToString(), 0.0);
                    LaserProject.Model1.Layers[i].ZOffset = yjCommon.StrToDoubleDef(row.Cells[6].Value?.ToString(), 0.0);
                    LaserProject.Model1.Layers[i].PulsePitch = yjCommon.StrToDoubleDef(row.Cells[7].Value?.ToString(), 0.0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // RoundRect의 중심점과 치수
            double centerX = 100; // 중심점 X
            double centerY = 100; // 중심점 Y
            double width = 200;   // 너비
            double height = 100;  // 높이
            double cornerRadius = 20; // 코너 반지름

            // 시작점과 방향 설정
            string start = "E"; // 시작점: "N", "E", "W", "S"
            string direction = "CW"; // 방향: "CW" 또는 "CCW"

            // 좌표 계산
            var points = CalculateRoundRectPath(centerX, centerY, width, height, cornerRadius, start, direction);

            CodeSite.SendMsg($"Line ({points[0].X}, {points[0].Y}, {points[1].X}, {points[1].Y})");
            CodeSite.SendMsg($" arc ({points[1].X}, {points[1].Y}, {points[2].X}, {points[2].Y})");
            CodeSite.SendMsg($"Line ({points[2].X}, {points[2].Y}, {points[3].X}, {points[3].Y})");
            CodeSite.SendMsg($"Line ({points[3].X}, {points[3].Y}, {points[4].X}, {points[4].Y})");
            CodeSite.SendMsg($" arc ({points[4].X}, {points[4].Y}, {points[5].X}, {points[5].Y})");
            CodeSite.SendMsg($"Line ({points[5].X}, {points[5].Y}, {points[6].X}, {points[6].Y})");
            CodeSite.SendMsg($"Line ({points[6].X}, {points[6].Y}, {points[7].X}, {points[7].Y})");
            CodeSite.SendMsg($" arc ({points[7].X}, {points[7].Y}, {points[8].X}, {points[8].Y})");
            CodeSite.SendMsg($"Line ({points[8].X}, {points[8].Y}, {points[9].X}, {points[9].Y})");
            CodeSite.SendMsg($"Line ({points[9].X}, {points[9].Y}, {points[10].X}, {points[10].Y})");
            CodeSite.SendMsg($" arc ({points[10].X}, {points[10].Y}, {points[11].X}, {points[11].Y})");
            CodeSite.SendMsg($"Line ({points[11].X}, {points[11].Y}, {points[0].X}, {points[0].Y})");
        }

        static List<(double X, double Y, String Type)> CalculateRoundRectPath(double centerX, double centerY, double width, double height, double radius, string start, string direction)
        {
            // 사각형 네 변의 중심 좌표
            double left = centerX - (width / 2);
            double right = centerX + (width / 2);
            double top = centerY + (height / 2);
            double bottom = centerY - (height / 2);

            // 모든 좌표를 순서대로 정의 (시계방향 기준)
            var points = new List<(double X, double Y, string Type)>
            {
                (left + radius, bottom, "0"), // 0
                (left, bottom + radius, "1"), // 1
                (left, centerY, "2"),         // 2
                (left, top - radius, "3"),    // 3
                (left + radius, top, "4"),    // 4
                (centerX, top, "5"),          // 5
                (right - radius, top, "6"),   // 6
                (right, top - radius, "7"),   // 7
                (right, centerY, "8"),        // 8
                (right, bottom + radius, "9"),// 9
                (right - radius, bottom, "10"),// 10
                (centerX, bottom, "11")       // 11
            };

            // 시작점 인덱스 설정
            int startIndex;
            switch (start)
            {
                case "S":
                case "s":
                    startIndex = 11;
                    break;

                case "N":
                case "n":
                    startIndex = 5;
                    break;

                case "E":
                case "e":
                    startIndex = 8;
                    break;

                case "W":
                case "w":
                    startIndex = 2;
                    break;

                default:
                    throw new Exception("Invalid start point");
            }

            // 방향에 따른 정렬
            var orderedPoints = new List<(double X, double Y, String Type)>();

            if ((direction == "CW") || (direction == "cw"))
            {
                for (int i = startIndex; i < points.Count; i++) // 현재에서 끝까지
                    orderedPoints.Add(points[i]);
                for (int i = 0; i < startIndex; i++) // 0부터 시작점 전까지
                    orderedPoints.Add(points[i]);
            }
            else
            if ((direction == "CCW") || (direction == "ccw"))
            {
                for (int i = startIndex; i >= 0; i--) // 현재에서 처음까지
                    orderedPoints.Add(points[i]);
                for (int i = points.Count - 1; i > startIndex; i--) // 끝에서 시작점 바로 앞까지
                    orderedPoints.Add(points[i]);
            }
            else
            {
                throw new Exception("Invalid direction");
            }

            return orderedPoints;
        }


    }
}
