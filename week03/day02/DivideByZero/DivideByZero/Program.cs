// Create a function that takes a number
// divides ten with it,
// and prints the result.
// It should print "fail" if the parameter is 0

using System;

namespace Practice
{
    class Program
    {
        public static void DivisorPractice(int a)
        {
            try
            {
                int result = 10 / a;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException divisorPractice)
            {
                Console.WriteLine("fail...");
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public static void Main(string[] args)
        {

            Console.Write("Please enter number you want to divide 10 with: ");
            int divisor = int.Parse(Console.ReadLine());

            DivisorPractice(divisor);
        }
    }
}