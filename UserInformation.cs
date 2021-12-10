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
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
