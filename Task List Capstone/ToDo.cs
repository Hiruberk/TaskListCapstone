using System;
using System.Collections.Generic;
using System.Text;

namespace Task_List_Capstone
{
    class ToDo//Object for each individal task with the below set properties
    {

        public string Member { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public ToDo()//Default constructor used to add a new task in the TaskList class
        {

        }

        public ToDo(string member, string description, string date)//Constructor for main program construction
        {
            this.Member = member;
            this.Description = description;
            this.Date = date;
            Status = "Incomplete";
        }

        public void MarkComplete()//Changes status of task to complete when user confirms.
        {
            Status = "Complete";
        }
    }
}
