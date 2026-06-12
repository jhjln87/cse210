public class Breathing : Activity
{
    
    public Breathing() : base("Breathing", "", 0)
    {
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
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
            Thread.Sleep((int)(800+(long)(800*Math.Pow(1.0-(i/5), 2))));
        }
    }
    private void BreatheOut(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.Write($"Breathe out...{i}");
            Thread.Sleep((int)(800+(long)(800*Math.Pow(1.0-(i/5), 2))));
        }
    }
    public void Full()
    {
        Begin();
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