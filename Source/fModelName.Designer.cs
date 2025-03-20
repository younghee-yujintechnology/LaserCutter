namespace LaserCutter
{
    partial class frmModelName
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
            this.btnCancel = new YujinTechnology.BitBtn();
            this.btnOk = new YujinTechnology.BitBtn();
            this.edName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Location = new System.Drawing.Point(251, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOk.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOk.Location = new System.Drawing.Point(171, 73);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 41);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "등록";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // edName
            // 
            this.edName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edName.Location = new System.Drawing.Point(48, 30);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(378, 24);
            this.edName.TabIndex = 3;
            // 
            // frmModelName
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(477, 126);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.edName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmModelName";
            this.Text = "모델";
            this.Shown += new System.EventHandler(this.frmModelName_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YujinTechnology.BitBtn btnCancel;
        private YujinTechnology.BitBtn btnOk;
        public System.Windows.Forms.TextBox edName;
    }
}