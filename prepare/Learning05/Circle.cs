class Circle: Shape
{
    private double _radius = 0;
    public Circle()
    {
        Console.WriteLine("What is the radius of the circle?");
        Console.Write(">");
        _radius = Double.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public Circle(string color, double radius): base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return(3.14 * (_radius * _radius));
    }
}