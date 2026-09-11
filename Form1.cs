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
                //Adding Key
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
                RightFlowPanel.Controls.Add(taskItemControl);
                NewTask.Clear();
            }
            else MessageBox.Show("Please select the list or add the task!", "Error",MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }
        // list selected
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RightFlowPanel.Controls.Clear();
            LoadTasksForList();
            
        }
        private void LoadTasksForList()
        {
            ListnameLbl.Text = listBox.Items[listBox.SelectedIndex].ToString();
            var listBoxKey = listBox.Items[listBox.SelectedIndex].ToString();
            foreach (var taskitem in allLists[listBoxKey])
            {
                TaskItemControl control = new TaskItemControl(taskitem);
                RightFlowPanel.Controls.Add(control);
            }
        }
        private void ImportantTasksBtn_Click(object sender, EventArgs e)
        {
            RightFlowPanel.Controls.Clear();
            ListnameLbl.Text = "Important Tasks";
            importantTasks=GetTasks();
            foreach (var task in importantTasks) {
                TaskItemControl control = new TaskItemControl(task);
                control.StateChanged += (s, ev) =>
                {
                    if (task.IsStarred)
                    {
                        importantTasks.Add(task);
                    }
                    else importantTasks.Remove(task);
                };
                RightFlowPanel.Controls.Add(control);
            }

            
            
        }
        private List<TaskItem> GetTasks()
        {
            return allLists.Values.SelectMany(taskList=>taskList).ToList();
        }
    }
}