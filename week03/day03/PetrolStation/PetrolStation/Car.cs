using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Car
    {
        private string Name;
        private float GasAmount;
        private float Capacity;

        public Car(string Name, float GasAmount = 0f, float Capacity = 100f)
        {
            this.Name = Name;
            this.GasAmount = GasAmount;
            this.Capacity = Capacity;
        }

        public float GetGasAmountCar()
        {
            return this.GasAmount;
        }

        public float GetCapacity()
        {
            return this.Capacity;
        }

        public void SetGasAmount(float _gasAmount)
        {
            GasAmount = _gasAmount;
        }
    }
}
