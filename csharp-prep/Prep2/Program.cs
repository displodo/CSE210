using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string grade = Console.ReadLine() ?? "";
        int NumberGrade = int.Parse(grade);
        GetGrade(NumberGrade);
    }
    static void GetGrade(int NumberGrade) {
        if (NumberGrade >= 90) {
            Console.WriteLine("You have an A!");
        }
        else if (NumberGrade >= 80 && NumberGrade <= 90) {
            Console.WriteLine("You have an B!");
        }
        else if (NumberGrade >= 70 && NumberGrade <= 80) {
            Console.WriteLine("You have an C!");
        }
        else if (NumberGrade >= 60 && NumberGrade <= 70) {
            Console.WriteLine("You have an D.");
        }
        else if (NumberGrade < 60) {
            Console.WriteLine("You got an F :(");
        }
    }

}