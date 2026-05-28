public class Word()
{
    private bool _shown;
    private string _word;
    public string GetWord()
    {
        if (_shown)
        {
            return _word;
        }
        else
        {
            return GetHiddenWord();
        }
    }
    public string GetHiddenWord()
    {
        if (!_shown)
        {
            string i = "";
            foreach (char ltr in _word)
            {
               i += "_"; 
            }
            return i;
        }
        else
        {
            return GetWord();
        }
    }
    public void SetWord(string word)
    {
        _word = word.ToString();
        _shown = true;
    }
    public void Show()
    {
        _shown = true;
    }
    public void Hide()
    {
        _shown = false;
    }
    public bool GetStatus()
    {
        return _shown;
    }
}