public class Activity
{
    protected string _activityName;
    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string name)
    {
        _activityName = name;
    }
    protected string _activityDescription;
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public void SetActivityDescription(string description)
    {
        _activityDescription = description;
    }
    protected int _activityDuration;
    public int GetActivityDuration()
    {
        return _activityDuration;
    }
    public void SetActivityDuration(int duration)
    {
        _activityDuration = duration;
    }
    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _activityDescription = description;
        _activityDuration = duration;
    }
    protected static void ClearCurrentLine()
    {
        int currentLine = Console.CursorTop;
        Console.SetCursorPosition(0, currentLine);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLine);
    }

    public void ActivityPrompt()
    {
        Console.WriteLine($"Welcome to the {_activityName} \n\nThis activity will help you{_activityDescription}\n\nHow long, in seconds, would you like for your session?");
        _activityDuration = int.Parse(Console.ReadLine());
    }
    public async IAsyncEnumerable<int> Counter(int duration) //**this one probably needs more research and edits in the main program**
    {
        for (int i = duration; i > 0; i--)
        {
            await Task.Delay(1000);
            yield return i; 
        }
    }
    // public void Counter(int duration)
    // {
    //     for (int i = duration; i > 0; i--)
    //     {
    //         Console.Write($"{_iterations[i % _iterations.Count()]}");
    //         Thread.Sleep(1000);
    //         ClearCurrentLine();
    //     }
    // }
    private List<string> _iterations = ["-", "\\", "|", "/"];
    public void Spinner(double seconds)
    {
        Console.WriteLine("Get ready...");
        for (int i = 0; i < seconds*8; i++)
        {
            Console.Write($"{_iterations[i % _iterations.Count()]}");
            Thread.Sleep(125);
            ClearCurrentLine();
        }
    }
}