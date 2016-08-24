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
    public partial class FrmDataBase : Form
    {
        public FrmDataBase()
        {
            InitializeComponent();
        }

        string backupPath = "";
        string restorePath = "";

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            sdlgBackup.FilterIndex = 0;
            sdlgBackup.FileName = "DBStudents";
            sdlgBackup.Filter = "Bak Files (*.bak)|*.bak|All Files(*.*)|*.*"; //选择类型
            if (sdlgBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = sdlgBackup.FileName.ToString();   //当前路径
                txtBackup.ReadOnly = true;
            }
            backupPath = txtBackup.Text.Trim();
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (backupPath == "")
                {
                    MessageBox.Show("请先选择数据库备份的路径", "提示");
                    return;
                }
                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                }
                this.Text = "正在备份.....";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;  

                string sqlStr = "Backup database DBStudents to disk ='" + backupPath + "'";
                SqlCommand sqlCom = new SqlCommand(sqlStr, CDataBase.conn);
                CDataBase.conn.Open();
                sqlCom.ExecuteNonQuery();
                CDataBase.conn.Close();
                if (MessageBox.Show("数据库备份成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }


        private void btnRestorePath_Click(object sender, EventArgs e)
        {
            odlgRestore.FilterIndex = 0;
            odlgRestore.FileName = "DBStudents";
            odlgRestore.Filter = "Bak Files (*.bak)|*.bak|All Files(*.*)|*.*";
            if (odlgRestore.ShowDialog() == DialogResult.OK)
            {
                txtResore.Text = odlgRestore.FileName.ToString();
                txtResore.ReadOnly = true;
            }
            restorePath = txtResore.Text.Trim();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (restorePath == "")
                {
                    MessageBox.Show("请先选择数据库恢复路径", "提示");
                    return;
                }

                
                this.Text = "正在还原.....";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;  //让光标变成沙漏状

                //关闭正在使用的数据库进程
                SqlConnection.ClearAllPools();
                string conStr = "data source=.;database=master;Integrated Security=True";
                CDataBase.conn.ConnectionString = conStr;
                CDataBase.conn.Open();
                string sqlStr = "select spid from master..sysprocesses where dbid=db_id('DBStudent')";
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr,CDataBase.conn);
                DataTable spidTable = new DataTable();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = CDataBase.conn;
                for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
                {
                    //强行关闭用户进程
                    cmd1.CommandText = "kill " + spidTable.Rows[iRow][0].ToString();
                    cmd1.ExecuteNonQuery();
                }
                CDataBase.conn.Close();
                CDataBase.conn.Dispose();
                string restoreStr = "use master restore database DBstudents from disk='" + restorePath
                    + "'" + " with replace";
                CDataBase.conn.ConnectionString = CDataBase.connStr;
                CDataBase.conn.Open();
                SqlCommand cmd2 = new SqlCommand(restoreStr,CDataBase.conn);
                cmd2.ExecuteNonQuery();
                CDataBase.conn.Close();
                if (MessageBox.Show("数据恢复成功","提示",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDataBase_Load(object sender, EventArgs e)
        {

        }
    }
}
