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

        public void ClearControlValue()
        {
            lblDxfPath.Text = "";
            Cad4.Clear();
            Cad4.ReDraw();

            edLaserPower.Value = 0.0;
            edPulsePitch.Value = 0.0;
            //  dataGridView1.IEnabled = bEnabled;

            edZOffset.Value = 0.0;
            edThickness.Value = 0.0;

            btnUse.LED.Value = false;

            dataGridView4.Rows.Clear();
        }


        public void EnableControl(bool bEnabled)
        {
            Cad4.Enabled = bEnabled;

            btnSave.Enabled = bEnabled;
            btnCancel.Enabled = bEnabled;
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


        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.Type1.btnUse.LED.Value = false;
            Table.Type2.btnUse.LED.Value = false;
            Table.Type3.btnUse.LED.Value = false;
            Table.Type4.btnUse.LED.Value = true;
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

        public void GetWorkCenter(int APageIndex)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckLayerInfo();
            SetGrid4Value();

            edLaserPower.Apply();
            edPulsePitch.Apply();

            edThickness.Apply();
            edZOffset.Apply();

            edGuideLength.Apply();
            edGuidePitch.Apply();

            edXLength.Apply();
            edXPitch.Apply();   

            edYLength.Apply();
            edYPitch.Apply();

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            edLaserPower.Cancel();
            edPulsePitch.Cancel();

            edThickness.Cancel();
            edZOffset.Cancel();
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
    }
}
