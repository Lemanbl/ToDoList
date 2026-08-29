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
    public partial class AddListForm : Form
    {
        public AddListForm()
        {
            InitializeComponent();
        }
        public string ListName
        {
            get;
            set;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ListName = name.Text;
            DialogResult= DialogResult.OK;
        }
    }
}
