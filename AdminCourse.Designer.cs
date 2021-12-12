
namespace App2
{
    partial class AdminCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cid = new System.Windows.Forms.TextBox();
            this.btn_selectDept = new System.Windows.Forms.Button();
            this.label_sType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.GroupBox();
            this.teacher = new System.Windows.Forms.TextBox();
            this.long1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.location1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.week = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.yuanxi = new System.Windows.Forms.TextBox();
            this.label_deptNo = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_modifyDept = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.location.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华光准圆_CNKI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(678, 637);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBox1.Controls.Add(this.cname);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cid);
            this.groupBox1.Controls.Add(this.btn_selectDept);
            this.groupBox1.Controls.Add(this.label_sType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(681, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 137);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查询";
            // 
            // cname
            // 
            this.cname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cname.Location = new System.Drawing.Point(84, 40);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(141, 32);
            this.cname.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(278, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cid
            // 
            this.cid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cid.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cid.Location = new System.Drawing.Point(336, 40);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(141, 32);
            this.cid.TabIndex = 5;
            // 
            // btn_selectDept
            // 
            this.btn_selectDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btn_selectDept.FlatAppearance.BorderSize = 0;
            this.btn_selectDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectDept.ForeColor = System.Drawing.Color.White;
            this.btn_selectDept.Location = new System.Drawing.Point(104, 91);
            this.btn_selectDept.Name = "btn_selectDept";
            this.btn_selectDept.Size = new System.Drawing.Size(141, 40);
            this.btn_selectDept.TabIndex = 3;
            this.btn_selectDept.Text = "点击查询";
            this.btn_selectDept.UseVisualStyleBackColor = false;
            this.btn_selectDept.Click += new System.EventHandler(this.btn_selectDept_Click);
            // 
            // label_sType
            // 
            this.label_sType.AutoSize = true;
            this.label_sType.Location = new System.Drawing.Point(252, 40);
            this.label_sType.Name = "label_sType";
            this.label_sType.Size = new System.Drawing.Size(57, 27);
            this.label_sType.TabIndex = 6;
            this.label_sType.Text = "课号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "课名：";
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.location.Controls.Add(this.button2);
            this.location.Controls.Add(this.teacher);
            this.location.Controls.Add(this.long1);
            this.location.Controls.Add(this.label9);
            this.location.Controls.Add(this.num);
            this.location.Controls.Add(this.location1);
            this.location.Controls.Add(this.label3);
            this.location.Controls.Add(this.label1);
            this.location.Controls.Add(this.week);
            this.location.Controls.Add(this.id);
            this.location.Controls.Add(this.yuanxi);
            this.location.Controls.Add(this.label_deptNo);
            this.location.Controls.Add(this.label_count);
            this.location.Controls.Add(this.label8);
            this.location.Controls.Add(this.label7);
            this.location.Controls.Add(this.name);
            this.location.Controls.Add(this.label6);
            this.location.Controls.Add(this.label5);
            this.location.Controls.Add(this.label4);
            this.location.Controls.Add(this.btn_modifyDept);
            this.location.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.location.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.location.Location = new System.Drawing.Point(678, 149);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(547, 488);
            this.location.TabIndex = 39;
            this.location.TabStop = false;
            this.location.Text = "成绩录入";
            // 
            // teacher
            // 
            this.teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacher.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacher.Location = new System.Drawing.Point(220, 131);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(242, 32);
            this.teacher.TabIndex = 72;
            // 
            // long1
            // 
            this.long1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.long1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.long1.Location = new System.Drawing.Point(220, 388);
            this.long1.Name = "long1";
            this.long1.Size = new System.Drawing.Size(242, 32);
            this.long1.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 27);
            this.label9.TabIndex = 70;
            this.label9.Text = "起始周：";
            // 
            // num
            // 
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(220, 337);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(242, 32);
            this.num.TabIndex = 69;
            // 
            // location1
            // 
            this.location1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.location1.Location = new System.Drawing.Point(220, 232);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(242, 32);
            this.location1.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 67;
            this.label3.Text = "节数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "周数：";
            // 
            // week
            // 
            this.week.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.week.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.week.Location = new System.Drawing.Point(220, 285);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(242, 32);
            this.week.TabIndex = 64;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.Location = new System.Drawing.Point(220, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(242, 32);
            this.id.TabIndex = 63;
            // 
            // yuanxi
            // 
            this.yuanxi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yuanxi.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yuanxi.Location = new System.Drawing.Point(220, 180);
            this.yuanxi.Name = "yuanxi";
            this.yuanxi.Size = new System.Drawing.Size(242, 32);
            this.yuanxi.TabIndex = 54;
            // 
            // label_deptNo
            // 
            this.label_deptNo.AutoSize = true;
            this.label_deptNo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_deptNo.Location = new System.Drawing.Point(191, 1);
            this.label_deptNo.Name = "label_deptNo";
            this.label_deptNo.Size = new System.Drawing.Size(0, 32);
            this.label_deptNo.TabIndex = 56;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_count.Location = new System.Drawing.Point(191, 259);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(0, 32);
            this.label_count.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 58;
            this.label8.Text = "教室：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 59;
            this.label7.Text = "院系：";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(220, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 32);
            this.name.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 60;
            this.label6.Text = "教师：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 61;
            this.label5.Text = "课号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 62;
            this.label4.Text = "课名：";
            // 
            // btn_modifyDept
            // 
            this.btn_modifyDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.btn_modifyDept.FlatAppearance.BorderSize = 0;
            this.btn_modifyDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifyDept.ForeColor = System.Drawing.Color.White;
            this.btn_modifyDept.Location = new System.Drawing.Point(107, 443);
            this.btn_modifyDept.Name = "btn_modifyDept";
            this.btn_modifyDept.Size = new System.Drawing.Size(154, 39);
            this.btn_modifyDept.TabIndex = 3;
            this.btn_modifyDept.Text = "点击添加课程";
            this.btn_modifyDept.UseVisualStyleBackColor = false;
            this.btn_modifyDept.Click += new System.EventHandler(this.btn_modifyDept_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(308, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 73;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.location);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminCourse";
            this.Size = new System.Drawing.Size(1225, 637);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.location.ResumeLayout(false);
            this.location.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Button btn_selectDept;
        private System.Windows.Forms.Label label_sType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox location;
        private System.Windows.Forms.Button btn_modifyDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.TextBox long1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox location1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox week;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox yuanxi;
        private System.Windows.Forms.Label label_deptNo;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}
