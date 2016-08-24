using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace SelectCourse
{
    public partial class FrmLogin : Form
    {
        string path = Application.StartupPath + "\\" + "Dbset.ini"; 

        public FrmLogin()
        {
            InitializeComponent();
        }

        //用户登录界面
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空!", "错误");
                    txtUsername.Focus();
                    return;
                }
                else if (txtUserpassword.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空!", "错误");
                    txtUserpassword.Focus();
                    return;
                }
                this.Text = "正在验证......";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;  //让光标变成沙漏状
              
                string sqlStr = "select userPassword ,userPurview,firstLogin from tb_User where userName='" + txtUsername.Text.Trim() + "'";
                DataSet ds = new DataSet();
                CDataBase.conn.ConnectionString = CDataBase.connStr;         
                CDataBase.conn.Open();
                //SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, CDataBase.conn);
                //adapter.Fill(ds);  
                //数据集登录方法
                             
                SqlCommand cmd = new SqlCommand(sqlStr, CDataBase.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                //if (ds.Tables[0].Rows.Count == 0)                      // 如果table中没有数据   
                if (!sdr.Read())
                {
                    MessageBox.Show("用户名错误！请重新输入", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "用户登录";
                    txtUsername.Text = "";
                    txtUserpassword.Text = "";
                    txtUsername.Focus();
                }

                //else if (ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim() == txtUserpassword.Text.Trim())
                //数据集登录方法

                else if (sdr["userPassword"].ToString().Trim() == txtUserpassword.Text.Trim())
                {
                    FrmMain ob_FrmMain = new FrmMain();
                    CPublic.userInfo[0] = txtUsername.Text.Trim();
                    CPublic.userInfo[1] = txtUserpassword.Text.Trim();

                    //CPublic.userInfo[2] = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                    //CPublic.userInfo[3] = ds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
                    //数据集登录方法

                    CPublic.userInfo[2] = sdr["userPurview"].ToString().Trim();
                    CPublic.userInfo[3] = sdr["firstLogin"].ToString().Trim();
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "用户登录";
                    ob_FrmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("密码错误！请重新输入", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "用户登录";
                    txtUserpassword.Text = "";
                    txtUserpassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录异常");
                this.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.Text = "用户登录";
                txtUsername.Text = "";
                txtUserpassword.Text = "";
                txtUsername.Focus();
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //密码处敲回车
        private void txtUserpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
        //数据库配置
        private void FrmLogin_Load(object sender, EventArgs e)
        {

            try
            {

                if (File.Exists(path))
                {
                    StreamReader sr = new StreamReader(path, Encoding.GetEncoding("GB2312"));
                    CDataBase.connStr = sr.ReadLine();
                    
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("初次使用，请配置数据库", "提示");
                    this.Height = 450;
                    txtUsername.Enabled = false;
                    txtUserpassword.Enabled = false;
                    btnLogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //配置按钮
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.Height == 230)
            {
                this.Height = 440;
                txtUsername.Enabled = false;
                txtUserpassword.Enabled = false;
                btnLogin.Enabled = false;
                txtServerWin.Focus();
            }
            else
            {
                this.Height = 230;
                txtUsername.Enabled = true;
                txtUserpassword.Enabled = true;
                btnLogin.Enabled = true;
                txtUsername.Focus();
            }
        }



        //Windows配置确认键
        private void btnOkWin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServerWin.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库服务器名称!", "提示");
                    txtServerWin.Focus();
                }
                else if (txtDataBaseWin.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库名称!", "提示");
                    txtDataBaseWin.Focus();
                }
                else
                {
                    this.Height = 230;
                    StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("GB2312"));
                    string connStr = "server=" + txtServerWin.Text.Trim() + "; database=" + txtDataBaseWin.Text.Trim() + ";Integrated Security=True";
                    sw.WriteLine(connStr);
                    sw.Close();
                    txtUsername.Enabled = true;
                    txtUserpassword.Enabled = true;
                    btnLogin.Enabled = true;
                    txtUsername.Focus();
                    CDataBase.connStr = connStr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Windows配置取消键
        private void btnCancelWin_Click(object sender, EventArgs e)
        {
            this.Height = 230;
            txtUsername.Enabled = true;
            txtUserpassword.Enabled = true;
            btnLogin.Enabled = true;
            txtUsername.Focus();
        }
        //sql-server配置确认键
        private void btnOkSql_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServerSql.Text.Trim() == "")
                {
                    MessageBox.Show("请输入服务器名称", "提示");
                    txtServerSql.Focus();
                }
                else if (txtDataBaseSql.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库名称", "提示");
                }
                else
                {
                    this.Height = 230;
                    StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("GB2312"));
                    string connStr = "server=" + txtServerSql.Text.Trim() + ";database=" + txtDataBaseSql.Text.Trim() + ";uid=" + txtUserSql.Text.Trim() + ";pwd=" + txtUserPasswordSql;
                    sw.WriteLine(connStr);
                    sw.Close();
                    txtUsername.Enabled = true;
                    txtUserpassword.Enabled = true;
                    btnLogin.Enabled = true;
                    txtUsername.Focus();
                    CDataBase.connStr = connStr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //sql-server配置取消键
        private void btnCancelSql_Click(object sender, EventArgs e)
        {
            btnCancelWin_Click(sender, e);
            //this.Height = 230;
            //txtUsername.Enabled = true;
            //txtUserpassword.Enabled = true;
            //btnLogin.Enabled = true;
            //txtUsername.Focus();
        }


        //测试应用
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string str1 = "admin", str2 = "123456";
                txtUsername.Text = str1;
                txtUserpassword.Text = str2;
                txtUserpassword.Focus();
            }
            else
            {
                txtUsername.Text = "";
                txtUserpassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string str1 = "student", str2 = "123456";
                txtUsername.Text = str1;
                txtUserpassword.Text = str2;
                txtUserpassword.Focus();
            }
            else
            {
                txtUsername.Text = "";
                txtUserpassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void txtDataBaseWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOkWin_Click(sender ,e);
        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
 