using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panManual: UserControl
    {
        public panManual()
        {
            CodeSite.SendMsg("panManual.Create()");

            InitializeComponent();

            staticInstance = this;
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
    }
}
