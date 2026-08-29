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
        public bool IsStarred
        {
            get;
            private set;
        } = false;

        public event EventHandler StateChanged;
        private void CheckboxChanged(object sender, EventArgs e)
        {
            StateChanged.Invoke(this, EventArgs.Empty);
        }

        private void StarClicked(object sender, EventArgs e)
        {
            IsStarred = !IsStarred;
            if (IsStarred)
            {
                star.BackgroundImage = Image.FromFile(@"star.png");
            }
            else
            {
                star.BackgroundImage = Image.FromFile(@"star1.png");
            }
            star.BackgroundImageLayout = ImageLayout.Stretch;
            StateChanged.Invoke(this, EventArgs.Empty);
        }
        public TaskItemControl()
        {
            InitializeComponent();
            //TaskText = taskText;
            chkDone.CheckedChanged += CheckboxChanged;
            star.Click += StarClicked;

        }

        private void lblTask_Click(object sender, EventArgs e)
        {

        }
    }
}
