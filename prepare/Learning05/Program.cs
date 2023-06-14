using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square small = new Square("red",4);
        Rectangle bigger = new Rectangle("Pink", 5, 10);
        Circle round = new Circle("blue", 5);
        shapes.Add(small);
        shapes.Add(bigger);
        shapes.Add(round);

        foreach(Shape shape in shapes)
        {
        string color = shape.GetColor();
        double area = shape.GetArea();
        Console.WriteLine(color);
        Console.WriteLine(area);
        }
    }
}