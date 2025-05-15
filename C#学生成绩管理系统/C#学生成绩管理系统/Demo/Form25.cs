using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form25 : Form
    {
        Form22 form22;
        string course;
        string[] str = new string[10];
        public Form25(Form22 f)
        {
            InitializeComponent();
            button3.Visible = false;
            form22 = f;
            course = form22.getcourse();
        }
        public Form25(string[] a, Form22 f)
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];//学号
            //textBox2.Text= str[1]; //课程
            textBox3.Text = str[2];//成绩
            textBox4.Text = str[3];//寄语
            button1.Visible = false;
            form22 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("必要信息输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // 学生存在，尝试插入成绩
                    string sql = "INSERT INTO Grade VALUES('" + textBox1.Text + "','" + course + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    Dao dao = new Dao();
                    int i = dao.Excute(sql);

                    if (i > 0)
                    {
                        MessageBox.Show("插入成功");
                        textBox1.Text = null;
                        textBox3.Text = null;
                        textBox4.Text= null;
                    }
                    form22.Table();
                }
                catch (SqlException ex) when (ex.Number == 2627) // 错误代码 2627 表示唯一约束冲突
                {
                    MessageBox.Show("该学生成绩已存在，无法重复插入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("该学生不存在，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("修改后有空项，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update Grade set student_id='" + textBox1.Text + "' where student_id='" + str[0] + "' and course_name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update Grade set grade='" + textBox3.Text + "' where student_id='" + str[0] + "' and course_name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update Grade set message='" + textBox4.Text + "' where student_id='" + str[0] + "' and course_name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[3] = textBox4.Text;
                }
                form22.Table();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;

            //textBox2.Text = null;

            textBox3.Text = null;

            textBox4.Text = null;
        }
    }
}
