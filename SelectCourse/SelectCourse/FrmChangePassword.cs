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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        void CleaAll()
        {
            txtOldPassWord.Text = "";
            txtNewPassWord.Text = "";
            txtMatcPassWord.Text = "";
        }

        private void changePassword_Load(object sender, EventArgs e)
        {
            lblShow.Text = "正在给用户 —— “" + CPublic.userInfo[0] + "” 修改密码。";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassWord.Text == "")
                {
                    MessageBox.Show("请输入原密码!", "提示");
                    txtOldPassWord.Focus();
                }
                else if (txtNewPassWord.Text == "")
                {
                    MessageBox.Show("请输入新密码", "提示");
                    txtNewPassWord.Focus();
                }
                else if (txtMatcPassWord.Text == "")
                {
                    MessageBox.Show("请再次输入密码", "提示");
                    txtMatcPassWord.Focus();
                }
                else if (txtNewPassWord.Text.Trim() == txtMatcPassWord.Text.Trim())
                {
                    string sql = "select userpassword from tb_User where username='" + CPublic.userInfo[0] + "'";
                    DataSet ds = new DataSet();
                    CDataBase.conn.ConnectionString = CDataBase.connStr;
                    CDataBase.conn.Open();
                    //SqlCommand cmd = new SqlCommand(sql, CDataBase.conn);
                    //SqlDataReader sdr = cmd.ExecuteReader();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, CDataBase.conn);
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim() == txtOldPassWord.Text.Trim())
                    {
                        string sqlStr;
                        CDataBase.conn.Close();
                        sqlStr = "update tb_User set userPassword='" + txtNewPassWord.Text.Trim() + "'"
                            + "where userName ='" + CPublic.userInfo[0] + "'";
                        if (CDataBase.UpdateDB(sqlStr))
                        {
                            
                            MessageBox.Show("修改成功!", "提示");
                        }
                        CleaAll();
                    }
                    else
                    {
                        MessageBox.Show("原密码错误", "提示");
                        CleaAll();
                        txtOldPassWord.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一样，重新输入!", "提示");
                    txtNewPassWord.Text = "";
                    txtMatcPassWord.Text = "";
                    txtNewPassWord.Focus();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMatcPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(sender, e);
        }
    }
}
