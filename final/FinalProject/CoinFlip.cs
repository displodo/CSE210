public class CoinFlip: Dice
{
    private List<string> _coinAnimation = new List<string>{"heads", "tails"};

    public CoinFlip(int sides): base(sides)
    {

        {
            DisplayAnimation();
            Console.Write($"Result: {_coinAnimation[Roll()]}");
        }
        Console.ReadLine();
        Console.WriteLine();
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
}
