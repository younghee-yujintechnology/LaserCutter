namespace LaserCutter
{
    partial class frmLogin
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
            this.uiPanel1 = new YujinTechnology.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbUserName = new YujinTechnology.ComboBox();
            this.cbUserMode = new YujinTechnology.ComboBox();
            this.LabelUserMode = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.panLogin = new System.Windows.Forms.Panel();
            this.edPassword = new YujinTechnology.Edit();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panLogout = new System.Windows.Forms.Panel();
            this.edit2 = new YujinTechnology.Edit();
            this.edit1 = new YujinTechnology.Edit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            this.panLogin.SuspendLayout();
            this.panLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.uiPanel1.Controls.Add(this.pictureBox1);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.GradientEnable = true;
            this.uiPanel1.GradientEndColor = System.Drawing.Color.White;
            this.uiPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uiPanel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.uiPanel1.Location = new System.Drawing.Point(2, 2);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(309, 172);
            this.uiPanel1.TabIndex = 935;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LaserCutter.Properties.Resources.UTI_LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbUserName
            // 
            this.cbUserName.BackColor = System.Drawing.Color.White;
            this.cbUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUserName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbUserName.Frame.FlatColor = System.Drawing.Color.Black;
            this.cbUserName.Location = new System.Drawing.Point(8, 86);
            this.cbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUserName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbUserName.Size = new System.Drawing.Size(255, 28);
            this.cbUserName.TabIndex = 942;
            // 
            // cbUserMode
            // 
            this.cbUserMode.BackColor = System.Drawing.Color.White;
            this.cbUserMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUserMode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbUserMode.Frame.FlatColor = System.Drawing.Color.Black;
            this.cbUserMode.Items.AddRange(new object[] {
            "Operator",
            "Technicial",
            "Super"});
            this.cbUserMode.Location = new System.Drawing.Point(8, 30);
            this.cbUserMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUserMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbUserMode.Name = "cbUserMode";
            this.cbUserMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbUserMode.Size = new System.Drawing.Size(255, 28);
            this.cbUserMode.TabIndex = 941;
            // 
            // LabelUserMode
            // 
            this.LabelUserMode.AutoSize = true;
            this.LabelUserMode.BackColor = System.Drawing.Color.White;
            this.LabelUserMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserMode.ForeColor = System.Drawing.Color.DimGray;
            this.LabelUserMode.Location = new System.Drawing.Point(8, 6);
            this.LabelUserMode.Name = "LabelUserMode";
            this.LabelUserMode.Size = new System.Drawing.Size(95, 19);
            this.LabelUserMode.TabIndex = 937;
            this.LabelUserMode.Text = "User Mode";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.White;
            this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.LabelPassword.Location = new System.Drawing.Point(8, 121);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(87, 19);
            this.LabelPassword.TabIndex = 939;
            this.LabelPassword.Text = "Password";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.BackColor = System.Drawing.Color.White;
            this.LabelUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelUserName.Location = new System.Drawing.Point(8, 62);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(98, 19);
            this.LabelUserName.TabIndex = 938;
            this.LabelUserName.Text = "User Name";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::LaserCutter.Properties.Resources.Image1;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Location = new System.Drawing.Point(280, 177);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(31, 28);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.edPassword);
            this.panLogin.Controls.Add(this.btnLogIn);
            this.panLogin.Controls.Add(this.cbUserName);
            this.panLogin.Controls.Add(this.cbUserMode);
            this.panLogin.Controls.Add(this.LabelUserMode);
            this.panLogin.Controls.Add(this.LabelPassword);
            this.panLogin.Controls.Add(this.LabelUserName);
            this.panLogin.Location = new System.Drawing.Point(20, 207);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(273, 251);
            this.panLogin.TabIndex = 944;
            // 
            // edPassword
            // 
            this.edPassword.BackColor = System.Drawing.Color.White;
            this.edPassword.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edPassword.Frame.FlatColor = System.Drawing.Color.Black;
            this.edPassword.Location = new System.Drawing.Point(8, 143);
            this.edPassword.Name = "edPassword";
            this.edPassword.Size = new System.Drawing.Size(255, 28);
            this.edPassword.TabIndex = 1448;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(77, 192);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(106, 47);
            this.btnLogIn.TabIndex = 944;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // panLogout
            // 
            this.panLogout.Controls.Add(this.edit2);
            this.panLogout.Controls.Add(this.edit1);
            this.panLogout.Controls.Add(this.label1);
            this.panLogout.Controls.Add(this.label2);
            this.panLogout.Controls.Add(this.btnLogOut);
            this.panLogout.Location = new System.Drawing.Point(20, 207);
            this.panLogout.Name = "panLogout";
            this.panLogout.Size = new System.Drawing.Size(273, 251);
            this.panLogout.TabIndex = 945;
            // 
            // edit2
            // 
            this.edit2.BackColor = System.Drawing.Color.White;
            this.edit2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit2.Frame.FlatColor = System.Drawing.Color.Black;
            this.edit2.Location = new System.Drawing.Point(8, 86);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(255, 28);
            this.edit2.TabIndex = 1450;
            // 
            // edit1
            // 
            this.edit1.BackColor = System.Drawing.Color.White;
            this.edit1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit1.Frame.FlatColor = System.Drawing.Color.Black;
            this.edit1.Location = new System.Drawing.Point(8, 30);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(255, 28);
            this.edit1.TabIndex = 1449;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 939;
            this.label1.Text = "User Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 940;
            this.label2.Text = "User Name";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(77, 192);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 47);
            this.btnLogOut.TabIndex = 937;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 463);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panLogout);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panLogout.ResumeLayout(false);
            this.panLogout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private YujinTechnology.GradientPanel uiPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private YujinTechnology.ComboBox cbUserName;
        private YujinTechnology.ComboBox cbUserMode;
        private System.Windows.Forms.Label LabelUserMode;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.PictureBox btnSetting;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Panel panLogout;
        private System.Windows.Forms.Button btnLogOut;
        private YujinTechnology.Edit edPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private YujinTechnology.Edit edit2;
        private YujinTechnology.Edit edit1;
    }
}