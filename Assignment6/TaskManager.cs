using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{/// <summary>
/// Class containing a list of tasks and methods for 
/// handling tasks
/// </summary>
    class TaskManager
    {
        private List<Task> taskList;
        /// <summary>
        /// Constructor for the class, creates a taskList 
        /// when called.
        /// </summary>
        public TaskManager()
        {
            taskList = new List<Task>();
        }
        /// <summary>
        /// Adds a task to the end of taskList, if that task is not null
        /// </summary>
        /// <param name="task">The task to be added if not null</param>
        /// <returns>true if added successfully, false if not</returns>
        public bool AddTask(Task task)
        {
            bool ok = true;
            if (task != null)
            {
                taskList.Add(task);
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        /// <summary>
        /// This method prepares an array of strings containing
        /// information about the tasks in taskList
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] GetInfoStrings()
        {
            //creates a local array with as many elements as there are tasks in taskList
            string[] infoStrings = new string[taskList.Count];
            //loops though the array and adds information from the task at i
            for(int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;
        }
        /// <summary>
        /// Method used to makes sure that the index passes 
        /// to the method is valid for use with the List<T>
        /// </summary>
        /// <returns>true if valid, false if not</returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;
            //check to see if index is larger than 0 and smaller than number of tasks in taskList
            if(index >= 0 && index < taskList.Count)
            {
                ok = true;//valid index
            }
            return ok;
        }
        /// <summary>
        /// This method is used to change a task in taskList by replacing
        /// the object at index with the object passes in param "task" 
        /// Index is passed using CheckIndex() method
        /// </summary>
        /// <param name="task">the Task object that is to go into list</param>
        /// <param name="index">index where the change will take place</param>
        public void ChangeTask(Task task, int index)
        {
            //creates a new copy of the task sent as argument at index, old
            //object will be dropped.
            taskList[index] = new Task(task);
        }
        /// <summary>
        /// This method is used to delete/remove an item from the list, using
        /// index validated by the CheckIndex() method.
        /// </summary>
        /// <param name="index">index to remove at</param>
        public void DeleteTask(int index)
        {
            //removes item at specified index
            taskList.RemoveAt(index);
        }
        /// <summary>
        /// This method is used to get the task at specified index
        /// </summary>
        /// <param name="index">index to get task from</param>
        /// <returns>the Task object at specified index</returns>
        public Task GetTask(int index)
        {
            //returns Task object
            return taskList[index];
        }
        /// <summary>
        /// This method will read data from a file with path "fileName"
        /// sending the taskList as reference. Any previously saved
        /// tasks in a taskList will be added, any current tasks in taskList will be 
        /// removed.
        /// </summary>
        /// <param name="fileName">taskList to read data to</param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            //calls method for reading file and returns the bool true if success, false if not
            return fileManager.ReadTaskListFromFile(taskList, fileName);
        }
        /// <summary>
        /// This method will save the current taskList to a file located
        /// at path "fileName
        /// </summary>
        /// <param name="fileName">path of file to save taskList to</param>
        /// <returns></returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            //calls method for writing to file and returns the bool true if success, false if not
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }

    }
}
