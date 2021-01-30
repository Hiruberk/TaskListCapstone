using System;
using System.Collections.Generic;
using System.Text;

namespace Task_List_Capstone
{
    
    class TaskList
    {
        public List<ToDo> ToDos { get; set; }
        public ToDo CurrentTask { get; set; }


        public TaskList()
        {
            ToDos = new List<ToDo>();
        }

        public void CreateTask(string member, string description, string date)
        {
            ToDo tazk = new ToDo();

            tazk.Member = member;
            tazk.Description = description;
            tazk.Date = date;

            ToDos.Add(tazk);

        }

        public void ListTask()
        {
            int count = 1;
            foreach (ToDo L in ToDos)
            {
                Console.WriteLine($"Task#{count}");
                Console.WriteLine($"Team Member: {L.Member}");
                Console.WriteLine($"Date: {L.Date}");
                Console.WriteLine($"Status: {L.Status}");
                Console.WriteLine($"Description: {L.Description}");
                Console.WriteLine("*********************************************************");
                count++;
            }
        }


    }
}
