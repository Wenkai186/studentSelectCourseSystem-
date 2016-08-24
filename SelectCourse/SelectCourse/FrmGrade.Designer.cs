namespace SelectCourse
{
    partial class FrmGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrade));
            this.dgrdvGrade = new System.Windows.Forms.DataGridView();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnItemize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGarde = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCountValue2 = new System.Windows.Forms.TextBox();
            this.txtCountValue1 = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdvGrade
            // 
            this.dgrdvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvGrade.Location = new System.Drawing.Point(-1, -3);
            this.dgrdvGrade.Name = "dgrdvGrade";
            this.dgrdvGrade.RowTemplate.Height = 23;
            this.dgrdvGrade.Size = new System.Drawing.Size(896, 436);
            this.dgrdvGrade.TabIndex = 0;
            this.dgrdvGrade.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvGrade_RowHeaderMouseClick);
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "数据结构",
            "算法分析",
            "高等数学(A)",
            "大学英语(一)",
            ".NET框架技术",
            "C语言程序设计"});
            this.cmbCourse.Location = new System.Drawing.Point(71, 456);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(126, 21);
            this.cmbCourse.TabIndex = 0;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(499, 506);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 25);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "排名";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "选  择";
            // 
            // btnItemize
            // 
            this.btnItemize.Location = new System.Drawing.Point(418, 506);
            this.btnItemize.Name = "btnItemize";
            this.btnItemize.Size = new System.Drawing.Size(75, 25);
            this.btnItemize.TabIndex = 12;
            this.btnItemize.Text = "统计";
            this.btnItemize.UseVisualStyleBackColor = true;
            this.btnItemize.Click += new System.EventHandler(this.btnItemize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "统计条件";
            // 
            // cmbCount
            // 
            this.cmbCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCount.DropDownWidth = 150;
            this.cmbCount.FormattingEnabled = true;
            this.cmbCount.Items.AddRange(new object[] {
            "优秀(100分>成绩>89分)",
            "良好(89分>成绩>79分)",
            "中等(79分>成绩>69分)",
            "及格(69分>成绩>59分)",
            "不及格(成绩<60分)",
            "其他"});
            this.cmbCount.Location = new System.Drawing.Point(71, 509);
            this.cmbCount.Name = "cmbCount";
            this.cmbCount.Size = new System.Drawing.Size(126, 21);
            this.cmbCount.TabIndex = 6;
            this.cmbCount.SelectedIndexChanged += new System.EventHandler(this.cmbCount_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "统 计 值";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(717, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "录入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(717, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(807, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGarde
            // 
            this.txtGarde.Location = new System.Drawing.Point(627, 508);
            this.txtGarde.Name = "txtGarde";
            this.txtGarde.Size = new System.Drawing.Size(75, 20);
            this.txtGarde.TabIndex = 5;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(580, 511);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(31, 13);
            this.lblShow.TabIndex = 11;
            this.lblShow.Text = "成绩";
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(627, 455);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(75, 20);
            this.txtCno.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(807, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(499, 454);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(75, 20);
            this.txtSno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "学号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "课程号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "—";
            // 
            // txtCountValue2
            // 
            this.txtCountValue2.Location = new System.Drawing.Point(291, 508);
            this.txtCountValue2.Name = "txtCountValue2";
            this.txtCountValue2.Size = new System.Drawing.Size(27, 20);
            this.txtCountValue2.TabIndex = 24;
            // 
            // txtCountValue1
            // 
            this.txtCountValue1.Location = new System.Drawing.Point(366, 508);
            this.txtCountValue1.Name = "txtCountValue1";
            this.txtCountValue1.Size = new System.Drawing.Size(27, 20);
            this.txtCountValue1.TabIndex = 25;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(366, 454);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 25);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "第一学期",
            "第二学期"});
            this.cmbSemester.Location = new System.Drawing.Point(217, 456);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 21);
            this.cmbSemester.TabIndex = 26;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged_1);
            // 
            // FrmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(894, 545);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtCountValue1);
            this.Controls.Add(this.txtCountValue2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnItemize);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtGarde);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.dgrdvGrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrade";
            this.Load += new System.EventHandler(this.FrmGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdvGrade;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGarde;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCountValue2;
        private System.Windows.Forms.TextBox txtCountValue1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cmbSemester;


    }
}