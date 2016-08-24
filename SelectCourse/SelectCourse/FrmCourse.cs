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
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void dgrdvCourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = dgrdvCourse.CurrentCell.RowIndex;
                if ( n <dgrdvCourse.RowCount - 1)
                {
                    txtNo.Text = dgrdvCourse[0,n].Value.ToString().Trim();
                    txtName.Text = dgrdvCourse[1,n].Value.ToString().Trim();
                    txtCredit.Text = dgrdvCourse[2,n].Value.ToString().Trim();
                    txtPeriod.Text = dgrdvCourse[3,n].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        void ObjOpen()
        {
            txtNo.Enabled = true;
            txtName.Enabled = true;
            txtCredit.Enabled = true;
            txtPeriod.Enabled = true;
            cmbSemester.Enabled = true;
            txtNo.Focus();
        }


        void ObjClose()
        {
            txtNo.Enabled = false;
            txtName.Enabled = false;
            txtCredit.Enabled = false;
            txtPeriod.Enabled = false ;
            cmbSemester.Enabled = false;
            txtNo.Focus();
        }

        void ClearAll()
        {
            txtNo.Text = "";
            txtName.Text = "";
            txtCredit.Text = "";
            txtPeriod.Text = "";
            cmbSemester.SelectedIndex = 0;
        }
        void RefreshData()
        {
            string sqlStr;
            DataSet ds = new DataSet();
            sqlStr = "select * from tb_Course";
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvCourse.DataSource = ds.Tables[0];
                dgrdvCourse.Columns[0].HeaderText = "课程号";
                dgrdvCourse.Columns[0].Width = 150;
                dgrdvCourse.Columns[1].HeaderText = "课程名";
                dgrdvCourse.Columns[1].Width = 200;
                dgrdvCourse.Columns[2].HeaderText = "课程学分";
                dgrdvCourse.Columns[2].Width = 80;
                dgrdvCourse.Columns[3].HeaderText = "课程学时";
                dgrdvCourse.Columns[3].Width = 80;
                dgrdvCourse.Columns[4].HeaderText = "开课学期";
                dgrdvCourse.Columns[4].Width = 150;
                dgrdvCourse_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvCourse.DataSource = null;
            }
        }

        bool No(string no)
        {
            int n = dgrdvCourse.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (no == dgrdvCourse.Rows[i].Cells[0].Value.ToString().Trim())
                return false;
            }
            return true;
        }



        private void FrmCourse_Load(object sender, EventArgs e)
        {
            try
            {
                ObjClose();
                RefreshData();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtName.Enabled)      //为什么使用txtName而不是txtNo?
            {
                if (MessageBox.Show("数据尚未保存，确认退出？", "提示", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text.Trim() == "添加")
                {
                    btnAdd.Text = "确定";
                    btnCancel1.Visible = true;
                    ObjOpen();
                    ClearAll();
                    RefreshData();
                    btnUpdata.Enabled = false;
                    btnDelete.Enabled = false;
                    dgrdvCourse.Enabled = false;
                    return;
                }
                else if (txtNo.Text.Trim() == "")
                {
                    MessageBox.Show("课程号不能为空", "提示");
                    txtNo.Focus();
                    return;
                }
                else if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("课程名不能为空", "提示");
                    txtName.Focus();
                    return;
                }
                else if (txtCredit.Text.Trim() == "")
                {
                    MessageBox.Show("课程学分不能为空", "提示");
                    txtCredit.Focus();
                    return;
                }
                else if (txtPeriod.Text.Trim() == "")
                {
                    MessageBox.Show("课程学时不能为空", "提示");
                    txtPeriod.Focus();
                    return;
                }
                else if (cmbSemester.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择开课学期", "提示");
                    cmbSemester.Focus();
                    return;
                }
                else if (!No(txtNo.Text.Trim()))
                {
                    MessageBox.Show("该课程已有", "提示");
                    txtNo.Text = "";
                    txtNo.Focus();
                    return;
                }
                btnCancel1.Visible = false;
                btnAdd.Text = "添加";
                string sqlStr;
                sqlStr = "insert into tb_Course values('" + txtNo.Text.Trim() + "','" + txtName.Text.Trim() + "','"
                    + txtCredit.Text.Trim() + "','" + txtPeriod.Text.Trim() + "','" + cmbSemester.Text.Trim() + "')";
                CDataBase.UpdateDB(sqlStr);
                RefreshData();
                if (MessageBox.Show("添加成功,继续添加吗?", "添加课程信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    btnCancel1.Visible = true;
                    ClearAll();
                    ObjOpen();
                    btnAdd.Text = "确定";
                }
                else
                {
                    ObjClose();
                    btnUpdata.Enabled = false;
                    btnDelete.Enabled = false;
                    dgrdvCourse.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ObjClose();
                btnUpdata.Enabled = true;
                btnDelete.Enabled = true;
                dgrdvCourse.Enabled = true;
                dgrdvCourse_RowHeaderMouseClick(null, null);
            }
        }
        //添加取消
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            btnCancel1.Visible = false;
            btnAdd.Text = "添加";
            ObjClose();
            btnUpdata.Enabled = true;
            btnDelete.Enabled = true;
            dgrdvCourse.Enabled = true;
        }

        //修改
        private void btnUpdata_Click(object sender, EventArgs e)  //为什么课程号不能修改?——要用课程号作为修改条件
        {
            try
            {
                if (btnUpdata.Text == "修改")
                {
                    btnUpdata.Text = "确定";
                    btnCancel2.Visible = true;
                    ObjOpen();
                    txtNo.Enabled = false;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    dgrdvCourse.Enabled = false;
                    txtName.Focus();
                }
                else
                {
                    btnUpdata.Text  = "修改";
                    btnCancel2.Visible = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    dgrdvCourse.Enabled = true;
                    ObjClose();
                    string sqlStr;
                    sqlStr = "update tb_Course set Cname='" + txtName.Text.Trim() + "',Ccredit='" + txtCredit.Text.Trim()
                        + "',Cperiod='" + txtPeriod.Text.Trim() + "',Csemester='" + cmbSemester.Text.Trim() +  "'where Cno='" + txtNo.Text.Trim() + "'";
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
        //修改取消
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            btnUpdata.Text = "修改";
            btnCancel2.Visible = false;
            ObjClose();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            dgrdvCourse.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNo.Text.Trim() == "")
                {
                    MessageBox.Show("木有可删除的记录", "提示");
                    return;
                }
                string sqlStr;
                sqlStr = "select * from tb_Select where cno='" + txtNo.Text.Trim() + "'";
                if (CDataBase.GetDataFromDB(sqlStr) != null)
                {
                    MessageBox.Show("已有该课程的选课信息,拒绝删除!", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("确定删除课程“" + txtName.Text.Trim() + "”吗?", "删除课程信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    sqlStr = "delete from tb_course where cno='" + txtNo.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr);
                    int n = dgrdvCourse.CurrentCell.RowIndex;
                    dgrdvCourse.Rows.RemoveAt(n);
                    if (dgrdvCourse.Rows.Count == 1)
                    {
                        ClearAll();
                        dgrdvCourse.DataSource = null;
                    }
                    else
                    {
                        dgrdvCourse_RowHeaderMouseClick(null, null);
                    }
                }
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


    }

}
