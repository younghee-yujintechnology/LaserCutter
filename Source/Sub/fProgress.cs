using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using YujinTechnology;

namespace LaserCutter
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();

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

        private void frmProgress_Load(object sender, EventArgs e)
        {

        }

    }
}
