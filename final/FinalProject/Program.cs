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
                CoinFlip coin = new CoinFlip(2);
            }
            if(input == "2")
            {
                D3 d3 = new D3(3);
            }
            if(input == "3")
            {
                D4 d4 = new D4(4);
            }
            if(input == "4")
            {
                D6 d6 = new D6(6);
            }
            if(input == "5")
            {
                D8 d8 = new D8(8);
            }
            if(input == "6")
            {
                D10 d10 = new D10(10);
            }
            if(input == "7")
            {
                D12 d12 = new D12(12);
            }
            if(input == "8")
            {
                D20 d20 = new D20(20);
            }
            if(input == "9")
            {
                Percentile percentile = new Percentile(100);
            }
            if(input == "10")
            {
                quit = true;
            }
        }
    }
}