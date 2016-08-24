using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SelectCourse
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        void SetHeadText()
        {
            dataGridView1.Columns[0].HeaderText = "用户名";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].HeaderText = "用户权限";
            dataGridView1.Columns[1].Width = 200;
        }


        //用于显示同步数据
        void RefreshData()
        {
            DataSet myDs = new DataSet();      
            string sqlStr = "select userName,userPurview from tb_User";
            myDs = CDataBase.GetDataFromDB(sqlStr);
            if (myDs != null)
            {
                dataGridView1.DataSource = myDs.Tables[0];
                SetHeadText();
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }



        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“testDataSet.tb1_User”中。您可以根据需要移动或移除它。
            //this.tb1_UserTableAdapter.Fill(this.testDataSet.tb1_User);
            RefreshData();
            cmbPurivew.SelectedIndex = 0;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出系统用户管理界面？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }


        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //RefreshData();
                string userName;
                int n = this.dataGridView1.CurrentCell.RowIndex;
                userName = this.dataGridView1.Rows[n].Cells[0].Value.ToString().Trim();               
                if (MessageBox.Show("确认删除 " + userName + " 吗?", "删除用户", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    
                    string sqlStr = "delete from tb_User where userName='" + userName + "'";
                    CDataBase.UpdateDB(sqlStr);
                    dataGridView1.Rows.RemoveAt(n);               
                }
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
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入要查询用户的关键字", "提示");
                    txtUserName.Focus();
                    return;
                }
                string sqlStr = "select * from tb_user where userName='" + txtUserName.Text.Trim() + "'";
                DataSet ds = new DataSet();
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds != null)
                {
                    txtUserName.Text = "";
                    dataGridView1.DataSource = ds.Tables[0];
                    SetHeadText();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    txtUserName.Text = "";
                    MessageBox.Show("没有该用户", "提示");
                    RefreshData();
                    SetHeadText();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        
        //拉取数据
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = dataGridView1.CurrentCell.RowIndex;
                if (n < dataGridView1.Rows.Count - 1)
                {
                    textBox1.Text = dataGridView1[0,n].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "update tb_user set userPurview='" + cmbPurivew.Text.Trim() + "'" + "where userName='" + textBox1.Text.Trim() + "'";
                CDataBase.UpdateDB(sqlStr);
                RefreshData();
                SetHeadText();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        }
}
