using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    public abstract class Instrument
    {
        protected string name;

        protected Instrument(string name)
        {
            this.name = name;
        }

        public abstract string Play();
    }
}
