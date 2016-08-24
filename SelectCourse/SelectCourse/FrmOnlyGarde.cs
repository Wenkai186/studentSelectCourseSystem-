using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectCourse
{
    public partial class FrmOnlyGarde : Form
    {
        public FrmOnlyGarde()
        {
            InitializeComponent();
        }
        void RefreshData()
        {
            string sqlStr;
            sqlStr = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.csemester='" + cmbSemester.Text.Trim() + "' and tb_grade.sno='" + CPublic.userInfo[0] +  "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvGrade.DataSource = ds.Tables[0];
                dgrdvGrade.Columns[0].HeaderText = "学号";
                dgrdvGrade.Columns[0].Width = 50;
                dgrdvGrade.Columns[1].HeaderText = "姓名";
                dgrdvGrade.Columns[1].Width = 80;
                dgrdvGrade.Columns[2].HeaderText = "课程号";
                dgrdvGrade.Columns[2].Width = 70;
                dgrdvGrade.Columns[3].HeaderText = "课程名";
                dgrdvGrade.Columns[3].Width = 100;
                dgrdvGrade.Columns[4].HeaderText = "学分";
                dgrdvGrade.Columns[4].Width = 50;
                dgrdvGrade.Columns[5].HeaderText = "开课学期";
                dgrdvGrade.Columns[5].Width = 100;
                dgrdvGrade.Columns[6].HeaderText = "成绩";
                dgrdvGrade.Columns[6].Width = 50;
                //dgrdvGrade_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvGrade.DataSource = null;
                MessageBox.Show("暂无该学期成绩", "提示");
            }
        }



        private void FrmOnlyGarde_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSemester.SelectedIndex = -1;
                lblShow.Text = "正在查看“" + CPublic.userInfo[0] + "”第_学期" + cmbSemester.Text.Trim() + "的成绩。";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSemester.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择学期!", "提示");
                    cmbSemester.Focus();
                }
                else
                {
                    lblShow.Text = "正在查看“" + CPublic.userInfo[0] + "”" + cmbSemester.Text.Trim() + "的成绩。";
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            this.Close();
            CDataBase.conn.Close();
        }
    }
}
