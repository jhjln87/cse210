using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal current = new Journal();
        PromptGen prompt = new PromptGen();
        prompt.Init();
        Console.WriteLine("Welcome to John's Journaling Program");
        int selector = 0;
        bool doneMood = false;
        while (selector != 5)
        {
            DisplayOptions();
            int.TryParse(Console.ReadLine(), out selector);
            Console.Write("\n");
            if (selector > 0 && selector < 6)
            {
                switch(selector)
                {
                    case 1:
                    if (doneMood)
                        {    
                            prompt.Pick();
                            Console.WriteLine(prompt._current);
                            Entry now = new Entry(DateTime.Now.ToString("MMMM dd, yyyy"), prompt._current, Console.ReadLine());
                            current._entries.Add(now);
                        }
                    else
                        {
                            Console.WriteLine("If you were to describe your mood in one word today, what would it be? ");
                            Entry now = new Entry(DateTime.Now.ToString("MMMM dd, yyyy"), "If you were to describe your mood in one word today, what would it be? ", Console.ReadLine());
                            current._entries.Add(now);
                            doneMood = true;
                        }
                    break;

                    case 2:
                    current.Display();
                    break;
                    
                    case 3:
                    Console.Write("Please enter the file name: ");
                    current.Read(Console.ReadLine());
                    if (current._entries.Count > 0)
                        {
                            Console.Write("Loaded successfully");
                        }
                    else
                        {
                            Console.Write("Load failed, please try again: ");
                            current.Read(Console.ReadLine());
                            if (current._entries.Count > 0)
                                {
                                    Console.Write("Loaded successfully");
                                }
                            else
                                {
                                    Console.Write("Load failed, please check if the file exists!");
                                }
                        }
                    break;

                    case 4:
                    Console.Write("Please enter the file name you would like to save to: ");
                    current.Save(Console.ReadLine());
                    break;

                    case 5:
                    Console.WriteLine("\n\n\n\nThanks for using the program!");
                    return;
                }
            }
            else Console.WriteLine("**That is an invalid option. Please respond with the number 1, 2, 3, 4, or 5**");
        }
    }
    static void DisplayOptions()
    {
        Console.Write($"Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
    }
}