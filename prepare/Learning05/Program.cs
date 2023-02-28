using System;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>();
        var circle = new Circle("blue", 5);
        var rectangle = new Rectangle("orange", 3, 6);
        var square = new Square("red", 7);
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);
        foreach(var s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
            Console.WriteLine();
        }
    }
}