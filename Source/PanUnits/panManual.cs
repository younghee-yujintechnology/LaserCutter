

using System;
using System.Windows.Forms;

using yjTech;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panManual : UserControl
    {
        public panManualMotion Motion;

        public panManualCarbide Laser;
        public panManualPowermeter PowerMeter;

        public panManualADV ADV;
        public panManualLight Light;

        public panManual()
        {
            CodeSite.SendMsg("panManual.Create()");

            InitializeComponent();

            staticInstance = this;

            Motion = new panManualMotion();
            tabPage1.Controls.Add(Motion);
            Motion.Dock = DockStyle.Fill;

            Laser = new panManualCarbide(this);
            Laser.Auto = panAuto.StaticInstance;
            tabPage2.Controls.Add(Laser);
            Laser.Location = new System.Drawing.Point(0, 0);

            PowerMeter = new panManualPowermeter();

            tabPage2.Controls.Add(PowerMeter);
            PowerMeter.Location = new System.Drawing.Point(Laser.Location.X + Laser.Size.Width, 0);

            ADV = new panManualADV();
            tabPage3.Controls.Add(ADV);

            Light = new panManualLight();
            tabPage3.Controls.Add(Light);

            ADV.Location = new System.Drawing.Point(0, 0);
            Light.Location = new System.Drawing.Point(ADV.Location.X + ADV.Size.Width, 0);

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
