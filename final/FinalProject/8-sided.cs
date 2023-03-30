public class D8: Dice
{
    public D8(int diceSides, int numberDice): base(diceSides, numberDice)
    {
        SetAnimation();
        foreach (var die in Enumerable.Range(0, _numberDice))
        {
            DisplayAnimation();
            Console.WriteLine($"Result{die+1}: {_animation[Roll()]}");
        }
        EndMessage();
    }
}