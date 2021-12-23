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
    public partial class adminer : Form
    {
        int panel1with;
        bool isCollapsed;
        public adminer()
        {
            InitializeComponent();
            panel1with = panel1.Width;
            isCollapsed = false;
            timer2.Start();
            label1.Text = Data.UID;
            label2.Text = Data.UName;
        }
        static adminer _obj;
        public static adminer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new adminer();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        



        private void adminer_Load(object sender, EventArgs e)
        {
            _obj = this;
            AdminInformation ui = new AdminInformation();
            ui.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ui);
        }

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("AdminInformation"))
            {
                AdminInformation ui = new AdminInformation();
                ui.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ui);
            }
            PnlContainer.Controls["AdminInformation"].BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("AdminStudent"))
            {
                AdminStudent ui = new AdminStudent();
                ui.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ui);
            }
            PnlContainer.Controls["AdminStudent"].BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("AdminScore"))
            {
                AdminScore ui = new AdminScore();
                ui.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ui);
            }
            PnlContainer.Controls["AdminScore"].BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            if (!PnlContainer.Controls.ContainsKey("AdminCourse"))
            {
                AdminCourse ui = new AdminCourse();
                ui.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ui);
            }
            PnlContainer.Controls["AdminCourse"].BringToFront();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            this.Hide();
            exit.ShowDialog();
            this.Show();
        }

        private void adminer_Load_1(object sender, EventArgs e)
        {
            _obj = this;
            AdminInformation ui = new AdminInformation();
            ui.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ui);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            this.Hide();
            exit.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Width = panel1.Width + 10;
                if (panel1.Width >= panel1with)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString("HH:MM:ss");
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
