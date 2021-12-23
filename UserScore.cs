using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace App2
{
    public partial class UserScore : UserControl
    {
        public UserScore()
        {
            InitializeComponent();
            table();
            timer2.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void idsearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("学号", "课程号", "课程名", "开课院系", "分数");
            Dao dao = new Dao();
            string mysql = $"SELECT `sc`.sid,`sc`.cid,`subject`.name,`subject`.yuanxi,`sc`.garade from `subject`,sc WHERE sc.cid=`subject`.id and `sc`.cid='{cid.Text}'";
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
                dataGridView1.Columns[i].Width = 100;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void namesearch()
        {
            //haoyajjfdffgf
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("学号", "课程号", "课程名", "开课院系", "分数");
            Dao dao = new Dao();
            string mysql = $"SELECT `sc`.sid,`sc`.cid,`subject`.name,`subject`.yuanxi,`sc`.garade from `subject`,sc WHERE sc.cid=`subject`.id and `subject`.name = '{cname.Text}'";
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
                dataGridView1.Columns[i].Width = 100;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void duoxiangsearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("学号", "课程号", "课程名", "开课院系", "分数");
            Dao dao = new Dao();
            string a, b, c, d;

            if (cid.Text == "") a = "%";
            else a = cid.Text;
            if (cname.Text == "") b = "%";
            else b = cname.Text;


            string mysql = $"SELECT `sc`.sid,`sc`.cid,`subject`.name,`subject`.yuanxi,`sc`.garade from `subject`,sc WHERE sc.cid=`subject`.id and `sc`.cid like '{a}' and `subject`.name like '{b}';";
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
                dataGridView1.Columns[i].Width = 100;
            }
            dc.Close();
            dao.DaoClose();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            dataGridView1.Rows.Add("学号",  "课程号", "课程名", "开课院系", "分数");
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
                dataGridView1.Columns[i].Width = 100;
            }
            dc.Close();
            dao.DaoClose();
        }
        public int Num(int n,int m)
        {
            int temp=0;
            Dao dao = new Dao();
            string mysql1 = $"SELECT cid from sc where garade>'{n}' and garade<='{m}';";
            IDataReader dc = dao.read(mysql1);
            while(dc.Read())
            {
                temp++;
            }
            dc.Close();
            dao.DaoClose();
            return temp;
        }
        public void TaskChart()
        {
            var taskEnd0=Num(90,100);
            var taskEnd1 = Num(80,90);
            var taskEnd2 = Num(60,80);
            var taskEnd3 = Num(0,60);
            //MessageBox.Show(taskEnd0.FieldCount.ToString());
            double[] yValues = { taskEnd0, taskEnd1, taskEnd2, taskEnd3 };
            string[] xValues = { "90-100", "80-90", "60-80", "0-60" };
            chart2.Series["Series1"].Points.DataBindXY(xValues, yValues);

            foreach (DataPoint point in chart2.Series[0].Points)
            {
                if (point.AxisLabel == "90-100")
                {
                    point.LegendText = taskEnd0.ToString();
                }
                if (point.AxisLabel == "80-90")
                {
                    point.LegendText = taskEnd1.ToString();
                }
                if (point.AxisLabel == "60-80")
                {
                    point.LegendText = taskEnd2.ToString();
                }
                if (point.AxisLabel == "0-60")
                {
                    point.LegendText = taskEnd3.ToString();
                }
            }
            chart2.Series["Series1"].IsXValueIndexed = false;
            chart2.Series["Series1"].IsValueShownAsLabel = false;
            chart2.Series["Series1"]["PieLineColor"] = "Black";//连线颜色
            chart2.Series["Series1"]["PieLabelStyle"] = "Outside";//标签位置
            chart2.Series["Series1"].ToolTip = "#VALX";//显示提示用语
        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TaskChart();
        }

        private void zhuangtai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            if (zhuangtai.Text == "单项查询")
            {
                if (cid.Text != "") idsearch();
                else if (cname.Text != "") namesearch();
                else table();
            }
            else if (zhuangtai.Text == "多项查询")
            {
                if (cid.Text == "" && cname.Text == "" ) table();
                else duoxiangsearch(); ;
            }
            else
            {
                MessageBox.Show("请选择查询类型");
                table();
            }
        }
        public void fun()
        {
            string mysql2 = $"call new_procedure('{Data.UID}');";
            Dao dao = new Dao();
            IDataReader de = dao.read(mysql2);
            while (de.Read())
            {
                circularProgressBar1.Text = de[0].ToString();
            }
            de.Close();
            dao.DaoClose();
        }
        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fun();
        }

        private void UserScore_Load(object sender, EventArgs e)
        {

        }

        private void cname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
