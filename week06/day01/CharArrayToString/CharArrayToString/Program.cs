using System;
using System.Linq;

namespace CharArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] futureString = new char[] { 'k', 'a', 'r', 'a', 'j' };

            var charArrayToStringMethodButIsThisLINQ = String.Join("", futureString);
            var charArrayToStringMethodButIsThisLINQAsWellIAmWondering = string.Concat(futureString);

            var charArrayToStringQuery = from ch in futureString
                                         select ch;

            Console.WriteLine(charArrayToStringMethodButIsThisLINQ);
            Console.WriteLine(charArrayToStringMethodButIsThisLINQAsWellIAmWondering);
            Console.WriteLine(String.Join("", futureString.Select(p => p.ToString()).ToArray()));

            foreach (var ch in charArrayToStringQuery)
            {
                Console.Write(ch);
            }

            Console.ReadLine();
        }
    }
}
