using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class CountByItself : ICountable
    {
        public int Counter { get; set; } = 1;

        public void Count()
        {
            Counter += Counter;
        }

        public int getNumber()
        {
            return Counter;
        }
    }
}
