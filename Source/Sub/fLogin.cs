using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DaekhonSystem;

namespace LaserCutter
{
    public enum UserAuthority
    {
        //Super, Operator, Technical,
        Operator, Technical, Super, UnKnown
    }

    public partial class frmLogin : Form
    {
        string strCulture;
         public frmLogin(string strCulture)
        {
            InitializeComponent();
            this.strCulture = strCulture;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

            //
            // if (!cMain.Data.User.IsLoggin) cMain.Sequecne.GetUser.LogOut();
            //
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            //if (!cMain.Data.User.IsLoggin)
            //{
            //    Common.Inform("사용자 편집 실패", "LogIn 후 사용 가능합니다.");

            //    return;
            //}

            //if (false == obj.IsSueper())
            //{
            //    Common.Inform("권한없음", "SuperVisior 권한자만 사용 가능합니다.");

            //    return;
            //}

            //frmUserSetting frmUserSetting = new frmUserSetting();

            //if (DialogResult.OK == frmUserSetting.ShowDialog())
            //{
            //    obj.SaveUsers();
            //}
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;

            //if (cbUserName.SelectedIndex < 0)
            //{
            //    dkCommon.Warning("로그인 실패", "사용자 이름을 선택해 주세요!");
            //}
            //else if (tbPass.Text.Length == 0)
            //{
            //    dkCommon.Warning("로그인 실패", "패스워드를 입력해 주세요!");
            //}
            //else 
            //if (false == obj.Loggin(cbUserName.Text.ToString(), tbPass.Text.ToString()))
            //{
            //    dkCommon.Warning("로그인 실패", "로그인 정보가 일치 하지 않습니다!");
            //}

            //else
            //{
            //    this.DialogResult = DialogResult.OK;
            //}
        }

        private void cbUserMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int nMode = cbUserMode.SelectedIndex;
            //List<string> lstName = new List<string>();
            //if (nMode == (int)UserAuthority.Operator)
            //{
            //    lstName = obj.GetUserName(UserAuthority.Operator);
            //}
            //else if (nMode == (int)UserAuthority.Technical)
            //{
            //    lstName = obj.GetUserName(UserAuthority.Technical);
            //}
            //else if (nMode == (int)UserAuthority.Super)
            //{
            //    lstName = obj.GetUserName(UserAuthority.Super);
            //}


            //cbUserName.Items.Clear();
            //int Cnt = lstName.Count;
            //for (int i = 0; i < Cnt; i++)
            //{
            //    cbUserName.Items.Add(lstName[i]);
            //}
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmUserSetting frmUserSetting = new frmUserSetting();
            if (frmUserSetting.ShowDialog() == DialogResult.OK)
            {
            }
        }
        public void ChangeLanguageEnglish()
        {
            LabelUserMode.Text = Global.iniEng.ReadString("fLogin", "LabelUserMode.Text", "User Mode");
            LabelUserName.Text = Global.iniEng.ReadString("fLogin", "LabelUserName.Text", "User Name");
            LabelPassword.Text = Global.iniEng.ReadString("fLogin", "LabelPassword.Text", "Password");
            btnLogIn.Text = Global.iniEng.ReadString("fLogin", "btnLogIn.Text", "Login");

        }

        public void ChangeLanguageKorea()
        {
            LabelUserMode.Text = Global.GetIniLanguageValue(Global.iniKor, "fLogin", "LabelUserMode.Text");
            LabelUserName.Text = Global.GetIniLanguageValue(Global.iniKor, "fLogin", "LabelUserName.Text");
            LabelPassword.Text = Global.GetIniLanguageValue(Global.iniKor, "fLogin", "LabelPassword.Text");
            btnLogIn.Text = Global.GetIniLanguageValue(Global.iniKor, "fLogin", "btnLogIn.Text");

        }
        public void ChangeLanguageVietnam()
        {
            LabelUserMode.Text = Global.GetIniLanguageValue(Global.iniVie, "fLogin", "LabelUserMode.Text");
            LabelUserName.Text = Global.GetIniLanguageValue(Global.iniVie, "fLogin", "LabelUserName.Text");
            LabelPassword.Text = Global.GetIniLanguageValue(Global.iniVie, "fLogin", "LabelPassword.Text");
            btnLogIn.Text = Global.GetIniLanguageValue(Global.iniVie, "fLogin", "btnLogIn.Text");
        }
    }
}
