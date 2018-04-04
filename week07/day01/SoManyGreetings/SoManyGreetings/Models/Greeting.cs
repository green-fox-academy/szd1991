using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SoManyGreetings.Models
{
    public class Greeting
    {
        private string[] greetings;

        public Greeting(string[] greetings)
        {
            this.greetings = greetings;
        }

        public string[] Greetings { get => greetings; }
    }
}
