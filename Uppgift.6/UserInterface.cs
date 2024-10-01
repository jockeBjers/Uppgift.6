using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift._6
{
    internal class UserInterface
    {
        private LogicHandler logicManager;

        public UserInterface()
        {
            logicManager = new LogicHandler();
        }

        public void RunProgram()
        {
           
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Print Original List");
                Console.WriteLine("2. Print Sorted List");
                Console.WriteLine("3. Search for a Name");
                Console.WriteLine("4. Add a Name");
                Console.WriteLine("5. Remove a Name");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        logicManager.PrintSortedList();
                        break;
                    case "2":
                        SearchName();
                        break;
                    case "3":
                        AddName();
                        break;
                    case "4":
                        RemoveName();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
        public static void SearchName()
        {

        }
        public static void AddName()
        {

        }

        public static void RemoveName()
        {

        }
    }
}
