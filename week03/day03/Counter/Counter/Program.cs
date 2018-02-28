using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Did you have a fine day yesterday? (Y or Yes for yes, any other option will turn this false!)");
            string yesterday = Console.ReadLine();

            Counter dailyGFAHappinessMeter = new Counter();
            if (yesterday == "Y" || yesterday == "Yes")
            {
                dailyGFAHappinessMeter = new Counter(40);
            }
            else
            {
                dailyGFAHappinessMeter = new Counter();
            }

            Console.WriteLine($"According to the Daily Green Fox Academy Happiness Meter, your happiness is currently at level {dailyGFAHappinessMeter.GetCurrentValue()}.\n");

            Console.WriteLine("Was your lunch delicious? (Y or Yes for yes, any other option will turn this false!)");
            string lunch = Console.ReadLine();
            if (lunch == "Y" || lunch == "Yes")
            {
                dailyGFAHappinessMeter.AddNumber(15);
            }
            else
            {
                dailyGFAHappinessMeter.AddNumber(0);
            }

            Console.WriteLine($"According to the Daily Green Fox Academy Happiness Meter, your happiness is currently at level {dailyGFAHappinessMeter.GetCurrentValue()}.\n");

            Console.WriteLine("How many problems did you manage to solve?");
            int problems = int.Parse(Console.ReadLine());

            for (int i = 0; i < problems; i++)
            {
                dailyGFAHappinessMeter.SimpleIncrease();
            }

            Console.WriteLine($"According to the Daily Green Fox Academy Happiness Meter, your happiness is currently at level {dailyGFAHappinessMeter.GetCurrentValue()}.\n");

            Console.WriteLine("Did you freak out inside? (Y or Yes for yes, any other option will turn this false!)");
            string freak = Console.ReadLine();
            if (freak == "Y" || freak == "Yes")
            {
                dailyGFAHappinessMeter.Reset();
                Console.WriteLine("Daily progress lost. Sorry... :(");
            }
            else
            {
                dailyGFAHappinessMeter.GetCurrentValue();
            }

            Console.WriteLine($"According to the Daily Green Fox Academy Happiness Meter, your happiness is currently at level {dailyGFAHappinessMeter.GetCurrentValue()}.\n");

            Console.ReadLine();
        }
    }
}
