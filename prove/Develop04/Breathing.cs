using System;
using static System.Console;

//! Class Completed: Do not change
class Breathing : Activity
{
    private int _duration;

    public Breathing(string description, string name) : base(description, name)
    {

    }

    public Breathing(int duration) : base(duration)
    {
        _duration = duration;
    }

    public void BreathCounter(int _duration)
    {
        WriteLine();
        int iterations = (int)(_duration / 10);
        while (iterations > 0)
        {
            Write("Breathe in... ");
            CountDown();
            WriteLine();
            Write("Now breathe out... ");
            CountDown();
            WriteLine();
            WriteLine();
            iterations = iterations - 1;
        }
    }



}