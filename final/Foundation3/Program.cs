using System;

class Program
{
    static void Main(string[] args)
    {
        
        LectureEvent lectureEvent = new LectureEvent("Andrew Huberman", 1500, "How to Build Lasting Health", "Discover hidden techniques on how to build a long lasting health", "3346 Dolfield Ave", "Baltimore", "Maryland", "USA", 2023, 04, 01, 12, 30);

        ReceptionEvent receptionEvent = new ReceptionEvent("info@recevent.com", "Principles for Dealing with the Changing World Order", "Learn more about the new changing world order and how to prepare for it", "38 S Carrollton Ave", "Baltimore", "Maryland", "USA", 2023, 05, 01, 12, 00);

        OutdoorEvent outdoorEvent = new OutdoorEvent("Cloudy", "Lear how to Learn, the Secrets of Learning New Skills", "Learning is a skill that a lot of people don't about, during this outdoor event you'll learn scientifically proven techniques on how to learn", "153 EdgeWood St", "Baltimore", "Maryland", "USA", 2023, 04, 15, 14, 30);

        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetShortDetails());
        Console.WriteLine();

        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDetails());
        Console.WriteLine();

        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDetails());
        Console.WriteLine();

    }
}