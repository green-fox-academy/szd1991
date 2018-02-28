using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie royal = new Sharpie("navy", 1f);
            Sharpie gold = new Sharpie("gold", 2f);

            /* draw Swedish flag
             
            rrr gg rrrrr 
            rrr gg rrrrr
            gggggggggggg
            rrr gg rrrrr
            rrr gg rrrrr
             
            */

            for (int i = 1; i <= 32; i++)
            {
                royal.Use();
            }

            for (int i = 1; i <= 10; i++)
            {
                gold.Use();
            }

            Console.WriteLine($"After drawing the Swedish flag, we have {royal.GetInkStatus()}% of our royal blue sharpie, and {gold.GetInkStatus()}% of our golden yellow sharpie left.");

            Console.ReadLine();
        }
    }
}
