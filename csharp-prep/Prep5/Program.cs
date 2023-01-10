using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = (number ^ 2);
        return numberSquared;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int factor = PromptUserNumber();
        int finalNumber = SquareNumber(factor);
        DisplayResult(name, finalNumber);

    }
}