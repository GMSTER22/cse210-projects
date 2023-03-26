public class CyclingActivity : Activity
{
  private double _speed;

  public CyclingActivity(double speed, double length) : base(length)
  {
    _speed = speed;
  }
  
  public override double GetDistance()
  {
    double duration = GetLength();

    return (_speed * duration) / 60;
  }
  public override double GetSpeed()
  {
    return _speed;
  }
  public override double GetPace()
  {
    return 60 / _speed;
  }
  public override string GetSummary()
  {
    DateTime date = GetDate();
    double duration = GetLength();
    double distance = Math.Round(GetDistance(), 1);
    double pace = Math.Round(GetPace(), 1);

    return $"{date.ToShortDateString()} Cycling ({GetLength()} min) - Distance {distance} miles, Speed {_speed} mph, Pace: {pace} min per mile";
  }
}