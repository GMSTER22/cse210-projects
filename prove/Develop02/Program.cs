using System;

class Program
{
    static void Main(string[] args)
    {
        
        int programStatus = -1;

        List<string> menu = new List<string>{

            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
            
        };

        while ( programStatus != 5 )
        {

            foreach ( string menuItem in menu )
            {

                Console.WriteLine( menuItem );

            }

            Console.WriteLine( "What would you like to do?" );
            int userChoice = int.Parse( Console.ReadLine() );

            programStatus = userChoice;

        }

    }
}