public class Scripture()
{
    private List<Word> _current = new List<Word>();
    private Reference _ref = new Reference();
    public void GrabReference()
    {
        bool isValid = false;
        string[] refs;

        while (!isValid)
        {
            Console.WriteLine("Please input the scripture reference (using standard scripture syntax, e.g Book 1: Verse1-EndVerse)");
            refs = Console.ReadLine().Split([' ', ':', '-'], StringSplitOptions.RemoveEmptyEntries);

            if (refs.Length == 3 || refs.Length == 4)
            {
                bool isChapterNum = int.TryParse(refs[1], out int chap);
                bool isStartVerseNum = int.TryParse(refs[2], out int verse);

                if (refs.Length == 3 && isChapterNum && isStartVerseNum)
                {
                    _ref.setByReference(refs[0], chap, verse);
                    isValid = true;
                }
                else if (refs.Length == 4 && isChapterNum && isStartVerseNum && int.TryParse(refs[3], out int endVerse))
                {
                    _ref.setByReference(refs[0], chap, verse, endVerse);
                    isValid = true;
                }
            }

            if (!isValid)
            {
                Console.WriteLine("Invalid format. Please ensure a space after the book name and a colon between chapter and verse (e.g Book 1: Verse1-EndVerse)");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Now, please paste the scripture itself:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        foreach (string wrd in words)
        {
            Word word = new Word();
            word.SetWord(wrd);
            _current.Add(word);
        }
    }
    public void Display()
    {
        _ref.GetFullReference(true);
        foreach (Word word in _current)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine("\n");
    }
    public bool Remove(int removeThisMany)
    {
        Random rand = new Random(); 
        for (int i = 0; i<removeThisMany; i++)
        {
            List<Word> visibleWords = _current.Where(w => w.GetStatus() == true).ToList();
            if (visibleWords.Count == 0)
            {
                return false; 
            }
            int randomIndex = rand.Next(0, visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
        return true;
    }
    public void ShowAll()
    {
        foreach (Word word in _current)
        {
            word.Show();
        }
    }
}