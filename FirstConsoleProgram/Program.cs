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
            Person shan = new Person();
            shan.firstName = "Shathi";
            shan.lastName = "K";
            shan.age = 37;
            shan.sex = Sex.FEMALE;

            Person kannan = new Person();
            kannan.firstName = "Kannan";
            kannan.lastName = "l";
            kannan.age = 39;
            kannan.sex = Sex.MALE;

            Person deekshu = new Person();

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
