using System;

class Program
{
    static void Main(string[] args)
    {

        string givenScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        string[] givenScriptureArray = givenScripture.Split(" ");

        string givenBook = "Proverbs";
        int givenChapter = 3;
        int startVerse = 5;
        int finalVerse = 6;

        Reference reference = new Reference(givenBook, givenChapter, startVerse, finalVerse);

        List<Word> scriptureListWords = new List<Word>();

        foreach(string word in givenScriptureArray)
        {
            scriptureListWords.Add(new Word(word));
        }

        Scripture scripture = new Scripture(reference, scriptureListWords);

        string userInput = "";
        int frequency = 0;

        Console.WriteLine("");
        Console.Write("This is a memorizer game. How many words do you want to hide at a time (the default is 3 words.)? ");

        try
        {
            frequency = int.Parse(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        while (userInput != "quit")
        {

            Console.Clear();

            scripture.Display();

            Console.WriteLine("\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                scripture.HideWords(frequency);
            }

        }

        Console.WriteLine("Thanks for using the scripture memorizer.");

    }
}