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
            int result = 0;
            int counter = 0;
            int[] a = new int[4];

            do
            {
                a[counter] = readIntegerFromConsole(); // call the function and store the return value to a
                counter = counter + 1;
            } while (counter < 4);


            Console.WriteLine("Here is your result");
            for (       counter = 0; counter < 4; counter++)
            {
                result = result + a[counter];// result += a
                Console.WriteLine(a[counter] + " + ");
            }
            Console.WriteLine("------");
            Console.WriteLine(result);
            Console.WriteLine("------");

            Console.ReadKey();
        }

        static int readIntegerFromConsole()
        {
            int x;
            Console.WriteLine("Enter a number!");// write the line in the console
            String xyz = Console.ReadLine();// Read the line from console and store it to xyz
           
            Int32.TryParse(xyz, out x); //Convert the string xyz to the integer x
           /* if (x == 0){
                Console.WriteLine("Enter a number instead of a string!");// write the line in the console
                xyz = Console.ReadLine();
                Int32.TryParse(xyz, out x);
            }
            else
            {
                Console.WriteLine("Thank you");
            }
            */
            return x; // return the value x to the caller
        }

        static void printWelcomeMessage()
        {
            Console.WriteLine("This is Shanthi!");
            Console.WriteLine("Welcome to my first program!");
        }
    }
}
