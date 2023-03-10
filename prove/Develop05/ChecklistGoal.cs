public class ChecklistGoal : Goal
{
  private int _timesCompleted = 0;
  private int _timesToCompletion;
  private int _bonusPoints;

  public ChecklistGoal( string name, string description, int pointsToGain, int timesToCompletion, int bonusPoints ) : base( name, description, pointsToGain )
  {
    _timesToCompletion = timesToCompletion;
    _bonusPoints = bonusPoints;
  }

 
  public int GetTimeCompleted()
  {
    return _timesCompleted;
  }
  public void SetTimesCompleted(int timesCompleted)
  {
    _timesCompleted = timesCompleted;
  }
  public int GetTimesToCompletion()
  {
    return _timesToCompletion;
  }
  public int GetBonusPoints()
  {
    return _bonusPoints;
  }
  public override void RecordEvent()
  {
    bool isCompleted = IsCompleted();

    if (isCompleted)
    {
      return;
    }
    else
    {
      _timesCompleted++;

      if (_timesCompleted == _timesToCompletion)
      {
        int points = _pointsToGain + _bonusPoints; 

        Console.WriteLine($"Congratulations! You have earned {points} points!");
      }
      else
      {
        Console.WriteLine($"Congratulations! You have earned {_pointsToGain} points!");
      }
    }
  }
  public override bool IsCompleted()
  {
    return _timesCompleted == _timesToCompletion;
  }

  public override string GetGoal()
  {
    bool isCompleted = IsCompleted();

    string isChecked = isCompleted ? "[X]" : "[ ]";

    return $"{isChecked} {_name} ({_description}) --- Currently completed: {_timesCompleted}/{_timesToCompletion}";
  }
}