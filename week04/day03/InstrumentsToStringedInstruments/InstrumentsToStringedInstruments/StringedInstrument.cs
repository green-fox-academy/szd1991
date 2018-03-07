using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        protected StringedInstrument(int numberOfStrings, string name) : base(name)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public abstract void Sound();
    }
}
