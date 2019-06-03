namespace MapWinForms
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.模拟演练ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.救援路径规划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模拟演练场景ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地点标注ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_2_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_2_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.救援管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事故现场管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.救援力量展示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.救援方案设计ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.救援路径规划ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(17, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "城市搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(487, 94);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(566, 424);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "北京",
            "上海",
            "天津",
            "重庆",
            "南京",
            "广州",
            "深圳",
            "成都",
            "长沙",
            "武汉",
            "石家庄",
            "郑州",
            "贵阳"});
            this.comboBox1.Location = new System.Drawing.Point(17, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(634, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "车位搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 101);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择城市";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(216, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择地点类型";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(16, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "搜索";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "学校",
            "景点",
            "酒店",
            "超市",
            "加油站",
            "KTV",
            "医院"});
            this.comboBox2.Location = new System.Drawing.Point(14, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(476, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "地图展示";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(782, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "路径生成";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(917, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 32);
            this.button6.TabIndex = 3;
            this.button6.Text = "行进状况模拟";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模拟演练ToolStripMenuItem,
            this.数据管理ToolStripMenuItem,
            this.救援管理ToolStripMenuItem,
            this.救援力量展示ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 模拟演练ToolStripMenuItem
            // 
            this.模拟演练ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_1,
            this.救援路径规划ToolStripMenuItem,
            this.模拟演练场景ToolStripMenuItem,
            this.地点标注ToolStripMenuItem});
            this.模拟演练ToolStripMenuItem.Name = "模拟演练ToolStripMenuItem";
            this.模拟演练ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.模拟演练ToolStripMenuItem.Text = "模拟演练";
            this.模拟演练ToolStripMenuItem.Click += new System.EventHandler(this.模拟演练ToolStripMenuItem_Click);
            // 
            // Menu_1
            // 
            this.Menu_1.Name = "Menu_1";
            this.Menu_1.Size = new System.Drawing.Size(172, 22);
            this.Menu_1.Text = "模拟灾难发生地点";
            this.Menu_1.Click += new System.EventHandler(this.Menu_1_Click);
            // 
            // 救援路径规划ToolStripMenuItem
            // 
            this.救援路径规划ToolStripMenuItem.Name = "救援路径规划ToolStripMenuItem";
            this.救援路径规划ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.救援路径规划ToolStripMenuItem.Text = "救援路径规划";
            this.救援路径规划ToolStripMenuItem.Click += new System.EventHandler(this.救援路径规划ToolStripMenuItem_Click);
            // 
            // 模拟演练场景ToolStripMenuItem
            // 
            this.模拟演练场景ToolStripMenuItem.Name = "模拟演练场景ToolStripMenuItem";
            this.模拟演练场景ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.模拟演练场景ToolStripMenuItem.Text = "模拟演练场景";
            this.模拟演练场景ToolStripMenuItem.Click += new System.EventHandler(this.模拟演练场景ToolStripMenuItem_Click);
            // 
            // 地点标注ToolStripMenuItem
            // 
            this.地点标注ToolStripMenuItem.Name = "地点标注ToolStripMenuItem";
            this.地点标注ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.地点标注ToolStripMenuItem.Text = "地点标注";
            this.地点标注ToolStripMenuItem.Click += new System.EventHandler(this.地点标注ToolStripMenuItem_Click);
            // 
            // 数据管理ToolStripMenuItem
            // 
            this.数据管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_2_1,
            this.menu_2_2});
            this.数据管理ToolStripMenuItem.Name = "数据管理ToolStripMenuItem";
            this.数据管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据管理ToolStripMenuItem.Text = "数据管理";
            // 
            // menu_2_1
            // 
            this.menu_2_1.Name = "menu_2_1";
            this.menu_2_1.Size = new System.Drawing.Size(148, 22);
            this.menu_2_1.Text = "救援物资管理";
            this.menu_2_1.Click += new System.EventHandler(this.menu_2_1_Click);
            // 
            // menu_2_2
            // 
            this.menu_2_2.Name = "menu_2_2";
            this.menu_2_2.Size = new System.Drawing.Size(148, 22);
            this.menu_2_2.Text = "救援力量管理";
            this.menu_2_2.Click += new System.EventHandler(this.menu_2_2_Click);
            // 
            // 救援管理ToolStripMenuItem
            // 
            this.救援管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.事故现场管理ToolStripMenuItem});
            this.救援管理ToolStripMenuItem.Name = "救援管理ToolStripMenuItem";
            this.救援管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.救援管理ToolStripMenuItem.Text = "救援管理";
            // 
            // 事故现场管理ToolStripMenuItem
            // 
            this.事故现场管理ToolStripMenuItem.Name = "事故现场管理ToolStripMenuItem";
            this.事故现场管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.事故现场管理ToolStripMenuItem.Text = "事故现场管理";
            this.事故现场管理ToolStripMenuItem.Click += new System.EventHandler(this.事故现场管理ToolStripMenuItem_Click);
            // 
            // 救援力量展示ToolStripMenuItem
            // 
            this.救援力量展示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem,
            this.救援方案设计ToolStripMenuItem1,
            this.救援路径规划ToolStripMenuItem1});
            this.救援力量展示ToolStripMenuItem.Name = "救援力量展示ToolStripMenuItem";
            this.救援力量展示ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.救援力量展示ToolStripMenuItem.Text = "救援力量展示";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detailToolStripMenuItem.Text = "室内图展示";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // 救援方案设计ToolStripMenuItem1
            // 
            this.救援方案设计ToolStripMenuItem1.Name = "救援方案设计ToolStripMenuItem1";
            this.救援方案设计ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.救援方案设计ToolStripMenuItem1.Text = "救援方案设计";
            // 
            // 救援路径规划ToolStripMenuItem1
            // 
            this.救援路径规划ToolStripMenuItem1.Name = "救援路径规划ToolStripMenuItem1";
            this.救援路径规划ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.救援路径规划ToolStripMenuItem1.Text = "救援路径规划";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.权限管理ToolStripMenuItem,
            this.参数设置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(443, 250);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(62, 438);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 37);
            this.button7.TabIndex = 10;
            this.button7.Text = "医院";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(263, 438);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 37);
            this.button8.TabIndex = 11;
            this.button8.Text = "消防";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 546);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "多主体应急协同模拟仿真平台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模拟演练ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 救援管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 救援力量展示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_1;
        private System.Windows.Forms.ToolStripMenuItem 救援路径规划ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模拟演练场景ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_2_1;
        private System.Windows.Forms.ToolStripMenuItem menu_2_2;
        private System.Windows.Forms.ToolStripMenuItem 事故现场管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 救援方案设计ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 救援路径规划ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem 地点标注ToolStripMenuItem;
    }
}

