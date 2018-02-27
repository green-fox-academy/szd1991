// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.

using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        public static int CountLinesInFile(string path)
        {
            try
            {
                string[] contentOfFile = File.ReadAllLines(path);
                return contentOfFile.Length;
            }
            catch
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            string mysteryFile = @".\IsThereEvenAFileLikeThis.txt";
            string favouriteBasketballPlayers = @".\Players.txt";

            Console.WriteLine(CountLinesInFile(mysteryFile));
            Console.WriteLine(CountLinesInFile(favouriteBasketballPlayers));

            Console.ReadLine();
        }
    }
}