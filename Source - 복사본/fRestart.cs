using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class frmRestart : Form
    {
        public bool Start = false;
        public bool Stop = false;

        int ii = 0;

        public frmRestart()
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

        #region private static frmRunStatus staticForm;
        private static frmRestart staticForm;

        public static frmRestart StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmRestart();
                }
                return staticForm;
            }
        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start = true;
            Stop = false;

            AutoThread.Enabled = false;

            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Start = false;
            Stop = true;

            AutoThread.Enabled = false;

            Close();
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

        private void frmTable1Restart_Load(object sender, EventArgs e)
        {
        }
    }
}
