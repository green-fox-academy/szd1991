using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Please enter a number: ");
            int rectangleHeight = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rectangleHeight; i++)
            {
                if (i == 1 || i == rectangleHeight)
                {
                    Console.WriteLine("%%%%%");
                }
                else
                {
                    Console.WriteLine("%   %");
                }
            }

            Console.ReadLine();
        }
    }
}