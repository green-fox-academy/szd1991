using System;
using System.Linq;

namespace FrequencyOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Console.WriteLine("Original array:");

            foreach (var number in n)
            {
                Console.Write(number + ", ");
            }

            var numCountQuery = from m in n
                                group m by m into mCount
                                select mCount;

            Console.WriteLine("\n\nCounts of numbers with query:");
            foreach (var numCount in numCountQuery)
            {
                Console.WriteLine($"Number: {numCount.Key}, Count: {numCount.Count()}");
            }

            var numCountMethod = n.GroupBy(m => m).Select(m => m.Count());

            Console.WriteLine("\n\nCounts of numbers with method:");
            foreach (var numCount in numCountMethod)
            {
                Console.WriteLine($"Number: , Count: {numCount}");
            }

            Console.ReadLine();
        }
    }
}
