using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.Write("What is the magic number? ");
        // string magicNumberInput = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberInput);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11); 

        int count = 0;

        int userGuess = -1;

        while ( userGuess != magicNumber ) 
        {            
            Console.Write("What is your guess? ");
            string userInputGuess = Console.ReadLine();
            userGuess = int.Parse(userInputGuess);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            } else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            count++;
        }

        Console.Write($"You guessed it in {count}!!!!");
    }
}