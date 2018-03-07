using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male", "BME");

            Student johnDeuce = (Student)john.Clone();

            john.Introduce();
            johnDeuce.Introduce();

            Console.ReadLine();
        }
    }
}
