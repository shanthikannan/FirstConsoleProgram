using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProgram
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int age { get; set; }
        private int points = 0;

        public Person()
        {
            firstName = "FN";
            lastName = "LN";

            Console.WriteLine($"{firstName} {lastName} is Created");
        }

        public Person(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
            Console.WriteLine($"{fn} {ln} is Created");
        }

        public void addPoint()
        {
            points++;
        }

        public int getPoints()
        {
            return points;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person shan = new Person();
            Person kannan = new Person("kannan", "loganathan");

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
