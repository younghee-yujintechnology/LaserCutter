using System;
using System.IO;
using System.Windows.Forms;

using DaekhonSystem;

namespace LaserCutter
{
    public partial class frmGroupName : Form
    {
        public frmGroupName()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String szDir;
            // 특수 문자 공백이 있는지 확인
            if (edName.Text == "")
            {
                dkCommon.Inform("그룹명이 올바르지 않습니다.", "입력 오류");
            };

            // 폴더명 중복 확인
            szDir = String.Format("{0}Model\\{1}", dkCommon.AppPath(), edName.Text);
            if (Directory.Exists(szDir))
            {
                dkCommon.Inform("중복되는 그룹명이 존재합니다.", "입력 오류");
            } 
            else
            {
                DialogResult = DialogResult.OK;
            };
        }

        private void frmGroupName_Shown(object sender, EventArgs e)
        {
            edName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
