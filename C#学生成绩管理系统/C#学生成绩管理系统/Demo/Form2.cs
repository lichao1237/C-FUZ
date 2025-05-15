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
    public partial class Form2 : Form
    {
        string SID;
        string course;
        public Form2(string sID)
        {
            SID = sID;
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "SELECT course_name FROM  Teacher WHERE teacher_id = '"+SID+"';";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            dr.Read();
            string cr = dr["course_name"].ToString();
            course = cr;
            timer1.Start();
            toolStripStatusLabel1.Text = "欢迎工号为" + SID + "的老师加入本系统";
            Table();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 学生成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22(SID);
            form22.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        //让表显示数据
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from Student;";
            Dao dao =new Dao();
            IDataReader dr=dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d;
                a = dr["student_id"].ToString();
                b = dr["name"].ToString();
                c = dr["class"].ToString();
                d = dr["hometown"].ToString();
                string[] str = {a,b,c,d};
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确认要删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
            string student_id, name;
            student_id = dataGridView1.SelectedCells[0].Value.ToString();
            name = dataGridView1.SelectedCells[1].Value.ToString();
            string sql = "delete from Student where student_id='" + student_id + "' and name ='" + name + "'";
            Dao dao=new Dao();
            dao.Excute(sql);
            Table();
            }
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 f= new Form21(this);
            f.ShowDialog();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //传递数据
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(),dataGridView1.SelectedCells[1].Value.ToString(),dataGridView1.SelectedCells[2].Value.ToString(),dataGridView1.SelectedCells[3].Value.ToString() };
            //MessageBox.Show(str[0] + str[1] + str[2] +str[3]);
            Form21 f = new Form21(str,this);
            f.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 form22= new Form22(SID); 
            form22.ShowDialog();
        }

        private void 修改成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22(SID);
            form22.ShowDialog();
        }

        private void 各科平均成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23= new Form23();
            form23.ShowDialog();
        }

        private void 学生成绩排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.ShowDialog();
        }
    }
}
