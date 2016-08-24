namespace SelectCourse
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcSet = new System.Windows.Forms.TabControl();
            this.tbpWin = new System.Windows.Forms.TabPage();
            this.btnCancelWin = new System.Windows.Forms.Button();
            this.btnOkWin = new System.Windows.Forms.Button();
            this.txtDataBaseWin = new System.Windows.Forms.TextBox();
            this.txtServerWin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpSql = new System.Windows.Forms.TabPage();
            this.txtUserPasswordSql = new System.Windows.Forms.TextBox();
            this.txtUserSql = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelSql = new System.Windows.Forms.Button();
            this.btnOkSql = new System.Windows.Forms.Button();
            this.txtDataBaseSql = new System.Windows.Forms.TextBox();
            this.txtServerSql = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbcSet.SuspendLayout();
            this.tbpWin.SuspendLayout();
            this.tbpSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(314, 101);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(314, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtUserpassword
            // 
            this.txtUserpassword.Location = new System.Drawing.Point(118, 145);
            this.txtUserpassword.Name = "txtUserpassword";
            this.txtUserpassword.PasswordChar = '*';
            this.txtUserpassword.Size = new System.Drawing.Size(186, 20);
            this.txtUserpassword.TabIndex = 6;
            this.txtUserpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserpassword_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcSet);
            this.groupBox1.Location = new System.Drawing.Point(5, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tbcSet
            // 
            this.tbcSet.Controls.Add(this.tbpWin);
            this.tbcSet.Controls.Add(this.tbpSql);
            this.tbcSet.Location = new System.Drawing.Point(6, 17);
            this.tbcSet.Name = "tbcSet";
            this.tbcSet.SelectedIndex = 0;
            this.tbcSet.Size = new System.Drawing.Size(408, 176);
            this.tbcSet.TabIndex = 8;
            // 
            // tbpWin
            // 
            this.tbpWin.Controls.Add(this.btnCancelWin);
            this.tbpWin.Controls.Add(this.btnOkWin);
            this.tbpWin.Controls.Add(this.txtDataBaseWin);
            this.tbpWin.Controls.Add(this.txtServerWin);
            this.tbpWin.Controls.Add(this.label4);
            this.tbpWin.Controls.Add(this.label3);
            this.tbpWin.Location = new System.Drawing.Point(4, 22);
            this.tbpWin.Name = "tbpWin";
            this.tbpWin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWin.Size = new System.Drawing.Size(400, 150);
            this.tbpWin.TabIndex = 0;
            this.tbpWin.Text = "Windows身份认证";
            this.tbpWin.UseVisualStyleBackColor = true;
            // 
            // btnCancelWin
            // 
            this.btnCancelWin.Location = new System.Drawing.Point(299, 105);
            this.btnCancelWin.Name = "btnCancelWin";
            this.btnCancelWin.Size = new System.Drawing.Size(75, 25);
            this.btnCancelWin.TabIndex = 5;
            this.btnCancelWin.Text = "取消";
            this.btnCancelWin.UseVisualStyleBackColor = true;
            this.btnCancelWin.Click += new System.EventHandler(this.btnCancelWin_Click);
            // 
            // btnOkWin
            // 
            this.btnOkWin.Location = new System.Drawing.Point(12, 105);
            this.btnOkWin.Name = "btnOkWin";
            this.btnOkWin.Size = new System.Drawing.Size(75, 25);
            this.btnOkWin.TabIndex = 4;
            this.btnOkWin.Text = "确认";
            this.btnOkWin.UseVisualStyleBackColor = true;
            this.btnOkWin.Click += new System.EventHandler(this.btnOkWin_Click);
            // 
            // txtDataBaseWin
            // 
            this.txtDataBaseWin.Location = new System.Drawing.Point(115, 62);
            this.txtDataBaseWin.Name = "txtDataBaseWin";
            this.txtDataBaseWin.Size = new System.Drawing.Size(174, 20);
            this.txtDataBaseWin.TabIndex = 3;
            this.txtDataBaseWin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataBaseWin_KeyDown);
            // 
            // txtServerWin
            // 
            this.txtServerWin.Location = new System.Drawing.Point(115, 22);
            this.txtServerWin.Name = "txtServerWin";
            this.txtServerWin.Size = new System.Drawing.Size(174, 20);
            this.txtServerWin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据库名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器名称:";
            // 
            // tbpSql
            // 
            this.tbpSql.Controls.Add(this.txtUserPasswordSql);
            this.tbpSql.Controls.Add(this.txtUserSql);
            this.tbpSql.Controls.Add(this.label8);
            this.tbpSql.Controls.Add(this.label7);
            this.tbpSql.Controls.Add(this.btnCancelSql);
            this.tbpSql.Controls.Add(this.btnOkSql);
            this.tbpSql.Controls.Add(this.txtDataBaseSql);
            this.tbpSql.Controls.Add(this.txtServerSql);
            this.tbpSql.Controls.Add(this.label5);
            this.tbpSql.Controls.Add(this.label6);
            this.tbpSql.Location = new System.Drawing.Point(4, 22);
            this.tbpSql.Name = "tbpSql";
            this.tbpSql.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSql.Size = new System.Drawing.Size(400, 150);
            this.tbpSql.TabIndex = 1;
            this.tbpSql.Text = "SQL Server身份认证";
            this.tbpSql.UseVisualStyleBackColor = true;
            // 
            // txtUserPasswordSql
            // 
            this.txtUserPasswordSql.Location = new System.Drawing.Point(282, 92);
            this.txtUserPasswordSql.Name = "txtUserPasswordSql";
            this.txtUserPasswordSql.PasswordChar = '*';
            this.txtUserPasswordSql.Size = new System.Drawing.Size(85, 20);
            this.txtUserPasswordSql.TabIndex = 13;
            // 
            // txtUserSql
            // 
            this.txtUserSql.Location = new System.Drawing.Point(115, 92);
            this.txtUserSql.Name = "txtUserSql";
            this.txtUserSql.Size = new System.Drawing.Size(85, 20);
            this.txtUserSql.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "用户密码:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "用  户  名:";
            // 
            // btnCancelSql
            // 
            this.btnCancelSql.Location = new System.Drawing.Point(299, 117);
            this.btnCancelSql.Name = "btnCancelSql";
            this.btnCancelSql.Size = new System.Drawing.Size(75, 25);
            this.btnCancelSql.TabIndex = 9;
            this.btnCancelSql.Text = "取消";
            this.btnCancelSql.UseVisualStyleBackColor = true;
            this.btnCancelSql.Click += new System.EventHandler(this.btnCancelSql_Click);
            // 
            // btnOkSql
            // 
            this.btnOkSql.Location = new System.Drawing.Point(12, 117);
            this.btnOkSql.Name = "btnOkSql";
            this.btnOkSql.Size = new System.Drawing.Size(75, 25);
            this.btnOkSql.TabIndex = 8;
            this.btnOkSql.Text = "确认";
            this.btnOkSql.UseVisualStyleBackColor = true;
            this.btnOkSql.Click += new System.EventHandler(this.btnOkSql_Click);
            // 
            // txtDataBaseSql
            // 
            this.txtDataBaseSql.Location = new System.Drawing.Point(115, 56);
            this.txtDataBaseSql.Name = "txtDataBaseSql";
            this.txtDataBaseSql.Size = new System.Drawing.Size(174, 20);
            this.txtDataBaseSql.TabIndex = 7;
            // 
            // txtServerSql
            // 
            this.txtServerSql.Location = new System.Drawing.Point(115, 16);
            this.txtServerSql.Name = "txtServerSql";
            this.txtServerSql.Size = new System.Drawing.Size(174, 20);
            this.txtServerSql.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "数据库名称:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "服务器名称:";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(314, 180);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 25);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Setting";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(190, 184);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "None Admin";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(432, 212);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserpassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生学籍管理系统登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tbcSet.ResumeLayout(false);
            this.tbpWin.ResumeLayout(false);
            this.tbpWin.PerformLayout();
            this.tbpSql.ResumeLayout(false);
            this.tbpSql.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbcSet;
        private System.Windows.Forms.TabPage tbpWin;
        private System.Windows.Forms.TabPage tbpSql;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelWin;
        private System.Windows.Forms.Button btnOkWin;
        private System.Windows.Forms.TextBox txtDataBaseWin;
        private System.Windows.Forms.TextBox txtServerWin;
        private System.Windows.Forms.TextBox txtDataBaseSql;
        private System.Windows.Forms.TextBox txtServerSql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelSql;
        private System.Windows.Forms.Button btnOkSql;
        private System.Windows.Forms.TextBox txtUserSql;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserPasswordSql;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

