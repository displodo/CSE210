public class Goal
{
    protected string _name = "";
    protected string _description = "";
    protected bool _complete = false;
    protected int _completionPoints = 0;
    protected int _points = 0;
    protected List<Goal> _Goals = new List<Goal>();
    public Goal()
    {

    }
    public Goal(string name, string description, bool isComplete, int completionPoints, int points)
    {
        _name = name;
        _description = description;
        _complete = isComplete;
        _completionPoints = completionPoints;
        _points = points;
    }
    public virtual void DisplayGoal()
    {

    }
    public virtual void SaveGoal(string file)
    {

    }
    public void LoadGoals()
    {
        List<string> newList = new List<string>();
        List<string> listString = new List<string>();
        Console.WriteLine("What is the name of the file you want to load?");
        Console.Write(">");
        string file = Console.ReadLine();
        file = file + ".txt";
        string fileContents = File.ReadAllText(file);
        string [] goals = fileContents.Split("\n");
        _points = int.Parse(goals[0]);
        foreach (var i in goals)
        {
            if (i != goals[0])
            {
                newList.Add(i);     
            }
        }
        foreach (var goal in newList)
        {
            bool complete = false;
            string[] stringList = goal.Split("|n");
            listString = new List<string>();
            foreach (var str in stringList){listString.Add(str);}
            if (stringList.Length == 4)
            {
                bool exists = false;
                var eternalGoal = new EternalGoal(listString[0], listString[1], int.Parse(listString[2]));
                foreach (var i in _Goals){if (i.CheckIfExists(eternalGoal)){exists = true;}}
                if (!exists)
                {
                    _Goals.Add(eternalGoal);
                }
            }
            if (stringList.Length == 5)
            {
                bool exists = false;
                if (listString[2] == "True") {complete = true; }
                var simpleGoal = new SimpleGoal(listString[0],listString[1],complete,int.Parse(listString[3]));
                foreach (var i in _Goals){if (i.CheckIfExists(simpleGoal)){exists = true;}}
                if (!exists)
                {
                    _Goals.Add(simpleGoal);
                }
            }
            if (stringList.Length == 8)
            {
                bool exists = false;
                if (listString[2] == "True") {complete = true;}
                var checklistGoal = new ChecklistGoal(listString[0], listString[1],complete, int.Parse(listString[3]),
                int.Parse(listString[4]), int.Parse(listString[5]), int.Parse(listString[6]));
                foreach (var i in _Goals){if (i.CheckIfExists(checklistGoal)){exists = true;}}
                if (!exists)
                {
                    _Goals.Add(checklistGoal);
                }
            }
        }
    }
    public List<Goal> GetGoals()
    {
        return _Goals;
    }
    public void AddGoals(Goal goal)
    {
        _Goals.Add(goal);
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void AddPoints(int points)
    {
        _points += points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual int AddEvent()
    {
        return 0;
    }
    public bool IsComplete()
    {
        return _complete;
    }
    public virtual bool CheckIfExists(Goal goal)
    {
        return false;
    }
}