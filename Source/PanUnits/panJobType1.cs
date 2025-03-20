/*
 * 1. 도면을 불러들이고
 * 2. 도면의 Center를 TableCenter에 위치한다.
 * 3. TabelCenter를 TableBasePos[]에 따라 조정한다.
 * 4. 가공한다.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using DaekhonSystem;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panJobType1 : UserControl
    {
        public panAuto Auto = null;
        public panConfigCommon Common = null;
        public LaserProject LaserProject = null;
        public panTable Table;

        public ztCad Cad1;
        public ztMarkPage cad1Data;

        public DoublePoint CenterPos = new DoublePoint();

        bool is1stReadyPos = false;
        public DoublePoint ReadyPos = new DoublePoint(0, 0);

        private AlignMethod mAlignMethod;

        private TreeNode draggedNode; // 드래그 중인 노드를 저장하는 변수
        private int originalIndex = -1;   // 드래그 시작 시 노드의 원래 위치 

        public DoublePoint WorkCenter = new DoublePoint(0, 0);
        public panJobType1()
        {
            // logger.SendMsg("panJobType1()");

            InitializeComponent();

            Global.ChangeDaekhonControlColor(this.Controls, typeof(DaekhonSystem.ComboBox), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));

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
            dataGridView1.Columns["Name"].Width = 180;

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
            dataGridView1.Columns.Add("p~.offset", "p~.offset");
            dataGridView1.Columns["p~.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["p~.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["p~.offset"].ReadOnly = true;
            dataGridView1.Columns["p~.offset"].Width = 75;

            // 7. z.offset
            dataGridView1.Columns.Add("z.offset", "z.offset");
            dataGridView1.Columns["z.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["z.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["z.offset"].ReadOnly = true;
            dataGridView1.Columns["z.offset"].Width = 75;

            dataGridView1.AllowUserToResizeRows = false;
        }
        #endregion

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (lblDxfPath.Text != "")
            {
                if (System.Windows.Forms.DialogResult.Yes != dkCommon.Confirm("도면 파일을 변경 하면 기존 데이타를 삭제합니다. 진행하시겠습니까?.", "확인"))
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

                szFileName = dkCommon.ExtractFileName(Cad1.FileName);

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

                if (Table.JobInfo.Type2.Cad2.Open(szNewPath))
                {
                    Table.JobInfo.Type2.Cad2.ZoomExtend();
                    Table.JobInfo.Type2.Cad2.ZoomScale(0.8);
                }

                Table.JobInfo.Type2.lblDxfPath.Text = szFileName;
                Table.JobInfo.Type2.CheckLayerInfo();
                Table.JobInfo.Type2.DisplayLayerInfo();
            }
        }

        public void GetWorkCenter()
        {
            double xShift = 0.0, yShift = 0.0;
            
            GetPageData();

            if (edGlassSizeX.Value > (cad1Data.MarkList.Width))
            {
                xShift = (edGlassSizeX.Value - cad1Data.MarkList.Width) / 2.0;
            };

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
            DaekhonSystem.StringList szList1 = new DaekhonSystem.StringList();
            DaekhonSystem.StringList szList2 = new DaekhonSystem.StringList();

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

            if (Auto.btnLaserRun.LED.Value)
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

     //       SetGrid1Value();

            Cad1.Open(Table.GetModelPath() + lblDxfPath.Text);
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

            Cad1.CurLayerName = "";

            String szStr = String.Format("{0}Program{1}.pmc", dkCommon.AppPath(), (int)tableNo);
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

                LaserProject.Model1.Layers[nRowIndex].LaserPower = dkCommon.StrToDoubleDef(dataGridView1.Rows[nRowIndex].Cells[4].Value.ToString(), 0.0);
                LaserProject.Model1.Layers[nRowIndex].ZOffset = dkCommon.StrToDoubleDef(dataGridView1.Rows[nRowIndex].Cells[5].Value.ToString(), 0.0);
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

        public void btnSave_Click(object sender, EventArgs e)
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

            DaekhonSystem.StringList ss = LaserProject.Model1.ToStringList();

            GetWorkCenter();

            CodeSite.SendMsg("");            
            CodeSite.SendMsg(String.Format("    {0}.Type1.SaveJobFile()", Table.TableNo));
            for (int nIndex = 0; nIndex < ss.Count; nIndex ++ )
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
            if (dkCommon.Confirm("Align1위치로 이동합니다.", "확인") == DialogResult.Yes)
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
                    dkCommon.Inform("ALIGN1 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        private void btnMoveAlign2Pos_Click(object sender, EventArgs e)
        {
            if (dkCommon.Confirm("Align2위치로 이동합니다.", "확인") == DialogResult.Yes)
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
                    dkCommon.Inform("ALIGN2 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        private void btnMoveAlign3Pos_Click(object sender, EventArgs e)
        {
            if (dkCommon.Confirm("Align3위치로 이동합니다.", "확인") == DialogResult.Yes)
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
                    };
                }
                else
                {
                    dkCommon.Inform("ALIGN3 마크 설정 오류로 이동할수 없습니다..", "오류");
                }
            }
        }

        private void btnMoveAlign4Pos_Click(object sender, EventArgs e)
        {
            if (dkCommon.Confirm("Align4위치로 이동합니다.", "확인") == DialogResult.Yes)
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
                    dkCommon.Inform("ALIGN4 마크 설정 오류로 이동할수 없습니다..", "오류");
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


        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // 드래그한 노드를 저장하고 드래그 시작
            draggedNode = (TreeNode)e.Item;

            originalIndex = draggedNode.Index; // 드래그 시작 시의 노드 위치 저장

            DoDragDrop(draggedNode, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            // DragEnter 이벤트 처리
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            // DragOver 이벤트 처리: 드래그 중에 현재 위치에 노드 삽입
            e.Effect = DragDropEffects.Move;

            // 마우스 위치에 해당하는 TreeNode 가져오기
            System.Windows.Forms.TreeView treeView = (System.Windows.Forms.TreeView)sender;
            Point targetPoint = treeView.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = treeView.GetNodeAt(targetPoint);

            // 타겟 노드가 존재하고, 현재 드래그 중인 노드와 다르면 하이라이트
            if (targetNode != null && targetNode != draggedNode)
            {
                treeView.SelectedNode = targetNode;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                System.Windows.Forms.TreeView treeView = (System.Windows.Forms.TreeView)sender;
                Point targetPoint = treeView.PointToClient(new Point(e.X, e.Y));
                TreeNode targetNode = treeView.GetNodeAt(targetPoint);

                // 드래그한 노드를 제거하고 새로운 위치에 삽입 (타겟 노드와 다른 경우에만)
                if (targetNode != null && targetNode != draggedNode)
                {
                    draggedNode.Remove();
                    int targetIndex = targetNode.Index;
                    treeView.Nodes.Insert(targetIndex, draggedNode);
                    treeView.SelectedNode = draggedNode;

                    // 노드의 위치가 변경된 경우에만 PrintTreeNodesOrder() 호출
                    if (originalIndex != targetIndex)
                    {
                        ChangeEntityPriority(treeView);
                    }
                }
            }
        }

        private void ChangeEntityPriority(System.Windows.Forms.TreeView treeView)
        {
            IntPtr hEnt1 = IntPtr.Zero;
            IntPtr hEnt2 = IntPtr.Zero;

            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                hEnt1 = new IntPtr(long.Parse(treeView.Nodes[i].Name));

                if (hEnt1 != IntPtr.Zero)
                {
                    hEnt2 = Cad1.GetFirstEntity(false);
                    while (hEnt2 != IntPtr.Zero)
                    {
                        if (hEnt1 == hEnt2)
                        {
                            Lcad.PropPutInt(hEnt2, Lcad.LC_PROP_ENT_PRIORITY, i);

                            break;
                        }
                        else
                        {
                            hEnt2 = Cad1.GetNextEntity(false, hEnt2);
                        }
                    }
                }
            }

            Lcad.BlockSortEnts(Cad1.GetBlockHandle(), false, IntPtr.Zero);

            Cad1.ReDraw();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            IntPtr hEnt = new IntPtr(long.Parse(e.Node.Name));

            if (hEnt != IntPtr.Zero)
            {
                Lcad.BlockUnselect(Cad1.GetBlockHandle());
                Lcad.BlockSelectEnt(Cad1.GetBlockHandle(), hEnt, true);

                Cad1.ReDraw();
            }
        }

        public void ChangeLanguageEnglish()
        {
            tabPage1.Text = Global.iniEng.ReadString("panJobType1", "tabPage1.Text", "Machining Properties");
            tabPage2.Text = Global.iniEng.ReadString("panJobType1", "tabPage2.Text", "Vision Align");
            btnSave.Text = Global.iniEng.ReadString("panJobType1", "btnSave.Text", "Save");
            btnCancel.Text = Global.iniEng.ReadString("panJobType1", "btnCancel.Text", "Cancel");
            btnMoveAlign1Pos.Text = Global.iniEng.ReadString("panJobType1", "btnMoveAlignPos1.Text", "Move");
            btnMoveAlign2Pos.Text = Global.iniEng.ReadString("panJobType1", "btnMoveAlignPos2.Text", "Move");
            btnMoveAlign3Pos.Text = Global.iniEng.ReadString("panJobType1", "btnMoveAlignPos3.Text", "Move");
            btnMoveAlign4Pos.Text = Global.iniEng.ReadString("panJobType1", "btnMoveAlignPos4.Text", "Move");
        }

        public void ChangeLanguageKorea()
        {
            tabPage1.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "tabPage1.Text");
            tabPage2.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "tabPage2.Text");
            btnSave.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "btnSave.Text");
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "btnCancel.Text");
            btnMoveAlign1Pos.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "btnMoveAlignPos1.Text");
            btnMoveAlign2Pos.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "btnMoveAlignPos2.Text");
            btnMoveAlign3Pos.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "btnMoveAlignPos3.Text");
            btnMoveAlign4Pos.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType1", "btnMoveAlignPos4.Text");

        }
        public void ChangeLanguageVietnam()
        {
            tabPage1.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "tabPage1.Text");
            tabPage2.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "tabPage2.Text");
            btnSave.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "btnSave.Text");
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "btnCancel.Text");
            btnMoveAlign1Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "btnMoveAlignPos1.Text");
            btnMoveAlign2Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "btnMoveAlignPos2.Text");
            btnMoveAlign3Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "btnMoveAlignPos3.Text");
            btnMoveAlign4Pos.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType1", "btnMoveAlignPos4.Text");
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.JobInfo.Type1.btnUse.LED.Value = true;
            Table.JobInfo.Type2.btnUse.LED.Value = false;
            Table.JobInfo.Type3.btnUse.LED.Value = false;
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
    }
}
