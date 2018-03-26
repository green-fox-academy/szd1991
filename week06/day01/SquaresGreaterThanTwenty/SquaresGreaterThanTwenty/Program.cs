using System;
using System.Linq;

namespace SquaresGreaterThanTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            Console.WriteLine("Original array:");

            foreach (var num in n)
            {
                Console.Write(num + ", ");
            }

            var squaresGreaterThanTwentyMethod = n.Where(m => m * m > 20).Select(m => m);

            Console.WriteLine("\n\nNumbers whose squares are greater than 20 with method syntax:");

            foreach (var originalNum in squaresGreaterThanTwentyMethod)
            {
                Console.Write(originalNum + ", ");
            }

            var squaresGreaterThanTwentyQuery = from m in n
                                                where m * m > 20
                                                select m;

            Console.WriteLine("\n\nNumbers whose squares are greater than 20 with query syntax:");

            foreach (var originalNum in squaresGreaterThanTwentyQuery)
            {
                Console.Write(originalNum + ", ");
            }
            
            Console.ReadLine();
        }
    }
}
