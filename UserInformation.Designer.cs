
namespace App2
{
    partial class UserInformation
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yuanxi = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sex = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.yuanxi1 = new System.Windows.Forms.Label();
            this.class1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.yuan = new System.Windows.Forms.Label();
            this.nainl = new System.Windows.Forms.Label();
            this.xuehao = new System.Windows.Forms.Label();
            this.banji = new System.Windows.Forms.Label();
            this.xingm = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.平均分数 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yuanxi);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // yuanxi
            // 
            this.yuanxi.AutoSize = true;
            this.yuanxi.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yuanxi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.yuanxi.Location = new System.Drawing.Point(131, 59);
            this.yuanxi.Name = "yuanxi";
            this.yuanxi.Size = new System.Drawing.Size(81, 28);
            this.yuanxi.TabIndex = 12;
            this.yuanxi.Text = "label12";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.name.Location = new System.Drawing.Point(131, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 28);
            this.name.TabIndex = 8;
            this.name.Text = "label11";
            this.name.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App2.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.sex);
            this.panel2.Controls.Add(this.性别);
            this.panel2.Controls.Add(this.age);
            this.panel2.Controls.Add(this.yuanxi1);
            this.panel2.Controls.Add(this.class1);
            this.panel2.Controls.Add(this.num);
            this.panel2.Controls.Add(this.name1);
            this.panel2.Controls.Add(this.yuan);
            this.panel2.Controls.Add(this.nainl);
            this.panel2.Controls.Add(this.xuehao);
            this.panel2.Controls.Add(this.banji);
            this.panel2.Controls.Add(this.xingm);
            this.panel2.Location = new System.Drawing.Point(57, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 262);
            this.panel2.TabIndex = 1;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sex.Location = new System.Drawing.Point(446, 211);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(73, 28);
            this.sex.TabIndex = 13;
            this.sex.Text = "label3";
            // 
            // 性别
            // 
            this.性别.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.性别.AutoSize = true;
            this.性别.Font = new System.Drawing.Font("华光综艺_CNKI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.ForeColor = System.Drawing.Color.Chocolate;
            this.性别.Location = new System.Drawing.Point(329, 211);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(70, 23);
            this.性别.TabIndex = 12;
            this.性别.Text = "性别：";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.age.ForeColor = System.Drawing.SystemColors.Desktop;
            this.age.Location = new System.Drawing.Point(150, 120);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(81, 28);
            this.age.TabIndex = 11;
            this.age.Text = "label10";
            // 
            // yuanxi1
            // 
            this.yuanxi1.AutoSize = true;
            this.yuanxi1.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yuanxi1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.yuanxi1.Location = new System.Drawing.Point(150, 213);
            this.yuanxi1.Name = "yuanxi1";
            this.yuanxi1.Size = new System.Drawing.Size(73, 28);
            this.yuanxi1.TabIndex = 10;
            this.yuanxi1.Text = "label9";
            // 
            // class1
            // 
            this.class1.AutoSize = true;
            this.class1.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.class1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.class1.Location = new System.Drawing.Point(446, 120);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(73, 28);
            this.class1.TabIndex = 9;
            this.class1.Text = "label8";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.ForeColor = System.Drawing.SystemColors.Desktop;
            this.num.Location = new System.Drawing.Point(446, 37);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(73, 28);
            this.num.TabIndex = 8;
            this.num.Text = "label2";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.name1.Location = new System.Drawing.Point(150, 32);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(68, 28);
            this.name1.TabIndex = 7;
            this.name1.Text = "label1";
            this.name1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yuan
            // 
            this.yuan.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.yuan.AutoSize = true;
            this.yuan.Font = new System.Drawing.Font("华光综艺_CNKI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yuan.ForeColor = System.Drawing.Color.Chocolate;
            this.yuan.Location = new System.Drawing.Point(42, 218);
            this.yuan.Name = "yuan";
            this.yuan.Size = new System.Drawing.Size(70, 23);
            this.yuan.TabIndex = 6;
            this.yuan.Text = "院系：";
            // 
            // nainl
            // 
            this.nainl.AutoSize = true;
            this.nainl.Font = new System.Drawing.Font("华光综艺_CNKI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nainl.ForeColor = System.Drawing.Color.Chocolate;
            this.nainl.Location = new System.Drawing.Point(42, 120);
            this.nainl.Name = "nainl";
            this.nainl.Size = new System.Drawing.Size(70, 23);
            this.nainl.TabIndex = 5;
            this.nainl.Text = "年龄：";
            // 
            // xuehao
            // 
            this.xuehao.AutoSize = true;
            this.xuehao.Font = new System.Drawing.Font("华光综艺_CNKI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xuehao.ForeColor = System.Drawing.Color.Chocolate;
            this.xuehao.Location = new System.Drawing.Point(329, 40);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(70, 23);
            this.xuehao.TabIndex = 4;
            this.xuehao.Text = "学号：";
            // 
            // banji
            // 
            this.banji.AutoSize = true;
            this.banji.Font = new System.Drawing.Font("华光综艺_CNKI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.banji.ForeColor = System.Drawing.Color.Chocolate;
            this.banji.Location = new System.Drawing.Point(329, 125);
            this.banji.Name = "banji";
            this.banji.Size = new System.Drawing.Size(70, 23);
            this.banji.TabIndex = 3;
            this.banji.Text = "班级：";
            // 
            // xingm
            // 
            this.xingm.AutoSize = true;
            this.xingm.Font = new System.Drawing.Font("华光综艺_CNKI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xingm.ForeColor = System.Drawing.Color.Chocolate;
            this.xingm.Location = new System.Drawing.Point(42, 37);
            this.xingm.Name = "xingm";
            this.xingm.Size = new System.Drawing.Size(70, 23);
            this.xingm.TabIndex = 2;
            this.xingm.Text = "姓名：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::App2.Properties.Resources.chart_diagram;
            this.pictureBox2.Location = new System.Drawing.Point(136, 426);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1027, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(996, 125);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circularProgressBar1.Size = new System.Drawing.Size(244, 235);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "67%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(696, 125);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circularProgressBar2.Size = new System.Drawing.Size(244, 235);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 14;
            this.circularProgressBar2.Text = "67%";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            this.circularProgressBar2.Click += new System.EventHandler(this.circularProgressBar2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(771, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "课程数量";
            // 
            // 平均分数
            // 
            this.平均分数.AutoSize = true;
            this.平均分数.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.平均分数.ForeColor = System.Drawing.SystemColors.Desktop;
            this.平均分数.Location = new System.Drawing.Point(1074, 363);
            this.平均分数.Name = "平均分数";
            this.平均分数.Size = new System.Drawing.Size(108, 28);
            this.平均分数.TabIndex = 16;
            this.平均分数.Text = "平均分数";
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.平均分数);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserInformation";
            this.Size = new System.Drawing.Size(1225, 637);
            this.Load += new System.EventHandler(this.UserInformation_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label yuanxi1;
        private System.Windows.Forms.Label class1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label yuan;
        private System.Windows.Forms.Label nainl;
        private System.Windows.Forms.Label xuehao;
        private System.Windows.Forms.Label banji;
        private System.Windows.Forms.Label xingm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label yuanxi;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label 性别;
        public System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label 平均分数;
    }
}
