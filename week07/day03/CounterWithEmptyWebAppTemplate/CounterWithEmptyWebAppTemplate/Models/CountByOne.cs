using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CounterWithEmptyWebAppTemplate.Models
{
    public class CountByOne : ICountable
    {
        public int Counter { get; set; } = 1;

        public void Count()
        {
            Counter++;
        }

        public int GetNumber()
        {
            return Counter;
        }
    }
}
