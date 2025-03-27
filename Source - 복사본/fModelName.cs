using System;
using System.IO;
using System.Windows.Forms;

using YujinTechnology;

namespace LaserCutter
{
    public partial class frmModelName : Form
    {
        private String mGroupName;

        public frmModelName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property 
        /// </summary>
        public string Group
        {
            get
            {
                return mGroupName;
            }

            set
            {
                mGroupName = value;
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            String szDir;
            // 특수 문자 공백이 있는지 확인
            if (edName.Text == "")
            {
                yjCommon.Inform("모델명이 올바르지 않습니다.", "입력 오류");
            };

            // 폴더명 중복 확인
            szDir = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), Group, edName.Text);
            if (Directory.Exists(szDir))
            {
                yjCommon.Inform("중복되는 모델명이 존재합니다.", "입력 오류");
            }
            else
            {
                DialogResult = DialogResult.OK;
            };
        }

        private void frmModelName_Shown(object sender, EventArgs e)
        {
            edName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
