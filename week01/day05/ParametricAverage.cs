using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.Write("Hello Friend! Please enter an integer number: ");
            int thisManyTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("Now I ask you to enter as many integer numbers as you just thought of before!");

            int sum = 0;

            for (int i = 1; i <= thisManyTimes; i++)
            {
                Console.Write("So your integer #" + i + " is: ");
                int numbersToWorkWith = int.Parse(Console.ReadLine());

                sum += numbersToWorkWith;
            }

            double average = sum / thisManyTimes;

            Console.WriteLine("I calculated some data of the numbers you just put in. Here you go:");
            Console.Write("Sum: " + sum + ", Average: " + average);

            Console.ReadLine();
        }
    }
}