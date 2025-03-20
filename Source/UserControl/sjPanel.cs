using Raize.CodeSiteLogging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Web.UI.Design.WebControls;

namespace LaserCutter
{
    public partial class sjPanel : System.Windows.Forms.Panel
    {
        YujinTechnology.GradientLabel lblTitle;
        System.Windows.Forms.Label lblBorder;

        public sjPanel()
        {
            lblTitle = new YujinTechnology.GradientLabel();
            lblBorder = new System.Windows.Forms.Label();

            lblBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblBorder.Dock = System.Windows.Forms.DockStyle.Top;
            lblBorder.ForeColor = System.Drawing.Color.Black;
            lblBorder.Location = new System.Drawing.Point(0, 40);
            lblBorder.Size = new System.Drawing.Size(995, 6);
            lblBorder.TabIndex = 1;
            lblBorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTitle.Frame.Visible = false;
            lblTitle.GradientEndColor = System.Drawing.Color.White;
            lblTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            lblTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(995, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Controls.Add(lblTitle);
            Controls.Add(lblBorder);

            Resize += _Resize;
        }

        private void _Resize(object sender, EventArgs e)
        {
            AdjustControlSizes();
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            // 디자인 타임인지 런타임인지 확인합니다.
            lblBorder.SendToBack();
            lblTitle.SendToBack();
        }

        private void AdjustControlSizes()
        {
            // UserControl의 크기를 가져옵니다.
            int panelWidth = this.Width;
            int panelHeight = this.Height;

            // lblTitle과 lblBorder의 크기를 조정합니다.
            lblTitle.Width = panelWidth;
            lblBorder.Width = panelWidth;
        }

        #region property public Font TitleFont
        [Category("Custom Properties")]
        [Description("Set the font of the Title label.")]
        public Font TitleFont
        {
            get { return lblTitle.Font; }
            set { lblTitle.Font = value; }
        }
        #endregion

        #region property public Font TitleForeColor
        [Category("Custom Properties")]
        [Description("Set the font of the Title label Color.")]
        public Color TitleForeColor
        {
            get { return lblTitle.ForeColor; }
            set { lblTitle.ForeColor = value; }
        }
        #endregion

        #region property public string TitleText
        [Category("Custom Properties")]
        [Description("Set the text of the Title label.")]
        public string TitleText
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        #endregion

        #region public ContentAlignment TitleTextAlign
        [Category("Custom Properties")]
        [Description("Set the text alignment of the Title label.")]
        public ContentAlignment TitleTextAlign
        {
            get { return lblTitle.TextAlign; }
            set { lblTitle.TextAlign = value; }
        }
        #endregion

        #region property public override Color BackColor
        [Category("Appearance")]
        [Description("Set the background color of the panel and the Title label.")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
            }
        }
        #endregion
    }
}
