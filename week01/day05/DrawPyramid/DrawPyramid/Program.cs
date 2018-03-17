using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number. I will draw a cool asterisk pyramid whit that many lines then! ");
            int pyramidLines = int.Parse(Console.ReadLine());
            Console.Write("\n");

            int currentLine, columnSpace, columnAsterisk;

            for (currentLine = 1; currentLine <= pyramidLines; currentLine++)
            {
                for (columnSpace = pyramidLines - currentLine + 1; columnSpace > 1; columnSpace--)
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
