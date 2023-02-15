using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John", "Math");
        Console.WriteLine(a1.GetSummary());

        Console.WriteLine("");

        MathAssignment m1 = new MathAssignment("John", "Arithmetic", "9.8", "1-4");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeWorkList());
        
        Console.WriteLine("");

        WritingAssignment w1 = new WritingAssignment("John", "Literature", "Herman Melville", "Jeff Stamos");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
        
    }

}