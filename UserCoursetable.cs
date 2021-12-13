using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace App2
{
    public partial class UserCoursetable : UserControl
    {
        //System.Timers.Timer t = new System.Timers.Timer(5000); //设置时间间隔为5秒
        public UserCoursetable()
        {

            InitializeComponent();
            table1();
            name.Text = Data.UID;
            yuanxi.Text = Data.UName;
            timer2.Start();
            /*System.Timers.Timer mTimer = new System.Timers.Timer(7000D);
            mTimer.Elapsed += new ElapsedEventHandler(mTimer_Elapsed);
            mTimer.Start();

            mTimer_Elapsed(null, null);*/

        }
        private void mTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            table1();
        }
        public void table1()
        {
            int num, week;   // 周数节数，第二步的时候用得到。
            DataTable dt = new DataTable("subject");
            for (int i = 0; i < 9; i++)  //用循环添加4个行集~
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            dt.Columns.Add("周数/节数", typeof(string));   //添加列集，下面都是
            dt.Columns.Add("周一", typeof(string));
            dt.Columns.Add("周二", typeof(string));
            dt.Columns.Add("周三", typeof(string));
            dt.Columns.Add("周四", typeof(string));
            dt.Columns.Add("周五", typeof(string));
            dt.Columns.Add("周六", typeof(string));
            dt.Columns.Add("周日", typeof(string));
            dt.Rows[0][0] = "周数/节数";
            dt.Rows[0][1] = "周一";
            dt.Rows[0][2] = "周二";
            dt.Rows[0][3] = "周三";
            dt.Rows[0][4] = "周四";
            dt.Rows[0][5] = "周五";
            dt.Rows[0][6] = "周六";
            dt.Rows[0][7] = "周日";
            dt.Rows[1][0] = "第1节";  //向第一行里的第一个格中添加一个“第1节”
            dt.Rows[2][0] = "第2节";  //向第二行里的第一个格中添加一个“第 2 节”
            dt.Rows[3][0] = "第3节";  //向第三行里的第一个格中添加一个“第3节”
            dt.Rows[4][0] = "第4节";  //向第四行里的第一个格中添加一个“第4节”
            dt.Rows[5][0] = "第5节";  //向第一行里的第一个格中添加一个“第1节”
            dt.Rows[6][0] = "第6节";  //向第二行里的第一个格中添加一个“第 2 节”
            dt.Rows[7][0] = "第7节";  //向第三行里的第一个格中添加一个“第3节”
            dt.Rows[8][0] = "第8节";  //向第四行里的第一个格中添加一个“第4节”
            for (int i = 1; i < 9; i++)//一共有四行，在课程表里i应该表示的是节数。
            {
                for (int j = 1; j < 8; j++)//每行有7列需要添加数据，在课程表中，J 表示的应该是周数。
                {
                    num = i;
                    week = j;
                    Dao dao = new Dao();
                    string mysql = $"SELECT `subject`.name,`subject`.teacher,`subject`.location,`subject`.long from `subject`,yonghu,`mysubject` WHERE yonghu.num = `mysubject`.sid and  yonghu.num = '{Data.UID}' and `subject`.num = '{num.ToString()}' and `subject`.week = '{week.ToString()}' and `mysubject`.cid=`subject`.id";
                    //string mysql = "select subject ,teacher,room,weekstar_end from subject_table where num='" + num.ToString() + "' and week = '" + week.ToString() + "'";  //拼凑SQL语句。
                    IDataReader dc = dao.read(mysql);
                    while (dc.Read())
                    {
                        string sum = dc.GetValue(0).ToString() + "\n" + dc.GetValue(1).ToString() + "\n" + dc.GetValue(2).ToString() + "\n" + dc.GetValue(3).ToString();
                        //如上图，一个格子里头有好几个信息。比如教师，教室，课程名。这里把从数据库中取出的数据拼在一起。
                        dt.Rows[i][j] = sum;  //把Sum 添加到datatable的小格子里。
                    }
                    dc.Close();
                    dao.DaoClose();

                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }

            
            
        }
        //fjdlsjfldsjflks
        /*private void Timer_TimesUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            //到达指定时间5秒触发该事件输出 Hello World!!!!
            table1();
            MessageBox.Show("jdslfjsdlfjsd");
        }*/
        private void UserCoursetable_Load(object sender, EventArgs e)
        {
            //t.Elapsed += new System.Timers.ElapsedEventHandler(Timer_TimesUp);
            //t.AutoReset = false;
            //每到指定时间Elapsed事件是触发一次（false），还是一直触发（true）
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_str_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            table1();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            table1();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            table1();
        }

        private void yuanxi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString("yyyy:MM:dd");
        }
    }
 }


