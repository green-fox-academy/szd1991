// Open a file called "my-file.txt"
// Write your name in it as a single line
// If the program is unable to write the file,
// then it should print an error message like: "Unable to write file: my-file.txt"

using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        public static void WriteSingleLine(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Daniel Szamosi");
                }

                string[] linesOfMyFile = File.ReadAllLines(filePath);

                foreach (var line in linesOfMyFile)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"Unable to write file: {filePath}");
            }
        }

        public static void Main(string[] args)
        {
            string myFile = @".\my-file.txt";
            string mysteriousFile = @".\IsThereEvenAFileLikeThis";

            WriteSingleLine(myFile);
            WriteSingleLine(mysteriousFile);        // For trying out on a non-existent file

            Console.ReadLine();
        }
    }
}