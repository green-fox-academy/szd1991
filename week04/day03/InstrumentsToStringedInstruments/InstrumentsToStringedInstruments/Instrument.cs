using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    abstract class Instrument
    {
        protected string name;

        protected Instrument(string name)
        {
            this.name = name;
        }

        public abstract void Play();
    }
}
