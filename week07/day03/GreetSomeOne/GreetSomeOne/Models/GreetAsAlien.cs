using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Models
{
    public class GreetAsAlien : IGreetable
    {
        public string Name { get; set; }

        public string SetName(string name)
        {
            Name = name;
            return Name;
        }

        public string GetName()
        {
            return Name;
        }

        public string Greet()
        {
            return $"Greetings, earthling {Name}...";
        }

    }
}
