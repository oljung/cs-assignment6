using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    /// <summary>
    /// Class for storing information regarding a task used in a 
    /// To Do list
    /// </summary>
    class Task
    {
        //instance variables
        private DateTime date;
        private string description;
        private PriorityType priority;

        /// <summary>
        /// Default constructor, setting the priority to normal as a default value
        /// </summary>
        public Task()
        {
            priority = PriorityType.Normal;
        }
        /// <summary>
        /// Constructor with one parameter callin constructor with 3 parameters. 
        /// Used to enter a date only for task if no other information is available
        /// </summary>
        /// <param name="taskDate">this parameter save data to the date variable</param>
        public Task(DateTime taskDate):this(taskDate, string.Empty, PriorityType.Normal)
        {

        }
        /// <summary>
        /// Constructor with 3 parameters to be used when all data is available 
        /// upon creating the object. Other constructors calls this one.
        /// </summary>
        /// <param name="taskDate">saves data to the date variable</param>
        /// <param name="description">saves a string to the description variable</param>
        /// <param name="priority">sets the priority enum value</param>
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">object to be copied</param>
        public Task(Task other)
        {
            this.date = other.date;
            this.description = other.description;
            this.priority = other.priority;
        }
        /// <summary>
        /// Proprty connected to the date instance variable. 
        /// Both read and write acces
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        /// <summary>
        /// Property connected to the description varible. 
        /// Both read and write acces, will validate string is not empty before 
        /// assigning value
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                //makes sure string is not empty
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }
        /// <summary>
        /// Property linked to the priority instance variable.
        /// Both read and write acccess.
        /// </summary>
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        /// <summary>
        /// This method is used to return a string representing a 
        /// priority enum with the "_" replaced with " "
        /// </summary>
        /// <returns>string with character replaced</returns>
        public string GetPriorityString()
        {
            //get the name from current enum value
            string output = priority.ToString();
            //replaces character using built in function
            output = output.Replace("_", " ");
            return output;
        }
        /// <summary>
        /// This method returns a string in the form of 
        /// HH:mm to represent when a task is to be performed.
        /// </summary>
        /// <returns>string of time formatted to HH:mm</returns>
        private string GetTimeString()
        {
            //creates a string with HH:mm from the DateTime saved in date
            string output = $"{date.Hour}:{date.Minute}";
            return output;
        }
        /// <summary>
        /// Overrides the ToString to return a formatted string with task information
        /// </summary>
        /// <returns>formatted string with task information</returns>
        public override string ToString()
        {
            //creates an infostring of the current task, containing all useful information
            string output = $"{date.ToLongDateString(),-20}{GetTimeString(),-10}" +
                $"{GetPriorityString(),25}{description,30}";
            return output;
        }
    }
}
