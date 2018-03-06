using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Tree : Plant
    {
        public Tree(string colour) : base(colour)
        {
            if (currentWaterAmount < 10)
            {
                needsWater = true;
            }
            else
            {
                needsWater = false;
            }

            waterAbsorb = 0.4f;
        }
    }
}
