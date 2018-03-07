using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings = 4, string name = "Bass Guitar") : base(numberOfStrings, name)
        {
        }

        public override void Play()
        {
            Console.Write($"{name}, a {numberOfStrings}-stringed instrument that goes ");
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("DuM-DuUm-DUum");
        }
    }
}
