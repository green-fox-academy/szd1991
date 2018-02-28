using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal giraffe = new Animal();
            Animal lion = new Animal();

            Console.WriteLine("How many leaves are there for Mr. Giraffe?");
            int leaves = int.Parse(Console.ReadLine());

            Console.WriteLine("How many sirloin steaks are there for Ms. Lion?");
            int steaks = int.Parse(Console.ReadLine());

            Console.WriteLine("How many lakes are there?");
            int lakes = int.Parse(Console.ReadLine());

            Console.WriteLine("For how many rounds should Ms. Lion chase Mr. Giraffe?");
            int rounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < leaves; i++)
            {
                giraffe.Eat();
            }

            for (int i = 0; i < steaks; i++)
            {
                lion.Eat();
            }

            for (int i = 0; i < lakes; i++)
            {
                giraffe.Drink();
                lion.Drink();
            }

            for (int i = 0; i < rounds; i++)
            {
                giraffe.Play();
                lion.Play();
            }

            Console.WriteLine($"Mr. Giraffe is now {giraffe.GetHunger()}% hungry and {giraffe.GetThirst()}% thirsty");
            Console.WriteLine($"Mr. Giraffe is now {lion.GetHunger()}% hungry and {lion.GetThirst()}% thirsty");

            Console.ReadLine();
        }
    }
}
