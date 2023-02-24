public class ReflectingActivity : Activity
{
  List<string> _prompts = new List<string>{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };
  List<string> _questions = new List<string>{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  public ReflectingActivity(string name, string description) : base(name, description)
  {
    
  }

  public string GetRandomQuestion()
  {
    Random rnd = new Random();
    int questionIndex = rnd.Next(_questions.Count - 1);
    return _questions[questionIndex];
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
      Console.WriteLine("Consider the following prompt:\n");

      Console.WriteLine($"--- {GetRandomPrompt()} ---\n");

      Console.WriteLine("When you have something in mind, press enter to continue.");
      Console.ReadLine();

      Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
      Console.Write("You may begin in: ");
      Countdown(4);

      Console.Clear();
      while (DateTime.Now < endTime)
      {
        Console.Write($"> {GetRandomQuestion()} ");
        Spinner(5);
        Console.WriteLine();
      }
    }

    Console.WriteLine("\nWell done!!");
    Spinner(3);

    Console.WriteLine($"\n{Farewell()}");
    Spinner(5);

  }
}