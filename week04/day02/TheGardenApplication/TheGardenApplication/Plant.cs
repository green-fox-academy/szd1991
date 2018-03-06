using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Plant
    {
        internal string colour;
        internal float currentWaterAmount;
        internal bool needsWater;
        internal float waterAbsorb;

        public Plant(string colour)
        {
            this.colour = colour;
            currentWaterAmount = 0f;
        }

        public virtual bool CheckIfNeedsWater()
        {
            if (currentWaterAmount < 5)
            {
                needsWater = true;
            }
            else
            {
                needsWater = false;
            }

            return needsWater;
        }
    }
}
