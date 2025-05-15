using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form21 : Form
    {
        Form2 form2;
        string[] str = new string[10];
        public Form21(Form2 f)
        {
            InitializeComponent();
            button3.Visible = false;
            form2 = f;
        }
        public Form21(string[] a,Form2 f)
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            button1.Visible = false;
            form2 = f;
        }
        //添加一条学生信息
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    try
                    {
                        string sql1 = "insert into Student values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','123456')";
                        Dao dao = new Dao();
                        int i = dao.Excute(sql1);
                        if (i > 0)
                        {
                            MessageBox.Show("插入成功");
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                            textBox4.Text = null;
                        }
                        form2.Table();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("已经有这个学生了，请重新输入" ,"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("修改后有空项，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update Student set student_id='" + textBox1.Text + "' where student_id='" + str[0] + "' and name ='" + str[1] + "'";
                    Dao dao= new Dao();
                    dao.Excute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update Student set name='" + textBox2.Text + "' where student_id='" + str[0] + "' and name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update Student set class='" + textBox3.Text + "' where student_id='" + str[0] + "' and name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update Student set hometown='" + textBox4.Text + "' where student_id='" + str[0] + "' and name ='" + str[1] + "'";
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[3] = textBox4.Text;
                }
                form2.Table();
            }
        }

    }
}
