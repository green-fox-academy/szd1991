using System;
using System.Linq;

namespace FindUppercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to find the uppercase characters in a string!

            string example = "How is Everyone Lurking around at Larry's?";

            var uppercaseLettersMethod = example.Where(l => char.IsUpper(l)).Select(l => l);

            Console.WriteLine($"In the phrase \"{example}\", the uppercase letters are:");

            foreach (var upper in uppercaseLettersMethod)
            {
                Console.Write(upper);
            }

            var uppercaseLettersQuery = from letter in example
                                       where char.IsUpper(letter)
                                       select letter;

            Console.WriteLine($"\n\nIn the phrase \"{example}\", the uppercase letters are:");

            foreach (var upper in uppercaseLettersQuery)
            {
                Console.Write(upper);
            }

            Console.ReadLine();
        }
    }
}
