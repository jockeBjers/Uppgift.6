using System.Diagnostics;

namespace Uppgift._6
{
    internal class Program
    {
        private static List<string> names = new List<string> { "Anna", "John", "Alice", "Bob" };
        static void Main(string[] args)
        {

            Console.WriteLine("Original list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort();  // Sort the names alphabetically
            Console.WriteLine("\nSorted list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

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

        public static void PrintOriginalList()
        {

        }
        public static void PrintSortedList()
        {

        }
        public static void SearchName()
        {

        }


    }

}
