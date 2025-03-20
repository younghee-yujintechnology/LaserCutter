using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class frmUserConfirm : Form
    {
        int ii = 0;

        public frmUserConfirm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
    }
}
