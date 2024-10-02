using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift._6
{
    internal class UserInterface
    {
        public static void RunProgram()
        {
            while (true) // Simple while that prints the menu again if input is wrong
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Print Sorted List");
                Console.WriteLine("2. Search for a Name");
                Console.WriteLine("3. Add a Name");
                Console.WriteLine("4. Remove a Name");
                Console.WriteLine("5. Exit");

                // Try parsing the input, handling errors.
                if (int.TryParse(Console.ReadLine(), out int input)) 
                {
                    switch (input)
                    {
                        case 1:
                            LogicHandler.PrintSortedList();
                            break;
                        case 2:
                            SearchName();
                            break;
                        case 3:
                            AddName();
                            break;
                        case 4:
                            RemoveName();
                            break;
                        case 5:
                            Console.WriteLine("Exiting program...");
                            return;
                        default:
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 5."); // if incorrect integer
                            break;
                    }
                }
                else
                {
                    // If input is not an integer 
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
        public static void SearchName()
        {
            Console.WriteLine("Enter a name to search for:");
            string name = Console.ReadLine();
            LogicHandler.SearchName(name);
        }

        public static void AddName()
        {
            Console.WriteLine("\nEnter a name to add:");
            string name = Console.ReadLine();
            LogicHandler.AddName(name);
        }

        public static void RemoveName()
        {
            Console.WriteLine("\nEnter a name to remove:");
            string name = Console.ReadLine();
            LogicHandler.RemoveName(name);
        }
    }
}
