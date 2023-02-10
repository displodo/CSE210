class HideWord
{
    private List<int> _wordCount = new List<int>();
    public void DisplayVerse(Scripture newScripture)
    {
        Console.WriteLine();
        Console.WriteLine(newScripture.GetReference());
        foreach(Verse verse in newScripture.GetVerses())
        {
            foreach(string var in verse.GetVerse())
            {
                Console.Write($" {var}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void NumberWords(Scripture newScripture, int verseIndex)
    {
        foreach(Verse var in newScripture.GetVerses())
        {
            List<int> newHideWord = new List<int>();
            int count = var.GetVerse().Count;
            var.SetVerseWordCount(count, verseIndex);
        }
    }
    public Scripture HideWords(Scripture newScripture)
    {
        Random random = new Random();
        List<Verse> verses = newScripture.GetVerses();
        int verseIndex = random.Next(0, verses.Count);
        Verse verse = verses[verseIndex];
        List<HideWord> wordCount = verse.GetVerseWordCount();
        verse = verses[verseIndex];
        wordCount = verse.GetVerseWordCount();
        if(wordCount.Count == 0)
            {
                int verseCount = verse.GetVerse().Count;
                foreach(int var in Enumerable.Range(0, newScripture.GetVerses().Count))
                {
                    NumberWords(newScripture, var);
                }
                
            }
        if(wordCount[0].GetWordCount().Count == 1)
        {
            
            foreach(Verse index in verses)
            {
                List<HideWord> words = index.GetVerseWordCount();
                if(words[0].GetWordCount().Count > 1)
                {
                    verseIndex = verses.IndexOf(index);
                    verse = verses[verseIndex];
                    verse = verses[verseIndex];
                    wordCount = verse.GetVerseWordCount();
                }
                
            }
        }
        foreach(int count in Enumerable.Range(0, 3))
        {
            if(wordCount[0].GetWordCount().Count > 1)
            {
                List<string> wholeVerse = verse.GetVerse();
                HideWord remove = (wordCount[0]);
                List<int> wordRemove = remove.GetWordCount();
                int wordIndex = random.Next(1, wordRemove.Count);
                int wordPosition = wordRemove[wordIndex];
                string word = wholeVerse[wordPosition];
                string underscores = new string(char.Parse("_"), wholeVerse[wordPosition].Length);
                wholeVerse[wordPosition] = wholeVerse[wordPosition].Replace(word, underscores);
                wordRemove.Remove(wordPosition);
            }
        }
        
        Scripture editedScripture = newScripture;
        return(editedScripture);
    }
    public void SetWordCount(List<int> wordCount)
    {
        _wordCount = wordCount;
    }
    public List<int> GetWordCount()
    {
        return(_wordCount);
    }
}