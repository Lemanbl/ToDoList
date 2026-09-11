using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class TaskItemControl : UserControl
    {
        private TaskItem taskItem;
        public string TaskText
        {
            get => lblTask.Text;
            set => lblTask.Text = value;
        }

        public bool IsDone
        {
            get => chkDone.Checked;
            set => chkDone.Checked = value;
        }
        private bool isStarred;

        public bool IsStarred
        {
            get { return isStarred; }
            private set
            {
                isStarred = value;
                if (isStarred)
                {
                    star.BackgroundImage = Properties.Resources.star;              
                }
                else
                {
                    star.BackgroundImage = Properties.Resources.star1;
                }

                star.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void CheckboxChanged(object sender, EventArgs e)
        {
           taskItem.IsDone= chkDone.Checked;
        }

        public EventHandler StateChanged;
        private void StarClicked(object sender, EventArgs e)
        {
            IsStarred = !IsStarred;
            taskItem.IsStarred=IsStarred;
            if (StateChanged != null)
            {
                StateChanged.Invoke(this, EventArgs.Empty);
            }
        }

        public TaskItemControl(TaskItem taskItem)
        {
            this.taskItem= taskItem;
            InitializeComponent();
            TaskText = taskItem.Text;
            IsDone= taskItem.IsDone;
            IsStarred= taskItem.IsStarred;
            chkDone.CheckedChanged += CheckboxChanged;
            star.Click += StarClicked;
        }

       
    }
}
