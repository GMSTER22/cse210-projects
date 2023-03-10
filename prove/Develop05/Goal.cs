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
}