using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace App2
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
            name.Text = name1.Text;
            yuanxi.Text = yuanxi1.Text;
            timer1.Start();
        }
        
        public void fun()
        {
            //circularProgressBar2
            string mysql1 = $"select cnum from first where id=('{Data.UID}');";
            Dao dao = new Dao();
            IDataReader dc = dao.read(mysql1);
            while(dc.Read())
            {
                circularProgressBar2.Text = dc[0].ToString();
            }
            dc.Close();

            string mysql2 = $"call new_procedure('{Data.UID}');";
            
            IDataReader de = dao.read(mysql2);
            while (de.Read())
            {
                circularProgressBar1.Text = de[0].ToString();
            }
            de.Close();
            dao.DaoClose();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UserInformation_Load_1(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string mysql = $"select * from yonghu where num='{Data.UID}'";
            IDataReader dc = dao.read(mysql);
            while(dc.Read())
            {
                name.Text = dc["name"].ToString();
                num.Text = dc["num"].ToString();
                sex.Text = dc["sex"].ToString();
                age.Text = dc["age"].ToString();
                class1.Text = dc["class"].ToString();
                name1.Text = dc["name"].ToString();
                yuanxi.Text = dc["yuanxi"].ToString();
                yuanxi1.Text = dc["yuanxi"].ToString();
            }
            dao.DaoClose();
            dc.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fun();
        }
    }
}
