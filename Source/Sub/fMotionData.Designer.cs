﻿namespace LaserCutter
{
    partial class frmMotionData
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
            this.Memo1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Memo1
            // 
            this.Memo1.Location = new System.Drawing.Point(13, 13);
            this.Memo1.Multiline = true;
            this.Memo1.Name = "Memo1";
            this.Memo1.Size = new System.Drawing.Size(759, 504);
            this.Memo1.TabIndex = 0;
            // 
            // frmMotionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Memo1);
            this.Name = "frmMotionData";
            this.Text = "MotionDataFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Memo1;
    }
}