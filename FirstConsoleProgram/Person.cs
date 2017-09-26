using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProgram
{
    enum Sex { MALE, FEMALE};
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Sex sex;
        private int points = 0;

        public void addPoint()
        {
            points++;
        }

        public int getPoints()
        {
            return points;
        }
    }
}
