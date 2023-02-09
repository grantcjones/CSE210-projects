
class Word
{
    public string _wordItem;
    public bool _hide = false;
    public List<string> _scriptureArray = new List<string>();

    public Word(string wordItem)
    {
        IfHidden(wordItem);
    }

    public void IfHidden(string wordItem)
    {
        foreach (char letter in wordItem)
        {
            Console.Write("_");
        }
    }

}