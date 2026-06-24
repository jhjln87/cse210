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
    protected int GetPoints()
    {
        return _points;
    }
    public void SetComplete()
    {
        _isComplete = true;
    }
    public virtual int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public virtual string GetGoalDetails(bool save = false, bool record = false)
    {
        if (record)
        {
            return _title;
        }
        if (save)
        {
            return $"{GetType()}|{_title}|{_description}|{_points}|";
        }
        if (IsComplete())
        {
            return $"[X] {_title} ({_description})";
        }
        return $"[ ] {_title} ({_description})";
    }
}