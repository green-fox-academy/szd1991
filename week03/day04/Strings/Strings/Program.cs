// Given a string, compute recursively a new string where all the 'x' chars have been removed.

using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string xHyppopotamus = "Hyppxxoxpoxtamxxxuxs";

            Console.WriteLine($"A {xHyppopotamus} without letter x's is just a {xRemover(xHyppopotamus)}.");

            Console.ReadLine();
        }

        public static string xRemover(string x)
        {
            if (x.StartsWith("x"))
            {
                return x.Replace("x", "");
            }
            else
            {
                return x[0] + xRemover(x.Substring(1));
            }
        }
    }
}
