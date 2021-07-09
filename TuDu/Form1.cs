using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using SQLiteUtil;

namespace TuDu
{
    public partial class mainWindow : Form
    {
        private DBHelper db;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainWindow_Shown(object sender, EventArgs e)
        {

        }
        public void refresh()
        {            
            DataTable personalDt = db.GetTable(db.personalQueryCommand);
            DataTable workgroupDt = db.GetTable(db.workgroupQueryCommand);
            personalTaskView.DataSource = personalDt;
            workgroupTaskView.DataSource = workgroupDt;
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            db = new DBHelper(false);
            if (!db.IsInitialized())
            {
                MessageBox.Show("未发现数据库文件，已在" + Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "新建数据库文件。");
            }
            //addTaskBox.Text = db.databasePath;
            db = new DBHelper();
            db.conn.Open();
            refresh();
            db.conn.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            db = new DBHelper();
            db.conn.Open();
            string task = addTaskBox.Text;
            string addtime = DateTime.Now.ToString();
            string taskType="";
            int urgency = 3;
            if (task == "")
            {
                MessageBox.Show("请先输入待办内容！");
                return;
            }
            if (level3.Checked == true)
                urgency = 3;
            else if (level2.Checked == true)
                urgency = 2;
            else if (level1.Checked == true)
                urgency = 1;
            if (personal.Checked == true)
            {
                taskType = "personalTaskdata (id, content, priority, addtime)";
                
            }
            else if (group.Checked == true)
            {
                taskType = "workgroupTaskdata (id, content, priority, addtime)";
            }
            db.insertCommand = "INSERT INTO " + taskType + "VALUES(NULL, @task, @urgency, @addtime)";
            db.command = new SQLiteCommand(db.insertCommand, db.conn);
            db.command.Parameters.AddWithValue("@task", task);
            db.command.Parameters.AddWithValue("@urgency", urgency);
            db.command.Parameters.AddWithValue("@addtime", addtime);
            db.command.ExecuteNonQuery();
            refresh();
            db.conn.Close();
            addTaskBox.Text="";
            statusBar.Text = "新待办已添加，" + DateTime.Now.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            db = new DBHelper();
            db.conn.Open();
            refresh();
            db.conn.Close();
            statusBar.Text = "就绪";
        }

        private void done_Click(object sender, EventArgs e)
        {
            db = new DBHelper();
            db.conn.Open();
            if (personalTaskView.SelectedRows.Count > 0)
            {
                //selectedRow = (DataRow)personalTaskView.CurrentRow.DataBoundItem;
                //int selectedIndex = personalTaskView.CurrentRow.Index;
                string selectedContent = personalTaskView.CurrentRow.Cells["id"].Value.ToString();
                int selectedIndex = int.Parse(selectedContent);
                //MessageBox.Show(selectedContent+personalTaskView.CurrentRow.Cells["id"].Value.GetType()+selectedIndex+selectedIndex.GetType());
                db.deleteRows(selectedIndex, "personalTaskdata");
                statusBar.Text = "选择待办已完成";
            }
            else if (workgroupTaskView.SelectedRows.Count > 0)
            {
                string selectedContent = workgroupTaskView.CurrentRow.Cells["id"].Value.ToString();
                int selectedIndex = int.Parse(selectedContent);
                //MessageBox.Show(selectedContent + workgroupTaskView.CurrentRow.Cells["id"].Value.GetType() + selectedIndex + selectedIndex.GetType());
                db.deleteRows(selectedIndex, "workgroupTaskdata");
                statusBar.Text = "选择待办已完成";
            }
            else
            {
                MessageBox.Show("请选择事项后再点击完成！");
                statusBar.Text = "就绪";
            }
            refresh();
            db.conn.Close();
        }

        private void moveToGroup_Click(object sender, EventArgs e)
        {
            db = new DBHelper();
            db.conn.Open();
            if (personalTaskView.SelectedRows.Count > 0)
            {
                string selectedContent = personalTaskView.CurrentRow.Cells["id"].Value.ToString();
                int selectedIndex = int.Parse(selectedContent); 
                string task = personalTaskView.CurrentRow.Cells["content"].Value.ToString();
                string addtime = personalTaskView.CurrentRow.Cells["addtime"].Value.ToString();
                int urgency = int.Parse(personalTaskView.CurrentRow.Cells["priority"].Value.ToString());
                string taskType = "workgroupTaskdata (id, content, priority, addtime)";
                db.insertCommand = "INSERT INTO " + taskType + "VALUES(NULL, @task, @urgency, @addtime)";
                db.command = new SQLiteCommand(db.insertCommand, db.conn);
                db.command.Parameters.AddWithValue("@task", task);
                db.command.Parameters.AddWithValue("@urgency", urgency);
                db.command.Parameters.AddWithValue("@addtime", addtime);
                db.command.ExecuteNonQuery();
                db.deleteRows(selectedIndex, "personalTaskdata");
                statusBar.Text = "所选待办已移动至工作组";
            }
            else if (workgroupTaskView.SelectedRows.Count > 0)
            {
                MessageBox.Show("当前待办已经在工作组中！");
                statusBar.Text = "就绪";
                return;
            }
            else
            {
                MessageBox.Show("请选择个人待办事项后再操作！");
                statusBar.Text = "就绪";
                return;
            }
            refresh();
            db.conn.Close();
        }

        private void moveToPersonal_Click(object sender, EventArgs e)
        {
            db = new DBHelper();
            db.conn.Open();
            if (personalTaskView.SelectedRows.Count > 0)
            {
                MessageBox.Show("当前待办已经在个人待办中！");
                statusBar.Text = "就绪";
                return;
            }
            else if (workgroupTaskView.SelectedRows.Count > 0)
            {
                string selectedContent = workgroupTaskView.CurrentRow.Cells["id"].Value.ToString();
                int selectedIndex = int.Parse(selectedContent);
                string task = workgroupTaskView.CurrentRow.Cells["content"].Value.ToString();
                string addtime = workgroupTaskView.CurrentRow.Cells["addtime"].Value.ToString();
                int urgency = int.Parse(workgroupTaskView.CurrentRow.Cells["priority"].Value.ToString());
                string taskType = "personalTaskdata (id, content, priority, addtime)";
                db.insertCommand = "INSERT INTO " + taskType + "VALUES(NULL, @task, @urgency, @addtime)";
                db.command = new SQLiteCommand(db.insertCommand, db.conn);
                db.command.Parameters.AddWithValue("@task", task);
                db.command.Parameters.AddWithValue("@urgency", urgency);
                db.command.Parameters.AddWithValue("@addtime", addtime);
                db.command.ExecuteNonQuery();
                db.deleteRows(selectedIndex, "workgroupTaskdata");
                statusBar.Text = "所选待办已移动至个人";
            }
            else
            {
                MessageBox.Show("请选择个人待办事项后再操作！");
                statusBar.Text = "就绪";
                return;
            }
            refresh();
            db.conn.Close();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            aboutBox1 aboutbox = new aboutBox1();
            aboutbox.Show();
        }
    }
}
