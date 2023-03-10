using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;
        List<Goal> goalsList = new List<Goal>();
        int totalPoints = 0;

        while (userChoice != 6)
        {
            DisplayMenu(goalsList, totalPoints);

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                DisplayGoals();

                int goalChoice = int.Parse(Console.ReadLine());

                if (goalChoice == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Goal newSimpleGoal = new SimpleGoal(name, description, points);
                    goalsList.Add(newSimpleGoal);
                }
                else if (goalChoice == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Goal newEternalGoal = new EternalGoal(name, description, points);
                    goalsList.Add(newEternalGoal);
                }
                else if (goalChoice == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int timesToCompletion = int.Parse(Console.ReadLine());
                    
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    Goal newChecklistGoal = new ChecklistGoal(name, description, points, timesToCompletion, bonusPoints);
                    goalsList.Add(newChecklistGoal);
                }
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("List goals:");
                
                if (goalsList.Count > 0)
                {
                    Console.Clear();
                    for (int i = 0; i < goalsList.Count; i++)
                    {
                        Goal currentGoal = goalsList[i];
                        Console.WriteLine($"{i + 1}. {currentGoal.GetGoal()}");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You currently don't have any goal.\n");
                }
            }
            else if (userChoice == 3)
            {   
                // int totalPoints = 0;

                // foreach (Goal goal in goalsList)
                // {
                //     totalPoints += goal.GetTotalPoints();
                // }

                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(totalPoints);

                    for (int i = 0; i < goalsList.Count; i++)
                    {
                        Type goalType = goalsList[i].GetType();

                        if (goalType.ToString() == "SimpleGoal")
                        {
                            Goal goal = goalsList[i];
                            outputFile.WriteLine($"{goal.GetType()}:##{goal.GetName()}##{goal.GetDescription()}##{goal.GetPointsToGain()}##{goal.IsCompleted()}");
                        }
                        else if (goalType.ToString() == "EternalGoal")
                        {
                            Goal goal = goalsList[i];
                            outputFile.WriteLine($"{goal.GetType()}:##{goal.GetName()}##{goal.GetDescription()}##{goal.GetPointsToGain()}");
                        }
                        else if (goalType.ToString() == "ChecklistGoal")
                        {
                            ChecklistGoal goal = (ChecklistGoal)goalsList[i];
                            outputFile.WriteLine($"{goal.GetType()}:##{goal.GetName()}##{goal.GetDescription()}##{goal.GetPointsToGain()}##{goal.GetBonusPoints()}##{goal.GetTimesToCompletion()}##{goal.GetTimeCompleted()}");
                        }
                    }
                }
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);
                totalPoints += int.Parse(lines[0]);

                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] parts = lines[i].Split("##");
                    string goalClassName = parts[0].Substring(0, parts[0].Count() - 1);
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (goalClassName == "SimpleGoal")
                    {
                        bool isCompleted = bool.Parse(parts[4].ToLower());
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        simpleGoal.SetIsCompleted(isCompleted);
                        goalsList.Add(simpleGoal);
                    }
                    else if (goalClassName == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        goalsList.Add(eternalGoal);
                    }
                    else if (goalClassName == "ChecklistGoal")
                    {
                        int bonusPoints = int.Parse(parts[4]);
                        int timesToCompletion = int.Parse(parts[5]);
                        int timesCompleted = int.Parse(parts[6]);

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, timesToCompletion, bonusPoints);
                        checklistGoal.SetTimesCompleted(timesCompleted);
                        goalsList.Add(checklistGoal);
                    }
                }
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("The goals are:\n");

                for (int i = 0; i < goalsList.Count; i++)
                {
                    string goalName = goalsList[i].GetName();
                    Console.WriteLine($"{i + 1}. {goalName}");
                }

                Console.Write("Which goal did you accomplish today? ");
                int goalAccomplishedNumber = int.Parse(Console.ReadLine());

                Goal goalAccomplished = goalsList[goalAccomplishedNumber - 1];
                bool isGoalCompleted = goalAccomplished.IsCompleted();
                string goalType = goalAccomplished.GetType().ToString();

                if (isGoalCompleted)
                {
                    return;
                }
                else
                {              
                    if (goalType == "SimpleGoal" || goalType == "EternalGoal")
                    {
                        totalPoints += goalAccomplished.GetPointsToGain();
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goalAccomplished;
                        if (checklistGoal.GetTimesToCompletion() - checklistGoal.GetTimeCompleted() == 1)
                        {
                            totalPoints += goalAccomplished.GetPointsToGain() + checklistGoal.GetBonusPoints();
                        }
                        else
                        {
                            totalPoints += goalAccomplished.GetPointsToGain();
                        }
                    }

                    goalAccomplished.RecordEvent(); 
                }

                Console.WriteLine($"You now have {totalPoints} points.\n");
            }
        }
    }

    static void DisplayMenu(List<Goal> goals, int totalPoints)
    {
        // int totalPoints = 0;

        // foreach (Goal goal in goals)
        // {
        //     totalPoints += goal.GetTotalPoints();
        // }

        Console.WriteLine($"\nYou have {totalPoints} points.\n");

        List<string> menuList = new List<string>(){
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        Console.WriteLine("Menu Options:");

        foreach (string menuItem in menuList)
        {
            Console.WriteLine($"   {menuItem}");
        }

        Console.Write("Select a choice from the menu: ");
    }

    static void DisplayGoals()
    {
        List<string> goalList = new List<string>(){
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };

        Console.WriteLine("The types of goals are:");

        foreach (string goal in goalList)
        {
            Console.WriteLine($"   {goal}");
        }

        Console.Write("Which type of goal would you like to create? ");
    }
}