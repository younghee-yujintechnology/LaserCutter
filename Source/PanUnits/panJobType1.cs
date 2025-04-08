/*
 * 
 * 
 */

using System;
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

        public DoublePoint CenterPos = new DoublePoint();
        public DoublePoint ReadyPos = new DoublePoint(0, 0);
        public DoublePoint WorkCenter = new DoublePoint(0, 0);

        public LaserProject LaserProject = null;

        private AlignMethod mAlignMethod;

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
            ColumnCheckBox.ReadOnly = true;
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

        public void GetPageData()
        {
            Cad1.CurLayerName = "";
            cad1Data.Clear();
            Cad1.GetPage(cad1Data);
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
                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ClearSelection();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.Type1.btnUse.LED.Value = true;
            Table.Type2.btnUse.LED.Value = false;
            Table.Type3.btnUse.LED.Value = false;
            Table.Type4.btnUse.LED.Value = false;
        }

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
    }
}
