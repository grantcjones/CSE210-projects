public class Prompts
{

    // public List<string> _prompts = new List<string>();

    public string _prompt1 = "Who was the most interesting person I interacted with today?";
    public string _prompt2 = "What was the best part of my day?";
    public string _prompt3 = "How did I see the hand of the Lord in my life today?";
    public string _prompt4 = "What was the strongest emotion I felt today?";
    public string _prompt5 = "If I had one thing I could do over today, what would it be?";


    public string RandomGenerator()
    {
        List<string> _prompts = new List<string>();

        _prompts.Add(_prompt1);
        _prompts.Add(_prompt2);
        _prompts.Add(_prompt3);
        _prompts.Add(_prompt4);
        _prompts.Add(_prompt5);

        int listLength = _prompts.Count();
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, listLength);

        // Console.WriteLine(number); // TESTING

        string promptActual = _prompts[number];
        return promptActual;
    }


    public void RandomPrompts()
    {

    }

    // public string Display()
    // {
    //     Console.WriteLine(RandomGenerator());
    // }

} 

