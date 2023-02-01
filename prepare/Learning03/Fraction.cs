class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    int GetTop()
    {
        return _top;
    }
    void SetTop(int top)
    {
        _top = top;
    }
    int GetBottom()
    {
        return _bottom;
    }
    void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fractionString = ($"{_top}/{_bottom}");
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decimalValue = (Convert.ToDouble(_top) / Convert.ToDouble(_bottom));
        return decimalValue;
    }

    public static Fraction GetUserInput()
    {
        Console.Write("What is the fraction?: ");
        string fractionInput = Console.ReadLine();
        Fraction newFraction = new Fraction();
        try
        {
            string[] input = fractionInput.Split("/");
            int top = int.Parse(input[0]);
            int bottom = int.Parse(input[1]);
            newFraction = new Fraction(top, bottom);
        }
        catch 
        {
            int wholeNumber = int.Parse(fractionInput);
            newFraction = new Fraction(wholeNumber);
        }
        return(newFraction);
    }
}