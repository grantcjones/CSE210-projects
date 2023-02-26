using System;
using static System.Console;

//! I don't understand why, but whenever Line 50 is executed, RandElement seems to be reading _prompts as null. Everything else in the program works, including Listing (which uses RandElement much in the same way), so I'm not sure what's going on.

class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _thoughts; 


    public Reflecting( string name, string description) : base(name, description)
    {
        List<string> prompts = new List<string>
        {"Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless.",
        "Think of a time you were proud of an accomplishment."
        };
        _prompts = prompts;

        List<string> questions = new List<string>
        {"Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
        _questions = questions;

        List<string> thoughts = new List<string>{};
        _thoughts = thoughts;
    }

    public Reflecting(int duration) : base(duration)
    {
        
    }

    public void Reflect(int seconds) 
    {
        WriteLine("Consider the following prompt:");
        WriteLine();
        Write($"  ---" + RandElement(_prompts) + "---"); //! I cannot understand why RandElement keeps passing _prompts as null; I tried as much as I could to fix that, and it was the one issue that decided to come up right before the due time
        WriteLine();
        WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Write("Now ponder on each of the following questions as they related to this experience. ");
        CountDown();
        WriteLine();
        QuestionTimer(seconds, _questions);


    }
        
    
    
}