﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomClasses
{
    class Person
    {
        private int points = 0;
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
            incrementPoint();
        }

        private void incrementPoint()
        {
            points++;
        }

        public int getPoints()
        {
            return points;
        }
    }
}