using System;
using System.Linq;

namespace AverageOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            Console.WriteLine("Original array:");
            foreach (var num in n)
            {
                Console.Write(num + ", ");
            }

            var averageOfOddsMethod = n.Where(i => i % 2 != 0).Average();

            Console.WriteLine("\n\nAverage of odd numbers with method syntax: " + averageOfOddsMethod);

            Console.ReadLine();
        }
    }
}
