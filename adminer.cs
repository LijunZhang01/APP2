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
        public adminer()
        {
            InitializeComponent();
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
    }
}
