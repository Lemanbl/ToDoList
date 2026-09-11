using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList

{
    public class TaskItem
    {
        public bool IsStarred { get; set; }
        public bool IsDone { get; set; }
        public string Text { get; set; }

        public TaskItem(bool isStarred, bool isDone, string text)
        {
            IsStarred = isStarred;
            IsDone = isDone;
            Text = text; 
        }
    }

}