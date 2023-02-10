class Verse
{
    private List<string> _verse = new List<string>();
    private List<HideWord> _wordCount = new List<HideWord>();
    public void SetVerse(string verse)
    {
        List<string> newList = new List<string>();
        string[] splitVerse = verse.Split(" ");
        foreach(string var in splitVerse)
        {
            _verse.Add(var);
        }
        
    }
    public List<string> GetVerse()
    {
       return(_verse);
    }
    public void SetVerseWordCount(int count, int verseIndex)
    {
        List<int> wordCount = new List<int>();
        foreach(int var in Enumerable.Range(0, count))
        {
            wordCount.Add(var);
        }
        HideWord newHideWord = new HideWord();
        newHideWord.SetWordCount(wordCount);
        _wordCount.Add(newHideWord);
    }
    public List<HideWord> GetVerseWordCount()
    {
        return(_wordCount);
    }
    
}