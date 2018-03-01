// Write a recursive function that takes one parameter: n and adds numbers from 1 to n.


using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World! Please enter a number from which I should add all the numbers until 1: ");
            int userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAdder(userChoice));

            Console.ReadLine();
        }

        public static int NumberAdder(int n)
        {
            if (n == 1)
            {
                n += 0;
            }
            else
            {
                n += NumberAdder(n - 1);
            }

            return n;
        }
    }
}
