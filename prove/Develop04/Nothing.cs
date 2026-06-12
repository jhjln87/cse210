public class Nothing : Activity
{
    public Nothing() : base("Meditation", "", 0)
    {
        _activityDescription = "This activity will encourage you to pause and observe the environment around you by doing nothing for an amount of time. This activity is best done after the Breathing activity.";
    }
    public Nothing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
    }
    public Nothing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
    }
    Random rand = new Random();
    public void Full()
    {
        Begin();
        for (int j = 0; j < (_activityDuration / 6); j++)
        {
            Console.Clear();
            for (int i = rand.Next(6); i > 0; i--)
            {
                Console.Write("\n");
            }
            for (int i = rand.Next(90); i > 0; i--)
            {
                Console.Write(" ");
            }
            Spinner(5, 4);
            Thread.Sleep(1);
        }
        Console.Clear();
        for (int i = rand.Next(6); i > 0; i--)
        {
            Console.Write("\n");
        }
        for (int i = rand.Next(90); i > 0; i--)
        {
            Console.Write(" ");
        }
        Spinner(_activityDuration % 6, 4);
        Console.Clear();
        Console.WriteLine("\nWell done");
        Thread.Sleep(1000);
        Console.Write($"You have completed another {_activityDuration} seconds of the {_activityName} activity  ");
        Spinner(3, 8);
        Console.Clear();
    }
}