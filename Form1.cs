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
                allLists.Add(name, new List<TaskItem>());
                listBox.Items.Add(name);
            }
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            ListnameLbl.Text=listBox.SelectedItem.ToString();
        }
        TaskItemControl taskItemControl = new TaskItemControl();
        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                TaskItemControl taskItemControl = new TaskItemControl();
            }
        }
    }
}
