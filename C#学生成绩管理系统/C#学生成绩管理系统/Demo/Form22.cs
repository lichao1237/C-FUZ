using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{

    public partial class Form22 : Form
    {    
        string SID;
        string course;
        public Form22(string sID)
        {
            InitializeComponent();
            SID = sID;
            string sql = "SELECT course_name FROM  Teacher WHERE teacher_id = '" + SID + "';";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            dr.Read();
            string cr = dr["course_name"].ToString();
            course = cr;
            Table();
        }
        public string getcourse()
        {
            return this.course;
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT  student_id,course_name,grade, message FROM  Grade WHERE course_name = '"+ course+"';";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c,d;
                a = dr["student_id"].ToString();
                b = dr["course_name"].ToString();
                c = dr["grade"].ToString();
                d = dr["message"].ToString();
                string[] str = { a, b, c,d };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }

        private void 各科平均成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23=new Form23();
            form23.ShowDialog();
        }

        private void 学生成绩排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 form24=new Form24();
            form24.ShowDialog();
        }

        private void 添加学生成绩评语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form25 form25=new Form25(this);
            form25.ShowDialog();
        }

        private void 修改学生成绩评语ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString() };
            Form25 form25 = new Form25(str, this);
            form25.ShowDialog();
        }
    }
}
