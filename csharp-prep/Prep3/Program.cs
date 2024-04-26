using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain;

        do
        {
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("Guess My Number Game");
            Console.WriteLine("--------------------");

            while (!guessedCorrectly)
            {
                Console.Write("What is your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());
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
                    guessedCorrectly = true;
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = playAgainInput == "yes";

            Console.WriteLine();
        } while (playAgain);

        Console.WriteLine("Thanks for playing!");
    }
}