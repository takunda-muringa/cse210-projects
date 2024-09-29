using System;

class Program
{
    static void Main(string[] args)
    {
        //Print the welcome message
        Console.WriteLine("WELCOME TO MY GUESSING GAME!!!!");
        string playAgain;

        do
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            // Keep asking until the guess is correct
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;
            

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
                    Console.WriteLine($"You guessed it in {attempts} attempts!");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();

        } while (playAgain.ToLower() == "yes");
    }
}
