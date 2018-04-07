using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Models
{
    public class AnagramsLenient : IAnagram
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }

        public string SetFirstWord(string firstInput)
        {
            FirstWord = firstInput;
            return FirstWord;
        }

        public string SetSecondWord(string secondInput)
        {
            SecondWord = secondInput;
            return SecondWord;
        }

        public string ModifyFirstWordToAnalyze()
        {
            return string.Join("",
                FirstWord
                .Replace(" ", "")
                .ToLower()
                .ToArray()
                .OrderBy(letter => letter)
                );
        }

        public string ModifySecondWordToAnalyze()
        {
            return string.Join("",
                SecondWord
                .Replace(" ", "")
                .ToLower()
                .ToArray()
                .OrderBy(letter => letter)
                );
        }

        public bool Analyze()
        {
            if (ModifyFirstWordToAnalyze().Equals(ModifySecondWordToAnalyze()))
            {
                return true;
            }

            return false;
        }
    }
}
