using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace LaserCutter
{

    public partial class frmCarbide : Form
    {
#if _CARBIDE
        private readonly string _baseUrl = "http://192.168.240.10:20018/v1";
        int nIndex = 0;
        int LiveIndex = 0;
#endif
        public panAuto Auto;

        public frmCarbide()
        {
            InitializeComponent();

            FormClosing += _FormClosing;

            Auto = panAuto.StaticInstance;
        }

        #region public static frmCarbide StaticInstance
        private static frmCarbide staticForm;

        public static frmCarbide StaticInstance
        {
            get
            {
                if (staticForm == null || staticForm.IsDisposed)
                {
                    staticForm = new frmCarbide();
                }
                return staticForm;
            }
        }
        #endregion

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            ReadThread.Enabled = false;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ReadThread_OnExecute(object sender, EventArgs e)
        {
#if _CARBIDE
            switch (nIndex)
            {
                case 0:

                    propertyGrid1.SelectedObject = Basic.Read();
                    nIndex = 10;
                    break;

                case 10:

                    propertyGrid2.SelectedObject = StretcherCompressor.Read();
                    nIndex = 20;
                    break;

                case 20:

                    propertyGrid3.SelectedObject = ExternalControl.Read();
                    nIndex = 30;
                    break;

                case 30:

                    propertyGrid4.SelectedObject = Advanced.Read();
                    nIndex = 40;
                    break;

                case 40:

                    propertyGrid5.SelectedObject = Chiller.Read();
                    nIndex = 0;
                    break;
            }

            LiveIndex = LiveIndex + 1;
            LiveIndex = LiveIndex % 4;

            switch (LiveIndex)
            {
                case 0:
                    ledRX.LED.Value = true;
                    ledTX.LED.Value = false;
                    break;

                case 1:
                    ledRX.LED.Value = true;
                    ledTX.LED.Value = true;
                    break;

                case 2:
                    ledRX.LED.Value = false;
                    ledTX.LED.Value = true;
                    break;

                case 3:
                    ledRX.LED.Value = false;
                    ledTX.LED.Value = false;
                    break;

            }

#endif

        }

        public void Connect()
        {
        }

        public void Disconnect()
        {

        }

    }

}
