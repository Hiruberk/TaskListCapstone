using System;
using System.Collections.Generic;
using System.Text;

namespace Task_List_Capstone
{
    
    class TaskList
    {
        public List<ToDo> ToDos { get; set; }//Stores all the ToDo objects in a list called ToDos
        public ToDo CurrentTask { get; set; }//Will be used for extended Exercises if I get around to them.


        public TaskList()//Constructor
        {
            ToDos = new List<ToDo>();
        }

        /// <summary>
        /// Asks user for the Team member, desciption of task, and the due date.
        /// Will add this task to the end of the list.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        public void CreateTask(string member, string description, string date)
        {
            ToDo tazk = new ToDo();

            tazk.Member = member;
            tazk.Description = description;
            tazk.Date = date;

            ToDos.Add(tazk);

        }

        /// <summary>
        /// Prints out all the tasks.
        /// </summary>
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

        /// <summary>
        /// Asks for a task # then displays task and confirms user decision to delete this task.
        /// </summary>
        public void RemoveTask()
        {
            Console.Write("Which task # would you like to remove? ");
            int option = ValidCheck(Console.ReadLine(), 0, (ToDos.Count));

            int index = option - 1;

            Console.WriteLine("Current Task is as follows:\n");
            Console.WriteLine($"Task#{option}");
            Console.WriteLine($"Team Member: {ToDos[index].Member}");
            Console.WriteLine($"Date: {ToDos[index].Date}");
            Console.WriteLine($"Status: {ToDos[index].Status}");
            Console.WriteLine($"Description: {ToDos[index].Description}\n");

            Console.WriteLine();

            while (true)//A loop to insure user gives y/yes or n/no to mark task complete
            {
                Console.WriteLine("Are you sure you want to delete this task?");
                string userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "y" || userInput == "yes")
                {
                    ToDos.RemoveAt(index);
                    break;
                }
                else if (userInput == "n" || userInput == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no.\n");
                }
            }
        }

        /// <summary>
        /// Asks for a task # then displays task and confirms user decision to mark this task complete.
        /// </summary>
        public void MarkTask()
        {
            Console.Write("Which task # would you like to mark complete? ");
            int option = ValidCheck(Console.ReadLine(), 0, (ToDos.Count));

            int index = option - 1;

            Console.WriteLine("Current Task is as follows:\n");
            Console.WriteLine($"Task#{option}");
            Console.WriteLine($"Team Member: {ToDos[index].Member}");
            Console.WriteLine($"Date: {ToDos[index].Date}");
            Console.WriteLine($"Status: {ToDos[index].Status}");
            Console.WriteLine($"Description: {ToDos[index].Description}\n");

            Console.WriteLine();

            while (true)//A loop to insure user gives y/yes or n/no to mark task complete
            {
                Console.Write("Are you sure you want to complete this task? ");
                string userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "y" || userInput == "yes")
                {
                    ToDos[index].MarkComplete();
                    break;
                }
                else if (userInput == "n" || userInput == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no.\n");
                }
            }
        }




        /// <summary>
        /// Checks that that the user enters a valid entry that will not throw an error.
        /// Enter a string to convert to int from Console.ReadLine() and a min and max inclusive range.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Returns a valid integer that is inbetween the given min and max range.</returns>
        public static int ValidCheck(string input, int min, int max)
        {
            int integer;
            while (true)
            {
                if (Int32.TryParse(input, out integer))//Checks if it can be converted to a number
                {
                    if (integer >= min && integer <= max)//Checks that it is within the given range
                    {
                        return integer;// returns a valid integer
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number that is on the list!\n");//requires them to keep trying until they give a valid entry
                        input = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Please enter the corresponding number for your category.\n");//requires them to keep trying until they give a valid entry
                    input = Console.ReadLine();
                }
            }
        }
    }
}
