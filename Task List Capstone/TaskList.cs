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

        public void RemoveTask()
        {
            Console.Write("Which task # would you like to remove? ");
            int option = ValidCheck(Console.ReadLine(), 0, (ToDos.Count));

            int index = option - 1;

            Console.WriteLine("Current Task is as follows:");
            Console.WriteLine($"Task#{option}");
            Console.WriteLine($"Team Member: {ToDos[index].Member}");
            Console.WriteLine($"Date: {ToDos[index].Date}");
            Console.WriteLine($"Status: {ToDos[index].Status}");
            Console.WriteLine($"Description: {ToDos[index].Description}");

            Console.WriteLine();

            while (true)
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
                    throw new Exception("Please enter yes or no.");
                }
            }
        }


        public void MarkTask()
        {
            Console.Write("Which task # would you like to mark complete? ");
            int option = ValidCheck(Console.ReadLine(), 0, (ToDos.Count));

            int index = option - 1;

            Console.WriteLine("Current Task is as follows:");
            Console.WriteLine($"Task#{option}");
            Console.WriteLine($"Team Member: {ToDos[index].Member}");
            Console.WriteLine($"Date: {ToDos[index].Date}");
            Console.WriteLine($"Status: {ToDos[index].Status}");
            Console.WriteLine($"Description: {ToDos[index].Description}");

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Are you sure you want to complete this task?");
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
                    throw new Exception("Please enter yes or no.");
                }
            }
        }





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
