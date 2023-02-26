using System;
using static System.Console;
class Program
{
    static int Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start Breathing activity");
        Console.WriteLine("    2. Start Reflecting Activity");
        Console.WriteLine("    3. Start Listing Activity");
        Console.WriteLine("    4. Quit");
        Console.WriteLine("Select a choice from the menu:");
        string userChoice = Console.ReadLine();
        int choice = Int32.Parse(userChoice);
        return choice;
    }

    static void CountDown()
    {
        string[] spinner = {"/", "-", "\\", "|"};
        foreach (string i in spinner)
        {
            Write(i);
            Write("\b \b");
        }
        // Console.Write("/");
        // Thread.Sleep(500);

        // Console.Write("\b \b"); // Erase the + character

    }


    static void Main(string[] args)
    {
        WriteLine("Menu Options:");
        WriteLine("    1. Start Breathing activity");
        WriteLine("    2. Start Reflecting Activity");
        WriteLine("    3. Start Listing Activity");
        WriteLine("    4. Quit");
        Write("Select a choice from the menu:");

        string userInput = Console.ReadLine();
        int contQuit = Int32.Parse(userInput);

        

        while (contQuit != 4)
        {
            if (contQuit == 1)
            {   
                
                Breathing b1 = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                {                    
                    Clear();                    
                    int time = b1.SetActivity();
                    Breathing b2 = new Breathing(time);
                    Clear();
                    WriteLine("Get ready.");
                    b1.Spinner();
                    b2.BreathCounter(time);
                    b1.EndActivity(time);
                    b1.Spinner(); //TODO Get rid of "Get ready" issue
                    Clear();
                }
                contQuit = Menu();
            }

            if (contQuit == 2)
            {
                Reflecting r1 = new Reflecting("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                {
                    Clear();
                    int time = r1.SetActivity();
                    Reflecting r2 = new Reflecting(time);
                    Clear();
                    WriteLine("Get ready.");
                    r1.Spinner();
                    r2.Reflect(time);
                    r1.EndActivity(time);
                    r1.Spinner();
                    Clear();
                }
                contQuit = Menu();

            }

            if (contQuit == 3) //TODO Correct all info to Listing activity instead of Reflecting
            {
                Listing l1 = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                {    
                    Clear();
                    int time = l1.SetActivity();
                    Listing l2 = new Listing(time);
                    Clear();
                    WriteLine("Get ready.");
                    l1.Spinner();
                    l1.List(time);
                    l1.EndActivity(time);
                    l1.Spinner();
                    Clear();
                }
                contQuit = Menu();
            }
        }

    }
    // Better comments
    // TODO DO THIS THING
    // ! DON'T DO THIS THING
    // ? Don't know how to do
    // * lime green
    //// show it's not supposed to be here
   
}