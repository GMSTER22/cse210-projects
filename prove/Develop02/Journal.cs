public class Journal
{

  public List<string> _promptList = new List<string>{

    "Who was the most interesting person I interacted with today?",

    "What was the best part of my day?",

    "How did I see the hand of the Lord in my life today?",

    "What was the strongest emotion I felt today?",

    "If I had one thing I could do over today, what would it be?"

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

    return _promptList[ promptListLength ];

  }

  public void Load() {}
  public void Save() {}

  public void Display()
  {

    foreach (Entry currentEntry in _entryList)
    {
      
      currentEntry.Display();

    }

  }

}