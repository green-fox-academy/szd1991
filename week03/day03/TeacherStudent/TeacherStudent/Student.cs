using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Student
    {
        private string Name;
        private int WillingnessToLearn;
        private int Knowledge;

        public Student(string Name, int WillingnessToLearn, int Knowledge = 1)
        {
            this.Name = Name;
            this.WillingnessToLearn = WillingnessToLearn;
            this.Knowledge = Knowledge;
        }

        public void Question(Teacher teacher)
        {
            for (int i = 0; i < (WillingnessToLearn + teacher.GetExperienceInYears()) / 2; i++)
            {
                teacher.Answer();
                Knowledge++;
            }
        }

        public void Learn()
        {
            Knowledge++;
        }

        public int GetKnowledge()
        {
            return this.Knowledge;
        }

        public int GetWillingnessToLearn()
        {
            return this.WillingnessToLearn;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
