public class SwimmingActivity : Activity
{
  private double _numberOfLaps;

  public SwimmingActivity(double numberOfLaps, double length) : base(length)
  {
    _numberOfLaps = numberOfLaps;
  }
  
  public override double GetDistance()
  {
    return _numberOfLaps * 50 / 1000 * 0.62;
  }
  public override double GetSpeed()
  {
    double distance = GetDistance();
    double duration = GetLength();

    return (distance / duration) * 60;
  }
  public override double GetPace()
  {
    double speed = GetSpeed();

    return 60 / speed;
  }
  public override string GetSummary()
  {
    DateTime date = GetDate();
    double duration = GetLength();
    double distance = Math.Round(GetDistance(), 1);
    double speed = Math.Round(GetSpeed(), 1);
    double pace = Math.Round(GetPace(), 1);

    return $"{date.ToShortDateString()} Swimming ({duration} min) - Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
  }
}