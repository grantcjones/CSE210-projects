using static System.Console;

public class Comment
{
    public string _user;
    public string _text;

    public Comment()
    {
        
    }

    public void Display()
    {
        WriteLine($"{_user}\n    {_text}\n");
    }
}