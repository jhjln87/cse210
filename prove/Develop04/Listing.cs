public class Listing : Activity
{
    public Listing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
        InitResponses();
    }
    public Listing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
        InitResponses();
    }
    List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    public void AddPrompt(string add)
    {
        _prompts.Add(add);
    }
    public void PopPrompt(int index = -1)
    {
        if (index < 0 || index > _prompts.Count())
        {
            index = _prompts.Count();
        }
        _prompts.RemoveAt(index);
    }
    private string GetPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }
    List<string> _responses = new List<string>();
    private void InitResponses()
    {
        _responses.Clear();
    }
    public void Full()
    {
        Console.Clear();
        RequestTime();
        Console.WriteLine("Get ready...");
        Spinner(3, 8);
        Console.Clear();
        Console.Write($"List as many responses as you can to the following prompt: \n --- {GetPrompt()} --- \nYou may begin in: ");
        Console.Write("10");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        for (int i = 9; i > 0; i--)
        {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);
        Console.WriteLine("\b ");
        while (endTime > currentTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        }
        Console.WriteLine($"\n\nWell done! You have listed {_responses.Count()} items");
        Spinner(3, 8);
        Console.WriteLine("\b ");
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Acitivy");
    }
}