using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I've chosen a number between 1 and 100. Try to guess it!");

            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                attempts++; 
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    guessedCorrectly = true;
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
