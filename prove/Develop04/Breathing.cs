class Breathing: Activity
{
    public Breathing(string title, int duration, string summary, string endMessage): base(title, duration, summary, endMessage)
    {
        Console.WriteLine($"Summary: {_summary}");
        Console.WriteLine();
        Console.WriteLine("Get ready");
        double myDouble = Convert.ToDouble(_duration);
        double iterations = (myDouble / 8);
        int range = (int)Math.Round(iterations);
        if(range > 0)
            {
                Pause(5);
                foreach(var i in Enumerable.Range(0, range))
                    {
                    Console.WriteLine();
                    Console.WriteLine("Breathe in...");
                    CountDown(4);
                    Console.WriteLine("Breate out...");
                    CountDown(4);
                }
                DisplayEndMessage();
            }
        else
        {
            Console.WriteLine("This activity requires at least 10 seconds.");
            Console.WriteLine("Hit enter to return to menu: ");
            Console.Read();
            Console.WriteLine();
        }
    }
}