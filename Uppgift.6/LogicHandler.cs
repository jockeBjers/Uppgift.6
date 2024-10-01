using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift._6
{
    internal class LogicHandler
    {

        private static List<string> names = new List<string> { "Anna", "John", "Alice", "Bob" }; //Define list
        public static void PrintSortedList()
        {
            names.Sort(); //Sorting the list
            Console.WriteLine("\nSorted list:");
            foreach (var name in names) //prints out all the names in the list
            {
                Console.WriteLine(name);
            }
        }

        public static void SearchName(string searchName) //Takes the input from the user and check if it exists.
        {
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
        }

        public static void AddName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) // Safety if input is empty.
            {
                Console.WriteLine("Invalid input. Name cannot be empty or just whitespace.");
            }
            else
            {
                names.Add(name); //If safe it is added to the list.
                Console.WriteLine($"{name} has been added to the list.");
            }
        }


        public static void RemoveName(string name)
        {
            if (names.Remove(name)) // If name matches, it is removed
            {
                Console.WriteLine($"{name} has been removed from the list.");
            }
            else
            {
                Console.WriteLine($"{name} could not be found in the list.");
            }
        }
    }
}
