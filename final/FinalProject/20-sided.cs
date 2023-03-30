public class D20: Dice
{
    public D20(int diceSides, int numberDice): base(diceSides, numberDice)
    {
        SetAnimation();
        foreach (var die in Enumerable.Range(0, _numberDice))
        {
            DisplayAnimation();
            int roll = _animation[Roll()];
            Console.WriteLine($"Result{die+1}: {roll}");
            _results.Add(roll);
        }
        EndMessage();
    }
}