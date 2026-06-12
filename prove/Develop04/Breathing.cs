public class Breathing : Activity
{
    public Breathing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
    }
    public Breathing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
    }
    private int _inLength = 6;
    private int _outLength = 6;
    private void BreatheIn(int seconds)
    {
        for (int i = 0; i < seconds*10; i++)
        {
            Console.Clear();
            Console.Write($"Breathe in...{Math.Round(2.8+Math.Cos(i/14)-1)}");
            Thread.Sleep(100);
        }
    }
    private void BreatheOut(int seconds)
    {
        for (int i = 0; i < seconds*10; i++)
        {
            Console.Clear();
            Console.Write($"Breathe out...{Math.Round(2.8+Math.Cos(i/14)-1)}");
            Thread.Sleep(100);
        }
    }
    public void Full()
    {
        Console.Clear();
        RequestTime();
        Console.WriteLine("Get ready...");
        Spinner(3, 8);
        Console.Clear();
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
        Console.Write($"You have completed another {_activityDuration} seconds of the {_activityName} activity  ");
        Spinner(3, 8);
        Console.Clear();
    }
}