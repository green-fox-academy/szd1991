using System;
using System.Collections.Generic;
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

            for (int i = 0; i < n.Length; i++)
            {
                if (i == n.Length - 1)
                {
                    Console.Write(n[i]);
                }
                else
                {
                    Console.Write(n[i] + ", ");
                }
            }

            var averageOfOddsMethod = n.Where(i => i % 2 != 0).Average();

            Console.WriteLine("\n\nAverage of odd numbers with method syntax: " + averageOfOddsMethod);

            var averageOfOddsQuery = (from m in n
                                      where m % 2 != 0
                                      select m)
                                      .Average();

            Console.WriteLine("\nAverage of odd numbers with query syntax: " + averageOfOddsQuery);

            Console.ReadLine();
        }
    }
}
