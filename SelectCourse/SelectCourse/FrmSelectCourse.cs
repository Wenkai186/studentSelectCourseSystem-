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
    public partial class FrmSelectCourse : Form
    {
        public FrmSelectCourse()
        {
            InitializeComponent();
        }

        //string selectCondition;

        void RefreshClass()
        {
            string sqlStr;
            sqlStr = "select * from tb_class where classname='" + cmbClass.Text.Trim() + "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvclass.DataSource = ds.Tables[0];
                dgrdvclass.Columns[0].HeaderText = "班级号";
                dgrdvclass.Columns[0].Width = 70;
                dgrdvclass.Columns[1].HeaderText = "班级名";
                dgrdvclass.Columns[1].Width = 90;
            }
            else
            {
                dgrdvCourse.DataSource = null;
            }
        }
            
        void RefreshCourseData()
        {
            string sqlStr;
            sqlStr = "select * from tb_course where csemester='" + cmbSemester.Text.Trim() + "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvCourse.DataSource = ds.Tables[0];
                dgrdvCourse.Columns[0].HeaderText = "课程号";
                dgrdvCourse.Columns[0].Width = 100;
                dgrdvCourse.Columns[1].HeaderText = "课程名";
                dgrdvCourse.Columns[1].Width = 130;
                dgrdvCourse.Columns[2].HeaderText = "学分";
                dgrdvCourse.Columns[2].Width = 50;
                dgrdvCourse.Columns[3].HeaderText = "学时";
                dgrdvCourse.Columns[3].Width = 50;
                dgrdvCourse.Columns[4].HeaderText = "课程学期";
                dgrdvCourse.Columns[4].Width = 130;
            }
            else
            {
                dgrdvCourse.DataSource = null;
            }
        }

        void RefreshSelcetCourseData()
        {
            string sqlStr,classCno;
            int i = dgrdvclass.CurrentCell.RowIndex;
            classCno = dgrdvclass[0, i].Value.ToString().Trim();

            //sqlStr = "select tb_select.classNo,tb_class.classname,tb_select.classno,tb_course.Cname,tb_course.csemester"
            //+ "from tb_class inner join(tb_course inner join tb_select on tb_course.cno=tb_select.cno)"
            //+ "on tb_class.classno =tb_select.classno where tb_select.classno='"
            //+ classCno + "'";

            sqlStr = "select tb_select.classNo,tb_class.classname,tb_Course.cno,tb_course.Cname,tb_course.cperiod,tb_course.csemester from tb_class inner join(tb_course inner join tb_select on tb_course.cno=tb_select.cno) on tb_class.classno =tb_select.classno where tb_select.classno='" + classCno + "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvSelectCourse.DataSource = ds.Tables[0];
                dgrdvSelectCourse.Columns[0].HeaderText = "班级号";
                dgrdvSelectCourse.Columns[0].Width = 130;
                dgrdvSelectCourse.Columns[1].HeaderText = "班级名";
                dgrdvSelectCourse.Columns[1].Width = 130;
                dgrdvSelectCourse.Columns[2].HeaderText = "课程号";
                dgrdvSelectCourse.Columns[2].Width = 130;
                dgrdvSelectCourse.Columns[3].HeaderText = "课程名";
                dgrdvSelectCourse.Columns[3].Width = 130;
                dgrdvSelectCourse.Columns[4].HeaderText = "课程学时";
                dgrdvSelectCourse.Columns[4].Width = 130;
                dgrdvSelectCourse.Columns[5].HeaderText = "课程学期";
                dgrdvSelectCourse.Columns[5].Width = 130;
            }
            else
            {
                dgrdvSelectCourse.DataSource = null;
            }
        }

        private void FrmSelectCourse_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSemester.SelectedIndex = 0;
                cmbClass.SelectedIndex = 0;
                string sqlStr;
                DataSet ds = new DataSet();
                sqlStr = "select * from tb_course";
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds != null)
                {
                    dgrdvCourse.DataSource = ds.Tables[0];
                    dgrdvCourse.Columns[0].HeaderText = "课程号";
                    dgrdvCourse.Columns[0].Width = 100;
                    dgrdvCourse.Columns[1].HeaderText = "课程名";
                    dgrdvCourse.Columns[1].Width = 130;
                    dgrdvCourse.Columns[2].HeaderText = "学分";
                    dgrdvCourse.Columns[2].Width = 50;
                    dgrdvCourse.Columns[3].HeaderText = "学时";
                    dgrdvCourse.Columns[3].Width = 50;
                    dgrdvCourse.Columns[4].HeaderText = "课程学期";
                    dgrdvCourse.Columns[4].Width = 130;
                }
                else
                {
                    dgrdvCourse.DataSource = null;
                }
                RefreshCourseData();
                RefreshClass();
                RefreshSelcetCourseData();              
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str;
                str = "正在为" + cmbClass.Text.Trim() + "选" + cmbSemester.Text.Trim() + "的课";
                this.Text = str;
                RefreshCourseData();
                RefreshClass();
                RefreshSelcetCourseData(); 
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str;
                str = "正在为" + cmbClass.Text.Trim() + "选" + cmbSemester.Text.Trim() + "的课";
                this.Text = str;
                RefreshCourseData();
                RefreshClass();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrdvCourse.DataSource == null)
                {
                    MessageBox.Show("没有课程可选", "提示");
                    return;
                }
                int n = dgrdvCourse.CurrentCell.RowIndex;
                int i = dgrdvclass.CurrentCell.RowIndex;
                string selectCno, classno;
                classno = dgrdvclass[0, i].Value.ToString().Trim();
                selectCno = dgrdvCourse[0, n].Value.ToString().Trim();                
                string sqlStr;
                sqlStr = "select * from tb_select where classno='" + classno + "'" + "and Cno='" + selectCno + "'" ;
                if (CDataBase.GetDataFromDB(sqlStr) != null)
                {
                    MessageBox.Show("已选该课程!", "不能重选", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sqlStr = "insert into tb_select (classNo,Cno) values ('" + classno + "','" + selectCno + "')";
                CDataBase.UpdateDB(sqlStr);
                RefreshSelcetCourseData();
                MessageBox.Show("选课成功", "提示");
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrdvSelectCourse.DataSource == null)
                {
                    MessageBox.Show("没有可删除的选课记录!","提示");
                    return;
                }
                int n = dgrdvSelectCourse.CurrentCell.RowIndex;
                string classNo, selectCno, selectCname ;
                classNo = dgrdvSelectCourse[0,n].Value.ToString().Trim();
                selectCno = dgrdvSelectCourse[2,n].Value.ToString().Trim();
                selectCname = dgrdvSelectCourse[3, n].Value.ToString().Trim();
                if (MessageBox.Show("确定要删除“" + classNo + "”的所选课程《" + selectCname + "》吗?","删除选课记录",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr;
                    sqlStr = "delete from tb_select where classno='" + classNo + "'" + "and Cno='" + selectCno + "'";
                    CDataBase.UpdateDB(sqlStr);
                    dgrdvSelectCourse.Rows.RemoveAt(n);
                    if (dgrdvSelectCourse.Rows.Count == 1)
                    {
                        dgrdvSelectCourse.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }


    }


}
