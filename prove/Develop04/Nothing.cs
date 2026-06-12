public class Nothing : Activity
{
    public Nothing(string activityName, string activityDescription) :base(activityName, activityDescription, 60)
    {
    }
    public Nothing(string activityName, string activityDescription, int activityDuration) :base(activityName, activityDescription, activityDuration)
    {
    }
    Random rand = new Random();
    public void Full()
    {
        Console.Clear();
        RequestTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3, 8);
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
        Console.WriteLine($"Well done, you have completed the {_activityName} Activity");
        Spinner(3, 8);
    }
}