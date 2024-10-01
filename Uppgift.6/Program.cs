using System.Diagnostics;

namespace Uppgift._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface.RunProgram(); 
            //Separated the program into two classes of which one handles the user input, and one handles the magic behind.
            // With things separated into smaller classes and methods, we would be able to scale this program but still maintain the readability and flexibilty.
        }

    }
}
