using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using yjTech;

namespace LaserCutter
{
    public partial class frmPreview : Form
    {
        public ztCad Cad1;

        public frmPreview()
        {
            InitializeComponent();

            InitializeControl();

            FormClosing += _FormClosing;
        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        #region public static staticForm StaticInstance 
        private static frmPreview staticForm;
        public static frmPreview StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmPreview();
                }
                return staticForm;
            }
        }
        #endregion

        public void InitializeControl()
        {
            Cad1 = new ztCad();

            Cad1.CadStyle.FileTabs = false;
            Cad1.CadStyle.Rulers = true;
            Cad1.CadStyle.Scrolls = true;
            Cad1.CadStyle.StatusBar = true;
            Cad1.CadStyle.ViewTab3D = false;
            Cad1.CadStyle.ViewTabs = false;

            Cad1.Location = new System.Drawing.Point(0, 0);
            Cad1.Size = new System.Drawing.Size(panCad.Width, panCad.Height);

            Cad1.Enabled = true;

            panCad.Controls.Add(Cad1);
        }
    }
}
