using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings = 6, string name = "Electric Guitar") : base(numberOfStrings, name)
        {
        }

        public override void Play()
        {
            Console.Write($"{name}, a {numberOfStrings}-stringed instrument that goes ");
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("TWANG");
        }
    }
}
