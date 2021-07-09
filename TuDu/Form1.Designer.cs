
namespace TuDu
{
    partial class mainWindow
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.addTask = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.RadioButton();
            this.personal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.level3 = new System.Windows.Forms.RadioButton();
            this.level2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addTaskBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personalTaskView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.workgroupTaskView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.about = new System.Windows.Forms.Button();
            this.moveToPersonal = new System.Windows.Forms.Button();
            this.moveToGroup = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.addTask.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalTaskView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workgroupTaskView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1119, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(46, 24);
            this.statusBar.Text = "就绪";
            // 
            // addTask
            // 
            this.addTask.Controls.Add(this.panel4);
            this.addTask.Controls.Add(this.panel3);
            this.addTask.Controls.Add(this.panel2);
            this.addTask.Controls.Add(this.panel1);
            this.addTask.Location = new System.Drawing.Point(50, 33);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(1006, 208);
            this.addTask.TabIndex = 3;
            this.addTask.TabStop = false;
            this.addTask.Text = "添加待办";
            this.addTask.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.reset);
            this.panel4.Controls.Add(this.add);
            this.panel4.Location = new System.Drawing.Point(326, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 38);
            this.panel4.TabIndex = 8;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(232, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(104, 32);
            this.reset.TabIndex = 1;
            this.reset.Text = "刷新";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(38, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 32);
            this.add.TabIndex = 0;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.group);
            this.panel3.Controls.Add(this.personal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(574, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 57);
            this.panel3.TabIndex = 7;
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(188, 18);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(87, 22);
            this.group.TabIndex = 4;
            this.group.TabStop = true;
            this.group.Text = "工作组";
            this.group.UseVisualStyleBackColor = true;
            // 
            // personal
            // 
            this.personal.AutoSize = true;
            this.personal.Checked = true;
            this.personal.Location = new System.Drawing.Point(94, 18);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(69, 22);
            this.personal.TabIndex = 0;
            this.personal.TabStop = true;
            this.personal.Text = "个人";
            this.personal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "分配给";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.level3);
            this.panel2.Controls.Add(this.level2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.level1);
            this.panel2.Location = new System.Drawing.Point(68, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 57);
            this.panel2.TabIndex = 6;
            // 
            // level3
            // 
            this.level3.AutoSize = true;
            this.level3.Checked = true;
            this.level3.Location = new System.Drawing.Point(381, 18);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(69, 22);
            this.level3.TabIndex = 6;
            this.level3.TabStop = true;
            this.level3.Text = "普通";
            this.level3.UseVisualStyleBackColor = true;
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.Location = new System.Drawing.Point(249, 18);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(69, 22);
            this.level2.TabIndex = 5;
            this.level2.TabStop = true;
            this.level2.Text = "优先";
            this.level2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "优先级";
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Location = new System.Drawing.Point(118, 18);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(69, 22);
            this.level1.TabIndex = 4;
            this.level1.TabStop = true;
            this.level1.Text = "紧急";
            this.level1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addTaskBox);
            this.panel1.Location = new System.Drawing.Point(68, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 38);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "待办内容";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addTaskBox
            // 
            this.addTaskBox.Location = new System.Drawing.Point(88, 6);
            this.addTaskBox.Name = "addTaskBox";
            this.addTaskBox.Size = new System.Drawing.Size(774, 28);
            this.addTaskBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(50, 248);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 374);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.personalTaskView);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人任务";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // personalTaskView
            // 
            this.personalTaskView.AllowUserToAddRows = false;
            this.personalTaskView.AllowUserToDeleteRows = false;
            this.personalTaskView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personalTaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalTaskView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalTaskView.Location = new System.Drawing.Point(3, 3);
            this.personalTaskView.MultiSelect = false;
            this.personalTaskView.Name = "personalTaskView";
            this.personalTaskView.ReadOnly = true;
            this.personalTaskView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.personalTaskView.RowTemplate.Height = 30;
            this.personalTaskView.Size = new System.Drawing.Size(794, 336);
            this.personalTaskView.TabIndex = 0;
            this.personalTaskView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.workgroupTaskView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工作组任务";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // workgroupTaskView
            // 
            this.workgroupTaskView.AllowUserToAddRows = false;
            this.workgroupTaskView.AllowUserToDeleteRows = false;
            this.workgroupTaskView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workgroupTaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workgroupTaskView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workgroupTaskView.Location = new System.Drawing.Point(3, 3);
            this.workgroupTaskView.Name = "workgroupTaskView";
            this.workgroupTaskView.ReadOnly = true;
            this.workgroupTaskView.RowHeadersWidth = 62;
            this.workgroupTaskView.RowTemplate.Height = 30;
            this.workgroupTaskView.Size = new System.Drawing.Size(794, 336);
            this.workgroupTaskView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.about);
            this.groupBox1.Controls.Add(this.moveToPersonal);
            this.groupBox1.Controls.Add(this.moveToGroup);
            this.groupBox1.Controls.Add(this.done);
            this.groupBox1.Location = new System.Drawing.Point(878, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 342);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待办操作";
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(14, 294);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(154, 33);
            this.about.TabIndex = 3;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.settings_Click);
            // 
            // moveToPersonal
            // 
            this.moveToPersonal.Location = new System.Drawing.Point(14, 210);
            this.moveToPersonal.Name = "moveToPersonal";
            this.moveToPersonal.Size = new System.Drawing.Size(154, 33);
            this.moveToPersonal.TabIndex = 2;
            this.moveToPersonal.Text = "移动至个人";
            this.moveToPersonal.UseVisualStyleBackColor = true;
            this.moveToPersonal.Click += new System.EventHandler(this.moveToPersonal_Click);
            // 
            // moveToGroup
            // 
            this.moveToGroup.Location = new System.Drawing.Point(15, 124);
            this.moveToGroup.Name = "moveToGroup";
            this.moveToGroup.Size = new System.Drawing.Size(154, 33);
            this.moveToGroup.TabIndex = 1;
            this.moveToGroup.Text = "移动至工作组";
            this.moveToGroup.UseVisualStyleBackColor = true;
            this.moveToGroup.Click += new System.EventHandler(this.moveToGroup_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(15, 44);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(154, 33);
            this.done.TabIndex = 0;
            this.done.Text = "完成待办";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1141, 720);
            this.MinimumSize = new System.Drawing.Size(1141, 720);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuDu Task Manager";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.Shown += new System.EventHandler(this.mainWindow_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.addTask.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalTaskView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workgroupTaskView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.GroupBox addTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView personalTaskView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView workgroupTaskView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton level3;
        private System.Windows.Forms.RadioButton level2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addTaskBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton group;
        private System.Windows.Forms.RadioButton personal;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button moveToPersonal;
        private System.Windows.Forms.Button moveToGroup;
        private System.Windows.Forms.Button done;
    }
}

