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
                Console.Write("Select an option: ");
                string userInput = Console.ReadLine();

                //These if statements go through the menu and call out a method from the TaskList class depending on their option.
                if(userInput == "1")
                {
                    taskList.ListTask();
                }
                else if(userInput == "2")
                {
                    Console.Write("Who's task is this? ");
                    string member = Console.ReadLine();

                    Console.Write("What is the task? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the due date (dd/mm/yyyy)? ");
                    string date = Console.ReadLine();

                    taskList.CreateTask(member, description, date);
                }
                else if (userInput == "3")
                {
                    taskList.RemoveTask();
                }
                else if(userInput == "4")
                {
                    taskList.MarkTask();
                }
                else if(userInput == "5")
                {
                    Console.WriteLine("Thank you for using TaskOrganizer5000, please like, comment & subscribe below.");
                    break;
                }
                else//If they dont choose anything on the menu asks for them to try again.
                {
                    Console.WriteLine("Please enter one of the options listed:");
                }
            }
        }
        /// <summary>
        /// Displays the main menu
        /// </summary>
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
