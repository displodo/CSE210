public class SimpleGoal: Goal
{
    public SimpleGoal()
    {
        _name = "SimpleGoal";
        Console.WriteLine("What is your goal?");
        Console.Write(">");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        Console.Write(">");
        _completionPoints = int.Parse(Console.ReadLine());
    }
    public SimpleGoal(string name, string description, bool isComplete, int completionPoints)
    :base(name, description, isComplete, completionPoints, 0)
    {
        
    }
    public override void DisplayGoal()
    {
        string isDone = " ";
        if (_complete == true){isDone = "X";}
        Console.WriteLine($"[{isDone}]: {_description}");
    }
    public override void SaveGoal(string file)
    {
        File.AppendAllText(file, _name + "|n");
        File.AppendAllText(file, _description + "|n");
        File.AppendAllText(file, _complete + "|n");
        File.AppendAllText(file, _completionPoints + "|n");
    }
    public override int AddEvent()
    {
        int points = 0;
        if (_complete == false)
        {
            points = _completionPoints;
            _complete = true;
        }
        return points;
    }
    public override bool CheckIfExists(Goal goal)
    {
        if (goal is SimpleGoal simpleGoal)
        {
            return 
                _description == simpleGoal._description &&
                _completionPoints == simpleGoal._completionPoints &&
                _complete == simpleGoal._complete;
        }
    return false;
    }
}