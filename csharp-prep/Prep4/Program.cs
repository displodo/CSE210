using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers.");
        Console.WriteLine("When you are finished type 0 to end program.");
        
        int input = 1;
        List<int> numbers = new List<int>();

        do {
            Console.Write("Please enter a number: ");
            input = int.Parse(Console.ReadLine() ?? "");
                       
            
            numbers.Add(input);

        } while (input != 0);

        int length = (numbers.Count);
        int count = -1;

        numbers.Remove(numbers[length-1]);
        numbers.Sort();
        Console.WriteLine(length);
        Console.Write("Here is your sorted list: ");
        foreach (int number in numbers) {
            count += 1;
            if (numbers[count] != numbers[length - 2]) {
                Console.Write($"{number}, ");
            }
            else {
                Console.Write(numbers[length - 2]);
            }
            
        }
    }
}