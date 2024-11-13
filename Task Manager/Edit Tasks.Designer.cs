namespace Task_Manager
{
    partial class FrmEditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTask));
            this.LblTaskName = new System.Windows.Forms.Label();
            this.TxtTaskName = new System.Windows.Forms.TextBox();
            this.LblTaskDescription = new System.Windows.Forms.Label();
            this.TxtTaskDescription = new System.Windows.Forms.RichTextBox();
            this.LblTaskPriority = new System.Windows.Forms.Label();
            this.BtnSaveTask = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.CalDueDate = new System.Windows.Forms.MonthCalendar();
            this.BtnLowPriority = new System.Windows.Forms.Button();
            this.BtnMidPriority = new System.Windows.Forms.Button();
            this.BtnHighPriority = new System.Windows.Forms.Button();
            this.LblTaskDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(23, 37);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.Size = new System.Drawing.Size(62, 13);
            this.LblTaskName.TabIndex = 3;
            this.LblTaskName.Text = "Task Name";
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.Location = new System.Drawing.Point(130, 34);
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Size = new System.Drawing.Size(201, 20);
            this.TxtTaskName.TabIndex = 4;
            // 
            // LblTaskDescription
            // 
            this.LblTaskDescription.AutoSize = true;
            this.LblTaskDescription.Location = new System.Drawing.Point(23, 93);
            this.LblTaskDescription.Name = "LblTaskDescription";
            this.LblTaskDescription.Size = new System.Drawing.Size(87, 13);
            this.LblTaskDescription.TabIndex = 5;
            this.LblTaskDescription.Text = "Task Description";
            // 
            // TxtTaskDescription
            // 
            this.TxtTaskDescription.Location = new System.Drawing.Point(130, 93);
            this.TxtTaskDescription.Name = "TxtTaskDescription";
            this.TxtTaskDescription.Size = new System.Drawing.Size(201, 106);
            this.TxtTaskDescription.TabIndex = 6;
            this.TxtTaskDescription.Text = "";
            // 
            // LblTaskPriority
            // 
            this.LblTaskPriority.AutoSize = true;
            this.LblTaskPriority.Location = new System.Drawing.Point(23, 231);
            this.LblTaskPriority.Name = "LblTaskPriority";
            this.LblTaskPriority.Size = new System.Drawing.Size(65, 13);
            this.LblTaskPriority.TabIndex = 9;
            this.LblTaskPriority.Text = "Task Priority";
            // 
            // BtnSaveTask
            // 
            this.BtnSaveTask.Location = new System.Drawing.Point(60, 480);
            this.BtnSaveTask.Name = "BtnSaveTask";
            this.BtnSaveTask.Size = new System.Drawing.Size(100, 23);
            this.BtnSaveTask.TabIndex = 23;
            this.BtnSaveTask.Text = "Save";
            this.BtnSaveTask.UseVisualStyleBackColor = true;
            this.BtnSaveTask.Click += new System.EventHandler(this.BtnSaveTask_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(195, 480);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(100, 23);
            this.BtnQuit.TabIndex = 22;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // CalDueDate
            // 
            this.CalDueDate.Location = new System.Drawing.Point(122, 305);
            this.CalDueDate.Name = "CalDueDate";
            this.CalDueDate.TabIndex = 21;
            // 
            // BtnLowPriority
            // 
            this.BtnLowPriority.Location = new System.Drawing.Point(270, 231);
            this.BtnLowPriority.Name = "BtnLowPriority";
            this.BtnLowPriority.Size = new System.Drawing.Size(75, 23);
            this.BtnLowPriority.TabIndex = 20;
            this.BtnLowPriority.Text = "Low";
            this.BtnLowPriority.UseVisualStyleBackColor = true;
            this.BtnLowPriority.Click += new System.EventHandler(this.BtnLowPriority_Click);
            // 
            // BtnMidPriority
            // 
            this.BtnMidPriority.Location = new System.Drawing.Point(196, 231);
            this.BtnMidPriority.Name = "BtnMidPriority";
            this.BtnMidPriority.Size = new System.Drawing.Size(75, 23);
            this.BtnMidPriority.TabIndex = 19;
            this.BtnMidPriority.Text = "Medium";
            this.BtnMidPriority.UseVisualStyleBackColor = true;
            this.BtnMidPriority.Click += new System.EventHandler(this.BtnMidPriority_Click);
            // 
            // BtnHighPriority
            // 
            this.BtnHighPriority.Location = new System.Drawing.Point(122, 231);
            this.BtnHighPriority.Name = "BtnHighPriority";
            this.BtnHighPriority.Size = new System.Drawing.Size(75, 23);
            this.BtnHighPriority.TabIndex = 18;
            this.BtnHighPriority.Text = "High";
            this.BtnHighPriority.UseVisualStyleBackColor = true;
            this.BtnHighPriority.Click += new System.EventHandler(this.BtnHighPriority_Click);
            // 
            // LblTaskDueDate
            // 
            this.LblTaskDueDate.AutoSize = true;
            this.LblTaskDueDate.Location = new System.Drawing.Point(23, 305);
            this.LblTaskDueDate.Name = "LblTaskDueDate";
            this.LblTaskDueDate.Size = new System.Drawing.Size(80, 13);
            this.LblTaskDueDate.TabIndex = 24;
            this.LblTaskDueDate.Text = "Task Due Date";
            // 
            // FrmEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 516);
            this.Controls.Add(this.LblTaskDueDate);
            this.Controls.Add(this.BtnSaveTask);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.CalDueDate);
            this.Controls.Add(this.BtnLowPriority);
            this.Controls.Add(this.BtnMidPriority);
            this.Controls.Add(this.BtnHighPriority);
            this.Controls.Add(this.LblTaskPriority);
            this.Controls.Add(this.TxtTaskDescription);
            this.Controls.Add(this.LblTaskDescription);
            this.Controls.Add(this.TxtTaskName);
            this.Controls.Add(this.LblTaskName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditTask";
            this.Text = "Edit Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTaskName;
        private System.Windows.Forms.TextBox TxtTaskName;
        private System.Windows.Forms.Label LblTaskDescription;
        private System.Windows.Forms.RichTextBox TxtTaskDescription;
        private System.Windows.Forms.Label LblTaskPriority;
        private System.Windows.Forms.Button BtnSaveTask;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.MonthCalendar CalDueDate;
        private System.Windows.Forms.Button BtnLowPriority;
        private System.Windows.Forms.Button BtnMidPriority;
        private System.Windows.Forms.Button BtnHighPriority;
        private System.Windows.Forms.Label LblTaskDueDate;
    }
}

