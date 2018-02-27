using System;
using System.IO;

namespace GreenFox
{
    class Program
    {
        public static void ResultDeterminator(string filePath)
        {
            string[] endOfGame = File.ReadAllLines(filePath);

            Console.WriteLine(endOfGame.Length);
            /*
            if (endOfGame[0] == endOfGame[1] && endOfGame[1] == endOfGame[2])
            {
                return endOfGame[0];
            }
            else if (endOfGame[3] == endOfGame[4] && endOfGame[4] == endOfGame[5])
            {
                return endOfGame[3];
            }
            else if (endOfGame[6] == endOfGame[7] && endOfGame[7] == endOfGame[8])
            {
                return endOfGame[6];
            }
            else if (endOfGame[0] == endOfGame[3] && endOfGame[3] == endOfGame[6])
            {
                return endOfGame[0];
            }
            else if (endOfGame[1] == endOfGame[4] && endOfGame[4] == endOfGame[7])
            {
                return endOfGame[1];
            }
            else if (endOfGame[2] == endOfGame[5] && endOfGame[5] == endOfGame[8])
            {
                return endOfGame[2];
            }
            else if (endOfGame[0] == endOfGame[4] && endOfGame[4] == endOfGame[8])
            {
                return endOfGame[0];
            }
            else if (endOfGame[2] == endOfGame[4] && endOfGame[4] == endOfGame[6])
            {
                return endOfGame[2];
            }
            else
            {
                return "draw";
            }
            */
        }

        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // open and read it. The file data represents a tic-tac-toe
            // game result. Return 'X'/'O'/'draw' based on which player
            // has winning situation.

            // Console.Write(ResultDeterminator("win-o.txt"));
            // should print O

            // Console.Write(ResultDeterminator("win-x.txt"));
            // should print X

            // Console.Write(ResultDeterminator("draw.txt"));
            // should print draw
            ResultDeterminator("win-o.txt");
            ResultDeterminator("win-x.txt");
            ResultDeterminator("draw.txt");
            Console.ReadLine();
        }
    }
}