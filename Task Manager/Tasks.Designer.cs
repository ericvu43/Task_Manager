namespace Task_Manager
{
    partial class FrmTasks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTasks));
            this.ChkLstTasks = new System.Windows.Forms.CheckedListBox();
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.BtnRemoveTask = new System.Windows.Forms.Button();
            this.BtnEditTask = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.TxtDate = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRemoveQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkLstTasks
            // 
            this.ChkLstTasks.ForeColor = System.Drawing.Color.Black;
            this.ChkLstTasks.FormattingEnabled = true;
            this.ChkLstTasks.HorizontalScrollbar = true;
            this.ChkLstTasks.Location = new System.Drawing.Point(270, 150);
            this.ChkLstTasks.Name = "ChkLstTasks";
            this.ChkLstTasks.Size = new System.Drawing.Size(287, 289);
            this.ChkLstTasks.TabIndex = 2;
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.BackColor = System.Drawing.Color.White;
            this.BtnAddTask.Location = new System.Drawing.Point(90, 170);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(100, 25);
            this.BtnAddTask.TabIndex = 3;
            this.BtnAddTask.Text = "Add Task";
            this.BtnAddTask.UseVisualStyleBackColor = false;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // BtnRemoveTask
            // 
            this.BtnRemoveTask.Location = new System.Drawing.Point(90, 220);
            this.BtnRemoveTask.Name = "BtnRemoveTask";
            this.BtnRemoveTask.Size = new System.Drawing.Size(100, 25);
            this.BtnRemoveTask.TabIndex = 4;
            this.BtnRemoveTask.Text = "Remove Task";
            this.BtnRemoveTask.UseVisualStyleBackColor = true;
            this.BtnRemoveTask.Click += new System.EventHandler(this.BtnRemoveTask_Click);
            // 
            // BtnEditTask
            // 
            this.BtnEditTask.Location = new System.Drawing.Point(90, 270);
            this.BtnEditTask.Name = "BtnEditTask";
            this.BtnEditTask.Size = new System.Drawing.Size(100, 25);
            this.BtnEditTask.TabIndex = 5;
            this.BtnEditTask.Text = "Edit Task";
            this.BtnEditTask.UseVisualStyleBackColor = true;
            this.BtnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(90, 320);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(100, 25);
            this.BtnQuit.TabIndex = 7;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(90, 12);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(400, 100);
            this.TxtDate.TabIndex = 8;
            this.TxtDate.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(30, 400);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(100, 25);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Visible = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRemoveQuit
            // 
            this.BtnRemoveQuit.Location = new System.Drawing.Point(150, 400);
            this.BtnRemoveQuit.Name = "BtnRemoveQuit";
            this.BtnRemoveQuit.Size = new System.Drawing.Size(100, 25);
            this.BtnRemoveQuit.TabIndex = 7;
            this.BtnRemoveQuit.Text = "Done";
            this.BtnRemoveQuit.UseVisualStyleBackColor = true;
            this.BtnRemoveQuit.Visible = false;
            this.BtnRemoveQuit.Click += new System.EventHandler(this.BtnRemoveDone_Click);
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.BtnRemoveQuit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnEditTask);
            this.Controls.Add(this.BtnRemoveTask);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.ChkLstTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChkLstTasks;
        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.Button BtnRemoveTask;
        private System.Windows.Forms.Button BtnEditTask;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.RichTextBox TxtDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRemoveQuit;
    }
}

