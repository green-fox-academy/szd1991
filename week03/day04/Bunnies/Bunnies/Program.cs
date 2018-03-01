// We have a number of bunnies and each bunny has two big floppy ears.
// We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter how many bunnies should we have?");
            int bunnies = int.Parse(Console.ReadLine());

            Console.WriteLine($"That's exactly {BunnyEars(bunnies)} bunny ears.");

            Console.ReadLine();
        }

        public static int BunnyEars(int bun)
        {
            if (bun == 1)
            {
                return bun = 2;
            }
            else
            {
                return 2 + BunnyEars(bun - 1);
            }
        }
    }
}
