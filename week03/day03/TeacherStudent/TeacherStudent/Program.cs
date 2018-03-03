using System;
using System.Collections.Generic;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mrFreeman = new Teacher("Morgan Freeman", 10);
            Teacher mrBravo = new Teacher("Johnny Bravo", 0);

            Student abel = new Student("Fluimucid Ábel", 10);
            Student moriczka = new Student("Móriczka", 0);

            var teachers = new List<Teacher>();
            var students = new List<Student>();

            teachers.Add(mrFreeman);
            teachers.Add(mrBravo);

            students.Add(abel);
            students.Add(moriczka);

            for (int t = 0; t < teachers.Count; t++)
            {
                for (int s = 0; s < students.Count; s++)
                {
                    teachers[t].Teach(students[s]);
                    Console.WriteLine($"After {teachers[t].GetName()} teaching {students[s].GetName()}, {teachers[t].GetName()} have {teachers[t].GetWisdom()} points of wisdom, and {students[s].GetName()} have {students[s].GetKnowledge()} points of knowledge.\n");
                    students[s].Question(teachers[t]);
                    Console.WriteLine($"After {teachers[t].GetName()} asking questions from {students[s].GetName()}, {teachers[t].GetName()} have {teachers[t].GetWisdom()} points of wisdom, and {students[s].GetName()} have {students[s].GetKnowledge()} points of knowledge.\n");
                }
            }

            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher name: {teacher.GetName()}");
                Console.WriteLine($"Teacher wisdom: {teacher.GetWisdom()}\n");
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Student name: {student.GetName()}");
                Console.WriteLine($"Student knowledge: {student.GetKnowledge()}\n");
            }

            Console.ReadLine();
        }
    }
}
