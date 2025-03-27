using YujinTechnology;

namespace LaserCutter
{
    partial class frmChannelSpy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propGridIO = new YujinTechnology.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propGridMotion = new YujinTechnology.PropertyGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.propGridADV = new YujinTechnology.PropertyGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.propGridLaser = new YujinTechnology.PropertyGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.propGridConfig = new YujinTechnology.PropertyGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(33, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 747);
            this.tabControl1.TabIndex = 114;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propGridIO);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  I/O  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propGridIO
            // 
            this.propGridIO.BackColor = System.Drawing.SystemColors.Control;
            this.propGridIO.CommandsActiveLinkColor = System.Drawing.Color.Yellow;
            this.propGridIO.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.propGridIO.Location = new System.Drawing.Point(6, 6);
            this.propGridIO.Name = "propGridIO";
            this.propGridIO.Size = new System.Drawing.Size(396, 709);
            this.propGridIO.TabIndex = 114;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propGridMotion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Motion  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propGridMotion
            // 
            this.propGridMotion.CommandsActiveLinkColor = System.Drawing.Color.Yellow;
            this.propGridMotion.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.propGridMotion.Location = new System.Drawing.Point(6, 6);
            this.propGridMotion.Name = "propGridMotion";
            this.propGridMotion.Size = new System.Drawing.Size(396, 709);
            this.propGridMotion.TabIndex = 115;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.propGridADV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(408, 721);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "  ADV  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // propGridADV
            // 
            this.propGridADV.CommandsActiveLinkColor = System.Drawing.Color.Yellow;
            this.propGridADV.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.propGridADV.Location = new System.Drawing.Point(6, 6);
            this.propGridADV.Name = "propGridADV";
            this.propGridADV.Size = new System.Drawing.Size(399, 712);
            this.propGridADV.TabIndex = 115;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.propGridLaser);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(408, 721);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "  Laser  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // propGridLaser
            // 
            this.propGridLaser.CommandsActiveLinkColor = System.Drawing.Color.Yellow;
            this.propGridLaser.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.propGridLaser.Location = new System.Drawing.Point(20, 39);
            this.propGridLaser.Name = "propGridLaser";
            this.propGridLaser.Size = new System.Drawing.Size(385, 682);
            this.propGridLaser.TabIndex = 116;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.propGridConfig);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(408, 721);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Config";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // propGridConfig
            // 
            this.propGridConfig.CommandsActiveLinkColor = System.Drawing.Color.Yellow;
            this.propGridConfig.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.propGridConfig.Location = new System.Drawing.Point(12, 19);
            this.propGridConfig.Name = "propGridConfig";
            this.propGridConfig.Size = new System.Drawing.Size(385, 682);
            this.propGridConfig.TabIndex = 117;
            // 
            // frmChannelSpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 785);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmChannelSpy";
            this.Text = "ChannelSpy";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChannelSpy_FormClosing);
            this.Load += new System.EventHandler(this.frmChannelSpy_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public YujinTechnology.PropertyGrid propGridIO;
        private System.Windows.Forms.TabPage tabPage3;
        public YujinTechnology.PropertyGrid propGridMotion;
        public YujinTechnology.PropertyGrid propGridADV;
        private System.Windows.Forms.TabPage tabPage4;
        public YujinTechnology.PropertyGrid propGridLaser;
        private System.Windows.Forms.TabPage tabPage5;
        public PropertyGrid propGridConfig;
    }
}