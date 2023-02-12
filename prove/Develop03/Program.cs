using System;

class Program
{
    static void Main(string[] args)
    {
        bool CONTINUE = true;

        // Console.Write("Enter name of book: ");
        // string book = Console.ReadLine();

        // Console.Write("Enter chapter number: ");
        // string userChapter = Console.ReadLine();
        // int chapter = Int32.Parse(userChapter);

        // Console.Write("Enter beginning verse: ");
        // string userStartVerse = Console.ReadLine();
        // int startVerse = Int32.Parse(userStartVerse);

        // Console.Write("Enter end verse: ");
        // string userEndVerse = Console.ReadLine();
        // int endVerse = Int32.Parse(userEndVerse);

        // Console.Write("Enter scripture text: ");
        // string text = Console.ReadLine();

        string book = "Lorem";
        int chapter = 5;
        int startVerse = 6;
        int endVerse = 7;
        string text = "Lorem ipsum dolor sit lorem ipsum dolor sit.";



        while (CONTINUE == true)
        {
            Reference r1 = new Reference();
            {
                r1._book = book;
                r1._chapter = chapter;
                r1._startVerse = startVerse;
                r1._endVerse = endVerse;
            }


            Scripture t1 = new Scripture(text);
            {
                t1.Display();
            }
            // {
            //     t1._scriptureText = text;
            // }
            Console.WriteLine("");
            string userContinue = Console.ReadLine();
            if (userContinue == "quit")
            {
                CONTINUE = false;
            }
        }
    }    
}