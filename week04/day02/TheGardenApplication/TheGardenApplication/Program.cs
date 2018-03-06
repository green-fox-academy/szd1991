using System;
using System.Collections.Generic;

namespace TheGardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower yellowFlower = new Flower("yellow");
            Flower blueFlower = new Flower("blue");
            Tree purpleTree = new Tree("purple");
            Tree orangeTree = new Tree("orange");

            Garden ofEden = new Garden("Garden of Eden");

            ofEden.AddFlower(yellowFlower);
            ofEden.AddFlower(blueFlower);
            ofEden.AddTree(purpleTree);
            ofEden.AddTree(orangeTree);

            ofEden.GetInfo();

            ofEden.Watering(40);

            ofEden.Watering(70);

            Console.ReadLine();
        }
    }
}
