using System;

class Program
{
    static void Main(string[] args) {
        
        // Generate random number for our code.
        Random generator = new Random();
        int MagicNumber = generator.Next(1,11);
        // Console.WriteLine($"Magic Number:{MagicNumber}");
        CheckNumber(MagicNumber);
    }

    // Define a function to guess our number.
    static void CheckNumber(int MagicNumber) {
        int Guess = -1;
        // While our number is not the guess repeat the code.
        while (Guess != MagicNumber) {
            Console.Write("What is your guess?: ");
            string UserGuess = Console.ReadLine() ?? "";
            try {
                Guess = int.Parse(UserGuess);
            }
            catch {
                Guess = 0;
            }
            if (Guess < MagicNumber) {
                Console.WriteLine("Higher.");
            }
            else if (Guess > MagicNumber) {
                Console.WriteLine("Lower");
            }
            else if (Guess == MagicNumber) {
                Console.WriteLine("You guessed it!");
            }
        } 
    }
}
