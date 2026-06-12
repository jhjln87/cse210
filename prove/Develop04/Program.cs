using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int ans = DispMenu() ?? 0;
            switch (ans)
            {
                case 1:
                    Breathing b = new Breathing();
                    b.Full();
                    break;
                case 2:
                    Nothing n = new Nothing();
                    n.Full();
                    break;
                case 3:
                    Reflection r = new Reflection();
                    r.Full();
                    break;
                case 4:
                    Listing l = new Listing();
                    l.Full();
                    break;
                case 5:
                    return;
            }
        }
    }

    static int? DispMenu()
    {
        Console.Clear();
        Console.Write("Menu options:\n  1. Start breathing activity\n  2. Start mindfulness activity\n  3. Start reflection activity\n  4. Start listing activity\n  5. Quit\nSelect a choice from the menu: ");
        if (int.TryParse(Console.ReadLine(), out int temp))
        {
           return temp;
        }
        return null;
    }
}