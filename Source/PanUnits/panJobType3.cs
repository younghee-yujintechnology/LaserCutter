
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

        public void EnableControl(bool bEnabled)
        {
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
    }
}
