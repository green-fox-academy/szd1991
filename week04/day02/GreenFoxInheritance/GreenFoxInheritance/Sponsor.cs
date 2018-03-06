using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            hiredStudents = 0;
        }

        public Sponsor() : base()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} years old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
    }
}
