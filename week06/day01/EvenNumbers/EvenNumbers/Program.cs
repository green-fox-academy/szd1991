using System;
using System.Linq;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to get the even numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbersMethod = n.Where(x => x % 2 == 0).Select(x => x);

            Console.WriteLine("Original array:");
            foreach (var num in n)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine("\nEven numbers array with method syntax:");
            foreach (var evenNumber in evenNumbersMethod)
            {
                Console.Write(evenNumber + ", ");
            }

            var evenNumbersQuery = from number in n
                                   where number % 2 == 0
                                   select number;

            Console.WriteLine("\nEven numbers array with query syntax:");
            foreach (var evenNumber in evenNumbersQuery)
            {
                Console.Write(evenNumber + ", ");
            }

            Console.ReadLine();
        }
    }
}
