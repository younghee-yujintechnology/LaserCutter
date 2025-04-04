using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using yjTech;
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

            Table1.TableNo = TableNo.Table1;
            Table1.Location = new Point(2, 2);
            Table1.btnOpenJobFile.Enabled = false;
            Table1.btnClose.Enabled = false;
            tabTable1.Controls.Add(Table1);

            Table2.TableNo = TableNo.Table2;
            Table2.Location = new Point(2, 2);
            Table2.btnOpenJobFile.Enabled = false;
            Table2.btnClose.Enabled = false;
            tabTable2.Controls.Add(Table2);

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
            }
        }
        #endregion

        #region private void lvRecentModel_MouseClick(object sender, MouseEventArgs e)
        /*
         * 사용자가 최근 리스트에서 선택하는 경우 처리
         */

        #endregion


       private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
