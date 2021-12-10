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
    public partial class UserCoursetable : UserControl
    {
        public UserCoursetable()
        {

            InitializeComponent();
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
                    num = i ;
                    week = j;
                    Dao dao = new Dao();
                    string mysql = $"SELECT `subject`.name,`subject`.teacher,`subject`.location,`subject`.long from `subject`,yonghu,sc WHERE yonghu.num = sc.sid and sc.cid =`subject`.id and yonghu.num = '{Data.UID}' and `subject`.num = '{num.ToString()}' and `subject`.week = '{week.ToString()}'";
                    //string mysql = "select subject ,teacher,room,weekstar_end from subject_table where num='" + num.ToString() + "' and week = '" + week.ToString() + "'";  //拼凑SQL语句。
                    IDataReader dc = dao.read(mysql);
                    while (dc.Read())
                    {
                        string sum = dc.GetValue(0).ToString() + "\n" + dc.GetValue(1).ToString() + "\n" + dc.GetValue(2).ToString() + "\n" + dc.GetValue(3).ToString();
                        //如上图，一个格子里头有好几个信息。比如教师，教室，课程名。这里把从数据库中取出的数据拼在一起。
                        dt.Rows[i][j] = sum;  //把Sum 添加到datatable的小格子里。
                    }
                }
            }
            this.dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 90);
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            for(int i=0;i<8;i++)
            {
                dataGridView1.Columns[i].Width = 122;
            }
        }

        private void UserCoursetable_Load(object sender, EventArgs e)
        {
                
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
    }
 }

