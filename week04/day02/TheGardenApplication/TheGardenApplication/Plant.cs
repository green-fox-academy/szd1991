using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Plant
    {
        protected string colour;
        protected float currentWaterAmount;
        protected bool needsWater;
        protected float waterAbsorb;

        public Plant(string colour)
        {
            this.colour = colour;
            currentWaterAmount = 0f;
        }
    }
}
