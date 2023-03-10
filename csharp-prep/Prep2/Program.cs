using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your percentage grade: ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        int remainder = grade % 10;

        if (remainder < 3)
        {
            if (letter != "F") {
                sign = "-";
            }
        }
        else if (remainder >= 7)
        {
            if (letter != "A" && letter != "F")
            {
                sign = "+";
            }
        }

        Console.WriteLine($"{letter}{sign}");

        if (grade >= 70) {
            Console.WriteLine("Congratulations, you passed the class");
        } else {
            Console.WriteLine("You still have a chance to pass it next year.");
        }
    }
}