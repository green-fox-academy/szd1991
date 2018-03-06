using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public int SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
            return skippedDays;
        }
    }
}
