using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<TaskItem> importantTasks = new List<TaskItem>();
        Dictionary<string, List<TaskItem>> allLists = new Dictionary<string, List<TaskItem>>();
        private void AddListBtn_Click(object sender, EventArgs e)
        {
            AddListForm addListForm = new AddListForm();
            var name = (addListForm.ShowDialog() == DialogResult.OK) ? addListForm.ListName : null;
            if(!string.IsNullOrEmpty(name) && !allLists.ContainsKey(name))
            { 
                allLists.Add(name, new List<TaskItem>());
                listBox.Items.Add(name);
            }
        }
        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            var task = NewTask.Text;
            if (listBox.SelectedIndex != -1 && task !=String.Empty)
            {
                var listBoxKey = listBox.Items[listBox.SelectedIndex].ToString();
                TaskItem taskItem = new TaskItem(false, false, task);
                allLists[listBoxKey].Add(taskItem);
                TaskItemControl taskItemControl = new TaskItemControl(taskItem);
                taskItemControl.StateChanged +=(s,ev)=> {
                    Count(listBoxKey);
                } ;
                RightFlowPanel.Controls.Add(taskItemControl);
                NewTask.Clear();
            }
            else MessageBox.Show("Please select the list or add the task!", "Error",MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RightFlowPanel.Controls.Clear();
            LoadTasksForList();            
        }
        private void LoadTasksForList()
        {
            if (listBox.SelectedIndex == -1) return;
            ListnameLbl.Text = listBox.Items[listBox.SelectedIndex].ToString();
            var listBoxKey = listBox.Items[listBox.SelectedIndex].ToString();
            foreach (var taskitem in allLists[listBoxKey])
            {
                TaskItemControl control = new TaskItemControl(taskitem);
                control.StateChanged += (s, ev) =>
                {
                    MessageBox.Show("StateChanged işləyir");
                    Count(listBoxKey);
                };
                RightFlowPanel.Controls.Add(control);
            }
        }
        private void ImportantTasksBtn_Click(object sender, EventArgs e)
        {
            ListnameLbl.Text = "Important Tasks";
            LoadImportantTasks();
        }
        private void LoadImportantTasks()
        {
            RightFlowPanel.Controls.Clear();
            importantTasks = allLists.Values.SelectMany(taskList => taskList).Where(task=>task.IsStarred).ToList();
            foreach (var task in importantTasks)
            {
                TaskItemControl control = new TaskItemControl(task);
                control.StateChanged += (s, ev) =>
                {
                    if (!task.IsStarred)
                    {
                        importantTasks.Remove(task);
                    }
                };
                RightFlowPanel.Controls.Add(control);
            }
        }
        private void Count(string currentListName)
        {
            if (listBox.SelectedIndex == -1) return;
            int count = allLists[currentListName].Count(task => task.IsDone);
            CompletedTasks.Text = count.ToString();
        }
    }
}