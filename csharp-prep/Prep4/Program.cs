using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter a number: ");
        string userInput = Console.ReadLine();
        int addNumber = int.Parse(userInput);

        while (addNumber != 0)
        {   
            numbers.Add(addNumber);
            Console.WriteLine("Enter a number: ");
            addNumber = int.Parse(Console.ReadLine());
        }

        int zeroSum = 0;
        int zeroHigh = 0;

        foreach (int number in numbers)
        {
            zeroSum = (number + zeroSum);

            if (number > zeroHigh)
            {
                zeroHigh = number;
            }
        }

        Console.WriteLine(numbers.Count); // Checking Math

        int listAverage = (zeroSum / (numbers.Count - 1));

        Console.WriteLine($"The sum is: {zeroSum}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The biggest number is: {zeroHigh}");



    }
}