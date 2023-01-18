using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Resume newResume = makeResume(name);
        DisplayResume(newResume);
    }
    static Resume makeResume(string name) 
    {
        Resume newResume = new Resume();
        newResume._name = name;
        Console.WriteLine("Please enter past Job experience.");
        addJob(newResume);
        return (newResume);
    }

    static void addJob(Resume newResume) 
    {
        bool end = true;
        while(end) 
        {
            Job newJob =  new Job();
            Console.Write("Company: ");
            newJob._company = Console.ReadLine();
            Console.Write("Job Title: ");
            newJob._jobTitle = Console.ReadLine();
            Console.Write("Start Year: ");
            newJob._startYear = int.Parse(Console.ReadLine());
            Console.Write("End Year: ");
            newJob._endYear = int.Parse(Console.ReadLine());
            newResume._jobs.Add(newJob);
            Console.Write("Would you like to add another Job?: ");
            string answer = Console.ReadLine();
            if (answer == "no" || answer == "NO" || answer == "No") 
            {
                end = false;
            }
        }
    }

static void DisplayResume(Resume newResume)
    {
        int count = 0;
    Console.WriteLine("");
    Console.WriteLine($"Name: {newResume._name}");
    Console.WriteLine("");
    Console.WriteLine("Your past jobs.");
        foreach(var item in newResume._jobs)
        {
            count += 1;
            Console.WriteLine($"Job{count}");
            Console.WriteLine($"Company Name: {item._company}");
            Console.WriteLine($"Job Title: {item._jobTitle}");
            Console.WriteLine($"Start Year: {item._startYear}");
            Console.WriteLine($"End Year: {item._endYear}");
            Console.WriteLine("");
        }

    }
}
public class Resume 
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
}
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
}

