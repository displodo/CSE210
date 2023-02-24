
class Listing: Activity
{
    private List<string> _userInput = new List<string>();
    private List<string> _prompt = new List<string>();

    public Listing(string title, int duration, string summary, string endMessage): base(title, duration, summary, endMessage)
    {
        Random random = new Random();
        Console.WriteLine($"Summary: {_summary}");
        Pause(5);
        Console.WriteLine();
        SetPrompt();
        Console.WriteLine(_prompt[random.Next(0, 4)]);
        Console.WriteLine("Get Ready: ");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {    
            Console.Write(">");
            _userInput.Add(Console.ReadLine());
        }
        DisplayEndMessage();
        Pause(5);
        Console.WriteLine($"You Listed {_userInput.Count()} Items!");
        Pause(5);
        Console.WriteLine();
    }
    public void SetPrompt()
    {
        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that you have helped this week?");
        _prompt.Add("When have you felt the Holy Ghost this month?");
        _prompt.Add("Who are some of your personal heroes?");
    }
    public List<string> GetPrompt()
    {
        return(_prompt);
    }
    public List<string> GetUserInput()
    {
        return(_userInput);
    }
}