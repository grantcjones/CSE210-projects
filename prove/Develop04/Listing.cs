using System;
using static System.Console;

class Listing : Activity
{
    private List<string> _questions;
    private List<string> _responses;

    public Listing(string name, string description) : base(name, description)
    {
        List<string> questions = new List<string>
        {"Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"
        };
        _questions = questions;

        List<string> responses = new List<string>();
        _responses = responses;
    }

    public Listing(int duration) : base(duration)
    {

    }

    public void List(int seconds) //TODO format this according to the ex video
    {
        WriteLine("List as many responses as you can to the following propmt:");
        WriteLine("    ---- " + RandElement(_questions) + "----");
        Write("You may begin in: ");
        CountDown();
        WriteLine();
        QuestionTimer(seconds, _questions);
        Write(">");
    }
}