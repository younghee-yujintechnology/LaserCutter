using yjTech;
using Raize.CodeSiteLogging;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class panManualPowermeter : UserControl, IDisposable
    {
        CodeSiteLogger logger = new CodeSiteLogger();

        public panManualPowermeter()
        {
            InitializeComponent();

            logger.Category = "Manual.PowerMeter";
        }
    }
}
