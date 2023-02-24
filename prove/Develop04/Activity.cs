public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  public string Greeting()
  {
    return $"Welcome to the {_name}.";
  }

  public string Farewell()
  {
    return $"You have completed another {_duration} seconds of the {_name}.";
  }

  public void SetDuration(int duration)
  {
    _duration = duration;
  }
  public int GetDuration()
  {
    return _duration;
  }
  public string GetDescription()
  {
    return _description;
  }

  public void Spinner(int time)
  {
    List<string> animationStrings = new List<string>{
      "|", "/", "-", "\\"
    };

    int i = 0;

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(time);

    while (DateTime.Now < futureTime)
    {
      Console.Write(animationStrings[i]);
      Thread.Sleep(250);
      Console.Write("\b \b");

      i++;

      if (i >= animationStrings.Count)
      {
        i = 0;
      }

    }

  }

  public void Countdown(int time)
  {
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(time);

    int i = time;

    while (DateTime.Now < futureTime && i != 0)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");

      i--;
    }
  }
}