public class Shape
{
    protected string _color = "";
    public Shape()
    {
        Console.WriteLine("What is the color of your shape?");
        Console.Write(">");
        _color = Console.ReadLine();
        Console.WriteLine();
    }
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor()
    {

    }
    virtual public double GetArea()
    {
        return 0;
    }
}