using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class CheckIfAnagrams
    {
        public bool AnagramsOrNot(string stringOne, string stringTwo)
        {
            // In most cases two words/strings can be considered anagrams regardless of cases, also they can differ in word count. That's why we need some string modification.

            stringOne = stringOne.Replace(" ", "").ToLower();
            stringTwo = stringTwo.Replace(" ", "").ToLower();

            if (stringOne.Length != stringTwo.Length)
            {
                return false;
            }

            int wordsLength = stringOne.Length;

            int matchingLetters = 0;

            for (int o = 0; o < stringOne.ToCharArray().Length; o++)
            {
                for (int t = 0; t < stringTwo.ToCharArray().Length; t++)
                {
                    if (stringOne.ToCharArray()[o].Equals(stringTwo.ToCharArray()[t]))
                    {
                        matchingLetters++;
                        break;
                    }
                }
            }

            if (wordsLength != matchingLetters)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
