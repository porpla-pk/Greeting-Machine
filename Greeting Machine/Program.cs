using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for User's name
            Console.WriteLine("Hello! What's your name?");

            // Capture User's Name
            string name  = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Nice to meet you " + name + ",how are you doing ?");

            // Stop the program
            Console.ReadKey();

        }
    }
}
