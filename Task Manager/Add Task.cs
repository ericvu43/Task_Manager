using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class FrmAddTasks : Form
    {
        private string priority = ""; // Variable for priority buttons
        public string saveFile = "SaveFile.txt";



        public FrmAddTasks()
        {
            InitializeComponent();

        }

        private void BtnHighPriority_Click(object sender, EventArgs e)
        {
            priority = "High";
            BtnHighPriority.BackColor = Color.LightBlue;
            BtnMidPriority.BackColor = Color.White;
            BtnLowPriority.BackColor = Color.White;


        }

        private void BtnMidPriority_Click(object sender, EventArgs e)
        {
            priority = "Medium";
            BtnHighPriority.BackColor = Color.White;
            BtnMidPriority.BackColor = Color.LightBlue;
            BtnLowPriority.BackColor = Color.White;

        }

        private void BtnLowPriority_Click(object sender, EventArgs e)
        {
            priority = "Low";
            BtnHighPriority.BackColor = Color.White;
            BtnMidPriority.BackColor = Color.White;
            BtnLowPriority.BackColor = Color.LightBlue;

        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            // Gets inputs from textboxes and calendar
            string taskName = TxtTaskName.Text;
            string taskDescription = TxtTaskDescription.Text;
            DateTime dueDate = CalDueDate.SelectionStart;

            // Creates a new task object
            string formattedTask = $"Name: {taskName}, Description: {taskDescription}, Priority: {priority}, DueDate: {dueDate.ToString("MM/dd/yyyy")}";

            // Append the task details to the existing file
            using (StreamWriter writer = new StreamWriter(saveFile, true))
            {
                writer.WriteLine(formattedTask);
            }


            // Shows details on the task added
            MessageBox.Show($"Task added:\nName: {taskName}\nDescription: {taskDescription}\nPriority: {priority}\nDue Date: {dueDate.ToString("MM/dd/yyyy")}");

            this.Close();

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
