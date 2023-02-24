public class BreathingActivity : Activity
{
  List<string> _messages;

  public BreathingActivity(string name, string description, List<string> messages) : base(name, description)
  {
    _messages = messages;
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
      Console.Write(_messages[0]);
      Countdown(4);
      Console.WriteLine();

      Console.Write(_messages[1]);
      Countdown(4);
      Console.WriteLine("\n");
    }

    Console.WriteLine("Well done!!");
    Spinner(3);

    Console.WriteLine($"\n{Farewell()}");
    Spinner(3);

  }
}