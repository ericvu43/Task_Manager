using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class FrmTasks : Form
    {
        public class Task
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; } 
            public DateTime DueDate { get; set; }
        }

        public string saveFile = "SaveFile.txt";

        public FrmTasks()
        {
            InitializeComponent();
            PopulateTasksFromFile(saveFile);

        }

        // Function prints all lines of content from Txt file to the Checked list
        public void PopulateTasksFromFile(string filePath)
        {
            // Clear existing items in the CheckedListBox
            ChkLstTasks.Items.Clear();

            // Creates a list of tasks
            List<Task> tasks = new List<Task>();

            // Reads lines from the text file
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Split the line into components using ','
                string[] taskInfo = line.Split(new string[] { ", " }, StringSplitOptions.None);

                if (taskInfo.Length == 4) 
                {
                    string name = taskInfo[0].Split(':')[1].Trim();
                    string description = taskInfo[1].Split(':')[1].Trim();
                    string priority = taskInfo[2].Split(':')[1].Trim();
                    string dueDate = taskInfo[3].Split(':')[1].Trim();


                    // Parse due date and due time into a string
                    DateTime parsedDueDate;
                    if (DateTime.TryParseExact(dueDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDueDate))
                    {
                        tasks.Add(new Task
                        {
                            Name = name,
                            Description = description,
                            Priority = priority,
                            DueDate = parsedDueDate.Date,
                        });
                    }
                }
            }
            // Sets value for each priority string
            var priorityOrder = new Dictionary<string, int>
            {
                { "High", 1 },
                { "Medium", 2 },
                { "Low", 3 },
                {"", 4 }
            };

            // Orders tasks by duedate first then the priority selected
            var sortedTasks = tasks.OrderBy(task => task.DueDate)
                           .ThenBy(task => priorityOrder[task.Priority]);

            // Adds sorted tasks to the CheckedListBox with formatted due date
            foreach (var task in sortedTasks)
            {
                string formattedDueDate = task.DueDate.ToString("MM/dd/yyyy"); // Format due date
                ChkLstTasks.Items.Add($"Name: {task.Name}, Description: {task.Description}, Priority: {task.Priority}, " +
                                      $"Due: {formattedDueDate}");
            }
        }



        private void Tasks_Load(object sender, EventArgs e)
        {
            // Timer for the clock at the top of the form
            timer1.Start();
            UpdateDateTime();
        }
        private void UpdateDateTime()
        {
            TxtDate.Text =  "Today's Date Is: \n" + DateTime.Now.ToString();

        }
        // Every time tick (second) the time is updated
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateSaveFile()
        {
            // Create a list of tasks
            List<Task> tasks = new List<Task>();

            foreach (var task in ChkLstTasks.Items)
            {
                // Splits up sentences in Txt file to variables
                string[] taskInfo = task.ToString().Split(',');

                string name = taskInfo[0].Split(':')[1].Trim();
                string description = taskInfo[1].Split(':')[1].Trim();
                string priority = taskInfo[2].Split(':')[1].Trim();
                string dueDateString = taskInfo[3].Split(':')[1].Trim();

                // Parse due date string to DateTime
                DateTime dueDate = DateTime.ParseExact(dueDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                tasks.Add(new Task
                {
                    Name = name,
                    Description = description,
                    Priority = priority,
                    DueDate = dueDate
                });
            }

            var priorityOrder = new Dictionary<string, int>
            {
                { "High", 1 },
                { "Medium", 2 },
                { "Low", 3 },
                {"", 4 }
            };

            // Sorts tasks by DueDate, then by Priority
            var sortedTasks = tasks.OrderBy(task => task.DueDate)
                                       .ThenBy(task => priorityOrder[task.Priority]);
            // Rewrites the file with the sorted tasks
            using (StreamWriter writer = new StreamWriter(saveFile))
            {
                foreach (var task in sortedTasks)
                {
                    // Formating the task information
                    string formattedDueDate = task.DueDate.ToString("MM/dd/yyyy");
                    writer.WriteLine($"Name: {task.Name}, Description: {task.Description}, Priority: {task.Priority}, DueDate: {formattedDueDate}");
                }
            }
        }



        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            // Instance of FrmAddTasks
            FrmAddTasks frmAddTasks = new FrmAddTasks();

            frmAddTasks.FormClosing += FrmAddTasks_FormClosing;


            // Show the FrmAddTasks form
            frmAddTasks.Show();

        }
        private void FrmAddTasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Repopulate tasks when FrmAddTasks is closing
            PopulateTasksFromFile(saveFile);
           
            UpdateSaveFile();

        }


        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            // Hides existing controls
            BtnAddTask.Visible = false;
            BtnRemoveTask.Visible = false;
            BtnEditTask.Visible = false;
            BtnQuit.Visible = false;


            // Reveals new buttons for Removing tasks buttons
            BtnRemove.Visible = true;      
            BtnRemoveQuit.Visible = true;

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Removes selected tasks from the checklist
            for (int i = ChkLstTasks.Items.Count - 1; i >= 0; i--)
            {
                if (ChkLstTasks.GetItemChecked(i))
                {
                    ChkLstTasks.Items.RemoveAt(i);
                }
            }
            UpdateSaveFile();

        }
        private void BtnRemoveDone_Click(object sender, EventArgs e)
        {
            BtnAddTask.Visible = true;
            BtnRemoveTask.Visible = true;
            BtnEditTask.Visible = true;
            BtnQuit.Visible = true;


            BtnRemove.Visible = false;
            BtnRemoveQuit.Visible = false;
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (ChkLstTasks.CheckedItems.Count == 1)
            {
                string selectedItem = ChkLstTasks.CheckedItems[0].ToString();

                // Get the index of the selected task
                int selectedIndex = ChkLstTasks.Items.IndexOf(selectedItem);

                // Pass the file path and index to FrmEditTask
                FrmEditTask frmEditTask = new FrmEditTask(saveFile, selectedIndex);
                frmEditTask.FormClosing += FrmEditTask_FormClosing;
                frmEditTask.Show();
            }
            else
            {
                MessageBox.Show("Only 1 task can be edited at a time");
            }
        }
        private void FrmEditTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Repopulate tasks when FrmEditTask closes
            PopulateTasksFromFile(saveFile);
            UpdateSaveFile();

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }     
        
    }
}
