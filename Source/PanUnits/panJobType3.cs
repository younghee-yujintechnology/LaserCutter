
using System;
using System.Windows.Forms;

using Raize.CodeSiteLogging;
using yjTech;

namespace LaserCutter
{
    public partial class panJobType3 : UserControl
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public LaserProject LaserProject = null;

        public panAuto Auto = null;
        public panAutoMenu AutoMenu = null;
        public panConfigCommon Common = null;

        public panTable Table;

        public ztCad Cad3;
        public ztMarkPage cad3Data;

        public panJobType3()
        {
            InitializeComponent();

            InitDataGridViewControl();
            InitializeControl();
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
            dataGridView3.Columns["Name"].Width = 250;

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

            // 6. power.offset
            dataGridView3.Columns.Add("laser.power\r\noffset", "laser.power\r\noffset");
            dataGridView3.Columns["laser.power\r\noffset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["laser.power\r\noffset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["laser.power\r\noffset"].Width = 100;

            // 7. z.offset
            dataGridView3.Columns.Add("z.offset", "z.offset");
            dataGridView3.Columns["z.offset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["z.offset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["z.offset"].Width = 75;

            // 8. Pitch.offset
            dataGridView3.Columns.Add("pulse.pitch\r\noffset", "pulse.pitch\r\noffset");
            dataGridView3.Columns["pulse.pitch\r\noffset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["pulse.pitch\r\noffset"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["pulse.pitch\r\noffset"].Width = 100;

            dataGridView3.AllowUserToResizeRows = false;
        }
        #endregion

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

        public void btnApply_Click(object sender, System.EventArgs e)
        {
            ;
        }

        public void CreateUserCell()
        {
        }

        public void CheckLayerInfo()
        {
        }

        public void GetWorkCenter(int APageIndex)
        {
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

        public void UpdateCellTypeUI(bool bCell)
        {
            lblLabelSize.Visible = bCell;
            edCellHeight.Visible = bCell;
            edCellWidth.Visible = bCell;
        }

        private void btnUse_Click(object sender, System.EventArgs e)
        {
            Table.Type1.btnUse.LED.Value = false;
            Table.Type2.btnUse.LED.Value = false;
            Table.Type3.btnUse.LED.Value = true;
            Table.Type4.btnUse.LED.Value = false;
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


        private void btnSave_Click(object sender, System.EventArgs e)
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

            yjTech.StringList ss = LaserProject.Model3.ToStringList();

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
    }
}
