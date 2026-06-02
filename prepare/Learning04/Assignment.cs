public class Assignment
{
    private string _studentName;
    private string _topic;
    public void SetName(string studentsName)
    {
        _studentName = studentsName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public Assignment()
    {
        _studentName = "J Doe";
        _topic = "Intro to";
    }
    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }
    public string GetName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}