// Given a non-negative int n, return the sum of its digits recursively (no loops). 
// Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
// divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World! Please enter a number I should sum the digits of: ");
            int numberToSumDigitsOf = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(numberToSumDigitsOf));

            Console.ReadLine();
        }

        public static int SumDigits(int n)
        {
        }
    }
}
