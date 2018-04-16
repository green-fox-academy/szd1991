using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndRest.Models
{
    public class DoUntilDTO
    {
        public int? Until { get; set; }

        public int SumUntil()
        {
            int sum = 0;

            for (int i = 1; i <= Until; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int FactorUntil()
        {
            int factor = 1;

            for (int i = 1; i <= Until; i++)
            {
                factor *= i;
            }

            return factor;
        }
    }
}
