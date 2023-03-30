public class CoinFlip: Dice
{
    private List<string> _coinAnimation = new List<string>{"heads", "tails"};
    private List<string> _coinResults = new List<string>();

    public CoinFlip(int sides, int numberDice): base(sides, numberDice)
    {
        foreach (var die in Enumerable.Range(0, _numberDice))
        {
            DisplayAnimation();
            string roll = _coinAnimation[Roll()];
            Console.WriteLine($"Result{die+1}: {roll}");
            _coinResults.Add(roll);
        }
        EndMessage();
    }
    public override void DisplayAnimation()
    {
        foreach (var i in Enumerable.Range(0,5))
            {
                foreach(var x in _coinAnimation)
                {
                    Console.Write(x);
                    Thread.Sleep(500);
                    Console.Write("\b \b"); 
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                }
            }
    }
    public override void EndMessage()
    {
        foreach (var roll in _coinResults)
        {
            Console.Write($"{roll}, ");
        }
        Console.Write("\b \b");
        Console.WriteLine("\b \b");
        Console.WriteLine("Hit Enter to return to menu:");
        Console.Write(">");
        Console.ReadLine();
        Console.WriteLine();
    }
}
