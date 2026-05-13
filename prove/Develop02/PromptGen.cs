public class PromptGen()
{
    public List<unused> _new = new List<unused>();
    public List<used> _used = new List<used>();
    public string _current;
    private Random rnd = new Random();
    private void Init()
    {
        _used = new int[15];
        _new = new string[15];
        _new[0] = "Who was the most interesting person I interacted with today?";
        _new[1] ="What was the best part of my day?";
        _new[2] ="How did I see the hand of the Lord in my life today?";
        _new[3] ="What was the strongest emotion I felt today?";
        _new[4] ="If I had one thing I could do over today, what would it be?";
        _new[5] ="What was the hardest part of my day?";
        _new[6] ="If I spoke to myself the way I would speak to a close friend, what would I say?";
        _new[7] ="What was my biggest distraction today?";
        _new[8] ="What is one thing that’s been weighing on my mind today?";
        _new[9] ="What are three things I can improve on?";
        _new[10] ="What is something I was proud of today?";
        _new[11] ="If I couldn't fail, what is one thing I would do?";
        _new[12] ="If you were to decribe today in one word, what would that word be?";
        _new[13] ="What is one past experience or thing you were reminded of today?";
        _new[14] ="What is something you look forward to?";
    }
    public void Pick()
    {
        int i = rnd.Next(_new.Length);
        while (_used[i] == 1)
        {
            _current = _new[i];
            i = rnd.Next(_new.Length);
        }
    }
}