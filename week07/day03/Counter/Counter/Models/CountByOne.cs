using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class CountByOne : ICountable
    {
        public int Count(int counter)
        {
            return counter++;
        }
    }
}
