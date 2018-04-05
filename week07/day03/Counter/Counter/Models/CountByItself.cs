using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class CountByItself : ICountable
    {
        public int Count(int counter)
        {
            counter += counter;
            return counter;
        }
    }
}
