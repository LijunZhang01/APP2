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
    public partial class AdminInformation : UserControl
    {
        public AdminInformation()
        {
            InitializeComponent();
            name.Text = Data.UID;
            yuanxi.Text = Data.UName;
            timer1.Start();
        }
        public void fun11()
        {
            Dao dao = new Dao();
            string mysql = $"select count(*) from subject";
            IDataReader dc = dao.read(mysql);
            
            while (dc.Read())
            {
                circularProgressBar2.Text = dc[0].ToString();
            }
            
            string mysq2 = $"select count(*) from yonghu";
            IDataReader de = dao.read(mysq2);
            while (de.Read())
            {
                circularProgressBar1.Text = de[0].ToString();
            }
            dc.Close();
            de.Close();
            dao.DaoClose();
            
        }
        private void AdminInformation_Load(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string mysql = $"select * from guanli where id='{Data.UID}'";
            IDataReader dc = dao.read(mysql);
            while (dc.Read())
            {
                
                age.Text = dc["age"].ToString();
                class1.Text = dc["zhiwei"].ToString();
                name1.Text = dc["name"].ToString();
                num.Text = dc["id"].ToString();
            }
            dao.DaoClose();
            dc.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fun11();
        }
    }
}
