using System;
using System.Collections.Generic;
using System.Text;

namespace Foxes
{
    class Fox
    {
        private string name;
        private string type;
        private string colour;

        public Fox(string name, string type, string colour)
        {
            this.name = name;
            this.type = type;
            this.colour = colour;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Colour { get => colour; set => colour = value; }
    }
}
