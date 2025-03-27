using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using YujinTechnology;
using Raize.CodeSiteLogging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaserCutter
{
    public partial class panJobFile : UserControl
    {
        public panTable Table1;
        public panTable Table2;

        public TableNo TableNo;
        public panJobFile()
        {
            CodeSite.SendMsg("panJobFile.Create()");

            InitializeComponent();

            Table1 = new panTable();
            Table2 = new panTable();

            tabTable1.Controls.Add(Table1);
            tabTable2.Controls.Add(Table2);

            Table1.TableNo = TableNo.Table1;
            Table1.btnOpenJobFile.Enabled = false;
            Table1.btnClose.Enabled = false;

            Table2.TableNo = TableNo.Table2;
            Table2.btnOpenJobFile.Enabled = false;
            Table2.btnClose.Enabled = false;

            tvModel.Nodes.Clear();
            lvRecentModel.Items.Clear();

            staticInstance = this;
        }

        #region staticInstance
        private static panJobFile staticInstance;
        public static panJobFile StaticInstance
        {
            get
            {
                if (staticInstance == null || staticInstance.IsDisposed)
                {
                    staticInstance = new panJobFile();
                }
                return staticInstance;
            }
        }
        #endregion

        #region public void LoadModelList()
        public void LoadModelList()
        {
            tvModel.BeginUpdate();
            tvModel.Nodes.Clear();

            string modelPath = String.Format("{0}Model", yjCommon.AppPath());
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

        #region private void LoadRecentList(string filePath)
        /*
         * Load.RecentList
         */
        public void LoadRecentList(System.Windows.Forms.ListView listview, TableNo tableNo)
        {
            String szStr = String.Format("{0}RecentList{1}.txt", yjCommon.AppPath(), (int)tableNo);
            LoadRecentList(listview, szStr);
        }

        public void LoadRecentList(System.Windows.Forms.ListView listview, string filePath)
        {
            listview.Items.Clear();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int count = 1;

                    while ((line = reader.ReadLine()) != null)
                    {
                        ListViewItem item = new ListViewItem(count.ToString()); // 첫 번째 열: Count
                        item.SubItems.Add(line); // 두 번째 열: 파일 내용
                        listview.Items.Add(item);

                        count++; // Count 증가
                    }
                }

                // 모든 항목의 번호를 갱신
                for (int i = 0; i < listview.Items.Count; i++)
                {
                    listview.Items[i].Text = (i + 1).ToString();
                }
            }
        }
        #endregion

        #region private void SaveRecentList(string filePath)
        /*
         * Save.RecentList
         */
        public void SaveRecentList(System.Windows.Forms.ListView listview, TableNo tableNo)
        {
            String szStr = String.Format("{0}RecentList{1}.txt", yjCommon.AppPath(), (int)tableNo);

            SaveRecentList(listview, szStr);
        }

        public void SaveRecentList(System.Windows.Forms.ListView listview, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (ListViewItem item in listview.Items)
                {
                    writer.WriteLine(item.SubItems[1].Text);
                }
            }
        }
        #endregion

        #region public void AddRecentList(String aGroupName, String aModelName)
        public void AddRecentList()
        {
            if ((!GroupName.IsNullOrEmpty()) && (!ModelName.IsNullOrEmpty()))
            {
                AddRecentList(lvRecentModel, GroupName, ModelName);
                SaveRecentList(lvRecentModel, (TableNo)TabControl1.SelectedIndex + 1);
            }
        }

        public void AddRecentList(System.Windows.Forms.ListView listview, String aGroupName, String aModelName)
        {
            string itemText = $"[{aGroupName}][{aModelName}]";

            // 기존에 동일한 항목이 있는지 확인하고 있다면 삭제
            foreach (ListViewItem item in listview.Items)
            {
                if (item.SubItems[1].Text == itemText)
                {
                    listview.Items.Remove(item);
                    break;
                }
            }

            // 첫 번째 컬럼에는 현재 Count, 두 번째 컬럼에는 "[aGroupName][aModelName]"을 설정
            ListViewItem newItem = new ListViewItem((listview.Items.Count + 1).ToString());
            newItem.SubItems.Add(itemText);

            // 새로운 항목을 리스트의 제일 위에 추가
            listview.Items.Insert(0, newItem);

            // 모든 항목의 번호를 갱신
            for (int i = 0; i < listview.Items.Count; i++)
            {
                listview.Items[i].Text = (i + 1).ToString();
            }
        }
        #endregion

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

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            String szDir;
            frmGroupName frmGroupName = new frmGroupName();

            frmGroupName.Text = "추가할 그룹의 이름을 입력합니다.";
            frmGroupName.edName.Text = "새 그룹";

            frmGroupName.StartPosition = FormStartPosition.CenterScreen;
            if (frmGroupName.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    szDir = String.Format("{0}Model\\{1}", yjCommon.AppPath(), frmGroupName.edName.Text);
                    Directory.CreateDirectory(szDir);

                    TreeNode rootNode;

                    rootNode = new TreeNode(frmGroupName.edName.Text);
                    rootNode.ImageIndex = 15;
                    rootNode.SelectedImageIndex = 16;

                    tvModel.Nodes.Add(rootNode);
                }

                catch (Exception)
                {
                    yjCommon.Warning("그룹 폴더를 생성하는데 실패했습니다.", yjCommon.MESSAGE_BOX_TITLE);
                }

                finally { }
            }
        }

        private void btnRenameGroup_Click(object sender, EventArgs e)
        {
            // 트리뷰에서 선택된 노드를 가져옵니다.
            TreeNode selectedNode = tvModel.SelectedNode;

            // 선택된 노드가 없는 경우 경고 메시지를 표시합니다.
            if (selectedNode == null)
            {
                yjCommon.Warning("이름을 변경할 그룹을 선택하세요.", yjCommon.MESSAGE_BOX_TITLE);
                return;
            }

            String oldGroupName = selectedNode.Text;
            String oldDir = String.Format("{0}Model\\{1}", yjCommon.AppPath(), oldGroupName);

            frmGroupName frmGroupName = new frmGroupName();
            frmGroupName.Text = "변경할 그룹의 이름을 입력합니다.";
            frmGroupName.edName.Text = oldGroupName;

            frmGroupName.StartPosition = FormStartPosition.CenterScreen;
            if (frmGroupName.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String newGroupName = frmGroupName.edName.Text;
                    String newDir = String.Format("{0}Model\\{1}", yjCommon.AppPath(), newGroupName);

                    // 폴더 이름을 변경합니다.
                    if (Directory.Exists(oldDir))
                    {
                        Directory.Move(oldDir, newDir);
                    }

                    // 트리 노드 이름을 변경합니다.
                    selectedNode.Text = newGroupName;
                }
                catch (Exception)
                {
                    yjCommon.Warning("그룹 폴더 이름을 변경하는데 실패했습니다.", yjCommon.MESSAGE_BOX_TITLE);
                }
                finally { }
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            String szGroupName = "", szFileName = "";
            String szDir;

            frmModelName frmModelName = new frmModelName();

            frmModelName.Text = "추가할 모델의 이름을 입력합니다.";
            frmModelName.edName.Text = "새 모델";

            if (tvModel.SelectedNode != null)
            {
                if (tvModel.SelectedNode.Level == 0)
                {
                    // 그룹이 선택되어 있음 ok..
                    szGroupName = tvModel.SelectedNode.Text;
                }
                else
                if (tvModel.SelectedNode.Level == 1)
                {
                    // 모델이 선택되어 있음 그룹으로 변경
                    tvModel.SelectedNode = tvModel.SelectedNode.Parent;
                    szGroupName = tvModel.SelectedNode.Text;
                }

                frmModelName.Group = szGroupName;

                frmModelName.StartPosition = FormStartPosition.CenterScreen;
                if (frmModelName.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        /*
                         * 1. Project파일 생성
                         */
                        szDir = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), szGroupName, frmModelName.edName.Text);
                        Directory.CreateDirectory(szDir);

                        //szDir = String.Format("{0}Model\\{1}\\{2}\\Table1", yjCommon.AppPath(), szGroupName, frmModelName.edName.Text);
                        //Directory.CreateDirectory(szDir);

                        szFileName = String.Format("{0}\\[{1}][{2}][Table1].prj", szDir, szGroupName, frmModelName.edName.Text);

                        LaserProject tmpProject1 = new LaserProject();

                        tmpProject1.SaveToFile(szFileName);

                        TreeNode rootNode;

                        rootNode = new TreeNode(frmModelName.edName.Text);
                        rootNode.ImageIndex = 17;
                        rootNode.SelectedImageIndex = 17;

                        tvModel.SelectedNode.Nodes.Add(rootNode);

                        /*
                         * 1. Project파일 생성
                         */
                        //szDir = String.Format("{0}Model\\{1}\\{2}\\Table2", yjCommon.AppPath(), szGroupName, frmModelName.edName.Text);
                        //Directory.CreateDirectory(szDir);

                        szFileName = String.Format("{0}\\[{1}][{2}][Table2].prj", szDir, szGroupName, frmModelName.edName.Text);

                        LaserProject tmpProject2 = new LaserProject();

                        tmpProject2.SaveToFile(szFileName);

                        /*
                         * 2. Vision 파일을 복사, 가져오기
                         */
                        szDir = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), szGroupName, frmModelName.edName.Text);

                        string srcPath = String.Format("{0}Vision\\CogPMAlignTool(4Align).vpp", yjCommon.AppPath());
                        string DestPath = String.Format("{0}\\CogPMAlignTool(4Align).vpp", szDir);

                        File.Copy(srcPath, DestPath, true);
                    }

                    catch (Exception)
                    {
                        yjCommon.Warning("모델 폴더를 생성하는 과정에서 에러가 발생했습니다.", yjCommon.MESSAGE_BOX_TITLE);
                    }

                    finally { }
                }
            }
            else
            {
                yjCommon.Warning("먼저 모델을 등록할 그룹을 선택합니다.", yjCommon.MESSAGE_BOX_TITLE);
            }
        }

        private void btnRenameModel_Click(object sender, EventArgs e)
        {
            // 트리뷰에서 선택된 노드를 가져옵니다.
            TreeNode selectedNode = tvModel.SelectedNode;

            // 선택된 노드가 없는 경우 경고 메시지를 표시합니다.
            if (selectedNode == null || selectedNode.Level != 1)
            {
                yjCommon.Warning("이름을 변경할 모델을 선택하세요.", yjCommon.MESSAGE_BOX_TITLE);
                return;
            }

            // 현재 모델의 그룹 이름과 모델 이름을 가져옵니다.
            String groupName = selectedNode.Parent.Text;
            String oldModelName = selectedNode.Text;
            String oldDir = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), groupName, oldModelName);

            // 새로운 모델 이름을 입력받기 위해 폼을 엽니다.
            frmModelName frmModelName = new frmModelName();
            frmModelName.Text = "변경할 모델의 이름을 입력합니다.";
            frmModelName.edName.Text = oldModelName;
            frmModelName.Group = groupName;

            frmModelName.StartPosition = FormStartPosition.CenterScreen;
            if (frmModelName.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String newModelName = frmModelName.edName.Text;
                    String newDir = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), groupName, newModelName);

                    // 프로젝트 파일 이름을 변경합니다.
                    String oldFileName = String.Format("{0}\\[{1}][{2}][Table1].prj", oldDir, groupName, oldModelName);
                    String newFileName = String.Format("{0}\\[{1}][{2}][Table1].prj", oldDir, groupName, newModelName);
                    if (File.Exists(oldFileName))
                    {
                        File.Move(oldFileName, newFileName);
                    }

                    // 프로젝트 파일 이름을 변경합니다.
                    oldFileName = String.Format("{0}\\[{1}][{2}][Table2].prj", oldDir, groupName, oldModelName);
                    newFileName = String.Format("{0}\\[{1}][{2}][Table2].prj", oldDir, groupName, newModelName);
                    if (File.Exists(oldFileName))
                    {
                        File.Move(oldFileName, newFileName);
                    }

                    // 폴더 이름을 변경합니다.
                    if (Directory.Exists(oldDir))
                    {
                        Directory.Move(oldDir, newDir);
                    }
                    // 트리 노드 이름을 변경합니다.
                    selectedNode.Text = newModelName;
                }
                catch (Exception)
                {
                    yjCommon.Warning("모델 폴더 이름을 변경하는데 실패했습니다.", yjCommon.MESSAGE_BOX_TITLE);
                }
                finally { }
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            // 트리뷰에서 선택된 노드를 가져옵니다.
            TreeNode selectedNode = tvModel.SelectedNode;

            // 선택된 노드가 없는 경우 경고 메시지를 표시합니다.
            if (selectedNode == null)
            {
                yjCommon.Warning("삭제할 그룹을 선택하세요.", yjCommon.MESSAGE_BOX_TITLE);
                return;
            }

            // 사용자에게 삭제 확인 메시지를 표시합니다.
            DialogResult result = MessageBox.Show("정말로 선택한 그룹을 삭제하시겠습니까?", "그룹 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                String groupName = selectedNode.Text;
                String groupDir = String.Format("{0}Model\\{1}", yjCommon.AppPath(), groupName);

                try
                {
                    // 트리 노드 삭제
                    tvModel.Nodes.Remove(selectedNode);

                    // 폴더 삭제
                    if (Directory.Exists(groupDir))
                    {
                        Directory.Delete(groupDir, true); // true는 하위 디렉토리 및 파일도 삭제
                    }
                }
                catch (Exception)
                {
                    yjCommon.Warning("그룹 폴더를 삭제하는데 실패했습니다.", yjCommon.MESSAGE_BOX_TITLE);
                }
                finally { }
            }
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            // 트리뷰에서 선택된 노드를 가져옵니다.
            TreeNode selectedNode = tvModel.SelectedNode;

            // 선택된 노드가 없는 경우 또는 선택된 노드가 그룹 노드인 경우 경고 메시지를 표시합니다.
            if (selectedNode == null || selectedNode.Level != 1)
            {
                yjCommon.Warning("삭제할 모델을 선택하세요.", yjCommon.MESSAGE_BOX_TITLE);
                return;
            }

            // 현재 모델의 그룹 이름과 모델 이름을 가져옵니다.
            String groupName = selectedNode.Parent.Text;
            String modelName = selectedNode.Text;
            String modelDir = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), groupName, modelName);

            // 사용자에게 삭제 확인 메시지를 표시합니다.
            DialogResult result = MessageBox.Show("정말로 선택한 모델을 삭제하시겠습니까?", "모델 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // 트리 노드 삭제
                    tvModel.Nodes.Remove(selectedNode);

                    // 모델 폴더와 파일 삭제
                    if (Directory.Exists(modelDir))
                    {
                        Directory.Delete(modelDir, true); // true는 하위 디렉토리 및 파일도 삭제
                    }
                }
                catch (Exception)
                {
                    yjCommon.Warning("모델 폴더를 삭제하는데 실패했습니다.", yjCommon.MESSAGE_BOX_TITLE);
                }
                finally { }
            }
        }

        #region private void tvModel_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        /*
         * 사용자가 등록되어 있는 JobFile에서 선택시
         */
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

                Table1.lblGroupName.Text = GroupName;
                Table1.lblModelName.Text = ModelName;
                Table1.GroupName = GroupName;
                Table1.ModelName = ModelName;

                Table2.lblGroupName.Text = GroupName;
                Table2.lblModelName.Text = ModelName;
                Table2.GroupName = GroupName;
                Table2.ModelName = ModelName;
            }
            else
            if (e.Button == MouseButtons.Right)
            {
                // 클릭된 노드를 선택 상태로 변경
                tvModel.SelectedNode = e.Node;

                // 팝업 메뉴를 클릭 위치에 표시
                contextMenuStrip1.Show(tvModel, e.Location);
            }
        }
        #endregion

        #region private void lvRecentModel_MouseClick(object sender, MouseEventArgs e)
        /*
         * 사용자가 최근 리스트에서 선택하는 경우 처리
         */

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (yjCommon.Confirm("\"최근 사용 목록\"을 삭제 합니다.", "삭제") == DialogResult.Yes)
            {
                lvRecentModel.Items.Clear();

                SaveRecentList(lvRecentModel, (TableNo)TabControl1.SelectedIndex);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tabControlSelectJobFile.SelectedIndex == 0)
            {
                if (lvRecentModel.SelectedItems.Count > 0)
                {
                    // 선택한 항목 가져오기
                    ListViewItem selectedItem = lvRecentModel.SelectedItems[0];

                    // 선택한 항목의 텍스트 가져오기
                    string szStr = selectedItem.SubItems[1].Text;

                    string pattern = @"\[(.*?)\]\[(.*?)\]";
                    Match match = Regex.Match(szStr, pattern);

                    if (match.Success)
                    {
                        // 첫 번째 대괄호 안의 값: GroupName
                        string groupName = match.Groups[1].Value;

                        // 두 번째 대괄호 안의 값: ModelName
                        string modelName = match.Groups[2].Value;

                        String szPath = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), groupName, modelName);

                        if (!string.IsNullOrEmpty(szPath) && System.IO.Directory.Exists(szPath))
                        {
                            // 탐색기에서 폴더 열기
                            System.Diagnostics.Process.Start("explorer.exe", szPath);
                        }
                        else
                        {
                            MessageBox.Show("유효한 폴더 경로가 없습니다.");
                        }
                    }
                    else
                    {

                    }
                }
            }
            else
            if (tabControlSelectJobFile.SelectedIndex == 1)
            {
                // 선택된 노드를 기반으로 폴더 경로를 가져옴
                TreeNode selectedNode = tvModel.SelectedNode;
                if (selectedNode != null)
                {
                    String szPath = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), GroupName, ModelName);

                    if (!string.IsNullOrEmpty(szPath) && System.IO.Directory.Exists(szPath))
                    {
                        // 탐색기에서 폴더 열기
                        System.Diagnostics.Process.Start("explorer.exe", szPath);
                    }
                    else
                    {
                        MessageBox.Show("유효한 폴더 경로가 없습니다.");
                    }
                }
            }
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

                    string szGroupName = yjCommon.GetWord(subItemText, 0, '@');
                    string szModelName = yjCommon.GetWord(subItemText, 1, '@');

                    String szPath = String.Format("{0}Model\\{1}\\{2}", yjCommon.AppPath(), szGroupName, szModelName);

                    if (yjCommon.DirectoryExists(szPath))
                    {
                        GroupName = szGroupName;
                        ModelName = szModelName;

                        if (TabControl1.SelectedIndex == 0)
                        {
                            Table1.lblGroupName.Text = szGroupName;
                            Table1.lblModelName.Text = szModelName;
                            Table1.GroupName = GroupName;
                            Table1.ModelName = ModelName;
                        }
                        else
                        if (TabControl1.SelectedIndex == 1)
                        {
                            Table2.lblGroupName.Text = szGroupName;
                            Table2.lblModelName.Text = szModelName;
                            Table2.GroupName = GroupName;
                            Table2.ModelName = ModelName;
                        }
                    }
                    else
                    {
                        yjCommon.Warning("해당 디렉토리가 존재하지 않습니다.", "오류");
                    }
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecentList(lvRecentModel, (TableNo)TabControl1.SelectedIndex + 1);
        }

        private void lvRecentModel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (lvRecentModel.SelectedItems.Count > 0))
            {
                if (yjCommon.Confirm("삭제 합니다.", "확인") == DialogResult.Yes)
                {
                    // 선택된 모든 항목 삭제
                    foreach (ListViewItem selectedItem in lvRecentModel.SelectedItems)
                    {
                        lvRecentModel.Items.Remove(selectedItem);
                    }

                    SaveRecentList(lvRecentModel, (TableNo)TabControl1.SelectedIndex + 1);
                }
            }
        }
    }
}
