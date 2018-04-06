using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CounterWithEmptyWebAppTemplate.Models
{
    public interface ICountable
    {
        void Count();

        int GetNumber();
    }
}
