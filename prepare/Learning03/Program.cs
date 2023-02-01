using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Fraction = Fraction.GetUserInput();
        Console.WriteLine(Fraction.GetFractionString());
        Console.WriteLine(Fraction.GetDecimalValue());
    }       
}
