using System;
using static System.Console;


class Activity
{
    private string _description;
    private string _name;
    private int _duration; // * in seconds

    public Activity(string name, string description)
    {
        _description = description;
        _name = name;
    }

    public Activity(int duration)
    {
        _duration = duration;
    }

    public int SetActivity()
    {
        //* 
        WriteLine($"Welcome to the {_name} Activity!");
        WriteLine();
        WriteLine(_description);
        WriteLine();
        Write("How long, in seconds, would you like for your session?: ");
        string userDuration = ReadLine();
        int myDuration = Int32.Parse(userDuration);
        return myDuration;
    }


    public void CountDown()
    {
        string[] count = {"5", "4", "3", "2", "1"};

        foreach (string i in count)
        {
            Write(i);
            Thread.Sleep(950);
            Write("\b \b");
        }
    }

    public void Spinner()
    {   
        int iterations = (5);
        while (iterations > 0)
        {
            string[] spinner = {"/", "-", "\\", "|"};
            foreach (string i in spinner)
            {
                Write(i);
                Thread.Sleep(150);
                Write("\b \b");
            }            
            iterations = iterations - 1;
        }
    }

    public string RandElement(List<string> arr)
    {
        Random random = new Random();
        int rand = random.Next(0, 4);
        string chosenElement = arr[rand];
        return chosenElement;
    }

    public void QuestionTimer(int seconds, List<string> arr)
    {
        Random random = new Random();

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            string question = arr[random.Next(arr.Count())];

            Console.WriteLine(question);

            string answer = Console.ReadLine();

            WriteLine();
        }
    }

    public void EndActivity(int seconds)
    {
        WriteLine("Well done!");
        WriteLine();
        WriteLine($"You have completed another {seconds} seconds of the {_name} Activity.");
    }


}