using System;

class Program
{
    static void Main(string[] args)
    {

        int GetMenu()
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            Console.Write("> ");
            string userInput = Console.ReadLine();
            int choice = Int32.Parse(userInput);
            return choice;
            
        }

        // Console.WriteLine("Welcome to the Journal Program!");
        // Console.WriteLine("Please select one of the following choices:");
        // Console.WriteLine("1. Write");
        // Console.WriteLine("2. Display");
        // Console.WriteLine("3. Load");
        // Console.WriteLine("4. Save");
        // Console.WriteLine("5. Quit");
        // Console.WriteLine("What would you like to do?"); // Change to 'Console.Write' when done.Or Delete block?

        // List<string> entriesList = new List<string>();

        int choice = GetMenu();

        while (choice < 5)
        {
            if (choice == 1)
            {
                Journal newJournal = new Journal();
                {   
                    newJournal.AddEntry();
                    GetMenu();
                }
            }
            else if (choice == 2)
            {
                Journal newDisplay = new Journal();
                {
                    // newDisplay.Display();
                    newDisplay.Display();
                    GetMenu();
                }
            }
        }
        // Entry newEntry = new Entry();
        // {
        //     newEntry.GetEntry();
        // }
        // string userChoice = Console.ReadLine();

        // if (userChoice == "1")
        // {
        // }
        // else if (userChoice == "2")
        // {

        // }
        // else if (userChoice == "3")
        // {

        // }
        // else if (userChoice == "4")
        // {
            
        // }
        // else if (userChoice == "5")
        // {
        //     // Simply a placeholder
        // }
        // else
        // {
        //     Console.WriteLine("Invalid entry, please try again");
        // }
        

        
        
    }
}