using LaserCutter;
using System;

using System.Drawing;
using System.IO;

using System.Windows.Forms;

using DaekhonSystem;

namespace LaserCutter
{
    public partial class frmSelectJob : Form
    {

        public panJobFile JobFile;

        public TableNo TableNo;
        public frmSelectJob()
        {
            InitializeComponent();

            FormClosing += _FormClosing;

            MaximizeBox = false;
            MinimizeBox = false;

            JobFile = panJobFile.StaticInstance;
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
        private static frmSelectJob staticForm;
        public static frmSelectJob StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmSelectJob();
                }
                return staticForm;
            }
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            JobFile.AddRecentList(lvRecentModel, GroupName, ModelName);
            JobFile.SaveRecentList(lvRecentModel, (TableNo)TableNo);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSelectJob_Load(object sender, EventArgs e)
        {
            JobFile.LoadRecentList(lvRecentModel, TableNo);

            LoadModelList();
        }

        #region public void LoadModelList()
        public void LoadModelList()
        {
            tvModel.BeginUpdate();
            tvModel.Nodes.Clear();

            string modelPath = String.Format("{0}Model", dkCommon.AppPath());
            string[] szDirectories = Directory.GetDirectories(modelPath);

            foreach (string szDir in szDirectories)
            {
                string szDirName = Path.GetFileName(szDir);
                TreeNode node = tvModel.Nodes.Add(szDirName);
                node.ImageIndex = 15;
                node.SelectedImageIndex = 16;

                string[] subDirectories = Directory.GetDirectories(szDir);
                foreach (string subDir in subDirectories)
                {
                    string szSubDirName = Path.GetFileName(subDir);
                    string szDBName1 = Path.Combine(szDir, $"{szSubDirName}", $"[{szDirName}][{szSubDirName}][Table1].prj");
                    string szDBName2 = Path.Combine(szDir, $"{szSubDirName}", $"[{szDirName}][{szSubDirName}][Table2].prj");

                    if (File.Exists(szDBName1) && File.Exists(szDBName2))
                    {
                        TreeNode childNode = node.Nodes.Add(szSubDirName);

                        childNode.ImageIndex = 17;
                        childNode.SelectedImageIndex = 17;
                    }
                }

                tvModel.EndUpdate();
            }
        }
        #endregion

        public string GetModelPath()
        {
            return String.Format("{0}Model\\{1}\\{2}\\", dkCommon.AppPath(), GroupName, ModelName);
        }

        private void lvRecentModel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewHitTestInfo hit = lvRecentModel.HitTest(e.Location);
                if (hit.Item != null)
                {
                    string itemText = hit.Item.Text;
                    string subItemText = hit.Item.SubItems[1].Text; // Assuming the row has at least one subitem

                    subItemText = subItemText.Substring(1, subItemText.Length - 2);
                    subItemText = subItemText.Replace("][", "@");

                    string szGroupName = dkCommon.GetWord(subItemText, 0, '@');
                    string szModelName = dkCommon.GetWord(subItemText, 1, '@');

                    String szStr = String.Format("{0}Model\\{1}\\{2}\\", dkCommon.AppPath(), szGroupName, szModelName);
                    if (dkCommon.DirectoryExists(szStr))
                    {
                        GroupName = szGroupName;
                        ModelName = szModelName;
                    }
                    else
                    {
                        dkCommon.Warning("해당 디렉토리가 존재하지 않습니다.", "오류");
                    }
                }
            }
        }

        #region property public string GroupName
        private String mGroupName;
        public string GroupName
        {
            get { return mGroupName; }
            set
            {
                mGroupName = value;
            }
        }
        #endregion

        #region property public string ModelName
        private String mModelName;

        public string ModelName
        {
            get { return mModelName; }
            set
            {
                mModelName = value;
            }
        }
        #endregion

        private void tvModel_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Parent == null)
                {
                    GroupName = e.Node.Text;
                    ModelName = "";
                }
                else
                {
                    GroupName = e.Node.Parent.Text;
                    ModelName = e.Node.Text;
                }
            }
            else
            if (e.Button == MouseButtons.Right)
            {
                // 클릭된 노드를 선택 상태로 변경
                tvModel.SelectedNode = e.Node;
            }
        }

        private void lvRecentModel_DoubleClick(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(GroupName)) && (!string.IsNullOrEmpty(ModelName)))
            {
                btnOK_Click(null, null);
            }
        }

        private void tvModel_DoubleClick(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(GroupName)) && (!string.IsNullOrEmpty(ModelName)))
            {
                btnOK_Click(null, null);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dkCommon.Confirm("최근 List를 삭제 합니다.", "확인") == DialogResult.Yes)
            {
                lvRecentModel.Items.Clear();

                JobFile.SaveRecentList(lvRecentModel, TableNo);
            }
        }

        private void lvRecentModel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (lvRecentModel.SelectedItems.Count > 0))
            {
                if (dkCommon.Confirm("삭제 합니다.", "확인") == DialogResult.Yes)
                {
                    // 선택된 모든 항목 삭제
                    foreach (ListViewItem selectedItem in lvRecentModel.SelectedItems)
                    {
                        lvRecentModel.Items.Remove(selectedItem);
                    }

                    JobFile.SaveRecentList(lvRecentModel, TableNo);
                }
            }
        }
    }
}
