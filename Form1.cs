using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //sfsdf
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!="")
            {//jdsklfjdlsjlksdfjdlskf
                login();
            }
            else
            {
                MessageBox.Show("请输入完整内容");
            }
        }
        public void login()
        {
            if(radioButton1.Checked==true)
            {
                Dao dao = new Dao();
                string mysql = $"select * from yonghu where num='{textBox1.Text}'and pass='{textBox2.Text}'";
                IDataReader dc = dao.read(mysql);
                if(dc.Read())
                {
                    Data.UID = textBox1.Text;
                    Data.UName = dc["name"].ToString();
                    //MessageBox.Show("登陆成功");
                    user user1 = new user();
                    this.Hide();
                    user1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("账号或密码不符合");
                }
                dao.DaoClose();

            }
            if (radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string mysql = $"select * from guanli where num='{textBox1.Text}'and pass='{textBox2.Text}'";
                IDataReader dc = dao.read(mysql);
                if (dc.Read())
                {
                    Data.UID = dc["num"].ToString();
                    Data.UName = dc["name"].ToString();
                    //MessageBox.Show(dc["num"].ToString());
                    adminer adminer1 = new adminer();
                    this.Hide();
                    adminer1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("账号或密码不符合");
                }
                dao.DaoClose();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
