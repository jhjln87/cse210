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
}