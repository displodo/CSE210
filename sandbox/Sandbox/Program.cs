class Program {
    static void Main(string[] args) {
        while(true){
            var random = new Random();
            int randomInt = random.Next(1, 4);
            Console.WriteLine(randomInt);
            Console.ReadLine();
        }
    }
}

