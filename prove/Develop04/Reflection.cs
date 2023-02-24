class Reflection: Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _ponder = new List<string>();

    public Reflection(string title, int duration, string summary, string endMessage): base(title, duration, summary, endMessage)
    {
        SetPrompt();
        SetPonder();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine($"Summary: {_summary}");
        Console.WriteLine();
        Console.WriteLine("Get Ready.");
        Pause(5);
        Console.WriteLine();
        Console.WriteLine(GetPrompt());
        Console.WriteLine();
        while(DateTime.Now < endTime)
        {
            int count = _ponder.Count() - 1;
            Pause(10);
            try{Console.WriteLine(GetPonder(count));Console.WriteLine();}catch{};
        }
    }
    public void SetPrompt()
    {
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");
    }
    public void SetPonder()
    {
        _ponder.Add("Why was this experience meaningful to you?");
        _ponder.Add("Have you ever done anything like this before?");
        _ponder.Add("How did you get started?");
        _ponder.Add("How did you feel when it was complete?");
        _ponder.Add("What made this time different than other times when you were not as successful?");
        _ponder.Add("What is your favorite thing about this experience?");
        _ponder.Add("What could you learn from this experience that applies to other situations?");
        _ponder.Add("What did you learn about yourself through this experience?");
        _ponder.Add("How can you keep this experience in mind in the future?");
    }
    public string GetPrompt()
    {
        Random random = new Random();
        string prompt = _prompt[random.Next(0,3)];
        return(prompt);
    }
    public string GetPonder(int count)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, count);
        string ponder = _ponder[randomIndex];
        _ponder.RemoveAt(randomIndex);
        return(ponder);
    }
}