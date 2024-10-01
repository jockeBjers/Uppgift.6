using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift._6
{
    internal class LogicHandler
    {

        private List<string> names = new List<string> { "Anna", "John", "Alice", "Bob" };
        public void PrintSortedList()
        {
            names.Sort();
            Console.WriteLine("\nSorted list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void SearchName(string searchName)
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

        public void AddName(string name)
        {
            names.Add(name);
            Console.WriteLine($"{name} has been added to the list.");
        }

        public void RemoveName(string name)
        {
            if (names.Remove(name))
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
