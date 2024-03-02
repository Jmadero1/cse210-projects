using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess;
        int guessCount = 0;
        string playAgain;

        do
        {
            Console.WriteLine("Welcome to Guess the Number game!");
            Console.WriteLine("I've picked a magic number between 1 and 100.");
            Console.WriteLine("Try to guess it!");

            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            } while (guess != magicNumber);

            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");

            Console.Write("Do you want to try again? (yes/no): ");
            playAgain = Console.ReadLine();

            if (playAgain.ToLower() == "yes")
            {
                magicNumber = random.Next(1, 101);
                guessCount = 0;
            }

        } while (playAgain.ToLower() == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
