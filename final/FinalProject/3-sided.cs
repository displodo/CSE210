public class D3: Dice
{
    public D3(int diceSides): base(diceSides)
    {
        SetAnimation();
        DisplayAnimation();
        Console.Write($"Roll: {_animation[Roll()]}");
        Console.ReadLine();
        Console.WriteLine();
    }
}