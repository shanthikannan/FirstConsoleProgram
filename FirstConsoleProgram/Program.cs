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
        public int age;
        private int points = 0;

        public Person()
        {
            firstName = "FIRST NAME";
            Console.WriteLine($"{firstName} is Created");
        }

        public Person(string name)
        {
            firstName = name;
            Console.WriteLine($"{name} is Created");
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
            Person kannan = new Person("kannan");
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
