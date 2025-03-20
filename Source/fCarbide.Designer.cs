namespace LaserCutter
{
    partial class frmCarbide
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
            this.ReadThread = new YujinTechnology.Thread();
            this.panBottom = new System.Windows.Forms.Panel();
            this.ledRX = new YujinTechnology.LEDLabel();
            this.ledTX = new YujinTechnology.LEDLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.propertyGrid3 = new System.Windows.Forms.PropertyGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.propertyGrid4 = new System.Windows.Forms.PropertyGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.propertyGrid5 = new System.Windows.Forms.PropertyGrid();
            this.panBottom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadThread
            // 
            this.ReadThread.Enabled = false;
            this.ReadThread.Interval = 300;
            this.ReadThread.OnExecute += new System.EventHandler(this.ReadThread_OnExecute);
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.ledRX);
            this.panBottom.Controls.Add(this.ledTX);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 824);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(367, 33);
            this.panBottom.TabIndex = 1350;
            // 
            // ledRX
            // 
            this.ledRX.BackColor = System.Drawing.Color.Transparent;
            this.ledRX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledRX.Frame.Visible = false;
            this.ledRX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledRX.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledRX.Location = new System.Drawing.Point(8, 8);
            this.ledRX.Name = "ledRX";
            this.ledRX.ShowChannelName = false;
            this.ledRX.Size = new System.Drawing.Size(13, 16);
            this.ledRX.TabIndex = 1425;
            this.ledRX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTX
            // 
            this.ledTX.BackColor = System.Drawing.Color.Transparent;
            this.ledTX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledTX.Frame.Visible = false;
            this.ledTX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ledTX.LED.Layout = YujinTechnology.LEDLayout.Center;
            this.ledTX.LED.OnColor = System.Drawing.Color.Red;
            this.ledTX.Location = new System.Drawing.Point(23, 8);
            this.ledTX.Name = "ledTX";
            this.ledTX.ShowChannelName = false;
            this.ledTX.Size = new System.Drawing.Size(13, 16);
            this.ledTX.TabIndex = 1424;
            this.ledTX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 824);
            this.tabControl1.TabIndex = 1351;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Location = new System.Drawing.Point(26, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 816);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Basic  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(331, 810);
            this.propertyGrid1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGrid2);
            this.tabPage2.Location = new System.Drawing.Point(26, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 816);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  StretcherCompressor  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid2.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(331, 810);
            this.propertyGrid2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.propertyGrid3);
            this.tabPage3.Location = new System.Drawing.Point(26, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(337, 816);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "  ExternalControl  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // propertyGrid3
            // 
            this.propertyGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid3.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid3.Name = "propertyGrid3";
            this.propertyGrid3.Size = new System.Drawing.Size(331, 810);
            this.propertyGrid3.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.propertyGrid4);
            this.tabPage4.Location = new System.Drawing.Point(26, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(337, 816);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "  Advanced  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // propertyGrid4
            // 
            this.propertyGrid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid4.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid4.Name = "propertyGrid4";
            this.propertyGrid4.Size = new System.Drawing.Size(331, 810);
            this.propertyGrid4.TabIndex = 12;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.propertyGrid5);
            this.tabPage5.Location = new System.Drawing.Point(26, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(337, 816);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Chiller";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // propertyGrid5
            // 
            this.propertyGrid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid5.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid5.Name = "propertyGrid5";
            this.propertyGrid5.Size = new System.Drawing.Size(331, 810);
            this.propertyGrid5.TabIndex = 13;
            // 
            // frmCarbide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(367, 857);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panBottom);
            this.Name = "frmCarbide";
            this.Text = "Carbide Laser (192.168.240.10)";
            this.panBottom.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DaekhonSystem.Thread ReadThread;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PropertyGrid propertyGrid3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PropertyGrid propertyGrid4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PropertyGrid propertyGrid5;
        private DaekhonSystem.LEDLabel ledRX;
        private DaekhonSystem.LEDLabel ledTX;
    }
}