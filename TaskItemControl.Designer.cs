namespace ToDoList
{
    partial class TaskItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.star = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.chkDone);
            this.panel1.Controls.Add(this.star);
            this.panel1.Controls.Add(this.lblTask);
            this.panel1.Location = new System.Drawing.Point(11, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 57);
            this.panel1.TabIndex = 0;
            // 
            // chkDone
            // 
            this.chkDone.Location = new System.Drawing.Point(19, 11);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(40, 40);
            this.chkDone.TabIndex = 3;
            this.chkDone.UseVisualStyleBackColor = true;
            // 
            // star
            // 
            this.star.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star.BackColor = System.Drawing.Color.Azure;
            this.star.BackgroundImage = global::ToDoList.Properties.Resources.star1;
            this.star.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star.Location = new System.Drawing.Point(364, 12);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(35, 35);
            this.star.TabIndex = 2;
            this.star.UseVisualStyleBackColor = false;
            // 
            // lblTask
            // 
            this.lblTask.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(55, 12);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(302, 35);
            this.lblTask.TabIndex = 1;
            this.lblTask.Click += new System.EventHandler(this.lblTask_Click);
            // 
            // TaskItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TaskItemControl";
            this.Size = new System.Drawing.Size(455, 122);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.CheckBox chkDone;
    }
}
