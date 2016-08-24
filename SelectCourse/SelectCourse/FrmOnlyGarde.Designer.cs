namespace SelectCourse
{
    partial class FrmOnlyGarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOnlyGarde));
            this.dgrdvGrade = new System.Windows.Forms.DataGridView();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnEixt = new System.Windows.Forms.Button();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdvGrade
            // 
            this.dgrdvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvGrade.Location = new System.Drawing.Point(-2, 59);
            this.dgrdvGrade.Name = "dgrdvGrade";
            this.dgrdvGrade.RowTemplate.Height = 23;
            this.dgrdvGrade.Size = new System.Drawing.Size(413, 222);
            this.dgrdvGrade.TabIndex = 0;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(23, 20);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(55, 13);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "个人成绩";
            // 
            // btnEixt
            // 
            this.btnEixt.Location = new System.Drawing.Point(323, 300);
            this.btnEixt.Name = "btnEixt";
            this.btnEixt.Size = new System.Drawing.Size(75, 25);
            this.btnEixt.TabIndex = 2;
            this.btnEixt.Text = "返回";
            this.btnEixt.UseVisualStyleBackColor = true;
            this.btnEixt.Click += new System.EventHandler(this.btnEixt_Click);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "第一学期",
            "第二学期"});
            this.cmbSemester.Location = new System.Drawing.Point(77, 302);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 21);
            this.cmbSemester.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(225, 300);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 25);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "确认";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "学 期";
            // 
            // FrmOnlyGarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(410, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.btnEixt);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.dgrdvGrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOnlyGarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOnlyGarde";
            this.Load += new System.EventHandler(this.FrmOnlyGarde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdvGrade;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnEixt;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
    }
}