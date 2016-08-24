namespace SelectCourse
{
    partial class FrmRegist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegist));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPurview1 = new System.Windows.Forms.ComboBox();
            this.txtUserPasswors = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "权 限:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "密 码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "用户名:";
            // 
            // cmbPurview1
            // 
            this.cmbPurview1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPurview1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPurview1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurview1.Enabled = false;
            this.cmbPurview1.FormattingEnabled = true;
            this.cmbPurview1.Items.AddRange(new object[] {
            "学生用户",
            "管理员"});
            this.cmbPurview1.Location = new System.Drawing.Point(175, 186);
            this.cmbPurview1.Name = "cmbPurview1";
            this.cmbPurview1.Size = new System.Drawing.Size(125, 21);
            this.cmbPurview1.Sorted = true;
            this.cmbPurview1.TabIndex = 12;
            // 
            // txtUserPasswors
            // 
            this.txtUserPasswors.Enabled = false;
            this.txtUserPasswors.Location = new System.Drawing.Point(175, 128);
            this.txtUserPasswors.Name = "txtUserPasswors";
            this.txtUserPasswors.PasswordChar = '*';
            this.txtUserPasswors.Size = new System.Drawing.Size(125, 20);
            this.txtUserPasswors.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(175, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 20);
            this.txtUserName.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegedit
            // 
            this.btnRegedit.Location = new System.Drawing.Point(57, 277);
            this.btnRegedit.Name = "btnRegedit";
            this.btnRegedit.Size = new System.Drawing.Size(75, 25);
            this.btnRegedit.TabIndex = 8;
            this.btnRegedit.Text = "注册";
            this.btnRegedit.UseVisualStyleBackColor = true;
            this.btnRegedit.Click += new System.EventHandler(this.btnRegedit_Click_1);
            // 
            // FrmRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPurview1);
            this.Controls.Add(this.txtUserPasswors);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegedit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册新用户";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPurview1;
        private System.Windows.Forms.TextBox txtUserPasswors;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegedit;


    }
}