using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>{
            new RunningActivity(3, 30),
            new CyclingActivity(15, 45),
            new SwimmingActivity(10, 10)
        };

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}