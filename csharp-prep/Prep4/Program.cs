using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int number = -1;

        List<int> numbersList = new List<int>();

        while ( number != 0 )
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();

            number = int.Parse(userInput);

            if (number != 0)
            {
                numbersList.Add(number);
            }
        }

        float maxNumber = numbersList[0];

        float total = 0;

        foreach (int num in numbersList)
        {
            if (num > maxNumber) 
            {
                maxNumber = num;
            }
            total = total + num;
        }

        float average = total/numbersList.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is: {maxNumber}");

    }
}