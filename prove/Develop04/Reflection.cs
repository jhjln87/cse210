public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _follows = new List<string>();
    public Reflection(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
        InitAllPrompts();
    }
    public Reflection(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
        InitAllPrompts();
    }
    private void InitAllPrompts()
    {
        _prompts.Clear();
        _follows.Clear();
        _prompts.AddRange(["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." ]);
        _follows.AddRange(["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"]);
    }
    public void AddPrompt(string add)
    {
        _prompts.Add(add);
    }
    public void PopPrompt(int index = -1)
    {
        if (index < 0 || index > _follows.Count())
        {
            index = _prompts.Count();
        }
        _prompts.RemoveAt(index);
    }
    private string GetPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }
    public void AddFollowUp(string add)
    {
        _follows.Add(add);
    }
    public void PopFollowUp(int index = -1)
    {
        if (index < 0 || index > _follows.Count())
        {
            index = _follows.Count();
        }
        _follows.RemoveAt(index);
    }
    private string GetFollowUp()
    {
        return _follows[Random.Shared.Next(_follows.Count)];
    }

    public void Full()
    {
        Console.WriteLine($"Consider the following prompt\n\n --- {GetPrompt()} --- \n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience\n");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"You may begin in {i} ");
            Thread.Sleep(1000);
            ClearCurrentLine();
        }
        Console.Clear();
        int timer2 = 0;
        while (timer2 < _activityDuration)
        {
            string follow = GetFollowUp();
            _follows.Remove(follow);
            Console.Write($"> {follow}  ");
            for (int j = 0; j < 10; j++)
            {
                Spinner(1);
                timer2++;
                if (timer2 >= _activityDuration)
                {
                    break;
                }
                if (_follows.Count() == 0)
                {
                    InitAllPrompts();
                }
            }
            Console.Write("\b \n"); 
        }
        InitAllPrompts();
        Console.WriteLine("\nWell done");
        Thread.Sleep(1000);
        Console.Write($"You have completed another {_activityDuration} seconds of the {_activityName} activity.  ");
        Spinner(3);
        Console.Clear();
    }
}