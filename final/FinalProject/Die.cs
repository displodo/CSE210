public class Dice
{
    protected int _numberDice = 0;
    protected int _diceSides = 0;
    protected List<int> _animation = new List<int>();
    public Dice(int diceSides)
    {
        _diceSides = diceSides;
    }
    public Dice(int diceSides, int numberDice)
    {
        _diceSides = diceSides;
        _numberDice = numberDice;
    }
    public int Roll()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _diceSides);
        return randomIndex;
    }
    public virtual void DisplayAnimation()
    {
        var random = new Random();  
        foreach (var i in Enumerable.Range(0,5))
            {
                foreach(var x in _animation)
                {
                    Console.Write(_animation[random.Next(0, _animation.Count())]);
                    Thread.Sleep(500);
                    Console.Write("\b \b"); 
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                }
            }
    }
    public virtual void SetAnimation()
    {
        var random = new Random();
        foreach(var num in Enumerable.Range(1, _diceSides))
        {
            _animation.Add(num);
        }
    }
}