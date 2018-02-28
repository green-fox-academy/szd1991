/*
Sharpie
Create Sharpie class
We should know about each sharpie their Color (which should be a string), Width (which will be a floating point number), InkAmount (another floating point number)
When creating one, we need to specify the Color and the Width
Every sharpie is created with a default 100 as InkAmount
We can Use() the sharpie objects
which decreases inkAmount
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    public class Sharpie
    {
        string Colour;
        float Width;
        float InkAmount;

        public Sharpie(string Colour, float Width)
        {
            this.Colour = Colour;
            this.Width = Width;
            this.InkAmount = 100;
        }

        public void Use()
        {
            InkAmount -= Width;
        }

        public float GetInkStatus()
        {
            return InkAmount;
        }
    }
}
