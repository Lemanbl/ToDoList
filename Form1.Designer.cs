namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NewTask = new System.Windows.Forms.TextBox();
            this.ListnameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompletedTasks = new System.Windows.Forms.Label();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.RightFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImportantTasksBtn = new System.Windows.Forms.Button();
            this.AddListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.LeftPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RightPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 644);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Azure;
            this.LeftPanel.Controls.Add(this.NewTask);
            this.LeftPanel.Controls.Add(this.ListnameLbl);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.CompletedTasks);
            this.LeftPanel.Controls.Add(this.AddTaskBtn);
            this.LeftPanel.Controls.Add(this.RightFlowPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(405, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(598, 638);
            this.LeftPanel.TabIndex = 0;
            // 
            // NewTask
            // 
            this.NewTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTask.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTask.Location = new System.Drawing.Point(48, 585);
            this.NewTask.Multiline = true;
            this.NewTask.Name = "NewTask";
            this.NewTask.Size = new System.Drawing.Size(541, 39);
            this.NewTask.TabIndex = 15;
            // 
            // ListnameLbl
            // 
            this.ListnameLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListnameLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ListnameLbl.Location = new System.Drawing.Point(15, 17);
            this.ListnameLbl.Name = "ListnameLbl";
            this.ListnameLbl.Size = new System.Drawing.Size(289, 41);
            this.ListnameLbl.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "Completed :";
            // 
            // CompletedTasks
            // 
            this.CompletedTasks.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTasks.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CompletedTasks.Location = new System.Drawing.Point(174, 79);
            this.CompletedTasks.Name = "CompletedTasks";
            this.CompletedTasks.Size = new System.Drawing.Size(107, 42);
            this.CompletedTasks.TabIndex = 12;
            this.CompletedTasks.Text = "0";
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTaskBtn.BackColor = System.Drawing.Color.Azure;
            this.AddTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTaskBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddTaskBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddTaskBtn.Location = new System.Drawing.Point(3, 582);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(43, 44);
            this.AddTaskBtn.TabIndex = 11;
            this.AddTaskBtn.Text = "+ ";
            this.AddTaskBtn.UseVisualStyleBackColor = false;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // RightFlowPanel
            // 
            this.RightFlowPanel.AutoScroll = true;
            this.RightFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightFlowPanel.Location = new System.Drawing.Point(0, 144);
            this.RightFlowPanel.Name = "RightFlowPanel";
            this.RightFlowPanel.Size = new System.Drawing.Size(581, 396);
            this.RightFlowPanel.TabIndex = 10;
            this.RightFlowPanel.WrapContents = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.LightCyan;
            this.RightPanel.Controls.Add(this.flowLayoutPanel1);
            this.RightPanel.Controls.Add(this.pictureBox1);
            this.RightPanel.Controls.Add(this.ImportantTasksBtn);
            this.RightPanel.Controls.Add(this.AddListBtn);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.monthCalendar1);
            this.RightPanel.Controls.Add(this.dateTimePicker1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(3, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(396, 638);
            this.RightPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 251);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 97);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.Color.Azure;
            this.listBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 35;
            this.listBox.Location = new System.Drawing.Point(3, 3);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(374, 74);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BackgroundImage = global::ToDoList.Properties.Resources.star;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(331, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ImportantTasksBtn
            // 
            this.ImportantTasksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportantTasksBtn.BackColor = System.Drawing.Color.Azure;
            this.ImportantTasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportantTasksBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportantTasksBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ImportantTasksBtn.Location = new System.Drawing.Point(19, 125);
            this.ImportantTasksBtn.Name = "ImportantTasksBtn";
            this.ImportantTasksBtn.Size = new System.Drawing.Size(358, 44);
            this.ImportantTasksBtn.TabIndex = 5;
            this.ImportantTasksBtn.Text = "important tasks";
            this.ImportantTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportantTasksBtn.UseVisualStyleBackColor = false;
            this.ImportantTasksBtn.Click += new System.EventHandler(this.ImportantTasksBtn_Click);
            // 
            // AddListBtn
            // 
            this.AddListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddListBtn.BackColor = System.Drawing.Color.Azure;
            this.AddListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddListBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddListBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddListBtn.Location = new System.Drawing.Point(19, 175);
            this.AddListBtn.Name = "AddListBtn";
            this.AddListBtn.Size = new System.Drawing.Size(358, 44);
            this.AddListBtn.TabIndex = 4;
            this.AddListBtn.Text = "+ add new list";
            this.AddListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddListBtn.UseVisualStyleBackColor = false;
            this.AddListBtn.Click += new System.EventHandler(this.AddListBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(26, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome!";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(37, 378);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 37);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1006, 644);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TO-DO list";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImportantTasksBtn;
        private System.Windows.Forms.Button AddListBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel RightFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Label CompletedTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ListnameLbl;
        private System.Windows.Forms.TextBox NewTask;
    }
}

