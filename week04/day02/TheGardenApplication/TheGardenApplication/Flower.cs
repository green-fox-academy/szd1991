using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Flower : Plant
    {
        public Flower(string colour) : base(colour)
        {
            waterAbsorb = 0.75f;
        }

        public override bool CheckIfNeedsWater()
        {
            return base.CheckIfNeedsWater();
        }
    }
}
