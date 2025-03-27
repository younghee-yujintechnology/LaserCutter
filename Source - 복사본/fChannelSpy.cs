using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Raize.CodeSiteLogging;

using YujinTechnology;

namespace LaserCutter
{
    public partial class frmChannelSpy : Form
    {
        public frmChannelSpy()
        {
            InitializeComponent();

            FormClosing += frmChannelSpy_FormClosing;
        }

        private void frmChannelSpy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide(); 
            }
        }

        private void frmChannelSpy_Load(object sender, EventArgs e)
        {               
            tabControl1.TabIndex = 0;
            tabControl1.Dock = DockStyle.Fill;

            propGridIO.Dock = DockStyle.Fill;
            propGridMotion.Dock = DockStyle.Fill;
            propGridADV.Dock = DockStyle.Fill;
            propGridLaser.Dock = DockStyle.Fill;
            propGridLaser.Dock = DockStyle.Fill;
            propGridConfig.Dock = DockStyle.Fill;
        }

        #region public static frmChannelSpy StaticInstance 
        private static frmChannelSpy staticForm;
        public static frmChannelSpy StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmChannelSpy();
                }
                return staticForm;
            }
        }
        #endregion
    }
}
