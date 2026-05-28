using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture current = new Scripture();
        Console.Clear();
        current.GrabReference();
        Random remove = new Random();
        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            current.Display();
            Console.WriteLine("Press enter to continue, 'reset' to start over your memorizing, or 'quit' to finish:");
            string inNow = Console.ReadLine();
            switch (inNow)
            {
                case "reset":
                    current.ShowAll();
                break;
                case "quit":
                    quit = true;
                break;
                default:
                    if (!current.Remove(remove.Next(2, 4)))
                        {
                            Console.Clear();
                            current.Display();
                            Console.WriteLine("Well done! You've hidden all the words.\nPress any key to finish...");
                            Console.ReadKey();
                            quit = true;
                        }
                break;
            }
        }
        Console.Clear();
        Console.Write("Thanks for using my scripture memorizer! Please play again.");
    }
}