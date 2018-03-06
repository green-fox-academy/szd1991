using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Flower : Plant
    {
        public Flower(string colour) : base(colour)
        {
            if (currentWaterAmount < 5)
            {
                needsWater = true;
            }
            else
            {
                needsWater = false;
            }

            waterAbsorb = 0.75f;
        }
    }
}
