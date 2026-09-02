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
            if (listBox.SelectedIndex != -1)
            {
                var listBoxKey = listBox.Items[listBox.SelectedIndex].ToString();
                TaskItem taskItem = new TaskItem(false,false,task);
                allLists[listBoxKey].Add(taskItem);
                TaskItemControl taskItemControl = new TaskItemControl(task);
                RightFlowPanel.Controls.Add(taskItemControl);
                NewTask.Clear();
            }
        }
        
        // list selected
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            RightFlowPanel.Controls.Clear();
            var listBoxKey = listBox.Items[listBox.SelectedIndex].ToString();
            foreach (var taskitem in allLists[listBoxKey])
            {
                if (taskitem != null) {
                    TaskItemControl control = new TaskItemControl(taskitem);
                    RightFlowPanel.Controls.Add(control);
                }
            }
            ListnameLbl.Text=listBox.Items[listBox.SelectedIndex].ToString();
            
        }

    }
}
