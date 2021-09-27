using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {

        private TaskManager taskManager;
        //creates a file path for use of a single file for storing and reading data
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        private bool closing = false;//used for closing event
        PictureBox pictureBox = new PictureBox();

        public MainForm()
        {
            InitializeComponent();

            //initializes GUI to default values
            InitializeGUI();

        }
        /// <summary>
        /// Called at start of program or when a new file is created
        /// This method initializes all controls and clears any information from the
        /// controls
        /// </summary>
        private void InitializeGUI()
        {
            //creates an instance of TaskManager
            taskManager = new TaskManager();

            this.Icon = Properties.Resources.Kearone_Platecons_Regional_settings;
            //enables custom DateTimePickerFormat and set it to prefered format
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd        HH:mm";            
            GetPriorities();//change representation of enum to "prettier" version
            cboxPriority.SelectedIndex = (int)PriorityType.Normal;
            //clears label showing time
            lblClock.Text = string.Empty;
            //clears the listbox
            lboxToDo.Items.Clear();

            txtDescription.Text = string.Empty;


        }
        /// <summary>
        /// This method sends strings to the combobox with the '_' caracter replaced
        /// with ' ' from the PriorityType enum
        /// </summary>
        private void GetPriorities()
        {
            //gets a string with all the names from the enum
            string[] priorities = Enum.GetNames(typeof(PriorityType));
            //loops through the array reaplacing all '_' with ' '
            for (int i = 0; i < priorities.Length; i++)
            {
                priorities[i] = priorities[i].Replace("_", " ");
            }
            //set combobox DataSource
            cboxPriority.DataSource = priorities;
        }
        /// <summary>
        /// This method updates the GUI so it will display correct information
        /// in the listbox and sets the combobox to default value
        /// </summary>
        private void UpdateGUI()
        {
            //clears controls of info
            cboxPriority.SelectedIndex = (int)PriorityType.Normal;
            txtDescription.Text = string.Empty;
            lboxToDo.Items.Clear();
            //creates an array of strings to show in listbox
            string[] infoStrings = taskManager.GetInfoStrings();
            if(infoStrings != null)
            {
                lboxToDo.Items.AddRange(infoStrings);
            }
            //disables buttons, if an item in listbox has been selected before
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Makes used of the form Timer control to update labeltext on every tick
        /// </summary>
        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadValues();
            if (taskManager.AddTask(task))
            {
                UpdateGUI();
            }
        }
        /// <summary>
        /// This method reads the input values from the form controls and
        /// creates a Task object using the values as arguments for
        /// constructor with 3 parameters. If no description is added an error
        /// message is shown
        /// </summary>
        /// <returns>object of Task class</returns>
        private Task ReadValues()
        {
            //creates a task and sets it to null
            Task task = null;
            bool ok = false;
            //makes sure string is not emtpy
            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                ok = true;
            }
            //all if fine
            if (ok)
            {
                //creates a new task using inputvalues as arguments, the SetPriority parses
                //text from the combox into a PriorityType
                task = new Task(dateTimePicker.Value, txtDescription.Text, SetPriority());
            }
            else
            {
                MessageBox.Show("Please enter a description for your task", "Error");
            }
            return task;
        }
        /// <summary>
        /// This method is used to convert the string value in cboxPriority
        /// to a PriorityType enum by replacing " " with "_" then parsing
        /// </summary>
        /// <returns>PriorityType enum</returns>
        private PriorityType SetPriority()
        {
            //gets string from combobox
            string prio = cboxPriority.Text;
            //replaces space with "_"
            prio = prio.Replace(" ", "_");
            //parses string to enum
            PriorityType priority = (PriorityType)Enum.Parse(typeof(PriorityType), prio);
            return priority;
        }
        /// <summary>
        /// Changebutton is used to save the current information from form controls
        /// and save them to the taskList at the selected index, replacing the task
        /// stored at that index.
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.CheckIndex(lboxToDo.SelectedIndex);
            if (ok)//valid index
            {
                //this works just like in add method
                Task task = ReadValues();
                //saves the new task to the selected index, replacing the object that was stored there
                taskManager.ChangeTask(task, lboxToDo.SelectedIndex);
                //after changes in the taskList always update GUI to display correct info
                UpdateGUI();
            }
            else//not valid index
            {
                MessageBox.Show("Something went wrong", "Error");
            }
        }
        /// <summary>
        /// When listbox index is changed the index is checked, 
        /// if index is valid for taskList, the Change/Delete buttons are enabled 
        /// and a local Task object is created to add the stored values to the 
        /// form controls
        /// </summary>
        private void lboxToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a valid index has been selected
            bool ok = taskManager.CheckIndex(lboxToDo.SelectedIndex);
            if (ok)//index valid
            {
                //enables the Change and Delete buttons
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
                Task task = new Task(taskManager.GetTask(lboxToDo.SelectedIndex));
                //sets the values of task to the form controls
                cboxPriority.SelectedIndex = (int)task.Priority;
                txtDescription.Text = task.Description;
                dateTimePicker.Value = task.Date;

            }

        }
        /// <summary>
        /// Deletebutton will delete/remove the task at selected index
        /// then update the GUI.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //checks if index is valid
            bool ok = taskManager.CheckIndex(lboxToDo.SelectedIndex);
            if (ok)
            {
                //removes the task at selected index
                taskManager.DeleteTask(lboxToDo.SelectedIndex);
                //updates the listbox after the list has changed
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Something went wrong", "Error");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //all that is needed is to call InitializeGUI and program will "reset"
            InitializeGUI();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a DailogResult from a messagebox with YesNo buttons
            DialogResult dlgResult = MessageBox.Show("You are about to exit. Are you sure?", "Close Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dlgResult == DialogResult.Yes)//if yes is clicked
            {
                //call exit method
                closing = true;
                Application.Exit();
                
            }
        }
        /// <summary>
        /// If user attempts to close form using the "X" button on form. If user
        /// has exited app using the menu exit then the form will automatically close
        /// </summary>

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)//this will be true if user closed app using the menu
            {
                DialogResult dlgResult = MessageBox.Show("You are about to exit. Are you sure?", "Close Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.No)//if yes is clicked
                {
                    //cancel the exit event
                    e.Cancel = true;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates an object of Aboutbox and displays it as dialog
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errorMessage = "Something went wrong when saving data to file";
            //calls the method for saving data from TaskManager and store bool value in "ok"
            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok)//if something went wrong
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else//display message that data was saved successfully
            {
                MessageBox.Show("Data saved to file" + Environment.NewLine + fileName);
            }
        }

        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You are opening a file, any unsaved data will be lost.\nProceed?";
            //will warn user that opening a file will delete any unsaved data
            if(MessageBox.Show(message, "Open File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string errorMessage = "Something went wrong when reading data from file";
                //calls the method for reading data from TaskManager and store bool value in "ok"
                bool ok = taskManager.ReadDataFromFile(fileName);
                if (!ok)//something went wrong
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else//if successful will update GUI with the taskList to the listbox
                {
                    UpdateGUI();
                }
            }
        }
    }
}
