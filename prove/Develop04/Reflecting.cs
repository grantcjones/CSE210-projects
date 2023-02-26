using System;
using static System.Console;
// TODO Need random prompt generator

class Reflecting : Activity
{
    private List<string> _prompts; // ? Create randgen, using constructor?
    private List<string> _questions;
    private List<string> _thoughts; //TODO Append user answers to list, need to display later?

    public Reflecting( string name, string description, int duration) : base(description, name)
    {
        List<string> prompts = new List<string>
        {"Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
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


    private string RandomPrompt()
    {
        string prompt = RandElement(_prompts);
        return prompt;
    }

    public void Reflect(int seconds) //todo add seconds in method
    {
        WriteLine("Consider the following prompt:");
        WriteLine();
        Write($"  ---" + RandomPrompt() + "---");
        WriteLine();
        WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Write("Now ponder on each of the following questions as they related to this experience. ");
        CountDown();
        WriteLine();
        QuestionTimer(20, _questions);

        //TODO add TimeLimit() from Base Class

    }
        //Todo Create loop that spits out random questions, takes responses, and keeps going until a timer (duration) runs out.
        
    
    
}