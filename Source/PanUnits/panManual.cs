

using System;
using System.Windows.Forms;

using YujinTechnology;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panManual : UserControl
    {
        public panManualMotion Motion;
#if _VERSION1
        public panManualCoherent Laser;
#elif _VERSION2
        public panManualCarbide Laser;
#elif (!_VERSION1 && !_VERSION2)
        public panManualCarbide Laser;
#endif
        public panManualPowermeter PowerMeter;
        public panManualADV ADV;
        public panManualLight Light;

        public panManual()
        {
            CodeSite.SendMsg("panManual.Create()");

            InitializeComponent();

            staticInstance = this;

            Motion = new panManualMotion();

#if _VERSION1 
            Laser = new panManualCoherent(this);            
#elif _VERSION2
 			Laser = new panManualCarbide(this);
#elif (!_VERSION1 && !_VERSION2)
            Laser = new panManualCarbide(this);
#endif   
            Laser.Auto = panAuto.StaticInstance;

            PowerMeter = new panManualPowermeter();
            PowerMeter.Manual = this;

            ADV = new panManualADV();
            Light = new panManualLight();

#if _VERSION1
            Motion.LoadVersion1ChannelInfo();
            Motion.Version1ChannelAssign();
#elif _VERSION2
            Motion.LoadVersion2ChannelInfo();
            Motion.Version2ChannelAssign();
#elif (!_VERSION1 && !_VERSION2)
            Motion.LoadDefaultChannelInfo();
            Motion.DefaultChannelAssign();
#endif   

            Laser.LoadChannelInfo();
            Laser.ChannelAssign();

            tabPage1.Controls.Add(Motion);
            Motion.Dock= DockStyle.Fill;

            tabPage2.Controls.Add(Laser);
            Laser.Location = new System.Drawing.Point(0, 0);

            tabPage2.Controls.Add(PowerMeter);
            PowerMeter.Location = new System.Drawing.Point(Laser.Location.X + Laser.Size.Width, 0);

            tabPage3.Controls.Add(ADV);
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
            if(uiTabControlMenu1.SelectedTab == tabPage1)
            {
                Motion.cbSpeed.SelectedIndex = Global.chSelectSpeed.AsInteger;
            }
        }

        private void panManual_Load(object sender, EventArgs e)
        {
            ADV.propSaver1.LoadProperty();
        }
    }
}
