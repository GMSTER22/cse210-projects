using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(3, "red");
        Rectangle rectangle = new Rectangle(5, 5, "blue");
        Circle circle = new Circle(6, "yellow");

        List<Shape> shapes = new List<Shape>();        
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}