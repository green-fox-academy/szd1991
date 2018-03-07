using System;

namespace Comparable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            return Values[0].CompareTo(((Domino)obj).Values[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}