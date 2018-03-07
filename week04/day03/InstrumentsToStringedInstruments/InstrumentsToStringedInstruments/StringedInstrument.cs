using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        protected StringedInstrument(int numberOfStrings, string name) : base(name)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public abstract string Sound();
    }
}
