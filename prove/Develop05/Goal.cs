using System.Runtime.CompilerServices;

public abstract class Goal
{
    private string _title;
    private string _description;
    private int _points;
    private bool _isComplete = false;
    protected Goal(string goal, int pointsWorth)
    {
        _title = goal;
        _description = "";
        _points = pointsWorth;
    }
    protected Goal(string goal, string description, int pointsWorth)
    {
        _title = goal;
        _description = description;
        _points = pointsWorth;
    }
    protected int RecordEvent()
    {
        return _points;
    }
    protected bool IsComplete()
    {
        return _isComplete;
    }
}