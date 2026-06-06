public class Breathing : Activity
{
    public Breathing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
    }
    public Breathing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
    }
    private void BreatheIn(int seconds)
    {
        Console.Write("Breathe in..."); //add counter
    }
    private void BreatheOut(int seconds)
    {
        Console.Write("Breathe out..."); //add counter
    }

}