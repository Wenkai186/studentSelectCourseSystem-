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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        void ObjOpen()
        {
            txtNo.Enabled = true;
            txtClass.Enabled = true;
            txtName.Enabled = true;
            txtAge.Enabled = true;
            cmbSex.Enabled = true;
            txtDept.Enabled = true;
            txtNo.Focus();
        }

        void Objclose()
        {
            txtNo.Enabled = false;
            txtName.Enabled = false;
            txtClass.Enabled = false;
            txtAge.Enabled = false;
            cmbSex.Enabled = false;
            txtDept.Enabled = false;
            txtNo.Focus();
        }

        void ClearAll()
        {
            txtNo.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
            txtAge.Text = "";
            txtDept.Text = "";
            cmbSex.SelectedIndex = -1;
        }
        //更新表
        void RefreshData()
        {
            string sqlStr;
            DataSet ds = new DataSet();
            sqlStr = "select * from tb_Student";
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvStudent.DataSource = ds.Tables[0];
                dgrdvStudent.Columns[0].HeaderText = "学生学号";
                dgrdvStudent.Columns[0].Width = 168;
                dgrdvStudent.Columns[1].HeaderText = "学生姓名";
                dgrdvStudent.Columns[1].Width = 159;
                dgrdvStudent.Columns[2].HeaderText = "学生性别";
                dgrdvStudent.Columns[2].Width = 88;
                dgrdvStudent.Columns[3].HeaderText = "学生年龄";
                dgrdvStudent.Columns[3].Width = 88;
                dgrdvStudent.Columns[4].HeaderText = "学生班级";
                dgrdvStudent.Columns[4].Width = 100;
                dgrdvStudent.Columns[5].HeaderText = "所在学院（系别）";
                dgrdvStudent.Columns[5].Width = 159;
                dgrdvStudent_RowHeaderMouseClick(null, null);
            }
            else
            {
                dgrdvStudent.DataSource = null;
            }
        }

        //判断信息是否存在
        bool No(string no)
        {
            int n=dgrdvStudent.Rows.Count;
            for (int i = 0;i < n-1; i++)
            {
                if (no == dgrdvStudent.Rows[i].Cells[0].Value.ToString().Trim())
                return false;
            }
            return true;
        }

        //把数据表中的数据拉进控件中
        private void dgrdvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = dgrdvStudent.CurrentCell.RowIndex;
                if (n < dgrdvStudent.RowCount - 1)
                {
                    txtNo.Text = dgrdvStudent[0, n].Value.ToString().Trim();
                    txtName.Text = dgrdvStudent[1, n].Value.ToString().Trim();
                    cmbSex.Text = dgrdvStudent[2, n].Value.ToString().Trim();
                    txtAge.Text = dgrdvStudent[3, n].Value.ToString().Trim();
                    txtClass.Text = dgrdvStudent[4, n].Value.ToString().Trim();
                    txtDept.Text = dgrdvStudent[5, n].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //进入窗体
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "学生信息管理";
                Objclose();
                RefreshData();
                cmbSelect.SelectedIndex = 6;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        //关闭窗体
        private void FrmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtName.Enabled)
            {
                if (MessageBox.Show("数据未保存,确认退出?", "询问", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        //退出
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出系统?", "询问", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            this.Close();
        }
        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {                    
                if (btnAdd.Text == "添加")
                {
                    btnCancel.Visible = true;
                    btnAdd.Text = "确定";
                   
                    ClearAll();      //这句无法工作
                    
                    cmbSex.SelectedIndex = -1;
                    
                    ObjOpen();
                    RefreshData();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSelect.Enabled = false;
                    cmbSelect.Enabled = false;
                    txtSelect.Enabled = false;
                    dgrdvStudent.Enabled = false;
                    return;
                }
                else if (txtNo.Text.Trim() == "")
                {
                    MessageBox.Show("学号不能为空!", "提示");
                    txtNo.Focus();
                    return;
                }
                else if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("姓名不能为空!", "提示");
                    txtName.Focus();
                    return;
                }
                else if (txtClass.Text.Trim() == "")
                {
                    MessageBox.Show("班级不能为空!", "提示");
                    txtClass.Focus();
                    return;
                }
                else if (cmbSex.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择性别", "提示");
                    cmbSex.Focus();
                    return;
                }
                else if (txtDept.Text == "")
                {
                    MessageBox.Show("所属学院(系别)不能为空!", "提示");
                    txtDept.Focus();
                    return;
                }
                else if (txtAge.Text.Trim() == "")
                {
                    MessageBox.Show("年龄不能为空!", "提示");
                    txtAge.Focus();
                    return;
                }
                else if (!No(txtNo.Text.Trim()))
                {
                    MessageBox.Show("该学号已存在,请重新输入!", "提示");
                    txtNo.Focus();
                    return;
                }

                btnAdd.Text = "添加";
                btnCancel.Visible = false;
                btnCancel2.Visible = false;

                string sqlStr;
                sqlStr = "insert into tb_Student values('"+txtNo.Text.Trim()+"','"+txtName.Text.Trim()+"','"+cmbSex.Text.Trim()+"','"+txtAge.Text.Trim()+"','"+txtClass.Text.Trim()+"','"+txtDept.Text.Trim()+"')";
                CDataBase.UpdateDB(sqlStr);
                RefreshData();

                if (MessageBox.Show("添加成功,继续添加吗?", "添加学生信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    btnCancel.Visible = true;
                    ClearAll();
                    ObjOpen();
                    btnAdd.Text = "确定";
                }
                else
                {
                    Objclose();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSelect.Enabled = true;
                    cmbSelect.Enabled = true;
                    txtSelect.Enabled = true;
                    dgrdvStudent.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
                Objclose();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSelect.Enabled = true;
                cmbSelect.Enabled = true;
                txtSelect.Enabled = true;
                dgrdvStudent.Enabled = true;
                dgrdvStudent_RowHeaderMouseClick(null, null);

            }
        }
        //添加取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "添加";
            btnCancel.Visible = false;
            Objclose();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSelect.Enabled = true;
            cmbSelect.Enabled = true;
            txtSelect.Enabled = true;
            dgrdvStudent.Enabled = true;

        }
        //修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnUpdate.Text.Trim() == "修改")
                {
                    MessageBox.Show("学号不能修改", "注意");
                    btnUpdate.Text = "确定";
                    btnCancel2.Visible = true;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    cmbSelect.Enabled = false;
                    btnSelect.Enabled = false;
                    txtSelect.Enabled = false;
                    txtName.Enabled = true;
                    txtAge.Enabled = true;
                    txtClass.Enabled = true;
                    txtDept.Enabled = true;
                    cmbSex.Enabled = true;
                    txtName.Focus();
                    
                }
                else
                {
                    btnUpdate.Text = "修改";
                    btnCancel2.Visible = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    cmbSelect.Enabled = true;
                    btnSelect.Enabled = true;
                    Objclose();
                    string sqlStr;
                    sqlStr = "update tb_student set Sname='" + txtName.Text.Trim() + "',Ssex='" + cmbSex.Text.Trim() + "',Sage='"
                        + txtAge.Text.Trim() + "',Sclass='" + txtClass.Text.Trim() + "',Sdept='" + txtDept.Text.Trim() + "'where sno='"
                        + txtNo.Text.Trim() + "'";
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
            btnUpdate.Text = "修改";
            btnCancel2.Visible = false;
            Objclose();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSelect.Enabled = true;
            cmbSelect.Enabled = true;
            txtSelect.Enabled = true;
            dgrdvStudent.Enabled = true;
        }
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNo.Text.Trim() == "")
                {
                    MessageBox.Show("没有可删除的记录", "提示");
                    return;
                }
                else if (MessageBox.Show("确定要删除“" + txtName.Text.Trim() + "”的资料吗?", "提示", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "delete from tb_student where Sno='" + txtNo.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr);
                    int n = dgrdvStudent.CurrentCell.RowIndex;
                    dgrdvStudent.Rows.RemoveAt(n);

                    if (dgrdvStudent.Rows.Count == 1)
                    {
                        ClearAll();
                        dgrdvStudent.DataSource = null;
                    }
                    else
                    {
                        dgrdvStudent_RowHeaderMouseClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
        //查询条件更改
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex == 6)
            {
                txtSelect.Text = "返回所有信息";
                txtSelect.Enabled = false;
            }
            else
            {
                txtSelect.Text = "";
                txtSelect.Enabled = true;
                txtSelect.Focus();
            }
        }
        //查询
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                if (txtSelect.Text.Trim() == "")
                {
                    MessageBox.Show("请输入需要查询的" + cmbSelect.SelectedItem.ToString().Trim() + "提示");
                    
                    return;
                }
                else if (cmbSelect.SelectedIndex == 0)
                    sqlStr = "select * from tb_Student where Sno='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 1)
                    sqlStr = "select * from tb_Student where Sname like'" + txtSelect.Text.Trim() + "%'";
                else if (cmbSelect.SelectedIndex == 2)
                    sqlStr = "select * from tb_Student where Ssex='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 3)
                    sqlStr = "select * from tb_Student where Sage='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 4)
                    sqlStr = "select * from tb_Student where Sclass='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 5)
                    sqlStr = "select * from tb_Student where Sdept='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 6)
                {

                    sqlStr = "select * from tb_student";

                }
                DataSet ds = new DataSet();
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds != null)
                {
                    dgrdvStudent.DataSource = ds.Tables[0];
                    dgrdvStudent.Columns[0].HeaderText = "学生学号";
                    dgrdvStudent.Columns[0].Width = 168;
                    dgrdvStudent.Columns[1].HeaderText = "学生姓名";
                    dgrdvStudent.Columns[1].Width = 159;
                    dgrdvStudent.Columns[2].HeaderText = "学生性别";
                    dgrdvStudent.Columns[2].Width = 88;
                    dgrdvStudent.Columns[3].HeaderText = "学生年龄";
                    dgrdvStudent.Columns[3].Width = 88;
                    dgrdvStudent.Columns[4].HeaderText = "学生班级";
                    dgrdvStudent.Columns[4].Width = 100;
                    dgrdvStudent.Columns[5].HeaderText = "所在学院（系别）";
                    dgrdvStudent.Columns[5].Width = 159;
                    dgrdvStudent_RowHeaderMouseClick(null, null);
                }
                else
                {
                    dgrdvStudent.DataSource = null;
                    ClearAll();
                    MessageBox.Show("没有该条记录,请重新查询。", "提示");
                    RefreshData();
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
