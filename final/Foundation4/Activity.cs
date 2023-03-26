public abstract class Activity
{
  private DateTime _date;
  private double _length;

  public Activity(double length)
  {
    _length = length;
    _date = DateTime.Now;
  }

  public double GetLength()
  {
    return _length;
  }
  public DateTime GetDate()
  {
    return _date;
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();
  public abstract string GetSummary();
}