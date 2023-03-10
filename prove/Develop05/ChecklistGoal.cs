public class ChecklistGoal: Goal
{
    private int _toDo = 0;
    private int _done = 0;
    private int _bonusPoints = 0;
    public ChecklistGoal()
    {
        _name = "ChecklistGoal";
        Console.WriteLine("What is your goal?");
        Console.Write(">");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        Console.Write(">");
        _completionPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times do you need to do this goal before its complete?");
        Console.Write(">");
        _toDo = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points is completing this goal worth?");
        Console.Write(">");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public ChecklistGoal(string name, string description, bool isComplete, int completionPoints, int toDo, int done, int bonusPoints)
    :base(name, description, isComplete, completionPoints, 0)
    {
        _toDo = toDo;
        _done = done;
        _bonusPoints = bonusPoints;
    }
    public override void DisplayGoal()
    {
        string isDone = " ";
        if (_complete == true){isDone = "X";}
        Console.WriteLine($"[{isDone}]: {_description} {_done}/{_toDo}");
    }
    public override void SaveGoal(string file)
    {
        File.AppendAllText(file, _name + "|n");
        File.AppendAllText(file, _description + "|n");
        File.AppendAllText(file, _complete + "|n");
        File.AppendAllText(file, _completionPoints + "|n");
        File.AppendAllText(file, _toDo + "|n");
        File.AppendAllText(file, _done + "|n");
        File.AppendAllText(file, _bonusPoints + "|n");

    }
    public override int AddEvent()
    {
        int points = 0;
        if (_complete == false){_done += 1;}
        if (_complete == false && _done == _toDo) 
        {
            points = (_completionPoints + _bonusPoints); 
            _complete = true;
        }
        if (_complete == false && _done <= _toDo)
        {
            points = _completionPoints;
        }
        
        return points;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override bool CheckIfExists(Goal goal)
    {
        if (goal is ChecklistGoal checklistGoal)
        {
            return 
                _description == checklistGoal._description &&
                _completionPoints == checklistGoal._completionPoints &&
                _complete == checklistGoal._complete &&
                _toDo == checklistGoal._toDo;
        }
    return false;
    }
}