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
    public partial class FrmGrade : Form
    {
        public FrmGrade()
        {
            InitializeComponent();
        }

        string str;
        void RefreshData()
        {
            string sqlStr;

            //int n = dgrdvGrade.CurrentCell.RowIndex;
            //string gardeName;
            //gardeName = dgrdvGrade[1, n].Value.ToString().Trim();
            //lblShow.Text = "现在正在查看“" + gardeName + "”的成绩";

            sqlStr = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.cname='" + cmbCourse.Text.Trim() + "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvGrade.DataSource = ds.Tables[0];
                dgrdvGrade.Columns[0].HeaderText = "学号";
                dgrdvGrade.Columns[0].Width = 100;
                dgrdvGrade.Columns[1].HeaderText = "姓名";
                dgrdvGrade.Columns[1].Width = 150;
                dgrdvGrade.Columns[2].HeaderText = "课程号";
                dgrdvGrade.Columns[2].Width = 100;
                dgrdvGrade.Columns[3].HeaderText = "课程名";
                dgrdvGrade.Columns[3].Width = 150;
                dgrdvGrade.Columns[4].HeaderText = "学分";
                dgrdvGrade.Columns[4].Width = 100;
                dgrdvGrade.Columns[5].HeaderText = "开课学期";
                dgrdvGrade.Columns[5].Width = 150;
                dgrdvGrade.Columns[6].HeaderText = "成绩";
                dgrdvGrade.Columns[6].Width = 100;
                dgrdvGrade_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvGrade.DataSource = null;
                //MessageBox.Show("暂无此课程信息", "提示");
            }
        }

        void objOpen()
        {
            txtSno.Enabled = true;
            txtCno.Enabled = true;
            txtGarde.Enabled = true;
        }

        void objClose()
        {
            txtSno.Enabled = false;
            txtCno.Enabled = false;
            txtGarde.Enabled = false;
        }

        void cleraAll()
        {
            txtSno.Text = "";
            txtCno.Text = "";
            txtGarde.Text = "";
        }

        //判断
        //bool No(string no)
        //{
        //    string sql = "select sno,cno from tb_grade where sno='" + txtSno.Text.Trim() + "' and cno='" + txtCno.Text.Trim() + "'";
        //    SqlCommand cmd = new SqlCommand(sqlStr, CDataBase.conn);
        //    CDataBase.conn.Open();
        //    SqlDataReader sdr = cmd.ExecuteReader();
        //    if (sdr.Read())
        //    {
        //        CDataBase.conn.Close();
        //        return false;
        //    }
        //    CDataBase.conn.Close();
        //    return true;
        //}
        //点击表格行
        private void dgrdvGrade_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = dgrdvGrade.CurrentCell.RowIndex;
                if (n < dgrdvGrade.RowCount - 1)
                {
                    txtGarde.Text = dgrdvGrade[6, n].Value.ToString().Trim();
                    txtSno.Text = dgrdvGrade[0, n].Value.ToString().Trim();
                    txtCno.Text = dgrdvGrade[2, n].Value.ToString().Trim();
                    str = dgrdvGrade[6, n].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //进入窗体
        private void FrmGrade_Load(object sender, EventArgs e)
        {
            try
            {
                txtGarde.Enabled = false;
                txtCountValue1.Enabled = false;
                txtCountValue2.Enabled = false;
                cmbCourse.SelectedIndex = 0;
                objClose();
                cmbCourse.SelectedIndex = -1;
            string sqlStr;
            sqlStr = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvGrade.DataSource = ds.Tables[0];
                dgrdvGrade.Columns[0].HeaderText = "学号";
                dgrdvGrade.Columns[0].Width = 100;
                dgrdvGrade.Columns[1].HeaderText = "姓名";
                dgrdvGrade.Columns[1].Width = 150;
                dgrdvGrade.Columns[2].HeaderText = "课程号";
                dgrdvGrade.Columns[2].Width = 100;
                dgrdvGrade.Columns[3].HeaderText = "课程名";
                dgrdvGrade.Columns[3].Width = 150;
                dgrdvGrade.Columns[4].HeaderText = "学分";
                dgrdvGrade.Columns[4].Width = 100;
                dgrdvGrade.Columns[5].HeaderText = "开课学期";
                dgrdvGrade.Columns[5].Width = 150;
                dgrdvGrade.Columns[6].HeaderText = "成绩";
                dgrdvGrade.Columns[6].Width = 100;
                dgrdvGrade_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvGrade.DataSource = null;
                
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //学期条件更改
        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSemester.SelectedIndex = -1;
            string sqlStr;
            sqlStr = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.cname='" + cmbCourse.Text.Trim() + "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvGrade.DataSource = ds.Tables[0];
                dgrdvGrade.Columns[0].HeaderText = "学号";
                dgrdvGrade.Columns[0].Width = 100;
                dgrdvGrade.Columns[1].HeaderText = "姓名";
                dgrdvGrade.Columns[1].Width = 150;
                dgrdvGrade.Columns[2].HeaderText = "课程号";
                dgrdvGrade.Columns[2].Width = 100;
                dgrdvGrade.Columns[3].HeaderText = "课程名";
                dgrdvGrade.Columns[3].Width = 150;
                dgrdvGrade.Columns[4].HeaderText = "学分";
                dgrdvGrade.Columns[4].Width = 100;
                dgrdvGrade.Columns[5].HeaderText = "开课学期";
                dgrdvGrade.Columns[5].Width = 150;
                dgrdvGrade.Columns[6].HeaderText = "成绩";
                dgrdvGrade.Columns[6].Width = 100;
                dgrdvGrade_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvGrade.DataSource = null;
                //MessageBox.Show("暂无此课程信息", "提示");
            }
        }
        //统计条件更改
        private void cmbCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCount.SelectedIndex == 5)
            {
                txtCountValue1.Text = "";
                txtCountValue2.Text = "";
                txtCountValue1.Enabled = true;
                txtCountValue2.Enabled = true;
            }
            else
            {
                txtCountValue1.Enabled = false;
                txtCountValue2.Enabled = false;
            }
            if (cmbCount.SelectedIndex == 0)
            {
                txtCountValue1.Text = "100";
                txtCountValue2.Text = "89";
            }
            else if (cmbCount.SelectedIndex == 1)
            {
                txtCountValue1.Text = "89";
                txtCountValue2.Text = "79";
            }
            else if (cmbCount.SelectedIndex == 2)
            {
                txtCountValue1.Text = "79";
                txtCountValue2.Text = "69";
            }
            else if (cmbCount.SelectedIndex == 3)
            {
                txtCountValue1.Text = "69";
                txtCountValue2.Text = "59";
            }
            else if (cmbCount.SelectedIndex == 4)
            {
                txtCountValue1.Text = "59";
                txtCountValue2.Text = "0";
            }

        }
        //录入
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select sno,cno from tb_grade where sno='" + txtSno.Text.Trim() + "' and cno='" + txtCno.Text.Trim() + "'";
                DataSet ds = new DataSet();
                ds = CDataBase.GetDataFromDB(sql);
                if (btnAdd.Text == "录入")
                {
                    btnAdd.Text = "确定";
                    cleraAll();
                    txtSno.Text = "";
                    txtCno.Text = "";
                    txtGarde.Text = "";
                    objOpen();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    return;
                }
                else if (txtSno.Text == "")
                {
                    MessageBox.Show("学号不能为空!", "提示");
                    txtSno.Focus();
                    return;
                }
                else if (txtCno.Text == "")
                {
                    MessageBox.Show("课程号不能为空", "提示");
                    txtCno.Focus();
                    return;
                }
                else if (ds != null )
                {
                    MessageBox.Show("该学生此成绩已存在,不能重复录入", "提示");
                    cleraAll();
                    txtSno.Focus();
                }

                btnAdd.Text = "录入";
                string sqlStr;
                sqlStr = "insert into tb_grade (Sno,Cno,grade) values ('" + txtSno.Text.Trim() + "','" + txtCno.Text.Trim()
                        + "','" + txtGarde.Text.Trim() + "')";
                CDataBase.UpdateDB(sqlStr);
                RefreshData();
                if (MessageBox.Show("录入成功,继续录入吗?", "录入成绩", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cleraAll();
                    objOpen();
                    btnAdd.Text = "确定";
                    btnAll_Click(sender, e);
                }
                else
                {
                    objClose();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnAll_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                cleraAll();
                objClose();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                dgrdvGrade_RowHeaderMouseClick(null, null);
            }


        }
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定要删除“" + txtSno.Text.Trim() + "”的资料吗?", "提示", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "delete from tb_grade where sno='" + txtSno.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr);
                    int n = dgrdvGrade.CurrentCell.RowIndex;
                    dgrdvGrade.Rows.RemoveAt(n);
                    if (dgrdvGrade.Rows.Count == 1)
                    {
                        cleraAll();
                        dgrdvGrade.DataSource = null;
                    }
                    else
                    {
                        dgrdvGrade_RowHeaderMouseClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnUpdate.Text == "修改")
                {
                    btnUpdate.Text = "确定";
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    txtSno.Enabled = false;
                    txtCno.Enabled = false;
                    txtGarde.Enabled = true;
                    txtGarde.Text = "";
                    txtGarde.Focus();
                }
                else
                {
                    btnUpdate.Text = "修改";
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    txtSno.Enabled = false;
                    txtCno.Enabled = false;
                    txtGarde.Enabled = false;
                    string sqlStr;
                    sqlStr = "update tb_grade set grade='" + txtGarde.Text.Trim() + "'where sno='" + txtSno.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
        //统计
        private void btnItemize_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCount.Text.Trim() == "")
                {
                    MessageBox.Show("请输入统计条件!", "提示!");
                    cmbCount.Focus();
                }
                else if (cmbCount.SelectedIndex == 5)
                {
                    if (txtCountValue1.Text.Trim() == "" & txtCountValue2.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入统计条件或统计值!", "提示!");
                        cmbCount.Focus();
                    }
                }
                string sqlStr;
                sqlStr = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.cname='" + cmbCourse.Text.Trim() + "' and grade between '" + txtCountValue2.Text.Trim() + "' and '" + txtCountValue1.Text.Trim() + "'";
                DataSet ds = new DataSet();
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds != null)
                {
                    dgrdvGrade.DataSource = ds.Tables[0];
                    dgrdvGrade.Columns[0].HeaderText = "学号";
                    dgrdvGrade.Columns[0].Width = 100;
                    dgrdvGrade.Columns[1].HeaderText = "姓名";
                    dgrdvGrade.Columns[1].Width = 150;
                    dgrdvGrade.Columns[2].HeaderText = "课程号";
                    dgrdvGrade.Columns[2].Width = 100;
                    dgrdvGrade.Columns[3].HeaderText = "课程名";
                    dgrdvGrade.Columns[3].Width = 150;
                    dgrdvGrade.Columns[4].HeaderText = "学分";
                    dgrdvGrade.Columns[4].Width = 100;
                    dgrdvGrade.Columns[5].HeaderText = "开课学期";
                    dgrdvGrade.Columns[5].Width = 150;
                    dgrdvGrade.Columns[6].HeaderText = "成绩";
                    dgrdvGrade.Columns[6].Width = 100;
                    dgrdvGrade_RowHeaderMouseClick(null, null);
                }
                else
                {
                    dgrdvGrade.DataSource = null;
                    txtCountValue1.Text = "";
                    txtCountValue2.Text = "";
                    MessageBox.Show("无此类信息", "提示");
                    cmbCourse.Focus();
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        //排序
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                //if (cmbSort.Text.Trim() == "")
                //{
                //    MessageBox.Show("请选择排序条件", "提示");
                //    cmbSort.Focus();
                //}
                string sqlStr1;
                    //, sqlStr2;
                sqlStr1 = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.cname='" + cmbCourse.Text.Trim() + "' ORDER BY grade DESC";
                //sqlStr2 = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.cname='" + cmbSemester.Text.Trim() + "' ORDER BY grade DESC";
                DataSet ds = new DataSet();
                //if (cmbSort.SelectedIndex == 0)
                //{
                    ds = CDataBase.GetDataFromDB(sqlStr1);
                    if (ds != null)
                    {
                        dgrdvGrade.DataSource = ds.Tables[0];
                        dgrdvGrade.Columns[0].HeaderText = "学号";
                        dgrdvGrade.Columns[0].Width = 100;
                        dgrdvGrade.Columns[1].HeaderText = "姓名";
                        dgrdvGrade.Columns[1].Width = 150;
                        dgrdvGrade.Columns[2].HeaderText = "课程号";
                        dgrdvGrade.Columns[2].Width = 100;
                        dgrdvGrade.Columns[3].HeaderText = "课程名";
                        dgrdvGrade.Columns[3].Width = 150;
                        dgrdvGrade.Columns[4].HeaderText = "学分";
                        dgrdvGrade.Columns[4].Width = 100;
                        dgrdvGrade.Columns[5].HeaderText = "开课学期";
                        dgrdvGrade.Columns[5].Width = 150;
                        dgrdvGrade.Columns[6].HeaderText = "成绩";
                        dgrdvGrade.Columns[6].Width = 100;
                        dgrdvGrade_RowHeaderMouseClick(null, null);
                    }
                }
                //else if (cmbSort.SelectedIndex == 1)
                //{
                //    ds = CDataBase.GetDataFromDB(sqlStr2);
                //    if (ds != null)
                //    {
                //        dgrdvGrade.DataSource = ds.Tables[0];
                //        dgrdvGrade.Columns[0].HeaderText = "学号";
                //        dgrdvGrade.Columns[0].Width = 100;
                //        dgrdvGrade.Columns[1].HeaderText = "姓名";
                //        dgrdvGrade.Columns[1].Width = 150;
                //        dgrdvGrade.Columns[2].HeaderText = "课程号";
                //        dgrdvGrade.Columns[2].Width = 100;
                //        dgrdvGrade.Columns[3].HeaderText = "课程名";
                //        dgrdvGrade.Columns[3].Width = 150;
                //        dgrdvGrade.Columns[4].HeaderText = "学分";
                //        dgrdvGrade.Columns[4].Width = 100;
                //        dgrdvGrade.Columns[5].HeaderText = "开课学期";
                //        dgrdvGrade.Columns[5].Width = 150;
                //        dgrdvGrade.Columns[6].HeaderText = "成绩";
                //        dgrdvGrade.Columns[6].Width = 100;
                //        dgrdvGrade_RowHeaderMouseClick(null, null);
                //    }
                //}
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            cmbCourse.SelectedIndex = -1;
            cmbSemester.SelectedIndex = -1;
            string sqlStr;
            sqlStr = "select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvGrade.DataSource = ds.Tables[0];
                dgrdvGrade.Columns[0].HeaderText = "学号";
                dgrdvGrade.Columns[0].Width = 100;
                dgrdvGrade.Columns[1].HeaderText = "姓名";
                dgrdvGrade.Columns[1].Width = 150;
                dgrdvGrade.Columns[2].HeaderText = "课程号";
                dgrdvGrade.Columns[2].Width = 100;
                dgrdvGrade.Columns[3].HeaderText = "课程名";
                dgrdvGrade.Columns[3].Width = 150;
                dgrdvGrade.Columns[4].HeaderText = "学分";
                dgrdvGrade.Columns[4].Width = 100;
                dgrdvGrade.Columns[5].HeaderText = "开课学期";
                dgrdvGrade.Columns[5].Width = 150;
                dgrdvGrade.Columns[6].HeaderText = "成绩";
                dgrdvGrade.Columns[6].Width = 100;
                dgrdvGrade_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvGrade.DataSource = null;
            }

               
        }

        private void cmbSemester_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCourse.SelectedIndex = -1;
            string sqlStr="select tb_grade.sno,tb_student.sname,tb_grade.cno,tb_course.cname,tb_course.cperiod,tb_course.csemester,tb_grade.grade from tb_student inner join tb_grade on tb_student.sno = tb_grade.sno join tb_course on tb_grade.cno = tb_course.cno where tb_course.csemester='" + cmbSemester.Text.Trim() + "'";
            DataSet ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvGrade.DataSource = ds.Tables[0];
                dgrdvGrade.Columns[0].HeaderText = "学号";
                dgrdvGrade.Columns[0].Width = 100;
                dgrdvGrade.Columns[1].HeaderText = "姓名";
                dgrdvGrade.Columns[1].Width = 150;
                dgrdvGrade.Columns[2].HeaderText = "课程号";
                dgrdvGrade.Columns[2].Width = 100;
                dgrdvGrade.Columns[3].HeaderText = "课程名";
                dgrdvGrade.Columns[3].Width = 150;
                dgrdvGrade.Columns[4].HeaderText = "学分";
                dgrdvGrade.Columns[4].Width = 100;
                dgrdvGrade.Columns[5].HeaderText = "开课学期";
                dgrdvGrade.Columns[5].Width = 150;
                dgrdvGrade.Columns[6].HeaderText = "成绩";
                dgrdvGrade.Columns[6].Width = 100;
                dgrdvGrade_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvGrade.DataSource = null;
                //MessageBox.Show("暂无该学期成绩", "提示");
            }

        }
    }
}