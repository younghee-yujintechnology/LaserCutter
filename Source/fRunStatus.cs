using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class frmRunStatus : Form
    {
        int ii = 0;

        public bool Abort = false;

        public frmRunStatus()
        {
            InitializeComponent();

            FormClosing += _FormClosing;
        }


        #region private static frmRunStatus staticForm;
        private static frmRunStatus staticForm;

        public static frmRunStatus StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmRunStatus();
                }
                return staticForm;
            }
        }
        #endregion

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void AutoThread_OnExecute(object sender, EventArgs e)
        {
            ii = ii + 1;
            ii = ii % 4;

            switch (ii)
            {
                case 0:
                    lblMessage.ForeColor = Color.Red;
                    break;

                case 1:
                    lblMessage.ForeColor = Color.Yellow;
                    break;

                case 2:
                    lblMessage.ForeColor = Color.Blue;
                    break;

                case 3:
                    lblMessage.ForeColor = Color.Lime;
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Abort = true;
        }
    }
}
