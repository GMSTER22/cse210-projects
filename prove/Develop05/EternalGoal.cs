public class EternalGoal : Goal
{
  public EternalGoal( string name, string description, int pointsToGain ) : base( name, description, pointsToGain )
  {

  }

  // public int GetTotalPoints()
  // {
  //   return _totalPoints;
  // }
  public override void RecordEvent()
  {
    Console.WriteLine($"Congratulations! You have earned {_pointsToGain} points!");
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