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

    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }


        //通用方法
        void ClearAll()
        {
            txtUserName.Text = "";
            txtUserPasswors.Text = "";
            cmbPurview1.SelectedIndex = 0;
        }

        //void ClearAll2()
        //{
        //    txtSelect.Text = "";
        //    cmdPurview2.Text = "管理员";
        //}

        void ObjOpen()
        {
            txtUserName.Enabled = true;
            txtUserPasswors.Enabled = true;
            cmbPurview1.Enabled = true;
            txtUserName.Focus();
        }
        void  ObjClose()
        {
            txtUserName.Enabled = false;
            txtUserPasswors.Enabled = false;
            cmbPurview1.Enabled = false;
            txtUserName.Focus();
        }

        bool UserName(string userName)
        {
            string sqlStr = "select userName from tb_User where UserName='" + txtUserName.Text.Trim() + " '";
            SqlCommand cmd = new SqlCommand(sqlStr, CDataBase.conn);
            CDataBase.conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                CDataBase.conn.Close();
                return false;
            }
            CDataBase.conn.Close();
            return true;
        }






        //窗体载入




        private void btnRegedit_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (btnRegedit.Text == "注册")
                {
                    btnRegedit.Text = "确定";
                    ObjOpen();
                }
                else if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空!", "提示");
                    txtUserName.Focus();
                }

                else if (txtUserPasswors.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空!", "提示");
                    txtUserPasswors.Focus();
                }
                else if (!UserName(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("该用户已存在,请使用其他账号注册!", "提示");
                    txtUserName.Text = "";
                    ClearAll();
                }
                else
                {
                    btnRegedit.Text = "注册";
                    string sqlStr = "insert into tb_User values('" + txtUserName.Text.Trim() + "','" + txtUserPasswors.Text.Trim() + "','" + cmbPurview1.Text.Trim() + "','是')";
                    if (CDataBase.UpdateDB(sqlStr))
                    {
                        MessageBox.Show(cmbPurview1.Text + " " + txtUserName.Text + "注册成功!", "注册用户");
                    }
                    ClearAll();
                    ObjClose();
                    //btnCancel.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
                ObjClose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认取消注册?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            cmbPurview1.SelectedIndex = 1;
        }

    }
}
