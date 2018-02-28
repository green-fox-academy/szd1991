/*
Create an Animal class
Every animal has a hunger value, which is a whole number
Every animal has a thirst value, which is a whole number
when creating a new animal object these values are created with the default 50 value
Every animal can eat() which decreases their hunger by one
Every animal can drink() which decreases their thirst by one
Every animal can play() which increases both by one
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Animal
    {
        private int hunger;
        private int thirst;

        public Animal(int hunger = 50, int thirst = 50)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
        }

        public int GetHunger()
        {
            return hunger;
        }

        public int GetThirst()
        {
            return thirst;
        }
    }
}
