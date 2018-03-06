using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Mentor : Person
    {
        string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor() : base()
        {
            level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} {level} mentor.");
        }
    }
}
