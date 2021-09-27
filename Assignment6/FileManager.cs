using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{/// <summary>
/// This class handles all files in the application and has methods for 
/// saving to and reading from files.
/// </summary>
    class FileManager
    {
        //token to mark files as "correct version"
        private const string fileVersionToken = "ToDoRe_21";
        //Version number to ensure compability
        //may as well be string as no number comparison needed (only one version exists)
        private const string fileVersionNr = "1.0";
        /// <summary>
        /// this method is used to save a taskList to file
        /// </summary>
        /// <param name="taskList">taskList to be saved</param>
        /// <param name="fileName">path of the file</param>
        /// <returns></returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;//writer must be declared here, to be accessed by try, catch and finally
            try
            {
                //write information about file version and taskList
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(taskList.Count);

                //save the items in the list, one field at a time
                //the DateTime is split up so that year and month etc can be read seperatly
                for(int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].Date.Year);
                    writer.WriteLine(taskList[i].Date.Month);
                    writer.WriteLine(taskList[i].Date.Day);
                    writer.WriteLine(taskList[i].Date.Hour);
                    writer.WriteLine(taskList[i].Date.Minute);
                    writer.WriteLine(taskList[i].Date.Second);
                }
            }
            catch
            {
                //if any error, jump to this line
                ok = false;
            }
            finally//always executed
            {
                //close the writer if opened
                if(writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// this method is used to read taskList from file and 
        /// add tasks to list to be displayed in the ToDo Reminder
        /// </summary>
        /// <param name="taskList">list where the tasks will be added</param>
        /// <param name="fileName">path of the file to read</param>
        /// <returns></returns>
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;//same as writer

            try
            {
                //clear contents of current taskList if one exists
                if (taskList != null)
                {
                    taskList.Clear();
                }
                else//if taskList as null (not created)
                {
                    taskList = new List<Task>();
                }
                reader = new StreamReader(fileName);
                //checking to see if the file is correct
                string versionTest = reader.ReadLine();
                //check version number
                string versionNr = reader.ReadLine();

                if(versionTest == fileVersionToken && versionNr == fileVersionNr)
                {
                    //read number of tasks saved to taskList
                    int count = int.Parse(reader.ReadLine());
                    //create task, read values and add to list
                    for(int i = 0; i < count; i++)
                    {
                        //create a new task
                        Task task = new Task();
                        //read description and parse PriorityType
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        //read and parse lines for date information
                        int year = int.Parse(reader.ReadLine());
                        int month = int.Parse(reader.ReadLine());
                        int day = int.Parse(reader.ReadLine());
                        int hour = int.Parse(reader.ReadLine());
                        int minute = int.Parse(reader.ReadLine());
                        int second = int.Parse(reader.ReadLine());
                        //creates a DateTime and stores it in the date field of task
                        task.Date = new DateTime(year, month, day, hour, minute, second);
                        //adds task to back of list
                        taskList.Add(task);
                    }
                }
                else//if versionnumber not compatible
                {
                    ok = false;
                }
            }
            catch//if anything goes wrong
            {
                ok = false;
            }
            finally//always executed
            {
                if(reader != null)//if reader not null, close reader
                {
                    reader.Close();
                }
            }
            return ok;
        }
    }
}
