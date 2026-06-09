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
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.Write($"Breathe in...{i}");
            Thread.Sleep(1000);
        }
    }
    private void BreatheOut(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.Write($"Breathe out...{i}");
            Thread.Sleep(1000);
        }
    }
    public void Full()
    {
        for (int i = (int)Math.Floor((double)_activityDuration/10); i > 0; i--)
        {
            BreatheIn(5);
            Console.Clear();
            Thread.Sleep(400);
            BreatheOut(5);
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(600);
        }
    }
}