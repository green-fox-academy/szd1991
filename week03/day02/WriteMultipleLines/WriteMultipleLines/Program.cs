// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should be a string, that describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
// The function should not raise any error if it could not write the file.

using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        public static void WriteLines(string file, string word, int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                File.WriteAllLines(file, word);
            }
        }

        public static void Main(string[] args)
        {
            string blueberries = @".\Blueberries.txt";
            string mysteriousFile = @".\IsThereEvenAFileLikeThis.txt";
            string wordToWrite = "Blueberry";
            int howManyLines = 5;

            WriteLines(blueberries, wordToWrite, howManyLines);
            WriteLines(mysteriousFile, wordToWrite, howManyLines);

            string[] content = File.ReadAllLines(blueberries);

            foreach (var line in content)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}