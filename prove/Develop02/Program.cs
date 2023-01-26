using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool quit = true;
        Journal newJournal = new Journal();
        string journalName = "";
        int count = 0;
        while(quit)
        {
            string selection = Menu();   
            Console.WriteLine(selection);
            if (selection == "1") 
            {
                count += 1;
                if (count == 1)
                {
                    Console.Write("What would you like to call this journal?: ");
                    journalName = Console.ReadLine();
                }
                Console.WriteLine("");
                Console.Write("Would you like to add a scripture refference (yes/no)?: ");
                string response = Console.ReadLine();
                ScriptureStudy newScripture = new ScriptureStudy();
                if (response == "yes") 
                {
                    newScripture = ScriptureStudy.AddScripture();
                }
                else
                {
                    newScripture._scriptRef = " ";
                    newScripture._scriptSum = " ";
                }
                newJournal = Entry.CreateEntry(journalName, newJournal, newScripture);

            }
            else if (selection == "2") 
            {
                Console.Write("What is the name of the journal you would like to load?: ");
                string fileName = Console.ReadLine();
                string filename = $"{fileName}.txt";
                newJournal = Journal.ReadFile(filename);
            }
            else if (selection == "3") 
            {
                string filename = $"{journalName}.txt";
                File.WriteAllText(filename, newJournal._journalName + "\n");
                foreach(var entry in newJournal._entrys)
                {
                    File.AppendAllText(filename, entry._dateAndTime + "\n");
                    File.AppendAllText(filename, entry._prompt + "\n");
                    File.AppendAllText(filename, entry._journalInput + "\n");
                    File.AppendAllText(filename, entry._scripture._scriptRef + "\n");
                    File.AppendAllText(filename, entry._scripture._scriptSum + "\n");
                }
            }
            else if (selection == "4") 
            {
                Journal.DisplayEntries(newJournal);
            }
            else if (selection == "5") 
            {
                quit = false;
            }
            else 
            {
                Console.WriteLine("Incorrect input try again.");
            }
        }
    }

    static String Menu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1: New Entry.");
        Console.WriteLine("2: Load Previous Entry.");
        Console.WriteLine("3: Save Current Entry.");
        Console.WriteLine("4: Read All Entrys.");
        Console.WriteLine("5: Quit.");
        Console.WriteLine("");
        Console.Write("Enter the number of what you would like to do: ");
        string selection = Console.ReadLine();
        return (selection);
    }
}

public class Journal
{
    public String _journalName = "";
    public List<Entry> _entrys = new List<Entry>();

    public static void DisplayEntries(Journal newJournal) 
    {
        Console.WriteLine("");
        Console.WriteLine(newJournal._journalName);
        foreach (var entry in newJournal._entrys)
        { 
            Console.WriteLine("");
            Console.WriteLine(entry._dateAndTime);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._journalInput);
            Console.WriteLine("");
            Console.WriteLine(entry._scripture._scriptRef);
            Console.WriteLine(entry._scripture._scriptSum);
            Console.Write("");
            Console.Write("Next Entry: ");
            Console.ReadLine();
        }
    }
        public static Journal ReadFile(string filename)
        {
            Journal newJournal = new Journal();
            int set = 1;
            string journalLines = File.ReadAllText(filename);
            string[] parts = journalLines.Split("\n");
            int numberEntries = (parts.Length - 1) / 5;
            newJournal._journalName = parts[0];
            
            foreach (int entry in Enumerable.Range(1, numberEntries))
            {
                
                if(entry >= 1)
                {
                    Entry newEntry = new Entry();
                    newEntry._dateAndTime = parts[set];
                    newEntry._prompt = parts[set + 1];
                    newEntry._journalInput = parts[set + 2];
                    newEntry._scripture._scriptRef = parts[set + 3];
                    newEntry._scripture._scriptSum = parts[set + 4];
                    newJournal._entrys.Add(newEntry);
                    set += 5;
                }
                
            }
            return(newJournal);
        }
}

public class Entry
{
    public String _prompt = "";
    public String _dateAndTime = "";
    public String _journalInput = "";
    public ScriptureStudy _scripture = new ScriptureStudy();


        static String GetDateAndTime()
        {
            DateTime theCurrentTime = DateTime.Now;
            String currentTime = theCurrentTime.ToString();
            String dateAndTime = ($"{currentTime}");
            return (dateAndTime);
        }
        public static Journal CreateEntry(string journalName, Journal newJournal, ScriptureStudy newScripture) 
        {
            Entry newEntry = new Entry();
            newEntry._dateAndTime = GetDateAndTime();
            GetPrompt prompt = new GetPrompt();
            newEntry._prompt = prompt._newPrompt;
            Console.WriteLine($"Prompt: {newEntry._prompt}");
            Console.WriteLine("Write Journal entry here");
            Console.Write(">");
            newEntry._journalInput = Console.ReadLine();
            newEntry._scripture = newScripture;

            newJournal._journalName = journalName;
            newJournal._entrys.Add(newEntry);
            return(newJournal);
        }
}

public class GetPrompt
{
    public String _newPrompt = GetNewPrompt();

    static String GetNewPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today??");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("Who do you wish you talked to today?");
        Random generator = new Random();
        int randomIndex = generator.Next(0,5);
        return(prompts[randomIndex]);
    }
}

public class ScriptureStudy
{
    public String _scriptRef = "";
    public String _scriptSum = "";

    public static ScriptureStudy AddScripture()
    {
        Console.Write("What is the refference?: ");
        string refference = Console.ReadLine();
        Console.WriteLine("Please give a brief summary.");
        Console.Write(">");
        string summary = Console.ReadLine();
        Console.Write("");

        ScriptureStudy newScripture = new ScriptureStudy();
        newScripture._scriptRef = refference;
        newScripture._scriptSum = summary;
        return(newScripture);
    }
}