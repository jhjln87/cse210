using System;
using System.Drawing;
using System.IO; 

class Program
{
    int _score = 0;
    List<Goal> _goals = new List<Goal>();
    bool _play = true;
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        while(myProgram._play)
        {
            switch (myProgram.ActionQuery())
            {
                case 1:
                    myProgram.NewGoal();
                    myProgram.AwaitInput();
                    break;
                case 2:
                    myProgram.DisplayGoals();
                    myProgram.AwaitInput();
                    break;
                case 3:
                    myProgram.SaveFile();
                    myProgram.AwaitInput();
                    break;
                case 4:
                
                    myProgram.AwaitInput();
                    break;
                case 5:
                    myProgram.LogEvent();
                    myProgram.AwaitInput();
                    break;
                case 6:
                    myProgram._play = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for using my goal program");
                    break;
            }
        }
    }
    void AwaitInput()
    {
        Console.Write("\nPress any key to continue");
        Console.ReadKey();
    }
    int ValidNum(int min, int max)
    {
        string input = new string((Console.ReadLine() ?? string.Empty).Where(char.IsDigit).ToArray());
        if (int.TryParse(input, out int parsed) && parsed >= min && parsed <= max) {return parsed;} 
        else
        {
            Console.WriteLine($"\nInvalid selection. Please choose a number between {min} and {max}.\nPress any key to continue");
            Console.ReadKey();
            return -1;
        }
    }

    int ActionQuery()
    {
        int selected = -1;
        while (selected == -1)
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points\n\nMenu options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record event\n 6. Quit\nSelect a choice from the menu: ");
            selected = ValidNum(1, 6);
        }

        return selected;
    }
    void DisplayGoals()
    {
        Console.Clear();
        foreach(Goal i in _goals)
        {
            Console.WriteLine(i.GetGoalDetails());
        }
    }
    void NewGoal()
    {
        int selected = -1;
        while (selected == -1)
        {
            Console.Clear();
            Console.WriteLine($"The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? (select a number from the menu)");
            selected = ValidNum(1, 3);
        }
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Please give a short description of it, leave blank if no description is needed: ");
        string desc = Console.ReadLine();
        int point = -1;
        switch (selected)
        {
            case 1:
                while (point == -1)
                {
                    Console.Write("What is the amount of points rewarded after this goal is complete? ");
                    point = ValidNum(1, 2147483647);
                }
                _goals.Add(new Simple(name, desc, point));
                break;
            case 2:
                while (point == -1)
                {
                    Console.Write("What amount of points should be rewarded after every completion? ");
                    point = ValidNum(1, 2147483647);
                }
                _goals.Add(new Eternal(name, desc, point));
                break;
            case 3:
                while (point == -1)
                {
                    Console.Write("What amount of points should be awarded after a single completion? ");
                    point = ValidNum(1, 2147483647);
                }
                int max = -1;
                while (max == -1)
                {
                    Console.Write("How many times should this goal be completed? ");
                    max = ValidNum(1, 2147483647);
                }
                int bonus = -1;
                while (bonus == -1)
                {
                    Console.Write("And how many points are awarded at the bonus? ");
                    bonus = ValidNum(1, 2147483647);
                }
                _goals.Add(new Checklist(name, desc, point, bonus, 0, max));
                break;
        }
    }
    void LogEvent()
    {
        if (_goals.Count > 0)
        {
            Console.Clear();
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {_goals[i].GetGoalDetails(record: true)}");
            }
            int choice = -1;
            while (choice == -1)
            {
                Console.Write("Which goal have you accomplished? ");
                choice = ValidNum(1, _goals.Count);
            }
            int points = _goals[choice-1].RecordEvent();
            _score += points;
            Console.WriteLine($"\nCongratulations! You earned {points} points!");
            Console.Write($"'{_goals[choice-1].GetGoalDetails(record: true)}' has been updated.");
        } 
        else
        {
            Console.WriteLine("Could not find any goals to record.");
        }
    }
    void SaveFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string save = Console.ReadLine();
        if (!save.Contains(".txt"))
        {
            save += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(save))
        {
            foreach(Goal i in _goals)
            {
                outputFile.WriteLine(i.GetGoalDetails(save:true));
            }
        }
    }
}