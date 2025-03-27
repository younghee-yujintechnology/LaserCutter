using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raize.CodeSiteLogging;

namespace LaserCutter
{
    public partial class panTable: UserControl
    {
        CodeSiteLogger logger;

        public panAuto Auto;

        public panJobType1 Type1;
        public panJobType2 Type2;
        public panJobType3 Type3;

        public frmMain frmMain;

        public panTable(bool withVision = false)
        {
            InitializeComponent();

            Type1 = new panJobType1();
            Type1.Auto = panAuto.StaticInstance;
            Type1.EnableControl(false);

            Type2 = new panJobType2();
            Type2.Auto = panAuto.StaticInstance;
            Type2.EnableControl(false);

            Type3 = new panJobType3();
            Type3.Auto = panAuto.StaticInstance;
            Type3.EnableControl(false);

            frmMain = frmMain.StaticInstance;

            tabPage1.Controls.Add(Type1);
            tabPage2.Controls.Add(Type2);
            tabPage3.Controls.Add(Type3);

            Type1.Location = new Point(2, 0);
            Type2.Location = new Point(2, 0);
            Type3.Location = new Point(2, 0);
        }

        #region private TableNo TableNo
        private TableNo mTableNo;

        public TableNo TableNo
        {
            get
            {
                return mTableNo;
            }

            set
            {
                mTableNo = value;
            }
        }
        #endregion

        public void EnableControl(bool enable)
        {
            //        btnOpenJobFile.Enabled = enable;
            //        btnClose.Enabled = enable;

            // JobInfo.TabControl2.Enabled = enable;
            //// JobInfo.Type1.EnableControl(enable);
            //// JobInfo.Type2.EnableControl(enable);
            //// JobInfo.Type3.EnableControl(enable);
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

                if (!String.IsNullOrEmpty(mModelName))
                {
                    ////if (LoadJobFile(GroupName, ModelName))
                    ////{
                    ////    DisplayJobFile();
                    ////}
                    ////else
                    ////{
                    ////    ClearAllControlValue();
                    ////}
                }
                else
                {
                    ////ClearAllControlValue();
                }
            }
        }
        #endregion
    }
}
