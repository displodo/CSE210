using System;
class Program
{
    static void Main(string[] args)
    {
        Goal newGoal = new Goal();
        Menu(newGoal);
    }
    static void Menu(Goal newGoal)
    {
        bool done = true;
        while(done)
        {
            Console.WriteLine($"Points: {newGoal.GetPoints()}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal.");
            Console.WriteLine("2. ListGoals.");
            Console.WriteLine("3. Save Goals.");
            Console.WriteLine("4. Load Goals.");
            Console.WriteLine("5. Record Event.");
            Console.WriteLine("6. Quit.");
            Console.WriteLine();
            Console.Write(">");
            string selection = Console.ReadLine();
            if(selection == "1")
            {
                Console.WriteLine("What type of goal would you like to create?");
                Console.WriteLine();
                Console.WriteLine("1. Simple Goal.");
                Console.WriteLine("2. EternalGoal.");
                Console.WriteLine("3. Checklist Goal.");
                Console.WriteLine();
                Console.Write(">");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    var newSimple = new SimpleGoal();
                    newGoal.AddGoals(newSimple);
                    Console.WriteLine();
                }
                else if(choice == "2")
                {
                    var newEternal = new EternalGoal();
                    newGoal.AddGoals(newEternal);
                    Console.WriteLine();
                }
                else if(choice == "3")
                {
                    var newChecklist = new ChecklistGoal();
                    newGoal.AddGoals(newChecklist);
                } else {Console.WriteLine("Invalid input.");}
                Console.WriteLine();
            }
            else if(selection == "2")
            {
                foreach(var goal in newGoal.GetGoals())
                {
                    goal.DisplayGoal();
                }
                Console.Write(">");
                Console.ReadLine();
                Console.WriteLine();
            }
            else if(selection == "3")
            {
                Console.WriteLine("What file would you like to save your gaols to?");
                Console.Write(">");
                string file =  Console.ReadLine();
                file = file + ".txt";
                File.WriteAllText(file, newGoal.GetPoints() + "\n");
                foreach (var goal in newGoal.GetGoals())
                {
                    goal.SaveGoal(file);
                    File.AppendAllText(file, "\n");
                }
                Console.WriteLine();
            }
            else if(selection == "4")
            {
                newGoal.LoadGoals();
                Console.WriteLine();
            }
            else if(selection == "5")
            {
                int count = 0;
                List<Goal> goalList = newGoal.GetGoals();
                Console.WriteLine("Which Goal would you like to add an event to?");
                foreach (var goal in goalList)
                {
                    count += 1;
                    Console.WriteLine($"{count}. {goal.GetDescription()}");
                }
                Console.Write(">");
                int index = -1;
                try{index = int.Parse(Console.ReadLine());} catch {Console.WriteLine("Invalid input.");}
                Goal selectedGoal = new Goal();
                try {selectedGoal = goalList[index - 1];}
                catch
                {
                    Console.WriteLine("Selection is out of range.");
                    Console.Write(">");
                    Console.ReadLine();
                    Console.WriteLine();
                }
                if (selectedGoal.IsComplete() == false)
                {
                    int points = selectedGoal.AddEvent();
                    newGoal.AddPoints(points);
                    Console.WriteLine();
                } 
                else if (selectedGoal.IsComplete() == true)
                {
                    Console.WriteLine("That goal is complete!");
                    Console.Write(">");
                    Console.ReadLine();
                    Console.WriteLine();
                }
            }
            else if(selection == "6")
            {
                done = false;
            } else {
                Console.WriteLine("Invalid input please try again.");
                Console.Write(">");
                Console.ReadLine();
                Console.WriteLine();
                }
        }
    }
}