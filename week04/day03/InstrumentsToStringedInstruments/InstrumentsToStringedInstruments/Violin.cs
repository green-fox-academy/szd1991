using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings = 4, string name = "Violin") : base(numberOfStrings, name)
        {
            base.name = "Violin";
        }

        public override void Play()
        {
            Console.Write($"{name}, a {numberOfStrings}-stringed instrument that goes ");
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("SCREECH");
        }
    }
}
