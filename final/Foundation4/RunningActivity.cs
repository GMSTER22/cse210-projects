public class RunningActivity : Activity
{
  private double _distance;

  public RunningActivity(double distance, double length) : base(length)
  {
    _distance = distance;
  }
  
  public override double GetDistance()
  {
    return _distance;
  }
  public override double GetSpeed()
  {
    double duration = GetLength();

    return (_distance / duration) * 60;
  }
  public override double GetPace()
  {
    double duration = GetLength();

    return duration / _distance;
  }
  public override string GetSummary()
  {
    DateTime date = GetDate();
    double duration = GetLength();
    double speed = Math.Round(GetSpeed(), 1);
    double pace = Math.Round(GetPace(), 1);

    return $"{date.ToShortDateString()} Running ({duration} min) - Distance {_distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
  }
}