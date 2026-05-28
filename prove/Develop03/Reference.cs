public class Reference()
{
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _book;

    public void SetChapter(int chapterNumber)
    {
        _chapter = chapterNumber;
    }
    public void setVerse(int verseNumber)
    {
        _verse = verseNumber;
    }
    public void setStartVerse(int verseNumber)
    {
        _verse = verseNumber;
    }
    public void setEndVerse(int verseNumber)
    {
        _endVerse = verseNumber;
    }
    public void setBook(string bookName)
    {
        _book = bookName;
    }
    public void setByReference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        if (endVerse <= startVerse)
        {
            _endVerse = startVerse;
        }
        else
        {
            _endVerse = endVerse;
        }
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public string GetBook()
    {
        return _book;
    }
    public string GetFullReference(bool display)
    {
        string disp;
        if (_verse == _endVerse)
        {
            disp = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            disp = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        if (display)
        {
            Console.Write($"{disp} ");
        }
        return disp;
    }
}