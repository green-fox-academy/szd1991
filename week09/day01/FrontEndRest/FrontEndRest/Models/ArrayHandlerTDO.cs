using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndRest.Models
{
    public class ArrayHandlerTDO
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }

        public int Sum()
        {
            int sum = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
            }

            return sum;
        }

        public int Multiply()
        {
            int multiplant = 1;

            for (int i = 0; i < Numbers.Length; i++)
            {
                multiplant *= Numbers[i];
            }

            return multiplant;
        }

        public int[] Double()
        {
            int[] doubles = new int[Numbers.Length];

            for (int i = 0; i < Numbers.Length; i++)
            {
                doubles[i] = Numbers[i] * 2;
            }

            return doubles;
        }

        public string NumbersToString()
        {
            string numbers = "{";

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (i == Numbers.Length - 1)
                {
                    numbers += Numbers[i] + "}";
                }
                else
                {
                    numbers += Numbers[i] + ",";
                }
            }

            return numbers;
        }
    }
}
