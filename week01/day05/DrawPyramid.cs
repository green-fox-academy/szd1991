using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("Please enter a number. I will draw a cool asterisk pyramid whit that many lines then! ");
            int pyramidLines = int.Parse(Console.ReadLine());
            Console.Write("\n");

            int currentLine, columnSpace, columnAsterisk;

            for (currentLine = 1; currentLine < pyramidLines; currentLine++)
            {
                for (columnSpace = pyramidLines - currentLine; columnSpace >1; columnSpace--)
                {
                    Console.Write(" ");
                }
                for (columnAsterisk = 1; columnAsterisk <= currentLine * 2 - 1; columnAsterisk++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}