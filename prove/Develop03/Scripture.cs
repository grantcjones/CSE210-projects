using System;
public class Scripture
{
    // bool _decision = false;

    public Scripture(string scriptureText)
    {
        List<string> _scriptureArray = scriptureText.Split(" ").ToList();
        foreach (string word in _scriptureArray) // CHECK IF HIDDEN
        {

        }
    }

    public void RemoveRandomWord(string word)
    {
        Random rng = new Random(); // USE .Next TO 'INVOKE'
        int randomNumber = rng.Next(0, 1);


        if (randomNumber == 1)
        {
            Word w1 = new Word(word);
        }
        else
        {
            Console.Write(word);
        }

    }
}