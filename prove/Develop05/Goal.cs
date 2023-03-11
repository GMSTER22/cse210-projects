public abstract class Goal
{
  protected string _name;
  protected string _description;
  protected int _pointsToGain;

  public Goal( string name, string description, int pointsToGain )
  {
    _name = name;
    _description = description;
    _pointsToGain = pointsToGain;
  }

  public abstract void RecordEvent();
  public abstract bool IsCompleted();
  public abstract string GetGoal();

  public string GetName()
  {
    return _name;
  }
  public string GetDescription()
  {
    return _description;
  }
  public int GetPoints()
  {
    return _pointsToGain;
  }
  public int GetPointsToGain()
  {
    return _pointsToGain;
  }

  public void AnimateWord(string stringToAnimate, string separator = "*")
  {
    string[] words = stringToAnimate.Split(" ");

    foreach (string word in words)
    {
      for (int i = 0; i < word.Count(); i++)
      {
        Thread.Sleep(100);
        if (i > 0)
        {
          Console.Write($"{separator}");
        }
        Console.Write($"{word[i]}");
      }
      Console.Write(" ");
    }


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
      Thread.Sleep(200);
      Console.Write("\b \b");

      i++;

      if (i >= animationStrings.Count)
      {
        i = 0;
      }

    }

  }
}