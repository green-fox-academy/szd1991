using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public interface ICountable
    {
        int Count(int counter);
    }
}
