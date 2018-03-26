using System;
using System.Linq;

namespace FrequencyOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to find the frequency of characters in a given string!

            string exercise = "kakaduketrec";

            Console.WriteLine("Original string: " + exercise);

            var charCountQuery = from ch in exercise
                                 group ch by ch into chCount
                                 select chCount;

            Console.WriteLine("\n\nCounts of characters with query:");
            
            foreach (var character in charCountQuery)
            {
                Console.WriteLine($"Letter: {character.Key}, Count: {character.Count()}");
            }

            var charCountMethod = exercise.GroupBy(ch => ch).Select(ch => ch.Count());

            Console.WriteLine("\n\nCounts of characters with method:");

            foreach (var characterCount in charCountMethod)
            {
                Console.WriteLine($"Letter: , Count: {characterCount}");
            }

            Console.ReadLine();
        }
    }
}
