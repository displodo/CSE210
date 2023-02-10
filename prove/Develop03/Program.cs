using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture newScripture = new Scripture();
        HideWord newHideWord = new HideWord();
        string scripture = newScripture.SelectScripture(newScripture);
        if(scripture != "Add My Own."){newScripture.SetScripture(scripture);}
        if(scripture == "Add My Own."){newScripture.AddScripture();}
        newHideWord.DisplayVerse(newScripture);
        bool stop = true;
        while (stop)
        {
            newScripture = newHideWord.HideWords(newScripture);
            Console.Write($"Enter 'stop' if you would like to exit: ");
            string answer = Console.ReadLine();
            newHideWord.DisplayVerse(newScripture);
            if (answer == "stop")
            {
                stop = false;
            }
        }
    }
}