using System;

using System.Windows.Forms;

using yjTech;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panJobType2: UserControl
    {
        public panAuto Auto = null;

        public ztCad Cad2;
        public ztMarkPage cad2Data;

        public panJobType2()
        {
            InitializeComponent();

            InitDataGridViewControl();
            InitializeControl();
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
    }
}
