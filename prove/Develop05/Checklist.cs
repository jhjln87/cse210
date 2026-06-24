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
        } else if (_timesCompleted < _target)
        {
            _timesCompleted++;
            return GetPoints();
        }
        return 0;
    }
    public override string GetGoalDetails(bool save = false, bool record = false)
    {
        if (save)
        {
            return base.GetGoalDetails(save) + $"{_endPoints}|{_target}|{_timesCompleted}";
        }
        return base.GetGoalDetails(save) + $" — Currently completed {_timesCompleted}/{_target}";
    }
}