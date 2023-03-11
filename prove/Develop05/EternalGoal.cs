public class EternalGoal : Goal
{
  public EternalGoal( string name, string description, int pointsToGain ) : base( name, description, pointsToGain )
  {

  }

  public override void RecordEvent()
  {
    Console.WriteLine($"Congratulations!!! You have earned {_pointsToGain} points!");
    Spinner(1);
  }
  public override bool IsCompleted()
  {
    return false;
  }

  public override string GetGoal()
  {
    return $"[ ] {_name} ({_description})";
  }
}