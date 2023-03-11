using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        EternalQuest eternalQuest = new EternalQuest();
        int userChoice = -1;
        // List<Goal> goalsList = new List<Goal>();
        // int totalPoints = 0;

        while (userChoice != 6)
        {
            eternalQuest.DisplayMenu();

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                eternalQuest.DisplayGoals();

                int goalChoice = int.Parse(Console.ReadLine());

                if (goalChoice == 1)
                {
                    eternalQuest.RegisterSimpleGoal();
                }
                else if (goalChoice == 2)
                {
                    eternalQuest.RegisterEternalGoal();
                }
                else if (goalChoice == 3)
                {
                    eternalQuest.RegisterChecklistGoal();
                }
            }
            else if (userChoice == 2)
            {
                eternalQuest.ListGoals();
            }
            else if (userChoice == 3)
            {
                eternalQuest.SaveGoals();
            }
            else if (userChoice == 4)
            {
                eternalQuest.LoadGoals();
            }
            else if (userChoice == 5)
            {
                eternalQuest.RecordEvent();
            }
        }
    }
}