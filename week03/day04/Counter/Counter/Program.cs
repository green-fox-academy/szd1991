using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World! Please enter number from wich countdown starts: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Countdown(number));

            Console.ReadLine();
        }

        public static int Countdown (int n)
        {
            if (n == 0)
            {
                return n;
            }
            else
            {
                return Countdown(n - 1);
            }
        }
    }
}
