using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SelectCourse
{
    class CDataBase
    {
        public static string connStr = "Data Source = . ;Initial Catalog = DBStudents; Integrated Security = True";

        //public static string connStr;
        public static SqlConnection conn = new SqlConnection(connStr);
       
        

        //读取数据
        public static DataSet GetDataFromDB(string sqlStr)
        {
            
            conn.Open();
            SqlDataAdapter MyAdapter = new SqlDataAdapter(sqlStr,conn);
            DataSet MyDataSet = new DataSet();
            MyDataSet.Clear();
            MyAdapter.Fill(MyDataSet); //在 DataSet 中添加或刷新行以匹配使用 DataSet 和 DataTable 名称的数据源中的行
            conn.Close();
            if (MyDataSet.Tables[0].Rows.Count != 0)
            {
                return MyDataSet;
            }
            else
            {
                return null;
            }
        }
        //写数据
        public static bool UpdateDB(string sqlStr)
        {           
            conn.Open();
            SqlCommand myCmd = new SqlCommand(sqlStr ,conn);            
            myCmd.CommandType = CommandType.Text;  
            myCmd.ExecuteNonQuery();//执行sql语句
            conn.Close();

            return true;
        }
    }
}
