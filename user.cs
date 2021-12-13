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
    public partial class user : Form
    {
        static user _obj;
        public static user Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new user();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        int panel1with;
        bool isCollapsed;
        public user()
        {
            InitializeComponent();
            timer2.Start();
            panel1with = panel1.Width;
            isCollapsed = false;
        }
       

        private void user_Load(object sender, EventArgs e)
        {
            label1.Text = Data.UID;
            label2.Text = Data.UName;
            _obj = this;
            UserInformation ui = new UserInformation();
            ui.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ui);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            this.Hide();
            exit.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("UserInformation"))
            {
                UserInformation ui = new UserInformation();
                ui.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ui);
            }
            PnlContainer.Controls["UserInformation"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("UserCoursetable"))
            {
                UserCoursetable ut = new UserCoursetable();
                ut.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ut);
            }
            
            PnlContainer.Controls["UserCoursetable"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("UserCheckcourse"))
            {
                UserCheckcourse ut = new UserCheckcourse();
                ut.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ut);
            }
            PnlContainer.Controls["UserCheckcourse"].BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("UserScore"))
            {
                UserScore ut = new UserScore();
                ut.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ut);
            }
            PnlContainer.Controls["UserScore"].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("UserTeacher"))
            {
                UserTeacher ut = new UserTeacher();
                ut.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ut);
            }
            PnlContainer.Controls["UserTeacher"].BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            this.Hide();
            exit.ShowDialog();
            this.Show();
        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panel1.Width = panel1.Width + 10;
                if(panel1.Width>=panel1with)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 10;
                if (panel1.Width <= 55)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString("HH:MM:ss");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
