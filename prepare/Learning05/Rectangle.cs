public class Rectangle : Shape
{

  private double _length;
  private double _width;

  public Rectangle(double width, double length, string color) : base(color)
  {
    _width = width;
    _length = length;
  }

  public override double GetArea()
  {
    return _width * _length;
  }

}