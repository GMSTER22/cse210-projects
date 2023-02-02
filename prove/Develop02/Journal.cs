using System.IO;

public class Journal
{

  public List<string> _promptList = new List<string>{

    "How did you sleep yesterday?",

    "How motivated are you?",

    "What is your main focus today?",

    "Are you glad it's a new day?",

    "List three things you are grateful for today.",

    "What was your biggest challenge today?",

    "What goal are you working towards?",

    "Did you get any closer to your goal today?",

    "What is one thing you can do to improve your life?",

    "Did you pray today? Why?",

    "How do you feel your relationship with God?"

  };
  public List<Entry> _entryList = new List<Entry>();

  public void AddEntry( Entry newEntry )
  {

    _entryList.Add( newEntry );

  }

  public string GeneratePrompt()
  {

    int promptListLength = _promptList.Count;

    Random rnd = new Random();

    int random = rnd.Next( 0, promptListLength );

    return _promptList[ random ];

  }

  public void Save( string filename ) 
  {

    using ( StreamWriter outputFile = new StreamWriter(filename) )
    {

      foreach ( Entry currentEntry in _entryList)
      {
        outputFile.WriteLine(currentEntry.GetEntry());
      }
    }

    Console.WriteLine($"{filename} was saved.");

  }
  public void Load( string filename )
  {
    string[] lines = System.IO.File.ReadAllLines( filename );

    foreach (string line in lines)
    {
      string[] returnedEntry = line.Split("##");
      DateTime returnedDate = DateTime.Parse(returnedEntry[0]);
      string returnedPrompt = returnedEntry[1];
      string returnedResponse = returnedEntry[2];

      Entry newEntry = new Entry( returnedDate, returnedPrompt, returnedResponse );

      _entryList.Add(newEntry);

    }
  }

  public void Display()
  {

    foreach (Entry currentEntry in _entryList)
    {
      
      currentEntry.Display();
      Console.WriteLine( "\n" );

    }

  }

}