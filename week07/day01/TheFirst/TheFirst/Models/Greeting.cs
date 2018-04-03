using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFirst.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        static long counter = 1;

        public Greeting(string content)
        {
            Content = content;
            Id = counter++;
        }

        //long id;
        //string content;

        //public long Id { get => id; set => id = value; }
        //public string Content { get => content; set => content = value; }
    }
}
