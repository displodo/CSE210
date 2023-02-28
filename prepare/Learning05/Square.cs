class Square: Shape
{
    private double _side = 0;
    public Square()
    {
        Console.WriteLine("What is the length of a side of your square?");
        Console.Write(">");
        _side = Double.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public Square(string color, double side): base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return(_side * _side);
    }
}