using System;
using System.Linq;

namespace SquareOfPositives
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squareOfPositivesMethod = n.Where(m => m > 0).Select(m => m * m);

            foreach (var square in squareOfPositivesMethod)
            {
                Console.WriteLine(square);
            }

            var squareOfPositivesQuery = from m in n
                                         where m >= 0
                                         orderby m
                                         select new
                                         {
                                             number = m,
                                             square = m * m
                                         };

            foreach (var square in squareOfPositivesQuery)
            {
                Console.WriteLine(square);
            }

            Console.ReadLine();
        }
    }
}
