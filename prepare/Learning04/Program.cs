using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "JR Forsyth";
        string topic = "Math in the Real World";
        string writeTopic = "Basic Writing";
        string textbook = "Chapter 01";
        string problems = "8-17";
        string title = "Love at Home by JR Forsyth";
        var assign = new Assignment(name, topic);
        var math = new MathAssignment(name, topic, textbook, problems);
        var writing = new WritingAssignment(name, writeTopic, title);
        Console.WriteLine("Which would you like to do?");
        Console.WriteLine("1: Display Student/Assignment.");
        Console.WriteLine("2: Display Math Assignment.");
        Console.WriteLine("3: Display Writing Assignment.");
        Console.Write(">");
        string answer = Console.ReadLine();
        Console.WriteLine("");
        if(answer == "1")
        {
            Console.WriteLine(assign.GetSummary());
            Console.WriteLine("");
        }
        if(answer == "2")
        {
            Console.WriteLine(math.GetSummary());
            Console.WriteLine(math.GetHomeworkList());
            Console.WriteLine();
        }
        if(answer == "3")
        {
            Console.WriteLine(writing.GetSummary());
            Console.WriteLine(writing.GetWritingInformation());
            Console.WriteLine();
        }
    }
}