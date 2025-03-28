

using System;
using System.Windows.Forms;

using DaekhonSystem;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panManual : UserControl
    {
        public panManualMotion Motion;

        public panManual()
        {
            CodeSite.SendMsg("panManual.Create()");

            InitializeComponent();

            staticInstance = this;

            Motion = new panManualMotion();
            tabPage1.Controls.Add(Motion);
            Motion.Dock = DockStyle.Fill;
        }

        #region staticInstance
        private static panManual staticInstance;
        public static panManual StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panManual();
                }
                return staticInstance;
            }
        }
        #endregion

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panManual_Load(object sender, EventArgs e)
        {
        }
    }
}
