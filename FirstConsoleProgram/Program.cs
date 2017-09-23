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
            String xyz;
            printWelcomeMessage();

            int a;
            Console.WriteLine("Enter a number!");
            xyz = Console.ReadLine();
            Int32.TryParse(xyz, out a); //Convert the string xyz to the integer a
            
            int b;
            Console.WriteLine("Enter a number!");
            xyz = Console.ReadLine();
            Int32.TryParse(xyz, out b); //Convert the string xyz to the integer b

            int c;
            Console.WriteLine("Enter a number!");
            xyz = Console.ReadLine();
            Int32.TryParse(xyz, out c); //Convert the string xyz to the integer c
            
            int d;
            Console.WriteLine("Enter a number!");
            xyz = Console.ReadLine();
            Int32.TryParse(xyz, out d); //Convert the string xyz to the integer d

            Console.WriteLine("The result is ");
            Console.WriteLine(a + b + c + d);
            Console.ReadKey();
        }

        static void printWelcomeMessage()
        {
            Console.WriteLine("This is Shanthi!");
            Console.WriteLine("Welcome to my first program!");
        }
    }
}
