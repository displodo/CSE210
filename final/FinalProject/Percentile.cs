public class Percentile: Dice
{
    public Percentile(int diceSides, int numberDice): base(diceSides, numberDice)
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
    public override void EndMessage()
    {
        Console.Write("Rolls: ");
        foreach (var roll in _results)
        {
            _combinedRolls += roll;
            Console.Write($"{roll}, ");
        }
        double average = Convert.ToDouble(_combinedRolls) / Convert.ToDouble(_results.Count());
        Console.Write("\b \b");
        Console.WriteLine("\b \b");
        Console.WriteLine($"Average: %{average}");
        Console.WriteLine("Hit Enter to return to menu:");
        Console.Write(">");
        Console.ReadLine();
        Console.WriteLine();
    }
}