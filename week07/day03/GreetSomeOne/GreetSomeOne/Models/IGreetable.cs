using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Models
{
    public interface IGreetable
    {
        string SetName(string name);

        string GetName();

        string Greet();
    }
}
