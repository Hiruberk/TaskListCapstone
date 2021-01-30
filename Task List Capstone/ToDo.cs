using System;
using System.Collections.Generic;
using System.Text;

namespace Task_List_Capstone
{
    class ToDo
    {

        public string Member { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; }

        public ToDo()
        {

        }

        public ToDo(string member, string description, string date)
        {
            this.Member = member;
            this.Description = description;
            this.Date = date;
            Status = false;
        }

        public void MarkComplete()
        {
            Status = true;
        }
    }
}
