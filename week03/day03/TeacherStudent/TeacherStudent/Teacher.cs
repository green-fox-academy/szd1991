using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Teacher
    {
        private string Name;
        private int ExperienceInYears;
        private int Wisdom;

        public Teacher(string Name, int ExperienceInYears, int Wisdom = 1)
        {
            this.Name = Name;
            this.ExperienceInYears = ExperienceInYears;
            this.Wisdom = Wisdom;
        }

        public void Teach(Student student)
        {
            for (int i = 0; i < (ExperienceInYears + student.GetWillingnessToLearn()) / 2; i++)
            {
                student.Learn();
                Wisdom++;
            }
        }

        public void Answer()
        {
            Wisdom++;
        }

        public int GetWisdom()
        {
            return this.Wisdom;
        }

        public int GetExperienceInYears()
        {
            return this.ExperienceInYears;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
