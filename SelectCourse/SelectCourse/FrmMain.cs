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
    public partial class FrmMain : Form
    {
        FrmStudent ob_FrmStudent;
        FrmCourse ob_FrmCourse;
        FrmSelectCourse ob_FrmSelectCourse;
        FrmGrade ob_FrmGrade;
        FrmDataBase ob_FrmDataBase;
        FrmRegist ob_FrmRegist;
        FrmUser ob_FrmUser;
        FrmChangePassword ob_FrmChangePassword;
        FrmOnlyGarde ob_FrmOnlyGarde;
        //FrmExplain ob_FrmExplain;
        //FrmHelp ob_FrmHelp;
        
        //通用段，不实例化
        


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = CPublic.userInfo[2].Trim() + "——" + CPublic.userInfo[0] + "," + "欢迎使用本系统";
            if (CPublic.userInfo[2].Trim() == "学生用户")
            {
                //lblShow.Visible = false;
                lblShow.Text = "以下功能只提供给管理员使用，如需操作，请使用权限重新登录";
                btnStudent.Enabled = false;
                btnCourse.Enabled = false;
                btnSelectCourse.Enabled = false;
                btnDataBase.Enabled = false;
                btnUser.Enabled = false;
                系统用户管理ToolStripMenuItem.Enabled = false;
            }
            else
            {
                lblShow.Text = CPublic.userInfo[2].Trim() + "——" + CPublic.userInfo[0] + "," + "欢迎使用本系统";
                lblWelcome.Visible = false;
            }
        }


        //菜单选项

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
          if ((ob_FrmStudent != null && !ob_FrmStudent.IsDisposed) ||
                (ob_FrmSelectCourse != null && !ob_FrmSelectCourse.IsDisposed) ||
                (ob_FrmGrade != null && !ob_FrmGrade.IsDisposed)  ||
                (ob_FrmDataBase != null && !ob_FrmDataBase.IsDisposed) || 
                (ob_FrmCourse != null && !ob_FrmCourse.IsDisposed) ||
                (ob_FrmRegist != null && !ob_FrmRegist.IsDisposed) ||
                (ob_FrmChangePassword != null && !ob_FrmChangePassword.IsDisposed) ||
                (ob_FrmOnlyGarde != null && !ob_FrmOnlyGarde.IsDisposed))
            {
                if (MessageBox.Show("有部分子系统尚未关闭，确认退出系统？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("谢谢使用，再见！", "");
                    Application.Exit();
                } 
          }
        else
          {
            Application.Exit();
          }
    
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FrmExplain ob_FrmExplain = new FrmExplain();
                ob_FrmExplain.Show();
        }

        private void 系统帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHelp ob_FrmHelp = new FrmHelp();
            ob_FrmHelp.Show();
        }


        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob_FrmRegist = new FrmRegist();
            ob_FrmRegist.Show();
        }

        private void 系统用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob_FrmUser = new FrmUser();
            ob_FrmUser.Show();
        }
        //菜单项结束





        //主窗体事件
        private void btnStudent_Click(object sender, EventArgs e)
        { 
            //if (ob_FrmCourse != null || !ob_FrmCourse.IsDisposed)        //测试一下
            //{
            //    ob_FrmCourse.Activate();
            //}

            if (ob_FrmStudent == null || ob_FrmStudent.IsDisposed)  //确保一次只开启一个窗体
            {
                ob_FrmStudent = new FrmStudent();
                ob_FrmStudent.Show();
            }
           
            else
            {
                ob_FrmStudent.Activate();
            }
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            if (ob_FrmCourse == null || ob_FrmCourse.IsDisposed)
            {
                ob_FrmCourse = new FrmCourse();
                ob_FrmCourse.Show();
            }
            else
            {
                ob_FrmCourse.Activate();
            }
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if ((ob_FrmGrade == null || ob_FrmGrade.IsDisposed) && (ob_FrmOnlyGarde == null || ob_FrmOnlyGarde.IsDisposed) )
            {

                if (CPublic.userInfo[2].Trim() == "学生用户")
                {
                    ob_FrmOnlyGarde = new FrmOnlyGarde();
                    ob_FrmOnlyGarde.Show();
                }
                else
                {
                    ob_FrmGrade = new FrmGrade();
                    ob_FrmGrade.Show();
                }
            }
            else
            {
                ob_FrmGrade.Activate();
            }
        }

        private void btnSelectCourse_Click(object sender, EventArgs e)
        {
            if (ob_FrmSelectCourse == null || ob_FrmSelectCourse.IsDisposed)
            {
                ob_FrmSelectCourse = new FrmSelectCourse();
                ob_FrmSelectCourse.Show();
            }
            else
            {
                ob_FrmSelectCourse.Activate();
            }
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            if (ob_FrmDataBase == null || ob_FrmDataBase.IsDisposed)
            {
                ob_FrmDataBase = new FrmDataBase();
                ob_FrmDataBase.Show();
            }
            else
            {
                ob_FrmDataBase.Activate();
            }
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((ob_FrmStudent != null && !ob_FrmStudent.IsDisposed) ||
                (ob_FrmSelectCourse != null && !ob_FrmSelectCourse.IsDisposed) ||
                (ob_FrmGrade != null && !ob_FrmGrade.IsDisposed) ||
                (ob_FrmDataBase != null && !ob_FrmDataBase.IsDisposed) ||
                (ob_FrmCourse != null && !ob_FrmCourse.IsDisposed))
            {
                MessageBox.Show("请退出其他子系统再重新登录!", "提示");
            }
            else
            {
                FrmLogin ob_FrmLogin = new FrmLogin();
                ob_FrmLogin.Show();
                this.Hide();
            }
            
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob_FrmChangePassword = new FrmChangePassword();
            ob_FrmChangePassword.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            系统用户管理ToolStripMenuItem_Click(sender, e);
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            重新登录ToolStripMenuItem_Click(sender, e);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            系统帮助ToolStripMenuItem1_Click(sender, e);
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            注册ToolStripMenuItem_Click(sender, e);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            修改密码ToolStripMenuItem_Click(sender, e);
        }






        //主窗体事件结束


    }
}
