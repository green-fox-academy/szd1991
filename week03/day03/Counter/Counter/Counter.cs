/*
Counter
Create Counter class
which has an integer property
when creating it should have a default value 0 or we can specify it when creating
we can Add(number) to this counter another whole number
or we can Add() without parameters just increasing the counter's value by one
and we can Get() the current value as string
also we can Reset() the value to the initial value
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        private int DefaultValue;
        private int CurrentValue;

        public Counter(int DefaultValue = 0)
        {
            this.DefaultValue = DefaultValue;
            CurrentValue = DefaultValue;
        }

        public void AddNumber(int number)
        {
            CurrentValue += number;
        }

        public void SimpleIncrease()
        {
            CurrentValue++;
        }

        public void Reset()
        {
            CurrentValue = DefaultValue;
        }

        public string GetCurrentValue()
        {
            return Convert.ToString(CurrentValue);
        }
    }
}
