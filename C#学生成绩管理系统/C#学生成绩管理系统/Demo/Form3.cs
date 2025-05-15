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
    public partial class Form3 : Form
    {
        string SID;
        public Form3(string sID)
        {
            SID= sID;
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            toolStripStatusLabel1.Text = "欢迎学号为 " + SID + " 的同学加入本系统";
            timer1.Start();
            Table();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        private void 学生成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 form31=new Form31(SID);
            form31.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT course_name, grade FROM  Grade WHERE student_id = '"+SID+"';";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b;
                a = dr["course_name"].ToString();
                b = dr["grade"].ToString();
                string[] str = { a, b };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
    }
}
