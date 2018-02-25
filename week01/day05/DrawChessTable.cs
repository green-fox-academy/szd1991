using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            Console.WriteLine("Hi! It's chess time!");

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("% % % % ");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(" % % % %");
                }
            }

            Console.ReadLine();
        }
    }
}