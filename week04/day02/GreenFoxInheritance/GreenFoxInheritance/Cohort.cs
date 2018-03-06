using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxInheritance
{
    class Cohort
    {
        string name;
        List<Student> students;
        List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public List<Student> AddStudent(Student student)
        {
            students.Add(student);
            return students;
        }

        public List<Mentor> AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
            return mentors;
        }

        public void Info()
        {
            Console.WriteLine($"The {name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }
    }
}
