using System;

class Program
{
    int _score = 0;
    List<Goal> _goals = new List<Goal>();
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        while(true)
        {
            switch (myProgram.ActionQuery())
            {
                case 1:
                    break;
                case 2:
                    myProgram.DisplayGoals();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }
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
        Console.WriteLine($"You have {_score} points\n\nMenu options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record event\n6. Quit\nSelect a choice from the menu: ");
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
        switch (selected)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}