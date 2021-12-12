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
    public partial class Mysubject : UserControl
    {
        public Mysubject()
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
            dataGridView1.Rows.Add("课程序号", "课程名称", "教室", "开课院系", "上课地点", "开课周数", "开课节数", "起始周");
            Dao dao = new Dao();
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi,`mysubject` WHERE yuanxi.id=`subject`.yuanxi and `mysubject`.id=`subject`.id" ;
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
            dc.Close();
            dao.DaoClose();
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (zhuangtai.Text == "单项查询")
            {
                if (id1.Text != "") idsearch();
                else if (name1.Text != "") namesearch();
                else if (teacher1.Text != "") teachersearch();
                else if (yuanxi.Text != "") yuanxisearch();
                else table();
            }
            else if (zhuangtai.Text == "多项查询")
            {
                if (id1.Text == "" && name1.Text == "" && teacher1.Text == "" && yuanxi.Text == "") table();
                else duoxiangsearch(); ;
            }
            else
            {
                MessageBox.Show("请选择查询类型");
                table();
            }
        }
        public void idsearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("课程序号", "课程名称", "教室", "开课院系", "上课地点", "开课周数", "开课节数", "起始周");
            Dao dao = new Dao();
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.id='{id1.Text}'and `mysubject`.id=`subject`.id";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void namesearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("课程序号", "课程名称", "教室", "开课院系", "上课地点", "开课周数", "开课节数", "起始周");
            Dao dao = new Dao();
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.name='{name1.Text}' and `mysubject`.id=`subject`.id";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void yuanxisearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("课程序号", "课程名称", "教室", "开课院系", "上课地点", "开课周数", "开课节数", "起始周");
            Dao dao = new Dao();
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `yuanxi`.name='{yuanxi.Text}' and `mysubject`.id=`subject`.id";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void teachersearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("课程序号", "课程名称", "教室", "开课院系", "上课地点", "开课周数", "开课节数", "起始周");
            Dao dao = new Dao();
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.teacher='{teacher1.Text}' and `mysubject`.id=`subject`.id";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void duoxiangsearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("课程序号", "课程名称", "教室", "开课院系", "上课地点", "开课周数", "开课节数", "起始周");
            Dao dao = new Dao();
            string a, b, c, d;

            if (id1.Text == "") a = "%";
            else a = id1.Text;
            if (name1.Text == "") b = "%";
            else b = name1.Text;
            if (teacher1.Text == "") c = "%";
            else c = teacher1.Text;
            if (yuanxi.Text == "") d = "%";
            else d = yuanxi.Text;

            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.id like '{a}' and `subject`.name like '{b}' and `subject`.teacher like '{c}' and yuanxi.name like '{d}' and `mysubject`.id=`subject`.id";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
            dc.Close();
            dao.DaoClose();
        }

        private void return1_Click(object sender, EventArgs e)
        {
            if (!user.Instance.PnlContainer.Controls.ContainsKey("UserCheckcourse"))
            {
                UserCheckcourse ut = new UserCheckcourse();
                ut.Dock = DockStyle.Fill;
                user.Instance.PnlContainer.Controls.Add(ut);
            }
            user.Instance.PnlContainer.Controls["UserCheckcourse"].BringToFront();
        }

        private void tuike_Click(object sender, EventArgs e)
        {
            string id12 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string mysql1 = $"delete from mysubject where  id=('{id12}');";
            Dao dao = new Dao();
            if (dao.Execute(mysql1) == 1)
            {
                MessageBox.Show("退课成功");
                table();
                //Data.tuike = 1;
            }
            else
            {
                MessageBox.Show("退课失败，请重新尝试或选择相应课程！");
                table();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //System.Timers.Timer t = new System.Timers.Timer(1000);
        private void Timer_TimesUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            //到达指定时间5秒触发该事件输出 Hello World!!!!
            table();
        }
        private void Mysubject_Load(object sender, EventArgs e)
        {
            //t.Elapsed += new System.Timers.ElapsedEventHandler(Timer_TimesUp);
            //t.AutoReset = false; //每到指定时间Elapsed事件是触发一次（false），还是一直触发（true）
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            table();
        }
    }
}
