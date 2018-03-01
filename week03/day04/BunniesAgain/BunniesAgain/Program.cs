// We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
// (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
// have 3 ears, because they each have a raised foot. Recursively return the
// number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

using System;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter how many zombie bunnies should we have?");
            int zombieBunnies = int.Parse(Console.ReadLine());

            Console.WriteLine($"That's exactly {ZombieBunnyEars(zombieBunnies)} zombie bunny ears.");

            Console.ReadLine();
        }

        public static int ZombieBunnyEars(int bun)
        {
            if (bun == 1)
            {
                return bun = 2;
            }
            else if (bun % 2 == 0)
            {
                return 3 + ZombieBunnyEars(bun - 1);
            }
            else
            {
                return 2 + ZombieBunnyEars(bun - 1);
            }
        }
    }
}
