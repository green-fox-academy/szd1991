// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful

using System;
using System.IO;
using System.Linq;

namespace CopyFile
{
    class Program
    {
        public static bool CopyFunction(string fileWithContent, string emptyFile)
        {
            string[] content = File.ReadAllLines(fileWithContent);
            File.WriteAllLines(emptyFile, content);

            return (File.ReadAllLines(fileWithContent).SequenceEqual(File.ReadAllLines(emptyFile)));
        }

        public static void Main(string[] args)
        {
            string dreamTeam = @".\Players.txt";
            string roster = @".\StartingRoster.txt";
            Console.Write(CopyFunction(dreamTeam, roster));

            Console.ReadLine();
        }
    }
}