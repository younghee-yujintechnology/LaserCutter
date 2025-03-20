namespace LaserCutter
{
    partial class frmUserSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCanecl = new YujinTechnology.BitBtn();
            this.btnOk = new YujinTechnology.BitBtn();
            this.btnAdd = new YujinTechnology.BitBtn();
            this.edName = new YujinTechnology.Edit();
            this.gradLabel8 = new YujinTechnology.GradientLabel();
            this.edit1 = new YujinTechnology.Edit();
            this.gradientLabel1 = new YujinTechnology.GradientLabel();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbUserName = new YujinTechnology.ComboBox();
            this.gradientLabel2 = new YujinTechnology.GradientLabel();
            this.userList1 = new YujinTechnology.UserList();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.HeaderText = "Name";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Author
            // 
            this.Author.HeaderText = "Authority";
            this.Author.Items.AddRange(new object[] {
            "Operator",
            "Technical",
            "Super"});
            this.Author.Name = "Author";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPassword,
            this.ColumnAuthority});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(363, 241);
            this.dataGridView1.TabIndex = 1593;
            // 
            // btnCanecl
            // 
            this.btnCanecl.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnCanecl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCanecl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanecl.Font = new System.Drawing.Font("굴림", 9F);
            this.btnCanecl.ForeColor = System.Drawing.Color.Black;
            this.btnCanecl.Location = new System.Drawing.Point(195, 386);
            this.btnCanecl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCanecl.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCanecl.Name = "btnCanecl";
            this.btnCanecl.Size = new System.Drawing.Size(98, 46);
            this.btnCanecl.TabIndex = 1591;
            this.btnCanecl.Text = "Cancel";
            this.btnCanecl.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("굴림", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(89, 386);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 46);
            this.btnOk.TabIndex = 1590;
            this.btnOk.Text = "Save";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(290, 330);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 29);
            this.btnAdd.TabIndex = 1596;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // edName
            // 
            this.edName.BackColor = System.Drawing.Color.White;
            this.edName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.edName.Font = new System.Drawing.Font("굴림", 9F);
            this.edName.Location = new System.Drawing.Point(120, 258);
            this.edName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edName.MinimumSize = new System.Drawing.Size(1, 1);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(162, 29);
            this.edName.TabIndex = 1595;
            this.edName.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // gradLabel8
            // 
            this.gradLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gradLabel8.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradLabel8.Font = new System.Drawing.Font("굴림", 9F);
            this.gradLabel8.Frame.Visible = false;
            this.gradLabel8.GradientEnable = false;
            this.gradLabel8.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradLabel8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradLabel8.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradLabel8.Location = new System.Drawing.Point(39, 261);
            this.gradLabel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gradLabel8.Name = "gradLabel8";
            this.gradLabel8.Size = new System.Drawing.Size(79, 23);
            this.gradLabel8.TabIndex = 1594;
            this.gradLabel8.Text = "Name";
            this.gradLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edit1
            // 
            this.edit1.BackColor = System.Drawing.Color.White;
            this.edit1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.edit1.Font = new System.Drawing.Font("굴림", 9F);
            this.edit1.Location = new System.Drawing.Point(120, 293);
            this.edit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit1.MinimumSize = new System.Drawing.Size(1, 1);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(162, 29);
            this.edit1.TabIndex = 1598;
            this.edit1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel1.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel1.Font = new System.Drawing.Font("굴림", 9F);
            this.gradientLabel1.Frame.Visible = false;
            this.gradientLabel1.GradientEnable = false;
            this.gradientLabel1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel1.Location = new System.Drawing.Point(37, 296);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(81, 23);
            this.gradientLabel1.TabIndex = 1597;
            this.gradientLabel1.Text = "Password";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            // 
            // ColumnAuthority
            // 
            this.ColumnAuthority.HeaderText = "Authority";
            this.ColumnAuthority.Name = "ColumnAuthority";
            this.ColumnAuthority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cbUserName
            // 
            this.cbUserName.BackColor = System.Drawing.Color.White;
            this.cbUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUserName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbUserName.Frame.FlatColor = System.Drawing.Color.Black;
            this.cbUserName.Location = new System.Drawing.Point(120, 329);
            this.cbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUserName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbUserName.Size = new System.Drawing.Size(162, 28);
            this.cbUserName.TabIndex = 1599;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientLabel2.CaptionStyle.OutlineFillColor = System.Drawing.SystemColors.Window;
            this.gradientLabel2.Font = new System.Drawing.Font("굴림", 9F);
            this.gradientLabel2.Frame.Visible = false;
            this.gradientLabel2.GradientEnable = false;
            this.gradientLabel2.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.gradientLabel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientLabel2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(238)))));
            this.gradientLabel2.Location = new System.Drawing.Point(37, 332);
            this.gradientLabel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(81, 23);
            this.gradientLabel2.TabIndex = 1600;
            this.gradientLabel2.Text = "Authority";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userList1
            // 
            this.userList1.SavePath = null;
            // 
            // frmUserSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(383, 442);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.cbUserName);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.gradLabel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCanecl);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUserSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Setting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewComboBoxColumn Author;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YujinTechnology.BitBtn btnCanecl;
        private YujinTechnology.BitBtn btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthority;
        private YujinTechnology.BitBtn btnAdd;
        private YujinTechnology.Edit edName;
        private YujinTechnology.GradientLabel gradLabel8;
        private YujinTechnology.Edit edit1;
        private YujinTechnology.GradientLabel gradientLabel1;
        private YujinTechnology.ComboBox cbUserName;
        private YujinTechnology.GradientLabel gradientLabel2;
        private YujinTechnology.UserList userList1;
    }
}