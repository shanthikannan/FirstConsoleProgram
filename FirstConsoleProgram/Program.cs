using System;
using MyCustomClasses;

namespace FirstConsoleProgram
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomClasses.Person shan = new MyCustomClasses.Person();

            MyCustomClasses.Person kannan = new MyCustomClasses.Person("kannan", "loganathan");

            shan.FullName = "Shanthi Kannan";
            Console.WriteLine($"Shanthi's First Name: {shan.firstName}");
            Console.WriteLine($"Shanthi's Last Name: {shan.lastName}");
            Console.WriteLine($"Shanthi's Full Name: {shan.FullName}");

            kannan.FullName = "Kamachi Sundaram";
            Console.WriteLine($"Kannan's First Name: {kannan.firstName}");
            Console.WriteLine($"Kannan's Last Name: {kannan.lastName}");
            Console.WriteLine($"Kannan's Full Name: {kannan.FullName}");

            String xyz;
            do
            {
                xyz = Console.ReadLine();
                if (xyz == "ABC")
                {
                    kannan.addPoint();
                }
                else if (xyz == "XYZ")
                {
                    shan.addPoint();
                }
            } while (xyz != "z");

            Console.WriteLine("THe Winner is");
            if (kannan.getPoints() > shan.getPoints())
            {
                Console.WriteLine("KANNAN !!!");
            }else
            {
                Console.WriteLine("SHAN !!!");
            }
        }  
    }
}
