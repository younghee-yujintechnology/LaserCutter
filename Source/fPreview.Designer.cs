namespace LaserCutter
{
    partial class frmPreview
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
            this.panCad = new yjTech.Panel();
            this.SuspendLayout();
            // 
            // panCad
            // 
            this.panCad.BackColor = System.Drawing.Color.Black;
            this.panCad.Font = new System.Drawing.Font("Tahoma", 11F);
            this.panCad.ForeColor = System.Drawing.Color.White;
            this.panCad.Location = new System.Drawing.Point(6, 7);
            this.panCad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panCad.Name = "panCad";
            this.panCad.Size = new System.Drawing.Size(772, 548);
            this.panCad.TabIndex = 1617;
            this.panCad.Text = "CAD는 동적으로 생성";
            // 
            // frmPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panCad);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public yjTech.Panel panCad;
    }
}