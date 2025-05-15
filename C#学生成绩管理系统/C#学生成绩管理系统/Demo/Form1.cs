using System.Data;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            if (login())
            {
                timer1.Start();
                textBox1.Visible= false;
                textBox2.Visible= false;
                comboBox1.Visible= false;
                button1.Visible= false;
                button2.Visible= false;
                label1.Visible= false;
                label2.Visible= false;
                label3.Visible= false;
            }
        }
        private bool login()
        {
            if (textBox1.Text == "" || textBox2.Text=="" || comboBox1.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBox1.Text == "学生")
            {
                string sql = "select *from Student where name='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dataReader = dao.read(sql);
                if (dataReader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (comboBox1.Text == "老师")
            {
                string sql = "select *from Teacher where name='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dataReader = dao.read(sql);
                if (dataReader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < 300)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X+2,pictureBox1.Location.Y);
            }
            else
            {
                if (comboBox1.Text == "学生")
                {
                    string sql = "select *from Student where name='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                    Dao dao = new Dao();
                    IDataReader dr=dao.read(sql);
                    dr.Read();
                    string sID = dr["student_id"].ToString();
                    Form3 form3= new Form3(sID);
                    Form31 form31= new Form31(sID);
                    form3.Show();
                    this.Hide();//隐藏窗体
                    //this.Close();
                }
                else
                {
                    if (comboBox1.Text == "老师")
                    {
                        string sql = "select *from Teacher where name='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                        Dao dao = new Dao();
                        IDataReader dr = dao.read(sql);
                        dr.Read();
                        string sID = dr["teacher_id"].ToString();
                        Form2 form2= new Form2(sID);
                        Form22 form22 = new Form22(sID);
                        form2.Show();
                        this.Hide();
                    }
                }
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text= null;
        }

    }
}