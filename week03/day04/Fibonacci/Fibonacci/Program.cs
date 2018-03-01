// The fibonacci sequence is a famous bit of mathematics, and it happens to
// have a recursive definition. The first two values in the sequence are
// 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the
// previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21
// and so on. Define a recursive fibonacci(n) method that returns the nth
// fibonacci number, with n=0 representing the start of the sequence.

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter number: ");
            int userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine($"The #{userChoice} element of the fiboacci sequence is {FibonacciNthElement(userChoice)}.");

            Console.ReadLine();
        }

        static public int FibonacciNthElement(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciNthElement(n - 1) + FibonacciNthElement(n - 2);
            }
        }
    }
}
