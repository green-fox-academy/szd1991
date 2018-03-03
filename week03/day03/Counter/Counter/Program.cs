using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On a scale of 0 (= awful) to 25 (= absolutely great), what feelings did you have yesterday?");
            Counter dailyGFAHappinessMeter = new Counter();
            int yesterday = int.Parse(Console.ReadLine());
            
            if (yesterday >= 0 && yesterday <= 25)
            {
                dailyGFAHappinessMeter = new Counter(yesterday);
            }
            else
            {
                dailyGFAHappinessMeter = new Counter();
                Console.WriteLine("You should've put in an integer number between 0 and 25. You're getting 0 as default.");
            }
                
            Console.WriteLine($"According to the Daily Green Fox Academy Happiness Meter, your happiness is currently at level {dailyGFAHappinessMeter.GetCurrentValue()}.\n");

            Console.WriteLine("On a scale of 0 to 10, how delicious and fulfilling was your lunch?");
            int lunch = int.Parse(Console.ReadLine());
            if (lunch >= 0 && lunch <= 10)
            {
                dailyGFAHappinessMeter.AddNumber(lunch);
            }
            else
            {
                dailyGFAHappinessMeter.AddNumber(0);
                Console.WriteLine("You should've put in an integer number between 0 and 10. You're getting 0 added.");
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
                Console.WriteLine("Daily happiness progress lost. Sorry... :(");
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
