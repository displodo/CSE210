public class EternalGoal: Goal
{
    public EternalGoal()
    {
        _name = "EternalGoal";
        Console.WriteLine("What is your goal?");
        Console.Write(">");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        Console.Write(">");
        _completionPoints = int.Parse(Console.ReadLine());
    }
    public EternalGoal(string name, string description, int completionPoints)
    :base(name, description, false, completionPoints, 0)
    {

    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ]: {_description}");
    }
    public override void SaveGoal(string file)
    {
        File.AppendAllText(file, _name + "|n");
        File.AppendAllText(file, _description + "|n");
        File.AppendAllText(file, _completionPoints + "|n");
    }
    public override int AddEvent()
    {
        return _completionPoints;
    }
    public override bool CheckIfExists(Goal goal)
    {
        if (goal is EternalGoal eternalGoal)
        {
            return 
                _description == eternalGoal._description &&
                _completionPoints == eternalGoal._completionPoints &&
                _complete == eternalGoal._complete;
        }
    return false;
    }
}