using System.Drawing;

public class Checklist : Goal
{
    private int _target;
    private int _timesCompleted;
    private int _endPoints;
    public Checklist(string goal, int singlePointWorth, int endPointsWorth, int timesCompleted, int maxAttempts) :base(goal, singlePointWorth)
    {
        _timesCompleted = timesCompleted;
        _endPoints = endPointsWorth;
        _target = maxAttempts;
        if (_timesCompleted >= _target) {SetComplete();}
    }
    public Checklist(string goal, string description, int singlePointWorth, int endPointsWorth, int timesCompleted, int maxAttempts) :base(goal, description, singlePointWorth)
    {
        _timesCompleted = timesCompleted;
        _endPoints = endPointsWorth;
        _target = maxAttempts;
        if (_timesCompleted >= _target) {SetComplete();}
    }
    public void SetTarget(int totalTries)
    {
        _target = totalTries;
    }
    public override int RecordEvent()
    {
        if (_timesCompleted==(_target-1))
        {
            _timesCompleted++;
            SetComplete();
            return _endPoints + GetPoints();
        }
        _timesCompleted++;
        return GetPoints();
    }
    public override string GetGoalDetails(bool save, bool record)
    {
        if (save)
        {
            return base.GetGoalDetails(save) + $"{_endPoints}|{_target}|{_timesCompleted}";
        }
        return base.GetGoalDetails(save) + $" — Currently completed {_timesCompleted}/{_target}";
    }
}