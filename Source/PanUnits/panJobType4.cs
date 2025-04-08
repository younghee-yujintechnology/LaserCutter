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
            ColumnCheckBox.ReadOnly = true;
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
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Table.Type1.btnUse.LED.Value = false;
            Table.Type2.btnUse.LED.Value = false;
            Table.Type3.btnUse.LED.Value = false;
            Table.Type4.btnUse.LED.Value = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void bitBtn1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
