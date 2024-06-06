using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int attempts = 0;
        bool correctGuess = false;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I've selected a random number between 1 and 100.");
        Console.WriteLine("Try to guess it!");

        do
        {
            Console.Write("Enter your guess Number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                attempts++;

                if (guess == randomNumber)
                {
                    correctGuess = true;
                    Console.WriteLine($"Congratulations! You guessed the number {randomNumber} correctly in {attempts} attempts!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 1 and 100.");
            }
        } while (!correctGuess);

        Console.WriteLine("Thanks for playing!");
    }
}
