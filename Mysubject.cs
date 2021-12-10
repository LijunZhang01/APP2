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
            
        }
    }
}
