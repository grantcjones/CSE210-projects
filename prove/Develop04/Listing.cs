using System;
using static System.Console;

class Listing : Activity
{
    private List<string> _questions;
    private List<string> _responses;

    public Listing(string description, string name, int duration) : base(name, description)
    {
        List<string> questions = new List<string>
        {"Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"};
        _questions = questions;

        List<string> responses = new List<string>();
        _responses = responses;
    }

    public void List(int seconds) //TODO add input for seconds / format this according to the ex video
    {
        WriteLine("List as many responses as you can to the following propmt:");
        WriteLine("    ---- " + RandElement(_questions) + "----");
        Write("You may begin in: ");
        CountDown();
        WriteLine();
        Write(">");
        QuestionTimer(20, _questions);
        //TODO create time limit in Base Class

        // bool duration = TimeLimit(seconds, _responses);
        // while ((TimeLimit(seconds, _responses))== false)
        // {
        //     if ((TimeLimit(seconds, _responses))  )
        //     string answer = ReadLine();
        //     _questions.Append<string>(answer);
        // }

        WriteLine("Well done!!");
    }
}