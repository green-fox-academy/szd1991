using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        private string Name;
        private float GasAmount;

        public Station(string Name, float GasAmount = 1000f)
        {
            this.Name = Name;
            this.GasAmount = GasAmount;
        }

        public void Refill(Car car)
        {
            GasAmount -= car.GetCapacity();
            car.SetGasAmount((GasAmount - car.GetCapacity()));
        }
    }
}
