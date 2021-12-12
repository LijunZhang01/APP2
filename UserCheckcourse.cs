using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace App2
{
    public partial class UserCheckcourse : UserControl
    {
        public UserCheckcourse()
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
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi";
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
            /*DataTable dt = new DataTable("subject");
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            
            dt.Columns.Add("周数/节数", typeof(string));   //添加列集，下面都是
            dt.Columns.Add("周一", typeof(string));
            dt.Columns.Add("周二", typeof(string));
            dt.Columns.Add("周三", typeof(string));
            dt.Columns.Add("周四", typeof(string));
            dt.Columns.Add("周五", typeof(string));
            dt.Columns.Add("周六", typeof(string));
            dt.Columns.Add("周日", typeof(string));

            dt.Rows[0][0] = "课程序号";
            dt.Rows[0][1] = "课程名称";
            dt.Rows[0][2] = "教室";
            dt.Rows[0][3] = "开课院系";
            dt.Rows[0][4] = "上课地点";
            dt.Rows[0][5] = "开课周数";
            dt.Rows[0][6] = "开课节数";
            dt.Rows[0][7] = "起始周";

            Dao dao = new Dao();
            string mysql = $"SELECT `subject`.name,`subject`.teacher,`subject`.location,`subject`.long from `subject`,yonghu,sc WHERE yonghu.num = sc.sid and sc.cid =`subject`.id and yonghu.num = '{Data.UID}' and `subject`.num = '{num.ToString()}' and `subject`.week = '{week.ToString()}'";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                
            }
            this.dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }*/
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            if (zhuangtai.Text == "单项查询")
            {
                if (id.Text != "") idsearch();
                else if (name.Text != "") namesearch();
                else if (teacher.Text != "") teachersearch();
                else if (yuanxi.Text != "") yuanxisearch();
                else table();
            }
            else if (zhuangtai.Text == "多项查询")
            {
                if (id.Text == "" && name.Text == "" && teacher.Text == "" && yuanxi.Text == "") table();
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
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.id='{id.Text}'";
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
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.name='{name.Text}'";
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
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `yuanxi`.name='{yuanxi.Text}'";
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
            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.teacher='{teacher.Text}'";
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

            if (id.Text == "") a = "%";
            else a = id.Text;
            if (name.Text == "") b = "%";
            else b = name.Text;
            if (teacher.Text == "") c = "%";
            else c = teacher.Text;
            if (yuanxi.Text == "") d = "%";
            else d = yuanxi.Text;

            string mysql = $"SELECT `subject`.id,`subject`.name,`subject`.teacher,`yuanxi`.name,`subject`.location,`subject`.week,`subject`.num,`subject`.long from `subject`,yuanxi WHERE yuanxi.id=`subject`.yuanxi and `subject`.id like '{a}' and `subject`.name like '{b}' and `subject`.teacher like '{c}' and yuanxi.name like '{d}'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string id11 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string mysql1 = $"select id from mysubject where id=('{id11}');";
            Dao dao = new Dao();
            IDataReader dc = dao.read(mysql1);
            if (dc.Read())
            {
                MessageBox.Show("选课失败，可能重复选课");
            }
            else
            {
                string mysql = $"insert into mysubject(id) values('{id11}');";
                if (dao.Execute(mysql) == 1)
                {
                    MessageBox.Show("选课成功");
                }
                else
                {
                    MessageBox.Show("选课失败，请重新尝试或选择相应课程！");
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("111111111111");
            Mysubject ut = new Mysubject();
            if (!user.Instance.PnlContainer.Controls.ContainsKey("Mysubject"))
            {
                ut.Dock = DockStyle.Fill;
                user.Instance.PnlContainer.Controls.Add(ut);
                //MessageBox.Show("222222222222");
            }
            //MessageBox.Show("333333333333");
            user.Instance.PnlContainer.Controls["Mysubject"].BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
