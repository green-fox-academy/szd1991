using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Summing
    {
        public int SumElements(List<int> numbersToSum)
        {
            int sum = 0;

            for (int i = 0; i < numbersToSum.Count; i++)
            {
                sum += numbersToSum[i];
            }
            return sum;
        }
    }
}
