using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            Random random = new Random();
            int storedNumber = random.Next(0, 100);
            int userInput;
            Console.WriteLine("Good day Sherlock! I thought of a number between 0 and 100. Want to guess it?");

            do
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput > storedNumber)
                {
                    Console.WriteLine("The stored number is lower. Try again!");
                }
                else if (userInput < storedNumber)
                {
                    Console.WriteLine("The stored number is higher. Don't give up!");
                }
                else if (userInput == storedNumber)
                {
                    Console.WriteLine("You found the number! It was: " + storedNumber);
                }

            } while (userInput != storedNumber);

            Console.ReadLine();
        }
    }
}