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
    public partial class AdminStudent : UserControl
    {
        public AdminStudent()
        {
            InitializeComponent();
            table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("姓名", "学号", "性别", "年龄", "班号", "院系", "密码");
            Dao dao = new Dao();
            string mysql = $"SELECT `yonghu`.name,`yonghu`.num,`yonghu`.sex,`yonghu`.age,`yonghu`.class,`yuanxi`.name,`yonghu`.pass   from `yonghu`,yuanxi WHERE yuanxi.id=`yonghu`.yuanxi";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].Width = 80;
            }
            dc.Close();
            dao.DaoClose();

        }
        public void duoxiangsearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("姓名", "学号", "性别", "年龄", "班号", "院系", "密码");
            Dao dao = new Dao();
            string a, b, c, d;

            if (textBox1.Text == "") a = "%";
            else a = textBox1.Text;


            string mysql = $"SELECT `yonghu`.name,`yonghu`.num,`yonghu`.sex,`yonghu`.age,`yonghu`.class,`yuanxi`.name,`yonghu`.pass from `yonghu`,yuanxi WHERE yuanxi.id=`yonghu`.yuanxi and (`yonghu`.name like'{a}'or `yonghu`.num like'{a}' or `yonghu`.sex like'{a}' or `yonghu`.age like'{a}' or `yonghu`.class like'{a}' or `yuanxi`.name like'{a}')";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].Width = 80;
            }
            dc.Close();
            dao.DaoClose();
        }

        private void btn_modifyDept_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string mysql = $"insert into  `yonghu` values('{name.Text}','{num.Text}','{sex.Text}','{age.Text}','{class1.Text}','{yuanxi.Text}','{pass.Text}')";
            try
            {
                if (dao.Execute(mysql) == 1)
                {
                    MessageBox.Show("添加成功");
                    table();
                }
                else
                {
                    MessageBox.Show("添加失败，请重新添加！");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("添加失败，请确认输入信息的正确性！");
            }
            
            dao.DaoClose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            duoxiangsearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            num.Text = "";
            sex.Text = "";
            age.Text = "";
            class1.Text = "";
            yuanxi.Text = "";
            pass.Text = "";
        }
    }
}
