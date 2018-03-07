using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        string name;
        int age;
        bool gender;
        string preferredFood;

        internal Animal(string name, int age, bool gender, string preferredFood)
        {

        }

        public abstract string Greet();

        public virtual string WantChild()
        {
            return "Wants a baby ";
        }

        public virtual string Eat()
        {
            return $"I like to eat {preferredFood}";
        }

        public abstract string Drink();

        public abstract string Sleep();

    }
}
