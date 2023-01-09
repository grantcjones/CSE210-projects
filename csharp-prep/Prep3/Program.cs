using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is the magic number?: ");
        string userInputNumber = Console.ReadLine();
        int magicNumber = int.Parse(userInputNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, magicNumber);

        Console.WriteLine("What is your guess?: ");
        string userInputGuess = Console.ReadLine();
        int magicGuess = int.Parse(userInputGuess);

        int tryCounter = 0;

        while (magicGuess != number)
        {
            if (magicGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (magicGuess > number)
            {
                Console.WriteLine("Lower");
            }

            tryCounter = (tryCounter + 1);

            Console.WriteLine("What is your guess?: ");
            magicGuess = int.Parse(Console.ReadLine());
        }

        if (magicGuess == number)
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of attemps: {tryCounter}.");
        }

    }
}