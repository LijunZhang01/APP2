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
    public partial class AdminScore : UserControl
    {
        public AdminScore()
        {
            InitializeComponent();
            table();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("学号", "课程号", "课程名", "开课院系", "分数");
            Dao dao = new Dao();
            string mysql = $"SELECT `sc`.sid,`sc`.cid,`subject`.name,`subject`.yuanxi,`sc`.garade from `subject`,sc WHERE sc.cid=`subject`.id";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].Width = 90;
            }
            dc.Close();
            dao.DaoClose();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void duoxiangsearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("学号", "课程号", "课程名", "开课院系", "分数");
            Dao dao = new Dao();
            string a, b;

            if (cid.Text == "") a = "%";
            else a = cid.Text;
            if (sid.Text == "") b = "%";
            else b = sid.Text;


            string mysql = $"SELECT `sc`.sid,`sc`.cid,`subject`.name,`subject`.yuanxi,`sc`.garade from `subject`,sc WHERE sc.cid=`subject`.id and `sc`.cid like '{a}' and `sc`.sid like '{b}'";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].Width = 90;
            }
            dc.Close();
            dao.DaoClose();
        }
        private void btn_selectDept_Click(object sender, EventArgs e)
        {
            duoxiangsearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cid.Text = "";
            sid.Text = "";
        }

        private void btn_modifyDept_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string mysql = $"insert into sc values('{sid1.Text}','{cid1.Text}','{garade1.Text}')";
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

                MessageBox.Show("添加失败，学生或课程不存在！");
            }
            
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sid1.Text = "";
            cid1.Text = "";
            garade1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Dao dao = new Dao();
            string mysql = $"update `sc` set garade='{textBox1.Text}' where sid='{textBox3.Text}' and cid='{textBox2.Text}'";
            try
            {
                if (dao.Execute(mysql) == 1)
                {
                    MessageBox.Show("修改成功");
                    table();
                }
                else
                {
                    MessageBox.Show("修改失败，请重新修改！");
                    table();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("修改失败，学生或课程不存在！");
            }
            table();
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            dao.DaoClose();
        }
    }
}
