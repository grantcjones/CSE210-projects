using System;
public class Scripture
{
    // bool _decision = false;
    public List<string> _scriptureArray = new List<string>();
    public List<string> _newArray = new List<string>();

    public Scripture(string scriptureText)
    {
        List<string> _scriptureArray = scriptureText.Split(" ").ToList();
        foreach (string word in _scriptureArray) // CHECK IF HIDDEN
        {   
            RemoveRandomWord(word);
            _newArray.Add(RemoveRandomWord(word));
            _scriptureArray = _newArray;
            // Replace(_scriptureArray, RemoveRandomWord(word));
            // int where = _scriptureArray.IndexOf(word);
            // _scriptureArray[where] = RemoveRandomWord(word);
            // Console.Write(word + " ");
        }
        
        // Console.WriteLine(_newArray);
    }

    public string RemoveRandomWord(string word)
    {
        Random rng = new Random(); // USE .Next TO 'INVOKE'
        int randomNumber = rng.Next(0, 5);

        // Word w1 = new Word(word);

        if (randomNumber == 0)
        {
            Word w1 = new Word(word);
            {
                word = w1.IfHidden(word);
                return (word + " ");
                // _newArray.Add(word);
            }
        }
        else
        {
            // _newArray.Add(word + " ");
            return (word + " ");
        }

    }

    // private void Replace(List<string> anyList, string anyWord)
    // {
    //     // int where = anyList.IndexOf(anyWord);
    //     anyList[where] = RemoveRandomWord(anyWord);
    // }

    public void Display()
    {
      foreach (string word in _newArray)
        {
            Console.Write(word + " ");
        }
    }
}