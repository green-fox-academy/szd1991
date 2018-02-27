// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"

using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        public static void Main(string[] args)
        {
            string myFile = @".\my-file.txt";

            // File.WriteAllText(myFile, "My file contains not too important things. Sorry about that.");

            try
            {
                string[] contentOfMyFile = File.ReadAllLines(myFile);
                foreach (var word in contentOfMyFile)
                {
                    Console.Write(word);
                }
            }
            catch (Exception fileError)
            {
                Console.WriteLine(fileError.Message);
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}