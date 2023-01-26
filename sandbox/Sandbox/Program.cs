using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Menu menu = new Menu();
    }
}

// How to use a constructor
class Menu
{
    // This is my Constructor
    public Menu() 
    {
        Console.WriteLine("Hello World");
    }
}