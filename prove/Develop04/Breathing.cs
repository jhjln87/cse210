public class Breathing : Activity
{
    public Breathing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
    }
    public Breathing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
    }
    private int _inLength = 5;
    private int _outLength = 5;
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
        Console.WriteLine("Get ready...");
        Spinner(3);
        int timer = _activityDuration;
        while (timer > 0)
            {
                int currentIn = Math.Min(_inLength, timer);
                BreatheIn(currentIn);
                timer -= currentIn;
                if (timer > 0)
                {
                    Console.Clear();
                    Thread.Sleep(400); 
                }

                if (timer > 0)
                {
                    int currentOut = Math.Min(_outLength, timer);
                    BreatheOut(currentOut);
                    timer -= currentOut;
                    if (timer > 0)
                    {
                        Console.Clear();
                        Thread.Sleep(600);
                    }
                }
            }
        Console.WriteLine("\nWell done");
        Thread.Sleep(1000);
        Console.Write($"You have completed another {_activityDuration} seconds of the {_activityName} activity");
        Thread.Sleep(3000);
        Console.Clear();
    }
}