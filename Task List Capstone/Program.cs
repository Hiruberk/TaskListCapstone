using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Task_List_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up some tasks, to save user from doing it           


            TaskList taskList = new TaskList();

            
            taskList.CreateTask("Sally", "Make cold calls.", "02/03/2021");
            taskList.CreateTask("Rick", "Construct the finaical reports.", "02/26/2021");
            taskList.CreateTask("Teddy", "Inspect all machinesare working properly.", "02/08/2021");
            taskList.CreateTask("Sally", "Turn in expense reports.", "02/26/2021");
            taskList.CreateTask("Frank", "Fix that flickering light in the hallway.", "02/03/2021");
            taskList.CreateTask("Rebecca", "Turn in Shop labor hours.", "02/12/2021");
            taskList.CreateTask("Rick", "Fire Andrew for sleeping in the bathroom.", "02/05/2021");

            Console.WriteLine("Welcome to TaskOrganizer5000");

            while (true)
            {
                Menu();
                Console.Write("Select option: ");
                string userInput = Console.ReadLine();


                if(userInput == "1")
                {
                    taskList.ListTask();
                }


                break;












            }


        }









        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1. List task");
            Console.WriteLine("2. Add task");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Mark task complete");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
        }






    }
}
