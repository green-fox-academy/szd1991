// Create a recursive function called `refactorio`
// that returns it's input's factorial

using System;

namespace Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World! Please enter number and I'll give the factorial value of that: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {Refactorio(userNumber)}");

            Console.ReadLine();
        }

        public static int Refactorio(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Refactorio(n - 1);
            }
        }
    }
}
