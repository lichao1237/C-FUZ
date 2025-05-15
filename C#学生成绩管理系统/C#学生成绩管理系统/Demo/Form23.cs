using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT course_name AS 课程名称, AVG(grade) AS 平均成绩 FROM Grade GROUP BY course_name";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b;
                a = dr["课程名称"].ToString();
                b = dr["平均成绩"].ToString();
                string[] str = { a, b};
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
    }
}
