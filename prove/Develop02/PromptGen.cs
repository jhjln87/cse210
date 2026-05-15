public class PromptGen()
{
    public List<string> _new = new List<string>();
    public List<int> _used = new List<int>();
    public string _current;
    private Random rnd = new Random();
    public void Init()
    {
        _used = new List<int>(new int[15]);
        _new = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the hardest part of my day?",
            "If I spoke to myself the way I would speak to a close friend, what would I say?",
            "What was my biggest distraction today?",
            "What is one thing that’s been weighing on my mind today?",
            "What are three things I can improve on?",
            "What is something I was proud of today?",
            "If I couldn't fail, what is one thing I would do?",
            "If you were to describe today in one word, what would that word be?",
            "What is one past experience or thing you were reminded of today?",
            "What is something you look forward to?"
        };
    }
    public void Pick()
    {
        int i = rnd.Next(_new.Count);
        int k = 0;
        while (_used[i] == 1 && k < 15)
        {
            i = rnd.Next(_new.Count);
        }
        _current = _new[i];
        _used[i] = 1;
        if (k > 14)
        {
            foreach (int j in _used)
            {
                _used[j] = 0;
            }
        }
    }
}