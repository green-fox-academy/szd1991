using InstrumentsToStringedInstruments;
using System;


namespace ConcertHall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1, create Electric Guitar, Bass Guitar and Violin with default strings.");
            var guitar = new ElectricGuitar();
            var bassGuitar = new BassGuitar();
            var violin = new Violin();

            Console.WriteLine("Test 1 Play");
            Console.WriteLine($"{guitar.Play()}\n" +
                $"{bassGuitar.Play()}\n" +
                $"{violin.Play()}");

            Console.WriteLine("Test 2, create Electric Guitar, Bass Guitar with 7 and 5 strings .");
            ElectricGuitar guitar2 = new ElectricGuitar(7);
            BassGuitar bassGuitar2 = new BassGuitar(5);

            Console.WriteLine("Test 2 Play");
            Console.WriteLine($"{guitar2.Play()}\n" +
                $"{bassGuitar2.Play()}");

            Console.ReadLine();
        }
    }
}
