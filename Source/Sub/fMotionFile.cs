using DaekhonSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserCutter
{
    public partial class frmMotionFile : Form
    {
        public IntegerList MessageQueue = new IntegerList();
        //private panJobFileType1 panJobFileType1Instance;
        public frmMotionFile()
        {
            InitializeComponent();

            //this.panJobFileType1Instance = panJobFileType1;
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

        public bool isStartAble()
        {
            bool result = false;

            for (int nIndex = 0; nIndex < Memo1.Lines.Length; nIndex++)
            {
                string line = Memo1.Lines[nIndex].ToLower();

                if (line.Contains("eof"))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }  
    }
}
