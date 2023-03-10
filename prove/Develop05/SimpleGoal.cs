public class SimpleGoal : Goal
{

  private bool _isCompleted = false;

  public SimpleGoal( string name, string description, int pointsToGain ) : base( name, description, pointsToGain )
  {

  }

  public void SetIsCompleted(bool isCompleted)
  {
    _isCompleted = isCompleted;
  }
  public override void RecordEvent()
  {
    _isCompleted = true;
    Console.WriteLine($"Congratulations! You have earned {_pointsToGain} points!");
  }
  public override bool IsCompleted()
  {
    return _isCompleted;
  }

  public override string GetGoal()
  {
    bool isCompleted = IsCompleted(); 

    string isChecked = isCompleted ? "[X]" : "[ ]";

    return $"{isChecked} {_name} ({_description})";
  }
}