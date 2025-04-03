using System;
using System.Drawing;
using System.Windows.Forms;

using yjTech;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panJobType2: UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public LaserProject LaserProject = null;

        public panAuto Auto = null;

        public ztCad Cad2;
        public ztMarkPage cad2Data;

        public DoublePoint CenterPos = new DoublePoint();
        public DoublePoint ReadyPos = new DoublePoint();
        public DoublePoint WorkCenter = new DoublePoint(0, 0);

        public panTable Table;

        public PageList PageList;

        public panJobType2()
        {
            InitializeComponent();

            InitDataGridViewControl();
            InitializeControl();

            PageList = new PageList();
        }

        public void InitializeControl()
        {
            cad2Data = new ztMarkPage();

            /*
             * 
             */
            Cad2 = new ztCad();

            Cad2.CadStyle.FileTabs = false;
            Cad2.CadStyle.Rulers = true;
            Cad2.CadStyle.Scrolls = true;
            Cad2.CadStyle.StatusBar = true;
            Cad2.CadStyle.ViewTab3D = false;
            Cad2.CadStyle.ViewTabs = false;

            Cad2.Location = new System.Drawing.Point(0, 0);
            Cad2.Size = new System.Drawing.Size(panCad2.Width, panCad2.Height);

            Cad2.Enabled = false;

            panCad2.Controls.Add(Cad2);
        }

        #region public void InitDataGridViewControl() 
        // DataGridView Column 동적 생성
        public void InitDataGridViewControl()
        {
            dataGridView2.RowHeadersVisible = true;
            dataGridView2.RowHeadersWidth = 20;

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            // 1.Color
            dataGridView2.Columns.Add("Color", "Color");
            dataGridView2.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Color"].Width = 40;

            // 2. Name
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Name"].Width = 180;

            // 3. Use
            DataGridViewCheckBoxColumn ColumnCheckBox = new DataGridViewCheckBoxColumn();
            ColumnCheckBox.ReadOnly = false;
            ColumnCheckBox.Name = "Use";
            ColumnCheckBox.HeaderText = "Use";
            ColumnCheckBox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnCheckBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns.Add(ColumnCheckBox);
            dataGridView2.Columns["Use"].Width = 50;

            // 4. ComboBoxColumn for ColumnTool
            DataGridViewComboBoxColumn ColumnTool = new DataGridViewComboBoxColumn();
            ColumnTool.Name = "Tool";
            ColumnTool.HeaderText = "Tool";
            ColumnTool.Items.AddRange("Scanner", "Nozzle");
            ColumnTool.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnTool.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns.Add(ColumnTool);
            dataGridView2.Columns["Tool"].Width = 90;

            // 5. ComboBoxColumn for Direction
            DataGridViewComboBoxColumn ColumnDir = new DataGridViewComboBoxColumn();
            ColumnDir.Name = "Dir";
            ColumnDir.HeaderText = "Dir";
            ColumnDir.Items.AddRange("CW", "CCW");
            ColumnDir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnDir.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns.Add(ColumnDir);
            dataGridView2.Columns["Dir"].Width = 60;

            // 6. Power
            dataGridView2.Columns.Add("p~.offset", "p~.offset");
            dataGridView2.Columns["p~.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["p~.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["p~.offset"].ReadOnly = true;
            dataGridView2.Columns["p~.offset"].Width = 75;

            // 7. Pitch
            dataGridView2.Columns.Add("z.offset", "z.offset");
            dataGridView2.Columns["z.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["z.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["z.offset"].ReadOnly = true;
            dataGridView2.Columns["z.offset"].Width = 75;

            dataGridView2.AllowUserToResizeRows = false;
        }
        #endregion

        public void EnableControl(bool bEnabled)
        {
        }

        private void btnUse_Click(object sender, EventArgs e)
        {

        }

        public void CheckLayerInfo()
        {
            bool error1 = false, error2 = false;

            ztCadLayerList list = new ztCadLayerList();
            Cad2.GetLayers(list);

            // Layer 갯수가 같은지 체크
            error1 = (list.Count != LaserProject.Model2.Layers.Count);

            // Layer의 이름이 다른지 체크
            int ii = 0;
            for (int nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                var szName = LaserProject.Model2.Layers[nIndex].Name;

                for (int nIndex2 = 0; nIndex2 < list.Count; nIndex2++)
                {
                    if (szName.ToLower() == list[nIndex2].Name.ToLower())
                    {
                        cad2Data.Clear();
                        Cad2.CurLayerName = szName;
                        Cad2.GetPage(cad2Data);

                        LaserProject.Model2.Layers[nIndex].Count = cad2Data.Count;
                        //      CodeSite.SendMsg(String.Format("Type2.Cad2.Layer[{0}] = {1}", szName, cad2Data.Count));
                        ii = ii + 1;
                        break;
                    }
                }

                Cad2.CurLayerName = "";
            }

            if (error1 || error2)
            {
                MakeNewLayer();

                for (int nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
                {
                    var szName = LaserProject.Model2.Layers[nIndex].Name;

                    for (int nIndex2 = 0; nIndex2 < list.Count; nIndex2++)
                    {
                        if (szName.ToLower() == list[nIndex2].Name.ToLower())
                        {
                            cad2Data.Clear();
                            Cad2.CurLayerName = szName;
                            Cad2.GetPage(cad2Data);

                            LaserProject.Model2.Layers[nIndex].Count = cad2Data.Count;
                            ii = ii + 1;
                            break;
                        }
                    }

                    Cad2.CurLayerName = "";
                }
            }

            for (int nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                LaserProject.Model2.Layers[nIndex].szColor = list.GetColor(LaserProject.Model2.Layers[nIndex].Name);
            }

            /* 
            * Layer에 ALign 정보가 있는지 확인 
            */
            StringList szList1 = new StringList();
            StringList szList2 = new StringList();

            for (int nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                string szTmp = LaserProject.Model2.Layers[nIndex].Name.ToLower(); // szTmp를 적절히 초기화해야 합니다.
                int dot = szTmp.IndexOf("align");
                if (dot >= 0)
                {
                    szTmp = szTmp.Remove(0, "align".Length); // 'ALIGN' 문자열 제거
                    szTmp = szTmp.Trim(); // 문자열 앞뒤 공백 제거

                    int jj = -1;
                    if (int.TryParse(szTmp, out jj) && jj > -1)
                    {
                        szList1.Add(LaserProject.Model2.Layers[nIndex].Name);
                        szList2.Add(string.Format("ALIGN {0:D5}", jj)); // 정수 값을 5자리로 포맷
                    }
                }
            }

            ledAlign1Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00001");
            if (ii >= 0)
            {
                Cad2.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad2.GetFirstEntity(false);
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
                    hEnt = Cad2.GetNextEntity(false, hEnt);
                }

                ledAlign1Pos.LED.Value = haveAlign;
                viAlign1PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign1PosY.AsDouble = (xYMin + xYMax) / 2;
            }

            ledAlign2Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00002");
            if (ii >= 0)
            {
                Cad2.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad2.GetFirstEntity(false);
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
                    hEnt = Cad2.GetNextEntity(false, hEnt);
                }

                ledAlign2Pos.LED.Value = haveAlign;
                viAlign2PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign2PosY.AsDouble = (xYMin + xYMax) / 2;
            }

            ledAlign3Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00003");
            if (ii >= 0)
            {
                Cad2.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad2.GetFirstEntity(false);
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
                    hEnt = Cad2.GetNextEntity(false, hEnt);
                }

                ledAlign3Pos.LED.Value = haveAlign;
                viAlign3PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign3PosY.AsDouble = (xYMin + xYMax) / 2;
            }

            ledAlign4Pos.LED.Value = false;
            ii = szList2.IndexOf("ALIGN 00004");
            if (ii >= 0)
            {
                Cad2.CurLayerName = szList1[ii];

                IntPtr hEnt = Cad2.GetFirstEntity(false);
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
                    hEnt = Cad2.GetNextEntity(false, hEnt);
                }

                ledAlign4Pos.LED.Value = haveAlign;
                viAlign4PosX.AsDouble = (xXMin + xXMax) / 2;
                viAlign4PosY.AsDouble = (xYMin + xYMax) / 2;
            }
        }

        public void ClearControlValue()
        {
            lblDxfPath.Text = "";

            Cad2.Clear();
            Cad2.ReDraw();

            edLaserPower.Value = 0.0;
            edPulsePitch.Value = 0.0;

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

            edXCount.AsInteger = 0;
            edYCount.AsInteger = 0;
            edGapX.Value = 0.0;
            edGapY.Value = 0.0;

            btnUse.LED.Value = false;

            dataGridView2.Rows.Clear();
        }

        public void DisplayLayerInfo()
        {
            LayerInfo layerInfo;

            dataGridView2.Rows.Clear();
            for (int nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                layerInfo = LaserProject.Model2.Layers[nIndex];

                // GridRow Data를 생성하고..
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2);
                //  row.Cells[0].Value = nIndex.ToString();
                row.Cells[1].Value = layerInfo.Name;
                row.Cells[2].Value = layerInfo.Used.ToString();
                row.Cells[3].Value = layerInfo.Tool.ToString();
                row.Cells[4].Value = layerInfo.Direction.ToString();
                row.Cells[5].Value = layerInfo.LaserPower.ToString("F3");
                row.Cells[6].Value = layerInfo.ZOffset.ToString("F3");
                dataGridView2.Rows.Add(row);
            }
        }

        public void GetPageData()
        {
            Cad2.CurLayerName = "";
            cad2Data.Clear();
            Cad2.GetPage(cad2Data);
        }

        public void GetWorkCenter(int APageIndex)
        {
            GetPageData();

            double xShift = 0.0, yShift = 0.0;
            if (edGlassSizeX.Value > (PageList.Width))
            {
                xShift = (edGlassSizeX.Value - PageList.Width) / 2.0;
            }
            ;

            if (edGlassSizeY.Value > (PageList.Height))
            {
                yShift = (edGlassSizeY.Value - PageList.Height) / 2.0;
            }

            CenterPos = new DoublePoint(cad2Data.CenterX, cad2Data.CenterY);
            // CodeSite.SendMsg(String.Format("    Type2.cadData.Center = {0:F3}, {1:F3}", cad2Data.CenterX, cad2Data.CenterY));

            double offsetX = 0.0;
            double offsetY = 0.0;
            Table.GetTableBaseOffset(PageList, APageIndex, xShift, yShift, cad2Data, ref offsetX, ref offsetY);

            WorkCenter.x = offsetX; WorkCenter.y = offsetY;
            //CodeSite.SendMsg(String.Format("        Type2.WorkCenter[{0}] = {1:F3}, {2:F3}", APageIndex, WorkCenter.x, WorkCenter.y));
        }

        public void MakeNewLayer()
        {
            ztCadLayerList list = new ztCadLayerList();
            LayerInfo layerInfo;

            LaserProject.Model2.Layers.Clear();

            Table.Type2.Cad2.GetLayers(list);

            for (int i = 0; i < list.Count; i++)
            {
                // Layer를 생성하고..
                layerInfo = new LayerInfo();
                layerInfo.Name = list[i].Name;
                layerInfo.Direction = Direction.CW;
                layerInfo.LaserPower = 10.0;
                layerInfo.PulsePitch = 1.0;
                layerInfo.ZOffset = 0.0;

                LaserProject.Model2.Layers.Add(layerInfo);
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
            switch (LaserProject.Model2.SortMethod)
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
                                ledLabel.Tag = ii;

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

            cbCellIndex.Items.Clear();

            ii = 0;
            for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
            {
                for (nRowIndex = edYCount.AsInteger - 1; nRowIndex >= 0; nRowIndex--)
                {
                    ii = ii + 1;
                    cbCellIndex.Items.Add(String.Format("Cell{0}", ii));
                }
            }
        }


        public void btnApply_Click(object sender, EventArgs e)
        {
            CreateArrayButton();

            GetPageData();

            PageList.Clear();
            PageList.PageSize = new DoublePoint(cad2Data.MarkList.Width, cad2Data.MarkList.Height);
            CalcCellPosition();

            edXCount.Apply();
            edYCount.Apply();
            edGapX.Apply();
            edGapY.Apply();
        }

        public void SetPageSize()
        {
            cad2Data.Width = cad2Data.MarkList.Width;
            cad2Data.Height = cad2Data.MarkList.Height;
        }

        public void CalcCellPosition()
        {
            int nRowIndex = 0, nColIndex = 0;

            SetPageSize();

            int ii = 1;
            switch (LaserProject.Model2.SortMethod)
            {
                case SortMethod.Method1:

                    for (nColIndex = 0; nColIndex < edXCount.AsInteger; nColIndex++)
                    {
                        if ((nColIndex % 2) == 0)
                        {
                            for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                            {
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nRowIndex = edYCount.AsInteger - 1; nRowIndex >= 0; nRowIndex--)
                            {
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * nRowIndex;
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
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nRowIndex = 0; nRowIndex < edYCount.AsInteger; nRowIndex++)
                            {
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * nRowIndex;
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
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * (edYCount.AsInteger - 1) - (cad2Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nColIndex = edXCount.AsInteger - 1; nColIndex >= 0; nColIndex--)
                            {
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * (edYCount.AsInteger - 1) - (cad2Data.Height + edGapY.Value) * nRowIndex;
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
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                        else
                        {
                            for (nColIndex = edXCount.AsInteger - 1; nColIndex >= 0; nColIndex--)
                            {
                                double x = (cad2Data.Width + edGapX.Value) * nColIndex;
                                double y = (cad2Data.Height + edGapY.Value) * nRowIndex;
                                PageList.Add(x, y, true);

                                ii = ii + 1;
                            }
                        }
                    }
                    break;
            }

            //for (int nIndex = 0; nIndex < PageList.Count; nIndex++)
            //{
            //    CodeSite.SendMsg(String.Format("PageList[{0}] = {1}", nIndex, PageList[nIndex].ToString()));
            //}

            //CodeSite.SendMsg(String.Format("PageList.XMin, XMax = {0}, {1}", PageList.XMin, PageList.XMax));
            //CodeSite.SendMsg(String.Format("PageList.YMin, YMax = {0}, {1}", PageList.YMin, PageList.YMax));
            //CodeSite.SendMsg(String.Format("PageList.Size = {0}, {1}", PageList.Width, PageList.Height));
        }

        private void ledLabel_Click(object sender, EventArgs e)
        {
            LEDLabel ledLabel = (LEDLabel)sender;

            ledLabel.LED.Value = !ledLabel.LED.Value;

            int nIndex = yjCommon.StrToIntDef(ledLabel.Text, -1);

            if (nIndex > -1)
            {
                var Item = PageList[nIndex - 1];
                Item.Used = ledLabel.LED.Value;
                PageList[nIndex - 1] = Item;
            }
        }

    }
}
