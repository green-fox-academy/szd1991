using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Models
{
    public interface IAnagram
    {
        string SetFirstWord(string firstInput);

        string SetSecondWord(string secondInput);

        string ModifyFirstWordToAnalyze();

        string ModifySecondWordToAnalyze();

        bool Analyze();
    }
}
