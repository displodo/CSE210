using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        var quit = false;
        while(!quit){
            Console.WriteLine("Choose which dice you would like to roll?");
            Console.WriteLine("1. Coin");
            Console.WriteLine("2. d3");
            Console.WriteLine("3. d4");
            Console.WriteLine("4. d6");
            Console.WriteLine("5. d8");
            Console.WriteLine("6. d10");
            Console.WriteLine("7. d12");
            Console.WriteLine("8. d20");
            Console.WriteLine("9. Percentile");
            Console.WriteLine("10. Quit");
            Console.WriteLine("What would you like to roll?");
            Console.Write(">");
            var input = Console.ReadLine();
            Console.WriteLine();
        
            if(input == "1")
            {
                int diceNumber = GetDiceNumber();
                CoinFlip coin = new CoinFlip(2, diceNumber);
            }
            else if(input == "2")
            {
                int diceNumber = GetDiceNumber();
                D3 d3 = new D3(3, diceNumber);
            }
            else if(input == "3")
            {
                int diceNumber = GetDiceNumber();
                D4 d4 = new D4(4, diceNumber);
            }
            else if(input == "4")
            {
                int diceNumber = GetDiceNumber();
                D6 d6 = new D6(6, diceNumber);
            }
            else if(input == "5")
            {
                int diceNumber = GetDiceNumber();
                D8 d8 = new D8(8, diceNumber);
            }
            else if(input == "6")
            {
                int diceNumber = GetDiceNumber();
                D10 d10 = new D10(10, diceNumber);
            }
            else if(input == "7")
            {
                int diceNumber = GetDiceNumber();
                D12 d12 = new D12(12, diceNumber);
            }
            else if(input == "8")
            {
                int diceNumber = GetDiceNumber();
                D20 d20 = new D20(20, diceNumber);
            }
            else if(input == "9")
            {
                int diceNumber = GetDiceNumber();
                Percentile percentile = new Percentile(100, diceNumber);
            }
            else if(input == "10")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Press enter to return to menu.");
                Console.Write(">");
                Console.ReadLine();
            }
        }
    }
    static int GetDiceNumber()
    {
        Console.WriteLine("How many dice would you like to roll?");
        Console.Write(">");
        int numberDice = 0;
        try{numberDice = int.Parse(Console.ReadLine());}
        catch
        {
            Console.WriteLine("Invalid input.");
            Console.WriteLine("Hit enter to return to to menu.");
            Console.Write(">");
            Console.ReadLine();
        }
        return numberDice;
    }
}