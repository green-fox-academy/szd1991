using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Garden
    {
        internal string name;
        internal List<Plant> garden;

        public Garden(string name)
        {
            this.name = name;
            garden = new List<Plant>();
        }

        public List<Plant> AddFlower(Flower flower)
        {
            garden.Add(flower);
            return garden;
        }

        public List<Plant> AddTree(Tree tree)
        {
            garden.Add(tree);
            return garden;
        }

        public void GetInfo()
        {
            foreach (var plant in garden)
            {
                if (plant.CheckIfNeedsWater() == true)
                {

                    Console.WriteLine($"The {plant.colour} {plant.GetType().Name} needs water.");
                }
                else
                {
                    Console.WriteLine($"The {plant.colour} {plant.GetType().Name} doesn't need water.");
                }
            }
            Console.WriteLine("\n");
        }

        public void Watering(float amountOfWateringWater)
        {
            Console.WriteLine("Watering with {0}", amountOfWateringWater);

            List<Plant> plantsToBeWatered = new List<Plant>();

            foreach (var plant in garden)
            {
                if (plant.CheckIfNeedsWater() == true)
                {
                    plantsToBeWatered.Add(plant);
                }
                else
                {
                }
            }    

            for (int i = 0; i < plantsToBeWatered.Count; i++)
            {
                plantsToBeWatered[i].currentWaterAmount += (amountOfWateringWater / plantsToBeWatered.Count) * plantsToBeWatered[i].waterAbsorb;
            }

            GetInfo();
        }
    }
}
