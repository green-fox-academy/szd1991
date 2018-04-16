using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
what can be 3 things: sum, multiply, double

and responds with sum or multiplication of all elements in the numbers or with another array with the doubled elements:
eg. /arrays with {"what": "sum", "numbers": [1,2,5,10]} will respond {"result": 18}
eg. /arrays with {"what": "multiply", "numbers": [1,2,5,10]} will respond {"result": 100}
eg. /arrays with {"what": "double", "numbers": [1,2,5,10]} will respond {"result": [2,4,10,20]}

if no what (or numbers) is provided:
{
  "error": "Please provide what to do with the numbers!"
} 
*/

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
    }
}
