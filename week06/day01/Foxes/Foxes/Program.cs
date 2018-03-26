using System;
using System.Collections.Generic;
using System.Linq;

namespace Foxes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green color! Write a LINQ Expression to find the foxes with green color and pallida type!

            List<Fox> foxes = new List<Fox>()
            {
                new Fox("Ice Cube", "Arctic", "white"),
                new Fox("Hubert", "Pallida", "purple"),
                new Fox("Wizard", "Fennec", "yellowish"),
                new Fox("Sickone", "Pallida", "green"),
                new Fox("Vomit", "Macrotis", "green")
            };

            foreach (var fox in foxes)
            {
                Console.Write($"{fox.Name}, {fox.Type}, {fox.Colour}\n");
            }

            var greenFoxesMethod = foxes.FindAll(f => f.Colour.Equals("green")).Select(f => f);

            Console.WriteLine("\nThe green foxes, using method syntax are:");

            foreach (var greenFox in greenFoxesMethod)
            {
                Console.WriteLine(greenFox.Name);
            }

            var greenPallidaFoxesMethod = foxes.FindAll(f => f.Colour.Equals("green") && f.Type.Equals("Pallida")).Select(f => f);

            Console.WriteLine("\nThe green pallida foxes, using method syntax are:");

            foreach (var greenPallidaFox in greenPallidaFoxesMethod)
            {
                Console.WriteLine(greenPallidaFox.Name);
            }

            var greenFoxesQuery = from f in foxes
                                  where f.Colour.Equals("green")
                                  select new
                                  {
                                      name = f.Name,
                                      type = f.Type,
                                      colour = f.Colour
                                  };

            Console.WriteLine("\nThe green foxes, using query syntax are:");

            foreach (var greenFox in greenFoxesQuery)
            {
                Console.WriteLine(greenFox);
            }

            var greenPallidaFoxesQuery = from f in foxes
                                  where f.Colour.Equals("green") && f.Type.Equals("Pallida")
                                  select new
                                  {
                                      name = f.Name,
                                      type = f.Type,
                                      colour = f.Colour
                                  };

            Console.WriteLine("\nThe green pallida foxes, using query syntax are:");

            foreach (var greenPallidaFox in greenPallidaFoxesQuery)
            {
                Console.WriteLine(greenPallidaFox);
            }

            Console.ReadLine();
        }
    }
}
