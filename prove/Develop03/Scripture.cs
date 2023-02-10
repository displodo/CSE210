class Scripture
{
    private string _reference = "";
    private List<Verse> _verses = new List<Verse>();

    public string SelectScripture(Scripture newScripture)
    {
        Console.WriteLine("Scriptures: ");
        Console.WriteLine("1. 1 Nephi 3:7");
        Console.WriteLine("2. D&C 82:10");
        Console.WriteLine("3. Helaman 5:12");
        Console.WriteLine("4. JSH 1:15-20");
        Console.WriteLine("5. Proverbs 4:4-5");
        Console.WriteLine("6. Add My Own.");
        Console.WriteLine();
        Console.Write("Which scripture would you like to memorize?: ");
        string selectionStr = Console.ReadLine();
        int selection = 0;
        string scripture = "";
        try
        {
            selection = int.Parse(selectionStr);
        } catch{}

        if(selection == 1)
        {
            scripture = "1 Nephi 3:7";
        }
        if(selection == 2)
        {
            scripture = "D&C 82:10";
        }
        if(selection == 3)
        {
            scripture = "Helaman 5:12";
        }
        if(selection == 4)
        {
            scripture = "JSH 1:15-20";
        }
        if(selection == 5)
        {
            scripture = "Proverbs 4:4-5";
        }
        if(selection == 6)
        {
            scripture = "Add My Own.";
        }
        return(scripture);
    }

    public void SetScripture(string scripture)
    {
        Dictionary<string, List<string>> scriptures = new Dictionary<string, List<string>>();
        scriptures.Add("1 Nephi 3:7", new List<string>(new string[] {"7. And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."}));
        scriptures.Add("D&C 82:10", new List<string>(new string[] {"10. I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."}));
        scriptures.Add("Helaman 5:12", new List<string>(new string[] {"12. And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."}));
        scriptures.Add("JSH 1:15-20", new List<string>(new string[] {"15. After I had retired to the place where I had previously designed to go, having looked around me, and finding myself alone, I kneeled down and began to offer up the desires of my heart to God. I had scarcely done so, when immediately I was aseized upon by some power which entirely overcame me, and had such an astonishing influence over me as to bind my tongue so that I could not speak. Thick darkness gathered around me, and it seemed to me for a time as if I were doomed to sudden destruction.", "16. But, exerting all my powers to acall upon God to deliver me out of the power of this enemy which had seized upon me, and at the very moment when I was ready to sink into despair and abandon myself to destruction not to an imaginary ruin, but to the power of some actual being from the unseen world, who had such marvelous power as I had never before felt in any being just at this moment of great alarm, I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me.","17. It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other This is My Beloved Son. Hear Him!","18. My object in going to inquire of the Lord was to know which of all the sects was right, that I might know which to join. No sooner, therefore, did I get possession of myself, so as to be able to speak, than I asked the Personages who stood above me in the light, which of all the sects was right (for at this time it had never entered into my heart that all were wrong) and which I should join.","19. I was answered that I must join none of them, for they were all wrong; and the Personage who addressed me said that all their creeds were an abomination in his sight; that those professors were all corrupt; that: “they draw near to me with their lips, but their hearts are far from me, they teach for doctrines the commandments of men, having a form of godliness, but they deny the power thereof.”","20. He again forbade me to join with any of them; and many other things did he say unto me, which I cannot write at this time. When I came to myself again, I found myself alying on my back, looking up into heaven. When the light had departed, I had no strength; but soon recovering in some degree, I went home. And as I leaned up to the fireplace, bmother inquired what the matter was. I replied, “Never mind, all is well I am well enough off.” I then said to my mother, “I have learned for myself that Presbyterianism is not true.” It seems as though the adversary was aware, at a very early period of my life, that I was destined to prove a disturber and an annoyer of his kingdom; else why should the powers of darkness combine against me? Why the dopposition and persecution that arose against me, almost in my infancy?"}));
        scriptures.Add("Proverbs 4:4-5", new List<string>(new string[] {"4. He taught me also, and said unto me, Let thine heart retain my words: keep my commandments, and live.","5. Get wisdom, get understanding: forget it not; neither decline from the words of my mouth."}));

        _reference = scripture;
        foreach(string var in scriptures[scripture])
        {
            Verse newVerse = new Verse();
            newVerse.SetVerse(var);
            _verses.Add(newVerse);
        }
    }
        public void SetScripture(string scripture, List<string> verses)
    {
        Dictionary<string, List<string>> scriptures = new Dictionary<string, List<string>>();
        scriptures.Add("1 Nephi 3:7", new List<string>(new string[] {"7. And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."}));
        scriptures.Add("D&C 82:10", new List<string>(new string[] {"10. I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."}));
        scriptures.Add("Helaman 5:12", new List<string>(new string[] {"12. And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."}));
        scriptures.Add("JSH 1:15-20", new List<string>(new string[] {"15. After I had retired to the place where I had previously designed to go, having looked around me, and finding myself alone, I kneeled down and began to offer up the desires of my heart to God. I had scarcely done so, when immediately I was aseized upon by some power which entirely overcame me, and had such an astonishing influence over me as to bind my tongue so that I could not speak. Thick darkness gathered around me, and it seemed to me for a time as if I were doomed to sudden destruction.", "16. But, exerting all my powers to acall upon God to deliver me out of the power of this enemy which had seized upon me, and at the very moment when I was ready to sink into despair and abandon myself to destruction not to an imaginary ruin, but to the power of some actual being from the unseen world, who had such marvelous power as I had never before felt in any being just at this moment of great alarm, I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me.","17. It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other This is My Beloved Son. Hear Him!","18. My object in going to inquire of the Lord was to know which of all the sects was right, that I might know which to join. No sooner, therefore, did I get possession of myself, so as to be able to speak, than I asked the Personages who stood above me in the light, which of all the sects was right (for at this time it had never entered into my heart that all were wrong) and which I should join.","19. I was answered that I must join none of them, for they were all wrong; and the Personage who addressed me said that all their creeds were an abomination in his sight; that those professors were all corrupt; that: “they draw near to me with their lips, but their hearts are far from me, they teach for doctrines the commandments of men, having a form of godliness, but they deny the power thereof.”","20. He again forbade me to join with any of them; and many other things did he say unto me, which I cannot write at this time. When I came to myself again, I found myself alying on my back, looking up into heaven. When the light had departed, I had no strength; but soon recovering in some degree, I went home. And as I leaned up to the fireplace, bmother inquired what the matter was. I replied, “Never mind, all is well I am well enough off.” I then said to my mother, “I have learned for myself that Presbyterianism is not true.” It seems as though the adversary was aware, at a very early period of my life, that I was destined to prove a disturber and an annoyer of his kingdom; else why should the powers of darkness combine against me? Why the dopposition and persecution that arose against me, almost in my infancy?"}));
        scriptures.Add("Proverbs 4:4-5", new List<string>(new string[] {"4. He taught me also, and said unto me, Let thine heart retain my words: keep my commandments, and live.","5. Get wisdom, get understanding: forget it not; neither decline from the words of my mouth."}));
        try {scriptures.Add(scripture, verses);}catch{}
        _reference = scripture;
        foreach(string var in scriptures[scripture])
        {
            Verse newVerse = new Verse();
            newVerse.SetVerse(var);
            _verses.Add(newVerse);
        }
    }
    public void AddScripture()
    {
        List<string> verses = new List<string>();
        string answer = "";
        Console.WriteLine();
        Console.Write("What is the Reference?: ");
        string reference = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the first verse?: ");
        string verse = Console.ReadLine();
        verses.Add(verse);
        Console.WriteLine();
        Console.Write("Would you like to add another verse?(Type 'no' if not.): ");
        answer = Console.ReadLine();
        while(answer != "no")
        {
            Console.WriteLine();
            Console.Write("What is the next verse?: ");
            verse = Console.ReadLine();
            verses.Add(verse);
            Console.WriteLine();
            Console.Write("Would you like to add another verse?(Type 'no' if not.): ");
            answer = Console.ReadLine();
        }
        SetScripture(reference, verses);
    }
    public string GetReference()
    {
        return(_reference);
    }
    public List<Verse> GetVerses()
    {
        return(_verses);
    }       
}