using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings = 6, string name = "Electric Guitar") : base(numberOfStrings, name)
        {
        }

        public override string Play()
        {
            return $"{name}, a {numberOfStrings}-stringed instrument that goes " + Sound();
        }

        public override string Sound()
        {
            return "TWANG";
        }
    }
}
