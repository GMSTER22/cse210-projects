using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menuList = new List<string>{
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit",
        };

        int userChoice = -1;

        while (userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");

            foreach (string menuItem in menuList)
            {
                Console.WriteLine($"  {menuItem}");
            }

            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (userChoice == 1)
            {
                string breathingActivityName = "Breathing Activity";

                string breathingActivityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

                List<string> breathingActivityMessages = new List<string>{"Breathe In...", "Now Breathe Out..."};

                BreathingActivity breathingActivity = new BreathingActivity(breathingActivityName, breathingActivityDescription, breathingActivityMessages);
                breathingActivity.StartActivity();
            }
            else if (userChoice == 2)
            {
                string reflectingActivityName = "Reflecting Activity";

                string reflectingActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity reflectionActivity = new ReflectingActivity(reflectingActivityName, reflectingActivityDescription);
                reflectionActivity.StartActivity();
            }
            else if (userChoice == 3 )
            {
                string listingActivityName = "Listing Activity";

                string listingActivityDescription = "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.";

                ListingActivity listingActivity = new ListingActivity(listingActivityName, listingActivityDescription);
                listingActivity.StartActivity();
            }
        }



        // Breathing Activity Section 

        // string breathingActivityName = "Breathing Activity";

        // string breathingActivityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

        // List<string> breathingActivityMessages = new List<string>{"Breathe In...", "Breathe Out..."};

        // BreathingActivity breathingActivity = new BreathingActivity(breathingActivityName, breathingActivityDescription, breathingActivityMessages);
        // breathingActivity.StartActivity();



        // Reflection Activity Section 

        // string reflectionActivityName = "Reflection Activity";

        // string reflectionActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        // ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionActivityName, reflectionActivityDescription);
        // reflectionActivity.StartActivity();



         // Listing Activity Section 

        // string listingActivityName = "Listing Activity";

        // string listingActivityDescription = "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.";

        // ListingActivity listingActivity = new ListingActivity(listingActivityName, listingActivityDescription);
        // listingActivity.StartActivity();
    }
}