public class Listing : Activity
{
    public Listing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
    }
    public Listing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
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
}