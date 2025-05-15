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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
            Table();
        }

        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT s.student_id AS 学号, s.name AS 姓名, SUM(g.grade) AS 总分, RANK() OVER (ORDER BY SUM(g.grade) DESC) AS 排名 FROM  Student s JOIN  Grade g ON s.student_id = g.student_id GROUP BY s.student_id, s.name ORDER BY 总分 DESC;";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b,c,d;
                a = dr["学号"].ToString();
                b = dr["姓名"].ToString();
                c = dr["总分"].ToString();
                d = dr["排名"].ToString();
                string[] str = { a, b, c, d};
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
    }
}
