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
{//Testing Git Workflow
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
            var task = NewTask.Text.ToString();
            if (listBox.SelectedIndex != -1 && task!=null)
            {
                var listBoxKey = listBox.Items[listBox.SelectedIndex].ToString();
                TaskItemControl taskItemControl = new TaskItemControl(task);
                TaskItem taskItem = new TaskItem(taskItemControl.IsStarred,taskItemControl.IsDone,task);
                allLists[listBoxKey].Add(taskItem);
                RightFlowPanel.Controls.Add(taskItemControl);
                NewTask.Clear();
            }
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
                control.StateChanged += (s, ev) =>
                {
                    taskitem.IsStarred = control.IsStarred;
                    taskitem.IsDone = control.IsDone;
                };
                RightFlowPanel.Controls.Add(control);
            }
        }
    }
}
