using System;
using static System.Console;

class Program
{

    static void Main(string[] args)
    {   
        List<string> goals = new List<string>();
        int count = 0;

        string MainMenu()
        {
            WriteLine("Menu Options:");
            WriteLine("    1. Create New Goal");
            WriteLine("    2. List Goals");
            WriteLine("    3. Save Goals");
            WriteLine("    4. Load Goals");
            WriteLine("    5. Record Event");
            WriteLine("    6. Quit");
            Write("Select a choice from the menu: ");
            return ReadLine();
        }

        string GoalMenu()
        {
            WriteLine("The types of goals are:");
            WriteLine("    1. Simple Goal");
            WriteLine("    2. Eternal Goal");
            WriteLine("    3. Checklist Goal");
            Write("Which type of goal would you like to create? ");
            return ReadLine();
        }
        
        string start = MainMenu();

        while (start != "6")
        {
            if (start == "1")
            {

                string goalOption = GoalMenu();

                    WriteLine("Name:");
                    string name = ReadLine();

                    WriteLine("Description:");
                    string description = ReadLine();

                    WriteLine("Point Value:");
                    string userPointValue = ReadLine();
                    int pointValue = Int32.Parse(userPointValue);
                    // start = MainMenu();

                if (goalOption == "1")
                {
                    SimpleGoal sGoal = new SimpleGoal(name, description, pointValue);
                    {
                        string newGoal = sGoal.GetGoal();
                        
                        sGoal.AddToList(goals, newGoal);
                        start = MainMenu();
                    }
                }

                else if (goalOption == "2")
                {
                    EternalGoal eGoal = new EternalGoal(name, description, pointValue);
                    {
                        string newGoal = eGoal.GetGoal();
                        eGoal.AddToList(goals, newGoal);
                        start = MainMenu(); 
                    }
                }

                else if (goalOption == "3") //TODO Add Bonus
                {
                    WriteLine("How many times does this need to be accomplished for a bonus?");
                    string userGoalAmount = ReadLine();
                    int goalAmount = Int32.Parse(userGoalAmount);
                    CheckListGoal clGoal = new CheckListGoal(name, description, pointValue, goalAmount);
                    {
                        string newGoal = clGoal.GetGoal();
                        clGoal.AddToList(goals, newGoal);
                        start = MainMenu();
                    }
                }
            }

            if (start == "2")
            {   
                foreach (string i in goals) //!
                {
                    WriteLine();
                    string[] parts = i.Split(",");
                    string newString = parts[0];
                    int lastSpaceIndex = newString.LastIndexOf("|");
                    string typeHidden = newString.Substring(0, lastSpaceIndex);
                    //// int newLastSpaceIndex = typeHidden.LastIndexOf(" ");
                    //// string pointsHidden = typeHidden.Substring(0, newLastSpaceIndex);

                    Console.WriteLine(typeHidden);
                }
                WriteLine();
                start = MainMenu();    
            }

            if (start == "3")
            {
                Write("Filename: ");
                string filename = ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (string i in goals)
                    outputFile.WriteLine(i + ",");
                }
                WriteLine();
                start = MainMenu();
            }

            if (start == "4")
            {
                WriteLine("Enter Filename: ");
                string fileName = ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                WriteLine();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string completed = parts[0];
                    int lastSpaceIndex = completed.LastIndexOf("|");
                    string typeHidden = completed.Substring(0, lastSpaceIndex);
                    //// int newLastSpaceIndex = typeHidden.LastIndexOf(" ");
                    //// string pointsHidden = typeHidden.Substring(0, newLastSpaceIndex);
                    goals.Add(completed);
                    //// string[] hidePoints = completed.Split("|");
                    //// string last = parts.Last();
                    WriteLine(typeHidden);
                    WriteLine();
                }
                start = MainMenu();
            }

            if (start == "5")
            {
                Write("Which goal did you accomplish?: ");
                string userInput = ReadLine();
                int userChoice = Int32.Parse(userInput);
                string goalCompleted = goals[(userChoice - 1)]; //! Goal Selected
                int goalType = goalCompleted.LastIndexOf(" " + 1);
                int goalPoints = goalCompleted[goalCompleted.LastIndexOf(" ") - 1];
                if (goalType == 1) //! For Simple Goal
                {
                    string result = goalCompleted.Replace("_", "X"); //TODO Does NOT WORK
                    goals[(userChoice - 1)] = result;
                    count += goalPoints;
                }
                else if (goalType == 2) //! For Eternal Goal
                {
                    count += goalPoints;
                }
                else if (goalType == 3) //! For Checklist Goal
                {
                    int currentIndex = goalCompleted.LastIndexOf("- ") - 1;
                    int currentAmount = goalCompleted[currentIndex];
                    int goalIndex = goalCompleted.LastIndexOf("/") + 1;
                    int goalAmount = goalCompleted[goalIndex];
                    if (currentAmount >= goalAmount)
                    {
                        goalCompleted = goalCompleted.Replace("_", "X"); //TODO Does NOT WORK
                        string result = goalCompleted.Substring(0, currentIndex) + goalAmount + goalCompleted.Substring(currentIndex + 1);
                        goals[(userChoice - 1)] = result;
                    }
                    else
                    {
                        string result = goalCompleted.Substring(0, currentIndex) + (currentAmount + 1) + goalCompleted.Substring(currentIndex + 1);
                        goals[(userChoice - 1)] = result;
                        count += goalPoints;
                    }
                }
                WriteLine();
                start = MainMenu();
            }

            // else
            // {
            //     WriteLine("Sorry that is an invalid answer. Please try again.");
            //     start = MainMenu();
            // }

            
        }


    //     MainMenu();

    //     if (MainMenu() == "1")
    //     {
    //         string goalType = GoalMenu();
    //         Write("What is the name of your goal? ");
    //         string goalName = ReadLine();
    //         Write("What is a short description of it? ");
    //         string goalDescription = ReadLine();
    //         Write("What is the amount of points associated with this goal? ");
    //         string userPoint = ReadLine();
    //         int pointValue = Int32.Parse(userPoint);

    //         if (goalType == "1")
    //         {
    //             Goal g1 = new SimpleGoal(goalName, goalDescription, pointValue);
    //             {

    //             }
    //         }
            

    //         //! To Write new "Goal"
    //         //TODO Has own MainMenu in base class 'Goal"
    //         //*Select a choice from the MainMenu: 
    //         //*1. Simple Goal
    //         //*2. Eternal Goal
    //         //*3. Checklist Goal
    //         //*Which type of goal would you like to create?
    //         //TODO Create 'Goal' base class, identify common attributes, set attributes and behaviors
    //         //TODO Add child classes attributes and behaviors
    //     }
    //     else if (MainMenu() == "2")
    //     {
    //         //! To display list of 'Goals', shows in '[ ]' if completed or not ex: [ ] Give a talk (In sacrament)
    //     }
    //     else if (MainMenu() == "3")
    //     {
    //         //! SAVES goals to a .txt file with filename of user's choice
    //         //? How to create open & write .txt with C#
    //     }
    //     else if (MainMenu() == "4")
    //     {
    //         //! GETS .txt file / still requires List Mainmenu option to list them out
    //     }
    }

    
}