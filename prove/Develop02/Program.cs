using System;

class Program
{
    static void Main(string[] args)
    {
        
        int programStatus = -1;

        Journal journal = new Journal();

        List<string> menu = new List<string>{

            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
            
        };

        while ( programStatus != 5 )
        {

            Console.WriteLine( "Please select one of the following" );
            
            foreach ( string menuItem in menu )
            {

                Console.WriteLine( menuItem );

            }

            Console.Write( "\nWhat would you like to do? " );
            int userChoice = int.Parse( Console.ReadLine() );

            if ( userChoice == 1 ) {

                string prompt = journal.GeneratePrompt();

                Console.WriteLine( prompt );

                string response = Console.ReadLine();

                DateTime currentDate = DateTime.Now;

                Entry newEntry = new Entry( currentDate, prompt, response );

                journal.AddEntry( newEntry );

            } else if ( userChoice == 2 ) {

                if ( journal._entryList.Count == 0 ) {

                    Console.WriteLine( "The entry list is empty" );

                } else {

                    journal.Display();

                }

            } else if ( userChoice == 3 ) {

                Console.WriteLine( "What is the filename?" );
                string filename = Console.ReadLine();

                bool isFileExist = File.Exists( filename );

                if ( isFileExist ) {

                    journal.Load( filename );

                    Console.WriteLine( "File was loaded. You can now display it." );

                } else {

                    string currentDirectory = System.Environment.CurrentDirectory;

                    string[] files = Directory.GetFiles( currentDirectory, "*.txt" );

                    Console.WriteLine( $"Sorry, but the file \"{filename}\" doesn't exist." );

                    if ( files.Count() == 0 ) {

                        Console.WriteLine( "Your folder is empty." );

                    } else {

                        foreach (string file in files)
                        {

                            Console.WriteLine( "Here is the list of existing files." );                            
                            Console.WriteLine( $"   =====> {Path.GetFileName(file)}" );

                        }

                    }

                }

            } else if ( userChoice == 4 ) {

                if (journal._entryList.Count == 0) {

                    Console.WriteLine("The entry list is empty, please write something to save. Thanks");

                } else {

                    Console.WriteLine( "What is the filename?" );
                    string filename = Console.ReadLine();

                    journal.Save( filename );

                }

            } else if ( userChoice == 5 ) {

                Console.WriteLine("Good Bye");

            } else {

                Console.WriteLine($"Sorry, \"{userChoice}\" is not an option.");

                Console.WriteLine("Please enter 5 if you want to Quit, otherwise.");

                Console.WriteLine("Enter either 1, 2, 3 or 4.");

            }

            programStatus = userChoice;

            Console.WriteLine( "\n\n" );

        }

    }
}