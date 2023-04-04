using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        DateTime fullDate = DateTime.Now;
        string today = fullDate.ToString("dd MMM yyyy");

        Running r1 = new Running((float)3, today, 30);

        Biking b1 = new Biking((float)12.2, today, 311);
        
        Swimming s1 = new Swimming(30, today, 9);        
        
        WriteLine(r1.GetSummary());
        WriteLine(b1.GetSummary());
        WriteLine(s1.GetSummary());
    }
}