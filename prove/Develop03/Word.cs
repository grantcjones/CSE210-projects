
class Word
{
    // public string _wordItem;
    // public bool _hide = false;

    public Word(string wordItem)
    {
        IfHidden(wordItem);
    }

    public string IfHidden(string wordItem)
    {
        if (wordItem.IndexOf("_") == -1)
        {
            string underscore = "";
            foreach (char letter in wordItem)
            {
                underscore = "_" + underscore;
                // return ("_");
            }
            return (underscore + " ");
        }
        else
        {
            return wordItem;
        }

    }

}