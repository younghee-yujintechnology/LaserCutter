/*
/*
 * 1. 도면을 불러들이고
 * 2. Array도면을 만들고
 * 3. Array도면의 Center를 TableCenter에 위치한다.
 * 4. TabelCenter를 TableBasePos[]에 따라 조정한다.
 * 5. Array[n] 위치를 뽑아내어 가공한다.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

using YujinTechnology;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panJobType2 : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();
        
        public panAuto Auto = null;
        public panConfigCommon Common = null;
        public LaserProject LaserProject = null;
        public panTable Table;

        public ztCad Cad2;
        public ztMarkPage cad2Data;

        bool is1stReadyPos = false;
        public DoublePoint ReadyPos = new DoublePoint();

        public DoublePoint CenterPos = new DoublePoint();

        public DoublePoint WorkCenter = new DoublePoint(0, 0);

        private AlignMethod mAlignMethod;

        public PageList PageList;

        public panJobType2()
        {
            // logger.SendMsg("panJobType2()");

            InitializeComponent();

            Global.ChangeDaekhonControlColor(this.Controls, typeof(YujinTechnology.ComboBox), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(KeypadEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(NumberEdit), System.Drawing.Color.FromArgb(80, 160, 255));
            Global.ChangeDaekhonControlColor(this.Controls, typeof(LEDLabel), System.Drawing.Color.FromArgb(80, 160, 255));

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

        public void btnSave_Click(object sender, EventArgs e)
        {
            SetGrid2Value();

            edLaserPower.Apply();
            edPulsePitch.Apply();

            edThickness.Apply();
            edZOffset.Apply();

            edXCount.Apply();
            edYCount.Apply();
            edGapX.Apply();
            edGapY.Apply();
            edManualShiftX.Apply();
            edManualShiftY.Apply();
            edGlassSizeX.Apply();
            edGlassSizeY.Apply();

            Table.SaveJobFile();

            YujinTechnology.StringList ss = LaserProject.Model2.ToStringList();

            GetWorkCenter(0);

            CodeSite.SendMsg("");
            CodeSite.SendMsg(String.Format("    {0}.Type2.SaveJobFile()", Table.TableNo, Table.TableNo));
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

        public void EnableControl(bool bEnabled)
        {
            Cad2.Enabled = bEnabled;
            edLaserPower.Enabled = bEnabled;
            edPulsePitch.Enabled = bEnabled;
            cbStartPoint.Enabled = bEnabled;

            edManualShiftX.Enabled = bEnabled;
            edManualShiftY.Enabled = bEnabled;

            edGlassSizeX.Enabled = bEnabled;
            edGlassSizeY.Enabled = bEnabled;

            edThickness.Enabled = bEnabled;

            dataGridView2.Enabled = bEnabled;

            ledSortMethod1.Enabled = bEnabled;
            ledSortMethod2.Enabled = bEnabled;  
            ledSortMethod3.Enabled = bEnabled;   
            ledSortMethod4.Enabled = bEnabled;  

            edXCount.Enabled = bEnabled;
            edYCount.Enabled = bEnabled;
            edGapX.Enabled = bEnabled;
            edGapY.Enabled = bEnabled;

            cbCellIndex.Enabled = bEnabled;

            btnMoveAlign1Pos.Enabled = bEnabled;
            btnMoveAlign2Pos.Enabled = bEnabled;
            btnMoveAlign3Pos.Enabled = bEnabled;
            btnMoveAlign4Pos.Enabled = bEnabled;

            btnMoveUp.Enabled = bEnabled;
            btnMoveDown.Enabled = bEnabled;

            edZOffset.Enabled = bEnabled;

            chkAlignUse.Enabled = bEnabled;
            rdoAlign2P_1_2.Enabled = bEnabled;
            rdoAlign2P_1_3.Enabled = bEnabled;
            rdoAlign2P_1_4.Enabled = bEnabled;
            rdoAlign4P.Enabled = bEnabled;

            btnApply.Enabled = bEnabled;
            btnSave.Enabled = bEnabled;
            btnCancel.Enabled = bEnabled;
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

        public bool AAA(int Index)
        {
            bool Result = false;
            foreach (Control control in panel2.Controls)
            {
                if (control is LEDLabel ledLabel)
                {
                    // Text 속성이 찾고자 하는 searchText와 일치하는지 확인
                    if (ledLabel.Text == String.Format("{0}", Index))
                    {
                        // Value 속성을 반환 (Value 타입에 따라 변환 필요)
                        Result = ledLabel.LED.Value; // 만약 Value가 int가 아닌 다른 타입이면, 적절히 변환
                        break;
                    }
                }
            }

            Result = true;
            return Result;
        }

        public void CreateLayerName(ztCadLayerList srcList, ztCadLayerList destList, int Index)
        {
            int nIndex = 0;
            ztCadLayer newLayer;
            destList.Clear();
            for (nIndex = 0; nIndex < srcList.Count; nIndex++)
            {
                newLayer = destList.Add();
                newLayer.Name = srcList[nIndex].Name;
                newLayer.Desc = srcList[nIndex].Desc;
                newLayer.Visible = srcList[nIndex].Visible;
                newLayer.Locked = srcList[nIndex].Locked;
                newLayer.Transparency = srcList[nIndex].Transparency;
                newLayer.Lineweight = srcList[nIndex].Lineweight;
                newLayer.ColorIndex = srcList[nIndex].ColorIndex;
                newLayer.IsFrozen = srcList[nIndex].IsFrozen;
            }

            for (nIndex = 0; nIndex < destList.Count; nIndex++)
            {
                destList[nIndex].Desc = String.Format("{0}", destList[nIndex].Name);
                destList[nIndex].Name = String.Format("{0}", Index * 100 + nIndex);
            }
        }

        public void CreateLayerName(LayerCollection srcList, ztCadLayerList destList, int Index)
        {
            int nIndex = 0;
            ztCadLayer newLayer;
            destList.Clear();
            for (nIndex = 0; nIndex < srcList.Count; nIndex++)
            {
                if (srcList[nIndex].Used)
                {
                    newLayer = destList.Add();
                    newLayer.Name = srcList[nIndex].Name;
                    newLayer.Desc = String.Format("{0}", Index * 100 + nIndex);
                    newLayer.Visible = true;
                    newLayer.Locked = false;
                    newLayer.Transparency = 0;
                    newLayer.Lineweight = 0;
                    newLayer.szColor = srcList[nIndex].szColor;
                    newLayer.IsFrozen = false;
                }
            }
        }

        public void ChangeLayerName(ztMarkPageList markPageList, ztCadLayerList List)
        {
            int nPageIndex = 0;
            ztMarkPage markPage;
            ztMarkData markData;

            for (nPageIndex = 0; nPageIndex < markPageList.Count; nPageIndex++)
            {
                markPage = markPageList[nPageIndex];

                for (int nIndex = 0; nIndex < markPage.Count; nIndex++)
                {
                    markData = markPage[nIndex];

                    for (int ii = 0; ii < List.Count; ii++)
                    {
                        if (markData.LayerName.ToLower() == List[ii].Desc.ToLower())
                        {
                            markData.LayerName = List[ii].Name;
                            break;
                        }
                    }
                }
            }
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

        private void ledSortMethod1_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = true;
            ledSortMethod2.LED.Value = false;
            ledSortMethod3.LED.Value = false;
            ledSortMethod4.LED.Value = false;

            LaserProject.Model2.SortMethod = SortMethod.Method1;

            btnApply.PerformClick();
        }

        private void ledSortMethod2_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = false;
            ledSortMethod2.LED.Value = true;
            ledSortMethod3.LED.Value = false;
            ledSortMethod4.LED.Value = false;

            LaserProject.Model2.SortMethod = SortMethod.Method2;

            btnApply.PerformClick();
        }

        private void ledSortMethod3_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = false;
            ledSortMethod2.LED.Value = false;
            ledSortMethod3.LED.Value = true;
            ledSortMethod4.LED.Value = false;

            LaserProject.Model2.SortMethod = SortMethod.Method3;

            btnApply.PerformClick();
        }

        private void ledSortMethod4_Click(object sender, EventArgs e)
        {
            ledSortMethod1.LED.Value = false;
            ledSortMethod2.LED.Value = false;
            ledSortMethod3.LED.Value = false;
            ledSortMethod4.LED.Value = true;

            LaserProject.Model2.SortMethod = SortMethod.Method4;

            btnApply.PerformClick();
        }

        public void GetWorkCenter(int APageIndex)
        {
            GetPageData();

            double xShift = 0.0, yShift = 0.0;
            if (edGlassSizeX.Value > (PageList.Width))
            {
                xShift = (edGlassSizeX.Value - PageList.Width) / 2.0;
            };

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
            YujinTechnology.StringList szList1 = new YujinTechnology.StringList();
            YujinTechnology.StringList szList2 = new YujinTechnology.StringList();

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

        public void MakeNewLayer()
        {
            ztCadLayerList list = new ztCadLayerList();
            LayerInfo layerInfo;

            LaserProject.Model2.Layers.Clear();

            Table.JobInfo.Type2.Cad2.GetLayers(list);

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

        public void GetReadyPos()
        {
            is1stReadyPos = true;

            /*
             * 현재 도면의 Min, Max..
             */
            DoublePoint tempReadyPos = new DoublePoint(0, 0);

            SetGrid2Value();

            double offsetX = WorkCenter.x - CenterPos.x;
            double offsetY = WorkCenter.y + CenterPos.y;

            if (Auto.btnLaserRun.LED.Value)
            {
                offsetX += Common.edTable2NozzleXOffset.Value;
                offsetY += Common.edTable2NozzleYOffset.Value;
            }

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                if (LaserProject.Model2.Layers[nIndex].Used)
                {
                    cad2Data.Clear();
                    Cad2.CurLayerName = LaserProject.Model2.Layers[nIndex].Name;
                    Cad2.GetPage(cad2Data);

                    var pMarkPage = cad2Data;

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

            cad2Data.Clear();
            Cad2.CurLayerName = "";
            Cad2.GetPage(cad2Data);
        }

        //
        public void MakeMotionFile(TableNo tableNo, int ACellIndex, double Angle, double shiftX, double shiftY, bool LaserRun)
        {
            GetWorkCenter(ACellIndex);

            YujinTechnology.StringList szList = new YujinTechnology.StringList();

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

     //       SetGrid2Value();

            Cad2.Open(Table.GetModelPath() + lblDxfPath.Text);
            SetGrid2Value();
            Cad2.Rotate(CenterPos.x, CenterPos.y, Angle);

            int nIndex = 0;
            for (nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                if (LaserProject.Model2.Layers[nIndex].Used)
                {
                    cad2Data.Clear();
                    Cad2.CurLayerName = LaserProject.Model2.Layers[nIndex].Name;
                    Cad2.GetPage(cad2Data);

                    if (cad2Data.Count <= 0) continue;

                    szList.Add("");
                    szList.Add(String.Format("Open Prog {0}", nIndex + 100 * (int)tableNo));

                    szList.Add("Linear");
                    szList.Add("ABS");
                    szList.Add("Frax(X,Y)");

              //      cad2Data.Rotate(CenterPos.x, CenterPos.y, Angle);
                    
                    var pMarkPage = cad2Data;

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

            Cad2.CurLayerName = "";

            String szStr = String.Format("{0}Program{1}.pmc", yjCommon.AppPath(), (int)tableNo);
            szList.SaveToFile(szStr);
            szList.Clear();
        }

        /*
        * 달리 방법이 없네..
        */
        public void SetGrid2Value()
        {
            if ((dataGridView2.Rows.Count - 1) != LaserProject.Model2.Layers.Count) return;

            for (int nRowIndex = 0; nRowIndex < LaserProject.Model2.Layers.Count; nRowIndex++)
            {
                if (dataGridView2.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "true")
                {
                    LaserProject.Model2.Layers[nRowIndex].Used = true;
                }
                else
                if (dataGridView2.Rows[nRowIndex].Cells[2].Value.ToString().ToLower() == "false")
                {
                    LaserProject.Model2.Layers[nRowIndex].Used = false;
                }

                // Tool
                if (dataGridView2.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "scanner")
                {
                    LaserProject.Model2.Layers[nRowIndex].Tool = Tool.Scanner;
                }
                else
                if (dataGridView2.Rows[nRowIndex].Cells[3].Value.ToString().ToLower() == "nozzle")
                {
                    LaserProject.Model2.Layers[nRowIndex].Tool = Tool.Nozzle;
                }

                // Direction
                if (dataGridView2.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "ccw")
                {
                    LaserProject.Model2.Layers[nRowIndex].Direction = Direction.CCW;
                }
                else
                if (dataGridView2.Rows[nRowIndex].Cells[4].Value.ToString().ToLower() == "cw")
                {
                    LaserProject.Model2.Layers[nRowIndex].Direction = Direction.CW;
                }

                LaserProject.Model2.Layers[nRowIndex].LaserPower = yjCommon.StrToDoubleDef(dataGridView2.Rows[nRowIndex].Cells[4].Value.ToString(), 0.0);
                LaserProject.Model2.Layers[nRowIndex].ZOffset = yjCommon.StrToDoubleDef(dataGridView2.Rows[nRowIndex].Cells[5].Value.ToString(), 0.0);
            }

            IntPtr hEnt = IntPtr.Zero;
            int nIndex;

            // 속성을 변경
            for (nIndex = 0; nIndex < LaserProject.Model2.Layers.Count; nIndex++)
            {
                if (LaserProject.Model2.Layers[nIndex].Used)
                {
                    /* Laser단위로 설정하고..
                     * Entity를 불러들여 속성을 변경한다.
                     * Direction, StartPoint..
                     */

                    Cad2.CurLayerName = LaserProject.Model2.Layers[nIndex].Name;

                    hEnt = Cad2.GetFirstEntity(false);
                    while (hEnt != IntPtr.Zero)
                    {
                        int nEntType = Lcad.PropGetInt(hEnt, Lcad.LC_PROP_ENT_TYPE);
                        if (nEntType == Lcad.LC_ENT_POLYLINE)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_PLINE_CW);
                            bool CCWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_PLINE_CCW);

                            if ((LaserProject.Model2.Layers[nIndex].Direction == Direction.CW) && CCWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            else
                            if ((LaserProject.Model2.Layers[nIndex].Direction == Direction.CCW) && CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            Lcad.EntUpdate(hEnt);

                            Cad2.SetStartPoint(hEnt, (StartPoint)cbStartPoint.ItemIndex);
                            Lcad.EntUpdate(hEnt);
                        }
                        else
                        if (nEntType == Lcad.LC_ENT_CIRCLE)
                        {
                            bool CWDir = Lcad.PropGetBool(hEnt, Lcad.LC_PROP_CIRCLE_DIRCW);

                            if ((LaserProject.Model2.Layers[nIndex].Direction == Direction.CW) && !CWDir)
                            {
                                Lcad.EntReverse(hEnt);
                            }
                            else
                            if ((LaserProject.Model2.Layers[nIndex].Direction == Direction.CCW) && CWDir)
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

                        hEnt = Cad2.GetNextEntity(false, hEnt);
                    }
                }
            }

            Cad2.CurLayerName = "";
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if ((LaserProject != null) && (LaserProject.Model2.Layers.Count > 0))
            {
                int bRGB, iColor, R, G, B;

                if (e.RowIndex < LaserProject.Model2.Layers.Count)
                {
                    if (dataGridView.Columns[e.ColumnIndex].Name == "Color")
                    {
                        String szColor = LaserProject.Model2.Layers[e.RowIndex].szColor;

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
            Cad2.CurLayerName = "";
            cad2Data.Clear();
            Cad2.GetPage(cad2Data);
        }

        private bool MoveUp(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex <= 0 || ASelectedIndex >= dataGridView2.Rows.Count) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView2.Rows[ASelectedIndex];
            dataGridView2.Rows.RemoveAt(ASelectedIndex);
            dataGridView2.Rows.Insert(ASelectedIndex - 1, selectedRow);

            // 선택 상태 유지
            dataGridView2.ClearSelection();
            dataGridView2.Rows[ASelectedIndex - 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0) return;

            int nIndex = dataGridView2.SelectedRows[0].Index;

            if (MoveUp(nIndex))
            {
                LaserProject.Model2.Layers.MoveUp(nIndex);
                DisplayLayerInfo();
                dataGridView2.Rows[nIndex - 1].Selected = true;

                // forDebug
                //logger.SendMsg("");
                //for (int i = 0; i < LaserProject.Model2.Layers.Count; i++)
                //{
                //    logger.SendMsg($"{LaserProject.Model2.Layers[i]}");
                //}
            }
        }

        private bool MoveDown(int ASelectedIndex)
        {
            // 선택된 행이 없는 경우
            if (ASelectedIndex < 0 || ASelectedIndex >= dataGridView2.Rows.Count - 2) return false;

            // 행 이동 처리
            DataGridViewRow selectedRow = dataGridView2.Rows[ASelectedIndex];
            dataGridView2.Rows.RemoveAt(ASelectedIndex);
            dataGridView2.Rows.Insert(ASelectedIndex + 1, selectedRow);

            // 선택 상태 유지
            dataGridView2.ClearSelection();
            dataGridView2.Rows[ASelectedIndex + 1].Selected = true;

            return true; // 성공적으로 이동
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0) return;

            int nIndex = dataGridView2.SelectedRows[0].Index;

            if (MoveDown(nIndex))
            {
                LaserProject.Model2.Layers.MoveDown(nIndex);
                DisplayLayerInfo();
                dataGridView2.Rows[nIndex + 1].Selected = true;
            }
        }

        public void AllPrint()
        {
            //logger.SendMsg("All2");
            //for (int nIndex = 0; nIndex < cad2DataList.Count; nIndex++)
            //{
            //    logger.SendMsg(String.Format("#1 {0}, {1}, {2}, {3}, {4}", nIndex,
            //                                    cad2DataList[nIndex].Align1X,
            //                                    cad2DataList[nIndex].Align1Y,
            //                                    cad2DataList[nIndex].Align2X,
            //                                    cad2DataList[nIndex].Align2Y));

            //    logger.SendMsg(String.Format("#2 {0}, {1}, {2}, {3}, {4}", nIndex,
            //                                    cad2DataList[nIndex].Align3X,
            //                                    cad2DataList[nIndex].Align3Y,
            //                                    cad2DataList[nIndex].Align4X,
            //                                    cad2DataList[nIndex].Align4Y));
            //}
        }
        public void ChangeLanguageEnglish()
        {
            tabPage1.Text = Global.iniEng.ReadString("panJobType2", "tabPage1.Text", "Machining Properties");
            tabPage3.Text = Global.iniEng.ReadString("panJobType2", "tabPage3.Text", "Vision Align");
            btnSave.Text = Global.iniEng.ReadString("panJobType2", "btnSave.Text", "Save");
            btnCancel.Text = Global.iniEng.ReadString("panJobType2", "btnCancel.Text", "Cancel");
            btnApply.Text = Global.iniEng.ReadString("panJobType2", "btnApply.Text", "Apply");
        }

        public void ChangeLanguageKorea()
        {
            tabPage1.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType2", "tabPage1.Text");
            tabPage3.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType2", "tabPage3.Text");
            btnSave.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType2", "btnSave.Text");
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType2", "btnCancel.Text");
            btnApply.Text = Global.GetIniLanguageValue(Global.iniKor, "panJobType2", "btnApply.Text");
        }

        public void ChangeLanguageVietnam()
        {
            tabPage1.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType2", "tabPage1.Text");
            tabPage3.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType2", "tabPage3.Text");
            btnSave.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType2", "btnSave.Text");
            btnCancel.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType2", "btnCancel.Text");
            btnApply.Text = Global.GetIniLanguageValue(Global.iniVie, "panJobType2", "btnApply.Text");
        }

        private void btnMoveAlign1Pos_Click(object sender, EventArgs e)
        {
            if (cbCellIndex.ItemIndex < 0)
            {
                yjCommon.Inform("이동 하고자 하는 CellIndex를 선택합니다.", "확인");
                return;
            }

            if (yjCommon.Confirm("Align1위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                GetWorkCenter(cbCellIndex.SelectedIndex);
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
        }

        private void btnMoveAlign2Pos_Click(object sender, EventArgs e)
        {
            if (cbCellIndex.ItemIndex < 0)
            {
                yjCommon.Inform("이동 하고자 하는 CellIndex를 선택합니다.", "확인");
                return;
            }

            if (yjCommon.Confirm("Align2위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                GetWorkCenter(cbCellIndex.SelectedIndex);
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
        }

        private void btnMoveAlign3Pos_Click(object sender, EventArgs e)
        {
            if (cbCellIndex.ItemIndex < 0)
            {
                yjCommon.Inform("이동 하고자 하는 CellIndex를 선택합니다.", "확인");
                return;
            }

            if (yjCommon.Confirm("Align3위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                GetWorkCenter(cbCellIndex.SelectedIndex);
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
        }

        private void btnMoveAlign4Pos_Click(object sender, EventArgs e)
        {
            if (cbCellIndex.ItemIndex < 0)
            {
                yjCommon.Inform("이동 하고자 하는 CellIndex를 선택합니다.", "확인");
                return;
            }

            if (yjCommon.Confirm("Align4위치로 이동합니다.", "확인") == DialogResult.Yes)
            {
                GetWorkCenter(cbCellIndex.SelectedIndex);
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
        }

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
            if (Cad2.Open(""))
            {
                Cad2.ZoomExtend();
                Cad2.ZoomScale(0.8);

                Cad2.Visible = true;

                szFileName = yjCommon.ExtractFileName(Cad2.FileName);

                String szNewPath = String.Format("{0}{1}", Table.GetModelPath(), szFileName);

                if (Cad2.FileName != szNewPath)
                {
                    System.IO.File.Copy(Cad2.FileName, szNewPath, true);
                }

                lblDxfPath.Text = szFileName;

                if (Cad2.Open(szNewPath))
                {
                    Cad2.ZoomExtend();
                    Cad2.ZoomScale(0.8);
                }

                CheckLayerInfo();
                DisplayLayerInfo();

                if (Table.JobInfo.Type1.Cad1.Open(szNewPath))
                {
                    Table.JobInfo.Type1.Cad1.ZoomExtend();
                    Table.JobInfo.Type1.Cad1.ZoomScale(0.8);
                }

                Table.JobInfo.Type1.lblDxfPath.Text = szFileName;
                Table.JobInfo.Type1.CheckLayerInfo();
                Table.JobInfo.Type1.DisplayLayerInfo();
            }
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
            Table.JobInfo.Type1.btnUse.LED.Value = false;
            Table.JobInfo.Type2.btnUse.LED.Value = true;
            Table.JobInfo.Type3.btnUse.LED.Value = false;
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
            edManualShiftX.Cancel();
            edManualShiftY.Cancel();
            edGlassSizeX.Cancel();
            edGlassSizeY.Cancel();
        }

        private void chkShowJumpline_CheckedChanged(object sender, EventArgs e)
        {
            Cad2.ShowJumpLine = chkShowJumpline.Checked;
        }
    }
}
