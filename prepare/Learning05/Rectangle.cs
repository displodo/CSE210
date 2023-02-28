class Rectangle: Shape
{
    private double _length = 0;
    private double _width = 0;
    public Rectangle()
    {
        Console.WriteLine("What is the length of the rectangle?");
        Console.Write(">");
        _length = Double.Parse(Console.ReadLine());
        Console.WriteLine("What is the width of the rectangle?");
        Console.Write(">");
        _width = Double.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public Rectangle(string color, double length, double width): base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return(_length * _width);
    }
}