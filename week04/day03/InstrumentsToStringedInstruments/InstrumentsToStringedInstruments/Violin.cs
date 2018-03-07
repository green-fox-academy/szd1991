using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    public class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings = 4, string name = "Violin") : base(numberOfStrings, name)
        {
        }

        public override string Play()
        {
            return $"{name}, a {numberOfStrings}-stringed instrument that goes " + Sound();
        }

        public override string Sound()
        {
            return "SCREECH";
        }
    }
}
