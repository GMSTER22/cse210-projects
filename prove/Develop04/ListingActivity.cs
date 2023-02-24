public class ListingActivity : Activity
{
  List<string> _prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };
  List<string> _answers = new List<string>();

  public ListingActivity(string name, string description) : base(name, description)
  {
    
  }

  public string GetRandomPrompt()
  {
    Random rnd = new Random();
    int promptIndex = rnd.Next(_prompts.Count - 1);
    return _prompts[promptIndex];
  }

  public void StartActivity()
  {
    Console.WriteLine($"{Greeting()}\n");
    
    Console.WriteLine($"{GetDescription()}\n");

    Console.Write("How long, in seconds, would you like for your session? " );
    SetDuration(int.Parse(Console.ReadLine()));

    Console.Clear();

    Console.WriteLine("Get ready...");
    Spinner(2);
    Console.WriteLine();

    int activityDuration = GetDuration();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(activityDuration);

    while (DateTime.Now < endTime)
    {
      Console.WriteLine("List as many responses you can to the following prompt:\n");

      Console.WriteLine($"--- {GetRandomPrompt()} ---\n");

      Console.Write("You may begin in: ");
      Countdown(4);
      Console.WriteLine();

      while (DateTime.Now < endTime)
      {
        Console.Write("> ");
        _answers.Add(Console.ReadLine());
      }
    }
    Console.WriteLine($"You listed {_answers.Count} items!");

    Console.WriteLine("\nWell done!!");
    Spinner(5);
    
    Console.WriteLine($"\n{Farewell()}");  
    Spinner(5);  

  }
}