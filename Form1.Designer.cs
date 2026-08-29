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
            this.ListnameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompletedTasks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Azure;
            this.LeftPanel.Controls.Add(this.ListnameLbl);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.CompletedTasks);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.flowLayoutPanel2);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(392, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(578, 602);
            this.LeftPanel.TabIndex = 0;
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
            this.CompletedTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompletedTasks.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTasks.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CompletedTasks.Location = new System.Drawing.Point(178, 80);
            this.CompletedTasks.Name = "CompletedTasks";
            this.CompletedTasks.Size = new System.Drawing.Size(107, 42);
            this.CompletedTasks.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(18, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(557, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "+ Add a new task";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 175);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(581, 420);
            this.flowLayoutPanel2.TabIndex = 10;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.LightCyan;
            this.RightPanel.Controls.Add(this.flowLayoutPanel1);
            this.RightPanel.Controls.Add(this.pictureBox1);
            this.RightPanel.Controls.Add(this.button4);
            this.RightPanel.Controls.Add(this.button3);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.monthCalendar1);
            this.RightPanel.Controls.Add(this.dateTimePicker1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(3, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(383, 602);
            this.RightPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 233);
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
            this.listBox.Items.AddRange(new object[] {
            "List1"});
            this.listBox.Location = new System.Drawing.Point(3, 3);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(374, 74);
            this.listBox.TabIndex = 0;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BackgroundImage = global::ToDoList.Properties.Resources.star;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(318, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(19, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(345, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "important tasks";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(19, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(345, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "+ add new list";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.AddListBtn_Click);
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
            this.monthCalendar1.Location = new System.Drawing.Point(37, 342);
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
            this.ClientSize = new System.Drawing.Size(973, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TO-DO list";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CompletedTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ListnameLbl;
    }
}

