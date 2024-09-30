using System.Diagnostics;

namespace Uppgift._6
{
    internal class Program
    {
        private static List<string> names = new List<string> { "Anna", "John", "Alice", "Bob" }; // Put list outside of main for easier access.

        static void Main(string[] args)
        {
            RunProgram();
            //The project I built for the assignment last week show how you can further add functionality and implement things such as 
            // print list, add, search and remove from user input 
            // And how to handle input validation and error handling. 
            // But for this program. This should be sufficient.
        }

        public static void RunProgram()  // Starts the program to keep the main clear.
        {
            PrintOriginalList();
            PrintSortedList();
            SearchName();
        }

        public static void PrintOriginalList()
        {
            Console.WriteLine("Original list:");
            foreach (var name in names) // loops through the original list and prints out the names
            {
                Console.WriteLine(name);
            }
        }

        public static void PrintSortedList()
        {
            names.Sort();  // Sort the names in alphabetical order
            Console.WriteLine("\nSorted list:");
            foreach (var name in names) // loops through the sorted names and prints them out.
            {
                Console.WriteLine(name);
            }
        }

        public static void SearchName()
        {
            // I am not using a try catch since thanks to the while loop, and the .Contains, null and wrong input is handled.
            // I am also not bothered with whitespace in this context as empty input is handled too.
            while (true) // while loop to ensure the user can leave the method when they want through input.
            {
                Console.WriteLine("\nEnter a name to search (or type \"stop\" to quit):");
                string searchName = Console.ReadLine();

                if (searchName?.ToLower() == "stop") // Turn the user input into lower case to match with stop
                {
                    break; // Exit the while loop
                }
                if (names.Contains(searchName))
                {
                    Console.WriteLine($"{searchName} is in the list."); // If name is found
                }
                else
                {
                    Console.WriteLine($"{searchName} is not in the list."); // If name is not found
                }
            } // end while loop
            Console.WriteLine("Exiting Method to search for name, Press any key to exit."); // Exit message
            Console.ReadKey();
        }
    }
}
