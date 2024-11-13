using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task_Manager
{

    public partial class FrmEditTask : Form
    {

        private List<string> taskLines;
        public string saveFile = "SaveFile.txt";
        private int index;   // Used to figure which task to edit based on selection
        string newPriority = "";



        public FrmEditTask(string filePath, int index)
        {
            InitializeComponent();
            this.index = index;  // Saves index value


            // Read all lines from the file
            taskLines = File.ReadAllLines(filePath).ToList();

            // Extract task details from the specified index
            string[] taskInfo = taskLines[index].Split(new string[] { ", " }, StringSplitOptions.None);

            if (taskInfo.Length == 4)
            {
                string name = taskInfo[0].Split(':')[1].Trim();
                string description = taskInfo[1].Split(':')[1].Trim();
                string priority = taskInfo[2].Split(':')[1].Trim();
                string dueDate = taskInfo[3].Split(':')[1].Trim();

                // Fills Txtboxes and changes date on calendar to whatever the task had before
                TxtTaskName.Text = name;
                TxtTaskDescription.Text = description;
                switch (priority)
                {
                    case "High":
                        BtnHighPriority.BackColor = Color.LightBlue;
                        break;
                    case "Medium":
                        BtnMidPriority.BackColor = Color.LightBlue;
                        break;
                    case "Low":
                        BtnLowPriority.BackColor = Color.LightBlue;
                        break;
                    
                }
                DateTime dateTime = DateTime.ParseExact(dueDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                CalDueDate.SetDate(dateTime);

                }
        }
        
        private void BtnHighPriority_Click(object sender, EventArgs e)
        {
            newPriority = "High";
            BtnHighPriority.BackColor = Color.LightBlue;
            BtnMidPriority.BackColor = Color.White;
            BtnLowPriority.BackColor = Color.White;
        }

        private void BtnMidPriority_Click(object sender, EventArgs e)
        {
            newPriority = "Medium";
            BtnHighPriority.BackColor = Color.White;
            BtnMidPriority.BackColor = Color.LightBlue;
            BtnLowPriority.BackColor = Color.White;
        }

        private void BtnLowPriority_Click(object sender, EventArgs e)
        {
            newPriority = "Low";
            BtnHighPriority.BackColor = Color.White;
            BtnMidPriority.BackColor = Color.White;
            BtnLowPriority.BackColor = Color.LightBlue;
        }

        private void BtnSaveTask_Click(object sender, EventArgs e)
        {
            // Gets the modified task details from the form
            string newTaskName = TxtTaskName.Text;
            string newTaskDescription = TxtTaskDescription.Text;
            string[] taskInfo = taskLines[index].Split(new string[] { ", " }, StringSplitOptions.None);
            string previousPriority = taskInfo[2].Split(':')[1].Trim();                

            DateTime newDueDate = CalDueDate.SelectionStart;

            if (newPriority == "")
            {
                newPriority = previousPriority;
            }

            // Create the updated task string
            string updatedTask = $"Name: {newTaskName}, Description: {newTaskDescription}, Priority: {newPriority}, DueDate: {newDueDate.ToString("MM/dd/yyyy")}";

            // Update the specific line in taskLines
            taskLines[index] = updatedTask;

            // Rewrite the entire content of the file with the updated taskLines
            File.WriteAllLines(saveFile, taskLines);

            MessageBox.Show("Task updated successfully.");
            this.Close();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
