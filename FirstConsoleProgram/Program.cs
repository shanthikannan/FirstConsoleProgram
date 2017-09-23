using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            printWelcomeMessage();
            int a = readIntegerFromConsole();
            int b = readIntegerFromConsole();
            int c = readIntegerFromConsole();
            int d = readIntegerFromConsole();
          
            Console.WriteLine("The result is ");
            Console.WriteLine(a + b + c + d);
            Console.ReadKey();
        }

        static int readIntegerFromConsole()
        {
            int x;
            Console.WriteLine("Enter a number!");
            String xyz = Console.ReadLine();
            Int32.TryParse(xyz, out x); //Convert the string xyz to the integer x
            return x;
        }

        static void printWelcomeMessage()
        {
            Console.WriteLine("This is Shanthi!");
            Console.WriteLine("Welcome to my first program!");
        }
    }
}
