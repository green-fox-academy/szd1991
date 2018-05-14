using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCreatorLive
{
    class Program
    {
        static void Main(string[] args)
        {
            string manki = "Majom";

            Console.WriteLine(CreatePalindrome(manki));

            Console.ReadLine();
        }

        static string CreatePalindrome(string potentialPalindrome)
        {
            string palindrome = potentialPalindrome;

            for (int i = potentialPalindrome.Length - 1; i >= 0; i--)
            {
                palindrome += potentialPalindrome[i];
            }

            return palindrome;
        }
    }
}
