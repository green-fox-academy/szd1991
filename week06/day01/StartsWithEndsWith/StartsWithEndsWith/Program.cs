using System;
using System.Linq;

namespace StartsWithEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var startsWithAEndsWithIMethod = cities.Where(c => c.StartsWith('A') && c.EndsWith('I'));

            Console.WriteLine("Original array:");

            foreach (var city in cities)
            {
                Console.Write(city + ", ");
            }

            Console.WriteLine("\n\nThe city that starts with letter A and ends with letter I is:");

            foreach (var city in startsWithAEndsWithIMethod)
            {
                Console.WriteLine(city);
            }

            var startsWithAEndsWithIQuery = from city in cities
                                            where city.StartsWith('A') && city.EndsWith('I')
                                            select city;

            Console.WriteLine("\n\nThe city that starts with letter A and ends with letter I is, again:");

            foreach (var city in startsWithAEndsWithIQuery)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
