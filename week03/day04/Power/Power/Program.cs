// Given base and n that are both 1 or more, compute recursively (no loops)
// the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter numbers!");
            Console.Write("Base number: ");
            int userBase = int.Parse(Console.ReadLine());
            Console.Write("Exponent number: ");
            int userExpo = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + Power(userBase, userExpo));
            Console.ReadLine();
        }

        public static int Power(int baseNumber, int exponentN)
        {
            if (exponentN == 0)
            {
                return 1;
            }
            else
            {
                return baseNumber * Power(baseNumber, exponentN - 1);
            }
        }
    }
}
