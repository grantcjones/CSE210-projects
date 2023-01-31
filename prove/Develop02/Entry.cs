public class Entry
{
    public string _date = "";
    Prompts _prompt = new Prompts();

    // public string _entry = "";
    List<string> _entries = new List<string>();

        public string GetDate()
    {
        string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        return date;
    }

    public string GetEntry()
    {   
        string currentDate = GetDate();
        string newPrompt = _prompt.RandomGenerator();
        Console.WriteLine($"{newPrompt}");
        Console.WriteLine("> ");
        string newEntry = Console.ReadLine();
        string fullEntry = ($"Date: {currentDate} - Prompt: {newPrompt} \n {newEntry}"); // Still need a breakline with input
        return fullEntry;
    }



}
