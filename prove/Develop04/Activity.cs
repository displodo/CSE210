class Activity
{
    protected string _title = "";
    protected int _duration = 0;
    protected string _summary = "";
    protected string _endMessage = "";

    public Activity(string title, int duration, string summary, string endMessage)
    {
        _title = title;
        _duration = duration;
        _summary = summary;
        _endMessage = endMessage;
    }
    public void Pause(int pauseLength)
    {
        List<string> Animation = new List<string>(new string[]{"/","-","\\","|","/","-","\\"});
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(pauseLength);
        while(DateTime.Now < endTime)
        {
            int count = 0;
            foreach(var i in Animation)
            {
                if(DateTime.Now >= endTime){break;}
                if(count == 0){count += 1; Console.Write("|");}
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write(i);
            }
            Console.Write("\b \b");
            Console.Write("");
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Good Job!!!");
        Pause(2);
        Console.WriteLine(_endMessage);
        Pause(2);
        Console.WriteLine($"Duration of activity: {_duration} seconds");
        Pause(2);
        Console.WriteLine();
    }
    public void CountDown(int countDownLength)
    {
        foreach(var num in Enumerable.Range(1, countDownLength))
        {
            Console.Write(num);
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void SetSummary(string summary)
    {
        _summary = summary;
    }
    public string GetTitle()
    {
        return(_title);
    }
    public int GetDuration()
    {
        return(_duration);
    }
    public string GetSummary()
    {
        return(_summary);
    }
}