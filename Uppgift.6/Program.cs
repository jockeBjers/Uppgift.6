using System.Diagnostics;

namespace Uppgift._6
{
    internal class Program
    {
        private static List<string> names = new List<string> { "Anna", "John", "Alice", "Bob" }; // Put list outside of main for easier access.
        static void Main(string[] args)
        {
            RunProgram();
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

            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
            Console.ReadKey();
        }


    }

}
