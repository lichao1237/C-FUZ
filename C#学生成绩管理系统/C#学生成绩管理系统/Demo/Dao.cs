using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo
{
    class Dao
    {

        public SqlConnection connection()
        {
            string str = "Data Source=LAPTOP-V9KMV7PC\\SQLEXPRESS01;Initial Catalog=SchoolDB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();//打开数据库连接
            return sc;
        }
        public SqlCommand command(string sql) 
        {
            SqlCommand sc = new SqlCommand(sql,connection());
            return sc;
        }

        //delecte update insert 
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //select
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}
