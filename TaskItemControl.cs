using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class TaskItemControl : UserControl
    {
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

        public event EventHandler StateChanged;
        private void CheckboxChanged(object sender, EventArgs e)
        {
            if (StateChanged != null)
            {
                StateChanged.Invoke(this, EventArgs.Empty);
            }
           
        }

        private void StarClicked(object sender, EventArgs e)
        {
            IsStarred = !IsStarred;
            if (StateChanged != null)
            {
                StateChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public TaskItemControl(string taskText)
        {
            InitializeComponent();
            TaskText = taskText;
            chkDone.CheckedChanged += CheckboxChanged;
            star.Click += StarClicked;

        }
        public TaskItemControl(TaskItem taskItem)
        {
            InitializeComponent();
            TaskText = taskItem.Text;
            IsDone= taskItem.IsDone;
            IsStarred= taskItem.IsStarred;
            chkDone.CheckedChanged += CheckboxChanged;
            star.Click += StarClicked;
        }

       
    }
}
