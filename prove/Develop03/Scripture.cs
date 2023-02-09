using System;
public class Scripture
{
    bool _decision = false;
    public List<Word> _scriptureArray = new List<Word>();

    public Scripture(string scriptureText)
    {
        
        List<string> _scriptureArray = scriptureText.Split(" ").ToList();
        foreach (string word in _scriptureArray) // CHECK IF HIDDEN
        {
            
        }
    }

    public void RemoveRandomWord()
}