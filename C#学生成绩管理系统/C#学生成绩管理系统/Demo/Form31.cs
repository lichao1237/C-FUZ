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
    public partial class Form31 : Form
    {
        string SID;
        public Form31(string sID)
        {
            SID = sID;
            InitializeComponent();
            Table();
        }
        private void Form31_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();//结束整个程序
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT course_name, message FROM  Grade WHERE student_id = '" + SID + "';";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b;
                a = dr["course_name"].ToString();
                b = dr["message"].ToString();
                string[] str = { a, b };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
    }
}
