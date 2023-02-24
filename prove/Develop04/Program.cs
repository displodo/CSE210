using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        bool end = true;
        string summary = "";
        int duration = 0;
        while(end)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1: Breathing Exercise");
            Console.WriteLine("2: Reflection Exercise");
            Console.WriteLine("3: Listing Exercise");
            Console.WriteLine("4: Quit Program");
            Console.WriteLine("Which Exercise would you like to do?");
            Console.Write(">");
            string title = Console.ReadLine();
            if(title != "4")
            {
                Console.WriteLine("How Long would you like to do the activity for in seconds?");
                Console.Write(">");
                duration = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            if(title == "1")
            {
                summary = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                string endMessage = "Breathing Activity Complete";
                Breathing breathing = new Breathing(title, duration, summary, endMessage);
            }
            if(title == "2")
            {
                summary = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                string endMessage = "Refelction Activity Complete";
                Reflection reflection = new Reflection(title, duration, summary, endMessage);
            }
            if(title == "3")
            {
                summary = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                string endMessage = "Listing Activity Complete";
                Listing listing = new Listing(title, duration, summary, endMessage);
            }
            if(title == "4")
            {
                end = false;
            }
        }
    }
}