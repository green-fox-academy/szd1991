using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings = 4, string name = "Bass Guitar") : base(numberOfStrings, name)
        {
        }

        public override string Play()
        {
            return $"{name}, a {numberOfStrings}-stringed instrument that goes " + Sound();
        }

        public override string Sound()
        {
           return "DuM-DuUm-DUum";
        }
    }
}
